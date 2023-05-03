namespace ProbeMedic.Controles
{
    partial class ucSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSeries));
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btn_BuscaSeries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtSerie.Location = new System.Drawing.Point(3, 2);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(164, 24);
            this.txtSerie.TabIndex = 30;
            this.txtSerie.TabStop = false;
            // 
            // btn_BuscaSeries
            // 
            this.btn_BuscaSeries.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaSeries.Image")));
            this.btn_BuscaSeries.Location = new System.Drawing.Point(172, 2);
            this.btn_BuscaSeries.Name = "btn_BuscaSeries";
            this.btn_BuscaSeries.Size = new System.Drawing.Size(27, 23);
            this.btn_BuscaSeries.TabIndex = 31;
            this.btn_BuscaSeries.UseVisualStyleBackColor = true;
            this.btn_BuscaSeries.Click += new System.EventHandler(this.btn_BuscaSeries_Click);
            // 
            // ucSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaSeries);
            this.Controls.Add(this.txtSerie);
            this.Name = "ucSeries";
            this.Size = new System.Drawing.Size(202, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaSeries;
        private System.Windows.Forms.TextBox txtSerie;
    }
}
