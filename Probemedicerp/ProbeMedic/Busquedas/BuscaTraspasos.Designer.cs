﻿namespace ProbeMedic.Busquedas
{
    partial class BuscaTraspasos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Centro_Costos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_oficina_Transfiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.K_Oficina,
            this.D_Oficina,
            this.Centro_Costos,
            this.d_oficina_Transfiere});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 92);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.Size = new System.Drawing.Size(790, 155);
            this.grdDatos.TabIndex = 3;
            // 
            // K_Oficina
            // 
            this.K_Oficina.DataPropertyName = "Consecutivo";
            this.K_Oficina.HeaderText = "Consecutivo";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.ReadOnly = true;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "d_almacen";
            this.D_Oficina.HeaderText = "Almacen Envio";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 300;
            // 
            // Centro_Costos
            // 
            this.Centro_Costos.DataPropertyName = "D_Oficina";
            this.Centro_Costos.HeaderText = "Oficina Envio";
            this.Centro_Costos.Name = "Centro_Costos";
            this.Centro_Costos.ReadOnly = true;
            // 
            // d_oficina_Transfiere
            // 
            this.d_oficina_Transfiere.DataPropertyName = "d_oficina_Transfiere";
            this.d_oficina_Transfiere.HeaderText = "Oficina Recepcion";
            this.d_oficina_Transfiere.Name = "d_oficina_Transfiere";
            this.d_oficina_Transfiere.ReadOnly = true;
            // 
            // BuscaTraspasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(790, 286);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "BuscaTraspasos";
            this.Text = "BUSQUEDA";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centro_Costos;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_oficina_Transfiere;
    }
}
