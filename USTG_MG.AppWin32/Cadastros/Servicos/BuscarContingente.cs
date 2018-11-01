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
    public partial class BuscarContingente : Form
    {
        private IRepository repository;
        public List<ContingenteVM> contingentes;

        public BuscarContingente(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
            int turmaId = Util.Configuracao.TurmaId;
            List<ContingenteVM> contigentesAtivos = this.repository.Contingentes.ObterTodosAtivos(turmaId);
            contigentesAtivosGrid.DataSource = contigentesAtivos;
            this.contingentes = new List<ContingenteVM>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.contingentes = null;
            this.Close();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < contigentesAtivosGrid.SelectedRows.Count; index++)
            {
                var selectedRow = contigentesAtivosGrid.SelectedRows[index];
                ContingenteVM contingente = (ContingenteVM)selectedRow.DataBoundItem;

                this.contingentes.Add(contingente);
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}