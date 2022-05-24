
namespace CapaVistaRRHH
{
    partial class frmVacaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacaciones));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxPeriodo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.txtPeriodo = new System.Windows.Forms.TextBox();
			this.dgvDisponibles = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvAsignados = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAsignarTodosEmp = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnAsignarUnEmpleado = new System.Windows.Forms.Button();
			this.quitarunemp = new System.Windows.Forms.Button();
			this.quietatodosemp = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCeldas = new System.Windows.Forms.TextBox();
			this.navegador1 = new DLL.nav.navegador();
			this.txtCeldasBorrar = new System.Windows.Forms.TextBox();
			this.btnNueva = new System.Windows.Forms.Button();
			this.dgvRegistrados = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistrados)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(268, 43);
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
			this.panel1.Location = new System.Drawing.Point(62, 38);
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
			this.rbnEstatusamodulo.TabIndex = 4;
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
			this.rbnEstatusimodulo.TabIndex = 5;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Location = new System.Drawing.Point(13, 50);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(43, 13);
			this.lblEstatus.TabIndex = 112;
			this.lblEstatus.Text = "Estado:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(195, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 115;
			this.label1.Text = "Seleccione un Periodo:";
			// 
			// cbxPeriodo
			// 
			this.cbxPeriodo.FormattingEnabled = true;
			this.cbxPeriodo.Location = new System.Drawing.Point(318, 12);
			this.cbxPeriodo.Name = "cbxPeriodo";
			this.cbxPeriodo.Size = new System.Drawing.Size(121, 21);
			this.cbxPeriodo.TabIndex = 116;
			this.cbxPeriodo.Tag = "periodo";
			this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 117;
			this.label2.Text = "ID Vacaciones:";
			// 
			// txtid
			// 
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(98, 12);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(82, 20);
			this.txtid.TabIndex = 118;
			this.txtid.Tag = "vacaciones_e";
			// 
			// txtPeriodo
			// 
			this.txtPeriodo.Location = new System.Drawing.Point(445, 12);
			this.txtPeriodo.Name = "txtPeriodo";
			this.txtPeriodo.Size = new System.Drawing.Size(44, 20);
			this.txtPeriodo.TabIndex = 119;
			this.txtPeriodo.Tag = "periodo";
			this.txtPeriodo.Visible = false;
			this.txtPeriodo.TextChanged += new System.EventHandler(this.txtPeriodo_TextChanged);
			// 
			// dgvDisponibles
			// 
			this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisponibles.Location = new System.Drawing.Point(18, 109);
			this.dgvDisponibles.Name = "dgvDisponibles";
			this.dgvDisponibles.Size = new System.Drawing.Size(240, 323);
			this.dgvDisponibles.TabIndex = 120;
			this.dgvDisponibles.SelectionChanged += new System.EventHandler(this.dgvDisponibles_SelectionChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(73, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 13);
			this.label3.TabIndex = 121;
			this.label3.Text = "Asignar Vacaciones a:";
			// 
			// dgvAsignados
			// 
			this.dgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAsignados.Location = new System.Drawing.Point(357, 109);
			this.dgvAsignados.Name = "dgvAsignados";
			this.dgvAsignados.Size = new System.Drawing.Size(240, 323);
			this.dgvAsignados.TabIndex = 122;
			this.dgvAsignados.SelectionChanged += new System.EventHandler(this.dgvAsignados_SelectionChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(424, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 13);
			this.label4.TabIndex = 123;
			this.label4.Text = "Asignando Vacaciones a:";
			// 
			// btnAsignarTodosEmp
			// 
			this.btnAsignarTodosEmp.Location = new System.Drawing.Point(281, 240);
			this.btnAsignarTodosEmp.Margin = new System.Windows.Forms.Padding(2);
			this.btnAsignarTodosEmp.Name = "btnAsignarTodosEmp";
			this.btnAsignarTodosEmp.Size = new System.Drawing.Size(58, 27);
			this.btnAsignarTodosEmp.TabIndex = 130;
			this.btnAsignarTodosEmp.Text = ">>";
			this.btnAsignarTodosEmp.UseVisualStyleBackColor = true;
			this.btnAsignarTodosEmp.Click += new System.EventHandler(this.btnAsignarTodosEmp_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(264, 284);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 128;
			this.label5.Text = "Quitar Empleado";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(264, 184);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 127;
			this.label6.Text = "Asignar Empleado";
			// 
			// btnAsignarUnEmpleado
			// 
			this.btnAsignarUnEmpleado.Location = new System.Drawing.Point(281, 209);
			this.btnAsignarUnEmpleado.Margin = new System.Windows.Forms.Padding(2);
			this.btnAsignarUnEmpleado.Name = "btnAsignarUnEmpleado";
			this.btnAsignarUnEmpleado.Size = new System.Drawing.Size(58, 27);
			this.btnAsignarUnEmpleado.TabIndex = 125;
			this.btnAsignarUnEmpleado.Text = ">";
			this.btnAsignarUnEmpleado.UseVisualStyleBackColor = true;
			this.btnAsignarUnEmpleado.Click += new System.EventHandler(this.btnAsignarUnEmpleado_Click);
			// 
			// quitarunemp
			// 
			this.quitarunemp.Location = new System.Drawing.Point(280, 309);
			this.quitarunemp.Margin = new System.Windows.Forms.Padding(2);
			this.quitarunemp.Name = "quitarunemp";
			this.quitarunemp.Size = new System.Drawing.Size(58, 27);
			this.quitarunemp.TabIndex = 124;
			this.quitarunemp.Text = "<";
			this.quitarunemp.UseVisualStyleBackColor = true;
			this.quitarunemp.Click += new System.EventHandler(this.quitarunemp_Click);
			// 
			// quietatodosemp
			// 
			this.quietatodosemp.Location = new System.Drawing.Point(280, 341);
			this.quietatodosemp.Margin = new System.Windows.Forms.Padding(2);
			this.quietatodosemp.Name = "quietatodosemp";
			this.quietatodosemp.Size = new System.Drawing.Size(58, 27);
			this.quietatodosemp.TabIndex = 126;
			this.quietatodosemp.Text = "<<";
			this.quietatodosemp.UseVisualStyleBackColor = true;
			this.quietatodosemp.Click += new System.EventHandler(this.quietatodosemp_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(717, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 13);
			this.label7.TabIndex = 133;
			this.label7.Text = "Vacaciones Asignadas a Periodos:";
			// 
			// txtCeldas
			// 
			this.txtCeldas.Location = new System.Drawing.Point(267, 125);
			this.txtCeldas.Name = "txtCeldas";
			this.txtCeldas.Size = new System.Drawing.Size(82, 20);
			this.txtCeldas.TabIndex = 134;
			this.txtCeldas.Tag = "vacaciones_e";
			this.txtCeldas.Visible = false;
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-210, -54);
			this.navegador1.Margin = new System.Windows.Forms.Padding(4);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 38);
			this.navegador1.TabIndex = 135;
			// 
			// txtCeldasBorrar
			// 
			this.txtCeldasBorrar.Location = new System.Drawing.Point(601, 125);
			this.txtCeldasBorrar.Name = "txtCeldasBorrar";
			this.txtCeldasBorrar.Size = new System.Drawing.Size(82, 20);
			this.txtCeldasBorrar.TabIndex = 136;
			this.txtCeldasBorrar.Tag = "vacaciones_e";
			this.txtCeldasBorrar.Visible = false;
			// 
			// btnNueva
			// 
			this.btnNueva.Location = new System.Drawing.Point(522, 10);
			this.btnNueva.Name = "btnNueva";
			this.btnNueva.Size = new System.Drawing.Size(75, 52);
			this.btnNueva.TabIndex = 137;
			this.btnNueva.Text = "Nueva Asignación";
			this.btnNueva.UseVisualStyleBackColor = true;
			this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
			// 
			// dgvRegistrados
			// 
			this.dgvRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistrados.Location = new System.Drawing.Point(689, 109);
			this.dgvRegistrados.Name = "dgvRegistrados";
			this.dgvRegistrados.Size = new System.Drawing.Size(240, 323);
			this.dgvRegistrados.TabIndex = 138;
			this.dgvRegistrados.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegistrados_RowHeaderMouseClick);
			this.dgvRegistrados.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegistrados_RowHeaderMouseDoubleClick);
			// 
			// frmVacaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 450);
			this.Controls.Add(this.dgvRegistrados);
			this.Controls.Add(this.btnNueva);
			this.Controls.Add(this.txtCeldasBorrar);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.txtCeldas);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnAsignarTodosEmp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnAsignarUnEmpleado);
			this.Controls.Add(this.quitarunemp);
			this.Controls.Add(this.quietatodosemp);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvAsignados);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvDisponibles);
			this.Controls.Add(this.txtPeriodo);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxPeriodo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEstatus);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVacaciones";
			this.Text = "Asignación de Vacaciones";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistrados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAsignarTodosEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAsignarUnEmpleado;
        private System.Windows.Forms.Button quitarunemp;
        private System.Windows.Forms.Button quietatodosemp;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCeldas;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.TextBox txtCeldasBorrar;
		private System.Windows.Forms.Button btnNueva;
		private System.Windows.Forms.DataGridView dgvRegistrados;
	}
}