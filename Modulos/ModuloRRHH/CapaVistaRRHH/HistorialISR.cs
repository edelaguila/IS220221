using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorRRHH;

namespace CapaVistaRRHH
{
    public partial class HistorialISR : Form
    {
        Controlador cont = new Controlador();
        public HistorialISR()
        {
            InitializeComponent();
            ocultar();
            habilitar();
            txtAnio.Enabled = false;
            lblRegAnio.Enabled = false;

        }

        private void rbnRegAños_CheckedChanged(object sender, EventArgs e)
        {
            txtAnio.Text = "";
            txtIdISR.Text = "";
            DataTable dt = new DataTable();
            dt.Rows.Add(dt.NewRow());
            dgvHistorialISR.DataSource = dt;
        }

        private void dgvHistorialISR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbnTodosReg.Checked)
            {
                //Primer consulta de todos los registros del historial ISR
                DataTable dt = cont.llenarDGVTodosReg();
                dgvHistorialISR.DataSource = dt;

            } 
            else if (rbnRegAnios.Checked && txtAnio.Text != null){
                //Segunda consulta de todos los registros del historial ISR por año
                string anio = Convert.ToString(txtAnio.Text);
                DataTable dt = cont.llenarDGVTodosRegAnio(anio);
                dgvHistorialISR.DataSource = dt;

            }

            //Tercera consulta por mes
            if (ckbEnero.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbFebrero.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbMarzo.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbAbril.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbMayo.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbJunio.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbJulio.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbAgosto.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbSeptiembre.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbOctubre.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbNoviembre.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if (ckbDiciembre.Checked && rbnRegMes.Checked)
            {
                string mes = Convert.ToString(txtMes.Text);
                DataTable dt = cont.llenarDGVRegMes(mes);
                dgvHistorialISR.DataSource = dt;
            }
            else if(rbnRegMes.Checked)
            {
                    MessageBox.Show("Seleccione el mes que desea consultar");    
            }

            //Cuarta consulta para los detalles de los registro
            if (rbnDetalleReg.Checked)
            {
                string Id = Convert.ToString(txtIdISR.Text);
                DataTable dt = cont.llenarDGVRegDetalle(Id);
                dgvHistorialISR.DataSource = dt;

            }

        }

        private void dgvHistorialISR_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void HistorialISR_Load(object sender, EventArgs e)
        {

        }

        public void ocultar() {

            btnHabilitar.Visible = false;
            ckbEnero.Visible = false;
            ckbFebrero.Visible = false;
            ckbMarzo.Visible = false;
            ckbAbril.Visible = false;
            ckbMayo.Visible = false;
            ckbJunio.Visible = false;
            ckbJulio.Visible = false;
            ckbAgosto.Visible = false;
            ckbSeptiembre.Visible = false;
            ckbOctubre.Visible = false;
            ckbNoviembre.Visible = false;
            ckbDiciembre.Visible = false;

        }

        public void mostrar()
        {
            btnHabilitar.Visible = true;
            ckbEnero.Visible = true;
            ckbFebrero.Visible = true;
            ckbMarzo.Visible = true;
            ckbAbril.Visible = true;
            ckbMayo.Visible = true;
            ckbJunio.Visible = true;
            ckbJulio.Visible = true;
            ckbAgosto.Visible = true;
            ckbSeptiembre.Visible = true;
            ckbOctubre.Visible = true;
            ckbNoviembre.Visible = true;
            ckbDiciembre.Visible = true;

        }

        private void ckbEnero_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEnero.Checked)
            {
                txtMes.Text = "01";

                ckbEnero.Enabled = true;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }


        public void habilitar()
        {

            ckbEnero.Enabled = true;
            ckbFebrero.Enabled = true;
            ckbMarzo.Enabled = true;
            ckbAbril.Enabled = true;
            ckbMayo.Enabled = true;
            ckbJunio.Enabled = true;
            ckbJulio.Enabled = true;
            ckbAgosto.Enabled = true;
            ckbSeptiembre.Enabled = true;
            ckbOctubre.Enabled = true;
            ckbNoviembre.Enabled = true;
            ckbDiciembre.Enabled = true;

        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbnRegMes_CheckedChanged(object sender, EventArgs e)
        {
            txtAnio.Text = "";
            txtIdISR.Text = "";
            if (rbnRegMes.Checked)
            {
                mostrar();
            }
            else
            {
                ocultar();
                DataTable dt = new DataTable();
                dt.Rows.Add(dt.NewRow());
                dgvHistorialISR.DataSource = dt;
            }
        }

        private void rbnRegAnios_CheckedChanged(object sender, EventArgs e)
        {
            txtAnio.Enabled = true;
            lblRegAnio.Enabled = true;
            DataTable dt = new DataTable();
            dt.Rows.Add(dt.NewRow());
            dgvHistorialISR.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtAnio.Text = "";
        }

        private void ckbFebrero_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFebrero.Checked)
            {

                txtMes.Text = "02";


                ckbFebrero.Enabled = true;
                ckbEnero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            habilitar();
            DataTable dt = new DataTable();
            dt.Rows.Add(dt.NewRow());
            dgvHistorialISR.DataSource = dt;
            txtMes.Text = "";
            ckbEnero.Checked = false;            
            ckbFebrero.Checked = false;
            ckbMarzo.Checked = false;
            ckbAbril.Checked = false;
            ckbMayo.Checked = false;
            ckbJunio.Checked = false;
            ckbJulio.Checked = false;
            ckbAgosto.Checked = false;
            ckbSeptiembre.Checked = false;
            ckbOctubre.Checked = false;
            ckbNoviembre.Checked = false;
            ckbDiciembre.Checked = false;
        }

        private void ckbMarzo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMarzo.Checked)
            {

                txtMes.Text = "03";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = true;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbAbril_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAbril.Checked)
            {

                txtMes.Text = "04";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = true;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMayo.Checked)
            {

                txtMes.Text = "05";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = true;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbJunio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbJunio.Checked)
            {

                txtMes.Text = "06";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = true;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbJulio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbJulio.Checked)
            {

                txtMes.Text = "07";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = true;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbAgosto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAgosto.Checked)
            {

                txtMes.Text = "08";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = true;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbSeptiembre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSeptiembre.Checked)
            {

                txtMes.Text = "09";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = true;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbOctubre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOctubre.Checked)
            {

                txtMes.Text = "10";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = true;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbNoviembre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNoviembre.Checked)
            {

                txtMes.Text = "11";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = true;
                ckbDiciembre.Enabled = false;

            }
        }

        private void ckbDiciembre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDiciembre.Checked)
            {

                txtMes.Text = "12";

                ckbEnero.Enabled = false;
                ckbFebrero.Enabled = false;
                ckbMarzo.Enabled = false;
                ckbAbril.Enabled = false;
                ckbMayo.Enabled = false;
                ckbJunio.Enabled = false;
                ckbJulio.Enabled = false;
                ckbAgosto.Enabled = false;
                ckbSeptiembre.Enabled = false;
                ckbOctubre.Enabled = false;
                ckbNoviembre.Enabled = false;
                ckbDiciembre.Enabled = true;

            }
        }
    }
}
