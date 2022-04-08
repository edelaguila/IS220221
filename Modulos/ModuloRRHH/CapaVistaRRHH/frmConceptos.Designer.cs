
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdConcepto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.cbxExcepcion = new System.Windows.Forms.ComboBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtExcepcion = new System.Windows.Forms.TextBox();
            this.txtEfecto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(150, 182);
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
            this.label2.Location = new System.Drawing.Point(40, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Excepción:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(358, 313);
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
            this.panel1.Location = new System.Drawing.Point(152, 313);
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
            this.lblEstatus.Location = new System.Drawing.Point(53, 313);
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
            this.label4.Location = new System.Drawing.Point(59, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Efecto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Formula:";
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
            this.txtFormula.Location = new System.Drawing.Point(160, 268);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(100, 20);
            this.txtFormula.TabIndex = 6;
            this.txtFormula.Tag = "formulaConcepto";
            // 
            // cbxExcepcion
            // 
            this.cbxExcepcion.FormattingEnabled = true;
            this.cbxExcepcion.Location = new System.Drawing.Point(160, 230);
            this.cbxExcepcion.Name = "cbxExcepcion";
            this.cbxExcepcion.Size = new System.Drawing.Size(121, 21);
            this.cbxExcepcion.TabIndex = 5;
            this.cbxExcepcion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // txtExcepcion
            // 
            this.txtExcepcion.Location = new System.Drawing.Point(287, 231);
            this.txtExcepcion.Name = "txtExcepcion";
            this.txtExcepcion.Size = new System.Drawing.Size(43, 20);
            this.txtExcepcion.TabIndex = 129;
            this.txtExcepcion.Tag = "fkIdExcepcion";
            this.txtExcepcion.Visible = false;
            // 
            // txtEfecto
            // 
            this.txtEfecto.Location = new System.Drawing.Point(358, 186);
            this.txtEfecto.Name = "txtEfecto";
            this.txtEfecto.Size = new System.Drawing.Size(46, 20);
            this.txtEfecto.TabIndex = 130;
            this.txtEfecto.Tag = "efectoConcepto";
            this.txtEfecto.Visible = false;
            this.txtEfecto.TextChanged += new System.EventHandler(this.txtEfecto_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 131;
            this.button1.Text = "f(x)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.txtExcepcion);
            this.Controls.Add(this.txtEfecto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdConcepto);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cbxExcepcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceptos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdConcepto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.ComboBox cbxExcepcion;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TextBox txtExcepcion;
        private System.Windows.Forms.TextBox txtEfecto;
        private System.Windows.Forms.Button button1;
    }
}