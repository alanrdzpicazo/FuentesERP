namespace ProbeMedic.CATALOGOS
{
    partial class FRM_ZONIFICACION_FPAMBULANCIA_ASEG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ZONIFICACION_FPAMBULANCIA_ASEG));
            this.pnlControles = new System.Windows.Forms.Panel();
            this.zonFA_Oficina1 = new ProbeMedic.Controles.ZonFA_Oficina();
            this.BtnAgergar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ucAseguradora1 = new ProbeMedic.Controles.ucAseguradora();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnLimpiar = new System.Windows.Forms.Button();
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
            this.pnlControles.Controls.Add(this.zonFA_Oficina1);
            this.pnlControles.Controls.Add(this.BtnAgergar);
            this.pnlControles.Controls.Add(this.BtnBuscar);
            this.pnlControles.Controls.Add(this.ucAseguradora1);
            this.pnlControles.Controls.Add(this.label9);
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
            this.pnlControles.Size = new System.Drawing.Size(1368, 306);
            this.pnlControles.TabIndex = 4;
            // 
            // zonFA_Oficina1
            // 
            this.zonFA_Oficina1.Location = new System.Drawing.Point(162, 0);
            this.zonFA_Oficina1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zonFA_Oficina1.Name = "zonFA_Oficina1";
            this.zonFA_Oficina1.Size = new System.Drawing.Size(556, 213);
            this.zonFA_Oficina1.TabIndex = 119;
            // 
            // BtnAgergar
            // 
            this.BtnAgergar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgergar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgergar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgergar.Image")));
            this.BtnAgergar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAgergar.Location = new System.Drawing.Point(860, 232);
            this.BtnAgergar.Name = "BtnAgergar";
            this.BtnAgergar.Size = new System.Drawing.Size(132, 66);
            this.BtnAgergar.TabIndex = 117;
            this.BtnAgergar.Text = "Agregar [F10]";
            this.BtnAgergar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnAgergar.UseVisualStyleBackColor = true;
            this.BtnAgergar.Click += new System.EventHandler(this.BtnAgergar_Click_1);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(1015, 231);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(134, 68);
            this.BtnBuscar.TabIndex = 118;
            this.BtnBuscar.Text = "Buscar  [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // ucAseguradora1
            // 
            this.ucAseguradora1.Location = new System.Drawing.Point(165, 263);
            this.ucAseguradora1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAseguradora1.Name = "ucAseguradora1";
            this.ucAseguradora1.Size = new System.Drawing.Size(365, 43);
            this.ucAseguradora1.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 115;
            this.label9.Text = "Aseguradora";
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
            this.btnBuscarCaracteristicas.Location = new System.Drawing.Point(567, 219);
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
            this.txt_Caracteristicas.Location = new System.Drawing.Point(171, 220);
            this.txt_Caracteristicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Caracteristicas.Name = "txt_Caracteristicas";
            this.txt_Caracteristicas.ReadOnly = true;
            this.txt_Caracteristicas.Size = new System.Drawing.Size(387, 28);
            this.txt_Caracteristicas.TabIndex = 110;
            this.txt_Caracteristicas.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 109;
            this.label8.Text = "Ambulancias";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(990, 68);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(315, 28);
            this.dtpFinal.TabIndex = 4;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(990, 13);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(315, 28);
            this.dtpInicial.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(675, 271);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 28);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 104;
            this.label6.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(856, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 174);
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
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 374);
            this.panel1.TabIndex = 5;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(0, 7);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(1368, 359);
            this.grdDatos.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1171, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 67);
            this.btnLimpiar.TabIndex = 120;
            this.btnLimpiar.Text = "Limpiar \r\n[F12]";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FRM_ZONIFICACION_FPAMBULANCIA_ASEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControles);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "FRM_ZONIFICACION_FPAMBULANCIA_ASEG";
            this.Text = "Zonificacion Foranea Precios Ambulancia Aseguradora";
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
        private Controles.ucAseguradora ucAseguradora1;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button BtnAgergar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdDatos;
        private Controles.ZonFA_Oficina zonFA_Oficina1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}