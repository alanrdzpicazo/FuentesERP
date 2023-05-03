namespace ProbeMedic.INVENTARIOS.REPORTES
{
    partial class Frm_Reportes_Inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reportes_Inventarios));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlAbajo = new System.Windows.Forms.Panel();
            this.PnlIzquierda = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpArticulos = new System.Windows.Forms.TabPage();
            this.txt_SKU = new System.Windows.Forms.TextBox();
            this.txt_K_Articulo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpProveedor = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.lblAlmacenTitulo = new System.Windows.Forms.Label();
            this.LblLaboratoriosSeleccionados = new System.Windows.Forms.Label();
            this.gbLaboratorios = new System.Windows.Forms.GroupBox();
            this.rdbSeleccionarLab = new System.Windows.Forms.RadioButton();
            this.rdbSeleccionarTodosLabs = new System.Windows.Forms.RadioButton();
            this.LblAlmacenesSeleccionados = new System.Windows.Forms.Label();
            this.gbAlmacen = new System.Windows.Forms.GroupBox();
            this.rdbSeleccionarAlmacen = new System.Windows.Forms.RadioButton();
            this.rdbSeleccionarTodos = new System.Windows.Forms.RadioButton();
            this.cbxTipoReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlDerecha = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnPreeliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlAbajo.SuspendLayout();
            this.PnlIzquierda.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpArticulos.SuspendLayout();
            this.tpProveedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbLaboratorios.SuspendLayout();
            this.gbAlmacen.SuspendLayout();
            this.PnlDerecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.tableLayoutPanel1);
            this.pnlGeneral.Controls.Add(this.PnlDerecha);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(718, 515);
            this.pnlGeneral.TabIndex = 3;
            this.pnlGeneral.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PnlAbajo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.30097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.69903F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 515);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // PnlAbajo
            // 
            this.PnlAbajo.Controls.Add(this.PnlIzquierda);
            this.PnlAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAbajo.Location = new System.Drawing.Point(3, 328);
            this.PnlAbajo.Name = "PnlAbajo";
            this.PnlAbajo.Size = new System.Drawing.Size(595, 184);
            this.PnlAbajo.TabIndex = 5;
            // 
            // PnlIzquierda
            // 
            this.PnlIzquierda.Controls.Add(this.tabControl1);
            this.PnlIzquierda.Controls.Add(this.lblTitulo);
            this.PnlIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlIzquierda.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierda.Name = "PnlIzquierda";
            this.PnlIzquierda.Size = new System.Drawing.Size(595, 184);
            this.PnlIzquierda.TabIndex = 4;
            this.PnlIzquierda.TabStop = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpArticulos);
            this.tabControl1.Controls.Add(this.tpProveedor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 164);
            this.tabControl1.TabIndex = 13;
            // 
            // tpArticulos
            // 
            this.tpArticulos.Controls.Add(this.txt_SKU);
            this.tpArticulos.Controls.Add(this.txt_K_Articulo);
            this.tpArticulos.Controls.Add(this.label13);
            this.tpArticulos.Controls.Add(this.label12);
            this.tpArticulos.Location = new System.Drawing.Point(4, 25);
            this.tpArticulos.Name = "tpArticulos";
            this.tpArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tpArticulos.Size = new System.Drawing.Size(587, 135);
            this.tpArticulos.TabIndex = 2;
            this.tpArticulos.Text = "Artículo";
            this.tpArticulos.UseVisualStyleBackColor = true;
            // 
            // txt_SKU
            // 
            this.txt_SKU.Location = new System.Drawing.Point(104, 44);
            this.txt_SKU.Name = "txt_SKU";
            this.txt_SKU.Size = new System.Drawing.Size(215, 24);
            this.txt_SKU.TabIndex = 7;
            // 
            // txt_K_Articulo
            // 
            this.txt_K_Articulo.Location = new System.Drawing.Point(104, 11);
            this.txt_K_Articulo.Name = "txt_K_Articulo";
            this.txt_K_Articulo.Size = new System.Drawing.Size(76, 24);
            this.txt_K_Articulo.TabIndex = 5;
            this.txt_K_Articulo.TextChanged += new System.EventHandler(this.TxtK_Articulo_TextChanged);
            this.txt_K_Articulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtK_Articulo_KeyPress);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cve. Artículo";
            // 
            // tpProveedor
            // 
            this.tpProveedor.Controls.Add(this.label3);
            this.tpProveedor.Controls.Add(this.txtClaveProveedor);
            this.tpProveedor.Controls.Add(this.btnBuscaProveedor);
            this.tpProveedor.Controls.Add(this.txtProveedor);
            this.tpProveedor.Location = new System.Drawing.Point(4, 25);
            this.tpProveedor.Name = "tpProveedor";
            this.tpProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpProveedor.Size = new System.Drawing.Size(587, 135);
            this.tpProveedor.TabIndex = 3;
            this.tpProveedor.Text = "Proveedor";
            this.tpProveedor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(83, 11);
            this.txtClaveProveedor.MaxLength = 5;
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(50, 24);
            this.txtClaveProveedor.TabIndex = 22;
            this.txtClaveProveedor.TabStop = false;
            this.txtClaveProveedor.Tag = "ENTERO";
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProveedor.Image")));
            this.btnBuscaProveedor.Location = new System.Drawing.Point(417, 11);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(28, 24);
            this.btnBuscaProveedor.TabIndex = 23;
            this.btnBuscaProveedor.Tag = "";
            this.btnBuscaProveedor.UseVisualStyleBackColor = true;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(134, 11);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(283, 24);
            this.txtProveedor.TabIndex = 24;
            this.txtProveedor.TabStop = false;
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
            this.panel2.Controls.Add(this.cbxAlmacen);
            this.panel2.Controls.Add(this.lblAlmacenTitulo);
            this.panel2.Controls.Add(this.LblLaboratoriosSeleccionados);
            this.panel2.Controls.Add(this.gbLaboratorios);
            this.panel2.Controls.Add(this.LblAlmacenesSeleccionados);
            this.panel2.Controls.Add(this.gbAlmacen);
            this.panel2.Controls.Add(this.cbxTipoReporte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxReporte);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 319);
            this.panel2.TabIndex = 3;
            this.panel2.TabStop = true;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(117, 288);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(263, 24);
            this.cbxAlmacen.TabIndex = 48;
            // 
            // lblAlmacenTitulo
            // 
            this.lblAlmacenTitulo.AutoSize = true;
            this.lblAlmacenTitulo.Location = new System.Drawing.Point(51, 290);
            this.lblAlmacenTitulo.Name = "lblAlmacenTitulo";
            this.lblAlmacenTitulo.Size = new System.Drawing.Size(59, 17);
            this.lblAlmacenTitulo.TabIndex = 47;
            this.lblAlmacenTitulo.Text = "Almacén";
            // 
            // LblLaboratoriosSeleccionados
            // 
            this.LblLaboratoriosSeleccionados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaboratoriosSeleccionados.Location = new System.Drawing.Point(114, 232);
            this.LblLaboratoriosSeleccionados.Name = "LblLaboratoriosSeleccionados";
            this.LblLaboratoriosSeleccionados.Size = new System.Drawing.Size(416, 45);
            this.LblLaboratoriosSeleccionados.TabIndex = 15;
            this.LblLaboratoriosSeleccionados.Visible = false;
            // 
            // gbLaboratorios
            // 
            this.gbLaboratorios.Controls.Add(this.rdbSeleccionarLab);
            this.gbLaboratorios.Controls.Add(this.rdbSeleccionarTodosLabs);
            this.gbLaboratorios.Location = new System.Drawing.Point(116, 184);
            this.gbLaboratorios.Name = "gbLaboratorios";
            this.gbLaboratorios.Size = new System.Drawing.Size(414, 46);
            this.gbLaboratorios.TabIndex = 14;
            this.gbLaboratorios.TabStop = false;
            this.gbLaboratorios.Text = "LABORATORIOS";
            this.gbLaboratorios.Visible = false;
            // 
            // rdbSeleccionarLab
            // 
            this.rdbSeleccionarLab.AutoSize = true;
            this.rdbSeleccionarLab.Location = new System.Drawing.Point(175, 19);
            this.rdbSeleccionarLab.Name = "rdbSeleccionarLab";
            this.rdbSeleccionarLab.Size = new System.Drawing.Size(168, 21);
            this.rdbSeleccionarLab.TabIndex = 13;
            this.rdbSeleccionarLab.TabStop = true;
            this.rdbSeleccionarLab.Text = "Seleccionar Laboratorio";
            this.rdbSeleccionarLab.UseVisualStyleBackColor = true;
            this.rdbSeleccionarLab.CheckedChanged += new System.EventHandler(this.rdbSeleccionarLaboratorio_CheckedChanged);
            // 
            // rdbSeleccionarTodosLabs
            // 
            this.rdbSeleccionarTodosLabs.AutoSize = true;
            this.rdbSeleccionarTodosLabs.Location = new System.Drawing.Point(22, 20);
            this.rdbSeleccionarTodosLabs.Name = "rdbSeleccionarTodosLabs";
            this.rdbSeleccionarTodosLabs.Size = new System.Drawing.Size(144, 21);
            this.rdbSeleccionarTodosLabs.TabIndex = 12;
            this.rdbSeleccionarTodosLabs.TabStop = true;
            this.rdbSeleccionarTodosLabs.Text = "Todos Laboratorios";
            this.rdbSeleccionarTodosLabs.UseVisualStyleBackColor = true;
            // 
            // LblAlmacenesSeleccionados
            // 
            this.LblAlmacenesSeleccionados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlmacenesSeleccionados.Location = new System.Drawing.Point(114, 133);
            this.LblAlmacenesSeleccionados.Name = "LblAlmacenesSeleccionados";
            this.LblAlmacenesSeleccionados.Size = new System.Drawing.Size(416, 45);
            this.LblAlmacenesSeleccionados.TabIndex = 13;
            // 
            // gbAlmacen
            // 
            this.gbAlmacen.Controls.Add(this.rdbSeleccionarAlmacen);
            this.gbAlmacen.Controls.Add(this.rdbSeleccionarTodos);
            this.gbAlmacen.Location = new System.Drawing.Point(116, 85);
            this.gbAlmacen.Name = "gbAlmacen";
            this.gbAlmacen.Size = new System.Drawing.Size(414, 46);
            this.gbAlmacen.TabIndex = 12;
            this.gbAlmacen.TabStop = false;
            this.gbAlmacen.Text = "ALMACÉN";
            // 
            // rdbSeleccionarAlmacen
            // 
            this.rdbSeleccionarAlmacen.AutoSize = true;
            this.rdbSeleccionarAlmacen.Location = new System.Drawing.Point(175, 19);
            this.rdbSeleccionarAlmacen.Name = "rdbSeleccionarAlmacen";
            this.rdbSeleccionarAlmacen.Size = new System.Drawing.Size(149, 21);
            this.rdbSeleccionarAlmacen.TabIndex = 13;
            this.rdbSeleccionarAlmacen.TabStop = true;
            this.rdbSeleccionarAlmacen.Text = "Seleccionar Almacén";
            this.rdbSeleccionarAlmacen.UseVisualStyleBackColor = true;
            this.rdbSeleccionarAlmacen.CheckedChanged += new System.EventHandler(this.rdbSeleccionarAlmacen_CheckedChanged);
            // 
            // rdbSeleccionarTodos
            // 
            this.rdbSeleccionarTodos.AutoSize = true;
            this.rdbSeleccionarTodos.Location = new System.Drawing.Point(22, 20);
            this.rdbSeleccionarTodos.Name = "rdbSeleccionarTodos";
            this.rdbSeleccionarTodos.Size = new System.Drawing.Size(132, 21);
            this.rdbSeleccionarTodos.TabIndex = 12;
            this.rdbSeleccionarTodos.TabStop = true;
            this.rdbSeleccionarTodos.Text = "Todos Almacenes";
            this.rdbSeleccionarTodos.UseVisualStyleBackColor = true;
            // 
            // cbxTipoReporte
            // 
            this.cbxTipoReporte.Enabled = false;
            this.cbxTipoReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTipoReporte.FormattingEnabled = true;
            this.cbxTipoReporte.Location = new System.Drawing.Point(117, 14);
            this.cbxTipoReporte.Name = "cbxTipoReporte";
            this.cbxTipoReporte.Size = new System.Drawing.Size(223, 27);
            this.cbxTipoReporte.TabIndex = 4;
            this.cbxTipoReporte.SelectedValueChanged += new System.EventHandler(this.cbxTipoReporte_SelectedValueChanged);
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
            // cbxReporte
            // 
            this.cbxReporte.FormattingEnabled = true;
            this.cbxReporte.Location = new System.Drawing.Point(117, 53);
            this.cbxReporte.Name = "cbxReporte";
            this.cbxReporte.Size = new System.Drawing.Size(475, 24);
            this.cbxReporte.TabIndex = 2;
            this.cbxReporte.SelectedValueChanged += new System.EventHandler(this.cbxReporte_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte";
            // 
            // PnlDerecha
            // 
            this.PnlDerecha.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlDerecha.Controls.Add(this.btnSalir);
            this.PnlDerecha.Controls.Add(this.btnExcel);
            this.PnlDerecha.Controls.Add(this.btnCorreo);
            this.PnlDerecha.Controls.Add(this.btnPreeliminar);
            this.PnlDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDerecha.Location = new System.Drawing.Point(601, 0);
            this.PnlDerecha.Name = "PnlDerecha";
            this.PnlDerecha.Size = new System.Drawing.Size(117, 515);
            this.PnlDerecha.TabIndex = 6;
            this.PnlDerecha.TabStop = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(7, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 68);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(7, 256);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(102, 68);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreo.Image = global::ProbeMedic.Properties.Resources.sendbymail_enviar_1541;
            this.btnCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCorreo.Location = new System.Drawing.Point(7, 160);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(102, 68);
            this.btnCorreo.TabIndex = 8;
            this.btnCorreo.Text = "Enviar a\r\nCorreo";
            this.btnCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.BtnCorreo_Click);
            // 
            // btnPreeliminar
            // 
            this.btnPreeliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreeliminar.Image = global::ProbeMedic.Properties.Resources.btnBuscaPaciente_Image;
            this.btnPreeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreeliminar.Location = new System.Drawing.Point(7, 68);
            this.btnPreeliminar.Name = "btnPreeliminar";
            this.btnPreeliminar.Size = new System.Drawing.Size(102, 68);
            this.btnPreeliminar.TabIndex = 7;
            this.btnPreeliminar.Text = "Preeliminar";
            this.btnPreeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreeliminar.UseVisualStyleBackColor = true;
            this.btnPreeliminar.Click += new System.EventHandler(this.BtnPreeliminar_Click);
            // 
            // Frm_Reportes_Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 592);
            this.Controls.Add(this.pnlGeneral);
            this.Name = "Frm_Reportes_Inventarios";
            this.Text = "ESTADÍSTICA DE ALMACÉN";
            this.Controls.SetChildIndex(this.pnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlAbajo.ResumeLayout(false);
            this.PnlIzquierda.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpArticulos.ResumeLayout(false);
            this.tpArticulos.PerformLayout();
            this.tpProveedor.ResumeLayout(false);
            this.tpProveedor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbLaboratorios.ResumeLayout(false);
            this.gbLaboratorios.PerformLayout();
            this.gbAlmacen.ResumeLayout(false);
            this.gbAlmacen.PerformLayout();
            this.PnlDerecha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlAbajo;
        private System.Windows.Forms.Panel PnlIzquierda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpArticulos;
        private System.Windows.Forms.TextBox txt_SKU;
        private System.Windows.Forms.TextBox txt_K_Articulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Button btnBuscaProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblLaboratoriosSeleccionados;
        private System.Windows.Forms.GroupBox gbLaboratorios;
        private System.Windows.Forms.RadioButton rdbSeleccionarLab;
        private System.Windows.Forms.RadioButton rdbSeleccionarTodosLabs;
        private System.Windows.Forms.Label LblAlmacenesSeleccionados;
        private System.Windows.Forms.GroupBox gbAlmacen;
        private System.Windows.Forms.RadioButton rdbSeleccionarAlmacen;
        private System.Windows.Forms.RadioButton rdbSeleccionarTodos;
        private System.Windows.Forms.ComboBox cbxTipoReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlDerecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnPreeliminar;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label lblAlmacenTitulo;
    }
}