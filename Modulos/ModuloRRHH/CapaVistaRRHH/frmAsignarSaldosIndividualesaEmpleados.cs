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

namespace CapaVistaRRHH
{
    public partial class frmAsignarSaldosIndividualesaEmpleados : Form
    {

        private Controlador cn = new Controlador();

        public frmAsignarSaldosIndividualesaEmpleados()
        {
            InitializeComponent();
        }

        public frmAsignarSaldosIndividualesaEmpleados(string nombreConcepto,string idConcepto)
        {
            InitializeComponent();
            lblConcepto.Text = nombreConcepto;
            lblIdConcepto.Text = idConcepto;

            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "saldosporempleados", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);

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

            navegador1.ObtenerNombreDGV(this.dvgConsulta);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);
            llenarcbxEmpleados();
        }

        private void frmAsignarSaldosIndividualesaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEmpleado();
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
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

        //Angel Chacón 9959-18-5201 
        //Muestra todos los empleados que no tengan asignado un monto o saldo
        public void llenarcbxEmpleados()
        {
            try
            {
                cbxEmpleado.Items.Clear();
                OdbcDataReader datareader = cn.llenarcbxEmpleados(lblIdConcepto.Text);
                while (datareader.Read())
                {
                    cbxEmpleado.Items.Add(datareader[0].ToString());
                }
                cbxEmpleado.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        //Angel Chacón 9959-18-5201 
        //funcion para mostrar id en el combobox de los empleados existentes
        public void IdEmpleado()
        {
            try
            {
                cbxIdEmpleado.Items.Clear();
                OdbcDataReader datareader = cn.IdEmpleado(cbxEmpleado.Text);
                while (datareader.Read())
                {
                    cbxIdEmpleado.Items.Add(datareader[0].ToString());
                }
                cbxIdEmpleado.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void txtIdConcepto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dvgConsulta_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dvgConsulta);
        }


        private void cbxEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxIdEmpleado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbxIdEmpleado.SelectedIndex > -1) {
                txtIdEmpleado.Text = cbxIdEmpleado.Text;
                txtIdConcepto.Text = lblIdConcepto.Text;
            }
        }
    }
}
