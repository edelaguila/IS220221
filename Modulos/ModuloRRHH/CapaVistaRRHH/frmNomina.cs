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
    public partial class frmNomina : Form
    {
        public string fechainicial, fechafinal;
        CapaControladorRRHH.Controlador controlador = new CapaControladorRRHH.Controlador();
        private CapaControladorRRHH.PideDatos global = new CapaControladorRRHH.PideDatos();
        //Variables 
        int cantidadConceptos = 0, cantidadEmpleados=0;
        DataTable idEmpleado, nombreEmpleado, sueldoEmpleado, nombreConcepto = new DataTable();
        DataTable tabalaNomina = new DataTable();
       
        public frmNomina()
        {
            InitializeComponent();
             //Variables Asignadas
            cantidadConceptos = cantidadEnTabla("concepto");
            cantidadEmpleados = cantidadEnTabla("empleado");
            nombreConcepto = controlador.EncabezadoNominaControlador("concepto", "nombreConcepto");
            nombreEmpleado = controlador.EncabezadoNominaControlador("empleado", "nombre");
            idEmpleado = controlador.EncabezadoNominaControlador("empleado", "pkIdEmpleado");
            sueldoEmpleado = controlador.EncabezadoNominaControlador("empleado", "sueldo");
            //Metodos de generacion de planilla
            encabezadoAutomático();
            llenarFilas();
            ingresoSueldoLiquidoPorEmpleado();
           

            rbnEstatusamodulo.Checked = true;
        }
        // datosAutomatico: Llena los datos del encabezado de la nómina al generarla de manera automática.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public void encabezadoAutomático()
        {
            try
            {
                int entero = controlador.idSiguienteDeNuevoIngreso("nomina_e", "CodigoNominaE");
                txtIdNomina.Text = entero.ToString();txtIdNomina.Enabled = false;
                txtInicio.Text = global.FechaInicio; txtInicio.Enabled = false;
                txtFin.Text = global.FechaFin; txtFin.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show("Error al obtener ID" + ex); }
        }
        // ingresoDatosDGV: Llena  el encabezado de la nómina con los datos obtenidos desde las tablas de BD.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public void ingresoDatosDGV(int idConcepto, int idEmpleado)
        {
            try
            {
                DataTable calculoConcepto, matrizNomina = new DataTable();
                matrizNomina.Columns.Add("Id Empleado");
                matrizNomina.Columns.Add("Nombre Empleado");
                matrizNomina.Columns.Add("Sueldo Empleado");
                for (int x = 0; x < cantidadConceptos; x++)
                {
                    matrizNomina.Columns.Add(nombreConcepto.Rows[x][0].ToString());
                }
                matrizNomina.Columns.Add("Sueldo Líquido");
                tabalaNomina = matrizNomina;
                dgvNomina.DataSource = tabalaNomina;               
                float sumaPercepciones = float.Parse(txtsumaper.Text);
                float sumaDeducciones = float.Parse(txtsumaded.Text);
                for (int y = 0; y < cantidadEmpleados; y++)
                { 
                    DataRow row = matrizNomina.NewRow();
                    row["Id Empleado"] = (y + 1).ToString();
                    row["Nombre Empleado"] = (nombreEmpleado.Rows[y][0].ToString());
                    row["Sueldo Empleado"] = (sueldoEmpleado.Rows[y][0].ToString());                                                      
                    for (int z = 0; z < cantidadConceptos; z++)
                    {    
                        calculoConcepto = controlador.calculoConcepto(z + 1, y + 1);string calculoConceptoSigno = "";       
                        Boolean respuesta= controlador.validarRelacion((y+1),(z+1), "detalle_personalizado_unicamente");         
                        if (respuesta==true)
                        {
                            Boolean efecto = controlador.validarEfecto(z + 1);
                            if (efecto==true)
                            {
                                calculoConceptoSigno = ("+"+calculoConcepto.Rows[0][0].ToString());
                                sumaPercepciones = sumaPercepciones + float.Parse(calculoConcepto.Rows[0][0].ToString());
                                txtsumaper.Text = sumaPercepciones.ToString();
                            }
                            else if (efecto==false)
                            {
                                calculoConceptoSigno = ("-"+calculoConcepto.Rows[0][0].ToString());
                                sumaDeducciones = sumaDeducciones + float.Parse(calculoConcepto.Rows[0][0].ToString());
                                txtsumaded.Text = sumaDeducciones.ToString();
                            }
                            else{MessageBox.Show("No se encontró un efecto para este concepto");}
                        }
                        else if(respuesta==false){calculoConceptoSigno = "+0.00";}
                        else{MessageBox.Show("No se encontró calculo relacionado.");}
                        row[nombreConcepto.Rows[z][0].ToString()] = (calculoConceptoSigno);
                    }
                    matrizNomina.Rows.Add(row);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al llenar tabla" + ex); }
        }
        // llenarFilas: Ingresa los datos de los calculos para cada empleado en la fila correspondiente.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public void llenarFilas()
        {
            for (int x = 0; x < cantidadConceptos; x++)
           { 
                for (int y = 0; y < cantidadEmpleados; y++)
                {
                    ingresoDatosDGV(x,y);                  
                }          
            }              
            float valordeducciones = calculoPlanilla(txtsumaded.Text);
            float valorpercepciones = calculoPlanilla(txtsumaper.Text);
            txtsumaper.Text = valorpercepciones.ToString();
            txtsumaded.Text = valordeducciones.ToString();
        }
        // cantidadEnTabla: Contabiliza los registros dentro de una tabla y los regresa como valor entero.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public int cantidadEnTabla(string tabla)
        {
            int CT=controlador.cantidadTabla(tabla);
            return (CT);
        }
        // calculoPlanilla: Sumariza los sueldos de los empleados para encontrar el sueldo líquido total de la planilla.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public float calculoPlanilla(string total)
        {
            float valorinicial = float.Parse(total);
            float resultado = valorinicial / float.Parse((cantidadConceptos*cantidadEmpleados).ToString());
           calculoSueldoLiquido();
            return resultado;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Reporte de Nómina";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"))+" ID Nómina: "+ txtIdNomina.Text.ToString() +"\n"+ " Inicio del Periodo: " + txtInicio.Text.ToString()+" Final del Periodo: " + txtFin.Text.ToString()+ "\n"+" Total Percepciones: " + txtsumaper.Text.ToString() + " Total Deducciones: "+ txtsumaded.Text.ToString()+ " Total Líquido: "+txtTotal.Text.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Módulo Recursos Humanos";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvNomina);
        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
          
        }

        // calculoSueldoLiquido: Calcula el sueldo líquido por empleado y la suma total en planilla.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public DataTable calculoSueldoLiquido()
        {
            DataTable TablaSueldoL  = new DataTable();
            TablaSueldoL.Columns.Add("sueldo liquido", typeof(string));
            float sumaSueldoLEmpleado = 0;
            float sumaSueldoLTotal = 0;float sumaTotalLiquido = 0;
            for (int i = 0; i < cantidadEmpleados; i++)
            {DataRow newRow = TablaSueldoL.NewRow();
                for(int j = 0; j < cantidadConceptos; j++)
                {                    
                    string valor= (String)dgvNomina[j+3, i].Value;
                    sumaSueldoLEmpleado = sumaSueldoLEmpleado + (float.Parse(valor)); 
                    string sueldo= (sueldoEmpleado.Rows[i][0].ToString()); 
                    sumaSueldoLTotal = sumaSueldoLEmpleado + (float.Parse(sueldo));               
                }
                
                newRow["sueldo liquido"] = sumaSueldoLTotal.ToString(); 
                TablaSueldoL.Rows.Add(newRow);
                sumaSueldoLEmpleado = 0;
                sumaTotalLiquido = sumaTotalLiquido + sumaSueldoLTotal;
                sumaSueldoLTotal = 0;
            }
            txtTotal.Text = sumaTotalLiquido.ToString();
            return TablaSueldoL;           
        }

        private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
        {
            //pone el estado activo para la nómina
            txtEstado.Text= "1";
        }

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
        {
            //pone el estado inactivo para la nómina
            txtEstado.Text = "0";
        }
        //btnGuardar_Click: Guarda el encabezado y los detalles de nómina relacionados con cada empleado.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idEmpleado = "", sueldoBase = "", calculoConcepto = "", sueldoLiquido = "";
            string idConcepto = "";
            try
            {
                //Se guarda el encabezado generado.
                controlador.guardarNominaEncabezado(txtIdNomina.Text, txtInicio.Text, txtFin.Text, txtsumaper.Text, txtsumaded.Text, txtTotal.Text, txtEstado.Text);
                for(int i = 0; i < cantidadEmpleados; i++)
                {
                    idEmpleado = tabalaNomina.Rows[i]["Id Empleado"].ToString();
                    sueldoBase= tabalaNomina.Rows[i]["Sueldo Empleado"].ToString();
                    sueldoLiquido= tabalaNomina.Rows[i][3+cantidadConceptos].ToString();

                    for (int j = 0; j < cantidadConceptos; j++)
                    {
                        idConcepto = (j + 1).ToString();
                        calculoConcepto= tabalaNomina.Rows[i][j+3].ToString();
                        //Se guardan los datos obtenidos para el detalle de la nómina del empleado.
                        controlador.guardarNominaDetalleBD(txtIdNomina.Text, idEmpleado, idConcepto, sueldoBase, calculoConcepto, sueldoLiquido, txtEstado.Text);
                    }
                    
                }
                MessageBox.Show("Nomina Guardada correctamente.");
            }
            catch (Exception ex) { MessageBox.Show("No fue posible guardar el encabezado de la nómina "+ ex); }
            
        }
        // ingresoSueldoLiquidoPorEmpleado: Ingresa los datos del sueldo líquido a cada empleado.
        // función realizada por: Pareja 1 - Heydi Quemé y Kevin Flores
        public void ingresoSueldoLiquidoPorEmpleado()
        {           
            DataTable sueldoL = new DataTable();
            sueldoL = calculoSueldoLiquido();
            
            for (int s = 0; s < cantidadEmpleados; s++)
            {   
                tabalaNomina.Rows[s][cantidadConceptos+3]= (sueldoL.Rows[s][0].ToString());
            }           
            dgvNomina.DataSource = tabalaNomina;
        }        
    }
}
