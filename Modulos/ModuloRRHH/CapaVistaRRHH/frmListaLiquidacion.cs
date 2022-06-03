using CapaControladorRRHH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmListaLiquidacion : Form
    {
        public frmListaLiquidacion()
        {
            InitializeComponent();
            llenarDTV();
        }
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        private PideDatos global = new PideDatos();
        void llenarDTV()
        {
            DataTable tabla = new DataTable();
            tabla = controlador.llenalistaliquidacion();
            dgvPeriodos.DataSource = tabla;
        }

        private void dgvPeriodos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string liquidacion = dgvPeriodos.CurrentRow.Cells[0].Value.ToString();
            global.IdLiquidasion= liquidacion;
            try
            {
                frmConsultaLiquidacion frm = new frmConsultaLiquidacion();
                frm.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
    }
}
