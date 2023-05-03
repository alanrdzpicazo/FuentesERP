namespace ProbeMedic.Controles
{
    partial class ucCelulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCelulas));
            this.btn_BuscaCelula = new System.Windows.Forms.Button();
            this.txtCelula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaCelula
            // 
            this.btn_BuscaCelula.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCelula.Image")));
            this.btn_BuscaCelula.Location = new System.Drawing.Point(172, 3);
            this.btn_BuscaCelula.Name = "btn_BuscaCelula";
            this.btn_BuscaCelula.Size = new System.Drawing.Size(27, 23);
            this.btn_BuscaCelula.TabIndex = 0;
            this.btn_BuscaCelula.UseVisualStyleBackColor = true;
            this.btn_BuscaCelula.Click += new System.EventHandler(this.btn_BuscaCelula_Click);
            // 
            // txtCelula
            // 
            this.txtCelula.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCelula.Location = new System.Drawing.Point(3, 3);
            this.txtCelula.Name = "txtCelula";
            this.txtCelula.ReadOnly = true;
            this.txtCelula.Size = new System.Drawing.Size(164, 24);
            this.txtCelula.TabIndex = 26;
            this.txtCelula.TabStop = false;
            // 
            // ucCelulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaCelula);
            this.Controls.Add(this.txtCelula);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucCelulas";
            this.Size = new System.Drawing.Size(204, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaCelula;
        private System.Windows.Forms.TextBox txtCelula;
    }
}
