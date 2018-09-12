using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Profissoes
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

            var obj = _repository.Profissoes.ObterNovoOuPor(id);
            txtDescricao.Text = obj.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var profissao = _repository.Profissoes.ObterNovoOuPor(_id);
                profissao.Descricao = txtDescricao.Text;
                profissao.AtualizadoPor = Util.Usuario.Nome;
                profissao.Validar();

                _repository.Profissoes.Salvar(profissao);
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
            txtDescricao.Text = string.Empty;
            txtDescricao.Focus();
        }
    }
}
