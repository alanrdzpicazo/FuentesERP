namespace ProbeMedic.PRECIOS
{
    partial class FRM_PRECIOS_ACTUALES_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PRECIOS_ACTUALES_CLIENTES));
            this.dgvPreciosActuales = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.K_Precio_ArticuloCliente_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Ultima_Actualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreciosActuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreciosActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Precio_ArticuloCliente_Actual,
            this.K_Cliente,
            this.D_Cliente,
            this.K_Articulo,
            this.D_Articulo,
            this.Precio,
            this.F_Ultima_Actualizacion});
            this.dgvPreciosActuales.Location = new System.Drawing.Point(0, 112);
            this.dgvPreciosActuales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPreciosActuales.MultiSelect = false;
            this.dgvPreciosActuales.Name = "dgvPreciosActuales";
            this.dgvPreciosActuales.ReadOnly = true;
            this.dgvPreciosActuales.RowTemplate.Height = 24;
            this.dgvPreciosActuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreciosActuales.Size = new System.Drawing.Size(845, 353);
            this.dgvPreciosActuales.TabIndex = 3;
            this.dgvPreciosActuales.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(845, 20);
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // K_Precio_ArticuloCliente_Actual
            // 
            this.K_Precio_ArticuloCliente_Actual.DataPropertyName = "K_Precio_ArticuloCliente_Actual";
            this.K_Precio_ArticuloCliente_Actual.HeaderText = "K_Precio_ArticuloCliente_Actual";
            this.K_Precio_ArticuloCliente_Actual.Name = "K_Precio_ArticuloCliente_Actual";
            this.K_Precio_ArticuloCliente_Actual.ReadOnly = true;
            this.K_Precio_ArticuloCliente_Actual.Visible = false;
            this.K_Precio_ArticuloCliente_Actual.Width = 224;
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "Num. Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            this.K_Cliente.Width = 110;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 73;
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
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // F_Ultima_Actualizacion
            // 
            this.F_Ultima_Actualizacion.DataPropertyName = "F_Ultima_Actualizacion";
            dataGridViewCellStyle4.Format = "d";
            this.F_Ultima_Actualizacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.F_Ultima_Actualizacion.HeaderText = "Ultima Actualización";
            this.F_Ultima_Actualizacion.Name = "F_Ultima_Actualizacion";
            this.F_Ultima_Actualizacion.ReadOnly = true;
            this.F_Ultima_Actualizacion.Width = 151;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(137, 73);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(354, 24);
            this.txtCliente.TabIndex = 112;
            this.txtCliente.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 110;
            this.label4.Text = "Cliente";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(494, 73);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaCliente.TabIndex = 0;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.Location = new System.Drawing.Point(83, 73);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.ReadOnly = true;
            this.txtClaveCliente.Size = new System.Drawing.Size(50, 24);
            this.txtClaveCliente.TabIndex = 111;
            this.txtClaveCliente.TabStop = false;
            // 
            // FRM_PRECIOS_ACTUALES_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 506);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.txtClaveCliente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvPreciosActuales);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "FRM_PRECIOS_ACTUALES_CLIENTES";
            this.Text = "Precios Actuales Clientes";
            this.Load += new System.EventHandler(this.FRM_PRECIOS_ACTUALES_CLIENTES_Load);
            this.Controls.SetChildIndex(this.dgvPreciosActuales, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.txtClaveCliente, 0);
            this.Controls.SetChildIndex(this.btnBuscaCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreciosActuales;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precio_ArticuloCliente_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Ultima_Actualizacion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtClaveCliente;
    }
}