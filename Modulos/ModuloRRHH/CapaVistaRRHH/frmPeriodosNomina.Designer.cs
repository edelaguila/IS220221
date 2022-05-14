
namespace CapaVistaRRHH
{
    partial class frmPeriodosNomina
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriodosNomina));
			this.dgvPeriodos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.navegador1 = new DLL.nav.navegador();
			((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPeriodos
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPeriodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPeriodos.Location = new System.Drawing.Point(10, 36);
			this.dgvPeriodos.Name = "dgvPeriodos";
			this.dgvPeriodos.ReadOnly = true;
			this.dgvPeriodos.RowHeadersWidth = 51;
			this.dgvPeriodos.Size = new System.Drawing.Size(237, 319);
			this.dgvPeriodos.TabIndex = 1;
			this.dgvPeriodos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodos_RowHeaderMouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Seleccione un Periodo:";
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-518, -57);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 39);
			this.navegador1.TabIndex = 3;
			// 
			// frmPeriodosNomina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 366);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvPeriodos);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPeriodosNomina";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "2201 Periodo Nomina";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmPeriodosNomina_HelpButtonClicked);
			this.Load += new System.EventHandler(this.frmPeriodosNomina_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeriodos;
        private System.Windows.Forms.Label label1;
		private DLL.nav.navegador navegador1;
	}
}