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

    }
}
