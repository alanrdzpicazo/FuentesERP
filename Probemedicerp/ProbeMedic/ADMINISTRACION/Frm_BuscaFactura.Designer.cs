namespace ProbeMedic.CUENTASXCOBRAR
{
    partial class FRM_BUSCA_FACTURA
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.grd_Datos = new System.Windows.Forms.DataGridView();
            this.K_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total_Abonado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtK_Factura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtD_Cliente = new System.Windows.Forms.TextBox();
            this.txtK_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ucOficinas1 = new ProbeMedic.Controles.ucOficinas();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd_Datos);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 256);
            this.panel2.TabIndex = 3;
            this.panel2.TabStop = true;
            // 
            // grd_Datos
            // 
            this.grd_Datos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grd_Datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Factura,
            this.K_Almacen,
            this.D_Almacen,
            this.Descuento,
            this.SubTotal,
            this.Total_Iva,
            this.Total_Factura,
            this.Monto_Total_Abonado,
            this.Monto_Total_Pendiente,
            this.F_Factura,
            this.F_Vencimiento,
            this.K_Cliente1,
            this.D_Cliente1,
            this.K_Oficina1,
            this.D_Oficina1});
            this.grd_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Datos.Location = new System.Drawing.Point(0, 0);
            this.grd_Datos.Margin = new System.Windows.Forms.Padding(2);
            this.grd_Datos.MultiSelect = false;
            this.grd_Datos.Name = "grd_Datos";
            this.grd_Datos.ReadOnly = true;
            this.grd_Datos.RowHeadersVisible = false;
            this.grd_Datos.RowTemplate.Height = 24;
            this.grd_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Datos.Size = new System.Drawing.Size(853, 256);
            this.grd_Datos.TabIndex = 4;
            this.grd_Datos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grd_Datos_KeyDown);
            this.grd_Datos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grd_Datos_MouseDoubleClick);
            this.grd_Datos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grd_Datos_PreviewKeyDown);
            // 
            // K_Factura
            // 
            this.K_Factura.DataPropertyName = "K_Factura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.K_Factura.DefaultCellStyle = dataGridViewCellStyle3;
            this.K_Factura.HeaderText = "No. Factura";
            this.K_Factura.Name = "K_Factura";
            this.K_Factura.ReadOnly = true;
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
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Visible = false;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Total_Iva
            // 
            this.Total_Iva.DataPropertyName = "Total_Iva";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Total_Iva.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total_Iva.HeaderText = "Iva";
            this.Total_Iva.Name = "Total_Iva";
            this.Total_Iva.ReadOnly = true;
            // 
            // Total_Factura
            // 
            this.Total_Factura.DataPropertyName = "Total_Factura";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Total_Factura.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total_Factura.HeaderText = "Total Factura";
            this.Total_Factura.Name = "Total_Factura";
            this.Total_Factura.ReadOnly = true;
            // 
            // Monto_Total_Abonado
            // 
            this.Monto_Total_Abonado.DataPropertyName = "Monto_Total_Abonado";
            this.Monto_Total_Abonado.HeaderText = "Monto_Total_Abonado";
            this.Monto_Total_Abonado.Name = "Monto_Total_Abonado";
            this.Monto_Total_Abonado.ReadOnly = true;
            this.Monto_Total_Abonado.Visible = false;
            // 
            // Monto_Total_Pendiente
            // 
            this.Monto_Total_Pendiente.DataPropertyName = "Monto_Total_Pendiente";
            this.Monto_Total_Pendiente.HeaderText = "Monto_Total_Pendiente";
            this.Monto_Total_Pendiente.Name = "Monto_Total_Pendiente";
            this.Monto_Total_Pendiente.ReadOnly = true;
            this.Monto_Total_Pendiente.Visible = false;
            // 
            // F_Factura
            // 
            this.F_Factura.DataPropertyName = "F_Factura";
            dataGridViewCellStyle7.Format = "dd MM yyyy";
            this.F_Factura.DefaultCellStyle = dataGridViewCellStyle7;
            this.F_Factura.HeaderText = "F. Factura";
            this.F_Factura.Name = "F_Factura";
            this.F_Factura.ReadOnly = true;
            // 
            // F_Vencimiento
            // 
            this.F_Vencimiento.DataPropertyName = "F_Vencimiento";
            this.F_Vencimiento.HeaderText = "F_Vencimiento";
            this.F_Vencimiento.Name = "F_Vencimiento";
            this.F_Vencimiento.ReadOnly = true;
            this.F_Vencimiento.Visible = false;
            // 
            // K_Cliente1
            // 
            this.K_Cliente1.DataPropertyName = "K_Cliente";
            this.K_Cliente1.HeaderText = "K_Cliente";
            this.K_Cliente1.Name = "K_Cliente1";
            this.K_Cliente1.ReadOnly = true;
            this.K_Cliente1.Visible = false;
            // 
            // D_Cliente1
            // 
            this.D_Cliente1.DataPropertyName = "D_Cliente";
            this.D_Cliente1.HeaderText = "D_Cliente";
            this.D_Cliente1.Name = "D_Cliente1";
            this.D_Cliente1.ReadOnly = true;
            this.D_Cliente1.Visible = false;
            // 
            // K_Oficina1
            // 
            this.K_Oficina1.DataPropertyName = "K_Oficina";
            this.K_Oficina1.HeaderText = "K_Oficina";
            this.K_Oficina1.Name = "K_Oficina1";
            this.K_Oficina1.ReadOnly = true;
            this.K_Oficina1.Visible = false;
            // 
            // D_Oficina1
            // 
            this.D_Oficina1.DataPropertyName = "D_Oficina";
            this.D_Oficina1.HeaderText = "D_Oficina";
            this.D_Oficina1.Name = "D_Oficina1";
            this.D_Oficina1.ReadOnly = true;
            this.D_Oficina1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtK_Factura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtD_Cliente);
            this.panel1.Controls.Add(this.txtK_Cliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ucOficinas1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 107);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // txtK_Factura
            // 
            this.txtK_Factura.Location = new System.Drawing.Point(99, 72);
            this.txtK_Factura.Margin = new System.Windows.Forms.Padding(2);
            this.txtK_Factura.Name = "txtK_Factura";
            this.txtK_Factura.Size = new System.Drawing.Size(117, 24);
            this.txtK_Factura.TabIndex = 2;
            this.txtK_Factura.TextChanged += new System.EventHandler(this.txtK_Factura_TextChanged);
            this.txtK_Factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_Factura_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // txtD_Cliente
            // 
            this.txtD_Cliente.Location = new System.Drawing.Point(180, 13);
            this.txtD_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtD_Cliente.Name = "txtD_Cliente";
            this.txtD_Cliente.ReadOnly = true;
            this.txtD_Cliente.Size = new System.Drawing.Size(380, 24);
            this.txtD_Cliente.TabIndex = 5;
            this.txtD_Cliente.TabStop = false;
            // 
            // txtK_Cliente
            // 
            this.txtK_Cliente.Location = new System.Drawing.Point(98, 13);
            this.txtK_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtK_Cliente.Name = "txtK_Cliente";
            this.txtK_Cliente.ReadOnly = true;
            this.txtK_Cliente.Size = new System.Drawing.Size(79, 24);
            this.txtK_Cliente.TabIndex = 4;
            this.txtK_Cliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oficina";
            // 
            // ucOficinas1
            // 
            this.ucOficinas1.kOficina = 0;
            this.ucOficinas1.Location = new System.Drawing.Point(97, 37);
            this.ucOficinas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucOficinas1.Name = "ucOficinas1";
            this.ucOficinas1.Size = new System.Drawing.Size(276, 30);
            this.ucOficinas1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Factura";
            // 
            // FRM_BUSCA_FACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FRM_BUSCA_FACTURA";
            this.Text = "BUSCA FACTURA";
            this.Shown += new System.EventHandler(this.FRM_BUSCA_FACTURA_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Controles.ucOficinas ucOficinas1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtD_Cliente;
        private System.Windows.Forms.TextBox txtK_Cliente;
        private System.Windows.Forms.TextBox txtK_Factura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total_Abonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina1;
    }
}