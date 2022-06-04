
namespace CapaVistaRRHH
{
    partial class frmPeriodo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriodo));
			this.navegador1 = new DLL.nav.navegador();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtIdPeriodo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txtInicio = new System.Windows.Forms.TextBox();
			this.txtFin = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(0, -2);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 0;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(354, 238);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 114;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 116;
			this.label2.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(148, 143);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(200, 20);
			this.txtNombre.TabIndex = 111;
			this.txtNombre.Tag = "nombre";
			// 
			// txtIdPeriodo
			// 
			this.txtIdPeriodo.Location = new System.Drawing.Point(148, 117);
			this.txtIdPeriodo.Name = "txtIdPeriodo";
			this.txtIdPeriodo.Size = new System.Drawing.Size(200, 20);
			this.txtIdPeriodo.TabIndex = 110;
			this.txtIdPeriodo.Tag = "pkId";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 117;
			this.label1.Text = "ID Periodo:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Location = new System.Drawing.Point(148, 238);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 115;
			// 
			// rbnEstatusamodulo
			// 
			this.rbnEstatusamodulo.AutoSize = true;
			this.rbnEstatusamodulo.Location = new System.Drawing.Point(16, 7);
			this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
			this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
			this.rbnEstatusamodulo.TabIndex = 3;
			this.rbnEstatusamodulo.TabStop = true;
			this.rbnEstatusamodulo.Text = "Activo";
			this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
			// 
			// rbnEstatusimodulo
			// 
			this.rbnEstatusimodulo.AutoSize = true;
			this.rbnEstatusimodulo.Location = new System.Drawing.Point(128, 7);
			this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
			this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
			this.rbnEstatusimodulo.TabIndex = 4;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Location = new System.Drawing.Point(38, 241);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(45, 13);
			this.lblEstatus.TabIndex = 113;
			this.lblEstatus.Text = "Estatus:";
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToOrderColumns = true;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(488, 104);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(688, 256);
			this.dgvVistaPrevia.TabIndex = 112;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 117;
			this.label3.Text = "Inicio:";
			// 
			// txtInicio
			// 
			this.txtInicio.Location = new System.Drawing.Point(354, 169);
			this.txtInicio.Name = "txtInicio";
			this.txtInicio.Size = new System.Drawing.Size(115, 20);
			this.txtInicio.TabIndex = 110;
			this.txtInicio.Tag = "inicio";
			this.txtInicio.Visible = false;
			this.txtInicio.TextChanged += new System.EventHandler(this.txtInicio_TextChanged);
			// 
			// txtFin
			// 
			this.txtFin.Location = new System.Drawing.Point(354, 193);
			this.txtFin.Name = "txtFin";
			this.txtFin.Size = new System.Drawing.Size(115, 20);
			this.txtFin.TabIndex = 111;
			this.txtFin.Tag = "fin";
			this.txtFin.Visible = false;
			this.txtFin.TextChanged += new System.EventHandler(this.txtFin_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 116;
			this.label4.Text = "Fin:";
			// 
			// dtpInicio
			// 
			this.dtpInicio.Location = new System.Drawing.Point(148, 169);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(200, 20);
			this.dtpInicio.TabIndex = 119;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Location = new System.Drawing.Point(148, 195);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(200, 20);
			this.dtpFin.TabIndex = 119;
			this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
			// 
			// frmPeriodo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 378);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtInicio);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdPeriodo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.navegador1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPeriodo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPeriodo";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}