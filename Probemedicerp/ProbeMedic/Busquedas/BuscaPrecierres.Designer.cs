namespace ProbeMedic.Busquedas
{
    partial class BuscaPrecierres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Precierre_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Abierto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Monto_Total_Captura = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Precierre_Empleado,
            this.K_Almacen,
            this.D_Almacen,
            this.D_Oficina,
            this.D_Usuario,
            this.F_Apertura,
            this.F_Cierre,
            this.F_Aplicacion,
            this.B_Abierto,
            this.Monto_Total_Captura});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 92);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(932, 222);
            this.grdDatos.TabIndex = 4;
            // 
            // K_Precierre_Empleado
            // 
            this.K_Precierre_Empleado.DataPropertyName = "K_Precierre_Empleado";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.K_Precierre_Empleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.K_Precierre_Empleado.HeaderText = "No. Precierre";
            this.K_Precierre_Empleado.Name = "K_Precierre_Empleado";
            this.K_Precierre_Empleado.ReadOnly = true;
            this.K_Precierre_Empleado.Width = 111;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.ReadOnly = true;
            this.K_Almacen.Visible = false;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 84;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 73;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.HeaderText = "Usuario";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Width = 78;
            // 
            // F_Apertura
            // 
            this.F_Apertura.DataPropertyName = "F_Apertura";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Apertura.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_Apertura.HeaderText = "Fec. Apertura";
            this.F_Apertura.Name = "F_Apertura";
            this.F_Apertura.ReadOnly = true;
            this.F_Apertura.Width = 115;
            // 
            // F_Cierre
            // 
            this.F_Cierre.DataPropertyName = "F_Cierre";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Cierre.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Cierre.HeaderText = "Fec, Cierre";
            this.F_Cierre.Name = "F_Cierre";
            this.F_Cierre.ReadOnly = true;
            this.F_Cierre.Width = 97;
            // 
            // F_Aplicacion
            // 
            this.F_Aplicacion.DataPropertyName = "F_Aplicacion";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Aplicacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.F_Aplicacion.HeaderText = "Fec, Aplicación";
            this.F_Aplicacion.Name = "F_Aplicacion";
            this.F_Aplicacion.ReadOnly = true;
            this.F_Aplicacion.Width = 121;
            // 
            // B_Abierto
            // 
            this.B_Abierto.DataPropertyName = "B_Abierto";
            this.B_Abierto.HeaderText = "¿Abierto?";
            this.B_Abierto.Name = "B_Abierto";
            this.B_Abierto.ReadOnly = true;
            this.B_Abierto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Abierto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Abierto.Width = 90;
            // 
            // Monto_Total_Captura
            // 
            this.Monto_Total_Captura.DataPropertyName = "Monto_Total_Captura";
            dataGridViewCellStyle6.Format = "N2";
            this.Monto_Total_Captura.DefaultCellStyle = dataGridViewCellStyle6;
            this.Monto_Total_Captura.HeaderText = "Monto Total Captura";
            this.Monto_Total_Captura.Name = "Monto_Total_Captura";
            this.Monto_Total_Captura.ReadOnly = true;
            this.Monto_Total_Captura.Width = 159;
            // 
            // BuscaPrecierres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 353);
            this.Controls.Add(this.grdDatos);
            this.Name = "BuscaPrecierres";
            this.Text = "BuscaPrecierres";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precierre_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Aplicacion;
        private System.Windows.Forms.DataGridViewButtonColumn B_Abierto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total_Captura;
    }
}