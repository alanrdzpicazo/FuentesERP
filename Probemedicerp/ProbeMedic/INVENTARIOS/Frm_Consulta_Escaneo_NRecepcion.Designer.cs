namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Consulta_Escaneo_NRecepcion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta_Escaneo_NRecepcion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Registro_Escaneo_NRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Orden_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Requerida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Escaneada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Sobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 413);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 331);
            this.panel3.TabIndex = 6;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Registro_Escaneo_NRecepcion,
            this.K_Orden_Compra,
            this.Factura,
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.Lote,
            this.F_Registro,
            this.Cantidad_Requerida,
            this.Cantidad_Escaneada,
            this.Cantidad_Lote,
            this.F_Caducidad,
            this.K_Usuario_Registro,
            this.PC_Name,
            this.B_Sobrante});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(1053, 331);
            this.grdDatos.TabIndex = 1;
            // 
            // K_Registro_Escaneo_NRecepcion
            // 
            this.K_Registro_Escaneo_NRecepcion.DataPropertyName = "K_Registro_Escaneo_NRecepcion";
            this.K_Registro_Escaneo_NRecepcion.HeaderText = "No. Registro Escaneo";
            this.K_Registro_Escaneo_NRecepcion.Name = "K_Registro_Escaneo_NRecepcion";
            this.K_Registro_Escaneo_NRecepcion.ReadOnly = true;
            this.K_Registro_Escaneo_NRecepcion.Width = 163;
            // 
            // K_Orden_Compra
            // 
            this.K_Orden_Compra.DataPropertyName = "K_Orden_Compra";
            this.K_Orden_Compra.HeaderText = "No. Orden";
            this.K_Orden_Compra.Name = "K_Orden_Compra";
            this.K_Orden_Compra.ReadOnly = true;
            this.K_Orden_Compra.Width = 96;
            // 
            // Factura
            // 
            this.Factura.DataPropertyName = "Factura";
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 79;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "K_Articulo";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Visible = false;
            this.K_Articulo.Width = 94;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 58;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Width = 60;
            // 
            // F_Registro
            // 
            this.F_Registro.DataPropertyName = "F_Registro";
            this.F_Registro.HeaderText = "Fec. Registro";
            this.F_Registro.Name = "F_Registro";
            this.F_Registro.ReadOnly = true;
            this.F_Registro.Width = 112;
            // 
            // Cantidad_Requerida
            // 
            this.Cantidad_Requerida.DataPropertyName = "Cantidad_Requerida";
            this.Cantidad_Requerida.HeaderText = "Cant. Requerida";
            this.Cantidad_Requerida.Name = "Cantidad_Requerida";
            this.Cantidad_Requerida.ReadOnly = true;
            this.Cantidad_Requerida.Width = 131;
            // 
            // Cantidad_Escaneada
            // 
            this.Cantidad_Escaneada.DataPropertyName = "Cantidad_Escaneada";
            this.Cantidad_Escaneada.HeaderText = "Cant. Escaneada";
            this.Cantidad_Escaneada.Name = "Cantidad_Escaneada";
            this.Cantidad_Escaneada.ReadOnly = true;
            this.Cantidad_Escaneada.Width = 135;
            // 
            // Cantidad_Lote
            // 
            this.Cantidad_Lote.DataPropertyName = "Cantidad_Lote";
            this.Cantidad_Lote.HeaderText = "Cant. Lote";
            this.Cantidad_Lote.Name = "Cantidad_Lote";
            this.Cantidad_Lote.ReadOnly = true;
            this.Cantidad_Lote.Width = 97;
            // 
            // F_Caducidad
            // 
            this.F_Caducidad.DataPropertyName = "F_Caducidad";
            this.F_Caducidad.HeaderText = "Fec. Caducidad";
            this.F_Caducidad.Name = "F_Caducidad";
            this.F_Caducidad.ReadOnly = true;
            this.F_Caducidad.Width = 126;
            // 
            // K_Usuario_Registro
            // 
            this.K_Usuario_Registro.DataPropertyName = "K_Usuario_Registro";
            this.K_Usuario_Registro.HeaderText = "K_Usuario_Registro";
            this.K_Usuario_Registro.Name = "K_Usuario_Registro";
            this.K_Usuario_Registro.ReadOnly = true;
            this.K_Usuario_Registro.Visible = false;
            this.K_Usuario_Registro.Width = 152;
            // 
            // PC_Name
            // 
            this.PC_Name.DataPropertyName = "PC_Name";
            this.PC_Name.HeaderText = "PC_Name";
            this.PC_Name.Name = "PC_Name";
            this.PC_Name.ReadOnly = true;
            this.PC_Name.Visible = false;
            this.PC_Name.Width = 93;
            // 
            // B_Sobrante
            // 
            this.B_Sobrante.DataPropertyName = "B_Sobrante";
            this.B_Sobrante.HeaderText = "B_Sobrante";
            this.B_Sobrante.Name = "B_Sobrante";
            this.B_Sobrante.ReadOnly = true;
            this.B_Sobrante.Visible = false;
            this.B_Sobrante.Width = 105;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1053, 23);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Consulta de Escaneo de Notas de Recepción";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNoOrden);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 82);
            this.panel2.TabIndex = 2;
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Enabled = false;
            this.txtNoOrden.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(149, 40);
            this.txtNoOrden.MaxLength = 10;
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.ReadOnly = true;
            this.txtNoOrden.Size = new System.Drawing.Size(100, 24);
            this.txtNoOrden.TabIndex = 3;
            this.txtNoOrden.Tag = "ENTERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orden de Compra";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "accept.png");
            this.imageList1.Images.SetKeyName(1, "zoom.png");
            this.imageList1.Images.SetKeyName(2, "printer.png");
            this.imageList1.Images.SetKeyName(3, "report_go.png");
            this.imageList1.Images.SetKeyName(4, "folder_up_upload_16671.ico");
            // 
            // Frm_Consulta_Escaneo_NRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 490);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Consulta_Escaneo_NRecepcion";
            this.Text = "CONSULTA DE ESCANEO DE NOTAS DE RECEPCIÓN";
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
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Registro_Escaneo_NRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Orden_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Requerida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Escaneada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Sobrante;
        private System.Windows.Forms.ImageList imageList1;
    }
}