namespace ProbeMedic.PEDIDOS
{
    partial class FRM_SEGUIMIENTO_PEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEGUIMIENTO_PEDIDOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRemisiones = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.rbPedidos = new System.Windows.Forms.RadioButton();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtClavePaciente = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GrdDatos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 656);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1132, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seguimiento de Pedidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.cbxAlmacen);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDocumento);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBuscaCliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rbRemisiones);
            this.groupBox3.Controls.Add(this.txtCliente);
            this.groupBox3.Controls.Add(this.rbPedidos);
            this.groupBox3.Controls.Add(this.txtClaveCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnBuscaPaciente);
            this.groupBox3.Controls.Add(this.txtPaciente);
            this.groupBox3.Controls.Add(this.txtClavePaciente);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(9, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1110, 209);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILTROS";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpInicial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 63);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(328, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "al";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Location = new System.Drawing.Point(61, 25);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(263, 23);
            this.dtpInicial.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(34, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "De";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.Location = new System.Drawing.Point(34, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "De";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Location = new System.Drawing.Point(352, 25);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(258, 23);
            this.dtpFinal.TabIndex = 6;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(644, 107);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(326, 24);
            this.cbxAlmacen.TabIndex = 154;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(581, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 153;
            this.label8.Text = "Almacén";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDocumento.Location = new System.Drawing.Point(110, 50);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(130, 24);
            this.txtDocumento.TabIndex = 141;
            this.txtDocumento.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 142;
            this.label5.Text = "Documento";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(460, 107);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaCliente.TabIndex = 3;
            this.btnBuscaCliente.Tag = "";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cliente";
            // 
            // rbRemisiones
            // 
            this.rbRemisiones.AutoSize = true;
            this.rbRemisiones.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbRemisiones.Location = new System.Drawing.Point(240, 17);
            this.rbRemisiones.Margin = new System.Windows.Forms.Padding(2);
            this.rbRemisiones.Name = "rbRemisiones";
            this.rbRemisiones.Size = new System.Drawing.Size(160, 21);
            this.rbRemisiones.TabIndex = 145;
            this.rbRemisiones.Text = "Pedidos Aseguradoras";
            this.rbRemisiones.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCliente.Location = new System.Drawing.Point(163, 107);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(296, 24);
            this.txtCliente.TabIndex = 54;
            this.txtCliente.TabStop = false;
            // 
            // rbPedidos
            // 
            this.rbPedidos.AutoSize = true;
            this.rbPedidos.Checked = true;
            this.rbPedidos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbPedidos.Location = new System.Drawing.Point(82, 17);
            this.rbPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.rbPedidos.Name = "rbPedidos";
            this.rbPedidos.Size = new System.Drawing.Size(123, 21);
            this.rbPedidos.TabIndex = 144;
            this.rbPedidos.TabStop = true;
            this.rbPedidos.Text = "Pedidos Clientes";
            this.rbPedidos.UseVisualStyleBackColor = true;
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtClaveCliente.Location = new System.Drawing.Point(110, 107);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.Size = new System.Drawing.Size(52, 24);
            this.txtClaveCliente.TabIndex = 53;
            this.txtClaveCliente.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Paciente";
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBuscaPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaPaciente.Image")));
            this.btnBuscaPaciente.Location = new System.Drawing.Point(460, 78);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaPaciente.TabIndex = 2;
            this.btnBuscaPaciente.Tag = "";
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPaciente.Location = new System.Drawing.Point(163, 78);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(296, 24);
            this.txtPaciente.TabIndex = 50;
            this.txtPaciente.TabStop = false;
            // 
            // txtClavePaciente
            // 
            this.txtClavePaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtClavePaciente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtClavePaciente.Location = new System.Drawing.Point(110, 78);
            this.txtClavePaciente.Name = "txtClavePaciente";
            this.txtClavePaciente.Size = new System.Drawing.Size(52, 24);
            this.txtClavePaciente.TabIndex = 49;
            this.txtClavePaciente.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 251);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1129, 402);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrdDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1121, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GrdDatos
            // 
            this.GrdDatos.AllowUserToAddRows = false;
            this.GrdDatos.AllowUserToDeleteRows = false;
            this.GrdDatos.AllowUserToResizeColumns = false;
            this.GrdDatos.AllowUserToResizeRows = false;
            this.GrdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Pedido,
            this.D_Estatus_Pedido,
            this.D_Oficina,
            this.D_Almacen,
            this.K_Cliente,
            this.D_Cliente,
            this.K_Paciente,
            this.D_Paciente,
            this.D_Usuario,
            this.F_Registro});
            this.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDatos.Location = new System.Drawing.Point(3, 3);
            this.GrdDatos.MultiSelect = false;
            this.GrdDatos.Name = "GrdDatos";
            this.GrdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDatos.Size = new System.Drawing.Size(1115, 367);
            this.GrdDatos.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GrdDetalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1121, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seguimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrdDetalle
            // 
            this.GrdDetalle.AllowUserToAddRows = false;
            this.GrdDetalle.AllowUserToDeleteRows = false;
            this.GrdDetalle.AllowUserToResizeColumns = false;
            this.GrdDetalle.AllowUserToResizeRows = false;
            this.GrdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.Cantidad,
            this.Lote,
            this.D_Unidad_Medida});
            this.GrdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDetalle.Location = new System.Drawing.Point(3, 3);
            this.GrdDetalle.MultiSelect = false;
            this.GrdDetalle.Name = "GrdDetalle";
            this.GrdDetalle.Size = new System.Drawing.Size(1115, 367);
            this.GrdDetalle.TabIndex = 3;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "Unidad Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            // 
            // K_Pedido
            // 
            this.K_Pedido.DataPropertyName = "K_Pedido";
            this.K_Pedido.HeaderText = "ID Pedido";
            this.K_Pedido.Name = "K_Pedido";
            this.K_Pedido.ReadOnly = true;
            this.K_Pedido.Width = 92;
            // 
            // D_Estatus_Pedido
            // 
            this.D_Estatus_Pedido.DataPropertyName = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.HeaderText = "Estatus";
            this.D_Estatus_Pedido.Name = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.ReadOnly = true;
            this.D_Estatus_Pedido.Width = 78;
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
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "No. Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            this.K_Cliente.Width = 98;
            // 
            // D_Cliente
            // 
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 73;
            // 
            // K_Paciente
            // 
            this.K_Paciente.HeaderText = "No. Paciente";
            this.K_Paciente.Name = "K_Paciente";
            this.K_Paciente.ReadOnly = true;
            this.K_Paciente.Width = 109;
            // 
            // D_Paciente
            // 
            this.D_Paciente.HeaderText = "Paciente";
            this.D_Paciente.Name = "D_Paciente";
            this.D_Paciente.ReadOnly = true;
            this.D_Paciente.Width = 84;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.HeaderText = "Creado Por";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Width = 102;
            // 
            // F_Registro
            // 
            this.F_Registro.DataPropertyName = "F_Registro";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Registro.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Registro.HeaderText = "Fec. Registro";
            this.F_Registro.Name = "F_Registro";
            this.F_Registro.ReadOnly = true;
            this.F_Registro.Width = 112;
            // 
            // FRM_SEGUIMIENTO_PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 733);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_SEGUIMIENTO_PEDIDOS";
            this.Text = "SEGUIMIENTO PEDIDOS";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRemisiones;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.RadioButton rbPedidos;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtClavePaciente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView GrdDatos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GrdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Registro;
    }
}