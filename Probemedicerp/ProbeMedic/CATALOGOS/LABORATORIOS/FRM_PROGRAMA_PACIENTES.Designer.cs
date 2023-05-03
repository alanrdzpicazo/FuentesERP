﻿namespace ProbeMedic.CATALOGOS.LABORATORIOS
{
    partial class FRM_PROGRAMA_PACIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PROGRAMA_PACIENTES));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.btnBuscaAseguradora = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtAseguradora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPrograma = new System.Windows.Forms.Button();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.BtnAplicar);
            this.pnlControles.Controls.Add(this.btnBuscaAseguradora);
            this.pnlControles.Controls.Add(this.BtnBuscar);
            this.pnlControles.Controls.Add(this.txtAseguradora);
            this.pnlControles.Controls.Add(this.label3);
            this.pnlControles.Controls.Add(this.btnBuscarPrograma);
            this.pnlControles.Controls.Add(this.txtPrograma);
            this.pnlControles.Controls.Add(this.btnBuscarPaciente);
            this.pnlControles.Controls.Add(this.txtPaciente);
            this.pnlControles.Controls.Add(this.label2);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(0, 38);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(1059, 112);
            this.pnlControles.TabIndex = 1;
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAplicar.Image")));
            this.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAplicar.Location = new System.Drawing.Point(551, 49);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(88, 44);
            this.BtnAplicar.TabIndex = 5;
            this.BtnAplicar.Text = "Asignar\r\n";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // btnBuscaAseguradora
            // 
            this.btnBuscaAseguradora.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaAseguradora.Image")));
            this.btnBuscaAseguradora.Location = new System.Drawing.Point(381, 42);
            this.btnBuscaAseguradora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscaAseguradora.Name = "btnBuscaAseguradora";
            this.btnBuscaAseguradora.Size = new System.Drawing.Size(31, 24);
            this.btnBuscaAseguradora.TabIndex = 2;
            this.btnBuscaAseguradora.UseVisualStyleBackColor = true;
            this.btnBuscaAseguradora.Click += new System.EventHandler(this.btnBuscaAseguradora_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(446, 49);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(88, 44);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtAseguradora
            // 
            this.txtAseguradora.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtAseguradora.Location = new System.Drawing.Point(130, 42);
            this.txtAseguradora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAseguradora.Name = "txtAseguradora";
            this.txtAseguradora.ReadOnly = true;
            this.txtAseguradora.Size = new System.Drawing.Size(249, 24);
            this.txtAseguradora.TabIndex = 3;
            this.txtAseguradora.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Aseguradora";
            // 
            // btnBuscarPrograma
            // 
            this.btnBuscarPrograma.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPrograma.Image")));
            this.btnBuscarPrograma.Location = new System.Drawing.Point(381, 11);
            this.btnBuscarPrograma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPrograma.Name = "btnBuscarPrograma";
            this.btnBuscarPrograma.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarPrograma.TabIndex = 1;
            this.btnBuscarPrograma.UseVisualStyleBackColor = true;
            this.btnBuscarPrograma.Click += new System.EventHandler(this.btnBuscarPrograma_Click);
            // 
            // txtPrograma
            // 
            this.txtPrograma.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtPrograma.Location = new System.Drawing.Point(130, 12);
            this.txtPrograma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.ReadOnly = true;
            this.txtPrograma.Size = new System.Drawing.Size(249, 24);
            this.txtPrograma.TabIndex = 10;
            this.txtPrograma.TabStop = false;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPaciente.Image")));
            this.btnBuscarPaciente.Location = new System.Drawing.Point(381, 72);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarPaciente.TabIndex = 3;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtPaciente.Location = new System.Drawing.Point(130, 72);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(249, 24);
            this.txtPaciente.TabIndex = 29;
            this.txtPaciente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 150);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 18);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.D_Programa,
            this.D_Aseguradora,
            this.K_Laboratorio,
            this.D_Laboratorio,
            this.B_Asignado});
            this.dgvDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisponibles.Location = new System.Drawing.Point(0, 0);
            this.dgvDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDisponibles.MultiSelect = false;
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.RowTemplate.Height = 24;
            this.dgvDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibles.Size = new System.Drawing.Size(1059, 351);
            this.dgvDisponibles.TabIndex = 19;
            this.dgvDisponibles.TabStop = false;
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.HeaderText = "Clave";
            this.K_Articulo.Name = "K_Articulo";
            this.K_Articulo.ReadOnly = true;
            this.K_Articulo.Width = 66;
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.HeaderText = "Artículo";
            this.D_Articulo.Name = "D_Articulo";
            this.D_Articulo.ReadOnly = true;
            this.D_Articulo.Width = 78;
            // 
            // D_Programa
            // 
            this.D_Programa.DataPropertyName = "D_Programa";
            this.D_Programa.HeaderText = "Programa";
            this.D_Programa.Name = "D_Programa";
            this.D_Programa.ReadOnly = true;
            this.D_Programa.Width = 93;
            // 
            // D_Aseguradora
            // 
            this.D_Aseguradora.DataPropertyName = "D_Aseguradora";
            this.D_Aseguradora.HeaderText = "Aseguradora";
            this.D_Aseguradora.Name = "D_Aseguradora";
            this.D_Aseguradora.ReadOnly = true;
            this.D_Aseguradora.Width = 110;
            // 
            // K_Laboratorio
            // 
            this.K_Laboratorio.DataPropertyName = "K_Laboratorio";
            this.K_Laboratorio.HeaderText = "K_Laboratorio";
            this.K_Laboratorio.Name = "K_Laboratorio";
            this.K_Laboratorio.ReadOnly = true;
            this.K_Laboratorio.Visible = false;
            this.K_Laboratorio.Width = 119;
            // 
            // D_Laboratorio
            // 
            this.D_Laboratorio.DataPropertyName = "D_Laboratorio";
            this.D_Laboratorio.HeaderText = "Laboratorio";
            this.D_Laboratorio.Name = "D_Laboratorio";
            this.D_Laboratorio.ReadOnly = true;
            this.D_Laboratorio.Width = 103;
            // 
            // B_Asignado
            // 
            this.B_Asignado.DataPropertyName = "B_Asignado";
            this.B_Asignado.HeaderText = "Asignado";
            this.B_Asignado.Name = "B_Asignado";
            this.B_Asignado.Width = 69;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDisponibles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 351);
            this.panel1.TabIndex = 20;
            // 
            // FRM_PROGRAMA_PACIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.Name = "FRM_PROGRAMA_PACIENTES";
            this.Text = "PROGRAMAS PACIENTES";
            this.Load += new System.EventHandler(this.FRM_PROGRAMA_ASEGURADORA_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_PROGRAMA_PACIENTES_KeyDown);
            this.Controls.SetChildIndex(this.pnlControles, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnBuscarPrograma;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button btnBuscaAseguradora;
        private System.Windows.Forms.TextBox txtAseguradora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Laboratorio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Asignado;
    }
}