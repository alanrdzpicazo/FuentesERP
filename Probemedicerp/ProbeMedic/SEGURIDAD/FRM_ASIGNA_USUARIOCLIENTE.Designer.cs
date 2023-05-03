namespace ProbeMedic.SEGURIDAD
{
    partial class FRM_ASIGNA_USUARIOCLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ASIGNA_USUARIOCLIENTE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAsignaCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminaCliente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnAsignaCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 155);
            this.panel1.TabIndex = 2;
            // 
            // btnEliminaCliente
            // 
            this.btnEliminaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminaCliente.Image")));
            this.btnEliminaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaCliente.Location = new System.Drawing.Point(735, 64);
            this.btnEliminaCliente.Name = "btnEliminaCliente";
            this.btnEliminaCliente.Size = new System.Drawing.Size(136, 58);
            this.btnEliminaCliente.TabIndex = 128;
            this.btnEliminaCliente.Text = "Elimina     Cliente";
            this.btnEliminaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminaCliente.UseVisualStyleBackColor = true;
            this.btnEliminaCliente.Click += new System.EventHandler(this.btnEliminaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 127);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta ";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(562, 51);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(131, 58);
            this.BtnBuscar.TabIndex = 128;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(112, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(422, 28);
            this.txtUsuario.TabIndex = 127;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(112, 81);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(422, 28);
            this.txtCorreo.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 125;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 124;
            this.label1.Text = "Usuario";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(1491, 87);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(33, 32);
            this.btnBuscarCliente.TabIndex = 124;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCliente.Location = new System.Drawing.Point(1036, 89);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(447, 28);
            this.txtCliente.TabIndex = 126;
            this.txtCliente.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1032, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 125;
            this.label3.Text = "Cliente ";
            // 
            // BtnAsignaCliente
            // 
            this.BtnAsignaCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnAsignaCliente.Image")));
            this.BtnAsignaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsignaCliente.Location = new System.Drawing.Point(886, 64);
            this.BtnAsignaCliente.Name = "BtnAsignaCliente";
            this.BtnAsignaCliente.Size = new System.Drawing.Size(125, 58);
            this.BtnAsignaCliente.TabIndex = 122;
            this.BtnAsignaCliente.Text = "Asigna   Cliente";
            this.BtnAsignaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAsignaCliente.UseVisualStyleBackColor = true;
            this.BtnAsignaCliente.Click += new System.EventHandler(this.BtnAsignaCliente_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.grdDatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1637, 353);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(167)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1637, 5);
            this.panel3.TabIndex = 7;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Usuario,
            this.D_Usuario,
            this.K_Cliente,
            this.D_Cliente,
            this.Correo});
            this.grdDatos.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowTemplate.Height = 24;
            this.grdDatos.Size = new System.Drawing.Size(1637, 353);
            this.grdDatos.TabIndex = 0;
            // 
            // K_Usuario
            // 
            this.K_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.K_Usuario.DataPropertyName = "K_Usuario_App";
            this.K_Usuario.HeaderText = "Clave";
            this.K_Usuario.Name = "K_Usuario";
            this.K_Usuario.ReadOnly = true;
            // 
            // D_Usuario
            // 
            this.D_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D_Usuario.DataPropertyName = "D_Usuario";
            this.D_Usuario.HeaderText = "Usuario";
            this.D_Usuario.Name = "D_Usuario";
            this.D_Usuario.ReadOnly = true;
            this.D_Usuario.Width = 250;
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.HeaderText = "No.Cliente";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            // 
            // D_Cliente
            // 
            this.D_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.HeaderText = "Cliente";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            this.D_Cliente.Width = 250;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 300;
            // 
            // FRM_ASIGNA_USUARIOCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_ASIGNA_USUARIOCLIENTE";
            this.Text = "Asigna Usuario App - Cliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.Button BtnAsignaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button btnEliminaCliente;
    }
}