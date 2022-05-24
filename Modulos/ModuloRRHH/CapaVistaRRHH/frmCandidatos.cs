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
	public partial class frmCandidatos : Form
	{
		CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
		public frmCandidatos()
		{
			InitializeComponent();

			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "candidato", "hotelSanCarlos");
			navegador1.MetodoSalirVista(this);
			//navegador1.LlenarCombobox(cbxIDPuesto, "puesto", "pkIdPuesto", "nombre", "estado");
			//navegador1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estado");
			//navegador1.LlenarCombobox(cbxJornada, "jornada", "pkId", "nombre", "estado");
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
		private void activaBotones()
		{
			if (txtApellido.Enabled == true && txtApellido.Text != "")
			{
				btnGuardar.Enabled = true;
				btnSelecionImagen.Enabled = true;
				txtNombre.Focus();
				rtxtEstudios.Enabled = true;
				rtxtExperiencia.Enabled = true;
				rtxtReferencias.Enabled = true;
			}
			else if (txtApellido.Enabled == true && txtApellido.Text == "" && txtNombre.Text == "")
			{
				btnGuardar.Enabled = true;
				btnSelecionImagen.Enabled = true;
				pbFoto.Image = null;
				txtNombre.Focus();
				rtxtEstudios.Enabled = true;
				rtxtExperiencia.Enabled = true;
				rtxtReferencias.Enabled = true;
			}
			else if (txtApellido.Enabled == false)
			{
				btnGuardar.Enabled = false;
				btnSelecionImagen.Enabled = false;
				rtxtEstudios.Enabled = false;
				rtxtExperiencia.Enabled = false;
				rtxtReferencias.Enabled = false;
			}
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

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtIdFoto.Text == "")
				{
					int id = controlador.idSiguienteDeNuevoIngreso("foto", "pkId");
					byte[] imagen = imagenAbyte();
					controlador.insertaNuevaFoto(id.ToString(), imagen);
					txtIdFoto.Text = id.ToString();
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

		private void txtIdFoto_TextChanged(object sender, EventArgs e)
		{
			if (txtIdFoto.Text != "")
			{
				string id = txtIdFoto.Text;
				obtienByte(id);
			}
			else if (txtIdFoto.Text == "")
			{
				pbFoto.Image = null;
			}
		}

		private void txtNombre_EnabledChanged(object sender, EventArgs e)
		{
			activaBotones();
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

		private void rtxtEstudios_TextChanged(object sender, EventArgs e)
		{
			txtEstudios.Text = "";
			txtEstudios.Text = rtxtEstudios.Text;
		}

		private void rtxtExperiencia_TextChanged(object sender, EventArgs e)
		{
			txtExperiencia.Text = "";
			txtExperiencia.Text = rtxtExperiencia.Text;
		}

		private void rtxtReferencias_TextChanged(object sender, EventArgs e)
		{
			txtReferencias.Text = "";
			txtReferencias.Text = rtxtReferencias.Text;
		}

		private void txtExperiencia_TextChanged(object sender, EventArgs e)
		{
			if (txtNombre.Enabled == false)
			{
				rtxtExperiencia.Text = txtExperiencia.Text;
			}
		}
	}
}
