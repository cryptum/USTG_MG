using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Religioes
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

            var obj = _repository.Religioes.ObterNovoOuPor(id);
            txtDescricao.Text = obj.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var religiao = _repository.Religioes.ObterNovoOuPor(_id);
                religiao.Descricao = txtDescricao.Text;
                religiao.AtualizadoPor = Util.Usuario.Nome;
                religiao.Validar();

                _repository.Religioes.Salvar(religiao);
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
