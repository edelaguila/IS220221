
namespace CapaVistaRRHH
{
    partial class frmNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomina));
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtIdNomina = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtsumaded = new System.Windows.Forms.TextBox();
            this.txtsumaper = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNomina
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Location = new System.Drawing.Point(12, 86);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.ReadOnly = true;
            this.dgvNomina.RowHeadersWidth = 51;
            this.dgvNomina.Size = new System.Drawing.Size(862, 412);
            this.dgvNomina.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Nomina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Percepciones totales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Deducciones totales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Estado:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(2, -108);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 2;
            this.navegador1.Visible = false;
            // 
            // txtIdNomina
            // 
            this.txtIdNomina.Location = new System.Drawing.Point(92, 6);
            this.txtIdNomina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdNomina.Name = "txtIdNomina";
            this.txtIdNomina.Size = new System.Drawing.Size(93, 20);
            this.txtIdNomina.TabIndex = 3;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(92, 29);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(93, 20);
            this.txtInicio.TabIndex = 4;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(92, 52);
            this.txtFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(93, 20);
            this.txtFin.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(328, 52);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0.00";
            // 
            // txtsumaded
            // 
            this.txtsumaded.Enabled = false;
            this.txtsumaded.Location = new System.Drawing.Point(328, 29);
            this.txtsumaded.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsumaded.Name = "txtsumaded";
            this.txtsumaded.Size = new System.Drawing.Size(93, 20);
            this.txtsumaded.TabIndex = 7;
            this.txtsumaded.Text = "0.00";
            // 
            // txtsumaper
            // 
            this.txtsumaper.Enabled = false;
            this.txtsumaper.Location = new System.Drawing.Point(328, 6);
            this.txtsumaper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsumaper.Name = "txtsumaper";
            this.txtsumaper.Size = new System.Drawing.Size(93, 20);
            this.txtsumaper.TabIndex = 6;
            this.txtsumaper.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(466, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 108;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Enabled = false;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 6;
            this.rbnEstatusamodulo.TabStop = true;
            this.rbnEstatusamodulo.Text = "Activo";
            this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
            // 
            // rbnEstatusimodulo
            // 
            this.rbnEstatusimodulo.AutoSize = true;
            this.rbnEstatusimodulo.Enabled = false;
            this.rbnEstatusimodulo.Location = new System.Drawing.Point(134, 7);
            this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
            this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
            this.rbnEstatusimodulo.TabIndex = 7;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(672, 46);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 109;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(818, 503);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnGuardar.TabIndex = 110;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Total líquido:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(758, 503);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(56, 19);
            this.btnImprimir.TabIndex = 110;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtsumaded);
            this.Controls.Add(this.txtsumaper);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtIdNomina);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNomina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2204 Generación Nómina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtIdNomina;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtsumaded;
        private System.Windows.Forms.TextBox txtsumaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImprimir;
    }
}