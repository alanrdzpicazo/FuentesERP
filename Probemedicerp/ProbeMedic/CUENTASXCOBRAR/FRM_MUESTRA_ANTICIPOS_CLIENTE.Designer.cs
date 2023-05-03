namespace ProbeMedic.CUENTASXCOBRAR
{
    partial class FRM_MUESTRA_ANTICIPOS_CLIENTE
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
            this.dbgDatos = new System.Windows.Forms.DataGridView();
            this.K_Anticipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Motivo_Anticipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Motivo_Anticipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgDatos
            // 
            this.dbgDatos.AllowUserToAddRows = false;
            this.dbgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Anticipo_Cliente,
            this.F_Generacion,
            this.Monto_Total,
            this.D_Motivo_Anticipo_Cliente,
            this.K_Motivo_Anticipo_Cliente});
            this.dbgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgDatos.Location = new System.Drawing.Point(0, 38);
            this.dbgDatos.Name = "dbgDatos";
            this.dbgDatos.RowTemplate.Height = 24;
            this.dbgDatos.Size = new System.Drawing.Size(946, 628);
            this.dbgDatos.TabIndex = 3;
            this.dbgDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgDatos_KeyDown);
            this.dbgDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbgDatos_MouseDoubleClick);
            // 
            // K_Anticipo_Cliente
            // 
            this.K_Anticipo_Cliente.DataPropertyName = "K_Anticipo_Cliente";
            this.K_Anticipo_Cliente.HeaderText = "Clave Anticipo";
            this.K_Anticipo_Cliente.Name = "K_Anticipo_Cliente";
            // 
            // F_Generacion
            // 
            this.F_Generacion.DataPropertyName = "F_Generacion";
            this.F_Generacion.HeaderText = "Fecha Anticipo";
            this.F_Generacion.Name = "F_Generacion";
            this.F_Generacion.Width = 150;
            // 
            // Monto_Total
            // 
            this.Monto_Total.DataPropertyName = "Monto_Total";
            this.Monto_Total.HeaderText = "Monto ";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.Width = 150;
            // 
            // D_Motivo_Anticipo_Cliente
            // 
            this.D_Motivo_Anticipo_Cliente.DataPropertyName = "D_Motivo_Anticipo_Cliente";
            this.D_Motivo_Anticipo_Cliente.HeaderText = "Motivo";
            this.D_Motivo_Anticipo_Cliente.Name = "D_Motivo_Anticipo_Cliente";
            this.D_Motivo_Anticipo_Cliente.Width = 300;
            // 
            // K_Motivo_Anticipo_Cliente
            // 
            this.K_Motivo_Anticipo_Cliente.DataPropertyName = "K_Motivo_Anticipo_Cliente";
            this.K_Motivo_Anticipo_Cliente.HeaderText = "K_Motivo_Anticipo_Cliente";
            this.K_Motivo_Anticipo_Cliente.Name = "K_Motivo_Anticipo_Cliente";
            this.K_Motivo_Anticipo_Cliente.Visible = false;
            // 
            // FRM_MUESTRA_ANTICIPOS_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 717);
            this.Controls.Add(this.dbgDatos);
            this.Name = "FRM_MUESTRA_ANTICIPOS_CLIENTE";
            this.Text = "ANTICIPOS CLIENTE";
            this.Load += new System.EventHandler(this.FRM_MUESTRA_ANTICIPOS_CLIENTE_Load);
            this.Controls.SetChildIndex(this.dbgDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Anticipo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Motivo_Anticipo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Motivo_Anticipo_Cliente;
    }
}