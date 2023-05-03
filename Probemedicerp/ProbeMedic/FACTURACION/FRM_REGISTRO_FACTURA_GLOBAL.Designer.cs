namespace ProbeMedic.FACTURACION
{
    partial class FRM_REGISTRO_FACTURA_GLOBAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_REGISTRO_FACTURA_GLOBAL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClaveAlmacen = new System.Windows.Forms.TextBox();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.btnBuscarDomiclioFiscal = new System.Windows.Forms.Button();
            this.txtDomicilioFiscal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveOficina = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarSerie = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtClaveAlmacen);
            this.panel1.Controls.Add(this.txtAlmacen);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.btnBuscaCliente);
            this.panel1.Controls.Add(this.btnBuscarDomiclioFiscal);
            this.panel1.Controls.Add(this.txtDomicilioFiscal);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClaveOficina);
            this.panel1.Controls.Add(this.txtOficina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscarSerie);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 247);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // txtClaveAlmacen
            // 
            this.txtClaveAlmacen.Location = new System.Drawing.Point(123, 66);
            this.txtClaveAlmacen.Name = "txtClaveAlmacen";
            this.txtClaveAlmacen.Size = new System.Drawing.Size(54, 24);
            this.txtClaveAlmacen.TabIndex = 168;
            this.txtClaveAlmacen.TabStop = false;
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Location = new System.Drawing.Point(180, 66);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(365, 24);
            this.txtAlmacen.TabIndex = 167;
            this.txtAlmacen.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(123, 194);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(372, 24);
            this.txtCorreo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 166;
            this.label6.Text = "Correo";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(123, 99);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(334, 25);
            this.txtCliente.TabIndex = 164;
            this.txtCliente.TabStop = false;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(461, 100);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(32, 25);
            this.btnBuscaCliente.TabIndex = 1;
            this.btnBuscaCliente.Tag = "";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // btnBuscarDomiclioFiscal
            // 
            this.btnBuscarDomiclioFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDomiclioFiscal.Image")));
            this.btnBuscarDomiclioFiscal.Location = new System.Drawing.Point(600, 132);
            this.btnBuscarDomiclioFiscal.Name = "btnBuscarDomiclioFiscal";
            this.btnBuscarDomiclioFiscal.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarDomiclioFiscal.TabIndex = 2;
            this.btnBuscarDomiclioFiscal.Tag = "";
            this.btnBuscarDomiclioFiscal.UseVisualStyleBackColor = true;
            this.btnBuscarDomiclioFiscal.Click += new System.EventHandler(this.btnBuscarDomiclioFiscal_Click);
            // 
            // txtDomicilioFiscal
            // 
            this.txtDomicilioFiscal.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilioFiscal.Location = new System.Drawing.Point(123, 131);
            this.txtDomicilioFiscal.Name = "txtDomicilioFiscal";
            this.txtDomicilioFiscal.ReadOnly = true;
            this.txtDomicilioFiscal.Size = new System.Drawing.Size(471, 24);
            this.txtDomicilioFiscal.TabIndex = 163;
            this.txtDomicilioFiscal.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 161;
            this.label13.Text = "Domicilio Fiscal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 160;
            this.label12.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Oficina";
            // 
            // txtClaveOficina
            // 
            this.txtClaveOficina.BackColor = System.Drawing.SystemColors.Window;
            this.txtClaveOficina.Location = new System.Drawing.Point(123, 36);
            this.txtClaveOficina.Name = "txtClaveOficina";
            this.txtClaveOficina.ReadOnly = true;
            this.txtClaveOficina.Size = new System.Drawing.Size(54, 24);
            this.txtClaveOficina.TabIndex = 90;
            this.txtClaveOficina.TabStop = false;
            // 
            // txtOficina
            // 
            this.txtOficina.BackColor = System.Drawing.SystemColors.Window;
            this.txtOficina.Location = new System.Drawing.Point(180, 36);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.ReadOnly = true;
            this.txtOficina.Size = new System.Drawing.Size(365, 24);
            this.txtOficina.TabIndex = 91;
            this.txtOficina.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "Almacén";
            // 
            // btnBuscarSerie
            // 
            this.btnBuscarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerie.Image")));
            this.btnBuscarSerie.Location = new System.Drawing.Point(600, 162);
            this.btnBuscarSerie.Name = "btnBuscarSerie";
            this.btnBuscarSerie.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarSerie.TabIndex = 3;
            this.btnBuscarSerie.Tag = "";
            this.btnBuscarSerie.UseVisualStyleBackColor = true;
            this.btnBuscarSerie.Click += new System.EventHandler(this.btnBuscarSerie_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.White;
            this.txtSerie.Location = new System.Drawing.Point(123, 162);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(474, 24);
            this.txtSerie.TabIndex = 87;
            this.txtSerie.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 169);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 17);
            this.label30.TabIndex = 86;
            this.label30.Text = "Serie";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(663, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Registro de Factura Global";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_REGISTRO_FACTURA_GLOBAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 324);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(679, 363);
            this.MinimumSize = new System.Drawing.Size(679, 363);
            this.Name = "FRM_REGISTRO_FACTURA_GLOBAL";
            this.Text = "FACTURACIÓN GLOBAL";
            this.Load += new System.EventHandler(this.FRM_REGISTRO_FACTURA_GLOBAL_Load);
            this.Shown += new System.EventHandler(this.FRM_REGISTRO_FACTURA_GLOBAL_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Button btnBuscarDomiclioFiscal;
        private System.Windows.Forms.TextBox txtDomicilioFiscal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClaveAlmacen;
        private System.Windows.Forms.TextBox txtAlmacen;
    }
}