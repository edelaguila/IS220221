
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
			this.txtJornada = new System.Windows.Forms.TextBox();
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
			this.cbxJornada = new System.Windows.Forms.ComboBox();
			this.pbFoto = new System.Windows.Forms.PictureBox();
			this.btnSelecionImagen = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtIdFoto = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxIDEmpresa
			// 
			this.cbxIDEmpresa.FormattingEnabled = true;
			this.cbxIDEmpresa.Location = new System.Drawing.Point(328, 445);
			this.cbxIDEmpresa.Name = "cbxIDEmpresa";
			this.cbxIDEmpresa.Size = new System.Drawing.Size(241, 21);
			this.cbxIDEmpresa.TabIndex = 86;
			this.cbxIDEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxIDEmpresa_SelectedIndexChanged);
			// 
			// cbxIDPuesto
			// 
			this.cbxIDPuesto.FormattingEnabled = true;
			this.cbxIDPuesto.Location = new System.Drawing.Point(328, 419);
			this.cbxIDPuesto.Name = "cbxIDPuesto";
			this.cbxIDPuesto.Size = new System.Drawing.Size(241, 21);
			this.cbxIDPuesto.TabIndex = 85;
			this.cbxIDPuesto.SelectedIndexChanged += new System.EventHandler(this.cbxIDPuesto_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Location = new System.Drawing.Point(324, 475);
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
			this.dtpFinContrato.Location = new System.Drawing.Point(329, 391);
			this.dtpFinContrato.Name = "dtpFinContrato";
			this.dtpFinContrato.Size = new System.Drawing.Size(240, 20);
			this.dtpFinContrato.TabIndex = 83;
			this.dtpFinContrato.ValueChanged += new System.EventHandler(this.dtpFinContrato_ValueChanged);
			// 
			// dtpFechaContratacion
			// 
			this.dtpFechaContratacion.Location = new System.Drawing.Point(328, 364);
			this.dtpFechaContratacion.Name = "dtpFechaContratacion";
			this.dtpFechaContratacion.Size = new System.Drawing.Size(241, 20);
			this.dtpFechaContratacion.TabIndex = 82;
			this.dtpFechaContratacion.ValueChanged += new System.EventHandler(this.dtpFechaContratacion_ValueChanged);
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(329, 182);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(241, 20);
			this.dtpFechaNacimiento.TabIndex = 81;
			this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
			// 
			// txtIDPuesto
			// 
			this.txtIDPuesto.Location = new System.Drawing.Point(328, 420);
			this.txtIDPuesto.Name = "txtIDPuesto";
			this.txtIDPuesto.Size = new System.Drawing.Size(63, 20);
			this.txtIDPuesto.TabIndex = 79;
			this.txtIDPuesto.Tag = "fkIdPuesto";
			this.txtIDPuesto.Visible = false;
			this.txtIDPuesto.TextChanged += new System.EventHandler(this.txtIDPuesto_TextChanged);
			// 
			// txtIDEmpresa
			// 
			this.txtIDEmpresa.Location = new System.Drawing.Point(328, 446);
			this.txtIDEmpresa.Name = "txtIDEmpresa";
			this.txtIDEmpresa.Size = new System.Drawing.Size(63, 20);
			this.txtIDEmpresa.TabIndex = 78;
			this.txtIDEmpresa.Tag = "fkIdEmpresa";
			this.txtIDEmpresa.Visible = false;
			this.txtIDEmpresa.TextChanged += new System.EventHandler(this.txtIDEmpresa_TextChanged);
			// 
			// lblIDPuesto
			// 
			this.lblIDPuesto.AutoSize = true;
			this.lblIDPuesto.Location = new System.Drawing.Point(215, 423);
			this.lblIDPuesto.Name = "lblIDPuesto";
			this.lblIDPuesto.Size = new System.Drawing.Size(57, 13);
			this.lblIDPuesto.TabIndex = 65;
			this.lblIDPuesto.Text = "ID Puesto:";
			// 
			// lblIDEmpresa
			// 
			this.lblIDEmpresa.AutoSize = true;
			this.lblIDEmpresa.Location = new System.Drawing.Point(213, 448);
			this.lblIDEmpresa.Name = "lblIDEmpresa";
			this.lblIDEmpresa.Size = new System.Drawing.Size(65, 13);
			this.lblIDEmpresa.TabIndex = 59;
			this.lblIDEmpresa.Text = "ID Empresa:";
			// 
			// txtFechaContratacion
			// 
			this.txtFechaContratacion.Location = new System.Drawing.Point(328, 364);
			this.txtFechaContratacion.Name = "txtFechaContratacion";
			this.txtFechaContratacion.Size = new System.Drawing.Size(63, 20);
			this.txtFechaContratacion.TabIndex = 77;
			this.txtFechaContratacion.Tag = "fechaContratacion";
			this.txtFechaContratacion.Visible = false;
			this.txtFechaContratacion.TextChanged += new System.EventHandler(this.txtFechaContratacion_TextChanged);
			// 
			// lblFechaContratacion
			// 
			this.lblFechaContratacion.AutoSize = true;
			this.lblFechaContratacion.Location = new System.Drawing.Point(214, 367);
			this.lblFechaContratacion.Name = "lblFechaContratacion";
			this.lblFechaContratacion.Size = new System.Drawing.Size(117, 13);
			this.lblFechaContratacion.TabIndex = 57;
			this.lblFechaContratacion.Text = "Fecha de contratación:";
			// 
			// txtAñosExperiencia
			// 
			this.txtAñosExperiencia.Location = new System.Drawing.Point(328, 312);
			this.txtAñosExperiencia.Name = "txtAñosExperiencia";
			this.txtAñosExperiencia.Size = new System.Drawing.Size(241, 20);
			this.txtAñosExperiencia.TabIndex = 76;
			this.txtAñosExperiencia.Tag = "añosDeExperiencia";
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(530, 475);
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
			this.lblAñosExperiencia.Location = new System.Drawing.Point(214, 315);
			this.lblAñosExperiencia.Name = "lblAñosExperiencia";
			this.lblAñosExperiencia.Size = new System.Drawing.Size(106, 13);
			this.lblAñosExperiencia.TabIndex = 55;
			this.lblAñosExperiencia.Text = "Años de experiencia:";
			// 
			// txtFinContrato
			// 
			this.txtFinContrato.Location = new System.Drawing.Point(329, 390);
			this.txtFinContrato.Name = "txtFinContrato";
			this.txtFinContrato.Size = new System.Drawing.Size(62, 20);
			this.txtFinContrato.TabIndex = 74;
			this.txtFinContrato.Tag = "finDeContrato";
			this.txtFinContrato.Visible = false;
			this.txtFinContrato.TextChanged += new System.EventHandler(this.txtFinContrato_TextChanged);
			// 
			// txtDirección
			// 
			this.txtDirección.Location = new System.Drawing.Point(328, 260);
			this.txtDirección.Name = "txtDirección";
			this.txtDirección.Size = new System.Drawing.Size(241, 20);
			this.txtDirección.TabIndex = 73;
			this.txtDirección.Tag = "direccion";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(328, 338);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(241, 20);
			this.txtTelefono.TabIndex = 72;
			this.txtTelefono.Tag = "telefono";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(214, 263);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(55, 13);
			this.lblDireccion.TabIndex = 53;
			this.lblDireccion.Text = "Dirección:";
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Location = new System.Drawing.Point(214, 478);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(45, 13);
			this.lblEstatus.TabIndex = 58;
			this.lblEstatus.Text = "Estatus:";
			// 
			// txtJornada
			// 
			this.txtJornada.Location = new System.Drawing.Point(329, 284);
			this.txtJornada.Name = "txtJornada";
			this.txtJornada.Size = new System.Drawing.Size(62, 20);
			this.txtJornada.TabIndex = 80;
			this.txtJornada.Tag = "fkIdJornada";
			this.txtJornada.Visible = false;
			this.txtJornada.TextChanged += new System.EventHandler(this.txtJornada_TextChanged);
			// 
			// lblFinContrato
			// 
			this.lblFinContrato.AutoSize = true;
			this.lblFinContrato.Location = new System.Drawing.Point(215, 397);
			this.lblFinContrato.Name = "lblFinContrato";
			this.lblFinContrato.Size = new System.Drawing.Size(82, 13);
			this.lblFinContrato.TabIndex = 66;
			this.lblFinContrato.Text = "Fin de Contrato:";
			// 
			// txtFechaNacimiento
			// 
			this.txtFechaNacimiento.Location = new System.Drawing.Point(328, 182);
			this.txtFechaNacimiento.Name = "txtFechaNacimiento";
			this.txtFechaNacimiento.Size = new System.Drawing.Size(63, 20);
			this.txtFechaNacimiento.TabIndex = 70;
			this.txtFechaNacimiento.Tag = "fechaDeNacimiento";
			this.txtFechaNacimiento.Visible = false;
			this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtFechaNacimiento_TextChanged);
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(214, 341);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(52, 13);
			this.lblTelefono.TabIndex = 54;
			this.lblTelefono.Text = "Telefono:";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(328, 234);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(241, 20);
			this.txtCorreo.TabIndex = 69;
			this.txtCorreo.Tag = "correo";
			// 
			// lblContratacion
			// 
			this.lblContratacion.AutoSize = true;
			this.lblContratacion.Location = new System.Drawing.Point(214, 289);
			this.lblContratacion.Name = "lblContratacion";
			this.lblContratacion.Size = new System.Drawing.Size(48, 13);
			this.lblContratacion.TabIndex = 56;
			this.lblContratacion.Text = "Jornada:";
			// 
			// lblFechaNacimiento
			// 
			this.lblFechaNacimiento.AutoSize = true;
			this.lblFechaNacimiento.Location = new System.Drawing.Point(214, 185);
			this.lblFechaNacimiento.Name = "lblFechaNacimiento";
			this.lblFechaNacimiento.Size = new System.Drawing.Size(112, 13);
			this.lblFechaNacimiento.TabIndex = 60;
			this.lblFechaNacimiento.Text = "Fecha de nacimiento: ";
			// 
			// lblCorreo
			// 
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.Location = new System.Drawing.Point(214, 237);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(41, 13);
			this.lblCorreo.TabIndex = 61;
			this.lblCorreo.Text = "Correo:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(328, 156);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(241, 20);
			this.txtApellido.TabIndex = 67;
			this.txtApellido.Tag = "apellido";
			// 
			// txtSueldo
			// 
			this.txtSueldo.Location = new System.Drawing.Point(328, 208);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(241, 20);
			this.txtSueldo.TabIndex = 68;
			this.txtSueldo.Tag = "sueldo";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(214, 159);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(52, 13);
			this.lblApellido.TabIndex = 62;
			this.lblApellido.Text = "Apellidos:";
			// 
			// lblSueldo
			// 
			this.lblSueldo.AutoSize = true;
			this.lblSueldo.Location = new System.Drawing.Point(214, 211);
			this.lblSueldo.Name = "lblSueldo";
			this.lblSueldo.Size = new System.Drawing.Size(43, 13);
			this.lblSueldo.TabIndex = 63;
			this.lblSueldo.Text = "Sueldo:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(328, 130);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(241, 20);
			this.txtNombre.TabIndex = 71;
			this.txtNombre.Tag = "nombre";
			this.txtNombre.EnabledChanged += new System.EventHandler(this.txtNombre_EnabledChanged);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(214, 133);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(55, 13);
			this.lblNombre.TabIndex = 64;
			this.lblNombre.Text = "Nombres: ";
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(0, -1);
			this.navegador1.Margin = new System.Windows.Forms.Padding(4);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 51;
			// 
			// lblIDEmpleado
			// 
			this.lblIDEmpleado.AutoSize = true;
			this.lblIDEmpleado.Location = new System.Drawing.Point(214, 107);
			this.lblIDEmpleado.Name = "lblIDEmpleado";
			this.lblIDEmpleado.Size = new System.Drawing.Size(71, 13);
			this.lblIDEmpleado.TabIndex = 64;
			this.lblIDEmpleado.Text = "ID Empleado:";
			// 
			// txtIDEmpleado
			// 
			this.txtIDEmpleado.Location = new System.Drawing.Point(328, 104);
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
			this.dgvVistaPrevia.Location = new System.Drawing.Point(591, 104);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(585, 410);
			this.dgvVistaPrevia.TabIndex = 87;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// cbxJornada
			// 
			this.cbxJornada.FormattingEnabled = true;
			this.cbxJornada.Location = new System.Drawing.Point(328, 284);
			this.cbxJornada.Name = "cbxJornada";
			this.cbxJornada.Size = new System.Drawing.Size(241, 21);
			this.cbxJornada.TabIndex = 88;
			this.cbxJornada.SelectedIndexChanged += new System.EventHandler(this.cbxJornada_SelectedIndexChanged);
			// 
			// pbFoto
			// 
			this.pbFoto.Location = new System.Drawing.Point(10, 107);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(198, 251);
			this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFoto.TabIndex = 89;
			this.pbFoto.TabStop = false;
			// 
			// btnSelecionImagen
			// 
			this.btnSelecionImagen.Location = new System.Drawing.Point(33, 367);
			this.btnSelecionImagen.Name = "btnSelecionImagen";
			this.btnSelecionImagen.Size = new System.Drawing.Size(152, 24);
			this.btnSelecionImagen.TabIndex = 90;
			this.btnSelecionImagen.Text = "Examinar";
			this.btnSelecionImagen.UseVisualStyleBackColor = true;
			this.btnSelecionImagen.Click += new System.EventHandler(this.btnSelecionImagen_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(33, 397);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(152, 23);
			this.btnGuardar.TabIndex = 91;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtIdFoto
			// 
			this.txtIdFoto.Location = new System.Drawing.Point(95, 426);
			this.txtIdFoto.Name = "txtIdFoto";
			this.txtIdFoto.Size = new System.Drawing.Size(32, 20);
			this.txtIdFoto.TabIndex = 67;
			this.txtIdFoto.Tag = "fotografia";
			this.txtIdFoto.Visible = false;
			this.txtIdFoto.TextChanged += new System.EventHandler(this.txtIdFoto_TextChanged);
			// 
			// frmEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 530);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtIDEmpresa);
			this.Controls.Add(this.txtIDPuesto);
			this.Controls.Add(this.txtFinContrato);
			this.Controls.Add(this.txtFechaContratacion);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtAñosExperiencia);
			this.Controls.Add(this.txtJornada);
			this.Controls.Add(this.txtDirección);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtSueldo);
			this.Controls.Add(this.txtFechaNacimiento);
			this.Controls.Add(this.txtIdFoto);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIDEmpleado);
			this.Controls.Add(this.cbxJornada);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.btnSelecionImagen);
			this.Controls.Add(this.btnGuardar);
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
			this.Text = "2105 Empleados";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
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
        private System.Windows.Forms.TextBox txtJornada;
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
        private System.Windows.Forms.ComboBox cbxJornada;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSelecionImagen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdFoto;
    }
}