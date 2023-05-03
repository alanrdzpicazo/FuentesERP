namespace ProbeMedic.Controles
{
    partial class ZonFE_Oficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZonFE_Oficina));
            this.txt_Z_Ciudad = new System.Windows.Forms.TextBox();
            this.txt_Z_Oficina = new System.Windows.Forms.TextBox();
            this.btn_Ciudad = new System.Windows.Forms.Button();
            this.btn_Estado = new System.Windows.Forms.Button();
            this.txt_Z_Estado = new System.Windows.Forms.TextBox();
            this.btn_Pais = new System.Windows.Forms.Button();
            this.txt_Z_Pais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Z_Ciudad
            // 
            this.txt_Z_Ciudad.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Z_Ciudad.Location = new System.Drawing.Point(3, 71);
            this.txt_Z_Ciudad.Name = "txt_Z_Ciudad";
            this.txt_Z_Ciudad.ReadOnly = true;
            this.txt_Z_Ciudad.Size = new System.Drawing.Size(255, 24);
            this.txt_Z_Ciudad.TabIndex = 102;
            this.txt_Z_Ciudad.TabStop = false;
            // 
            // txt_Z_Oficina
            // 
            this.txt_Z_Oficina.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Z_Oficina.Location = new System.Drawing.Point(3, 101);
            this.txt_Z_Oficina.Name = "txt_Z_Oficina";
            this.txt_Z_Oficina.ReadOnly = true;
            this.txt_Z_Oficina.Size = new System.Drawing.Size(255, 24);
            this.txt_Z_Oficina.TabIndex = 103;
            this.txt_Z_Oficina.TabStop = false;
            // 
            // btn_Ciudad
            // 
            this.btn_Ciudad.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ciudad.Image")));
            this.btn_Ciudad.Location = new System.Drawing.Point(260, 70);
            this.btn_Ciudad.Name = "btn_Ciudad";
            this.btn_Ciudad.Size = new System.Drawing.Size(24, 25);
            this.btn_Ciudad.TabIndex = 2;
            this.btn_Ciudad.UseVisualStyleBackColor = true;
            this.btn_Ciudad.Click += new System.EventHandler(this.btn_Ciudad_Click);
            // 
            // btn_Estado
            // 
            this.btn_Estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Estado.Image")));
            this.btn_Estado.Location = new System.Drawing.Point(196, 37);
            this.btn_Estado.Name = "btn_Estado";
            this.btn_Estado.Size = new System.Drawing.Size(24, 25);
            this.btn_Estado.TabIndex = 1;
            this.btn_Estado.UseVisualStyleBackColor = true;
            this.btn_Estado.Click += new System.EventHandler(this.btn_Estado_Click);
            // 
            // txt_Z_Estado
            // 
            this.txt_Z_Estado.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Z_Estado.Location = new System.Drawing.Point(3, 37);
            this.txt_Z_Estado.Name = "txt_Z_Estado";
            this.txt_Z_Estado.ReadOnly = true;
            this.txt_Z_Estado.Size = new System.Drawing.Size(191, 24);
            this.txt_Z_Estado.TabIndex = 101;
            this.txt_Z_Estado.TabStop = false;
            // 
            // btn_Pais
            // 
            this.btn_Pais.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pais.Image")));
            this.btn_Pais.Location = new System.Drawing.Point(196, 3);
            this.btn_Pais.Name = "btn_Pais";
            this.btn_Pais.Size = new System.Drawing.Size(24, 24);
            this.btn_Pais.TabIndex = 0;
            this.btn_Pais.UseVisualStyleBackColor = true;
            this.btn_Pais.Click += new System.EventHandler(this.btn_Pais_Click);
            // 
            // txt_Z_Pais
            // 
            this.txt_Z_Pais.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Z_Pais.Location = new System.Drawing.Point(3, 3);
            this.txt_Z_Pais.Name = "txt_Z_Pais";
            this.txt_Z_Pais.ReadOnly = true;
            this.txt_Z_Pais.Size = new System.Drawing.Size(191, 24);
            this.txt_Z_Pais.TabIndex = 98;
            this.txt_Z_Pais.TabStop = false;
            // 
            // ZonFE_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Z_Ciudad);
            this.Controls.Add(this.txt_Z_Oficina);
            this.Controls.Add(this.btn_Ciudad);
            this.Controls.Add(this.btn_Estado);
            this.Controls.Add(this.txt_Z_Estado);
            this.Controls.Add(this.btn_Pais);
            this.Controls.Add(this.txt_Z_Pais);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ZonFE_Oficina";
            this.Size = new System.Drawing.Size(289, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Z_Ciudad;
        private System.Windows.Forms.TextBox txt_Z_Oficina;
        private System.Windows.Forms.Button btn_Ciudad;
        private System.Windows.Forms.Button btn_Estado;
        private System.Windows.Forms.TextBox txt_Z_Estado;
        private System.Windows.Forms.Button btn_Pais;
        private System.Windows.Forms.TextBox txt_Z_Pais;
    }
}
