﻿namespace ProbeMedic.VENTAS
{
    partial class Frm_Datos_Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Datos_Tarjeta));
            this.PnlAlta = new System.Windows.Forms.Panel();
            this.txtK_Cliente = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTarjetaCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarjetaCapturada = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblSaldoActual = new System.Windows.Forms.Label();
            this.lblUltimoConsumo = new System.Windows.Forms.Label();
            this.lblUltimoMConsumo = new System.Windows.Forms.Label();
            this.txtxSaldoActual = new System.Windows.Forms.TextBox();
            this.txtUltimoConsumo = new System.Windows.Forms.TextBox();
            this.txtUltimoCanje = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.PnlAlta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAlta
            // 
            this.PnlAlta.Controls.Add(this.txtK_Cliente);
            this.PnlAlta.Controls.Add(this.btnAsignar);
            this.PnlAlta.Controls.Add(this.txtCorreo);
            this.PnlAlta.Controls.Add(this.txtRFC);
            this.PnlAlta.Controls.Add(this.label9);
            this.PnlAlta.Controls.Add(this.label4);
            this.PnlAlta.Controls.Add(this.txtDescripcion);
            this.PnlAlta.Controls.Add(this.txtTarjetaCliente);
            this.PnlAlta.Controls.Add(this.label2);
            this.PnlAlta.Controls.Add(this.lblTarjetaCapturada);
            this.PnlAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAlta.Location = new System.Drawing.Point(0, 38);
            this.PnlAlta.Margin = new System.Windows.Forms.Padding(2);
            this.PnlAlta.Name = "PnlAlta";
            this.PnlAlta.Size = new System.Drawing.Size(638, 149);
            this.PnlAlta.TabIndex = 0;
            // 
            // txtK_Cliente
            // 
            this.txtK_Cliente.Enabled = false;
            this.txtK_Cliente.Location = new System.Drawing.Point(177, 16);
            this.txtK_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtK_Cliente.Name = "txtK_Cliente";
            this.txtK_Cliente.ReadOnly = true;
            this.txtK_Cliente.Size = new System.Drawing.Size(9, 24);
            this.txtK_Cliente.TabIndex = 8;
            this.txtK_Cliente.Visible = false;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(482, 97);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(91, 40);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar \r\nTarjeta";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(177, 70);
            this.txtCorreo.MaxLength = 80;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(396, 24);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtRFC
            // 
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Location = new System.Drawing.Point(177, 43);
            this.txtRFC.MaxLength = 40;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(242, 24);
            this.txtRFC.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 133;
            this.label9.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 131;
            this.label4.Text = "Correo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(177, 16);
            this.txtDescripcion.MaxLength = 80;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(397, 24);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtTarjetaCliente
            // 
            this.txtTarjetaCliente.Location = new System.Drawing.Point(177, 98);
            this.txtTarjetaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarjetaCliente.MaxLength = 16;
            this.txtTarjetaCliente.Name = "txtTarjetaCliente";
            this.txtTarjetaCliente.Size = new System.Drawing.Size(189, 24);
            this.txtTarjetaCliente.TabIndex = 3;
            this.txtTarjetaCliente.TextChanged += new System.EventHandler(this.txtTarjetaCliente_TextChanged);
            this.txtTarjetaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 129;
            this.label2.Text = "Nombre Cliente";
            // 
            // lblTarjetaCapturada
            // 
            this.lblTarjetaCapturada.AutoSize = true;
            this.lblTarjetaCapturada.Location = new System.Drawing.Point(56, 102);
            this.lblTarjetaCapturada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarjetaCapturada.Name = "lblTarjetaCapturada";
            this.lblTarjetaCapturada.Size = new System.Drawing.Size(119, 17);
            this.lblTarjetaCapturada.TabIndex = 119;
            this.lblTarjetaCapturada.Text = "Tarjeta Capturada";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(484, 40);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(90, 40);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "F8 Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // LblSaldoActual
            // 
            this.LblSaldoActual.AutoSize = true;
            this.LblSaldoActual.Location = new System.Drawing.Point(167, 119);
            this.LblSaldoActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSaldoActual.Name = "LblSaldoActual";
            this.LblSaldoActual.Size = new System.Drawing.Size(86, 17);
            this.LblSaldoActual.TabIndex = 121;
            this.LblSaldoActual.Text = "Saldo Actual ";
            // 
            // lblUltimoConsumo
            // 
            this.lblUltimoConsumo.AutoSize = true;
            this.lblUltimoConsumo.Location = new System.Drawing.Point(149, 56);
            this.lblUltimoConsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUltimoConsumo.Name = "lblUltimoConsumo";
            this.lblUltimoConsumo.Size = new System.Drawing.Size(109, 17);
            this.lblUltimoConsumo.TabIndex = 122;
            this.lblUltimoConsumo.Text = "Ultimo Consumo";
            // 
            // lblUltimoMConsumo
            // 
            this.lblUltimoMConsumo.AutoSize = true;
            this.lblUltimoMConsumo.Location = new System.Drawing.Point(131, 86);
            this.lblUltimoMConsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUltimoMConsumo.Name = "lblUltimoMConsumo";
            this.lblUltimoMConsumo.Size = new System.Drawing.Size(125, 17);
            this.lblUltimoMConsumo.TabIndex = 123;
            this.lblUltimoMConsumo.Text = "Fecha Ultimo Canje";
            // 
            // txtxSaldoActual
            // 
            this.txtxSaldoActual.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxSaldoActual.Location = new System.Drawing.Point(265, 116);
            this.txtxSaldoActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtxSaldoActual.Name = "txtxSaldoActual";
            this.txtxSaldoActual.ReadOnly = true;
            this.txtxSaldoActual.Size = new System.Drawing.Size(189, 25);
            this.txtxSaldoActual.TabIndex = 131;
            // 
            // txtUltimoConsumo
            // 
            this.txtUltimoConsumo.Location = new System.Drawing.Point(265, 56);
            this.txtUltimoConsumo.Margin = new System.Windows.Forms.Padding(2);
            this.txtUltimoConsumo.Name = "txtUltimoConsumo";
            this.txtUltimoConsumo.ReadOnly = true;
            this.txtUltimoConsumo.Size = new System.Drawing.Size(189, 24);
            this.txtUltimoConsumo.TabIndex = 132;
            // 
            // txtUltimoCanje
            // 
            this.txtUltimoCanje.Location = new System.Drawing.Point(265, 86);
            this.txtUltimoCanje.Margin = new System.Windows.Forms.Padding(2);
            this.txtUltimoCanje.Name = "txtUltimoCanje";
            this.txtUltimoCanje.ReadOnly = true;
            this.txtUltimoCanje.Size = new System.Drawing.Size(189, 24);
            this.txtUltimoCanje.TabIndex = 133;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUltimoCanje);
            this.panel1.Controls.Add(this.txtUltimoConsumo);
            this.panel1.Controls.Add(this.txtxSaldoActual);
            this.panel1.Controls.Add(this.lblUltimoMConsumo);
            this.panel1.Controls.Add(this.lblUltimoConsumo);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.LblSaldoActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 171);
            this.panel1.TabIndex = 1;
            // 
            // Frm_Datos_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(638, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlAlta);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Datos_Tarjeta";
            this.Text = "DATOS TARJETA";
            this.Load += new System.EventHandler(this.Frm_Datos_Tarjeta_Load);
            this.Shown += new System.EventHandler(this.Frm_Datos_Tarjeta_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Datos_Tarjeta_KeyUp);
            this.Controls.SetChildIndex(this.PnlAlta, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.PnlAlta.ResumeLayout(false);
            this.PnlAlta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel PnlAlta;
        private System.Windows.Forms.Label lblTarjetaCapturada;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtRFC;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtTarjetaCliente;
        private System.Windows.Forms.Label LblSaldoActual;
        private System.Windows.Forms.Label lblUltimoConsumo;
        private System.Windows.Forms.Label lblUltimoMConsumo;
        public System.Windows.Forms.TextBox txtxSaldoActual;
        public System.Windows.Forms.TextBox txtUltimoConsumo;
        public System.Windows.Forms.TextBox txtUltimoCanje;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtK_Cliente;
    }
}