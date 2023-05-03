namespace ProbeMedic.Controles
{
    partial class ucTipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTipoProducto));
            this.btn_TipoProducto = new System.Windows.Forms.Button();
            this.txt_TP_Tipo_Producto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_TipoProducto
            // 
            this.btn_TipoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_TipoProducto.Image")));
            this.btn_TipoProducto.Location = new System.Drawing.Point(187, 2);
            this.btn_TipoProducto.Name = "btn_TipoProducto";
            this.btn_TipoProducto.Size = new System.Drawing.Size(28, 24);
            this.btn_TipoProducto.TabIndex = 0;
            this.btn_TipoProducto.UseVisualStyleBackColor = true;
            this.btn_TipoProducto.Click += new System.EventHandler(this.btn_TipoProducto_Click);
            // 
            // txt_TP_Tipo_Producto
            // 
            this.txt_TP_Tipo_Producto.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_TP_Tipo_Producto.Location = new System.Drawing.Point(1, 3);
            this.txt_TP_Tipo_Producto.Name = "txt_TP_Tipo_Producto";
            this.txt_TP_Tipo_Producto.ReadOnly = true;
            this.txt_TP_Tipo_Producto.Size = new System.Drawing.Size(181, 24);
            this.txt_TP_Tipo_Producto.TabIndex = 10;
            this.txt_TP_Tipo_Producto.TabStop = false;
            // 
            // ucTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TipoProducto);
            this.Controls.Add(this.txt_TP_Tipo_Producto);
            this.Name = "ucTipoProducto";
            this.Size = new System.Drawing.Size(223, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TipoProducto;
        private System.Windows.Forms.TextBox txt_TP_Tipo_Producto;
    }
}
