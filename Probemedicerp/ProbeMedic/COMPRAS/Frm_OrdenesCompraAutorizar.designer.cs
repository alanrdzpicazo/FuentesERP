namespace ProbeMedic.COMPRAS
{
    partial class Frm_OrdenesCompraAutorizar
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlRequisiciones = new System.Windows.Forms.Panel();
            this.grdRequisiciones = new System.Windows.Forms.DataGridView();
            this.K_Orden_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Elaboro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Detalle_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Empaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlRequisiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEncabezado.Controls.Add(this.pnlRequisiciones);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 38);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1077, 235);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // pnlRequisiciones
            // 
            this.pnlRequisiciones.Controls.Add(this.grdRequisiciones);
            this.pnlRequisiciones.Controls.Add(this.label1);
            this.pnlRequisiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRequisiciones.Location = new System.Drawing.Point(0, 0);
            this.pnlRequisiciones.Name = "pnlRequisiciones";
            this.pnlRequisiciones.Size = new System.Drawing.Size(1073, 231);
            this.pnlRequisiciones.TabIndex = 4;
            // 
            // grdRequisiciones
            // 
            this.grdRequisiciones.AllowUserToAddRows = false;
            this.grdRequisiciones.AllowUserToDeleteRows = false;
            this.grdRequisiciones.BackgroundColor = System.Drawing.Color.White;
            this.grdRequisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequisiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Orden_Compra,
            this.Nombre,
            this.D_Oficina,
            this.Total,
            this.D_Usuario_Elaboro,
            this.F_OrdenCompra,
            this.Observaciones});
            this.grdRequisiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRequisiciones.Location = new System.Drawing.Point(0, 25);
            this.grdRequisiciones.MultiSelect = false;
            this.grdRequisiciones.Name = "grdRequisiciones";
            this.grdRequisiciones.ReadOnly = true;
            this.grdRequisiciones.RowHeadersVisible = false;
            this.grdRequisiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRequisiciones.Size = new System.Drawing.Size(1073, 206);
            this.grdRequisiciones.TabIndex = 1;
            this.grdRequisiciones.SelectionChanged += new System.EventHandler(this.grdRequisiciones_SelectionChanged_1);
            this.grdRequisiciones.Click += new System.EventHandler(this.grdRequisiciones_Click_1);
            // 
            // K_Orden_Compra
            // 
            this.K_Orden_Compra.DataPropertyName = "K_Orden_Compra";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Orden_Compra.DefaultCellStyle = dataGridViewCellStyle1;
            this.K_Orden_Compra.HeaderText = "No.";
            this.K_Orden_Compra.Name = "K_Orden_Compra";
            this.K_Orden_Compra.ReadOnly = true;
            this.K_Orden_Compra.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Proveedor";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 120;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // D_Usuario_Elaboro
            // 
            this.D_Usuario_Elaboro.DataPropertyName = "D_Usuario_Elaboro";
            this.D_Usuario_Elaboro.HeaderText = "Usuario";
            this.D_Usuario_Elaboro.Name = "D_Usuario_Elaboro";
            this.D_Usuario_Elaboro.ReadOnly = true;
            this.D_Usuario_Elaboro.Width = 150;
            // 
            // F_OrdenCompra
            // 
            this.F_OrdenCompra.DataPropertyName = "F_OrdenCompra";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.F_OrdenCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_OrdenCompra.HeaderText = "Fecha";
            this.F_OrdenCompra.Name = "F_OrdenCompra";
            this.F_OrdenCompra.ReadOnly = true;
            this.F_OrdenCompra.Width = 150;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 600;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1073, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes de Compra Pendientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1077, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detalle de Articulos";
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
            this.K_Articulo,
            this.D_Articulo,
            this.Cantidad,
            this.D_Tipo_Empaque,
            this.PrecioUnitario,
            this.TotalDetalle});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 298);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(1077, 260);
            this.grdDetalle.TabIndex = 7;
            // 
            // K_Detalle_Requisicion
            // 
            this.K_Detalle_Requisicion.DataPropertyName = "K_Detalle_Requisicion";
            this.K_Detalle_Requisicion.HeaderText = "K_Detalle_Requisicion";
            this.K_Detalle_Requisicion.Name = "K_Detalle_Requisicion";
            this.K_Detalle_Requisicion.ReadOnly = true;
            this.K_Detalle_Requisicion.Visible = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Articulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.K_Articulo.HeaderText = "Clave";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 70;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 550;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // D_Tipo_Empaque
            // 
            this.D_Tipo_Empaque.DataPropertyName = "D_Tipo_Empaque";
            this.D_Tipo_Empaque.HeaderText = "Tipo Empaque";
            this.D_Tipo_Empaque.Name = "D_Tipo_Empaque";
            this.D_Tipo_Empaque.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrecioUnitario.HeaderText = "Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // TotalDetalle
            // 
            this.TotalDetalle.DataPropertyName = "TotalDetalle";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.TotalDetalle.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalDetalle.HeaderText = "PrecioTotal";
            this.TotalDetalle.Name = "TotalDetalle";
            this.TotalDetalle.ReadOnly = true;
            // 
            // Frm_OrdenesCompraAutorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 597);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlEncabezado);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_OrdenesCompraAutorizar";
            this.Text = "ORDENES DE COMPRA POR AUTORIZAR";
            this.Controls.SetChildIndex(this.pnlEncabezado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.grdDetalle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlRequisiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlRequisiciones;
        private System.Windows.Forms.DataGridView grdRequisiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Elaboro;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Detalle_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Empaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDetalle;
    }
}