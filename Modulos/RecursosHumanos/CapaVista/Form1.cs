using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;

namespace CapaVista
{
	public partial class MDIRecursosHumanos : Form
	{
		public MDIRecursosHumanos()
		{
			InitializeComponent();
		}

		private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void MDIRecursosHumanos_Load(object sender, EventArgs e)
		{
			frmLoginHSC form = new frmLoginHSC();
			if (form.ShowDialog() == DialogResult.OK)
			{
				txtUsuario.Text = form.usuario();
			}
			else
			{
				this.Close();
			}

		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLoginHSC form = new frmLoginHSC();
			if (form.ShowDialog() == DialogResult.OK)
			{
				txtUsuario.Text = form.usuario();
			}
			else
			{ this.Close(); }

		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			/*frmFacturacion form3 = new frmFacturacion();
			form3.MdiParent = this;
			form3.Show();*/

		}
	}
}
