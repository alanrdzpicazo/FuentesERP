namespace ProbeMedic.ADMINISTRACION
{
    partial class Frm_CorreosClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CorreosClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Canal_Distribucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Canal_Distribucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCuerpoCorreo = new System.Windows.Forms.TextBox();
            this.CbxSeleccionarTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxTodoCanal = new System.Windows.Forms.CheckBox();
            this.CbxTodosClientes = new System.Windows.Forms.CheckBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.ucCanalDistribucionCliente1 = new ProbeMedic.Controles.ucCanalDistribucionCliente();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtClaveCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 494);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 303);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 191);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
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
            this.Seleccionar,
            this.K_Cliente,
            this.D_Cliente,
            this.K_Canal_Distribucion,
            this.D_Canal_Distribucion,
            this.Correo});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(827, 191);
            this.grdDatos.TabIndex = 429;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.Width = 80;
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
            // K_Canal_Distribucion
            // 
            this.K_Canal_Distribucion.DataPropertyName = "K_Canal_Distribucion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Canal_Distribucion.DefaultCellStyle = dataGridViewCellStyle3;
            this.K_Canal_Distribucion.HeaderText = "K_Canal_Distribucion";
            this.K_Canal_Distribucion.Name = "K_Canal_Distribucion";
            this.K_Canal_Distribucion.Visible = false;
            this.K_Canal_Distribucion.Width = 103;
            // 
            // D_Canal_Distribucion
            // 
            this.D_Canal_Distribucion.DataPropertyName = "D_Canal_Distribucion_Cliente";
            this.D_Canal_Distribucion.HeaderText = "Canal de Distribución";
            this.D_Canal_Distribucion.Name = "D_Canal_Distribucion";
            this.D_Canal_Distribucion.Width = 180;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 280;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtAsunto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtCuerpoCorreo);
            this.panel2.Controls.Add(this.CbxSeleccionarTodos);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 303);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(282, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Asunto del Correo";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Location = new System.Drawing.Point(284, 155);
            this.TxtAsunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAsunto.Multiline = true;
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(433, 25);
            this.TxtAsunto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(282, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cuerpo del Correo";
            // 
            // TxtCuerpoCorreo
            // 
            this.TxtCuerpoCorreo.Location = new System.Drawing.Point(284, 205);
            this.TxtCuerpoCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCuerpoCorreo.Multiline = true;
            this.TxtCuerpoCorreo.Name = "TxtCuerpoCorreo";
            this.TxtCuerpoCorreo.Size = new System.Drawing.Size(433, 84);
            this.TxtCuerpoCorreo.TabIndex = 6;
            // 
            // CbxSeleccionarTodos
            // 
            this.CbxSeleccionarTodos.AutoSize = true;
            this.CbxSeleccionarTodos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeleccionarTodos.Location = new System.Drawing.Point(11, 264);
            this.CbxSeleccionarTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxSeleccionarTodos.Name = "CbxSeleccionarTodos";
            this.CbxSeleccionarTodos.Size = new System.Drawing.Size(163, 22);
            this.CbxSeleccionarTodos.TabIndex = 27;
            this.CbxSeleccionarTodos.Text = "Seleccionar Todos";
            this.CbxSeleccionarTodos.UseVisualStyleBackColor = true;
            this.CbxSeleccionarTodos.CheckedChanged += new System.EventHandler(this.CbxSeleccionarTodos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxTodoCanal);
            this.groupBox1.Controls.Add(this.CbxTodosClientes);
            this.groupBox1.Controls.Add(this.btnBuscaCliente);
            this.groupBox1.Controls.Add(this.ucCanalDistribucionCliente1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.TxtCliente);
            this.groupBox1.Controls.Add(this.TxtClaveCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(712, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS DE BÚSQUEDA";
            // 
            // CbxTodoCanal
            // 
            this.CbxTodoCanal.AutoSize = true;
            this.CbxTodoCanal.Location = new System.Drawing.Point(436, 56);
            this.CbxTodoCanal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxTodoCanal.Name = "CbxTodoCanal";
            this.CbxTodoCanal.Size = new System.Drawing.Size(277, 22);
            this.CbxTodoCanal.TabIndex = 29;
            this.CbxTodoCanal.TabStop = false;
            this.CbxTodoCanal.Text = "Todos los Canales de Distribución";
            this.CbxTodoCanal.UseVisualStyleBackColor = true;
            this.CbxTodoCanal.CheckedChanged += new System.EventHandler(this.CbxTodoCanal_CheckedChanged);
            // 
            // CbxTodosClientes
            // 
            this.CbxTodosClientes.AutoSize = true;
            this.CbxTodosClientes.Location = new System.Drawing.Point(571, 23);
            this.CbxTodosClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxTodosClientes.Name = "CbxTodosClientes";
            this.CbxTodosClientes.Size = new System.Drawing.Size(136, 22);
            this.CbxTodosClientes.TabIndex = 28;
            this.CbxTodosClientes.TabStop = false;
            this.CbxTodosClientes.Text = "Todos Clientes";
            this.CbxTodosClientes.UseVisualStyleBackColor = true;
            this.CbxTodosClientes.CheckedChanged += new System.EventHandler(this.CbxTodosClientes_CheckedChanged);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(532, 21);
            this.btnBuscaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(31, 24);
            this.btnBuscaCliente.TabIndex = 3;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // ucCanalDistribucionCliente1
            // 
            this.ucCanalDistribucionCliente1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCanalDistribucionCliente1.Location = new System.Drawing.Point(102, 53);
            this.ucCanalDistribucionCliente1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCanalDistribucionCliente1.Name = "ucCanalDistribucionCliente1";
            this.ucCanalDistribucionCliente1.Size = new System.Drawing.Size(319, 36);
            this.ucCanalDistribucionCliente1.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 36);
            this.label18.TabIndex = 24;
            this.label18.Text = "Canal de\r\nDistribución";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(164, 21);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(363, 26);
            this.TxtCliente.TabIndex = 10;
            this.TxtCliente.TabStop = false;
            this.TxtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // TxtClaveCliente
            // 
            this.TxtClaveCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClaveCliente.Location = new System.Drawing.Point(107, 21);
            this.TxtClaveCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtClaveCliente.Name = "TxtClaveCliente";
            this.TxtClaveCliente.ReadOnly = true;
            this.TxtClaveCliente.Size = new System.Drawing.Size(53, 26);
            this.TxtClaveCliente.TabIndex = 9;
            this.TxtClaveCliente.TabStop = false;
            this.TxtClaveCliente.TextChanged += new System.EventHandler(this.TxtClaveCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CORREOS MASIVOS A CLIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // Frm_CorreosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 571);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Frm_CorreosClientes";
            this.Text = "CORREOS MASIVOS A CLIENTES";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtClaveCliente;
        private System.Windows.Forms.Label label3;
        private Controles.ucCanalDistribucionCliente ucCanalDistribucionCliente1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.CheckBox CbxSeleccionarTodos;
        private System.Windows.Forms.CheckBox CbxTodoCanal;
        private System.Windows.Forms.CheckBox CbxTodosClientes;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCuerpoCorreo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Canal_Distribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Canal_Distribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}