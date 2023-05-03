namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_AnticipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnticipoCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlGeneral = new System.Windows.Forms.Panel();
            this.GrdDatos = new System.Windows.Forms.DataGridView();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.PnlCuentas = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.BtnBuscaCuentaOrigen = new System.Windows.Forms.Button();
            this.BtnBuscaCuentaDeposito = new System.Windows.Forms.Button();
            this.TxtClaveCuentaOrigen = new System.Windows.Forms.TextBox();
            this.TxtCuentaDeposito = new System.Windows.Forms.TextBox();
            this.TxtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.TxtClaveCuentaDeposito = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.PnlIntermedio = new System.Windows.Forms.Panel();
            this.TxtMonto = new ProbeMedic.Controles.txt_Moneda();
            this.ucMotivosAnticipoCliente1 = new ProbeMedic.Controles.ucMotivosAnticipoCliente();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnBuscaCliente = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtClaveCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.K_Anticipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cuenta_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Motivo_Anticipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Autorizo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Aprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Aplicado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.F_Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Autorizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.F_Autorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Cancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.PnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
            this.PnlEncabezado.SuspendLayout();
            this.PnlCuentas.SuspendLayout();
            this.PnlIntermedio.SuspendLayout();
            this.PnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGeneral
            // 
            this.PnlGeneral.Controls.Add(this.GrdDatos);
            this.PnlGeneral.Controls.Add(this.PnlEncabezado);
            this.PnlGeneral.Controls.Add(this.PnlIntermedio);
            this.PnlGeneral.Controls.Add(this.PnlSuperior);
            this.PnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.PnlGeneral.Name = "PnlGeneral";
            this.PnlGeneral.Size = new System.Drawing.Size(1006, 494);
            this.PnlGeneral.TabIndex = 0;
            this.PnlGeneral.TabStop = true;
            // 
            // GrdDatos
            // 
            this.GrdDatos.AllowUserToAddRows = false;
            this.GrdDatos.AllowUserToDeleteRows = false;
            this.GrdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Anticipo_Cliente,
            this.D_Cliente,
            this.D_Oficina,
            this.D_Almacen,
            this.F_Generacion,
            this.K_Cuenta_Empresa,
            this.Numero_Cuenta,
            this.Monto_Total,
            this.D_Motivo_Anticipo_Cliente,
            this.D_Usuario_Genero,
            this.D_Usuario_Autorizo,
            this.F_Aprobacion,
            this.B_Aplicado,
            this.F_Aplicacion,
            this.B_Autorizado,
            this.F_Autorizacion,
            this.B_Cancelado});
            this.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDatos.Location = new System.Drawing.Point(0, 183);
            this.GrdDatos.MultiSelect = false;
            this.GrdDatos.Name = "GrdDatos";
            this.GrdDatos.ReadOnly = true;
            this.GrdDatos.Size = new System.Drawing.Size(1006, 311);
            this.GrdDatos.TabIndex = 51;
            this.GrdDatos.TabStop = false;
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.Controls.Add(this.PnlCuentas);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(0, 110);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(1006, 73);
            this.PnlEncabezado.TabIndex = 6;
            this.PnlEncabezado.TabStop = true;
            // 
            // PnlCuentas
            // 
            this.PnlCuentas.Controls.Add(this.label30);
            this.PnlCuentas.Controls.Add(this.BtnBuscaCuentaOrigen);
            this.PnlCuentas.Controls.Add(this.BtnBuscaCuentaDeposito);
            this.PnlCuentas.Controls.Add(this.TxtClaveCuentaOrigen);
            this.PnlCuentas.Controls.Add(this.TxtCuentaDeposito);
            this.PnlCuentas.Controls.Add(this.TxtCuentaOrigen);
            this.PnlCuentas.Controls.Add(this.TxtClaveCuentaDeposito);
            this.PnlCuentas.Controls.Add(this.label29);
            this.PnlCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCuentas.Location = new System.Drawing.Point(0, 0);
            this.PnlCuentas.Name = "PnlCuentas";
            this.PnlCuentas.Size = new System.Drawing.Size(1006, 73);
            this.PnlCuentas.TabIndex = 7;
            this.PnlCuentas.TabStop = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Green;
            this.label30.Location = new System.Drawing.Point(24, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(129, 17);
            this.label30.TabIndex = 41;
            this.label30.Text = "Cuenta de Depósito";
            // 
            // BtnBuscaCuentaOrigen
            // 
            this.BtnBuscaCuentaOrigen.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscaCuentaOrigen.Image")));
            this.BtnBuscaCuentaOrigen.Location = new System.Drawing.Point(620, 5);
            this.BtnBuscaCuentaOrigen.Name = "BtnBuscaCuentaOrigen";
            this.BtnBuscaCuentaOrigen.Size = new System.Drawing.Size(28, 28);
            this.BtnBuscaCuentaOrigen.TabIndex = 8;
            this.BtnBuscaCuentaOrigen.UseVisualStyleBackColor = true;
            this.BtnBuscaCuentaOrigen.Click += new System.EventHandler(this.btnBuscaCuentaOrigen_Click);
            // 
            // BtnBuscaCuentaDeposito
            // 
            this.BtnBuscaCuentaDeposito.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscaCuentaDeposito.Image")));
            this.BtnBuscaCuentaDeposito.Location = new System.Drawing.Point(621, 40);
            this.BtnBuscaCuentaDeposito.Name = "BtnBuscaCuentaDeposito";
            this.BtnBuscaCuentaDeposito.Size = new System.Drawing.Size(28, 25);
            this.BtnBuscaCuentaDeposito.TabIndex = 9;
            this.BtnBuscaCuentaDeposito.UseVisualStyleBackColor = true;
            this.BtnBuscaCuentaDeposito.Click += new System.EventHandler(this.btnBuscaCuentaDeposito_Click);
            // 
            // TxtClaveCuentaOrigen
            // 
            this.TxtClaveCuentaOrigen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClaveCuentaOrigen.Location = new System.Drawing.Point(157, 6);
            this.TxtClaveCuentaOrigen.MaxLength = 5;
            this.TxtClaveCuentaOrigen.Name = "TxtClaveCuentaOrigen";
            this.TxtClaveCuentaOrigen.ReadOnly = true;
            this.TxtClaveCuentaOrigen.Size = new System.Drawing.Size(50, 24);
            this.TxtClaveCuentaOrigen.TabIndex = 42;
            this.TxtClaveCuentaOrigen.TabStop = false;
            this.TxtClaveCuentaOrigen.Tag = "ENTERO";
            // 
            // TxtCuentaDeposito
            // 
            this.TxtCuentaDeposito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuentaDeposito.Location = new System.Drawing.Point(208, 40);
            this.TxtCuentaDeposito.Name = "TxtCuentaDeposito";
            this.TxtCuentaDeposito.ReadOnly = true;
            this.TxtCuentaDeposito.Size = new System.Drawing.Size(411, 24);
            this.TxtCuentaDeposito.TabIndex = 39;
            this.TxtCuentaDeposito.TabStop = false;
            // 
            // TxtCuentaOrigen
            // 
            this.TxtCuentaOrigen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuentaOrigen.Location = new System.Drawing.Point(209, 6);
            this.TxtCuentaOrigen.Name = "TxtCuentaOrigen";
            this.TxtCuentaOrigen.ReadOnly = true;
            this.TxtCuentaOrigen.Size = new System.Drawing.Size(409, 24);
            this.TxtCuentaOrigen.TabIndex = 43;
            this.TxtCuentaOrigen.TabStop = false;
            // 
            // TxtClaveCuentaDeposito
            // 
            this.TxtClaveCuentaDeposito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClaveCuentaDeposito.Location = new System.Drawing.Point(156, 40);
            this.TxtClaveCuentaDeposito.MaxLength = 5;
            this.TxtClaveCuentaDeposito.Name = "TxtClaveCuentaDeposito";
            this.TxtClaveCuentaDeposito.ReadOnly = true;
            this.TxtClaveCuentaDeposito.Size = new System.Drawing.Size(50, 24);
            this.TxtClaveCuentaDeposito.TabIndex = 38;
            this.TxtClaveCuentaDeposito.TabStop = false;
            this.TxtClaveCuentaDeposito.Tag = "ENTERO";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Blue;
            this.label29.Location = new System.Drawing.Point(24, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 17);
            this.label29.TabIndex = 44;
            this.label29.Text = "Cuenta Origen";
            // 
            // PnlIntermedio
            // 
            this.PnlIntermedio.Controls.Add(this.TxtMonto);
            this.PnlIntermedio.Controls.Add(this.ucMotivosAnticipoCliente1);
            this.PnlIntermedio.Controls.Add(this.TxtObservaciones);
            this.PnlIntermedio.Controls.Add(this.label18);
            this.PnlIntermedio.Controls.Add(this.label1);
            this.PnlIntermedio.Controls.Add(this.label4);
            this.PnlIntermedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlIntermedio.Location = new System.Drawing.Point(0, 37);
            this.PnlIntermedio.Name = "PnlIntermedio";
            this.PnlIntermedio.Size = new System.Drawing.Size(1006, 73);
            this.PnlIntermedio.TabIndex = 2;
            this.PnlIntermedio.TabStop = true;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(157, 37);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(139, 28);
            this.TxtMonto.TabIndex = 4;
            // 
            // ucMotivosAnticipoCliente1
            // 
            this.ucMotivosAnticipoCliente1.Location = new System.Drawing.Point(154, 3);
            this.ucMotivosAnticipoCliente1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucMotivosAnticipoCliente1.Name = "ucMotivosAnticipoCliente1";
            this.ucMotivosAnticipoCliente1.Size = new System.Drawing.Size(342, 34);
            this.ucMotivosAnticipoCliente1.TabIndex = 40;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservaciones.Location = new System.Drawing.Point(608, 7);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(374, 53);
            this.TxtObservaciones.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(24, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Monto Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(505, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Motivo Anticipo";
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.Controls.Add(this.BtnBuscaCliente);
            this.PnlSuperior.Controls.Add(this.TxtCliente);
            this.PnlSuperior.Controls.Add(this.TxtClaveCliente);
            this.PnlSuperior.Controls.Add(this.label3);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(1006, 37);
            this.PnlSuperior.TabIndex = 1;
            this.PnlSuperior.TabStop = true;
            // 
            // BtnBuscaCliente
            // 
            this.BtnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscaCliente.Image")));
            this.BtnBuscaCliente.Location = new System.Drawing.Point(568, 7);
            this.BtnBuscaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscaCliente.Name = "BtnBuscaCliente";
            this.BtnBuscaCliente.Size = new System.Drawing.Size(32, 24);
            this.BtnBuscaCliente.TabIndex = 1;
            this.BtnBuscaCliente.UseVisualStyleBackColor = true;
            this.BtnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(212, 7);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(354, 24);
            this.TxtCliente.TabIndex = 36;
            this.TxtCliente.TabStop = false;
            // 
            // TxtClaveCliente
            // 
            this.TxtClaveCliente.Location = new System.Drawing.Point(158, 7);
            this.TxtClaveCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtClaveCliente.Name = "TxtClaveCliente";
            this.TxtClaveCliente.ReadOnly = true;
            this.TxtClaveCliente.Size = new System.Drawing.Size(50, 24);
            this.TxtClaveCliente.TabIndex = 35;
            this.TxtClaveCliente.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cliente";
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
            // K_Anticipo_Cliente
            // 
            this.K_Anticipo_Cliente.DataPropertyName = "K_Anticipo_Cliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Anticipo_Cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.K_Anticipo_Cliente.HeaderText = "ID Anticipo";
            this.K_Anticipo_Cliente.MinimumWidth = 70;
            this.K_Anticipo_Cliente.Name = "K_Anticipo_Cliente";
            this.K_Anticipo_Cliente.ReadOnly = true;
            this.K_Anticipo_Cliente.Width = 99;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.MinimumWidth = 40;
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 73;
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
            // F_Generacion
            // 
            this.F_Generacion.DataPropertyName = "F_Generacion";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Generacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_Generacion.HeaderText = "Fec. Generación";
            this.F_Generacion.MinimumWidth = 50;
            this.F_Generacion.Name = "F_Generacion";
            this.F_Generacion.ReadOnly = true;
            this.F_Generacion.Width = 130;
            // 
            // K_Cuenta_Empresa
            // 
            this.K_Cuenta_Empresa.DataPropertyName = "K_Cuenta_Empresa";
            this.K_Cuenta_Empresa.HeaderText = "Cuenta Empresa";
            this.K_Cuenta_Empresa.MinimumWidth = 40;
            this.K_Cuenta_Empresa.Name = "K_Cuenta_Empresa";
            this.K_Cuenta_Empresa.ReadOnly = true;
            this.K_Cuenta_Empresa.Width = 134;
            // 
            // Numero_Cuenta
            // 
            this.Numero_Cuenta.DataPropertyName = "Numero_Cuenta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Numero_Cuenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.Numero_Cuenta.HeaderText = "No. Cuenta";
            this.Numero_Cuenta.Name = "Numero_Cuenta";
            this.Numero_Cuenta.ReadOnly = true;
            this.Numero_Cuenta.Visible = false;
            this.Numero_Cuenta.Width = 102;
            // 
            // Monto_Total
            // 
            this.Monto_Total.DataPropertyName = "Monto_Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Monto_Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            this.Monto_Total.Width = 106;
            // 
            // D_Motivo_Anticipo_Cliente
            // 
            this.D_Motivo_Anticipo_Cliente.DataPropertyName = "D_Motivo_Anticipo_Cliente";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.D_Motivo_Anticipo_Cliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.D_Motivo_Anticipo_Cliente.HeaderText = "Motivo";
            this.D_Motivo_Anticipo_Cliente.Name = "D_Motivo_Anticipo_Cliente";
            this.D_Motivo_Anticipo_Cliente.ReadOnly = true;
            this.D_Motivo_Anticipo_Cliente.Width = 74;
            // 
            // D_Usuario_Genero
            // 
            this.D_Usuario_Genero.DataPropertyName = "D_Usuario_Genero";
            this.D_Usuario_Genero.HeaderText = "Usuario Generó";
            this.D_Usuario_Genero.Name = "D_Usuario_Genero";
            this.D_Usuario_Genero.ReadOnly = true;
            this.D_Usuario_Genero.Visible = false;
            this.D_Usuario_Genero.Width = 126;
            // 
            // D_Usuario_Autorizo
            // 
            this.D_Usuario_Autorizo.DataPropertyName = "D_Usuario_Autorizo";
            this.D_Usuario_Autorizo.HeaderText = "Usuario Autoriza";
            this.D_Usuario_Autorizo.Name = "D_Usuario_Autorizo";
            this.D_Usuario_Autorizo.ReadOnly = true;
            this.D_Usuario_Autorizo.Width = 131;
            // 
            // F_Aprobacion
            // 
            this.F_Aprobacion.DataPropertyName = "F_Aprobacion";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Aprobacion.DefaultCellStyle = dataGridViewCellStyle7;
            this.F_Aprobacion.HeaderText = "Fec. Aprobación";
            this.F_Aprobacion.Name = "F_Aprobacion";
            this.F_Aprobacion.ReadOnly = true;
            this.F_Aprobacion.Visible = false;
            this.F_Aprobacion.Width = 131;
            // 
            // B_Aplicado
            // 
            this.B_Aplicado.DataPropertyName = "B_Aplicado";
            this.B_Aplicado.HeaderText = "Aplicado";
            this.B_Aplicado.Name = "B_Aplicado";
            this.B_Aplicado.ReadOnly = true;
            this.B_Aplicado.Width = 64;
            // 
            // F_Aplicacion
            // 
            this.F_Aplicacion.DataPropertyName = "F_Aplicacion";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Aplicacion.DefaultCellStyle = dataGridViewCellStyle8;
            this.F_Aplicacion.HeaderText = "Fec. Aplicación";
            this.F_Aplicacion.Name = "F_Aplicacion";
            this.F_Aplicacion.ReadOnly = true;
            this.F_Aplicacion.Visible = false;
            this.F_Aplicacion.Width = 121;
            // 
            // B_Autorizado
            // 
            this.B_Autorizado.DataPropertyName = "B_Autorizado";
            this.B_Autorizado.HeaderText = "Autorizado";
            this.B_Autorizado.Name = "B_Autorizado";
            this.B_Autorizado.ReadOnly = true;
            this.B_Autorizado.Width = 79;
            // 
            // F_Autorizacion
            // 
            this.F_Autorizacion.DataPropertyName = "F_Autorizacion";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Autorizacion.DefaultCellStyle = dataGridViewCellStyle9;
            this.F_Autorizacion.HeaderText = "Fec. Autorización";
            this.F_Autorizacion.Name = "F_Autorizacion";
            this.F_Autorizacion.ReadOnly = true;
            this.F_Autorizacion.Width = 136;
            // 
            // B_Cancelado
            // 
            this.B_Cancelado.DataPropertyName = "B_Cancelado";
            this.B_Cancelado.HeaderText = "Cancelado";
            this.B_Cancelado.Name = "B_Cancelado";
            this.B_Cancelado.ReadOnly = true;
            this.B_Cancelado.Width = 77;
            // 
            // Frm_AnticipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 571);
            this.Controls.Add(this.PnlGeneral);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_AnticipoCliente";
            this.Text = "ANTICIPO CLIENTE";
            this.Controls.SetChildIndex(this.PnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.PnlGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlCuentas.ResumeLayout(false);
            this.PnlCuentas.PerformLayout();
            this.PnlIntermedio.ResumeLayout(false);
            this.PnlIntermedio.PerformLayout();
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGeneral;
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscaCliente;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtClaveCliente;
        private System.Windows.Forms.Panel PnlIntermedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlEncabezado;
        private System.Windows.Forms.Button BtnBuscaCuentaOrigen;
        private System.Windows.Forms.TextBox TxtClaveCuentaOrigen;
        private System.Windows.Forms.TextBox TxtCuentaOrigen;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TxtClaveCuentaDeposito;
        private System.Windows.Forms.TextBox TxtCuentaDeposito;
        private System.Windows.Forms.Button BtnBuscaCuentaDeposito;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel PnlCuentas;
        private System.Windows.Forms.DataGridView GrdDatos;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private Controles.ucMotivosAnticipoCliente ucMotivosAnticipoCliente1;
        private Controles.txt_Moneda TxtMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Anticipo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cuenta_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Motivo_Anticipo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Autorizo;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Aprobacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Aplicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Aplicacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Autorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Autorizacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Cancelado;
    }
}