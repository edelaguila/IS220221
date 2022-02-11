using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSeguridadHSC
{
	public partial class frmModulo : Form
	{
		public frmModulo()
		{
			InitializeComponent();
			//TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
			TextBox[] alias = navegador1.funAsignandoTexts(this);
			navegador1.funAsignarAliasVista(alias, "modulo", "hotelSanCarlos");
			navegador1.funAsignarSalidadVista(this);
			// navegador1.funLlenarComboControl(cbxCodMarca, "marcaP", "idMarca", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "Estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "1002";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegador1.pideGrid(this.dtgModulo);
			navegador1.llenaTabla();
			navegador1.pedirRef(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);
			
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.funCambioEstatusRBVista(txtEstado, rbnEstatusamodulo, "1");

		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.funCambioEstatusRBVista(txtEstado, rbnEstatusimodulo, "0");
		}
	}
}
