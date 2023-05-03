namespace ProbeMedic.FACTURACION
{
    partial class FRM_CONSULTA_FACTURAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CONSULTA_FACTURAS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.D_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Facturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucTipoVenta1 = new ProbeMedic.Controles.ucTipoVenta();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_F_Final = new System.Windows.Forms.DateTimePicker();
            this.dtp_F_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDatos);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.sd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 452);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToOrderColumns = true;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_Serie,
            this.K_Factura,
            this.UUID,
            this.F_Facturacion,
            this.Total_Factura});
            this.grdDatos.Location = new System.Drawing.Point(3, 189);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1135, 260);
            this.grdDatos.TabIndex = 77;
            this.grdDatos.SelectionChanged += new System.EventHandler(this.grdDatos_SelectionChanged);
            // 
            // D_Serie
            // 
            this.D_Serie.DataPropertyName = "D_Serie";
            this.D_Serie.HeaderText = "Serie";
            this.D_Serie.Name = "D_Serie";
            this.D_Serie.ReadOnly = true;
            // 
            // K_Factura
            // 
            this.K_Factura.DataPropertyName = "K_Factura";
            this.K_Factura.HeaderText = "Factura";
            this.K_Factura.Name = "K_Factura";
            this.K_Factura.ReadOnly = true;
            // 
            // UUID
            // 
            this.UUID.DataPropertyName = "UUID";
            this.UUID.HeaderText = "Folio Fiscal";
            this.UUID.Name = "UUID";
            this.UUID.ReadOnly = true;
            // 
            // F_Facturacion
            // 
            this.F_Facturacion.DataPropertyName = "F_Factura";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Facturacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Facturacion.HeaderText = "Fec. Facturación";
            this.F_Facturacion.Name = "F_Facturacion";
            this.F_Facturacion.ReadOnly = true;
            // 
            // Total_Factura
            // 
            this.Total_Factura.DataPropertyName = "Total_Factura";
            dataGridViewCellStyle3.Format = "N2";
            this.Total_Factura.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total_Factura.HeaderText = "Total";
            this.Total_Factura.Name = "Total_Factura";
            this.Total_Factura.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ucTipoVenta1);
            this.groupBox1.Controls.Add(this.btnBuscaCliente);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtClaveCliente);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtp_F_Final);
            this.groupBox1.Controls.Add(this.dtp_F_Inicial);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 159);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // ucTipoVenta1
            // 
            this.ucTipoVenta1.Location = new System.Drawing.Point(115, 107);
            this.ucTipoVenta1.Margin = new System.Windows.Forms.Padding(4);
            this.ucTipoVenta1.Name = "ucTipoVenta1";
            this.ucTipoVenta1.Size = new System.Drawing.Size(319, 33);
            this.ucTipoVenta1.TabIndex = 80;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(596, 19);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaCliente.TabIndex = 77;
            this.btnBuscaCliente.Tag = "";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCliente.Location = new System.Drawing.Point(175, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(420, 24);
            this.txtCliente.TabIndex = 79;
            this.txtCliente.TabStop = false;
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtClaveCliente.Location = new System.Drawing.Point(121, 19);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.Size = new System.Drawing.Size(52, 24);
            this.txtClaveCliente.TabIndex = 78;
            this.txtClaveCliente.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(560, 115);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(444, 23);
            this.txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.5F);
            this.label3.Location = new System.Drawing.Point(509, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.5F);
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.5F);
            this.label11.Location = new System.Drawing.Point(23, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 73;
            this.label11.Text = "Fecha Final";
            // 
            // dtp_F_Final
            // 
            this.dtp_F_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_F_Final.Location = new System.Drawing.Point(120, 81);
            this.dtp_F_Final.Name = "dtp_F_Final";
            this.dtp_F_Final.Size = new System.Drawing.Size(261, 22);
            this.dtp_F_Final.TabIndex = 33;
            // 
            // dtp_F_Inicial
            // 
            this.dtp_F_Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_F_Inicial.Location = new System.Drawing.Point(120, 50);
            this.dtp_F_Inicial.Name = "dtp_F_Inicial";
            this.dtp_F_Inicial.Size = new System.Drawing.Size(261, 22);
            this.dtp_F_Inicial.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.5F);
            this.label10.Location = new System.Drawing.Point(23, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Fecha Inicial";
            // 
            // sd
            // 
            this.sd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.sd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.ForeColor = System.Drawing.SystemColors.Control;
            this.sd.Location = new System.Drawing.Point(0, 0);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(1141, 21);
            this.sd.TabIndex = 30;
            this.sd.Text = "Consulta de Facturas";
            this.sd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_CONSULTA_FACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 529);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_CONSULTA_FACTURAS";
            this.Text = "CONSULTA FACTURAS";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_F_Final;
        private System.Windows.Forms.DateTimePicker dtp_F_Inicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private Controles.ucTipoVenta ucTipoVenta1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn UUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Facturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Factura;
    }
}