namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Consulta_inventario_Detalle_Movimiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSaldoDisponible = new System.Windows.Forms.Label();
            this.LblTituloSaldoDisponible = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdDetalleMovimiento = new System.Windows.Forms.DataGridView();
            this.ID_MovimientoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 127);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.LblSaldoDisponible);
            this.groupBox1.Controls.Add(this.LblTituloSaldoDisponible);
            this.groupBox1.Controls.Add(this.txtLote);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnidadMedida);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOficina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAlmacen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 90);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES";
            // 
            // LblSaldoDisponible
            // 
            this.LblSaldoDisponible.AutoSize = true;
            this.LblSaldoDisponible.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldoDisponible.Location = new System.Drawing.Point(927, 57);
            this.LblSaldoDisponible.Name = "LblSaldoDisponible";
            this.LblSaldoDisponible.Size = new System.Drawing.Size(44, 16);
            this.LblSaldoDisponible.TabIndex = 30;
            this.LblSaldoDisponible.Text = "0 KGS";
            this.LblSaldoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTituloSaldoDisponible
            // 
            this.LblTituloSaldoDisponible.AutoSize = true;
            this.LblTituloSaldoDisponible.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloSaldoDisponible.Location = new System.Drawing.Point(927, 36);
            this.LblTituloSaldoDisponible.Name = "LblTituloSaldoDisponible";
            this.LblTituloSaldoDisponible.Size = new System.Drawing.Size(185, 16);
            this.LblTituloSaldoDisponible.TabIndex = 29;
            this.LblTituloSaldoDisponible.Text = "Existencia Disponible x Lote";
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLote.Location = new System.Drawing.Point(723, 48);
            this.txtLote.Name = "txtLote";
            this.txtLote.ReadOnly = true;
            this.txtLote.Size = new System.Drawing.Size(166, 24);
            this.txtLote.TabIndex = 10;
            this.txtLote.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(678, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lote";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadMedida.Location = new System.Drawing.Point(505, 48);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.ReadOnly = true;
            this.txtUnidadMedida.Size = new System.Drawing.Size(166, 24);
            this.txtUnidadMedida.TabIndex = 7;
            this.txtUnidadMedida.TabStop = false;
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticulo.Location = new System.Drawing.Point(505, 21);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(307, 24);
            this.txtArticulo.TabIndex = 8;
            this.txtArticulo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidad Medida";
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
            // txtOficina
            // 
            this.txtOficina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOficina.Location = new System.Drawing.Point(80, 21);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(307, 24);
            this.txtOficina.TabIndex = 5;
            this.txtOficina.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Almacen";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlmacen.Location = new System.Drawing.Point(80, 48);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.ReadOnly = true;
            this.txtAlmacen.Size = new System.Drawing.Size(307, 24);
            this.txtAlmacen.TabIndex = 6;
            this.txtAlmacen.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1144, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Detalles de Movimientos del Artículo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdDetalleMovimiento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 342);
            this.panel2.TabIndex = 3;
            // 
            // grdDetalleMovimiento
            // 
            this.grdDetalleMovimiento.AllowUserToAddRows = false;
            this.grdDetalleMovimiento.AllowUserToDeleteRows = false;
            this.grdDetalleMovimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalleMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleMovimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MovimientoDetalle,
            this.ID_Movimiento,
            this.K_Tipo_Movimiento,
            this.D_Tipo_Movimiento,
            this.Cantidad_Movimiento,
            this.Observaciones,
            this.F_Movimiento,
            this.K_Usuario_Movimiento,
            this.D_Usuario_Movimiento});
            this.grdDetalleMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalleMovimiento.Location = new System.Drawing.Point(0, 0);
            this.grdDetalleMovimiento.Name = "grdDetalleMovimiento";
            this.grdDetalleMovimiento.ReadOnly = true;
            this.grdDetalleMovimiento.RowHeadersVisible = false;
            this.grdDetalleMovimiento.Size = new System.Drawing.Size(1144, 342);
            this.grdDetalleMovimiento.TabIndex = 0;
            this.grdDetalleMovimiento.DataSourceChanged += new System.EventHandler(this.grdDetalleMovimiento_DataSourceChanged);
            // 
            // ID_MovimientoDetalle
            // 
            this.ID_MovimientoDetalle.DataPropertyName = "ID_MovimientoDetalle";
            this.ID_MovimientoDetalle.HeaderText = "ID_MovimientoDetalle";
            this.ID_MovimientoDetalle.Name = "ID_MovimientoDetalle";
            this.ID_MovimientoDetalle.ReadOnly = true;
            this.ID_MovimientoDetalle.Visible = false;
            // 
            // ID_Movimiento
            // 
            this.ID_Movimiento.DataPropertyName = "ID_Movimiento";
            this.ID_Movimiento.HeaderText = "ID_Movimiento";
            this.ID_Movimiento.Name = "ID_Movimiento";
            this.ID_Movimiento.ReadOnly = true;
            this.ID_Movimiento.Visible = false;
            // 
            // K_Tipo_Movimiento
            // 
            this.K_Tipo_Movimiento.DataPropertyName = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.HeaderText = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.Name = "K_Tipo_Movimiento";
            this.K_Tipo_Movimiento.ReadOnly = true;
            this.K_Tipo_Movimiento.Visible = false;
            // 
            // D_Tipo_Movimiento
            // 
            this.D_Tipo_Movimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.D_Tipo_Movimiento.DataPropertyName = "D_Tipo_Movimiento";
            this.D_Tipo_Movimiento.HeaderText = "Tipo Movimiento";
            this.D_Tipo_Movimiento.Name = "D_Tipo_Movimiento";
            this.D_Tipo_Movimiento.ReadOnly = true;
            // 
            // Cantidad_Movimiento
            // 
            this.Cantidad_Movimiento.DataPropertyName = "Cantidad_Movimiento";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = "0";
            this.Cantidad_Movimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad_Movimiento.HeaderText = "Cant. Movimiento";
            this.Cantidad_Movimiento.Name = "Cantidad_Movimiento";
            this.Cantidad_Movimiento.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // F_Movimiento
            // 
            this.F_Movimiento.DataPropertyName = "F_Movimiento";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Movimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Movimiento.HeaderText = "Fecha";
            this.F_Movimiento.Name = "F_Movimiento";
            this.F_Movimiento.ReadOnly = true;
            // 
            // K_Usuario_Movimiento
            // 
            this.K_Usuario_Movimiento.DataPropertyName = "K_Usuario_Movimiento";
            this.K_Usuario_Movimiento.HeaderText = "K_Usuario_Movimiento";
            this.K_Usuario_Movimiento.Name = "K_Usuario_Movimiento";
            this.K_Usuario_Movimiento.ReadOnly = true;
            this.K_Usuario_Movimiento.Visible = false;
            // 
            // D_Usuario_Movimiento
            // 
            this.D_Usuario_Movimiento.DataPropertyName = "D_Usuario_Movimiento";
            this.D_Usuario_Movimiento.HeaderText = "Usuario";
            this.D_Usuario_Movimiento.Name = "D_Usuario_Movimiento";
            this.D_Usuario_Movimiento.ReadOnly = true;
            // 
            // Frm_Consulta_inventario_Detalle_Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Consulta_inventario_Detalle_Movimiento";
            this.Text = "DETALLES DE MOVIMIENTOS DEL ARTÍCULO";
            this.Load += new System.EventHandler(this.Frm_Consulta_inventario_Detalle_Movimiento_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleMovimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdDetalleMovimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSaldoDisponible;
        private System.Windows.Forms.Label LblTituloSaldoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MovimientoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Movimiento;
    }
}