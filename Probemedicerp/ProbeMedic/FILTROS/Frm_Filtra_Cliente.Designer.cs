namespace ProbeMedic.FILTROS
{
    partial class Frm_Filtra_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filtra_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtClave = new ProbeMedic.Controles.ucInteger32();
            this.K_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Comercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Image = ((System.Drawing.Image)(resources.GetObject("Entrar.Image")));
            this.Entrar.Location = new System.Drawing.Point(493, 61);
            this.Entrar.Size = new System.Drawing.Size(123, 35);
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "Número de Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(146, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre";
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            this.grDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Cliente,
            this.D_Cliente,
            this.C_Cliente,
            this.D_Comercial,
            this.RFC,
            this.CURP,
            this.DiasCredito,
            this.LimiteCredito,
            this.URL,
            this.Correo,
            this.No_Tarjeta,
            this.Monto1});
            this.grDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDatos.Location = new System.Drawing.Point(0, 102);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.Name = "grDatos";
            this.grDatos.ReadOnly = true;
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(659, 241);
            this.grDatos.TabIndex = 3;
            this.grDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellContentDoubleClick);
            this.grDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grDatos_KeyDown);
            this.grDatos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grDatos_PreviewKeyDown);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoEllipsis = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(493, 59);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 41);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(146, 35);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(94, 23);
            this.txtClave.TabIndex = 0;
            // 
            // K_Cliente
            // 
            this.K_Cliente.DataPropertyName = "K_Cliente";
            this.K_Cliente.FillWeight = 7.266356F;
            this.K_Cliente.HeaderText = "Clave";
            this.K_Cliente.Name = "K_Cliente";
            this.K_Cliente.ReadOnly = true;
            // 
            // D_Cliente
            // 
            this.D_Cliente.DataPropertyName = "D_Cliente";
            this.D_Cliente.FillWeight = 64.30724F;
            this.D_Cliente.HeaderText = "Descripción";
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.ReadOnly = true;
            // 
            // C_Cliente
            // 
            this.C_Cliente.DataPropertyName = "C_Cliente";
            this.C_Cliente.HeaderText = "C_Cliente";
            this.C_Cliente.Name = "C_Cliente";
            this.C_Cliente.ReadOnly = true;
            this.C_Cliente.Visible = false;
            // 
            // D_Comercial
            // 
            this.D_Comercial.DataPropertyName = "D_Comercial";
            this.D_Comercial.HeaderText = "D_Comercial";
            this.D_Comercial.Name = "D_Comercial";
            this.D_Comercial.ReadOnly = true;
            this.D_Comercial.Visible = false;
            // 
            // RFC
            // 
            this.RFC.DataPropertyName = "RFC";
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            this.RFC.Visible = false;
            // 
            // CURP
            // 
            this.CURP.DataPropertyName = "CURP";
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            this.CURP.ReadOnly = true;
            this.CURP.Visible = false;
            // 
            // DiasCredito
            // 
            this.DiasCredito.DataPropertyName = "DiasCredito";
            this.DiasCredito.HeaderText = "DiasCredito";
            this.DiasCredito.Name = "DiasCredito";
            this.DiasCredito.ReadOnly = true;
            this.DiasCredito.Visible = false;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.DataPropertyName = "LimiteCredito";
            this.LimiteCredito.HeaderText = "LimiteCredito";
            this.LimiteCredito.Name = "LimiteCredito";
            this.LimiteCredito.ReadOnly = true;
            this.LimiteCredito.Visible = false;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Visible = false;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Visible = false;
            // 
            // No_Tarjeta
            // 
            this.No_Tarjeta.DataPropertyName = "No_Tarjeta";
            this.No_Tarjeta.FillWeight = 228.4264F;
            this.No_Tarjeta.HeaderText = "No.Tarjeta";
            this.No_Tarjeta.Name = "No_Tarjeta";
            this.No_Tarjeta.ReadOnly = true;
            this.No_Tarjeta.Visible = false;
            // 
            // Monto1
            // 
            this.Monto1.DataPropertyName = "Monto";
            this.Monto1.HeaderText = "Monto";
            this.Monto1.Name = "Monto1";
            this.Monto1.ReadOnly = true;
            this.Monto1.Visible = false;
            // 
            // Frm_Filtra_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 343);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Filtra_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtra Cliente";
            this.Load += new System.EventHandler(this.Frm_Filtra_Cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Filtra_Cliente_KeyDown);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.grDatos, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Button BtnBuscar;
        private Controles.ucInteger32 txtClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Comercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto1;
    }
}