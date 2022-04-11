using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace CapaModeloRRHH
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();

        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter UnicamentellenarTbl(string tabla2)
        {
            //Obtiene todos los conceptos
            string sql = "SELECT pkIdConcepto, nombreConcepto FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter UnicamentellenarTblPersonal(string tabla2, string condicion)
        {
            //Obtiene todos los conceptos asignados a un emepleado especifico
            string sql = "SELECT concepto.pkIdConcepto, concepto.nombreConcepto FROM " + tabla2 + "  LEFT JOIN detalle_personalizado_unicamente ON concepto.pkIdConcepto = detalle_personalizado_unicamente.fkIdConcepto LEFT JOIN empleado ON detalle_personalizado_unicamente.fkIdEmpleado = empleado.pkIdEmpleado WHERE empleado.pkIdEmpleado = " + condicion + " ORDER BY concepto.pkIdConcepto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter UnicamentellenarNombre(string tabla, string condicion)
        {
            //Obtiene el nombre del empleado
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkIdEmpleado = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }
        //Danny Saldaña 0901-18-18686
        public void Unicamenteagregar(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkIdEmpleado, fkIdConcepto) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Danny Saldaña 0901-18-18686
        public void Unicamenteeliminar(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdEmpleado = '" + valor1 + "' AND  fkIdConcepto='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void Unicamenteeliminartodo(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdEmpleado = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void Unicamenteagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO detalle_personalizado_unicamente (fkIdEmpleado, fkIdConcepto) SELECT NULL, pkidConcepto FROM concepto;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE detalle_personalizado_unicamente SET " + tabla3 + " = '" + valor1 + "' WHERE fkIdEmpleado = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }

        //Primer consulta de todos los registros del historial ISR
        public OdbcDataAdapter llenarDGVTodosReg()// metodo  que obtinene el contenio de una tabla en la BD
        {
            string sql = "SELECT * FROM isrencabezado WHERE periodoInicio LIKE '%-%-%';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Segunda consulta de todos los registros del historial ISR por año
        public OdbcDataAdapter llenarDGVTodosRegAnio(string anio)// metodo  que obtinene el contenio de una tabla en la BD
        {
            string sql = "SELECT * FROM isrencabezado WHERE periodoInicio LIKE '"+ anio + "-%-%' and periodoFinal LIKE '"+ anio + "-%-%';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Tercer consulta de todos los registros del historial ISR por mes
        public OdbcDataAdapter llenarDGVRegMes(string mes)// metodo  que obtinene el contenio de una tabla en la BD
        {
            string sql = "SELECT * FROM isrencabezado WHERE periodoInicio LIKE '%-" + mes + "-%' and periodoFinal LIKE '%-" + mes + "-%';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Cuarta consulta de todos los registros detalles del historial ISR por ID Registrado
        public OdbcDataAdapter llenarDGVRegDetalle(string Id)// metodo  que obtinene el contenio de una tabla en la BD
        {
            string sql = "select isrencabezado.pkIdISR,isrencabezado.periodoInicio,isrencabezado.periodoFinal,isrdetalle.fkIdEmpleado,empleado.nombre,isrdetalle.isrSubTotal from isrdetalle,isrencabezado,empleado where isrencabezado.pkIdISR=isrdetalle.fkIdISR and empleado.pkIdEmpleado = isrdetalle.fkIdEmpleado and isrencabezado.pkIdISR='"+Id+"';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        

        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter ExceptollenarTbl(string tabla2)
        {
            //Obtiene todos los conceptos
            string sql = "SELECT pkIdConcepto, nombreConcepto FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter ExceptollenarTblPersonal(string tabla2, string condicion)
        {
            //Obtiene todos los conceptos asignados a un emepleado especifico
            string sql = "SELECT concepto.pkIdConcepto, concepto.nombreConcepto FROM " + tabla2 + "  LEFT JOIN detalle_personalizado_excepto ON concepto.pkIdConcepto = detalle_personalizado_excepto.fkIdConcepto LEFT JOIN empleado ON detalle_personalizado_excepto.fkIdEmpleado = empleado.pkIdEmpleado WHERE empleado.pkIdEmpleado = " + condicion + " ORDER BY concepto.pkIdConcepto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter ExceptollenarNombre(string tabla, string condicion)
        {
            //Obtiene el nombre del empleado
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkIdEmpleado = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }
        //Danny Saldaña 0901-18-18686
        public void Exceptoagregar(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkIdEmpleado, fkIdConcepto) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Danny Saldaña 0901-18-18686
        public void Exceptoeliminar(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdEmpleado = '" + valor1 + "' AND  fkIdConcepto='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void Exceptoeliminartodo(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdEmpleado = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void Exceptoagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO detalle_personalizado_excepto (fkIdEmpleado, fkIdConcepto) SELECT NULL, pkidConcepto FROM concepto;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE detalle_personalizado_excepto SET " + tabla3 + " = '" + valor1 + "' WHERE fkIdEmpleado = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }








        public OdbcDataAdapter FormulasLlenarComboTablas()
        {
            //Obtiene todas las tablas
            string sql = "SHOW TABLES FROM hotelsancarlos;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter FormulasLlenarComboCampos(String tabla)
        {
            //Obtiene todos los campos de la tabla seleccionada
            string sql = "show columns from " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter FormulasTodosLosConceptos()
        {
            //Obtiene todos los conceptos
            string sql = "SELECT pkIdConcepto, nombreConcepto FROM concepto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void FormulasAsignarConcepto(string formula, string pkIdConcepto)
        {
            string sql = "UPDATE concepto SET formulaConcepto = '" + formula + "' WHERE pkIdConcepto = '" + pkIdConcepto + "';";
            OdbcCommand consulta2 = new OdbcCommand(sql, cn.conexion());
            consulta2.ExecuteNonQuery();
        }








        public void GuradarSentenciaSql(string valor1, string valor2)
        {
            try 
            { 
                string sql = "INSERT INTO sentenciaSqlPlanilla (fkIdConcepto, sentenciaSql) Values( '" + valor1 + "', '" + valor2 + "');";
                OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }


        //Generación de Nómina Heydi Quemé 9959-18-5335 

              
        public void generarNomina(string fechaInicio, string fechaFin)
        {
            string[,] Vectornomina;
            int dimensionalEmpleados = 0;
            int dimensionalConceptos = 0;
            string tabla = "";
            string querydimensionale = "";
            string conceptos = "";
            string empleados = "";
            try
            {
                tabla = "concepto";
                querydimensionale = "SELECT count(*) from " + tabla + ";";
                DataTable dt = PasarCalculoTabla(querydimensionale);
                string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(l => string.Join(" ; ", l.ItemArray)));
                conceptos = dta;
                dimensionalConceptos = Int32.Parse(conceptos);
                MessageBox.Show("El número de elementos en " + tabla + " son:" + conceptos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }
            try
            {
                tabla = "empleado";
                querydimensionale = "SELECT count(*) from " + tabla + ";";
                DataTable dt = PasarCalculoTabla(querydimensionale);
                string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(l => string.Join(" ; ", l.ItemArray)));
                empleados = dta;
                dimensionalEmpleados = Int32.Parse(empleados);
                MessageBox.Show("El número de elementos en " + tabla + " son:" + empleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }

            Vectornomina = new string[dimensionalEmpleados, dimensionalConceptos];
            for (int x = 0; x < dimensionalEmpleados; x++)
            {
                for (int z = 0; z < dimensionalConceptos; z++)
                {
                    int contador = z + 1;
                    string reemplazo = contador.ToString().Trim();
                    string id = "";
                    string Query = "SELECT * FROM detalle_personalizado_unicamente WHERE fkidempleado='" + reemplazo + "';";

                    OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                    consulta.ExecuteNonQuery();

                    OdbcDataReader busqueda;
                    busqueda = consulta.ExecuteReader();

                    if (busqueda.Read())
                    {

                        id = busqueda["fkidconcepto"].ToString();
                    }


                    string sql = "";
                    string Query2 = "SELECT * FROM sentenciasqlplanilla WHERE fkidconcepto='" + id + "';";

                    OdbcCommand consulta2 = new OdbcCommand(Query2, cn.conexion());
                    consulta2.ExecuteNonQuery();

                    OdbcDataReader busqueda2;
                    busqueda2 = consulta2.ExecuteReader();

                    if (busqueda2.Read())
                    {
                        sql = busqueda2["sentenciasql"].ToString();
                    }

                    string reemplazoComillas = "'" + reemplazo + "'";
                    string sentenciaComillas = sql.Replace('"', ' ');
                    string sentenciaReplace = sentenciaComillas.Replace("+ condicion +", reemplazoComillas);
                    string calculo = "";
                    try
                    {
                        DataTable dt = PasarCalculoTabla(sentenciaReplace);
                        string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(l => string.Join(" ; ", l.ItemArray)));
                        calculo = dta;
                        MessageBox.Show("El calculo es:" + calculo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en Asignación:" + ex);
                    }
                    int idconcepto = Int32.Parse(id);
                    Vectornomina[z, x] = Vectornomina[z, x] + calculo;

                    MessageBox.Show("El valor registrado es: " + Vectornomina[z, x]);
                    z++;
                }
                x++;
            }

        }
        public OdbcDataAdapter ExtraerDatoCalculado(string condicion)
        {
            //Obtiene todos los calculos realizados
            string sql = condicion;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public DataTable PasarCalculoTabla(string sentencia)
        {
            OdbcDataAdapter dt = ExtraerDatoCalculado(sentencia);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


    }
}
