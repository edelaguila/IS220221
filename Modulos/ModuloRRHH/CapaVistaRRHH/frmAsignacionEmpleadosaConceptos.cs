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
using CapaControladorRRHH;
using System.Diagnostics;

namespace CapaVistaRRHH
{
    public partial class frmAsignacionEmpleadosaConceptos : Form
    {

        private Controlador cn = new Controlador();
        private string tablaempleados = "empleado";
        private string tabla3 = "empleado_concepto";

        public frmAsignacionEmpleadosaConceptos()
        {
            InitializeComponent();
            llenarcbxConcepto();
        }

        //Angel Chacón 9959-18-5201 
        //funcion para mostrar los nombres en el combobox de los conceptos creados
        public void llenarcbxConcepto()
        {
            try
            {
                cbxNombreConcepto.Items.Clear();
                OdbcDataReader datareader = cn.llenarcbxConcepto();
                while (datareader.Read())
                {
                    cbxNombreConcepto.Items.Add(datareader[0].ToString());
                }
                cbxNombreConcepto.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        //9959-18-5201 Angel Chacón
        //Muestra a todos los empleados disponibles para asignarle al concepto
        public void actualizardatagriewEmpleados()
        {
            DataTable dt = cn.llenarTblDatosEmpleados(cbxIdConcepto.Text);
            dvgTodosEmpleados.DataSource = dt;
        }        

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados asignados al concepto
        public void llenarTblEmpleadosAsignadosConcepto()
        {
            string IdConcepto = cbxIdConcepto.Text;
            DataTable dt = cn.llenarTblEmpleadosAsignadosConcepto(tablaempleados, IdConcepto);
            dvgEmpleadosAsignados.DataSource = dt;
        }

        //9959-18-5201 Angel Chacón
        public void DatosConcepto()
        {
            //Obtiene todos los datos del concepto al que se le van a asignar empleados
            DataTable dt = cn.DatosConcepto(cbxIdConcepto.Text);
            dvgDatosConcepto.DataSource = dt;
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (cbxNombreConcepto.Text != "")
            {
                try
                {
                    string IdConcepto = cbxIdConcepto.Text;
                    actualizardatagriewEmpleados();
                    llenarTblEmpleadosAsignadosConcepto();
                    DatosConcepto();

                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el concepto a consultar");
            }

        }

        private void btnAsignarUnEmpleado_Click(object sender, EventArgs e)
        {
            txtCeldas.Text = dvgTodosEmpleados.CurrentRow.Cells[0].Value.ToString();

            string valor1 = cbxIdConcepto.Text;
            string valor2 = txtCeldas.Text;
            cn.AsignarEmpleados(tabla3, valor1, valor2);
            llenarTblEmpleadosAsignadosConcepto();
            actualizardatagriewEmpleados();
        }

        private void dvgTodosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCeldas.Text = dvgTodosEmpleados.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAsignarTodosEmp_Click(object sender, EventArgs e)
        {
            string valor1 = cbxIdConcepto.Text;
            string valor2 = txtCeldas.Text;
            string str;

            cn.AsignarATodosLosEmpleados(tabla3, valor1);
            llenarTblEmpleadosAsignadosConcepto();

            int CantidadFilas = dvgTodosEmpleados.RowCount;

            for (int i = 0; i < CantidadFilas; i++)
            {
                dvgTodosEmpleados.CurrentCell = dvgTodosEmpleados.Rows[i].Cells[0];
                str = dvgTodosEmpleados.Rows[i].Cells[0].Value.ToString();

                txtCeldas.Text = str;

                cn.AsignarEmpleados(tabla3, valor1, str);
                llenarTblEmpleadosAsignadosConcepto();

            }
            actualizardatagriewEmpleados();
        }

        private void quitarunemp_Click(object sender, EventArgs e)
        {
            txtCeldas.Text = dvgEmpleadosAsignados.CurrentRow.Cells[0].Value.ToString();

            string valor1 = cbxIdConcepto.Text;
            string valor2 = txtCeldas.Text;
            cn.EliminarUnEmpleadoAsignado(tabla3, valor1, valor2);
            llenarTblEmpleadosAsignadosConcepto();
            actualizardatagriewEmpleados();
        }

        private void quietatodosemp_Click(object sender, EventArgs e)
        {
            string valor = cbxIdConcepto.Text;
            cn.EliminarTodasLasAsignacionesEmpleados(tabla3, valor);
            llenarTblEmpleadosAsignadosConcepto();
            actualizardatagriewEmpleados();
        }

        //Angel Chacón 9959-18-5201 
        //funcion para mostrar id en el combobox de los conceptos existentes
        public void llenarcbxIdConcepto()
        {
            try
            {
                cbxIdConcepto.Items.Clear();
                OdbcDataReader datareader = cn.IdConcepto(cbxNombreConcepto.Text);
                while (datareader.Read())
                {
                    cbxIdConcepto.Items.Add(datareader[0].ToString());
                }
                cbxIdConcepto.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cbxIdConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxNombreConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcbxIdConcepto();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            cbxIdConcepto.Text = "";
            cbxNombreConcepto.Text = "";
            txtCeldas.Text = "";
            dvgDatosConcepto.DataSource = null;
            dvgTodosEmpleados.DataSource = null;
            dvgEmpleadosAsignados.DataSource = null;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\\Users\\achac\\OneDrive\\Escritorio\\ayudas\\Ayuda Asignacion Empleado Concepto\\Ayuda para la asignacionEmpleadosAConceptos.pdf");
        }

        private void btnAsignarSaldo_Click(object sender, EventArgs e)
        {
            if (cbxIdConcepto.Text != "")
            {
                string nombreConcepto = cbxNombreConcepto.Text;
                string idConcepto = cbxIdConcepto.Text;
                frmAsignarSaldosIndividualesaEmpleados formE = new frmAsignarSaldosIndividualesaEmpleados(nombreConcepto, idConcepto);
                formE.Show();
            }
            else
            {

                MessageBox.Show("Debe elegir un concepto a gestionar!");

            }

        }
    }
}
