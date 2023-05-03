namespace ProbeMedic.INVENTARIOS
{
    partial class FRM_TRANSFERENCIAS_ALMACEN
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TRANSFERENCIAS_ALMACEN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Solicitud_Transferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina_Solicita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina_Solicita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen_Solicita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen_Solicita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Oficina_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Oficina_Tranfiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen_Transfiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Solicito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Motivo_Transferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Aplicada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D_Usuario_Aplico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Aplica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Rechazada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D_Usuario_Rechazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Rechazada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficinaSolicita = new System.Windows.Forms.TextBox();
            this.cBoxFiltroFecha = new System.Windows.Forms.CheckBox();
            this.PnlFiltroFecha = new System.Windows.Forms.Panel();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.LblAnio = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.PnlFiltroFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 469);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdDatos);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 307);
            this.panel3.TabIndex = 27;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToOrderColumns = true;
            this.grdDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Solicitud_Transferencia,
            this.K_Oficina_Solicita,
            this.D_Oficina_Solicita,
            this.K_Almacen_Solicita,
            this.D_Almacen_Solicita,
            this.K_Oficina_Origen,
            this.D_Oficina_Tranfiere,
            this.K_Almacen_Origen,
            this.D_Almacen_Transfiere,
            this.Usuario_Solicito,
            this.D_Motivo_Transferencia,
            this.F_Solicitud,
            this.B_Aplicada,
            this.D_Usuario_Aplico,
            this.F_Aplica,
            this.B_Rechazada,
            this.D_Usuario_Rechazo,
            this.F_Rechazada,
            this.Observaciones});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 17);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.ShowEditingIcon = false;
            this.grdDatos.Size = new System.Drawing.Size(1031, 290);
            this.grdDatos.TabIndex = 35;
            this.grdDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistro);
            // 
            // K_Solicitud_Transferencia
            // 
            this.K_Solicitud_Transferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.K_Solicitud_Transferencia.DataPropertyName = "K_Solicitud_Transferencia";
            this.K_Solicitud_Transferencia.HeaderText = "No. Solicitud";
            this.K_Solicitud_Transferencia.MinimumWidth = 85;
            this.K_Solicitud_Transferencia.Name = "K_Solicitud_Transferencia";
            this.K_Solicitud_Transferencia.ReadOnly = true;
            this.K_Solicitud_Transferencia.Width = 108;
            // 
            // K_Oficina_Solicita
            // 
            this.K_Oficina_Solicita.DataPropertyName = "K_Oficina_Solicita";
            this.K_Oficina_Solicita.HeaderText = "K_Oficina_Solicita";
            this.K_Oficina_Solicita.Name = "K_Oficina_Solicita";
            this.K_Oficina_Solicita.ReadOnly = true;
            this.K_Oficina_Solicita.Visible = false;
            this.K_Oficina_Solicita.Width = 138;
            // 
            // D_Oficina_Solicita
            // 
            this.D_Oficina_Solicita.DataPropertyName = "D_Oficina_Solicita";
            this.D_Oficina_Solicita.HeaderText = "Of. Solicita";
            this.D_Oficina_Solicita.Name = "D_Oficina_Solicita";
            this.D_Oficina_Solicita.ReadOnly = true;
            this.D_Oficina_Solicita.Width = 96;
            // 
            // K_Almacen_Solicita
            // 
            this.K_Almacen_Solicita.DataPropertyName = "K_Almacen_Solicita";
            this.K_Almacen_Solicita.HeaderText = "K_Almacen_Solicita";
            this.K_Almacen_Solicita.Name = "K_Almacen_Solicita";
            this.K_Almacen_Solicita.ReadOnly = true;
            this.K_Almacen_Solicita.Visible = false;
            this.K_Almacen_Solicita.Width = 149;
            // 
            // D_Almacen_Solicita
            // 
            this.D_Almacen_Solicita.DataPropertyName = "D_Almacen_Solicita";
            this.D_Almacen_Solicita.HeaderText = "Almacén Solicita";
            this.D_Almacen_Solicita.Name = "D_Almacen_Solicita";
            this.D_Almacen_Solicita.ReadOnly = true;
            this.D_Almacen_Solicita.Width = 129;
            // 
            // K_Oficina_Origen
            // 
            this.K_Oficina_Origen.DataPropertyName = "K_Oficina_Origen";
            this.K_Oficina_Origen.HeaderText = "K_Oficina_Origen";
            this.K_Oficina_Origen.Name = "K_Oficina_Origen";
            this.K_Oficina_Origen.ReadOnly = true;
            this.K_Oficina_Origen.Visible = false;
            this.K_Oficina_Origen.Width = 137;
            // 
            // D_Oficina_Tranfiere
            // 
            this.D_Oficina_Tranfiere.DataPropertyName = "D_Oficina_Tranfiere";
            this.D_Oficina_Tranfiere.HeaderText = "Of. Origen";
            this.D_Oficina_Tranfiere.Name = "D_Oficina_Tranfiere";
            this.D_Oficina_Tranfiere.ReadOnly = true;
            this.D_Oficina_Tranfiere.Width = 95;
            // 
            // K_Almacen_Origen
            // 
            this.K_Almacen_Origen.DataPropertyName = "K_Almacen_Origen";
            this.K_Almacen_Origen.HeaderText = "K_Almacen_Origen";
            this.K_Almacen_Origen.Name = "K_Almacen_Origen";
            this.K_Almacen_Origen.ReadOnly = true;
            this.K_Almacen_Origen.Visible = false;
            this.K_Almacen_Origen.Width = 148;
            // 
            // D_Almacen_Transfiere
            // 
            this.D_Almacen_Transfiere.DataPropertyName = "D_Almacen_Transfiere";
            this.D_Almacen_Transfiere.HeaderText = "Almacén Origen";
            this.D_Almacen_Transfiere.Name = "D_Almacen_Transfiere";
            this.D_Almacen_Transfiere.ReadOnly = true;
            this.D_Almacen_Transfiere.Width = 128;
            // 
            // Usuario_Solicito
            // 
            this.Usuario_Solicito.DataPropertyName = "Usuario_Solicito";
            this.Usuario_Solicito.HeaderText = "Usuario Solicita";
            this.Usuario_Solicito.Name = "Usuario_Solicito";
            this.Usuario_Solicito.ReadOnly = true;
            this.Usuario_Solicito.Width = 123;
            // 
            // D_Motivo_Transferencia
            // 
            this.D_Motivo_Transferencia.DataPropertyName = "D_Motivo_Transferencia";
            this.D_Motivo_Transferencia.HeaderText = "Motivo";
            this.D_Motivo_Transferencia.Name = "D_Motivo_Transferencia";
            this.D_Motivo_Transferencia.ReadOnly = true;
            this.D_Motivo_Transferencia.Width = 74;
            // 
            // F_Solicitud
            // 
            this.F_Solicitud.DataPropertyName = "F_Solicitud";
            this.F_Solicitud.HeaderText = "Fec. Solicitud";
            this.F_Solicitud.Name = "F_Solicitud";
            this.F_Solicitud.ReadOnly = true;
            this.F_Solicitud.Width = 112;
            // 
            // B_Aplicada
            // 
            this.B_Aplicada.DataPropertyName = "B_Aplicada";
            this.B_Aplicada.HeaderText = "Aplicada";
            this.B_Aplicada.Name = "B_Aplicada";
            this.B_Aplicada.ReadOnly = true;
            this.B_Aplicada.Width = 63;
            // 
            // D_Usuario_Aplico
            // 
            this.D_Usuario_Aplico.DataPropertyName = "D_Usuario_Aplico";
            this.D_Usuario_Aplico.HeaderText = "Usuario Aplicó";
            this.D_Usuario_Aplico.Name = "D_Usuario_Aplico";
            this.D_Usuario_Aplico.ReadOnly = true;
            this.D_Usuario_Aplico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.D_Usuario_Aplico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D_Usuario_Aplico.Width = 98;
            // 
            // F_Aplica
            // 
            this.F_Aplica.DataPropertyName = "F_Aplica";
            this.F_Aplica.HeaderText = "Fec. Aplicación";
            this.F_Aplica.Name = "F_Aplica";
            this.F_Aplica.ReadOnly = true;
            this.F_Aplica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.F_Aplica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.F_Aplica.Width = 102;
            // 
            // B_Rechazada
            // 
            this.B_Rechazada.DataPropertyName = "B_Rechazada";
            this.B_Rechazada.HeaderText = "Rechazada";
            this.B_Rechazada.Name = "B_Rechazada";
            this.B_Rechazada.ReadOnly = true;
            this.B_Rechazada.Width = 80;
            // 
            // D_Usuario_Rechazo
            // 
            this.D_Usuario_Rechazo.DataPropertyName = "D_Usuario_Rechazo";
            this.D_Usuario_Rechazo.HeaderText = "Usuario Rechazo";
            this.D_Usuario_Rechazo.Name = "D_Usuario_Rechazo";
            this.D_Usuario_Rechazo.ReadOnly = true;
            this.D_Usuario_Rechazo.Width = 134;
            // 
            // F_Rechazada
            // 
            this.F_Rechazada.DataPropertyName = "F_Rechazada";
            this.F_Rechazada.HeaderText = "Fec. Rechazo";
            this.F_Rechazada.Name = "F_Rechazada";
            this.F_Rechazada.ReadOnly = true;
            this.F_Rechazada.Width = 114;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 122;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1031, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Solicitudes de Artículos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOficinaSolicita);
            this.panel2.Controls.Add(this.cBoxFiltroFecha);
            this.panel2.Controls.Add(this.PnlFiltroFecha);
            this.panel2.Controls.Add(this.cbxAlmacen);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 162);
            this.panel2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Oficina";
            // 
            // txtOficinaSolicita
            // 
            this.txtOficinaSolicita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOficinaSolicita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOficinaSolicita.Location = new System.Drawing.Point(97, 45);
            this.txtOficinaSolicita.Name = "txtOficinaSolicita";
            this.txtOficinaSolicita.ReadOnly = true;
            this.txtOficinaSolicita.Size = new System.Drawing.Size(307, 24);
            this.txtOficinaSolicita.TabIndex = 51;
            this.txtOficinaSolicita.TabStop = false;
            // 
            // cBoxFiltroFecha
            // 
            this.cBoxFiltroFecha.AutoSize = true;
            this.cBoxFiltroFecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFiltroFecha.Location = new System.Drawing.Point(97, 123);
            this.cBoxFiltroFecha.Name = "cBoxFiltroFecha";
            this.cBoxFiltroFecha.Size = new System.Drawing.Size(110, 18);
            this.cBoxFiltroFecha.TabIndex = 50;
            this.cBoxFiltroFecha.Text = "Filtro por Fecha";
            this.cBoxFiltroFecha.UseVisualStyleBackColor = true;
            this.cBoxFiltroFecha.CheckedChanged += new System.EventHandler(this.cBoxFiltroFecha_CheckedChanged);
            // 
            // PnlFiltroFecha
            // 
            this.PnlFiltroFecha.Controls.Add(this.dtpFinal);
            this.PnlFiltroFecha.Controls.Add(this.label1);
            this.PnlFiltroFecha.Controls.Add(this.dtpInicial);
            this.PnlFiltroFecha.Controls.Add(this.LblAnio);
            this.PnlFiltroFecha.Location = new System.Drawing.Point(229, 113);
            this.PnlFiltroFecha.Name = "PnlFiltroFecha";
            this.PnlFiltroFecha.Size = new System.Drawing.Size(398, 34);
            this.PnlFiltroFecha.TabIndex = 49;
            this.PnlFiltroFecha.Visible = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(287, 4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(100, 24);
            this.dtpFinal.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha Final";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(91, 5);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(100, 24);
            this.dtpInicial.TabIndex = 31;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(5, 9);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(80, 17);
            this.LblAnio.TabIndex = 30;
            this.LblAnio.Text = "Fecha Inicial";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(97, 80);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(307, 24);
            this.cbxAlmacen.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1031, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Transferencias de Artículos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BtnCancelar.Image.png");
            this.imageList1.Images.SetKeyName(1, "BtnRealizado.Image.png");
            this.imageList1.Images.SetKeyName(2, "cancel_stop_exit_1583.ico");
            this.imageList1.Images.SetKeyName(3, "New_icon-icons.com_73694.ico");
            this.imageList1.Images.SetKeyName(4, "if_icon-111-search_314689.png");
            this.imageList1.Images.SetKeyName(5, "if_to-do-list_checked3_15154.png");
            // 
            // FRM_TRANSFERENCIAS_ALMACEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 546);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FRM_TRANSFERENCIAS_ALMACEN";
            this.Text = "TRANSFERENCIAS DE ARTÍCULOS";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlFiltroFecha.ResumeLayout(false);
            this.PnlFiltroFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBoxFiltroFecha;
        private System.Windows.Forms.Panel PnlFiltroFecha;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOficinaSolicita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Solicitud_Transferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina_Solicita;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina_Solicita;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen_Solicita;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen_Solicita;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Oficina_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Oficina_Tranfiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen_Transfiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Solicito;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Motivo_Transferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Solicitud;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Aplicada;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Aplico;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Aplica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Rechazada;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Usuario_Rechazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Rechazada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}