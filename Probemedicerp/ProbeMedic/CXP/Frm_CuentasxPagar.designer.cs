﻿namespace ProbeMedic.CXP
{
    partial class Frm_CuentasxPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CuentasxPagar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.txtTotalISR = new ProbeMedic.Controles.customTextBox();
            this.txtTasaISR = new ProbeMedic.Controles.customTextBox();
            this.txtTotalRetencionIVA = new ProbeMedic.Controles.customTextBox();
            this.txtTasaRetencionIVA = new ProbeMedic.Controles.customTextBox();
            this.txtTotalIVA = new ProbeMedic.Controles.customTextBox();
            this.txtSubtotal = new ProbeMedic.Controles.customTextBox();
            this.pnlTotalesTotal = new System.Windows.Forms.Panel();
            this.txtTotal = new ProbeMedic.Controles.customTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFolioFiscal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarOrdenCompra = new System.Windows.Forms.Button();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAbajo = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.QuitarDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Manual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAbajoDerecha = new System.Windows.Forms.Panel();
            this.seleccionaArchivoXML1 = new ProbeMedic.Controles.SeleccionaArchivoXML();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlArriba.SuspendLayout();
            this.pnlTotales.SuspendLayout();
            this.pnlTotalesTotal.SuspendLayout();
            this.pnlAbajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.pnlAbajoDerecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.AllowDrop = true;
            this.pnlArriba.Controls.Add(this.pnlTotales);
            this.pnlArriba.Controls.Add(this.txtTipoCambio);
            this.pnlArriba.Controls.Add(this.txtFolio);
            this.pnlArriba.Controls.Add(this.label17);
            this.pnlArriba.Controls.Add(this.txtFolioFiscal);
            this.pnlArriba.Controls.Add(this.label15);
            this.pnlArriba.Controls.Add(this.txtObservaciones);
            this.pnlArriba.Controls.Add(this.label16);
            this.pnlArriba.Controls.Add(this.txtFechaVencimiento);
            this.pnlArriba.Controls.Add(this.label14);
            this.pnlArriba.Controls.Add(this.txtFechaFactura);
            this.pnlArriba.Controls.Add(this.label13);
            this.pnlArriba.Controls.Add(this.lblTipoCambio);
            this.pnlArriba.Controls.Add(this.cmbMoneda);
            this.pnlArriba.Controls.Add(this.label4);
            this.pnlArriba.Controls.Add(this.txtSerie);
            this.pnlArriba.Controls.Add(this.label2);
            this.pnlArriba.Controls.Add(this.label3);
            this.pnlArriba.Controls.Add(this.txtClaveProveedor);
            this.pnlArriba.Controls.Add(this.btnBuscaProveedor);
            this.pnlArriba.Controls.Add(this.txtProveedor);
            this.pnlArriba.Controls.Add(this.btnBuscarOrdenCompra);
            this.pnlArriba.Controls.Add(this.txtNoOrden);
            this.pnlArriba.Controls.Add(this.label1);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 38);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(1066, 253);
            this.pnlArriba.TabIndex = 4;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.txtTotalISR);
            this.pnlTotales.Controls.Add(this.txtTasaISR);
            this.pnlTotales.Controls.Add(this.txtTotalRetencionIVA);
            this.pnlTotales.Controls.Add(this.txtTasaRetencionIVA);
            this.pnlTotales.Controls.Add(this.txtTotalIVA);
            this.pnlTotales.Controls.Add(this.txtSubtotal);
            this.pnlTotales.Controls.Add(this.pnlTotalesTotal);
            this.pnlTotales.Controls.Add(this.label11);
            this.pnlTotales.Controls.Add(this.label9);
            this.pnlTotales.Controls.Add(this.label10);
            this.pnlTotales.Controls.Add(this.label8);
            this.pnlTotales.Controls.Add(this.label7);
            this.pnlTotales.Controls.Add(this.label5);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTotales.Location = new System.Drawing.Point(765, 0);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(301, 253);
            this.pnlTotales.TabIndex = 64;
            // 
            // txtTotalISR
            // 
            this.txtTotalISR.DecimalPlaces = 2;
            this.txtTotalISR.DecimalsSeparator = '.';
            this.txtTotalISR.Enabled = false;
            this.txtTotalISR.Location = new System.Drawing.Point(98, 162);
            this.txtTotalISR.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalISR.Name = "txtTotalISR";
            this.txtTotalISR.PreFix = null;
            this.txtTotalISR.ReadOnly = true;
            this.txtTotalISR.Size = new System.Drawing.Size(101, 24);
            this.txtTotalISR.TabIndex = 57;
            this.txtTotalISR.TabStop = false;
            this.txtTotalISR.Text = "0";
            this.txtTotalISR.ThousandsSeparator = ',';
            // 
            // txtTasaISR
            // 
            this.txtTasaISR.DecimalPlaces = 2;
            this.txtTasaISR.DecimalsSeparator = '.';
            this.txtTasaISR.Enabled = false;
            this.txtTasaISR.Location = new System.Drawing.Point(99, 130);
            this.txtTasaISR.Margin = new System.Windows.Forms.Padding(2);
            this.txtTasaISR.Name = "txtTasaISR";
            this.txtTasaISR.PreFix = null;
            this.txtTasaISR.ReadOnly = true;
            this.txtTasaISR.Size = new System.Drawing.Size(99, 24);
            this.txtTasaISR.TabIndex = 56;
            this.txtTasaISR.TabStop = false;
            this.txtTasaISR.Text = "0";
            this.txtTasaISR.ThousandsSeparator = ',';
            // 
            // txtTotalRetencionIVA
            // 
            this.txtTotalRetencionIVA.DecimalPlaces = 2;
            this.txtTotalRetencionIVA.DecimalsSeparator = '.';
            this.txtTotalRetencionIVA.Enabled = false;
            this.txtTotalRetencionIVA.Location = new System.Drawing.Point(99, 100);
            this.txtTotalRetencionIVA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalRetencionIVA.Name = "txtTotalRetencionIVA";
            this.txtTotalRetencionIVA.PreFix = null;
            this.txtTotalRetencionIVA.ReadOnly = true;
            this.txtTotalRetencionIVA.Size = new System.Drawing.Size(100, 24);
            this.txtTotalRetencionIVA.TabIndex = 55;
            this.txtTotalRetencionIVA.TabStop = false;
            this.txtTotalRetencionIVA.Text = "0";
            this.txtTotalRetencionIVA.ThousandsSeparator = ',';
            // 
            // txtTasaRetencionIVA
            // 
            this.txtTasaRetencionIVA.DecimalPlaces = 2;
            this.txtTasaRetencionIVA.DecimalsSeparator = '.';
            this.txtTasaRetencionIVA.Enabled = false;
            this.txtTasaRetencionIVA.Location = new System.Drawing.Point(98, 70);
            this.txtTasaRetencionIVA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTasaRetencionIVA.Name = "txtTasaRetencionIVA";
            this.txtTasaRetencionIVA.PreFix = null;
            this.txtTasaRetencionIVA.ReadOnly = true;
            this.txtTasaRetencionIVA.Size = new System.Drawing.Size(100, 24);
            this.txtTasaRetencionIVA.TabIndex = 54;
            this.txtTasaRetencionIVA.TabStop = false;
            this.txtTasaRetencionIVA.Text = "0";
            this.txtTasaRetencionIVA.ThousandsSeparator = ',';
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.DecimalPlaces = 2;
            this.txtTotalIVA.DecimalsSeparator = '.';
            this.txtTotalIVA.Enabled = false;
            this.txtTotalIVA.Location = new System.Drawing.Point(98, 39);
            this.txtTotalIVA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.PreFix = null;
            this.txtTotalIVA.ReadOnly = true;
            this.txtTotalIVA.Size = new System.Drawing.Size(100, 24);
            this.txtTotalIVA.TabIndex = 53;
            this.txtTotalIVA.TabStop = false;
            this.txtTotalIVA.ThousandsSeparator = ',';
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.DecimalPlaces = 2;
            this.txtSubtotal.DecimalsSeparator = '.';
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(98, 8);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PreFix = null;
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 24);
            this.txtSubtotal.TabIndex = 51;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.ThousandsSeparator = ',';
            // 
            // pnlTotalesTotal
            // 
            this.pnlTotalesTotal.Controls.Add(this.txtTotal);
            this.pnlTotalesTotal.Controls.Add(this.label12);
            this.pnlTotalesTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalesTotal.Location = new System.Drawing.Point(0, 205);
            this.pnlTotalesTotal.Name = "pnlTotalesTotal";
            this.pnlTotalesTotal.Size = new System.Drawing.Size(301, 48);
            this.pnlTotalesTotal.TabIndex = 50;
            // 
            // txtTotal
            // 
            this.txtTotal.DecimalPlaces = 2;
            this.txtTotal.DecimalsSeparator = '.';
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(94, 13);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PreFix = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(101, 24);
            this.txtTotal.TabIndex = 52;
            this.txtTotal.ThousandsSeparator = ',';
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "ISR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Retención IVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Total IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "SubTotal";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Enabled = false;
            this.txtTipoCambio.Location = new System.Drawing.Point(586, 44);
            this.txtTipoCambio.MaxLength = 10;
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(88, 24);
            this.txtTipoCambio.TabIndex = 9;
            this.txtTipoCambio.Tag = "";
            this.txtTipoCambio.Visible = false;
            this.txtTipoCambio.Leave += new System.EventHandler(this.txtTipoCambio_Leave);
            // 
            // txtFolio
            // 
            this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(306, 70);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(138, 24);
            this.txtFolio.TabIndex = 5;
            this.txtFolio.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(265, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 63;
            this.label17.Text = "Folio";
            // 
            // txtFolioFiscal
            // 
            this.txtFolioFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFolioFiscal.Enabled = false;
            this.txtFolioFiscal.Location = new System.Drawing.Point(111, 100);
            this.txtFolioFiscal.MaxLength = 40;
            this.txtFolioFiscal.Name = "txtFolioFiscal";
            this.txtFolioFiscal.Size = new System.Drawing.Size(333, 24);
            this.txtFolioFiscal.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "Folio Fiscal";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 178);
            this.txtObservaciones.MaxLength = 200;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(708, 59);
            this.txtObservaciones.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Observaciones";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Enabled = false;
            this.txtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(356, 130);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(88, 24);
            this.txtFechaVencimiento.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Vencimiento";
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.Enabled = false;
            this.txtFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaFactura.Location = new System.Drawing.Point(111, 130);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.Size = new System.Drawing.Size(88, 24);
            this.txtFechaFactura.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "Fecha Factura";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(504, 46);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(84, 17);
            this.lblTipoCambio.TabIndex = 31;
            this.lblTipoCambio.Text = "Tipo Cambio";
            this.lblTipoCambio.Visible = false;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.Enabled = false;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(563, 13);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(160, 24);
            this.cmbMoneda.TabIndex = 8;
            this.cmbMoneda.Visible = false;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Moneda";
            this.label4.Visible = false;
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(111, 70);
            this.txtSerie.MaxLength = 10;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 24);
            this.txtSerie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(111, 39);
            this.txtClaveProveedor.MaxLength = 5;
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(50, 24);
            this.txtClaveProveedor.TabIndex = 2;
            this.txtClaveProveedor.Tag = "ENTERO";
            this.txtClaveProveedor.Leave += new System.EventHandler(this.txtClaveProveedor_Leave);
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProveedor.Image")));
            this.btnBuscaProveedor.Location = new System.Drawing.Point(450, 39);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaProveedor.TabIndex = 3;
            this.btnBuscaProveedor.UseVisualStyleBackColor = true;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(162, 39);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(283, 24);
            this.txtProveedor.TabIndex = 23;
            // 
            // btnBuscarOrdenCompra
            // 
            this.btnBuscarOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOrdenCompra.Image")));
            this.btnBuscarOrdenCompra.Location = new System.Drawing.Point(218, 9);
            this.btnBuscarOrdenCompra.Name = "btnBuscarOrdenCompra";
            this.btnBuscarOrdenCompra.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarOrdenCompra.TabIndex = 1;
            this.btnBuscarOrdenCompra.UseVisualStyleBackColor = true;
            this.btnBuscarOrdenCompra.Visible = false;
            this.btnBuscarOrdenCompra.Click += new System.EventHandler(this.btnBuscarOrdenCompra_Click);
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(111, 8);
            this.txtNoOrden.MaxLength = 10;
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(100, 24);
            this.txtNoOrden.TabIndex = 0;
            this.txtNoOrden.Tag = "ENTERO";
            this.txtNoOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOrden_KeyPress);
            this.txtNoOrden.Leave += new System.EventHandler(this.txtNoOrden_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Orden";
            // 
            // pnlAbajo
            // 
            this.pnlAbajo.Controls.Add(this.grdDatos);
            this.pnlAbajo.Controls.Add(this.pnlAbajoDerecha);
            this.pnlAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbajo.Location = new System.Drawing.Point(0, 291);
            this.pnlAbajo.Name = "pnlAbajo";
            this.pnlAbajo.Size = new System.Drawing.Size(1066, 241);
            this.pnlAbajo.TabIndex = 5;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuitarDetalle,
            this.Cantidad,
            this.UnidadMedida,
            this.Concepto,
            this.PrecioUnitario,
            this.ImporteTotal,
            this.B_Manual,
            this.Id});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(765, 241);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // QuitarDetalle
            // 
            this.QuitarDetalle.HeaderText = "";
            this.QuitarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("QuitarDetalle.Image")));
            this.QuitarDetalle.Name = "QuitarDetalle";
            this.QuitarDetalle.ReadOnly = true;
            this.QuitarDetalle.ToolTipText = "Quitar Concepto del Detalle";
            this.QuitarDetalle.Width = 25;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "Unidad Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Width = 130;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 310;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrecioUnitario.HeaderText = "P. Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // ImporteTotal
            // 
            this.ImporteTotal.DataPropertyName = "ImporteTotal";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.ImporteTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.ImporteTotal.HeaderText = "Importe";
            this.ImporteTotal.Name = "ImporteTotal";
            this.ImporteTotal.ReadOnly = true;
            this.ImporteTotal.Width = 130;
            // 
            // B_Manual
            // 
            this.B_Manual.DataPropertyName = "B_Manual";
            this.B_Manual.HeaderText = "Manual";
            this.B_Manual.Name = "B_Manual";
            this.B_Manual.ReadOnly = true;
            this.B_Manual.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // pnlAbajoDerecha
            // 
            this.pnlAbajoDerecha.BackColor = System.Drawing.Color.White;
            this.pnlAbajoDerecha.Controls.Add(this.seleccionaArchivoXML1);
            this.pnlAbajoDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAbajoDerecha.Location = new System.Drawing.Point(765, 0);
            this.pnlAbajoDerecha.Name = "pnlAbajoDerecha";
            this.pnlAbajoDerecha.Size = new System.Drawing.Size(301, 241);
            this.pnlAbajoDerecha.TabIndex = 0;
            // 
            // seleccionaArchivoXML1
            // 
            this.seleccionaArchivoXML1.Location = new System.Drawing.Point(2, 68);
            this.seleccionaArchivoXML1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seleccionaArchivoXML1.Name = "seleccionaArchivoXML1";
            this.seleccionaArchivoXML1.PropiedadEsRFCValido = false;
            this.seleccionaArchivoXML1.PropiedadFactura = null;
            this.seleccionaArchivoXML1.PropiedadRuta = null;
            this.seleccionaArchivoXML1.PropiedadRutas = null;
            this.seleccionaArchivoXML1.PropiedadXML = null;
            this.seleccionaArchivoXML1.Size = new System.Drawing.Size(295, 40);
            this.seleccionaArchivoXML1.TabIndex = 0;
            this.seleccionaArchivoXML1.Load += new System.EventHandler(this.seleccionaArchivoXML1_Load);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "zoom.png");
            // 
            // Frm_CuentasxPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 571);
            this.Controls.Add(this.pnlAbajo);
            this.Controls.Add(this.pnlArriba);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_CuentasxPagar";
            this.Text = "CUENTAS POR COBRAR";
            this.Load += new System.EventHandler(this.Frm_CuentasxPagar_Load);
            this.Controls.SetChildIndex(this.pnlArriba, 0);
            this.Controls.SetChildIndex(this.pnlAbajo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.pnlTotalesTotal.ResumeLayout(false);
            this.pnlTotalesTotal.PerformLayout();
            this.pnlAbajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.pnlAbajoDerecha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker txtFechaVencimiento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txtFechaFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Button btnBuscaProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnBuscarOrdenCompra;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolioFiscal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlAbajo;
        //private ControlesUsuario.SeleccionaArchivoXML seleccionaArchivoXML1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Panel pnlTotalesTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Controles.customTextBox txtTotalISR;
        private Controles.customTextBox txtTasaISR;
        private Controles.customTextBox txtTotalRetencionIVA;
        private Controles.customTextBox txtTasaRetencionIVA;
        private Controles.customTextBox txtTotalIVA;
        private Controles.customTextBox txtSubtotal;
        private Controles.customTextBox txtTotal;
        private System.Windows.Forms.Panel pnlAbajoDerecha;
        private Controles.SeleccionaArchivoXML seleccionaArchivoXML1;
        private System.Windows.Forms.DataGridViewImageColumn QuitarDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ImageList imageList;
    }
}