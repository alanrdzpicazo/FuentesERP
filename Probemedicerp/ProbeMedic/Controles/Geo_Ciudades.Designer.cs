namespace ProbeMedic.Controles
{
    partial class Geo_Ciudades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geo_Ciudades));
            this.txt_D_Ciudad = new System.Windows.Forms.TextBox();
            this.txt_D_Estado = new System.Windows.Forms.TextBox();
            this.txt_D_Pais = new System.Windows.Forms.TextBox();
            this.btn_Ciudad = new System.Windows.Forms.Button();
            this.btn_Estado = new System.Windows.Forms.Button();
            this.btn_Pais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_D_Ciudad
            // 
            this.txt_D_Ciudad.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Ciudad.Location = new System.Drawing.Point(12, 71);
            this.txt_D_Ciudad.Name = "txt_D_Ciudad";
            this.txt_D_Ciudad.ReadOnly = true;
            this.txt_D_Ciudad.Size = new System.Drawing.Size(255, 24);
            this.txt_D_Ciudad.TabIndex = 91;
            this.txt_D_Ciudad.TabStop = false;
            // 
            // txt_D_Estado
            // 
            this.txt_D_Estado.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Estado.Location = new System.Drawing.Point(12, 37);
            this.txt_D_Estado.Name = "txt_D_Estado";
            this.txt_D_Estado.ReadOnly = true;
            this.txt_D_Estado.Size = new System.Drawing.Size(191, 24);
            this.txt_D_Estado.TabIndex = 90;
            this.txt_D_Estado.TabStop = false;
            // 
            // txt_D_Pais
            // 
            this.txt_D_Pais.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_D_Pais.Location = new System.Drawing.Point(12, 3);
            this.txt_D_Pais.Name = "txt_D_Pais";
            this.txt_D_Pais.ReadOnly = true;
            this.txt_D_Pais.Size = new System.Drawing.Size(191, 24);
            this.txt_D_Pais.TabIndex = 88;
            this.txt_D_Pais.TabStop = false;
            // 
            // btn_Ciudad
            // 
            this.btn_Ciudad.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ciudad.Image")));
            this.btn_Ciudad.Location = new System.Drawing.Point(273, 68);
            this.btn_Ciudad.Name = "btn_Ciudad";
            this.btn_Ciudad.Size = new System.Drawing.Size(24, 27);
            this.btn_Ciudad.TabIndex = 2;
            this.btn_Ciudad.UseVisualStyleBackColor = true;
            this.btn_Ciudad.Click += new System.EventHandler(this.btn_Ciudad_Click_1);
            // 
            // btn_Estado
            // 
            this.btn_Estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Estado.Image")));
            this.btn_Estado.Location = new System.Drawing.Point(216, 37);
            this.btn_Estado.Name = "btn_Estado";
            this.btn_Estado.Size = new System.Drawing.Size(24, 27);
            this.btn_Estado.TabIndex = 1;
            this.btn_Estado.UseVisualStyleBackColor = true;
            this.btn_Estado.Click += new System.EventHandler(this.btn_Estado_Click_1);
            // 
            // btn_Pais
            // 
            this.btn_Pais.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pais.Image")));
            this.btn_Pais.Location = new System.Drawing.Point(216, 3);
            this.btn_Pais.Name = "btn_Pais";
            this.btn_Pais.Size = new System.Drawing.Size(24, 27);
            this.btn_Pais.TabIndex = 0;
            this.btn_Pais.UseVisualStyleBackColor = true;
            this.btn_Pais.Click += new System.EventHandler(this.btn_Pais_Click_1);
            // 
            // Geo_Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_D_Ciudad);
            this.Controls.Add(this.btn_Ciudad);
            this.Controls.Add(this.btn_Estado);
            this.Controls.Add(this.txt_D_Estado);
            this.Controls.Add(this.btn_Pais);
            this.Controls.Add(this.txt_D_Pais);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Geo_Ciudades";
            this.Size = new System.Drawing.Size(306, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_D_Ciudad;
        private System.Windows.Forms.Button btn_Ciudad;
        private System.Windows.Forms.Button btn_Estado;
        private System.Windows.Forms.TextBox txt_D_Estado;
        private System.Windows.Forms.Button btn_Pais;
        private System.Windows.Forms.TextBox txt_D_Pais;
    }
}
