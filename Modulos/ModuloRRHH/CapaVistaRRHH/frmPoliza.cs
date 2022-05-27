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
    public partial class frmPoliza : Form
    {
        private Controlador cn = new Controlador();
        public frmPoliza()
        {
            InitializeComponent();
            ConsultaTablasPoliza();
        }


        public void ConsultaTablasPoliza()
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            string fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            DataTable ConnceptosUsados = cn.CantidadConceptosPlanilla(id);
            DataTable valor1Poliza = cn.ConsultaTablasPoliza1(id,fecha);
            DataTable valor2Poliza = cn.ConsultaTablasPoliza2(id,fecha);
            DataTable valor3Poliza = cn.ConsultaTablasPoliza3(id,fecha);
            int cantidadConceptos = ConnceptosUsados.Rows.Count;
            //string fecha = Convert.ToString(dateTimePicker1.Value.Date);
            
            //string fecha = "0000-00-00";
            cn.Borrarpoliza(fecha);
           //MessageBox.Show(fecha);
            for (int i = 0; i < cantidadConceptos; i++)
            {
                //Obtiene id de cuenta
                DataTable valor1 = cn.ConsultaTablasPoliza1(ConnceptosUsados.Rows[i]["pkIdConcepto"].ToString(),fecha);
                string valor1a = string.Join(Environment.NewLine, valor1.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));

                //Obtiene Suma de concepto
                DataTable valor2 = cn.ConsultaTablasPoliza2(ConnceptosUsados.Rows[i]["pkIdConcepto"].ToString(),fecha);
                string valor2a = string.Join(Environment.NewLine, valor2.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));

                //Obtiene Efecto
                DataTable valor3 = cn.ConsultaTablasPoliza3(ConnceptosUsados.Rows[i]["pkIdConcepto"].ToString(),fecha);
                string valor3a = string.Join(Environment.NewLine, valor3.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));

                
                cn.Guradarpoliza(valor1a, valor2a, fecha);
                
            }
            //DataTable filaPoliza = cn.ConsultaTablasPoliza(dtCantidad.Rows[i]["pkIdConcepto"].ToString());


            //Obtener suma salarios
            DataTable SalariosPoliza = cn.ObtenerSalarioPoliza(id,fecha);
            var Suma3 = SalariosPoliza.Compute("SUM(SueldoBase)", string.Empty);
            int ResultadoSalario = 0;
            if (Suma3 != System.DBNull.Value)
            {
                ResultadoSalario = Convert.ToInt32(Suma3);
            }
            string ResultadoSalarioFinal = ResultadoSalario.ToString();

            string codigoSalario = "6.1.1.1.001"; //Id Salario
            cn.Guradarpoliza(codigoSalario, ResultadoSalarioFinal, fecha);
            //Fin suma salarios

            //Calculo de Cuota patronal
            double cuotaPatronal = Convert.ToInt32(ResultadoSalarioFinal) * 0.1267;
            string cuotaPatronalFinal = ResultadoSalario.ToString();
            string codigoPatronal = "6.1.1.1.006"; //id Cuota patronal
            cn.Guradarpoliza(codigoPatronal, cuotaPatronalFinal, fecha);

            string codigoPatronalPorPagar = "2.1.3.1.003"; //Id cuota patornal por pagar
            cn.Guradarpoliza(codigoPatronalPorPagar, cuotaPatronalFinal, fecha);
            //Fin cuota patronal


            //MessageBox.Show(ResultadoSalario.ToString());


            DataTable DatosAMostarEnPoliza = cn.MostarPoliza(id, fecha);
            int cantidadDatosPoliza = DatosAMostarEnPoliza.Rows.Count;
            int SaldoD = 0;
            int SaldoA = 0;
            for (int i = 0; i < cantidadDatosPoliza; i++)
            {
                if (DatosAMostarEnPoliza.Rows[i]["efecto"].ToString() == "1")
                {
                    SaldoD = Convert.ToInt32(DatosAMostarEnPoliza.Rows[i]["valor"].ToString()) + SaldoD;
                }
                else if (DatosAMostarEnPoliza.Rows[i]["efecto"].ToString() == "2")
                {
                    SaldoA = Convert.ToInt32(DatosAMostarEnPoliza.Rows[i]["valor"].ToString()) + SaldoA;
                }

            }
            int saldoBanco = Math.Abs(SaldoD - SaldoA);
            string codigoBanco = "1.1.1.2.001";
            cn.Guradarpoliza(codigoBanco, saldoBanco.ToString(), fecha);






            DataTable dt = cn.MostarPoliza(id, fecha);
            dtgPoliza.DataSource = dt;


        }
    }



}


