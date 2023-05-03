namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Cancelacion_Remisiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.CLAVE_REMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTATUS_REMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALMACEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Txt_Clave_Oficina = new System.Windows.Forms.TextBox();
            this.Txt_Oficina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 340);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 202);
            this.panel3.TabIndex = 2;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE_REMISION,
            this.ESTATUS_REMISION,
            this.OFICINA,
            this.ALMACEN,
            this.CLIENTE,
            this.FECHA_REMISION,
            this.TOTAL});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1157, 202);
            this.grdDatos.TabIndex = 5;
            this.grdDatos.TabStop = false;
            // 
            // CLAVE_REMISION
            // 
            this.CLAVE_REMISION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CLAVE_REMISION.DataPropertyName = "CLAVE_REMISION";
            this.CLAVE_REMISION.HeaderText = "No. Remisión";
            this.CLAVE_REMISION.Name = "CLAVE_REMISION";
            this.CLAVE_REMISION.ReadOnly = true;
            this.CLAVE_REMISION.Width = 110;
            // 
            // ESTATUS_REMISION
            // 
            this.ESTATUS_REMISION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ESTATUS_REMISION.DataPropertyName = "ESTATUS_REMISION";
            this.ESTATUS_REMISION.HeaderText = "Estatus";
            this.ESTATUS_REMISION.Name = "ESTATUS_REMISION";
            this.ESTATUS_REMISION.ReadOnly = true;
            this.ESTATUS_REMISION.Width = 140;
            // 
            // OFICINA
            // 
            this.OFICINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OFICINA.DataPropertyName = "OFICINA";
            this.OFICINA.HeaderText = "Oficina";
            this.OFICINA.Name = "OFICINA";
            this.OFICINA.ReadOnly = true;
            this.OFICINA.Width = 140;
            // 
            // ALMACEN
            // 
            this.ALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ALMACEN.DataPropertyName = "ALMACEN";
            this.ALMACEN.HeaderText = "Almacén";
            this.ALMACEN.Name = "ALMACEN";
            this.ALMACEN.ReadOnly = true;
            this.ALMACEN.Width = 140;
            // 
            // CLIENTE
            // 
            this.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "Cliente";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Width = 300;
            // 
            // FECHA_REMISION
            // 
            this.FECHA_REMISION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FECHA_REMISION.DataPropertyName = "FECHA_REMISION";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FECHA_REMISION.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA_REMISION.HeaderText = "Fec. Remisión";
            this.FECHA_REMISION.Name = "FECHA_REMISION";
            this.FECHA_REMISION.ReadOnly = true;
            this.FECHA_REMISION.Width = 125;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Txt_Observaciones);
            this.panel2.Controls.Add(this.Txt_Clave_Oficina);
            this.panel2.Controls.Add(this.Txt_Oficina);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 138);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "0bservaciones";
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Enabled = false;
            this.Txt_Observaciones.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Txt_Observaciones.Location = new System.Drawing.Point(18, 78);
            this.Txt_Observaciones.MaxLength = 10;
            this.Txt_Observaciones.Multiline = true;
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.ReadOnly = true;
            this.Txt_Observaciones.Size = new System.Drawing.Size(499, 47);
            this.Txt_Observaciones.TabIndex = 2;
            this.Txt_Observaciones.Tag = "ENTERO";
            // 
            // Txt_Clave_Oficina
            // 
            this.Txt_Clave_Oficina.Enabled = false;
            this.Txt_Clave_Oficina.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Txt_Clave_Oficina.Location = new System.Drawing.Point(69, 30);
            this.Txt_Clave_Oficina.MaxLength = 10;
            this.Txt_Clave_Oficina.Name = "Txt_Clave_Oficina";
            this.Txt_Clave_Oficina.ReadOnly = true;
            this.Txt_Clave_Oficina.Size = new System.Drawing.Size(64, 24);
            this.Txt_Clave_Oficina.TabIndex = 9;
            this.Txt_Clave_Oficina.TabStop = false;
            this.Txt_Clave_Oficina.Tag = "ENTERO";
            // 
            // Txt_Oficina
            // 
            this.Txt_Oficina.Enabled = false;
            this.Txt_Oficina.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Txt_Oficina.Location = new System.Drawing.Point(136, 30);
            this.Txt_Oficina.MaxLength = 10;
            this.Txt_Oficina.Name = "Txt_Oficina";
            this.Txt_Oficina.ReadOnly = true;
            this.Txt_Oficina.Size = new System.Drawing.Size(381, 24);
            this.Txt_Oficina.TabIndex = 8;
            this.Txt_Oficina.TabStop = false;
            this.Txt_Oficina.Tag = "ENTERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oficina";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1157, 21);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cancelación de Remisiones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Cancelacion_Remisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 417);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cancelacion_Remisiones";
            this.Text = "CANCELACION REMISIONES";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_Clave_Oficina;
        private System.Windows.Forms.TextBox Txt_Oficina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_REMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS_REMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALMACEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}