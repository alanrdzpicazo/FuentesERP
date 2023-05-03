﻿namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_PACIENTES_MEDICOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PACIENTES_MEDICOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.K_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Asignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Tratante = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Dictaminador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn3.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 296;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 296;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnEliminar);
            this.pnlControl.Controls.Add(this.BtnAplicar);
            this.pnlControl.Controls.Add(this.btnBuscarMedico);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.txtMedico);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(0, 38);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1059, 102);
            this.pnlControl.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(561, 39);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 44);
            this.btnEliminar.TabIndex = 18;
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
            this.BtnAplicar.Location = new System.Drawing.Point(459, 39);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(98, 44);
            this.BtnAplicar.TabIndex = 17;
            this.BtnAplicar.Text = "Agregar";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMedico.Image")));
            this.btnBuscarMedico.Location = new System.Drawing.Point(394, 49);
            this.btnBuscarMedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarMedico.TabIndex = 16;
            this.btnBuscarMedico.UseVisualStyleBackColor = true;
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Médico";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(81, 49);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.ReadOnly = true;
            this.txtMedico.Size = new System.Drawing.Size(312, 24);
            this.txtMedico.TabIndex = 14;
            this.txtMedico.TabStop = false;
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Medico,
            this.Medico,
            this.F_Asignacion,
            this.D_Profesion,
            this.D_Especialidad,
            this.Correo,
            this.B_Tratante,
            this.B_Dictaminador});
            this.grDatos.Location = new System.Drawing.Point(2, 2);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.MultiSelect = false;
            this.grDatos.Name = "grDatos";
            this.grDatos.ReadOnly = true;
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1055, 347);
            this.grDatos.TabIndex = 14;
            this.grDatos.TabStop = false;
            this.grDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellContentDoubleClick);
            // 
            // K_Medico
            // 
            this.K_Medico.DataPropertyName = "K_Medico";
            this.K_Medico.HeaderText = "Clave Medico";
            this.K_Medico.Name = "K_Medico";
            this.K_Medico.ReadOnly = true;
            this.K_Medico.Width = 112;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "Médico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Width = 75;
            // 
            // F_Asignacion
            // 
            this.F_Asignacion.DataPropertyName = "F_Asignacion";
            this.F_Asignacion.HeaderText = "Fecha Asignación";
            this.F_Asignacion.Name = "F_Asignacion";
            this.F_Asignacion.ReadOnly = true;
            this.F_Asignacion.Width = 137;
            // 
            // D_Profesion
            // 
            this.D_Profesion.DataPropertyName = "D_Profesion";
            this.D_Profesion.HeaderText = "Profesion";
            this.D_Profesion.Name = "D_Profesion";
            this.D_Profesion.ReadOnly = true;
            this.D_Profesion.Width = 89;
            // 
            // D_Especialidad
            // 
            this.D_Especialidad.DataPropertyName = "D_Especialidad";
            this.D_Especialidad.HeaderText = "Especialidad";
            this.D_Especialidad.Name = "D_Especialidad";
            this.D_Especialidad.ReadOnly = true;
            this.D_Especialidad.Width = 105;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 75;
            // 
            // B_Tratante
            // 
            this.B_Tratante.DataPropertyName = "B_Tratante";
            this.B_Tratante.HeaderText = "T";
            this.B_Tratante.Name = "B_Tratante";
            this.B_Tratante.ReadOnly = true;
            this.B_Tratante.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Tratante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Tratante.TrueValue = "B_Tratante";
            this.B_Tratante.Width = 41;
            // 
            // B_Dictaminador
            // 
            this.B_Dictaminador.DataPropertyName = "B_Dictaminador";
            this.B_Dictaminador.HeaderText = "D";
            this.B_Dictaminador.Name = "B_Dictaminador";
            this.B_Dictaminador.ReadOnly = true;
            this.B_Dictaminador.TrueValue = "B_Dictaminador";
            this.B_Dictaminador.Width = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 24);
            this.panel2.TabIndex = 15;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDICOS ASIGNADOS AL PACIENTE";
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
            this.lblPac.TabIndex = 16;
            this.lblPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grDatos);
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 351);
            this.panel1.TabIndex = 17;
            // 
            // FRM_PACIENTES_MEDICOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPac);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlControl);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PACIENTES_MEDICOS";
            this.Text = "PACIENTES MEDICOS";
            this.Load += new System.EventHandler(this.FRM_PACIENTES_MEDICOS_Load);
            this.Controls.SetChildIndex(this.pnlControl, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblPac, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Button btnBuscarMedico;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Asignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Tratante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Dictaminador;
    }
}