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
    public partial class frmGeneracionNomina : Form
    {
        public frmGeneracionNomina()
        {
            InitializeComponent();
        }
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
       // string[][] vectorNomina;
        private void btnGeneraNomina_Click(object sender, EventArgs e)
        {
            string fechaInicio = txtInicio.Text.ToString();
            string fechaFin = txtFin.Text.ToString();
            string [,] vectorNomina= new string [1000,100];

            generarNomina(fechaInicio,fechaFin);
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
    }
}
