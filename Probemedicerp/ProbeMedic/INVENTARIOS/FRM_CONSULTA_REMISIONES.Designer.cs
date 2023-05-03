﻿namespace ProbeMedic.INVENTARIOS
{
    partial class FRM_CONSULTA_REMISIONES
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
            this.GrdDatos = new System.Windows.Forms.DataGridView();
            this.K_Remision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Remision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Remision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Entregada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Cancelada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtK_Remision = new System.Windows.Forms.TextBox();
            this.DtpF_Inicial = new System.Windows.Forms.DateTimePicker();
            this.DtpF_Final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxAlmacen = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdDatos
            // 
            this.GrdDatos.AllowUserToAddRows = false;
            this.GrdDatos.AllowUserToDeleteRows = false;
            this.GrdDatos.AllowUserToResizeColumns = false;
            this.GrdDatos.AllowUserToResizeRows = false;
            this.GrdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Remision,
            this.K_Pedido,
            this.D_Estatus_Remision,
            this.D_Oficina,
            this.D_Almacen,
            this.D_Tipo_Entrega,
            this.F_Remision,
            this.B_Entregada,
            this.B_Cancelada,
            this.D_Usuario});
            this.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDatos.Location = new System.Drawing.Point(3, 3);
            this.GrdDatos.MultiSelect = false;
            this.GrdDatos.Name = "GrdDatos";
            this.GrdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDatos.Size = new System.Drawing.Size(1106, 347);
            this.GrdDatos.TabIndex = 2;
            this.GrdDatos.SelectionChanged += new System.EventHandler(this.GrdDatos_SelectionChanged);
            // 
            // K_Remision
            // 
            this.K_Remision.DataPropertyName = "K_Remision";
            this.K_Remision.HeaderText = "ID Remisión";
            this.K_Remision.Name = "K_Remision";
            this.K_Remision.ReadOnly = true;
            this.K_Remision.Width = 105;
            // 
            // K_Pedido
            // 
            this.K_Pedido.DataPropertyName = "K_Pedido";
            this.K_Pedido.HeaderText = "ID Pedido";
            this.K_Pedido.Name = "K_Pedido";
            this.K_Pedido.ReadOnly = true;
            this.K_Pedido.Width = 92;
            // 
            // D_Estatus_Remision
            // 
            this.D_Estatus_Remision.DataPropertyName = "D_Estatus_Remision";
            this.D_Estatus_Remision.HeaderText = "Estatus";
            this.D_Estatus_Remision.Name = "D_Estatus_Remision";
            this.D_Estatus_Remision.ReadOnly = true;
            this.D_Estatus_Remision.Width = 78;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 73;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 84;
            // 
            // D_Tipo_Entrega
            // 
            this.D_Tipo_Entrega.DataPropertyName = "D_Tipo_Entrega";
            this.D_Tipo_Entrega.HeaderText = "Tipo Entrega";
            this.D_Tipo_Entrega.Name = "D_Tipo_Entrega";
            this.D_Tipo_Entrega.ReadOnly = true;
            this.D_Tipo_Entrega.Width = 111;
            // 
            // F_Remision
            // 
            this.F_Remision.DataPropertyName = "F_Remision";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.F_Remision.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Remision.HeaderText = "Fec. Remisión";
            this.F_Remision.Name = "F_Remision";
            this.F_Remision.ReadOnly = true;
            this.F_Remision.Width = 116;
            // 
            // B_Entregada
            // 
            this.B_Entregada.DataPropertyName = "B_Entregada";
            this.B_Entregada.HeaderText = "¿Entregada?";
            this.B_Entregada.Name = "B_Entregada";
            this.B_Entregada.ReadOnly = true;
            this.B_Entregada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Entregada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Entregada.Width = 110;
            // 
            // B_Cancelada
            // 
            this.B_Cancelada.DataPropertyName = "B_Cancelada";
            this.B_Cancelada.HeaderText = "¿Cancelada?";
            this.B_Cancelada.Name = "B_Cancelada";
            this.B_Cancelada.ReadOnly = true;
            this.B_Cancelada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Cancelada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Cancelada.Width = 109;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.HeaderText = "Usuario Captura";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Width = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. Remisión";
            // 
            // TxtK_Remision
            // 
            this.TxtK_Remision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtK_Remision.Location = new System.Drawing.Point(112, 56);
            this.TxtK_Remision.Name = "TxtK_Remision";
            this.TxtK_Remision.Size = new System.Drawing.Size(366, 24);
            this.TxtK_Remision.TabIndex = 4;
            this.TxtK_Remision.TextChanged += new System.EventHandler(this.TxtK_Remision_TextChanged);
            this.TxtK_Remision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtK_Remision_KeyPress);
            // 
            // DtpF_Inicial
            // 
            this.DtpF_Inicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpF_Inicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpF_Inicial.Location = new System.Drawing.Point(61, 25);
            this.DtpF_Inicial.Name = "DtpF_Inicial";
            this.DtpF_Inicial.Size = new System.Drawing.Size(516, 23);
            this.DtpF_Inicial.TabIndex = 5;
            // 
            // DtpF_Final
            // 
            this.DtpF_Final.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpF_Final.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpF_Final.Location = new System.Drawing.Point(605, 25);
            this.DtpF_Final.Name = "DtpF_Final";
            this.DtpF_Final.Size = new System.Drawing.Size(258, 23);
            this.DtpF_Final.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "De";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DtpF_Inicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpF_Final);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(581, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "al";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(34, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Almacén";
            // 
            // CbxAlmacen
            // 
            this.CbxAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxAlmacen.FormattingEnabled = true;
            this.CbxAlmacen.Location = new System.Drawing.Point(112, 88);
            this.CbxAlmacen.Name = "CbxAlmacen";
            this.CbxAlmacen.Size = new System.Drawing.Size(579, 24);
            this.CbxAlmacen.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 203);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 382);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrdDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remisiones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GrdDetalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrdDetalle
            // 
            this.GrdDetalle.AllowUserToAddRows = false;
            this.GrdDetalle.AllowUserToDeleteRows = false;
            this.GrdDetalle.AllowUserToResizeColumns = false;
            this.GrdDetalle.AllowUserToResizeRows = false;
            this.GrdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.Cantidad,
            this.Lote,
            this.D_Unidad_Medida});
            this.GrdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDetalle.Location = new System.Drawing.Point(3, 3);
            this.GrdDetalle.MultiSelect = false;
            this.GrdDetalle.Name = "GrdDetalle";
            this.GrdDetalle.Size = new System.Drawing.Size(853, 194);
            this.GrdDetalle.TabIndex = 3;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "Unidad Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            // 
            // FRM_CONSULTA_REMISIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CbxAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtK_Remision);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(895, 513);
            this.Name = "FRM_CONSULTA_REMISIONES";
            this.Text = "CONSULTA REMISIONES";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtK_Remision, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CbxAlmacen, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtK_Remision;
        private System.Windows.Forms.DateTimePicker DtpF_Inicial;
        private System.Windows.Forms.DateTimePicker DtpF_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxAlmacen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GrdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Remision;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Remision;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Remision;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Entregada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Cancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
    }
}