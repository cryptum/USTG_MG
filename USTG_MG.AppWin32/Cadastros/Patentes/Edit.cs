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

namespace USTG_MG.AppWin32.Cadastros.Patentes
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

            var obj = _repository.Patentes.ObterNovoOuPor(id);
            txtDescricao.Text = obj.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var patente = _repository.Patentes.ObterNovoOuPor(_id);
                patente.Descricao = txtDescricao.Text;
                patente.AtualizadoPor = Util.Usuario.Nome;
                patente.Validar();

                _repository.Patentes.Salvar(patente);
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
