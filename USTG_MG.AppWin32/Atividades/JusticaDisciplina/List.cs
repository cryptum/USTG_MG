using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.JusticaEDisciplina
{
    public partial class List : Form
    {
        private readonly IRepository _repository;
        private readonly int _turmaId;
        public List(IRepository repository)
        {
            _repository = repository;
            _turmaId = Util.Configuracao == null ? 0 : Util.Configuracao.TurmaId;
            InitializeComponent();
            CarregarGrids();
        }

        private void CarregarGrids()
        {
            CarregaGridContingentes();
            CarregaGridJusticaOuDisciplina();

        }

        private void CarregaGridJusticaOuDisciplina()
        {
            var listaJusticaOuDisciplina = _repository.JusticasOuDisciplinas.ObterTodos(_turmaId);
            lblTotalElogiosOuPunicoes.Text = listaJusticaOuDisciplina.Count.ToString();
            gridJusticaOuDisciplina.DataSource = listaJusticaOuDisciplina;
        }

        private void CarregaGridContingentes()
        {
            var listaContingente = _repository.Contingentes.ObterTodos(_turmaId);
            gridContingente.DataSource = listaContingente;
        }

        private void txtPesquisaContingente_TextChanged(object sender, EventArgs e)
        {
            CarregaGridContingentes();
            if (txtPesquisaContingente.Text.Length > 1)
            {
                RealizarBuscaContingentes();
            }
        }

        private void RealizarBuscaContingentes()
        {
            if (txtPesquisaContingente.Text.All(p => char.IsDigit(p)))
                BuscaPorRAContingente();
            else
                BuscaPorNomeContingente();
        }

        private void BuscaPorNomeContingente()
        {
            gridContingente.DataSource = _repository.Contingentes.ObterPorNome(txtPesquisaContingente.Text, _turmaId);
        }

        private void BuscaPorRAContingente()
        {
            gridContingente.DataSource = _repository.Contingentes.ObterPorRA(txtPesquisaContingente.Text, _turmaId);
        }

        private DataGridViewSelectedRowCollection Selecao()
        {
            var lista = gridContingente.SelectedRows;
            if (lista.Count < 1)
                MessageBox.Show("Selecione a(s) linhas que deseja aplicar a alteração!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return lista;
        }
       
        private void RealizaBuscaOuCarregaGridContingentes()
        {
            if (!string.IsNullOrEmpty(txtPesquisaContingente.Text))
                RealizarBuscaContingentes();
            else
                CarregaGridContingentes();
        }

        private void RealizaBuscaOuCarregaGridJusticaOuDisciplina()
        {
            if (!string.IsNullOrEmpty(txtPesquisaJusticaOuDisciplina.Text))
                RealizarBuscaJusticaOuDiciplina();
            else
                CarregaGridJusticaOuDisciplina();
        }
       
        private void RealizarBuscaJusticaOuDiciplina()
        {
            if (txtPesquisaJusticaOuDisciplina.Text.All(p => char.IsDigit(p)))
                BuscaPorRAJusticaOuDisciplina();
            else
                BuscaPorNomeJusticaOuDisciplina();
        }

        private void BuscaPorRAJusticaOuDisciplina()
        {
            gridJusticaOuDisciplina.DataSource = _repository.JusticasOuDisciplinas.ObterPorRA(txtPesquisaJusticaOuDisciplina.Text, _turmaId);
        }

        private void BuscaPorNomeJusticaOuDisciplina()
        {
            gridJusticaOuDisciplina.DataSource = _repository.JusticasOuDisciplinas.ObterPorNome(txtPesquisaJusticaOuDisciplina.Text, _turmaId);
        }

        private void btnElogio_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.JusticaEDisciplina.Edit(_repository, obj.Id, Acao.Elogio);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGridContingentes();
            RealizaBuscaOuCarregaGridJusticaOuDisciplina();
        }

        private void btnPunicao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.JusticaEDisciplina.Edit(_repository, obj.Id, Acao.Punição);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGridContingentes();
            RealizaBuscaOuCarregaGridJusticaOuDisciplina();
        }

        private void txtPesquisaJusticaOuDisciplina_TextChanged(object sender, EventArgs e)
        {
            CarregaGridJusticaOuDisciplina();
            if (txtPesquisaJusticaOuDisciplina.Text.Length > 1)
            {
                RealizarBuscaJusticaOuDiciplina();
            }
        }
    }
}
