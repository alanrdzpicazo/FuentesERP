namespace ProbeMedic.ENTREGAS
{
    partial class FRM_REGISTRO_PAGOS_REMISIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_REGISTRO_PAGOS_REMISIONES));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.txtOficinaLiquidacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaApertura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_registra_pagos = new System.Windows.Forms.Button();
            this.txtClaveEmpleadoRecibe = new System.Windows.Forms.TextBox();
            this.txtEmpleadoRecibe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveEmpleadoEntrega = new System.Windows.Forms.TextBox();
            this.txtEmpleadoEntrega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaLiquidacion = new System.Windows.Forms.Button();
            this.txtClaveLiquidacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.K_Liquidacion_Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Remision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coaseguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Remision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGO_REGISTRADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel_filtros.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(883, 29);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Registro entregas liquidación";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.txtClaveOficina);
            this.panel_filtros.Controls.Add(this.txtOficinaLiquidacion);
            this.panel_filtros.Controls.Add(this.label5);
            this.panel_filtros.Controls.Add(this.txtFechaApertura);
            this.panel_filtros.Controls.Add(this.label3);
            this.panel_filtros.Controls.Add(this.btn_registra_pagos);
            this.panel_filtros.Controls.Add(this.txtClaveEmpleadoRecibe);
            this.panel_filtros.Controls.Add(this.txtEmpleadoRecibe);
            this.panel_filtros.Controls.Add(this.label2);
            this.panel_filtros.Controls.Add(this.txtClaveEmpleadoEntrega);
            this.panel_filtros.Controls.Add(this.txtEmpleadoEntrega);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.btnBuscaLiquidacion);
            this.panel_filtros.Controls.Add(this.txtClaveLiquidacion);
            this.panel_filtros.Controls.Add(this.label4);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filtros.Location = new System.Drawing.Point(0, 67);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(883, 148);
            this.panel_filtros.TabIndex = 7;
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficina.Location = new System.Drawing.Point(248, 20);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.ReadOnly = true;
            this.txtClaveOficina.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficina.TabIndex = 31;
            // 
            // txtOficinaLiquidacion
            // 
            this.txtOficinaLiquidacion.Location = new System.Drawing.Point(306, 20);
            this.txtOficinaLiquidacion.Name = "txtOficinaLiquidacion";
            this.txtOficinaLiquidacion.ReadOnly = true;
            this.txtOficinaLiquidacion.Size = new System.Drawing.Size(217, 24);
            this.txtOficinaLiquidacion.TabIndex = 30;
            this.txtOficinaLiquidacion.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Oficina";
            // 
            // txtFechaApertura
            // 
            this.txtFechaApertura.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaApertura.Location = new System.Drawing.Point(131, 113);
            this.txtFechaApertura.Name = "txtFechaApertura";
            this.txtFechaApertura.Size = new System.Drawing.Size(142, 24);
            this.txtFechaApertura.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha apertura ";
            // 
            // btn_registra_pagos
            // 
            this.btn_registra_pagos.Location = new System.Drawing.Point(719, 22);
            this.btn_registra_pagos.Name = "btn_registra_pagos";
            this.btn_registra_pagos.Size = new System.Drawing.Size(152, 40);
            this.btn_registra_pagos.TabIndex = 26;
            this.btn_registra_pagos.Text = "Guardar entregas";
            this.btn_registra_pagos.UseVisualStyleBackColor = true;
            this.btn_registra_pagos.Click += new System.EventHandler(this.btn_registra_pagos_Click);
            // 
            // txtClaveEmpleadoRecibe
            // 
            this.txtClaveEmpleadoRecibe.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveEmpleadoRecibe.Location = new System.Drawing.Point(131, 83);
            this.txtClaveEmpleadoRecibe.Name = "txtClaveEmpleadoRecibe";
            this.txtClaveEmpleadoRecibe.ReadOnly = true;
            this.txtClaveEmpleadoRecibe.Size = new System.Drawing.Size(52, 24);
            this.txtClaveEmpleadoRecibe.TabIndex = 25;
            // 
            // txtEmpleadoRecibe
            // 
            this.txtEmpleadoRecibe.Location = new System.Drawing.Point(189, 83);
            this.txtEmpleadoRecibe.Name = "txtEmpleadoRecibe";
            this.txtEmpleadoRecibe.ReadOnly = true;
            this.txtEmpleadoRecibe.Size = new System.Drawing.Size(334, 24);
            this.txtEmpleadoRecibe.TabIndex = 24;
            this.txtEmpleadoRecibe.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Empleado Recibe";
            // 
            // txtClaveEmpleadoEntrega
            // 
            this.txtClaveEmpleadoEntrega.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveEmpleadoEntrega.Location = new System.Drawing.Point(131, 53);
            this.txtClaveEmpleadoEntrega.Name = "txtClaveEmpleadoEntrega";
            this.txtClaveEmpleadoEntrega.ReadOnly = true;
            this.txtClaveEmpleadoEntrega.Size = new System.Drawing.Size(52, 24);
            this.txtClaveEmpleadoEntrega.TabIndex = 22;
            // 
            // txtEmpleadoEntrega
            // 
            this.txtEmpleadoEntrega.Location = new System.Drawing.Point(189, 53);
            this.txtEmpleadoEntrega.Name = "txtEmpleadoEntrega";
            this.txtEmpleadoEntrega.ReadOnly = true;
            this.txtEmpleadoEntrega.Size = new System.Drawing.Size(334, 24);
            this.txtEmpleadoEntrega.TabIndex = 21;
            this.txtEmpleadoEntrega.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Empleado Entrega";
            // 
            // btnBuscaLiquidacion
            // 
            this.btnBuscaLiquidacion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaLiquidacion.Image")));
            this.btnBuscaLiquidacion.Location = new System.Drawing.Point(151, 19);
            this.btnBuscaLiquidacion.Name = "btnBuscaLiquidacion";
            this.btnBuscaLiquidacion.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaLiquidacion.TabIndex = 18;
            this.btnBuscaLiquidacion.Tag = "";
            this.btnBuscaLiquidacion.UseVisualStyleBackColor = true;
            this.btnBuscaLiquidacion.Click += new System.EventHandler(this.btnBuscaLiquidacion_Click);
            // 
            // txtClaveLiquidacion
            // 
            this.txtClaveLiquidacion.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveLiquidacion.Location = new System.Drawing.Point(93, 19);
            this.txtClaveLiquidacion.Name = "txtClaveLiquidacion";
            this.txtClaveLiquidacion.ReadOnly = true;
            this.txtClaveLiquidacion.Size = new System.Drawing.Size(52, 24);
            this.txtClaveLiquidacion.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Liquidación";
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.dgv_datos);
            this.panel_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos.Location = new System.Drawing.Point(0, 215);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(883, 292);
            this.panel_datos.TabIndex = 8;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AllowUserToResizeColumns = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Liquidacion_Empleados,
            this.K_Oficina,
            this.K_Remision,
            this.D_Oficina,
            this.D_Cliente,
            this.Coaseguro,
            this.Total_Remision,
            this.PAGO_REGISTRADO});
            this.dgv_datos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_datos.Location = new System.Drawing.Point(0, 0);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.Size = new System.Drawing.Size(883, 292);
            this.dgv_datos.TabIndex = 0;
            this.dgv_datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_datos_CellMouseDoubleClick);
            // 
            // K_Liquidacion_Empleados
            // 
            this.K_Liquidacion_Empleados.HeaderText = "Número liquidación";
            this.K_Liquidacion_Empleados.Name = "K_Liquidacion_Empleados";
            this.K_Liquidacion_Empleados.ReadOnly = true;
            this.K_Liquidacion_Empleados.Width = 135;
            // 
            // K_Oficina
            // 
            this.K_Oficina.HeaderText = "";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.ReadOnly = true;
            this.K_Oficina.Visible = false;
            this.K_Oficina.Width = 19;
            // 
            // K_Remision
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Remision.DefaultCellStyle = dataGridViewCellStyle1;
            this.K_Remision.HeaderText = "Num. Remsión";
            this.K_Remision.Name = "K_Remision";
            this.K_Remision.ReadOnly = true;
            this.K_Remision.Width = 112;
            // 
            // D_Oficina
            // 
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 73;
            // 
            // D_Cliente
            // 
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 73;
            // 
            // Coaseguro
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Coaseguro.DefaultCellStyle = dataGridViewCellStyle2;
            this.Coaseguro.HeaderText = "Coaseguro";
            this.Coaseguro.Name = "Coaseguro";
            this.Coaseguro.ReadOnly = true;
            this.Coaseguro.Width = 99;
            // 
            // Total_Remision
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Total_Remision.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total_Remision.HeaderText = "Total ";
            this.Total_Remision.Name = "Total_Remision";
            this.Total_Remision.ReadOnly = true;
            this.Total_Remision.Width = 67;
            // 
            // PAGO_REGISTRADO
            // 
            this.PAGO_REGISTRADO.HeaderText = "Entrega registrada";
            this.PAGO_REGISTRADO.Name = "PAGO_REGISTRADO";
            this.PAGO_REGISTRADO.ReadOnly = true;
            this.PAGO_REGISTRADO.Width = 113;
            // 
            // FRM_REGISTRO_PAGOS_REMISIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 546);
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.panel_filtros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FRM_REGISTRO_PAGOS_REMISIONES";
            this.Text = "Registro entrega de liquidaciónes";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.panel_filtros, 0);
            this.Controls.SetChildIndex(this.panel_datos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Button btnBuscaLiquidacion;
        private System.Windows.Forms.TextBox txtClaveLiquidacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpleadoEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registra_pagos;
        private System.Windows.Forms.TextBox txtClaveEmpleadoRecibe;
        private System.Windows.Forms.TextBox txtEmpleadoRecibe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveEmpleadoEntrega;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaApertura;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.TextBox txtOficinaLiquidacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Liquidacion_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Remision;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coaseguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Remision;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PAGO_REGISTRADO;
    }
}