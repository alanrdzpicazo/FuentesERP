﻿namespace ProbeMedic.ENTREGAS
{
    partial class FRM_ENTREGA_PEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ENTREGA_PEDIDOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btnBuscaEmpleado = new System.Windows.Forms.Button();
            this.txtClaveEmpleado = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_busca_remisiones = new System.Windows.Forms.Button();
            this.txtClaveRemision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_oficina1 = new ProbeMedic.Controles.cbx_oficina();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.CLAVE_REMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE_OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTATUS_REMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(930, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Entrega de Pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.btn_agregar);
            this.panel_filtros.Controls.Add(this.btnBuscaEmpleado);
            this.panel_filtros.Controls.Add(this.txtClaveEmpleado);
            this.panel_filtros.Controls.Add(this.txtEmpleado);
            this.panel_filtros.Controls.Add(this.label4);
            this.panel_filtros.Controls.Add(this.label2);
            this.panel_filtros.Controls.Add(this.btn_busca_remisiones);
            this.panel_filtros.Controls.Add(this.txtClaveRemision);
            this.panel_filtros.Controls.Add(this.label3);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.cbx_oficina1);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filtros.Location = new System.Drawing.Point(0, 0);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(930, 115);
            this.panel_filtros.TabIndex = 0;
            this.panel_filtros.TabStop = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Green;
            this.btn_agregar.Location = new System.Drawing.Point(224, 73);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(34, 25);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "+";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btnBuscaEmpleado
            // 
            this.btnBuscaEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaEmpleado.Image")));
            this.btnBuscaEmpleado.Location = new System.Drawing.Point(479, 43);
            this.btnBuscaEmpleado.Name = "btnBuscaEmpleado";
            this.btnBuscaEmpleado.Size = new System.Drawing.Size(32, 24);
            this.btnBuscaEmpleado.TabIndex = 2;
            this.btnBuscaEmpleado.Tag = "";
            this.btnBuscaEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscaEmpleado.Click += new System.EventHandler(this.btnBuscaEmpleado_Click);
            // 
            // txtClaveEmpleado
            // 
            this.txtClaveEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveEmpleado.Location = new System.Drawing.Point(88, 43);
            this.txtClaveEmpleado.Name = "txtClaveEmpleado";
            this.txtClaveEmpleado.Size = new System.Drawing.Size(52, 24);
            this.txtClaveEmpleado.TabIndex = 15;
            this.txtClaveEmpleado.TabStop = false;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(144, 43);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(334, 24);
            this.txtEmpleado.TabIndex = 16;
            this.txtEmpleado.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // btn_busca_remisiones
            // 
            this.btn_busca_remisiones.Image = ((System.Drawing.Image)(resources.GetObject("btn_busca_remisiones.Image")));
            this.btn_busca_remisiones.Location = new System.Drawing.Point(190, 73);
            this.btn_busca_remisiones.Name = "btn_busca_remisiones";
            this.btn_busca_remisiones.Size = new System.Drawing.Size(32, 24);
            this.btn_busca_remisiones.TabIndex = 3;
            this.btn_busca_remisiones.Tag = "";
            this.btn_busca_remisiones.UseVisualStyleBackColor = true;
            this.btn_busca_remisiones.Click += new System.EventHandler(this.btn_busca_remisiones_Click);
            // 
            // txtClaveRemision
            // 
            this.txtClaveRemision.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveRemision.Enabled = false;
            this.txtClaveRemision.Location = new System.Drawing.Point(89, 73);
            this.txtClaveRemision.Name = "txtClaveRemision";
            this.txtClaveRemision.Size = new System.Drawing.Size(99, 24);
            this.txtClaveRemision.TabIndex = 8;
            this.txtClaveRemision.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remisión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oficina";
            // 
            // cbx_oficina1
            // 
            this.cbx_oficina1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_oficina1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_oficina1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_oficina1.Enabled = false;
            this.cbx_oficina1.FormattingEnabled = true;
            this.cbx_oficina1.Location = new System.Drawing.Point(89, 12);
            this.cbx_oficina1.Name = "cbx_oficina1";
            this.cbx_oficina1.Size = new System.Drawing.Size(178, 24);
            this.cbx_oficina1.TabIndex = 1;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE_REMISION,
            this.CLAVE_OFICINA,
            this.OFICINA,
            this.EMPLEADO,
            this.ESTATUS_REMISION});
            this.dgv_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datos.Location = new System.Drawing.Point(0, 115);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.Size = new System.Drawing.Size(930, 325);
            this.dgv_datos.TabIndex = 0;
            // 
            // CLAVE_REMISION
            // 
            this.CLAVE_REMISION.DataPropertyName = "CLAVE_REMISION";
            this.CLAVE_REMISION.HeaderText = "No. Remisión";
            this.CLAVE_REMISION.Name = "CLAVE_REMISION";
            this.CLAVE_REMISION.ReadOnly = true;
            this.CLAVE_REMISION.Width = 110;
            // 
            // CLAVE_OFICINA
            // 
            this.CLAVE_OFICINA.DataPropertyName = "CLAVE_OFICINA";
            this.CLAVE_OFICINA.HeaderText = "";
            this.CLAVE_OFICINA.Name = "CLAVE_OFICINA";
            this.CLAVE_OFICINA.ReadOnly = true;
            this.CLAVE_OFICINA.Visible = false;
            this.CLAVE_OFICINA.Width = 19;
            // 
            // OFICINA
            // 
            this.OFICINA.DataPropertyName = "OFICINA";
            this.OFICINA.HeaderText = "Oficina";
            this.OFICINA.Name = "OFICINA";
            this.OFICINA.ReadOnly = true;
            this.OFICINA.Width = 130;
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.DataPropertyName = "EMPLEADO";
            this.EMPLEADO.HeaderText = "Empleado";
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.ReadOnly = true;
            this.EMPLEADO.Width = 250;
            // 
            // ESTATUS_REMISION
            // 
            this.ESTATUS_REMISION.DataPropertyName = "ESTATUS_REMISION";
            this.ESTATUS_REMISION.HeaderText = "Estatus remisión";
            this.ESTATUS_REMISION.Name = "ESTATUS_REMISION";
            this.ESTATUS_REMISION.ReadOnly = true;
            this.ESTATUS_REMISION.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_datos);
            this.panel1.Controls.Add(this.panel_filtros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 440);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // FRM_ENTREGA_PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FRM_ENTREGA_PEDIDOS";
            this.Text = "ENTREGA DE PEDIDOS";
            this.Load += new System.EventHandler(this.FRM_ENTREGA_PEDIDOS_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.DataGridView dgv_datos;
        private Controles.cbx_oficina cbx_oficina1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_busca_remisiones;
        private System.Windows.Forms.TextBox txtClaveRemision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaEmpleado;
        private System.Windows.Forms.TextBox txtClaveEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_REMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS_REMISION;
    }
}