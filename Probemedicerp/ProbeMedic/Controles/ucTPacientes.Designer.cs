namespace ProbeMedic.Controles
{
    partial class ucTPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTPacientes));
            this.btn_BuscaTipoPaciente = new System.Windows.Forms.Button();
            this.txtTipoPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaTipoPaciente
            // 
            this.btn_BuscaTipoPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaTipoPaciente.Image")));
            this.btn_BuscaTipoPaciente.Location = new System.Drawing.Point(172, 3);
            this.btn_BuscaTipoPaciente.Name = "btn_BuscaTipoPaciente";
            this.btn_BuscaTipoPaciente.Size = new System.Drawing.Size(27, 23);
            this.btn_BuscaTipoPaciente.TabIndex = 0;
            this.btn_BuscaTipoPaciente.UseVisualStyleBackColor = true;
            this.btn_BuscaTipoPaciente.Click += new System.EventHandler(this.btn_BuscaTipoPaciente_Click);
            // 
            // txtTipoPaciente
            // 
            this.txtTipoPaciente.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtTipoPaciente.Location = new System.Drawing.Point(3, 3);
            this.txtTipoPaciente.Name = "txtTipoPaciente";
            this.txtTipoPaciente.ReadOnly = true;
            this.txtTipoPaciente.Size = new System.Drawing.Size(164, 24);
            this.txtTipoPaciente.TabIndex = 26;
            this.txtTipoPaciente.TabStop = false;
            // 
            // ucTPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BuscaTipoPaciente);
            this.Controls.Add(this.txtTipoPaciente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucTPacientes";
            this.Size = new System.Drawing.Size(202, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaTipoPaciente;
        private System.Windows.Forms.TextBox txtTipoPaciente;
    }
}
