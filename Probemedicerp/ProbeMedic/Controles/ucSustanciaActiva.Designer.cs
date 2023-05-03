namespace ProbeMedic.Controles
{
    partial class ucSustanciaActiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSustanciaActiva));
            this.btn_BuscaSustanciaActiva = new System.Windows.Forms.Button();
            this.txtSustanciaActiva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaSustanciaActiva
            // 
            this.btn_BuscaSustanciaActiva.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaSustanciaActiva.Image")));
            this.btn_BuscaSustanciaActiva.Location = new System.Drawing.Point(188, 1);
            this.btn_BuscaSustanciaActiva.Name = "btn_BuscaSustanciaActiva";
            this.btn_BuscaSustanciaActiva.Size = new System.Drawing.Size(28, 23);
            this.btn_BuscaSustanciaActiva.TabIndex = 17;
            this.btn_BuscaSustanciaActiva.UseVisualStyleBackColor = true;
            this.btn_BuscaSustanciaActiva.Click += new System.EventHandler(this.btn_BuscaSustanciaActiva_Click);
            // 
            // txtSustanciaActiva
            // 
            this.txtSustanciaActiva.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtSustanciaActiva.Location = new System.Drawing.Point(2, 1);
            this.txtSustanciaActiva.Name = "txtSustanciaActiva";
            this.txtSustanciaActiva.ReadOnly = true;
            this.txtSustanciaActiva.Size = new System.Drawing.Size(181, 24);
            this.txtSustanciaActiva.TabIndex = 16;
            this.txtSustanciaActiva.TabStop = false;
            // 
            // ucSustanciaActiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaSustanciaActiva);
            this.Controls.Add(this.txtSustanciaActiva);
            this.Name = "ucSustanciaActiva";
            this.Size = new System.Drawing.Size(236, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaSustanciaActiva;
        private System.Windows.Forms.TextBox txtSustanciaActiva;
    }
}
