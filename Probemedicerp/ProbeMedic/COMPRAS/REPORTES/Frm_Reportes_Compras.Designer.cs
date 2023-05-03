﻿namespace ProbeMedic.COMPRAS.REPORTES
{
    partial class Frm_Reportes_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reportes_Compras));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlAbajo = new System.Windows.Forms.Panel();
            this.PnlIzquierda = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpArticulos = new System.Windows.Forms.TabPage();
            this.TxtSKU = new System.Windows.Forms.TextBox();
            this.TxtK_Articulo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpProveedor = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLaboratoriosSeleccionados = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbSeleccionarLaboratorio = new System.Windows.Forms.RadioButton();
            this.RdbSeleccionarTodos = new System.Windows.Forms.RadioButton();
            this.LblAlmacenesSeleccionados = new System.Windows.Forms.Label();
            this.GbxAlmacen = new System.Windows.Forms.GroupBox();
            this.RdbSeleccionarAlmacen = new System.Windows.Forms.RadioButton();
            this.RdbSelecionarTodos = new System.Windows.Forms.RadioButton();
            this.CbxTipoReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlDerecha = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnCorreo = new System.Windows.Forms.Button();
            this.BtnPreeliminar = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.GbxAlmacen.SuspendLayout();
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
            this.pnlGeneral.TabIndex = 2;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.6699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.3301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 515);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // PnlAbajo
            // 
            this.PnlAbajo.Controls.Add(this.PnlIzquierda);
            this.PnlAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAbajo.Location = new System.Drawing.Point(3, 299);
            this.PnlAbajo.Name = "PnlAbajo";
            this.PnlAbajo.Size = new System.Drawing.Size(595, 213);
            this.PnlAbajo.TabIndex = 5;
            // 
            // PnlIzquierda
            // 
            this.PnlIzquierda.Controls.Add(this.tabControl1);
            this.PnlIzquierda.Controls.Add(this.lblTitulo);
            this.PnlIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlIzquierda.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierda.Name = "PnlIzquierda";
            this.PnlIzquierda.Size = new System.Drawing.Size(595, 213);
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
            this.tabControl1.Size = new System.Drawing.Size(595, 193);
            this.tabControl1.TabIndex = 13;
            // 
            // tpArticulos
            // 
            this.tpArticulos.Controls.Add(this.TxtSKU);
            this.tpArticulos.Controls.Add(this.TxtK_Articulo);
            this.tpArticulos.Controls.Add(this.label13);
            this.tpArticulos.Controls.Add(this.label12);
            this.tpArticulos.Location = new System.Drawing.Point(4, 25);
            this.tpArticulos.Name = "tpArticulos";
            this.tpArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tpArticulos.Size = new System.Drawing.Size(587, 164);
            this.tpArticulos.TabIndex = 2;
            this.tpArticulos.Text = "Artículo";
            this.tpArticulos.UseVisualStyleBackColor = true;
            // 
            // TxtSKU
            // 
            this.TxtSKU.Location = new System.Drawing.Point(104, 44);
            this.TxtSKU.Name = "TxtSKU";
            this.TxtSKU.Size = new System.Drawing.Size(215, 24);
            this.TxtSKU.TabIndex = 7;
            // 
            // TxtK_Articulo
            // 
            this.TxtK_Articulo.Location = new System.Drawing.Point(104, 11);
            this.TxtK_Articulo.Name = "TxtK_Articulo";
            this.TxtK_Articulo.Size = new System.Drawing.Size(76, 24);
            this.TxtK_Articulo.TabIndex = 5;
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
            this.tpProveedor.Size = new System.Drawing.Size(587, 164);
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
            this.panel2.Controls.Add(this.LblLaboratoriosSeleccionados);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.LblAlmacenesSeleccionados);
            this.panel2.Controls.Add(this.GbxAlmacen);
            this.panel2.Controls.Add(this.CbxTipoReporte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CbxReporte);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 290);
            this.panel2.TabIndex = 3;
            this.panel2.TabStop = true;
            // 
            // LblLaboratoriosSeleccionados
            // 
            this.LblLaboratoriosSeleccionados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaboratoriosSeleccionados.Location = new System.Drawing.Point(114, 232);
            this.LblLaboratoriosSeleccionados.Name = "LblLaboratoriosSeleccionados";
            this.LblLaboratoriosSeleccionados.Size = new System.Drawing.Size(416, 45);
            this.LblLaboratoriosSeleccionados.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbSeleccionarLaboratorio);
            this.groupBox1.Controls.Add(this.RdbSeleccionarTodos);
            this.groupBox1.Location = new System.Drawing.Point(116, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 46);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laboratorios";
            // 
            // RdbSeleccionarLaboratorio
            // 
            this.RdbSeleccionarLaboratorio.AutoSize = true;
            this.RdbSeleccionarLaboratorio.Location = new System.Drawing.Point(175, 19);
            this.RdbSeleccionarLaboratorio.Name = "RdbSeleccionarLaboratorio";
            this.RdbSeleccionarLaboratorio.Size = new System.Drawing.Size(168, 21);
            this.RdbSeleccionarLaboratorio.TabIndex = 13;
            this.RdbSeleccionarLaboratorio.TabStop = true;
            this.RdbSeleccionarLaboratorio.Text = "Seleccionar Laboratorio";
            this.RdbSeleccionarLaboratorio.UseVisualStyleBackColor = true;
            this.RdbSeleccionarLaboratorio.CheckedChanged += new System.EventHandler(this.RdbSeleccionarLaboratorio_CheckedChanged);
            // 
            // RdbSeleccionarTodos
            // 
            this.RdbSeleccionarTodos.AutoSize = true;
            this.RdbSeleccionarTodos.Location = new System.Drawing.Point(22, 20);
            this.RdbSeleccionarTodos.Name = "RdbSeleccionarTodos";
            this.RdbSeleccionarTodos.Size = new System.Drawing.Size(144, 21);
            this.RdbSeleccionarTodos.TabIndex = 12;
            this.RdbSeleccionarTodos.TabStop = true;
            this.RdbSeleccionarTodos.Text = "Todos Laboratorios";
            this.RdbSeleccionarTodos.UseVisualStyleBackColor = true;
            // 
            // LblAlmacenesSeleccionados
            // 
            this.LblAlmacenesSeleccionados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlmacenesSeleccionados.Location = new System.Drawing.Point(114, 133);
            this.LblAlmacenesSeleccionados.Name = "LblAlmacenesSeleccionados";
            this.LblAlmacenesSeleccionados.Size = new System.Drawing.Size(416, 45);
            this.LblAlmacenesSeleccionados.TabIndex = 13;
            // 
            // GbxAlmacen
            // 
            this.GbxAlmacen.Controls.Add(this.RdbSeleccionarAlmacen);
            this.GbxAlmacen.Controls.Add(this.RdbSelecionarTodos);
            this.GbxAlmacen.Location = new System.Drawing.Point(116, 85);
            this.GbxAlmacen.Name = "GbxAlmacen";
            this.GbxAlmacen.Size = new System.Drawing.Size(414, 46);
            this.GbxAlmacen.TabIndex = 12;
            this.GbxAlmacen.TabStop = false;
            this.GbxAlmacen.Text = "Almacén";
            // 
            // RdbSeleccionarAlmacen
            // 
            this.RdbSeleccionarAlmacen.AutoSize = true;
            this.RdbSeleccionarAlmacen.Location = new System.Drawing.Point(175, 19);
            this.RdbSeleccionarAlmacen.Name = "RdbSeleccionarAlmacen";
            this.RdbSeleccionarAlmacen.Size = new System.Drawing.Size(149, 21);
            this.RdbSeleccionarAlmacen.TabIndex = 13;
            this.RdbSeleccionarAlmacen.TabStop = true;
            this.RdbSeleccionarAlmacen.Text = "Seleccionar Almacén";
            this.RdbSeleccionarAlmacen.UseVisualStyleBackColor = true;
            this.RdbSeleccionarAlmacen.CheckedChanged += new System.EventHandler(this.RdbSeleccionarAlmacen_CheckedChanged);
            // 
            // RdbSelecionarTodos
            // 
            this.RdbSelecionarTodos.AutoSize = true;
            this.RdbSelecionarTodos.Location = new System.Drawing.Point(22, 20);
            this.RdbSelecionarTodos.Name = "RdbSelecionarTodos";
            this.RdbSelecionarTodos.Size = new System.Drawing.Size(132, 21);
            this.RdbSelecionarTodos.TabIndex = 12;
            this.RdbSelecionarTodos.TabStop = true;
            this.RdbSelecionarTodos.Text = "Todos Almacenes";
            this.RdbSelecionarTodos.UseVisualStyleBackColor = true;
            // 
            // CbxTipoReporte
            // 
            this.CbxTipoReporte.Enabled = false;
            this.CbxTipoReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxTipoReporte.FormattingEnabled = true;
            this.CbxTipoReporte.Location = new System.Drawing.Point(117, 14);
            this.CbxTipoReporte.Name = "CbxTipoReporte";
            this.CbxTipoReporte.Size = new System.Drawing.Size(223, 27);
            this.CbxTipoReporte.TabIndex = 4;
            this.CbxTipoReporte.SelectedValueChanged += new System.EventHandler(this.CbxTipoReporte_SelectedValueChanged);
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
            // CbxReporte
            // 
            this.CbxReporte.FormattingEnabled = true;
            this.CbxReporte.Location = new System.Drawing.Point(117, 53);
            this.CbxReporte.Name = "CbxReporte";
            this.CbxReporte.Size = new System.Drawing.Size(475, 24);
            this.CbxReporte.TabIndex = 2;
            this.CbxReporte.SelectedValueChanged += new System.EventHandler(this.CbxReporte_SelectedValueChanged);
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
            // PnlDerecha
            // 
            this.PnlDerecha.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlDerecha.Controls.Add(this.BtnSalir);
            this.PnlDerecha.Controls.Add(this.BtnExcel);
            this.PnlDerecha.Controls.Add(this.BtnCorreo);
            this.PnlDerecha.Controls.Add(this.BtnPreeliminar);
            this.PnlDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDerecha.Location = new System.Drawing.Point(601, 0);
            this.PnlDerecha.Name = "PnlDerecha";
            this.PnlDerecha.Size = new System.Drawing.Size(117, 515);
            this.PnlDerecha.TabIndex = 6;
            this.PnlDerecha.TabStop = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Location = new System.Drawing.Point(7, 253);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(102, 68);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Image")));
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcel.Location = new System.Drawing.Point(7, 158);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(102, 68);
            this.BtnExcel.TabIndex = 9;
            this.BtnExcel.Text = "Excel";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnCorreo
            // 
            this.BtnCorreo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorreo.Image = global::ProbeMedic.Properties.Resources.sendbymail_enviar_1541;
            this.BtnCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCorreo.Location = new System.Drawing.Point(12, 88);
            this.BtnCorreo.Name = "BtnCorreo";
            this.BtnCorreo.Size = new System.Drawing.Size(102, 68);
            this.BtnCorreo.TabIndex = 8;
            this.BtnCorreo.Text = "Enviar a\r\nCorreo";
            this.BtnCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorreo.UseVisualStyleBackColor = true;
            this.BtnCorreo.Click += new System.EventHandler(this.BtnCorreo_Click);
            // 
            // BtnPreeliminar
            // 
            this.BtnPreeliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreeliminar.Image = global::ProbeMedic.Properties.Resources.btnBuscaPaciente_Image;
            this.BtnPreeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPreeliminar.Location = new System.Drawing.Point(7, 60);
            this.BtnPreeliminar.Name = "BtnPreeliminar";
            this.BtnPreeliminar.Size = new System.Drawing.Size(102, 68);
            this.BtnPreeliminar.TabIndex = 7;
            this.BtnPreeliminar.Text = "Preeliminar";
            this.BtnPreeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPreeliminar.UseVisualStyleBackColor = true;
            this.BtnPreeliminar.Visible = false;
            this.BtnPreeliminar.Click += new System.EventHandler(this.BtnPreeliminar_Click);
            // 
            // Frm_Reportes_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 592);
            this.Controls.Add(this.pnlGeneral);
            this.Name = "Frm_Reportes_Compras";
            this.Text = "Estadistica de Inventarios";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbxAlmacen.ResumeLayout(false);
            this.GbxAlmacen.PerformLayout();
            this.PnlDerecha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlAbajo;
        private System.Windows.Forms.Panel PnlIzquierda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAlmacenesSeleccionados;
        private System.Windows.Forms.GroupBox GbxAlmacen;
        private System.Windows.Forms.RadioButton RdbSeleccionarAlmacen;
        private System.Windows.Forms.RadioButton RdbSelecionarTodos;
        private System.Windows.Forms.ComboBox CbxTipoReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlDerecha;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button BtnCorreo;
        private System.Windows.Forms.Button BtnPreeliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpArticulos;
        private System.Windows.Forms.TextBox TxtSKU;
        private System.Windows.Forms.TextBox TxtK_Articulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Button btnBuscaProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label LblLaboratoriosSeleccionados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbSeleccionarLaboratorio;
        private System.Windows.Forms.RadioButton RdbSeleccionarTodos;
    }
}