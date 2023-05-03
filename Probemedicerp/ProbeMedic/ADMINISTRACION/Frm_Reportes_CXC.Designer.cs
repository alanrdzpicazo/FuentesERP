namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_Reportes_CXC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reportes_CXC));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAbajo = new System.Windows.Forms.Panel();
            this.pnlIzquierda = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAlmacenesSeleccionados = new System.Windows.Forms.Label();
            this.gbAlmacen = new System.Windows.Forms.GroupBox();
            this.rdb_SeleccionarAlmacen = new System.Windows.Forms.RadioButton();
            this.rdb_SeleccionarTodosAlmacenes = new System.Windows.Forms.RadioButton();
            this.dtp_F_Final = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_F_Inicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fechas = new System.Windows.Forms.Label();
            this.cmb_TipoReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Reporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDerecha = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btn_Correo = new System.Windows.Forms.Button();
            this.btn_Preeliminar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tpArticulos = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rdbTodosClientes = new System.Windows.Forms.RadioButton();
            this.rdbSeleccionarClientes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.ucCanalDistribucionCliente1 = new ProbeMedic.Controles.ucCanalDistribucionCliente();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.tpFacturas = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_K_Factura = new System.Windows.Forms.TextBox();
            this.txt_Pedido_Inicial_Remision = new System.Windows.Forms.TextBox();
            this.txt_Pedido_Final_Remision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Rango_Inicial_Remision = new System.Windows.Forms.TextBox();
            this.txt_Rango_Fina_Remision = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFacturasPorDepositar = new System.Windows.Forms.RadioButton();
            this.rdbTodasFacturas = new System.Windows.Forms.RadioButton();
            this.rdbFacturasDepositadas = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnl_Fechas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAbajo.SuspendLayout();
            this.pnlIzquierda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbAlmacen.SuspendLayout();
            this.pnlDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tpArticulos.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.tpFacturas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnl_Fechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.tableLayoutPanel1);
            this.pnlGeneral.Controls.Add(this.pnlDerecha);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(718, 515);
            this.pnlGeneral.TabIndex = 0;
            this.pnlGeneral.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlAbajo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.91262F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.08738F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 515);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pnlAbajo
            // 
            this.pnlAbajo.Controls.Add(this.pnlIzquierda);
            this.pnlAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbajo.Location = new System.Drawing.Point(3, 223);
            this.pnlAbajo.Name = "pnlAbajo";
            this.pnlAbajo.Size = new System.Drawing.Size(595, 289);
            this.pnlAbajo.TabIndex = 5;
            // 
            // pnlIzquierda
            // 
            this.pnlIzquierda.Controls.Add(this.tabControl1);
            this.pnlIzquierda.Controls.Add(this.lblTitulo);
            this.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierda.Name = "pnlIzquierda";
            this.pnlIzquierda.Size = new System.Drawing.Size(595, 289);
            this.pnlIzquierda.TabIndex = 4;
            this.pnlIzquierda.TabStop = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(595, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "FILTROS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_Fechas);
            this.panel2.Controls.Add(this.lblAlmacenesSeleccionados);
            this.panel2.Controls.Add(this.gbAlmacen);
            this.panel2.Controls.Add(this.cmb_TipoReporte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_Reporte);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 214);
            this.panel2.TabIndex = 3;
            this.panel2.TabStop = true;
            // 
            // lblAlmacenesSeleccionados
            // 
            this.lblAlmacenesSeleccionados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenesSeleccionados.Location = new System.Drawing.Point(114, 168);
            this.lblAlmacenesSeleccionados.Name = "lblAlmacenesSeleccionados";
            this.lblAlmacenesSeleccionados.Size = new System.Drawing.Size(416, 45);
            this.lblAlmacenesSeleccionados.TabIndex = 13;
            // 
            // gbAlmacen
            // 
            this.gbAlmacen.Controls.Add(this.rdb_SeleccionarAlmacen);
            this.gbAlmacen.Controls.Add(this.rdb_SeleccionarTodosAlmacenes);
            this.gbAlmacen.Location = new System.Drawing.Point(116, 120);
            this.gbAlmacen.Name = "gbAlmacen";
            this.gbAlmacen.Size = new System.Drawing.Size(414, 46);
            this.gbAlmacen.TabIndex = 12;
            this.gbAlmacen.TabStop = false;
            this.gbAlmacen.Text = "Almacén";
            // 
            // rdb_SeleccionarAlmacen
            // 
            this.rdb_SeleccionarAlmacen.AutoSize = true;
            this.rdb_SeleccionarAlmacen.Location = new System.Drawing.Point(175, 19);
            this.rdb_SeleccionarAlmacen.Name = "rdb_SeleccionarAlmacen";
            this.rdb_SeleccionarAlmacen.Size = new System.Drawing.Size(149, 21);
            this.rdb_SeleccionarAlmacen.TabIndex = 13;
            this.rdb_SeleccionarAlmacen.TabStop = true;
            this.rdb_SeleccionarAlmacen.Text = "Seleccionar Almacén";
            this.rdb_SeleccionarAlmacen.UseVisualStyleBackColor = true;
            this.rdb_SeleccionarAlmacen.CheckedChanged += new System.EventHandler(this.rdb_SeleccionarAlmacen_CheckedChanged);
            // 
            // rdb_SeleccionarTodosAlmacenes
            // 
            this.rdb_SeleccionarTodosAlmacenes.AutoSize = true;
            this.rdb_SeleccionarTodosAlmacenes.Location = new System.Drawing.Point(22, 20);
            this.rdb_SeleccionarTodosAlmacenes.Name = "rdb_SeleccionarTodosAlmacenes";
            this.rdb_SeleccionarTodosAlmacenes.Size = new System.Drawing.Size(132, 21);
            this.rdb_SeleccionarTodosAlmacenes.TabIndex = 12;
            this.rdb_SeleccionarTodosAlmacenes.TabStop = true;
            this.rdb_SeleccionarTodosAlmacenes.Text = "Todos Almacenes";
            this.rdb_SeleccionarTodosAlmacenes.UseVisualStyleBackColor = true;
            // 
            // dtp_F_Final
            // 
            this.dtp_F_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_F_Final.Location = new System.Drawing.Point(359, 2);
            this.dtp_F_Final.Name = "dtp_F_Final";
            this.dtp_F_Final.Size = new System.Drawing.Size(109, 24);
            this.dtp_F_Final.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "a la fecha final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "De";
            // 
            // dtp_F_Inicial
            // 
            this.dtp_F_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_F_Inicial.Location = new System.Drawing.Point(134, 2);
            this.dtp_F_Inicial.Name = "dtp_F_Inicial";
            this.dtp_F_Inicial.Size = new System.Drawing.Size(109, 24);
            this.dtp_F_Inicial.TabIndex = 6;
            // 
            // lbl_Fechas
            // 
            this.lbl_Fechas.AutoSize = true;
            this.lbl_Fechas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechas.Location = new System.Drawing.Point(10, 6);
            this.lbl_Fechas.Name = "lbl_Fechas";
            this.lbl_Fechas.Size = new System.Drawing.Size(48, 16);
            this.lbl_Fechas.TabIndex = 5;
            this.lbl_Fechas.Text = "Fechas";
            // 
            // cmb_TipoReporte
            // 
            this.cmb_TipoReporte.Enabled = false;
            this.cmb_TipoReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TipoReporte.FormattingEnabled = true;
            this.cmb_TipoReporte.Location = new System.Drawing.Point(117, 14);
            this.cmb_TipoReporte.Name = "cmb_TipoReporte";
            this.cmb_TipoReporte.Size = new System.Drawing.Size(223, 27);
            this.cmb_TipoReporte.TabIndex = 4;
            this.cmb_TipoReporte.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Reporte";
            // 
            // cmb_Reporte
            // 
            this.cmb_Reporte.FormattingEnabled = true;
            this.cmb_Reporte.Location = new System.Drawing.Point(117, 53);
            this.cmb_Reporte.Name = "cmb_Reporte";
            this.cmb_Reporte.Size = new System.Drawing.Size(475, 24);
            this.cmb_Reporte.TabIndex = 2;
            this.cmb_Reporte.SelectedIndexChanged += new System.EventHandler(this.cmb_Reporte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte";
            // 
            // pnlDerecha
            // 
            this.pnlDerecha.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDerecha.Controls.Add(this.btnSalir);
            this.pnlDerecha.Controls.Add(this.btnExcel);
            this.pnlDerecha.Controls.Add(this.btn_Correo);
            this.pnlDerecha.Controls.Add(this.btn_Preeliminar);
            this.pnlDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDerecha.Location = new System.Drawing.Point(601, 0);
            this.pnlDerecha.Name = "pnlDerecha";
            this.pnlDerecha.Size = new System.Drawing.Size(117, 515);
            this.pnlDerecha.TabIndex = 6;
            this.pnlDerecha.TabStop = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(7, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 68);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(7, 251);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(102, 68);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btn_Correo
            // 
            this.btn_Correo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Correo.Image = global::ProbeMedic.Properties.Resources.sendbymail_enviar_1541;
            this.btn_Correo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Correo.Location = new System.Drawing.Point(6, 154);
            this.btn_Correo.Name = "btn_Correo";
            this.btn_Correo.Size = new System.Drawing.Size(102, 68);
            this.btn_Correo.TabIndex = 8;
            this.btn_Correo.Text = "Enviar a\r\nCorreo";
            this.btn_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Correo.UseVisualStyleBackColor = true;
            this.btn_Correo.Click += new System.EventHandler(this.btn_Correo_Click);
            // 
            // btn_Preeliminar
            // 
            this.btn_Preeliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preeliminar.Image = global::ProbeMedic.Properties.Resources.btnBuscaPaciente_Image;
            this.btn_Preeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Preeliminar.Location = new System.Drawing.Point(7, 60);
            this.btn_Preeliminar.Name = "btn_Preeliminar";
            this.btn_Preeliminar.Size = new System.Drawing.Size(102, 68);
            this.btn_Preeliminar.TabIndex = 7;
            this.btn_Preeliminar.Text = "Preeliminar";
            this.btn_Preeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Preeliminar.UseVisualStyleBackColor = true;
            this.btn_Preeliminar.Click += new System.EventHandler(this.btn_Preeliminar_Click);
            // 
            // tpArticulos
            // 
            this.tpArticulos.Controls.Add(this.textBox2);
            this.tpArticulos.Controls.Add(this.textBox1);
            this.tpArticulos.Controls.Add(this.label13);
            this.tpArticulos.Controls.Add(this.label12);
            this.tpArticulos.Location = new System.Drawing.Point(4, 25);
            this.tpArticulos.Name = "tpArticulos";
            this.tpArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tpArticulos.Size = new System.Drawing.Size(587, 240);
            this.tpArticulos.TabIndex = 2;
            this.tpArticulos.Text = "Artículo";
            this.tpArticulos.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cve. Artículo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 24);
            this.textBox1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "SKU";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 24);
            this.textBox2.TabIndex = 7;
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.panel3);
            this.tpClientes.Location = new System.Drawing.Point(4, 25);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(587, 240);
            this.tpClientes.TabIndex = 1;
            this.tpClientes.Text = "Clientes";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_RFC);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.ucCanalDistribucionCliente1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.gbCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 234);
            this.panel3.TabIndex = 0;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.rdbSeleccionarClientes);
            this.gbCliente.Controls.Add(this.rdbTodosClientes);
            this.gbCliente.Location = new System.Drawing.Point(19, 13);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(414, 46);
            this.gbCliente.TabIndex = 13;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // rdbTodosClientes
            // 
            this.rdbTodosClientes.AutoSize = true;
            this.rdbTodosClientes.Location = new System.Drawing.Point(22, 20);
            this.rdbTodosClientes.Name = "rdbTodosClientes";
            this.rdbTodosClientes.Size = new System.Drawing.Size(114, 21);
            this.rdbTodosClientes.TabIndex = 12;
            this.rdbTodosClientes.TabStop = true;
            this.rdbTodosClientes.Text = "Todos Clientes";
            this.rdbTodosClientes.UseVisualStyleBackColor = true;
            // 
            // rdbSeleccionarClientes
            // 
            this.rdbSeleccionarClientes.AutoSize = true;
            this.rdbSeleccionarClientes.Location = new System.Drawing.Point(175, 19);
            this.rdbSeleccionarClientes.Name = "rdbSeleccionarClientes";
            this.rdbSeleccionarClientes.Size = new System.Drawing.Size(144, 21);
            this.rdbSeleccionarClientes.TabIndex = 13;
            this.rdbSeleccionarClientes.TabStop = true;
            this.rdbSeleccionarClientes.Text = "Seleccionar Clientes";
            this.rdbSeleccionarClientes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Canal de Distribución";
            // 
            // ucCanalDistribucionCliente1
            // 
            this.ucCanalDistribucionCliente1.Location = new System.Drawing.Point(156, 66);
            this.ucCanalDistribucionCliente1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCanalDistribucionCliente1.Name = "ucCanalDistribucionCliente1";
            this.ucCanalDistribucionCliente1.Size = new System.Drawing.Size(281, 33);
            this.ucCanalDistribucionCliente1.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "RFC";
            // 
            // txt_RFC
            // 
            this.txt_RFC.Location = new System.Drawing.Point(162, 104);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(100, 24);
            this.txt_RFC.TabIndex = 17;
            // 
            // tpFacturas
            // 
            this.tpFacturas.Controls.Add(this.panel1);
            this.tpFacturas.Controls.Add(this.label10);
            this.tpFacturas.Controls.Add(this.txt_Rango_Fina_Remision);
            this.tpFacturas.Controls.Add(this.txt_Rango_Inicial_Remision);
            this.tpFacturas.Controls.Add(this.txt_Pedido_Final_Remision);
            this.tpFacturas.Controls.Add(this.txt_Pedido_Inicial_Remision);
            this.tpFacturas.Controls.Add(this.txt_K_Factura);
            this.tpFacturas.Controls.Add(this.label9);
            this.tpFacturas.Controls.Add(this.label8);
            this.tpFacturas.Controls.Add(this.label7);
            this.tpFacturas.Controls.Add(this.label6);
            this.tpFacturas.Location = new System.Drawing.Point(4, 25);
            this.tpFacturas.Name = "tpFacturas";
            this.tpFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.tpFacturas.Size = new System.Drawing.Size(587, 240);
            this.tpFacturas.TabIndex = 0;
            this.tpFacturas.Text = "Facturas";
            this.tpFacturas.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cve. Factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pedido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Remisión";
            // 
            // txt_K_Factura
            // 
            this.txt_K_Factura.Location = new System.Drawing.Point(110, 8);
            this.txt_K_Factura.Name = "txt_K_Factura";
            this.txt_K_Factura.Size = new System.Drawing.Size(109, 24);
            this.txt_K_Factura.TabIndex = 3;
            this.txt_K_Factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_K_Factura_KeyPress);
            // 
            // txt_Pedido_Inicial_Remision
            // 
            this.txt_Pedido_Inicial_Remision.Location = new System.Drawing.Point(110, 40);
            this.txt_Pedido_Inicial_Remision.Name = "txt_Pedido_Inicial_Remision";
            this.txt_Pedido_Inicial_Remision.Size = new System.Drawing.Size(109, 24);
            this.txt_Pedido_Inicial_Remision.TabIndex = 4;
            // 
            // txt_Pedido_Final_Remision
            // 
            this.txt_Pedido_Final_Remision.Location = new System.Drawing.Point(255, 40);
            this.txt_Pedido_Final_Remision.Name = "txt_Pedido_Final_Remision";
            this.txt_Pedido_Final_Remision.Size = new System.Drawing.Size(109, 24);
            this.txt_Pedido_Final_Remision.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "al";
            // 
            // txt_Rango_Inicial_Remision
            // 
            this.txt_Rango_Inicial_Remision.Location = new System.Drawing.Point(110, 71);
            this.txt_Rango_Inicial_Remision.Name = "txt_Rango_Inicial_Remision";
            this.txt_Rango_Inicial_Remision.Size = new System.Drawing.Size(109, 24);
            this.txt_Rango_Inicial_Remision.TabIndex = 7;
            // 
            // txt_Rango_Fina_Remision
            // 
            this.txt_Rango_Fina_Remision.Location = new System.Drawing.Point(255, 71);
            this.txt_Rango_Fina_Remision.Name = "txt_Rango_Fina_Remision";
            this.txt_Rango_Fina_Remision.Size = new System.Drawing.Size(109, 24);
            this.txt_Rango_Fina_Remision.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "al";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFacturasDepositadas);
            this.panel1.Controls.Add(this.rdbTodasFacturas);
            this.panel1.Controls.Add(this.rdbFacturasPorDepositar);
            this.panel1.Location = new System.Drawing.Point(17, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 29);
            this.panel1.TabIndex = 13;
            // 
            // rdbFacturasPorDepositar
            // 
            this.rdbFacturasPorDepositar.AutoSize = true;
            this.rdbFacturasPorDepositar.Location = new System.Drawing.Point(258, 5);
            this.rdbFacturasPorDepositar.Name = "rdbFacturasPorDepositar";
            this.rdbFacturasPorDepositar.Size = new System.Drawing.Size(174, 21);
            this.rdbFacturasPorDepositar.TabIndex = 14;
            this.rdbFacturasPorDepositar.TabStop = true;
            this.rdbFacturasPorDepositar.Text = "Por Depositar/Por Pagar";
            this.rdbFacturasPorDepositar.UseVisualStyleBackColor = true;
            // 
            // rdbTodasFacturas
            // 
            this.rdbTodasFacturas.AutoSize = true;
            this.rdbTodasFacturas.Location = new System.Drawing.Point(13, 5);
            this.rdbTodasFacturas.Name = "rdbTodasFacturas";
            this.rdbTodasFacturas.Size = new System.Drawing.Size(63, 21);
            this.rdbTodasFacturas.TabIndex = 13;
            this.rdbTodasFacturas.TabStop = true;
            this.rdbTodasFacturas.Text = "Todas";
            this.rdbTodasFacturas.UseVisualStyleBackColor = true;
            // 
            // rdbFacturasDepositadas
            // 
            this.rdbFacturasDepositadas.AutoSize = true;
            this.rdbFacturasDepositadas.Location = new System.Drawing.Point(96, 5);
            this.rdbFacturasDepositadas.Name = "rdbFacturasDepositadas";
            this.rdbFacturasDepositadas.Size = new System.Drawing.Size(156, 21);
            this.rdbFacturasDepositadas.TabIndex = 15;
            this.rdbFacturasDepositadas.TabStop = true;
            this.rdbFacturasDepositadas.Text = "Depositadas/Pagadas\r\n";
            this.rdbFacturasDepositadas.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFacturas);
            this.tabControl1.Controls.Add(this.tpClientes);
            this.tabControl1.Controls.Add(this.tpArticulos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 269);
            this.tabControl1.TabIndex = 13;
            // 
            // pnl_Fechas
            // 
            this.pnl_Fechas.Controls.Add(this.lbl_Fechas);
            this.pnl_Fechas.Controls.Add(this.dtp_F_Inicial);
            this.pnl_Fechas.Controls.Add(this.label4);
            this.pnl_Fechas.Controls.Add(this.dtp_F_Final);
            this.pnl_Fechas.Controls.Add(this.label5);
            this.pnl_Fechas.Location = new System.Drawing.Point(4, 82);
            this.pnl_Fechas.Name = "pnl_Fechas";
            this.pnl_Fechas.Size = new System.Drawing.Size(472, 29);
            this.pnl_Fechas.TabIndex = 14;
            // 
            // Frm_Reportes_CXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 592);
            this.Controls.Add(this.pnlGeneral);
            this.Name = "Frm_Reportes_CXC";
            this.Text = "Estadística de Ventas";
            this.Controls.SetChildIndex(this.pnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlAbajo.ResumeLayout(false);
            this.pnlIzquierda.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbAlmacen.ResumeLayout(false);
            this.gbAlmacen.PerformLayout();
            this.pnlDerecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tpArticulos.ResumeLayout(false);
            this.tpArticulos.PerformLayout();
            this.tpClientes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.tpFacturas.ResumeLayout(false);
            this.tpFacturas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pnl_Fechas.ResumeLayout(false);
            this.pnl_Fechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlDerecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btn_Correo;
        private System.Windows.Forms.Button btn_Preeliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlAbajo;
        private System.Windows.Forms.Panel pnlIzquierda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAlmacenesSeleccionados;
        private System.Windows.Forms.GroupBox gbAlmacen;
        private System.Windows.Forms.RadioButton rdb_SeleccionarAlmacen;
        private System.Windows.Forms.RadioButton rdb_SeleccionarTodosAlmacenes;
        private System.Windows.Forms.DateTimePicker dtp_F_Final;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_F_Inicial;
        private System.Windows.Forms.Label lbl_Fechas;
        private System.Windows.Forms.ComboBox cmb_TipoReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFacturas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbFacturasDepositadas;
        private System.Windows.Forms.RadioButton rdbTodasFacturas;
        private System.Windows.Forms.RadioButton rdbFacturasPorDepositar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Rango_Fina_Remision;
        private System.Windows.Forms.TextBox txt_Rango_Inicial_Remision;
        private System.Windows.Forms.TextBox txt_Pedido_Final_Remision;
        private System.Windows.Forms.TextBox txt_Pedido_Inicial_Remision;
        private System.Windows.Forms.TextBox txt_K_Factura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.Label label14;
        private Controles.ucCanalDistribucionCliente ucCanalDistribucionCliente1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.RadioButton rdbSeleccionarClientes;
        private System.Windows.Forms.RadioButton rdbTodosClientes;
        private System.Windows.Forms.TabPage tpArticulos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnl_Fechas;
    }
}