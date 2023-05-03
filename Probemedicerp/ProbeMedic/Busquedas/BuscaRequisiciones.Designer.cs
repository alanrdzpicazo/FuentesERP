﻿namespace ProbeMedic.Busquedas
{
    partial class BuscaRequisiciones
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina_Requiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRequisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario_Requiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasifica_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina_Requiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario_Requiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Requisicion,
            this.D_Oficina_Requiere,
            this.D_Tipo_Requisicion,
            this.F_Requisicion,
            this.TotalRequisicion,
            this.D_Usuario_Requiere,
            this.Tipo_Articulo,
            this.Clasifica_Articulo,
            this.K_Oficina_Requiere,
            this.K_Tipo_Requisicion,
            this.K_Usuario_Requiere});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 92);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(871, 222);
            this.grdDatos.TabIndex = 3;
            // 
            // K_Requisicion
            // 
            this.K_Requisicion.DataPropertyName = "K_Requisicion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.K_Requisicion.DefaultCellStyle = dataGridViewCellStyle1;
            this.K_Requisicion.HeaderText = "No. Req.";
            this.K_Requisicion.Name = "K_Requisicion";
            this.K_Requisicion.ReadOnly = true;
            // 
            // D_Oficina_Requiere
            // 
            this.D_Oficina_Requiere.DataPropertyName = "D_Oficina_Requiere";
            this.D_Oficina_Requiere.HeaderText = "Oficina";
            this.D_Oficina_Requiere.Name = "D_Oficina_Requiere";
            this.D_Oficina_Requiere.ReadOnly = true;
            this.D_Oficina_Requiere.Width = 200;
            // 
            // D_Tipo_Requisicion
            // 
            this.D_Tipo_Requisicion.DataPropertyName = "D_Tipo_Requisicion";
            this.D_Tipo_Requisicion.HeaderText = "Tipo";
            this.D_Tipo_Requisicion.Name = "D_Tipo_Requisicion";
            this.D_Tipo_Requisicion.ReadOnly = true;
            // 
            // F_Requisicion
            // 
            this.F_Requisicion.DataPropertyName = "F_Requisicion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.F_Requisicion.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Requisicion.HeaderText = "Fecha";
            this.F_Requisicion.Name = "F_Requisicion";
            this.F_Requisicion.ReadOnly = true;
            // 
            // TotalRequisicion
            // 
            this.TotalRequisicion.DataPropertyName = "TotalRequisicion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.TotalRequisicion.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.D_Usuario_Requiere.Width = 200;
            // 
            // Tipo_Articulo
            // 
            this.Tipo_Articulo.DataPropertyName = "Tipo_Articulo";
            this.Tipo_Articulo.HeaderText = "Tipo Articulo";
            this.Tipo_Articulo.Name = "Tipo_Articulo";
            this.Tipo_Articulo.ReadOnly = true;
            this.Tipo_Articulo.Width = 150;
            // 
            // Clasifica_Articulo
            // 
            this.Clasifica_Articulo.DataPropertyName = "Clasifica_Articulo";
            this.Clasifica_Articulo.HeaderText = "Clasificación";
            this.Clasifica_Articulo.Name = "Clasifica_Articulo";
            this.Clasifica_Articulo.ReadOnly = true;
            this.Clasifica_Articulo.Width = 150;
            // 
            // K_Oficina_Requiere
            // 
            this.K_Oficina_Requiere.DataPropertyName = "K_Oficina_Requiere";
            this.K_Oficina_Requiere.HeaderText = "K_Oficina_Requiere";
            this.K_Oficina_Requiere.Name = "K_Oficina_Requiere";
            this.K_Oficina_Requiere.ReadOnly = true;
            this.K_Oficina_Requiere.Visible = false;
            // 
            // K_Tipo_Requisicion
            // 
            this.K_Tipo_Requisicion.DataPropertyName = "K_Tipo_Requisicion";
            this.K_Tipo_Requisicion.HeaderText = "K_Tipo_Requisicion";
            this.K_Tipo_Requisicion.Name = "K_Tipo_Requisicion";
            this.K_Tipo_Requisicion.ReadOnly = true;
            this.K_Tipo_Requisicion.Visible = false;
            // 
            // K_Usuario_Requiere
            // 
            this.K_Usuario_Requiere.DataPropertyName = "K_Usuario_Requiere";
            this.K_Usuario_Requiere.HeaderText = "K_Usuario_Requiere";
            this.K_Usuario_Requiere.Name = "K_Usuario_Requiere";
            this.K_Usuario_Requiere.ReadOnly = true;
            this.K_Usuario_Requiere.Visible = false;
            // 
            // BuscaRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 353);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "BuscaRequisiciones";
            this.Text = "Busca Requisiciones";
            this.Controls.SetChildIndex(this.grdDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina_Requiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRequisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Requiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasifica_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina_Requiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario_Requiere;
    }
}