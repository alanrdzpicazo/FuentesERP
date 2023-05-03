namespace ProbeMedic.Busquedas
{
    partial class BuscaCFDI
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
            this.K_Uso_CFDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Uso_CFDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_SAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Uso_CFDI,
            this.D_Uso_CFDI,
            this.Clave_SAT});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 92);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(800, 319);
            this.grdDatos.TabIndex = 4;
            // 
            // K_Uso_CFDI
            // 
            this.K_Uso_CFDI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.K_Uso_CFDI.DataPropertyName = "K_Uso_CFDI";
            this.K_Uso_CFDI.HeaderText = "Clave";
            this.K_Uso_CFDI.Name = "K_Uso_CFDI";
            this.K_Uso_CFDI.ReadOnly = true;
            this.K_Uso_CFDI.Width = 266;
            // 
            // D_Uso_CFDI
            // 
            this.D_Uso_CFDI.DataPropertyName = "D_Uso_CFDI";
            this.D_Uso_CFDI.HeaderText = "Nombre";
            this.D_Uso_CFDI.Name = "D_Uso_CFDI";
            this.D_Uso_CFDI.ReadOnly = true;
            // 
            // Clave_SAT
            // 
            this.Clave_SAT.DataPropertyName = "Clave_SAT";
            this.Clave_SAT.HeaderText = "Clave SAT";
            this.Clave_SAT.Name = "Clave_SAT";
            this.Clave_SAT.ReadOnly = true;
            // 
            // BuscaCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdDatos);
            this.Name = "BuscaCFDI";
            this.Text = "Busca USO CFDI";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Uso_CFDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Uso_CFDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_SAT;
    }
}