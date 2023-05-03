namespace ProbeMedic.Controles
{
    partial class ucEmpresaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmpresaEntrega));
            this.txt_Empresa_Entrega = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Empresa_Entrega
            // 
            this.txt_Empresa_Entrega.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Empresa_Entrega.Location = new System.Drawing.Point(3, 1);
            this.txt_Empresa_Entrega.Name = "txt_Empresa_Entrega";
            this.txt_Empresa_Entrega.ReadOnly = true;
            this.txt_Empresa_Entrega.Size = new System.Drawing.Size(181, 24);
            this.txt_Empresa_Entrega.TabIndex = 28;
            this.txt_Empresa_Entrega.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(189, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(28, 22);
            this.Btn_Buscar.TabIndex = 0;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // ucEmpresaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.txt_Empresa_Entrega);
            this.Name = "ucEmpresaEntrega";
            this.Size = new System.Drawing.Size(220, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txt_Empresa_Entrega;
    }
}
