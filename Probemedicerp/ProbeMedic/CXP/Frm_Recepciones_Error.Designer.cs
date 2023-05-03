namespace ProbeMedic.CXP
{
    partial class Frm_Recepciones_Error
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoMoneda = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.grdRecepciones = new System.Windows.Forms.DataGridView();
            this.K_Operacion_Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCEmisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MensajeError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Detalle_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRequerida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionesDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecepciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1471, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recepciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 83);
            this.panel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtProveedor);
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(567, 75);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proveedores";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(113, 28);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(363, 28);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipoMoneda);
            this.groupBox2.Location = new System.Drawing.Point(1018, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(449, 75);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Moneda";
            // 
            // cmbTipoMoneda
            // 
            this.cmbTipoMoneda.FormattingEnabled = true;
            this.cmbTipoMoneda.Location = new System.Drawing.Point(53, 24);
            this.cmbTipoMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoMoneda.Name = "cmbTipoMoneda";
            this.cmbTipoMoneda.Size = new System.Drawing.Size(342, 29);
            this.cmbTipoMoneda.TabIndex = 5;
            this.cmbTipoMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMoneda_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.txtFechaInicio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(579, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(432, 75);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaFin.Location = new System.Drawing.Point(284, 28);
            this.txtFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(112, 28);
            this.txtFechaFin.TabIndex = 4;
            this.txtFechaFin.Value = new System.DateTime(2014, 5, 28, 22, 29, 48, 0);
            this.txtFechaFin.ValueChanged += new System.EventHandler(this.txtFechaFin_ValueChanged);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.Location = new System.Drawing.Point(102, 28);
            this.txtFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(112, 28);
            this.txtFechaInicio.TabIndex = 3;
            this.txtFechaInicio.Value = new System.DateTime(2014, 5, 28, 22, 29, 31, 0);
            this.txtFechaInicio.ValueChanged += new System.EventHandler(this.txtFechaInicio_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(35, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Desde";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(222, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Hasta";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.grdRecepciones);
            this.pnlEncabezado.Controls.Add(this.panel1);
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 38);
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1471, 394);
            this.pnlEncabezado.TabIndex = 4;
            // 
            // grdRecepciones
            // 
            this.grdRecepciones.AllowUserToAddRows = false;
            this.grdRecepciones.AllowUserToDeleteRows = false;
            this.grdRecepciones.BackgroundColor = System.Drawing.Color.White;
            this.grdRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Operacion_Error,
            this.NombreEmisor,
            this.RFCEmisor,
            this.Fecha,
            this.D_Tipo_Moneda,
            this.Subtotal,
            this.TotalIVA,
            this.Total,
            this.RutaArchivo,
            this.MensajeError});
            this.grdRecepciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdRecepciones.Location = new System.Drawing.Point(0, 116);
            this.grdRecepciones.Margin = new System.Windows.Forms.Padding(4);
            this.grdRecepciones.MultiSelect = false;
            this.grdRecepciones.Name = "grdRecepciones";
            this.grdRecepciones.ReadOnly = true;
            this.grdRecepciones.RowHeadersVisible = false;
            this.grdRecepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRecepciones.Size = new System.Drawing.Size(1471, 278);
            this.grdRecepciones.TabIndex = 5;
            this.grdRecepciones.SelectionChanged += new System.EventHandler(this.grdRecepciones_SelectionChanged);
            // 
            // K_Operacion_Error
            // 
            this.K_Operacion_Error.DataPropertyName = "K_Operacion_Error";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Operacion_Error.DefaultCellStyle = dataGridViewCellStyle1;
            this.K_Operacion_Error.HeaderText = "No.";
            this.K_Operacion_Error.Name = "K_Operacion_Error";
            this.K_Operacion_Error.ReadOnly = true;
            this.K_Operacion_Error.Width = 50;
            // 
            // NombreEmisor
            // 
            this.NombreEmisor.DataPropertyName = "NombreEmisor";
            this.NombreEmisor.HeaderText = "Nombre";
            this.NombreEmisor.Name = "NombreEmisor";
            this.NombreEmisor.ReadOnly = true;
            this.NombreEmisor.Width = 270;
            // 
            // RFCEmisor
            // 
            this.RFCEmisor.DataPropertyName = "RFCEmisor";
            this.RFCEmisor.HeaderText = "RFC";
            this.RFCEmisor.Name = "RFCEmisor";
            this.RFCEmisor.ReadOnly = true;
            this.RFCEmisor.Width = 110;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // D_Tipo_Moneda
            // 
            this.D_Tipo_Moneda.DataPropertyName = "D_Tipo_Moneda";
            dataGridViewCellStyle3.NullValue = null;
            this.D_Tipo_Moneda.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Tipo_Moneda.HeaderText = "Tipo Moneda";
            this.D_Tipo_Moneda.Name = "D_Tipo_Moneda";
            this.D_Tipo_Moneda.ReadOnly = true;
            this.D_Tipo_Moneda.Width = 80;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 80;
            // 
            // TotalIVA
            // 
            this.TotalIVA.DataPropertyName = "TotalIVA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.TotalIVA.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalIVA.HeaderText = "IVA";
            this.TotalIVA.Name = "TotalIVA";
            this.TotalIVA.ReadOnly = true;
            this.TotalIVA.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // RutaArchivo
            // 
            this.RutaArchivo.DataPropertyName = "RutaArchivo";
            this.RutaArchivo.HeaderText = "Ruta Archivo";
            this.RutaArchivo.Name = "RutaArchivo";
            this.RutaArchivo.ReadOnly = true;
            this.RutaArchivo.Width = 200;
            // 
            // MensajeError
            // 
            this.MensajeError.DataPropertyName = "MensajeError";
            this.MensajeError.HeaderText = "Mensaje";
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1471, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.BackgroundColor = System.Drawing.Color.White;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Detalle_Requisicion,
            this.D_Articulo,
            this.CantidadRequerida,
            this.Unitario,
            this.PrecioTotal,
            this.ObservacionesDetalle});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdDetalle.Location = new System.Drawing.Point(0, 465);
            this.grdDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(1471, 197);
            this.grdDetalle.TabIndex = 8;
            // 
            // K_Detalle_Requisicion
            // 
            this.K_Detalle_Requisicion.DataPropertyName = "K_Operacion";
            this.K_Detalle_Requisicion.HeaderText = "K_Operacion";
            this.K_Detalle_Requisicion.Name = "K_Detalle_Requisicion";
            this.K_Detalle_Requisicion.ReadOnly = true;
            this.K_Detalle_Requisicion.Visible = false;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "Concepto";
            this.D_Articulo.HeaderText = "Concepto";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 580;
            // 
            // CantidadRequerida
            // 
            this.CantidadRequerida.DataPropertyName = "Cantidad";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CantidadRequerida.DefaultCellStyle = dataGridViewCellStyle7;
            this.CantidadRequerida.HeaderText = "Cantidad";
            this.CantidadRequerida.Name = "CantidadRequerida";
            this.CantidadRequerida.ReadOnly = true;
            // 
            // Unitario
            // 
            this.Unitario.DataPropertyName = "UnidadMedida";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.Unitario.HeaderText = "U. Medida";
            this.Unitario.Name = "Unitario";
            this.Unitario.ReadOnly = true;
            this.Unitario.Width = 150;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.PrecioTotal.HeaderText = "PrecioUnitario";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            this.PrecioTotal.Width = 150;
            // 
            // ObservacionesDetalle
            // 
            this.ObservacionesDetalle.DataPropertyName = "ImporteTotal";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.ObservacionesDetalle.DefaultCellStyle = dataGridViewCellStyle10;
            this.ObservacionesDetalle.HeaderText = "Importe Total";
            this.ObservacionesDetalle.Name = "ObservacionesDetalle";
            this.ObservacionesDetalle.ReadOnly = true;
            this.ObservacionesDetalle.Width = 150;
            // 
            // Frm_Recepciones_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 717);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlEncabezado);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_Recepciones_Error";
            this.Text = "Recepciones XML con Error";
            this.Load += new System.EventHandler(this.Frm_Recepciones_Error_Load);
            this.Controls.SetChildIndex(this.pnlEncabezado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.grdDetalle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecepciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoMoneda;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Detalle_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRequerida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionesDetalle;
        private System.Windows.Forms.DataGridView grdRecepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Operacion_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MensajeError;
    }
}