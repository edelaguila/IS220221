
namespace CapaVistaMBancos
{
    partial class frmMantenimientoMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoMoneda));
            this.navegador1 = new DLL.nav.navegador();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.btnInhabilitado = new System.Windows.Forms.RadioButton();
            this.btnHabilitado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.gbxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Datos Moneda";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(249, 333);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(27, 20);
            this.txtEstado.TabIndex = 34;
            this.txtEstado.Tag = "Estado_Moneda";
            this.txtEstado.Visible = false;
            // 
            // gbxEstado
            // 
            this.gbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.gbxEstado.Controls.Add(this.btnInhabilitado);
            this.gbxEstado.Controls.Add(this.btnHabilitado);
            this.gbxEstado.Location = new System.Drawing.Point(43, 292);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(200, 100);
            this.gbxEstado.TabIndex = 33;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado Moneda";
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.Location = new System.Drawing.Point(115, 41);
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.btnInhabilitado.TabIndex = 4;
            this.btnInhabilitado.TabStop = true;
            this.btnInhabilitado.Text = "Inhabilitado";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            this.btnInhabilitado.CheckedChanged += new System.EventHandler(this.btnInhabilitado_CheckedChanged);
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.Location = new System.Drawing.Point(7, 41);
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.btnHabilitado.TabIndex = 3;
            this.btnHabilitado.TabStop = true;
            this.btnHabilitado.Text = "Habilitado";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            this.btnHabilitado.CheckedChanged += new System.EventHandler(this.btnHabilitado_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id Moneda";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.Tag = "nombreMoneda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Tag = "Pkid";
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(369, 131);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.Size = new System.Drawing.Size(833, 307);
            this.dvgConsulta.TabIndex = 36;
            this.dvgConsulta.SelectionChanged += new System.EventHandler(this.dvgConsulta_SelectionChanged);
            // 
            // frmMantenimientoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 450);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMantenimientoMoneda";
            this.Text = "frmMantenimientoMoneda";
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton btnInhabilitado;
        private System.Windows.Forms.RadioButton btnHabilitado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dvgConsulta;
    }
}