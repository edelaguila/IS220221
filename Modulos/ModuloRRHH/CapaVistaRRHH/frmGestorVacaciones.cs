using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
	public partial class frmGestorVacaciones : Form
	{
		CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
		public frmGestorVacaciones()
		{
			InitializeComponent();
			llenarcbxPeriodo();
			dgvSeleccion.Enabled = false;
			rbnTodos.Checked = false;
			rbnAlgunos.Checked = false;
			llenarDGVSeleccion();
			dgvGestionados.Columns.Add("pkIdEmpleado", "pkIdEmpleado");
			dgvGestionados.Columns.Add("Nombre", "Nombre");
		}

		public void llenarcbxPeriodo()
		{
			try
			{
				cbxPeriodo.Items.Clear();
				OdbcDataReader datareader = controlador.llenarcbxPeriodo();
				while (datareader.Read())
				{
					cbxPeriodo.Items.Add(datareader[0].ToString());
				}
				cbxPeriodo.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
		public void IdPeriodo()
		{
			try
			{
				OdbcDataReader datareader = controlador.IdPeriodo(cbxPeriodo.Text);
				while (datareader.Read())
				{
					txtPeriodo.Text=datareader[0].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
		public void IdEncabezado()
		{
			if (cbxPeriodo.Text == "")
			{

			}
			else
			{
				try
				{
					OdbcDataReader datareader = controlador.IdEncabezado(txtPeriodo.Text);
					while (datareader.Read())
					{
						txtEncabezado.Text = datareader[0].ToString();
					}
				}
				catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			}
		}
		public void llenarDGVSeleccion()
		{
			DataTable dt = controlador.llenarDGVSeleccion(txtPeriodo.Text);
			dgvSeleccion.DataSource = dt;
		}
		private void rbnTodos_CheckedChanged(object sender, EventArgs e)
		{
			dgvSeleccion.Enabled = false;
			btnAsignarUnEmpleado.Enabled = false;
			quitarunemp.Enabled = false;
			quietatodosemp.Enabled = false;
		}

		private void rbnAlgunos_CheckedChanged(object sender, EventArgs e)
		{
			dgvSeleccion.Enabled = true;
			btnAsignarUnEmpleado.Enabled = true;
			quitarunemp.Enabled = true;
			quietatodosemp.Enabled = true;
		}

		private void cbxPeriodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			IdPeriodo();
			IdEncabezado();
			llenarDGVSeleccion();
		}

		private void btnDescontar_Click(object sender, EventArgs e)
		{
			string str;
			if (rbnTodos.Checked == true)
			{
				int CantidadFilas = dgvSeleccion.RowCount - 1;

				for (int i = 0; i < CantidadFilas; i++)
				{
					dgvSeleccion.CurrentCell = dgvSeleccion.Rows[i].Cells[0];
					str = dgvSeleccion.Rows[i].Cells[0].Value.ToString();
					txtCeldas.Text = str;

					controlador.ModificarVacaciones(txtEncabezado.Text, txtCeldas.Text, txtDias.Text);
				}
				llenarDGVSeleccion();
				dgvGestionados.Rows.Clear();
			}
			else if (rbnAlgunos.Checked == true)
			{
				int CantidadFilas = dgvGestionados.RowCount - 1;

				for (int i = 0; i < CantidadFilas; i++)
				{
					
					dgvGestionados.CurrentCell = dgvGestionados.Rows[i].Cells[0];
					str = dgvGestionados.Rows[i].Cells[0].Value.ToString();
					txtCeldas.Text = str;

					controlador.ModificarVacaciones(txtEncabezado.Text, txtCeldas.Text, txtDias.Text);
				}
				llenarDGVSeleccion();
				dgvGestionados.Rows.Clear();
			}
		}

		private void btnAsignarUnEmpleado_Click(object sender, EventArgs e)
		{
			string id = dgvSeleccion.CurrentRow.Cells[0].Value.ToString();
			string nombre = dgvSeleccion.CurrentRow.Cells[1].Value.ToString();
			dgvGestionados.Rows.Add(id,nombre);
		}

		private void quitarunemp_Click(object sender, EventArgs e)
		{
			dgvGestionados.Rows.Remove(dgvGestionados.CurrentRow);
		}

		private void quietatodosemp_Click(object sender, EventArgs e)
		{
			dgvGestionados.Rows.Clear();
		}

        private void frmGestorVacaciones_HelpButtonClicked(object sender, CancelEventArgs e)
        {
			navegador1.Obtenerayuda(navegador1.idAplicacion, navegador1.campoAyuda, navegador1.tablaAyuda);
		}

		private void dgvSeleccion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			string id = dgvSeleccion.CurrentRow.Cells[0].Value.ToString();
			string nombre = dgvSeleccion.CurrentRow.Cells[1].Value.ToString();
			dgvGestionados.Rows.Add(id, nombre);
		}
	}
}
