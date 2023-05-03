namespace ProbeMedic.VENTAS
{
    partial class Frm_Consulta_Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta_Tickets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_Descuento = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chk_Credito = new System.Windows.Forms.CheckBox();
            this.chk_EAD = new System.Windows.Forms.CheckBox();
            this.chk_Facturadas = new System.Windows.Forms.CheckBox();
            this.chk_Canceladas = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grd_Datos = new System.Windows.Forms.DataGridView();
            this.K_Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Precierre_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Cancelada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Facturada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Entrega_Domicilio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Credito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Descuento_Empleado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Porcentaje_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_Almacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_F_Final = new System.Windows.Forms.DateTimePicker();
            this.dtp_F_Inicial = new System.Windows.Forms.DateTimePicker();
            this.txt_K_Transaccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_Descuento);
            this.panel1.Controls.Add(this.chk_Credito);
            this.panel1.Controls.Add(this.chk_EAD);
            this.panel1.Controls.Add(this.chk_Facturadas);
            this.panel1.Controls.Add(this.chk_Canceladas);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.cbx_Almacen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_K_Transaccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 550);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // chk_Descuento
            // 
            this.chk_Descuento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_Descuento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Descuento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Descuento.ImageList = this.imageList1;
            this.chk_Descuento.Location = new System.Drawing.Point(669, 158);
            this.chk_Descuento.Name = "chk_Descuento";
            this.chk_Descuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Descuento.Size = new System.Drawing.Size(204, 25);
            this.chk_Descuento.TabIndex = 9;
            this.chk_Descuento.Text = "Solo Descuento Empleado";
            this.chk_Descuento.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Reload.png");
            this.imageList1.Images.SetKeyName(1, "cancel.png");
            // 
            // chk_Credito
            // 
            this.chk_Credito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_Credito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Credito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Credito.ImageList = this.imageList1;
            this.chk_Credito.Location = new System.Drawing.Point(511, 160);
            this.chk_Credito.Name = "chk_Credito";
            this.chk_Credito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Credito.Size = new System.Drawing.Size(129, 25);
            this.chk_Credito.TabIndex = 9;
            this.chk_Credito.Text = "Solo Crédito";
            this.chk_Credito.UseVisualStyleBackColor = true;
            // 
            // chk_EAD
            // 
            this.chk_EAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_EAD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_EAD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_EAD.ImageList = this.imageList1;
            this.chk_EAD.Location = new System.Drawing.Point(399, 160);
            this.chk_EAD.Name = "chk_EAD";
            this.chk_EAD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_EAD.Size = new System.Drawing.Size(102, 25);
            this.chk_EAD.TabIndex = 8;
            this.chk_EAD.Text = "Solo EAD";
            this.chk_EAD.UseVisualStyleBackColor = true;
            // 
            // chk_Facturadas
            // 
            this.chk_Facturadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_Facturadas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Facturadas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Facturadas.Location = new System.Drawing.Point(227, 163);
            this.chk_Facturadas.Name = "chk_Facturadas";
            this.chk_Facturadas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Facturadas.Size = new System.Drawing.Size(149, 25);
            this.chk_Facturadas.TabIndex = 7;
            this.chk_Facturadas.Text = "Solo Facturadas";
            this.chk_Facturadas.UseVisualStyleBackColor = true;
            // 
            // chk_Canceladas
            // 
            this.chk_Canceladas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_Canceladas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Canceladas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Canceladas.ImageIndex = 1;
            this.chk_Canceladas.ImageList = this.imageList1;
            this.chk_Canceladas.Location = new System.Drawing.Point(35, 163);
            this.chk_Canceladas.Name = "chk_Canceladas";
            this.chk_Canceladas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Canceladas.Size = new System.Drawing.Size(160, 25);
            this.chk_Canceladas.TabIndex = 6;
            this.chk_Canceladas.Text = "Solo Canceladas";
            this.chk_Canceladas.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 199);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 348);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grd_Datos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1217, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tickets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grd_Datos
            // 
            this.grd_Datos.AllowUserToAddRows = false;
            this.grd_Datos.AllowUserToDeleteRows = false;
            this.grd_Datos.AllowUserToResizeColumns = false;
            this.grd_Datos.AllowUserToResizeRows = false;
            this.grd_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Transaccion,
            this.K_Precierre_Empleado,
            this.D_Almacen,
            this.D_Usuario,
            this.F_Transaccion,
            this.Cantidad_Articulos,
            this.Monto_Transaccion,
            this.D_Medico,
            this.Observaciones1,
            this.Observaciones2,
            this.Observaciones3,
            this.Observaciones4,
            this.Observaciones5,
            this.B_Cancelada,
            this.B_Facturada,
            this.B_Entrega_Domicilio,
            this.B_Credito,
            this.B_Descuento_Empleado,
            this.Porcentaje_Descuento});
            this.grd_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Datos.Location = new System.Drawing.Point(3, 3);
            this.grd_Datos.MultiSelect = false;
            this.grd_Datos.Name = "grd_Datos";
            this.grd_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Datos.Size = new System.Drawing.Size(1211, 313);
            this.grd_Datos.TabIndex = 11;
            this.grd_Datos.SelectionChanged += new System.EventHandler(this.grd_Datos_SelectionChanged);
            // 
            // K_Transaccion
            // 
            this.K_Transaccion.DataPropertyName = "K_Transaccion";
            this.K_Transaccion.HeaderText = "# Ticket";
            this.K_Transaccion.Name = "K_Transaccion";
            this.K_Transaccion.ReadOnly = true;
            this.K_Transaccion.Width = 83;
            // 
            // K_Precierre_Empleado
            // 
            this.K_Precierre_Empleado.DataPropertyName = "K_Precierre_Empleado";
            this.K_Precierre_Empleado.HeaderText = "# Precierre Empleado";
            this.K_Precierre_Empleado.Name = "K_Precierre_Empleado";
            this.K_Precierre_Empleado.ReadOnly = true;
            this.K_Precierre_Empleado.Width = 164;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 84;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.HeaderText = "Usuario";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Width = 78;
            // 
            // F_Transaccion
            // 
            this.F_Transaccion.DataPropertyName = "F_Transaccion";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Transaccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Transaccion.HeaderText = "Fec. Transacción";
            this.F_Transaccion.Name = "F_Transaccion";
            this.F_Transaccion.ReadOnly = true;
            this.F_Transaccion.Width = 135;
            // 
            // Cantidad_Articulos
            // 
            this.Cantidad_Articulos.DataPropertyName = "Cantidad_Articulos";
            this.Cantidad_Articulos.HeaderText = "Cant. Artículos";
            this.Cantidad_Articulos.Name = "Cantidad_Articulos";
            this.Cantidad_Articulos.ReadOnly = true;
            this.Cantidad_Articulos.Width = 121;
            // 
            // Monto_Transaccion
            // 
            this.Monto_Transaccion.DataPropertyName = "Monto_Transaccion";
            dataGridViewCellStyle3.Format = "N2";
            this.Monto_Transaccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto_Transaccion.HeaderText = "Monto Transacción";
            this.Monto_Transaccion.Name = "Monto_Transaccion";
            this.Monto_Transaccion.ReadOnly = true;
            this.Monto_Transaccion.Width = 149;
            // 
            // D_Medico
            // 
            this.D_Medico.DataPropertyName = "D_Medico";
            this.D_Medico.HeaderText = "Médico";
            this.D_Medico.Name = "D_Medico";
            this.D_Medico.ReadOnly = true;
            this.D_Medico.Width = 75;
            // 
            // Observaciones1
            // 
            this.Observaciones1.DataPropertyName = "Observaciones1";
            this.Observaciones1.HeaderText = "Observaciones 1";
            this.Observaciones1.Name = "Observaciones1";
            this.Observaciones1.ReadOnly = true;
            this.Observaciones1.Width = 134;
            // 
            // Observaciones2
            // 
            this.Observaciones2.DataPropertyName = "Observaciones2";
            this.Observaciones2.HeaderText = "Observaciones 2";
            this.Observaciones2.Name = "Observaciones2";
            this.Observaciones2.ReadOnly = true;
            this.Observaciones2.Width = 134;
            // 
            // Observaciones3
            // 
            this.Observaciones3.DataPropertyName = "Observaciones3";
            this.Observaciones3.HeaderText = "Observaciones 3";
            this.Observaciones3.Name = "Observaciones3";
            this.Observaciones3.ReadOnly = true;
            this.Observaciones3.Width = 134;
            // 
            // Observaciones4
            // 
            this.Observaciones4.DataPropertyName = "Observaciones4";
            this.Observaciones4.HeaderText = "Observaciones 4";
            this.Observaciones4.Name = "Observaciones4";
            this.Observaciones4.ReadOnly = true;
            this.Observaciones4.Width = 134;
            // 
            // Observaciones5
            // 
            this.Observaciones5.DataPropertyName = "Observaciones5";
            this.Observaciones5.HeaderText = "Observaciones 5";
            this.Observaciones5.Name = "Observaciones5";
            this.Observaciones5.ReadOnly = true;
            this.Observaciones5.Width = 134;
            // 
            // B_Cancelada
            // 
            this.B_Cancelada.DataPropertyName = "B_Cancelada";
            this.B_Cancelada.HeaderText = "¿Esta Cancelado?";
            this.B_Cancelada.Name = "B_Cancelada";
            this.B_Cancelada.ReadOnly = true;
            this.B_Cancelada.Width = 121;
            // 
            // B_Facturada
            // 
            this.B_Facturada.DataPropertyName = "B_Facturada";
            this.B_Facturada.HeaderText = "¿Esta Facturado?";
            this.B_Facturada.Name = "B_Facturada";
            this.B_Facturada.ReadOnly = true;
            this.B_Facturada.Width = 120;
            // 
            // B_Entrega_Domicilio
            // 
            this.B_Entrega_Domicilio.DataPropertyName = "B_Entrega_Domicilio";
            this.B_Entrega_Domicilio.HeaderText = "EAD";
            this.B_Entrega_Domicilio.Name = "B_Entrega_Domicilio";
            this.B_Entrega_Domicilio.ReadOnly = true;
            this.B_Entrega_Domicilio.Width = 40;
            // 
            // B_Credito
            // 
            this.B_Credito.DataPropertyName = "B_Credito";
            this.B_Credito.HeaderText = "¿Crédito?";
            this.B_Credito.Name = "B_Credito";
            this.B_Credito.ReadOnly = true;
            this.B_Credito.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Credito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Credito.Width = 91;
            // 
            // B_Descuento_Empleado
            // 
            this.B_Descuento_Empleado.DataPropertyName = "B_Descuento_Empleado";
            this.B_Descuento_Empleado.HeaderText = "¿Descuento Empleado?";
            this.B_Descuento_Empleado.Name = "B_Descuento_Empleado";
            this.B_Descuento_Empleado.ReadOnly = true;
            this.B_Descuento_Empleado.Width = 158;
            // 
            // Porcentaje_Descuento
            // 
            this.Porcentaje_Descuento.DataPropertyName = "Porcentaje_Descuento";
            dataGridViewCellStyle4.Format = "N2";
            this.Porcentaje_Descuento.DefaultCellStyle = dataGridViewCellStyle4;
            this.Porcentaje_Descuento.HeaderText = "Porcentaje Descuento";
            this.Porcentaje_Descuento.Name = "Porcentaje_Descuento";
            this.Porcentaje_Descuento.ReadOnly = true;
            this.Porcentaje_Descuento.Width = 169;
            // 
            // cbx_Almacen
            // 
            this.cbx_Almacen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Almacen.FormattingEnabled = true;
            this.cbx_Almacen.Location = new System.Drawing.Point(113, 54);
            this.cbx_Almacen.Name = "cbx_Almacen";
            this.cbx_Almacen.Size = new System.Drawing.Size(684, 24);
            this.cbx_Almacen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Almacén";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_F_Final);
            this.groupBox1.Controls.Add(this.dtp_F_Inicial);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(335, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "al";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "De";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "De";
            // 
            // dtp_F_Final
            // 
            this.dtp_F_Final.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_F_Final.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_F_Final.Location = new System.Drawing.Point(363, 22);
            this.dtp_F_Final.Name = "dtp_F_Final";
            this.dtp_F_Final.Size = new System.Drawing.Size(258, 23);
            this.dtp_F_Final.TabIndex = 5;
            // 
            // dtp_F_Inicial
            // 
            this.dtp_F_Inicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_F_Inicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_F_Inicial.Location = new System.Drawing.Point(52, 22);
            this.dtp_F_Inicial.Name = "dtp_F_Inicial";
            this.dtp_F_Inicial.Size = new System.Drawing.Size(267, 23);
            this.dtp_F_Inicial.TabIndex = 4;
            // 
            // txt_K_Transaccion
            // 
            this.txt_K_Transaccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_K_Transaccion.Location = new System.Drawing.Point(113, 22);
            this.txt_K_Transaccion.Name = "txt_K_Transaccion";
            this.txt_K_Transaccion.Size = new System.Drawing.Size(471, 24);
            this.txt_K_Transaccion.TabIndex = 1;
            this.txt_K_Transaccion.TextChanged += new System.EventHandler(this.txt_K_Transaccion_TextChanged);
            this.txt_K_Transaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_K_Transaccion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "No. Ticket";
            // 
            // Frm_Consulta_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 627);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(895, 513);
            this.Name = "Frm_Consulta_Tickets";
            this.Text = "CONSULTA TICKETS VENTA";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_Almacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_F_Inicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_F_Final;
        private System.Windows.Forms.TextBox txt_K_Transaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grd_Datos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chk_Canceladas;
        private System.Windows.Forms.CheckBox chk_Descuento;
        private System.Windows.Forms.CheckBox chk_Credito;
        private System.Windows.Forms.CheckBox chk_EAD;
        private System.Windows.Forms.CheckBox chk_Facturadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precierre_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Cancelada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Facturada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Entrega_Domicilio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Credito;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Descuento_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Descuento;
    }
}