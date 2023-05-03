namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_NotaCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NotaCargo));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.Txt_Total_Retencion = new System.Windows.Forms.TextBox();
            this.Txt_Porcentaje_Retencion = new System.Windows.Forms.TextBox();
            this.Txt_Total_IVA = new System.Windows.Forms.TextBox();
            this.Txt_Porcentaje_IVA = new System.Windows.Forms.TextBox();
            this.Txt_Subtotal = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.LblUsuarioAutorizo = new System.Windows.Forms.Label();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.txtCuentaCompletaCliente = new System.Windows.Forms.TextBox();
            this.txtClaveCuentaOrigen = new System.Windows.Forms.TextBox();
            this.btnBuscaCuentaOrigen = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.DtpFechaGeneracion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Usuario_Autoriza = new System.Windows.Forms.TextBox();
            this.Txt_Usuario_Genero = new System.Windows.Forms.TextBox();
            this.LblUsuarioGenero = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_Motivo_Nota_Cargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.pnlDetalle);
            this.pnlGeneral.Controls.Add(this.pnlEncabezado);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(809, 364);
            this.pnlGeneral.TabIndex = 0;
            this.pnlGeneral.TabStop = true;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetalle.Controls.Add(this.panel3);
            this.pnlDetalle.Controls.Add(this.TxtObservaciones);
            this.pnlDetalle.Controls.Add(this.label16);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 187);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(809, 177);
            this.pnlDetalle.TabIndex = 8;
            this.pnlDetalle.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(535, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 173);
            this.panel3.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 173);
            this.panel2.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(4, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "TOTAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "SubTotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Porcentaje IVA\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(5, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 53;
            this.label14.Text = "Importe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Porcentaje Retención";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(5, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Total Retención";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total IVA\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.TxtTotal);
            this.panel1.Controls.Add(this.Txt_Total_Retencion);
            this.panel1.Controls.Add(this.Txt_Porcentaje_Retencion);
            this.panel1.Controls.Add(this.Txt_Total_IVA);
            this.panel1.Controls.Add(this.Txt_Porcentaje_IVA);
            this.panel1.Controls.Add(this.Txt_Subtotal);
            this.panel1.Controls.Add(this.TxtImporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 173);
            this.panel1.TabIndex = 57;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(156, 140);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(114, 24);
            this.TxtTotal.TabIndex = 60;
            this.TxtTotal.TabStop = false;
            // 
            // Txt_Total_Retencion
            // 
            this.Txt_Total_Retencion.Location = new System.Drawing.Point(156, 116);
            this.Txt_Total_Retencion.Name = "Txt_Total_Retencion";
            this.Txt_Total_Retencion.ReadOnly = true;
            this.Txt_Total_Retencion.Size = new System.Drawing.Size(114, 24);
            this.Txt_Total_Retencion.TabIndex = 59;
            this.Txt_Total_Retencion.TabStop = false;
            // 
            // Txt_Porcentaje_Retencion
            // 
            this.Txt_Porcentaje_Retencion.Location = new System.Drawing.Point(156, 93);
            this.Txt_Porcentaje_Retencion.Name = "Txt_Porcentaje_Retencion";
            this.Txt_Porcentaje_Retencion.Size = new System.Drawing.Size(114, 24);
            this.Txt_Porcentaje_Retencion.TabIndex = 58;
            this.Txt_Porcentaje_Retencion.TabStop = false;
            this.Txt_Porcentaje_Retencion.Enter += new System.EventHandler(this.Txt_Porcentaje_Retencion_Enter);
            this.Txt_Porcentaje_Retencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Porcentaje_Retencion_KeyPress);
            this.Txt_Porcentaje_Retencion.Leave += new System.EventHandler(this.Txt_Porcentaje_Retencion_Leave);
            // 
            // Txt_Total_IVA
            // 
            this.Txt_Total_IVA.Location = new System.Drawing.Point(155, 70);
            this.Txt_Total_IVA.Name = "Txt_Total_IVA";
            this.Txt_Total_IVA.ReadOnly = true;
            this.Txt_Total_IVA.Size = new System.Drawing.Size(114, 24);
            this.Txt_Total_IVA.TabIndex = 57;
            this.Txt_Total_IVA.TabStop = false;
            // 
            // Txt_Porcentaje_IVA
            // 
            this.Txt_Porcentaje_IVA.Location = new System.Drawing.Point(155, 47);
            this.Txt_Porcentaje_IVA.Name = "Txt_Porcentaje_IVA";
            this.Txt_Porcentaje_IVA.Size = new System.Drawing.Size(114, 24);
            this.Txt_Porcentaje_IVA.TabIndex = 56;
            this.Txt_Porcentaje_IVA.TabStop = false;
            this.Txt_Porcentaje_IVA.Enter += new System.EventHandler(this.Txt_Porcentaje_IVA_Enter);
            this.Txt_Porcentaje_IVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Porcentaje_IVA_KeyPress);
            this.Txt_Porcentaje_IVA.Leave += new System.EventHandler(this.Txt_Porcentaje_IVA_Leave);
            // 
            // Txt_Subtotal
            // 
            this.Txt_Subtotal.Location = new System.Drawing.Point(155, 24);
            this.Txt_Subtotal.Name = "Txt_Subtotal";
            this.Txt_Subtotal.ReadOnly = true;
            this.Txt_Subtotal.Size = new System.Drawing.Size(114, 24);
            this.Txt_Subtotal.TabIndex = 55;
            this.Txt_Subtotal.TabStop = false;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Location = new System.Drawing.Point(155, 1);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(114, 23);
            this.TxtImporte.TabIndex = 0;
            this.TxtImporte.Enter += new System.EventHandler(this.TxtImporte_Enter);
            this.TxtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImporte_KeyPress);
            this.TxtImporte.Leave += new System.EventHandler(this.TxtImporte_Leave);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservaciones.Location = new System.Drawing.Point(19, 30);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(514, 86);
            this.TxtObservaciones.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 16);
            this.label16.TabIndex = 60;
            this.label16.Text = "Observaciones";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.txtCuentaOrigen);
            this.pnlEncabezado.Controls.Add(this.label17);
            this.pnlEncabezado.Controls.Add(this.txtFactura);
            this.pnlEncabezado.Controls.Add(this.LblUsuarioAutorizo);
            this.pnlEncabezado.Controls.Add(this.BtnFactura);
            this.pnlEncabezado.Controls.Add(this.txtCuentaCompletaCliente);
            this.pnlEncabezado.Controls.Add(this.txtClaveCuentaOrigen);
            this.pnlEncabezado.Controls.Add(this.btnBuscaCuentaOrigen);
            this.pnlEncabezado.Controls.Add(this.label29);
            this.pnlEncabezado.Controls.Add(this.DtpFechaGeneracion);
            this.pnlEncabezado.Controls.Add(this.label8);
            this.pnlEncabezado.Controls.Add(this.Txt_Usuario_Autoriza);
            this.pnlEncabezado.Controls.Add(this.Txt_Usuario_Genero);
            this.pnlEncabezado.Controls.Add(this.LblUsuarioGenero);
            this.pnlEncabezado.Controls.Add(this.btnBuscaCliente);
            this.pnlEncabezado.Controls.Add(this.txtCliente);
            this.pnlEncabezado.Controls.Add(this.txtClaveCliente);
            this.pnlEncabezado.Controls.Add(this.label4);
            this.pnlEncabezado.Controls.Add(this.txtClave);
            this.pnlEncabezado.Controls.Add(this.cbxAlmacen);
            this.pnlEncabezado.Controls.Add(this.label3);
            this.pnlEncabezado.Controls.Add(this.btnBuscarOficina);
            this.pnlEncabezado.Controls.Add(this.label2);
            this.pnlEncabezado.Controls.Add(this.Cbx_Motivo_Nota_Cargo);
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Controls.Add(this.txtClaveOficina);
            this.pnlEncabezado.Controls.Add(this.label5);
            this.pnlEncabezado.Controls.Add(this.txtOficina);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(809, 187);
            this.pnlEncabezado.TabIndex = 1;
            this.pnlEncabezado.TabStop = true;
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaOrigen.Location = new System.Drawing.Point(464, 97);
            this.txtCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.ReadOnly = true;
            this.txtCuentaOrigen.Size = new System.Drawing.Size(267, 24);
            this.txtCuentaOrigen.TabIndex = 55;
            this.txtCuentaOrigen.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 54;
            this.label17.Text = "Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(123, 97);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(114, 24);
            this.txtFactura.TabIndex = 52;
            // 
            // LblUsuarioAutorizo
            // 
            this.LblUsuarioAutorizo.AutoSize = true;
            this.LblUsuarioAutorizo.Location = new System.Drawing.Point(407, 156);
            this.LblUsuarioAutorizo.Name = "LblUsuarioAutorizo";
            this.LblUsuarioAutorizo.Size = new System.Drawing.Size(106, 17);
            this.LblUsuarioAutorizo.TabIndex = 18;
            this.LblUsuarioAutorizo.Text = "Usuario Autoriza";
            this.LblUsuarioAutorizo.Visible = false;
            // 
            // BtnFactura
            // 
            this.BtnFactura.Image = ((System.Drawing.Image)(resources.GetObject("BtnFactura.Image")));
            this.BtnFactura.Location = new System.Drawing.Point(239, 97);
            this.BtnFactura.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(34, 23);
            this.BtnFactura.TabIndex = 4;
            this.BtnFactura.UseVisualStyleBackColor = true;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // txtCuentaCompletaCliente
            // 
            this.txtCuentaCompletaCliente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCompletaCliente.Location = new System.Drawing.Point(464, 97);
            this.txtCuentaCompletaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuentaCompletaCliente.Name = "txtCuentaCompletaCliente";
            this.txtCuentaCompletaCliente.ReadOnly = true;
            this.txtCuentaCompletaCliente.Size = new System.Drawing.Size(267, 24);
            this.txtCuentaCompletaCliente.TabIndex = 51;
            this.txtCuentaCompletaCliente.TabStop = false;
            // 
            // txtClaveCuentaOrigen
            // 
            this.txtClaveCuentaOrigen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCuentaOrigen.Location = new System.Drawing.Point(410, 97);
            this.txtClaveCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClaveCuentaOrigen.MaxLength = 5;
            this.txtClaveCuentaOrigen.Name = "txtClaveCuentaOrigen";
            this.txtClaveCuentaOrigen.ReadOnly = true;
            this.txtClaveCuentaOrigen.Size = new System.Drawing.Size(50, 24);
            this.txtClaveCuentaOrigen.TabIndex = 48;
            this.txtClaveCuentaOrigen.TabStop = false;
            this.txtClaveCuentaOrigen.Tag = "ENTERO";
            // 
            // btnBuscaCuentaOrigen
            // 
            this.btnBuscaCuentaOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCuentaOrigen.Image")));
            this.btnBuscaCuentaOrigen.Location = new System.Drawing.Point(733, 96);
            this.btnBuscaCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaCuentaOrigen.Name = "btnBuscaCuentaOrigen";
            this.btnBuscaCuentaOrigen.Size = new System.Drawing.Size(28, 26);
            this.btnBuscaCuentaOrigen.TabIndex = 5;
            this.btnBuscaCuentaOrigen.UseVisualStyleBackColor = true;
            this.btnBuscaCuentaOrigen.Click += new System.EventHandler(this.btnBuscaCuentaOrigen_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Blue;
            this.label29.Location = new System.Drawing.Point(301, 100);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 17);
            this.label29.TabIndex = 50;
            this.label29.Text = "Cuenta Bancaria";
            // 
            // DtpFechaGeneracion
            // 
            this.DtpFechaGeneracion.Enabled = false;
            this.DtpFechaGeneracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaGeneracion.Location = new System.Drawing.Point(668, 11);
            this.DtpFechaGeneracion.Name = "DtpFechaGeneracion";
            this.DtpFechaGeneracion.Size = new System.Drawing.Size(122, 24);
            this.DtpFechaGeneracion.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fecha Generación";
            // 
            // Txt_Usuario_Autoriza
            // 
            this.Txt_Usuario_Autoriza.Location = new System.Drawing.Point(518, 153);
            this.Txt_Usuario_Autoriza.Name = "Txt_Usuario_Autoriza";
            this.Txt_Usuario_Autoriza.ReadOnly = true;
            this.Txt_Usuario_Autoriza.Size = new System.Drawing.Size(251, 24);
            this.Txt_Usuario_Autoriza.TabIndex = 21;
            this.Txt_Usuario_Autoriza.TabStop = false;
            this.Txt_Usuario_Autoriza.Visible = false;
            // 
            // Txt_Usuario_Genero
            // 
            this.Txt_Usuario_Genero.Location = new System.Drawing.Point(124, 153);
            this.Txt_Usuario_Genero.Name = "Txt_Usuario_Genero";
            this.Txt_Usuario_Genero.ReadOnly = true;
            this.Txt_Usuario_Genero.Size = new System.Drawing.Size(251, 24);
            this.Txt_Usuario_Genero.TabIndex = 20;
            this.Txt_Usuario_Genero.TabStop = false;
            this.Txt_Usuario_Genero.Visible = false;
            // 
            // LblUsuarioGenero
            // 
            this.LblUsuarioGenero.AutoSize = true;
            this.LblUsuarioGenero.Location = new System.Drawing.Point(16, 156);
            this.LblUsuarioGenero.Name = "LblUsuarioGenero";
            this.LblUsuarioGenero.Size = new System.Drawing.Size(101, 17);
            this.LblUsuarioGenero.TabIndex = 19;
            this.LblUsuarioGenero.Text = "Usuario Generó";
            this.LblUsuarioGenero.Visible = false;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(533, 66);
            this.btnBuscaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaCliente.TabIndex = 3;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(177, 66);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(354, 24);
            this.txtCliente.TabIndex = 16;
            this.txtCliente.TabStop = false;
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.Location = new System.Drawing.Point(124, 66);
            this.txtClaveCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.ReadOnly = true;
            this.txtClaveCliente.Size = new System.Drawing.Size(50, 24);
            this.txtClaveCliente.TabIndex = 15;
            this.txtClaveCliente.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(124, 10);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(100, 24);
            this.txtClave.TabIndex = 3;
            this.txtClave.TabStop = false;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(571, 126);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(196, 24);
            this.cbxAlmacen.TabIndex = 7;
            this.cbxAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAlmacen_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Almacén";
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(374, 125);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarOficina.TabIndex = 6;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            // 
            // Cbx_Motivo_Nota_Cargo
            // 
            this.Cbx_Motivo_Nota_Cargo.FormattingEnabled = true;
            this.Cbx_Motivo_Nota_Cargo.Location = new System.Drawing.Point(123, 38);
            this.Cbx_Motivo_Nota_Cargo.Name = "Cbx_Motivo_Nota_Cargo";
            this.Cbx_Motivo_Nota_Cargo.Size = new System.Drawing.Size(251, 24);
            this.Cbx_Motivo_Nota_Cargo.TabIndex = 2;
            this.Cbx_Motivo_Nota_Cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbx_Motivo_Nota_Cargo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivo de \r\nNota de Cargo";
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(123, 126);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficina.TabIndex = 5;
            this.txtClaveOficina.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Oficina";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(177, 126);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(196, 24);
            this.txtOficina.TabIndex = 7;
            this.txtOficina.TabStop = false;
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
            // 
            // Frm_NotaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 441);
            this.Controls.Add(this.pnlGeneral);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_NotaCargo";
            this.Text = "NOTA DE CARGO";
            this.Controls.SetChildIndex(this.pnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_Motivo_Nota_Cargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Button btnBuscarOficina;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.DateTimePicker DtpFechaGeneracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Usuario_Autoriza;
        private System.Windows.Forms.TextBox Txt_Usuario_Genero;
        private System.Windows.Forms.Label LblUsuarioGenero;
        private System.Windows.Forms.Label LblUsuarioAutorizo;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCuentaCompletaCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClaveCuentaOrigen;
        private System.Windows.Forms.Button btnBuscaCuentaOrigen;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox Txt_Total_Retencion;
        private System.Windows.Forms.TextBox Txt_Porcentaje_Retencion;
        private System.Windows.Forms.TextBox Txt_Total_IVA;
        private System.Windows.Forms.TextBox Txt_Porcentaje_IVA;
        private System.Windows.Forms.TextBox Txt_Subtotal;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnFactura;
        public System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
    }
}