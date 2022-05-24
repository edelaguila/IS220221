using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorRRHH;

namespace CapaVistaRRHH
{
    public partial class frmGeneracionNomina : Form
    { private PideDatos global = new PideDatos();
        public frmGeneracionNomina()
        {
            InitializeComponent();
            llenarFecha();

            navegador1.idAplicacion = "2204";
            navegador1.idmodulo = "2";
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
        }
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        // string[][] vectorNomina;
        frmLoading Loading;
        private void btnGeneraNomina_Click(object sender, EventArgs e)
        {          
            string fechaInicio = txtInicio.Text.ToString();
            string fechaFin = txtFin.Text.ToString();
            string[,] vectorNomina = new string[1000, 100];
            global.FechaInicio = fechaInicio;
            global.FechaFin = fechaFin;
            generarNomina(fechaInicio, fechaFin);

            if (dtpInicio.Value > dtpFin.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final. Seleccione una fecha valida.");
                
            }
            else
            {
                try
                {
                     
                    show();
                    frmNomina frm = new frmNomina();
                    frm.Show();
                    hide();
                   
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex);}
            }
        }

        private void generarNomina(string fechaInicio, string fechaFin)
        {
            controlador.generarNomina(fechaInicio, fechaFin);
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            navegador1.CambiarFormatoFecha(dtpInicio, txtInicio);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            navegador1.CambiarFormatoFecha(dtpFin, txtFin);
        }
        private void llenarFecha()
        {
            navegador1.CambiarFormatoFecha(dtpInicio, txtInicio);
            navegador1.CambiarFormatoFecha(dtpFin, txtFin);
        }
              
        public void show()
        {
            
            Loading = new frmLoading();
            Loading.Show();
            
        }
        public void hide()
        {
            Loading.Close();
           
        }
		private void frmGeneracionNomina_HelpButtonClicked(object sender, CancelEventArgs e)
		{
            navegador1.Obtenerayuda(navegador1.idAplicacion, navegador1.campoAyuda, navegador1.tablaAyuda);
        }
	}
}
