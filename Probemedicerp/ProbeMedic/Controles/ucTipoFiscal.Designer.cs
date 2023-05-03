namespace ProbeMedic.Controles
{
    partial class ucTipoFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTipoFiscal));
            this.btn_TipoFiscal = new System.Windows.Forms.Button();
            this.txt_D_Tipo_Fiscal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_TipoFiscal
            // 
            this.btn_TipoFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btn_TipoFiscal.Image")));
            this.btn_TipoFiscal.Location = new System.Drawing.Point(209, 0);
            this.btn_TipoFiscal.Name = "btn_TipoFiscal";
            this.btn_TipoFiscal.Size = new System.Drawing.Size(24, 23);
            this.btn_TipoFiscal.TabIndex = 0;
            this.btn_TipoFiscal.UseVisualStyleBackColor = true;
            this.btn_TipoFiscal.Click += new System.EventHandler(this.btn_TipoFiscal_Click);
            // 
            // txt_D_Tipo_Fiscal
            // 
            this.txt_D_Tipo_Fiscal.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Tipo_Fiscal.Location = new System.Drawing.Point(1, 1);
            this.txt_D_Tipo_Fiscal.Name = "txt_D_Tipo_Fiscal";
            this.txt_D_Tipo_Fiscal.ReadOnly = true;
            this.txt_D_Tipo_Fiscal.Size = new System.Drawing.Size(204, 24);
            this.txt_D_Tipo_Fiscal.TabIndex = 8;
            this.txt_D_Tipo_Fiscal.TabStop = false;
            // 
            // ucTipoFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TipoFiscal);
            this.Controls.Add(this.txt_D_Tipo_Fiscal);
            this.Name = "ucTipoFiscal";
            this.Size = new System.Drawing.Size(236, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TipoFiscal;
        private System.Windows.Forms.TextBox txt_D_Tipo_Fiscal;
    }
}
