namespace ProbeMedic.Controles
{
    partial class ucCuentaMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCuentaMayor));
            this.txt_D_Cuenta = new System.Windows.Forms.TextBox();
            this.btn_BuscaCuentaMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_D_Cuenta
            // 
            this.txt_D_Cuenta.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Cuenta.Location = new System.Drawing.Point(4, 3);
            this.txt_D_Cuenta.Name = "txt_D_Cuenta";
            this.txt_D_Cuenta.ReadOnly = true;
            this.txt_D_Cuenta.Size = new System.Drawing.Size(300, 24);
            this.txt_D_Cuenta.TabIndex = 26;
            this.txt_D_Cuenta.TabStop = false;
            // 
            // btn_BuscaCuentaMayor
            // 
            this.btn_BuscaCuentaMayor.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCuentaMayor.Image")));
            this.btn_BuscaCuentaMayor.Location = new System.Drawing.Point(310, 3);
            this.btn_BuscaCuentaMayor.Name = "btn_BuscaCuentaMayor";
            this.btn_BuscaCuentaMayor.Size = new System.Drawing.Size(27, 23);
            this.btn_BuscaCuentaMayor.TabIndex = 0;
            this.btn_BuscaCuentaMayor.TabStop = false;
            this.btn_BuscaCuentaMayor.UseVisualStyleBackColor = true;
            this.btn_BuscaCuentaMayor.Click += new System.EventHandler(this.btn_BuscaCuentaMayor_Click);
            // 
            // ucCuentaMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaCuentaMayor);
            this.Controls.Add(this.txt_D_Cuenta);
            this.Name = "ucCuentaMayor";
            this.Size = new System.Drawing.Size(339, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaCuentaMayor;
        private System.Windows.Forms.TextBox txt_D_Cuenta;
    }
}
