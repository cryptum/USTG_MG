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

namespace USTG_MG.AppWin32.Atividades.TAFs
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
            CarregaGridTAF();
        }

        private void CarregaGridTAF()
        {
            var listaTAF = _repository.Tafs.ObterTodos(_turmaId);
            lblTotalTAFs.Text = listaTAF.Count.ToString();           
            gridTAF.DataSource = listaTAF;
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

        private void RealizaBuscaOuCarregaGridTAF()
        {
            if (!string.IsNullOrEmpty(txtPesquisaTAF.Text))
                RealizarBuscaTAF();
            else
                CarregaGridTAF();
        }

        private void RealizarBuscaTAF()
        {
            if (txtPesquisaTAF.Text.All(p => char.IsDigit(p)))
                BuscaPorRaTAF();
            else
                BuscaPorNomeTAF();
        }

        private void BuscaPorRaTAF()
        {
            gridTAF.DataSource = _repository.Tafs.ObterPorRA(txtPesquisaTAF.Text, _turmaId);
        }

        private void BuscaPorNomeTAF()
        {
            gridTAF.DataSource = _repository.Tafs.ObterPorNome(txtPesquisaTAF.Text, _turmaId);
        }      

        private void btnTAF_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Selecao())
            {
                var obj = item.DataBoundItem as ContingenteVM;
                var frm = new Atividades.TAFs.Edit(_repository, obj.Id);
                frm.ShowDialog();
            }

            RealizaBuscaOuCarregaGridContingentes();
            RealizaBuscaOuCarregaGridTAF();
        }

        private void txtPesquisaTAF_TextChanged(object sender, EventArgs e)
        {
            CarregaGridTAF();
            if (txtPesquisaTAF.Text.Length > 1)
            {
                RealizarBuscaTAF();
            }
        }
    }
}
