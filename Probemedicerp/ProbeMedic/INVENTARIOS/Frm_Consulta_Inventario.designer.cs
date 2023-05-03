namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Consulta_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta_Inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ReOrdenInventario = new System.Windows.Forms.Button();
            this.btn_articulos_a_caducar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.ucSustanciaActiva1 = new ProbeMedic.Controles.ucSustanciaActiva();
            this.label7 = new System.Windows.Forms.Label();
            this.ucLaboratorio1 = new ProbeMedic.Controles.ucLaboratorio();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxExistencia = new System.Windows.Forms.CheckBox();
            this.btnBuscaProducto = new System.Windows.Forms.Button();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.cBoxMostrarTodo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.btnLimpiaArticulo = new System.Windows.Forms.Button();
            this.btnLimpiaOficina = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdEncabezado = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Lote = new System.Windows.Forms.DataGridViewButtonColumn();
            this.K_Oficina1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_UltimaRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_PorRecibir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_ReOrdenInventario);
            this.panel1.Controls.Add(this.btn_articulos_a_caducar);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Controls.Add(this.ucSustanciaActiva1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ucLaboratorio1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSKU);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxExistencia);
            this.panel1.Controls.Add(this.btnBuscaProducto);
            this.panel1.Controls.Add(this.btnBuscarOficina);
            this.panel1.Controls.Add(this.cBoxMostrarTodo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblActivo);
            this.panel1.Controls.Add(this.cbxAlmacen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClaveOficina);
            this.panel1.Controls.Add(this.btnLimpiaArticulo);
            this.panel1.Controls.Add(this.btnLimpiaOficina);
            this.panel1.Controls.Add(this.txtArticulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOficina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 184);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // btn_ReOrdenInventario
            // 
            this.btn_ReOrdenInventario.Location = new System.Drawing.Point(479, 62);
            this.btn_ReOrdenInventario.Name = "btn_ReOrdenInventario";
            this.btn_ReOrdenInventario.Size = new System.Drawing.Size(77, 23);
            this.btn_ReOrdenInventario.TabIndex = 63;
            this.btn_ReOrdenInventario.Text = "Re-orden";
            this.btn_ReOrdenInventario.UseVisualStyleBackColor = true;
            this.btn_ReOrdenInventario.Click += new System.EventHandler(this.btn_ReOrdenInventario_Click);
            // 
            // btn_articulos_a_caducar
            // 
            this.btn_articulos_a_caducar.Location = new System.Drawing.Point(968, 104);
            this.btn_articulos_a_caducar.Name = "btn_articulos_a_caducar";
            this.btn_articulos_a_caducar.Size = new System.Drawing.Size(161, 53);
            this.btn_articulos_a_caducar.TabIndex = 61;
            this.btn_articulos_a_caducar.Text = "Mostrar artículos próximos a caducar";
            this.btn_articulos_a_caducar.UseVisualStyleBackColor = true;
            this.btn_articulos_a_caducar.Click += new System.EventHandler(this.btn_articulos_a_caducar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(1168, 30);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(149, 150);
            this.pbImagen.TabIndex = 59;
            this.pbImagen.TabStop = false;
            // 
            // ucSustanciaActiva1
            // 
            this.ucSustanciaActiva1.Location = new System.Drawing.Point(666, 130);
            this.ucSustanciaActiva1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ucSustanciaActiva1.Name = "ucSustanciaActiva1";
            this.ucSustanciaActiva1.Size = new System.Drawing.Size(252, 30);
            this.ucSustanciaActiva1.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sustancia Activa";
            // 
            // ucLaboratorio1
            // 
            this.ucLaboratorio1.Location = new System.Drawing.Point(667, 98);
            this.ucLaboratorio1.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.ucLaboratorio1.Name = "ucLaboratorio1";
            this.ucLaboratorio1.Size = new System.Drawing.Size(251, 33);
            this.ucLaboratorio1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Laboratorio";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(668, 65);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(391, 24);
            this.txtSKU.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "SKU";
            // 
            // cbxExistencia
            // 
            this.cbxExistencia.AutoSize = true;
            this.cbxExistencia.Checked = true;
            this.cbxExistencia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxExistencia.Location = new System.Drawing.Point(287, 110);
            this.cbxExistencia.Name = "cbxExistencia";
            this.cbxExistencia.Size = new System.Drawing.Size(116, 21);
            this.cbxExistencia.TabIndex = 4;
            this.cbxExistencia.Text = "Con Existencia";
            this.cbxExistencia.UseVisualStyleBackColor = true;
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProducto.Image")));
            this.btnBuscaProducto.Location = new System.Drawing.Point(1061, 34);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaProducto.TabIndex = 5;
            this.btnBuscaProducto.Tag = "";
            this.btnBuscaProducto.UseVisualStyleBackColor = true;
            this.btnBuscaProducto.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(477, 34);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarOficina.TabIndex = 1;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // cBoxMostrarTodo
            // 
            this.cBoxMostrarTodo.AutoSize = true;
            this.cBoxMostrarTodo.Location = new System.Drawing.Point(288, 136);
            this.cBoxMostrarTodo.Name = "cBoxMostrarTodo";
            this.cBoxMostrarTodo.Size = new System.Drawing.Size(188, 21);
            this.cBoxMostrarTodo.TabIndex = 3;
            this.cBoxMostrarTodo.Text = "Mostrar Todo el Inventario";
            this.cBoxMostrarTodo.UseVisualStyleBackColor = true;
            this.cBoxMostrarTodo.CheckedChanged += new System.EventHandler(this.cBoxMostrarTodo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1325, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Consulta de Inventario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblActivo.Location = new System.Drawing.Point(549, 34);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(0, 17);
            this.lblActivo.TabIndex = 20;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(81, 62);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(392, 24);
            this.cbxAlmacen.TabIndex = 2;
            this.cbxAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAlmacen_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Almacén";
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(81, 34);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.ReadOnly = true;
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficina.TabIndex = 1;
            this.txtClaveOficina.TabStop = false;
            this.txtClaveOficina.Leave += new System.EventHandler(this.txtClaveOficina_Leave);
            // 
            // btnLimpiaArticulo
            // 
            this.btnLimpiaArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiaArticulo.Image")));
            this.btnLimpiaArticulo.Location = new System.Drawing.Point(1097, 34);
            this.btnLimpiaArticulo.Name = "btnLimpiaArticulo";
            this.btnLimpiaArticulo.Size = new System.Drawing.Size(32, 24);
            this.btnLimpiaArticulo.TabIndex = 8;
            this.btnLimpiaArticulo.Tag = "";
            this.toolTip1.SetToolTip(this.btnLimpiaArticulo, "LIMPIA FILTRO ARTICULO");
            this.btnLimpiaArticulo.UseVisualStyleBackColor = true;
            this.btnLimpiaArticulo.Click += new System.EventHandler(this.btnLimpiaArticulo_Click);
            // 
            // btnLimpiaOficina
            // 
            this.btnLimpiaOficina.FlatAppearance.BorderSize = 0;
            this.btnLimpiaOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiaOficina.Image")));
            this.btnLimpiaOficina.Location = new System.Drawing.Point(512, 34);
            this.btnLimpiaOficina.Name = "btnLimpiaOficina";
            this.btnLimpiaOficina.Size = new System.Drawing.Size(44, 24);
            this.btnLimpiaOficina.TabIndex = 7;
            this.btnLimpiaOficina.Tag = "";
            this.toolTip1.SetToolTip(this.btnLimpiaOficina, "LIMPIA FILTRO OFICINA");
            this.btnLimpiaOficina.UseVisualStyleBackColor = true;
            this.btnLimpiaOficina.Click += new System.EventHandler(this.btnLimpiaOficina_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(667, 34);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(391, 24);
            this.txtArticulo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Articulo";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(139, 34);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(334, 24);
            this.txtOficina.TabIndex = 2;
            this.txtOficina.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficina";
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
            this.imageList1.Images.SetKeyName(6, "montacargas.png");
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.grdEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 285);
            this.panel2.TabIndex = 3;
            // 
            // grdEncabezado
            // 
            this.grdEncabezado.AllowUserToAddRows = false;
            this.grdEncabezado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdEncabezado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEncabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdEncabezado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEncabezado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEncabezado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lote,
            this.K_Oficina1,
            this.D_Laboratorio,
            this.D_Sustancia_Activa,
            this.SKU,
            this.D_Oficina,
            this.D_Almacen,
            this.K_Articulo1,
            this.D_Articulo,
            this.Cantidad_Articulo,
            this.Cantidad_Real,
            this.D_Unidad_Medida,
            this.K_Almacen1,
            this.UltimoCosto,
            this.D_Tipo_Moneda,
            this.F_UltimaRecepcion,
            this.Cantidad_PorRecibir,
            this.Pedidos,
            this.ReOrden});
            this.grdEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEncabezado.Location = new System.Drawing.Point(0, 0);
            this.grdEncabezado.Name = "grdEncabezado";
            this.grdEncabezado.ReadOnly = true;
            this.grdEncabezado.RowHeadersVisible = false;
            this.grdEncabezado.RowHeadersWidth = 200;
            this.grdEncabezado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEncabezado.Size = new System.Drawing.Size(1325, 285);
            this.grdEncabezado.TabIndex = 9;
            this.grdEncabezado.DataSourceChanged += new System.EventHandler(this.grdEncabezado_DataSourceChanged);
            this.grdEncabezado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEncabezado_CellClick);
            this.grdEncabezado.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEncabezado_CellMouseEnter);
            this.grdEncabezado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grdEncabezado_CellPainting);
            this.grdEncabezado.SelectionChanged += new System.EventHandler(this.grdEncabezado_SelectionChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "application_view_detail.png");
            this.imageList2.Images.SetKeyName(1, "IconoEtiqueta.jpg");
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Text = "";
            this.Lote.UseColumnTextForButtonValue = true;
            this.Lote.Width = 41;
            // 
            // K_Oficina1
            // 
            this.K_Oficina1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.K_Oficina1.DataPropertyName = "K_Oficina";
            this.K_Oficina1.HeaderText = "K_Oficina";
            this.K_Oficina1.Name = "K_Oficina1";
            this.K_Oficina1.ReadOnly = true;
            this.K_Oficina1.Visible = false;
            // 
            // D_Laboratorio
            // 
            this.D_Laboratorio.DataPropertyName = "D_Laboratorio";
            this.D_Laboratorio.HeaderText = "Laboratorio";
            this.D_Laboratorio.Name = "D_Laboratorio";
            this.D_Laboratorio.ReadOnly = true;
            this.D_Laboratorio.Width = 103;
            // 
            // D_Sustancia_Activa
            // 
            this.D_Sustancia_Activa.DataPropertyName = "D_Sustancia_Activa";
            this.D_Sustancia_Activa.HeaderText = "Sustancia Activa";
            this.D_Sustancia_Activa.Name = "D_Sustancia_Activa";
            this.D_Sustancia_Activa.ReadOnly = true;
            this.D_Sustancia_Activa.Width = 121;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 58;
            // 
            // D_Oficina
            // 
            this.D_Oficina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.FillWeight = 200F;
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.MinimumWidth = 150;
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Visible = false;
            this.D_Oficina.Width = 150;
            // 
            // D_Almacen
            // 
            this.D_Almacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacen";
            this.D_Almacen.MinimumWidth = 150;
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 150;
            // 
            // K_Articulo1
            // 
            this.K_Articulo1.DataPropertyName = "K_Articulo";
            this.K_Articulo1.HeaderText = "K_Articulo";
            this.K_Articulo1.Name = "K_Articulo1";
            this.K_Articulo1.ReadOnly = true;
            this.K_Articulo1.Visible = false;
            this.K_Articulo1.Width = 94;
            // 
            // D_Articulo
            // 
            this.D_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D_Articulo.DataPropertyName = "D_Articulo";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.D_Articulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.MinimumWidth = 300;
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 300;
            // 
            // Cantidad_Articulo
            // 
            this.Cantidad_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad_Articulo.DataPropertyName = "Cantidad_Articulo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "False";
            this.Cantidad_Articulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad_Articulo.HeaderText = "Existencia";
            this.Cantidad_Articulo.MinimumWidth = 100;
            this.Cantidad_Articulo.Name = "Cantidad_Articulo";
            this.Cantidad_Articulo.ReadOnly = true;
            this.Cantidad_Articulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Cantidad_Real
            // 
            this.Cantidad_Real.DataPropertyName = "Cantidad_Real";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            this.Cantidad_Real.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad_Real.HeaderText = "Disponible";
            this.Cantidad_Real.Name = "Cantidad_Real";
            this.Cantidad_Real.ReadOnly = true;
            this.Cantidad_Real.Width = 94;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.FillWeight = 176.6497F;
            this.D_Unidad_Medida.HeaderText = "U.Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Width = 88;
            // 
            // K_Almacen1
            // 
            this.K_Almacen1.DataPropertyName = "K_Almacen";
            this.K_Almacen1.HeaderText = "K_Almacen1";
            this.K_Almacen1.Name = "K_Almacen1";
            this.K_Almacen1.ReadOnly = true;
            this.K_Almacen1.Visible = false;
            this.K_Almacen1.Width = 108;
            // 
            // UltimoCosto
            // 
            this.UltimoCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UltimoCosto.DataPropertyName = "UltimoCosto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.UltimoCosto.DefaultCellStyle = dataGridViewCellStyle6;
            this.UltimoCosto.HeaderText = "Ultimo Costo";
            this.UltimoCosto.MinimumWidth = 90;
            this.UltimoCosto.Name = "UltimoCosto";
            this.UltimoCosto.ReadOnly = true;
            this.UltimoCosto.Width = 110;
            // 
            // D_Tipo_Moneda
            // 
            this.D_Tipo_Moneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D_Tipo_Moneda.DataPropertyName = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.HeaderText = "Moneda";
            this.D_Tipo_Moneda.MinimumWidth = 50;
            this.D_Tipo_Moneda.Name = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.ReadOnly = true;
            this.D_Tipo_Moneda.Width = 60;
            // 
            // F_UltimaRecepcion
            // 
            this.F_UltimaRecepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.F_UltimaRecepcion.DataPropertyName = "F_UltimaRecepcion";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy hh:mm";
            dataGridViewCellStyle7.NullValue = " ";
            this.F_UltimaRecepcion.DefaultCellStyle = dataGridViewCellStyle7;
            this.F_UltimaRecepcion.HeaderText = "Ultima Recepcion";
            this.F_UltimaRecepcion.MinimumWidth = 100;
            this.F_UltimaRecepcion.Name = "F_UltimaRecepcion";
            this.F_UltimaRecepcion.ReadOnly = true;
            this.F_UltimaRecepcion.Width = 130;
            // 
            // Cantidad_PorRecibir
            // 
            this.Cantidad_PorRecibir.DataPropertyName = "Cantidad_PorRecibir";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.NullValue = "0";
            this.Cantidad_PorRecibir.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cantidad_PorRecibir.HeaderText = "Articulos Por Recibir";
            this.Cantidad_PorRecibir.Name = "Cantidad_PorRecibir";
            this.Cantidad_PorRecibir.ReadOnly = true;
            this.Cantidad_PorRecibir.Width = 104;
            // 
            // Pedidos
            // 
            this.Pedidos.DataPropertyName = "Cantidad_Pedidos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.NullValue = "0";
            this.Pedidos.DefaultCellStyle = dataGridViewCellStyle9;
            this.Pedidos.HeaderText = "Cantidad Pedidos";
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.ReadOnly = true;
            this.Pedidos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pedidos.Width = 126;
            // 
            // ReOrden
            // 
            this.ReOrden.DataPropertyName = "B_ReOrden";
            this.ReOrden.HeaderText = "Re-Orden";
            this.ReOrden.Name = "ReOrden";
            this.ReOrden.ReadOnly = true;
            this.ReOrden.Width = 73;
            // 
            // Frm_Consulta_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Consulta_Inventario";
            this.Text = "CONSULTA DE INVENTARIO DE ARTICULOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Consulta_Inventario_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEncabezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiaArticulo;
        private System.Windows.Forms.Button btnLimpiaOficina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.CheckBox cBoxMostrarTodo;
        private System.Windows.Forms.Button btnBuscarOficina;
        private System.Windows.Forms.Button btnBuscaProducto;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxExistencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Controles.ucSustanciaActiva ucSustanciaActiva1;
        private Controles.ucLaboratorio ucLaboratorio1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btn_articulos_a_caducar;
        private System.Windows.Forms.Button btn_ReOrdenInventario;
        private System.Windows.Forms.DataGridViewButtonColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Sustancia_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Real;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_UltimaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_PorRecibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReOrden;
    }
}