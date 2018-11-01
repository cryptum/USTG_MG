using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USTG_MG.AppWin32.ML;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Servicos
{
    public partial class Edit : Form
    {
        private IRepository repository;
        private Servico _servico;
        private List<ContingenteVM> contigentesVM;

        public Edit(IRepository repository, Servico servico)
        {
            this.repository = repository;
            InitializeComponent();
            tipoServicoCombo.DataSource = Enum.GetValues(typeof(TipoServico));
            this._servico = servico;
            if(servico.Id != 0)
            {
                tipoServicoCombo.SelectedItem = this._servico.Tipo;
                dataServicoCampo.Value = this._servico.Data;
                this.contigentesVM = servico.Contigentes.ConvertToVM();
            }           
            dataGridContingentes.DataSource = contigentesVM;
            dataGridContingentes.AllowDrop = true;
            dataGridContingentes.AllowUserToDeleteRows = true;
        }
        
        public List<ContingenteVM> buscarListaContigente(int turmaId, int tipoServico, DateTime dataAtualServico)
        {
            List<ContingenteVM> result = new List<ContingenteVM>(); 

            Patente patenteCabo = repository.Patentes.ObterTodos().Find(p => p.Descricao.ToUpper().Equals("CABO"));
            Patente patenteSoldado = repository.Patentes.ObterTodos().Find(p => p.Descricao.ToUpper().Equals("SOLDADO"));

            if (patenteCabo is null || patenteSoldado is null)
                throw new Exception("Patente CABO ou SOLDADO não encontradas na Turma.");


            foreach (var contigente in repository.Contingentes.ObterTodosAtivos(turmaId, patenteCabo.Id))
            {
                int resultML = ObterSeContigenteApto(contigente, tipoServico, dataAtualServico);
                if (resultML == 1) //Contingente APTO para Guarda
                {
                    result.Add(contigente);
                    break;
                } 
            }

            int qtdSoldados = 0;

            foreach (var contigente in repository.Contingentes.ObterTodosAtivos(turmaId, patenteSoldado.Id))
            {
                int resultML = ObterSeContigenteApto(contigente, tipoServico, dataAtualServico);
                if (resultML == 1) //Contingente APTO para Guarda
                {
                    result.Add(contigente);
                    qtdSoldados++;
                }

                if (qtdSoldados == 3)
                    break;
            }

            return result;

        }

        public int ObterSeContigenteApto(ContingenteVM contigente, int tipoServico, DateTime dataAtualServico)
        {
            int punicao = repository.JusticasOuDisciplinas
                    .ObterContigente(contigente.Id, Acao.Punição, dataAtualServico).Count;
            int justica = repository.JusticasOuDisciplinas
                    .ObterContigente(contigente.Id, Acao.Elogio, dataAtualServico).Count;

            List<ServicoVM> listaServicos = repository.Servicos.obterUltimoPor(contigente.Id, tipoServico);
            ServicoVM ultimoServico = listaServicos.Count > 0 ? listaServicos.First() : null;
            float prioridade = 0f;
            float ultimoDiaSemanaServico = 0f;
            float diaAtualSemanaServico = (float)dataAtualServico.DayOfWeek;

            if( !(ultimoServico is null))
            { 
                int qtdDias = (int)(dataAtualServico.Date - ultimoServico.Data.Date).TotalDays;
                prioridade = (float)(1 / (1 + Math.Exp(qtdDias * (-1))));       
                ultimoDiaSemanaServico = (float)ultimoServico.Data.DayOfWeek;
            }
            else
            {
                prioridade = 1f;
                ultimoDiaSemanaServico = (float)dataAtualServico.AddDays(-1).DayOfWeek;
            }

            float punicaoVal = 0f;
            float justicaVal = 0f;

            if (punicao > 0 )
                punicaoVal = 1f;
            if (justica > 0 )
                justicaVal = 1f;

            float resultML = ServicoPredicaoControl.carregar(prioridade, punicaoVal, justicaVal,
                ultimoDiaSemanaServico, diaAtualSemanaServico);

            return (int)resultML;
        }

        private void btnGerarLista_Click(object sender, EventArgs e)
        {
            int _turmaId = Util.Configuracao == null ? 0 : Util.Configuracao.TurmaId;
            int tipoServico = (int)tipoServicoCombo.SelectedItem;
            DateTime dataAtualServico = dataServicoCampo.Value;
            this.contigentesVM = buscarListaContigente(_turmaId, tipoServico, dataAtualServico);
            dataGridContingentes.DataSource = this.contigentesVM;
            dataGridContingentes.AllowUserToDeleteRows = true;
        }

        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            List<Contingente> contigentes = new List<Contingente>();
            foreach(var contigente in this.contigentesVM)
            {
                contigentes.Add(repository.Contingentes.ObterNovoOuPor(contigente.Id));
            }
            this._servico.Contigentes = contigentes;
            this._servico.Tipo = (TipoServico)tipoServicoCombo.SelectedItem;
            this._servico.Data = dataServicoCampo.Value;
            this._servico.AtualizadoPor = Util.Usuario.Nome;
            this._servico.Validar();

            //Validando o serviço
            if (!this.validarContingentes())
            {
                MessageBox.Show("Não foi possível Salvar, verifique os dados");
                return;
            }            

            //TODO Realizar check da Flag de Permanência
            repository.Servicos.Salvar(this._servico);
            repository.SaveChanges();
            MessageBox.Show("Salvo com sucesso.");
            this.Refresh();
        }

        private void tipoServicoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridContingentes.DataSource = new List<ContingenteVM>();
        }

        private void btnInserirManualmente_Click(object sender, EventArgs e)
        {
            if (this.contigentesVM is null)
                this.contigentesVM = new List<ContingenteVM>();

            using (BuscarContingente buscarContingente = new BuscarContingente(this.repository))
            {
                if(buscarContingente.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in buscarContingente.contingentes)
                        this.contigentesVM.Add(item);
                        
                    dataGridContingentes.DataSource = null;
                    dataGridContingentes.DataSource = this.contigentesVM;
                }
            }
            
        }

        private void dataGridContingentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow item in dataGridContingentes.SelectedRows)
                {
                    var contingente = (ContingenteVM)item.DataBoundItem;
                    this.contigentesVM.Remove(contingente);
                }
                dataGridContingentes.DataSource = null;
                dataGridContingentes.DataSource = this.contigentesVM;
            }
        }

        private void dataServicoCampo_ValueChanged(object sender, EventArgs e)
        {
            dataGridContingentes.DataSource = new List<ContingenteVM>();
        }

        private bool validarContingentes()
        {
            int qtdCabos = 0;
            int qtdSoldados = 0;

            foreach(ContingenteVM contigente in this.contigentesVM)
            {
                if (contigente.Patente.ToUpper().Equals("CABO"))
                    qtdCabos++;
                else if (contigente.Patente.ToUpper().Equals("SOLDADO"))
                    qtdSoldados++;
            }

            if (qtdCabos != 1)
                return false;

            if (qtdSoldados == 1)
                this._servico.FlagPermanencia = 1;
            else if (qtdSoldados != 3)
                return false;



            return true;
        }
    }
}
