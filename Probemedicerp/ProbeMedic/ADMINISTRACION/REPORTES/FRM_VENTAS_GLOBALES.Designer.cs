namespace ProbeMedic.ADMINISTRACION.REPORTES
{
    partial class FRM_VENTAS_GLOBALES
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
            this.chk_Farmacia = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Reporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.LblClientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rdb_SeleccionarClientes = new System.Windows.Forms.RadioButton();
            this.rdb_TodosClientes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Coaseguro = new System.Windows.Forms.CheckBox();
            this.chk_Aseguradora = new System.Windows.Forms.CheckBox();
            this.chk_VP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Farmacia
            // 
            this.chk_Farmacia.AutoSize = true;
            this.chk_Farmacia.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chk_Farmacia.Location = new System.Drawing.Point(70, 51);
            this.chk_Farmacia.Name = "chk_Farmacia";
            this.chk_Farmacia.Size = new System.Drawing.Size(87, 21);
            this.chk_Farmacia.TabIndex = 2;
            this.chk_Farmacia.Text = "Farmacias";
            this.chk_Farmacia.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Reporte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.LblClientes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gbCliente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 402);
            this.panel1.TabIndex = 7;
            // 
            // cmb_Reporte
            // 
            this.cmb_Reporte.FormattingEnabled = true;
            this.cmb_Reporte.Items.AddRange(new object[] {
            " ",
            "Reporte de Facturación",
            "Remisiones por Facturar",
            "Reporte Global de Pedidos",
            "Margen de Utilidad",
            "Promedio Ponderado",
            "Reporte Costeo"});
            this.cmb_Reporte.Location = new System.Drawing.Point(74, 21);
            this.cmb_Reporte.Name = "cmb_Reporte";
            this.cmb_Reporte.Size = new System.Drawing.Size(347, 24);
            this.cmb_Reporte.TabIndex = 0;
            this.cmb_Reporte.SelectedIndexChanged += new System.EventHandler(this.cmb_Reporte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 162;
            this.label1.Text = "Reporte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpFinal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpInicial);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(16, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANGO DE FECHAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Inicial";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Location = new System.Drawing.Point(100, 53);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(263, 23);
            this.dtpFinal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Final";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Location = new System.Drawing.Point(100, 24);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(263, 23);
            this.dtpInicial.TabIndex = 8;
            // 
            // LblClientes
            // 
            this.LblClientes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.Location = new System.Drawing.Point(5, 340);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(416, 45);
            this.LblClientes.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 10);
            this.label4.TabIndex = 159;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.rdb_SeleccionarClientes);
            this.gbCliente.Controls.Add(this.rdb_TodosClientes);
            this.gbCliente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbCliente.Location = new System.Drawing.Point(13, 272);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(406, 55);
            this.gbCliente.TabIndex = 158;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "CLIENTE";
            // 
            // rdb_SeleccionarClientes
            // 
            this.rdb_SeleccionarClientes.AutoSize = true;
            this.rdb_SeleccionarClientes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rdb_SeleccionarClientes.Location = new System.Drawing.Point(209, 22);
            this.rdb_SeleccionarClientes.Name = "rdb_SeleccionarClientes";
            this.rdb_SeleccionarClientes.Size = new System.Drawing.Size(144, 21);
            this.rdb_SeleccionarClientes.TabIndex = 6;
            this.rdb_SeleccionarClientes.TabStop = true;
            this.rdb_SeleccionarClientes.Text = "Seleccionar Clientes";
            this.rdb_SeleccionarClientes.UseVisualStyleBackColor = true;
            this.rdb_SeleccionarClientes.Click += new System.EventHandler(this.rdbSeleccionarClientes_Click);
            // 
            // rdb_TodosClientes
            // 
            this.rdb_TodosClientes.AutoSize = true;
            this.rdb_TodosClientes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rdb_TodosClientes.Location = new System.Drawing.Point(70, 23);
            this.rdb_TodosClientes.Name = "rdb_TodosClientes";
            this.rdb_TodosClientes.Size = new System.Drawing.Size(114, 21);
            this.rdb_TodosClientes.TabIndex = 5;
            this.rdb_TodosClientes.TabStop = true;
            this.rdb_TodosClientes.Text = "Todos Clientes";
            this.rdb_TodosClientes.UseVisualStyleBackColor = true;
            this.rdb_TodosClientes.Click += new System.EventHandler(this.rdbTodosClientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Coaseguro);
            this.groupBox1.Controls.Add(this.chk_Aseguradora);
            this.groupBox1.Controls.Add(this.chk_Farmacia);
            this.groupBox1.Controls.Add(this.chk_VP);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE VENTA";
            // 
            // chk_Coaseguro
            // 
            this.chk_Coaseguro.AutoSize = true;
            this.chk_Coaseguro.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chk_Coaseguro.Location = new System.Drawing.Point(225, 51);
            this.chk_Coaseguro.Name = "chk_Coaseguro";
            this.chk_Coaseguro.Size = new System.Drawing.Size(93, 21);
            this.chk_Coaseguro.TabIndex = 5;
            this.chk_Coaseguro.Text = "Coaseguro";
            this.chk_Coaseguro.UseVisualStyleBackColor = true;
            // 
            // chk_Aseguradora
            // 
            this.chk_Aseguradora.AutoSize = true;
            this.chk_Aseguradora.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chk_Aseguradora.Location = new System.Drawing.Point(70, 24);
            this.chk_Aseguradora.Name = "chk_Aseguradora";
            this.chk_Aseguradora.Size = new System.Drawing.Size(110, 21);
            this.chk_Aseguradora.TabIndex = 3;
            this.chk_Aseguradora.Text = "Aseguradoras";
            this.chk_Aseguradora.UseVisualStyleBackColor = true;
            // 
            // chk_VP
            // 
            this.chk_VP.AutoSize = true;
            this.chk_VP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chk_VP.Location = new System.Drawing.Point(225, 24);
            this.chk_VP.Name = "chk_VP";
            this.chk_VP.Size = new System.Drawing.Size(123, 21);
            this.chk_VP.TabIndex = 4;
            this.chk_VP.Text = "Ventas Privadas";
            this.chk_VP.UseVisualStyleBackColor = true;
            // 
            // FRM_VENTAS_GLOBALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 479);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(452, 518);
            this.MinimumSize = new System.Drawing.Size(452, 518);
            this.Name = "FRM_VENTAS_GLOBALES";
            this.Text = "ESTADISTICA DE VENTAS";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Farmacia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_Aseguradora;
        private System.Windows.Forms.CheckBox chk_VP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.RadioButton rdb_SeleccionarClientes;
        private System.Windows.Forms.RadioButton rdb_TodosClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.ComboBox cmb_Reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_Coaseguro;
    }
}