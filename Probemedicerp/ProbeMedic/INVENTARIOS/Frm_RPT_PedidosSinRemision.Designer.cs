namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_RPT_PedidosSinRemision
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estatus_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Celula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1493, 464);
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
            this.dataGridViewTextBoxColumn1,
            this.F_Registro,
            this.Fecha_Entrega,
            this.dataGridViewTextBoxColumn2,
            this.D_Aseguradora,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.D_Estatus_Pedido,
            this.D_Paciente,
            this.D_Celula,
            this.Total_Pedido});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 125);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.RowHeadersWidth = 200;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1493, 339);
            this.grdDatos.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "K_Pedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // F_Registro
            // 
            this.F_Registro.DataPropertyName = "F_Registro";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.F_Registro.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_Registro.HeaderText = "Fecha Registro";
            this.F_Registro.Name = "F_Registro";
            this.F_Registro.ReadOnly = true;
            this.F_Registro.Width = 220;
            // 
            // Fecha_Entrega
            // 
            this.Fecha_Entrega.DataPropertyName = "Fecha_Entrega";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.Fecha_Entrega.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha_Entrega.HeaderText = "Fec. Entrega";
            this.Fecha_Entrega.Name = "Fecha_Entrega";
            this.Fecha_Entrega.ReadOnly = true;
            this.Fecha_Entrega.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "D_Tipo_Entrega";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Entrega";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // D_Aseguradora
            // 
            this.D_Aseguradora.DataPropertyName = "D_Aseguradora";
            this.D_Aseguradora.HeaderText = "Aseguradora";
            this.D_Aseguradora.Name = "D_Aseguradora";
            this.D_Aseguradora.ReadOnly = true;
            this.D_Aseguradora.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "D_Almacen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Almacén";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "D_Oficina";
            this.dataGridViewTextBoxColumn4.HeaderText = "Oficina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // D_Estatus_Pedido
            // 
            this.D_Estatus_Pedido.DataPropertyName = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.HeaderText = "Esatus";
            this.D_Estatus_Pedido.Name = "D_Estatus_Pedido";
            this.D_Estatus_Pedido.ReadOnly = true;
            this.D_Estatus_Pedido.Width = 200;
            // 
            // D_Paciente
            // 
            this.D_Paciente.DataPropertyName = "D_Paciente";
            this.D_Paciente.HeaderText = "Paciente";
            this.D_Paciente.Name = "D_Paciente";
            this.D_Paciente.ReadOnly = true;
            this.D_Paciente.Width = 320;
            // 
            // D_Celula
            // 
            this.D_Celula.DataPropertyName = "D_Celula";
            this.D_Celula.HeaderText = "Celula";
            this.D_Celula.Name = "D_Celula";
            this.D_Celula.ReadOnly = true;
            this.D_Celula.Width = 120;
            // 
            // Total_Pedido
            // 
            this.Total_Pedido.DataPropertyName = "Total_Pedido";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Total_Pedido.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total_Pedido.HeaderText = "Total Pedido";
            this.Total_Pedido.Name = "Total_Pedido";
            this.Total_Pedido.ReadOnly = true;
            this.Total_Pedido.Width = 140;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1493, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pedidos Sin Remisión";
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
            this.panel2.Size = new System.Drawing.Size(1493, 88);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbxAlmacen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1493, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROS DE BÚSQUEDA";
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
            // Frm_RPT_PedidosSinRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 553);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Frm_RPT_PedidosSinRemision";
            this.Text = "Reporte de Pedidos Sin Remisión x Almacén";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estatus_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Celula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pedido;
    }
}