namespace ProbeMedic.VENTAS
{
    partial class Frm_Inventario_Venta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inventario_Venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_General = new System.Windows.Forms.Panel();
            this.Pnl_Abajo = new System.Windows.Forms.Panel();
            this.Dgv_Datos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Pnl_Arriba = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Sku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiaArticulo = new System.Windows.Forms.Button();
            this.btnBuscaProducto = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sdds = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.Pnl_General.SuspendLayout();
            this.Pnl_Abajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Datos)).BeginInit();
            this.Pnl_Arriba.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sdds.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_General
            // 
            this.Pnl_General.Controls.Add(this.Pnl_Abajo);
            this.Pnl_General.Controls.Add(this.Pnl_Arriba);
            this.Pnl_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_General.Location = new System.Drawing.Point(0, 38);
            this.Pnl_General.Name = "Pnl_General";
            this.Pnl_General.Size = new System.Drawing.Size(1258, 652);
            this.Pnl_General.TabIndex = 0;
            this.Pnl_General.TabStop = true;
            // 
            // Pnl_Abajo
            // 
            this.Pnl_Abajo.Controls.Add(this.Dgv_Datos);
            this.Pnl_Abajo.Controls.Add(this.lblTitulo);
            this.Pnl_Abajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Abajo.Location = new System.Drawing.Point(0, 220);
            this.Pnl_Abajo.Name = "Pnl_Abajo";
            this.Pnl_Abajo.Size = new System.Drawing.Size(1258, 432);
            this.Pnl_Abajo.TabIndex = 10;
            this.Pnl_Abajo.TabStop = true;
            // 
            // Dgv_Datos
            // 
            this.Dgv_Datos.AllowUserToAddRows = false;
            this.Dgv_Datos.AllowUserToDeleteRows = false;
            this.Dgv_Datos.AllowUserToOrderColumns = true;
            this.Dgv_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Oficina,
            this.D_Oficina,
            this.K_Almacen,
            this.D_Almacen,
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.Cantidad_Articulo,
            this.Precio_Unitario,
            this.Ubicacion,
            this.K_Laboratorio,
            this.D_Laboratorio,
            this.K_Sustancia_Activa,
            this.D_Sustancia_Activa});
            this.Dgv_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Datos.Location = new System.Drawing.Point(0, 20);
            this.Dgv_Datos.Name = "Dgv_Datos";
            this.Dgv_Datos.RowHeadersWidth = 25;
            this.Dgv_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgv_Datos.Size = new System.Drawing.Size(1258, 412);
            this.Dgv_Datos.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1258, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Detalle de Inventario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Arriba
            // 
            this.Pnl_Arriba.Controls.Add(this.groupBox2);
            this.Pnl_Arriba.Controls.Add(this.sdds);
            this.Pnl_Arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Arriba.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Arriba.Name = "Pnl_Arriba";
            this.Pnl_Arriba.Size = new System.Drawing.Size(1258, 220);
            this.Pnl_Arriba.TabIndex = 1;
            this.Pnl_Arriba.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Txt_Sku);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnLimpiaArticulo);
            this.groupBox2.Controls.Add(this.btnBuscaProducto);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1224, 106);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROS DE BÚSQUEDA";
            // 
            // Txt_Sku
            // 
            this.Txt_Sku.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sku.Location = new System.Drawing.Point(80, 56);
            this.Txt_Sku.Name = "Txt_Sku";
            this.Txt_Sku.Size = new System.Drawing.Size(321, 33);
            this.Txt_Sku.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "SKU";
            // 
            // btnLimpiaArticulo
            // 
            this.btnLimpiaArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiaArticulo.Image")));
            this.btnLimpiaArticulo.Location = new System.Drawing.Point(443, 23);
            this.btnLimpiaArticulo.Name = "btnLimpiaArticulo";
            this.btnLimpiaArticulo.Size = new System.Drawing.Size(32, 24);
            this.btnLimpiaArticulo.TabIndex = 8;
            this.btnLimpiaArticulo.Tag = "";
            this.btnLimpiaArticulo.UseVisualStyleBackColor = true;
            this.btnLimpiaArticulo.Click += new System.EventHandler(this.btnLimpiaArticulo_Click);
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProducto.Image")));
            this.btnBuscaProducto.Location = new System.Drawing.Point(405, 23);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaProducto.TabIndex = 7;
            this.btnBuscaProducto.UseVisualStyleBackColor = true;
            this.btnBuscaProducto.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtArticulo.Location = new System.Drawing.Point(80, 23);
            this.txtArticulo.MaxLength = 30;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(321, 24);
            this.txtArticulo.TabIndex = 6;
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            this.txtArticulo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtArticulo_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Articulo";
            // 
            // sdds
            // 
            this.sdds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sdds.Controls.Add(this.btnBuscarCliente);
            this.sdds.Controls.Add(this.txtCliente);
            this.sdds.Controls.Add(this.label5);
            this.sdds.Controls.Add(this.CbxAlmacen);
            this.sdds.Controls.Add(this.label1);
            this.sdds.Controls.Add(this.txtOficina);
            this.sdds.Controls.Add(this.label3);
            this.sdds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdds.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdds.Location = new System.Drawing.Point(13, 6);
            this.sdds.Name = "sdds";
            this.sdds.Size = new System.Drawing.Size(1224, 91);
            this.sdds.TabIndex = 2;
            this.sdds.TabStop = false;
            this.sdds.Text = "DATOS GENERALES";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(785, 18);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 24);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCliente.Location = new System.Drawing.Point(471, 18);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(313, 24);
            this.txtCliente.TabIndex = 26;
            this.txtCliente.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cliente";
            // 
            // CbxAlmacen
            // 
            this.CbxAlmacen.FormattingEnabled = true;
            this.CbxAlmacen.Location = new System.Drawing.Point(80, 49);
            this.CbxAlmacen.Name = "CbxAlmacen";
            this.CbxAlmacen.Size = new System.Drawing.Size(307, 24);
            this.CbxAlmacen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oficina";
            // 
            // txtOficina
            // 
            this.txtOficina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOficina.Location = new System.Drawing.Point(80, 18);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(307, 24);
            this.txtOficina.TabIndex = 5;
            this.txtOficina.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Almacen";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "actualizarsmall.png");
            this.imageList1.Images.SetKeyName(1, "zoom.png");
            this.imageList1.Images.SetKeyName(2, "application_view_detail.png");
            this.imageList1.Images.SetKeyName(3, "Reload.png");
            this.imageList1.Images.SetKeyName(4, "page_refresh.png");
            this.imageList1.Images.SetKeyName(5, "transfer.png");
            // 
            // K_Oficina
            // 
            this.K_Oficina.DataPropertyName = "K_Oficina";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.K_Oficina.DefaultCellStyle = dataGridViewCellStyle2;
            this.K_Oficina.HeaderText = "K_Oficina";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.ReadOnly = true;
            this.K_Oficina.Visible = false;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.D_Oficina.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Almacen.DefaultCellStyle = dataGridViewCellStyle4;
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.ReadOnly = true;
            this.K_Almacen.Visible = false;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.D_Almacen.DefaultCellStyle = dataGridViewCellStyle5;
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "K_Articulo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Visible = false;
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
            // Cantidad_Articulo
            // 
            this.Cantidad_Articulo.DataPropertyName = "Cantidad_Articulo";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.NullValue = null;
            this.Cantidad_Articulo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad_Articulo.HeaderText = "Disponible";
            this.Cantidad_Articulo.Name = "Cantidad_Articulo";
            this.Cantidad_Articulo.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle7;
            this.Precio_Unitario.HeaderText = "P. Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Visible = false;
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
            // 
            // Frm_Inventario_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 729);
            this.Controls.Add(this.Pnl_General);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1274, 768);
            this.Name = "Frm_Inventario_Venta";
            this.Text = "INVENTARIO VENTA";
            this.Load += new System.EventHandler(this.Frm_Inventario_Venta_Load);
            this.Controls.SetChildIndex(this.Pnl_General, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.Pnl_General.ResumeLayout(false);
            this.Pnl_Abajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Datos)).EndInit();
            this.Pnl_Arriba.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sdds.ResumeLayout(false);
            this.sdds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_General;
        private System.Windows.Forms.Panel Pnl_Arriba;
        private System.Windows.Forms.Panel Pnl_Abajo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Sku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiaArticulo;
        private System.Windows.Forms.Button btnBuscaProducto;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox sdds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxAlmacen;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView Dgv_Datos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Sustancia_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Sustancia_Activa;
    }
}