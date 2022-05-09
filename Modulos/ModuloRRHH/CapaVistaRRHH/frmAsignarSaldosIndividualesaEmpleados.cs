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

namespace CapaVistaRRHH
{
    public partial class frmAsignarSaldosIndividualesaEmpleados : Form
    {

        private Controlador cn = new Controlador();

        public frmAsignarSaldosIndividualesaEmpleados()
        {
            InitializeComponent();
        }

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados con saldos asignados
        public void llenartblSaldosEmpleadosAsignados()
        {
            DataTable dt = cn.llenartblSaldosEmpleadosAsignados();
            dgvEmpleados.DataSource = dt;
        }

        public frmAsignarSaldosIndividualesaEmpleados(string nombreConcepto)
        {
            InitializeComponent();
            lblConcepto.Text = "Nombre Concepto Gestionado: "+nombreConcepto;
            llenartblSaldosEmpleadosAsignados();

            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "saldosporempleados", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);
            navegador1.LlenarCombobox(cbxEmpleado, "empleado", "pkIdEmpleado", "nombre", "estado");
            navegador1.LlenarCombobox(cbxNombreConcepto, "concepto", "pkIdConcepto", "nombreConcepto", "estado");

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

        }

        private void frmAsignarSaldosIndividualesaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.EnviarDatoComboaTextbox(cbxEmpleado, txtIdEmpleado);
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxEmpleado, txtIdEmpleado);
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

        private void cbxNombreConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.EnviarDatoComboaTextbox(cbxNombreConcepto, txtIdConcepto);
        }

        private void txtIdConcepto_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxNombreConcepto, txtIdConcepto);
        }

        private void dvgConsulta_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dvgConsulta);
        }
    }
}
