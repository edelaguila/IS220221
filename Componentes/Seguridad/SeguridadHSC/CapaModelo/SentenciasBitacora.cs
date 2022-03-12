using System.Data.Odbc;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CapaModeloSeguridadHSC
{
    public class SentenciasBitacora
    {
        public int pkId { get; set; }
        public int fkIdUsuario { get; set; }
        public string host { get; set; }
        public string ip { get; set; }
        public int fkIdModulo { get; set; }
        public int fkIdAplicacion { get; set; }
        public string accion { get; set; }
        public DateTime conexionFecha { get; set; }
        public TimeSpan conexionHora { get; set; }

        public SentenciasBitacora()
        {
            DateTime fecha = DateTime.Now;
            string fechaconHora = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaSolita = fecha.ToString("yyyy-MM-dd");
            DateTime fechaNueva = DateTime.Parse(fechaconHora);
            conexionFecha = DateTime.Parse(fechaSolita);
            conexionHora = new TimeSpan(fechaNueva.Hour, fechaNueva.Minute, fechaNueva.Second);
        }

        Conexion ODBC = new Conexion();

        /// MELANIE REVOLORIO
        /// <summary>
        /// Metodo que almacena en la base de datos el registro para la bitácora
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <param name="IdModulo"></param>
        /// <param name="IdAplicacion"></param>
        /// <param name="accion"></param>
        public void guardarEnBitacora(string IdUsuario, string IdModulo, string IdAplicacion, string accion)
        {
            string host = Dns.GetHostName();
            string ip = "";
            IPAddress[] hostIPs = Dns.GetHostAddresses(host);
            for (int i = 0; i < hostIPs.Length; i++)
            {
                ip = hostIPs[i].ToString();
            }

            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO bitacorausuario (pkId, host, ip, conexionFecha, conexionHora, fkIdUsuario, fkIdAplicacion, accion, fkIdModulo) " +
                "VALUES (NULL, ?host?, ?ip?, ?conexionFecha?, ?conexionHora?, ?fkIdUsuario?, ?fkIdAplicacion?, ?accion?, ?fkIdModulo?);";
                var ValorDeVariables = new
                {
                    host = host,
                    ip = ip,
                    conexionFecha = conexionFecha,
                    conexionHora = conexionHora,
                    fkIdUsuario = IdUsuario,
                    fkIdAplicacion = IdAplicacion,
                    accion = accion,
                    fkIdModulo = IdModulo
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.desconexion(conexionODBC);
            }
        }

        /// JORGE GONZÁLEZ
        /// <summary>
        /// Método que obtiene el ID del Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public string obtenerIdDeUsuario(string nombre)
        {

            string res = "";
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT pkId FROM usuario WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.desconexion(conexionODBC);
            }
            return res;
        }
        public string obtenerIdDeAplicacion(string nombre)
        {

            string res = "";
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT pkId FROM aplicacion WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.desconexion(conexionODBC);
            }
            return res;
        }

        public string obtenerIdDeModulo(string nombre)
        {

            string res = "";
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT fkIdModulo FROM aplicacion WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.desconexion(conexionODBC);
            }
            return res;
        }

        /// MELANIE REVOLORIO
        /// <summary>
        /// Obtiene todos los datos de la Bitácora 
        /// </summary>
        /// <returns></returns>
        public List<ViewModelBitacora.ViewModelBitacora> leerBitacora()
        {
            List<ViewModelBitacora.ViewModelBitacora> sqlresultado = new List<ViewModelBitacora.ViewModelBitacora>();
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT A.pkId, B.nombre AS usuario, A.host, A.ip, D.nombre AS modulo, C.nombre AS aplicacion, A.accion AS accion, A.conexionFecha, A.conexionHora FROM bitacorausuario A JOIN usuario B ON A.fkIdUsuario = B.pkId JOIN aplicacion C ON A.fkIdAplicacion = C.pkId JOIN modulo D ON A.fkIdModulo = D.pkId;";
                sqlresultado = conexionODBC.Query<ViewModelBitacora.ViewModelBitacora>(sqlconsulta).ToList();
                ODBC.desconexion(conexionODBC);
            }
            return sqlresultado;
        }

    }
}

