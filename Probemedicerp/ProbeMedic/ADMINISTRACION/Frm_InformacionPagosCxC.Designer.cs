namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_InformacionPagosCxC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlFormasPago = new System.Windows.Forms.Panel();
            this.pnlIncobrable = new System.Windows.Forms.Panel();
            this.txtPagoTotalTipoMoneda4 = new ProbeMedic.Controles.txt_Moneda_MX();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTarjetaImporte = new System.Windows.Forms.TextBox();
            this.txtNumOperacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAprobacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.Cbx_Tarjeta_Credito = new System.Windows.Forms.CheckBox();
            this.cmbTarjetaBanco = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlCheque = new System.Windows.Forms.Panel();
            this.txtPagoTotalTipoMoneda3 = new ProbeMedic.Controles.txt_Moneda_MX();
            this.lblTotalPagoPesos3 = new System.Windows.Forms.Label();
            this.txtChequeImporte = new System.Windows.Forms.TextBox();
            this.txtChequeNoCheque = new System.Windows.Forms.TextBox();
            this.txtChequeCuenta = new System.Windows.Forms.TextBox();
            this.cmbChequeBanco = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlTransferencia = new System.Windows.Forms.Panel();
            this.txtPagoTotalTipoMoneda2 = new ProbeMedic.Controles.txt_Moneda_MX();
            this.lblTotalPagoPesos2 = new System.Windows.Forms.Label();
            this.txtTransferenciaImporte = new System.Windows.Forms.TextBox();
            this.txtTransferenciaReferencia = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTransferenciaNoTransferencia = new System.Windows.Forms.TextBox();
            this.txtTransferenciaCuenta = new System.Windows.Forms.TextBox();
            this.cmbTransferenciaBanco = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlEfectivo = new System.Windows.Forms.Panel();
            this.txtPagoTotalTipoMoneda1 = new ProbeMedic.Controles.txt_Moneda_MX();
            this.lblTotalPagoPesos = new System.Windows.Forms.Label();
            this.txtEfectivoImporte = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFormasPago.SuspendLayout();
            this.pnlIncobrable.SuspendLayout();
            this.pnlCheque.SuspendLayout();
            this.pnlTransferencia.SuspendLayout();
            this.pnlEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlFormasPago);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 249);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 47);
            this.panel2.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Location = new System.Drawing.Point(364, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 47);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlFormasPago
            // 
            this.pnlFormasPago.Controls.Add(this.pnlIncobrable);
            this.pnlFormasPago.Controls.Add(this.pnlCheque);
            this.pnlFormasPago.Controls.Add(this.pnlTransferencia);
            this.pnlFormasPago.Controls.Add(this.pnlEfectivo);
            this.pnlFormasPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormasPago.Enabled = false;
            this.pnlFormasPago.Location = new System.Drawing.Point(0, 0);
            this.pnlFormasPago.Name = "pnlFormasPago";
            this.pnlFormasPago.Size = new System.Drawing.Size(463, 202);
            this.pnlFormasPago.TabIndex = 6;
            this.pnlFormasPago.TabStop = true;
            // 
            // pnlIncobrable
            // 
            this.pnlIncobrable.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlIncobrable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlIncobrable.Controls.Add(this.txtPagoTotalTipoMoneda4);
            this.pnlIncobrable.Controls.Add(this.label12);
            this.pnlIncobrable.Controls.Add(this.label6);
            this.pnlIncobrable.Controls.Add(this.txtTarjetaImporte);
            this.pnlIncobrable.Controls.Add(this.txtNumOperacion);
            this.pnlIncobrable.Controls.Add(this.label8);
            this.pnlIncobrable.Controls.Add(this.label5);
            this.pnlIncobrable.Controls.Add(this.txtAprobacion);
            this.pnlIncobrable.Controls.Add(this.label10);
            this.pnlIncobrable.Controls.Add(this.txtNumTarjeta);
            this.pnlIncobrable.Controls.Add(this.Cbx_Tarjeta_Credito);
            this.pnlIncobrable.Controls.Add(this.cmbTarjetaBanco);
            this.pnlIncobrable.Controls.Add(this.label11);
            this.pnlIncobrable.Controls.Add(this.label17);
            this.pnlIncobrable.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIncobrable.Location = new System.Drawing.Point(381, 0);
            this.pnlIncobrable.Name = "pnlIncobrable";
            this.pnlIncobrable.Size = new System.Drawing.Size(82, 202);
            this.pnlIncobrable.TabIndex = 24;
            this.pnlIncobrable.TabStop = true;
            // 
            // txtPagoTotalTipoMoneda4
            // 
            this.txtPagoTotalTipoMoneda4.dValor = null;
            this.txtPagoTotalTipoMoneda4.Location = new System.Drawing.Point(136, 162);
            this.txtPagoTotalTipoMoneda4.Margin = new System.Windows.Forms.Padding(2);
            this.txtPagoTotalTipoMoneda4.Name = "txtPagoTotalTipoMoneda4";
            this.txtPagoTotalTipoMoneda4.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPagoTotalTipoMoneda4.Size = new System.Drawing.Size(149, 27);
            this.txtPagoTotalTipoMoneda4.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(6, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "Aprobación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Total a Pagar\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTarjetaImporte
            // 
            this.txtTarjetaImporte.Location = new System.Drawing.Point(138, 208);
            this.txtTarjetaImporte.Name = "txtTarjetaImporte";
            this.txtTarjetaImporte.ReadOnly = true;
            this.txtTarjetaImporte.Size = new System.Drawing.Size(195, 23);
            this.txtTarjetaImporte.TabIndex = 6;
            this.txtTarjetaImporte.Tag = "DECIMAL2";
            this.txtTarjetaImporte.Visible = false;
            // 
            // txtNumOperacion
            // 
            this.txtNumOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumOperacion.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOperacion.Location = new System.Drawing.Point(138, 133);
            this.txtNumOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumOperacion.Name = "txtNumOperacion";
            this.txtNumOperacion.Size = new System.Drawing.Size(298, 25);
            this.txtNumOperacion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Importe";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Operación";
            // 
            // txtAprobacion
            // 
            this.txtAprobacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAprobacion.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAprobacion.Location = new System.Drawing.Point(138, 105);
            this.txtAprobacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAprobacion.Name = "txtAprobacion";
            this.txtAprobacion.Size = new System.Drawing.Size(298, 25);
            this.txtAprobacion.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Num. Tarjeta";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumTarjeta.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarjeta.Location = new System.Drawing.Point(138, 77);
            this.txtNumTarjeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(298, 25);
            this.txtNumTarjeta.TabIndex = 3;
            // 
            // Cbx_Tarjeta_Credito
            // 
            this.Cbx_Tarjeta_Credito.AutoSize = true;
            this.Cbx_Tarjeta_Credito.Location = new System.Drawing.Point(138, 55);
            this.Cbx_Tarjeta_Credito.Name = "Cbx_Tarjeta_Credito";
            this.Cbx_Tarjeta_Credito.Size = new System.Drawing.Size(114, 20);
            this.Cbx_Tarjeta_Credito.TabIndex = 2;
            this.Cbx_Tarjeta_Credito.Text = "Tarjeta Crédtio";
            this.Cbx_Tarjeta_Credito.UseVisualStyleBackColor = true;
            // 
            // cmbTarjetaBanco
            // 
            this.cmbTarjetaBanco.FormattingEnabled = true;
            this.cmbTarjetaBanco.Location = new System.Drawing.Point(138, 27);
            this.cmbTarjetaBanco.Name = "cmbTarjetaBanco";
            this.cmbTarjetaBanco.Size = new System.Drawing.Size(298, 24);
            this.cmbTarjetaBanco.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 66;
            this.label11.Text = "Banco";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "TARJETA";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCheque
            // 
            this.pnlCheque.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlCheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCheque.Controls.Add(this.txtPagoTotalTipoMoneda3);
            this.pnlCheque.Controls.Add(this.lblTotalPagoPesos3);
            this.pnlCheque.Controls.Add(this.txtChequeImporte);
            this.pnlCheque.Controls.Add(this.txtChequeNoCheque);
            this.pnlCheque.Controls.Add(this.txtChequeCuenta);
            this.pnlCheque.Controls.Add(this.cmbChequeBanco);
            this.pnlCheque.Controls.Add(this.label22);
            this.pnlCheque.Controls.Add(this.label21);
            this.pnlCheque.Controls.Add(this.label20);
            this.pnlCheque.Controls.Add(this.label19);
            this.pnlCheque.Controls.Add(this.label15);
            this.pnlCheque.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCheque.Location = new System.Drawing.Point(170, 0);
            this.pnlCheque.Name = "pnlCheque";
            this.pnlCheque.Size = new System.Drawing.Size(219, 202);
            this.pnlCheque.TabIndex = 23;
            this.pnlCheque.TabStop = true;
            this.pnlCheque.Visible = false;
            // 
            // txtPagoTotalTipoMoneda3
            // 
            this.txtPagoTotalTipoMoneda3.dValor = null;
            this.txtPagoTotalTipoMoneda3.Location = new System.Drawing.Point(113, 107);
            this.txtPagoTotalTipoMoneda3.Margin = new System.Windows.Forms.Padding(2);
            this.txtPagoTotalTipoMoneda3.Name = "txtPagoTotalTipoMoneda3";
            this.txtPagoTotalTipoMoneda3.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPagoTotalTipoMoneda3.Size = new System.Drawing.Size(142, 34);
            this.txtPagoTotalTipoMoneda3.TabIndex = 48;
            // 
            // lblTotalPagoPesos3
            // 
            this.lblTotalPagoPesos3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagoPesos3.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagoPesos3.Location = new System.Drawing.Point(5, 102);
            this.lblTotalPagoPesos3.Name = "lblTotalPagoPesos3";
            this.lblTotalPagoPesos3.Size = new System.Drawing.Size(97, 42);
            this.lblTotalPagoPesos3.TabIndex = 47;
            this.lblTotalPagoPesos3.Text = "Total a Pagar";
            this.lblTotalPagoPesos3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChequeImporte
            // 
            this.txtChequeImporte.Location = new System.Drawing.Point(109, 202);
            this.txtChequeImporte.Name = "txtChequeImporte";
            this.txtChequeImporte.ReadOnly = true;
            this.txtChequeImporte.Size = new System.Drawing.Size(175, 23);
            this.txtChequeImporte.TabIndex = 4;
            this.txtChequeImporte.Tag = "DECIMAL2";
            this.txtChequeImporte.Visible = false;
            // 
            // txtChequeNoCheque
            // 
            this.txtChequeNoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequeNoCheque.Location = new System.Drawing.Point(114, 79);
            this.txtChequeNoCheque.MaxLength = 30;
            this.txtChequeNoCheque.Name = "txtChequeNoCheque";
            this.txtChequeNoCheque.Size = new System.Drawing.Size(298, 23);
            this.txtChequeNoCheque.TabIndex = 3;
            // 
            // txtChequeCuenta
            // 
            this.txtChequeCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequeCuenta.Location = new System.Drawing.Point(114, 52);
            this.txtChequeCuenta.MaxLength = 30;
            this.txtChequeCuenta.Name = "txtChequeCuenta";
            this.txtChequeCuenta.Size = new System.Drawing.Size(298, 23);
            this.txtChequeCuenta.TabIndex = 2;
            // 
            // cmbChequeBanco
            // 
            this.cmbChequeBanco.FormattingEnabled = true;
            this.cmbChequeBanco.Location = new System.Drawing.Point(114, 25);
            this.cmbChequeBanco.Name = "cmbChequeBanco";
            this.cmbChequeBanco.Size = new System.Drawing.Size(298, 24);
            this.cmbChequeBanco.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(9, 205);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 17);
            this.label22.TabIndex = 43;
            this.label22.Text = "Importe";
            this.label22.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(14, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 42;
            this.label21.Text = "No. Cheque";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(14, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 17);
            this.label20.TabIndex = 41;
            this.label20.Text = "Cuenta";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(14, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "Banco";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "CHEQUE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTransferencia
            // 
            this.pnlTransferencia.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTransferencia.Controls.Add(this.txtPagoTotalTipoMoneda2);
            this.pnlTransferencia.Controls.Add(this.lblTotalPagoPesos2);
            this.pnlTransferencia.Controls.Add(this.txtTransferenciaImporte);
            this.pnlTransferencia.Controls.Add(this.txtTransferenciaReferencia);
            this.pnlTransferencia.Controls.Add(this.label27);
            this.pnlTransferencia.Controls.Add(this.txtTransferenciaNoTransferencia);
            this.pnlTransferencia.Controls.Add(this.txtTransferenciaCuenta);
            this.pnlTransferencia.Controls.Add(this.cmbTransferenciaBanco);
            this.pnlTransferencia.Controls.Add(this.label23);
            this.pnlTransferencia.Controls.Add(this.label24);
            this.pnlTransferencia.Controls.Add(this.label25);
            this.pnlTransferencia.Controls.Add(this.label26);
            this.pnlTransferencia.Controls.Add(this.label16);
            this.pnlTransferencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTransferencia.Location = new System.Drawing.Point(57, 0);
            this.pnlTransferencia.Name = "pnlTransferencia";
            this.pnlTransferencia.Size = new System.Drawing.Size(113, 202);
            this.pnlTransferencia.TabIndex = 22;
            this.pnlTransferencia.TabStop = true;
            this.pnlTransferencia.Visible = false;
            // 
            // txtPagoTotalTipoMoneda2
            // 
            this.txtPagoTotalTipoMoneda2.dValor = null;
            this.txtPagoTotalTipoMoneda2.Location = new System.Drawing.Point(136, 138);
            this.txtPagoTotalTipoMoneda2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPagoTotalTipoMoneda2.Name = "txtPagoTotalTipoMoneda2";
            this.txtPagoTotalTipoMoneda2.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPagoTotalTipoMoneda2.Size = new System.Drawing.Size(194, 32);
            this.txtPagoTotalTipoMoneda2.TabIndex = 60;
            // 
            // lblTotalPagoPesos2
            // 
            this.lblTotalPagoPesos2.AutoSize = true;
            this.lblTotalPagoPesos2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagoPesos2.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagoPesos2.Location = new System.Drawing.Point(4, 142);
            this.lblTotalPagoPesos2.Name = "lblTotalPagoPesos2";
            this.lblTotalPagoPesos2.Size = new System.Drawing.Size(88, 17);
            this.lblTotalPagoPesos2.TabIndex = 59;
            this.lblTotalPagoPesos2.Text = "Total a Pagar";
            this.lblTotalPagoPesos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTransferenciaImporte
            // 
            this.txtTransferenciaImporte.Location = new System.Drawing.Point(229, 203);
            this.txtTransferenciaImporte.Name = "txtTransferenciaImporte";
            this.txtTransferenciaImporte.ReadOnly = true;
            this.txtTransferenciaImporte.Size = new System.Drawing.Size(195, 23);
            this.txtTransferenciaImporte.TabIndex = 5;
            this.txtTransferenciaImporte.Tag = "DECIMAL2";
            this.txtTransferenciaImporte.Visible = false;
            // 
            // txtTransferenciaReferencia
            // 
            this.txtTransferenciaReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransferenciaReferencia.Location = new System.Drawing.Point(136, 110);
            this.txtTransferenciaReferencia.MaxLength = 30;
            this.txtTransferenciaReferencia.Name = "txtTransferenciaReferencia";
            this.txtTransferenciaReferencia.Size = new System.Drawing.Size(298, 23);
            this.txtTransferenciaReferencia.TabIndex = 4;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(4, 112);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "Referencia";
            // 
            // txtTransferenciaNoTransferencia
            // 
            this.txtTransferenciaNoTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransferenciaNoTransferencia.Location = new System.Drawing.Point(136, 82);
            this.txtTransferenciaNoTransferencia.MaxLength = 30;
            this.txtTransferenciaNoTransferencia.Name = "txtTransferenciaNoTransferencia";
            this.txtTransferenciaNoTransferencia.Size = new System.Drawing.Size(298, 23);
            this.txtTransferenciaNoTransferencia.TabIndex = 3;
            // 
            // txtTransferenciaCuenta
            // 
            this.txtTransferenciaCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransferenciaCuenta.Location = new System.Drawing.Point(136, 54);
            this.txtTransferenciaCuenta.MaxLength = 30;
            this.txtTransferenciaCuenta.Name = "txtTransferenciaCuenta";
            this.txtTransferenciaCuenta.Size = new System.Drawing.Size(298, 23);
            this.txtTransferenciaCuenta.TabIndex = 2;
            // 
            // cmbTransferenciaBanco
            // 
            this.cmbTransferenciaBanco.FormattingEnabled = true;
            this.cmbTransferenciaBanco.Location = new System.Drawing.Point(136, 27);
            this.cmbTransferenciaBanco.Name = "cmbTransferenciaBanco";
            this.cmbTransferenciaBanco.Size = new System.Drawing.Size(298, 24);
            this.cmbTransferenciaBanco.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(90, 210);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 17);
            this.label23.TabIndex = 51;
            this.label23.Text = "Importe";
            this.label23.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(4, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 17);
            this.label24.TabIndex = 50;
            this.label24.Text = "No. Transferencia";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(4, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 17);
            this.label25.TabIndex = 49;
            this.label25.Text = "Cuenta";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(4, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 17);
            this.label26.TabIndex = 48;
            this.label26.Text = "Banco";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "TRANSFERENCIA";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEfectivo
            // 
            this.pnlEfectivo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEfectivo.Controls.Add(this.txtPagoTotalTipoMoneda1);
            this.pnlEfectivo.Controls.Add(this.lblTotalPagoPesos);
            this.pnlEfectivo.Controls.Add(this.txtEfectivoImporte);
            this.pnlEfectivo.Controls.Add(this.label18);
            this.pnlEfectivo.Controls.Add(this.label7);
            this.pnlEfectivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEfectivo.Location = new System.Drawing.Point(0, 0);
            this.pnlEfectivo.Name = "pnlEfectivo";
            this.pnlEfectivo.Size = new System.Drawing.Size(57, 202);
            this.pnlEfectivo.TabIndex = 21;
            this.pnlEfectivo.TabStop = true;
            this.pnlEfectivo.Visible = false;
            // 
            // txtPagoTotalTipoMoneda1
            // 
            this.txtPagoTotalTipoMoneda1.dValor = null;
            this.txtPagoTotalTipoMoneda1.Location = new System.Drawing.Point(119, 34);
            this.txtPagoTotalTipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPagoTotalTipoMoneda1.Name = "txtPagoTotalTipoMoneda1";
            this.txtPagoTotalTipoMoneda1.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPagoTotalTipoMoneda1.Size = new System.Drawing.Size(160, 28);
            this.txtPagoTotalTipoMoneda1.TabIndex = 44;
            // 
            // lblTotalPagoPesos
            // 
            this.lblTotalPagoPesos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagoPesos.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagoPesos.Location = new System.Drawing.Point(2, 27);
            this.lblTotalPagoPesos.Name = "lblTotalPagoPesos";
            this.lblTotalPagoPesos.Size = new System.Drawing.Size(97, 42);
            this.lblTotalPagoPesos.TabIndex = 43;
            this.lblTotalPagoPesos.Text = "Total a Pagar ";
            this.lblTotalPagoPesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEfectivoImporte
            // 
            this.txtEfectivoImporte.Location = new System.Drawing.Point(79, 206);
            this.txtEfectivoImporte.Name = "txtEfectivoImporte";
            this.txtEfectivoImporte.ReadOnly = true;
            this.txtEfectivoImporte.Size = new System.Drawing.Size(160, 23);
            this.txtEfectivoImporte.TabIndex = 1;
            this.txtEfectivoImporte.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(17, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Importe";
            this.label18.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "EFECTIVO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_InformacionPagosCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 249);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_InformacionPagosCxC";
            this.Text = "INFORMACIÓN PAGO";
            this.Load += new System.EventHandler(this.Frm_InformacionPagosCxC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlFormasPago.ResumeLayout(false);
            this.pnlIncobrable.ResumeLayout(false);
            this.pnlIncobrable.PerformLayout();
            this.pnlCheque.ResumeLayout(false);
            this.pnlCheque.PerformLayout();
            this.pnlTransferencia.ResumeLayout(false);
            this.pnlTransferencia.PerformLayout();
            this.pnlEfectivo.ResumeLayout(false);
            this.pnlEfectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFormasPago;
        private System.Windows.Forms.Panel pnlIncobrable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTarjetaImporte;
        private System.Windows.Forms.TextBox txtNumOperacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAprobacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.CheckBox Cbx_Tarjeta_Credito;
        private System.Windows.Forms.ComboBox cmbTarjetaBanco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlCheque;
        private System.Windows.Forms.Label lblTotalPagoPesos3;
        private System.Windows.Forms.TextBox txtChequeImporte;
        private System.Windows.Forms.TextBox txtChequeNoCheque;
        private System.Windows.Forms.TextBox txtChequeCuenta;
        private System.Windows.Forms.ComboBox cmbChequeBanco;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlTransferencia;
        private System.Windows.Forms.Label lblTotalPagoPesos2;
        private System.Windows.Forms.TextBox txtTransferenciaImporte;
        private System.Windows.Forms.TextBox txtTransferenciaReferencia;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtTransferenciaNoTransferencia;
        private System.Windows.Forms.TextBox txtTransferenciaCuenta;
        private System.Windows.Forms.ComboBox cmbTransferenciaBanco;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlEfectivo;
        private System.Windows.Forms.Label lblTotalPagoPesos;
        private System.Windows.Forms.TextBox txtEfectivoImporte;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAceptar;
        private Controles.txt_Moneda_MX txtPagoTotalTipoMoneda4;
        private Controles.txt_Moneda_MX txtPagoTotalTipoMoneda3;
        private Controles.txt_Moneda_MX txtPagoTotalTipoMoneda1;
        private Controles.txt_Moneda_MX txtPagoTotalTipoMoneda2;
    }
}