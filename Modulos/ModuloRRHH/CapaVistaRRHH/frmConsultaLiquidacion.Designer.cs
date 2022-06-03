
namespace CapaVistaRRHH
{
    partial class frmConsultaLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaLiquidacion));
            this.txtIdLiquidacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFinContrato = new System.Windows.Forms.DateTimePicker();
            this.txtIdFoto = new System.Windows.Forms.TextBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.dgvVista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUltimoPago = new System.Windows.Forms.TextBox();
            this.txtUltimoPeriodoVacaciones = new System.Windows.Forms.TextBox();
            this.dtpUltimoPago = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodoVacaiones = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtFinContrato = new System.Windows.Forms.TextBox();
            this.txtFechaContratacion = new System.Windows.Forms.TextBox();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtBonificacionIncentivo = new System.Windows.Forms.TextBox();
            this.txtVacacionesAnuales = new System.Windows.Forms.TextBox();
            this.txtHorasExtraordinarias = new System.Windows.Forms.TextBox();
            this.txtComisionesPromedio = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSalarioPromedio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblIDEmpresa = new System.Windows.Forms.Label();
            this.lblIDPuesto = new System.Windows.Forms.Label();
            this.lblFinContrato = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.lblContratacion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdLiquidacion
            // 
            this.txtIdLiquidacion.Enabled = false;
            this.txtIdLiquidacion.Location = new System.Drawing.Point(341, 25);
            this.txtIdLiquidacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdLiquidacion.Name = "txtIdLiquidacion";
            this.txtIdLiquidacion.Size = new System.Drawing.Size(197, 20);
            this.txtIdLiquidacion.TabIndex = 248;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 247;
            this.label3.Text = "ID Liquidación:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(873, 292);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(72, 36);
            this.btnImprimir.TabIndex = 212;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtRegresar
            // 
            this.txtRegresar.Location = new System.Drawing.Point(795, 292);
            this.txtRegresar.Name = "txtRegresar";
            this.txtRegresar.Size = new System.Drawing.Size(72, 36);
            this.txtRegresar.TabIndex = 210;
            this.txtRegresar.Text = "Regresar";
            this.txtRegresar.UseVisualStyleBackColor = true;
            this.txtRegresar.Click += new System.EventHandler(this.txtRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(612, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 246;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 21;
            this.rbnEstatusamodulo.TabStop = true;
            this.rbnEstatusamodulo.Text = "Activo";
            this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
            // 
            // rbnEstatusimodulo
            // 
            this.rbnEstatusimodulo.AutoSize = true;
            this.rbnEstatusimodulo.Location = new System.Drawing.Point(134, 7);
            this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
            this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
            this.rbnEstatusimodulo.TabIndex = 22;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(89, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(33, 20);
            this.txtEstado.TabIndex = 184;
            this.txtEstado.TabStop = false;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(551, 253);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 245;
            this.lblEstatus.Text = "Estatus:";
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Enabled = false;
            this.dtpFechaContratacion.Location = new System.Drawing.Point(341, 207);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaContratacion.TabIndex = 197;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Enabled = false;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(341, 128);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(196, 20);
            this.dtFechaNacimiento.TabIndex = 194;
            // 
            // dtpFinContrato
            // 
            this.dtpFinContrato.Enabled = false;
            this.dtpFinContrato.Location = new System.Drawing.Point(341, 233);
            this.dtpFinContrato.Name = "dtpFinContrato";
            this.dtpFinContrato.Size = new System.Drawing.Size(196, 20);
            this.dtpFinContrato.TabIndex = 198;
            this.dtpFinContrato.ValueChanged += new System.EventHandler(this.dtpFinContrato_ValueChanged);
            // 
            // txtIdFoto
            // 
            this.txtIdFoto.Location = new System.Drawing.Point(12, 19);
            this.txtIdFoto.Name = "txtIdFoto";
            this.txtIdFoto.Size = new System.Drawing.Size(32, 20);
            this.txtIdFoto.TabIndex = 244;
            this.txtIdFoto.TabStop = false;
            this.txtIdFoto.Tag = "fotografia";
            this.txtIdFoto.Visible = false;
            this.txtIdFoto.TextChanged += new System.EventHandler(this.txtIdFoto_TextChanged);
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 342);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(933, 224);
            this.dgvVistaPrevia.TabIndex = 243;
            // 
            // dgvVista
            // 
            this.dgvVista.AllowUserToAddRows = false;
            this.dgvVista.AllowUserToDeleteRows = false;
            this.dgvVista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVista.Location = new System.Drawing.Point(12, 342);
            this.dgvVista.Name = "dgvVista";
            this.dgvVista.ReadOnly = true;
            this.dgvVista.RowHeadersWidth = 51;
            this.dgvVista.Size = new System.Drawing.Size(664, 224);
            this.dgvVista.TabIndex = 242;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(727, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 237;
            this.label2.Text = "Q.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(727, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 236;
            this.label17.Text = "Q.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(345, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 238;
            this.label18.Text = "Q.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(727, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 239;
            this.label15.Text = "Q.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 240;
            this.label8.Text = "Salario Ordinario promedio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 241;
            this.label5.Text = "ID Empleado:";
            // 
            // txtUltimoPago
            // 
            this.txtUltimoPago.Enabled = false;
            this.txtUltimoPago.Location = new System.Drawing.Point(946, 43);
            this.txtUltimoPago.Name = "txtUltimoPago";
            this.txtUltimoPago.Size = new System.Drawing.Size(63, 20);
            this.txtUltimoPago.TabIndex = 235;
            this.txtUltimoPago.TabStop = false;
            this.txtUltimoPago.Tag = "";
            this.txtUltimoPago.Visible = false;
            this.txtUltimoPago.TextChanged += new System.EventHandler(this.txtUltimoPago_TextChanged);
            // 
            // txtUltimoPeriodoVacaciones
            // 
            this.txtUltimoPeriodoVacaciones.Enabled = false;
            this.txtUltimoPeriodoVacaciones.Location = new System.Drawing.Point(946, 15);
            this.txtUltimoPeriodoVacaciones.Name = "txtUltimoPeriodoVacaciones";
            this.txtUltimoPeriodoVacaciones.Size = new System.Drawing.Size(63, 20);
            this.txtUltimoPeriodoVacaciones.TabIndex = 234;
            this.txtUltimoPeriodoVacaciones.TabStop = false;
            this.txtUltimoPeriodoVacaciones.Tag = "fechaDeNacimiento";
            this.txtUltimoPeriodoVacaciones.Visible = false;
            this.txtUltimoPeriodoVacaciones.TextChanged += new System.EventHandler(this.txtUltimoPeriodoVacaciones_TextChanged);
            // 
            // dtpUltimoPago
            // 
            this.dtpUltimoPago.Enabled = false;
            this.dtpUltimoPago.Location = new System.Drawing.Point(747, 43);
            this.dtpUltimoPago.Name = "dtpUltimoPago";
            this.dtpUltimoPago.Size = new System.Drawing.Size(198, 20);
            this.dtpUltimoPago.TabIndex = 202;
            // 
            // dtpPeriodoVacaiones
            // 
            this.dtpPeriodoVacaiones.Enabled = false;
            this.dtpPeriodoVacaiones.Location = new System.Drawing.Point(747, 16);
            this.dtpPeriodoVacaiones.Name = "dtpPeriodoVacaiones";
            this.dtpPeriodoVacaiones.Size = new System.Drawing.Size(198, 20);
            this.dtpPeriodoVacaiones.TabIndex = 201;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(747, 195);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(198, 47);
            this.txtObservaciones.TabIndex = 208;
            this.txtObservaciones.Tag = "";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(341, 286);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(196, 20);
            this.txtEmpresa.TabIndex = 200;
            this.txtEmpresa.TabStop = false;
            this.txtEmpresa.Tag = "";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Location = new System.Drawing.Point(341, 259);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(196, 20);
            this.txtPuesto.TabIndex = 199;
            this.txtPuesto.TabStop = false;
            this.txtPuesto.Tag = "";
            // 
            // txtFinContrato
            // 
            this.txtFinContrato.Enabled = false;
            this.txtFinContrato.Location = new System.Drawing.Point(341, 233);
            this.txtFinContrato.Name = "txtFinContrato";
            this.txtFinContrato.Size = new System.Drawing.Size(165, 20);
            this.txtFinContrato.TabIndex = 231;
            this.txtFinContrato.TabStop = false;
            this.txtFinContrato.Tag = "";
            this.txtFinContrato.TextChanged += new System.EventHandler(this.txtFinContrato_TextChanged);
            // 
            // txtFechaContratacion
            // 
            this.txtFechaContratacion.Enabled = false;
            this.txtFechaContratacion.Location = new System.Drawing.Point(341, 207);
            this.txtFechaContratacion.Name = "txtFechaContratacion";
            this.txtFechaContratacion.Size = new System.Drawing.Size(165, 20);
            this.txtFechaContratacion.TabIndex = 232;
            this.txtFechaContratacion.TabStop = false;
            this.txtFechaContratacion.Tag = "";
            this.txtFechaContratacion.TextChanged += new System.EventHandler(this.txtFechaContratacion_TextChanged);
            // 
            // txtJornada
            // 
            this.txtJornada.Enabled = false;
            this.txtJornada.Location = new System.Drawing.Point(341, 180);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(196, 20);
            this.txtJornada.TabIndex = 196;
            this.txtJornada.Tag = "";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Location = new System.Drawing.Point(341, 153);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(196, 20);
            this.txtSueldo.TabIndex = 195;
            this.txtSueldo.Tag = "sueldo";
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(341, 128);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(165, 20);
            this.txtFechaNacimiento.TabIndex = 230;
            this.txtFechaNacimiento.TabStop = false;
            this.txtFechaNacimiento.Tag = "fechaDeNacimiento";
            this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtFechaNacimiento_TextChanged);
            // 
            // txtBonificacionIncentivo
            // 
            this.txtBonificacionIncentivo.Enabled = false;
            this.txtBonificacionIncentivo.Location = new System.Drawing.Point(747, 116);
            this.txtBonificacionIncentivo.Name = "txtBonificacionIncentivo";
            this.txtBonificacionIncentivo.Size = new System.Drawing.Size(198, 20);
            this.txtBonificacionIncentivo.TabIndex = 205;
            this.txtBonificacionIncentivo.Tag = "";
            this.txtBonificacionIncentivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVacacionesAnuales
            // 
            this.txtVacacionesAnuales.Enabled = false;
            this.txtVacacionesAnuales.Location = new System.Drawing.Point(747, 169);
            this.txtVacacionesAnuales.Name = "txtVacacionesAnuales";
            this.txtVacacionesAnuales.Size = new System.Drawing.Size(65, 20);
            this.txtVacacionesAnuales.TabIndex = 207;
            this.txtVacacionesAnuales.Tag = "";
            // 
            // txtHorasExtraordinarias
            // 
            this.txtHorasExtraordinarias.Enabled = false;
            this.txtHorasExtraordinarias.Location = new System.Drawing.Point(747, 142);
            this.txtHorasExtraordinarias.Name = "txtHorasExtraordinarias";
            this.txtHorasExtraordinarias.Size = new System.Drawing.Size(65, 20);
            this.txtHorasExtraordinarias.TabIndex = 206;
            this.txtHorasExtraordinarias.Tag = "";
            // 
            // txtComisionesPromedio
            // 
            this.txtComisionesPromedio.Enabled = false;
            this.txtComisionesPromedio.Location = new System.Drawing.Point(747, 93);
            this.txtComisionesPromedio.Name = "txtComisionesPromedio";
            this.txtComisionesPromedio.Size = new System.Drawing.Size(198, 20);
            this.txtComisionesPromedio.TabIndex = 204;
            this.txtComisionesPromedio.Tag = "";
            this.txtComisionesPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(341, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 20);
            this.txtApellido.TabIndex = 193;
            this.txtApellido.Tag = "apellido";
            // 
            // txtSalarioPromedio
            // 
            this.txtSalarioPromedio.Enabled = false;
            this.txtSalarioPromedio.Location = new System.Drawing.Point(747, 68);
            this.txtSalarioPromedio.Name = "txtSalarioPromedio";
            this.txtSalarioPromedio.Size = new System.Drawing.Size(198, 20);
            this.txtSalarioPromedio.TabIndex = 203;
            this.txtSalarioPromedio.Tag = "";
            this.txtSalarioPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(341, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 192;
            this.txtNombre.Tag = "nombre";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Enabled = false;
            this.txtIDEmpleado.Location = new System.Drawing.Point(341, 50);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(196, 20);
            this.txtIDEmpleado.TabIndex = 213;
            this.txtIDEmpleado.Tag = "pkIdEmpleado";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.BackgroundImage")));
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(12, 19);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(208, 253);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 233;
            this.pbFoto.TabStop = false;
            // 
            // lblIDEmpresa
            // 
            this.lblIDEmpresa.AutoSize = true;
            this.lblIDEmpresa.Location = new System.Drawing.Point(227, 292);
            this.lblIDEmpresa.Name = "lblIDEmpresa";
            this.lblIDEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblIDEmpresa.TabIndex = 216;
            this.lblIDEmpresa.Text = "Empresa:";
            // 
            // lblIDPuesto
            // 
            this.lblIDPuesto.AutoSize = true;
            this.lblIDPuesto.Location = new System.Drawing.Point(227, 265);
            this.lblIDPuesto.Name = "lblIDPuesto";
            this.lblIDPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblIDPuesto.TabIndex = 228;
            this.lblIDPuesto.Text = "Puesto:";
            // 
            // lblFinContrato
            // 
            this.lblFinContrato.AutoSize = true;
            this.lblFinContrato.Location = new System.Drawing.Point(227, 239);
            this.lblFinContrato.Name = "lblFinContrato";
            this.lblFinContrato.Size = new System.Drawing.Size(82, 13);
            this.lblFinContrato.TabIndex = 229;
            this.lblFinContrato.Text = "Fin de Contrato:";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(227, 213);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(117, 13);
            this.lblFechaContratacion.TabIndex = 215;
            this.lblFechaContratacion.Text = "Fecha de contratación:";
            // 
            // lblContratacion
            // 
            this.lblContratacion.AutoSize = true;
            this.lblContratacion.Location = new System.Drawing.Point(227, 186);
            this.lblContratacion.Name = "lblContratacion";
            this.lblContratacion.Size = new System.Drawing.Size(48, 13);
            this.lblContratacion.TabIndex = 214;
            this.lblContratacion.Text = "Jornada:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(227, 130);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaNacimiento.TabIndex = 217;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 222;
            this.label11.Text = "Bonificación incentivo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(549, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 220;
            this.label14.Text = "Observaciones:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 223;
            this.label10.Text = "Días de vacaciones anuales:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 221;
            this.label9.Text = "Horas extraordinarias sin pagar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 218;
            this.label7.Text = "Comisiones :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 226;
            this.label4.Text = "Fecha de pago:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(227, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 219;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(227, 156);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 13);
            this.lblSueldo.TabIndex = 224;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(227, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 13);
            this.lblNombre.TabIndex = 225;
            this.lblNombre.Text = "Nombres: ";
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(543, 22);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(198, 13);
            this.lblIDEmpleado.TabIndex = 227;
            this.lblIDEmpleado.Text = "Fecha del último periodo de vacaciones\t:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(148, -102);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 249;
            // 
            // frmConsultaLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 578);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtIdLiquidacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtRegresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.dtpFechaContratacion);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.dtpFinContrato);
            this.Controls.Add(this.txtIdFoto);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.dgvVista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUltimoPago);
            this.Controls.Add(this.txtUltimoPeriodoVacaciones);
            this.Controls.Add(this.dtpUltimoPago);
            this.Controls.Add(this.dtpPeriodoVacaiones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtFinContrato);
            this.Controls.Add(this.txtFechaContratacion);
            this.Controls.Add(this.txtJornada);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtBonificacionIncentivo);
            this.Controls.Add(this.txtVacacionesAnuales);
            this.Controls.Add(this.txtHorasExtraordinarias);
            this.Controls.Add(this.txtComisionesPromedio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtSalarioPromedio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lblIDEmpresa);
            this.Controls.Add(this.lblIDPuesto);
            this.Controls.Add(this.lblFinContrato);
            this.Controls.Add(this.lblFechaContratacion);
            this.Controls.Add(this.lblContratacion);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIDEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultaLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2316 Consulta Liquidación";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdLiquidacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button txtRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFinContrato;
        private System.Windows.Forms.TextBox txtIdFoto;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.DataGridView dgvVista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUltimoPago;
        private System.Windows.Forms.TextBox txtUltimoPeriodoVacaciones;
        private System.Windows.Forms.DateTimePicker dtpUltimoPago;
        private System.Windows.Forms.DateTimePicker dtpPeriodoVacaiones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtFinContrato;
        private System.Windows.Forms.TextBox txtFechaContratacion;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtBonificacionIncentivo;
        private System.Windows.Forms.TextBox txtVacacionesAnuales;
        private System.Windows.Forms.TextBox txtHorasExtraordinarias;
        private System.Windows.Forms.TextBox txtComisionesPromedio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSalarioPromedio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblIDEmpresa;
        private System.Windows.Forms.Label lblIDPuesto;
        private System.Windows.Forms.Label lblFinContrato;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblContratacion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDEmpleado;
        private DLL.nav.navegador navegador1;
    }
}