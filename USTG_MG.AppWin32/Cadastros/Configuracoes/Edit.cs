using System;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Configuracoes
{
    public partial class Edit : Form
    {
        private readonly IRepository _repository;
        
        public Edit(IRepository repository)
        {
            _repository = repository;            
            InitializeComponent();
            CarregaDropTrurma();
            MostrarNaTela();
        }

        private void CarregaDropTrurma()
        {
            dropTurma.DataSource = _repository.Turmas.ObterTodos();
            dropTurma.SelectedIndex = -1;
        }

        private void MostrarNaTela()
        {
            var obj = _repository.Configuracoes.ObterPor(Util.Usuario.Id);
            if(obj != null)
            {
                dropTurma.SelectedValue = obj.TurmaId;
                chkIniciarComContingenteAberto.Checked = obj.IniciarComContingenteAberto;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var configuracao = _repository.Configuracoes.ObterPor(Util.Usuario.Id);
                if (configuracao == null)
                    configuracao = new Configuracao();                                              

                configuracao.Turma = _repository.Turmas.ObterNovoOuPor(Convert.ToInt32(dropTurma.SelectedValue));                
                configuracao.IniciarComContingenteAberto = chkIniciarComContingenteAberto.Checked;
                configuracao.UsuarioId = Util.Usuario.Id;
                configuracao.AtualizadoPor = Util.Usuario.Nome;
                configuracao.Validar();               

                _repository.Configuracoes.Salvar(configuracao);
                _repository.SaveChanges();

                
                Util.Configuracao = _repository.Configuracoes.ObterPor(Util.Usuario.Id);
                var principal = this.MdiParent as Principal;
                principal.RefreshConfiguracaoFecharJanelasAbertas();

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
