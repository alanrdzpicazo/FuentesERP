﻿namespace ProbeMedic.CATALOGOS
{
    partial class FRM_CAMBIA_OFICINA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucOficinas1 = new ProbeMedic.Controles.ucOficinas();
            this.txtClaveOficinaActual = new System.Windows.Forms.TextBox();
            this.txtOficinaActual = new System.Windows.Forms.TextBox();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucOficinas1);
            this.panel1.Controls.Add(this.txtClaveOficinaActual);
            this.panel1.Controls.Add(this.txtOficinaActual);
            this.panel1.Controls.Add(this.txtClaveUsuario);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 180);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // ucOficinas1
            // 
            this.ucOficinas1.kOficina = 0;
            this.ucOficinas1.Location = new System.Drawing.Point(184, 110);
            this.ucOficinas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucOficinas1.Name = "ucOficinas1";
            this.ucOficinas1.Size = new System.Drawing.Size(279, 31);
            this.ucOficinas1.TabIndex = 1;
            // 
            // txtClaveOficinaActual
            // 
            this.txtClaveOficinaActual.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveOficinaActual.Enabled = false;
            this.txtClaveOficinaActual.Location = new System.Drawing.Point(184, 76);
            this.txtClaveOficinaActual.Name = "txtClaveOficinaActual";
            this.txtClaveOficinaActual.ReadOnly = true;
            this.txtClaveOficinaActual.Size = new System.Drawing.Size(52, 24);
            this.txtClaveOficinaActual.TabIndex = 27;
            this.txtClaveOficinaActual.TabStop = false;
            // 
            // txtOficinaActual
            // 
            this.txtOficinaActual.Enabled = false;
            this.txtOficinaActual.Location = new System.Drawing.Point(239, 76);
            this.txtOficinaActual.Name = "txtOficinaActual";
            this.txtOficinaActual.ReadOnly = true;
            this.txtOficinaActual.Size = new System.Drawing.Size(365, 24);
            this.txtOficinaActual.TabIndex = 28;
            this.txtOficinaActual.TabStop = false;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveUsuario.Enabled = false;
            this.txtClaveUsuario.Location = new System.Drawing.Point(184, 38);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.ReadOnly = true;
            this.txtClaveUsuario.Size = new System.Drawing.Size(52, 24);
            this.txtClaveUsuario.TabIndex = 25;
            this.txtClaveUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(239, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(365, 24);
            this.txtUsuario.TabIndex = 26;
            this.txtUsuario.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oficina a cambiar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oficina Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // FRM_CAMBIA_OFICINA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 257);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_CAMBIA_OFICINA";
            this.Text = "CAMBIA OFICINA";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Controles.ucOficinas ucOficinas1;
        private System.Windows.Forms.TextBox txtClaveOficinaActual;
        private System.Windows.Forms.TextBox txtOficinaActual;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}