namespace ProbeMedic.CATALOGOS
{
    partial class FRM_ZONIFICACION_LPAMBULANCIA_ASEG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ZONIFICACION_LPAMBULANCIA_ASEG));
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAgergar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ucAseguradora1 = new ProbeMedic.Controles.ucAseguradora();
            this.label9 = new System.Windows.Forms.Label();
            this.zonLA_Oficina1 = new ProbeMedic.Controles.ZonLA_Oficina();
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
            this.CbxTodas = new System.Windows.Forms.CheckBox();
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
            this.pnlControles.Controls.Add(this.CbxTodas);
            this.pnlControles.Controls.Add(this.btnLimpiar);
            this.pnlControles.Controls.Add(this.label10);
            this.pnlControles.Controls.Add(this.BtnAgergar);
            this.pnlControles.Controls.Add(this.BtnBuscar);
            this.pnlControles.Controls.Add(this.ucAseguradora1);
            this.pnlControles.Controls.Add(this.label9);
            this.pnlControles.Controls.Add(this.zonLA_Oficina1);
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
            this.pnlControles.Size = new System.Drawing.Size(1362, 345);
            this.pnlControles.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1140, 249);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 67);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar \r\n[F12]";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 120;
            this.label10.Text = "Colonia";
            // 
            // BtnAgergar
            // 
            this.BtnAgergar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgergar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgergar.Image")));
            this.BtnAgergar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgergar.Location = new System.Drawing.Point(837, 250);
            this.BtnAgergar.Name = "BtnAgergar";
            this.BtnAgergar.Size = new System.Drawing.Size(127, 68);
            this.BtnAgergar.TabIndex = 6;
            this.BtnAgergar.Text = "Agregar\r\n[F10]\r\n";
            this.BtnAgergar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgergar.UseVisualStyleBackColor = true;
            this.BtnAgergar.Click += new System.EventHandler(this.BtnAgergar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(980, 249);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(144, 68);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar\r\n[F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucAseguradora1
            // 
            this.ucAseguradora1.Location = new System.Drawing.Point(969, 119);
            this.ucAseguradora1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAseguradora1.Name = "ucAseguradora1";
            this.ucAseguradora1.Size = new System.Drawing.Size(364, 43);
            this.ucAseguradora1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(833, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 115;
            this.label9.Text = "Aseguradora";
            // 
            // zonLA_Oficina1
            // 
            this.zonLA_Oficina1.Location = new System.Drawing.Point(180, 18);
            this.zonLA_Oficina1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.zonLA_Oficina1.Name = "zonLA_Oficina1";
            this.zonLA_Oficina1.Size = new System.Drawing.Size(462, 251);
            this.zonLA_Oficina1.TabIndex = 0;
            this.zonLA_Oficina1.Load += new System.EventHandler(this.zonLA_Oficina1_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 114;
            this.label4.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 112;
            this.label1.Text = "Pais";
            // 
            // btnBuscarCaracteristicas
            // 
            this.btnBuscarCaracteristicas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCaracteristicas.Image")));
            this.btnBuscarCaracteristicas.Location = new System.Drawing.Point(751, 285);
            this.btnBuscarCaracteristicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCaracteristicas.Name = "btnBuscarCaracteristicas";
            this.btnBuscarCaracteristicas.Size = new System.Drawing.Size(40, 32);
            this.btnBuscarCaracteristicas.TabIndex = 1;
            this.btnBuscarCaracteristicas.UseVisualStyleBackColor = true;
            this.btnBuscarCaracteristicas.Click += new System.EventHandler(this.btnBuscarCaracteristicas_Click);
            // 
            // txt_Caracteristicas
            // 
            this.txt_Caracteristicas.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Caracteristicas.Location = new System.Drawing.Point(184, 286);
            this.txt_Caracteristicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Caracteristicas.Name = "txt_Caracteristicas";
            this.txt_Caracteristicas.ReadOnly = true;
            this.txt_Caracteristicas.Size = new System.Drawing.Size(558, 28);
            this.txt_Caracteristicas.TabIndex = 110;
            this.txt_Caracteristicas.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 109;
            this.label8.Text = "Ambulancias";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(975, 74);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(298, 28);
            this.dtpFinal.TabIndex = 3;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(975, 22);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(298, 28);
            this.dtpInicial.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(975, 176);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 28);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(833, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 104;
            this.label6.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 238);
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
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 308);
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
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grdDatos.Size = new System.Drawing.Size(1362, 303);
            this.grdDatos.TabIndex = 4;
            // 
            // CbxTodas
            // 
            this.CbxTodas.AutoSize = true;
            this.CbxTodas.Location = new System.Drawing.Point(837, 212);
            this.CbxTodas.Name = "CbxTodas";
            this.CbxTodas.Size = new System.Drawing.Size(234, 25);
            this.CbxTodas.TabIndex = 126;
            this.CbxTodas.Text = "Agregar Todas las Colonias";
            this.CbxTodas.UseVisualStyleBackColor = true;
            // 
            // FRM_ZONIFICACION_LPAMBULANCIA_ASEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControles);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FRM_ZONIFICACION_LPAMBULANCIA_ASEG";
            this.Text = "Precios Local Ambulancia Aseguradora";
            this.Load += new System.EventHandler(this.FRM_ZONIFICACION_LPAMBULANCIA_ASEG_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_ZONIFICACION_LPAMBULANCIA_ASEG_KeyDown);
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
        private Controles.ZonLA_Oficina zonLA_Oficina1;
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
        private System.Windows.Forms.Label label9;
        private Controles.ucAseguradora ucAseguradora1;
        private System.Windows.Forms.Button BtnAgergar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox CbxTodas;
    }
}