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
    public partial class frmPeriodosNomina : Form
    {
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        DataTable Periodos = new DataTable();
        private PideDatos global = new PideDatos();
        public frmPeriodosNomina()
        {
            InitializeComponent();
            llenarDGV();

            navegador1.idAplicacion = "2201";
            navegador1.idmodulo = "2";
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
        }

        private void frmPeriodosNomina_Load(object sender, EventArgs e)
        {

        }
        void llenarDGV()
        {
            Periodos = controlador.EncabezadoNominaControlador("nomina_e", "FechaInicialN, FechaFinalN");
            dgvPeriodos.DataSource = Periodos;
        }

        private void dgvPeriodos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string fechainicial = Convert.ToDateTime(dgvPeriodos.CurrentRow.Cells[0].Value.ToString()).ToString("yyyy-MM-dd");
            string fechafinal = Convert.ToDateTime(dgvPeriodos.CurrentRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd"); 
            
            MessageBox.Show("El periodo seleccionado es: " + fechainicial + " al " + fechafinal);
            global.PeriodoInicio = fechainicial;
            global.PeriodoFin = fechafinal;
            try
            {
                frmConsultaNomina frm = new frmConsultaNomina();
                frm.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void frmPeriodosNomina_HelpButtonClicked(object sender, CancelEventArgs e)
		{
            navegador1.Obtenerayuda(navegador1.idAplicacion, navegador1.campoAyuda, navegador1.tablaAyuda);
        }
	}
}
