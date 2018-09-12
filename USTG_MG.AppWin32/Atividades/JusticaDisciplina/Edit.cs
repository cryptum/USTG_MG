using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Atividades.JusticaEDisciplina
{
    public partial class Edit : Form
    {
        private readonly IRepository _repository;
        private readonly int _id;
        public Edit(IRepository repository, int id, Acao acao)
        {
            _id = id;
            _repository = repository;
            InitializeComponent();
            CarregarDadosDoMilitar();
            CarregaDropTipo(acao);
        }

        private void CarregaDropTipo(Acao acao)
        {
            dropTipo.DataSource = Enum.GetNames(typeof(Acao));
            dropTipo.SelectedIndex = (int)acao - 1;
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
                var obj = new JusticaOuDisciplina();
                obj.Contingente = _repository.Contingentes.ObterNovoOuPor(_id);
                obj.Acao = (Acao) dropTipo.SelectedIndex + 1;
                obj.Data = txtData.Value;
                obj.Observacao = txtObservacao.Text;
                obj.AtualizadoPor = Util.Usuario.Nome;

                obj.Validar();
                obj.ComputarAcao();

                _repository.JusticasOuDisciplinas.Salvar(obj);
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
