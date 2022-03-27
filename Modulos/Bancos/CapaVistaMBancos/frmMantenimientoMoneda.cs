﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmMantenimientoMoneda : Form
    {
        public frmMantenimientoMoneda()
        {
            InitializeComponent();

            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "moneda", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);

            navegador1.ObtenerNombreDGV(this.dvgConsulta);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);
            //inicio de elementos para dar de baja
            navegador1.campoEstado = "Estado_Moneda";
            //fin de elementos para dar de baja

            /* Inicio ID Aplicacion usada para reportes y ayudas */
            navegador1.idAplicacion = "1002";
            /* Inicio ID Aplicacion usada para reportes y ayudas */

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda


            // Inicio datos para ejecurar reportes
            navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes

            navegador1.ObtenerNombreDGV(this.dvgConsulta);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);

        }

        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dvgConsulta);
        }
    }
}
