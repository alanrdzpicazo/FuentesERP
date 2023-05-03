namespace ProbeMedic.Controles
{
    partial class ucCuentaNivel2
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCuentaNivel2));
            this.txt_D_Cuenta_Mayor = new System.Windows.Forms.TextBox();
            this.btn_BuscaCuentaMayor = new System.Windows.Forms.Button();
            this.btn_BuscaCuenta = new System.Windows.Forms.Button();
            this.txt_D_Cuenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_D_Cuenta_Mayor
            // 
            this.txt_D_Cuenta_Mayor.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Cuenta_Mayor.Location = new System.Drawing.Point(4, 3);
            this.txt_D_Cuenta_Mayor.Name = "txt_D_Cuenta_Mayor";
            this.txt_D_Cuenta_Mayor.ReadOnly = true;
            this.txt_D_Cuenta_Mayor.Size = new System.Drawing.Size(301, 24);
            this.txt_D_Cuenta_Mayor.TabIndex = 28;
            this.txt_D_Cuenta_Mayor.TabStop = false;
            // 
            // btn_BuscaCuentaMayor
            // 
            this.btn_BuscaCuentaMayor.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCuentaMayor.Image")));
            this.btn_BuscaCuentaMayor.Location = new System.Drawing.Point(311, 4);
            this.btn_BuscaCuentaMayor.Name = "btn_BuscaCuentaMayor";
            this.btn_BuscaCuentaMayor.Size = new System.Drawing.Size(27, 25);
            this.btn_BuscaCuentaMayor.TabIndex = 27;
            this.btn_BuscaCuentaMayor.UseVisualStyleBackColor = true;
            this.btn_BuscaCuentaMayor.Click += new System.EventHandler(this.btn_BuscaCuentaMayor_Click);
            // 
            // btn_BuscaCuenta
            // 
            this.btn_BuscaCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCuenta.Image")));
            this.btn_BuscaCuenta.Location = new System.Drawing.Point(311, 32);
            this.btn_BuscaCuenta.Name = "btn_BuscaCuenta";
            this.btn_BuscaCuenta.Size = new System.Drawing.Size(27, 25);
            this.btn_BuscaCuenta.TabIndex = 29;
            this.btn_BuscaCuenta.UseVisualStyleBackColor = true;
            this.btn_BuscaCuenta.Click += new System.EventHandler(this.btn_BuscaCuenta_Click);
            // 
            // txt_D_Cuenta
            // 
            this.txt_D_Cuenta.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Cuenta.Location = new System.Drawing.Point(4, 31);
            this.txt_D_Cuenta.Name = "txt_D_Cuenta";
            this.txt_D_Cuenta.ReadOnly = true;
            this.txt_D_Cuenta.Size = new System.Drawing.Size(301, 24);
            this.txt_D_Cuenta.TabIndex = 30;
            this.txt_D_Cuenta.TabStop = false;
            // 
            // ucCuentaNivel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaCuenta);
            this.Controls.Add(this.txt_D_Cuenta);
            this.Controls.Add(this.btn_BuscaCuentaMayor);
            this.Controls.Add(this.txt_D_Cuenta_Mayor);
            this.Name = "ucCuentaNivel2";
            this.Size = new System.Drawing.Size(338, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaCuentaMayor;
        private System.Windows.Forms.TextBox txt_D_Cuenta_Mayor;
        private System.Windows.Forms.Button btn_BuscaCuenta;
        private System.Windows.Forms.TextBox txt_D_Cuenta;
    }
}
