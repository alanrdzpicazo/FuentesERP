﻿namespace ProbeMedic.Controles
{
    partial class ucIVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucIVA));
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.btn_BuscaIVA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtIVA.Location = new System.Drawing.Point(2, 1);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(181, 24);
            this.txtIVA.TabIndex = 22;
            this.txtIVA.TabStop = false;
            this.txtIVA.TextChanged += new System.EventHandler(this.txtIVA_TextChanged);
            // 
            // btn_BuscaIVA
            // 
            this.btn_BuscaIVA.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaIVA.Image")));
            this.btn_BuscaIVA.Location = new System.Drawing.Point(186, 1);
            this.btn_BuscaIVA.Name = "btn_BuscaIVA";
            this.btn_BuscaIVA.Size = new System.Drawing.Size(28, 21);
            this.btn_BuscaIVA.TabIndex = 0;
            this.btn_BuscaIVA.UseVisualStyleBackColor = true;
            this.btn_BuscaIVA.Click += new System.EventHandler(this.btn_BuscaIVA_Click);
            // 
            // ucIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaIVA);
            this.Controls.Add(this.txtIVA);
            this.Name = "ucIVA";
            this.Size = new System.Drawing.Size(222, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaIVA;
        private System.Windows.Forms.TextBox txtIVA;
    }
}
