﻿namespace ProbeMedic.COMPRAS
{
    partial class Frm_RequisicionAutorizarBloqueadas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdRequisiciones = new System.Windows.Forms.DataGridView();
            this.K_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina_Requiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRequisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Requiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.K_Detalle_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRequerida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Empaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionesDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisiciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdRequisiciones);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 215);
            this.panel1.TabIndex = 2;
            // 
            // grdRequisiciones
            // 
            this.grdRequisiciones.AllowUserToAddRows = false;
            this.grdRequisiciones.AllowUserToDeleteRows = false;
            this.grdRequisiciones.BackgroundColor = System.Drawing.Color.White;
            this.grdRequisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequisiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Requisicion,
            this.D_Tipo_Requisicion,
            this.D_Estatus_Compra,
            this.D_Oficina_Requiere,
            this.TotalRequisicion,
            this.D_Usuario_Requiere,
            this.F_Requisicion,
            this.Observaciones});
            this.grdRequisiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRequisiciones.Location = new System.Drawing.Point(0, 25);
            this.grdRequisiciones.MultiSelect = false;
            this.grdRequisiciones.Name = "grdRequisiciones";
            this.grdRequisiciones.ReadOnly = true;
            this.grdRequisiciones.RowHeadersVisible = false;
            this.grdRequisiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRequisiciones.Size = new System.Drawing.Size(1038, 190);
            this.grdRequisiciones.TabIndex = 3;
            this.grdRequisiciones.SelectionChanged += new System.EventHandler(this.grdRequisiciones_SelectionChanged);
            this.grdRequisiciones.Click += new System.EventHandler(this.grdRequisiciones_Click);
            // 
            // K_Requisicion
            // 
            this.K_Requisicion.DataPropertyName = "K_Requisicion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Requisicion.DefaultCellStyle = dataGridViewCellStyle1;
            this.K_Requisicion.HeaderText = "No.";
            this.K_Requisicion.Name = "K_Requisicion";
            this.K_Requisicion.ReadOnly = true;
            this.K_Requisicion.Width = 60;
            // 
            // D_Tipo_Requisicion
            // 
            this.D_Tipo_Requisicion.DataPropertyName = "D_Tipo_Requisicion";
            this.D_Tipo_Requisicion.HeaderText = "Tipo";
            this.D_Tipo_Requisicion.Name = "D_Tipo_Requisicion";
            this.D_Tipo_Requisicion.ReadOnly = true;
            // 
            // D_Estatus_Compra
            // 
            this.D_Estatus_Compra.DataPropertyName = "D_Estatus_Compra";
            this.D_Estatus_Compra.HeaderText = "Estatus";
            this.D_Estatus_Compra.Name = "D_Estatus_Compra";
            this.D_Estatus_Compra.ReadOnly = true;
            // 
            // D_Oficina_Requiere
            // 
            this.D_Oficina_Requiere.DataPropertyName = "D_Oficina_Requiere";
            this.D_Oficina_Requiere.HeaderText = "Oficina";
            this.D_Oficina_Requiere.Name = "D_Oficina_Requiere";
            this.D_Oficina_Requiere.ReadOnly = true;
            this.D_Oficina_Requiere.Width = 120;
            // 
            // TotalRequisicion
            // 
            this.TotalRequisicion.DataPropertyName = "TotalRequisicion";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.TotalRequisicion.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalRequisicion.HeaderText = "Total";
            this.TotalRequisicion.Name = "TotalRequisicion";
            this.TotalRequisicion.ReadOnly = true;
            // 
            // D_Usuario_Requiere
            // 
            this.D_Usuario_Requiere.DataPropertyName = "D_Usuario_Requiere";
            this.D_Usuario_Requiere.HeaderText = "Usuario";
            this.D_Usuario_Requiere.Name = "D_Usuario_Requiere";
            this.D_Usuario_Requiere.ReadOnly = true;
            this.D_Usuario_Requiere.Width = 150;
            // 
            // F_Requisicion
            // 
            this.F_Requisicion.DataPropertyName = "F_Requisicion";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.F_Requisicion.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_Requisicion.HeaderText = "Fecha";
            this.F_Requisicion.Name = "F_Requisicion";
            this.F_Requisicion.ReadOnly = true;
            this.F_Requisicion.Width = 150;
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
            this.label1.Size = new System.Drawing.Size(1038, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requisiciones Bloqueadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdDetalle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 279);
            this.panel2.TabIndex = 3;
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
            this.CantidadRequerida,
            this.Unitario,
            this.IVA,
            this.D_Tipo_Empaque,
            this.PrecioTotal,
            this.ObservacionesDetalle});
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 25);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(1038, 254);
            this.grdDetalle.TabIndex = 9;
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
            // CantidadRequerida
            // 
            this.CantidadRequerida.DataPropertyName = "CantidadRequerida";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CantidadRequerida.DefaultCellStyle = dataGridViewCellStyle5;
            this.CantidadRequerida.HeaderText = "Cantidad";
            this.CantidadRequerida.Name = "CantidadRequerida";
            this.CantidadRequerida.ReadOnly = true;
            // 
            // Unitario
            // 
            this.Unitario.DataPropertyName = "Unitario";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            this.Unitario.DefaultCellStyle = dataGridViewCellStyle6;
            this.Unitario.HeaderText = "Unitario";
            this.Unitario.Name = "Unitario";
            this.Unitario.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            dataGridViewCellStyle7.Format = "C2";
            this.IVA.DefaultCellStyle = dataGridViewCellStyle7;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // D_Tipo_Empaque
            // 
            this.D_Tipo_Empaque.DataPropertyName = "D_Tipo_Empaque";
            this.D_Tipo_Empaque.HeaderText = "Tipo Empaque";
            this.D_Tipo_Empaque.Name = "D_Tipo_Empaque";
            this.D_Tipo_Empaque.ReadOnly = true;
            this.D_Tipo_Empaque.Visible = false;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.DataPropertyName = "PrecioTotal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C2";
            this.PrecioTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrecioTotal.HeaderText = "PrecioTotal";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // ObservacionesDetalle
            // 
            this.ObservacionesDetalle.DataPropertyName = "ObservacionesDetalle";
            this.ObservacionesDetalle.HeaderText = "Comentarios";
            this.ObservacionesDetalle.Name = "ObservacionesDetalle";
            this.ObservacionesDetalle.ReadOnly = true;
            this.ObservacionesDetalle.Visible = false;
            this.ObservacionesDetalle.Width = 320;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1038, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Detalle de Articulos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_RequisicionAutorizarBloqueadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_RequisicionAutorizarBloqueadas";
            this.Text = "REQUISICIONES POR AUTOIZAR BLOQUEADAS";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisiciones)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdRequisiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina_Requiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRequisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Requiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Detalle_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRequerida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Empaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionesDetalle;
        private System.Windows.Forms.Label label2;
    }
}