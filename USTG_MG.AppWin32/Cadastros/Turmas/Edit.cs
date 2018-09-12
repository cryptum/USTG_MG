using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Turmas
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

            var obj = _repository.Turmas.ObterNovoOuPor(id);
            txtAno.Text = obj.ANO;
            txtNomeComandante.Text = obj.NomeComandante;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var turma = _repository.Turmas.ObterNovoOuPor(_id);
                turma.ANO = txtAno.Text;
                turma.NomeComandante = txtNomeComandante.Text;
                turma.AtualizadoPor = Util.Usuario.Nome;
                turma.Validar();

                _repository.Turmas.Salvar(turma);
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
            txtAno.Text = string.Empty;
            txtNomeComandante.Text = string.Empty;
            txtAno.Focus();
        }
    }
}
