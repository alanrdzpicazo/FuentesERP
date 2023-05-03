namespace ProbeMedic.FACTURACION
{
    partial class Frm_Factura_Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Factura_Farmacia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscaFormaPago = new System.Windows.Forms.Button();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btnCFDI = new System.Windows.Forms.Button();
            this.txtCFDI = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnBuscarSerie = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarDomiclioFiscal = new System.Windows.Forms.Button();
            this.txtDomicilioFiscal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCanalDistribucionCliente1 = new ProbeMedic.Controles.ucCanalDistribucionCliente();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxPagado = new System.Windows.Forms.CheckBox();
            this.CbxCredito = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotalIVA = new System.Windows.Forms.TextBox();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.txtTasaIVA = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ucClientes1 = new ProbeMedic.Controles.ucClientes();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransaccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.btnBuscaCliente);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnBuscaFormaPago);
            this.panel2.Controls.Add(this.txtFormaPago);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.btnCFDI);
            this.panel2.Controls.Add(this.txtCFDI);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.btnBuscarSerie);
            this.panel2.Controls.Add(this.txtSerie);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.ucClientes1);
            this.panel2.Controls.Add(this.dtpFechaEntrega);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnBuscarDomiclioFiscal);
            this.panel2.Controls.Add(this.txtDomicilioFiscal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ucCanalDistribucionCliente1);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbxAlmacen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtClaveOficina);
            this.panel2.Controls.Add(this.txtOficina);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTransaccion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 278);
            this.panel2.TabIndex = 4;
            this.panel2.TabStop = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(153, 97);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(334, 25);
            this.txtCliente.TabIndex = 158;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(488, 97);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaCliente.TabIndex = 159;
            this.btnBuscaCliente.Tag = "";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(634, 244);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(372, 24);
            this.txtCorreo.TabIndex = 157;
            this.txtCorreo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 156;
            this.label6.Text = "Correo";
            // 
            // btnBuscaFormaPago
            // 
            this.btnBuscaFormaPago.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaFormaPago.Image")));
            this.btnBuscaFormaPago.Location = new System.Drawing.Point(525, 214);
            this.btnBuscaFormaPago.Name = "btnBuscaFormaPago";
            this.btnBuscaFormaPago.Size = new System.Drawing.Size(29, 24);
            this.btnBuscaFormaPago.TabIndex = 154;
            this.btnBuscaFormaPago.Tag = "";
            this.btnBuscaFormaPago.UseVisualStyleBackColor = true;
            this.btnBuscaFormaPago.Click += new System.EventHandler(this.btnBuscaFormaPago_Click);
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.BackColor = System.Drawing.Color.White;
            this.txtFormaPago.Location = new System.Drawing.Point(153, 214);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.ReadOnly = true;
            this.txtFormaPago.Size = new System.Drawing.Size(372, 24);
            this.txtFormaPago.TabIndex = 155;
            this.txtFormaPago.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(59, 218);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(82, 17);
            this.label32.TabIndex = 153;
            this.label32.Text = "Forma Pago";
            // 
            // btnCFDI
            // 
            this.btnCFDI.Image = ((System.Drawing.Image)(resources.GetObject("btnCFDI.Image")));
            this.btnCFDI.Location = new System.Drawing.Point(525, 244);
            this.btnCFDI.Name = "btnCFDI";
            this.btnCFDI.Size = new System.Drawing.Size(29, 24);
            this.btnCFDI.TabIndex = 151;
            this.btnCFDI.Tag = "";
            this.btnCFDI.UseVisualStyleBackColor = true;
            this.btnCFDI.Click += new System.EventHandler(this.btnCFDI_Click);
            // 
            // txtCFDI
            // 
            this.txtCFDI.BackColor = System.Drawing.Color.White;
            this.txtCFDI.Location = new System.Drawing.Point(153, 243);
            this.txtCFDI.Name = "txtCFDI";
            this.txtCFDI.ReadOnly = true;
            this.txtCFDI.Size = new System.Drawing.Size(372, 24);
            this.txtCFDI.TabIndex = 152;
            this.txtCFDI.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(76, 247);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 17);
            this.label31.TabIndex = 150;
            this.label31.Text = "Uso CFDI";
            // 
            // btnBuscarSerie
            // 
            this.btnBuscarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerie.Image")));
            this.btnBuscarSerie.Location = new System.Drawing.Point(627, 185);
            this.btnBuscarSerie.Name = "btnBuscarSerie";
            this.btnBuscarSerie.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarSerie.TabIndex = 148;
            this.btnBuscarSerie.Tag = "";
            this.btnBuscarSerie.UseVisualStyleBackColor = true;
            this.btnBuscarSerie.Click += new System.EventHandler(this.btnBuscarSerie_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.White;
            this.txtSerie.Location = new System.Drawing.Point(153, 185);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(474, 24);
            this.txtSerie.TabIndex = 149;
            this.txtSerie.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(104, 191);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 17);
            this.label30.TabIndex = 147;
            this.label30.Text = "Serie";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(414, 8);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(89, 24);
            this.dtpFechaEntrega.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 135;
            this.label11.Text = "Fecha Entrega";
            // 
            // btnBuscarDomiclioFiscal
            // 
            this.btnBuscarDomiclioFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDomiclioFiscal.Image")));
            this.btnBuscarDomiclioFiscal.Location = new System.Drawing.Point(626, 127);
            this.btnBuscarDomiclioFiscal.Name = "btnBuscarDomiclioFiscal";
            this.btnBuscarDomiclioFiscal.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarDomiclioFiscal.TabIndex = 132;
            this.btnBuscarDomiclioFiscal.Tag = "";
            this.btnBuscarDomiclioFiscal.UseVisualStyleBackColor = true;
            this.btnBuscarDomiclioFiscal.Click += new System.EventHandler(this.btnBuscarDomiclioFiscal_Click);
            // 
            // txtDomicilioFiscal
            // 
            this.txtDomicilioFiscal.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilioFiscal.Location = new System.Drawing.Point(154, 127);
            this.txtDomicilioFiscal.Name = "txtDomicilioFiscal";
            this.txtDomicilioFiscal.ReadOnly = true;
            this.txtDomicilioFiscal.Size = new System.Drawing.Size(471, 24);
            this.txtDomicilioFiscal.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 131;
            this.label1.Text = "Canal de Distribución ";
            // 
            // ucCanalDistribucionCliente1
            // 
            this.ucCanalDistribucionCliente1.Location = new System.Drawing.Point(150, 151);
            this.ucCanalDistribucionCliente1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucCanalDistribucionCliente1.Name = "ucCanalDistribucionCliente1";
            this.ucCanalDistribucionCliente1.Size = new System.Drawing.Size(276, 31);
            this.ucCanalDistribucionCliente1.TabIndex = 130;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(798, 126);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(460, 56);
            this.txtObservaciones.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CbxPagado);
            this.groupBox1.Controls.Add(this.CbxCredito);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.txtTotalIVA);
            this.groupBox1.Controls.Add(this.txtTotalFactura);
            this.groupBox1.Controls.Add(this.txtTasaIVA);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(859, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 103);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTALES";
            // 
            // CbxPagado
            // 
            this.CbxPagado.AutoSize = true;
            this.CbxPagado.Enabled = false;
            this.CbxPagado.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.CbxPagado.Location = new System.Drawing.Point(103, 76);
            this.CbxPagado.Margin = new System.Windows.Forms.Padding(2);
            this.CbxPagado.Name = "CbxPagado";
            this.CbxPagado.Size = new System.Drawing.Size(69, 20);
            this.CbxPagado.TabIndex = 58;
            this.CbxPagado.Text = "Pagado";
            this.CbxPagado.UseVisualStyleBackColor = true;
            // 
            // CbxCredito
            // 
            this.CbxCredito.AutoSize = true;
            this.CbxCredito.Enabled = false;
            this.CbxCredito.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.CbxCredito.Location = new System.Drawing.Point(28, 74);
            this.CbxCredito.Margin = new System.Windows.Forms.Padding(2);
            this.CbxCredito.Name = "CbxCredito";
            this.CbxCredito.Size = new System.Drawing.Size(68, 20);
            this.CbxCredito.TabIndex = 57;
            this.CbxCredito.Text = "Crédito";
            this.CbxCredito.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label26.Location = new System.Drawing.Point(168, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 16);
            this.label26.TabIndex = 56;
            this.label26.Text = "%";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtSubtotal.Location = new System.Drawing.Point(280, 15);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(106, 23);
            this.txtSubtotal.TabIndex = 55;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalIVA.Enabled = false;
            this.txtTotalIVA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTotalIVA.Location = new System.Drawing.Point(280, 43);
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.ReadOnly = true;
            this.txtTotalIVA.Size = new System.Drawing.Size(106, 23);
            this.txtTotalIVA.TabIndex = 53;
            this.txtTotalIVA.TabStop = false;
            this.txtTotalIVA.Text = "0.00";
            this.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTotalFactura.Location = new System.Drawing.Point(280, 71);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(106, 23);
            this.txtTotalFactura.TabIndex = 52;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.Text = "0.00";
            this.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTasaIVA
            // 
            this.txtTasaIVA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTasaIVA.Location = new System.Drawing.Point(99, 16);
            this.txtTasaIVA.Name = "txtTasaIVA";
            this.txtTasaIVA.ReadOnly = true;
            this.txtTasaIVA.Size = new System.Drawing.Size(65, 23);
            this.txtTasaIVA.TabIndex = 15;
            this.txtTasaIVA.Text = "16";
            this.txtTasaIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDescuento.Location = new System.Drawing.Point(99, 43);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(65, 23);
            this.txtDescuento.TabIndex = 51;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label19.Location = new System.Drawing.Point(193, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 48;
            this.label19.Text = "SubTotal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label18.Location = new System.Drawing.Point(17, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 16);
            this.label18.TabIndex = 47;
            this.label18.Text = "Tasa IVA";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label17.Location = new System.Drawing.Point(194, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 46;
            this.label17.Text = "Total IVA";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label16.Location = new System.Drawing.Point(194, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 45;
            this.label16.Text = "Total Factura";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label15.Location = new System.Drawing.Point(17, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 44;
            this.label15.Text = "Descuento";
            // 
            // ucClientes1
            // 
            this.ucClientes1.BackColor = System.Drawing.Color.DarkGray;
            this.ucClientes1.Location = new System.Drawing.Point(889, 189);
            this.ucClientes1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucClientes1.Name = "ucClientes1";
            this.ucClientes1.ncliente = 0;
            this.ucClientes1.Size = new System.Drawing.Size(302, 31);
            this.ucClientes1.TabIndex = 10;
            this.ucClientes1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Domicilio Fiscal";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(686, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 17);
            this.label22.TabIndex = 52;
            this.label22.Text = "Observaciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Cliente";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(154, 67);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(278, 24);
            this.cbxAlmacen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Almacén";
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(154, 37);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficina.TabIndex = 22;
            this.txtClaveOficina.TabStop = false;
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(208, 37);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(365, 24);
            this.txtOficina.TabIndex = 24;
            this.txtOficina.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Oficina";
            // 
            // txtTransaccion
            // 
            this.txtTransaccion.BackColor = System.Drawing.Color.White;
            this.txtTransaccion.Location = new System.Drawing.Point(155, 8);
            this.txtTransaccion.Name = "txtTransaccion";
            this.txtTransaccion.Size = new System.Drawing.Size(129, 24);
            this.txtTransaccion.TabIndex = 0;
            this.txtTransaccion.TextChanged += new System.EventHandler(this.txtTransaccion_TextChanged);
            this.txtTransaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransaccion_KeyPress);
            this.txtTransaccion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTransaccion_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Ticket";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1272, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registro de Facturas  Farmacia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.K_Articulo,
            this.D_Articulo,
            this.CSKU,
            this.D_Unidad_Medida,
            this.Precio_Unitario,
            this.Descuento,
            this.Subtotal,
            this.Total_IVA,
            this.Total_Detalle,
            this.K_Tipo_Producto,
            this.K_Unidad_Medida,
            this.PorcentajeDescuento,
            this.Tasa_IVA});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 364);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.Size = new System.Drawing.Size(1272, 224);
            this.grdDetalle.TabIndex = 19;
            this.grdDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalle_CellClick);
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.FillWeight = 52.00946F;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 66;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.FillWeight = 91.78947F;
            this.K_Articulo.HeaderText = "No. Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 103;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.FillWeight = 75.11013F;
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // CSKU
            // 
            this.CSKU.DataPropertyName = "SKU";
            this.CSKU.FillWeight = 60.77729F;
            this.CSKU.HeaderText = "SKU";
            this.CSKU.Name = "CSKU";
            this.CSKU.ReadOnly = true;
            this.CSKU.Width = 58;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.FillWeight = 105.2584F;
            this.D_Unidad_Medida.HeaderText = "U. Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Width = 92;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio_Unitario.FillWeight = 109.6814F;
            this.Precio_Unitario.HeaderText = "P.Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Width = 91;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descuento.FillWeight = 125.0351F;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 99;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Subtotal.FillWeight = 109.9201F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 84;
            // 
            // Total_IVA
            // 
            this.Total_IVA.DataPropertyName = "Total_Iva";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Total_IVA.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total_IVA.FillWeight = 118.8486F;
            this.Total_IVA.HeaderText = "Total IVA";
            this.Total_IVA.Name = "Total_IVA";
            this.Total_IVA.ReadOnly = true;
            this.Total_IVA.Width = 87;
            // 
            // Total_Detalle
            // 
            this.Total_Detalle.DataPropertyName = "Total_Detalle";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Total_Detalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total_Detalle.FillWeight = 151.5701F;
            this.Total_Detalle.HeaderText = "Total Detalle";
            this.Total_Detalle.Name = "Total_Detalle";
            this.Total_Detalle.ReadOnly = true;
            this.Total_Detalle.Width = 107;
            // 
            // K_Tipo_Producto
            // 
            this.K_Tipo_Producto.DataPropertyName = "K_Tipo_Producto";
            this.K_Tipo_Producto.HeaderText = "K_Tipo_Producto";
            this.K_Tipo_Producto.Name = "K_Tipo_Producto";
            this.K_Tipo_Producto.ReadOnly = true;
            this.K_Tipo_Producto.Visible = false;
            this.K_Tipo_Producto.Width = 140;
            // 
            // K_Unidad_Medida
            // 
            this.K_Unidad_Medida.DataPropertyName = "K_Unidad_Medida";
            this.K_Unidad_Medida.HeaderText = "K_Unidad_Medida";
            this.K_Unidad_Medida.Name = "K_Unidad_Medida";
            this.K_Unidad_Medida.ReadOnly = true;
            this.K_Unidad_Medida.Visible = false;
            this.K_Unidad_Medida.Width = 141;
            // 
            // PorcentajeDescuento
            // 
            this.PorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.PorcentajeDescuento.HeaderText = "PorcentajeDescuento";
            this.PorcentajeDescuento.Name = "PorcentajeDescuento";
            this.PorcentajeDescuento.ReadOnly = true;
            this.PorcentajeDescuento.Visible = false;
            this.PorcentajeDescuento.Width = 165;
            // 
            // Tasa_IVA
            // 
            this.Tasa_IVA.DataPropertyName = "Tasa_IVA";
            this.Tasa_IVA.HeaderText = "Tasa_IVA";
            this.Tasa_IVA.Name = "Tasa_IVA";
            this.Tasa_IVA.ReadOnly = true;
            this.Tasa_IVA.Visible = false;
            this.Tasa_IVA.Width = 89;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 344);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1272, 20);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Detalle de Artículos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Factura_Farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 627);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(1288, 666);
            this.MinimumSize = new System.Drawing.Size(1288, 666);
            this.Name = "Frm_Factura_Farmacia";
            this.Text = "FACTURACION FARMACIA";
            this.Load += new System.EventHandler(this.Frm_Factura_Farmacia_Load);
            this.Shown += new System.EventHandler(this.Frm_Factura_Farmacia_Shown);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.grdDetalle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotalIVA;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.TextBox txtTasaIVA;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private Controles.ucClientes ucClientes1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTransaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbxCredito;
        private System.Windows.Forms.Label label1;
        private Controles.ucCanalDistribucionCliente ucCanalDistribucionCliente1;
        private System.Windows.Forms.CheckBox CbxPagado;
        private System.Windows.Forms.Button btnBuscarDomiclioFiscal;
        private System.Windows.Forms.TextBox txtDomicilioFiscal;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_IVA;
        private System.Windows.Forms.Button btnBuscaFormaPago;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnCFDI;
        private System.Windows.Forms.TextBox txtCFDI;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnBuscarSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscaCliente;
    }
}