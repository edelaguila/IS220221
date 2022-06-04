using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace CapaModeloRRHH
{
    public class Sentencias
    {
        DataTable tabla = new DataTable();
        private Conexion cn = new Conexion();

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados disponibles para asignarle al concepto
        public OdbcDataAdapter llenarTblDatosEmpleados(string IdConcepto)
        {
            //Obtiene todos los empleados
            string sql = "SELECT pkIdEmpleado, nombre FROM empleado  WHERE pkIdEmpleado NOT IN(SELECT fkIdEmpleado FROM empleado_concepto where fkIdConcepto = '" + IdConcepto + "');";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //9959-18-5201 Angel Chacón
        //Muestra todos los saldos asignados a los empleados
        public OdbcDataAdapter tblSaldoEmpleados()
        {
            //Obtiene todos los empleados
            string sql = "SELECT concepto.nombreConcepto as 'Concepto',empleado.nombre as 'Empleado',saldo,saldosporempleados.estado FROM saldosporempleados,concepto,empleado where  saldosporempleados.fkIdEmpleado=empleado.pkIdEmpleado and saldosporempleados.fkIdConcepto=concepto.pkIdConcepto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados asignados al concepto
        public OdbcDataAdapter llenarTblEmpleadosAsignadosConcepto(string tablaempleados, string IdConcepto)
        {
            //Obtiene todos los conceptos asignados a un emepleado especifico
            string sql = "SELECT empleado.pkIdEmpleado, empleado.nombre FROM " + tablaempleados + " LEFT JOIN empleado_concepto ON empleado.pkIdEmpleado = empleado_concepto.fkIdEmpleado LEFT JOIN concepto ON empleado_concepto.fkIdConcepto = concepto.pkIdConcepto WHERE concepto.pkIdConcepto = '" + IdConcepto + "' ORDER BY empleado.pkIdEmpleado;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;

        }


        //9959-18-5201 Angel Chacón
        public OdbcDataAdapter DatosConcepto(string IdConcepto)
        {
            //Obtiene todos los datos del concepto al que se le van a asignar empleados
            string sql = "SELECT * FROM concepto where pkIdConcepto='" + IdConcepto + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //9959-18-5201 Angel Chacón
        //Asinar un empleado al concepto
        public void AsignarEmpleados(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkIdConcepto, fkIdEmpleado) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        //9959-18-5201 Angel Chacón
        //Asigna todos los empleados al concepto
        public void AsignarATodosLosEmpleados(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdConcepto = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //9959-18-5201 Angel Chacón
        //Se elima a un empleado asignado al concepto
        public void EliminarUnEmpleadoAsignado(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdConcepto = '" + valor1 + "' AND  fkIdEmpleado='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //9959-18-5201 Angel Chacón
        //Se eliminan todos los empleados asignados al concepto
        public void EliminarTodasLasAsignacionesEmpleados(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkIdConcepto = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Angel Chacón 9959-18-5201
        //funcion para mostrar id en el combobox de los conceptos existentes
        public OdbcDataReader IdConcepto(string nombreA)//conexion para obtener el IdConcepto para el Combobox
        {
            string cadena = "Select pkIdConcepto from concepto where nombreConcepto = '" + nombreA + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }

        //Angel Chacón 9959-18-5201
        //funcion para mostrar id en el combobox de los empleados existentes
        public OdbcDataReader IdEmpleado(string nombreE)//conexion para obtener el IdConcepto para el Combobox
        {
            string cadena = "select pkIdEmpleado from empleado where nombre =  '" + nombreE + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }

        //9959-18-5201 Angel Chacón
        //Función para obtener el nombre de los conceptos creados en el combobox
        public OdbcDataReader llenarcbxConcepto()
        {
            string sql = "SELECT nombreConcepto FROM hotelsancarlos.concepto;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //9959-18-5201 Angel Chacón
        //Muestra todos los empleados que no tengan asignado un monto o saldo
        public OdbcDataReader llenarcbxEmpleados(string idConcepto)
        {
            string sql = "select empleado.nombre from empleado_concepto,empleado where fkIdConcepto = " + idConcepto + " and pkIdEmpleado=fkIdEmpleado and fkIdEmpleado NOT IN(SELECT fkIdEmpleado FROM saldosporempleados where fkIdConcepto = " + idConcepto + ") order by fkIdEmpleado;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
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
        //9959-18-5201 Angel Chacón
        //Cuarta consulta de todos los registros detalles del historial ISR por ID Registrado
        public OdbcDataAdapter llenarDGVRegDetalle(string Id)// metodo  que obtinene el contenio de una tabla en la BD
        {
            string sql = "select isrencabezado.pkIdISR,isrencabezado.periodoInicio,isrencabezado.periodoFinal,isrdetalle.fkIdEmpleado,empleado.nombre,isrdetalle.isrSubTotal from isrdetalle,isrencabezado,empleado where isrencabezado.pkIdISR=isrdetalle.fkIdISR and empleado.pkIdEmpleado = isrdetalle.fkIdEmpleado and isrencabezado.pkIdISR='" + Id + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;

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

                string sqlBorrar = "DELETE FROM sentenciasqlplanilla WHERE fkIdConcepto = '" + valor1 + "';";
                OdbcCommand consultaBorrar = new OdbcCommand(sqlBorrar, cn.conexion());
                consultaBorrar.ExecuteNonQuery();
                string sql = "INSERT INTO sentenciaSqlPlanilla (fkIdConcepto, sentenciaSql) Values( '" + valor1 + "', '" + valor2 + "');";
                OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
                consulta.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }

        public void GuradarFormula(string valor1, string valor2)
        {
            try
            {

                string sqlBorrar = "DELETE FROM formula WHERE fkIdConcepto = '" + valor1 + "';";
                OdbcCommand consultaBorrar = new OdbcCommand(sqlBorrar, cn.conexion());
                consultaBorrar.ExecuteNonQuery();
                string sql = "INSERT INTO formula (pkIdFormula, valorFormula, estado) Values( '" + valor1 + "', '" + valor2 + "','1');";
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
        public DataTable calculoConceptoSentencias(int idConcepto, int idEmpleado, string IdPeriodo)
        {

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
                string sentenciaReplace2;
                string sentenciafinal = "";
                string idperiodoingreso = "'" + IdPeriodo.ToString() + "'";
                sentenciafinal = sentenciaReplace;

                if (sentenciaReplace.Contains("+ condicion2 +") == true)
                {
                    sentenciaReplace2 = sentenciaReplace.Replace("+ condicion2 +", idperiodoingreso);
                    sentenciafinal = sentenciaReplace2;
                }
                //sentenciafinal = sentenciaReplace + ";";
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
        public Boolean valorUnico(int idConcepto, int idEmpleado, string IdPeriodo)
        {

            //SE SELECCIONAN LAS FORMULAS RELACIONADAS CON LOS CONCEPTOS
            Boolean respuesta = false; string sql = "";
            string Query2 = "SELECT * FROM saldosporempleados WHERE fkIdConcepto='" + idConcepto + "'" + " AND fkIdEmpleado='" + idEmpleado + "';";
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta2 = new OdbcCommand(Query2, conect);
                consulta2.ExecuteNonQuery();
                OdbcDataReader busqueda2;
                busqueda2 = consulta2.ExecuteReader();
                if (busqueda2.Read())
                {
                    sql = busqueda2["fkidconcepto"].ToString();
                }
                cn.desconexion(conect);
                if (sql == "")
                {
                    respuesta = false;
                }
                else
                {
                    respuesta = true;
                }
            }
            catch (Exception)
            {
            }
            return respuesta;
        }

        public DataTable calculoValorUnicoSentencias(int idConcepto, int idEmpleado, string IdPeriodo)
        {
            string sql = "";
            try
            {
                //SE SELECCIONAN LAS FORMULAS RELACIONADAS CON LOS CONCEPTOS
                string Query2 = "SELECT saldo FROM saldosporempleados WHERE fkIdConcepto='" + idConcepto + "'" + " AND fkIdEmpleado='" + idEmpleado + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta2 = new OdbcCommand(Query2, conect);
                consulta2.ExecuteNonQuery(); OdbcDataReader busqueda2;
                busqueda2 = consulta2.ExecuteReader();
                if (busqueda2.Read())
                {
                    sql = busqueda2["saldo"].ToString();
                }
                cn.desconexion(conect);
                //SE ENVIA COMO QUERY LA FORMULA DEL CONCEPTO
                try
                {
                    // MessageBox.Show(Query2 + "   " + sql);
                    tabla = PasarCalculoTabla(Query2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en Asignación:" + ex);
                }

            }
            catch (Exception ex) { MessageBox.Show("Error en obtener encabezado Nomina capa Controlador " + ex); }
            return (tabla);
        }
        public DataTable calculoConceptoSentenciasFinal(int idConcepto, int idEmpleado, string IdPeriodo)
        {
            Boolean valor = valorUnico(idConcepto, idEmpleado, IdPeriodo);
            DataTable tabla = new DataTable();
            if (valor == true)
            {
                tabla = calculoValorUnicoSentencias(idConcepto, idEmpleado, IdPeriodo);
            }
            else if (valor == false)
            {
                tabla = calculoConceptoSentencias(idConcepto, idEmpleado, IdPeriodo);
            }
            return tabla;
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
                string QueryDetalle = "select nomina_d.CodigoNominaE, nomina_d.pkIdEmpleado, empleado.nombre, empleado.apellido, nomina_d.pkIdConcepto, concepto.nombreConcepto,nomina_d.SueldoBase, nomina_d.CalculoConcepto, nomina_d.SueldoLiquido, nomina_d.estado " +
                                      "from((nomina_d " +
                                      "inner join empleado on nomina_d.pkIdEmpleado = empleado.pkIdEmpleado) " +
                                      "inner join concepto on nomina_d.pkIdConcepto = concepto.pkIdConcepto) where nomina_d.CodigoNominaE ='"+idnomina+"' order by nomina_d.pkIdEmpleado;";
                tabla = PasarCalculoTabla(QueryDetalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }
            return tabla;
        }

        //Fin Generacion Nomina

        //Foto Empleado Heydi Quemé 9959-18-5335 Kevin Flores 9959-18-17632
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "INSERT INTO foto VALUES ('" + id + "',?);";
                OdbcConnection conect = cn.conexion(); //conect.Open();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                OdbcParameter prm = new OdbcParameter("@img", OdbcType.Binary, foto.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, foto);
                command.Parameters.Add(prm);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Guardado exitoso");
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar imagen" + ex);
            }
        }
        public void insertaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "UPDATE foto SET fotografia=? where pkId='" + id + "';";
                OdbcConnection conect = cn.conexion(); //conect.Open();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                OdbcParameter prm = new OdbcParameter("@img", OdbcType.Binary, foto.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, foto);
                command.Parameters.Add(prm);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Guardado exitoso");
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar imagen" + ex);
            }
        }
        public byte[] obtenerByte(string id)
        {
            int bufferSize = 100; byte[] bytefoto = new byte[bufferSize];
            byte[] binary = null;
            try
            {
                string insertQuery = "SELECT * FROM foto WHERE pkId ='" + id + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    throw new Exception("No hay fotografia guardada.");
                }
                if (busquedac.Read())
                {
                    binary = (byte[])busquedac["fotografia"];
                }
                cn.desconexion(conect);
                return binary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen" + ex);
                return null;
            }

        }
        //HEYDI QUEME FRMVACACIONES
        public OdbcDataAdapter llenarDGVDisponibles(string IdVacaciones)
        {
            //Obtiene todos los empleados
            string sql = "SELECT pkIdEmpleado, nombre FROM empleado  WHERE pkIdEmpleado NOT IN(SELECT empleado FROM vacaciones_d where vacaciones_e = '" + IdVacaciones + "');";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void guardarVacacionesEncabezado(string tabla, string id, string periodo, string estado)
        {
            try
            {
                string cadena = "INSERT INTO " + tabla + " VALUES ('" + id + "','" + periodo + "','" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir vacaciones: " + ex.Message);
            }
        }

        public void AsignarVacaciones(string tabla, string id, string valor2, string diasd, string diasg, string Estado)
        {
            string sql = "INSERT INTO " + tabla + " Values( '" + id + "', '" + valor2 + "','" + diasd + "','" + diasg + "','" + Estado + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public OdbcDataAdapter llenarDGVAsignados(string IdPeriodo)
        {
            //Obtiene todos los empleados
            string sql = "SELECT pkIdEmpleado, nombre FROM empleado  WHERE pkIdEmpleado IN(SELECT empleado FROM vacaciones_d where vacaciones_e = '" + IdPeriodo + "');";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public void limpiarRegistros(string tabla, string encabezado)
        {
            string sql = "DELETE FROM " + tabla + " WHERE vacaciones_e = '" + encabezado + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public Boolean ComprobarEncabezado(string tabla, string encabezado, string periodo)
        {
            string sql = "SELECT * FROM " + tabla + " WHERE vacaciones_e = '" + encabezado + "' AND periodo = '" + periodo + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
            Boolean existente = false;
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                existente = true;
            }
            else
            {
                existente = false;
            }
            return existente;
        }

        public void eliminarRegistroVacaciones(string tabla, string id, string empleado)
        {
            string sql = "DELETE FROM " + tabla + " WHERE vacaciones_e ='" + id + "' AND empleado ='" + empleado + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public Boolean ComprobarDetalles(string tabla, string encabezado)
        {
            string sql = "SELECT * FROM " + tabla + " WHERE vacaciones_e = '" + encabezado + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
            Boolean existente = false;
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                existente = true;
            }
            else
            {
                existente = false;
            }
            return existente;
        }

        public void eliminarEncabezado(string tabla, string id, string periodo)
        {
            string sql = "DELETE FROM " + tabla + " WHERE vacaciones_e ='" + id + "' AND periodo ='" + periodo + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarDGVRegistrados()
        {
            //Obtiene todos los empleados
            string sql = "SELECT vacaciones_e.vacaciones_e, periodo.nombre, vacaciones_e.estado from vacaciones_e inner join periodo where vacaciones_e.periodo = periodo.pkid and periodo.estado='1' and vacaciones_e.estado='1';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataReader llenarcbxPeriodo()
        {
            string sql = "select periodo.nombre from periodo inner join vacaciones_e where vacaciones_e.periodo = periodo.pkId;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader IdPeriodo(string nombreA)//conexion para obtener el IdConcepto para el Combobox
        {
            string cadena = "Select pkid from periodo where nombre = '" + nombreA + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }
        public OdbcDataReader IdEncabezado(string nombreA)//conexion para obtener el IdConcepto para el Combobox
        {
            string cadena = "Select vacaciones_e from hotelsancarlos.vacaciones_e where periodo = '" + nombreA + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }
        public OdbcDataAdapter llenarDGVSeleccion(string IdPeriodo)
        {
            //Obtiene todos los empleados
            string sql = "SELECT empleado.pkIdEmpleado, empleado.nombre, vacaciones_d.diasdisponibles, vacaciones_d.diasgozados FROM empleado INNER JOIN vacaciones_d ON empleado.pkidempleado = vacaciones_d.empleado WHERE vacaciones_d.diasdisponibles != 0 AND vacaciones_e IN(SELECT vacaciones_e.vacaciones_e FROM hotelsancarlos.vacaciones_e INNER JOIN vacaciones_d WHERE vacaciones_e.vacaciones_e = vacaciones_d.vacaciones_e AND vacaciones_e.periodo = '" + IdPeriodo + "') ORDER BY pkidempleado;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public void ModificarVacaciones(string encabezado, string celdas, string dias)
        {
            string sql = "UPDATE vacaciones_d SET diasdisponibles = diasdisponibles -" + dias + ", diasgozados = diasgozados +" + dias + " WHERE empleado= '" + celdas + "' AND vacaciones_e = '" + encabezado + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public OdbcDataAdapter ConsultaTablasPoliza1(string id, string fecha)
        {
            //Suma total de cada concepto
            string sql = "SELECT cuentascontables.nomenclatura FROM nomina_d INNER JOIN nomina_e ON nomina_d.CodigoNominaE = nomina_e.CodigoNominaE INNER JOIN concepto  ON nomina_d.pkIdConcepto = concepto.pkIdConcepto INNER JOIN cuentascontables  ON concepto.fkCuentaContable = cuentascontables.pkId WHERE concepto.pkIdConcepto='" + id + "'AND nomina_e.FechaFinalN='"+ fecha +"' GROUP by cuentascontables.pkId ORDER BY cuentascontables.efecto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ConsultaTablasPoliza2(string id, string fecha)
        {
            //Suma total de cada concepto
            string sql = "SELECT SUM(CalculoConcepto) FROM nomina_d INNER JOIN nomina_e ON nomina_d.CodigoNominaE = nomina_e.CodigoNominaE INNER JOIN concepto  ON nomina_d.pkIdConcepto = concepto.pkIdConcepto INNER JOIN cuentascontables  ON concepto.fkCuentaContable = cuentascontables.pkId WHERE concepto.pkIdConcepto='" + id + "' AND nomina_e.FechaFinalN='" + fecha + "' ORDER BY cuentascontables.efecto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ConsultaTablasPoliza3(string id, string fecha)
        {
            //Suma total de cada concepto
            string sql = "SELECT cuentascontables.efecto FROM nomina_d INNER JOIN nomina_e ON nomina_d.CodigoNominaE = nomina_e.CodigoNominaE INNER JOIN concepto  ON nomina_d.pkIdConcepto = concepto.pkIdConcepto INNER JOIN cuentascontables  ON concepto.fkCuentaContable = cuentascontables.pkId WHERE concepto.pkIdConcepto='" + id + "' AND nomina_e.FechaFinalN='" + fecha + "' GROUP BY cuentascontables.efecto ORDER BY cuentascontables.efecto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }


        public void Guradarpoliza(string valor1, string valor2, string valor3)
        {
            try
            {
                string sql = "INSERT INTO poliza_p (fkidCuentaContable, valor, Periodo, estado) Values( '" + valor1 + "', '" + valor2 + "','" + valor3 + "','1');";
                OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
                consulta.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }
        public void Borrarpoliza(string valor3)
        {
            try
            {

                string sqlBorrar = "DELETE FROM poliza_p WHERE Periodo = '" + valor3 + "';";
                OdbcCommand consultaBorrar = new OdbcCommand(sqlBorrar, cn.conexion());
                consultaBorrar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }



        public OdbcDataAdapter CantidadConceptosPlanilla(string id)
        {
            //Ver que conceptos se usan en la planilla
            string sql = "SELECT nomina_d.pkIdConcepto FROM nomina_d INNER JOIN nomina_e  ON nomina_d.CodigoNominaE = nomina_e.CodigoNominaE GROUP BY nomina_d.pkIdConcepto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;

        }



        public OdbcDataAdapter MostarPoliza(string id, string fecha)
        {
            //Ver que conceptos se usan en la planilla
            string sql = "SELECT cuentascontables.nomenclatura, cuentascontables.nombre, poliza_p.valor, cuentascontables.efecto  FROM poliza_p INNER JOIN cuentascontables ON poliza_p.fkidCuentaContable = cuentascontables.nomenclatura WHERE poliza_p.Periodo = '" + fecha + "' GROUP BY poliza_p.fkidCuentaContable ORDER BY cuentascontables.efecto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;

        }

        public OdbcDataAdapter ObtenerSalarioPoliza(string id, string fecha)
        {
            //Ver que conceptos se usan en la planilla
            string sql = "SELECT nomina_d.SueldoBase FROM nomina_d INNER JOIN nomina_e  ON nomina_d.CodigoNominaE = nomina_e.CodigoNominaE WHERE nomina_e.FechaFinalN='" + fecha + "' GROUP By nomina_d.pkIdEmpleado;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;

        }

        public OdbcDataAdapter obtenerCuentaPagoPlanilla()
        {
            string sql = "SELECT pago FROM poliza_Conf  WHERE pkPoliza_Conf = '1';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter obtenerGastoPlanilla()
        {
            string sql = "SELECT gasto FROM poliza_Conf  WHERE pkPoliza_Conf = '1';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter obtenerCuentaPasivoPlanilla()
        {
            string sql = "SELECT pasivo FROM poliza_Conf  WHERE pkPoliza_Conf = '1';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter obtenerSalarioPlanilla()
        {
            string sql = "SELECT salario FROM poliza_Conf  WHERE pkPoliza_Conf = '1';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void ActualizarCodigosCuentas(string valor1, string valor2, string valor3, string valor4)
        {
            string sql = "UPDATE `poliza_conf` SET `pkPoliza_Conf`='1',`pago`='" + valor1 + "',`gasto`='" + valor2 + "',`pasivo`='" + valor3 + "',`salario`='" + valor4 + "' WHERE pkPoliza_Conf = '1';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

        }



        public OdbcDataAdapter ConsultaSentenciaSql(string valor1)
        {
            string sql = "SELECT `sentenciaSql` FROM `sentenciasqlplanilla` WHERE fkIdConcepto = '" + valor1 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Liquidación empleado 

        public void formatoMoneda(TextBox txt)
        {
            if (txt.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal monto;
                monto = Convert.ToDecimal(txt.Text);
                txt.Text = monto.ToString("N2");
            }
        }
        public DataTable consultarDetallesEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            try
            {
                string QueryDetalle = "SELECT * FROM empleado WHERE pkIdEmpleado = '" + idEmpleado + "';";
                tabla = PasarCalculoTabla(QueryDetalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }
            return tabla;
        }
        public string BuscaDato(string tabla, string campo, string id, string buscarid)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + buscarid + " ='" + id + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    throw new Exception("No hay dato guardado.");
                }
                if (busquedac.Read())
                {
                    dato = busquedac[campo].ToString();
                }
                cn.desconexion(conect);
                return dato;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al optener " + dato + ".    " + ex);
                return dato;
            }
        }
        //Cálculo Indemnizacion 


        //Paso 1: Cálculo días laborados. 
        public int calculoDiasLaborados(string contratacion, string despido)
        {
            int dias = 0;
            try
            {
                DateTime fechaUno = Convert.ToDateTime(contratacion);
                DateTime fechaDos = Convert.ToDateTime(despido);
                TimeSpan difFechas = fechaDos - fechaUno;
                dias = difFechas.Days;
                return dias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular días laborados" + ex);
                return dias;
            }
        }
        public int calculoDiasLaboradosAñoCursado(string despido)
        {
            int dias = 0;
            try
            {
                DateTime fechaDos = Convert.ToDateTime(despido);
                string año = fechaDos.Year.ToString();
                DateTime fechaUno = Convert.ToDateTime(año + "-01-01");
                TimeSpan difFechas = fechaDos - fechaUno;
                dias = difFechas.Days;
                return dias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular días laborados" + ex);
                return dias;
            }
        }
        public int calculoDiasLaboradosaguinaldo(string despido)
        {
            int dias = 0;
            try
            {
                DateTime fechaDos = Convert.ToDateTime(despido);
                int año = fechaDos.Year;
                string year = (año - 1).ToString();
                DateTime fechaUno = Convert.ToDateTime(year + "-12-01");
                TimeSpan difFechas = fechaDos - fechaUno;
                dias = difFechas.Days;
                return dias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular días laborados" + ex);
                return dias;
            }
        }
        public int calculoDiasLaboradosBono14(string despido)
        {
            int dias = 0;
            try
            {
                DateTime fechaDos = Convert.ToDateTime(despido);
                int año = fechaDos.Year;
                string year = (año - 1).ToString();
                DateTime fechaUno = Convert.ToDateTime(year + "-07-01");
                TimeSpan difFechas = fechaDos - fechaUno;
                dias = difFechas.Days;
                return dias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular días laborados" + ex);
                return dias;
            }
        }
        public int calculoDiasBonoIncentivo(string despido)
        {
            int dia = 0;
            try
            {
                DateTime fechaDos = Convert.ToDateTime(despido);
                dia = fechaDos.Day;
                return dia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular días laborados" + ex);
                return dia;
            }
        }
        public void GuardarEncabezadoLiquidacion(string tabla,string id, string fecha, string estado)
        {
            try
            {
                string cadena = "INSERT INTO " + tabla + " VALUES ('" + id + "','" + fecha+ "','" + estado + "');";
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta = new OdbcCommand(cadena, conect);
                consulta.ExecuteNonQuery();
                cn.desconexion(conect);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir liquidación: " + ex.Message);
            }
        }
        public void guardarLiquidacionDetalleBD(string tabla,string liquidacion_e, string empleado, double sueldo, string UltimasVacaciones, double salarioPromedio, double bonificacionIncentivo,double horaextra, string observaciones, double indeminizacion,double aguinaldoT,double bono14T, double bonificacionT, double vacacionesT, double comisionesT,double horasExtraT,double totalPercibido)
        {
            try
            {
                string cadena = "INSERT INTO "+tabla+" VALUES ('" + liquidacion_e + "','" + empleado + "','" + sueldo + "','" + UltimasVacaciones + "','" + salarioPromedio + "','" + bonificacionIncentivo  +"','" + horaextra + "','" + observaciones + "','" + aguinaldoT+"','" + aguinaldoT + "','" + bono14T + "','" + bonificacionT + "','"+ vacacionesT + "','"+ comisionesT + "','" + horasExtraT  + "','" + totalPercibido + "');";
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta = new OdbcCommand(cadena, conect);
                consulta.ExecuteNonQuery();
                cn.desconexion(conect);MessageBox.Show("Guardado con éxito.");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir el detalle de nomina: " + ex.Message);
            }
        }
        public DataTable llenalistaliquidacion()
        {
            DataTable tabla = new DataTable();
            try
            {
                string QueryDetalle = "select liquidacion_d.fkLiquidacion_e, empleado.nombre, empleado.apellido,liquidacion_e.fecha "
                + "from((liquidacion_d "
                + "inner join  empleado on liquidacion_d.fkIdEmpleado = empleado.pkIdEmpleado) "
                + "inner join liquidacion_e on liquidacion_d.fkLiquidacion_e = liquidacion_e.pkid); ";                    
                tabla = PasarCalculoTabla(QueryDetalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar Liquidaciones:" + ex);
            }
            return tabla;
        }
        public DataTable consultarDetallesliquidacion(string idliquidacion)
        {
            DataTable tabla = new DataTable();
            try
            {
                string QueryDetalle = "SELECT * FROM liquidacion_d WHERE fkLiquidacion_e = '" + idliquidacion + "';";
                tabla = PasarCalculoTabla(QueryDetalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar conceptos:" + ex);
            }
            return tabla;
        }
    }
}
