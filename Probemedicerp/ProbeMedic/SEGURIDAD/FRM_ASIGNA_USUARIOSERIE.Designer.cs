namespace ProbeMedic.SEGURIDAD
{
    partial class FRM_ASIGNA_USUARIOSERIE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.D_SerieDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsignados = new System.Windows.Forms.DataGridView();
            this.D_SerieAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucUsuarios1 = new ProbeMedic.Controles.ucUsuarios();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 494);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.20856F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.79144F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.17004F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.82996F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 494);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(416, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 419);
            this.panel5.TabIndex = 6;
            this.panel5.TabStop = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvDisponibles);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(119, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(419, 419);
            this.panel7.TabIndex = 1;
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_SerieDisp});
            this.dgvDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisponibles.Location = new System.Drawing.Point(0, 20);
            this.dgvDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDisponibles.MultiSelect = false;
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.ReadOnly = true;
            this.dgvDisponibles.RowTemplate.Height = 24;
            this.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibles.Size = new System.Drawing.Size(419, 399);
            this.dgvDisponibles.TabIndex = 32;
            this.dgvDisponibles.TabStop = false;
            // 
            // D_SerieDisp
            // 
            this.D_SerieDisp.DataPropertyName = "D_Serie";
            this.D_SerieDisp.HeaderText = "Serie";
            this.D_SerieDisp.Name = "D_SerieDisp";
            this.D_SerieDisp.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(144, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "SERIES DISPONIBLES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 20);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btn_Agregar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(119, 419);
            this.panel6.TabIndex = 7;
            this.panel6.TabStop = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Eliminar--- >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(8, 152);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(103, 43);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "<--- Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dgvAsignados);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 419);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(146, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "SERIES ASIGNADAS";
            // 
            // dgvAsignados
            // 
            this.dgvAsignados.AllowUserToAddRows = false;
            this.dgvAsignados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAsignados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_SerieAsig});
            this.dgvAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsignados.Location = new System.Drawing.Point(0, 20);
            this.dgvAsignados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsignados.Name = "dgvAsignados";
            this.dgvAsignados.ReadOnly = true;
            this.dgvAsignados.RowTemplate.Height = 24;
            this.dgvAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignados.Size = new System.Drawing.Size(407, 399);
            this.dgvAsignados.TabIndex = 28;
            this.dgvAsignados.TabStop = false;
            // 
            // D_SerieAsig
            // 
            this.D_SerieAsig.DataPropertyName = "D_Serie";
            this.D_SerieAsig.HeaderText = "Serie";
            this.D_SerieAsig.Name = "D_SerieAsig";
            this.D_SerieAsig.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 20);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucUsuarios1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(416, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 63);
            this.panel3.TabIndex = 3;
            this.panel3.TabStop = true;
            // 
            // ucUsuarios1
            // 
            this.ucUsuarios1.Location = new System.Drawing.Point(118, 30);
            this.ucUsuarios1.Name = "ucUsuarios1";
            this.ucUsuarios1.Size = new System.Drawing.Size(286, 28);
            this.ucUsuarios1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Usuario";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 63);
            this.panel2.TabIndex = 0;
            // 
            // FRM_ASIGNA_USUARIOSERIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 571);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_ASIGNA_USUARIOSERIE";
            this.Text = "ASIGNACION DE SERIES A USUARIOS";
            this.Load += new System.EventHandler(this.FRM_ASIGNACION_USUARIOS_SERIE_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_SerieDisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_SerieAsig;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Controles.ucUsuarios ucUsuarios1;
    }
}