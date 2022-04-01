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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
		{
			//Controlador conAplicacion = new Controlador();
			InitializeComponent();

			
			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "empleado", "hotelSanCarlos");
			navegador1.MetodoSalirVista(this);
			navegador1.LlenarCombobox(cbxIDPuesto, "puesto", "pkIdPuesto", "nombre", "estado");
			navegador1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estado");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "0018";
			navegador1.idmodulo = "2";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegador1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegador1.LlenarTabla();
			navegador1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);

		}

		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
		}


		private void txtFinContrato_TextChanged(object sender, EventArgs e)
		{
			//navegador1.CambiarFormatoFecha(dtpFinContrato, txtFinContrato);
			navegador1.SeleccionarFechaDTP(dtpFinContrato, txtFinContrato);
		}

		private void cbxIDPuesto_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(cbxIDPuesto, txtIDPuesto);
		}

		private void cbxIDEmpresa_SelectedIndexChanged(object sender, EventArgs e)
		{
		
			navegador1.EnviarDatoComboaTextbox(cbxIDEmpresa, txtIDEmpresa);
		}

		private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
		{
			try{
				//navegador1.SeleccionarFechaDTP(dtpFechaNacimiento, txtFechaNacimiento);
				navegador1.CambiarFormatoFecha(dtpFechaNacimiento, txtFechaNacimiento);

			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void dtpFechaContratacion_ValueChanged(object sender, EventArgs e)
		{
			navegador1.CambiarFormatoFecha(dtpFechaContratacion, txtFechaContratacion);
		}

		private void dtpFinContrato_ValueChanged(object sender, EventArgs e)
		{
			navegador1.CambiarFormatoFecha(dtpFinContrato, txtFinContrato);
		}

		private void txtFechaContratacion_TextChanged(object sender, EventArgs e)
		{
			//navegador1.CambiarFormatoFecha(dtpFechaContratacion, txtFechaContratacion);
			navegador1.SeleccionarFechaDTP(dtpFechaContratacion, txtFechaContratacion);
		
		}

		private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
		{
			try
			{
				//navegador1.CambiarFormatoFecha(dtpFechaNacimiento, txtFechaNacimiento);
				navegador1.SeleccionarFechaDTP(dtpFechaNacimiento, txtFechaNacimiento);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void txtIDEmpresa_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxIDEmpresa, txtIDEmpresa);
		}

        private void txtIDPuesto_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxIDPuesto, txtIDPuesto);
		}

        private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
        {
			navegador1.SelecciondeFilaDGV(dgvVistaPrevia);
		}
    }
}

