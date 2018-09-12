using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Usuarios
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
            var lista = _repository.Usuarios.ObterTodos();
            var admin = lista.Find(p => p.Id.Equals(1));
            lista.Remove(admin);
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
                var obj = gridList.Rows[index].DataBoundItem as Usuario;
                var usuario = _repository.Usuarios.ObterNovoOuPor(obj.Id);
                _repository.Usuarios.Excluir(usuario);
                _repository.SaveChanges();
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ExecutaEdit(int index)
        {
            var obj = gridList.Rows[index].DataBoundItem as Usuario;
            MostraEdit(obj.Id);
        }

        private void MostraEdit(int id)
        {
            var frm = new Usuarios.Edit(_repository, id);
            frm.ShowDialog();
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MostraEdit(0);
        }
    }
}
