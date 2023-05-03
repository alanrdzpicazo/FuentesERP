namespace ProbeMedic.CATALOGOS.AMBULANCIAS
{
    partial class FRM_ZONIFICACION_LOCAL_AMB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtCD_Asignadas = new System.Windows.Forms.DataGridView();
            this.K_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_D_Empresa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtCD_Disponible = new System.Windows.Forms.DataGridView();
            this.K_Ciudad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Ciudad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbxTodas = new System.Windows.Forms.CheckBox();
            this.geo_Ciudades1 = new ProbeMedic.Controles.Geo_Ciudades();
            this.label6 = new System.Windows.Forms.Label();
            this.ucOficinas1 = new ProbeMedic.Controles.ucOficinas();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Asignadas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Disponible)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 480);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 315);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtCD_Asignadas);
            this.panel4.Controls.Add(this.lbl_D_Empresa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 309);
            this.panel4.TabIndex = 1;
            // 
            // dtCD_Asignadas
            // 
            this.dtCD_Asignadas.AllowUserToAddRows = false;
            this.dtCD_Asignadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCD_Asignadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtCD_Asignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCD_Asignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCD_Asignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Ciudad,
            this.D_Ciudad});
            this.dtCD_Asignadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCD_Asignadas.Location = new System.Drawing.Point(0, 17);
            this.dtCD_Asignadas.Margin = new System.Windows.Forms.Padding(2);
            this.dtCD_Asignadas.Name = "dtCD_Asignadas";
            this.dtCD_Asignadas.ReadOnly = true;
            this.dtCD_Asignadas.RowTemplate.Height = 24;
            this.dtCD_Asignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCD_Asignadas.Size = new System.Drawing.Size(346, 292);
            this.dtCD_Asignadas.TabIndex = 14;
            // 
            // K_Ciudad
            // 
            this.K_Ciudad.DataPropertyName = "K_Colonia";
            this.K_Ciudad.HeaderText = "K_Ciudad";
            this.K_Ciudad.Name = "K_Ciudad";
            this.K_Ciudad.ReadOnly = true;
            this.K_Ciudad.Visible = false;
            // 
            // D_Ciudad
            // 
            this.D_Ciudad.DataPropertyName = "D_Colonia";
            this.D_Ciudad.HeaderText = "Colonia";
            this.D_Ciudad.Name = "D_Ciudad";
            this.D_Ciudad.ReadOnly = true;
            // 
            // lbl_D_Empresa
            // 
            this.lbl_D_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.lbl_D_Empresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_D_Empresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D_Empresa.ForeColor = System.Drawing.Color.White;
            this.lbl_D_Empresa.Location = new System.Drawing.Point(0, 0);
            this.lbl_D_Empresa.Name = "lbl_D_Empresa";
            this.lbl_D_Empresa.Size = new System.Drawing.Size(346, 17);
            this.lbl_D_Empresa.TabIndex = 76;
            this.lbl_D_Empresa.Text = "ASIGNADOS";
            this.lbl_D_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtCD_Disponible);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(494, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 309);
            this.panel3.TabIndex = 0;
            // 
            // dtCD_Disponible
            // 
            this.dtCD_Disponible.AllowUserToAddRows = false;
            this.dtCD_Disponible.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCD_Disponible.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtCD_Disponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCD_Disponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCD_Disponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Ciudad2,
            this.D_Ciudad2});
            this.dtCD_Disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCD_Disponible.Location = new System.Drawing.Point(0, 17);
            this.dtCD_Disponible.Margin = new System.Windows.Forms.Padding(2);
            this.dtCD_Disponible.MultiSelect = false;
            this.dtCD_Disponible.Name = "dtCD_Disponible";
            this.dtCD_Disponible.ReadOnly = true;
            this.dtCD_Disponible.RowTemplate.Height = 24;
            this.dtCD_Disponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCD_Disponible.Size = new System.Drawing.Size(321, 292);
            this.dtCD_Disponible.TabIndex = 78;
            // 
            // K_Ciudad2
            // 
            this.K_Ciudad2.DataPropertyName = "K_Colonia";
            this.K_Ciudad2.HeaderText = "K_Ciudad";
            this.K_Ciudad2.Name = "K_Ciudad2";
            this.K_Ciudad2.ReadOnly = true;
            this.K_Ciudad2.Visible = false;
            // 
            // D_Ciudad2
            // 
            this.D_Ciudad2.DataPropertyName = "D_Colonia";
            this.D_Ciudad2.HeaderText = "Colonia";
            this.D_Ciudad2.Name = "D_Ciudad2";
            this.D_Ciudad2.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "DISPONIBLES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CbxTodas);
            this.panel2.Controls.Add(this.geo_Ciudades1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ucOficinas1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 165);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // CbxTodas
            // 
            this.CbxTodas.AutoSize = true;
            this.CbxTodas.Location = new System.Drawing.Point(669, 132);
            this.CbxTodas.Margin = new System.Windows.Forms.Padding(2);
            this.CbxTodas.Name = "CbxTodas";
            this.CbxTodas.Size = new System.Drawing.Size(136, 21);
            this.CbxTodas.TabIndex = 4;
            this.CbxTodas.Text = "Seleccionar Todas";
            this.CbxTodas.UseVisualStyleBackColor = true;
            // 
            // geo_Ciudades1
            // 
            this.geo_Ciudades1.Location = new System.Drawing.Point(89, 4);
            this.geo_Ciudades1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.geo_Ciudades1.Name = "geo_Ciudades1";
            this.geo_Ciudades1.Size = new System.Drawing.Size(348, 118);
            this.geo_Ciudades1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ciudad";
            // 
            // ucOficinas1
            // 
            this.ucOficinas1.kOficina = 0;
            this.ucOficinas1.Location = new System.Drawing.Point(99, 122);
            this.ucOficinas1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucOficinas1.Name = "ucOficinas1";
            this.ucOficinas1.Size = new System.Drawing.Size(277, 34);
            this.ucOficinas1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oficina";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Eliminar);
            this.panel5.Controls.Add(this.btn_Agregar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(355, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 309);
            this.panel5.TabIndex = 6;
            this.panel5.TabStop = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(15, 132);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(103, 42);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar --->";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(15, 77);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(103, 43);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "<--- Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // FRM_ZONIFICACION_LOCAL_AMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 557);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FRM_ZONIFICACION_LOCAL_AMB";
            this.Text = "Zonificación Local Ambulancias";
            this.Load += new System.EventHandler(this.FRM_ZONIFICACION_LOCAL_AMB_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Asignadas)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Disponible)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox CbxTodas;
        private Controles.Geo_Ciudades geo_Ciudades1;
        private System.Windows.Forms.Label label6;
        private Controles.ucOficinas ucOficinas1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_D_Empresa;
        private System.Windows.Forms.DataGridView dtCD_Asignadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Ciudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtCD_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Ciudad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Ciudad2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
    }
}