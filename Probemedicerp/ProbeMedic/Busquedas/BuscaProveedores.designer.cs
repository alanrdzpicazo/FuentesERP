namespace ProbeMedic.Busquedas
{
    partial class BuscaProveedores
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Proveedor,
            this.RFC,
            this.Nombre});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 108);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(1184, 304);
            this.grdDatos.TabIndex = 2;
            // 
            // K_Proveedor
            // 
            this.K_Proveedor.DataPropertyName = "K_Proveedor";
            this.K_Proveedor.HeaderText = "Clave";
            this.K_Proveedor.Name = "K_Proveedor";
            this.K_Proveedor.ReadOnly = true;
            // 
            // RFC
            // 
            this.RFC.DataPropertyName = "RFC";
            this.RFC.HeaderText = "R.F.C.";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "D_Proveedor";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 700;
            // 
            // BuscaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 463);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.Name = "BuscaProveedores";
            this.Text = "Busca Proveedores";
            this.Controls.SetChildIndex(this.grdDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}