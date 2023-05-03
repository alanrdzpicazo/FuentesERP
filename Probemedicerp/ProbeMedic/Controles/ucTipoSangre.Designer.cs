namespace ProbeMedic.Controles
{
    partial class ucTipoSangre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTipoSangre));
            this.btn_BuscaTipoSangre = new System.Windows.Forms.Button();
            this.txtTipoSangre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaTipoSangre
            // 
            this.btn_BuscaTipoSangre.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaTipoSangre.Image")));
            this.btn_BuscaTipoSangre.Location = new System.Drawing.Point(172, 3);
            this.btn_BuscaTipoSangre.Name = "btn_BuscaTipoSangre";
            this.btn_BuscaTipoSangre.Size = new System.Drawing.Size(27, 23);
            this.btn_BuscaTipoSangre.TabIndex = 0;
            this.btn_BuscaTipoSangre.UseVisualStyleBackColor = true;
            this.btn_BuscaTipoSangre.Click += new System.EventHandler(this.btn_BuscaTipoSangre_Click);
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtTipoSangre.Location = new System.Drawing.Point(3, 3);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.ReadOnly = true;
            this.txtTipoSangre.Size = new System.Drawing.Size(164, 24);
            this.txtTipoSangre.TabIndex = 24;
            this.txtTipoSangre.TabStop = false;
            // 
            // ucTipoSangre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaTipoSangre);
            this.Controls.Add(this.txtTipoSangre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucTipoSangre";
            this.Size = new System.Drawing.Size(204, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaTipoSangre;
        private System.Windows.Forms.TextBox txtTipoSangre;
    }
}
