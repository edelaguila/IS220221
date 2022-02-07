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
using CapaVistaReporte;
using CapaVista;


namespace CapaVistaHoteleria
{
   
    public partial class frmMDIHoteleria : Form
    {
        public frmMDIHoteleria()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmMDIHoteleria_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                nombreUsuario.nombre = txtUsuario.Text;

            }
            else
            { 
                this.Close(); 
            }
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad seguridad = new frmMIDSeguridad();
            seguridad.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin repo = new ReporteadorAdmin();
            repo.Show();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas consultas = new menuconsultas();
            consultas.Show();
        }

        private void mantenimientoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa();
            form.MdiParent = this;
            form.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSucursal form = new frmSucursal();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoCliente form = new frmTipoCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoCamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoCama form = new frmTipoCama();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoHabitacion form = new frmTipoHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion form = new frmHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoServicio form = new frmTipoServicio();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalon form = new frmSalon();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesa form = new frmMesa();
            form.MdiParent = this;
            form.Show();
        }
    }
}
