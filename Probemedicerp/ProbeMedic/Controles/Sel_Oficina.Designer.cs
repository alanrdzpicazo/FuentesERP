namespace ProbeMedic.Controles
{
    partial class Sel_Oficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sel_Oficina));
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(3, 3);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.ReadOnly = true;
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 20);
            this.txtClaveOficina.TabIndex = 7;
            this.txtClaveOficina.TabStop = false;
            this.txtClaveOficina.Enter += new System.EventHandler(this.txtClaveOficina_Enter);
            this.txtClaveOficina.Leave += new System.EventHandler(this.txtClaveOficina_Leave);
            // 
            // txtOficina
            // 
            this.txtOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOficina.Location = new System.Drawing.Point(61, 3);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(297, 20);
            this.txtOficina.TabIndex = 8;
            this.txtOficina.TabStop = false;
            this.txtOficina.TextChanged += new System.EventHandler(this.txtOficina_TextChanged);
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(363, 1);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarOficina.TabIndex = 0;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // Sel_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarOficina);
            this.Controls.Add(this.txtClaveOficina);
            this.Controls.Add(this.txtOficina);
            this.Name = "Sel_Oficina";
            this.Size = new System.Drawing.Size(398, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Button btnBuscarOficina;
    }
}
