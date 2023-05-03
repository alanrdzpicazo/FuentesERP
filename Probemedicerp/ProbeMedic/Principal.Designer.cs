namespace ProbeMedic
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.BarraEstatus = new System.Windows.Forms.StatusStrip();
            this.lblEstatusVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstatusGrupo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstatusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOficina = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstatusSPID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstatusBaseDatos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstatusServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lblempresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.Probemedic = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.White;
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(13, 2, 0, 9);
            this.MenuPrincipal.Size = new System.Drawing.Size(1370, 11);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // BarraEstatus
            // 
            this.BarraEstatus.BackColor = System.Drawing.Color.White;
            this.BarraEstatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraEstatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraEstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstatusVersion,
            this.toolStripStatusLabel2,
            this.lblEstatusGrupo,
            this.toolStripStatusLabel1,
            this.lblEstatusUsuario,
            this.toolStripStatusLabel6,
            this.lblOficina,
            this.toolStripStatusLabel4,
            this.lblEstatusSPID,
            this.toolStripStatusLabel7,
            this.lblEstatusBaseDatos,
            this.toolStripStatusLabel5,
            this.lblEstatusServidor,
            this.toolStripStatusLabel9,
            this.Lblempresa});
            this.BarraEstatus.Location = new System.Drawing.Point(0, 724);
            this.BarraEstatus.Name = "BarraEstatus";
            this.BarraEstatus.Padding = new System.Windows.Forms.Padding(31, 0, 1, 0);
            this.BarraEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BarraEstatus.Size = new System.Drawing.Size(1370, 25);
            this.BarraEstatus.TabIndex = 6;
            this.BarraEstatus.Text = "Barra de Estatus";
            // 
            // lblEstatusVersion
            // 
            this.lblEstatusVersion.BackColor = System.Drawing.Color.Maroon;
            this.lblEstatusVersion.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblEstatusVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusVersion.ForeColor = System.Drawing.Color.White;
            this.lblEstatusVersion.Name = "lblEstatusVersion";
            this.lblEstatusVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstatusVersion.Size = new System.Drawing.Size(60, 20);
            this.lblEstatusVersion.Text = "Versión";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblEstatusGrupo
            // 
            this.lblEstatusGrupo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusGrupo.ForeColor = System.Drawing.Color.Green;
            this.lblEstatusGrupo.Name = "lblEstatusGrupo";
            this.lblEstatusGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstatusGrupo.Size = new System.Drawing.Size(52, 20);
            this.lblEstatusGrupo.Text = "Grupo";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblEstatusUsuario
            // 
            this.lblEstatusUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusUsuario.ForeColor = System.Drawing.Color.Navy;
            this.lblEstatusUsuario.Name = "lblEstatusUsuario";
            this.lblEstatusUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstatusUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblEstatusUsuario.Text = "Usuario";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // lblOficina
            // 
            this.lblOficina.BackColor = System.Drawing.Color.Navy;
            this.lblOficina.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOficina.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(56, 20);
            this.lblOficina.Text = "Oficina";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // lblEstatusSPID
            // 
            this.lblEstatusSPID.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.lblEstatusSPID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusSPID.ForeColor = System.Drawing.Color.Navy;
            this.lblEstatusSPID.Name = "lblEstatusSPID";
            this.lblEstatusSPID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstatusSPID.Size = new System.Drawing.Size(40, 20);
            this.lblEstatusSPID.Text = "SPID";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // lblEstatusBaseDatos
            // 
            this.lblEstatusBaseDatos.BackColor = System.Drawing.Color.Navy;
            this.lblEstatusBaseDatos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusBaseDatos.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblEstatusBaseDatos.Name = "lblEstatusBaseDatos";
            this.lblEstatusBaseDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstatusBaseDatos.Size = new System.Drawing.Size(40, 20);
            this.lblEstatusBaseDatos.Text = "Base";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // lblEstatusServidor
            // 
            this.lblEstatusServidor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusServidor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEstatusServidor.Name = "lblEstatusServidor";
            this.lblEstatusServidor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstatusServidor.Size = new System.Drawing.Size(68, 20);
            this.lblEstatusServidor.Text = "Servidor";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel9.Text = "|";
            // 
            // Lblempresa
            // 
            this.Lblempresa.BackColor = System.Drawing.Color.Navy;
            this.Lblempresa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblempresa.ForeColor = System.Drawing.Color.White;
            this.Lblempresa.Name = "Lblempresa";
            this.Lblempresa.Size = new System.Drawing.Size(96, 20);
            this.Lblempresa.Text = "Probemedic";
            this.Lblempresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Probemedic
            // 
            this.Probemedic.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Probemedic.BalloonTipTitle = "Probemedic";
            this.Probemedic.Icon = ((System.Drawing.Icon)(resources.GetObject("Probemedic.Icon")));
            this.Probemedic.Text = "Probemedic";
            this.Probemedic.Visible = true;
            this.Probemedic.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 180000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::ProbeMedic.Properties.Resources.fonso_sisem_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BarraEstatus);
            this.Controls.Add(this.MenuPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA  DE  INTEGRACIÓN";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Principal_PreviewKeyDown);
            this.BarraEstatus.ResumeLayout(false);
            this.BarraEstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip BarraEstatus;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatusVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatusGrupo;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatusUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel lblOficina;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel lblEstatusSPID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatusBaseDatos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatusServidor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel Lblempresa;
        public System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.NotifyIcon Probemedic;
        private System.Windows.Forms.Timer timer1;
    }
}