﻿using CapaControladorSeguridadHSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitacoraUsuario;
using static datosUsuario;

namespace CapaVistaSeguridadHSC
{
    public partial class frmMantenimientoUsuario : Form
    {
        public frmMantenimientoUsuario()
        {
            InitializeComponent();
            //TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "usuario", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);
            // navegador1.funLlenarComboControl(cbxCodMarca, "marcaP", "idMarca", "nombre", "estatus");

            //inicio de elementos para dar de baja
            navegador1.campoEstado = "Estado";
            //fin de elementos para dar de baja

            /* Inicio ID Aplicacion usada para reportes y ayudas */
            navegador1.idAplicacion = "1002";
            /* Inicio ID Aplicacion usada para reportes y ayudas */

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda


            // Inicio datos para ejecurar reportes
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes

            navegador1.pideGrid(this.dtgUsuarios);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            //String cadena = txtprueba.Text;
            //navegador1.pruebaMensaje(cadena);
        }

        private void labelClientes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labeldireccioncliente_Click(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void labelnombrecliente_Click(object sender, EventArgs e)
        {

        }

        private void labelapellidocliente_Click(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = false;
            txtConfirmar.UseSystemPasswordChar = false;
            btnPassword.Visible = false;
            btnPasswordn.Visible = true;
        }

        private void btnPasswordn_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;
            btnPassword.Visible = true;
            btnPasswordn.Visible = false;
        }
        private void validarcontraseña()
        {
            Controlador s = new Controlador();
            Encriptar a = new Encriptar();
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0002", "Registrar");
            string hash = a.funcEncryptString(key, txtClave.Text);
            txtContraseña.Text = hash.ToString();
        }
        private void comparaconteraseña()
        {
            if(txtClave.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                txtClave.Text = "";txtConfirmar.Text = "";
                txtClave.Focus();
            }
         
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            comparaconteraseña();
        }

        private void rbnActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbnHabilitado, "1");
        }

        private void rbnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbnInhabilitado, "0");
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rbnHabilitado, rbnInhabilitado, txtEstatus);
        }
    }
}
