namespace ProbeMedic.Controles
{
    partial class ucIeps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucIeps));
            this.txtIeps = new System.Windows.Forms.TextBox();
            this.btn_BuscaIeps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIeps
            // 
            this.txtIeps.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtIeps.Location = new System.Drawing.Point(0, 0);
            this.txtIeps.Name = "txtIeps";
            this.txtIeps.ReadOnly = true;
            this.txtIeps.Size = new System.Drawing.Size(277, 24);
            this.txtIeps.TabIndex = 24;
            this.txtIeps.TabStop = false;
            // 
            // btn_BuscaIeps
            // 
            this.btn_BuscaIeps.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaIeps.Image")));
            this.btn_BuscaIeps.Location = new System.Drawing.Point(278, 0);
            this.btn_BuscaIeps.Name = "btn_BuscaIeps";
            this.btn_BuscaIeps.Size = new System.Drawing.Size(28, 24);
            this.btn_BuscaIeps.TabIndex = 23;
            this.btn_BuscaIeps.UseVisualStyleBackColor = true;
            this.btn_BuscaIeps.Click += new System.EventHandler(this.btn_BuscaIeps_Click);
            // 
            // ucIeps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaIeps);
            this.Controls.Add(this.txtIeps);
            this.Name = "ucIeps";
            this.Size = new System.Drawing.Size(308, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaIeps;
        private System.Windows.Forms.TextBox txtIeps;
    }
}
