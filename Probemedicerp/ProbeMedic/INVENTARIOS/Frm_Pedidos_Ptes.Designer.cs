namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Pedidos_Ptes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cK_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgv_datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido,
            this.F_Pedido,
            this.F_Entrega,
            this.cK_Almacen,
            this.Almacen,
            this.Oficina,
            this.Estatus,
            this.D_Cliente,
            this.Nombre});
            this.dgv_datos.Location = new System.Drawing.Point(0, 88);
            this.dgv_datos.MultiSelect = false;
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.Size = new System.Drawing.Size(1155, 289);
            this.dgv_datos.TabIndex = 3;
            this.dgv_datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_datos_CellMouseDoubleClick);
            this.dgv_datos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_datos_KeyDown);
            // 
            // Pedido
            // 
            this.Pedido.DataPropertyName = "Pedido";
            this.Pedido.FillWeight = 248.731F;
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Width = 74;
            // 
            // F_Pedido
            // 
            this.F_Pedido.DataPropertyName = "F_Pedido";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.F_Pedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.F_Pedido.FillWeight = 75.21151F;
            this.F_Pedido.HeaderText = "Fec. Pedido";
            this.F_Pedido.Name = "F_Pedido";
            this.F_Pedido.ReadOnly = true;
            this.F_Pedido.Width = 103;
            // 
            // F_Entrega
            // 
            this.F_Entrega.DataPropertyName = "F_Entrega";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.F_Entrega.DefaultCellStyle = dataGridViewCellStyle7;
            this.F_Entrega.HeaderText = "Fec. Entrega";
            this.F_Entrega.Name = "F_Entrega";
            this.F_Entrega.ReadOnly = true;
            this.F_Entrega.Width = 110;
            // 
            // cK_Almacen
            // 
            this.cK_Almacen.DataPropertyName = "K_Almacen";
            this.cK_Almacen.HeaderText = "cK_Almacen";
            this.cK_Almacen.Name = "cK_Almacen";
            this.cK_Almacen.ReadOnly = true;
            this.cK_Almacen.Visible = false;
            this.cK_Almacen.Width = 107;
            // 
            // Almacen
            // 
            this.Almacen.DataPropertyName = "Almacen";
            this.Almacen.FillWeight = 75.21151F;
            this.Almacen.HeaderText = "Almacén";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            this.Almacen.Width = 84;
            // 
            // Oficina
            // 
            this.Oficina.DataPropertyName = "Oficina";
            this.Oficina.FillWeight = 75.21151F;
            this.Oficina.HeaderText = "Oficina";
            this.Oficina.Name = "Oficina";
            this.Oficina.ReadOnly = true;
            this.Oficina.Width = 73;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Estatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.Estatus.FillWeight = 75.21151F;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 78;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.FillWeight = 75.21151F;
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 73;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 75.21151F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 82;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(78, 50);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(249, 24);
            this.txtFiltrar.TabIndex = 4;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoPedido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar";
            // 
            // Frm_Pedidos_Ptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.dgv_datos);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_Pedidos_Ptes";
            this.Text = "PEDIDOS PENDIENTES POR SURTIR";
            this.Load += new System.EventHandler(this.Frm_Pedidos_Ptes_Load);
            this.Controls.SetChildIndex(this.dgv_datos, 0);
            this.Controls.SetChildIndex(this.txtFiltrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn cK_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label label1;
    }
}