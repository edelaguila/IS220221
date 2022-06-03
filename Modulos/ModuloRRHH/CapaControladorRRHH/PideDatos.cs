using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloRRHH;

namespace CapaControladorRRHH
{
    public class PideDatos
    {
        static string FechaF;
        static string FechaI;
        static string liquida;
        public string FechaInicio
        {
            get { return FechaI; }
            set { FechaI = value; }
        }
        public string FechaFin
        {
            get { return FechaF; }
            set { FechaF = value; }
        }
        static string PeriodoF;
        static string PeriodoI;
        public string PeriodoInicio
        {
            get { return PeriodoI; }
            set { PeriodoI = value; }
        }
        public string PeriodoFin
        {
            get { return PeriodoF; }
            set { PeriodoF = value; }
        }
        public string IdLiquidasion
        {
            get { return liquida; }
            set { liquida = value; }
        }
    }
}
