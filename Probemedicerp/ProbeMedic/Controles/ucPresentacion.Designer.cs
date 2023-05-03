namespace ProbeMedic.Controles
{
    partial class ucPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPresentacion));
            this.btn_BuscaPresentacion = new System.Windows.Forms.Button();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaPresentacion
            // 
            this.btn_BuscaPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaPresentacion.Image")));
            this.btn_BuscaPresentacion.Location = new System.Drawing.Point(188, 1);
            this.btn_BuscaPresentacion.Name = "btn_BuscaPresentacion";
            this.btn_BuscaPresentacion.Size = new System.Drawing.Size(28, 23);
            this.btn_BuscaPresentacion.TabIndex = 0;
            this.btn_BuscaPresentacion.UseVisualStyleBackColor = true;
            this.btn_BuscaPresentacion.Click += new System.EventHandler(this.btn_BuscaPresentacion_Click);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtPresentacion.Location = new System.Drawing.Point(2, 1);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.ReadOnly = true;
            this.txtPresentacion.Size = new System.Drawing.Size(181, 24);
            this.txtPresentacion.TabIndex = 12;
            this.txtPresentacion.TabStop = false;
            // 
            // ucPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaPresentacion);
            this.Controls.Add(this.txtPresentacion);
            this.Name = "ucPresentacion";
            this.Size = new System.Drawing.Size(236, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaPresentacion;
        private System.Windows.Forms.TextBox txtPresentacion;
    }
}
