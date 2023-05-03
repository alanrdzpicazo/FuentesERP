namespace ProbeMedic.Controles
{
    partial class ucPacienteDireccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPacienteDireccion));
            this.txtPacienteDireccion = new System.Windows.Forms.TextBox();
            this.btnBuscarPacienteDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPacienteDireccion
            // 
            this.txtPacienteDireccion.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtPacienteDireccion.Location = new System.Drawing.Point(4, 2);
            this.txtPacienteDireccion.Name = "txtPacienteDireccion";
            this.txtPacienteDireccion.ReadOnly = true;
            this.txtPacienteDireccion.Size = new System.Drawing.Size(313, 24);
            this.txtPacienteDireccion.TabIndex = 20;
            this.txtPacienteDireccion.TabStop = false;
            // 
            // btnBuscarPacienteDireccion
            // 
            this.btnBuscarPacienteDireccion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPacienteDireccion.Image")));
            this.btnBuscarPacienteDireccion.Location = new System.Drawing.Point(323, 2);
            this.btnBuscarPacienteDireccion.Name = "btnBuscarPacienteDireccion";
            this.btnBuscarPacienteDireccion.Size = new System.Drawing.Size(26, 24);
            this.btnBuscarPacienteDireccion.TabIndex = 0;
            this.btnBuscarPacienteDireccion.UseVisualStyleBackColor = true;
            this.btnBuscarPacienteDireccion.Click += new System.EventHandler(this.btnBuscarPacienteDireccion_Click);
            // 
            // ucPacienteDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarPacienteDireccion);
            this.Controls.Add(this.txtPacienteDireccion);
            this.Name = "ucPacienteDireccion";
            this.Size = new System.Drawing.Size(353, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPacienteDireccion;
        private System.Windows.Forms.TextBox txtPacienteDireccion;
    }
}
