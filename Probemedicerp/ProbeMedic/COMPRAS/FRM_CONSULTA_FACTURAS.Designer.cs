namespace ProbeMedic.COMPRAS
{
    partial class FRM_CONSULTA_FACTURAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CONSULTA_FACTURAS));
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_rango_fechas = new System.Windows.Forms.CheckBox();
            this.checkBox_habilita_fecha_factura = new System.Windows.Forms.CheckBox();
            this.txt_no_devolucion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nota_de_Credito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Factura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Factura = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Final = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.check_box_sin_factura = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Orden_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficina_Recibe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Elaboro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Recibio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Directa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Autoriza_SinFactura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Sucursal_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel_filtros.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.gbFiltros);
            this.panel_filtros.Controls.Add(this.lblTitulo);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filtros.Location = new System.Drawing.Point(0, 38);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(1255, 253);
            this.panel_filtros.TabIndex = 2;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.White;
            this.gbFiltros.Controls.Add(this.cbxAlmacen);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.checkBox_rango_fechas);
            this.gbFiltros.Controls.Add(this.checkBox_habilita_fecha_factura);
            this.gbFiltros.Controls.Add(this.txt_no_devolucion);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.txt_Nota_de_Credito);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.txt_Factura);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.dtp_Fecha_Factura);
            this.gbFiltros.Controls.Add(this.groupBox1);
            this.gbFiltros.Controls.Add(this.check_box_sin_factura);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.txtClaveProveedor);
            this.gbFiltros.Controls.Add(this.btnBuscaProveedor);
            this.gbFiltros.Controls.Add(this.txtProveedor);
            this.gbFiltros.Controls.Add(this.txtNoOrden);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiltros.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.Black;
            this.gbFiltros.Location = new System.Drawing.Point(0, 29);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1255, 224);
            this.gbFiltros.TabIndex = 6;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Tipo de Búsqueda";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(88, 88);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(335, 25);
            this.cbxAlmacen.TabIndex = 414;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 415;
            this.label7.Text = "Almacen";
            // 
            // checkBox_rango_fechas
            // 
            this.checkBox_rango_fechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_rango_fechas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_rango_fechas.ImageIndex = 1;
            this.checkBox_rango_fechas.Location = new System.Drawing.Point(7, 144);
            this.checkBox_rango_fechas.Name = "checkBox_rango_fechas";
            this.checkBox_rango_fechas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_rango_fechas.Size = new System.Drawing.Size(174, 19);
            this.checkBox_rango_fechas.TabIndex = 52;
            this.checkBox_rango_fechas.Text = "Habilita rango fechas";
            this.checkBox_rango_fechas.UseVisualStyleBackColor = true;
            this.checkBox_rango_fechas.CheckedChanged += new System.EventHandler(this.checkBox_rango_fechas_CheckedChanged);
            // 
            // checkBox_habilita_fecha_factura
            // 
            this.checkBox_habilita_fecha_factura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_habilita_fecha_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_habilita_fecha_factura.ImageIndex = 1;
            this.checkBox_habilita_fecha_factura.Location = new System.Drawing.Point(236, 117);
            this.checkBox_habilita_fecha_factura.Name = "checkBox_habilita_fecha_factura";
            this.checkBox_habilita_fecha_factura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_habilita_fecha_factura.Size = new System.Drawing.Size(121, 25);
            this.checkBox_habilita_fecha_factura.TabIndex = 51;
            this.checkBox_habilita_fecha_factura.Text = "Habilita Fecha";
            this.checkBox_habilita_fecha_factura.UseVisualStyleBackColor = true;
            this.checkBox_habilita_fecha_factura.CheckedChanged += new System.EventHandler(this.checkBox_habilita_fecha_factura_CheckedChanged);
            // 
            // txt_no_devolucion
            // 
            this.txt_no_devolucion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_no_devolucion.Location = new System.Drawing.Point(725, 68);
            this.txt_no_devolucion.MaxLength = 10;
            this.txt_no_devolucion.Name = "txt_no_devolucion";
            this.txt_no_devolucion.Size = new System.Drawing.Size(132, 24);
            this.txt_no_devolucion.TabIndex = 49;
            this.txt_no_devolucion.Tag = "ENTERO";
            this.txt_no_devolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_devolucion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(592, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "No. de devolución";
            // 
            // txt_Nota_de_Credito
            // 
            this.txt_Nota_de_Credito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nota_de_Credito.Location = new System.Drawing.Point(725, 33);
            this.txt_Nota_de_Credito.MaxLength = 10;
            this.txt_Nota_de_Credito.Name = "txt_Nota_de_Credito";
            this.txt_Nota_de_Credito.Size = new System.Drawing.Size(132, 24);
            this.txt_Nota_de_Credito.TabIndex = 47;
            this.txt_Nota_de_Credito.Tag = "ENTERO";
            this.txt_Nota_de_Credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nota_de_Credito_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(592, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "No. Nota de crédito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Factura";
            // 
            // txt_Factura
            // 
            this.txt_Factura.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Factura.Location = new System.Drawing.Point(87, 117);
            this.txt_Factura.MaxLength = 10;
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.Size = new System.Drawing.Size(132, 24);
            this.txt_Factura.TabIndex = 45;
            this.txt_Factura.Tag = "ENTERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(363, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Fecha factura";
            // 
            // dtp_Fecha_Factura
            // 
            this.dtp_Fecha_Factura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha_Factura.Location = new System.Drawing.Point(459, 117);
            this.dtp_Fecha_Factura.Name = "dtp_Fecha_Factura";
            this.dtp_Fecha_Factura.Size = new System.Drawing.Size(102, 24);
            this.dtp_Fecha_Factura.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtp_Fecha_Final);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtp_Fecha_Inicial);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 51);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Fechas Entrada Almacén";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(275, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hasta";
            // 
            // dtp_Fecha_Final
            // 
            this.dtp_Fecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha_Final.Location = new System.Drawing.Point(321, 23);
            this.dtp_Fecha_Final.Name = "dtp_Fecha_Final";
            this.dtp_Fecha_Final.Size = new System.Drawing.Size(102, 24);
            this.dtp_Fecha_Final.TabIndex = 1;
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
            // dtp_Fecha_Inicial
            // 
            this.dtp_Fecha_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha_Inicial.Location = new System.Drawing.Point(72, 23);
            this.dtp_Fecha_Inicial.Name = "dtp_Fecha_Inicial";
            this.dtp_Fecha_Inicial.Size = new System.Drawing.Size(102, 24);
            this.dtp_Fecha_Inicial.TabIndex = 0;
            // 
            // check_box_sin_factura
            // 
            this.check_box_sin_factura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_box_sin_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_box_sin_factura.ImageIndex = 1;
            this.check_box_sin_factura.Location = new System.Drawing.Point(667, 176);
            this.check_box_sin_factura.Name = "check_box_sin_factura";
            this.check_box_sin_factura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_box_sin_factura.Size = new System.Drawing.Size(160, 25);
            this.check_box_sin_factura.TabIndex = 15;
            this.check_box_sin_factura.Text = "Sin factura";
            this.check_box_sin_factura.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(88, 61);
            this.txtClaveProveedor.MaxLength = 5;
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.Size = new System.Drawing.Size(50, 24);
            this.txtClaveProveedor.TabIndex = 4;
            this.txtClaveProveedor.Tag = "ENTERO";
            this.txtClaveProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveProveedor_KeyPress);
            this.txtClaveProveedor.Leave += new System.EventHandler(this.txtClaveProveedor_Leave);
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProveedor.Image")));
            this.btnBuscaProveedor.Location = new System.Drawing.Point(427, 61);
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
            this.txtProveedor.Location = new System.Drawing.Point(139, 61);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(283, 24);
            this.txtProveedor.TabIndex = 5;
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(88, 29);
            this.txtNoOrden.MaxLength = 10;
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(132, 24);
            this.txtNoOrden.TabIndex = 0;
            this.txtNoOrden.Tag = "ENTERO";
            this.txtNoOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOrden_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Orden";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1255, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Consulta de facturas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.grdDatos);
            this.panel_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos.Location = new System.Drawing.Point(0, 291);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(1255, 271);
            this.panel_datos.TabIndex = 3;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Orden_Compra,
            this.No_Factura,
            this.F_Factura,
            this.F_OrdenCompra,
            this.Oficina_Recibe,
            this.D_Estatus_Compra,
            this.Almacen,
            this.Usuario_Elaboro,
            this.Usuario_Recibio,
            this.B_Directa,
            this.B_Autoriza_SinFactura,
            this.Devolucion,
            this.NotaCredito,
            this.D_Tipo_Moneda,
            this.D_Sucursal_Proveedor,
            this.Subtotal,
            this.Total_Iva,
            this.Total});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(1255, 271);
            this.grdDatos.TabIndex = 1;
            // 
            // K_Orden_Compra
            // 
            this.K_Orden_Compra.DataPropertyName = "K_Orden_Compra";
            this.K_Orden_Compra.HeaderText = "No. Orden";
            this.K_Orden_Compra.Name = "K_Orden_Compra";
            this.K_Orden_Compra.ReadOnly = true;
            // 
            // No_Factura
            // 
            this.No_Factura.DataPropertyName = "No_Factura";
            this.No_Factura.HeaderText = "Factura";
            this.No_Factura.Name = "No_Factura";
            this.No_Factura.ReadOnly = true;
            // 
            // F_Factura
            // 
            this.F_Factura.DataPropertyName = "F_Factura";
            this.F_Factura.HeaderText = "Fecha factura";
            this.F_Factura.Name = "F_Factura";
            this.F_Factura.ReadOnly = true;
            // 
            // F_OrdenCompra
            // 
            this.F_OrdenCompra.DataPropertyName = "F_OrdenCompra";
            this.F_OrdenCompra.HeaderText = "Fecha Orden Compra";
            this.F_OrdenCompra.Name = "F_OrdenCompra";
            this.F_OrdenCompra.ReadOnly = true;
            // 
            // Oficina_Recibe
            // 
            this.Oficina_Recibe.DataPropertyName = "Oficina_Recibe";
            this.Oficina_Recibe.HeaderText = "Oficina recibe";
            this.Oficina_Recibe.Name = "Oficina_Recibe";
            this.Oficina_Recibe.ReadOnly = true;
            // 
            // D_Estatus_Compra
            // 
            this.D_Estatus_Compra.DataPropertyName = "D_Estatus_Compra";
            this.D_Estatus_Compra.HeaderText = "Estatus Compra";
            this.D_Estatus_Compra.Name = "D_Estatus_Compra";
            this.D_Estatus_Compra.ReadOnly = true;
            // 
            // Almacen
            // 
            this.Almacen.DataPropertyName = "D_Almacen";
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            // 
            // Usuario_Elaboro
            // 
            this.Usuario_Elaboro.DataPropertyName = "Usuario_Elaboro";
            this.Usuario_Elaboro.HeaderText = "Usuario Elaboró";
            this.Usuario_Elaboro.Name = "Usuario_Elaboro";
            this.Usuario_Elaboro.ReadOnly = true;
            // 
            // Usuario_Recibio
            // 
            this.Usuario_Recibio.DataPropertyName = "Usuario_Recibio";
            this.Usuario_Recibio.HeaderText = "Usuario Recibió";
            this.Usuario_Recibio.Name = "Usuario_Recibio";
            this.Usuario_Recibio.ReadOnly = true;
            // 
            // B_Directa
            // 
            this.B_Directa.DataPropertyName = "B_Directa";
            this.B_Directa.HeaderText = "Directa";
            this.B_Directa.Name = "B_Directa";
            this.B_Directa.ReadOnly = true;
            // 
            // B_Autoriza_SinFactura
            // 
            this.B_Autoriza_SinFactura.DataPropertyName = "B_Autoriza_SinFactura";
            this.B_Autoriza_SinFactura.HeaderText = "Autoriza sin factura";
            this.B_Autoriza_SinFactura.Name = "B_Autoriza_SinFactura";
            this.B_Autoriza_SinFactura.ReadOnly = true;
            this.B_Autoriza_SinFactura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Autoriza_SinFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Devolucion
            // 
            this.Devolucion.DataPropertyName = "K_Devolucion";
            this.Devolucion.HeaderText = "Devolución";
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.ReadOnly = true;
            // 
            // NotaCredito
            // 
            this.NotaCredito.DataPropertyName = "K_Notas_Credito_Orden_Compra";
            this.NotaCredito.HeaderText = "Nota Credito";
            this.NotaCredito.Name = "NotaCredito";
            this.NotaCredito.ReadOnly = true;
            // 
            // D_Tipo_Moneda
            // 
            this.D_Tipo_Moneda.DataPropertyName = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.HeaderText = "Tipo Moneda";
            this.D_Tipo_Moneda.Name = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.ReadOnly = true;
            // 
            // D_Sucursal_Proveedor
            // 
            this.D_Sucursal_Proveedor.DataPropertyName = "D_Sucursal_Proveedor";
            this.D_Sucursal_Proveedor.HeaderText = "Sucursal Proveedor";
            this.D_Sucursal_Proveedor.Name = "D_Sucursal_Proveedor";
            this.D_Sucursal_Proveedor.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Total_Iva
            // 
            this.Total_Iva.DataPropertyName = "Total_Iva";
            this.Total_Iva.HeaderText = "Iva";
            this.Total_Iva.Name = "Total_Iva";
            this.Total_Iva.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FRM_CONSULTA_FACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 601);
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.panel_filtros);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FRM_CONSULTA_FACTURAS";
            this.Text = "CONSULTA DE FACTURAS";
            this.Controls.SetChildIndex(this.panel_filtros, 0);
            this.Controls.SetChildIndex(this.panel_datos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Final;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Inicial;
        private System.Windows.Forms.CheckBox check_box_sin_factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Button btnBuscaProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Factura;
        private System.Windows.Forms.TextBox txt_no_devolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nota_de_Credito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Factura;
        private System.Windows.Forms.CheckBox checkBox_rango_fechas;
        private System.Windows.Forms.CheckBox checkBox_habilita_fecha_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficina_Recibe;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Elaboro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Recibio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Directa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Autoriza_SinFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Sucursal_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label7;
    }
}