using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorRRHH;
using System.Text.RegularExpressions;
using static datosUsuario;

namespace CapaVistaRRHH
{
    public partial class Conceptos : Form
    {
		private Controlador cn = new Controlador();
		public Conceptos()
        {
            InitializeComponent();
			rbnExcepto.Visible = false;
			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "concepto", "hotelSanCarlos");
			navegador1.MetodoSalirVista(this);
			navegador1.LlenarCombobox(cbxFormulaConcepto, "formula", "pkIdFormula", "valorFormula", "estado");
			navegador1.LlenarCombobox(cbxCuentaContable, "cuentasContables", "pkId", "nombre", "estado");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "0007";
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



		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
        {
			navegador1.SelecciondeFilaDGV(dgvVistaPrevia);
		}

        private void rbnPercepcion_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtEfecto, rbnPercepcion, "+");
		}

        private void rbnDeduccion_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtEfecto, rbnDeduccion, "-");
		}

        private void txtEfecto_TextChanged(object sender, EventArgs e)
        {
			navegador1.ActivaRadiobtn(rbnPercepcion, rbnDeduccion, txtEfecto);
		}

        private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
		}

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
		}

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
			navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

        private void txtExcepcion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEfecto_TextChanged_1(object sender, EventArgs e)
        {
			navegador1.ActivaRadiobtn(rbnDeduccion, rbnPercepcion, txtEfecto);

			if (txtEfecto.Text == "-")
			{
				rbnDeduccion.Checked = true;
			}


			if (txtEfecto.Text == "+")
			{
				rbnPercepcion.Checked = true;
			}

		}

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				//Conceptos frmConceptos = Owner as Conceptos; frmConceptos.txtIdFormulaConcepto.Text = this.txtFormula.Text;
				frmFormula frmFormula = new frmFormula();
				AddOwnedForm(frmFormula);
				frmFormula.textBox2.Text = this.txtIdConcepto.Text;
				frmFormula.Show();
				//frmFormula frm = new frmFormula();
				//frm.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void rbnTodos_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtAplicacion, rbnTodos, "1");
			
			if (rbnTodos.Checked == true)
			{
				rbnAlgunos.Checked = false;
				rbnExcepto.Visible = true;
				rbnExcepto.Checked = false;
			}
		}

        private void rbnUnicamente_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtAplicacion, rbnAlgunos, "2");

			if (rbnAlgunos.Checked == true)
			{
				rbnTodos.Checked = false;
				rbnExcepto.Checked = false;
				rbnExcepto.Visible = false;
			}
		}

        private void rbnExcepto_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtAplicacion, rbnExcepto, "3");

			if (rbnExcepto.Checked == true)
			{
				rbnAlgunos.Checked = false;
			}
		}

        private void txtAplicacion_TextChanged(object sender, EventArgs e)
        {
			if (txtAplicacion.Text == "1")
			{
				rbnTodos.Checked = true;
			}

			if (txtAplicacion.Text == "2")
			{
				rbnAlgunos.Checked = true;
			}

			if (txtAplicacion.Text == "3")
			{
				rbnTodos.Checked = true;
				rbnExcepto.Checked = true;
			}
		}

        private void rbnValorU_CheckedChanged(object sender, EventArgs e)
        {
			if (rbnValorU.Checked)
			{
				button1.Visible = false;
				rbnFormula.Checked = false;
				cbxFormulaConcepto.Visible = false;
				txtFormula.Visible = true;
				txtIdFormulaConcepto.Text = "0";

				
				

			}
		}

        private void rbnPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
			
		}

        private void rbnFormula_CheckedChanged(object sender, EventArgs e)
        {
			if (rbnFormula.Checked)
			{
				rbnValorU.Checked = false;
				button1.Visible = true;
				txtFormula.Text = "0";
				txtFormula.Visible = false;
				cbxFormulaConcepto.Visible = false;				
			}
			txtFormula.Visible = false;

			if ((rbnFormula.Checked) && (button1.Visible == true))
			{
				string valor1 = txtIdConcepto.Text;
				string valor2 = labelsqlformula.Text;
				cn.GuradarSentenciaSql(valor1, valor2);
			}


		}

        private void cbxFormulaConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.EnviarDatoComboaTextbox(cbxFormulaConcepto, txtIdFormulaConcepto);	
		}

        private void cbxCuentaContable_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.EnviarDatoComboaTextbox(cbxCuentaContable, txtIdCuentaContable);
		}

        private void txtIdFormulaConcepto_TextChanged(object sender, EventArgs e)
        {
			
			navegador1.SeleccionarElementosenCombo(cbxFormulaConcepto, txtIdFormulaConcepto);

			if (txtIdFormulaConcepto.Text != "0")
			{
				cbxFormulaConcepto.Visible = false;
				txtFormula.Visible = false;
			}
			else
			{
				cbxFormulaConcepto.Visible = false;
			}

			

		}

        private void txtIdCuentaContable_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxCuentaContable, txtIdCuentaContable);
		}

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {
			if (txtFormula.Text != "0")
			{
				txtFormula.Visible = true;
			}
			else
			{
				txtFormula.Visible = false;
			}


			if (cbxFormulaConcepto.Text == "NA")
			{
				rbnValorU.Checked = true;
				rbnFormula.Checked = false;
			}
			else if (txtFormula.Text == "0")
			{
				rbnFormula.Checked = true;
				rbnValorU.Checked = false;
			}




			if ((rbnValorU.Checked) && (txtFormula.Enabled==true) && ((txtFormula.Text != "0") || (txtFormula.Text != "")))
			{
				string valor1 = txtIdConcepto.Text;
				string valorUnico = txtFormula.Text;
				string valorPuente = "(SELECT " + valorUnico + ")";
				string valor2 = "SELECT(" + valorPuente + ") FROM `empleado` WHERE pkIdEmpleado = \" + condicion + \";";
				labelsqlvalor.Text = valor2;
				cn.GuradarSentenciaSql(valor1, valor2);
			}

		}

        private void labelsqlformula_TextChanged(object sender, EventArgs e)
        {
			if ((rbnFormula.Checked) && (button1.Visible == true))
			{
				string valor1 = txtIdConcepto.Text;
				string valor2 = labelsqlformula.Text;
				cn.GuradarSentenciaSql(valor1, valor2);
			}
		}
    }
}
