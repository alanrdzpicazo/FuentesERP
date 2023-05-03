namespace ProbeMedic.CATALOGOS
{
    partial class FRM_PRECIOS_ART_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PRECIOS_ART_CLIENTES));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscaArticulo = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpActualizacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Precio_Articulo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Actualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.pnlAlta.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.BtnAplicar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(1021, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 195);
            this.panel1.TabIndex = 3;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(5, 4);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(88, 44);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(5, 52);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(88, 44);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta";
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Enabled = false;
            this.BtnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAplicar.Image")));
            this.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAplicar.Location = new System.Drawing.Point(5, 100);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(88, 44);
            this.BtnAplicar.TabIndex = 6;
            this.BtnAplicar.Text = "Aplicar\r\n Precios";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(5, 148);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 44);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 242);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1125, 23);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Cliente,
            this.K_Precio_Articulo_Cliente,
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.F_Actualizacion,
            this.Precio});
            this.grDatos.Location = new System.Drawing.Point(0, 259);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.Name = "grDatos";
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1122, 266);
            this.grDatos.TabIndex = 1;
            this.grDatos.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtPrecio.Location = new System.Drawing.Point(194, 55);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 24);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Precio";
            // 
            // btnBuscaArticulo
            // 
            this.btnBuscaArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaArticulo.Image")));
            this.btnBuscaArticulo.Location = new System.Drawing.Point(513, 9);
            this.btnBuscaArticulo.Name = "btnBuscaArticulo";
            this.btnBuscaArticulo.Size = new System.Drawing.Size(26, 24);
            this.btnBuscaArticulo.TabIndex = 5;
            this.btnBuscaArticulo.UseVisualStyleBackColor = true;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtArticulo.Location = new System.Drawing.Point(194, 12);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(313, 24);
            this.txtArticulo.TabIndex = 99;
            this.txtArticulo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Articulo";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(525, 52);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 24);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCliente.Location = new System.Drawing.Point(206, 52);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(313, 24);
            this.txtCliente.TabIndex = 95;
            this.txtCliente.TabStop = false;
            // 
            // dtpActualizacion
            // 
            this.dtpActualizacion.Location = new System.Drawing.Point(194, 99);
            this.dtpActualizacion.Name = "dtpActualizacion";
            this.dtpActualizacion.Size = new System.Drawing.Size(249, 24);
            this.dtpActualizacion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Fecha de Actualización";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Cliente";
            // 
            // pnlAlta
            // 
            this.pnlAlta.Controls.Add(this.txtPrecio);
            this.pnlAlta.Controls.Add(this.label2);
            this.pnlAlta.Controls.Add(this.label4);
            this.pnlAlta.Controls.Add(this.dtpActualizacion);
            this.pnlAlta.Controls.Add(this.btnBuscaArticulo);
            this.pnlAlta.Controls.Add(this.label3);
            this.pnlAlta.Controls.Add(this.txtArticulo);
            this.pnlAlta.Enabled = false;
            this.pnlAlta.Location = new System.Drawing.Point(12, 84);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(551, 148);
            this.pnlAlta.TabIndex = 101;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.dtpFinal);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.dtpInicial);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Location = new System.Drawing.Point(596, 53);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(404, 179);
            this.gbFiltros.TabIndex = 102;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Consulta";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(139, 97);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(249, 24);
            this.dtpFinal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Final";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(139, 52);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(249, 24);
            this.dtpInicial.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Inicial";
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "Num. Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            this.K_Cliente.Width = 101;
            // 
            // K_Precio_Articulo_Cliente
            // 
            this.K_Precio_Articulo_Cliente.DataPropertyName = "K_Precio_Articulo_Cliente";
            this.K_Precio_Articulo_Cliente.HeaderText = "K_Precio_Articulo_Cliente";
            this.K_Precio_Articulo_Cliente.Name = "K_Precio_Articulo_Cliente";
            this.K_Precio_Articulo_Cliente.ReadOnly = true;
            this.K_Precio_Articulo_Cliente.Visible = false;
            this.K_Precio_Articulo_Cliente.Width = 187;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 105;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 58;
            // 
            // F_Actualizacion
            // 
            this.F_Actualizacion.DataPropertyName = "F_Actualizacion";
            this.F_Actualizacion.HeaderText = "Fecha Actualización";
            this.F_Actualizacion.Name = "F_Actualizacion";
            this.F_Actualizacion.ReadOnly = true;
            this.F_Actualizacion.Width = 137;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 70;
            // 
            // FRM_PRECIOS_ART_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 555);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.pnlAlta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "FRM_PRECIOS_ART_CLIENTES";
            this.Text = "Precios Articulos Clientes";
            this.Load += new System.EventHandler(this.FRM_PRECIOS_ART_CLIENTES_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grDatos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.pnlAlta, 0);
            this.Controls.SetChildIndex(this.btnBuscarCliente, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.pnlAlta.ResumeLayout(false);
            this.pnlAlta.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscaArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpActualizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAlta;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precio_Articulo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Actualizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}