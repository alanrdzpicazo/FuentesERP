﻿namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_DevolucionesCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DevolucionesCliente));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Movimiento_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblDetalleInventario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_K_Factura = new System.Windows.Forms.TextBox();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuentaCompletaCliente = new System.Windows.Forms.TextBox();
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.txtClaveCuentaOrigen = new System.Windows.Forms.TextBox();
            this.btnBuscaCuentaOrigen = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.panel3);
            this.pnlGeneral.Controls.Add(this.panel2);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(946, 411);
            this.pnlGeneral.TabIndex = 0;
            this.pnlGeneral.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.grdDatos);
            this.panel3.Controls.Add(this.LblDetalleInventario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 223);
            this.panel3.TabIndex = 5;
            this.panel3.TabStop = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.K_Movimiento_Inventario,
            this.Lote,
            this.F_Caducidad,
            this.Precio_Unitario,
            this.Cantidad,
            this.SubTotal,
            this.Porcentaje_Iva,
            this.IVA,
            this.Total_Detalle});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 22);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(942, 197);
            this.grdDatos.TabIndex = 6;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            this.grdDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 40;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "No. Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 120;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 220;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 130;
            // 
            // K_Movimiento_Inventario
            // 
            this.K_Movimiento_Inventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.K_Movimiento_Inventario.DataPropertyName = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.HeaderText = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Name = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.ReadOnly = true;
            this.K_Movimiento_Inventario.Visible = false;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Visible = false;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.F_Caducidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Caducidad.HeaderText = "Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            this.F_Caducidad.Visible = false;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio_Unitario.HeaderText = "P. Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Porcentaje_Iva
            // 
            this.Porcentaje_Iva.DataPropertyName = "Porcentaje_Iva";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Porcentaje_Iva.DefaultCellStyle = dataGridViewCellStyle5;
            this.Porcentaje_Iva.HeaderText = "Porcentaje IVA";
            this.Porcentaje_Iva.Name = "Porcentaje_Iva";
            this.Porcentaje_Iva.ReadOnly = true;
            this.Porcentaje_Iva.Width = 140;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle6;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // Total_Detalle
            // 
            this.Total_Detalle.DataPropertyName = "Total_Detalle";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Total_Detalle.DefaultCellStyle = dataGridViewCellStyle7;
            this.Total_Detalle.HeaderText = "Total";
            this.Total_Detalle.Name = "Total_Detalle";
            this.Total_Detalle.ReadOnly = true;
            this.Total_Detalle.Width = 140;
            // 
            // LblDetalleInventario
            // 
            this.LblDetalleInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.LblDetalleInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDetalleInventario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleInventario.ForeColor = System.Drawing.Color.White;
            this.LblDetalleInventario.Location = new System.Drawing.Point(0, 0);
            this.LblDetalleInventario.Name = "LblDetalleInventario";
            this.LblDetalleInventario.Size = new System.Drawing.Size(942, 22);
            this.LblDetalleInventario.TabIndex = 22;
            this.LblDetalleInventario.Text = "Detalle de la Factura";
            this.LblDetalleInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_K_Factura);
            this.panel2.Controls.Add(this.txt_Observaciones);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCuentaCompletaCliente);
            this.panel2.Controls.Add(this.txtCuentaOrigen);
            this.panel2.Controls.Add(this.txtClaveCuentaOrigen);
            this.panel2.Controls.Add(this.btnBuscaCuentaOrigen);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.txtClaveCliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 188);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // txt_K_Factura
            // 
            this.txt_K_Factura.Location = new System.Drawing.Point(129, 10);
            this.txt_K_Factura.Name = "txt_K_Factura";
            this.txt_K_Factura.Size = new System.Drawing.Size(103, 24);
            this.txt_K_Factura.TabIndex = 2;
            this.txt_K_Factura.TextChanged += new System.EventHandler(this.txt_K_Factura_TextChanged);
            this.txt_K_Factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_K_Factura_KeyPress);
            this.txt_K_Factura.Leave += new System.EventHandler(this.txt_K_Factura_Leave);
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Observaciones.Location = new System.Drawing.Point(22, 119);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(562, 44);
            this.txt_Observaciones.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 101;
            this.label9.Text = "Observaciones";
            // 
            // txtCuentaCompletaCliente
            // 
            this.txtCuentaCompletaCliente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCompletaCliente.Location = new System.Drawing.Point(180, 71);
            this.txtCuentaCompletaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuentaCompletaCliente.Name = "txtCuentaCompletaCliente";
            this.txtCuentaCompletaCliente.ReadOnly = true;
            this.txtCuentaCompletaCliente.Size = new System.Drawing.Size(270, 24);
            this.txtCuentaCompletaCliente.TabIndex = 100;
            this.txtCuentaCompletaCliente.TabStop = false;
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaOrigen.Location = new System.Drawing.Point(183, 71);
            this.txtCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.ReadOnly = true;
            this.txtCuentaOrigen.Size = new System.Drawing.Size(267, 24);
            this.txtCuentaOrigen.TabIndex = 98;
            this.txtCuentaOrigen.TabStop = false;
            // 
            // txtClaveCuentaOrigen
            // 
            this.txtClaveCuentaOrigen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCuentaOrigen.Location = new System.Drawing.Point(127, 71);
            this.txtClaveCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClaveCuentaOrigen.MaxLength = 5;
            this.txtClaveCuentaOrigen.Name = "txtClaveCuentaOrigen";
            this.txtClaveCuentaOrigen.ReadOnly = true;
            this.txtClaveCuentaOrigen.Size = new System.Drawing.Size(50, 24);
            this.txtClaveCuentaOrigen.TabIndex = 97;
            this.txtClaveCuentaOrigen.TabStop = false;
            this.txtClaveCuentaOrigen.Tag = "ENTERO";
            // 
            // btnBuscaCuentaOrigen
            // 
            this.btnBuscaCuentaOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCuentaOrigen.Image")));
            this.btnBuscaCuentaOrigen.Location = new System.Drawing.Point(451, 70);
            this.btnBuscaCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaCuentaOrigen.Name = "btnBuscaCuentaOrigen";
            this.btnBuscaCuentaOrigen.Size = new System.Drawing.Size(28, 26);
            this.btnBuscaCuentaOrigen.TabIndex = 3;
            this.btnBuscaCuentaOrigen.UseVisualStyleBackColor = true;
            this.btnBuscaCuentaOrigen.Click += new System.EventHandler(this.btnBuscaCuentaOrigen_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Blue;
            this.label29.Location = new System.Drawing.Point(19, 75);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 17);
            this.label29.TabIndex = 99;
            this.label29.Text = "Cuenta Bancaria";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(180, 40);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(354, 24);
            this.txtCliente.TabIndex = 96;
            this.txtCliente.TabStop = false;
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.Location = new System.Drawing.Point(127, 40);
            this.txtClaveCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.ReadOnly = true;
            this.txtClaveCliente.Size = new System.Drawing.Size(50, 24);
            this.txtClaveCliente.TabIndex = 95;
            this.txtClaveCliente.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 94;
            this.label10.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_Total);
            this.groupBox1.Controls.Add(this.lbl_SubTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_IVA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(615, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 107);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTALES";
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lbl_Total.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(99, 73);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(169, 24);
            this.lbl_Total.TabIndex = 141;
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lbl_SubTotal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_SubTotal.ForeColor = System.Drawing.Color.White;
            this.lbl_SubTotal.Location = new System.Drawing.Point(99, 18);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(169, 24);
            this.lbl_SubTotal.TabIndex = 140;
            this.lbl_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(49, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 90;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(57, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 89;
            this.label7.Text = "IVA";
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lbl_IVA.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_IVA.ForeColor = System.Drawing.Color.White;
            this.lbl_IVA.Location = new System.Drawing.Point(99, 45);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(169, 24);
            this.lbl_IVA.TabIndex = 138;
            this.lbl_IVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "SubTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Factura";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "quitar.ico");
            this.imageList1.Images.SetKeyName(2, "if_icon-111-search_314689.png");
            this.imageList1.Images.SetKeyName(3, "btnGuardar.Image.png");
            this.imageList1.Images.SetKeyName(4, "BtnCancelar.Image.png");
            this.imageList1.Images.SetKeyName(5, "btnProceso4.Image.png");
            this.imageList1.Images.SetKeyName(6, "btnNuevo.Image.png");
            this.imageList1.Images.SetKeyName(7, "btnModificar.Image.png");
            this.imageList1.Images.SetKeyName(8, "btnBorrar.Image.png");
            this.imageList1.Images.SetKeyName(9, "btnAfectar.Image.png");
            // 
            // Frm_DevolucionesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 488);
            this.Controls.Add(this.pnlGeneral);
            this.Name = "Frm_DevolucionesCliente";
            this.Text = "DEVOLUCIONES CLIENTE";
            this.Load += new System.EventHandler(this.Frm_DevolucionesCliente_Load);
            this.Controls.SetChildIndex(this.pnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDetalleInventario;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCuentaCompletaCliente;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
        private System.Windows.Forms.TextBox txtClaveCuentaOrigen;
        private System.Windows.Forms.Button btnBuscaCuentaOrigen;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.TextBox txt_K_Factura;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Movimiento_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Detalle;
    }
}