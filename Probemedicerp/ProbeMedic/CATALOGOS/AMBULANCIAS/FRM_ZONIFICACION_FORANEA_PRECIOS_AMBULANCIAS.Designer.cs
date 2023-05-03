namespace ProbeMedic.CATALOGOS
{
    partial class FRM_ZONIFICACION_FORANEA_PRECIOS_AMBULANCIAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ZONIFICACION_FORANEA_PRECIOS_AMBULANCIAS));
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgergar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.zonFA_Oficina1 = new ProbeMedic.Controles.ZonFA_Oficina();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCaracteristicas = new System.Windows.Forms.Button();
            this.txt_Caracteristicas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.btnLimpiar);
            this.pnlControles.Controls.Add(this.BtnAgergar);
            this.pnlControles.Controls.Add(this.BtnBuscar);
            this.pnlControles.Controls.Add(this.zonFA_Oficina1);
            this.pnlControles.Controls.Add(this.label4);
            this.pnlControles.Controls.Add(this.label2);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.btnBuscarCaracteristicas);
            this.pnlControles.Controls.Add(this.txt_Caracteristicas);
            this.pnlControles.Controls.Add(this.label8);
            this.pnlControles.Controls.Add(this.dtpFinal);
            this.pnlControles.Controls.Add(this.dtpInicial);
            this.pnlControles.Controls.Add(this.txtPrecio);
            this.pnlControles.Controls.Add(this.label7);
            this.pnlControles.Controls.Add(this.label6);
            this.pnlControles.Controls.Add(this.label5);
            this.pnlControles.Controls.Add(this.label3);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(0, 38);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(1245, 319);
            this.pnlControles.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1069, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 67);
            this.btnLimpiar.TabIndex = 118;
            this.btnLimpiar.Text = "Limpiar \r\n[F12]";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnAgergar
            // 
            this.BtnAgergar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgergar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgergar.Image")));
            this.BtnAgergar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgergar.Location = new System.Drawing.Point(765, 216);
            this.BtnAgergar.Name = "BtnAgergar";
            this.BtnAgergar.Size = new System.Drawing.Size(134, 68);
            this.BtnAgergar.TabIndex = 116;
            this.BtnAgergar.Text = "Agregar\r\n[F10]";
            this.BtnAgergar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgergar.UseVisualStyleBackColor = true;
            this.BtnAgergar.Click += new System.EventHandler(this.BtnAgergar_Click);
            this.BtnAgergar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnAgergar_KeyDown);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(918, 216);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(134, 68);
            this.BtnBuscar.TabIndex = 117;
            this.BtnBuscar.Text = "Buscar\r\n[F11]\r\n\r\n";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnAgergar_KeyDown);
            // 
            // zonFA_Oficina1
            // 
            this.zonFA_Oficina1.Location = new System.Drawing.Point(156, 5);
            this.zonFA_Oficina1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zonFA_Oficina1.Name = "zonFA_Oficina1";
            this.zonFA_Oficina1.Size = new System.Drawing.Size(444, 202);
            this.zonFA_Oficina1.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 114;
            this.label4.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 112;
            this.label1.Text = "Pais";
            // 
            // btnBuscarCaracteristicas
            // 
            this.btnBuscarCaracteristicas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCaracteristicas.Image")));
            this.btnBuscarCaracteristicas.Location = new System.Drawing.Point(675, 218);
            this.btnBuscarCaracteristicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCaracteristicas.Name = "btnBuscarCaracteristicas";
            this.btnBuscarCaracteristicas.Size = new System.Drawing.Size(40, 32);
            this.btnBuscarCaracteristicas.TabIndex = 2;
            this.btnBuscarCaracteristicas.UseVisualStyleBackColor = true;
            this.btnBuscarCaracteristicas.Click += new System.EventHandler(this.btnBuscarCaracteristicas_Click);
            // 
            // txt_Caracteristicas
            // 
            this.txt_Caracteristicas.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Caracteristicas.Location = new System.Drawing.Point(165, 220);
            this.txt_Caracteristicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Caracteristicas.Name = "txt_Caracteristicas";
            this.txt_Caracteristicas.ReadOnly = true;
            this.txt_Caracteristicas.Size = new System.Drawing.Size(502, 28);
            this.txt_Caracteristicas.TabIndex = 110;
            this.txt_Caracteristicas.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 109;
            this.label8.Text = "Ambulancias";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(886, 68);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(315, 28);
            this.dtpFinal.TabIndex = 4;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(886, 20);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(315, 28);
            this.dtpInicial.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(165, 268);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 28);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 104;
            this.label6.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "Oficina";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 324);
            this.panel1.TabIndex = 3;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(0, 2);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(1245, 321);
            this.grdDatos.TabIndex = 4;
            // 
            // FRM_ZONIFICACION_FORANEA_PRECIOS_AMBULANCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControles);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FRM_ZONIFICACION_FORANEA_PRECIOS_AMBULANCIAS";
            this.Text = "Zonificación Foranea Precios Ambulancias";
            this.Load += new System.EventHandler(this.FRM_ZONIFICACION_FORANEA_PRECIOS_AMBULANCIAS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_ZONIFICACION_FORANEA_PRECIOS_AMBULANCIAS_KeyDown);
            this.Controls.SetChildIndex(this.pnlControles, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCaracteristicas;
        private System.Windows.Forms.TextBox txt_Caracteristicas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Controles.ZonFA_Oficina zonFA_Oficina1;
        private System.Windows.Forms.Button BtnAgergar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}