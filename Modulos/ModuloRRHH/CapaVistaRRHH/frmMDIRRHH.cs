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
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
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
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
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
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoDeFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoFalta form3 = new frmTipoFalta();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpresas form3 = new frmEmpresas();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursales form3 = new frmSucursales();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Conceptos form3 = new Conceptos();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCuentasContables form3 = new frmCuentasContables();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBancos form = new frmBancos();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMoneda form = new frmMoneda();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void conceptosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                Conceptos form = new Conceptos();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

        }



        private void excepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmExcepciones form = new frmExcepciones();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void historialISRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                HistorialISR form = new HistorialISR();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

        }

        private void generaciónDeNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void generaciónDeNóminaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmGeneracionNomina form = new frmGeneracionNomina();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void consultaNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPeriodosNomina form = new frmPeriodosNomina();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void jornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmJornada form = new frmJornada();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPeriodo form = new frmPeriodo();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void asignaciónDeEmpleadosAConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAsignacionEmpleadosaConceptos form = new frmAsignacionEmpleadosaConceptos();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                frmVacaciones form = new frmVacaciones();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void consultaDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                frmGestorVacaciones form = new frmGestorVacaciones();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                frmCandidatos form = new frmCandidatos();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPoliza form = new frmPoliza();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void liquidaciónEmpeladoIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {
                frmLiquidacionEmpleado form = new frmLiquidacionEmpleado();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void consultarLiquidaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmListaLiquidacion form = new frmListaLiquidacion();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
    }
}
    

