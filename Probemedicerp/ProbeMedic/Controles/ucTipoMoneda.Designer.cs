namespace ProbeMedic.Controles
{
    partial class ucTipoMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTipoMoneda));
            this.btn_BuscaTipoMoneda = new System.Windows.Forms.Button();
            this.txtTipoMoneda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaTipoMoneda
            // 
            this.btn_BuscaTipoMoneda.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaTipoMoneda.Image")));
            this.btn_BuscaTipoMoneda.Location = new System.Drawing.Point(184, 0);
            this.btn_BuscaTipoMoneda.Name = "btn_BuscaTipoMoneda";
            this.btn_BuscaTipoMoneda.Size = new System.Drawing.Size(28, 24);
            this.btn_BuscaTipoMoneda.TabIndex = 0;
            this.btn_BuscaTipoMoneda.UseVisualStyleBackColor = true;
            this.btn_BuscaTipoMoneda.Click += new System.EventHandler(this.btn_BuscaTipoMoneda_Click);
            // 
            // txtTipoMoneda
            // 
            this.txtTipoMoneda.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtTipoMoneda.Location = new System.Drawing.Point(1, 1);
            this.txtTipoMoneda.Name = "txtTipoMoneda";
            this.txtTipoMoneda.ReadOnly = true;
            this.txtTipoMoneda.Size = new System.Drawing.Size(181, 24);
            this.txtTipoMoneda.TabIndex = 18;
            this.txtTipoMoneda.TabStop = false;
            // 
            // ucTipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaTipoMoneda);
            this.Controls.Add(this.txtTipoMoneda);
            this.Name = "ucTipoMoneda";
            this.Size = new System.Drawing.Size(218, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaTipoMoneda;
        private System.Windows.Forms.TextBox txtTipoMoneda;
    }
}
