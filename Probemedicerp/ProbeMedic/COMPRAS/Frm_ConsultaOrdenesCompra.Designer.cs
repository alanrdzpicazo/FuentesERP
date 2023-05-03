namespace ProbeMedic.COMPRAS
{
    partial class Frm_ConsultaOrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaOrdenesCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbx_grupo_articulo1 = new ProbeMedic.Controles.cbx_grupo_articulo();
            this.cbx_clasificacion_articulo1 = new ProbeMedic.Controles.cbx_clasificacion_articulo();
            this.cbx_tipo_articulo1 = new ProbeMedic.Controles.cbx_tipo_articulo();
            this.cbx_estatus_compra1 = new ProbeMedic.Controles.cbx_estatus_compra();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClaveRequisicion = new System.Windows.Forms.TextBox();
            this.btnBuscaRequisicion = new System.Windows.Forms.Button();
            this.txtRequisicion = new System.Windows.Forms.TextBox();
            this.cbxCanceladas = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tipo_moneda1 = new ProbeMedic.Controles.cbx_tipo_moneda();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOrdenes = new System.Windows.Forms.TabPage();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Orden_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Elaboro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Cancelada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D_Usuario_Cancelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo_Cancela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Orden_CompraDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Empaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Clasificacion_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Grupo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.tpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(887, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Consulta Ordenes de Compra";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Controls.Add(this.gbFiltros);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 67);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(887, 222);
            this.pnlFiltros.TabIndex = 0;
            this.pnlFiltros.TabStop = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.White;
            this.gbFiltros.Controls.Add(this.cbx_grupo_articulo1);
            this.gbFiltros.Controls.Add(this.cbx_clasificacion_articulo1);
            this.gbFiltros.Controls.Add(this.cbx_tipo_articulo1);
            this.gbFiltros.Controls.Add(this.cbx_estatus_compra1);
            this.gbFiltros.Controls.Add(this.groupBox1);
            this.gbFiltros.Controls.Add(this.label9);
            this.gbFiltros.Controls.Add(this.label8);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.txtClaveRequisicion);
            this.gbFiltros.Controls.Add(this.btnBuscaRequisicion);
            this.gbFiltros.Controls.Add(this.txtRequisicion);
            this.gbFiltros.Controls.Add(this.cbxCanceladas);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.txtClaveProveedor);
            this.gbFiltros.Controls.Add(this.txtClaveOficina);
            this.gbFiltros.Controls.Add(this.btnBuscaProveedor);
            this.gbFiltros.Controls.Add(this.txtProveedor);
            this.gbFiltros.Controls.Add(this.btnBuscarOficina);
            this.gbFiltros.Controls.Add(this.txtOficina);
            this.gbFiltros.Controls.Add(this.txtNoOrden);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiltros.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.Black;
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(883, 218);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Tipo de Búsqueda";
            // 
            // cbx_grupo_articulo1
            // 
            this.cbx_grupo_articulo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_grupo_articulo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_grupo_articulo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_grupo_articulo1.FormattingEnabled = true;
            this.cbx_grupo_articulo1.Location = new System.Drawing.Point(594, 119);
            this.cbx_grupo_articulo1.Name = "cbx_grupo_articulo1";
            this.cbx_grupo_articulo1.Size = new System.Drawing.Size(273, 24);
            this.cbx_grupo_articulo1.TabIndex = 9;
            // 
            // cbx_clasificacion_articulo1
            // 
            this.cbx_clasificacion_articulo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_clasificacion_articulo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_clasificacion_articulo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_clasificacion_articulo1.FormattingEnabled = true;
            this.cbx_clasificacion_articulo1.Location = new System.Drawing.Point(594, 89);
            this.cbx_clasificacion_articulo1.Name = "cbx_clasificacion_articulo1";
            this.cbx_clasificacion_articulo1.Size = new System.Drawing.Size(273, 24);
            this.cbx_clasificacion_articulo1.TabIndex = 8;
            // 
            // cbx_tipo_articulo1
            // 
            this.cbx_tipo_articulo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_tipo_articulo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_tipo_articulo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_tipo_articulo1.FormattingEnabled = true;
            this.cbx_tipo_articulo1.Location = new System.Drawing.Point(594, 59);
            this.cbx_tipo_articulo1.Name = "cbx_tipo_articulo1";
            this.cbx_tipo_articulo1.Size = new System.Drawing.Size(273, 24);
            this.cbx_tipo_articulo1.TabIndex = 7;
            // 
            // cbx_estatus_compra1
            // 
            this.cbx_estatus_compra1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_estatus_compra1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_estatus_compra1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_estatus_compra1.FormattingEnabled = true;
            this.cbx_estatus_compra1.Location = new System.Drawing.Point(594, 29);
            this.cbx_estatus_compra1.Name = "cbx_estatus_compra1";
            this.cbx_estatus_compra1.Size = new System.Drawing.Size(273, 24);
            this.cbx_estatus_compra1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtFecha2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFecha1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 57);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Fechas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(199, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hasta";
            // 
            // txtFecha2
            // 
            this.txtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha2.Location = new System.Drawing.Point(245, 22);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.Size = new System.Drawing.Size(102, 24);
            this.txtFecha2.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Desde";
            // 
            // txtFecha1
            // 
            this.txtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha1.Location = new System.Drawing.Point(72, 23);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(102, 24);
            this.txtFecha1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Grupo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Clasificación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tipo Articulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Estatus Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Requisición";
            // 
            // txtClaveRequisicion
            // 
            this.txtClaveRequisicion.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveRequisicion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveRequisicion.Location = new System.Drawing.Point(88, 119);
            this.txtClaveRequisicion.MaxLength = 5;
            this.txtClaveRequisicion.Name = "txtClaveRequisicion";
            this.txtClaveRequisicion.ReadOnly = true;
            this.txtClaveRequisicion.Size = new System.Drawing.Size(50, 24);
            this.txtClaveRequisicion.TabIndex = 7;
            this.txtClaveRequisicion.TabStop = false;
            this.txtClaveRequisicion.Tag = "ENTERO";
            this.txtClaveRequisicion.Leave += new System.EventHandler(this.txtClaveRequisicion_Leave);
            // 
            // btnBuscaRequisicion
            // 
            this.btnBuscaRequisicion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaRequisicion.Image")));
            this.btnBuscaRequisicion.Location = new System.Drawing.Point(427, 119);
            this.btnBuscaRequisicion.Name = "btnBuscaRequisicion";
            this.btnBuscaRequisicion.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaRequisicion.TabIndex = 5;
            this.btnBuscaRequisicion.Tag = "";
            this.btnBuscaRequisicion.UseVisualStyleBackColor = true;
            this.btnBuscaRequisicion.Click += new System.EventHandler(this.btnBuscaRequisicion_Click);
            // 
            // txtRequisicion
            // 
            this.txtRequisicion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisicion.Location = new System.Drawing.Point(139, 119);
            this.txtRequisicion.Name = "txtRequisicion";
            this.txtRequisicion.ReadOnly = true;
            this.txtRequisicion.Size = new System.Drawing.Size(283, 24);
            this.txtRequisicion.TabIndex = 8;
            this.txtRequisicion.TabStop = false;
            // 
            // cbxCanceladas
            // 
            this.cbxCanceladas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCanceladas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxCanceladas.ImageIndex = 1;
            this.cbxCanceladas.ImageList = this.imageList1;
            this.cbxCanceladas.Location = new System.Drawing.Point(707, 187);
            this.cbxCanceladas.Name = "cbxCanceladas";
            this.cbxCanceladas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxCanceladas.Size = new System.Drawing.Size(160, 25);
            this.cbxCanceladas.TabIndex = 13;
            this.cbxCanceladas.Text = "Solo Canceladas";
            this.cbxCanceladas.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Reload.png");
            this.imageList1.Images.SetKeyName(1, "cancel.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Oficina";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(88, 89);
            this.txtClaveProveedor.MaxLength = 5;
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(50, 24);
            this.txtClaveProveedor.TabIndex = 4;
            this.txtClaveProveedor.TabStop = false;
            this.txtClaveProveedor.Tag = "ENTERO";
            this.txtClaveProveedor.Leave += new System.EventHandler(this.txtClaveProveedor_Leave);
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveOficina.Location = new System.Drawing.Point(88, 59);
            this.txtClaveOficina.MaxLength = 5;
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.ReadOnly = true;
            this.txtClaveOficina.Size = new System.Drawing.Size(50, 24);
            this.txtClaveOficina.TabIndex = 1;
            this.txtClaveOficina.TabStop = false;
            this.txtClaveOficina.Tag = "ENTERO";
            this.txtClaveOficina.Leave += new System.EventHandler(this.txtClaveOficina_Leave);
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProveedor.Image")));
            this.btnBuscaProveedor.Location = new System.Drawing.Point(427, 89);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaProveedor.TabIndex = 4;
            this.btnBuscaProveedor.Tag = "";
            this.btnBuscaProveedor.UseVisualStyleBackColor = true;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(139, 89);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(283, 24);
            this.txtProveedor.TabIndex = 5;
            this.txtProveedor.TabStop = false;
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(427, 59);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarOficina.TabIndex = 3;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // txtOficina
            // 
            this.txtOficina.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficina.Location = new System.Drawing.Point(139, 59);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(283, 24);
            this.txtOficina.TabIndex = 2;
            this.txtOficina.TabStop = false;
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(88, 29);
            this.txtNoOrden.MaxLength = 30;
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(100, 24);
            this.txtNoOrden.TabIndex = 2;
            this.txtNoOrden.Tag = "ENTERO";
            this.txtNoOrden.TextChanged += new System.EventHandler(this.txtNoOrden_TextChanged);
            this.txtNoOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOrden_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Orden";
            // 
            // cbx_tipo_moneda1
            // 
            this.cbx_tipo_moneda1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_tipo_moneda1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_tipo_moneda1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_tipo_moneda1.FormattingEnabled = true;
            this.cbx_tipo_moneda1.Location = new System.Drawing.Point(508, 74);
            this.cbx_tipo_moneda1.Name = "cbx_tipo_moneda1";
            this.cbx_tipo_moneda1.Size = new System.Drawing.Size(273, 24);
            this.cbx_tipo_moneda1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo Moneda";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.tabControl1);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 289);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(887, 230);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.TabStop = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tpOrdenes);
            this.tabControl1.Controls.Add(this.tpDetalle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 230);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpOrdenes
            // 
            this.tpOrdenes.Controls.Add(this.grdDatos);
            this.tpOrdenes.Controls.Add(this.cbx_tipo_moneda1);
            this.tpOrdenes.Controls.Add(this.label6);
            this.tpOrdenes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpOrdenes.Location = new System.Drawing.Point(4, 28);
            this.tpOrdenes.Name = "tpOrdenes";
            this.tpOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrdenes.Size = new System.Drawing.Size(879, 198);
            this.tpOrdenes.TabIndex = 0;
            this.tpOrdenes.Text = "Ordenes de Compra";
            this.tpOrdenes.ToolTipText = "Muestra Ordenes de Compra";
            this.tpOrdenes.UseVisualStyleBackColor = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Orden_Compra,
            this.D_Oficina,
            this.D_Almacen,
            this.K_Proveedor,
            this.Nombre,
            this.D_Estatus_Compra,
            this.D_Tipo_Moneda,
            this.Tipo_Cambio,
            this.F_OrdenCompra,
            this.TiempoEntrega,
            this.F_Entrega,
            this.D_Usuario_Elaboro,
            this.Observaciones,
            this.B_Cancelada,
            this.D_Usuario_Cancelo,
            this.F_Cancelacion,
            this.Motivo_Cancela});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 3);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(873, 192);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistro);
            // 
            // K_Orden_Compra
            // 
            this.K_Orden_Compra.DataPropertyName = "K_Orden_Compra";
            this.K_Orden_Compra.HeaderText = "No. Orden";
            this.K_Orden_Compra.Name = "K_Orden_Compra";
            this.K_Orden_Compra.ReadOnly = true;
            this.K_Orden_Compra.Width = 96;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 73;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 84;
            // 
            // K_Proveedor
            // 
            this.K_Proveedor.DataPropertyName = "K_Proveedor";
            this.K_Proveedor.HeaderText = "No. Proveedor";
            this.K_Proveedor.Name = "K_Proveedor";
            this.K_Proveedor.ReadOnly = true;
            this.K_Proveedor.Visible = false;
            this.K_Proveedor.Width = 122;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Proveedor";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 97;
            // 
            // D_Estatus_Compra
            // 
            this.D_Estatus_Compra.DataPropertyName = "D_Estatus_Compra";
            this.D_Estatus_Compra.HeaderText = "Estatus Compra";
            this.D_Estatus_Compra.Name = "D_Estatus_Compra";
            this.D_Estatus_Compra.ReadOnly = true;
            this.D_Estatus_Compra.Width = 131;
            // 
            // D_Tipo_Moneda
            // 
            this.D_Tipo_Moneda.DataPropertyName = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.HeaderText = "Tipo Moneda";
            this.D_Tipo_Moneda.Name = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.ReadOnly = true;
            this.D_Tipo_Moneda.Visible = false;
            this.D_Tipo_Moneda.Width = 111;
            // 
            // Tipo_Cambio
            // 
            this.Tipo_Cambio.DataPropertyName = "Tipo_Cambio";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Tipo_Cambio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo_Cambio.HeaderText = "Tipo Cambio";
            this.Tipo_Cambio.Name = "Tipo_Cambio";
            this.Tipo_Cambio.ReadOnly = true;
            this.Tipo_Cambio.Visible = false;
            this.Tipo_Cambio.Width = 109;
            // 
            // F_OrdenCompra
            // 
            this.F_OrdenCompra.DataPropertyName = "F_OrdenCompra";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.F_OrdenCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_OrdenCompra.HeaderText = "Fecha";
            this.F_OrdenCompra.Name = "F_OrdenCompra";
            this.F_OrdenCompra.ReadOnly = true;
            this.F_OrdenCompra.Width = 69;
            // 
            // TiempoEntrega
            // 
            this.TiempoEntrega.DataPropertyName = "TiempoEntrega";
            this.TiempoEntrega.HeaderText = "Tiempo Entrega";
            this.TiempoEntrega.Name = "TiempoEntrega";
            this.TiempoEntrega.ReadOnly = true;
            this.TiempoEntrega.Width = 130;
            // 
            // F_Entrega
            // 
            this.F_Entrega.DataPropertyName = "F_Entrega";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.F_Entrega.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Entrega.HeaderText = "Fecha Entrega";
            this.F_Entrega.Name = "F_Entrega";
            this.F_Entrega.ReadOnly = true;
            this.F_Entrega.Width = 121;
            // 
            // D_Usuario_Elaboro
            // 
            this.D_Usuario_Elaboro.DataPropertyName = "D_Usuario_Elaboro";
            this.D_Usuario_Elaboro.HeaderText = "Usuario";
            this.D_Usuario_Elaboro.Name = "D_Usuario_Elaboro";
            this.D_Usuario_Elaboro.ReadOnly = true;
            this.D_Usuario_Elaboro.Width = 78;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 122;
            // 
            // B_Cancelada
            // 
            this.B_Cancelada.DataPropertyName = "B_Cancelada";
            this.B_Cancelada.HeaderText = "Cancelada";
            this.B_Cancelada.Name = "B_Cancelada";
            this.B_Cancelada.ReadOnly = true;
            this.B_Cancelada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Cancelada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Cancelada.Width = 95;
            // 
            // D_Usuario_Cancelo
            // 
            this.D_Usuario_Cancelo.DataPropertyName = "D_Usuario_Cancelo";
            this.D_Usuario_Cancelo.HeaderText = "Usuario Cancela";
            this.D_Usuario_Cancelo.Name = "D_Usuario_Cancelo";
            this.D_Usuario_Cancelo.ReadOnly = true;
            this.D_Usuario_Cancelo.Width = 129;
            // 
            // F_Cancelacion
            // 
            this.F_Cancelacion.DataPropertyName = "F_Cancelacion";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.F_Cancelacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.F_Cancelacion.HeaderText = "Fecha Cancela";
            this.F_Cancelacion.Name = "F_Cancelacion";
            this.F_Cancelacion.ReadOnly = true;
            this.F_Cancelacion.Width = 120;
            // 
            // Motivo_Cancela
            // 
            this.Motivo_Cancela.DataPropertyName = "Motivo_Cancela";
            this.Motivo_Cancela.HeaderText = "Motivo Cancela";
            this.Motivo_Cancela.Name = "Motivo_Cancela";
            this.Motivo_Cancela.ReadOnly = true;
            this.Motivo_Cancela.Width = 125;
            // 
            // tpDetalle
            // 
            this.tpDetalle.Controls.Add(this.grdDetalle);
            this.tpDetalle.Location = new System.Drawing.Point(4, 28);
            this.tpDetalle.Name = "tpDetalle";
            this.tpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalle.Size = new System.Drawing.Size(879, 198);
            this.tpDetalle.TabIndex = 1;
            this.tpDetalle.Text = "Detalle";
            this.tpDetalle.ToolTipText = "Muestra el Detalle de una Orden de Compra";
            this.tpDetalle.UseVisualStyleBackColor = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Orden_CompraDetalle,
            this.K_Requisicion,
            this.Cantidad,
            this.K_Articulo,
            this.D_Articulo,
            this.D_Tipo_Empaque,
            this.D_Unidad_Medida,
            this.D_Tipo_Articulo,
            this.D_Clasificacion_Articulo,
            this.D_Grupo_Articulo,
            this.PrecioUnitario,
            this.TotalDetalle});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(3, 3);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(873, 192);
            this.grdDetalle.TabIndex = 0;
            // 
            // K_Orden_CompraDetalle
            // 
            this.K_Orden_CompraDetalle.DataPropertyName = "K_Orden_Compra";
            this.K_Orden_CompraDetalle.HeaderText = "No. Orden";
            this.K_Orden_CompraDetalle.Name = "K_Orden_CompraDetalle";
            this.K_Orden_CompraDetalle.ReadOnly = true;
            this.K_Orden_CompraDetalle.Width = 96;
            // 
            // K_Requisicion
            // 
            this.K_Requisicion.DataPropertyName = "K_Requisicion";
            this.K_Requisicion.HeaderText = "No. Requisición";
            this.K_Requisicion.Name = "K_Requisicion";
            this.K_Requisicion.ReadOnly = true;
            this.K_Requisicion.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 87;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "No. Articulo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 103;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // D_Tipo_Empaque
            // 
            this.D_Tipo_Empaque.DataPropertyName = "D_Tipo_Empaque";
            this.D_Tipo_Empaque.HeaderText = "Tipo Empaque";
            this.D_Tipo_Empaque.Name = "D_Tipo_Empaque";
            this.D_Tipo_Empaque.ReadOnly = true;
            this.D_Tipo_Empaque.Visible = false;
            this.D_Tipo_Empaque.Width = 121;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "Unidad Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Width = 121;
            // 
            // D_Tipo_Articulo
            // 
            this.D_Tipo_Articulo.DataPropertyName = "D_Tipo_Producto";
            this.D_Tipo_Articulo.HeaderText = "Tipo Articulo";
            this.D_Tipo_Articulo.Name = "D_Tipo_Articulo";
            this.D_Tipo_Articulo.ReadOnly = true;
            this.D_Tipo_Articulo.Width = 108;
            // 
            // D_Clasificacion_Articulo
            // 
            this.D_Clasificacion_Articulo.DataPropertyName = "D_Categoria_Articulo";
            this.D_Clasificacion_Articulo.HeaderText = "Clasificación";
            this.D_Clasificacion_Articulo.Name = "D_Clasificacion_Articulo";
            this.D_Clasificacion_Articulo.ReadOnly = true;
            this.D_Clasificacion_Articulo.Width = 104;
            // 
            // D_Grupo_Articulo
            // 
            this.D_Grupo_Articulo.DataPropertyName = "D_Grupo_Articulo";
            this.D_Grupo_Articulo.HeaderText = "Grupo";
            this.D_Grupo_Articulo.Name = "D_Grupo_Articulo";
            this.D_Grupo_Articulo.ReadOnly = true;
            this.D_Grupo_Articulo.Width = 71;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle7;
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 70;
            // 
            // TotalDetalle
            // 
            this.TotalDetalle.DataPropertyName = "TotalDetalle";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.TotalDetalle.DefaultCellStyle = dataGridViewCellStyle8;
            this.TotalDetalle.HeaderText = "Total";
            this.TotalDetalle.Name = "TotalDetalle";
            this.TotalDetalle.ReadOnly = true;
            this.TotalDetalle.Width = 63;
            // 
            // Frm_ConsultaOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 558);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_ConsultaOrdenesCompra";
            this.Text = "CONSULTA ORDENES DE COMPRA";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.pnlFiltros, 0);
            this.Controls.SetChildIndex(this.pnlDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpOrdenes.ResumeLayout(false);
            this.tpOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.tpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.Button btnBuscaProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnBuscarOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.CheckBox cbxCanceladas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClaveRequisicion;
        private System.Windows.Forms.Button btnBuscaRequisicion;
        private System.Windows.Forms.TextBox txtRequisicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOrdenes;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.TabPage tpDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtFecha2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtFecha1;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.ImageList imageList1;
        private Controles.cbx_estatus_compra cbx_estatus_compra1;
        private Controles.cbx_grupo_articulo cbx_grupo_articulo1;
        private Controles.cbx_clasificacion_articulo cbx_clasificacion_articulo1;
        private Controles.cbx_tipo_articulo cbx_tipo_articulo1;
        private Controles.cbx_tipo_moneda cbx_tipo_moneda1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_CompraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Empaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Clasificacion_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Grupo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Elaboro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Cancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Cancelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo_Cancela;
    }
}