﻿namespace ProbeMedic.Controles
{
    partial class ucFamiliaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFamiliaArticulo));
            this.btn_BuscaFamArt = new System.Windows.Forms.Button();
            this.txtFamiliaArticulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaFamArt
            // 
            this.btn_BuscaFamArt.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaFamArt.Image")));
            this.btn_BuscaFamArt.Location = new System.Drawing.Point(186, 1);
            this.btn_BuscaFamArt.Name = "btn_BuscaFamArt";
            this.btn_BuscaFamArt.Size = new System.Drawing.Size(28, 23);
            this.btn_BuscaFamArt.TabIndex = 0;
            this.btn_BuscaFamArt.UseVisualStyleBackColor = true;
            this.btn_BuscaFamArt.Click += new System.EventHandler(this.btn_BuscaFamArt_Click);
            // 
            // txtFamiliaArticulo
            // 
            this.txtFamiliaArticulo.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtFamiliaArticulo.Location = new System.Drawing.Point(0, 1);
            this.txtFamiliaArticulo.Name = "txtFamiliaArticulo";
            this.txtFamiliaArticulo.ReadOnly = true;
            this.txtFamiliaArticulo.Size = new System.Drawing.Size(181, 24);
            this.txtFamiliaArticulo.TabIndex = 14;
            this.txtFamiliaArticulo.TabStop = false;

            // 
            // ucFamiliaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaFamArt);
            this.Controls.Add(this.txtFamiliaArticulo);
            this.Name = "ucFamiliaArticulo";
            this.Size = new System.Drawing.Size(236, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaFamArt;
        private System.Windows.Forms.TextBox txtFamiliaArticulo;
    }
}
