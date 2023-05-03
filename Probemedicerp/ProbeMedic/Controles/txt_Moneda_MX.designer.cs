namespace ProbeMedic.Controles
{
    partial class txt_Moneda_MX
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Moneda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Moneda
            // 
            this.Moneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Moneda.Font = new System.Drawing.Font("Arial", 10.5F);
            this.Moneda.Location = new System.Drawing.Point(2, 2);
            this.Moneda.Name = "Moneda";
            this.Moneda.Size = new System.Drawing.Size(117, 24);
            this.Moneda.TabIndex = 11;
            this.Moneda.Text = "0.00";
            this.Moneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Moneda.Enter += new System.EventHandler(this.Moneda_Enter);
            this.Moneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Moneda_KeyPress);
            this.Moneda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Moneda_KeyUp);
            this.Moneda.Leave += new System.EventHandler(this.Moneda_Leave);
            // 
            // txt_Moneda_MX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Moneda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "txt_Moneda_MX";
            this.Size = new System.Drawing.Size(121, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Moneda;

    }
}
