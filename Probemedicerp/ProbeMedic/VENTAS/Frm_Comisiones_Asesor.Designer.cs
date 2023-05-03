namespace ProbeMedic.VENTAS
{
    partial class Frm_Comisiones_Asesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Comisiones_Asesor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Comision_Asesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Asesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Celula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAsesor = new System.Windows.Forms.Button();
            this.txtClaveAsesor = new System.Windows.Forms.TextBox();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.LblAnio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 488);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDetalle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 375);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Comision_Asesor,
            this.K_Pedido,
            this.K_Asesor,
            this.Nombre,
            this.Porcentaje_Comision,
            this.Total_Pedido,
            this.Total_Comision,
            this.F_Aplicacion,
            this.D_Almacen,
            this.D_Oficina,
            this.F_Entregado,
            this.F_Registro,
            this.D_Aseguradora,
            this.D_Celula,
            this.Paciente,
            this.D_Cliente});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 0);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(954, 375);
            this.grdDetalle.TabIndex = 29;
            // 
            // K_Comision_Asesor
            // 
            this.K_Comision_Asesor.DataPropertyName = "K_Comision_Asesor";
            this.K_Comision_Asesor.HeaderText = "Clave";
            this.K_Comision_Asesor.Name = "K_Comision_Asesor";
            this.K_Comision_Asesor.ReadOnly = true;
            this.K_Comision_Asesor.Width = 70;
            // 
            // K_Pedido
            // 
            this.K_Pedido.DataPropertyName = "K_Pedido";
            this.K_Pedido.HeaderText = "Pedido No.";
            this.K_Pedido.Name = "K_Pedido";
            this.K_Pedido.ReadOnly = true;
            // 
            // K_Asesor
            // 
            this.K_Asesor.DataPropertyName = "K_Asesor";
            this.K_Asesor.HeaderText = "K_Asesor";
            this.K_Asesor.Name = "K_Asesor";
            this.K_Asesor.ReadOnly = true;
            this.K_Asesor.Visible = false;
            this.K_Asesor.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Asesor";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 260;
            // 
            // Porcentaje_Comision
            // 
            this.Porcentaje_Comision.DataPropertyName = "Porcentaje_Comision";
            this.Porcentaje_Comision.HeaderText = "Comisión %";
            this.Porcentaje_Comision.Name = "Porcentaje_Comision";
            this.Porcentaje_Comision.ReadOnly = true;
            this.Porcentaje_Comision.Visible = false;
            this.Porcentaje_Comision.Width = 135;
            // 
            // Total_Pedido
            // 
            this.Total_Pedido.DataPropertyName = "Total_Pedido";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total_Pedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total_Pedido.HeaderText = "Total Pedido";
            this.Total_Pedido.Name = "Total_Pedido";
            this.Total_Pedido.ReadOnly = true;
            this.Total_Pedido.Width = 120;
            // 
            // Total_Comision
            // 
            this.Total_Comision.DataPropertyName = "Total_Comision";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Total_Comision.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total_Comision.HeaderText = "Total Comisión";
            this.Total_Comision.Name = "Total_Comision";
            this.Total_Comision.ReadOnly = true;
            this.Total_Comision.Width = 130;
            // 
            // F_Aplicacion
            // 
            this.F_Aplicacion.DataPropertyName = "F_Aplicacion";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.F_Aplicacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Aplicacion.HeaderText = "Fec. Aplicación";
            this.F_Aplicacion.Name = "F_Aplicacion";
            this.F_Aplicacion.ReadOnly = true;
            this.F_Aplicacion.Width = 130;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.D_Almacen.DefaultCellStyle = dataGridViewCellStyle5;
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 120;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.D_Oficina.DefaultCellStyle = dataGridViewCellStyle6;
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 120;
            // 
            // F_Entregado
            // 
            this.F_Entregado.DataPropertyName = "F_Entregado";
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.F_Entregado.DefaultCellStyle = dataGridViewCellStyle7;
            this.F_Entregado.HeaderText = "Fec. Entregado";
            this.F_Entregado.Name = "F_Entregado";
            this.F_Entregado.ReadOnly = true;
            this.F_Entregado.Width = 130;
            // 
            // F_Registro
            // 
            this.F_Registro.DataPropertyName = "F_Registro";
            this.F_Registro.HeaderText = "Fec. Registro";
            this.F_Registro.Name = "F_Registro";
            this.F_Registro.ReadOnly = true;
            this.F_Registro.Width = 130;
            // 
            // D_Aseguradora
            // 
            this.D_Aseguradora.DataPropertyName = "D_Aseguradora";
            this.D_Aseguradora.HeaderText = "Aseguradora";
            this.D_Aseguradora.Name = "D_Aseguradora";
            this.D_Aseguradora.ReadOnly = true;
            this.D_Aseguradora.Width = 115;
            // 
            // D_Celula
            // 
            this.D_Celula.DataPropertyName = "D_Celula";
            this.D_Celula.HeaderText = "Célula";
            this.D_Celula.Name = "D_Celula";
            this.D_Celula.ReadOnly = true;
            this.D_Celula.Width = 120;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Width = 260;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 260;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAsesor);
            this.panel2.Controls.Add(this.txtClaveAsesor);
            this.panel2.Controls.Add(this.txtAsesor);
            this.panel2.Controls.Add(this.dtpFinal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpInicial);
            this.panel2.Controls.Add(this.LblAnio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 113);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // BtnAsesor
            // 
            this.BtnAsesor.Image = ((System.Drawing.Image)(resources.GetObject("BtnAsesor.Image")));
            this.BtnAsesor.Location = new System.Drawing.Point(492, 40);
            this.BtnAsesor.Name = "BtnAsesor";
            this.BtnAsesor.Size = new System.Drawing.Size(32, 24);
            this.BtnAsesor.TabIndex = 235;
            this.BtnAsesor.Tag = "";
            this.BtnAsesor.UseVisualStyleBackColor = true;
            this.BtnAsesor.Click += new System.EventHandler(this.BtnAsesor_Click);
            // 
            // txtClaveAsesor
            // 
            this.txtClaveAsesor.Location = new System.Drawing.Point(113, 40);
            this.txtClaveAsesor.Name = "txtClaveAsesor";
            this.txtClaveAsesor.ReadOnly = true;
            this.txtClaveAsesor.Size = new System.Drawing.Size(80, 24);
            this.txtClaveAsesor.TabIndex = 39;
            this.txtClaveAsesor.TabStop = false;
            // 
            // txtAsesor
            // 
            this.txtAsesor.Location = new System.Drawing.Point(195, 40);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.ReadOnly = true;
            this.txtAsesor.Size = new System.Drawing.Size(296, 24);
            this.txtAsesor.TabIndex = 38;
            this.txtAsesor.TabStop = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(309, 76);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(100, 24);
            this.dtpFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha Final";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(113, 77);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(100, 24);
            this.dtpInicial.TabIndex = 2;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnio.Location = new System.Drawing.Point(17, 81);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(86, 16);
            this.LblAnio.TabIndex = 34;
            this.LblAnio.Text = "Fecha Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Asesor";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(954, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Consulta de Comisiones por Asesor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Comisiones_Asesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 565);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Comisiones_Asesor";
            this.Text = "COMISIONES DE ASESOR";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.TextBox txtClaveAsesor;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Comision_Asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Aplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Celula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.Button BtnAsesor;
    }
}