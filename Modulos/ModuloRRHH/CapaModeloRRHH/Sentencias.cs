﻿using System;
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
            string sql = "SELECT * FROM isrencabezado WHERE periodoInicio LIKE '" + anio + "-%-%' and periodoFinal LIKE '" + anio + "-%-%';";
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
            string sql = "select isrencabezado.pkIdISR,isrencabezado.periodoInicio,isrencabezado.periodoFinal,isrdetalle.fkIdEmpleado,empleado.nombre,isrdetalle.isrSubTotal from isrdetalle,isrencabezado,empleado where isrencabezado.pkIdISR=isrdetalle.fkIdISR and empleado.pkIdEmpleado = isrdetalle.fkIdEmpleado and isrencabezado.pkIdISR='" + Id + "';";
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


        //Generación de Nómina Heydi Quemé 9959-18-5335 Kevin Flores 9959-18-17632

        public OdbcDataAdapter ExtraerDatoCalculado(string condicion)
        {
            //Obtiene todos los calculos realizados
            string sql = condicion;
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);
            return dataTable;

        }
        public DataTable PasarCalculoTabla(string sentencia)
        {
            OdbcDataAdapter dt = ExtraerDatoCalculado(sentencia);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable EncabezadoNominaSetencias(string tabla, string querybusqueda)
        {
            int dimensionalConceptos = 0; string querydimensionale = "", conceptos = ""; DataTable Encabezado = new DataTable();
            try
            {                
                dimensionalConceptos = cantidadTB(tabla);                
                for (int i = 0; i < dimensionalConceptos; i++)
                {
                    querydimensionale = "SELECT " + querybusqueda + " from " + tabla + " where estado= '1';";
                    Encabezado = PasarCalculoTabla(querydimensionale);
                    string dtConceptosE = string.Join(Environment.NewLine, Encabezado.Rows.OfType<DataRow>().Select(l => string.Join(" ; ", l.ItemArray)));                                 
                }
            }
            catch (Exception ex) { MessageBox.Show("Error en obtener encabezado Nomina capa Modelo " + ex); }
            cn.desconexion(cn.conexion());
            return (Encabezado);            
        }
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            string ultimoEntero = ""; int enteroSumado = 0; OdbcDataReader leer = null;
            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
            OdbcConnection conect = cn.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    //enteroSumado += ultimoEntero; 
                    enteroSumado = int.Parse(ultimoEntero) + 1;
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            finally
            { cn.desconexion(conect); }
            if (enteroSumado == 0)
            { enteroSumado = 1; }

            return enteroSumado;
        }
        public DataTable calculoConceptoSentencias(int idConcepto, int idEmpleado)
        {
            DataTable tabla = new DataTable();
            try
            {
                //SE SELECCIONAN LAS FORMULAS RELACIONADAS CON LOS CONCEPTOS
                string sql = "", Query2 = "SELECT * FROM sentenciasqlplanilla WHERE fkidconcepto='" + idConcepto + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta2 = new OdbcCommand(Query2, conect);
                consulta2.ExecuteNonQuery(); OdbcDataReader busqueda2;
                busqueda2 = consulta2.ExecuteReader();
                if (busqueda2.Read())
                {
                    sql = busqueda2["sentenciasql"].ToString();
                }
                cn.desconexion(conect);
                // SE ADAPTA LA FORMULA PARA ENVIARLA COMO QUERY
                string reemplazoComillas = "'" + idEmpleado.ToString() + "'", sentenciaComillas = sql.Replace('"', ' ');
                string sentenciaReplace = sentenciaComillas.Replace("+ condicion +", reemplazoComillas);
                string sentenciafinal = sentenciaReplace + ";";               
                //SE ENVIA COMO QUERY LA FORMULA DEL CONCEPTO
                try
                {
                    tabla = PasarCalculoTabla(sentenciafinal);                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en Asignación:" + ex);
                }

            }
            catch (Exception ex) { MessageBox.Show("Error en obtener encabezado Nomina capa Controlador " + ex); }

            return (tabla);

        }
        public int cantidadTB(string tabla)
        {
            int CT = 0;
            try
            {
                string querydimensionale = "SELECT count(*) from " + tabla + " where estado= '1';";
                DataTable dtConceptos = PasarCalculoTabla(querydimensionale);
                string dta = string.Join(Environment.NewLine, dtConceptos.Rows.OfType<DataRow>().Select(l => string.Join(" ; ", l.ItemArray)));
                CT = Int32.Parse(dta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }

            return (CT);
        }
        public Boolean validarRelacion(int idEmpleado, int idConcepto, string tabla)
        {
            Boolean respuesta = false;
            int cantidadc = cantidadTB("concepto");
            string Queryc = "SELECT * FROM " + tabla + " WHERE fkidempleado='" + idEmpleado + "' AND fkidconcepto='" + idConcepto + "';";           
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consultac = new OdbcCommand(Queryc, conect);
                consultac.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = consultac.ExecuteReader();
                if (busquedac.Read())
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
                cn.desconexion(conect);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al validar relación concepto-empleado: " + e);
            }                        
            return respuesta;
        }
        public Boolean validarEfecto(int idConcepto)
        {
            string efecto = "";
            Boolean respuesta = false;
            int cantidadc = cantidadTB("concepto");
            string Queryc = "SELECT efectoConcepto FROM concepto WHERE pkidconcepto='" + idConcepto + "';";            
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consultac = new OdbcCommand(Queryc, conect);
                consultac.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = consultac.ExecuteReader();
                if (busquedac.Read())
                {
                    efecto = busquedac["efectoConcepto"].ToString();
                }
                if (efecto == "+")
                {
                    respuesta = true;
                }
                else if (efecto == "-")
                {
                    respuesta = false;
                }
                else
                {
                    MessageBox.Show("No se encontró un efecto asignado.");
                }
                cn.desconexion(conect);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al validar efecto del concepto: " + e);
            }
            //MessageBox.Show("la respuesta es " + respuesta.ToString());
            return respuesta;
        }
        public void guardarNominaEncabezado(string id, string fechai, string fechaf, string totalp, string totald, string total, string estado)
        {
            try
            {
                string cadena = "INSERT INTO nomina_e VALUES ('" + id + "','" + fechai + "','" + fechaf + "'," + totalp + "," + totald + "," + total + ",'" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir póliza por venta: " + ex.Message);
            }
        }
        public void guardarNominaDetalleBD(string nomina_e, string empleado, string concepto, string sueldob, string calculo, string liquido, string estado)
        {
            try
            {
                string cadena = "INSERT INTO nomina_d VALUES ('" + nomina_e + "','" + empleado + "','" + concepto + "'," + sueldob + "," + calculo + "," + liquido + ",'" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir el detalle de nomina: " + ex.Message);
            }

        }
        //funcion general para llenar un combo sin consultar estado
        public OdbcDataReader llenarCombo(string tabla)
        {
            string sql = "SELECT * FROM " + " " + tabla + "WHERE estado='1';";
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand datos = new OdbcCommand(sql, conect);
                OdbcDataReader leer = datos.ExecuteReader();
                cn.desconexion(conect);
                return leer;                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string optnerIDEmpleado(string nombre)
        {
            string dta = "";
            try
            {
                string querydimensionale = "SELECT pkIdEmpleado from empleado where nombre= '" + nombre + "' and estado= '1';";
                DataTable dtConceptos = PasarCalculoTabla(querydimensionale);
                dta = string.Join(Environment.NewLine, dtConceptos.Rows.OfType<DataRow>().Select(l => string.Join(" ; ", l.ItemArray)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }
            return (dta);
        }
        public OdbcDataAdapter consultarPeriodo(string fechainicio, string fechafin)
        {
            string QueryEncabezado = "SELECT * FROM nomina_e WHERE fechainicialn = '" + fechainicio + "' AND fechafinaln = '" + fechafin + "';";
            // inicia la busqueda
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(QueryEncabezado, conect);
            cn.desconexion(conect);
            return dataTable;
        }
        public DataTable consultarDetalles(string idnomina)
        {
            DataTable tabla = new DataTable();
            try
            {
                string QueryDetalle = "SELECT * FROM nomina_d WHERE codigonominae = '" + idnomina + "';";
                tabla = PasarCalculoTabla(QueryDetalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }
            return tabla;

        }

        //Fin Generacion Nomina
    }
}
