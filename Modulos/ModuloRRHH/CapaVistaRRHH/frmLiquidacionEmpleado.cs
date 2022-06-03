using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmLiquidacionEmpleado : Form
    {
        public frmLiquidacionEmpleado()
        {
            InitializeComponent();
            navegador1.LlenarCombobox(cbxEmpleado, "empleado", "pkIdEmpleado", "nombre", "estado");
            encabezadoAutomático();
        }
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.EnviarDatoComboaTextbox(cbxEmpleado, txtEmpleado);
        }
        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxEmpleado, txtEmpleado);
            llenaDatosEmpleado();
        }
        private void llenaDatosEmpleado()
        {
            DataTable table = new DataTable();
            table = controlador.consultarDetallesEmpleado(txtEmpleado.Text.ToString());
            txtIDEmpleado.Text = (table.Rows[0]["pkIdEmpleado"]).ToString();
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
        private void txtSalarioPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaDigitos(e, txtSalarioPromedio);
        }
        private void ValidaDigitos(KeyPressEventArgs e, TextBox dato)
        {
            CultureInfo ci = System.Globalization.CultureInfo.CurrentUICulture;
            char cDecimalSeparator = ci.NumberFormat.CurrencyDecimalSeparator[0]; // "." or "," depending of systems config.
            bool bDecimalSeparatorFound = (0 <= dato.Text.IndexOf(cDecimalSeparator));

            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == cDecimalSeparator))
                || (e.KeyChar == cDecimalSeparator && bDecimalSeparatorFound)) // only one decimal separator
            {
                // unauthorized KeyChar or double decimal separator received : skipping this one
                e.Handled = true;
            }
            // only "ci.NumberFormat.CurrencyDecimalDigits" numbers allowed after decimal separator
            if (char.IsDigit(e.KeyChar) && bDecimalSeparatorFound)
            {
                int nDecimalDigits = dato.Text.Length
                    - dato.Text.LastIndexOf(ci.NumberFormat.CurrencyDecimalSeparator) - 1;
                if (nDecimalDigits >= ci.NumberFormat.CurrencyDecimalDigits)
                    e.Handled = true; // doesn't comply to system configuration : skipping this one
            }
            // Everything seems okay, let base class handle this one!
            base.OnKeyPress(e);
        }             
        private void txtComisionesPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaDigitos(e, txtComisionesPromedio);
        }
        private void txtHorasExtraordinarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaDigitos(e, txtHorasExtraordinarias);
        }
        private void txtVacacionesAnuales_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaDigitos(e, txtVacacionesAnuales);
        }           
        private void txtBonificacionIncentivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaDigitos(e, txtBonificacionIncentivo);
        }
        private void txtFechaContratacion_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtpFechaContratacion, txtFechaContratacion);
            navegador1.CambiarFormatoFecha(dtpFechaContratacion, txtFechaContratacion);
        }
        private void txtFinContrato_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtpFinContrato, txtFinContrato);
            navegador1.CambiarFormatoFecha(dtpFinContrato, txtFinContrato);
        }
        private void dtpPeriodoVacaiones_ValueChanged(object sender, EventArgs e)
        {
            navegador1.CambiarFormatoFecha(dtpPeriodoVacaiones, txtUltimoPeriodoVacaciones);
        }
        private void dtpUltimoPago_ValueChanged(object sender, EventArgs e)
        {
            navegador1.CambiarFormatoFecha(dtpUltimoPago, txtUltimoPago);
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
        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
        }
        private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
        }
        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
        }
        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            controlador.formatoMoneda(txtSueldo);
        }
        private void txtCalcular_Click(object sender, EventArgs e)
        {
            validaCampos();           
        }
        private void llenarGrid()
        {
            DataTable table = new DataTable();
            //int cantidad = datos.Rows.Count;

            table.Columns.Add("Prestación");
            table.Columns.Add("Valor");


            DataRow row = table.NewRow();
            row["Prestación"] = ("Indemnización");
            row["Valor"] = (calculoIndemnizacion().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Aguinaldo");
            row["Valor"] = (calculoAguinaldo().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Bono 14");
            row["Valor"] = (calculoBono14().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Bonificación Incentivo");
            row["Valor"] = (calculoBonificacionIncentivo().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Total de Vacaciones");
            row["Valor"] = (calculoVacaciones().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Total Comisiones");
            row["Valor"] = (comisiones().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Horas Extra");
            row["Valor"] = (HorasExtra().ToString("N2"));
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("_______________________________");
            row["Valor"] = ("__________________________________");
            table.Rows.Add(row);
            row = table.NewRow();
            row["Prestación"] = ("Total a Percibir");
            row["Valor"] = (CalculoTotal().ToString("N2"));
            table.Rows.Add(row);
            dgvVistaPrevia.DataSource = table;
            dgvVista.DataSource = table;
        }
        private double calculoIndemnizacion()
        {
            int dias = controlador.calculoDiasLaborados(txtFechaContratacion.Text, txtFinContrato.Text);
            double promedioSueldo = Convert.ToDouble(txtSalarioPromedio.Text);
            double resultado = (promedioSueldo * dias) / 365;
            return resultado;
        }
        private double calculoAguinaldo()
        {
            int dias = controlador.calculoDiasLaboradosaguinaldo(txtFinContrato.Text);
            double promedioSueldo = Convert.ToDouble(txtSalarioPromedio.Text);
            double resultado = (promedioSueldo * dias) / 365;
            return resultado;
        }
        private double calculoBono14()
        {
            int dias = controlador.calculoDiasLaboradosBono14(txtFinContrato.Text);
            double promedioSueldo = Convert.ToDouble(txtSalarioPromedio.Text);
            double resultado = (promedioSueldo * dias) / 365;
            return resultado;
        }
        private double calculoBonificacionIncentivo()
        {
            int dia = controlador.calculoDiasBonoIncentivo(txtFinContrato.Text);
            double bono = Convert.ToDouble(txtBonificacionIncentivo.Text);
            double resultado = (bono * dia) / 30;
            return resultado;
        }
        private double calculoVacaciones()
        {
            int dias = controlador.calculoDiasLaborados(txtUltimoPeriodoVacaciones.Text, txtFinContrato.Text);
            double diasOtorgados = Convert.ToDouble(txtVacacionesAnuales.Text);
            double promedioSueldo = Convert.ToDouble(txtSalarioPromedio.Text);
            double SueldoDiario = promedioSueldo / 30;
            double resultadodias = (diasOtorgados * dias) / 365;
            double resultado = SueldoDiario * resultadodias;
            return resultado;
        }
        private double comisiones()
        {
            if (txtComisionesPromedio.Text != "")
            {
                double valorcomision = Convert.ToDouble(txtComisionesPromedio.Text);
                return valorcomision;
            }
            else
            {
                double comision = 0;
                return comision;
            }
        }
        private double HorasExtra()
        {
            if (txtComisionesPromedio.Text != "")
            {
                double horas = Convert.ToDouble(txtHorasExtraordinarias.Text);
                double SueldoPromedio = Convert.ToDouble(txtSalarioPromedio.Text);
                double valorDia = (SueldoPromedio/30) * 1.5;
                double resultado = horas * valorDia;
                return resultado;
            }
            else
            {
                double comision = 0;
                return comision;
            }
        }
        private double CalculoTotal()
        {
            double Indemnizacion = calculoIndemnizacion();
            double Aguinaldo = calculoAguinaldo();
            double Bono14 = calculoBono14();
            double Incentivo = calculoBonificacionIncentivo();
            double vacaciones = calculoVacaciones();
            double comision = comisiones();
            double extra = HorasExtra();
            double resultado = Indemnizacion + Aguinaldo + Bono14 + Incentivo + vacaciones+comision+extra;
            return resultado;
        }
        private void txtSalarioPromedio_Leave(object sender, EventArgs e)
        {
            controlador.formatoMoneda(txtSalarioPromedio);
        }
        private void txtComisionesPromedio_Leave(object sender, EventArgs e)
        {
            controlador.formatoMoneda(txtComisionesPromedio);
        }
        private void txtBonificacionIncentivo_Leave(object sender, EventArgs e)
        {
            controlador.formatoMoneda(txtBonificacionIncentivo);
        }
        private void Limpiar()
        {
            dgvVistaPrevia.DataSource = null;
            txtUltimoPeriodoVacaciones.Text = "";
            txtUltimoPago.Text = "";
            txtSalarioPromedio.Text = "";
            txtComisionesPromedio.Text = "";
            txtBonificacionIncentivo.Text = "";
            txtHorasExtraordinarias.Text = "";
            txtVacacionesAnuales.Text = "";
            txtObservaciones.Text = "";
            txtEstado.Text = "";
            dtpPeriodoVacaiones.Value = DateTime.Now;
            dtpUltimoPago.Value = DateTime.Now;
            rbnEstatusamodulo.Checked = false;
            rbnEstatusimodulo.Checked = false;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
        }
        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void validaCampos()
        {
            if(txtUltimoPeriodoVacaciones.Text == "" || txtUltimoPago.Text == "" || txtSalarioPromedio.Text == ""
                || txtComisionesPromedio.Text == ""|| txtBonificacionIncentivo.Text == ""
                || txtHorasExtraordinarias.Text == ""|| txtVacacionesAnuales.Text == ""
                || txtObservaciones.Text == ""|| txtEstado.Text == "")
            {
                MessageBox.Show("Llene los campos vacíos");
                if (txtUltimoPeriodoVacaciones.Text == "")
                {
                    dtpPeriodoVacaiones.Focus();
                }
                else if (txtUltimoPago.Text == "")
                {
                    dtpUltimoPago.Focus();
                } 
                else if (txtSalarioPromedio.Text == "")
                {
                    txtSalarioPromedio.Focus();
                }
                else if(txtComisionesPromedio.Text == "")
                {
                    txtComisionesPromedio.Focus();
                }
                else if(txtComisionesPromedio.Text == "")
                {
                    txtComisionesPromedio.Focus();
                }
                else if (txtBonificacionIncentivo.Text == "")
                {
                    txtBonificacionIncentivo.Focus();
                }
                else if(txtHorasExtraordinarias.Text == "")
                {
                    txtHorasExtraordinarias.Focus();
                }
                else if (txtVacacionesAnuales.Text == "")
                {
                    txtVacacionesAnuales.Focus();
                }
                else if(txtObservaciones.Text == "")
                {
                    txtObservaciones.Focus();
                }
                else if(txtEstado.Text == "")
                {
                    rbnEstatusamodulo.Focus();
                }
            }
            else
            {
                llenarGrid();
                btnGuardar.Enabled = true;
                btnImprimir.Enabled = true;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }
        public void encabezadoAutomático()
        {
            try
            {
                int entero = controlador.idSiguienteDeNuevoIngreso("liquidacion_e", "pkid");
                txtIdLiquidacion.Text = entero.ToString(); txtIdLiquidacion.Enabled = false;               
            }
            catch (Exception ex) { MessageBox.Show("Error al obtener ID" + ex); }
        }
        private void Guardar()
        {
            controlador.GuardarEncabezadoLiquidacion("liquidacion_e", txtIdLiquidacion.Text, txtUltimoPago.Text, txtEstado.Text);
            controlador.guardarLiquidacionDetalleBD("liquidacion_d", txtIdLiquidacion.Text,txtIDEmpleado.Text, Convert.ToDouble(txtSueldo.Text),txtUltimoPeriodoVacaciones.Text, Convert.ToDouble(txtSalarioPromedio.Text), Convert.ToDouble(txtBonificacionIncentivo.Text), Convert.ToDouble(txtHorasExtraordinarias.Text),txtObservaciones.Text,calculoIndemnizacion(),calculoAguinaldo(),calculoBono14(),calculoBonificacionIncentivo(),calculoVacaciones(), Convert.ToDouble(txtComisionesPromedio.Text),HorasExtra(),CalculoTotal());
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Reporte de Liquidación";
            
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")) + " ID Liquidación: " 
                + txtIdLiquidacion.Text.ToString() + "\n" + " Empleado: " + txtIDEmpleado.Text.ToString() 
                + " " + txtNombre.Text.ToString()+" "+txtApellido.Text.ToString()+ "\n" + " Fecha de nacimiento: " 
                + txtFechaNacimiento.Text.ToString() + "\n"+ " Sueldo " + txtSueldo.Text.ToString()+ " Jornada: " 
                + txtJornada.Text.ToString() + "\n" +"Fecha contratación: "+txtFechaContratacion.Text.ToString()
                +"   Fecha de Fin de Contrato: "+txtFinContrato.Text.ToString()+ "\n" +" Puesto: "+txtPuesto
                + " Empresa: "+txtEmpresa.Text.ToString()+"\n"+"Último Periodo de Vacaciones: "+txtUltimoPeriodoVacaciones.Text.ToString()
                +" Pago De Liquidación: "+ txtUltimoPago .Text.ToString()+"\n"+" Sueldo Promedio: "+txtSalarioPromedio.Text.ToString()
                +"\n"+"Observaciones: "+txtObservaciones.Text.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Módulo Recursos Humanos";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvVista);
            
        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarFechaDTP(dtFechaNacimiento, txtFechaNacimiento);
            navegador1.CambiarFormatoFecha(dtFechaNacimiento, txtFechaNacimiento);
        }
    }
}
