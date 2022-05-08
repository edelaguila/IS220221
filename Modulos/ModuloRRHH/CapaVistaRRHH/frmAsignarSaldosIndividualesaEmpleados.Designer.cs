
namespace CapaVistaRRHH
{
    partial class frmAsignarSaldosIndividualesaEmpleados
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
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtIdConcepto = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtIdAsignacion = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.cbxNombreConcepto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(167, 166);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(153, 13);
            this.lblConcepto.TabIndex = 47;
            this.lblConcepto.Text = "Nombre Concepto Gestionado:";
            // 
            // txtIdConcepto
            // 
            this.txtIdConcepto.Location = new System.Drawing.Point(304, 187);
            this.txtIdConcepto.Name = "txtIdConcepto";
            this.txtIdConcepto.Size = new System.Drawing.Size(49, 20);
            this.txtIdConcepto.TabIndex = 48;
            this.txtIdConcepto.Tag = "fkIdConcepto";
            this.txtIdConcepto.Visible = false;
            this.txtIdConcepto.TextChanged += new System.EventHandler(this.txtIdConcepto_TextChanged);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(142, 443);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(660, 150);
            this.dgvEmpleados.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(140, 427);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Asignacionaciones a empleados realizadas";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 51;
            // 
            // txtIdAsignacion
            // 
            this.txtIdAsignacion.Location = new System.Drawing.Point(170, 134);
            this.txtIdAsignacion.Name = "txtIdAsignacion";
            this.txtIdAsignacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdAsignacion.TabIndex = 52;
            this.txtIdAsignacion.Tag = "pkid";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(304, 233);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(49, 20);
            this.txtIdEmpleado.TabIndex = 54;
            this.txtIdEmpleado.Tag = "fkIdEmpleado";
            this.txtIdEmpleado.Visible = false;
            this.txtIdEmpleado.TextChanged += new System.EventHandler(this.txtIdEmpleado_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(170, 282);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 55;
            this.txtSaldo.Tag = "saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Id Asignacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nombre Concepto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Id Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Saldo de asignacion:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(376, 325);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 116;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(170, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 117;
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
            this.lblEstatus.Location = new System.Drawing.Point(70, 325);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(43, 13);
            this.lblEstatus.TabIndex = 115;
            this.lblEstatus.Text = "Estado:";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(170, 234);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpleado.TabIndex = 118;
            this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleado_SelectedIndexChanged);
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(475, 134);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.Size = new System.Drawing.Size(683, 236);
            this.dvgConsulta.TabIndex = 119;
            this.dvgConsulta.SelectionChanged += new System.EventHandler(this.dvgConsulta_SelectionChanged);
            this.dvgConsulta.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dvgConsulta_UserAddedRow);
            // 
            // cbxNombreConcepto
            // 
            this.cbxNombreConcepto.FormattingEnabled = true;
            this.cbxNombreConcepto.Location = new System.Drawing.Point(170, 187);
            this.cbxNombreConcepto.Name = "cbxNombreConcepto";
            this.cbxNombreConcepto.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreConcepto.TabIndex = 120;
            this.cbxNombreConcepto.SelectedIndexChanged += new System.EventHandler(this.cbxNombreConcepto_SelectedIndexChanged);
            // 
            // frmAsignarSaldosIndividualesaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 615);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdConcepto);
            this.Controls.Add(this.txtIdAsignacion);
            this.Controls.Add(this.cbxNombreConcepto);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblConcepto);
            this.Name = "frmAsignarSaldosIndividualesaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1112 Asignar Saldos Individuales a Empleados";
            this.Load += new System.EventHandler(this.frmAsignarSaldosIndividualesaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtIdConcepto;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label2;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtIdAsignacion;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.ComboBox cbxNombreConcepto;
    }
}