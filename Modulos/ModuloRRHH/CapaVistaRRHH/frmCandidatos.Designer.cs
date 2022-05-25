
namespace CapaVistaRRHH
{
	partial class frmCandidatos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCandidatos));
			this.navegador1 = new DLL.nav.navegador();
			this.label1 = new System.Windows.Forms.Label();
			this.pbFoto = new System.Windows.Forms.PictureBox();
			this.txtIdFoto = new System.Windows.Forms.TextBox();
			this.btnSelecionImagen = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblIDEmpleado = new System.Windows.Forms.Label();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDPI = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rtxtExperiencia = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.rtxtReferencias = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.txtEstudios = new System.Windows.Forms.TextBox();
			this.rtxtEstudios = new System.Windows.Forms.RichTextBox();
			this.txtExperiencia = new System.Windows.Forms.TextBox();
			this.txtReferencias = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(1, -3);
			this.navegador1.Margin = new System.Windows.Forms.Padding(4);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 52;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(81, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 93;
			this.label1.Text = "Fotografía";
			// 
			// pbFoto
			// 
			this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbFoto.Location = new System.Drawing.Point(12, 104);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(198, 251);
			this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFoto.TabIndex = 94;
			this.pbFoto.TabStop = false;
			// 
			// txtIdFoto
			// 
			this.txtIdFoto.Location = new System.Drawing.Point(99, 419);
			this.txtIdFoto.Name = "txtIdFoto";
			this.txtIdFoto.Size = new System.Drawing.Size(32, 20);
			this.txtIdFoto.TabIndex = 95;
			this.txtIdFoto.TabStop = false;
			this.txtIdFoto.Tag = "fotografia";
			this.txtIdFoto.Visible = false;
			this.txtIdFoto.TextChanged += new System.EventHandler(this.txtIdFoto_TextChanged);
			// 
			// btnSelecionImagen
			// 
			this.btnSelecionImagen.Location = new System.Drawing.Point(37, 360);
			this.btnSelecionImagen.Name = "btnSelecionImagen";
			this.btnSelecionImagen.Size = new System.Drawing.Size(152, 24);
			this.btnSelecionImagen.TabIndex = 11;
			this.btnSelecionImagen.Text = "Examinar";
			this.btnSelecionImagen.UseVisualStyleBackColor = true;
			this.btnSelecionImagen.Click += new System.EventHandler(this.btnSelecionImagen_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(37, 390);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(152, 23);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(338, 153);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(241, 20);
			this.txtApellido.TabIndex = 2;
			this.txtApellido.Tag = "apellido";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(338, 127);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(241, 20);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.Tag = "nombre";
			this.txtNombre.EnabledChanged += new System.EventHandler(this.txtNombre_EnabledChanged);
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(338, 101);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(241, 20);
			this.txtID.TabIndex = 103;
			this.txtID.Tag = "pkid";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(224, 156);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(52, 13);
			this.lblApellido.TabIndex = 98;
			this.lblApellido.Text = "Apellidos:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(224, 130);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(55, 13);
			this.lblNombre.TabIndex = 99;
			this.lblNombre.Text = "Nombres: ";
			// 
			// lblIDEmpleado
			// 
			this.lblIDEmpleado.AutoSize = true;
			this.lblIDEmpleado.Location = new System.Drawing.Point(224, 104);
			this.lblIDEmpleado.Name = "lblIDEmpleado";
			this.lblIDEmpleado.Size = new System.Drawing.Size(71, 13);
			this.lblIDEmpleado.TabIndex = 100;
			this.lblIDEmpleado.Text = "ID Empleado:";
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 443);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(1164, 249);
			this.dgvVistaPrevia.TabIndex = 104;
			this.dgvVistaPrevia.TabStop = false;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(338, 179);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(241, 20);
			this.txtEdad.TabIndex = 3;
			this.txtEdad.Tag = "edad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(224, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 105;
			this.label2.Text = "Edad:";
			// 
			// txtDPI
			// 
			this.txtDPI.Location = new System.Drawing.Point(338, 205);
			this.txtDPI.Name = "txtDPI";
			this.txtDPI.Size = new System.Drawing.Size(241, 20);
			this.txtDPI.TabIndex = 4;
			this.txtDPI.Tag = "DPI";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 107;
			this.label3.Text = "DPI:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(338, 231);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(241, 20);
			this.txtTelefono.TabIndex = 5;
			this.txtTelefono.Tag = "telefono";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 109;
			this.label4.Text = "Teléfono:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(338, 257);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(241, 20);
			this.txtDireccion.TabIndex = 6;
			this.txtDireccion.Tag = "direccion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(224, 260);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 111;
			this.label5.Text = "Dirección:";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(338, 283);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(241, 20);
			this.txtCorreo.TabIndex = 7;
			this.txtCorreo.Tag = "correo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(224, 286);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 113;
			this.label6.Text = "Correo:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(224, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 115;
			this.label7.Text = "Estudios:";
			// 
			// rtxtExperiencia
			// 
			this.rtxtExperiencia.Enabled = false;
			this.rtxtExperiencia.Location = new System.Drawing.Point(710, 99);
			this.rtxtExperiencia.Name = "rtxtExperiencia";
			this.rtxtExperiencia.Size = new System.Drawing.Size(241, 96);
			this.rtxtExperiencia.TabIndex = 9;
			this.rtxtExperiencia.Tag = "";
			this.rtxtExperiencia.Text = "";
			this.rtxtExperiencia.EnabledChanged += new System.EventHandler(this.rtxtExperiencia_EnabledChanged);
			this.rtxtExperiencia.TextChanged += new System.EventHandler(this.rtxtExperiencia_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(596, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 117;
			this.label8.Text = "Experiencia:";
			// 
			// rtxtReferencias
			// 
			this.rtxtReferencias.Enabled = false;
			this.rtxtReferencias.Location = new System.Drawing.Point(710, 208);
			this.rtxtReferencias.Name = "rtxtReferencias";
			this.rtxtReferencias.Size = new System.Drawing.Size(241, 96);
			this.rtxtReferencias.TabIndex = 10;
			this.rtxtReferencias.Tag = "";
			this.rtxtReferencias.Text = "";
			this.rtxtReferencias.EnabledChanged += new System.EventHandler(this.rtxtReferencias_EnabledChanged);
			this.rtxtReferencias.TextChanged += new System.EventHandler(this.rtxtReferencias_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(596, 211);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 119;
			this.label9.Text = "Referencias:";
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(916, 312);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 122;
			this.txtEstado.TabStop = false;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Location = new System.Drawing.Point(710, 312);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 123;
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
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Location = new System.Drawing.Point(600, 315);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(45, 13);
			this.lblEstatus.TabIndex = 121;
			this.lblEstatus.Text = "Estatus:";
			// 
			// txtEstudios
			// 
			this.txtEstudios.Location = new System.Drawing.Point(603, 360);
			this.txtEstudios.Name = "txtEstudios";
			this.txtEstudios.Size = new System.Drawing.Size(29, 20);
			this.txtEstudios.TabIndex = 124;
			this.txtEstudios.TabStop = false;
			this.txtEstudios.Tag = "estudios";
			// 
			// rtxtEstudios
			// 
			this.rtxtEstudios.Enabled = false;
			this.rtxtEstudios.Location = new System.Drawing.Point(338, 309);
			this.rtxtEstudios.Name = "rtxtEstudios";
			this.rtxtEstudios.Size = new System.Drawing.Size(241, 96);
			this.rtxtEstudios.TabIndex = 8;
			this.rtxtEstudios.Tag = "";
			this.rtxtEstudios.Text = "";
			this.rtxtEstudios.EnabledChanged += new System.EventHandler(this.rtxtEstudios_EnabledChanged);
			this.rtxtEstudios.TextChanged += new System.EventHandler(this.rtxtEstudios_TextChanged);
			// 
			// txtExperiencia
			// 
			this.txtExperiencia.Location = new System.Drawing.Point(957, 130);
			this.txtExperiencia.Name = "txtExperiencia";
			this.txtExperiencia.Size = new System.Drawing.Size(165, 20);
			this.txtExperiencia.TabIndex = 125;
			this.txtExperiencia.TabStop = false;
			this.txtExperiencia.Tag = "experiencia";
			// 
			// txtReferencias
			// 
			this.txtReferencias.Location = new System.Drawing.Point(980, 257);
			this.txtReferencias.Name = "txtReferencias";
			this.txtReferencias.Size = new System.Drawing.Size(142, 20);
			this.txtReferencias.TabIndex = 126;
			this.txtReferencias.TabStop = false;
			this.txtReferencias.Tag = "referencias";
			// 
			// frmCandidatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 707);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtReferencias);
			this.Controls.Add(this.txtExperiencia);
			this.Controls.Add(this.txtEstudios);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDPI);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdFoto);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.rtxtExperiencia);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.rtxtEstudios);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblIDEmpleado);
			this.Controls.Add(this.btnSelecionImagen);
			this.Controls.Add(this.rtxtReferencias);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.navegador1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCandidatos";
			this.Text = "frmCandidatos";
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbFoto;
		private System.Windows.Forms.TextBox txtIdFoto;
		private System.Windows.Forms.Button btnSelecionImagen;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblIDEmpleado;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDPI;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox rtxtExperiencia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox rtxtReferencias;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnEstatusamodulo;
		private System.Windows.Forms.RadioButton rbnEstatusimodulo;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.TextBox txtEstudios;
		private System.Windows.Forms.RichTextBox rtxtEstudios;
		private System.Windows.Forms.TextBox txtExperiencia;
		private System.Windows.Forms.TextBox txtReferencias;
	}
}