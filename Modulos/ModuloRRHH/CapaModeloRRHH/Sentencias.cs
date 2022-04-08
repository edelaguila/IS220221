using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

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
            string sql = "INSERT INTO sentenciaSqlPlanilla (fkIdConcepto, sentenciaSql) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }





    }
}
