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
            string sql = "select empleado.nombre from empleado_concepto,empleado where fkIdConcepto = " + idConcepto + " and pkIdEmpleado=fkIdEmpleado and fkIdEmpleado NOT IN(SELECT fkIdEmpleado FROM saldosporempleados where fkIdConcepto = " + idConcepto+ ") order by fkIdEmpleado;";
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
                    MessageBox.Show("Guradado exitoso");
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
                    MessageBox.Show("Guradado exitoso");
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

    }
}
