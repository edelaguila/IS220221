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
using static datosUsuario;

namespace CapaVistaRRHH
{
    public partial class frmMDIRRHH : Form
    {
        CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
        public frmMDIRRHH()
        {
            InitializeComponent();
        }

        private void frmMDIRRHH_Load(object sender, EventArgs e)
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

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados form3 = new frmEmpleados();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch { }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepartamentos form3 = new frmDepartamentos();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch { }
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPuesto form3 = new frmPuesto();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch { }
        }
    }
}
