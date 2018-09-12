using System;
using System.Drawing;
using System.Windows.Forms;
using USTG_MG.DataAccess;
using USTG_MG.Model;

namespace USTG_MG.AppWin32
{
    public partial class Principal : Form
    {
        IRepository repository = new Repository();

        public Principal(Usuario usuario, Configuracao configuracao)
        {
            InitializeComponent();
            Util.Usuario = usuario;
            Util.Configuracao = configuracao;

        }

        private void Turmas_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Turmas.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void Patentes_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Patentes.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void Contingente_Click(object sender, EventArgs e)
        {
            CarregaContingente();
        }

        private void horizonta_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void veritical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void fecharTodas_Click(object sender, EventArgs e)
        {
            FecharTodas();
        }

        private void FecharTodas()
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
                item.Close();
            }
        }

        private void escolaridades_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Escolaridades.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void profissões_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Profissoes.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void religiões_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Religioes.List(repository);
            frm.MdiParent = this;           
            frm.Show();
        }

        private void atividadesExtras_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.AtividadesExtras.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void faltasEAtrasos_Click(object sender, EventArgs e)
        {
            var frm = new Atividades.FaltasEAtrasos.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void justiçaEDisciplina_Click(object sender, EventArgs e)
        {
            var frm = new Atividades.JusticaEDisciplina.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void escalaDeServiço_Click(object sender, EventArgs e)
        {
            var frm = new Atividades.EscalasDeTrabalhos.List();
            frm.MdiParent = this;
            frm.Show();
        }

        private void horasExtras_Click_1(object sender, EventArgs e)
        {
            var frm = new Atividades.HorasExtras.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tAF_Click(object sender, EventArgs e)
        {
            var frm = new Atividades.TAFs.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MudaCorDoFundaDaJanelaPrincipal();
            RefreshConfiguracaoFecharJanelasAbertas();

            if (Util.Configuracao != null)
                if (Util.Configuracao.IniciarComContingenteAberto)
                    CarregaContingente();
        }

        private void MudaCorDoFundaDaJanelaPrincipal()
        {
            foreach (Control item in this.Controls)
            {
                if (item is MdiClient)
                {
                    var c = item as MdiClient;
                    c.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        public void RefreshConfiguracaoFecharJanelasAbertas()
        {
            lblusuarioLogado.Text = Util.Usuario.Nome;
            if (Util.Configuracao == null)
            {
                lblConfiguracaoTurmaAno.Text = "Defina as configurações";
                lblConfiguracaoTurmaAno.ForeColor = Color.Red;
                lblConfiguracaoTurmaAno.Font = new Font("Arial", 8, FontStyle.Regular);
            }
            else
            {
                lblConfiguracaoTurmaAno.Text = Util.Configuracao.Turma.ANO;
                lblConfiguracaoTurmaAno.ForeColor = Color.Black;
                lblConfiguracaoTurmaAno.Font = new Font("Arial", 8, FontStyle.Bold);
            }

            FecharTodas();
        }

        private void CarregaContingente()
        {
            var frm = new Cadastros.Contingentes.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Usuarios.List(repository);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            var frm = new Cadastros.Configuracoes.Edit(repository);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
