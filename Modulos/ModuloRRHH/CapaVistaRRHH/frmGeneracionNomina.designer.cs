
namespace CapaVistaRRHH
{
    partial class frmGeneracionNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneracionNomina));
            this.btnGeneraNomina = new System.Windows.Forms.Button();
            this.btnConsulataNomina = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneraNomina
            // 
            this.btnGeneraNomina.Location = new System.Drawing.Point(45, 181);
            this.btnGeneraNomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeneraNomina.Name = "btnGeneraNomina";
            this.btnGeneraNomina.Size = new System.Drawing.Size(137, 28);
            this.btnGeneraNomina.TabIndex = 0;
            this.btnGeneraNomina.Text = "Generar Nomina";
            this.btnGeneraNomina.UseVisualStyleBackColor = true;
            this.btnGeneraNomina.Click += new System.EventHandler(this.btnGeneraNomina_Click);
            // 
            // btnConsulataNomina
            // 
            this.btnConsulataNomina.Location = new System.Drawing.Point(276, 181);
            this.btnConsulataNomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulataNomina.Name = "btnConsulataNomina";
            this.btnConsulataNomina.Size = new System.Drawing.Size(137, 28);
            this.btnConsulataNomina.TabIndex = 0;
            this.btnConsulataNomina.Text = "Consultar Nomina";
            this.btnConsulataNomina.UseVisualStyleBackColor = true;
            this.btnConsulataNomina.Click += new System.EventHandler(this.btnConsulataNomina_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(148, 48);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(148, 80);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(265, 22);
            this.dtpFin.TabIndex = 1;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio del Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final del Periodo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFin);
            this.panel1.Controls.Add(this.txtInicio);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 138);
            this.panel1.TabIndex = 3;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(148, 79);
            this.txtFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(228, 22);
            this.txtFin.TabIndex = 3;
            this.txtFin.Visible = false;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(148, 47);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(228, 22);
            this.txtInicio.TabIndex = 3;
            this.txtInicio.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione un Periodo";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(12, -118);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1585, 107);
            this.navegador1.TabIndex = 4;
            this.navegador1.Visible = false;
            // 
            // frmGeneracionNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 233);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsulataNomina);
            this.Controls.Add(this.btnGeneraNomina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneracionNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación Nómina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneraNomina;
        private System.Windows.Forms.Button btnConsulataNomina;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtInicio;
        private DLL.nav.navegador navegador1;
    }
}