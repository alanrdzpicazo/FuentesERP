namespace ProbeMedic.VENTAS
{
    partial class Frm_PreCierre_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv_Tipos_Pagos = new System.Windows.Forms.DataGridView();
            this.K_Tipo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloDetallePedido = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txt_Clave_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_No_Precierre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tipos_Pagos)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(723, 272);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Dgv_Tipos_Pagos);
            this.panel3.Controls.Add(this.lblTituloDetallePedido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 180);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            // 
            // Dgv_Tipos_Pagos
            // 
            this.Dgv_Tipos_Pagos.AllowUserToAddRows = false;
            this.Dgv_Tipos_Pagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tipos_Pagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Tipos_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tipos_Pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Tipo_Pago,
            this.D_Tipo_Pago,
            this.Monto_Pago});
            this.Dgv_Tipos_Pagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Tipos_Pagos.Location = new System.Drawing.Point(0, 21);
            this.Dgv_Tipos_Pagos.Name = "Dgv_Tipos_Pagos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tipos_Pagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Tipos_Pagos.RowHeadersVisible = false;
            this.Dgv_Tipos_Pagos.Size = new System.Drawing.Size(719, 155);
            this.Dgv_Tipos_Pagos.TabIndex = 5;
            this.Dgv_Tipos_Pagos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Dgv_Tipos_Pagos_CellValidating);
            this.Dgv_Tipos_Pagos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_Tipos_Pagos_EditingControlShowing);
            // 
            // K_Tipo_Pago
            // 
            this.K_Tipo_Pago.DataPropertyName = "K_Tipo_Pago";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.K_Tipo_Pago.DefaultCellStyle = dataGridViewCellStyle2;
            this.K_Tipo_Pago.HeaderText = "Clave";
            this.K_Tipo_Pago.Name = "K_Tipo_Pago";
            this.K_Tipo_Pago.ReadOnly = true;
            this.K_Tipo_Pago.Visible = false;
            this.K_Tipo_Pago.Width = 70;
            // 
            // D_Tipo_Pago
            // 
            this.D_Tipo_Pago.DataPropertyName = "D_Tipo_Pago";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.D_Tipo_Pago.DefaultCellStyle = dataGridViewCellStyle3;
            this.D_Tipo_Pago.HeaderText = "Tipo de pago";
            this.D_Tipo_Pago.Name = "D_Tipo_Pago";
            this.D_Tipo_Pago.ReadOnly = true;
            this.D_Tipo_Pago.Width = 600;
            // 
            // Monto_Pago
            // 
            this.Monto_Pago.DataPropertyName = "Monto_Pago";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Monto_Pago.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto_Pago.HeaderText = "Cantidades";
            this.Monto_Pago.Name = "Monto_Pago";
            this.Monto_Pago.Width = 115;
            // 
            // lblTituloDetallePedido
            // 
            this.lblTituloDetallePedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblTituloDetallePedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloDetallePedido.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetallePedido.ForeColor = System.Drawing.Color.White;
            this.lblTituloDetallePedido.Location = new System.Drawing.Point(0, 0);
            this.lblTituloDetallePedido.Name = "lblTituloDetallePedido";
            this.lblTituloDetallePedido.Size = new System.Drawing.Size(719, 21);
            this.lblTituloDetallePedido.TabIndex = 22;
            this.lblTituloDetallePedido.Text = " Capture las cantidades de los tipos de pago";
            this.lblTituloDetallePedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.Txt_Clave_Usuario);
            this.panel2.Controls.Add(this.Txt_Usuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Txt_No_Precierre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 92);
            this.panel2.TabIndex = 0;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(599, 40);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(112, 36);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.TabStop = false;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Txt_Clave_Usuario
            // 
            this.Txt_Clave_Usuario.Location = new System.Drawing.Point(119, 52);
            this.Txt_Clave_Usuario.Name = "Txt_Clave_Usuario";
            this.Txt_Clave_Usuario.ReadOnly = true;
            this.Txt_Clave_Usuario.Size = new System.Drawing.Size(50, 24);
            this.Txt_Clave_Usuario.TabIndex = 4;
            this.Txt_Clave_Usuario.TabStop = false;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(172, 52);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.ReadOnly = true;
            this.Txt_Usuario.Size = new System.Drawing.Size(347, 24);
            this.Txt_Usuario.TabIndex = 3;
            this.Txt_Usuario.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // Txt_No_Precierre
            // 
            this.Txt_No_Precierre.Location = new System.Drawing.Point(120, 17);
            this.Txt_No_Precierre.Name = "Txt_No_Precierre";
            this.Txt_No_Precierre.ReadOnly = true;
            this.Txt_No_Precierre.Size = new System.Drawing.Size(134, 24);
            this.Txt_No_Precierre.TabIndex = 1;
            this.Txt_No_Precierre.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Precierre";
            // 
            // Frm_PreCierre_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 349);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_PreCierre_Empleado";
            this.Text = "PRECIERRE EMPLEADO";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tipos_Pagos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Clave_Usuario;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_No_Precierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloDetallePedido;
        private System.Windows.Forms.DataGridView Dgv_Tipos_Pagos;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pago;
    }
}