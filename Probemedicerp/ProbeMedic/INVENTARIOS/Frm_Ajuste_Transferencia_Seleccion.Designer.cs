﻿namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Ajuste_Transferencia_Seleccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ajuste_Transferencia_Seleccion));
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Nota_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrada_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Transferir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Detalle_Nota_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Movimiento_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxMostrarTodo = new System.Windows.Forms.CheckBox();
            this.txtRecepcion = new ProbeMedic.Controles.ucInteger32();
            this.Txt_Sku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiaArticulo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaProducto = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sdds = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sdds.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.D_Articulo,
            this.K_Nota_Recepcion,
            this.K_Proveedor,
            this.D_Proveedor,
            this.D_Tipo_Movimiento,
            this.Cantidad_Articulo,
            this.Cantidad_Movimiento,
            this.No_Lote,
            this.F_Caducidad,
            this.Precio_Unitario,
            this.F_Entrada_Lote,
            this.Cantidad_Disponible,
            this.F_Movimiento,
            this.Cantidad_Transferir,
            this.K_Detalle_Nota_Recepcion,
            this.K_Articulo1,
            this.K_Oficina_Movimiento,
            this.D_Oficina,
            this.K_Tipo_Movimiento,
            this.K_Movimiento_Inventario,
            this.F_Recepcion,
            this.Tipo_Documento,
            this.No_Documento});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 193);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDetalle.Size = new System.Drawing.Size(1220, 273);
            this.grdDetalle.TabIndex = 1;
            this.grdDetalle.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDetalle_CellValidating);
            this.grdDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdDetalle_EditingControlShowing);
            // 
            // Seleccion
            // 
            this.Seleccion.DataPropertyName = "Seleccion";
            this.Seleccion.FillWeight = 30F;
            this.Seleccion.HeaderText = "#";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Visible = false;
            // 
            // D_Articulo
            // 
            this.D_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // K_Nota_Recepcion
            // 
            this.K_Nota_Recepcion.DataPropertyName = "K_Nota_Recepcion";
            this.K_Nota_Recepcion.FillWeight = 93.24873F;
            this.K_Nota_Recepcion.HeaderText = "No. Recepción";
            this.K_Nota_Recepcion.Name = "K_Nota_Recepcion";
            this.K_Nota_Recepcion.ReadOnly = true;
            this.K_Nota_Recepcion.Visible = false;
            // 
            // K_Proveedor
            // 
            this.K_Proveedor.DataPropertyName = "K_Proveedor";
            this.K_Proveedor.HeaderText = "K_Proveedor";
            this.K_Proveedor.Name = "K_Proveedor";
            this.K_Proveedor.ReadOnly = true;
            this.K_Proveedor.Visible = false;
            // 
            // D_Proveedor
            // 
            this.D_Proveedor.DataPropertyName = "D_Proveedor";
            this.D_Proveedor.HeaderText = "D_Proveedor";
            this.D_Proveedor.Name = "D_Proveedor";
            this.D_Proveedor.ReadOnly = true;
            this.D_Proveedor.Visible = false;
            // 
            // D_Tipo_Movimiento
            // 
            this.D_Tipo_Movimiento.DataPropertyName = "D_Tipo_Movimiento";
            this.D_Tipo_Movimiento.HeaderText = "Tipo Movimiento";
            this.D_Tipo_Movimiento.Name = "D_Tipo_Movimiento";
            this.D_Tipo_Movimiento.ReadOnly = true;
            this.D_Tipo_Movimiento.Visible = false;
            // 
            // Cantidad_Articulo
            // 
            this.Cantidad_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad_Articulo.DataPropertyName = "Cantidad_Articulo";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.NullValue = "0";
            this.Cantidad_Articulo.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cantidad_Articulo.HeaderText = "Cant. Inicial";
            this.Cantidad_Articulo.Name = "Cantidad_Articulo";
            this.Cantidad_Articulo.ReadOnly = true;
            // 
            // Cantidad_Movimiento
            // 
            this.Cantidad_Movimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad_Movimiento.DataPropertyName = "Cantidad_Movimiento";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.NullValue = "0";
            this.Cantidad_Movimiento.DefaultCellStyle = dataGridViewCellStyle13;
            this.Cantidad_Movimiento.HeaderText = "Cant. Mov.";
            this.Cantidad_Movimiento.Name = "Cantidad_Movimiento";
            this.Cantidad_Movimiento.ReadOnly = true;
            // 
            // No_Lote
            // 
            this.No_Lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No_Lote.DataPropertyName = "No_Lote";
            this.No_Lote.HeaderText = "Lote";
            this.No_Lote.Name = "No_Lote";
            this.No_Lote.ReadOnly = true;
            this.No_Lote.Width = 170;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            this.F_Caducidad.HeaderText = "Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            this.Precio_Unitario.FillWeight = 93.24873F;
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Visible = false;
            // 
            // F_Entrada_Lote
            // 
            this.F_Entrada_Lote.DataPropertyName = "F_Entrada_Lote";
            this.F_Entrada_Lote.FillWeight = 93.24873F;
            this.F_Entrada_Lote.HeaderText = "Fecha Entrada";
            this.F_Entrada_Lote.Name = "F_Entrada_Lote";
            this.F_Entrada_Lote.ReadOnly = true;
            this.F_Entrada_Lote.Visible = false;
            // 
            // Cantidad_Disponible
            // 
            this.Cantidad_Disponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad_Disponible.DataPropertyName = "Cantidad_Disponible";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.NullValue = "0";
            this.Cantidad_Disponible.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cantidad_Disponible.HeaderText = "Disponible";
            this.Cantidad_Disponible.Name = "Cantidad_Disponible";
            this.Cantidad_Disponible.ReadOnly = true;
            this.Cantidad_Disponible.Width = 130;
            // 
            // F_Movimiento
            // 
            this.F_Movimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.F_Movimiento.DataPropertyName = "F_Movimiento";
            this.F_Movimiento.HeaderText = "Fecha Mov.";
            this.F_Movimiento.Name = "F_Movimiento";
            this.F_Movimiento.ReadOnly = true;
            this.F_Movimiento.Visible = false;
            this.F_Movimiento.Width = 170;
            // 
            // Cantidad_Transferir
            // 
            this.Cantidad_Transferir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad_Transferir.DataPropertyName = "Cantidad_Transferir";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.NullValue = "0";
            this.Cantidad_Transferir.DefaultCellStyle = dataGridViewCellStyle15;
            this.Cantidad_Transferir.HeaderText = "Cant. Transf.";
            this.Cantidad_Transferir.Name = "Cantidad_Transferir";
            this.Cantidad_Transferir.Width = 130;
            // 
            // K_Detalle_Nota_Recepcion
            // 
            this.K_Detalle_Nota_Recepcion.DataPropertyName = "K_Detalle_Nota_Recepcion";
            this.K_Detalle_Nota_Recepcion.HeaderText = "K_Detalle_Nota_Recepcion";
            this.K_Detalle_Nota_Recepcion.Name = "K_Detalle_Nota_Recepcion";
            this.K_Detalle_Nota_Recepcion.Visible = false;
            // 
            // K_Articulo1
            // 
            this.K_Articulo1.DataPropertyName = "K_Articulo";
            this.K_Articulo1.HeaderText = "K_Articulo";
            this.K_Articulo1.Name = "K_Articulo1";
            this.K_Articulo1.Visible = false;
            // 
            // K_Oficina_Movimiento
            // 
            this.K_Oficina_Movimiento.DataPropertyName = "K_Oficina_Movimiento";
            this.K_Oficina_Movimiento.HeaderText = "K_Oficina_Movimiento";
            this.K_Oficina_Movimiento.Name = "K_Oficina_Movimiento";
            this.K_Oficina_Movimiento.Visible = false;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.Visible = false;
            // 
            // K_Tipo_Movimiento
            // 
            this.K_Tipo_Movimiento.DataPropertyName = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.HeaderText = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.Name = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.Visible = false;
            // 
            // K_Movimiento_Inventario
            // 
            this.K_Movimiento_Inventario.DataPropertyName = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.HeaderText = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Name = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Visible = false;
            // 
            // F_Recepcion
            // 
            this.F_Recepcion.DataPropertyName = "F_Recepcion";
            this.F_Recepcion.HeaderText = "F_Recepcion";
            this.F_Recepcion.Name = "F_Recepcion";
            this.F_Recepcion.Visible = false;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.DataPropertyName = "Tipo_Documento";
            this.Tipo_Documento.HeaderText = "Tipo_Documento";
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.Visible = false;
            // 
            // No_Documento
            // 
            this.No_Documento.DataPropertyName = "No_Documento";
            this.No_Documento.HeaderText = "No_Documento";
            this.No_Documento.Name = "No_Documento";
            this.No_Documento.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.sdds);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 193);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxMostrarTodo);
            this.groupBox2.Controls.Add(this.txtRecepcion);
            this.groupBox2.Controls.Add(this.Txt_Sku);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnLimpiaArticulo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpFinal);
            this.groupBox2.Controls.Add(this.btnBuscaProducto);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1195, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROS DE BÚSQUEDA";
            // 
            // cbxMostrarTodo
            // 
            this.cbxMostrarTodo.AutoSize = true;
            this.cbxMostrarTodo.Checked = true;
            this.cbxMostrarTodo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMostrarTodo.Location = new System.Drawing.Point(552, 59);
            this.cbxMostrarTodo.Name = "cbxMostrarTodo";
            this.cbxMostrarTodo.Size = new System.Drawing.Size(109, 21);
            this.cbxMostrarTodo.TabIndex = 22;
            this.cbxMostrarTodo.Text = "Mostrar Todo";
            this.cbxMostrarTodo.UseVisualStyleBackColor = true;
            this.cbxMostrarTodo.CheckedChanged += new System.EventHandler(this.cbxMostrarTodo_CheckedChanged);
            // 
            // txtRecepcion
            // 
            this.txtRecepcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecepcion.Location = new System.Drawing.Point(567, 19);
            this.txtRecepcion.Name = "txtRecepcion";
            this.txtRecepcion.Size = new System.Drawing.Size(94, 25);
            this.txtRecepcion.TabIndex = 5;
            // 
            // Txt_Sku
            // 
            this.Txt_Sku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Sku.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sku.Location = new System.Drawing.Point(735, 52);
            this.Txt_Sku.Name = "Txt_Sku";
            this.Txt_Sku.Size = new System.Drawing.Size(321, 33);
            this.Txt_Sku.TabIndex = 1;
            this.Txt_Sku.TextChanged += new System.EventHandler(this.Txt_Sku_TextChanged);
            this.Txt_Sku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Sku_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "SKU";
            // 
            // btnLimpiaArticulo
            // 
            this.btnLimpiaArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiaArticulo.Image")));
            this.btnLimpiaArticulo.Location = new System.Drawing.Point(1094, 19);
            this.btnLimpiaArticulo.Name = "btnLimpiaArticulo";
            this.btnLimpiaArticulo.Size = new System.Drawing.Size(32, 24);
            this.btnLimpiaArticulo.TabIndex = 19;
            this.btnLimpiaArticulo.Tag = "";
            this.btnLimpiaArticulo.UseVisualStyleBackColor = true;
            this.btnLimpiaArticulo.Click += new System.EventHandler(this.btnLimpiaArticulo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(150, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "al";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(175, 18);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(103, 24);
            this.dtpFinal.TabIndex = 3;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProducto.Image")));
            this.btnBuscaProducto.Location = new System.Drawing.Point(1062, 19);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaProducto.TabIndex = 7;
            this.btnBuscaProducto.UseVisualStyleBackColor = true;
            this.btnBuscaProducto.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(41, 17);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(103, 24);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtArticulo.Location = new System.Drawing.Point(735, 19);
            this.txtArticulo.MaxLength = 30;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(321, 24);
            this.txtArticulo.TabIndex = 6;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            this.txtArticulo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtArticulo_PreviewKeyDown);
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.SystemColors.Window;
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.Location = new System.Drawing.Point(351, 19);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(103, 24);
            this.txtLote.TabIndex = 4;
            this.txtLote.Leave += new System.EventHandler(this.txtLote_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "No. Recepción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Articulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "No. Lote";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Del";
            // 
            // sdds
            // 
            this.sdds.Controls.Add(this.label1);
            this.sdds.Controls.Add(this.txtOficina);
            this.sdds.Controls.Add(this.label3);
            this.sdds.Controls.Add(this.txtAlmacen);
            this.sdds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdds.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdds.Location = new System.Drawing.Point(12, 31);
            this.sdds.Name = "sdds";
            this.sdds.Size = new System.Drawing.Size(1195, 52);
            this.sdds.TabIndex = 23;
            this.sdds.TabStop = false;
            this.sdds.Text = "DATOS GENERALES";
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
            this.txtOficina.Location = new System.Drawing.Point(70, 18);
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
            this.label3.Location = new System.Drawing.Point(383, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Almacen";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlmacen.Location = new System.Drawing.Point(455, 18);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.ReadOnly = true;
            this.txtAlmacen.Size = new System.Drawing.Size(307, 24);
            this.txtAlmacen.TabIndex = 6;
            this.txtAlmacen.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1220, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Selección de Artículos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 47);
            this.panel3.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(598, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(484, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 28);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Frm_Ajuste_Transferencia_Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_Ajuste_Transferencia_Seleccion";
            this.Text = "TRASPASO SELECCION";
            this.Load += new System.EventHandler(this.Frm_Ajuste_Transferencia_Seleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sdds.ResumeLayout(false);
            this.sdds.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiaArticulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnBuscaProducto;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox sdds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Nota_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrada_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Transferir;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Detalle_Nota_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Movimiento_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Documento;
        private System.Windows.Forms.TextBox Txt_Sku;
        private System.Windows.Forms.Label label4;
        private Controles.ucInteger32 txtRecepcion;
        private System.Windows.Forms.CheckBox cbxMostrarTodo;
    }
}