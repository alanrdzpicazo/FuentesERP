﻿namespace ProbeMedic.CATALOGOS.LABORATORIOS
{
    partial class FRM_REP_PRECIOS_PROG_ACTUAL
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvPreciosActuales = new System.Windows.Forms.DataGridView();
            this.K_Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Ultima_Actualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(921, 20);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // dgvPreciosActuales
            // 
            this.dgvPreciosActuales.AllowUserToAddRows = false;
            this.dgvPreciosActuales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPreciosActuales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreciosActuales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreciosActuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreciosActuales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreciosActuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreciosActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Programa,
            this.D_Programa,
            this.K_Articulo,
            this.D_Articulo,
            this.K_Aseguradora,
            this.D_Aseguradora,
            this.K_Laboratorio,
            this.D_Laboratorio,
            this.Precio,
            this.F_Ultima_Actualizacion});
            this.dgvPreciosActuales.Location = new System.Drawing.Point(0, 58);
            this.dgvPreciosActuales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPreciosActuales.MultiSelect = false;
            this.dgvPreciosActuales.Name = "dgvPreciosActuales";
            this.dgvPreciosActuales.ReadOnly = true;
            this.dgvPreciosActuales.RowTemplate.Height = 24;
            this.dgvPreciosActuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreciosActuales.Size = new System.Drawing.Size(921, 407);
            this.dgvPreciosActuales.TabIndex = 15;
            this.dgvPreciosActuales.TabStop = false;
            // 
            // K_Programa
            // 
            this.K_Programa.DataPropertyName = "K_Programa";
            this.K_Programa.HeaderText = "Clave Programa";
            this.K_Programa.Name = "K_Programa";
            this.K_Programa.ReadOnly = true;
            this.K_Programa.Width = 130;
            // 
            // D_Programa
            // 
            this.D_Programa.DataPropertyName = "D_Programa";
            this.D_Programa.HeaderText = "Programa";
            this.D_Programa.Name = "D_Programa";
            this.D_Programa.ReadOnly = true;
            this.D_Programa.Width = 93;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 115;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // K_Aseguradora
            // 
            this.K_Aseguradora.DataPropertyName = "K_Aseguradora";
            this.K_Aseguradora.HeaderText = "K_Aseguradora";
            this.K_Aseguradora.Name = "K_Aseguradora";
            this.K_Aseguradora.ReadOnly = true;
            this.K_Aseguradora.Visible = false;
            this.K_Aseguradora.Width = 152;
            // 
            // D_Aseguradora
            // 
            this.D_Aseguradora.DataPropertyName = "D_Aseguradora";
            this.D_Aseguradora.HeaderText = "Aseguradora";
            this.D_Aseguradora.Name = "D_Aseguradora";
            this.D_Aseguradora.ReadOnly = true;
            this.D_Aseguradora.Width = 110;
            // 
            // K_Laboratorio
            // 
            this.K_Laboratorio.DataPropertyName = "K_Laboratorio";
            this.K_Laboratorio.HeaderText = "K_Laboratorio";
            this.K_Laboratorio.Name = "K_Laboratorio";
            this.K_Laboratorio.ReadOnly = true;
            this.K_Laboratorio.Visible = false;
            this.K_Laboratorio.Width = 142;
            // 
            // D_Laboratorio
            // 
            this.D_Laboratorio.DataPropertyName = "D_Laboratorio";
            this.D_Laboratorio.HeaderText = "Laboratorio";
            this.D_Laboratorio.Name = "D_Laboratorio";
            this.D_Laboratorio.ReadOnly = true;
            this.D_Laboratorio.Width = 103;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // F_Ultima_Actualizacion
            // 
            this.F_Ultima_Actualizacion.DataPropertyName = "F_Ultima_Actualizacion";
            this.F_Ultima_Actualizacion.HeaderText = "Fecha Ultima Actualización";
            this.F_Ultima_Actualizacion.Name = "F_Ultima_Actualizacion";
            this.F_Ultima_Actualizacion.ReadOnly = true;
            this.F_Ultima_Actualizacion.Width = 191;
            // 
            // FRM_REP_PRECIOS_PROG_ACTUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 506);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvPreciosActuales);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "FRM_REP_PRECIOS_PROG_ACTUAL";
            this.Text = "PRECIOS ACTUALES PROGRAMAS";
            this.Load += new System.EventHandler(this.FRM_REP_PRECIOS_PROG_ACTUAL_Load);
            this.Controls.SetChildIndex(this.dgvPreciosActuales, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvPreciosActuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Ultima_Actualizacion;
    }
}