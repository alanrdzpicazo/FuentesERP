﻿namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_PACIENTES_INSTITUCIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PACIENTES_INSTITUCIONES));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPac = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.btnBuscarInstitucion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.K_Institucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Institucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Institucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC_Institucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
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
            this.lblPac.TabIndex = 17;
            this.lblPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnEliminar);
            this.pnlControl.Controls.Add(this.BtnAplicar);
            this.pnlControl.Controls.Add(this.btnBuscarInstitucion);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.txtInstitucion);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(0, 67);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1059, 74);
            this.pnlControl.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(571, 16);
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
            this.BtnAplicar.Location = new System.Drawing.Point(469, 16);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(88, 44);
            this.BtnAplicar.TabIndex = 2;
            this.BtnAplicar.Text = "Asignar\r\n";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // btnBuscarInstitucion
            // 
            this.btnBuscarInstitucion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInstitucion.Image")));
            this.btnBuscarInstitucion.Location = new System.Drawing.Point(410, 26);
            this.btnBuscarInstitucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarInstitucion.Name = "btnBuscarInstitucion";
            this.btnBuscarInstitucion.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarInstitucion.TabIndex = 1;
            this.btnBuscarInstitucion.UseVisualStyleBackColor = true;
            this.btnBuscarInstitucion.Click += new System.EventHandler(this.btnBuscarInstitucion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Institución";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Location = new System.Drawing.Point(92, 26);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.ReadOnly = true;
            this.txtInstitucion.Size = new System.Drawing.Size(312, 24);
            this.txtInstitucion.TabIndex = 14;
            this.txtInstitucion.TabStop = false;
            this.txtInstitucion.TextChanged += new System.EventHandler(this.txtInstitucion_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 24);
            this.panel2.TabIndex = 20;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTITUCIONES ASIGNADAS AL PACIENTE";
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Institucion,
            this.D_Institucion,
            this.C_Institucion,
            this.RFC_Institucion});
            this.grDatos.Location = new System.Drawing.Point(0, 165);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.MultiSelect = false;
            this.grDatos.Name = "grDatos";
            this.grDatos.ReadOnly = true;
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1059, 352);
            this.grDatos.TabIndex = 19;
            this.grDatos.TabStop = false;
            this.grDatos.SelectionChanged += new System.EventHandler(this.grDatos_SelectionChanged);
            // 
            // K_Institucion
            // 
            this.K_Institucion.DataPropertyName = "K_Institucion";
            this.K_Institucion.HeaderText = "Num. Institución";
            this.K_Institucion.Name = "K_Institucion";
            this.K_Institucion.ReadOnly = true;
            this.K_Institucion.Width = 122;
            // 
            // D_Institucion
            // 
            this.D_Institucion.DataPropertyName = "D_Institucion";
            this.D_Institucion.HeaderText = "Institución";
            this.D_Institucion.Name = "D_Institucion";
            this.D_Institucion.ReadOnly = true;
            this.D_Institucion.Width = 350;
            // 
            // C_Institucion
            // 
            this.C_Institucion.DataPropertyName = "C_Institucion";
            this.C_Institucion.HeaderText = "Nombre Corto";
            this.C_Institucion.Name = "C_Institucion";
            this.C_Institucion.ReadOnly = true;
            this.C_Institucion.Width = 170;
            // 
            // RFC_Institucion
            // 
            this.RFC_Institucion.DataPropertyName = "RFC_Institucion";
            this.RFC_Institucion.HeaderText = "RFC";
            this.RFC_Institucion.Name = "RFC_Institucion";
            this.RFC_Institucion.ReadOnly = true;
            this.RFC_Institucion.Width = 200;
            // 
            // FRM_PACIENTES_INSTITUCIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.lblPac);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FRM_PACIENTES_INSTITUCIONES";
            this.Text = "PACIENTES INSTITUCIONES";
            this.Load += new System.EventHandler(this.FRM_PACIENTES_INSTITUCIONES_Load);
            this.Controls.SetChildIndex(this.lblPac, 0);
            this.Controls.SetChildIndex(this.pnlControl, 0);
            this.Controls.SetChildIndex(this.grDatos, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
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

        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Button btnBuscarInstitucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Institucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Institucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Institucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC_Institucion;
    }
}