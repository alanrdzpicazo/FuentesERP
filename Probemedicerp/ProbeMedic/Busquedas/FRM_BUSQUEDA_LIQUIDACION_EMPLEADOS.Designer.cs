namespace ProbeMedic.Busquedas
{
    partial class FRM_BUSQUEDA_LIQUIDACION_EMPLEADOS
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
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.CLAVE_LIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA_LIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO_ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_APERTURA_LIQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO_RECIBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHEQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE_LIQUIDACION,
            this.OFICINA_LIQUIDACION,
            this.EMPLEADO_ENTREGA,
            this.F_APERTURA_LIQ,
            this.EMPLEADO_RECIBE,
            this.EFECTIVO,
            this.CHEQUE,
            this.TRANSFERENCIA});
            this.dgv_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datos.Location = new System.Drawing.Point(0, 92);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(882, 226);
            this.dgv_datos.TabIndex = 3;
            // 
            // CLAVE_LIQUIDACION
            // 
            this.CLAVE_LIQUIDACION.DataPropertyName = "CLAVE_LIQUIDACION";
            this.CLAVE_LIQUIDACION.HeaderText = "Clave liquidación";
            this.CLAVE_LIQUIDACION.Name = "CLAVE_LIQUIDACION";
            this.CLAVE_LIQUIDACION.ReadOnly = true;
            // 
            // OFICINA_LIQUIDACION
            // 
            this.OFICINA_LIQUIDACION.DataPropertyName = "OFICINA_LIQUIDACION";
            this.OFICINA_LIQUIDACION.HeaderText = "Oficina liquidación";
            this.OFICINA_LIQUIDACION.Name = "OFICINA_LIQUIDACION";
            this.OFICINA_LIQUIDACION.ReadOnly = true;
            // 
            // EMPLEADO_ENTREGA
            // 
            this.EMPLEADO_ENTREGA.DataPropertyName = "EMPLEADO_ENTREGA";
            this.EMPLEADO_ENTREGA.HeaderText = "Empleado entrega";
            this.EMPLEADO_ENTREGA.Name = "EMPLEADO_ENTREGA";
            this.EMPLEADO_ENTREGA.ReadOnly = true;
            // 
            // F_APERTURA_LIQ
            // 
            this.F_APERTURA_LIQ.DataPropertyName = "F_APERTURA_LIQ";
            this.F_APERTURA_LIQ.HeaderText = "Fecha apertura liquidación";
            this.F_APERTURA_LIQ.Name = "F_APERTURA_LIQ";
            this.F_APERTURA_LIQ.ReadOnly = true;
            // 
            // EMPLEADO_RECIBE
            // 
            this.EMPLEADO_RECIBE.DataPropertyName = "EMPLEADO_RECIBE";
            this.EMPLEADO_RECIBE.HeaderText = "Empleado recibe";
            this.EMPLEADO_RECIBE.Name = "EMPLEADO_RECIBE";
            this.EMPLEADO_RECIBE.ReadOnly = true;
            // 
            // EFECTIVO
            // 
            this.EFECTIVO.DataPropertyName = "EFECTIVO";
            this.EFECTIVO.HeaderText = "Efectivo";
            this.EFECTIVO.Name = "EFECTIVO";
            this.EFECTIVO.ReadOnly = true;
            // 
            // CHEQUE
            // 
            this.CHEQUE.DataPropertyName = "CHEQUE";
            this.CHEQUE.HeaderText = "Cheque";
            this.CHEQUE.Name = "CHEQUE";
            this.CHEQUE.ReadOnly = true;
            // 
            // TRANSFERENCIA
            // 
            this.TRANSFERENCIA.DataPropertyName = "TRANSFERENCIA";
            this.TRANSFERENCIA.HeaderText = "Transferencia";
            this.TRANSFERENCIA.Name = "TRANSFERENCIA";
            this.TRANSFERENCIA.ReadOnly = true;
            // 
            // FRM_BUSQUEDA_LIQUIDACION_EMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 357);
            this.Controls.Add(this.dgv_datos);
            this.Name = "FRM_BUSQUEDA_LIQUIDACION_EMPLEADOS";
            this.Text = "FRM_BUSQUEDA_LIQUIDACION_EMPLEADOS";
            this.Controls.SetChildIndex(this.dgv_datos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_LIQUIDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA_LIQUIDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_ENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_APERTURA_LIQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_RECIBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFECTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHEQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSFERENCIA;
    }
}