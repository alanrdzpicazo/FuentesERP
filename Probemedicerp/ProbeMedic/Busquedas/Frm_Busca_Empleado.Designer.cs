namespace ProbeMedic.Busquedas
{
    partial class Frm_Busca_Empleado
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
            this.K_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.K_Empleado,
            this.D_Empleado,
            this.D_Oficina,
            this.D_Puesto,
            this.D_Departamento});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 92);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(808, 222);
            this.grdDatos.TabIndex = 3;
            // 
            // K_Empleado
            // 
            this.K_Empleado.DataPropertyName = "K_Empleado";
            this.K_Empleado.HeaderText = "Clave";
            this.K_Empleado.Name = "K_Empleado";
            this.K_Empleado.ReadOnly = true;
            // 
            // D_Empleado
            // 
            this.D_Empleado.DataPropertyName = "D_Empleado";
            this.D_Empleado.HeaderText = "Nombre";
            this.D_Empleado.Name = "D_Empleado";
            this.D_Empleado.ReadOnly = true;
            this.D_Empleado.Width = 400;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            // 
            // D_Puesto
            // 
            this.D_Puesto.DataPropertyName = "D_Puesto";
            this.D_Puesto.HeaderText = "Puesto";
            this.D_Puesto.Name = "D_Puesto";
            this.D_Puesto.ReadOnly = true;
            // 
            // D_Departamento
            // 
            this.D_Departamento.DataPropertyName = "D_Departamento";
            this.D_Departamento.HeaderText = "Departamento";
            this.D_Departamento.Name = "D_Departamento";
            this.D_Departamento.ReadOnly = true;
            // 
            // Frm_Busca_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 353);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_Busca_Empleado";
            this.Text = "Busca Empleados";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Departamento;
    }
}