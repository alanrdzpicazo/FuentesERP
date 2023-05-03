namespace ProbeMedic.FACTURACION
{
    partial class Frm_VP_Asigna_Inventario
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
            this.lblD_Articulo = new System.Windows.Forms.Label();
            this.lblD_Almacen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Movimiento_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Asignada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Pedido_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.lblD_Articulo);
            this.panel1.Controls.Add(this.lblD_Almacen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 360);
            this.panel1.TabIndex = 4;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.K_Movimiento_Inventario,
            this.F_Caducidad,
            this.No_Lote,
            this.Cantidad_Disponible,
            this.Cantidad_Asignada,
            this.K_Pedido,
            this.K_Pedido_Detalle});
            this.grdDatos.Location = new System.Drawing.Point(3, 70);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(794, 287);
            this.grdDatos.TabIndex = 26;
            this.grdDatos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdDatos_CellBeginEdit);
            this.grdDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellEndEdit);
            this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
            this.grdDatos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDatos_CellValidating);
            this.grdDatos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdDatos_EditingControlShowing);
            // 
            // lblD_Articulo
            // 
            this.lblD_Articulo.AutoSize = true;
            this.lblD_Articulo.Location = new System.Drawing.Point(97, 37);
            this.lblD_Articulo.Name = "lblD_Articulo";
            this.lblD_Articulo.Size = new System.Drawing.Size(0, 17);
            this.lblD_Articulo.TabIndex = 3;
            // 
            // lblD_Almacen
            // 
            this.lblD_Almacen.AutoSize = true;
            this.lblD_Almacen.Location = new System.Drawing.Point(97, 10);
            this.lblD_Almacen.Name = "lblD_Almacen";
            this.lblD_Almacen.Size = new System.Drawing.Size(0, 17);
            this.lblD_Almacen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacén:";
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "K_Articulo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.Visible = false;
            // 
            // K_Movimiento_Inventario
            // 
            this.K_Movimiento_Inventario.DataPropertyName = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.HeaderText = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Name = "K_Movimiento_Inventario";
            this.K_Movimiento_Inventario.Visible = false;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            dataGridViewCellStyle2.Format = "d/MM/yyyy";
            this.F_Caducidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Caducidad.HeaderText = "Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            // 
            // No_Lote
            // 
            this.No_Lote.DataPropertyName = "No_Lote";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.No_Lote.DefaultCellStyle = dataGridViewCellStyle3;
            this.No_Lote.HeaderText = "Lote";
            this.No_Lote.Name = "No_Lote";
            this.No_Lote.ReadOnly = true;
            // 
            // Cantidad_Disponible
            // 
            this.Cantidad_Disponible.DataPropertyName = "Cantidad_Disponible";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Cantidad_Disponible.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad_Disponible.HeaderText = "Pzas Disp.";
            this.Cantidad_Disponible.Name = "Cantidad_Disponible";
            this.Cantidad_Disponible.ReadOnly = true;
            // 
            // Cantidad_Asignada
            // 
            this.Cantidad_Asignada.DataPropertyName = "Cantidad_Asignada";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.Cantidad_Asignada.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad_Asignada.HeaderText = "Pzas Asig.";
            this.Cantidad_Asignada.Name = "Cantidad_Asignada";
            // 
            // K_Pedido
            // 
            this.K_Pedido.DataPropertyName = "K_Pedido";
            this.K_Pedido.HeaderText = "K_Pedido";
            this.K_Pedido.Name = "K_Pedido";
            this.K_Pedido.ReadOnly = true;
            // 
            // K_Pedido_Detalle
            // 
            this.K_Pedido_Detalle.DataPropertyName = "K_Pedido_Detalle";
            this.K_Pedido_Detalle.HeaderText = "K_Pedido_Detalle";
            this.K_Pedido_Detalle.Name = "K_Pedido_Detalle";
            this.K_Pedido_Detalle.ReadOnly = true;
            // 
            // Frm_VP_Asigna_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_VP_Asigna_Inventario";
            this.Text = "ASIGNACION DE PIEZAS A VENTAS PRIVADAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_VP_Asigna_Inventario_FormClosing);
            this.Load += new System.EventHandler(this.Frm_VP_Asigna_Inventario_Load);
            this.Shown += new System.EventHandler(this.Frm_VP_Asigna_Inventario_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblD_Articulo;
        private System.Windows.Forms.Label lblD_Almacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Movimiento_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Asignada;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Pedido_Detalle;
    }
}