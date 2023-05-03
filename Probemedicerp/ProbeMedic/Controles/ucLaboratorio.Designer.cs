namespace ProbeMedic.Controles
{
    partial class ucLaboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLaboratorio));
            this.btn_BuscaLaboratorio = new System.Windows.Forms.Button();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaLaboratorio
            // 
            this.btn_BuscaLaboratorio.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaLaboratorio.Image")));
            this.btn_BuscaLaboratorio.Location = new System.Drawing.Point(187, 2);
            this.btn_BuscaLaboratorio.Name = "btn_BuscaLaboratorio";
            this.btn_BuscaLaboratorio.Size = new System.Drawing.Size(28, 22);
            this.btn_BuscaLaboratorio.TabIndex = 0;
            this.btn_BuscaLaboratorio.UseVisualStyleBackColor = true;
            this.btn_BuscaLaboratorio.Click += new System.EventHandler(this.btn_BuscaLaboratorio_Click);
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtLaboratorio.Location = new System.Drawing.Point(1, 1);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.ReadOnly = true;
            this.txtLaboratorio.Size = new System.Drawing.Size(181, 24);
            this.txtLaboratorio.TabIndex = 14;
            this.txtLaboratorio.TabStop = false;
            // 
            // ucLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaLaboratorio);
            this.Controls.Add(this.txtLaboratorio);
            this.Name = "ucLaboratorio";
            this.Size = new System.Drawing.Size(220, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaLaboratorio;
        private System.Windows.Forms.TextBox txtLaboratorio;
    }
}
