namespace ProbeMedic.Busquedas
{
    partial class BuscaClientesCuentas
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
            this.K_Cuenta_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Clabe = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.K_Cuenta_Cliente,
            this.K_Cliente,
            this.D_Cliente,
            this.D_Banco,
            this.Numero_Cuenta,
            this.Cuenta_Clabe});
            this.grdDatos.Location = new System.Drawing.Point(0, 106);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(1014, 218);
            this.grdDatos.TabIndex = 4;
            // 
            // K_Cuenta_Cliente
            // 
            this.K_Cuenta_Cliente.DataPropertyName = "K_Cuenta_Cliente";
            this.K_Cuenta_Cliente.HeaderText = "Clave";
            this.K_Cuenta_Cliente.Name = "K_Cuenta_Cliente";
            this.K_Cuenta_Cliente.ReadOnly = true;
            this.K_Cuenta_Cliente.Width = 80;
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "Clave Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            this.K_Cliente.Width = 300;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.D_Cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 150;
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
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Cuenta_Clabe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cuenta_Clabe.HeaderText = "Cuenta Clabe";
            this.Cuenta_Clabe.Name = "Cuenta_Clabe";
            this.Cuenta_Clabe.ReadOnly = true;
            // 
            // BuscaClientesCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 376);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "BuscaClientesCuentas";
            this.Text = "Busca Clientes Cuentas";
            this.Load += new System.EventHandler(this.BuscaClientesCuentas_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cuenta_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Clabe;
    }
}