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
    public partial class frmVacaciones : Form
    {
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        public frmVacaciones()
        {
            InitializeComponent();
            navegador1.LlenarCombobox(cbxPeriodo, "periodo", "pkid", "nombre", "estado");
            int id = controlador.idSiguienteDeNuevoIngreso("hotelsancarlos.vacaciones_e", "vacaciones_e");
            txtid.Text = id.ToString();
            llenarDGVDisponibles();
            llenarDGVAsignados();
            llenarDGVRegistrados();
            dgvRegistrados.CurrentCell = null;
        }

        public void llenarDGVDisponibles()
        {
            DataTable dt = controlador.llenarDGVDisponibles(txtid.Text);
            dgvDisponibles.DataSource = dt;
        }
        public void llenarDGVAsignados()
        {
            DataTable dt = controlador.llenarDGVAsignados(txtid.Text);
            dgvAsignados.DataSource = dt;
        }
        public void llenarDGVRegistrados()
        {
            DataTable dt = controlador.llenarDGVRegistrados();
            dgvRegistrados.DataSource = dt;
        }
        private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnEstatusamodulo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnEstatusimodulo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void cbxPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.EnviarDatoComboaTextbox(cbxPeriodo, txtPeriodo);
            llenarDGVDisponibles();
            llenarDGVAsignados();
        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxPeriodo, txtPeriodo);
        }

        private void dgvDisponibles_SelectionChanged(object sender, EventArgs e)
        {
            txtCeldas.Text = dgvDisponibles.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAsignarUnEmpleado_Click(object sender, EventArgs e)
        {
            Boolean existente = false;
            existente = controlador.ComprobarEncabezado("vacaciones_e", txtid.Text, txtPeriodo.Text);

            if (existente == false)
            {
                controlador.guardarVacacionesEncabezado("vacaciones_e", txtid.Text, txtPeriodo.Text, txtEstado.Text);
                controlador.AsignarVacaciones("vacaciones_d", txtid.Text, txtCeldas.Text, "15", "0", txtEstado.Text);
                llenarDGVDisponibles();
                llenarDGVAsignados();
            }
            else
            {
                controlador.AsignarVacaciones("vacaciones_d", txtid.Text, txtCeldas.Text, "15", "0", txtEstado.Text);
                llenarDGVDisponibles();
                llenarDGVAsignados();
            }
            llenarDGVRegistrados();
        }

        private void btnAsignarTodosEmp_Click(object sender, EventArgs e)
        {
            string str;
            Boolean existente = false;

            existente = controlador.ComprobarEncabezado("vacaciones_e", txtid.Text, txtPeriodo.Text);

            if (existente == false)
            {
                controlador.guardarVacacionesEncabezado("vacaciones_e", txtid.Text, txtPeriodo.Text, txtEstado.Text);
                int CantidadFilas = dgvDisponibles.RowCount - 1;

                for (int i = 0; i < CantidadFilas; i++)
                {
                    dgvDisponibles.CurrentCell = dgvDisponibles.Rows[i].Cells[0];
                    str = dgvDisponibles.Rows[i].Cells[0].Value.ToString();

                    txtCeldas.Text = str;

                    controlador.AsignarVacaciones("vacaciones_d", txtid.Text, str, "15", "0", txtEstado.Text);
                }
                llenarDGVDisponibles();
                llenarDGVAsignados();
            }
            else
            {
                controlador.limpiarRegistros("vacaciones_d", txtid.Text);
                int CantidadFilas = dgvDisponibles.RowCount;

                for (int i = 0; i < CantidadFilas; i++)
                {
                    dgvDisponibles.CurrentCell = dgvDisponibles.Rows[i].Cells[0];
                    str = dgvDisponibles.Rows[i].Cells[0].Value.ToString();

                    txtCeldas.Text = str;

                    controlador.AsignarVacaciones("vacaciones_d", txtid.Text, str, "15", "0", txtEstado.Text);
                }
                llenarDGVDisponibles();
                llenarDGVAsignados();
            }
            llenarDGVRegistrados();
        }

        private void quitarunemp_Click(object sender, EventArgs e)
        {
            controlador.eliminarRegistroVacaciones("vacaciones_d", txtid.Text, txtCeldasBorrar.Text);
            Boolean existente = false;
            existente = controlador.ComprobarDetalles("vacaciones_d", txtid.Text);

            if (existente == false)
            {
                controlador.eliminarEncabezado("vacaciones_e", txtid.Text, txtPeriodo.Text);
            }
            llenarDGVDisponibles();
            llenarDGVAsignados();
            llenarDGVRegistrados();
        }

        private void dgvAsignados_SelectionChanged(object sender, EventArgs e)
        {
            txtCeldasBorrar.Text = dgvAsignados.CurrentRow.Cells[0].Value.ToString();
        }

        private void quietatodosemp_Click(object sender, EventArgs e)
        {
            controlador.limpiarRegistros("vacaciones_d", txtid.Text);
            controlador.eliminarEncabezado("vacaciones_e", txtid.Text, txtPeriodo.Text);
            llenarDGVDisponibles();
            llenarDGVAsignados();
            llenarDGVRegistrados();
        }

		private void btnNueva_Click(object sender, EventArgs e)
		{
            txtid.Text = "";
            int id = controlador.idSiguienteDeNuevoIngreso("hotelsancarlos.vacaciones_e", "vacaciones_e");
            txtid.Text = id.ToString();
            llenarDGVDisponibles();
            llenarDGVAsignados();
            llenarDGVRegistrados();
            rbnEstatusamodulo.Checked = true;
        }

		private void dgvRegistrados_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            
		}

		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
            if (txtEstado.Text == "1")
            {
                rbnEstatusamodulo.Checked = true;
                rbnEstatusimodulo.Checked = false;
            }
            else if (txtEstado.Text == "0")
            {
                rbnEstatusamodulo.Checked = false;
                rbnEstatusimodulo.Checked = true;
            }
		}

		private void dgvRegistrados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            txtid.Text = dgvRegistrados.CurrentRow.Cells[0].Value.ToString();
            cbxPeriodo.Text = dgvRegistrados.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = dgvRegistrados.CurrentRow.Cells[2].Value.ToString();
        }
	}
}
