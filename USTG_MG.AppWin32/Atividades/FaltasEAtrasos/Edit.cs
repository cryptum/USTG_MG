using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.FaltasEAtrasos
{
    public partial class Edit : Form
    {
        private readonly IRepository _repository;
        private readonly int _id;
        public Edit(IRepository repository, int id, Situacao situacao)
        {
            _repository = repository;
            _id = id;
            InitializeComponent();
            CarregarDadosDoMilitar();
            CarregaDropTipo(situacao);
        }

        private void CarregaDropTipo(Situacao situacao)
        {
            dropTipo.DataSource = Enum.GetNames(typeof(Situacao));
            dropTipo.SelectedIndex = (int)situacao - 1;
            dropTipo.Enabled = dropTipo.SelectedIndex == -1;
        }

        private void CarregarDadosDoMilitar()
        {
            var obj = _repository.Contingentes.ObterNovoOuPor(_id);
            lblNome.Text = obj.NomeDeGuerra;
            lblPatente.Text = obj.Patente.Descricao;
            lblRA.Text = obj.RA;
            if (obj.Fotos.Count > 0)
                picBoxFoto.Image = Util.ObterFoto(obj.Fotos);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new FaltaOuAtraso();
                obj.Contingente = _repository.Contingentes.ObterNovoOuPor(_id);
                obj.Situacao = (Situacao)dropTipo.SelectedIndex + 1;
                obj.Data = txtData.Value;
                obj.Observacao = txtObservacao.Text;
                obj.AtualizadoPor = Util.Usuario.Nome;

                obj.Validar();
                obj.ComputarAcao();

                _repository.FaltasOuAtrasos.Salvar(obj);
                _repository.SaveChanges();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
