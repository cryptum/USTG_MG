using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Usuarios
{
    public partial class Edit : Form
    {
        private IRepository _repository;
        private readonly int _id;
        public Edit(IRepository repository, int id)
        {
            _id = id;
            _repository = repository;
            InitializeComponent();
            ExibirNaTela(id);
        }

        private void ExibirNaTela(int id)
        {
            if (id.Equals(0)) return;

            var obj = _repository.Usuarios.ObterNovoOuPor(id);
            txtUsuario.Text = obj.Nome;
            txtUsuario.Enabled = false;
            txtSenha.Text = obj.Senha;
            txtConfirmaSenha.Text = obj.Senha;
            this.groupBox1.Enabled = btnSalvar.Enabled = Util.Usuario.Id == obj.Id;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = _repository.Usuarios.ObterNovoOuPor(_id);
                obj.Nome = txtUsuario.Text.Trim();
                obj.Senha = txtSenha.Text.Trim();
                obj.ConfirmaSenha = txtConfirmaSenha.Text.Trim();
                obj.AtualizadoPor = Util.Usuario.Nome;
                obj.Validar();

                _repository.Usuarios.Salvar(obj);
                _repository.SaveChanges();

                if (_id.Equals(0))
                    Limpar();
                else
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpar()
        {
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
            txtUsuario.Focus();
        }
    }
}
