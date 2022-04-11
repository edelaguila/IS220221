using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloRRHH;
using System.Data;
using System.Data.Odbc;


namespace CapaControladorRRHH
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        //Danny Saldaña 0901-18-18686
        public DataTable UnicamentellenarTbl(string tabla2)
        {
            OdbcDataAdapter dt = sn.UnicamentellenarTbl(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Danny Saldaña 0901-18-18686
        public DataTable UnicamentellenarTblPersonal(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.UnicamentellenarTblPersonal(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable UnicamentellenarNombre(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.UnicamentellenarNombre(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public void Unicamenteagregar(string tabla3, string valor1, string valor2)
        {
            sn.Unicamenteagregar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void Unicamenteeliminar(string tabla3, string valor1, string valor2)
        {
            sn.Unicamenteeliminar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void UnicamenteUnicamenteeliminartodo(string tabla3, string valor1)
        {
            sn.Unicamenteeliminartodo(tabla3, valor1);
        }
        //Danny Saldaña 0901-18-18686
        public void UnicamenteUnicamenteagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.Unicamenteagregartodo(tabla3, valor1, valor2, tabla2);
        }

        //Primer consulta de todos los registros del historial ISR
        public DataTable llenarDGVTodosReg()//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVTodosReg();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Segunda consulta de todos los registros del historial ISR por año
        public DataTable llenarDGVRegMes(string anio)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVRegMes(anio);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Tercer consulta de todos los registros del historial ISR por mes
        public DataTable llenarDGVTodosRegAnio(string anio)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVTodosRegAnio(anio);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Cuarta consulta de todos los registros detalles del historial ISR por ID Registrado
        public DataTable llenarDGVRegDetalle(string Id)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = sn.llenarDGVRegDetalle(Id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Danny Saldaña 0901-18-18686
        public DataTable ExceptollenarTbl(string tabla2)
        {
            OdbcDataAdapter dt = sn.ExceptollenarTbl(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Danny Saldaña 0901-18-18686
        public DataTable ExceptollenarTblPersonal(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.ExceptollenarTblPersonal(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable ExceptollenarNombre(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.ExceptollenarNombre(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public void Exceptoagregar(string tabla3, string valor1, string valor2)
        {
            sn.Exceptoagregar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void Exceptoeliminar(string tabla3, string valor1, string valor2)
        {
            sn.Exceptoeliminar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void ExceptoExceptoeliminartodo(string tabla3, string valor1)
        {
            sn.Exceptoeliminartodo(tabla3, valor1);
        }
        //Danny Saldaña 0901-18-18686
        public void Exceptoagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.Exceptoagregartodo(tabla3, valor1, valor2, tabla2);
        }

       











        public DataTable FormulasLlenarComboTablas()
        {
            OdbcDataAdapter dt = sn.FormulasLlenarComboTablas();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable FormulasLlenarComboCampos(String tabla)
        {
            OdbcDataAdapter dt = sn.FormulasLlenarComboCampos(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable FormulasTodosLosConceptos()
        {
            OdbcDataAdapter dt = sn.FormulasTodosLosConceptos();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void FormulasAsignarConcepto(string formula, string pkIdConcepto)
        {
            sn.FormulasAsignarConcepto(formula, pkIdConcepto);
        }







        public void GuradarSentenciaSql(string valor1, string valor2)
        {
            sn.GuradarSentenciaSql(valor1, valor2);
        }

        //Heydi Quemé 9959-18-5335
        public void generarNomina(string fechaInicio, string fechaFin)
        {
            sn.generarNomina(fechaInicio, fechaFin);
        }
    }
}
