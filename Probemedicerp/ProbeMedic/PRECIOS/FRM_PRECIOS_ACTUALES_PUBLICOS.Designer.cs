namespace ProbeMedic.PRECIOS
{
    partial class FRM_PRECIOS_ACTUALES_PUBLICOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvPreciosActuales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.K_Precio_Articulo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Ultima_Actualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1061, 20);
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            // 
            // dgvPreciosActuales
            // 
            this.dgvPreciosActuales.AllowUserToAddRows = false;
            this.dgvPreciosActuales.AllowUserToDeleteRows = false;
            this.dgvPreciosActuales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreciosActuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreciosActuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreciosActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Precio_Articulo_Actual,
            this.K_Articulo,
            this.D_Articulo,
            this.Precio,
            this.F_Ultima_Actualizacion});
            this.dgvPreciosActuales.Location = new System.Drawing.Point(4, 73);
            this.dgvPreciosActuales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPreciosActuales.Name = "dgvPreciosActuales";
            this.dgvPreciosActuales.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreciosActuales.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPreciosActuales.RowTemplate.Height = 24;
            this.dgvPreciosActuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreciosActuales.Size = new System.Drawing.Size(1053, 353);
            this.dgvPreciosActuales.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFiltrar);
            this.panel1.Controls.Add(this.dgvPreciosActuales);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 429);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Filtrar";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(72, 34);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(285, 24);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // K_Precio_Articulo_Actual
            // 
            this.K_Precio_Articulo_Actual.DataPropertyName = "K_Precio_Articulo_Actual";
            this.K_Precio_Articulo_Actual.HeaderText = "K_Precio_ArticuloCliente_Actual";
            this.K_Precio_Articulo_Actual.Name = "K_Precio_Articulo_Actual";
            this.K_Precio_Articulo_Actual.ReadOnly = true;
            this.K_Precio_Articulo_Actual.Visible = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.K_Articulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.K_Articulo.HeaderText = "ID";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.D_Articulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio C/IVA";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // F_Ultima_Actualizacion
            // 
            this.F_Ultima_Actualizacion.DataPropertyName = "F_Ultima_Actualizacion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy hh:mm:ss";
            dataGridViewCellStyle5.NullValue = null;
            this.F_Ultima_Actualizacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.F_Ultima_Actualizacion.HeaderText = "Ultima Actualización";
            this.F_Ultima_Actualizacion.Name = "F_Ultima_Actualizacion";
            this.F_Ultima_Actualizacion.ReadOnly = true;
            // 
            // FRM_PRECIOS_ACTUALES_PUBLICOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 506);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_PRECIOS_ACTUALES_PUBLICOS";
            this.Text = "PRECIOS PÚBLICOS ACTUALES";
            this.Load += new System.EventHandler(this.FRM_PRECIOS_ACTUALES_PUBLICOS_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvPreciosActuales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precio_Articulo_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Ultima_Actualizacion;
    }
}