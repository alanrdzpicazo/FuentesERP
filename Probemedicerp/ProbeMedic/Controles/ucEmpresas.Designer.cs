namespace ProbeMedic.Controles
{
    partial class ucEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmpresas));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txt_D_Empresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(297, 3);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(28, 23);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txt_D_Empresa
            // 
            this.txt_D_Empresa.BackColor = System.Drawing.SystemColors.Control;
            this.txt_D_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_D_Empresa.Location = new System.Drawing.Point(2, 4);
            this.txt_D_Empresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_D_Empresa.Name = "txt_D_Empresa";
            this.txt_D_Empresa.ReadOnly = true;
            this.txt_D_Empresa.Size = new System.Drawing.Size(288, 23);
            this.txt_D_Empresa.TabIndex = 4;
            this.txt_D_Empresa.TabStop = false;
            // 
            // ucEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txt_D_Empresa);
            this.Name = "ucEmpresas";
            this.Size = new System.Drawing.Size(352, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txt_D_Empresa;
    }
}
