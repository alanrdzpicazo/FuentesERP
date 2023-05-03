namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_PACIENTES_DIRECCIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PACIENTES_DIRECCIONES));
            this.lblPac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.K_Paciente_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tipo_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Tipo_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Exterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Interior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entre_Calles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnAgergar = new System.Windows.Forms.Button();
            this.btnBuscarTipoDireccion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lblPac.TabIndex = 68;
            this.lblPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grDatos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 455);
            this.panel1.TabIndex = 69;
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
            this.K_Paciente_Direccion,
            this.K_Tipo_Direccion,
            this.D_Tipo_Direccion,
            this.D_Pais,
            this.D_Estado,
            this.D_Ciudad,
            this.D_Municipio,
            this.D_Colonia,
            this.Codigo_Postal,
            this.Calle,
            this.Numero_Exterior,
            this.Numero_Interior,
            this.Entre_Calles,
            this.Edificio,
            this.Piso,
            this.B_Activo});
            this.grDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDatos.Location = new System.Drawing.Point(0, 88);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.MultiSelect = false;
            this.grDatos.Name = "grDatos";
            this.grDatos.ReadOnly = true;
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1059, 367);
            this.grDatos.TabIndex = 76;
            this.grDatos.TabStop = false;
            this.grDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellContentDoubleClick);
            // 
            // K_Paciente_Direccion
            // 
            this.K_Paciente_Direccion.DataPropertyName = "K_Paciente_Direccion";
            this.K_Paciente_Direccion.HeaderText = "K_Paciente_Direccion";
            this.K_Paciente_Direccion.Name = "K_Paciente_Direccion";
            this.K_Paciente_Direccion.ReadOnly = true;
            this.K_Paciente_Direccion.Visible = false;
            this.K_Paciente_Direccion.Width = 164;
            // 
            // K_Tipo_Direccion
            // 
            this.K_Tipo_Direccion.DataPropertyName = "K_Tipo_Direccion";
            this.K_Tipo_Direccion.HeaderText = "K_Tipo_Direccion";
            this.K_Tipo_Direccion.Name = "K_Tipo_Direccion";
            this.K_Tipo_Direccion.ReadOnly = true;
            this.K_Tipo_Direccion.Visible = false;
            this.K_Tipo_Direccion.Width = 139;
            // 
            // D_Tipo_Direccion
            // 
            this.D_Tipo_Direccion.DataPropertyName = "D_Tipo_Direccion";
            this.D_Tipo_Direccion.HeaderText = "Tipo Dirección";
            this.D_Tipo_Direccion.Name = "D_Tipo_Direccion";
            this.D_Tipo_Direccion.ReadOnly = true;
            this.D_Tipo_Direccion.Width = 119;
            // 
            // D_Pais
            // 
            this.D_Pais.DataPropertyName = "D_Pais";
            this.D_Pais.HeaderText = "País";
            this.D_Pais.Name = "D_Pais";
            this.D_Pais.ReadOnly = true;
            this.D_Pais.Width = 56;
            // 
            // D_Estado
            // 
            this.D_Estado.DataPropertyName = "D_Estado";
            this.D_Estado.HeaderText = "Estado";
            this.D_Estado.Name = "D_Estado";
            this.D_Estado.ReadOnly = true;
            this.D_Estado.Width = 75;
            // 
            // D_Ciudad
            // 
            this.D_Ciudad.DataPropertyName = "D_Ciudad";
            this.D_Ciudad.HeaderText = "Ciudad";
            this.D_Ciudad.Name = "D_Ciudad";
            this.D_Ciudad.ReadOnly = true;
            this.D_Ciudad.Width = 75;
            // 
            // D_Municipio
            // 
            this.D_Municipio.DataPropertyName = "D_Municipio";
            this.D_Municipio.HeaderText = "Municipio";
            this.D_Municipio.Name = "D_Municipio";
            this.D_Municipio.ReadOnly = true;
            this.D_Municipio.Width = 88;
            // 
            // D_Colonia
            // 
            this.D_Colonia.DataPropertyName = "D_Colonia";
            this.D_Colonia.HeaderText = "Colonia";
            this.D_Colonia.Name = "D_Colonia";
            this.D_Colonia.ReadOnly = true;
            this.D_Colonia.Width = 77;
            // 
            // Codigo_Postal
            // 
            this.Codigo_Postal.DataPropertyName = "Codigo_Postal";
            this.Codigo_Postal.HeaderText = "CP";
            this.Codigo_Postal.Name = "Codigo_Postal";
            this.Codigo_Postal.ReadOnly = true;
            this.Codigo_Postal.Width = 50;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 60;
            // 
            // Numero_Exterior
            // 
            this.Numero_Exterior.DataPropertyName = "Numero_Exterior";
            this.Numero_Exterior.HeaderText = "No. Exterior";
            this.Numero_Exterior.Name = "Numero_Exterior";
            this.Numero_Exterior.ReadOnly = true;
            this.Numero_Exterior.Width = 106;
            // 
            // Numero_Interior
            // 
            this.Numero_Interior.DataPropertyName = "Numero_Interior";
            this.Numero_Interior.HeaderText = "No. Interior";
            this.Numero_Interior.Name = "Numero_Interior";
            this.Numero_Interior.ReadOnly = true;
            this.Numero_Interior.Width = 102;
            // 
            // Entre_Calles
            // 
            this.Entre_Calles.DataPropertyName = "Entre_Calles";
            this.Entre_Calles.HeaderText = "Entre Calles";
            this.Entre_Calles.Name = "Entre_Calles";
            this.Entre_Calles.ReadOnly = true;
            this.Entre_Calles.Width = 103;
            // 
            // Edificio
            // 
            this.Edificio.DataPropertyName = "Edificio";
            this.Edificio.HeaderText = "Edificio";
            this.Edificio.Name = "Edificio";
            this.Edificio.ReadOnly = true;
            this.Edificio.Width = 74;
            // 
            // Piso
            // 
            this.Piso.DataPropertyName = "Piso";
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 57;
            // 
            // B_Activo
            // 
            this.B_Activo.DataPropertyName = "B_Activo";
            this.B_Activo.HeaderText = "Activo";
            this.B_Activo.Name = "B_Activo";
            this.B_Activo.ReadOnly = true;
            this.B_Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Activo.Width = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 22);
            this.panel3.TabIndex = 75;
            this.panel3.TabStop = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "DIRECCIONES REGISTRADAS";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnBorrar);
            this.panel4.Controls.Add(this.BtnAgergar);
            this.panel4.Controls.Add(this.btnBuscarTipoDireccion);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtTipoDireccion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1059, 66);
            this.panel4.TabIndex = 74;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Image")));
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrar.Location = new System.Drawing.Point(544, 11);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(93, 44);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "Eliminar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnAgergar
            // 
            this.BtnAgergar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgergar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgergar.Image")));
            this.BtnAgergar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgergar.Location = new System.Drawing.Point(439, 10);
            this.BtnAgergar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgergar.Name = "BtnAgergar";
            this.BtnAgergar.Size = new System.Drawing.Size(89, 44);
            this.BtnAgergar.TabIndex = 2;
            this.BtnAgergar.Text = "Agregar";
            this.BtnAgergar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgergar.UseVisualStyleBackColor = true;
            this.BtnAgergar.Click += new System.EventHandler(this.BtnAgergar_Click);
            // 
            // btnBuscarTipoDireccion
            // 
            this.btnBuscarTipoDireccion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTipoDireccion.Image")));
            this.btnBuscarTipoDireccion.Location = new System.Drawing.Point(383, 22);
            this.btnBuscarTipoDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarTipoDireccion.Name = "btnBuscarTipoDireccion";
            this.btnBuscarTipoDireccion.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarTipoDireccion.TabIndex = 1;
            this.btnBuscarTipoDireccion.UseVisualStyleBackColor = true;
            this.btnBuscarTipoDireccion.Click += new System.EventHandler(this.btnBuscarTipoDireccion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tipo de  Dirección";
            // 
            // txtTipoDireccion
            // 
            this.txtTipoDireccion.Location = new System.Drawing.Point(161, 22);
            this.txtTipoDireccion.Name = "txtTipoDireccion";
            this.txtTipoDireccion.ReadOnly = true;
            this.txtTipoDireccion.Size = new System.Drawing.Size(220, 24);
            this.txtTipoDireccion.TabIndex = 74;
            this.txtTipoDireccion.TabStop = false;
            this.txtTipoDireccion.TextChanged += new System.EventHandler(this.txtTipoDireccion_TextChanged);
            // 
            // FRM_PACIENTES_DIRECCIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPac);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.Name = "FRM_PACIENTES_DIRECCIONES";
            this.Text = "PACIENTES DIRECCIONES";
            this.Load += new System.EventHandler(this.FRM_PACIENTES_DIRECCIONES_Load);
            this.Controls.SetChildIndex(this.lblPac, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnAgergar;
        private System.Windows.Forms.Button btnBuscarTipoDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoDireccion;
        public System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tipo_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Tipo_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Exterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Interior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entre_Calles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Activo;
    }
}