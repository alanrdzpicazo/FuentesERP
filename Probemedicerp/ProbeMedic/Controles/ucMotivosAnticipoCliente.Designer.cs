namespace ProbeMedic.Controles
{
    partial class ucMotivosAnticipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMotivosAnticipoCliente));
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnBuscarMotivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtMotivo.Location = new System.Drawing.Point(3, 3);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(256, 24);
            this.txtMotivo.TabIndex = 20;
            this.txtMotivo.TabStop = false;
            // 
            // btnBuscarMotivo
            // 
            this.btnBuscarMotivo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMotivo.Image")));
            this.btnBuscarMotivo.Location = new System.Drawing.Point(264, 3);
            this.btnBuscarMotivo.Name = "btnBuscarMotivo";
            this.btnBuscarMotivo.Size = new System.Drawing.Size(26, 24);
            this.btnBuscarMotivo.TabIndex = 0;
            this.btnBuscarMotivo.UseVisualStyleBackColor = true;
            this.btnBuscarMotivo.Click += new System.EventHandler(this.btnBuscarMotivo_Click);
            // 
            // ucMotivosAnticipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucMotivosAnticipoCliente";
            this.Size = new System.Drawing.Size(296, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}
