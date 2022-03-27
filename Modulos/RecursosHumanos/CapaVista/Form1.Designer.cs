
namespace CapaVista
{
	partial class MDIRecursosHumanos
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIRecursosHumanos));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// catalogosToolStripMenuItem
			// 
			this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
			this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
			this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.catalogosToolStripMenuItem.Text = "Catalogos";
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// ayudasToolStripMenuItem
			// 
			this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
			this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.ayudasToolStripMenuItem.Text = "Ayudas";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(688, 27);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Visible = false;
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
			// 
			// MDIRecursosHumanos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDIRecursosHumanos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recursos Humanos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MDIRecursosHumanos_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
	}
}

