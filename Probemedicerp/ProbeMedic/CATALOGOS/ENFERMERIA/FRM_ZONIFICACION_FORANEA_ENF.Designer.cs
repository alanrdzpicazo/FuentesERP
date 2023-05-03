namespace ProbeMedic.CATALOGOS.ENFERMERIA
{
    partial class FRM_ZONIFICACION_FORANEA_ENF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucOficinas1 = new ProbeMedic.Controles.ucOficinas();
            this.geo_Pais1 = new ProbeMedic.Controles.Geo_Pais();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtCD_Asignadas = new System.Windows.Forms.DataGridView();
            this.K_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtCD_Disponible = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.K_Ciudad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Ciudad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Asignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Disponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ucOficinas1);
            this.panel2.Controls.Add(this.geo_Pais1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 124);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oficina";
            // 
            // ucOficinas1
            // 
            this.ucOficinas1.kOficina = 0;
            this.ucOficinas1.Location = new System.Drawing.Point(145, 4);
            this.ucOficinas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucOficinas1.Name = "ucOficinas1";
            this.ucOficinas1.Size = new System.Drawing.Size(281, 38);
            this.ucOficinas1.TabIndex = 1;
            // 
            // geo_Pais1
            // 
            this.geo_Pais1.Location = new System.Drawing.Point(131, 32);
            this.geo_Pais1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geo_Pais1.Name = "geo_Pais1";
            this.geo_Pais1.Size = new System.Drawing.Size(274, 87);
            this.geo_Pais1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 370);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtCD_Asignadas);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 364);
            this.panel3.TabIndex = 4343;
            // 
            // dtCD_Asignadas
            // 
            this.dtCD_Asignadas.AllowUserToAddRows = false;
            this.dtCD_Asignadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCD_Asignadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtCD_Asignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCD_Asignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCD_Asignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Ciudad,
            this.D_Ciudad});
            this.dtCD_Asignadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCD_Asignadas.Location = new System.Drawing.Point(0, 23);
            this.dtCD_Asignadas.Margin = new System.Windows.Forms.Padding(2);
            this.dtCD_Asignadas.Name = "dtCD_Asignadas";
            this.dtCD_Asignadas.ReadOnly = true;
            this.dtCD_Asignadas.RowTemplate.Height = 24;
            this.dtCD_Asignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCD_Asignadas.Size = new System.Drawing.Size(303, 341);
            this.dtCD_Asignadas.TabIndex = 6;
            // 
            // K_Ciudad
            // 
            this.K_Ciudad.DataPropertyName = "K_Ciudad";
            this.K_Ciudad.HeaderText = "K_Ciudad";
            this.K_Ciudad.Name = "K_Ciudad";
            this.K_Ciudad.ReadOnly = true;
            this.K_Ciudad.Visible = false;
            // 
            // D_Ciudad
            // 
            this.D_Ciudad.DataPropertyName = "D_Ciudad";
            this.D_Ciudad.HeaderText = "Ciudad";
            this.D_Ciudad.Name = "D_Ciudad";
            this.D_Ciudad.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(109, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "ASIGNADOS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(303, 23);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtCD_Disponible);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(437, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 364);
            this.panel5.TabIndex = 545454;
            // 
            // dtCD_Disponible
            // 
            this.dtCD_Disponible.AllowUserToAddRows = false;
            this.dtCD_Disponible.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCD_Disponible.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtCD_Disponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCD_Disponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCD_Disponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Ciudad2,
            this.D_Ciudad2});
            this.dtCD_Disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCD_Disponible.Location = new System.Drawing.Point(0, 24);
            this.dtCD_Disponible.Margin = new System.Windows.Forms.Padding(2);
            this.dtCD_Disponible.Name = "dtCD_Disponible";
            this.dtCD_Disponible.ReadOnly = true;
            this.dtCD_Disponible.RowTemplate.Height = 24;
            this.dtCD_Disponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCD_Disponible.Size = new System.Drawing.Size(304, 340);
            this.dtCD_Disponible.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(111, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "DISPONIBLES";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(304, 24);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Eliminar);
            this.panel4.Controls.Add(this.btn_Agregar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(312, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 364);
            this.panel4.TabIndex = 3;
            this.panel4.TabStop = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(6, 131);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(103, 42);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar --->";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(6, 63);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(103, 43);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "<--- Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // K_Ciudad2
            // 
            this.K_Ciudad2.DataPropertyName = "K_Ciudad";
            this.K_Ciudad2.HeaderText = "K_Ciudad";
            this.K_Ciudad2.Name = "K_Ciudad2";
            this.K_Ciudad2.ReadOnly = true;
            this.K_Ciudad2.Visible = false;
            // 
            // D_Ciudad2
            // 
            this.D_Ciudad2.DataPropertyName = "D_Ciudad";
            this.D_Ciudad2.HeaderText = "Ciudad";
            this.D_Ciudad2.Name = "D_Ciudad2";
            this.D_Ciudad2.ReadOnly = true;
            // 
            // FRM_ZONIFICACION_FORANEA_ENF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FRM_ZONIFICACION_FORANEA_ENF";
            this.Text = "Zonificación Foranea Enfermería";
            this.Load += new System.EventHandler(this.FRM_ZONIFICACION_FORANEA_ENF_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Asignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCD_Disponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controles.ucOficinas ucOficinas1;
        private Controles.Geo_Pais geo_Pais1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtCD_Asignadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Ciudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtCD_Disponible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Ciudad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Ciudad2;
    }
}