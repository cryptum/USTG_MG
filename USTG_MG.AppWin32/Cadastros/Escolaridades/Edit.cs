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

namespace USTG_MG.AppWin32.Cadastros.Escolaridades
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

            var obj = _repository.Escolaridades.ObterNovoOuPor(id);
            txtDescricao.Text = obj.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var escolaridade = _repository.Escolaridades.ObterNovoOuPor(_id);
                escolaridade.Descricao = txtDescricao.Text;
                escolaridade.AtualizadoPor = Util.Usuario.Nome;
                escolaridade.Validar();

                _repository.Escolaridades.Salvar(escolaridade);
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
