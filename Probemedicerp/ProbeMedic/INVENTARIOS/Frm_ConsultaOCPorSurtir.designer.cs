﻿
namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_ConsultaOCPorSurtir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaOCPorSurtir));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOrdenes = new System.Windows.Forms.TabPage();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Orden_CompraDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK_Detalle_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK_Tipo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK_Clasificacion_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK_Grupo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Clasificacion_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Grupo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.K_Orden_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Elaboro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_estatus_compra1 = new ProbeMedic.Controles.cbx_estatus_compra();
            this.label5 = new System.Windows.Forms.Label();
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
            this.lblTitulo.BackColor = System.Drawing.Color.Gray;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1047, 21);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Consulta Ordenes de Compra por Surtir";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Controls.Add(this.gbFiltros);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 59);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1047, 189);
            this.pnlFiltros.TabIndex = 5;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cbx_estatus_compra1);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.groupBox1);
            this.gbFiltros.Controls.Add(this.cmbClasificacion);
            this.gbFiltros.Controls.Add(this.label8);
            this.gbFiltros.Controls.Add(this.cmbTipoArticulo);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.txtClaveProveedor);
            this.gbFiltros.Controls.Add(this.txtClaveOficina);
            this.gbFiltros.Controls.Add(this.btnBuscaProveedor);
            this.gbFiltros.Controls.Add(this.txtProveedor);
            this.gbFiltros.Controls.Add(this.txtOficina);
            this.gbFiltros.Controls.Add(this.txtNoOrden);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiltros.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.Black;
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1043, 185);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtFecha2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFecha1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 57);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Fechas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(234, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hasta";
            // 
            // txtFecha2
            // 
            this.txtFecha2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha2.Location = new System.Drawing.Point(280, 18);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.Size = new System.Drawing.Size(88, 23);
            this.txtFecha2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(70, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Desde";
            // 
            // txtFecha1
            // 
            this.txtFecha1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha1.Location = new System.Drawing.Point(122, 19);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(88, 23);
            this.txtFecha1.TabIndex = 0;
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Location = new System.Drawing.Point(665, 43);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(274, 24);
            this.cmbClasificacion.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Clasificación";
            // 
            // cmbTipoArticulo
            // 
            this.cmbTipoArticulo.FormattingEnabled = true;
            this.cmbTipoArticulo.Location = new System.Drawing.Point(665, 15);
            this.cmbTipoArticulo.Name = "cmbTipoArticulo";
            this.cmbTipoArticulo.Size = new System.Drawing.Size(274, 24);
            this.cmbTipoArticulo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tipo Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 80);
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
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Oficina";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(88, 73);
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
            this.txtClaveOficina.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveOficina.Location = new System.Drawing.Point(88, 43);
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
            this.btnBuscaProveedor.Location = new System.Drawing.Point(426, 73);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaProveedor.TabIndex = 6;
            this.btnBuscaProveedor.Tag = "";
            this.btnBuscaProveedor.UseVisualStyleBackColor = true;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(139, 73);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(283, 24);
            this.txtProveedor.TabIndex = 5;
            this.txtProveedor.TabStop = false;
            // 
            // txtOficina
            // 
            this.txtOficina.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficina.Location = new System.Drawing.Point(139, 43);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(283, 24);
            this.txtOficina.TabIndex = 2;
            this.txtOficina.TabStop = false;
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(88, 15);
            this.txtNoOrden.MaxLength = 10;
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(100, 24);
            this.txtNoOrden.TabIndex = 0;
            this.txtNoOrden.Tag = "ENTERO";
            this.txtNoOrden.TextChanged += new System.EventHandler(this.txtNoOrden_TextChanged);
            this.txtNoOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOrden_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Orden";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.tabControl1);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 248);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1047, 259);
            this.pnlDatos.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOrdenes);
            this.tabControl1.Controls.Add(this.tpDetalle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 259);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpOrdenes
            // 
            this.tpOrdenes.Controls.Add(this.grdDatos);
            this.tpOrdenes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpOrdenes.Location = new System.Drawing.Point(4, 25);
            this.tpOrdenes.Name = "tpOrdenes";
            this.tpOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrdenes.Size = new System.Drawing.Size(1039, 230);
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
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Orden_Compra,
            this.K_Almacen,
            this.D_Almacen,
            this.K_Oficina,
            this.F_OrdenCompra,
            this.K_Proveedor,
            this.Nombre,
            this.D_Oficina,
            this.SubTotal,
            this.IVA,
            this.TotalIva,
            this.Total,
            this.D_Tipo_Moneda,
            this.TiempoEntrega,
            this.F_Entrega,
            this.Observaciones,
            this.Tipo_Cambio,
            this.D_Usuario_Elaboro});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 3);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1033, 224);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentDoubleClick);
            // 
            // tpDetalle
            // 
            this.tpDetalle.Controls.Add(this.grdDetalle);
            this.tpDetalle.Location = new System.Drawing.Point(4, 25);
            this.tpDetalle.Name = "tpDetalle";
            this.tpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalle.Size = new System.Drawing.Size(1039, 230);
            this.tpDetalle.TabIndex = 1;
            this.tpDetalle.Text = "Detalle";
            this.tpDetalle.ToolTipText = "Muestra el Detalle de una Orden de Compra";
            this.tpDetalle.UseVisualStyleBackColor = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Orden_CompraDetalle,
            this.K_Requisicion,
            this.Cantidad,
            this.K_Articulo,
            this.D_Articulo,
            this.D_Unidad_Medida,
            this.D_Tipo_Articulo,
            this.colK_Detalle_Requisicion,
            this.colK_Unidad_Medida,
            this.colK_Tipo_Articulo,
            this.colK_Clasificacion_Articulo,
            this.colK_Grupo_Articulo,
            this.D_Clasificacion_Articulo,
            this.D_Grupo_Articulo,
            this.PrecioUnitario,
            this.TotalDetalle});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(3, 3);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.Size = new System.Drawing.Size(1033, 224);
            this.grdDetalle.TabIndex = 0;
            // 
            // K_Orden_CompraDetalle
            // 
            this.K_Orden_CompraDetalle.DataPropertyName = "K_Orden_Compra";
            this.K_Orden_CompraDetalle.HeaderText = "No. Orden";
            this.K_Orden_CompraDetalle.Name = "K_Orden_CompraDetalle";
            this.K_Orden_CompraDetalle.ReadOnly = true;
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
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "No. Articulo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 300;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "Unidad Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Width = 125;
            // 
            // D_Tipo_Articulo
            // 
            this.D_Tipo_Articulo.DataPropertyName = "D_Tipo_Producto";
            this.D_Tipo_Articulo.HeaderText = "Tipo Articulo";
            this.D_Tipo_Articulo.Name = "D_Tipo_Articulo";
            this.D_Tipo_Articulo.ReadOnly = true;
            this.D_Tipo_Articulo.Width = 150;
            // 
            // colK_Detalle_Requisicion
            // 
            this.colK_Detalle_Requisicion.DataPropertyName = "K_Detalle_Requisicion";
            this.colK_Detalle_Requisicion.HeaderText = "Cve Detalle Requisicion";
            this.colK_Detalle_Requisicion.Name = "colK_Detalle_Requisicion";
            this.colK_Detalle_Requisicion.ReadOnly = true;
            this.colK_Detalle_Requisicion.Visible = false;
            // 
            // colK_Unidad_Medida
            // 
            this.colK_Unidad_Medida.DataPropertyName = "K_Unidad_Medida";
            this.colK_Unidad_Medida.HeaderText = "Cve Unidad Medida";
            this.colK_Unidad_Medida.Name = "colK_Unidad_Medida";
            this.colK_Unidad_Medida.ReadOnly = true;
            this.colK_Unidad_Medida.Visible = false;
            // 
            // colK_Tipo_Articulo
            // 
            this.colK_Tipo_Articulo.DataPropertyName = "K_Tipo_Articulo";
            this.colK_Tipo_Articulo.HeaderText = "Cve Tipo Articulo";
            this.colK_Tipo_Articulo.Name = "colK_Tipo_Articulo";
            this.colK_Tipo_Articulo.ReadOnly = true;
            this.colK_Tipo_Articulo.Visible = false;
            // 
            // colK_Clasificacion_Articulo
            // 
            this.colK_Clasificacion_Articulo.DataPropertyName = "K_Clasificacion_Articulo";
            this.colK_Clasificacion_Articulo.HeaderText = "Clasif Articulo";
            this.colK_Clasificacion_Articulo.Name = "colK_Clasificacion_Articulo";
            this.colK_Clasificacion_Articulo.ReadOnly = true;
            this.colK_Clasificacion_Articulo.Visible = false;
            // 
            // colK_Grupo_Articulo
            // 
            this.colK_Grupo_Articulo.DataPropertyName = "K_Grupo_Articulo";
            this.colK_Grupo_Articulo.HeaderText = "Cve Grupo Articulo";
            this.colK_Grupo_Articulo.Name = "colK_Grupo_Articulo";
            this.colK_Grupo_Articulo.ReadOnly = true;
            this.colK_Grupo_Articulo.Visible = false;
            // 
            // D_Clasificacion_Articulo
            // 
            this.D_Clasificacion_Articulo.DataPropertyName = "D_Categoria_Articulo";
            this.D_Clasificacion_Articulo.HeaderText = "Clasificación";
            this.D_Clasificacion_Articulo.Name = "D_Clasificacion_Articulo";
            this.D_Clasificacion_Articulo.ReadOnly = true;
            this.D_Clasificacion_Articulo.Width = 250;
            // 
            // D_Grupo_Articulo
            // 
            this.D_Grupo_Articulo.DataPropertyName = "D_Grupo_Articulo";
            this.D_Grupo_Articulo.HeaderText = "Grupo";
            this.D_Grupo_Articulo.Name = "D_Grupo_Articulo";
            this.D_Grupo_Articulo.ReadOnly = true;
            this.D_Grupo_Articulo.Width = 80;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle8.Format = "C2";
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // TotalDetalle
            // 
            this.TotalDetalle.DataPropertyName = "TotalDetalle";
            dataGridViewCellStyle9.Format = "C2";
            this.TotalDetalle.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalDetalle.HeaderText = "Total";
            this.TotalDetalle.Name = "TotalDetalle";
            this.TotalDetalle.ReadOnly = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // K_Orden_Compra
            // 
            this.K_Orden_Compra.DataPropertyName = "K_Orden_Compra";
            this.K_Orden_Compra.HeaderText = "No. Orden";
            this.K_Orden_Compra.Name = "K_Orden_Compra";
            this.K_Orden_Compra.ReadOnly = true;
            this.K_Orden_Compra.Width = 96;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.ReadOnly = true;
            this.K_Almacen.Visible = false;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacen";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 84;
            // 
            // K_Oficina
            // 
            this.K_Oficina.DataPropertyName = "D_Estatus_Compra";
            this.K_Oficina.HeaderText = "Estatus Compra";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.ReadOnly = true;
            this.K_Oficina.Width = 131;
            // 
            // F_OrdenCompra
            // 
            this.F_OrdenCompra.DataPropertyName = "F_OrdenCompra";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.F_OrdenCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.F_OrdenCompra.HeaderText = "Fecha";
            this.F_OrdenCompra.Name = "F_OrdenCompra";
            this.F_OrdenCompra.ReadOnly = true;
            this.F_OrdenCompra.ToolTipText = "Fecha de la Orden de Compra";
            this.F_OrdenCompra.Width = 69;
            // 
            // K_Proveedor
            // 
            this.K_Proveedor.DataPropertyName = "K_Proveedor";
            this.K_Proveedor.HeaderText = "No. Proveedor";
            this.K_Proveedor.Name = "K_Proveedor";
            this.K_Proveedor.ReadOnly = true;
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
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.ToolTipText = "Oficina que recibe";
            this.D_Oficina.Width = 73;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle2.Format = "N2";
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 87;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "TasaIVA";
            dataGridViewCellStyle3.Format = "N2";
            this.IVA.DefaultCellStyle = dataGridViewCellStyle3;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Visible = false;
            this.IVA.Width = 53;
            // 
            // TotalIva
            // 
            this.TotalIva.DataPropertyName = "Total_IVA";
            dataGridViewCellStyle4.Format = "N2";
            this.TotalIva.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalIva.HeaderText = "TotalIva";
            this.TotalIva.Name = "TotalIva";
            this.TotalIva.ReadOnly = true;
            this.TotalIva.Width = 82;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "N2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 63;
            // 
            // D_Tipo_Moneda
            // 
            this.D_Tipo_Moneda.DataPropertyName = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.HeaderText = "Tipo Moneda";
            this.D_Tipo_Moneda.Name = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.ReadOnly = true;
            this.D_Tipo_Moneda.Width = 111;
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
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.F_Entrega.DefaultCellStyle = dataGridViewCellStyle6;
            this.F_Entrega.HeaderText = "Fecha Entrega";
            this.F_Entrega.Name = "F_Entrega";
            this.F_Entrega.ReadOnly = true;
            this.F_Entrega.Width = 121;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 122;
            // 
            // Tipo_Cambio
            // 
            this.Tipo_Cambio.DataPropertyName = "Tipo_Cambio";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Tipo_Cambio.DefaultCellStyle = dataGridViewCellStyle7;
            this.Tipo_Cambio.HeaderText = "Tipo Cambio";
            this.Tipo_Cambio.Name = "Tipo_Cambio";
            this.Tipo_Cambio.ReadOnly = true;
            this.Tipo_Cambio.Visible = false;
            this.Tipo_Cambio.Width = 109;
            // 
            // D_Usuario_Elaboro
            // 
            this.D_Usuario_Elaboro.DataPropertyName = "D_Usuario_Elaboro";
            this.D_Usuario_Elaboro.HeaderText = "Usuario";
            this.D_Usuario_Elaboro.Name = "D_Usuario_Elaboro";
            this.D_Usuario_Elaboro.ReadOnly = true;
            this.D_Usuario_Elaboro.Visible = false;
            this.D_Usuario_Elaboro.Width = 78;
            // 
            // cbx_estatus_compra1
            // 
            this.cbx_estatus_compra1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_estatus_compra1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_estatus_compra1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_estatus_compra1.FormattingEnabled = true;
            this.cbx_estatus_compra1.Location = new System.Drawing.Point(666, 73);
            this.cbx_estatus_compra1.Name = "cbx_estatus_compra1";
            this.cbx_estatus_compra1.Size = new System.Drawing.Size(273, 24);
            this.cbx_estatus_compra1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Estatus Compra";
            // 
            // Frm_ConsultaOCPorSurtir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 546);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_ConsultaOCPorSurtir";
            this.Text = "CONSULTA ORDENES DE COMPRA POR SURTIR";
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
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.ComboBox cmbTipoArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_CompraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK_Detalle_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK_Tipo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK_Clasificacion_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK_Grupo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Clasificacion_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Grupo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDetalle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Elaboro;
        private Controles.cbx_estatus_compra cbx_estatus_compra1;
        private System.Windows.Forms.Label label5;
    }
}