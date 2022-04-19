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
	public partial class frmConsultaNomina : Form
	{
		CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
		CapaControladorRRHH.PideDatos datos = new CapaControladorRRHH.PideDatos();
		
		public frmConsultaNomina()
		{   			
			InitializeComponent();
			DataTable datosEncabezado = new DataTable();
			datosEncabezado=controlador.consultarPeriodo(datos.PeriodoInicio,datos.PeriodoFin);
			llenarEncabezado(datosEncabezado);
		}
		DataTable datosDetalle = new DataTable();
		void llenarEncabezado(DataTable tabla)
        {
			txtIdNomina.Text = tabla.Rows[0][0].ToString();
			txtInicio.Text = tabla.Rows[0][1].ToString();
			txtFin.Text = tabla.Rows[0][2].ToString();
			txtsumaper.Text = tabla.Rows[0][3].ToString();
			txtsumaded.Text = tabla.Rows[0][4].ToString();
			txtTotal.Text = tabla.Rows[0][5].ToString();
			txtEstado.Text = tabla.Rows[0][6].ToString();
			llenarDetalle(tabla.Rows[0][0].ToString());
		}
		void llenarDetalle(string id)
        {
			datosDetalle = controlador.consultarDetalles(id);
			dgvNomina.DataSource = datosDetalle;
        }

        private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
        {
			txtEstado.Text = "1";
        }

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
        {
			txtEstado.Text = "0";
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
            else
            {
				rbnEstatusamodulo.Checked = false;
				rbnEstatusimodulo.Checked = false;
			}
        }
    }


}
