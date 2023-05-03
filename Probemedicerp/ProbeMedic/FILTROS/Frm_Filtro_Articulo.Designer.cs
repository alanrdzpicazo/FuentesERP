namespace ProbeMedic.FILTROS
{
    partial class Frm_Filtro_Articulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filtro_Articulo));
            this.txt_D_Articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucSustanciaActiva1 = new ProbeMedic.Controles.ucSustanciaActiva();
            this.ucLaboratorio1 = new ProbeMedic.Controles.ucLaboratorio();
            this.ucFamiliaArticulo1 = new ProbeMedic.Controles.ucFamiliaArticulo();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Ieps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Ieps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Familia_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Sustancia_Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(508, 275);
            this.Entrar.Margin = new System.Windows.Forms.Padding(4);
            this.Entrar.Size = new System.Drawing.Size(8, 9);
            // 
            // txt_D_Articulo
            // 
            this.txt_D_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_D_Articulo.Location = new System.Drawing.Point(147, 44);
            this.txt_D_Articulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_D_Articulo.Name = "txt_D_Articulo";
            this.txt_D_Articulo.Size = new System.Drawing.Size(230, 23);
            this.txt_D_Articulo.TabIndex = 0;
            this.txt_D_Articulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_D_Articulo_KeyPress);
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = "Nombre";
            // 
            // ucSustanciaActiva1
            // 
            this.ucSustanciaActiva1.Location = new System.Drawing.Point(144, 201);
            this.ucSustanciaActiva1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ucSustanciaActiva1.Name = "ucSustanciaActiva1";
            this.ucSustanciaActiva1.Size = new System.Drawing.Size(288, 30);
            this.ucSustanciaActiva1.TabIndex = 5;
            // 
            // ucLaboratorio1
            // 
            this.ucLaboratorio1.Location = new System.Drawing.Point(147, 167);
            this.ucLaboratorio1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.ucLaboratorio1.Name = "ucLaboratorio1";
            this.ucLaboratorio1.Size = new System.Drawing.Size(286, 32);
            this.ucLaboratorio1.TabIndex = 4;
            // 
            // ucFamiliaArticulo1
            // 
            this.ucFamiliaArticulo1.Location = new System.Drawing.Point(147, 135);
            this.ucFamiliaArticulo1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ucFamiliaArticulo1.Name = "ucFamiliaArticulo1";
            this.ucFamiliaArticulo1.Size = new System.Drawing.Size(286, 30);
            this.ucFamiliaArticulo1.TabIndex = 3;
            // 
            // txtSKU
            // 
            this.txtSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSKU.Location = new System.Drawing.Point(147, 105);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(230, 23);
            this.txtSKU.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 116;
            this.label5.Text = "Sustancia Activa";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 115;
            this.label6.Text = "Laboratorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "Família Artículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "SKU";
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.SKU,
            this.Precio_Unitario,
            this.K_Iva,
            this.K_Ieps,
            this.Porcentaje_Ieps,
            this.Porcentaje,
            this.K_Familia_Articulo,
            this.D_Familia,
            this.K_Laboratorio,
            this.D_Laboratorio,
            this.K_Sustancia_Activa,
            this.D_Sustancia_Activa,
            this.D_Unidad_Medida});
            this.dgvDisponibles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDisponibles.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDisponibles.Location = new System.Drawing.Point(0, 253);
            this.dgvDisponibles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDisponibles.MultiSelect = false;
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.ReadOnly = true;
            this.dgvDisponibles.RowTemplate.Height = 24;
            this.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibles.Size = new System.Drawing.Size(973, 364);
            this.dgvDisponibles.TabIndex = 7;
            this.dgvDisponibles.DoubleClick += new System.EventHandler(this.dgvDisponibles_DoubleClick);
            this.dgvDisponibles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDisponibles_KeyDown);
            this.dgvDisponibles.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvDisponibles_PreviewKeyDown);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoEllipsis = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(459, 191);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 41);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Location = new System.Drawing.Point(147, 75);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(230, 23);
            this.txtClave.TabIndex = 1;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 120;
            this.label2.Text = "Clave";
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 85;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 520;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 180;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio_Unitario";
            this.Precio_Unitario.HeaderText = "P. Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Width = 120;
            // 
            // K_Iva
            // 
            this.K_Iva.DataPropertyName = "K_Iva";
            this.K_Iva.HeaderText = "K_Iva";
            this.K_Iva.Name = "K_Iva";
            this.K_Iva.ReadOnly = true;
            this.K_Iva.Visible = false;
            // 
            // K_Ieps
            // 
            this.K_Ieps.DataPropertyName = "K_Ieps";
            this.K_Ieps.HeaderText = "K_Ieps";
            this.K_Ieps.Name = "K_Ieps";
            this.K_Ieps.ReadOnly = true;
            this.K_Ieps.Visible = false;
            // 
            // Porcentaje_Ieps
            // 
            this.Porcentaje_Ieps.DataPropertyName = "Porcentaje_Ieps";
            this.Porcentaje_Ieps.HeaderText = "Porcentaje_Ieps";
            this.Porcentaje_Ieps.Name = "Porcentaje_Ieps";
            this.Porcentaje_Ieps.ReadOnly = true;
            this.Porcentaje_Ieps.Visible = false;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Visible = false;
            // 
            // K_Familia_Articulo
            // 
            this.K_Familia_Articulo.DataPropertyName = "K_Familia_Articulo";
            this.K_Familia_Articulo.HeaderText = "K_Familia_Articulo";
            this.K_Familia_Articulo.Name = "K_Familia_Articulo";
            this.K_Familia_Articulo.ReadOnly = true;
            this.K_Familia_Articulo.Visible = false;
            // 
            // D_Familia
            // 
            this.D_Familia.DataPropertyName = "D_Familia";
            this.D_Familia.HeaderText = "Familia";
            this.D_Familia.Name = "D_Familia";
            this.D_Familia.ReadOnly = true;
            this.D_Familia.Visible = false;
            this.D_Familia.Width = 155;
            // 
            // K_Laboratorio
            // 
            this.K_Laboratorio.DataPropertyName = "K_Laboratorio";
            this.K_Laboratorio.HeaderText = "K_Laboratorio";
            this.K_Laboratorio.Name = "K_Laboratorio";
            this.K_Laboratorio.ReadOnly = true;
            this.K_Laboratorio.Visible = false;
            // 
            // D_Laboratorio
            // 
            this.D_Laboratorio.DataPropertyName = "D_Laboratorio";
            this.D_Laboratorio.HeaderText = "Laboratorio";
            this.D_Laboratorio.Name = "D_Laboratorio";
            this.D_Laboratorio.ReadOnly = true;
            this.D_Laboratorio.Visible = false;
            this.D_Laboratorio.Width = 155;
            // 
            // K_Sustancia_Activa
            // 
            this.K_Sustancia_Activa.DataPropertyName = "K_Sustancia_Activa";
            this.K_Sustancia_Activa.HeaderText = "K_Sustancia_Activa";
            this.K_Sustancia_Activa.Name = "K_Sustancia_Activa";
            this.K_Sustancia_Activa.ReadOnly = true;
            this.K_Sustancia_Activa.Visible = false;
            // 
            // D_Sustancia_Activa
            // 
            this.D_Sustancia_Activa.DataPropertyName = "D_Sustancia_Activa";
            this.D_Sustancia_Activa.HeaderText = "Sustancia Activa";
            this.D_Sustancia_Activa.Name = "D_Sustancia_Activa";
            this.D_Sustancia_Activa.ReadOnly = true;
            this.D_Sustancia_Activa.Visible = false;
            this.D_Sustancia_Activa.Width = 155;
            // 
            // D_Unidad_Medida
            // 
            this.D_Unidad_Medida.DataPropertyName = "D_Unidad_Medida";
            this.D_Unidad_Medida.HeaderText = "D_Unidad_Medida";
            this.D_Unidad_Medida.Name = "D_Unidad_Medida";
            this.D_Unidad_Medida.ReadOnly = true;
            this.D_Unidad_Medida.Visible = false;
            // 
            // Frm_Filtro_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(973, 617);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.txt_D_Articulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucSustanciaActiva1);
            this.Controls.Add(this.ucLaboratorio1);
            this.Controls.Add(this.ucFamiliaArticulo1);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Filtro_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Artículo";
            this.Load += new System.EventHandler(this.Frm_Filtro_Articulo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Filtro_Articulo_KeyDown);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtSKU, 0);
            this.Controls.SetChildIndex(this.ucFamiliaArticulo1, 0);
            this.Controls.SetChildIndex(this.ucLaboratorio1, 0);
            this.Controls.SetChildIndex(this.ucSustanciaActiva1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_D_Articulo, 0);
            this.Controls.SetChildIndex(this.dgvDisponibles, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_D_Articulo;
        private System.Windows.Forms.Label label1;
        private Controles.ucSustanciaActiva ucSustanciaActiva1;
        private Controles.ucLaboratorio ucLaboratorio1;
        private Controles.ucFamiliaArticulo ucFamiliaArticulo1;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Ieps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Ieps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Familia_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Sustancia_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Sustancia_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Unidad_Medida;
    }
}