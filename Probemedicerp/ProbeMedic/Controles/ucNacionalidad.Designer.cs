namespace ProbeMedic.Controles
{
    partial class ucNacionalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNacionalidad));
            this.btn_BuscaNacionalidad = new System.Windows.Forms.Button();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaNacionalidad
            // 
            this.btn_BuscaNacionalidad.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaNacionalidad.Image")));
            this.btn_BuscaNacionalidad.Location = new System.Drawing.Point(172, 3);
            this.btn_BuscaNacionalidad.Name = "btn_BuscaNacionalidad";
            this.btn_BuscaNacionalidad.Size = new System.Drawing.Size(27, 23);
            this.btn_BuscaNacionalidad.TabIndex = 0;
            this.btn_BuscaNacionalidad.UseVisualStyleBackColor = true;
            this.btn_BuscaNacionalidad.Click += new System.EventHandler(this.btn_BuscaNacionalidad_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtNacionalidad.Location = new System.Drawing.Point(3, 3);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.ReadOnly = true;
            this.txtNacionalidad.Size = new System.Drawing.Size(164, 24);
            this.txtNacionalidad.TabIndex = 26;
            this.txtNacionalidad.TabStop = false;
            // 
            // ucNacionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaNacionalidad);
            this.Controls.Add(this.txtNacionalidad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucNacionalidad";
            this.Size = new System.Drawing.Size(202, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidad;
    }
}
