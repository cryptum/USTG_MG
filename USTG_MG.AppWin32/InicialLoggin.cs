using System;
using System.Windows.Forms;
using USTG_MG.DataAccess;
using USTG_MG.Model;

namespace USTG_MG.AppWin32
{
    public partial class InicialLoggin : Form
    {
        IRepository repository = new Repository();
        public InicialLoggin()
        {
            InitializeComponent();
            InicializarUsuarioLogado();
            txtNome.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string senha = txtSenha.Text;
                var usuario = repository.Usuarios.ObterPor(nome, senha);

                if (usuario == null)
                { MessageBox.Show("Credenciais Incorretas!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    var configuracao = repository.Configuracoes.ObterPor(usuario.Id);
                    var frm = new Principal(usuario, configuracao);
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void InicializarUsuarioLogado()
        {
            try
            {
                var obj = repository.Usuarios.ObterPor(1);
                if (obj == null)
                {
                    var usuarioAdmin = new Usuario();
                    usuarioAdmin.Nome = "admin";
                    usuarioAdmin.Senha = "admin";
                    usuarioAdmin.ConfirmaSenha = "admin";
                    usuarioAdmin.AtualizadoPor = "admin";
                    usuarioAdmin.Validar();

                    repository.Usuarios.Salvar(usuarioAdmin);
                    repository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InicialLoggin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
