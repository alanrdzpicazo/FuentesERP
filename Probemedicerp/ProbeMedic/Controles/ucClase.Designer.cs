namespace ProbeMedic.Controles
{
    partial class ucClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucClase));
            this.btn_TipoProducto = new System.Windows.Forms.Button();
            this.txt_TP_Tipo_Producto = new System.Windows.Forms.TextBox();
            this.btnBuscarClase = new System.Windows.Forms.Button();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_TipoProducto
            // 
            this.btn_TipoProducto.Location = new System.Drawing.Point(146, 63);
            this.btn_TipoProducto.Name = "btn_TipoProducto";
            this.btn_TipoProducto.Size = new System.Drawing.Size(28, 25);
            this.btn_TipoProducto.TabIndex = 13;
            this.btn_TipoProducto.Text = "...";
            this.btn_TipoProducto.UseVisualStyleBackColor = true;
            // 
            // txt_TP_Tipo_Producto
            // 
            this.txt_TP_Tipo_Producto.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_TP_Tipo_Producto.Location = new System.Drawing.Point(-24, 63);
            this.txt_TP_Tipo_Producto.Name = "txt_TP_Tipo_Producto";
            this.txt_TP_Tipo_Producto.Size = new System.Drawing.Size(168, 24);
            this.txt_TP_Tipo_Producto.TabIndex = 12;
            // 
            // btnBuscarClase
            // 
            this.btnBuscarClase.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClase.Image")));
            this.btnBuscarClase.Location = new System.Drawing.Point(187, 2);
            this.btnBuscarClase.Name = "btnBuscarClase";
            this.btnBuscarClase.Size = new System.Drawing.Size(28, 21);
            this.btnBuscarClase.TabIndex = 0;
            this.btnBuscarClase.UseVisualStyleBackColor = true;
            this.btnBuscarClase.Click += new System.EventHandler(this.btnBuscarClase_Click);
            // 
            // txtClase
            // 
            this.txtClase.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtClase.Location = new System.Drawing.Point(1, 1);
            this.txtClase.Name = "txtClase";
            this.txtClase.ReadOnly = true;
            this.txtClase.Size = new System.Drawing.Size(181, 24);
            this.txtClase.TabIndex = 14;
            this.txtClase.TabStop = false;
            // 
            // ucClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarClase);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.btn_TipoProducto);
            this.Controls.Add(this.txt_TP_Tipo_Producto);
            this.Name = "ucClase";
            this.Size = new System.Drawing.Size(236, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TipoProducto;
        private System.Windows.Forms.TextBox txt_TP_Tipo_Producto;
        private System.Windows.Forms.Button btnBuscarClase;
        private System.Windows.Forms.TextBox txtClase;
    }
}
