namespace ProbeMedic.VENTAS
{
    partial class Frm_Cancelacion_Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad_Cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_RequiereReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Precierre_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Almacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_Folio = new System.Windows.Forms.TextBox();
            this.fdfdf = new System.Windows.Forms.Label();
            this.fdfdfdd = new System.Windows.Forms.Label();
            this.Lbl_Folio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 547);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.grdDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 320);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Salir);
            this.panel4.Controls.Add(this.btn_Limpiar);
            this.panel4.Controls.Add(this.btn_Cancelar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 75);
            this.panel4.TabIndex = 3;
            this.panel4.TabStop = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.btn_Limpiar.FlatAppearance.BorderSize = 2;
            this.btn_Limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(80)))));
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(463, 11);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(107, 52);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar\r\n[F3]";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(80)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(580, 11);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(107, 52);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar\r\n[F4]\r\n";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Transaccion,
            this.K_Almacen,
            this.D_Almacen,
            this.K_Usuario,
            this.D_Usuario,
            this.F_Transaccion,
            this.Cancelado,
            this.Cantidad_Cancelacion,
            this.Cantidad_Articulos,
            this.K_Medico,
            this.D_Medico,
            this.K_Cliente,
            this.D_Cliente,
            this.B_RequiereReceta,
            this.Observaciones1,
            this.Observaciones2,
            this.Observaciones3,
            this.Observaciones4,
            this.K_Articulo,
            this.SKU,
            this.D_Articulo,
            this.D_Unidad_Medida,
            this.Lote,
            this.F_Caducidad,
            this.Monto_Total,
            this.Precio_Unitario,
            this.K_Precierre_Empleado,
            this.Monto_Transaccion});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(815, 320);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.TabStop = false;
            this.grdDatos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDatos_CellValidating);
            this.grdDatos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdDatos_EditingControlShowing);
            // 
            // K_Transaccion
            // 
            this.K_Transaccion.DataPropertyName = "K_Transaccion";
            this.K_Transaccion.HeaderText = "K_Transaccion";
            this.K_Transaccion.Name = "K_Transaccion";
            this.K_Transaccion.ReadOnly = true;
            this.K_Transaccion.Visible = false;
            this.K_Transaccion.Width = 85;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.ReadOnly = true;
            this.K_Almacen.Visible = false;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "D_Almacen";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Visible = false;
            // 
            // K_Usuario
            // 
            this.K_Usuario.DataPropertyName = "K_Usuario";
            this.K_Usuario.HeaderText = "K_Usuario";
            this.K_Usuario.Name = "K_Usuario";
            this.K_Usuario.ReadOnly = true;
            this.K_Usuario.Visible = false;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.HeaderText = "D_Usuario";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Visible = false;
            // 
            // F_Transaccion
            // 
            this.F_Transaccion.DataPropertyName = "F_Transaccion";
            this.F_Transaccion.HeaderText = "F_Transaccion";
            this.F_Transaccion.Name = "F_Transaccion";
            this.F_Transaccion.ReadOnly = true;
            this.F_Transaccion.Visible = false;
            // 
            // Cancelado
            // 
            this.Cancelado.DataPropertyName = "Cancelado";
            this.Cancelado.HeaderText = "Cancelado";
            this.Cancelado.Name = "Cancelado";
            this.Cancelado.Visible = false;
            this.Cancelado.Width = 80;
            // 
            // Cantidad_Cancelacion
            // 
            this.Cantidad_Cancelacion.DataPropertyName = "Cantidad_Cancelacion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Cantidad_Cancelacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad_Cancelacion.HeaderText = "Cant. a Cancelar";
            this.Cantidad_Cancelacion.MaxInputLength = 5;
            this.Cantidad_Cancelacion.Name = "Cantidad_Cancelacion";
            this.Cantidad_Cancelacion.Width = 65;
            // 
            // Cantidad_Articulos
            // 
            this.Cantidad_Articulos.DataPropertyName = "Cantidad_Articulos";
            this.Cantidad_Articulos.HeaderText = "Cant.";
            this.Cantidad_Articulos.Name = "Cantidad_Articulos";
            this.Cantidad_Articulos.ReadOnly = true;
            this.Cantidad_Articulos.Width = 50;
            // 
            // K_Medico
            // 
            this.K_Medico.DataPropertyName = "K_Medico";
            this.K_Medico.HeaderText = "K_Medico";
            this.K_Medico.Name = "K_Medico";
            this.K_Medico.ReadOnly = true;
            this.K_Medico.Visible = false;
            // 
            // D_Medico
            // 
            this.D_Medico.DataPropertyName = "D_Medico";
            this.D_Medico.HeaderText = "D_Medico";
            this.D_Medico.Name = "D_Medico";
            this.D_Medico.ReadOnly = true;
            this.D_Medico.Visible = false;
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "K_Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            this.K_Cliente.Visible = false;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = " D_Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Visible = false;
            // 
            // B_RequiereReceta
            // 
            this.B_RequiereReceta.DataPropertyName = "B_RequiereReceta";
            this.B_RequiereReceta.HeaderText = "B_RequiereReceta";
            this.B_RequiereReceta.Name = "B_RequiereReceta";
            this.B_RequiereReceta.ReadOnly = true;
            this.B_RequiereReceta.Visible = false;
            // 
            // Observaciones1
            // 
            this.Observaciones1.DataPropertyName = "Observaciones1";
            this.Observaciones1.HeaderText = "Observaciones1";
            this.Observaciones1.Name = "Observaciones1";
            this.Observaciones1.ReadOnly = true;
            this.Observaciones1.Visible = false;
            // 
            // Observaciones2
            // 
            this.Observaciones2.DataPropertyName = "Observaciones2";
            this.Observaciones2.HeaderText = "Observaciones2";
            this.Observaciones2.Name = "Observaciones2";
            this.Observaciones2.ReadOnly = true;
            this.Observaciones2.Visible = false;
            // 
            // Observaciones3
            // 
            this.Observaciones3.DataPropertyName = "Observaciones3";
            this.Observaciones3.HeaderText = "Observaciones3";
            this.Observaciones3.Name = "Observaciones3";
            this.Observaciones3.ReadOnly = true;
            this.Observaciones3.Visible = false;
            // 
            // Observaciones4
            // 
            this.Observaciones4.DataPropertyName = "Observaciones4";
            this.Observaciones4.HeaderText = "Observaciones4";
            this.Observaciones4.Name = "Observaciones4";
            this.Observaciones4.ReadOnly = true;
            this.Observaciones4.Visible = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "K_Articulo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Visible = false;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SKU.DefaultCellStyle = dataGridViewCellStyle2;
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 135;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 300;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "U. Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Visible = false;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            this.F_Caducidad.HeaderText = "F_Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            this.F_Caducidad.Visible = false;
            // 
            // Monto_Total
            // 
            this.Monto_Total.DataPropertyName = "Monto_Total";
            this.Monto_Total.HeaderText = "Monto_Total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            this.Monto_Total.Visible = false;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio_Unitario.HeaderText = "Importe";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Width = 120;
            // 
            // K_Precierre_Empleado
            // 
            this.K_Precierre_Empleado.DataPropertyName = "K_Precierre_Empleado";
            this.K_Precierre_Empleado.HeaderText = "K_Precierre_Empleado";
            this.K_Precierre_Empleado.Name = "K_Precierre_Empleado";
            this.K_Precierre_Empleado.ReadOnly = true;
            this.K_Precierre_Empleado.Visible = false;
            // 
            // Monto_Transaccion
            // 
            this.Monto_Transaccion.DataPropertyName = "Monto_Transaccion";
            this.Monto_Transaccion.HeaderText = "Monto_Transaccion";
            this.Monto_Transaccion.Name = "Monto_Transaccion";
            this.Monto_Transaccion.ReadOnly = true;
            this.Monto_Transaccion.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txt_Observaciones);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Cliente);
            this.panel2.Controls.Add(this.lbl_Total);
            this.panel2.Controls.Add(this.txt_Almacen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sd);
            this.panel2.Controls.Add(this.lbl_Fecha);
            this.panel2.Controls.Add(this.txt_Folio);
            this.panel2.Controls.Add(this.fdfdf);
            this.panel2.Controls.Add(this.fdfdfdd);
            this.panel2.Controls.Add(this.Lbl_Folio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 217);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Observaciones.Location = new System.Drawing.Point(138, 135);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(341, 58);
            this.txt_Observaciones.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Observaciones";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(138, 103);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.ReadOnly = true;
            this.txt_Cliente.Size = new System.Drawing.Size(660, 24);
            this.txt_Cliente.TabIndex = 22;
            this.txt_Cliente.TabStop = false;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(585, 138);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(133, 29);
            this.lbl_Total.TabIndex = 10;
            this.lbl_Total.Text = "________";
            // 
            // txt_Almacen
            // 
            this.txt_Almacen.Location = new System.Drawing.Point(138, 71);
            this.txt_Almacen.Name = "txt_Almacen";
            this.txt_Almacen.ReadOnly = true;
            this.txt_Almacen.Size = new System.Drawing.Size(660, 24);
            this.txt_Almacen.TabIndex = 21;
            this.txt_Almacen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(138, 40);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.ReadOnly = true;
            this.txt_Usuario.Size = new System.Drawing.Size(660, 24);
            this.txt_Usuario.TabIndex = 20;
            this.txt_Usuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.sd.Location = new System.Drawing.Point(19, 108);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(55, 17);
            this.sd.TabIndex = 7;
            this.sd.Text = "Cliente";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(346, 14);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(176, 17);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "_____________________";
            // 
            // txt_Folio
            // 
            this.txt_Folio.Location = new System.Drawing.Point(138, 10);
            this.txt_Folio.Name = "txt_Folio";
            this.txt_Folio.Size = new System.Drawing.Size(116, 24);
            this.txt_Folio.TabIndex = 2;
            this.txt_Folio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Folio_KeyDown);
            this.txt_Folio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Folio_KeyPress);
            this.txt_Folio.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_Folio_PreviewKeyDown);
            // 
            // fdfdf
            // 
            this.fdfdf.AutoSize = true;
            this.fdfdf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fdfdf.Location = new System.Drawing.Point(19, 47);
            this.fdfdf.Name = "fdfdf";
            this.fdfdf.Size = new System.Drawing.Size(60, 17);
            this.fdfdf.TabIndex = 3;
            this.fdfdf.Text = "Usuario";
            // 
            // fdfdfdd
            // 
            this.fdfdfdd.AutoSize = true;
            this.fdfdfdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fdfdfdd.Location = new System.Drawing.Point(19, 75);
            this.fdfdfdd.Name = "fdfdfdd";
            this.fdfdfdd.Size = new System.Drawing.Size(66, 17);
            this.fdfdfdd.TabIndex = 2;
            this.fdfdfdd.Text = "Almacén";
            // 
            // Lbl_Folio
            // 
            this.Lbl_Folio.AutoSize = true;
            this.Lbl_Folio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Folio.Location = new System.Drawing.Point(19, 15);
            this.Lbl_Folio.Name = "Lbl_Folio";
            this.Lbl_Folio.Size = new System.Drawing.Size(64, 17);
            this.Lbl_Folio.TabIndex = 0;
            this.Lbl_Folio.Text = "Ticket #";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(815, 10);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.btn_Salir.FlatAppearance.BorderSize = 2;
            this.btn_Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(80)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(696, 11);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(107, 52);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir\r\n[F5]\r\n";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Frm_Cancelacion_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 547);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cancelacion_Venta";
            this.Text = "CANCELACION DE TICKETS";
            this.Load += new System.EventHandler(this.Frm_Cancelacion_Venta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Cancelacion_Venta_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.TextBox txt_Folio;
        private System.Windows.Forms.Label fdfdf;
        private System.Windows.Forms.Label fdfdfdd;
        private System.Windows.Forms.Label Lbl_Folio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.TextBox txt_Almacen;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Transaccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_RequiereReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones4;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precierre_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Transaccion;
        private System.Windows.Forms.Button btn_Salir;
    }
}