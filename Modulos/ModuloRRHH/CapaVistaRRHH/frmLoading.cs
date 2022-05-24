using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            this.UseWaitCursor = true;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            
            pbxLoad.Location = new Point(this.Width/2-pbxLoad.Width/2, this.Height / 2 - pbxLoad.Height / 2);

        }

    }
}
