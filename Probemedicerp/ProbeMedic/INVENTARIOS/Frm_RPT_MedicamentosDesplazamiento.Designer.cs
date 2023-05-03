namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_RPT_MedicamentosDesplazamiento
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDatos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 502);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.Cantidad_Articulo,
            this.F_Caducidad,
            this.No_Lote,
            this.F_Entrada,
            this.D_Oficina,
            this.D_Almacen});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 179);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.RowHeadersWidth = 200;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1367, 323);
            this.grdDatos.TabIndex = 27;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "ID Artículo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 90;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 320;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 140;
            // 
            // Cantidad_Articulo
            // 
            this.Cantidad_Articulo.DataPropertyName = "Cantidad_Articulo";
            this.Cantidad_Articulo.HeaderText = "Cantidad";
            this.Cantidad_Articulo.Name = "Cantidad_Articulo";
            this.Cantidad_Articulo.ReadOnly = true;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            this.F_Caducidad.HeaderText = "Fec. Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            this.F_Caducidad.Width = 140;
            // 
            // No_Lote
            // 
            this.No_Lote.DataPropertyName = "No_Lote";
            this.No_Lote.HeaderText = "Lote";
            this.No_Lote.Name = "No_Lote";
            this.No_Lote.ReadOnly = true;
            // 
            // F_Entrada
            // 
            this.F_Entrada.DataPropertyName = "F_Entrada";
            this.F_Entrada.HeaderText = "Fec. Entrada";
            this.F_Entrada.Name = "F_Entrada";
            this.F_Entrada.ReadOnly = true;
            this.F_Entrada.Width = 140;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.Width = 120;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacén";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 120;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1367, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Medicamentos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 142);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.cbxAlmacen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1367, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROS DE BÚSQUEDA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb6);
            this.groupBox1.Controls.Add(this.rdb4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(122, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(271, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Tiempo";
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb6.Location = new System.Drawing.Point(139, 29);
            this.rdb6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(84, 22);
            this.rdb6.TabIndex = 6;
            this.rdb6.TabStop = true;
            this.rdb6.Text = "6 Meses";
            this.rdb6.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4.Location = new System.Drawing.Point(37, 29);
            this.rdb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(84, 22);
            this.rdb4.TabIndex = 5;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "4 Meses";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(122, 33);
            this.cbxAlmacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(270, 29);
            this.cbxAlmacen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Almacén";
            // 
            // Frm_RPT_MedicamentosDesplazamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 591);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_RPT_MedicamentosDesplazamiento";
            this.Text = "Reporte de Lento/Sin Movimiento de Medicamentos";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb6;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
    }
}