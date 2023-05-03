namespace ProbeMedic.SEGURIDAD
{
    partial class FRMSPID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSPID));
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblSPID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BarraEstatus = new System.Windows.Forms.StatusStrip();
            this.lblEspaciosEnBlanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlUsuario.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            this.BarraEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.pnlUsuario.Controls.Add(this.lblSPID);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUsuario.Location = new System.Drawing.Point(0, 38);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(164, 50);
            this.pnlUsuario.TabIndex = 12;
            // 
            // lblSPID
            // 
            this.lblSPID.AutoSize = true;
            this.lblSPID.BackColor = System.Drawing.Color.Silver;
            this.lblSPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSPID.Location = new System.Drawing.Point(74, 9);
            this.lblSPID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSPID.Name = "lblSPID";
            this.lblSPID.Size = new System.Drawing.Size(0, 25);
            this.lblSPID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPID:";
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnBuscar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(164, 38);
            this.BarraHerramientas.TabIndex = 11;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 35);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.ToolTipText = "Salir de Esta Opción";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 35);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.ToolTipText = "Buscar Información";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // BarraEstatus
            // 
            this.BarraEstatus.AutoSize = false;
            this.BarraEstatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraEstatus.BackgroundImage")));
            this.BarraEstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarraEstatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraEstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEspaciosEnBlanco});
            this.BarraEstatus.Location = new System.Drawing.Point(0, 96);
            this.BarraEstatus.Name = "BarraEstatus";
            this.BarraEstatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.BarraEstatus.Size = new System.Drawing.Size(164, 48);
            this.BarraEstatus.TabIndex = 10;
            this.BarraEstatus.Text = "statusStrip1";
            // 
            // lblEspaciosEnBlanco
            // 
            this.lblEspaciosEnBlanco.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEspaciosEnBlanco.ForeColor = System.Drawing.Color.White;
            this.lblEspaciosEnBlanco.Name = "lblEspaciosEnBlanco";
            this.lblEspaciosEnBlanco.Size = new System.Drawing.Size(45, 43);
            this.lblEspaciosEnBlanco.Text = "       ";
            // 
            // FRMSPID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 144);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.BarraEstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMSPID";
            this.Text = "SPID";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRMSPID_KeyPress);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.BarraEstatus.ResumeLayout(false);
            this.BarraEstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblSPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.StatusStrip BarraEstatus;
        private System.Windows.Forms.ToolStripStatusLabel lblEspaciosEnBlanco;
    }
}