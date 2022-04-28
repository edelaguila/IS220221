
namespace CapaVistaRRHH
{
    partial class HistorialISR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialISR));
            this.rbnTodosReg = new System.Windows.Forms.RadioButton();
            this.rbnRegAnios = new System.Windows.Forms.RadioButton();
            this.rbnRegMes = new System.Windows.Forms.RadioButton();
            this.dgvHistorialISR = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.ckbEnero = new System.Windows.Forms.CheckBox();
            this.ckbFebrero = new System.Windows.Forms.CheckBox();
            this.ckbMarzo = new System.Windows.Forms.CheckBox();
            this.ckbJunio = new System.Windows.Forms.CheckBox();
            this.ckbMayo = new System.Windows.Forms.CheckBox();
            this.ckbAbril = new System.Windows.Forms.CheckBox();
            this.ckbSeptiembre = new System.Windows.Forms.CheckBox();
            this.ckbAgosto = new System.Windows.Forms.CheckBox();
            this.ckbJulio = new System.Windows.Forms.CheckBox();
            this.ckbDiciembre = new System.Windows.Forms.CheckBox();
            this.ckbNoviembre = new System.Windows.Forms.CheckBox();
            this.ckbOctubre = new System.Windows.Forms.CheckBox();
            this.rbnDetalleReg = new System.Windows.Forms.RadioButton();
            this.txtIdISR = new System.Windows.Forms.TextBox();
            this.lblRegAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnHabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialISR)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnTodosReg
            // 
            this.rbnTodosReg.AutoSize = true;
            this.rbnTodosReg.Location = new System.Drawing.Point(35, 26);
            this.rbnTodosReg.Name = "rbnTodosReg";
            this.rbnTodosReg.Size = new System.Drawing.Size(137, 17);
            this.rbnTodosReg.TabIndex = 1;
            this.rbnTodosReg.TabStop = true;
            this.rbnTodosReg.Text = "Filtrar todos los registros";
            this.rbnTodosReg.UseVisualStyleBackColor = true;
            this.rbnTodosReg.CheckedChanged += new System.EventHandler(this.rbnRegAños_CheckedChanged);
            // 
            // rbnRegAnios
            // 
            this.rbnRegAnios.AutoSize = true;
            this.rbnRegAnios.Location = new System.Drawing.Point(188, 26);
            this.rbnRegAnios.Name = "rbnRegAnios";
            this.rbnRegAnios.Size = new System.Drawing.Size(136, 17);
            this.rbnRegAnios.TabIndex = 2;
            this.rbnRegAnios.TabStop = true;
            this.rbnRegAnios.Text = "Filtrar registros por años";
            this.rbnRegAnios.UseVisualStyleBackColor = true;
            this.rbnRegAnios.CheckedChanged += new System.EventHandler(this.rbnRegAnios_CheckedChanged);
            // 
            // rbnRegMes
            // 
            this.rbnRegMes.AutoSize = true;
            this.rbnRegMes.Location = new System.Drawing.Point(472, 29);
            this.rbnRegMes.Name = "rbnRegMes";
            this.rbnRegMes.Size = new System.Drawing.Size(132, 17);
            this.rbnRegMes.TabIndex = 3;
            this.rbnRegMes.TabStop = true;
            this.rbnRegMes.Text = "Filtrar registros por mes";
            this.rbnRegMes.UseVisualStyleBackColor = true;
            this.rbnRegMes.CheckedChanged += new System.EventHandler(this.rbnRegMes_CheckedChanged);
            // 
            // dgvHistorialISR
            // 
            this.dgvHistorialISR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialISR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialISR.Location = new System.Drawing.Point(12, 187);
            this.dgvHistorialISR.Name = "dgvHistorialISR";
            this.dgvHistorialISR.Size = new System.Drawing.Size(917, 413);
            this.dgvHistorialISR.TabIndex = 4;
            this.dgvHistorialISR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialISR_CellContentClick);
            this.dgvHistorialISR.DoubleClick += new System.EventHandler(this.dgvHistorialISR_DoubleClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(836, 76);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(47, 46);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ckbEnero
            // 
            this.ckbEnero.AutoSize = true;
            this.ckbEnero.Location = new System.Drawing.Point(194, 72);
            this.ckbEnero.Name = "ckbEnero";
            this.ckbEnero.Size = new System.Drawing.Size(54, 17);
            this.ckbEnero.TabIndex = 6;
            this.ckbEnero.Text = "Enero";
            this.ckbEnero.UseVisualStyleBackColor = true;
            this.ckbEnero.CheckedChanged += new System.EventHandler(this.ckbEnero_CheckedChanged);
            // 
            // ckbFebrero
            // 
            this.ckbFebrero.AutoSize = true;
            this.ckbFebrero.Location = new System.Drawing.Point(194, 105);
            this.ckbFebrero.Name = "ckbFebrero";
            this.ckbFebrero.Size = new System.Drawing.Size(62, 17);
            this.ckbFebrero.TabIndex = 7;
            this.ckbFebrero.Text = "Febrero";
            this.ckbFebrero.UseVisualStyleBackColor = true;
            this.ckbFebrero.CheckedChanged += new System.EventHandler(this.ckbFebrero_CheckedChanged);
            // 
            // ckbMarzo
            // 
            this.ckbMarzo.AutoSize = true;
            this.ckbMarzo.Location = new System.Drawing.Point(194, 143);
            this.ckbMarzo.Name = "ckbMarzo";
            this.ckbMarzo.Size = new System.Drawing.Size(55, 17);
            this.ckbMarzo.TabIndex = 8;
            this.ckbMarzo.Text = "Marzo";
            this.ckbMarzo.UseVisualStyleBackColor = true;
            this.ckbMarzo.CheckedChanged += new System.EventHandler(this.ckbMarzo_CheckedChanged);
            // 
            // ckbJunio
            // 
            this.ckbJunio.AutoSize = true;
            this.ckbJunio.Location = new System.Drawing.Point(289, 143);
            this.ckbJunio.Name = "ckbJunio";
            this.ckbJunio.Size = new System.Drawing.Size(51, 17);
            this.ckbJunio.TabIndex = 11;
            this.ckbJunio.Text = "Junio";
            this.ckbJunio.UseVisualStyleBackColor = true;
            this.ckbJunio.CheckedChanged += new System.EventHandler(this.ckbJunio_CheckedChanged);
            // 
            // ckbMayo
            // 
            this.ckbMayo.AutoSize = true;
            this.ckbMayo.Location = new System.Drawing.Point(289, 105);
            this.ckbMayo.Name = "ckbMayo";
            this.ckbMayo.Size = new System.Drawing.Size(52, 17);
            this.ckbMayo.TabIndex = 10;
            this.ckbMayo.Text = "Mayo";
            this.ckbMayo.UseVisualStyleBackColor = true;
            this.ckbMayo.CheckedChanged += new System.EventHandler(this.ckbMayo_CheckedChanged);
            // 
            // ckbAbril
            // 
            this.ckbAbril.AutoSize = true;
            this.ckbAbril.Location = new System.Drawing.Point(289, 72);
            this.ckbAbril.Name = "ckbAbril";
            this.ckbAbril.Size = new System.Drawing.Size(46, 17);
            this.ckbAbril.TabIndex = 9;
            this.ckbAbril.Text = "Abril";
            this.ckbAbril.UseVisualStyleBackColor = true;
            this.ckbAbril.CheckedChanged += new System.EventHandler(this.ckbAbril_CheckedChanged);
            // 
            // ckbSeptiembre
            // 
            this.ckbSeptiembre.AutoSize = true;
            this.ckbSeptiembre.Location = new System.Drawing.Point(391, 143);
            this.ckbSeptiembre.Name = "ckbSeptiembre";
            this.ckbSeptiembre.Size = new System.Drawing.Size(79, 17);
            this.ckbSeptiembre.TabIndex = 14;
            this.ckbSeptiembre.Text = "Septiembre";
            this.ckbSeptiembre.UseVisualStyleBackColor = true;
            this.ckbSeptiembre.CheckedChanged += new System.EventHandler(this.ckbSeptiembre_CheckedChanged);
            // 
            // ckbAgosto
            // 
            this.ckbAgosto.AutoSize = true;
            this.ckbAgosto.Location = new System.Drawing.Point(391, 105);
            this.ckbAgosto.Name = "ckbAgosto";
            this.ckbAgosto.Size = new System.Drawing.Size(59, 17);
            this.ckbAgosto.TabIndex = 13;
            this.ckbAgosto.Text = "Agosto";
            this.ckbAgosto.UseVisualStyleBackColor = true;
            this.ckbAgosto.CheckedChanged += new System.EventHandler(this.ckbAgosto_CheckedChanged);
            // 
            // ckbJulio
            // 
            this.ckbJulio.AutoSize = true;
            this.ckbJulio.Location = new System.Drawing.Point(391, 72);
            this.ckbJulio.Name = "ckbJulio";
            this.ckbJulio.Size = new System.Drawing.Size(47, 17);
            this.ckbJulio.TabIndex = 12;
            this.ckbJulio.Text = "Julio";
            this.ckbJulio.UseVisualStyleBackColor = true;
            this.ckbJulio.CheckedChanged += new System.EventHandler(this.ckbJulio_CheckedChanged);
            // 
            // ckbDiciembre
            // 
            this.ckbDiciembre.AutoSize = true;
            this.ckbDiciembre.Location = new System.Drawing.Point(494, 143);
            this.ckbDiciembre.Name = "ckbDiciembre";
            this.ckbDiciembre.Size = new System.Drawing.Size(73, 17);
            this.ckbDiciembre.TabIndex = 17;
            this.ckbDiciembre.Text = "Diciembre";
            this.ckbDiciembre.UseVisualStyleBackColor = true;
            this.ckbDiciembre.CheckedChanged += new System.EventHandler(this.ckbDiciembre_CheckedChanged);
            // 
            // ckbNoviembre
            // 
            this.ckbNoviembre.AutoSize = true;
            this.ckbNoviembre.Location = new System.Drawing.Point(494, 105);
            this.ckbNoviembre.Name = "ckbNoviembre";
            this.ckbNoviembre.Size = new System.Drawing.Size(77, 17);
            this.ckbNoviembre.TabIndex = 16;
            this.ckbNoviembre.Text = "Noviembre";
            this.ckbNoviembre.UseVisualStyleBackColor = true;
            this.ckbNoviembre.CheckedChanged += new System.EventHandler(this.ckbNoviembre_CheckedChanged);
            // 
            // ckbOctubre
            // 
            this.ckbOctubre.AutoSize = true;
            this.ckbOctubre.Location = new System.Drawing.Point(494, 72);
            this.ckbOctubre.Name = "ckbOctubre";
            this.ckbOctubre.Size = new System.Drawing.Size(64, 17);
            this.ckbOctubre.TabIndex = 15;
            this.ckbOctubre.Text = "Octubre";
            this.ckbOctubre.UseVisualStyleBackColor = true;
            this.ckbOctubre.CheckedChanged += new System.EventHandler(this.ckbOctubre_CheckedChanged);
            // 
            // rbnDetalleReg
            // 
            this.rbnDetalleReg.AutoSize = true;
            this.rbnDetalleReg.Location = new System.Drawing.Point(637, 30);
            this.rbnDetalleReg.Name = "rbnDetalleReg";
            this.rbnDetalleReg.Size = new System.Drawing.Size(194, 17);
            this.rbnDetalleReg.TabIndex = 20;
            this.rbnDetalleReg.TabStop = true;
            this.rbnDetalleReg.Text = "Ver detalle por registro de empleado";
            this.rbnDetalleReg.UseVisualStyleBackColor = true;
            this.rbnDetalleReg.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtIdISR
            // 
            this.txtIdISR.Location = new System.Drawing.Point(836, 28);
            this.txtIdISR.Name = "txtIdISR";
            this.txtIdISR.Size = new System.Drawing.Size(74, 20);
            this.txtIdISR.TabIndex = 21;
            // 
            // lblRegAnio
            // 
            this.lblRegAnio.AutoSize = true;
            this.lblRegAnio.Location = new System.Drawing.Point(343, 10);
            this.lblRegAnio.Name = "lblRegAnio";
            this.lblRegAnio.Size = new System.Drawing.Size(92, 13);
            this.lblRegAnio.TabIndex = 23;
            this.lblRegAnio.Text = "Registros del año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(346, 26);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(86, 20);
            this.txtAnio.TabIndex = 24;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(610, 70);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(74, 20);
            this.txtMes.TabIndex = 25;
            this.txtMes.Visible = false;
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(609, 105);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 26;
            this.btnHabilitar.Text = "Ver otro mes";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // HistorialISR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 612);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblRegAnio);
            this.Controls.Add(this.txtIdISR);
            this.Controls.Add(this.rbnDetalleReg);
            this.Controls.Add(this.ckbDiciembre);
            this.Controls.Add(this.ckbNoviembre);
            this.Controls.Add(this.ckbOctubre);
            this.Controls.Add(this.ckbSeptiembre);
            this.Controls.Add(this.ckbAgosto);
            this.Controls.Add(this.ckbJulio);
            this.Controls.Add(this.ckbJunio);
            this.Controls.Add(this.ckbMayo);
            this.Controls.Add(this.ckbAbril);
            this.Controls.Add(this.ckbMarzo);
            this.Controls.Add(this.ckbFebrero);
            this.Controls.Add(this.ckbEnero);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvHistorialISR);
            this.Controls.Add(this.rbnRegMes);
            this.Controls.Add(this.rbnRegAnios);
            this.Controls.Add(this.rbnTodosReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistorialISR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3001 Historico ISR";
            this.Load += new System.EventHandler(this.HistorialISR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialISR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnTodosReg;
        private System.Windows.Forms.RadioButton rbnRegAnios;
        private System.Windows.Forms.RadioButton rbnRegMes;
        private System.Windows.Forms.DataGridView dgvHistorialISR;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox ckbEnero;
        private System.Windows.Forms.CheckBox ckbFebrero;
        private System.Windows.Forms.CheckBox ckbMarzo;
        private System.Windows.Forms.CheckBox ckbJunio;
        private System.Windows.Forms.CheckBox ckbMayo;
        private System.Windows.Forms.CheckBox ckbAbril;
        private System.Windows.Forms.CheckBox ckbSeptiembre;
        private System.Windows.Forms.CheckBox ckbAgosto;
        private System.Windows.Forms.CheckBox ckbJulio;
        private System.Windows.Forms.CheckBox ckbDiciembre;
        private System.Windows.Forms.CheckBox ckbNoviembre;
        private System.Windows.Forms.CheckBox ckbOctubre;
        private System.Windows.Forms.RadioButton rbnDetalleReg;
        private System.Windows.Forms.TextBox txtIdISR;
        private System.Windows.Forms.Label lblRegAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnHabilitar;
    }
}