
namespace CapaVistaRRHH
{
    partial class frmAsignacionEmpleadosaConceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionEmpleadosaConceptos));
            this.dvgEmpleadosAsignados = new System.Windows.Forms.DataGridView();
            this.txtCeldas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dvgTodosEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAsignarTodosEmp = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignarUnEmpleado = new System.Windows.Forms.Button();
            this.quitarunemp = new System.Windows.Forms.Button();
            this.quietatodosemp = new System.Windows.Forms.Button();
            this.dvgDatosConcepto = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cbxIdConcepto = new System.Windows.Forms.ComboBox();
            this.cbxNombreConcepto = new System.Windows.Forms.ComboBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAsignarSaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleadosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatosConcepto)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEmpleadosAsignados
            // 
            this.dvgEmpleadosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmpleadosAsignados.Location = new System.Drawing.Point(454, 162);
            this.dvgEmpleadosAsignados.Name = "dvgEmpleadosAsignados";
            this.dvgEmpleadosAsignados.Size = new System.Drawing.Size(334, 322);
            this.dvgEmpleadosAsignados.TabIndex = 45;
            // 
            // txtCeldas
            // 
            this.txtCeldas.Location = new System.Drawing.Point(19, 414);
            this.txtCeldas.Name = "txtCeldas";
            this.txtCeldas.Size = new System.Drawing.Size(100, 20);
            this.txtCeldas.TabIndex = 44;
            this.txtCeldas.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Datos del concepto";
            // 
            // dvgTodosEmpleados
            // 
            this.dvgTodosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTodosEmpleados.Location = new System.Drawing.Point(12, 162);
            this.dvgTodosEmpleados.Name = "dvgTodosEmpleados";
            this.dvgTodosEmpleados.Size = new System.Drawing.Size(334, 322);
            this.dvgTodosEmpleados.TabIndex = 42;
            this.dvgTodosEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTodosEmpleados_CellContentClick);
            // 
            // btnAsignarTodosEmp
            // 
            this.btnAsignarTodosEmp.Location = new System.Drawing.Point(374, 234);
            this.btnAsignarTodosEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarTodosEmp.Name = "btnAsignarTodosEmp";
            this.btnAsignarTodosEmp.Size = new System.Drawing.Size(58, 27);
            this.btnAsignarTodosEmp.TabIndex = 41;
            this.btnAsignarTodosEmp.Text = ">>";
            this.btnAsignarTodosEmp.UseVisualStyleBackColor = true;
            this.btnAsignarTodosEmp.Click += new System.EventHandler(this.btnAsignarTodosEmp_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(365, 438);
            this.btnNuevaConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(77, 41);
            this.btnNuevaConsulta.TabIndex = 40;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Todos los empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(460, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Empleados asignados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(356, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Quitar Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(357, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Asignar Empleado";
            // 
            // btnAsignarUnEmpleado
            // 
            this.btnAsignarUnEmpleado.Location = new System.Drawing.Point(374, 203);
            this.btnAsignarUnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarUnEmpleado.Name = "btnAsignarUnEmpleado";
            this.btnAsignarUnEmpleado.Size = new System.Drawing.Size(58, 27);
            this.btnAsignarUnEmpleado.TabIndex = 34;
            this.btnAsignarUnEmpleado.Text = ">";
            this.btnAsignarUnEmpleado.UseVisualStyleBackColor = true;
            this.btnAsignarUnEmpleado.Click += new System.EventHandler(this.btnAsignarUnEmpleado_Click);
            // 
            // quitarunemp
            // 
            this.quitarunemp.Location = new System.Drawing.Point(373, 303);
            this.quitarunemp.Margin = new System.Windows.Forms.Padding(2);
            this.quitarunemp.Name = "quitarunemp";
            this.quitarunemp.Size = new System.Drawing.Size(58, 27);
            this.quitarunemp.TabIndex = 33;
            this.quitarunemp.Text = "<";
            this.quitarunemp.UseVisualStyleBackColor = true;
            this.quitarunemp.Click += new System.EventHandler(this.quitarunemp_Click);
            // 
            // quietatodosemp
            // 
            this.quietatodosemp.Location = new System.Drawing.Point(373, 335);
            this.quietatodosemp.Margin = new System.Windows.Forms.Padding(2);
            this.quietatodosemp.Name = "quietatodosemp";
            this.quietatodosemp.Size = new System.Drawing.Size(58, 27);
            this.quietatodosemp.TabIndex = 35;
            this.quietatodosemp.Text = "<<";
            this.quietatodosemp.UseVisualStyleBackColor = true;
            this.quietatodosemp.Click += new System.EventHandler(this.quietatodosemp_Click);
            // 
            // dvgDatosConcepto
            // 
            this.dvgDatosConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatosConcepto.Location = new System.Drawing.Point(43, 51);
            this.dvgDatosConcepto.Name = "dvgDatosConcepto";
            this.dvgDatosConcepto.Size = new System.Drawing.Size(669, 73);
            this.dvgDatosConcepto.TabIndex = 32;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(583, 9);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(97, 37);
            this.btnConsulta.TabIndex = 31;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // cbxIdConcepto
            // 
            this.cbxIdConcepto.FormattingEnabled = true;
            this.cbxIdConcepto.Location = new System.Drawing.Point(310, 18);
            this.cbxIdConcepto.Name = "cbxIdConcepto";
            this.cbxIdConcepto.Size = new System.Drawing.Size(121, 21);
            this.cbxIdConcepto.TabIndex = 47;
            this.cbxIdConcepto.Visible = false;
            this.cbxIdConcepto.SelectedIndexChanged += new System.EventHandler(this.cbxIdConcepto_SelectedIndexChanged);
            // 
            // cbxNombreConcepto
            // 
            this.cbxNombreConcepto.FormattingEnabled = true;
            this.cbxNombreConcepto.Location = new System.Drawing.Point(448, 18);
            this.cbxNombreConcepto.Name = "cbxNombreConcepto";
            this.cbxNombreConcepto.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreConcepto.TabIndex = 46;
            this.cbxNombreConcepto.SelectedIndexChanged += new System.EventHandler(this.cbxNombreConcepto_SelectedIndexChanged);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(743, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(55, 37);
            this.btnAyuda.TabIndex = 48;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAsignarSaldo
            // 
            this.btnAsignarSaldo.Location = new System.Drawing.Point(360, 376);
            this.btnAsignarSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarSaldo.Name = "btnAsignarSaldo";
            this.btnAsignarSaldo.Size = new System.Drawing.Size(85, 48);
            this.btnAsignarSaldo.TabIndex = 49;
            this.btnAsignarSaldo.Text = "Asignar Saldo Individual a Empleados";
            this.btnAsignarSaldo.UseVisualStyleBackColor = true;
            this.btnAsignarSaldo.Click += new System.EventHandler(this.btnAsignarSaldo_Click);
            // 
            // frmAsignacionEmpleadosaConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnAsignarSaldo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.cbxIdConcepto);
            this.Controls.Add(this.cbxNombreConcepto);
            this.Controls.Add(this.dvgEmpleadosAsignados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dvgTodosEmpleados);
            this.Controls.Add(this.btnAsignarTodosEmp);
            this.Controls.Add(this.btnNuevaConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAsignarUnEmpleado);
            this.Controls.Add(this.quitarunemp);
            this.Controls.Add(this.quietatodosemp);
            this.Controls.Add(this.dvgDatosConcepto);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtCeldas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAsignacionEmpleadosaConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2301 Asignacion de Empleados A Conceptos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleadosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatosConcepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEmpleadosAsignados;
        private System.Windows.Forms.TextBox txtCeldas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvgTodosEmpleados;
        private System.Windows.Forms.Button btnAsignarTodosEmp;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignarUnEmpleado;
        private System.Windows.Forms.Button quitarunemp;
        private System.Windows.Forms.Button quietatodosemp;
        private System.Windows.Forms.DataGridView dvgDatosConcepto;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cbxIdConcepto;
        private System.Windows.Forms.ComboBox cbxNombreConcepto;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnAsignarSaldo;
    }
}