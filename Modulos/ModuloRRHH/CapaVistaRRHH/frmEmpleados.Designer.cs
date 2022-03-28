
namespace CapaVistaRRHH
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.cbxIDEmpresa = new System.Windows.Forms.ComboBox();
            this.cbxIDPuesto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.dtpFinContrato = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtIDPuesto = new System.Windows.Forms.TextBox();
            this.txtIDEmpresa = new System.Windows.Forms.TextBox();
            this.lblIDPuesto = new System.Windows.Forms.Label();
            this.lblIDEmpresa = new System.Windows.Forms.Label();
            this.txtFechaContratacion = new System.Windows.Forms.TextBox();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.txtAñosExperiencia = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblAñosExperiencia = new System.Windows.Forms.Label();
            this.txtFinContrato = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtContratacion = new System.Windows.Forms.TextBox();
            this.lblFinContrato = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContratacion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIDEmpresa
            // 
            this.cbxIDEmpresa.FormattingEnabled = true;
            this.cbxIDEmpresa.Location = new System.Drawing.Point(61, 460);
            this.cbxIDEmpresa.Name = "cbxIDEmpresa";
            this.cbxIDEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbxIDEmpresa.TabIndex = 86;
            this.cbxIDEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxIDEmpresa_SelectedIndexChanged);
            // 
            // cbxIDPuesto
            // 
            this.cbxIDPuesto.FormattingEnabled = true;
            this.cbxIDPuesto.Location = new System.Drawing.Point(61, 433);
            this.cbxIDPuesto.Name = "cbxIDPuesto";
            this.cbxIDPuesto.Size = new System.Drawing.Size(121, 21);
            this.cbxIDPuesto.TabIndex = 85;
            this.cbxIDPuesto.SelectedIndexChanged += new System.EventHandler(this.cbxIDPuesto_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(324, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 84;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 8;
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
            this.rbnEstatusimodulo.TabIndex = 9;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // dtpFinContrato
            // 
            this.dtpFinContrato.Location = new System.Drawing.Point(12, 404);
            this.dtpFinContrato.Name = "dtpFinContrato";
            this.dtpFinContrato.Size = new System.Drawing.Size(197, 20);
            this.dtpFinContrato.TabIndex = 83;
            this.dtpFinContrato.ValueChanged += new System.EventHandler(this.dtpFinContrato_ValueChanged);
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(12, 371);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaContratacion.TabIndex = 82;
            this.dtpFechaContratacion.ValueChanged += new System.EventHandler(this.dtpFechaContratacion_ValueChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(12, 199);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaNacimiento.TabIndex = 81;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtIDPuesto
            // 
            this.txtIDPuesto.Location = new System.Drawing.Point(328, 434);
            this.txtIDPuesto.Name = "txtIDPuesto";
            this.txtIDPuesto.Size = new System.Drawing.Size(241, 20);
            this.txtIDPuesto.TabIndex = 79;
            this.txtIDPuesto.Tag = "fkIdPuesto";
            this.txtIDPuesto.TextChanged += new System.EventHandler(this.txtIDPuesto_TextChanged);
            // 
            // txtIDEmpresa
            // 
            this.txtIDEmpresa.Location = new System.Drawing.Point(328, 460);
            this.txtIDEmpresa.Name = "txtIDEmpresa";
            this.txtIDEmpresa.Size = new System.Drawing.Size(241, 20);
            this.txtIDEmpresa.TabIndex = 78;
            this.txtIDEmpresa.Tag = "fkIdEmpresa";
            this.txtIDEmpresa.TextChanged += new System.EventHandler(this.txtIDEmpresa_TextChanged);
            // 
            // lblIDPuesto
            // 
            this.lblIDPuesto.AutoSize = true;
            this.lblIDPuesto.Location = new System.Drawing.Point(215, 437);
            this.lblIDPuesto.Name = "lblIDPuesto";
            this.lblIDPuesto.Size = new System.Drawing.Size(57, 13);
            this.lblIDPuesto.TabIndex = 65;
            this.lblIDPuesto.Text = "ID Puesto:";
            // 
            // lblIDEmpresa
            // 
            this.lblIDEmpresa.AutoSize = true;
            this.lblIDEmpresa.Location = new System.Drawing.Point(213, 462);
            this.lblIDEmpresa.Name = "lblIDEmpresa";
            this.lblIDEmpresa.Size = new System.Drawing.Size(65, 13);
            this.lblIDEmpresa.TabIndex = 59;
            this.lblIDEmpresa.Text = "ID Empresa:";
            // 
            // txtFechaContratacion
            // 
            this.txtFechaContratacion.Location = new System.Drawing.Point(328, 378);
            this.txtFechaContratacion.Name = "txtFechaContratacion";
            this.txtFechaContratacion.Size = new System.Drawing.Size(241, 20);
            this.txtFechaContratacion.TabIndex = 77;
            this.txtFechaContratacion.Tag = "fechaContratacion";
            this.txtFechaContratacion.TextChanged += new System.EventHandler(this.txtFechaContratacion_TextChanged);
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(214, 381);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(117, 13);
            this.lblFechaContratacion.TabIndex = 57;
            this.lblFechaContratacion.Text = "Fecha de contratación:";
            // 
            // txtAñosExperiencia
            // 
            this.txtAñosExperiencia.Location = new System.Drawing.Point(328, 326);
            this.txtAñosExperiencia.Name = "txtAñosExperiencia";
            this.txtAñosExperiencia.Size = new System.Drawing.Size(241, 20);
            this.txtAñosExperiencia.TabIndex = 76;
            this.txtAñosExperiencia.Tag = "añosDeExperiencia";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(530, 489);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 75;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblAñosExperiencia
            // 
            this.lblAñosExperiencia.AutoSize = true;
            this.lblAñosExperiencia.Location = new System.Drawing.Point(214, 329);
            this.lblAñosExperiencia.Name = "lblAñosExperiencia";
            this.lblAñosExperiencia.Size = new System.Drawing.Size(106, 13);
            this.lblAñosExperiencia.TabIndex = 55;
            this.lblAñosExperiencia.Text = "Años de experiencia:";
            // 
            // txtFinContrato
            // 
            this.txtFinContrato.Location = new System.Drawing.Point(329, 404);
            this.txtFinContrato.Name = "txtFinContrato";
            this.txtFinContrato.Size = new System.Drawing.Size(241, 20);
            this.txtFinContrato.TabIndex = 74;
            this.txtFinContrato.Tag = "finDeContrato";
            this.txtFinContrato.TextChanged += new System.EventHandler(this.txtFinContrato_TextChanged);
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(328, 274);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(241, 20);
            this.txtDirección.TabIndex = 73;
            this.txtDirección.Tag = "direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(328, 352);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(241, 20);
            this.txtTelefono.TabIndex = 72;
            this.txtTelefono.Tag = "telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(214, 277);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(214, 492);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 58;
            this.lblEstatus.Text = "Estatus:";
            // 
            // txtContratacion
            // 
            this.txtContratacion.Location = new System.Drawing.Point(328, 300);
            this.txtContratacion.Name = "txtContratacion";
            this.txtContratacion.Size = new System.Drawing.Size(241, 20);
            this.txtContratacion.TabIndex = 80;
            this.txtContratacion.Tag = "contratado";
            // 
            // lblFinContrato
            // 
            this.lblFinContrato.AutoSize = true;
            this.lblFinContrato.Location = new System.Drawing.Point(215, 411);
            this.lblFinContrato.Name = "lblFinContrato";
            this.lblFinContrato.Size = new System.Drawing.Size(82, 13);
            this.lblFinContrato.TabIndex = 66;
            this.lblFinContrato.Text = "Fin de Contrato:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(328, 196);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(241, 20);
            this.txtFechaNacimiento.TabIndex = 70;
            this.txtFechaNacimiento.Tag = "fechaDeNacimiento";
            this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtFechaNacimiento_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(214, 355);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(328, 248);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 20);
            this.txtCorreo.TabIndex = 69;
            this.txtCorreo.Tag = "correo";
            // 
            // lblContratacion
            // 
            this.lblContratacion.AutoSize = true;
            this.lblContratacion.Location = new System.Drawing.Point(214, 303);
            this.lblContratacion.Name = "lblContratacion";
            this.lblContratacion.Size = new System.Drawing.Size(70, 13);
            this.lblContratacion.TabIndex = 56;
            this.lblContratacion.Text = "Contratación:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(214, 199);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaNacimiento.TabIndex = 60;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(214, 251);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 61;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(328, 170);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 20);
            this.txtApellido.TabIndex = 67;
            this.txtApellido.Tag = "apellido";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(328, 222);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(241, 20);
            this.txtSueldo.TabIndex = 68;
            this.txtSueldo.Tag = "sueldo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(214, 173);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 62;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(214, 225);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 13);
            this.lblSueldo.TabIndex = 63;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(328, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 20);
            this.txtNombre.TabIndex = 71;
            this.txtNombre.Tag = "nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(214, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 13);
            this.lblNombre.TabIndex = 64;
            this.lblNombre.Text = "Nombres: ";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 51;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(214, 121);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(71, 13);
            this.lblIDEmpleado.TabIndex = 64;
            this.lblIDEmpleado.Text = "ID Empleado:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(328, 118);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(241, 20);
            this.txtIDEmpleado.TabIndex = 71;
            this.txtIDEmpleado.Tag = "pkIdEmpleado";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(591, 118);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(566, 391);
            this.dgvVistaPrevia.TabIndex = 87;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 540);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtIDEmpresa);
            this.Controls.Add(this.txtIDPuesto);
            this.Controls.Add(this.txtFinContrato);
            this.Controls.Add(this.txtFechaContratacion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtAñosExperiencia);
            this.Controls.Add(this.txtContratacion);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.dtpFechaContratacion);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.dtpFinContrato);
            this.Controls.Add(this.cbxIDEmpresa);
            this.Controls.Add(this.cbxIDPuesto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblIDEmpresa);
            this.Controls.Add(this.lblIDPuesto);
            this.Controls.Add(this.lblFinContrato);
            this.Controls.Add(this.lblFechaContratacion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblAñosExperiencia);
            this.Controls.Add(this.lblContratacion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIDEmpleado);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIDEmpresa;
        private System.Windows.Forms.ComboBox cbxIDPuesto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.DateTimePicker dtpFinContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtIDPuesto;
        private System.Windows.Forms.TextBox txtIDEmpresa;
        private System.Windows.Forms.Label lblIDPuesto;
        private System.Windows.Forms.Label lblIDEmpresa;
        private System.Windows.Forms.TextBox txtFechaContratacion;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.TextBox txtAñosExperiencia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblAñosExperiencia;
        private System.Windows.Forms.TextBox txtFinContrato;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtContratacion;
        private System.Windows.Forms.Label lblFinContrato;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContratacion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
    }
}