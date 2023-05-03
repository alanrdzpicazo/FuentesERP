namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Muestra_Articulos_Por_Caducar
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
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Almacen,
            this.Articulo,
            this.Lote,
            this.F_Caducidad,
            this.Cantidad});
            this.dgv_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datos.Location = new System.Drawing.Point(0, 38);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(788, 220);
            this.dgv_datos.TabIndex = 2;
            // 
            // Almacen
            // 
            this.Almacen.DataPropertyName = "Almacen";
            this.Almacen.HeaderText = "Almacén";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.DataPropertyName = "Artículo";
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "Fecha de caducidad";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.F_Caducidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Caducidad.HeaderText = "Fecha Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Frm_Muestra_Articulos_Por_Caducar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 297);
            this.Controls.Add(this.dgv_datos);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_Muestra_Articulos_Por_Caducar";
            this.Text = "MUESTRA ARTICULOS POR CADUCAR (4 MESES, CADUCADOS)";
            this.Load += new System.EventHandler(this.Frm_Muestra_Articulos_Por_Caducar_Load);
            this.Controls.SetChildIndex(this.dgv_datos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}