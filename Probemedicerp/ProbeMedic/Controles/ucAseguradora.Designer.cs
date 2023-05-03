namespace ProbeMedic.Controles
{
    partial class ucAseguradora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAseguradora));
            this.txt_Aseguradora = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Aseguradora
            // 
            this.txt_Aseguradora.Location = new System.Drawing.Point(4, 4);
            this.txt_Aseguradora.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Aseguradora.Name = "txt_Aseguradora";
            this.txt_Aseguradora.ReadOnly = true;
            this.txt_Aseguradora.Size = new System.Drawing.Size(202, 20);
            this.txt_Aseguradora.TabIndex = 8;
            this.txt_Aseguradora.TabStop = false;
            this.txt_Aseguradora.TextChanged += new System.EventHandler(this.txt_Aseguradora_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(210, 3);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(27, 21);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucAseguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txt_Aseguradora);
            this.Name = "ucAseguradora";
            this.Size = new System.Drawing.Size(240, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txt_Aseguradora;
    }
}
