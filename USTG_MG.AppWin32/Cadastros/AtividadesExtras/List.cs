﻿using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.AtividadesExtras
{
    public partial class List : Form
    {
        private readonly IRepository _repository;
        public List(IRepository repository)
        {
            _repository = repository;
            InitializeComponent();
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            var lista = _repository.AtividadesExtras.ObterTodos();
            lblTotalItens.Text = lista.Count.ToString();
            gridList.DataSource = lista;
        }

        private void gridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nomeBotao = gridList.Columns[e.ColumnIndex].Name;

            switch (nomeBotao)
            {
                case "Edit":
                    ExecutaEdit(e.RowIndex);
                    break;
                case "Del":
                    ExecutaDel(e.RowIndex);
                    break;
            }

        }

        private void ExecutaDel(int index)
        {
            try
            {
                var obj = gridList.Rows[index].DataBoundItem as AtividadeExtra;

                if (MessageBox.Show($"Deseja realmente excluir {obj.Descricao}?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var atividadeExtra = _repository.AtividadesExtras.ObterNovoOuPor(obj.Id);
                    _repository.AtividadesExtras.Excluir(atividadeExtra);
                    _repository.SaveChanges();
                    CarregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ExecutaEdit(int index)
        {
            var obj = gridList.Rows[index].DataBoundItem as AtividadeExtra;
            MostraEdit(obj.Id);
        }

        private void MostraEdit(int id)
        {
            var frm = new AtividadesExtras.Edit(_repository, id);
            frm.ShowDialog();
            CarregaGrid();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            MostraEdit(0);
        }
    }
}