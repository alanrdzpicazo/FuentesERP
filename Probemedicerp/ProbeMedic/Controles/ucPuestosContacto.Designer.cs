﻿namespace ProbeMedic.Controles
{
    partial class ucPuestosContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPuestosContacto));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txt_Puesto_Contacto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(210, 4);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(27, 23);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txt_Puesto_Contacto
            // 
            this.txt_Puesto_Contacto.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Puesto_Contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Puesto_Contacto.Location = new System.Drawing.Point(4, 6);
            this.txt_Puesto_Contacto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Puesto_Contacto.Name = "txt_Puesto_Contacto";
            this.txt_Puesto_Contacto.ReadOnly = true;
            this.txt_Puesto_Contacto.Size = new System.Drawing.Size(202, 23);
            this.txt_Puesto_Contacto.TabIndex = 10;
            this.txt_Puesto_Contacto.TabStop = false;
            // 
            // ucPuestosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txt_Puesto_Contacto);
            this.Name = "ucPuestosContacto";
            this.Size = new System.Drawing.Size(240, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txt_Puesto_Contacto;
    }
}
