﻿namespace ProbeMedic.CATALOGOS.ASEGURADORAS
{
    partial class FRM_ZONIFICACION_FPENFERMERIA_ASEG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ZONIFICACION_FPENFERMERIA_ASEG));
            this.pnlControles = new System.Windows.Forms.Panel();
            this.zonFE_Oficina1 = new ProbeMedic.Controles.ZonFE_Oficina();
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.zonFE_Oficina1);
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
            this.pnlControles.Location = new System.Drawing.Point(0, 40);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(2);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(1155, 263);
            this.pnlControles.TabIndex = 6;
            // 
            // zonFE_Oficina1
            // 
            this.zonFE_Oficina1.Location = new System.Drawing.Point(140, 11);
            this.zonFE_Oficina1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zonFE_Oficina1.Name = "zonFE_Oficina1";
            this.zonFE_Oficina1.Size = new System.Drawing.Size(334, 153);
            this.zonFE_Oficina1.TabIndex = 1;
            // 
            // BtnAgergar
            // 
            this.BtnAgergar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgergar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgergar.Image")));
            this.BtnAgergar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgergar.Location = new System.Drawing.Point(928, 202);
            this.BtnAgergar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgergar.Name = "BtnAgergar";
            this.BtnAgergar.Size = new System.Drawing.Size(99, 48);
            this.BtnAgergar.TabIndex = 7;
            this.BtnAgergar.Text = "Agregar [F10]";
            this.BtnAgergar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgergar.UseVisualStyleBackColor = true;
            this.BtnAgergar.Click += new System.EventHandler(this.BtnAgergar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(1039, 202);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(99, 48);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar\r\n[F11]\r\n";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucAseguradora1
            // 
            this.ucAseguradora1.Location = new System.Drawing.Point(589, 167);
            this.ucAseguradora1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucAseguradora1.Name = "ucAseguradora1";
            this.ucAseguradora1.Size = new System.Drawing.Size(283, 33);
            this.ucAseguradora1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 115;
            this.label9.Text = "Aseguradora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Pais";
            // 
            // btnBuscarCaracteristicas
            // 
            this.btnBuscarCaracteristicas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCaracteristicas.Image")));
            this.btnBuscarCaracteristicas.Location = new System.Drawing.Point(448, 171);
            this.btnBuscarCaracteristicas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCaracteristicas.Name = "btnBuscarCaracteristicas";
            this.btnBuscarCaracteristicas.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarCaracteristicas.TabIndex = 2;
            this.btnBuscarCaracteristicas.UseVisualStyleBackColor = true;
            this.btnBuscarCaracteristicas.Click += new System.EventHandler(this.btnBuscarCaracteristicas_Click);
            // 
            // txt_Caracteristicas
            // 
            this.txt_Caracteristicas.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txt_Caracteristicas.Location = new System.Drawing.Point(140, 170);
            this.txt_Caracteristicas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Caracteristicas.Name = "txt_Caracteristicas";
            this.txt_Caracteristicas.ReadOnly = true;
            this.txt_Caracteristicas.Size = new System.Drawing.Size(302, 24);
            this.txt_Caracteristicas.TabIndex = 110;
            this.txt_Caracteristicas.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 109;
            this.label8.Text = "Enfermeria";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(470, 212);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(246, 24);
            this.dtpFinal.TabIndex = 6;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(140, 211);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(233, 24);
            this.dtpInicial.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(928, 171);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(99, 24);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(877, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 103;
            this.label5.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 102;
            this.label3.Text = "Oficina";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(0, 307);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grdDatos.Size = new System.Drawing.Size(1155, 236);
            this.grdDatos.TabIndex = 7;
            // 
            // FRM_ZONIFICACION_FPENFERMERIA_ASEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 558);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.grdDatos);
            this.Name = "FRM_ZONIFICACION_FPENFERMERIA_ASEG";
            this.Text = "Zonificacion Foranea Precios Enfermeria Aseguradora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_ZONIFICACION_FPENFERMERIA_ASEG_KeyDown);
            this.Controls.SetChildIndex(this.grdDatos, 0);
            this.Controls.SetChildIndex(this.pnlControles, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private Controles.ZonFE_Oficina zonFE_Oficina1;
        private System.Windows.Forms.Button BtnAgergar;
        private System.Windows.Forms.Button BtnBuscar;
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
        public System.Windows.Forms.DataGridView grdDatos;
    }
}