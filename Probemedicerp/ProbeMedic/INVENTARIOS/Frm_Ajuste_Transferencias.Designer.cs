namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Ajuste_Transferencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ajuste_Transferencias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad_Transferir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Nota_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrada_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Detalle_Nota_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Movimiento_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbxAlmacenRecibe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxAlmacenEnvio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficinaEnvio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmacenEnvio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Seleccion,
            this.Cantidad_Transferir,
            this.Cantidad_Disponible,
            this.D_Articulo,
            this.K_Nota_Recepcion,
            this.K_Proveedor,
            this.D_Proveedor,
            this.D_Tipo_Movimiento,
            this.Cantidad_Articulo,
            this.Cantidad_Movimiento,
            this.No_Lote,
            this.F_Entrada_Lote,
            this.F_Movimiento,
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
            this.grdDetalle.Location = new System.Drawing.Point(0, 200);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDetalle.Size = new System.Drawing.Size(1062, 307);
            this.grdDetalle.TabIndex = 5;
            this.grdDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalle_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 40F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 5;
            // 
            // Seleccion
            // 
            this.Seleccion.DataPropertyName = "Seleccion";
            this.Seleccion.FillWeight = 30F;
            this.Seleccion.HeaderText = "#";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Visible = false;
            this.Seleccion.Width = 24;
            // 
            // Cantidad_Transferir
            // 
            this.Cantidad_Transferir.DataPropertyName = "Cantidad_Transferir";
            dataGridViewCellStyle2.NullValue = "0";
            this.Cantidad_Transferir.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad_Transferir.FillWeight = 82.28452F;
            this.Cantidad_Transferir.HeaderText = "Cant. Transferir";
            this.Cantidad_Transferir.Name = "Cantidad_Transferir";
            this.Cantidad_Transferir.ReadOnly = true;
            this.Cantidad_Transferir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad_Transferir.Width = 116;
            // 
            // Cantidad_Disponible
            // 
            this.Cantidad_Disponible.DataPropertyName = "Cantidad_Disponible";
            this.Cantidad_Disponible.FillWeight = 82.28452F;
            this.Cantidad_Disponible.HeaderText = "Cant. Disponible";
            this.Cantidad_Disponible.Name = "Cantidad_Disponible";
            this.Cantidad_Disponible.ReadOnly = true;
            this.Cantidad_Disponible.Width = 120;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.FillWeight = 82.28452F;
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // K_Nota_Recepcion
            // 
            this.K_Nota_Recepcion.DataPropertyName = "K_Nota_Recepcion";
            this.K_Nota_Recepcion.FillWeight = 82.28452F;
            this.K_Nota_Recepcion.HeaderText = "No. Recepción";
            this.K_Nota_Recepcion.Name = "K_Nota_Recepcion";
            this.K_Nota_Recepcion.ReadOnly = true;
            this.K_Nota_Recepcion.Width = 111;
            // 
            // K_Proveedor
            // 
            this.K_Proveedor.DataPropertyName = "K_Proveedor";
            this.K_Proveedor.HeaderText = "K_Proveedor";
            this.K_Proveedor.Name = "K_Proveedor";
            this.K_Proveedor.ReadOnly = true;
            this.K_Proveedor.Visible = false;
            this.K_Proveedor.Width = 113;
            // 
            // D_Proveedor
            // 
            this.D_Proveedor.DataPropertyName = "D_Proveedor";
            this.D_Proveedor.HeaderText = "D_Proveedor";
            this.D_Proveedor.Name = "D_Proveedor";
            this.D_Proveedor.ReadOnly = true;
            this.D_Proveedor.Visible = false;
            this.D_Proveedor.Width = 115;
            // 
            // D_Tipo_Movimiento
            // 
            this.D_Tipo_Movimiento.DataPropertyName = "D_Tipo_Movimiento";
            this.D_Tipo_Movimiento.HeaderText = "Tipo Movimiento";
            this.D_Tipo_Movimiento.Name = "D_Tipo_Movimiento";
            this.D_Tipo_Movimiento.ReadOnly = true;
            this.D_Tipo_Movimiento.Visible = false;
            this.D_Tipo_Movimiento.Width = 122;
            // 
            // Cantidad_Articulo
            // 
            this.Cantidad_Articulo.DataPropertyName = "Cantidad_Articulo";
            this.Cantidad_Articulo.FillWeight = 82.28452F;
            this.Cantidad_Articulo.HeaderText = "Cant. Articulo";
            this.Cantidad_Articulo.Name = "Cantidad_Articulo";
            this.Cantidad_Articulo.ReadOnly = true;
            this.Cantidad_Articulo.Width = 105;
            // 
            // Cantidad_Movimiento
            // 
            this.Cantidad_Movimiento.DataPropertyName = "Cantidad_Movimiento";
            this.Cantidad_Movimiento.FillWeight = 82.28452F;
            this.Cantidad_Movimiento.HeaderText = "Cant. Movimiento";
            this.Cantidad_Movimiento.Name = "Cantidad_Movimiento";
            this.Cantidad_Movimiento.ReadOnly = true;
            this.Cantidad_Movimiento.Width = 128;
            // 
            // No_Lote
            // 
            this.No_Lote.DataPropertyName = "No_Lote";
            this.No_Lote.FillWeight = 82.28452F;
            this.No_Lote.HeaderText = "Lote";
            this.No_Lote.Name = "No_Lote";
            this.No_Lote.ReadOnly = true;
            this.No_Lote.Width = 60;
            // 
            // F_Entrada_Lote
            // 
            this.F_Entrada_Lote.DataPropertyName = "F_Entrada_Lote";
            this.F_Entrada_Lote.FillWeight = 82.28452F;
            this.F_Entrada_Lote.HeaderText = "Fecha Entrada";
            this.F_Entrada_Lote.Name = "F_Entrada_Lote";
            this.F_Entrada_Lote.ReadOnly = true;
            this.F_Entrada_Lote.Width = 111;
            // 
            // F_Movimiento
            // 
            this.F_Movimiento.DataPropertyName = "F_Movimiento";
            this.F_Movimiento.FillWeight = 82.28452F;
            this.F_Movimiento.HeaderText = "Fecha Movimiento";
            this.F_Movimiento.Name = "F_Movimiento";
            this.F_Movimiento.ReadOnly = true;
            this.F_Movimiento.Width = 131;
            // 
            // K_Detalle_Nota_Recepcion
            // 
            this.K_Detalle_Nota_Recepcion.DataPropertyName = "K_Detalle_Nota_Recepcion";
            this.K_Detalle_Nota_Recepcion.HeaderText = "K_Detalle_Nota_Recepcion";
            this.K_Detalle_Nota_Recepcion.Name = "K_Detalle_Nota_Recepcion";
            this.K_Detalle_Nota_Recepcion.Visible = false;
            this.K_Detalle_Nota_Recepcion.Width = 197;
            // 
            // K_Articulo1
            // 
            this.K_Articulo1.DataPropertyName = "K_Articulo";
            this.K_Articulo1.HeaderText = "K_Articulo";
            this.K_Articulo1.Name = "K_Articulo1";
            this.K_Articulo1.Visible = false;
            this.K_Articulo1.Width = 94;
            // 
            // K_Oficina_Movimiento
            // 
            this.K_Oficina_Movimiento.DataPropertyName = "K_Oficina_Movimiento";
            this.K_Oficina_Movimiento.HeaderText = "K_Oficina_Movimiento";
            this.K_Oficina_Movimiento.Name = "K_Oficina_Movimiento";
            this.K_Oficina_Movimiento.Visible = false;
            this.K_Oficina_Movimiento.Width = 167;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.Visible = false;
            this.D_Oficina.Width = 73;
            // 
            // K_Tipo_Movimiento
            // 
            this.K_Tipo_Movimiento.DataPropertyName = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.HeaderText = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.Name = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.Visible = false;
            this.K_Tipo_Movimiento.Width = 153;
            // 
            // K_Movimiento_Inventario
            // 
            this.K_Movimiento_Inventario.DataPropertyName = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.HeaderText = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Name = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Visible = false;
            this.K_Movimiento_Inventario.Width = 189;
            // 
            // F_Recepcion
            // 
            this.F_Recepcion.DataPropertyName = "F_Recepcion";
            this.F_Recepcion.HeaderText = "F_Recepcion";
            this.F_Recepcion.Name = "F_Recepcion";
            this.F_Recepcion.Visible = false;
            this.F_Recepcion.Width = 111;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.DataPropertyName = "Tipo_Documento";
            this.Tipo_Documento.HeaderText = "Tipo_Documento";
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.Visible = false;
            this.Tipo_Documento.Width = 140;
            // 
            // No_Documento
            // 
            this.No_Documento.DataPropertyName = "No_Documento";
            this.No_Documento.HeaderText = "No_Documento";
            this.No_Documento.Name = "No_Documento";
            this.No_Documento.Visible = false;
            this.No_Documento.Width = 131;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 162);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.CbxAlmacenRecibe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.txtClaveOficina);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnBuscarOficina);
            this.groupBox2.Controls.Add(this.txtOficina);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(478, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 124);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS RECEPCIÓN";
            // 
            // CbxAlmacenRecibe
            // 
            this.CbxAlmacenRecibe.FormattingEnabled = true;
            this.CbxAlmacenRecibe.Location = new System.Drawing.Point(129, 54);
            this.CbxAlmacenRecibe.Name = "CbxAlmacenRecibe";
            this.CbxAlmacenRecibe.Size = new System.Drawing.Size(307, 24);
            this.CbxAlmacenRecibe.TabIndex = 29;
            this.CbxAlmacenRecibe.SelectedIndexChanged += new System.EventHandler(this.CbxAlmacenRecibe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Almacen";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(129, 88);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(392, 25);
            this.txtObservaciones.TabIndex = 27;
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(129, 23);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficina.TabIndex = 21;
            this.txtClaveOficina.Leave += new System.EventHandler(this.txtClaveOficina_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Observaciones";
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.FlatAppearance.BorderSize = 0;
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(522, 23);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarOficina.TabIndex = 23;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(187, 23);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(334, 24);
            this.txtOficina.TabIndex = 22;
            this.txtOficina.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Oficina";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CbxAlmacenEnvio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOficinaEnvio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAlmacenEnvio);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 124);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS ENVIO";
            // 
            // CbxAlmacenEnvio
            // 
            this.CbxAlmacenEnvio.FormattingEnabled = true;
            this.CbxAlmacenEnvio.Location = new System.Drawing.Point(141, 55);
            this.CbxAlmacenEnvio.Name = "CbxAlmacenEnvio";
            this.CbxAlmacenEnvio.Size = new System.Drawing.Size(307, 24);
            this.CbxAlmacenEnvio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oficina";
            // 
            // txtOficinaEnvio
            // 
            this.txtOficinaEnvio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOficinaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOficinaEnvio.Location = new System.Drawing.Point(141, 21);
            this.txtOficinaEnvio.Name = "txtOficinaEnvio";
            this.txtOficinaEnvio.ReadOnly = true;
            this.txtOficinaEnvio.Size = new System.Drawing.Size(307, 24);
            this.txtOficinaEnvio.TabIndex = 5;
            this.txtOficinaEnvio.TabStop = false;
            this.txtOficinaEnvio.TextChanged += new System.EventHandler(this.txtOficinaEnvio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Almacen";
            // 
            // txtAlmacenEnvio
            // 
            this.txtAlmacenEnvio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlmacenEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlmacenEnvio.Location = new System.Drawing.Point(6, 94);
            this.txtAlmacenEnvio.Name = "txtAlmacenEnvio";
            this.txtAlmacenEnvio.ReadOnly = true;
            this.txtAlmacenEnvio.Size = new System.Drawing.Size(18, 24);
            this.txtAlmacenEnvio.TabIndex = 6;
            this.txtAlmacenEnvio.TabStop = false;
            this.txtAlmacenEnvio.Visible = false;
            this.txtAlmacenEnvio.TextChanged += new System.EventHandler(this.txtAlmacenEnvio_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1062, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Detalles de Movimientos del Artículo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Ajuste_Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 546);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_Ajuste_Transferencias";
            this.Text = "AJUSTE POR TRASPASO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grdDetalle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CbxAlmacenRecibe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxAlmacenEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficinaEnvio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlmacenEnvio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Transferir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Nota_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrada_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Detalle_Nota_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Movimiento_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Documento;
    }
}