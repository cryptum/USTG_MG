using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.TAFs
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
                var obj = new TAF();
                obj.Contingente = _repository.Contingentes.ObterNovoOuPor(_id);
                obj.Data = txtData.Value;
                obj.Abdominais = txtAbdominais.Text;
                obj.Flexoes = txtFlexoes.Text;
                obj.Corrida12Min = txtCorrida.Text;
                obj.Barras = txtBarras.Text;
                obj.Nota = txtNota.Text;
                obj.Observacao = txtObservacao.Text;
                obj.AtualizadoPor = Util.Usuario.Nome;
                obj.Validar();              

                _repository.Tafs.Salvar(obj);
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
