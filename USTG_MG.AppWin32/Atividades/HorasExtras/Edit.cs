using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.HorasExtras
{
    public partial class Edit : Form
    {
        private readonly IRepository _repository;
        private readonly int _id;
        public Edit(IRepository repository, int id)
        {
            _repository = repository;
            _id = id;
            InitializeComponent();
            CarregarDadosDoMilitar();
            CarregarDropAtividades();
        }

        private void CarregarDropAtividades()
        {
            dropAtividades.DataSource = _repository.AtividadesExtras.ObterTodos();
            dropAtividades.SelectedIndex = -1;
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
                var obj = new HoraExtra();
                obj.Contingente = _repository.Contingentes.ObterNovoOuPor(_id);
                obj.Atividade = _repository.AtividadesExtras.ObterNovoOuPor(Convert.ToInt32(dropAtividades.SelectedValue));
                obj.Data = txtData.Value;
                obj.Observacoes = txtObservacao.Text;
                Int32.TryParse(txtQtdHoras.Text, out int qtdHoras);
                obj.QtdHoras = qtdHoras;
                obj.AtualizadoPor = Util.Usuario.Nome;

                obj.Validar();
                obj.ComputarAcao();

                _repository.HorasExtras.Salvar(obj);
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
