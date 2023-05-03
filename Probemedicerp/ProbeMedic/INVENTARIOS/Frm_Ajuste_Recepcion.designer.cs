namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Ajuste_Recepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ajuste_Recepcion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Cantidad_por_Recibir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Recibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Nota_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Movimiento_Transito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsecutivo = new ProbeMedic.Controles.ucInteger32();
            this.btnBuscaTraspaso = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficinaEnvio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 278);
            this.panel2.TabIndex = 6;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad_por_Recibir,
            this.Cantidad_Movimiento,
            this.Cantidad_Recibida,
            this.D_Articulo,
            this.K_Nota_Recepcion,
            this.No_Lote,
            this.observaciones,
            this.K_Movimiento_Transito});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 0);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDetalle.Size = new System.Drawing.Size(1066, 278);
            this.grdDetalle.TabIndex = 4;
            this.grdDetalle.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDetalle_CellValidating);
            // 
            // Cantidad_por_Recibir
            // 
            this.Cantidad_por_Recibir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad_por_Recibir.DataPropertyName = "Cantidad_por_Recibir";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            this.Cantidad_por_Recibir.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad_por_Recibir.FillWeight = 90F;
            this.Cantidad_por_Recibir.HeaderText = "Cant. x Recibir";
            this.Cantidad_por_Recibir.MinimumWidth = 80;
            this.Cantidad_por_Recibir.Name = "Cantidad_por_Recibir";
            this.Cantidad_por_Recibir.ReadOnly = true;
            this.Cantidad_por_Recibir.Width = 122;
            // 
            // Cantidad_Movimiento
            // 
            this.Cantidad_Movimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad_Movimiento.DataPropertyName = "Cantidad_Movimiento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0";
            this.Cantidad_Movimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad_Movimiento.FillWeight = 95F;
            this.Cantidad_Movimiento.HeaderText = "Cant. Traspaso";
            this.Cantidad_Movimiento.MinimumWidth = 85;
            this.Cantidad_Movimiento.Name = "Cantidad_Movimiento";
            this.Cantidad_Movimiento.ReadOnly = true;
            this.Cantidad_Movimiento.Width = 114;
            // 
            // Cantidad_Recibida
            // 
            this.Cantidad_Recibida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad_Recibida.DataPropertyName = "Cantidad_Recibida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkBlue;
            this.Cantidad_Recibida.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad_Recibida.FillWeight = 90F;
            this.Cantidad_Recibida.HeaderText = "Cant. Recibida";
            this.Cantidad_Recibida.MinimumWidth = 55;
            this.Cantidad_Recibida.Name = "Cantidad_Recibida";
            this.Cantidad_Recibida.Visible = false;
            // 
            // D_Articulo
            // 
            this.D_Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // K_Nota_Recepcion
            // 
            this.K_Nota_Recepcion.DataPropertyName = "K_Nota_Recepcion";
            this.K_Nota_Recepcion.FillWeight = 82.28452F;
            this.K_Nota_Recepcion.HeaderText = "No. Recepción";
            this.K_Nota_Recepcion.Name = "K_Nota_Recepcion";
            this.K_Nota_Recepcion.ReadOnly = true;
            this.K_Nota_Recepcion.Visible = false;
            // 
            // No_Lote
            // 
            this.No_Lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.No_Lote.DataPropertyName = "No_Lote";
            this.No_Lote.FillWeight = 120F;
            this.No_Lote.HeaderText = "Lote";
            this.No_Lote.Name = "No_Lote";
            this.No_Lote.ReadOnly = true;
            this.No_Lote.Width = 60;
            // 
            // observaciones
            // 
            this.observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 122;
            // 
            // K_Movimiento_Transito
            // 
            this.K_Movimiento_Transito.DataPropertyName = "K_Movimiento_Transito";
            this.K_Movimiento_Transito.HeaderText = "K_Movimiento_Transito";
            this.K_Movimiento_Transito.Name = "K_Movimiento_Transito";
            this.K_Movimiento_Transito.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1066, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Recepción de Articulos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConsecutivo);
            this.groupBox1.Controls.Add(this.btnBuscaTraspaso);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOficinaEnvio);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 151);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS ENVIO";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(129, 22);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(94, 24);
            this.txtConsecutivo.TabIndex = 1;
            // 
            // btnBuscaTraspaso
            // 
            this.btnBuscaTraspaso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaTraspaso.Image")));
            this.btnBuscaTraspaso.Location = new System.Drawing.Point(225, 22);
            this.btnBuscaTraspaso.Name = "btnBuscaTraspaso";
            this.btnBuscaTraspaso.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaTraspaso.TabIndex = 28;
            this.btnBuscaTraspaso.UseVisualStyleBackColor = true;
            this.btnBuscaTraspaso.Visible = false;
            this.btnBuscaTraspaso.Click += new System.EventHandler(this.btnBuscaTraspaso_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(129, 78);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(399, 54);
            this.txtObservaciones.TabIndex = 27;
            this.txtObservaciones.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Folio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oficina";
            // 
            // txtOficinaEnvio
            // 
            this.txtOficinaEnvio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOficinaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOficinaEnvio.Location = new System.Drawing.Point(129, 50);
            this.txtOficinaEnvio.Name = "txtOficinaEnvio";
            this.txtOficinaEnvio.ReadOnly = true;
            this.txtOficinaEnvio.Size = new System.Drawing.Size(307, 24);
            this.txtOficinaEnvio.TabIndex = 5;
            this.txtOficinaEnvio.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxAlmacen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOficina);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(552, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 151);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS RECEPCIÓN";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(99, 80);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(392, 24);
            this.cbxAlmacen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Almacen";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(101, 50);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(334, 24);
            this.txtOficina.TabIndex = 22;
            this.txtOficina.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Oficina";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 191);
            this.panel1.TabIndex = 5;
            // 
            // Frm_Ajuste_Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Ajuste_Recepcion";
            this.Text = "RECEPCION DE TRASPASO";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscaTraspaso;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficinaEnvio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Controles.ucInteger32 txtConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_por_Recibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Recibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Nota_Recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Movimiento_Transito;
    }
}