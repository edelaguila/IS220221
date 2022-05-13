using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
			navegador1.LlenarCombobox(cbxJornada, "jornada", "pkId", "nombre", "estado");
			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "2018";
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
		CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
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
			navegador1.SeleccionarFechaDTP(dtpFinContrato, txtFinContrato);
			navegador1.CambiarFormatoFecha(dtpFinContrato, txtFinContrato);
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
			try {
				
				navegador1.CambiarFormatoFecha(dtpFechaNacimiento, txtFechaNacimiento);
				navegador1.SeleccionarFechaDTP(dtpFechaNacimiento, txtFechaNacimiento);
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
			navegador1.SeleccionarFechaDTP(dtpFechaContratacion, txtFechaContratacion);
			navegador1.CambiarFormatoFecha(dtpFechaContratacion, txtFechaContratacion);
		}

		private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
		{
			try
			{				
				navegador1.SeleccionarFechaDTP(dtpFechaNacimiento, txtFechaNacimiento);
				navegador1.CambiarFormatoFecha(dtpFechaNacimiento, txtFechaNacimiento);
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

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtIdFoto.Text == "")
				{
					int id = controlador.idSiguienteDeNuevoIngreso("foto", "pkId");
					byte[] imagen = imagenAbyte();
					controlador.insertaNuevaFoto(id.ToString(), imagen);
				}
				else if (txtIdFoto.Text != "")
				{
					string id = txtIdFoto.Text;
					byte[] imagen = imagenAbyte();
					controlador.insertaFoto(id, imagen);
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }			
		}
		private void btnSelecionImagen_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Title = "Selecione una imagen";
				dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					pbFoto.ImageLocation = dialog.FileName;
				}
				else
				{ MessageBox.Show("Error al cargar imagen."); }
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }			
		}
		public byte[] imagenAbyte()
		{
			byte[] imagen = null; MemoryStream ms = new MemoryStream();
			try
			{
				pbFoto.Image.Save(ms, ImageFormat.Png);
				ms.Seek(0, SeekOrigin.Begin);
				imagen = ms.ToArray();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			return imagen;
		}
		public void obtienByte(string id)
		{
			byte[] imagen = null;
			pbFoto.Image = null;
			try
			{
				imagen = controlador.obtenerByte(id);
				using (MemoryStream ms = new MemoryStream())
				{
					ms.Write(imagen, 0, imagen.Length);
					Image returnImage = Image.FromStream(ms, true);
					pbFoto.Image = returnImage;
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
		private void txtIdFoto_TextChanged(object sender, EventArgs e)
		{
			if (txtIdFoto.Text != "")
			{
				string id = txtIdFoto.Text;
				obtienByte(id);
			}
		}
		private void activaBotones()
		{
			if (txtApellido.Enabled == true && txtApellido.Text != "")
			{
				btnGuardar.Enabled = true;
				btnSelecionImagen.Enabled = true;
			}
			else if (txtApellido.Enabled == true && txtApellido.Text == "" && txtNombre.Text=="")
			{
				btnGuardar.Enabled = true;
				btnSelecionImagen.Enabled = true;
				pbFoto.Image = null;
			}
			else if(txtApellido.Enabled==false)
            {
				btnGuardar.Enabled = false;
				btnSelecionImagen.Enabled = false;				
			}
        }

        private void txtNombre_EnabledChanged(object sender, EventArgs e)
        {
			activaBotones();
		}
        private void txtJornada_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxJornada, txtJornada);
		}
    }
}

