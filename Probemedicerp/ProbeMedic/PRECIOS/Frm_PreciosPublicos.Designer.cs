namespace ProbeMedic.PRECIOS
{
    partial class Frm_PreciosPublicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PreciosPublicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdPrecios = new System.Windows.Forms.DataGridView();
            this.K_Precio_Articulo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Actualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucSustanciaActiva1 = new ProbeMedic.Controles.ucSustanciaActiva();
            this.label7 = new System.Windows.Forms.Label();
            this.ucLaboratorio1 = new ProbeMedic.Controles.ucLaboratorio();
            this.label2 = new System.Windows.Forms.Label();
            this.ucFamiliaArticulo1 = new ProbeMedic.Controles.ucFamiliaArticulo();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_D_Articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_D_Empresa = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 525);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.grdPrecios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Arial", 9.5F);
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 308);
            this.panel3.TabIndex = 5;
            this.panel3.TabStop = true;
            // 
            // grdPrecios
            // 
            this.grdPrecios.AllowUserToAddRows = false;
            this.grdPrecios.AllowUserToDeleteRows = false;
            this.grdPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrecios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Precio_Articulo_Actual,
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.F_Actualizacion,
            this.Precio});
            this.grdPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrecios.Location = new System.Drawing.Point(0, 0);
            this.grdPrecios.Name = "grdPrecios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrecios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPrecios.Size = new System.Drawing.Size(599, 304);
            this.grdPrecios.TabIndex = 6;
            this.grdPrecios.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdPrecios_CellBeginEdit);
            this.grdPrecios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPrecios_CellEndEdit);
            this.grdPrecios.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdPrecios_CellValidating);
            this.grdPrecios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdPrecios_EditingControlShowing);
            this.grdPrecios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdPrecios_KeyPress);
            // 
            // K_Precio_Articulo_Actual
            // 
            this.K_Precio_Articulo_Actual.DataPropertyName = "K_Precio_Articulo_Actual";
            this.K_Precio_Articulo_Actual.HeaderText = "K_Precio_Articulo";
            this.K_Precio_Articulo_Actual.Name = "K_Precio_Articulo_Actual";
            this.K_Precio_Articulo_Actual.ReadOnly = true;
            this.K_Precio_Articulo_Actual.Visible = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // F_Actualizacion
            // 
            this.F_Actualizacion.DataPropertyName = "F_Actualizacion";
            this.F_Actualizacion.HeaderText = "F_Actualizacion";
            this.F_Actualizacion.Name = "F_Actualizacion";
            this.F_Actualizacion.ReadOnly = true;
            this.F_Actualizacion.Visible = false;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio C/IVA ($)";
            this.Precio.Name = "Precio";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ucSustanciaActiva1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ucLaboratorio1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ucFamiliaArticulo1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSKU);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_D_Articulo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_D_Empresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 213);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // ucSustanciaActiva1
            // 
            this.ucSustanciaActiva1.Location = new System.Drawing.Point(135, 167);
            this.ucSustanciaActiva1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.ucSustanciaActiva1.Name = "ucSustanciaActiva1";
            this.ucSustanciaActiva1.Size = new System.Drawing.Size(259, 31);
            this.ucSustanciaActiva1.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(23, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 138;
            this.label7.Text = "Sustancia Activa";
            // 
            // ucLaboratorio1
            // 
            this.ucLaboratorio1.Location = new System.Drawing.Point(135, 131);
            this.ucLaboratorio1.Margin = new System.Windows.Forms.Padding(6, 14, 6, 14);
            this.ucLaboratorio1.Name = "ucLaboratorio1";
            this.ucLaboratorio1.Size = new System.Drawing.Size(256, 33);
            this.ucLaboratorio1.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 136;
            this.label2.Text = "Laboratorio";
            // 
            // ucFamiliaArticulo1
            // 
            this.ucFamiliaArticulo1.Location = new System.Drawing.Point(135, 96);
            this.ucFamiliaArticulo1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.ucFamiliaArticulo1.Name = "ucFamiliaArticulo1";
            this.ucFamiliaArticulo1.Size = new System.Drawing.Size(256, 32);
            this.ucFamiliaArticulo1.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 134;
            this.label3.Text = "Família Artículo";
            // 
            // txtSKU
            // 
            this.txtSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSKU.Location = new System.Drawing.Point(134, 63);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(213, 24);
            this.txtSKU.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 132;
            this.label4.Text = "SKU";
            // 
            // txt_D_Articulo
            // 
            this.txt_D_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_D_Articulo.Location = new System.Drawing.Point(135, 29);
            this.txt_D_Articulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_D_Articulo.Name = "txt_D_Articulo";
            this.txt_D_Articulo.Size = new System.Drawing.Size(213, 24);
            this.txt_D_Articulo.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 130;
            this.label1.Text = "Nombre";
            // 
            // lbl_D_Empresa
            // 
            this.lbl_D_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
            this.lbl_D_Empresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_D_Empresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D_Empresa.ForeColor = System.Drawing.Color.White;
            this.lbl_D_Empresa.Location = new System.Drawing.Point(0, 0);
            this.lbl_D_Empresa.Name = "lbl_D_Empresa";
            this.lbl_D_Empresa.Size = new System.Drawing.Size(599, 17);
            this.lbl_D_Empresa.TabIndex = 76;
            this.lbl_D_Empresa.Text = "Precios Públicos";
            this.lbl_D_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "contract_78463.ico");
            this.imageList1.Images.SetKeyName(1, "if_price_1814073.png");
            this.imageList1.Images.SetKeyName(2, "btnGuardar.Image.png");
            this.imageList1.Images.SetKeyName(3, "business_rankhistoryreport_therange_negocio_2345.ico");
            // 
            // Frm_PreciosPublicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 602);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_PreciosPublicos";
            this.Text = "PRECIOS PUBLICOS";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdPrecios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_D_Empresa;
        private Controles.ucSustanciaActiva ucSustanciaActiva1;
        private System.Windows.Forms.Label label7;
        private Controles.ucLaboratorio ucLaboratorio1;
        private System.Windows.Forms.Label label2;
        private Controles.ucFamiliaArticulo ucFamiliaArticulo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_D_Articulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Precio_Articulo_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Actualizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}