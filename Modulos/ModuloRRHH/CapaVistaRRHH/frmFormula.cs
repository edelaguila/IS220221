﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorRRHH;
using System.Text.RegularExpressions;
using static datosUsuario;

namespace CapaVistaRRHH
{
    public partial class frmFormula : Form
    {
        private Controlador cn = new Controlador();
        public frmFormula()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            txtValor.Visible = false;
            textBox1.Enabled = false;
            FormulasTodosLosConceptos();
        }
        int contadorParentesis = 0;
        int contadorParentesis2 = 0;
        public void FormulasTodosLosConceptos()
        {
            DataTable dt = cn.FormulasTodosLosConceptos();
            dataGridView1.DataSource = dt;
        }

        public void FormulasLlenarComboTablas()
        {
            DataTable dt = cn.FormulasLlenarComboTablas();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Tables_in_hotelsancarlos";
            comboBox1.ValueMember = "Tables_in_hotelsancarlos";
        }

        public void FormulasLlenarComboCampos()
        {
            string tabla = Convert.ToString(comboBox1.SelectedValue);
            DataTable dt = cn.FormulasLlenarComboCampos(tabla);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Field";
            comboBox2.ValueMember = "Field";
        }


        public void visiblecampos()
        {
            if (rbn1.Checked == true)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                txtValor.Visible = true;

                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = true;
            }
            else if (rbn2.Checked == true)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                txtValor.Visible = false;

                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
            }
            else if (rbn3.Checked == true)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                txtValor.Visible = false;

                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
            }
        }


        private void rbn1_CheckedChanged(object sender, EventArgs e)
        {
            visiblecampos();
            FormulasLlenarComboTablas();
        }

        private void rbn2_CheckedChanged(object sender, EventArgs e)
        {
            visiblecampos();
            FormulasLlenarComboTablas();
        }

        private void rbn3_CheckedChanged(object sender, EventArgs e)
        {
            visiblecampos();
            FormulasLlenarComboTablas();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            FormulasLlenarComboCampos();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            FormulasLlenarComboCampos();

        }
        //SELECT (empleado.sueldo) /(SELECT 30) / (SELECT 8) * (SELECT 1.5) * (SELECT 12) FROM `empleado` WHERE pkIdEmpleado = '1';
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbn1.Checked == true)
            {
                string cadenaFormula = textBox1.Text;
                if (cadenaFormula == "")
                {
                    string valor = txtValor.Text;
                    string puente = cadenaFormula + valor;
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text+"(SELECT " + valor + ")";

                }
                else if (cadenaFormula != "")
                {
                    string compararUltimoCaracter = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                    if (Regex.IsMatch(compararUltimoCaracter, @"^[a-zA-Z0-9]+$"))
                    {
                    }else
                    {
                        string valor = txtValor.Text;
                        string puente = cadenaFormula + valor;
                        textBox1.Text = puente;
                        txtsql.Text = txtsql.Text + "(SELECT " + valor + ")";


                    }
                }
            }




            if (rbn2.Checked == true)
            {
                if (rbn2.Checked == true)
                {
                    string tabla = Convert.ToString(comboBox1.SelectedValue);
                    string campo = Convert.ToString(comboBox2.SelectedValue);
                    string cadenaFormula = textBox1.Text;
                    if (cadenaFormula == "")
                    {
                        string valor = txtValor.Text;
                        string puente = cadenaFormula + tabla + "." + campo;
                        textBox1.Text = puente;
                        txtsql.Text = txtsql.Text + "(SELECT " + tabla + "." + campo + " WHERE pkIdEmpleado = \" + condicion + \")";

                    }
                    else if (cadenaFormula != "")
                    {
                        string compararUltimoCaracter = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                        if (Regex.IsMatch(compararUltimoCaracter, @"^[a-zA-Z0-9]+$"))
                        {
                        }
                        else
                        {
                            string valor = txtValor.Text;
                            string puente = cadenaFormula + tabla + "." + campo;
                            textBox1.Text = puente;
                            txtsql.Text = txtsql.Text + "(SELECT " + tabla + "." + campo + " WHERE pkIdEmpleado = \" + condicion + \")";


                        }
                    }
                }
            }

            if (rbn3.Checked == true)
            {
                if (rbn3.Checked == true)
                {
                    string tabla = Convert.ToString(comboBox1.SelectedValue);
                    string campo = Convert.ToString(comboBox2.SelectedValue);
                    string cadenaFormula = textBox1.Text;
                    if (cadenaFormula == "")
                    {
                        string valor = txtValor.Text;
                        string puente = cadenaFormula + "@" + tabla + "." + campo;
                        textBox1.Text = puente;
                        txtsql.Text = txtsql.Text + "(SELECT " + tabla + "." + campo + " WHERE pkIdEmpleado = \" + condicion + \" AND " + tabla +".periodo = \" + condicion2 + \")";               

                    }
                    else if (cadenaFormula != "")
                    {
                        string compararUltimoCaracter = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                        if (Regex.IsMatch(compararUltimoCaracter, @"^[a-zA-Z0-9]+$"))
                        {
                        }
                        else
                        {
                            string valor = txtValor.Text;
                            string puente = cadenaFormula + "@" + tabla + "." + campo;
                            textBox1.Text = puente;
                            txtsql.Text = txtsql.Text + "(SELECT " + tabla + "." + campo + " WHERE pkIdEmpleado = \" + condicion + \" AND " + tabla + ".periodo = \" + condicion + \")";
                        }
                    }
                }
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cadenaFormula = textBox1.Text;
            if (cadenaFormula != "")
            {
                string compararSiHayOtroSigno = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                if ((compararSiHayOtroSigno !="+") && (compararSiHayOtroSigno !="-") && (compararSiHayOtroSigno !="*") && (compararSiHayOtroSigno !="/") && (compararSiHayOtroSigno !="("))
                {
                    string puente = cadenaFormula + " +";
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text + "+";


                }
            }
            else if (cadenaFormula == "")
            {   
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cadenaFormula = textBox1.Text;
            if (cadenaFormula != "")
            {
                string compararSiHayOtroSigno = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                if (compararSiHayOtroSigno != "+" && compararSiHayOtroSigno != "-" && compararSiHayOtroSigno != "*" && compararSiHayOtroSigno != "/" && compararSiHayOtroSigno != "(")
                {
                    string puente = cadenaFormula + " -";
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text + "-";
                }
            }
            else if (cadenaFormula == "")
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cadenaFormula = textBox1.Text;
            if (cadenaFormula != "")
            {
                string compararSiHayOtroSigno = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                if (compararSiHayOtroSigno != "+" && compararSiHayOtroSigno != "-" && compararSiHayOtroSigno != "*" && compararSiHayOtroSigno != "/" && compararSiHayOtroSigno != "(")
                {
                    string puente = cadenaFormula + " *";
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text + "*";
                }
            }
            else if (cadenaFormula == "")
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cadenaFormula = textBox1.Text;
            if (cadenaFormula != "")
            {
                string compararSiHayOtroSigno = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                if (compararSiHayOtroSigno != "+" && compararSiHayOtroSigno != "-" && compararSiHayOtroSigno != "*" && compararSiHayOtroSigno != "/" && compararSiHayOtroSigno != "(")
                {
                    string puente = cadenaFormula + " /";
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text + "/";
                }
            }
            else if (cadenaFormula == "")
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string cadenaFormula = textBox1.Text;
            
                    string puente = cadenaFormula + " (";
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text + "(";
                    contadorParentesis = contadorParentesis + 1;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string cadenaFormula = textBox1.Text;
            if (cadenaFormula != "")
            {
                string compararSiHayOtroSigno = cadenaFormula.Substring(cadenaFormula.Length - 1, 1);
                if (compararSiHayOtroSigno != "+" && compararSiHayOtroSigno != "-" && compararSiHayOtroSigno != "*" && compararSiHayOtroSigno != "/" && compararSiHayOtroSigno != "(")
                {
                    string puente = cadenaFormula + " )";
                    textBox1.Text = puente;
                    txtsql.Text = txtsql.Text + ")";
                    contadorParentesis2 = contadorParentesis2 + 1;
                }
            }
            else if (cadenaFormula == "")
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contadorParentesis == contadorParentesis2)
            {
                string formula = textBox1.Text;
                string pkIdConcepto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cn.FormulasAsignarConcepto(formula, pkIdConcepto);
                MessageBox.Show("Asignacion Correcta", "Formulas RRHH");


                string valor2 = "SELECT(" + txtsql.Text + ") FROM `empleado` WHERE pkIdEmpleado = \" + condicion + \";";
                string valor1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cn.GuradarSentenciaSql(valor1, valor2);
            }
            else
            {
                MessageBox.Show("Error en estructura", "Formulas RRHH");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtsql.Text = "";
            txtValor.Text = "";
        }
    }
}
