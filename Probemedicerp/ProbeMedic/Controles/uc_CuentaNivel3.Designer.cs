﻿namespace ProbeMedic.Controles
{
    partial class uc_CuentaNivel3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_CuentaNivel3));
            this.txt_D_Cuenta = new System.Windows.Forms.TextBox();
            this.txt_D_Cuenta_Mayor = new System.Windows.Forms.TextBox();
            this.txt_D_SubCuenta = new System.Windows.Forms.TextBox();
            this.btn_BuscaSubCuenta = new System.Windows.Forms.Button();
            this.btn_BuscaCuenta = new System.Windows.Forms.Button();
            this.btn_BuscaCuentaMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_D_Cuenta
            // 
            this.txt_D_Cuenta.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Cuenta.Location = new System.Drawing.Point(3, 31);
            this.txt_D_Cuenta.Name = "txt_D_Cuenta";
            this.txt_D_Cuenta.ReadOnly = true;
            this.txt_D_Cuenta.Size = new System.Drawing.Size(304, 24);
            this.txt_D_Cuenta.TabIndex = 34;
            this.txt_D_Cuenta.TabStop = false;
            // 
            // txt_D_Cuenta_Mayor
            // 
            this.txt_D_Cuenta_Mayor.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Cuenta_Mayor.Location = new System.Drawing.Point(3, 3);
            this.txt_D_Cuenta_Mayor.Name = "txt_D_Cuenta_Mayor";
            this.txt_D_Cuenta_Mayor.ReadOnly = true;
            this.txt_D_Cuenta_Mayor.Size = new System.Drawing.Size(304, 24);
            this.txt_D_Cuenta_Mayor.TabIndex = 32;
            this.txt_D_Cuenta_Mayor.TabStop = false;
            // 
            // txt_D_SubCuenta
            // 
            this.txt_D_SubCuenta.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_SubCuenta.Location = new System.Drawing.Point(3, 61);
            this.txt_D_SubCuenta.Name = "txt_D_SubCuenta";
            this.txt_D_SubCuenta.ReadOnly = true;
            this.txt_D_SubCuenta.Size = new System.Drawing.Size(304, 24);
            this.txt_D_SubCuenta.TabIndex = 36;
            this.txt_D_SubCuenta.TabStop = false;
            // 
            // btn_BuscaSubCuenta
            // 
            this.btn_BuscaSubCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaSubCuenta.Image")));
            this.btn_BuscaSubCuenta.Location = new System.Drawing.Point(310, 62);
            this.btn_BuscaSubCuenta.Name = "btn_BuscaSubCuenta";
            this.btn_BuscaSubCuenta.Size = new System.Drawing.Size(27, 25);
            this.btn_BuscaSubCuenta.TabIndex = 35;
            this.btn_BuscaSubCuenta.UseVisualStyleBackColor = true;
            this.btn_BuscaSubCuenta.Click += new System.EventHandler(this.btn_BuscaSubCuenta_Click);
            // 
            // btn_BuscaCuenta
            // 
            this.btn_BuscaCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCuenta.Image")));
            this.btn_BuscaCuenta.Location = new System.Drawing.Point(310, 32);
            this.btn_BuscaCuenta.Name = "btn_BuscaCuenta";
            this.btn_BuscaCuenta.Size = new System.Drawing.Size(30, 25);
            this.btn_BuscaCuenta.TabIndex = 33;
            this.btn_BuscaCuenta.UseVisualStyleBackColor = true;
            this.btn_BuscaCuenta.Click += new System.EventHandler(this.btn_BuscaCuenta_Click);
            // 
            // btn_BuscaCuentaMayor
            // 
            this.btn_BuscaCuentaMayor.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCuentaMayor.Image")));
            this.btn_BuscaCuentaMayor.Location = new System.Drawing.Point(310, 4);
            this.btn_BuscaCuentaMayor.Name = "btn_BuscaCuentaMayor";
            this.btn_BuscaCuentaMayor.Size = new System.Drawing.Size(30, 25);
            this.btn_BuscaCuentaMayor.TabIndex = 31;
            this.btn_BuscaCuentaMayor.UseVisualStyleBackColor = true;
            this.btn_BuscaCuentaMayor.Click += new System.EventHandler(this.btn_BuscaCuentaMayor_Click);
            // 
            // uc_CuentaNivel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaSubCuenta);
            this.Controls.Add(this.txt_D_SubCuenta);
            this.Controls.Add(this.btn_BuscaCuenta);
            this.Controls.Add(this.txt_D_Cuenta);
            this.Controls.Add(this.btn_BuscaCuentaMayor);
            this.Controls.Add(this.txt_D_Cuenta_Mayor);
            this.Name = "uc_CuentaNivel3";
            this.Size = new System.Drawing.Size(341, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaCuenta;
        private System.Windows.Forms.TextBox txt_D_Cuenta;
        private System.Windows.Forms.Button btn_BuscaCuentaMayor;
        private System.Windows.Forms.TextBox txt_D_Cuenta_Mayor;
        private System.Windows.Forms.Button btn_BuscaSubCuenta;
        private System.Windows.Forms.TextBox txt_D_SubCuenta;
    }
}
