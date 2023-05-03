namespace ProbeMedic.Busquedas
{
    partial class BuscaProveedorCuentas
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Cuenta_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Clabe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaCompleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.K_Cuenta_Proveedor,
            this.K_Proveedor,
            this.D_Empresa,
            this.D_Banco,
            this.Numero_Cuenta,
            this.Cuenta_Clabe,
            this.CuentaCompleta});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 92);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(764, 165);
            this.grdDatos.TabIndex = 4;
            // 
            // K_Cuenta_Proveedor
            // 
            this.K_Cuenta_Proveedor.DataPropertyName = "K_Cuenta_Proveedor";
            this.K_Cuenta_Proveedor.HeaderText = "Clave";
            this.K_Cuenta_Proveedor.Name = "K_Cuenta_Proveedor";
            this.K_Cuenta_Proveedor.ReadOnly = true;
            this.K_Cuenta_Proveedor.Width = 80;
            // 
            // K_Proveedor
            // 
            this.K_Proveedor.DataPropertyName = "K_Proveedor";
            this.K_Proveedor.HeaderText = "Clave Proveedor";
            this.K_Proveedor.Name = "K_Proveedor";
            this.K_Proveedor.ReadOnly = true;
            this.K_Proveedor.Width = 300;
            // 
            // D_Empresa
            // 
            this.D_Empresa.DataPropertyName = "D_Empresa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.D_Empresa.DefaultCellStyle = dataGridViewCellStyle1;
            this.D_Empresa.HeaderText = "Proveedor";
            this.D_Empresa.Name = "D_Empresa";
            this.D_Empresa.ReadOnly = true;
            this.D_Empresa.Visible = false;
            this.D_Empresa.Width = 150;
            // 
            // D_Banco
            // 
            this.D_Banco.DataPropertyName = "D_Banco";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.D_Banco.DefaultCellStyle = dataGridViewCellStyle2;
            this.D_Banco.HeaderText = "Banco";
            this.D_Banco.Name = "D_Banco";
            this.D_Banco.ReadOnly = true;
            this.D_Banco.Width = 150;
            // 
            // Numero_Cuenta
            // 
            this.Numero_Cuenta.DataPropertyName = "Numero_Cuenta";
            this.Numero_Cuenta.HeaderText = "Num. Cuenta";
            this.Numero_Cuenta.Name = "Numero_Cuenta";
            this.Numero_Cuenta.ReadOnly = true;
            // 
            // Cuenta_Clabe
            // 
            this.Cuenta_Clabe.DataPropertyName = "Cuenta_Clabe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            this.Cuenta_Clabe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cuenta_Clabe.HeaderText = "Cuenta Clabe";
            this.Cuenta_Clabe.Name = "Cuenta_Clabe";
            this.Cuenta_Clabe.ReadOnly = true;
            // 
            // CuentaCompleta
            // 
            this.CuentaCompleta.DataPropertyName = "CuentaCompleta";
            this.CuentaCompleta.HeaderText = "CuentaCompleta";
            this.CuentaCompleta.Name = "CuentaCompleta";
            this.CuentaCompleta.ReadOnly = true;
            // 
            // BuscaProveedorCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 296);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "BuscaProveedorCuentas";
            this.Text = "BuscaProveedorCuentas";
            this.Load += new System.EventHandler(this.BuscaProveedorCuentas_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cuenta_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Clabe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaCompleta;
    }
}