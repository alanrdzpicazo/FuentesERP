namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_PACIENTES_TELEFONOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PACIENTES_TELEFONOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.K_Paciente_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarTipoDato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoDato = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grDatos);
            this.panel1.Controls.Add(this.pnlControl);
            this.panel1.Controls.Add(this.lblPac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 481);
            this.panel1.TabIndex = 2;
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Paciente_Telefono,
            this.K_Tipo_Dato,
            this.D_Tipo_Dato,
            this.Codigo_Pais,
            this.Lada,
            this.Telefono,
            this.B_Activo});
            this.grDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDatos.Location = new System.Drawing.Point(0, 194);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.MultiSelect = false;
            this.grDatos.Name = "grDatos";
            this.grDatos.ReadOnly = true;
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1059, 287);
            this.grDatos.TabIndex = 23;
            this.grDatos.TabStop = false;
            this.grDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellDoubleClick);
            // 
            // K_Paciente_Telefono
            // 
            this.K_Paciente_Telefono.DataPropertyName = "K_Paciente_Telefono";
            this.K_Paciente_Telefono.HeaderText = "K_Paciente_Telefono";
            this.K_Paciente_Telefono.Name = "K_Paciente_Telefono";
            this.K_Paciente_Telefono.ReadOnly = true;
            this.K_Paciente_Telefono.Visible = false;
            this.K_Paciente_Telefono.Width = 194;
            // 
            // K_Tipo_Dato
            // 
            this.K_Tipo_Dato.DataPropertyName = "K_Tipo_Dato";
            this.K_Tipo_Dato.HeaderText = "K_Tipo_Dato";
            this.K_Tipo_Dato.Name = "K_Tipo_Dato";
            this.K_Tipo_Dato.ReadOnly = true;
            this.K_Tipo_Dato.Visible = false;
            this.K_Tipo_Dato.Width = 135;
            // 
            // D_Tipo_Dato
            // 
            this.D_Tipo_Dato.DataPropertyName = "D_Tipo_Dato";
            this.D_Tipo_Dato.HeaderText = "Tipo Telefono";
            this.D_Tipo_Dato.Name = "D_Tipo_Dato";
            this.D_Tipo_Dato.ReadOnly = true;
            this.D_Tipo_Dato.Width = 115;
            // 
            // Codigo_Pais
            // 
            this.Codigo_Pais.DataPropertyName = "Codigo_Pais";
            this.Codigo_Pais.HeaderText = "Codigo País";
            this.Codigo_Pais.Name = "Codigo_Pais";
            this.Codigo_Pais.ReadOnly = true;
            this.Codigo_Pais.Width = 103;
            // 
            // Lada
            // 
            this.Lada.DataPropertyName = "Lada";
            this.Lada.HeaderText = "Lada";
            this.Lada.Name = "Lada";
            this.Lada.ReadOnly = true;
            this.Lada.Width = 62;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Numero";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 82;
            // 
            // B_Activo
            // 
            this.B_Activo.DataPropertyName = "B_Activo";
            this.B_Activo.HeaderText = "Activo";
            this.B_Activo.Name = "B_Activo";
            this.B_Activo.ReadOnly = true;
            this.B_Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Activo.Visible = false;
            this.B_Activo.Width = 85;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtTelefono);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.txtLada);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.txtCodigo);
            this.pnlControl.Controls.Add(this.btnBuscarTipoDato);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.txtTipoDato);
            this.pnlControl.Controls.Add(this.panel2);
            this.pnlControl.Controls.Add(this.btnEliminar);
            this.pnlControl.Controls.Add(this.BtnAplicar);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(0, 26);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1059, 168);
            this.pnlControl.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(133, 103);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(177, 24);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Lada ";
            // 
            // txtLada
            // 
            this.txtLada.Location = new System.Drawing.Point(133, 74);
            this.txtLada.Name = "txtLada";
            this.txtLada.Size = new System.Drawing.Size(65, 24);
            this.txtLada.TabIndex = 2;
            this.txtLada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLada_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Codigo País ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 24);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnBuscarTipoDato
            // 
            this.btnBuscarTipoDato.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTipoDato.Image")));
            this.btnBuscarTipoDato.Location = new System.Drawing.Point(352, 18);
            this.btnBuscarTipoDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarTipoDato.Name = "btnBuscarTipoDato";
            this.btnBuscarTipoDato.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarTipoDato.TabIndex = 0;
            this.btnBuscarTipoDato.UseVisualStyleBackColor = true;
            this.btnBuscarTipoDato.Click += new System.EventHandler(this.btnBuscarTipoDato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo de  Telefono";
            // 
            // txtTipoDato
            // 
            this.txtTipoDato.Location = new System.Drawing.Point(133, 18);
            this.txtTipoDato.Name = "txtTipoDato";
            this.txtTipoDato.ReadOnly = true;
            this.txtTipoDato.Size = new System.Drawing.Size(211, 24);
            this.txtTipoDato.TabIndex = 0;
            this.txtTipoDato.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 24);
            this.panel2.TabIndex = 27;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELEFONOS REGISTRADOS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(455, 90);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 44);
            this.btnEliminar.TabIndex = 5;
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
            this.BtnAplicar.Location = new System.Drawing.Point(352, 90);
            this.BtnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(88, 44);
            this.BtnAplicar.TabIndex = 4;
            this.BtnAplicar.Text = "Agregar";
            this.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefono";
            // 
            // lblPac
            // 
            this.lblPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPac.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPac.Location = new System.Drawing.Point(0, 0);
            this.lblPac.Name = "lblPac";
            this.lblPac.Size = new System.Drawing.Size(1059, 26);
            this.lblPac.TabIndex = 2;
            this.lblPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_PACIENTES_TELEFONOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FRM_PACIENTES_TELEFONOS";
            this.Text = "PACIENTES TELEFONOS";
            this.Load += new System.EventHandler(this.FRM_PACIENTES_TELEFONOS_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscarTipoDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Activo;
        public System.Windows.Forms.Button btnEliminar;
    }
}