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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dbgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Anticipo_Cliente,
            this.F_Generacion,
            this.Monto_Total,
            this.D_Motivo_Anticipo_Cliente,
            this.K_Motivo_Anticipo_Cliente});
            this.dbgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgDatos.Location = new System.Drawing.Point(0, 38);
            this.dbgDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbgDatos.Name = "dbgDatos";
            this.dbgDatos.RowTemplate.Height = 24;
            this.dbgDatos.Size = new System.Drawing.Size(736, 469);
            this.dbgDatos.TabIndex = 3;
            this.dbgDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgDatos_KeyDown);
            this.dbgDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbgDatos_MouseDoubleClick);
            // 
            // K_Anticipo_Cliente
            // 
            this.K_Anticipo_Cliente.DataPropertyName = "K_Anticipo_Cliente";
            this.K_Anticipo_Cliente.HeaderText = "Clave Anticípo";
            this.K_Anticipo_Cliente.Name = "K_Anticipo_Cliente";
            // 
            // F_Generacion
            // 
            this.F_Generacion.DataPropertyName = "F_Generacion";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Generacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Generacion.HeaderText = "Fecha Anticípo";
            this.F_Generacion.Name = "F_Generacion";
            // 
            // Monto_Total
            // 
            this.Monto_Total.DataPropertyName = "Monto_Total";
            dataGridViewCellStyle3.Format = "N2";
            this.Monto_Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto_Total.HeaderText = "Monto ";
            this.Monto_Total.Name = "Monto_Total";
            // 
            // D_Motivo_Anticipo_Cliente
            // 
            this.D_Motivo_Anticipo_Cliente.DataPropertyName = "D_Motivo_Anticipo_Cliente";
            this.D_Motivo_Anticipo_Cliente.HeaderText = "Motivo Ant.";
            this.D_Motivo_Anticipo_Cliente.Name = "D_Motivo_Anticipo_Cliente";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 546);
            this.Controls.Add(this.dbgDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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