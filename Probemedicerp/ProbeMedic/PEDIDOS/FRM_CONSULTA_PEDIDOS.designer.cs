namespace ProbeMedic
{
    partial class FRM_CONSULTA_PEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CONSULTA_PEDIDOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxAseguradora = new System.Windows.Forms.ComboBox();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClavePaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.GroupBox();
            this.rdbCancelados = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acuse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reclamacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D_Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Celula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Coaseguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coaseguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Programa_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Cancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Derivado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHistoriaPedido = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.txtVerNotas = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarPaqueteria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel_filtros.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.txtFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1428, 23);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Pedidos Call-Center";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.txtFiltrar);
            this.panel_filtros.Controls.Add(this.label2);
            this.panel_filtros.Controls.Add(this.txtPedido);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.groupBox3);
            this.panel_filtros.Controls.Add(this.txtFilter);
            this.panel_filtros.Controls.Add(this.groupBox1);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filtros.Location = new System.Drawing.Point(0, 61);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(1428, 226);
            this.panel_filtros.TabIndex = 6;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltrar.Location = new System.Drawing.Point(821, 188);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(205, 24);
            this.txtFiltrar.TabIndex = 55;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Filtrar";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(110, 188);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(92, 24);
            this.txtPedido.TabIndex = 52;
            this.txtPedido.TextChanged += new System.EventHandler(this.txtPedido_TextChanged);
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            this.txtPedido.Validated += new System.EventHandler(this.txtPedido_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "No. Pedido ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbxAseguradora);
            this.groupBox3.Controls.Add(this.btnBuscaPaciente);
            this.groupBox3.Controls.Add(this.cbxAlmacen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnBuscarOficina);
            this.groupBox3.Controls.Add(this.txtClaveOficina);
            this.groupBox3.Controls.Add(this.txtOficina);
            this.groupBox3.Controls.Add(this.txtPaciente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtClavePaciente);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(502, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 160);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILTROS";
            // 
            // cbxAseguradora
            // 
            this.cbxAseguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAseguradora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAseguradora.FormattingEnabled = true;
            this.cbxAseguradora.Location = new System.Drawing.Point(127, 114);
            this.cbxAseguradora.Name = "cbxAseguradora";
            this.cbxAseguradora.Size = new System.Drawing.Size(384, 24);
            this.cbxAseguradora.TabIndex = 32;
            this.cbxAseguradora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAseguradora_KeyPress);
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaPaciente.Image")));
            this.btnBuscaPaciente.Location = new System.Drawing.Point(480, 83);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaPaciente.TabIndex = 48;
            this.btnBuscaPaciente.Tag = "";
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAlmacen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(127, 51);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(384, 24);
            this.cbxAlmacen.TabIndex = 44;
            this.cbxAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAlmacen_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Almacén";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Paciente";
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(479, 22);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarOficina.TabIndex = 25;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Window;
            this.txtClaveOficina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveOficina.Location = new System.Drawing.Point(127, 22);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 23);
            this.txtClaveOficina.TabIndex = 27;
            this.txtClaveOficina.TabStop = false;
            this.txtClaveOficina.TextChanged += new System.EventHandler(this.txtClaveOficina_TextChanged);
            this.txtClaveOficina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveOficina_KeyPress);
            this.txtClaveOficina.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtClaveOficina_PreviewKeyDown);
            // 
            // txtOficina
            // 
            this.txtOficina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOficina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficina.Location = new System.Drawing.Point(181, 22);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(296, 23);
            this.txtOficina.TabIndex = 28;
            this.txtOficina.TabStop = false;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaciente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(182, 83);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(296, 23);
            this.txtPaciente.TabIndex = 50;
            this.txtPaciente.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Oficina";
            // 
            // txtClavePaciente
            // 
            this.txtClavePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClavePaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtClavePaciente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClavePaciente.Location = new System.Drawing.Point(127, 83);
            this.txtClavePaciente.Name = "txtClavePaciente";
            this.txtClavePaciente.Size = new System.Drawing.Size(52, 23);
            this.txtClavePaciente.TabIndex = 49;
            this.txtClavePaciente.TabStop = false;
            this.txtClavePaciente.TextChanged += new System.EventHandler(this.txtClavePaciente_TextChanged);
            this.txtClavePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClavePaciente_KeyPress);
            this.txtClavePaciente.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtClavePaciente_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Aseguradora";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Controls.Add(this.rdbCancelados);
            this.txtFilter.Controls.Add(this.rdbTodos);
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(23, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(422, 60);
            this.txtFilter.TabIndex = 47;
            this.txtFilter.TabStop = false;
            this.txtFilter.Text = "MOSTRAR PEDIDOS";
            // 
            // rdbCancelados
            // 
            this.rdbCancelados.AutoSize = true;
            this.rdbCancelados.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelados.Location = new System.Drawing.Point(122, 23);
            this.rdbCancelados.Name = "rdbCancelados";
            this.rdbCancelados.Size = new System.Drawing.Size(139, 20);
            this.rdbCancelados.TabIndex = 48;
            this.rdbCancelados.Text = "Pedidos Cancelados";
            this.rdbCancelados.UseVisualStyleBackColor = true;
            this.rdbCancelados.CheckedChanged += new System.EventHandler(this.rdbCancelados_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(23, 23);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(61, 20);
            this.rdbTodos.TabIndex = 47;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtp_inicial);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONAR PERIODO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(184, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hasta";
            // 
            // dtp_final
            // 
            this.dtp_final.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(230, 23);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(88, 23);
            this.dtp_final.TabIndex = 5;
            this.dtp_final.ValueChanged += new System.EventHandler(this.dtp_final_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Desde";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(72, 24);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(88, 23);
            this.dtp_inicial.TabIndex = 4;
            this.dtp_inicial.ValueChanged += new System.EventHandler(this.dtp_inicial_ValueChanged);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Pedido,
            this.D_Estatus_Pedido,
            this.K_Paciente,
            this.D_Paciente,
            this.D_Usuario,
            this.FechaPedido,
            this.FechaEntrega,
            this.F_Entrgado,
            this.Acuse,
            this.Reclamacion,
            this.Vip,
            this.D_Aseguradora,
            this.D_Celula,
            this.Porcentaje_Coaseguro,
            this.Coaseguro,
            this.D_Programa_Paciente,
            this.B_Cancelado,
            this.Derivado});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
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
            this.grdDatos.Size = new System.Drawing.Size(1428, 345);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datos_CellDoubleClick);
            this.grdDatos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellMouseEnter);
            // 
            // K_Pedido
            // 
            this.K_Pedido.DataPropertyName = "K_Pedido";
            this.K_Pedido.FillWeight = 127.9398F;
            this.K_Pedido.HeaderText = "ID";
            this.K_Pedido.Name = "K_Pedido";
            this.K_Pedido.ReadOnly = true;
            this.K_Pedido.Width = 80;
            // 
            // D_Estatus_Pedido
            // 
            this.D_Estatus_Pedido.DataPropertyName = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.FillWeight = 327.2926F;
            this.D_Estatus_Pedido.HeaderText = "Estatus";
            this.D_Estatus_Pedido.Name = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.ReadOnly = true;
            this.D_Estatus_Pedido.Width = 220;
            // 
            // K_Paciente
            // 
            this.K_Paciente.DataPropertyName = "K_Paciente";
            this.K_Paciente.HeaderText = "K_Paciente";
            this.K_Paciente.Name = "K_Paciente";
            this.K_Paciente.ReadOnly = true;
            this.K_Paciente.Visible = false;
            // 
            // D_Paciente
            // 
            this.D_Paciente.DataPropertyName = "D_Paciente";
            this.D_Paciente.FillWeight = 475.4409F;
            this.D_Paciente.HeaderText = "Paciente";
            this.D_Paciente.Name = "D_Paciente";
            this.D_Paciente.ReadOnly = true;
            this.D_Paciente.Width = 400;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.FillWeight = 225.0427F;
            this.D_Usuario.HeaderText = "Creado Por";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Width = 300;
            // 
            // FechaPedido
            // 
            this.FechaPedido.DataPropertyName = "FechaPedido";
            dataGridViewCellStyle2.Format = "d / MM / yyyy";
            this.FechaPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaPedido.FillWeight = 71.1413F;
            this.FechaPedido.HeaderText = "Fecha";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            this.FechaPedido.Width = 130;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.DataPropertyName = "FechaEntrega";
            dataGridViewCellStyle3.Format = "d / MM / yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaEntrega.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaEntrega.FillWeight = 63.58551F;
            this.FechaEntrega.HeaderText = "Fecha de Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 150;
            // 
            // F_Entrgado
            // 
            this.F_Entrgado.DataPropertyName = "F_Entrgado";
            dataGridViewCellStyle4.Format = "d / MM / yyyy";
            this.F_Entrgado.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Entrgado.FillWeight = 56.95377F;
            this.F_Entrgado.HeaderText = "Fecha Entregado";
            this.F_Entrgado.Name = "F_Entrgado";
            this.F_Entrgado.ReadOnly = true;
            this.F_Entrgado.Width = 150;
            // 
            // Acuse
            // 
            this.Acuse.DataPropertyName = "Acuse";
            this.Acuse.FillWeight = 39.33312F;
            this.Acuse.HeaderText = "Acuse";
            this.Acuse.Name = "Acuse";
            this.Acuse.ReadOnly = true;
            // 
            // Reclamacion
            // 
            this.Reclamacion.DataPropertyName = "Reclamacion";
            this.Reclamacion.FillWeight = 36.51328F;
            this.Reclamacion.HeaderText = "Reclamación";
            this.Reclamacion.Name = "Reclamacion";
            this.Reclamacion.ReadOnly = true;
            // 
            // Vip
            // 
            this.Vip.DataPropertyName = "Vip";
            this.Vip.FillWeight = 33.95871F;
            this.Vip.HeaderText = "V.I.P";
            this.Vip.Name = "Vip";
            this.Vip.ReadOnly = true;
            // 
            // D_Aseguradora
            // 
            this.D_Aseguradora.DataPropertyName = "D_Aseguradora";
            this.D_Aseguradora.FillWeight = 69.61783F;
            this.D_Aseguradora.HeaderText = "Aseguradora";
            this.D_Aseguradora.Name = "D_Aseguradora";
            this.D_Aseguradora.ReadOnly = true;
            this.D_Aseguradora.Width = 220;
            // 
            // D_Celula
            // 
            this.D_Celula.DataPropertyName = "D_Celula";
            this.D_Celula.FillWeight = 57.14641F;
            this.D_Celula.HeaderText = "Celula";
            this.D_Celula.Name = "D_Celula";
            this.D_Celula.ReadOnly = true;
            this.D_Celula.Width = 220;
            // 
            // Porcentaje_Coaseguro
            // 
            this.Porcentaje_Coaseguro.DataPropertyName = "Porcentaje_Coaseguro";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Porcentaje_Coaseguro.DefaultCellStyle = dataGridViewCellStyle5;
            this.Porcentaje_Coaseguro.FillWeight = 21.48005F;
            this.Porcentaje_Coaseguro.HeaderText = "Coaseguro %";
            this.Porcentaje_Coaseguro.Name = "Porcentaje_Coaseguro";
            this.Porcentaje_Coaseguro.ReadOnly = true;
            this.Porcentaje_Coaseguro.Width = 120;
            // 
            // Coaseguro
            // 
            this.Coaseguro.DataPropertyName = "Coaseguro";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Coaseguro.DefaultCellStyle = dataGridViewCellStyle6;
            this.Coaseguro.FillWeight = 20.33971F;
            this.Coaseguro.HeaderText = "Coaseguro";
            this.Coaseguro.Name = "Coaseguro";
            this.Coaseguro.ReadOnly = true;
            // 
            // D_Programa_Paciente
            // 
            this.D_Programa_Paciente.DataPropertyName = "D_Programa_Paciente";
            this.D_Programa_Paciente.FillWeight = 42.4746F;
            this.D_Programa_Paciente.HeaderText = "Programa";
            this.D_Programa_Paciente.Name = "D_Programa_Paciente";
            this.D_Programa_Paciente.ReadOnly = true;
            this.D_Programa_Paciente.Width = 220;
            // 
            // B_Cancelado
            // 
            this.B_Cancelado.DataPropertyName = "B_Cancelado";
            this.B_Cancelado.FillWeight = 16.19127F;
            this.B_Cancelado.HeaderText = "Cancelado";
            this.B_Cancelado.Name = "B_Cancelado";
            this.B_Cancelado.ReadOnly = true;
            // 
            // Derivado
            // 
            this.Derivado.DataPropertyName = "Derivado";
            this.Derivado.FillWeight = 15.54846F;
            this.Derivado.HeaderText = "Derivado";
            this.Derivado.Name = "Derivado";
            this.Derivado.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.Location = new System.Drawing.Point(3, 3);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(171, 52);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            this.btnVer.MouseEnter += new System.EventHandler(this.btnVer_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.btnHistoriaPedido, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAprobar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVerNotas, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActivar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarPaqueteria, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1428, 58);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // btnHistoriaPedido
            // 
            this.btnHistoriaPedido.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoriaPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoriaPedido.Image")));
            this.btnHistoriaPedido.Location = new System.Drawing.Point(1257, 3);
            this.btnHistoriaPedido.Name = "btnHistoriaPedido";
            this.btnHistoriaPedido.Size = new System.Drawing.Size(167, 52);
            this.btnHistoriaPedido.TabIndex = 10;
            this.btnHistoriaPedido.Text = "Historia";
            this.btnHistoriaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistoriaPedido.UseVisualStyleBackColor = true;
            this.btnHistoriaPedido.Click += new System.EventHandler(this.btnHistoriaPedido_Click);
            this.btnHistoriaPedido.MouseEnter += new System.EventHandler(this.btnHistoriaPedido_MouseEnter);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobar.Image")));
            this.btnAprobar.Location = new System.Drawing.Point(180, 3);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(171, 52);
            this.btnAprobar.TabIndex = 5;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            this.btnAprobar.MouseEnter += new System.EventHandler(this.btnAprobar_MouseEnter);
            // 
            // txtVerNotas
            // 
            this.txtVerNotas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerNotas.Image = ((System.Drawing.Image)(resources.GetObject("txtVerNotas.Image")));
            this.txtVerNotas.Location = new System.Drawing.Point(888, 3);
            this.txtVerNotas.Name = "txtVerNotas";
            this.txtVerNotas.Size = new System.Drawing.Size(171, 52);
            this.txtVerNotas.TabIndex = 1;
            this.txtVerNotas.Text = "Ver Notas";
            this.txtVerNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtVerNotas.UseVisualStyleBackColor = true;
            this.txtVerNotas.Click += new System.EventHandler(this.txtVerNotas_Click);
            this.txtVerNotas.MouseEnter += new System.EventHandler(this.txtVerNotas_MouseEnter);
            // 
            // btnActivar
            // 
            this.btnActivar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.Location = new System.Drawing.Point(357, 3);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(171, 52);
            this.btnActivar.TabIndex = 4;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            this.btnActivar.MouseEnter += new System.EventHandler(this.btnActivar_MouseEnter);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(711, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(171, 52);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(534, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            // 
            // btnModificarPaqueteria
            // 
            this.btnModificarPaqueteria.Enabled = false;
            this.btnModificarPaqueteria.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPaqueteria.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarPaqueteria.Image")));
            this.btnModificarPaqueteria.Location = new System.Drawing.Point(1065, 3);
            this.btnModificarPaqueteria.Name = "btnModificarPaqueteria";
            this.btnModificarPaqueteria.Size = new System.Drawing.Size(186, 52);
            this.btnModificarPaqueteria.TabIndex = 9;
            this.btnModificarPaqueteria.Text = "Modificar \r\nPaqueteria";
            this.btnModificarPaqueteria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPaqueteria.UseVisualStyleBackColor = true;
            this.btnModificarPaqueteria.Click += new System.EventHandler(this.btnModificarPaqueteria_Click);
            this.btnModificarPaqueteria.MouseEnter += new System.EventHandler(this.btnModificarPaqueteria_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 58);
            this.panel1.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdDatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 345);
            this.panel2.TabIndex = 8;
            // 
            // FRM_CONSULTA_PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_filtros);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(1444, 768);
            this.Name = "FRM_CONSULTA_PEDIDOS";
            this.Text = "PEDIDOS CALL CENTER";
            this.Load += new System.EventHandler(this.FRM_CONSULTA_PEDIDOS_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.panel_filtros, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.txtFilter.ResumeLayout(false);
            this.txtFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.Button btnBuscarOficina;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAseguradora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscaPaciente;
        private System.Windows.Forms.TextBox txtClavePaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.GroupBox txtFilter;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button txtVerNotas;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificarPaqueteria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbCancelados;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHistoriaPedido;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrgado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Acuse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reclamacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vip;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Celula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Coaseguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coaseguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Programa_Paciente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Cancelado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Derivado;
    }
}