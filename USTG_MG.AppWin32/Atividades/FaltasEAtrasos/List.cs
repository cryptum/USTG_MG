using System;
using System.Linq;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.FaltasEAtrasos
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
            CarregaGridFaltasOuAtrasos();

        }

        private void CarregaGridFaltasOuAtrasos()
        {
            var listaFaltasOuAtrasos = _repository.FaltasOuAtrasos.ObterTodos(_turmaId);
            lblTotalFaltasOuAtrasos.Text = listaFaltasOuAtrasos.Count.ToString();
            gridFaltasOuAtrasos.DataSource = listaFaltasOuAtrasos;
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

        private void btnAtrasos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.FaltasEAtrasos.Edit(_repository, obj.Id, Situacao.Atraso);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGridContingentes();
            RealizaBuscaOuCarregaGridFaltasOuAtrasos();        

        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.FaltasEAtrasos.Edit(_repository, obj.Id, Situacao.Falta);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGridContingentes();
            RealizaBuscaOuCarregaGridFaltasOuAtrasos();
            
        }

        private void RealizaBuscaOuCarregaGridContingentes()
        {
            if (!string.IsNullOrEmpty(txtPesquisaContingente.Text))
                RealizarBuscaContingentes();
            else
                CarregaGridContingentes();
        }

        private void RealizaBuscaOuCarregaGridFaltasOuAtrasos()
        {
            if (!string.IsNullOrEmpty(txtPesquisaFaltasOuAtrasos.Text))
                RealizarBuscaFaltasOuAtrasos();
            else
                CarregaGridFaltasOuAtrasos();
        }

        private void txtPesquisaFaltasOuAtrasos_TextChanged(object sender, EventArgs e)
        {
            CarregaGridFaltasOuAtrasos();
            if (txtPesquisaFaltasOuAtrasos.Text.Length > 1)
            {
                RealizarBuscaFaltasOuAtrasos();
            }
        }      

        private void RealizarBuscaFaltasOuAtrasos()
        {
            if (txtPesquisaFaltasOuAtrasos.Text.All(p => char.IsDigit(p)))
                BuscaPorRAFaltaOuAtraso();
            else
                BuscaPorNomeFaltaOuAtraso();
        }

        private void BuscaPorRAFaltaOuAtraso()
        {
            gridFaltasOuAtrasos.DataSource = _repository.FaltasOuAtrasos.ObterPorRA(txtPesquisaFaltasOuAtrasos.Text, _turmaId);
        }

        private void BuscaPorNomeFaltaOuAtraso()
        {
            gridFaltasOuAtrasos.DataSource = _repository.FaltasOuAtrasos.ObterPorNome(txtPesquisaFaltasOuAtrasos.Text, _turmaId);
        }


    }
}
