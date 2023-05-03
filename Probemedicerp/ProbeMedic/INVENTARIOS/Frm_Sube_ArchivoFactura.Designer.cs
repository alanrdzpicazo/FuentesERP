namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Sube_ArchivoFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sube_ArchivoFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEstatus = new System.Windows.Forms.Panel();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CbxAutorizado = new System.Windows.Forms.CheckBox();
            this.BtnAutorizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnSubirPDF = new System.Windows.Forms.Button();
            this.cbxPDF = new System.Windows.Forms.CheckBox();
            this.txtD_Proveedor = new System.Windows.Forms.TextBox();
            this.btnSubirXML = new System.Windows.Forms.Button();
            this.cbxXML = new System.Windows.Forms.CheckBox();
            this.txtK_Proveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlEstatus);
            this.panel1.Controls.Add(this.CbxAutorizado);
            this.panel1.Controls.Add(this.BtnAutorizar);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.btnSubirPDF);
            this.panel1.Controls.Add(this.cbxPDF);
            this.panel1.Controls.Add(this.txtD_Proveedor);
            this.panel1.Controls.Add(this.btnSubirXML);
            this.panel1.Controls.Add(this.cbxXML);
            this.panel1.Controls.Add(this.txtK_Proveedor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFactura);
            this.panel1.Controls.Add(this.txtOC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 249);
            this.panel1.TabIndex = 0;
            // 
            // pnlEstatus
            // 
            this.pnlEstatus.Controls.Add(this.lblProgreso);
            this.pnlEstatus.Controls.Add(this.progressBar1);
            this.pnlEstatus.Enabled = false;
            this.pnlEstatus.Location = new System.Drawing.Point(222, 182);
            this.pnlEstatus.Name = "pnlEstatus";
            this.pnlEstatus.Size = new System.Drawing.Size(416, 58);
            this.pnlEstatus.TabIndex = 24;
            this.pnlEstatus.Visible = false;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(120, 33);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(201, 17);
            this.lblProgreso.TabIndex = 24;
            this.lblProgreso.Text = "Procesando, espere por favor...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 22);
            this.progressBar1.TabIndex = 23;
            // 
            // CbxAutorizado
            // 
            this.CbxAutorizado.AutoSize = true;
            this.CbxAutorizado.Enabled = false;
            this.CbxAutorizado.Location = new System.Drawing.Point(498, 89);
            this.CbxAutorizado.Margin = new System.Windows.Forms.Padding(4);
            this.CbxAutorizado.Name = "CbxAutorizado";
            this.CbxAutorizado.Size = new System.Drawing.Size(92, 21);
            this.CbxAutorizado.TabIndex = 15;
            this.CbxAutorizado.Text = "Autorizado";
            this.CbxAutorizado.UseVisualStyleBackColor = true;
            // 
            // BtnAutorizar
            // 
            this.BtnAutorizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAutorizar.Image")));
            this.BtnAutorizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAutorizar.Location = new System.Drawing.Point(438, 133);
            this.BtnAutorizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAutorizar.Name = "BtnAutorizar";
            this.BtnAutorizar.Size = new System.Drawing.Size(122, 42);
            this.BtnAutorizar.TabIndex = 14;
            this.BtnAutorizar.Text = "Sin Factura";
            this.BtnAutorizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAutorizar.UseVisualStyleBackColor = true;
            this.BtnAutorizar.Click += new System.EventHandler(this.BtnAutorizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(568, 133);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(122, 42);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnSubirPDF
            // 
            this.btnSubirPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirPDF.Image")));
            this.btnSubirPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirPDF.Location = new System.Drawing.Point(298, 133);
            this.btnSubirPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirPDF.Name = "btnSubirPDF";
            this.btnSubirPDF.Size = new System.Drawing.Size(122, 42);
            this.btnSubirPDF.TabIndex = 8;
            this.btnSubirPDF.Text = "Subir PDF";
            this.btnSubirPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirPDF.UseVisualStyleBackColor = true;
            this.btnSubirPDF.Click += new System.EventHandler(this.btnSubirPDF_Click);
            // 
            // cbxPDF
            // 
            this.cbxPDF.AutoSize = true;
            this.cbxPDF.Enabled = false;
            this.cbxPDF.Location = new System.Drawing.Point(428, 89);
            this.cbxPDF.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPDF.Name = "cbxPDF";
            this.cbxPDF.Size = new System.Drawing.Size(52, 21);
            this.cbxPDF.TabIndex = 10;
            this.cbxPDF.Text = "PDF";
            this.cbxPDF.UseVisualStyleBackColor = true;
            // 
            // txtD_Proveedor
            // 
            this.txtD_Proveedor.Enabled = false;
            this.txtD_Proveedor.Location = new System.Drawing.Point(226, 53);
            this.txtD_Proveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtD_Proveedor.Name = "txtD_Proveedor";
            this.txtD_Proveedor.Size = new System.Drawing.Size(511, 24);
            this.txtD_Proveedor.TabIndex = 13;
            // 
            // btnSubirXML
            // 
            this.btnSubirXML.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirXML.Image")));
            this.btnSubirXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirXML.Location = new System.Drawing.Point(168, 133);
            this.btnSubirXML.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirXML.Name = "btnSubirXML";
            this.btnSubirXML.Size = new System.Drawing.Size(122, 42);
            this.btnSubirXML.TabIndex = 7;
            this.btnSubirXML.Text = "Subir XML";
            this.btnSubirXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirXML.UseVisualStyleBackColor = true;
            this.btnSubirXML.Click += new System.EventHandler(this.btnSubirXML_Click);
            // 
            // cbxXML
            // 
            this.cbxXML.AutoSize = true;
            this.cbxXML.Enabled = false;
            this.cbxXML.Location = new System.Drawing.Point(357, 89);
            this.cbxXML.Margin = new System.Windows.Forms.Padding(4);
            this.cbxXML.Name = "cbxXML";
            this.cbxXML.Size = new System.Drawing.Size(52, 21);
            this.cbxXML.TabIndex = 9;
            this.cbxXML.Text = "XML";
            this.cbxXML.UseVisualStyleBackColor = true;
            // 
            // txtK_Proveedor
            // 
            this.txtK_Proveedor.Enabled = false;
            this.txtK_Proveedor.Location = new System.Drawing.Point(169, 53);
            this.txtK_Proveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtK_Proveedor.Name = "txtK_Proveedor";
            this.txtK_Proveedor.Size = new System.Drawing.Size(55, 24);
            this.txtK_Proveedor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Proveedor";
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(168, 87);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(169, 24);
            this.txtFactura.TabIndex = 10;
            // 
            // txtOC
            // 
            this.txtOC.Enabled = false;
            this.txtOC.Location = new System.Drawing.Point(168, 17);
            this.txtOC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(169, 24);
            this.txtOC.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Orden de Compra";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Frm_Sube_ArchivoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 326);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Sube_ArchivoFactura";
            this.Text = "SUBE ARCHIVOS FACTURA";
            this.Load += new System.EventHandler(this.Frm_Sube_ArchivoFactura_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEstatus.ResumeLayout(false);
            this.pnlEstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtD_Proveedor;
        private System.Windows.Forms.TextBox txtK_Proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubirXML;
        private System.Windows.Forms.CheckBox cbxPDF;
        private System.Windows.Forms.CheckBox cbxXML;
        private System.Windows.Forms.Button btnSubirPDF;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnAutorizar;
        private System.Windows.Forms.CheckBox CbxAutorizado;
        private System.Windows.Forms.Panel pnlEstatus;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}