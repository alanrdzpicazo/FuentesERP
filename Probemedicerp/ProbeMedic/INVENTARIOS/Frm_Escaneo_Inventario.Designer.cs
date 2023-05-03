namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Escaneo_Entrada_Almacen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escaneo_Entrada_Almacen));
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_Escaneo_Contador = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEscaneoArticulos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.txtbx_entrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoDocto = new System.Windows.Forms.Label();
            this.txtNoDocto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txtMultiplicador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Escaneo_Contador)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaneoArticulos)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(328, 116);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(0, 59);
            this.lbl_nombre_producto.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 267);
            this.panel1.TabIndex = 419;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgv_Escaneo_Contador);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(296, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 267);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 267);
            this.panel4.TabIndex = 25;
            // 
            // dgv_Escaneo_Contador
            // 
            this.dgv_Escaneo_Contador.AllowUserToAddRows = false;
            this.dgv_Escaneo_Contador.AllowUserToDeleteRows = false;
            this.dgv_Escaneo_Contador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Escaneo_Contador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Escaneo_Contador.Location = new System.Drawing.Point(0, 0);
            this.dgv_Escaneo_Contador.Name = "dgv_Escaneo_Contador";
            this.dgv_Escaneo_Contador.ReadOnly = true;
            this.dgv_Escaneo_Contador.Size = new System.Drawing.Size(778, 267);
            this.dgv_Escaneo_Contador.TabIndex = 24;
            this.dgv_Escaneo_Contador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Escaneo_Contador_CellContentClick);
            this.dgv_Escaneo_Contador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Escaneo_Contador_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEscaneoArticulos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 267);
            this.panel2.TabIndex = 24;
            // 
            // dgvEscaneoArticulos
            // 
            this.dgvEscaneoArticulos.AllowUserToAddRows = false;
            this.dgvEscaneoArticulos.AllowUserToDeleteRows = false;
            this.dgvEscaneoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscaneoArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEscaneoArticulos.Location = new System.Drawing.Point(0, 0);
            this.dgvEscaneoArticulos.Name = "dgvEscaneoArticulos";
            this.dgvEscaneoArticulos.Size = new System.Drawing.Size(296, 267);
            this.dgvEscaneoArticulos.TabIndex = 23;
            this.dgvEscaneoArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscaneoArticulos_CellContentClick);
            this.dgvEscaneoArticulos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscaneoArticulos_CellMouseEnter);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 21);
            this.label9.TabIndex = 419;
            this.label9.Text = "No. Orden de compra";
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(169, 5);
            this.txtNoOrden.MaxLength = 10;
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.ReadOnly = true;
            this.txtNoOrden.Size = new System.Drawing.Size(100, 24);
            this.txtNoOrden.TabIndex = 420;
            this.txtNoOrden.Tag = "ENTERO";
            // 
            // txtbx_entrada
            // 
            this.txtbx_entrada.AcceptsTab = true;
            this.txtbx_entrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_entrada.Location = new System.Drawing.Point(16, 139);
            this.txtbx_entrada.Name = "txtbx_entrada";
            this.txtbx_entrada.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbx_entrada.Size = new System.Drawing.Size(182, 29);
            this.txtbx_entrada.TabIndex = 417;
            this.txtbx_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_entrada_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 421;
            this.label1.Text = "SKU del artículo";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(219, 37);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(283, 24);
            this.txtProveedor.TabIndex = 423;
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(169, 37);
            this.txtClaveProveedor.MaxLength = 5;
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(44, 24);
            this.txtClaveProveedor.TabIndex = 422;
            this.txtClaveProveedor.Tag = "ENTERO";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 424;
            this.label2.Text = "Proveedor";
            // 
            // lblNoDocto
            // 
            this.lblNoDocto.AutoSize = true;
            this.lblNoDocto.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDocto.ForeColor = System.Drawing.Color.Black;
            this.lblNoDocto.Location = new System.Drawing.Point(19, 66);
            this.lblNoDocto.Name = "lblNoDocto";
            this.lblNoDocto.Size = new System.Drawing.Size(79, 17);
            this.lblNoDocto.TabIndex = 426;
            this.lblNoDocto.Text = "No. Factura";
            // 
            // txtNoDocto
            // 
            this.txtNoDocto.Enabled = false;
            this.txtNoDocto.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoDocto.Location = new System.Drawing.Point(169, 66);
            this.txtNoDocto.MaxLength = 10;
            this.txtNoDocto.Name = "txtNoDocto";
            this.txtNoDocto.Size = new System.Drawing.Size(141, 24);
            this.txtNoDocto.TabIndex = 425;
            this.txtNoDocto.Tag = "ENTERO";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(323, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 18);
            this.label3.TabIndex = 427;
            this.label3.Text = "Último artículo escaneado";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(963, 7);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(92, 33);
            this.btn_salir.TabIndex = 428;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(865, 7);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(92, 33);
            this.btn_guardar.TabIndex = 429;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.AcceptsTab = true;
            this.txtMultiplicador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplicador.Location = new System.Drawing.Point(204, 139);
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMultiplicador.Size = new System.Drawing.Size(106, 29);
            this.txtMultiplicador.TabIndex = 418;
            this.txtMultiplicador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMultiplicador_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(202, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 430;
            this.label4.Text = "Multiplicador";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtMultiplicador);
            this.panel5.Controls.Add(this.lbl_nombre_producto);
            this.panel5.Controls.Add(this.btn_guardar);
            this.panel5.Controls.Add(this.btn_salir);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtNoDocto);
            this.panel5.Controls.Add(this.lblNoDocto);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtClaveProveedor);
            this.panel5.Controls.Add(this.txtProveedor);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtbx_entrada);
            this.panel5.Controls.Add(this.txtNoOrden);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1074, 197);
            this.panel5.TabIndex = 418;
            // 
            // Frm_Escaneo_Entrada_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Escaneo_Entrada_Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESCANEO ENTRADA ALMACÉN";
            this.Load += new System.EventHandler(this.Frm_Escaneo_Entrada_Almacen_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Escaneo_Contador)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaneoArticulos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_Escaneo_Contador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEscaneoArticulos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.TextBox txtbx_entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoDocto;
        private System.Windows.Forms.TextBox txtNoDocto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txtMultiplicador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
    }
}