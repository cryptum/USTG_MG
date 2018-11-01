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

namespace USTG_MG.AppWin32.Cadastros.Servicos
{
    public partial class Grid : Form
    {
        private IRepository repository;
        private ServicoVM servico;

        public Grid(IRepository _repository)
        {          
            InitializeComponent();
            this.repository = _repository;  
            this.servico = this.repository.Servicos.obterUltimoPor(dataBuscar.Value);

            if (!(servico is null))
                gridEscala.DataSource = servico.Contigentes;

        }

        private void gridEscala_CellContentClick(object sender, DataGridViewCellEventArgs e)   { }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this.repository, this.repository.Servicos.ObterNovoOuPor(0))
            {
                MdiParent = this.MdiParent
            };
            edit.Show();
            this.Close();
        }

        private void dataBuscar_ValueChanged(object sender, EventArgs e)
        {
            gridEscala.DataSource = null;
            this.servico = this.repository.Servicos.obterUltimoPor(dataBuscar.Value);

            if (!(servico is null))
                gridEscala.DataSource = servico.Contigentes;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this.repository, this.repository.Servicos.ObterNovoOuPor(this.servico.Id))
            {
                MdiParent = this.MdiParent
            };
            edit.Show();
            this.Close();
        }
    }
}
