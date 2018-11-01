using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USTG_MG.AppWin32.ML
{
    public partial class WaitForm : Form
    {
        public Action Worker { get; set; }

        public WaitForm(string texto, Action worker)
        {
            InitializeComponent();

            if (worker == null)
                throw new ArgumentNullException();

            Worker = worker;

            waitText.Text = texto;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

    }
}
