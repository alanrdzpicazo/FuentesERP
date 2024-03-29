﻿namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_PACIENTES_PADECIMIENTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PACIENTES_PADECIMIENTO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPac = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtICD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.btnBuscarPadecimiento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grPadecimientos = new System.Windows.Forms.DataGridView();
            this.K_Padecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Padecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Registro_Padecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grPadecimientos)).BeginInit();
            this.SuspendLayout();
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
            this.lblPac.TabIndex = 19;
            this.lblPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.BtnBuscar);
            this.pnlControl.Controls.Add(this.txtICD);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.btnEliminar);
            this.pnlControl.Controls.Add(this.BtnAplicar);
            this.pnlControl.Controls.Add(this.btnBuscarPadecimiento);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.txtPadecimiento);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(0, 64);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1059, 97);
            this.pnlControl.TabIndex = 22;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(495, 25);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 44);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtICD
            // 
            this.txtICD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtICD.Location = new System.Drawing.Point(124, 52);
            this.txtICD.Name = "txtICD";
            this.txtICD.Size = new System.Drawing.Size(312, 24);
            this.txtICD.TabIndex = 3;
            this.txtICD.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "ICD";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(715, 25);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar\r\n\r\n";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAplicar.Image")));
            this.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAplicar.Location = new System.Drawing.Point(606, 25);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(94, 44);
            this.BtnAplicar.TabIndex = 5;
            this.BtnAplicar.Text = "Asignar\r\n\r\n";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // btnBuscarPadecimiento
            // 
            this.btnBuscarPadecimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPadecimiento.Image")));
            this.btnBuscarPadecimiento.Location = new System.Drawing.Point(439, 17);
            this.btnBuscarPadecimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPadecimiento.Name = "btnBuscarPadecimiento";
            this.btnBuscarPadecimiento.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarPadecimiento.TabIndex = 2;
            this.btnBuscarPadecimiento.UseVisualStyleBackColor = true;
            this.btnBuscarPadecimiento.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Padecimiento";
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Location = new System.Drawing.Point(124, 17);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.ReadOnly = true;
            this.txtPadecimiento.Size = new System.Drawing.Size(312, 24);
            this.txtPadecimiento.TabIndex = 1;
            this.txtPadecimiento.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 24);
            this.panel2.TabIndex = 23;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PADECIMIENTOS ASIGNADOS AL PACIENTE";
            // 
            // grPadecimientos
            // 
            this.grPadecimientos.AllowUserToAddRows = false;
            this.grPadecimientos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grPadecimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grPadecimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grPadecimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grPadecimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Padecimiento,
            this.D_Padecimiento,
            this.ICD,
            this.F_Registro_Padecimiento,
            this.K_Paciente,
            this.Nombre_Paciente});
            this.grPadecimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPadecimientos.Location = new System.Drawing.Point(0, 185);
            this.grPadecimientos.Margin = new System.Windows.Forms.Padding(2);
            this.grPadecimientos.MultiSelect = false;
            this.grPadecimientos.Name = "grPadecimientos";
            this.grPadecimientos.ReadOnly = true;
            this.grPadecimientos.RowTemplate.Height = 24;
            this.grPadecimientos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grPadecimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grPadecimientos.Size = new System.Drawing.Size(1059, 334);
            this.grPadecimientos.TabIndex = 24;
            this.grPadecimientos.TabStop = false;
            this.grPadecimientos.SelectionChanged += new System.EventHandler(this.grDatos_SelectionChanged);
            // 
            // K_Padecimiento
            // 
            this.K_Padecimiento.DataPropertyName = "K_Padecimiento";
            this.K_Padecimiento.HeaderText = "K_Padecimiento";
            this.K_Padecimiento.Name = "K_Padecimiento";
            this.K_Padecimiento.ReadOnly = true;
            this.K_Padecimiento.Visible = false;
            this.K_Padecimiento.Width = 130;
            // 
            // D_Padecimiento
            // 
            this.D_Padecimiento.DataPropertyName = "D_Padecimiento";
            this.D_Padecimiento.HeaderText = "Padecimiento";
            this.D_Padecimiento.Name = "D_Padecimiento";
            this.D_Padecimiento.ReadOnly = true;
            this.D_Padecimiento.Width = 114;
            // 
            // ICD
            // 
            this.ICD.DataPropertyName = "ICD";
            this.ICD.HeaderText = "ICD";
            this.ICD.Name = "ICD";
            this.ICD.ReadOnly = true;
            this.ICD.Width = 56;
            // 
            // F_Registro_Padecimiento
            // 
            this.F_Registro_Padecimiento.DataPropertyName = "F_Registro_Padecimiento";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.F_Registro_Padecimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.F_Registro_Padecimiento.HeaderText = "Fecha Registro";
            this.F_Registro_Padecimiento.Name = "F_Registro_Padecimiento";
            this.F_Registro_Padecimiento.ReadOnly = true;
            this.F_Registro_Padecimiento.Width = 123;
            // 
            // K_Paciente
            // 
            this.K_Paciente.DataPropertyName = "K_Paciente";
            this.K_Paciente.HeaderText = "ID Paciente";
            this.K_Paciente.Name = "K_Paciente";
            this.K_Paciente.ReadOnly = true;
            this.K_Paciente.Width = 102;
            // 
            // Nombre_Paciente
            // 
            this.Nombre_Paciente.DataPropertyName = "Nombre_Paciente";
            this.Nombre_Paciente.HeaderText = "Nombre Paciente";
            this.Nombre_Paciente.Name = "Nombre_Paciente";
            this.Nombre_Paciente.ReadOnly = true;
            this.Nombre_Paciente.Width = 137;
            // 
            // FRM_PACIENTES_PADECIMIENTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.grPadecimientos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.lblPac);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FRM_PACIENTES_PADECIMIENTO";
            this.Text = "PACIENTES PADECIMIENTOS";
            this.Controls.SetChildIndex(this.lblPac, 0);
            this.Controls.SetChildIndex(this.pnlControl, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.grPadecimientos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grPadecimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtICD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Button btnBuscarPadecimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grPadecimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Padecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Padecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICD;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Registro_Padecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Paciente;
    }
}