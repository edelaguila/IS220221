
using CapaControladorRRHH;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Danny Saldaña 0901-18-18686
namespace CapaVistaRRHH
{
    public partial class frmUnicamente : Form
    {
        private Controlador cn = new Controlador();
        

        public frmUnicamente()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //Mostrar los datos CAPA VISTA
        private string tabla = "empleado";

        private string tabla2 = "concepto";
        private string tabla3 = "detalle_personalizado_unicamente";
        //Danny Saldaña 0901-18-18686
        public void actualizardatagriew()
        {
            DataTable dt = cn.UnicamentellenarTbl(tabla2);
            dtgConsulta.DataSource = dt;
        }
        //Danny Saldaña 0901-18-18686
        public void actualizardatagriewpersonal()
        {
            string condicion = textBox1.Text;
            DataTable dt = cn.UnicamentellenarTblPersonal(tabla2, condicion);
            dataGridView1.DataSource = dt;
        }
        //Danny Saldaña 0901-18-18686
        public void UnicamentellenarNombre()
        {
            string condicion = textBox1.Text;
            DataTable dt = cn.UnicamentellenarNombre(tabla, condicion);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox2.Text = dta;
        }
        //Danny Saldaña 0901-18-18686
        private void button1_Click(object sender, EventArgs e)
        {
            //Jorge González 0901-18-3920
            

            //
            string condicion = textBox1.Text;
            actualizardatagriew();
            UnicamentellenarNombre();
            actualizardatagriewpersonal();
        }
        //Danny Saldaña 0901-18-18686
        private void dtgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dtgConsulta.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void fmConsulta_Load(object sender, EventArgs e)
        {
        }
        //Danny Saldaña 0901-18-18686
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = dtgConsulta.CurrentRow.Cells[0].Value.ToString();

            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            cn.Unicamenteagregar(tabla3, valor1, valor2);
            actualizardatagriewpersonal();
   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        //Danny Saldaña 0901-18-18686
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            cn.Unicamenteeliminar(tabla3, valor1, valor2);
            actualizardatagriewpersonal();
 
        }
        //Danny Saldaña 0901-18-18686
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Danny Saldaña 0901-18-18686
        private void button5_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            cn.UnicamenteUnicamenteeliminartodo(tabla3, valor1);
            actualizardatagriewpersonal();

        }
        //Danny Saldaña 0901-18-18686
      
        private void button4_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            string condicion = textBox1.Text;
            cn.UnicamenteUnicamenteeliminartodo(tabla3, valor1);
            cn.UnicamenteUnicamenteagregartodo(tabla3, valor1, valor2, tabla2);
        }















        //Danny Saldaña 0901-18-18686
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Llenar con Enter

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                UnicamentellenarNombre();//llama al evento click del boton
                actualizardatagriewpersonal();
                actualizardatagriew();
                textBox2.Focus();
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dtgConsulta.DataSource = null;
            dataGridView1.DataSource = null;

  
        }
        //Danny Saldaña 0901-18-18686
        //Utilizar flechas para moverse entre botones

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button3.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button4.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button2.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button5.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button6.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button1.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                textBox1.Focus();//Mueve al siguiente boton
            }
        }
    }
}