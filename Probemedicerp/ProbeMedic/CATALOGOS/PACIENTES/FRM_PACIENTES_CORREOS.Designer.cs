﻿namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_PACIENTES_CORREOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PACIENTES_CORREOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaTipoDato = new System.Windows.Forms.Button();
            this.txtTipoDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.lblPac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.K_Paciente_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.panel3);
            this.pnlControl.Controls.Add(this.txtCorreo);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.btnBuscaTipoDato);
            this.pnlControl.Controls.Add(this.txtTipoDato);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.btnEliminar);
            this.pnlControl.Controls.Add(this.BtnAplicar);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(0, 64);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1059, 112);
            this.pnlControl.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 308);
            this.panel3.TabIndex = 25;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(115, 61);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(312, 24);
            this.txtCorreo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Correo";
            // 
            // btnBuscaTipoDato
            // 
            this.btnBuscaTipoDato.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaTipoDato.Image")));
            this.btnBuscaTipoDato.Location = new System.Drawing.Point(433, 21);
            this.btnBuscaTipoDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscaTipoDato.Name = "btnBuscaTipoDato";
            this.btnBuscaTipoDato.Size = new System.Drawing.Size(31, 24);
            this.btnBuscaTipoDato.TabIndex = 0;
            this.btnBuscaTipoDato.UseVisualStyleBackColor = true;
            this.btnBuscaTipoDato.Click += new System.EventHandler(this.btnBuscaTipoDato_Click);
            // 
            // txtTipoDato
            // 
            this.txtTipoDato.Location = new System.Drawing.Point(115, 21);
            this.txtTipoDato.Name = "txtTipoDato";
            this.txtTipoDato.ReadOnly = true;
            this.txtTipoDato.Size = new System.Drawing.Size(312, 24);
            this.txtTipoDato.TabIndex = 25;
            this.txtTipoDato.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo de Dato";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(578, 50);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 44);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAplicar.Image")));
            this.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAplicar.Location = new System.Drawing.Point(476, 50);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(88, 44);
            this.BtnAplicar.TabIndex = 2;
            this.BtnAplicar.Text = "Asignar\r\n";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // lblPac
            // 
            this.lblPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPac.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPac.Location = new System.Drawing.Point(0, 38);
            this.lblPac.Name = "lblPac";
            this.lblPac.Size = new System.Drawing.Size(1059, 26);
            this.lblPac.TabIndex = 0;
            this.lblPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 343);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 24);
            this.panel2.TabIndex = 23;
            this.panel2.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 314);
            this.panel4.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CORREOS ASIGNADOS AL PACIENTE";
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Paciente_Correo,
            this.D_Tipo_Dato,
            this.Correo,
            this.B_Activo});
            this.grDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDatos.Location = new System.Drawing.Point(0, 200);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.MultiSelect = false;
            this.grDatos.Name = "grDatos";
            this.grDatos.ReadOnly = true;
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1059, 319);
            this.grDatos.TabIndex = 26;
            this.grDatos.TabStop = false;
            // 
            // K_Paciente_Correo
            // 
            this.K_Paciente_Correo.DataPropertyName = "K_Paciente_Correo";
            this.K_Paciente_Correo.HeaderText = "K_Paciente_Correo";
            this.K_Paciente_Correo.Name = "K_Paciente_Correo";
            this.K_Paciente_Correo.ReadOnly = true;
            this.K_Paciente_Correo.Visible = false;
            this.K_Paciente_Correo.Width = 400;
            // 
            // D_Tipo_Dato
            // 
            this.D_Tipo_Dato.DataPropertyName = "D_Tipo_Dato";
            this.D_Tipo_Dato.HeaderText = "Tipo de Dato";
            this.D_Tipo_Dato.Name = "D_Tipo_Dato";
            this.D_Tipo_Dato.ReadOnly = true;
            this.D_Tipo_Dato.Width = 150;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 400;
            // 
            // B_Activo
            // 
            this.B_Activo.DataPropertyName = "B_Activo";
            this.B_Activo.HeaderText = "Activo";
            this.B_Activo.Name = "B_Activo";
            this.B_Activo.ReadOnly = true;
            this.B_Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Activo.Width = 71;
            // 
            // FRM_PACIENTES_CORREOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.lblPac);
            this.MaximizeBox = false;
            this.Name = "FRM_PACIENTES_CORREOS";
            this.Text = "PACIENTES CORREOS";
            this.Load += new System.EventHandler(this.FRM_PACIENTES_CORREOS_Load);
            this.Controls.SetChildIndex(this.lblPac, 0);
            this.Controls.SetChildIndex(this.pnlControl, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.grDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaTipoDato;
        private System.Windows.Forms.TextBox txtTipoDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Activo;
    }
}