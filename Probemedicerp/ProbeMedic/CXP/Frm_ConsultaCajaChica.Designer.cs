namespace ProbeMedic.CXP
{
    partial class Frm_ConsultaCajaChica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaCajaChica));
            this.PnlConsulta = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.CbxLiquidada = new System.Windows.Forms.CheckBox();
            this.CbxReposicion = new System.Windows.Forms.RadioButton();
            this.CbxViaticos = new System.Windows.Forms.RadioButton();
            this.CbxCajaChica = new System.Windows.Forms.RadioButton();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.BtnOficina = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.txtK_Usuario = new System.Windows.Forms.TextBox();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.txtD_Usuario = new System.Windows.Forms.TextBox();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Caja_Chica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario_Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Abierto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Liquidada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.F_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Caja_Chica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Viaticos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Reposicion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.PnlConsulta.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlConsulta
            // 
            this.PnlConsulta.Controls.Add(this.gbFiltros);
            this.PnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlConsulta.Location = new System.Drawing.Point(0, 38);
            this.PnlConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.PnlConsulta.Name = "PnlConsulta";
            this.PnlConsulta.Size = new System.Drawing.Size(1066, 118);
            this.PnlConsulta.TabIndex = 0;
            this.PnlConsulta.TabStop = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.CbxLiquidada);
            this.gbFiltros.Controls.Add(this.CbxReposicion);
            this.gbFiltros.Controls.Add(this.CbxViaticos);
            this.gbFiltros.Controls.Add(this.CbxCajaChica);
            this.gbFiltros.Controls.Add(this.txtClaveOficina);
            this.gbFiltros.Controls.Add(this.BtnOficina);
            this.gbFiltros.Controls.Add(this.LblUsuario);
            this.gbFiltros.Controls.Add(this.txtK_Usuario);
            this.gbFiltros.Controls.Add(this.BtnUsuario);
            this.gbFiltros.Controls.Add(this.txtD_Usuario);
            this.gbFiltros.Controls.Add(this.cbxAlmacen);
            this.gbFiltros.Controls.Add(this.label18);
            this.gbFiltros.Controls.Add(this.txtOficina);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiltros.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.Black;
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1066, 118);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Tipo de Búsqueda";
            // 
            // CbxLiquidada
            // 
            this.CbxLiquidada.AutoSize = true;
            this.CbxLiquidada.Location = new System.Drawing.Point(544, 55);
            this.CbxLiquidada.Margin = new System.Windows.Forms.Padding(2);
            this.CbxLiquidada.Name = "CbxLiquidada";
            this.CbxLiquidada.Size = new System.Drawing.Size(84, 21);
            this.CbxLiquidada.TabIndex = 8;
            this.CbxLiquidada.Text = "Liquidada";
            this.CbxLiquidada.UseVisualStyleBackColor = true;
            // 
            // CbxReposicion
            // 
            this.CbxReposicion.AutoSize = true;
            this.CbxReposicion.Location = new System.Drawing.Point(739, 21);
            this.CbxReposicion.Margin = new System.Windows.Forms.Padding(2);
            this.CbxReposicion.Name = "CbxReposicion";
            this.CbxReposicion.Size = new System.Drawing.Size(91, 21);
            this.CbxReposicion.TabIndex = 7;
            this.CbxReposicion.TabStop = true;
            this.CbxReposicion.Text = "Reposición";
            this.CbxReposicion.UseVisualStyleBackColor = true;
            // 
            // CbxViaticos
            // 
            this.CbxViaticos.AutoSize = true;
            this.CbxViaticos.Location = new System.Drawing.Point(643, 21);
            this.CbxViaticos.Margin = new System.Windows.Forms.Padding(2);
            this.CbxViaticos.Name = "CbxViaticos";
            this.CbxViaticos.Size = new System.Drawing.Size(71, 21);
            this.CbxViaticos.TabIndex = 6;
            this.CbxViaticos.TabStop = true;
            this.CbxViaticos.Text = "Víaticos";
            this.CbxViaticos.UseVisualStyleBackColor = true;
            // 
            // CbxCajaChica
            // 
            this.CbxCajaChica.AutoSize = true;
            this.CbxCajaChica.Location = new System.Drawing.Point(544, 22);
            this.CbxCajaChica.Margin = new System.Windows.Forms.Padding(2);
            this.CbxCajaChica.Name = "CbxCajaChica";
            this.CbxCajaChica.Size = new System.Drawing.Size(90, 21);
            this.CbxCajaChica.TabIndex = 5;
            this.CbxCajaChica.TabStop = true;
            this.CbxCajaChica.Text = "Caja Chica";
            this.CbxCajaChica.UseVisualStyleBackColor = true;
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.Location = new System.Drawing.Point(121, 24);
            this.txtClaveOficina.MaxLength = 5;
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.Size = new System.Drawing.Size(50, 24);
            this.txtClaveOficina.TabIndex = 145;
            this.txtClaveOficina.TabStop = false;
            this.txtClaveOficina.Tag = "ENTERO";
            // 
            // BtnOficina
            // 
            this.BtnOficina.Image = ((System.Drawing.Image)(resources.GetObject("BtnOficina.Image")));
            this.BtnOficina.Location = new System.Drawing.Point(459, 23);
            this.BtnOficina.Name = "BtnOficina";
            this.BtnOficina.Size = new System.Drawing.Size(35, 23);
            this.BtnOficina.TabIndex = 2;
            this.BtnOficina.UseVisualStyleBackColor = true;
            this.BtnOficina.Click += new System.EventHandler(this.BtnOficina_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.Black;
            this.LblUsuario.Location = new System.Drawing.Point(21, 82);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(53, 17);
            this.LblUsuario.TabIndex = 143;
            this.LblUsuario.Text = "Usuario";
            // 
            // txtK_Usuario
            // 
            this.txtK_Usuario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK_Usuario.Location = new System.Drawing.Point(120, 79);
            this.txtK_Usuario.MaxLength = 5;
            this.txtK_Usuario.Name = "txtK_Usuario";
            this.txtK_Usuario.ReadOnly = true;
            this.txtK_Usuario.Size = new System.Drawing.Size(50, 24);
            this.txtK_Usuario.TabIndex = 140;
            this.txtK_Usuario.TabStop = false;
            this.txtK_Usuario.Tag = "ENTERO";
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuario.Image")));
            this.BtnUsuario.Location = new System.Drawing.Point(458, 78);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(31, 23);
            this.BtnUsuario.TabIndex = 4;
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // txtD_Usuario
            // 
            this.txtD_Usuario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_Usuario.Location = new System.Drawing.Point(172, 79);
            this.txtD_Usuario.Name = "txtD_Usuario";
            this.txtD_Usuario.ReadOnly = true;
            this.txtD_Usuario.Size = new System.Drawing.Size(283, 24);
            this.txtD_Usuario.TabIndex = 142;
            this.txtD_Usuario.TabStop = false;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(120, 52);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(335, 24);
            this.cbxAlmacen.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 17);
            this.label18.TabIndex = 139;
            this.label18.Text = "Almacén";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(172, 24);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(284, 24);
            this.txtOficina.TabIndex = 138;
            this.txtOficina.TabStop = false;
            this.txtOficina.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 137;
            this.label1.Text = "Oficina";
            // 
            // Pnl
            // 
            this.Pnl.Controls.Add(this.grdDatos);
            this.Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl.Location = new System.Drawing.Point(0, 156);
            this.Pnl.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(1066, 351);
            this.Pnl.TabIndex = 3;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.CausesValidation = false;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Caja_Chica,
            this.K_Almacen,
            this.D_Almacen,
            this.F_Apertura,
            this.K_Usuario_Caja,
            this.D_Oficina,
            this.K_Oficina,
            this.Departamento,
            this.B_Abierto,
            this.B_Liquidada,
            this.F_Cierre,
            this.B_Caja_Chica,
            this.B_Viaticos,
            this.B_Reposicion});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(1066, 351);
            this.grdDatos.TabIndex = 1;
            this.grdDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentDoubleClick);
            // 
            // K_Caja_Chica
            // 
            this.K_Caja_Chica.DataPropertyName = "K_Caja_Chica";
            this.K_Caja_Chica.HeaderText = "No.Caja Chica";
            this.K_Caja_Chica.Name = "K_Caja_Chica";
            this.K_Caja_Chica.ReadOnly = true;
            this.K_Caja_Chica.Width = 118;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.ReadOnly = true;
            this.K_Almacen.Visible = false;
            this.K_Almacen.Width = 90;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "Almacen";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.ReadOnly = true;
            this.D_Almacen.Width = 84;
            // 
            // F_Apertura
            // 
            this.F_Apertura.DataPropertyName = "F_Apertura";
            this.F_Apertura.HeaderText = "F.Apertura";
            this.F_Apertura.Name = "F_Apertura";
            this.F_Apertura.ReadOnly = true;
            this.F_Apertura.Width = 97;
            // 
            // K_Usuario_Caja
            // 
            this.K_Usuario_Caja.DataPropertyName = "K_Usuario_Caja";
            this.K_Usuario_Caja.HeaderText = "K_Usuario_Caja";
            this.K_Usuario_Caja.Name = "K_Usuario_Caja";
            this.K_Usuario_Caja.ReadOnly = true;
            this.K_Usuario_Caja.Visible = false;
            this.K_Usuario_Caja.Width = 220;
            // 
            // D_Oficina
            // 
            this.D_Oficina.DataPropertyName = "D_Oficina";
            this.D_Oficina.HeaderText = "Oficina";
            this.D_Oficina.Name = "D_Oficina";
            this.D_Oficina.ReadOnly = true;
            this.D_Oficina.ToolTipText = "Oficina que recibe";
            this.D_Oficina.Width = 73;
            // 
            // K_Oficina
            // 
            this.K_Oficina.DataPropertyName = "K_Oficina";
            this.K_Oficina.HeaderText = "K_Oficina";
            this.K_Oficina.Name = "K_Oficina";
            this.K_Oficina.ReadOnly = true;
            this.K_Oficina.Visible = false;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "D_Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 122;
            // 
            // B_Abierto
            // 
            this.B_Abierto.DataPropertyName = "B_Abierto";
            this.B_Abierto.HeaderText = "Abierto";
            this.B_Abierto.Name = "B_Abierto";
            this.B_Abierto.ReadOnly = true;
            this.B_Abierto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Abierto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Abierto.Width = 76;
            // 
            // B_Liquidada
            // 
            this.B_Liquidada.DataPropertyName = "B_Liquidada";
            this.B_Liquidada.HeaderText = "Liquidada";
            this.B_Liquidada.Name = "B_Liquidada";
            this.B_Liquidada.ReadOnly = true;
            this.B_Liquidada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Liquidada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.B_Liquidada.Width = 90;
            // 
            // F_Cierre
            // 
            this.F_Cierre.DataPropertyName = "F_Cierre";
            this.F_Cierre.HeaderText = "F.Cierre";
            this.F_Cierre.Name = "F_Cierre";
            this.F_Cierre.ReadOnly = true;
            this.F_Cierre.Width = 79;
            // 
            // B_Caja_Chica
            // 
            this.B_Caja_Chica.DataPropertyName = "B_Caja_Chica";
            this.B_Caja_Chica.HeaderText = "Caja Chica";
            this.B_Caja_Chica.Name = "B_Caja_Chica";
            this.B_Caja_Chica.ReadOnly = true;
            this.B_Caja_Chica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Caja_Chica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Caja_Chica.Width = 97;
            // 
            // B_Viaticos
            // 
            this.B_Viaticos.DataPropertyName = "B_Viaticos";
            this.B_Viaticos.HeaderText = "Víaticos";
            this.B_Viaticos.Name = "B_Viaticos";
            this.B_Viaticos.ReadOnly = true;
            this.B_Viaticos.Width = 59;
            // 
            // B_Reposicion
            // 
            this.B_Reposicion.DataPropertyName = "B_Reposicion";
            this.B_Reposicion.HeaderText = "Reposición";
            this.B_Reposicion.Name = "B_Reposicion";
            this.B_Reposicion.ReadOnly = true;
            this.B_Reposicion.Width = 79;
            // 
            // Frm_ConsultaCajaChica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 546);
            this.Controls.Add(this.Pnl);
            this.Controls.Add(this.PnlConsulta);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_ConsultaCajaChica";
            this.Text = "Busca Caja Chica ";
            this.Controls.SetChildIndex(this.PnlConsulta, 0);
            this.Controls.SetChildIndex(this.Pnl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.PnlConsulta.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.Pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlConsulta;
        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.Button BtnOficina;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox txtK_Usuario;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.TextBox txtD_Usuario;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CbxReposicion;
        private System.Windows.Forms.RadioButton CbxViaticos;
        private System.Windows.Forms.RadioButton CbxCajaChica;
        private System.Windows.Forms.CheckBox CbxLiquidada;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Caja_Chica;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario_Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Abierto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Liquidada;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Cierre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Caja_Chica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Viaticos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Reposicion;
    }
}