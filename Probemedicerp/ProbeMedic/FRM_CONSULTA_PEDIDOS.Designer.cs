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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CONSULTA_PEDIDOS));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ucClientes1 = new ProbeMedic.Controles.ucClientes();
            this.label6 = new System.Windows.Forms.Label();
            this.ucPacientes1 = new ProbeMedic.Controles.ucPacientes();
            this.checkBoxRemisionado = new System.Windows.Forms.CheckBox();
            this.checkBoxCancelado = new System.Windows.Forms.CheckBox();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.cbxAseguradora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.K_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel_filtros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(1054, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Consulta de Pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.cbxAlmacen);
            this.panel_filtros.Controls.Add(this.label3);
            this.panel_filtros.Controls.Add(this.cbxAseguradora);
            this.panel_filtros.Controls.Add(this.label8);
            this.panel_filtros.Controls.Add(this.label12);
            this.panel_filtros.Controls.Add(this.ucClientes1);
            this.panel_filtros.Controls.Add(this.label6);
            this.panel_filtros.Controls.Add(this.ucPacientes1);
            this.panel_filtros.Controls.Add(this.checkBoxRemisionado);
            this.panel_filtros.Controls.Add(this.checkBoxCancelado);
            this.panel_filtros.Controls.Add(this.btnBuscarOficina);
            this.panel_filtros.Controls.Add(this.txtClaveOficina);
            this.panel_filtros.Controls.Add(this.txtOficina);
            this.panel_filtros.Controls.Add(this.label4);
            this.panel_filtros.Controls.Add(this.txtNoPedido);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.groupBox1);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filtros.Location = new System.Drawing.Point(0, 67);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(1054, 138);
            this.panel_filtros.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Cliente";
            // 
            // ucClientes1
            // 
            this.ucClientes1.Location = new System.Drawing.Point(566, 38);
            this.ucClientes1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ucClientes1.Name = "ucClientes1";
            this.ucClientes1.Size = new System.Drawing.Size(409, 34);
            this.ucClientes1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Paciente";
            // 
            // ucPacientes1
            // 
            this.ucPacientes1.Location = new System.Drawing.Point(566, 6);
            this.ucPacientes1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ucPacientes1.Name = "ucPacientes1";
            this.ucPacientes1.Size = new System.Drawing.Size(426, 33);
            this.ucPacientes1.TabIndex = 30;
            // 
            // checkBoxRemisionado
            // 
            this.checkBoxRemisionado.AutoSize = true;
            this.checkBoxRemisionado.Location = new System.Drawing.Point(358, 14);
            this.checkBoxRemisionado.Name = "checkBoxRemisionado";
            this.checkBoxRemisionado.Size = new System.Drawing.Size(104, 21);
            this.checkBoxRemisionado.TabIndex = 29;
            this.checkBoxRemisionado.Text = "Remisionado";
            this.checkBoxRemisionado.UseVisualStyleBackColor = true;
            // 
            // checkBoxCancelado
            // 
            this.checkBoxCancelado.AutoSize = true;
            this.checkBoxCancelado.Location = new System.Drawing.Point(231, 14);
            this.checkBoxCancelado.Name = "checkBoxCancelado";
            this.checkBoxCancelado.Size = new System.Drawing.Size(90, 21);
            this.checkBoxCancelado.TabIndex = 29;
            this.checkBoxCancelado.Text = "Cancelado";
            this.checkBoxCancelado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficina.Image")));
            this.btnBuscarOficina.Location = new System.Drawing.Point(421, 48);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarOficina.TabIndex = 25;
            this.btnBuscarOficina.Tag = "";
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(113, 48);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficina.TabIndex = 27;
            this.txtClaveOficina.TabStop = false;
            this.txtClaveOficina.TextChanged += new System.EventHandler(this.txtClaveOficina_TextChanged);
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(172, 48);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(234, 24);
            this.txtOficina.TabIndex = 28;
            this.txtOficina.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Oficina";
            // 
            // txtNoPedido
            // 
            this.txtNoPedido.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPedido.Location = new System.Drawing.Point(115, 15);
            this.txtNoPedido.MaxLength = 10;
            this.txtNoPedido.Name = "txtNoPedido";
            this.txtNoPedido.Size = new System.Drawing.Size(100, 24);
            this.txtNoPedido.TabIndex = 7;
            this.txtNoPedido.Tag = "ENTERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtp_inicial);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Fechas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(237, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hasta";
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(283, 26);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(88, 24);
            this.dtp_final.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(73, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Desde";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(125, 27);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(88, 24);
            this.dtp_inicial.TabIndex = 4;
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.dgv_datos);
            this.panel_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos.Location = new System.Drawing.Point(0, 205);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(1054, 302);
            this.panel_datos.TabIndex = 7;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Pedido,
            this.D_Oficina,
            this.D_Estatus_Pedido,
            this.D_Cliente,
            this.F_Pedido,
            this.Subtotal,
            this.Total_IVA,
            this.Total_Pedido});
            this.dgv_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datos.Location = new System.Drawing.Point(0, 0);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(1054, 302);
            this.dgv_datos.TabIndex = 0;
            // 
            // cbxAseguradora
            // 
            this.cbxAseguradora.FormattingEnabled = true;
            this.cbxAseguradora.Location = new System.Drawing.Point(583, 75);
            this.cbxAseguradora.Name = "cbxAseguradora";
            this.cbxAseguradora.Size = new System.Drawing.Size(392, 24);
            this.cbxAseguradora.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Aseguradora";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(569, 105);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(406, 24);
            this.cbxAlmacen.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Almacén";
            // 
            // K_Pedido
            // 
            this.K_Pedido.DataPropertyName = "K_Pedido";
            this.K_Pedido.HeaderText = "Clave pedido";
            this.K_Pedido.Name = "K_Pedido";
            this.K_Pedido.ReadOnly = true;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            // 
            // D_Estatus_Pedido
            // 
            this.D_Estatus_Pedido.DataPropertyName = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.HeaderText = "Estatus Pedido";
            this.D_Estatus_Pedido.Name = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.ReadOnly = true;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            // 
            // F_Pedido
            // 
            this.F_Pedido.DataPropertyName = "F_Pedido";
            this.F_Pedido.HeaderText = "Fecha pedido";
            this.F_Pedido.Name = "F_Pedido";
            this.F_Pedido.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Total_IVA
            // 
            this.Total_IVA.DataPropertyName = "Total_IVA";
            this.Total_IVA.HeaderText = "IVA";
            this.Total_IVA.Name = "Total_IVA";
            this.Total_IVA.ReadOnly = true;
            // 
            // Total_Pedido
            // 
            this.Total_Pedido.DataPropertyName = "Total_Pedido";
            this.Total_Pedido.HeaderText = "Total";
            this.Total_Pedido.Name = "Total_Pedido";
            this.Total_Pedido.ReadOnly = true;
            // 
            // FRM_CONSULTA_PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 546);
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.panel_filtros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FRM_CONSULTA_PEDIDOS";
            this.Text = "Consulta pedidos";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.panel_filtros, 0);
            this.Controls.SetChildIndex(this.panel_datos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.TextBox txtNoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarOficina;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxRemisionado;
        private System.Windows.Forms.CheckBox checkBoxCancelado;
        private Controles.ucPacientes ucPacientes1;
        private System.Windows.Forms.Label label6;
        private Controles.ucClientes ucClientes1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxAseguradora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pedido;
    }
}