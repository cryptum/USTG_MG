using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using USTG_MG.Model;
using System.Linq.Dynamic;

namespace USTG_MG.AppWin32.Cadastros.Contingentes
{
    public partial class List : Form
    {
        private readonly IRepository _repository;
        private readonly int _turmaId;
        private bool _isDescending = false;
        private List<ContingenteVM> _lista;

        public List(IRepository repository)
        {
            _repository = repository;
            _turmaId = Util.Configuracao == null ? 0 : Util.Configuracao.TurmaId;
            InitializeComponent();

            _lista = _repository.Contingentes.ObterTodos(_turmaId);
            CarregarGrid();
        }

        private void MostarEdit(int id)
        {
            var frm = new Cadastros.Contingentes.Edit(_repository, id);
            frm.ShowDialog();

            if (!string.IsNullOrEmpty(txtBusca.Text))
                RealizarBusca();
            else
            {
                _lista = _repository.Contingentes.ObterTodos(_turmaId);
                CarregarGrid();
            }
        }

        private void CarregarGrid()
        {
            lblTotalItens.Text = _lista.Count.ToString();
            gridList.DataSource = _lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MostarEdit(0);
        }

        private void btnPunicao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.JusticaEDisciplina.Edit(_repository, obj.Id, Acao.Punição);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGrid();

        }

        private void gridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var obj = gridList.Rows[e.RowIndex].DataBoundItem as ContingenteVM;
            MostarEdit(obj.Id);

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            _lista = _repository.Contingentes.ObterTodos(_turmaId);
            CarregarGrid();
            if (txtBusca.Text.Length > 1)
            {
                RealizarBusca();
            }
        }

        private void RealizarBusca()
        {
            if (txtBusca.Text.All(p => char.IsDigit(p)))
                BuscaPorRA();
            else
                BuscaPorNome();
        }

        private void BuscaPorNome()
        {
            var lista = _repository.Contingentes.ObterPorNome(txtBusca.Text, _turmaId);
            lblTotalItens.Text = lista.Count.ToString();
            gridList.DataSource = lista;
        }

        private void BuscaPorRA()
        {
            var lista = _repository.Contingentes.ObterPorRA(txtBusca.Text, _turmaId);
            lblTotalItens.Text = lista.Count.ToString();
            gridList.DataSource = lista;
        }

        private void btnAtraso_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.FaltasEAtrasos.Edit(_repository, obj.Id, Situacao.Atraso);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGrid();
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.FaltasEAtrasos.Edit(_repository, obj.Id, Situacao.Falta);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGrid();
        }

        private void btnElogio_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.JusticaEDisciplina.Edit(_repository, obj.Id, Acao.Elogio);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGrid();
        }

        private void btnHoraExtra_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.HorasExtras.Edit(_repository, obj.Id);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGrid();
        }

        private void RealizaBuscaOuCarregaGrid()
        {
            if (!string.IsNullOrEmpty(txtBusca.Text))
                RealizarBusca();
            else
            {
                _lista = _repository.Contingentes.ObterTodos(_turmaId);
                CarregarGrid();
            }

        }

        private DataGridViewSelectedRowCollection Selecao()
        {
            var lista = gridList.SelectedRows;
            if (lista.Count < 1)
                MessageBox.Show("Selecione a(s) linhas que deseja aplicar a alteração!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return lista;
        }

        private void gridList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBusca.Text = string.Empty;
            string nomeColuna = gridList.Columns[e.ColumnIndex].DataPropertyName;
            string ordenacao = _isDescending ? "asc" : "desc";
            string colunaOrdenacao = $"{nomeColuna} {ordenacao}";
            _lista = _lista.OrderBy(colunaOrdenacao).ToList();
            _isDescending = !_isDescending;
            CarregarGrid();
        }
    }
}
