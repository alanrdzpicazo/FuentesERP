namespace ProbeMedic.Controles
{
    partial class ucAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAgente));
            this.btnBuscaraAsesor = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscaraAsesor
            // 
            this.btnBuscaraAsesor.BackColor = System.Drawing.Color.White;
            this.btnBuscaraAsesor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaraAsesor.Image")));
            this.btnBuscaraAsesor.Location = new System.Drawing.Point(314, 2);
            this.btnBuscaraAsesor.Name = "btnBuscaraAsesor";
            this.btnBuscaraAsesor.Size = new System.Drawing.Size(26, 24);
            this.btnBuscaraAsesor.TabIndex = 0;
            this.btnBuscaraAsesor.UseVisualStyleBackColor = false;
            this.btnBuscaraAsesor.Click += new System.EventHandler(this.btnBuscaraAsesor_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtNombre.Location = new System.Drawing.Point(1, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(313, 24);
            this.txtNombre.TabIndex = 1832233;
            this.txtNombre.TabStop = false;
            // 
            // ucAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscaraAsesor);
            this.Controls.Add(this.txtNombre);
            this.Name = "ucAgente";
            this.Size = new System.Drawing.Size(341, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaraAsesor;
        private System.Windows.Forms.TextBox txtNombre;
    }
}
