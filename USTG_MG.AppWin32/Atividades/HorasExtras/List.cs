using System;
using System.Linq;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.HorasExtras
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
            CarregaGridHoraExtra();

        }

        private void CarregaGridHoraExtra()
        {
            var listaHorasExtras = _repository.HorasExtras.ObterTodos(_turmaId);
            lblTotalHorasExtras.Text = listaHorasExtras.Count.ToString();
            lblSomaHorasExtras.Text = listaHorasExtras.Sum(p => Convert.ToInt64(p.QtdHoras)).ToString();
            gridHoraExtra.DataSource = listaHorasExtras;
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

        private void RealizaBuscaOuCarregaGridHoraExtra()
        {
            if (!string.IsNullOrEmpty(txtPesquisaHoraExtra.Text))
                RealizarBuscaHoraExtra();
            else
                CarregaGridHoraExtra();
        }

        private void RealizarBuscaHoraExtra()
        {
            if (txtPesquisaHoraExtra.Text.All(p => char.IsDigit(p)))
                BuscaPorRAHoraExtra();
            else
                BuscaPorNomeHoraExtra();
        }

        private void BuscaPorRAHoraExtra()
        {
            var listaHorasExtras = _repository.HorasExtras.ObterPorRA(txtPesquisaHoraExtra.Text, _turmaId);
            lblTotalHorasExtras.Text = listaHorasExtras.Count.ToString();
            lblSomaHorasExtras.Text = listaHorasExtras.Sum(p => Convert.ToInt64(p.QtdHoras)).ToString();
            gridHoraExtra.DataSource = listaHorasExtras;
        }

        private void BuscaPorNomeHoraExtra()
        {
            var listaHorasExtras = _repository.HorasExtras.ObterPorNome(txtPesquisaHoraExtra.Text, _turmaId);
            lblTotalHorasExtras.Text = listaHorasExtras.Count.ToString();
            lblSomaHorasExtras.Text = listaHorasExtras.Sum(p => Convert.ToInt64(p.QtdHoras)).ToString();
            gridHoraExtra.DataSource = listaHorasExtras;
        }

        private void btnHoraExtra_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.HorasExtras.Edit(_repository, obj.Id);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGridContingentes();
            RealizaBuscaOuCarregaGridHoraExtra();
        }

        private void txtPesquisaHoraExtra_TextChanged(object sender, EventArgs e)
        {
            CarregaGridHoraExtra();
            if (txtPesquisaHoraExtra.Text.Length > 1)
            {
                RealizarBuscaHoraExtra();
            }
        }
    }
}
