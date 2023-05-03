namespace ProbeMedic.CXP
{
    partial class Frm_Autoriza_CajaChica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Autoriza_CajaChica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_Asigandos = new System.Windows.Forms.DataGridView();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Disponibles = new System.Windows.Forms.DataGridView();
            this.D_Usuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BuscarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asigandos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btn_Borrar);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Location = new System.Drawing.Point(18, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 530);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(338, 112);
            this.btn_Borrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(103, 43);
            this.btn_Borrar.TabIndex = 2;
            this.btn_Borrar.Text = "Eliminar--- >";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(338, 40);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(103, 43);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "<--- Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Dgv_Asigandos
            // 
            this.Dgv_Asigandos.AllowUserToAddRows = false;
            this.Dgv_Asigandos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Asigandos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Asigandos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Asigandos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Asigandos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Asigandos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_Usuario,
            this.K_Usuario});
            this.Dgv_Asigandos.Location = new System.Drawing.Point(0, 110);
            this.Dgv_Asigandos.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Asigandos.MultiSelect = false;
            this.Dgv_Asigandos.Name = "Dgv_Asigandos";
            this.Dgv_Asigandos.ReadOnly = true;
            this.Dgv_Asigandos.RowTemplate.Height = 24;
            this.Dgv_Asigandos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Dgv_Asigandos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Asigandos.Size = new System.Drawing.Size(354, 530);
            this.Dgv_Asigandos.TabIndex = 2;
            this.Dgv_Asigandos.TabStop = false;
            // 
            // D_Usuario
            // 
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.FillWeight = 101.1233F;
            this.D_Usuario.HeaderText = "Usuario";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            // 
            // K_Usuario
            // 
            this.K_Usuario.DataPropertyName = "K_Usuario";
            this.K_Usuario.HeaderText = "K_Usuario";
            this.K_Usuario.Name = "K_Usuario";
            this.K_Usuario.ReadOnly = true;
            this.K_Usuario.Visible = false;
            // 
            // Dgv_Disponibles
            // 
            this.Dgv_Disponibles.AllowUserToAddRows = false;
            this.Dgv_Disponibles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Disponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Disponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Disponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_Usuario2,
            this.K_Usuario2});
            this.Dgv_Disponibles.Location = new System.Drawing.Point(465, 110);
            this.Dgv_Disponibles.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Disponibles.MultiSelect = false;
            this.Dgv_Disponibles.Name = "Dgv_Disponibles";
            this.Dgv_Disponibles.ReadOnly = true;
            this.Dgv_Disponibles.RowTemplate.Height = 24;
            this.Dgv_Disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Disponibles.Size = new System.Drawing.Size(334, 528);
            this.Dgv_Disponibles.TabIndex = 1;
            this.Dgv_Disponibles.TabStop = false;
            // 
            // D_Usuario2
            // 
            this.D_Usuario2.DataPropertyName = "D_Usuario";
            this.D_Usuario2.FillWeight = 149.2386F;
            this.D_Usuario2.HeaderText = "Usuario";
            this.D_Usuario2.Name = "D_Usuario2";
            this.D_Usuario2.ReadOnly = true;
            // 
            // K_Usuario2
            // 
            this.K_Usuario2.DataPropertyName = "K_Usuario";
            this.K_Usuario2.HeaderText = "K_Usuario";
            this.K_Usuario2.Name = "K_Usuario2";
            this.K_Usuario2.ReadOnly = true;
            this.K_Usuario2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 89);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 20);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.pictureBox1.Location = new System.Drawing.Point(464, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 20);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(142, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ASIGNADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(599, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "DISPONIBLES";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(89, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(297, 24);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Usuario";
            // 
            // btn_BuscarUsuario
            // 
            this.btn_BuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarUsuario.Image")));
            this.btn_BuscarUsuario.Location = new System.Drawing.Point(391, 44);
            this.btn_BuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BuscarUsuario.Name = "btn_BuscarUsuario";
            this.btn_BuscarUsuario.Size = new System.Drawing.Size(31, 24);
            this.btn_BuscarUsuario.TabIndex = 4;
            this.btn_BuscarUsuario.UseVisualStyleBackColor = true;
            this.btn_BuscarUsuario.Click += new System.EventHandler(this.btn_BuscarUsuario_Click);
            // 
            // Frm_Autoriza_CajaChica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 571);
            this.Controls.Add(this.btn_BuscarUsuario);
            this.Controls.Add(this.Dgv_Disponibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Asigandos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Autoriza_CajaChica";
            this.Text = "Usuarios Autorizan Caja Chica";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.Dgv_Asigandos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Dgv_Disponibles, 0);
            this.Controls.SetChildIndex(this.btn_BuscarUsuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asigandos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_Asigandos;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView Dgv_Disponibles;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario;
        private System.Windows.Forms.Button btn_BuscarUsuario;
    }
}