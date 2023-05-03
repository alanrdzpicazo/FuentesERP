namespace ProbeMedic.INVENTARIOS
{
    partial class FRM_LOTES_INVENTARIO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDatos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 303);
            this.panel1.TabIndex = 2;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.No_Lote,
            this.F_Caducidad,
            this.D_Almacen,
            this.D_Oficina,
            this.Cantidad_Disponible,
            this.K_Oficina,
            this.K_Almacen});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 20);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(883, 283);
            this.grdDatos.TabIndex = 27;
            this.grdDatos.TabStop = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.K_Articulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.K_Articulo.HeaderText = "No. Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.D_Articulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // No_Lote
            // 
            this.No_Lote.DataPropertyName = "No_Lote";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.No_Lote.DefaultCellStyle = dataGridViewCellStyle4;
            this.No_Lote.HeaderText = "No. Lote";
            this.No_Lote.Name = "No_Lote";
            this.No_Lote.ReadOnly = true;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.F_Caducidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.F_Caducidad.HeaderText = "Fec. Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.D_Almacen.DefaultCellStyle = dataGridViewCellStyle6;
            this.D_Almacen.HeaderText = "Almacen";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.D_Oficina.DefaultCellStyle = dataGridViewCellStyle7;
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            // 
            // Cantidad_Disponible
            // 
            this.Cantidad_Disponible.DataPropertyName = "Cantidad_Disponible";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cantidad_Disponible.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cantidad_Disponible.HeaderText = "Cant. Disponible";
            this.Cantidad_Disponible.Name = "Cantidad_Disponible";
            this.Cantidad_Disponible.ReadOnly = true;
            // 
            // K_Oficina
            // 
            this.K_Oficina.DataPropertyName = "K_Oficina";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.K_Oficina.DefaultCellStyle = dataGridViewCellStyle9;
            this.K_Oficina.HeaderText = "K_Oficina";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.ReadOnly = true;
            this.K_Oficina.Visible = false;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.K_Almacen.DefaultCellStyle = dataGridViewCellStyle10;
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.ReadOnly = true;
            this.K_Almacen.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(883, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Detalle de Lotes ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_LOTES_INVENTARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 380);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_LOTES_INVENTARIO";
            this.Text = "LOTES INVENTARIO";
            this.Load += new System.EventHandler(this.FRM_LOTES_INVENTARIO_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
    }
}