
namespace CapaVistaRRHH
{
    partial class Conceptos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conceptos));
            this.navegador1 = new DLL.nav.navegador();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbnPercepcion = new System.Windows.Forms.RadioButton();
            this.rbnDeduccion = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdConcepto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtAplicacion = new System.Windows.Forms.TextBox();
            this.txtEfecto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbnTodos = new System.Windows.Forms.RadioButton();
            this.rbnAlgunos = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbnExcepto = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbnFormula = new System.Windows.Forms.RadioButton();
            this.rbnValorU = new System.Windows.Forms.RadioButton();
            this.rbnPorcentaje = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbnPercepcion);
            this.panel2.Controls.Add(this.rbnDeduccion);
            this.panel2.Location = new System.Drawing.Point(150, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 30);
            this.panel2.TabIndex = 117;
            // 
            // rbnPercepcion
            // 
            this.rbnPercepcion.AutoSize = true;
            this.rbnPercepcion.Location = new System.Drawing.Point(12, 7);
            this.rbnPercepcion.Name = "rbnPercepcion";
            this.rbnPercepcion.Size = new System.Drawing.Size(79, 17);
            this.rbnPercepcion.TabIndex = 3;
            this.rbnPercepcion.TabStop = true;
            this.rbnPercepcion.Text = "Percepcion";
            this.rbnPercepcion.UseVisualStyleBackColor = true;
            this.rbnPercepcion.CheckedChanged += new System.EventHandler(this.rbnPercepcion_CheckedChanged);
            // 
            // rbnDeduccion
            // 
            this.rbnDeduccion.AutoSize = true;
            this.rbnDeduccion.Location = new System.Drawing.Point(120, 7);
            this.rbnDeduccion.Name = "rbnDeduccion";
            this.rbnDeduccion.Size = new System.Drawing.Size(77, 17);
            this.rbnDeduccion.TabIndex = 4;
            this.rbnDeduccion.TabStop = true;
            this.rbnDeduccion.Text = "Deduccion";
            this.rbnDeduccion.UseVisualStyleBackColor = true;
            this.rbnDeduccion.CheckedChanged += new System.EventHandler(this.rbnDeduccion_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Aplicación:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(358, 412);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 113;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(152, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 114;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 7;
            this.rbnEstatusamodulo.TabStop = true;
            this.rbnEstatusamodulo.Text = "Activo";
            this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
            // 
            // rbnEstatusimodulo
            // 
            this.rbnEstatusimodulo.AutoSize = true;
            this.rbnEstatusimodulo.Location = new System.Drawing.Point(134, 7);
            this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
            this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
            this.rbnEstatusimodulo.TabIndex = 8;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(53, 412);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(43, 13);
            this.lblEstatus.TabIndex = 112;
            this.lblEstatus.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Id Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Efecto:";
            // 
            // txtIdConcepto
            // 
            this.txtIdConcepto.Location = new System.Drawing.Point(160, 116);
            this.txtIdConcepto.Name = "txtIdConcepto";
            this.txtIdConcepto.Size = new System.Drawing.Size(100, 20);
            this.txtIdConcepto.TabIndex = 1;
            this.txtIdConcepto.Tag = "pkIdConcepto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombreConcepto";
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(267, 347);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(100, 20);
            this.txtFormula.TabIndex = 6;
            this.txtFormula.Tag = "formulaConcepto";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(453, 106);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.Size = new System.Drawing.Size(719, 332);
            this.dgvVistaPrevia.TabIndex = 127;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // txtAplicacion
            // 
            this.txtAplicacion.Location = new System.Drawing.Point(361, 241);
            this.txtAplicacion.Name = "txtAplicacion";
            this.txtAplicacion.Size = new System.Drawing.Size(43, 20);
            this.txtAplicacion.TabIndex = 129;
            this.txtAplicacion.Tag = "aplicacion";
            this.txtAplicacion.Visible = false;
            this.txtAplicacion.TextChanged += new System.EventHandler(this.txtAplicacion_TextChanged);
            // 
            // txtEfecto
            // 
            this.txtEfecto.Location = new System.Drawing.Point(358, 193);
            this.txtEfecto.Name = "txtEfecto";
            this.txtEfecto.Size = new System.Drawing.Size(46, 20);
            this.txtEfecto.TabIndex = 130;
            this.txtEfecto.Tag = "efectoConcepto";
            this.txtEfecto.Visible = false;
            this.txtEfecto.TextChanged += new System.EventHandler(this.txtEfecto_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 131;
            this.button1.Text = "f(x)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbnTodos);
            this.panel3.Controls.Add(this.rbnAlgunos);
            this.panel3.Location = new System.Drawing.Point(152, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 30);
            this.panel3.TabIndex = 118;
            // 
            // rbnTodos
            // 
            this.rbnTodos.AutoSize = true;
            this.rbnTodos.Location = new System.Drawing.Point(12, 7);
            this.rbnTodos.Name = "rbnTodos";
            this.rbnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbnTodos.TabIndex = 3;
            this.rbnTodos.TabStop = true;
            this.rbnTodos.Text = "Todos";
            this.rbnTodos.UseVisualStyleBackColor = true;
            this.rbnTodos.CheckedChanged += new System.EventHandler(this.rbnTodos_CheckedChanged);
            // 
            // rbnAlgunos
            // 
            this.rbnAlgunos.AutoSize = true;
            this.rbnAlgunos.Location = new System.Drawing.Point(115, 7);
            this.rbnAlgunos.Name = "rbnAlgunos";
            this.rbnAlgunos.Size = new System.Drawing.Size(63, 17);
            this.rbnAlgunos.TabIndex = 4;
            this.rbnAlgunos.TabStop = true;
            this.rbnAlgunos.Text = "Algunos";
            this.rbnAlgunos.UseVisualStyleBackColor = true;
            this.rbnAlgunos.CheckedChanged += new System.EventHandler(this.rbnUnicamente_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbnExcepto);
            this.panel4.Location = new System.Drawing.Point(152, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 30);
            this.panel4.TabIndex = 132;
            // 
            // rbnExcepto
            // 
            this.rbnExcepto.AutoSize = true;
            this.rbnExcepto.Location = new System.Drawing.Point(12, 7);
            this.rbnExcepto.Name = "rbnExcepto";
            this.rbnExcepto.Size = new System.Drawing.Size(64, 17);
            this.rbnExcepto.TabIndex = 3;
            this.rbnExcepto.TabStop = true;
            this.rbnExcepto.Text = "Excepto";
            this.rbnExcepto.UseVisualStyleBackColor = true;
            this.rbnExcepto.CheckedChanged += new System.EventHandler(this.rbnExcepto_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbnFormula);
            this.panel5.Controls.Add(this.rbnValorU);
            this.panel5.Controls.Add(this.rbnPorcentaje);
            this.panel5.Location = new System.Drawing.Point(152, 320);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(98, 77);
            this.panel5.TabIndex = 142;
            // 
            // rbnFormula
            // 
            this.rbnFormula.AutoSize = true;
            this.rbnFormula.Location = new System.Drawing.Point(14, 53);
            this.rbnFormula.Name = "rbnFormula";
            this.rbnFormula.Size = new System.Drawing.Size(62, 17);
            this.rbnFormula.TabIndex = 5;
            this.rbnFormula.TabStop = true;
            this.rbnFormula.Text = "Formula";
            this.rbnFormula.UseVisualStyleBackColor = true;
            this.rbnFormula.CheckedChanged += new System.EventHandler(this.rbnFormula_CheckedChanged);
            // 
            // rbnValorU
            // 
            this.rbnValorU.AutoSize = true;
            this.rbnValorU.Location = new System.Drawing.Point(12, 7);
            this.rbnValorU.Name = "rbnValorU";
            this.rbnValorU.Size = new System.Drawing.Size(80, 17);
            this.rbnValorU.TabIndex = 3;
            this.rbnValorU.TabStop = true;
            this.rbnValorU.Text = "Valor Unico";
            this.rbnValorU.UseVisualStyleBackColor = true;
            this.rbnValorU.CheckedChanged += new System.EventHandler(this.rbnValorU_CheckedChanged);
            // 
            // rbnPorcentaje
            // 
            this.rbnPorcentaje.AutoSize = true;
            this.rbnPorcentaje.Location = new System.Drawing.Point(13, 30);
            this.rbnPorcentaje.Name = "rbnPorcentaje";
            this.rbnPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.rbnPorcentaje.TabIndex = 4;
            this.rbnPorcentaje.TabStop = true;
            this.rbnPorcentaje.Text = "Porcentaje";
            this.rbnPorcentaje.UseVisualStyleBackColor = true;
            this.rbnPorcentaje.CheckedChanged += new System.EventHandler(this.rbnPorcentaje_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 143;
            this.label6.Text = "Tipo de valor aplicacion:";
            // 
            // Conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.txtAplicacion);
            this.Controls.Add(this.txtEfecto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdConcepto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2102 Conceptos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnPercepcion;
        private System.Windows.Forms.RadioButton rbnDeduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdConcepto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TextBox txtAplicacion;
        private System.Windows.Forms.TextBox txtEfecto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbnTodos;
        private System.Windows.Forms.RadioButton rbnAlgunos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbnExcepto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbnFormula;
        private System.Windows.Forms.RadioButton rbnValorU;
        private System.Windows.Forms.RadioButton rbnPorcentaje;
        private System.Windows.Forms.Label label6;
    }
}