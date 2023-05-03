namespace ProbeMedic.Controles
{
    partial class ucCategoriaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCategoriaArticulo));
            this.btn_BuscaCatArt = new System.Windows.Forms.Button();
            this.txtCatArt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaCatArt
            // 
            this.btn_BuscaCatArt.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCatArt.Image")));
            this.btn_BuscaCatArt.Location = new System.Drawing.Point(188, 1);
            this.btn_BuscaCatArt.Name = "btn_BuscaCatArt";
            this.btn_BuscaCatArt.Size = new System.Drawing.Size(28, 24);
            this.btn_BuscaCatArt.TabIndex = 0;
            this.btn_BuscaCatArt.UseVisualStyleBackColor = true;
            this.btn_BuscaCatArt.Click += new System.EventHandler(this.btn_BuscaCatArt_Click);
            // 
            // txtCatArt
            // 
            this.txtCatArt.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCatArt.Location = new System.Drawing.Point(2, 1);
            this.txtCatArt.Name = "txtCatArt";
            this.txtCatArt.ReadOnly = true;
            this.txtCatArt.Size = new System.Drawing.Size(181, 24);
            this.txtCatArt.TabIndex = 24;
            this.txtCatArt.TabStop = false;
            // 
            // ucCategoriaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaCatArt);
            this.Controls.Add(this.txtCatArt);
            this.Name = "ucCategoriaArticulo";
            this.Size = new System.Drawing.Size(236, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaCatArt;
        private System.Windows.Forms.TextBox txtCatArt;
    }
}
