namespace ProbeMedic.FILTROS
{
    partial class Frm_Filtro_Articulo_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filtro_Articulo_Clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdArticulos = new System.Windows.Forms.DataGridView();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Familia_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txt_D_Articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucSustanciaActiva1 = new ProbeMedic.Controles.ucSustanciaActiva();
            this.ucLaboratorio1 = new ProbeMedic.Controles.ucLaboratorio();
            this.ucFamiliaArticulo1 = new ProbeMedic.Controles.ucFamiliaArticulo();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 594);
            this.panel1.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdArticulos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 408);
            this.panel3.TabIndex = 1;
            // 
            // grdArticulos
            // 
            this.grdArticulos.AllowUserToAddRows = false;
            this.grdArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArticulos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.grdArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.K_Tipo_Producto,
            this.D_Tipo_Producto,
            this.K_Unidad_Medida,
            this.D_Unidad_Medida,
            this.K_Familia_Articulo,
            this.D_Familia,
            this.K_Laboratorio,
            this.D_Laboratorio,
            this.K_Sustancia_Activa,
            this.D_Sustancia_Activa,
            this.Precio_Unitario,
            this.SubTotal,
            this.Total_Iva,
            this.Porcentaje});
            this.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArticulos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdArticulos.Location = new System.Drawing.Point(0, 0);
            this.grdArticulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdArticulos.MultiSelect = false;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.ReadOnly = true;
            this.grdArticulos.RowTemplate.Height = 24;
            this.grdArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArticulos.Size = new System.Drawing.Size(934, 408);
            this.grdArticulos.TabIndex = 119;
            this.grdArticulos.TabStop = false;
            this.grdArticulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdArticulos_CellMouseDoubleClick);
            this.grdArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdArticulos_KeyDown);
            this.grdArticulos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdArticulos_PreviewKeyDown);
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // K_Tipo_Producto
            // 
            this.K_Tipo_Producto.DataPropertyName = "K_Tipo_Producto";
            this.K_Tipo_Producto.HeaderText = "K_Tipo_Producto";
            this.K_Tipo_Producto.Name = "K_Tipo_Producto";
            this.K_Tipo_Producto.ReadOnly = true;
            this.K_Tipo_Producto.Visible = false;
            // 
            // D_Tipo_Producto
            // 
            this.D_Tipo_Producto.DataPropertyName = "D_Tipo_Producto";
            this.D_Tipo_Producto.HeaderText = "Tipo Producto";
            this.D_Tipo_Producto.Name = "D_Tipo_Producto";
            this.D_Tipo_Producto.ReadOnly = true;
            this.D_Tipo_Producto.Visible = false;
            // 
            // K_Unidad_Medida
            // 
            this.K_Unidad_Medida.DataPropertyName = "K_Unidad_Medida";
            this.K_Unidad_Medida.HeaderText = "K_Unidad_Medida";
            this.K_Unidad_Medida.Name = "K_Unidad_Medida";
            this.K_Unidad_Medida.ReadOnly = true;
            this.K_Unidad_Medida.Visible = false;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "Unidad Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            // 
            // K_Familia_Articulo
            // 
            this.K_Familia_Articulo.DataPropertyName = "K_Familia_Articulo";
            this.K_Familia_Articulo.HeaderText = "K_Familia_Articulo";
            this.K_Familia_Articulo.Name = "K_Familia_Articulo";
            this.K_Familia_Articulo.ReadOnly = true;
            this.K_Familia_Articulo.Visible = false;
            // 
            // D_Familia
            // 
            this.D_Familia.DataPropertyName = "D_Familia";
            this.D_Familia.HeaderText = "Familia";
            this.D_Familia.Name = "D_Familia";
            this.D_Familia.ReadOnly = true;
            this.D_Familia.Visible = false;
            // 
            // K_Laboratorio
            // 
            this.K_Laboratorio.DataPropertyName = "K_Laboratorio";
            this.K_Laboratorio.HeaderText = "K_Laboratorio";
            this.K_Laboratorio.Name = "K_Laboratorio";
            this.K_Laboratorio.ReadOnly = true;
            this.K_Laboratorio.Visible = false;
            // 
            // D_Laboratorio
            // 
            this.D_Laboratorio.DataPropertyName = "D_Laboratorio";
            this.D_Laboratorio.HeaderText = "Laboratorio";
            this.D_Laboratorio.Name = "D_Laboratorio";
            this.D_Laboratorio.ReadOnly = true;
            // 
            // K_Sustancia_Activa
            // 
            this.K_Sustancia_Activa.DataPropertyName = "K_Sustancia_Activa";
            this.K_Sustancia_Activa.HeaderText = "K_Sustancia_Activa";
            this.K_Sustancia_Activa.Name = "K_Sustancia_Activa";
            this.K_Sustancia_Activa.ReadOnly = true;
            this.K_Sustancia_Activa.Visible = false;
            // 
            // D_Sustancia_Activa
            // 
            this.D_Sustancia_Activa.DataPropertyName = "D_Sustancia_Activa";
            this.D_Sustancia_Activa.HeaderText = "Sustancia Activa";
            this.D_Sustancia_Activa.Name = "D_Sustancia_Activa";
            this.D_Sustancia_Activa.ReadOnly = true;
            this.D_Sustancia_Activa.Visible = false;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle2.Format = "N2";
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio_Unitario.HeaderText = "P. Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.Format = "N2";
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Visible = false;
            // 
            // Total_Iva
            // 
            this.Total_Iva.DataPropertyName = "Total_Iva";
            dataGridViewCellStyle4.Format = "N2";
            this.Total_Iva.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total_Iva.HeaderText = "Total_Iva";
            this.Total_Iva.Name = "Total_Iva";
            this.Total_Iva.ReadOnly = true;
            this.Total_Iva.Visible = false;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            dataGridViewCellStyle5.Format = "N2";
            this.Porcentaje.DefaultCellStyle = dataGridViewCellStyle5;
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.txt_D_Articulo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ucSustanciaActiva1);
            this.panel2.Controls.Add(this.ucLaboratorio1);
            this.panel2.Controls.Add(this.ucFamiliaArticulo1);
            this.panel2.Controls.Add(this.txtSKU);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 186);
            this.panel2.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoEllipsis = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(459, 125);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 41);
            this.BtnBuscar.TabIndex = 123;
            this.BtnBuscar.Text = "Buscar [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txt_D_Articulo
            // 
            this.txt_D_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_D_Articulo.Location = new System.Drawing.Point(146, 14);
            this.txt_D_Articulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_D_Articulo.Name = "txt_D_Articulo";
            this.txt_D_Articulo.Size = new System.Drawing.Size(230, 23);
            this.txt_D_Articulo.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 128;
            this.label1.Text = "Nombre";
            // 
            // ucSustanciaActiva1
            // 
            this.ucSustanciaActiva1.Location = new System.Drawing.Point(144, 144);
            this.ucSustanciaActiva1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ucSustanciaActiva1.Name = "ucSustanciaActiva1";
            this.ucSustanciaActiva1.Size = new System.Drawing.Size(290, 30);
            this.ucSustanciaActiva1.TabIndex = 122;
            // 
            // ucLaboratorio1
            // 
            this.ucLaboratorio1.Location = new System.Drawing.Point(146, 109);
            this.ucLaboratorio1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.ucLaboratorio1.Name = "ucLaboratorio1";
            this.ucLaboratorio1.Size = new System.Drawing.Size(290, 32);
            this.ucLaboratorio1.TabIndex = 121;
            // 
            // ucFamiliaArticulo1
            // 
            this.ucFamiliaArticulo1.Location = new System.Drawing.Point(147, 75);
            this.ucFamiliaArticulo1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ucFamiliaArticulo1.Name = "ucFamiliaArticulo1";
            this.ucFamiliaArticulo1.Size = new System.Drawing.Size(289, 30);
            this.ucFamiliaArticulo1.TabIndex = 120;
            // 
            // txtSKU
            // 
            this.txtSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSKU.Location = new System.Drawing.Point(146, 45);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(230, 23);
            this.txtSKU.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Sustancia Activa";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 126;
            this.label6.Text = "Laboratorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Família Artículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 124;
            this.label4.Text = "SKU";
            // 
            // Frm_Filtro_Articulo_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 623);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Filtro_Articulo_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Artículo";
            this.Load += new System.EventHandler(this.Frm_Filtro_Articulo_Clientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Filtro_Articulo_Clientes_KeyDown);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txt_D_Articulo;
        private System.Windows.Forms.Label label1;
        private Controles.ucSustanciaActiva ucSustanciaActiva1;
        private Controles.ucLaboratorio ucLaboratorio1;
        private Controles.ucFamiliaArticulo ucFamiliaArticulo1;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Familia_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Sustancia_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Sustancia_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}