﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using static datosUsuario;

namespace CapaVistaRRHH
{
    public partial class frmMDIRRHH : Form
    {
        CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
        public frmMDIRRHH()
        {
            InitializeComponent();
        }

        private void frmMDIRRHH_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            { this.Close(); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados form3 = new frmEmpleados();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepartamentos form3 = new frmDepartamentos();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPuesto form3 = new frmPuesto();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoDeFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoFalta form3 = new frmTipoFalta();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpresas form3 = new frmEmpresas();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursales form3 = new frmSucursales();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmConceptos form3 = new frmConceptos();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCuentasContables form3 = new frmCuentasContables();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
    }
    }
    

