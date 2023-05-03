namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_Cheque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cheque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCheque = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Posfechado = new System.Windows.Forms.DateTimePicker();
            this.cbx_Posfechado = new System.Windows.Forms.CheckBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtClaveCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChequeImporte = new System.Windows.Forms.TextBox();
            this.txtChequeNoCheque = new System.Windows.Forms.TextBox();
            this.txtChequeCuenta = new System.Windows.Forms.TextBox();
            this.cmbChequeBanco = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Usuario_Captura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucOficinas1 = new ProbeMedic.Controles.ucOficinas();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_No_Cheque = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.K_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estado_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Posfechado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Devuelto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Aplicado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.F_Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Posfechado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Aplico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlCheque.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDatos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 601);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.BackgroundColor = System.Drawing.Color.Silver;
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Cheque,
            this.K_Cliente,
            this.D_Cliente,
            this.D_Estado_Cheque,
            this.B_Posfechado,
            this.B_Devuelto,
            this.B_Aplicado,
            this.F_Alta,
            this.F_Aplicacion,
            this.D_Banco,
            this.Numero_Cuenta,
            this.Numero_Cheque,
            this.Monto,
            this.D_Oficina,
            this.F_Posfechado,
            this.D_Usuario_Registro,
            this.D_Usuario_Aplico});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 340);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1443, 261);
            this.grdDatos.TabIndex = 430;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlCheque);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 340);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // pnlCheque
            // 
            this.pnlCheque.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlCheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCheque.Controls.Add(this.label3);
            this.pnlCheque.Controls.Add(this.dtp_Fecha_Posfechado);
            this.pnlCheque.Controls.Add(this.cbx_Posfechado);
            this.pnlCheque.Controls.Add(this.btnBuscaCliente);
            this.pnlCheque.Controls.Add(this.TxtCliente);
            this.pnlCheque.Controls.Add(this.TxtClaveCliente);
            this.pnlCheque.Controls.Add(this.label2);
            this.pnlCheque.Controls.Add(this.txtChequeImporte);
            this.pnlCheque.Controls.Add(this.txtChequeNoCheque);
            this.pnlCheque.Controls.Add(this.txtChequeCuenta);
            this.pnlCheque.Controls.Add(this.cmbChequeBanco);
            this.pnlCheque.Controls.Add(this.label22);
            this.pnlCheque.Controls.Add(this.label21);
            this.pnlCheque.Controls.Add(this.label20);
            this.pnlCheque.Controls.Add(this.label19);
            this.pnlCheque.Controls.Add(this.label15);
            this.pnlCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheque.Location = new System.Drawing.Point(0, 100);
            this.pnlCheque.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCheque.Name = "pnlCheque";
            this.pnlCheque.Size = new System.Drawing.Size(1443, 240);
            this.pnlCheque.TabIndex = 3;
            this.pnlCheque.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Fecha Posfechado";
            // 
            // dtp_Fecha_Posfechado
            // 
            this.dtp_Fecha_Posfechado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha_Posfechado.Location = new System.Drawing.Point(1064, 189);
            this.dtp_Fecha_Posfechado.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Fecha_Posfechado.Name = "dtp_Fecha_Posfechado";
            this.dtp_Fecha_Posfechado.Size = new System.Drawing.Size(143, 28);
            this.dtp_Fecha_Posfechado.TabIndex = 10;
            // 
            // cbx_Posfechado
            // 
            this.cbx_Posfechado.AutoSize = true;
            this.cbx_Posfechado.Location = new System.Drawing.Point(900, 153);
            this.cbx_Posfechado.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Posfechado.Name = "cbx_Posfechado";
            this.cbx_Posfechado.Size = new System.Drawing.Size(116, 25);
            this.cbx_Posfechado.TabIndex = 9;
            this.cbx_Posfechado.Text = "Posfechado";
            this.cbx_Posfechado.UseVisualStyleBackColor = true;
            this.cbx_Posfechado.CheckedChanged += new System.EventHandler(this.cbx_Posfechado_CheckedChanged);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(694, 38);
            this.btnBuscaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(40, 32);
            this.btnBuscaCliente.TabIndex = 4;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(221, 38);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(466, 30);
            this.TxtCliente.TabIndex = 47;
            this.TxtCliente.TabStop = false;
            // 
            // TxtClaveCliente
            // 
            this.TxtClaveCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClaveCliente.Location = new System.Drawing.Point(148, 38);
            this.TxtClaveCliente.Name = "TxtClaveCliente";
            this.TxtClaveCliente.ReadOnly = true;
            this.TxtClaveCliente.Size = new System.Drawing.Size(67, 30);
            this.TxtClaveCliente.TabIndex = 46;
            this.TxtClaveCliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cliente";
            // 
            // txtChequeImporte
            // 
            this.txtChequeImporte.Location = new System.Drawing.Point(147, 185);
            this.txtChequeImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtChequeImporte.Name = "txtChequeImporte";
            this.txtChequeImporte.Size = new System.Drawing.Size(224, 28);
            this.txtChequeImporte.TabIndex = 8;
            this.txtChequeImporte.Tag = "DECIMAL2";
            this.txtChequeImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChequeImporte_KeyPress);
            // 
            // txtChequeNoCheque
            // 
            this.txtChequeNoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequeNoCheque.Location = new System.Drawing.Point(147, 150);
            this.txtChequeNoCheque.Margin = new System.Windows.Forms.Padding(4);
            this.txtChequeNoCheque.MaxLength = 30;
            this.txtChequeNoCheque.Name = "txtChequeNoCheque";
            this.txtChequeNoCheque.Size = new System.Drawing.Size(382, 28);
            this.txtChequeNoCheque.TabIndex = 7;
            this.txtChequeNoCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChequeNoCheque_KeyPress);
            // 
            // txtChequeCuenta
            // 
            this.txtChequeCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequeCuenta.Location = new System.Drawing.Point(147, 113);
            this.txtChequeCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtChequeCuenta.MaxLength = 30;
            this.txtChequeCuenta.Name = "txtChequeCuenta";
            this.txtChequeCuenta.Size = new System.Drawing.Size(382, 28);
            this.txtChequeCuenta.TabIndex = 6;
            this.txtChequeCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChequeCuenta_KeyPress);
            // 
            // cmbChequeBanco
            // 
            this.cmbChequeBanco.FormattingEnabled = true;
            this.cmbChequeBanco.Location = new System.Drawing.Point(147, 77);
            this.cmbChequeBanco.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChequeBanco.Name = "cmbChequeBanco";
            this.cmbChequeBanco.Size = new System.Drawing.Size(382, 29);
            this.cmbChequeBanco.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(18, 189);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 21);
            this.label22.TabIndex = 43;
            this.label22.Text = "Importe";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(18, 156);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 21);
            this.label21.TabIndex = 42;
            this.label21.Text = "No. Cheque";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(18, 121);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 21);
            this.label20.TabIndex = 41;
            this.label20.Text = "Cuenta";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(18, 80);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 21);
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
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1439, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "CHEQUES";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Usuario_Captura);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ucOficinas1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_No_Cheque);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1443, 100);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            // 
            // txt_Usuario_Captura
            // 
            this.txt_Usuario_Captura.Location = new System.Drawing.Point(652, 59);
            this.txt_Usuario_Captura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario_Captura.Name = "txt_Usuario_Captura";
            this.txt_Usuario_Captura.ReadOnly = true;
            this.txt_Usuario_Captura.Size = new System.Drawing.Size(310, 28);
            this.txt_Usuario_Captura.TabIndex = 43446;
            this.txt_Usuario_Captura.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 43445;
            this.label1.Text = "Usuario Captura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Oficina";
            // 
            // ucOficinas1
            // 
            this.ucOficinas1.kOficina = 0;
            this.ucOficinas1.Location = new System.Drawing.Point(149, 49);
            this.ucOficinas1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucOficinas1.Name = "ucOficinas1";
            this.ucOficinas1.Size = new System.Drawing.Size(360, 41);
            this.ucOficinas1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. Cheque";
            // 
            // txt_No_Cheque
            // 
            this.txt_No_Cheque.Location = new System.Drawing.Point(154, 16);
            this.txt_No_Cheque.Margin = new System.Windows.Forms.Padding(4);
            this.txt_No_Cheque.Name = "txt_No_Cheque";
            this.txt_No_Cheque.ReadOnly = true;
            this.txt_No_Cheque.Size = new System.Drawing.Size(106, 28);
            this.txt_No_Cheque.TabIndex = 43443;
            this.txt_No_Cheque.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "btnGuardar.Image.png");
            this.imageList1.Images.SetKeyName(2, "btnCancelar.Image.png");
            this.imageList1.Images.SetKeyName(3, "checks_22171.ico");
            // 
            // K_Cheque
            // 
            this.K_Cheque.DataPropertyName = "K_Cheque";
            this.K_Cheque.HeaderText = "ID Cheque";
            this.K_Cheque.Name = "K_Cheque";
            this.K_Cheque.ReadOnly = true;
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "No. Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.Width = 120;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.Width = 280;
            // 
            // D_Estado_Cheque
            // 
            this.D_Estado_Cheque.DataPropertyName = "D_Estado_Cheque";
            this.D_Estado_Cheque.HeaderText = "Estado Cheque";
            this.D_Estado_Cheque.Name = "D_Estado_Cheque";
            this.D_Estado_Cheque.ReadOnly = true;
            this.D_Estado_Cheque.Width = 120;
            // 
            // B_Posfechado
            // 
            this.B_Posfechado.DataPropertyName = "B_Posfechado";
            this.B_Posfechado.HeaderText = "Posfechado";
            this.B_Posfechado.Name = "B_Posfechado";
            this.B_Posfechado.ReadOnly = true;
            this.B_Posfechado.Width = 120;
            // 
            // B_Devuelto
            // 
            this.B_Devuelto.DataPropertyName = "B_Devuelto";
            this.B_Devuelto.HeaderText = "Devuelto";
            this.B_Devuelto.Name = "B_Devuelto";
            this.B_Devuelto.Width = 120;
            // 
            // B_Aplicado
            // 
            this.B_Aplicado.DataPropertyName = "B_Aplicado";
            this.B_Aplicado.HeaderText = "Aplicado";
            this.B_Aplicado.Name = "B_Aplicado";
            // 
            // F_Alta
            // 
            this.F_Alta.DataPropertyName = "F_Alta";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.F_Alta.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_Alta.HeaderText = "Fec. Alta";
            this.F_Alta.Name = "F_Alta";
            this.F_Alta.ReadOnly = true;
            this.F_Alta.Width = 150;
            // 
            // F_Aplicacion
            // 
            this.F_Aplicacion.DataPropertyName = "F_Aplicacion";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.F_Aplicacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Aplicacion.HeaderText = "Fec. Aplicacion";
            this.F_Aplicacion.Name = "F_Aplicacion";
            this.F_Aplicacion.ReadOnly = true;
            this.F_Aplicacion.Width = 150;
            // 
            // D_Banco
            // 
            this.D_Banco.DataPropertyName = "D_Banco";
            this.D_Banco.HeaderText = "Banco";
            this.D_Banco.Name = "D_Banco";
            this.D_Banco.ReadOnly = true;
            // 
            // Numero_Cuenta
            // 
            this.Numero_Cuenta.DataPropertyName = "Numero_Cuenta";
            this.Numero_Cuenta.HeaderText = "Cuenta";
            this.Numero_Cuenta.Name = "Numero_Cuenta";
            this.Numero_Cuenta.ReadOnly = true;
            this.Numero_Cuenta.Width = 200;
            // 
            // Numero_Cheque
            // 
            this.Numero_Cheque.DataPropertyName = "Numero_Cheque";
            this.Numero_Cheque.HeaderText = "Numero_Cheque";
            this.Numero_Cheque.Name = "Numero_Cheque";
            this.Numero_Cheque.ReadOnly = true;
            this.Numero_Cheque.Width = 200;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 150;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 120;
            // 
            // F_Posfechado
            // 
            this.F_Posfechado.DataPropertyName = "F_Posfechado";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.F_Posfechado.DefaultCellStyle = dataGridViewCellStyle6;
            this.F_Posfechado.HeaderText = "Fec. Posfechado";
            this.F_Posfechado.Name = "F_Posfechado";
            this.F_Posfechado.ReadOnly = true;
            this.F_Posfechado.Width = 240;
            // 
            // D_Usuario_Registro
            // 
            this.D_Usuario_Registro.DataPropertyName = "D_Usuario_Registro";
            this.D_Usuario_Registro.HeaderText = "Usuario Captura";
            this.D_Usuario_Registro.Name = "D_Usuario_Registro";
            this.D_Usuario_Registro.ReadOnly = true;
            this.D_Usuario_Registro.Width = 140;
            // 
            // D_Usuario_Aplico
            // 
            this.D_Usuario_Aplico.DataPropertyName = "D_Usuario_Aplico";
            this.D_Usuario_Aplico.HeaderText = "Usuario Aplica";
            this.D_Usuario_Aplico.Name = "D_Usuario_Aplico";
            this.D_Usuario_Aplico.ReadOnly = true;
            this.D_Usuario_Aplico.Width = 140;
            // 
            // Frm_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 690);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_Cheque";
            this.Text = "Cheque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlCheque.ResumeLayout(false);
            this.pnlCheque.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Usuario_Captura;
        private System.Windows.Forms.Label label1;
        private Controles.ucOficinas ucOficinas1;
        private System.Windows.Forms.TextBox txt_No_Cheque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCheque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChequeImporte;
        private System.Windows.Forms.TextBox txtChequeNoCheque;
        private System.Windows.Forms.TextBox txtChequeCuenta;
        private System.Windows.Forms.ComboBox cmbChequeBanco;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtClaveCliente;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Posfechado;
        private System.Windows.Forms.CheckBox cbx_Posfechado;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estado_Cheque;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Posfechado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Devuelto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Aplicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Aplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Posfechado;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Aplico;
    }
}