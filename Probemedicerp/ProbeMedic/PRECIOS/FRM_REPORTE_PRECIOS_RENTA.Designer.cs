namespace ProbeMedic.CATALOGOS.PRECIOS
{
    partial class FRM_REPORTE_PRECIOS_RENTA
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
            this.dgvPreciosActuales = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreciosActuales
            // 
            this.dgvPreciosActuales.AllowUserToAddRows = false;
            this.dgvPreciosActuales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPreciosActuales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreciosActuales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreciosActuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreciosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreciosActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.Precio_Articulo,
            this.F_Alta,
            this.SKU});
            this.dgvPreciosActuales.Location = new System.Drawing.Point(0, 76);
            this.dgvPreciosActuales.MultiSelect = false;
            this.dgvPreciosActuales.Name = "dgvPreciosActuales";
            this.dgvPreciosActuales.ReadOnly = true;
            this.dgvPreciosActuales.RowTemplate.Height = 24;
            this.dgvPreciosActuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreciosActuales.Size = new System.Drawing.Size(1373, 534);
            this.dgvPreciosActuales.TabIndex = 2;
            this.dgvPreciosActuales.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1373, 26);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 141;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 96;
            // 
            // Precio_Articulo
            // 
            this.Precio_Articulo.DataPropertyName = "Precio_Articulo";
            this.Precio_Articulo.HeaderText = "Precio";
            this.Precio_Articulo.Name = "Precio_Articulo";
            this.Precio_Articulo.ReadOnly = true;
            this.Precio_Articulo.Width = 84;
            // 
            // F_Alta
            // 
            this.F_Alta.DataPropertyName = "F_Alta";
            this.F_Alta.HeaderText = "Fecha Actualizacion";
            this.F_Alta.Name = "F_Alta";
            this.F_Alta.ReadOnly = true;
            this.F_Alta.Width = 170;
            // 
            // SKU
            // 
            this.SKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 200;
            // 
            // FRM_REPORTE_PRECIOS_RENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 664);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvPreciosActuales);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FRM_REPORTE_PRECIOS_RENTA";
            this.Text = "Precios Actuales de Artículos en Renta";
            this.Load += new System.EventHandler(this.FFRM_REPORTE_PRECIOS_RENTA_Load);
            this.Controls.SetChildIndex(this.dgvPreciosActuales, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreciosActuales;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
    }
}