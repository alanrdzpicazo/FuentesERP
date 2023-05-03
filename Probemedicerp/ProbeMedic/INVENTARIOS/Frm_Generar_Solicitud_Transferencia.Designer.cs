namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Generar_Solicitud_Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Generar_Solicitud_Transferencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Mas = new System.Windows.Forms.DataGridViewImageColumn();
            this.Menos = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sel_OficinaOrigen = new ProbeMedic.Controles.Sel_Oficina();
            this.ucMotivoTransferencia1 = new ProbeMedic.Controles.ucMotivoTransferencia();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxAlmacenOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxAlmacenSolicita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficinaSolicita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 469);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDetalle);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 243);
            this.panel3.TabIndex = 28;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mas,
            this.Menos,
            this.Cantidad,
            this.K_Articulo,
            this.D_Articulo,
            this.CSKU,
            this.D_Unidad_Medida});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 90);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.Size = new System.Drawing.Size(1036, 153);
            this.grdDetalle.TabIndex = 16;
            this.grdDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalle_CellClick);
            // 
            // Mas
            // 
            this.Mas.HeaderText = "";
            this.Mas.Image = ((System.Drawing.Image)(resources.GetObject("Mas.Image")));
            this.Mas.Name = "Mas";
            this.Mas.ReadOnly = true;
            this.Mas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mas.Width = 5;
            // 
            // Menos
            // 
            this.Menos.HeaderText = "";
            this.Menos.Image = ((System.Drawing.Image)(resources.GetObject("Menos.Image")));
            this.Menos.Name = "Menos";
            this.Menos.ReadOnly = true;
            this.Menos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Menos.Width = 5;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 66;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "No. Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 103;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // CSKU
            // 
            this.CSKU.DataPropertyName = "SKU";
            this.CSKU.HeaderText = "SKU";
            this.CSKU.Name = "CSKU";
            this.CSKU.ReadOnly = true;
            this.CSKU.Width = 58;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "Unidad Médida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Width = 121;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.txtCantidad);
            this.panel4.Controls.Add(this.txtArticulo);
            this.panel4.Controls.Add(this.btnBuscarArticulos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1036, 71);
            this.panel4.TabIndex = 13;
            this.panel4.TabStop = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(21, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 17);
            this.label25.TabIndex = 62;
            this.label25.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(199, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Tag = "";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 17);
            this.label24.TabIndex = 61;
            this.label24.Text = "Articulo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(95, 38);
            this.txtCantidad.MaxLength = 0;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(99, 24);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.Tag = "";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtArticulo
            // 
            this.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArticulo.Location = new System.Drawing.Point(96, 9);
            this.txtArticulo.MaxLength = 120;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(353, 24);
            this.txtArticulo.TabIndex = 60;
            this.txtArticulo.TabStop = false;
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarArticulos.Image")));
            this.btnBuscarArticulos.Location = new System.Drawing.Point(455, 10);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarArticulos.TabIndex = 14;
            this.btnBuscarArticulos.Tag = "";
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            this.btnBuscarArticulos.Click += new System.EventHandler(this.btnBuscarArticulos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1036, 19);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Detalle de Artículos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 226);
            this.panel2.TabIndex = 27;
            this.panel2.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.sel_OficinaOrigen);
            this.groupBox2.Controls.Add(this.ucMotivoTransferencia1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CbxAlmacenOrigen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(428, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 171);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS ORIGEN";
            // 
            // sel_OficinaOrigen
            // 
            this.sel_OficinaOrigen.K_Oficina = 0;
            this.sel_OficinaOrigen.Location = new System.Drawing.Point(126, 17);
            this.sel_OficinaOrigen.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.sel_OficinaOrigen.Name = "sel_OficinaOrigen";
            this.sel_OficinaOrigen.Size = new System.Drawing.Size(465, 32);
            this.sel_OficinaOrigen.TabIndex = 9;
            // 
            // ucMotivoTransferencia1
            // 
            this.ucMotivoTransferencia1.Location = new System.Drawing.Point(126, 113);
            this.ucMotivoTransferencia1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucMotivoTransferencia1.Name = "ucMotivoTransferencia1";
            this.ucMotivoTransferencia1.Size = new System.Drawing.Size(254, 34);
            this.ucMotivoTransferencia1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Motivo";
            // 
            // CbxAlmacenOrigen
            // 
            this.CbxAlmacenOrigen.FormattingEnabled = true;
            this.CbxAlmacenOrigen.Location = new System.Drawing.Point(129, 52);
            this.CbxAlmacenOrigen.Name = "CbxAlmacenOrigen";
            this.CbxAlmacenOrigen.Size = new System.Drawing.Size(307, 24);
            this.CbxAlmacenOrigen.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Almacen";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(129, 83);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(453, 25);
            this.txtObservaciones.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Oficina";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CbxAlmacenSolicita);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOficinaSolicita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 171);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS SOLICITA";
            // 
            // CbxAlmacenSolicita
            // 
            this.CbxAlmacenSolicita.FormattingEnabled = true;
            this.CbxAlmacenSolicita.Location = new System.Drawing.Point(85, 51);
            this.CbxAlmacenSolicita.Name = "CbxAlmacenSolicita";
            this.CbxAlmacenSolicita.Size = new System.Drawing.Size(307, 24);
            this.CbxAlmacenSolicita.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oficina";
            // 
            // txtOficinaSolicita
            // 
            this.txtOficinaSolicita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOficinaSolicita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOficinaSolicita.Location = new System.Drawing.Point(85, 21);
            this.txtOficinaSolicita.Name = "txtOficinaSolicita";
            this.txtOficinaSolicita.ReadOnly = true;
            this.txtOficinaSolicita.Size = new System.Drawing.Size(307, 24);
            this.txtOficinaSolicita.TabIndex = 5;
            this.txtOficinaSolicita.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Almacen";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1036, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nueva Solicitud de Artículos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Generar_Solicitud_Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 546);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Generar_Solicitud_Transferencia";
            this.Text = "SOLICITUD DE ARTICULOS";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxAlmacenSolicita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficinaSolicita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CbxAlmacenOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Controles.ucMotivoTransferencia ucMotivoTransferencia1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.Label lblTitulo;
        private Controles.Sel_Oficina sel_OficinaOrigen;
        private System.Windows.Forms.DataGridViewImageColumn Mas;
        private System.Windows.Forms.DataGridViewImageColumn Menos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
    }
}