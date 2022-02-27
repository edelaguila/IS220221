using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using static datosUsuario;

//Forma Creada por Sebastián Moreira 9959-18-7960
namespace CapaVistaSeguridadHSC
{
    public partial class frmMantenimientoAplicacion : Form
    {
        Controlador conAplicacion = new Controlador();
        Bitacora loggear = new Bitacora();
        public frmMantenimientoAplicacion()
        {
            InitializeComponent();
            CenterToScreen();
            llenarcbxAplicacion();

            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "aplicacion", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);

            navegador1.ObtenerNombreDGV(this.dvgConsulta);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);
            //String cadena = txtprueba.Text;
            //navegador1.pruebaMensaje(cadena);

            // Actualizacion de Permisos, Liam Patrick Bernard García - 0901-18-10092
            navegador1.usuario = "admin";
            navegador1.aplicacion = "Mantenimiento Módulo";
            navegador1.ActualizaPermisos();
            navegador1.idmodulo = "1";
        }
        


        //Sebastián Moreira 9959-18-7960
        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }





        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = textBox4.Text.Replace("\\", "\\\\");
            textBox5.Text = textBox5.Text.Replace("\\", "\\\\");
        }
                       
        
        //Sebastián Moreira 9959-18-7960
        public void llenarcbxAplicacion()
        {
            try
            {
                cbxModulo.Items.Clear();
                OdbcDataReader datareader = conAplicacion.llenarcbxModulo();
                cbxModulo.Items.Add("Selecione un Modulo");
                while (datareader.Read())
                {
                    cbxModulo.Items.Add(datareader[0].ToString());
                }
                cbxModulo.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }




        //Sebastián Moreira 9959-18-7960
        private void button1_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    textBox4.Text = fd.SelectedPath.Replace("\\","\\\\");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //Sebastián Moreira 9959-18-7960
        private void button2_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    textBox5.Text = fd.SelectedPath.Replace("\\", "\\\\");
                }
            }
        }
        //Sebastián Moreira 9959-18-7960
        private void cbxModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               
                    textBox6.Text = consultaModulo(cbxModulo.Text.ToString());                                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
                
        //Sebastián Moreira 9959-18-7960
        public string consultaModulo(string nombre)
        {
            string id_modulo = conAplicacion.consultaModulo(nombre);

            return id_modulo;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dvgConsulta);
        }
    }




}
