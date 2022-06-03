using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmConsultaLiquidacion : Form
    {
        public frmConsultaLiquidacion()
        {
            InitializeComponent();
            encabezado();
        }
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        private CapaControladorRRHH.PideDatos global = new CapaControladorRRHH.PideDatos();
        private void txtRegresar_Click(object sender, EventArgs e)
        {                  
                     this.Close();           
        }
        public void encabezado()
        {
            txtIdLiquidacion.Text = global.IdLiquidasion;
            txtIDEmpleado.Text = controlador.BuscaDato("liquidacion_d", "fkIdEmpleado",txtIdLiquidacion.Text, "fkLiquidacion_e");
            DataTable table = new DataTable();
            table = controlador.consultarDetallesEmpleado(txtIDEmpleado.Text.ToString());
            //txtIDEmpleado.Text = (table.Rows[0]["pkIdEmpleado"]).ToString();
            txtNombre.Text = (table.Rows[0]["nombre"]).ToString();
            txtApellido.Text = (table.Rows[0]["apellido"]).ToString();
            txtFechaNacimiento.Text = (table.Rows[0]["fechaDeNacimiento"]).ToString();
            txtSueldo.Text = (table.Rows[0]["sueldo"]).ToString();
            txtJornada.Text = controlador.BuscaDato("jornada", "nombre", (table.Rows[0]["fkIdJornada"]).ToString(), "pkId");
            txtFechaContratacion.Text = (table.Rows[0]["fechaContratacion"]).ToString();
            txtFinContrato.Text = (table.Rows[0]["finDeContrato"]).ToString();
            txtPuesto.Text = controlador.BuscaDato("puesto", "nombre", (table.Rows[0]["fkIdPuesto"]).ToString(), "pkIdPuesto");
            txtEmpresa.Text = controlador.BuscaDato("empresa", "nombre", (table.Rows[0]["fkIdEmpresa"]).ToString(), "idEmpresa");
            txtIdFoto.Text = (table.Rows[0]["fotografia"]).ToString();
            llenaDGV();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Reporte de Liquidación";

            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")) + " ID Liquidación: "
                + txtIdLiquidacion.Text.ToString() + "\n" + " Empleado: " + txtIDEmpleado.Text.ToString()
                + " " + txtNombre.Text.ToString() + " " + txtApellido.Text.ToString() + "\n" + " Fecha de nacimiento: "
                + txtFechaNacimiento.Text.ToString() + "\n" + " Sueldo " + txtSueldo.Text.ToString() + " Jornada: "
                + txtJornada.Text.ToString() + "\n" + "Fecha contratación: " + txtFechaContratacion.Text.ToString()
                + "   Fecha de Fin de Contrato: " + txtFinContrato.Text.ToString() + "\n" + " Puesto: " + txtPuesto
                + " Empresa: " + txtEmpresa.Text.ToString() + "\n" + "Último Periodo de Vacaciones: " + txtUltimoPeriodoVacaciones.Text.ToString()
                + " Pago De Liquidación: " + txtUltimoPago.Text.ToString() + "\n" + " Sueldo Promedio" + txtSalarioPromedio.Text.ToString()
                + "\n" + "Observaciones: " + txtObservaciones.Text.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Módulo Recursos Humanos";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvVista);
        }
        public void llenaDGV()
        {
            DataTable tabla = new DataTable();
            tabla = controlador.consultarDetallesliquidacion(txtIdLiquidacion.Text);
            DataTable table = new DataTable();
            //int cantidad = datos.Rows.Count;
            txtSalarioPromedio.Text= (tabla.Rows[0]["salarioPromedio"]).ToString();
            txtUltimoPeriodoVacaciones.Text= (tabla.Rows[0]["ultimasVacaciones"]).ToString();
            txtComisionesPromedio.Text= (tabla.Rows[0]["comisionesT"]).ToString();
            txtBonificacionIncentivo.Text= (tabla.Rows[0]["bonificacionIncentivo"]).ToString();
            txtHorasExtraordinarias.Text= (tabla.Rows[0]["horasExtras"]).ToString();
            txtVacacionesAnuales.Text = "15";
            txtObservaciones.Text= (tabla.Rows[0]["observaciones"]).ToString();
            table.Columns.Add("Prestación");
            table.Columns.Add("Valor");


            DataRow row = table.NewRow();

            row["Prestación"] = ("Indemnización");
            row["Valor"] = (tabla.Rows[0]["indemnizacionT"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Aguinaldo");
            row["Valor"] = (tabla.Rows[0]["aguinaldoT"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Bono 14");
            row["Valor"] = (tabla.Rows[0]["bono14T"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Bonificación Incentivo");
            row["Valor"] = (tabla.Rows[0]["bonificacionT"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Total de Vacaciones");
            row["Valor"] = (tabla.Rows[0]["vacacionesT"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Total Comisiones");
            row["Valor"] = (tabla.Rows[0]["comisionesT"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Horas Extra");
            row["Valor"] = (tabla.Rows[0]["horasExtraT"]).ToString();
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("_______________________________");
            row["Valor"] = ("__________________________________");
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Total a Percibir");
            row["Valor"] = (tabla.Rows[0]["totalPercibido"]).ToString();
            table.Rows.Add(row);
            dgvVistaPrevia.DataSource = table;
            dgvVista.DataSource = table;

        }

        private void txtUltimoPeriodoVacaciones_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtpPeriodoVacaiones, txtUltimoPeriodoVacaciones);
            navegador1.CambiarFormatoFecha(dtpPeriodoVacaiones, txtUltimoPeriodoVacaciones);
        }

        private void txtUltimoPago_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtpUltimoPago, txtUltimoPago);
            navegador1.CambiarFormatoFecha(dtpUltimoPago, txtUltimoPago);
        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtFechaNacimiento, txtFechaNacimiento);
            navegador1.CambiarFormatoFecha(dtFechaNacimiento, txtFechaNacimiento);
        }

        private void txtFechaContratacion_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtpFechaContratacion, txtFechaContratacion);
            navegador1.CambiarFormatoFecha(dtpFechaContratacion, txtFechaContratacion);
        }

        private void dtpFinContrato_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFinContrato_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtpFinContrato, txtFinContrato);
            navegador1.CambiarFormatoFecha(dtpFinContrato, txtFinContrato);
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
            else if (txtIdFoto.Text == "")
            {
                pbFoto.Image = null;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
        }
    }
}
