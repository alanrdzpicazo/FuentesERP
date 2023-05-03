﻿namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Consulta_Inventario_Ubicacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblSaldoDisponible = new System.Windows.Forms.Label();
            this.LblTituloSaldoDisponible = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSinUbicacion = new System.Windows.Forms.CheckBox();
            this.cbxCompleta = new System.Windows.Forms.CheckBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(954, 488);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDetalle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 315);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.No_Lote,
            this.F_Caducidad,
            this.K_Almacen,
            this.D_Almacen,
            this.K_Oficina,
            this.D_Oficina,
            this.Cantidad_Disponible,
            this.Ubicacion});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 0);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.Size = new System.Drawing.Size(954, 315);
            this.grdDetalle.TabIndex = 2;
            this.grdDetalle.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblSaldoDisponible);
            this.panel2.Controls.Add(this.LblTituloSaldoDisponible);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 173);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // LblSaldoDisponible
            // 
            this.LblSaldoDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSaldoDisponible.AutoSize = true;
            this.LblSaldoDisponible.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldoDisponible.Location = new System.Drawing.Point(732, 122);
            this.LblSaldoDisponible.Name = "LblSaldoDisponible";
            this.LblSaldoDisponible.Size = new System.Drawing.Size(18, 18);
            this.LblSaldoDisponible.TabIndex = 30;
            this.LblSaldoDisponible.Text = "0";
            this.LblSaldoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTituloSaldoDisponible
            // 
            this.LblTituloSaldoDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloSaldoDisponible.AutoSize = true;
            this.LblTituloSaldoDisponible.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloSaldoDisponible.Location = new System.Drawing.Point(732, 95);
            this.LblTituloSaldoDisponible.Name = "LblTituloSaldoDisponible";
            this.LblTituloSaldoDisponible.Size = new System.Drawing.Size(210, 18);
            this.LblTituloSaldoDisponible.TabIndex = 29;
            this.LblTituloSaldoDisponible.Text = "Existencia Total Disponible";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxSinUbicacion);
            this.groupBox1.Controls.Add(this.cbxCompleta);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOficina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAlmacen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES";
            // 
            // cbxSinUbicacion
            // 
            this.cbxSinUbicacion.AutoSize = true;
            this.cbxSinUbicacion.Location = new System.Drawing.Point(582, 76);
            this.cbxSinUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSinUbicacion.Name = "cbxSinUbicacion";
            this.cbxSinUbicacion.Size = new System.Drawing.Size(107, 21);
            this.cbxSinUbicacion.TabIndex = 4;
            this.cbxSinUbicacion.Text = "Sin Ubicación";
            this.cbxSinUbicacion.UseVisualStyleBackColor = true;
            this.cbxSinUbicacion.CheckedChanged += new System.EventHandler(this.cbxSinUbicacion_CheckedChanged);
            // 
            // cbxCompleta
            // 
            this.cbxCompleta.AutoSize = true;
            this.cbxCompleta.Location = new System.Drawing.Point(472, 75);
            this.cbxCompleta.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCompleta.Name = "cbxCompleta";
            this.cbxCompleta.Size = new System.Drawing.Size(85, 21);
            this.cbxCompleta.TabIndex = 3;
            this.cbxCompleta.Text = "Completa";
            this.cbxCompleta.UseVisualStyleBackColor = true;
            this.cbxCompleta.CheckedChanged += new System.EventHandler(this.cbxCompleta_CheckedChanged);
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticulo.Location = new System.Drawing.Point(141, 75);
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
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artículo";
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
            this.txtOficina.Location = new System.Drawing.Point(141, 21);
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
            this.txtAlmacen.Location = new System.Drawing.Point(141, 48);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.ReadOnly = true;
            this.txtAlmacen.Size = new System.Drawing.Size(307, 24);
            this.txtAlmacen.TabIndex = 6;
            this.txtAlmacen.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(954, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ubicaciones de Artículos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "No.";
            this.K_Articulo.Name = "K_Articulo";
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.D_Articulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            // 
            // No_Lote
            // 
            this.No_Lote.DataPropertyName = "No_Lote";
            this.No_Lote.HeaderText = "LOTE";
            this.No_Lote.Name = "No_Lote";
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Format = "d /MM/ yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.F_Caducidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Caducidad.HeaderText = "Fec. Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.Visible = false;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            // 
            // K_Oficina
            // 
            this.K_Oficina.DataPropertyName = "K_Oficina";
            this.K_Oficina.HeaderText = "K_Oficina";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.Visible = false;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            // 
            // Cantidad_Disponible
            // 
            this.Cantidad_Disponible.DataPropertyName = "Cantidad_Disponible";
            dataGridViewCellStyle5.NullValue = null;
            this.Cantidad_Disponible.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad_Disponible.HeaderText = "Disponible";
            this.Cantidad_Disponible.Name = "Cantidad_Disponible";
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ubicacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // Frm_Consulta_Inventario_Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 565);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(970, 604);
            this.Name = "Frm_Consulta_Inventario_Ubicacion";
            this.Text = "CONSULTA DE UBICACION DE ARTICULOS POR ALMACÉN";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label LblSaldoDisponible;
        private System.Windows.Forms.Label LblTituloSaldoDisponible;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.CheckBox cbxSinUbicacion;
        private System.Windows.Forms.CheckBox cbxCompleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
    }
}