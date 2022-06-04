
namespace CapaVistaRRHH
{
	partial class frmGestorVacaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorVacaciones));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnAlgunos = new System.Windows.Forms.RadioButton();
			this.rbnTodos = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDias = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxPeriodo = new System.Windows.Forms.ComboBox();
			this.dgvSeleccion = new System.Windows.Forms.DataGridView();
			this.dgvGestionados = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.navegador1 = new DLL.nav.navegador();
			this.txtPeriodo = new System.Windows.Forms.TextBox();
			this.btnDescontar = new System.Windows.Forms.Button();
			this.txtCeldasBorrar = new System.Windows.Forms.TextBox();
			this.txtCeldas = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnAsignarUnEmpleado = new System.Windows.Forms.Button();
			this.quitarunemp = new System.Windows.Forms.Button();
			this.quietatodosemp = new System.Windows.Forms.Button();
			this.txtEncabezado = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGestionados)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gestionar Vacaciones de:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnAlgunos);
			this.panel1.Controls.Add(this.rbnTodos);
			this.panel1.Location = new System.Drawing.Point(175, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(153, 24);
			this.panel1.TabIndex = 1;
			// 
			// rbnAlgunos
			// 
			this.rbnAlgunos.AutoSize = true;
			this.rbnAlgunos.Location = new System.Drawing.Point(88, 4);
			this.rbnAlgunos.Name = "rbnAlgunos";
			this.rbnAlgunos.Size = new System.Drawing.Size(63, 17);
			this.rbnAlgunos.TabIndex = 1;
			this.rbnAlgunos.TabStop = true;
			this.rbnAlgunos.Text = "Algunos";
			this.rbnAlgunos.UseVisualStyleBackColor = true;
			this.rbnAlgunos.CheckedChanged += new System.EventHandler(this.rbnAlgunos_CheckedChanged);
			// 
			// rbnTodos
			// 
			this.rbnTodos.AutoSize = true;
			this.rbnTodos.Location = new System.Drawing.Point(4, 4);
			this.rbnTodos.Name = "rbnTodos";
			this.rbnTodos.Size = new System.Drawing.Size(55, 17);
			this.rbnTodos.TabIndex = 0;
			this.rbnTodos.TabStop = true;
			this.rbnTodos.Text = "Todos";
			this.rbnTodos.UseVisualStyleBackColor = true;
			this.rbnTodos.CheckedChanged += new System.EventHandler(this.rbnTodos_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(210, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Días a Descontar:";
			// 
			// txtDias
			// 
			this.txtDias.Location = new System.Drawing.Point(303, 42);
			this.txtDias.Name = "txtDias";
			this.txtDias.Size = new System.Drawing.Size(45, 20);
			this.txtDias.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Periodo:";
			// 
			// cbxPeriodo
			// 
			this.cbxPeriodo.FormattingEnabled = true;
			this.cbxPeriodo.Location = new System.Drawing.Point(86, 42);
			this.cbxPeriodo.Name = "cbxPeriodo";
			this.cbxPeriodo.Size = new System.Drawing.Size(121, 21);
			this.cbxPeriodo.TabIndex = 5;
			this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
			// 
			// dgvSeleccion
			// 
			this.dgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeleccion.Location = new System.Drawing.Point(12, 107);
			this.dgvSeleccion.Name = "dgvSeleccion";
			this.dgvSeleccion.Size = new System.Drawing.Size(420, 249);
			this.dgvSeleccion.TabIndex = 6;
			this.dgvSeleccion.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeleccion_RowHeaderMouseDoubleClick);
			// 
			// dgvGestionados
			// 
			this.dgvGestionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGestionados.Location = new System.Drawing.Point(501, 107);
			this.dgvGestionados.Name = "dgvGestionados";
			this.dgvGestionados.Size = new System.Drawing.Size(240, 249);
			this.dgvGestionados.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(172, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Selección de Empleados";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(560, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Empleados Gestionados";
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-193, -101);
			this.navegador1.Margin = new System.Windows.Forms.Padding(4);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 52;
			// 
			// txtPeriodo
			// 
			this.txtPeriodo.Location = new System.Drawing.Point(35, 61);
			this.txtPeriodo.Name = "txtPeriodo";
			this.txtPeriodo.Size = new System.Drawing.Size(45, 20);
			this.txtPeriodo.TabIndex = 53;
			this.txtPeriodo.Visible = false;
			// 
			// btnDescontar
			// 
			this.btnDescontar.Location = new System.Drawing.Point(354, 40);
			this.btnDescontar.Name = "btnDescontar";
			this.btnDescontar.Size = new System.Drawing.Size(75, 23);
			this.btnDescontar.TabIndex = 54;
			this.btnDescontar.Text = "Descontar";
			this.btnDescontar.UseVisualStyleBackColor = true;
			this.btnDescontar.Click += new System.EventHandler(this.btnDescontar_Click);
			// 
			// txtCeldasBorrar
			// 
			this.txtCeldasBorrar.Location = new System.Drawing.Point(659, 84);
			this.txtCeldasBorrar.Name = "txtCeldasBorrar";
			this.txtCeldasBorrar.Size = new System.Drawing.Size(82, 20);
			this.txtCeldasBorrar.TabIndex = 144;
			this.txtCeldasBorrar.Tag = "vacaciones_e";
			this.txtCeldasBorrar.Visible = false;
			// 
			// txtCeldas
			// 
			this.txtCeldas.Location = new System.Drawing.Point(414, 84);
			this.txtCeldas.Name = "txtCeldas";
			this.txtCeldas.Size = new System.Drawing.Size(82, 20);
			this.txtCeldas.TabIndex = 143;
			this.txtCeldas.Tag = "vacaciones_e";
			this.txtCeldas.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(444, 233);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 141;
			this.label6.Text = "Quitar";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(434, 144);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 140;
			this.label7.Text = "Seleccionar";
			// 
			// btnAsignarUnEmpleado
			// 
			this.btnAsignarUnEmpleado.Location = new System.Drawing.Point(437, 168);
			this.btnAsignarUnEmpleado.Margin = new System.Windows.Forms.Padding(2);
			this.btnAsignarUnEmpleado.Name = "btnAsignarUnEmpleado";
			this.btnAsignarUnEmpleado.Size = new System.Drawing.Size(58, 27);
			this.btnAsignarUnEmpleado.TabIndex = 138;
			this.btnAsignarUnEmpleado.Text = ">";
			this.btnAsignarUnEmpleado.UseVisualStyleBackColor = true;
			this.btnAsignarUnEmpleado.Click += new System.EventHandler(this.btnAsignarUnEmpleado_Click);
			// 
			// quitarunemp
			// 
			this.quitarunemp.Location = new System.Drawing.Point(436, 258);
			this.quitarunemp.Margin = new System.Windows.Forms.Padding(2);
			this.quitarunemp.Name = "quitarunemp";
			this.quitarunemp.Size = new System.Drawing.Size(58, 27);
			this.quitarunemp.TabIndex = 137;
			this.quitarunemp.Text = "<";
			this.quitarunemp.UseVisualStyleBackColor = true;
			this.quitarunemp.Click += new System.EventHandler(this.quitarunemp_Click);
			// 
			// quietatodosemp
			// 
			this.quietatodosemp.Location = new System.Drawing.Point(436, 290);
			this.quietatodosemp.Margin = new System.Windows.Forms.Padding(2);
			this.quietatodosemp.Name = "quietatodosemp";
			this.quietatodosemp.Size = new System.Drawing.Size(58, 27);
			this.quietatodosemp.TabIndex = 139;
			this.quietatodosemp.Text = "<<";
			this.quietatodosemp.UseVisualStyleBackColor = true;
			this.quietatodosemp.Click += new System.EventHandler(this.quietatodosemp_Click);
			// 
			// txtEncabezado
			// 
			this.txtEncabezado.Location = new System.Drawing.Point(76, 69);
			this.txtEncabezado.Name = "txtEncabezado";
			this.txtEncabezado.Size = new System.Drawing.Size(45, 20);
			this.txtEncabezado.TabIndex = 145;
			this.txtEncabezado.Visible = false;
			// 
			// frmGestorVacaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 365);
			this.Controls.Add(this.txtEncabezado);
			this.Controls.Add(this.txtCeldasBorrar);
			this.Controls.Add(this.txtCeldas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnAsignarUnEmpleado);
			this.Controls.Add(this.quitarunemp);
			this.Controls.Add(this.quietatodosemp);
			this.Controls.Add(this.btnDescontar);
			this.Controls.Add(this.txtPeriodo);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvGestionados);
			this.Controls.Add(this.dgvSeleccion);
			this.Controls.Add(this.cbxPeriodo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGestorVacaciones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "2319 Gestor de Vacaciones";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmGestorVacaciones_HelpButtonClicked);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGestionados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnAlgunos;
		private System.Windows.Forms.RadioButton rbnTodos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDias;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxPeriodo;
		private System.Windows.Forms.DataGridView dgvSeleccion;
		private System.Windows.Forms.DataGridView dgvGestionados;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.TextBox txtPeriodo;
		private System.Windows.Forms.Button btnDescontar;
		private System.Windows.Forms.TextBox txtCeldasBorrar;
		private System.Windows.Forms.TextBox txtCeldas;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnAsignarUnEmpleado;
		private System.Windows.Forms.Button quitarunemp;
		private System.Windows.Forms.Button quietatodosemp;
		private System.Windows.Forms.TextBox txtEncabezado;
	}
}