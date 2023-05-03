namespace ProbeMedic.SERVICIOS
{
    partial class FRM_PAGO_SERV_ENF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PAGO_SERV_ENF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCambio = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarBanco = new System.Windows.Forms.Button();
            this.txtNumOperacion = new System.Windows.Forms.TextBox();
            this.txtAprobacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxForma = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMontoServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dds = new System.Windows.Forms.Label();
            this.txtNumServicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCambio.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCambio);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.pnlTotal);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.pnlTarjeta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 407);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // pnlCambio
            // 
            this.pnlCambio.Controls.Add(this.label11);
            this.pnlCambio.Controls.Add(this.label12);
            this.pnlCambio.Controls.Add(this.txtCambio);
            this.pnlCambio.Location = new System.Drawing.Point(474, 265);
            this.pnlCambio.Name = "pnlCambio";
            this.pnlCambio.Size = new System.Drawing.Size(221, 58);
            this.pnlCambio.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cambio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "$";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(28, 26);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(180, 24);
            this.txtCambio.TabIndex = 13;
            this.txtCambio.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(330, 364);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 28);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(521, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.label10);
            this.pnlTotal.Controls.Add(this.label9);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Location = new System.Drawing.Point(233, 265);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(221, 58);
            this.pnlTotal.TabIndex = 10;
            this.pnlTotal.TabStop = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Pagado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "$";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(28, 26);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 24);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(421, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.Controls.Add(this.groupBox2);
            this.pnlTarjeta.Enabled = false;
            this.pnlTarjeta.Location = new System.Drawing.Point(2, 117);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(951, 125);
            this.pnlTarjeta.TabIndex = 3;
            this.pnlTarjeta.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarBanco);
            this.groupBox2.Controls.Add(this.txtNumOperacion);
            this.groupBox2.Controls.Add(this.txtAprobacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBanco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tarjeta";
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarBanco.Image")));
            this.btnBuscarBanco.Location = new System.Drawing.Point(841, 19);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(26, 24);
            this.btnBuscarBanco.TabIndex = 6;
            this.btnBuscarBanco.UseVisualStyleBackColor = true;
            this.btnBuscarBanco.Click += new System.EventHandler(this.btnBuscarBanco_Click);
            // 
            // txtNumOperacion
            // 
            this.txtNumOperacion.Location = new System.Drawing.Point(599, 54);
            this.txtNumOperacion.Name = "txtNumOperacion";
            this.txtNumOperacion.Size = new System.Drawing.Size(237, 24);
            this.txtNumOperacion.TabIndex = 8;
            this.txtNumOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOperacion_KeyPress);
            // 
            // txtAprobacion
            // 
            this.txtAprobacion.Location = new System.Drawing.Point(152, 54);
            this.txtAprobacion.Name = "txtAprobacion";
            this.txtAprobacion.Size = new System.Drawing.Size(237, 24);
            this.txtAprobacion.TabIndex = 7;
         
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Num. Operación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Aprobación";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(599, 19);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(237, 24);
            this.txtBanco.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Num. Tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Banco";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Location = new System.Drawing.Point(152, 20);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(237, 24);
            this.txtNumTarjeta.TabIndex = 5;
            this.txtNumTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTarjeta_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbxForma);
            this.panel3.Location = new System.Drawing.Point(2, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 40);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Forma de Pago";
            // 
            // cbxForma
            // 
            this.cbxForma.FormattingEnabled = true;
            this.cbxForma.Items.AddRange(new object[] {
            "[Seleccionar]",
            "EFECTIVO",
            "TARJETA DE CREDITO",
            "TARJETA DE DEBITO"});
            this.cbxForma.Location = new System.Drawing.Point(160, 8);
            this.cbxForma.Name = "cbxForma";
            this.cbxForma.Size = new System.Drawing.Size(218, 24);
            this.cbxForma.TabIndex = 2;
            this.cbxForma.Text = "[Seleccionar]";
            this.cbxForma.SelectedIndexChanged += new System.EventHandler(this.cbxForma_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMontoServicio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dds);
            this.panel2.Controls.Add(this.txtNumServicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 74);
            this.panel2.TabIndex = 7;
            // 
            // txtMontoServicio
            // 
            this.txtMontoServicio.Enabled = false;
            this.txtMontoServicio.Location = new System.Drawing.Point(760, 39);
            this.txtMontoServicio.Name = "txtMontoServicio";
            this.txtMontoServicio.ReadOnly = true;
            this.txtMontoServicio.Size = new System.Drawing.Size(133, 24);
            this.txtMontoServicio.TabIndex = 8;
            this.txtMontoServicio.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto del Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num. Servicio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(760, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 24);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(162, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(371, 24);
            this.txtCliente.TabIndex = 6;
            this.txtCliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // dds
            // 
            this.dds.AutoSize = true;
            this.dds.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dds.Location = new System.Drawing.Point(30, 45);
            this.dds.Name = "dds";
            this.dds.Size = new System.Drawing.Size(61, 18);
            this.dds.TabIndex = 5;
            this.dds.Text = "Cliente";
            // 
            // txtNumServicio
            // 
            this.txtNumServicio.Enabled = false;
            this.txtNumServicio.Location = new System.Drawing.Point(162, 8);
            this.txtNumServicio.Name = "txtNumServicio";
            this.txtNumServicio.ReadOnly = true;
            this.txtNumServicio.Size = new System.Drawing.Size(237, 24);
            this.txtNumServicio.TabIndex = 4;
            this.txtNumServicio.TabStop = false;
            // 
            // FRM_PAGO_SERV_ENF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 484);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_PAGO_SERV_ENF";
            this.Text = "Pago de Servicios de Enfermeria";
            this.Load += new System.EventHandler(this.FRM_PAGO_SERV_ENF_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlCambio.ResumeLayout(false);
            this.pnlCambio.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlTarjeta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumOperacion;
        private System.Windows.Forms.TextBox txtAprobacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMontoServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dds;
        private System.Windows.Forms.TextBox txtNumServicio;
        private System.Windows.Forms.ComboBox cbxForma;
        private System.Windows.Forms.Panel pnlCambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Button btnBuscarBanco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAceptar;
    }
}