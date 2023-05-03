namespace ProbeMedic.SEGURIDAD
{
    partial class FRM_CambiaContrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CambiaContrasenia));
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblD_Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.txtConfirmaContra = new System.Windows.Forms.TextBox();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUsuario.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            this.pnlCaptura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.pnlUsuario.Controls.Add(this.lblLogin);
            this.pnlUsuario.Controls.Add(this.lblD_Usuario);
            this.pnlUsuario.Controls.Add(this.label2);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 41);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(408, 58);
            this.pnlUsuario.TabIndex = 15;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(69, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 3;
            // 
            // lblD_Usuario
            // 
            this.lblD_Usuario.AutoSize = true;
            this.lblD_Usuario.ForeColor = System.Drawing.Color.White;
            this.lblD_Usuario.Location = new System.Drawing.Point(69, 7);
            this.lblD_Usuario.Name = "lblD_Usuario";
            this.lblD_Usuario.Size = new System.Drawing.Size(0, 13);
            this.lblD_Usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.AutoSize = false;
            this.BarraHerramientas.BackColor = System.Drawing.Color.White;
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnGuardar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(408, 41);
            this.BarraHerramientas.TabIndex = 14;
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
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 35);
            this.btnGuardar.Text = "&Guardar ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.ToolTipText = "Guardar Información...";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // pnlCaptura
            // 
            this.pnlCaptura.BackColor = System.Drawing.Color.White;
            this.pnlCaptura.Controls.Add(this.txtConfirmaContra);
            this.pnlCaptura.Controls.Add(this.txtNuevaContra);
            this.pnlCaptura.Controls.Add(this.label5);
            this.pnlCaptura.Controls.Add(this.label4);
            this.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCaptura.Enabled = false;
            this.pnlCaptura.Location = new System.Drawing.Point(0, 154);
            this.pnlCaptura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(408, 97);
            this.pnlCaptura.TabIndex = 13;
            // 
            // txtConfirmaContra
            // 
            this.txtConfirmaContra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaContra.Location = new System.Drawing.Point(154, 40);
            this.txtConfirmaContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmaContra.MaxLength = 20;
            this.txtConfirmaContra.Name = "txtConfirmaContra";
            this.txtConfirmaContra.PasswordChar = '*';
            this.txtConfirmaContra.Size = new System.Drawing.Size(128, 23);
            this.txtConfirmaContra.TabIndex = 7;
            this.txtConfirmaContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmaContra_KeyPress_1);
            this.txtConfirmaContra.Leave += new System.EventHandler(this.txtConfirmaContra_Leave_1);
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContra.Location = new System.Drawing.Point(154, 10);
            this.txtNuevaContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNuevaContra.MaxLength = 20;
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.PasswordChar = '*';
            this.txtNuevaContra.Size = new System.Drawing.Size(128, 23);
            this.txtNuevaContra.TabIndex = 6;
            this.txtNuevaContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevaContra_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nueva Contraseña";
            // 
            // txtContraActual
            // 
            this.txtContraActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraActual.Location = new System.Drawing.Point(154, 110);
            this.txtContraActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraActual.MaxLength = 20;
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.PasswordChar = '*';
            this.txtContraActual.Size = new System.Drawing.Size(126, 23);
            this.txtContraActual.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña Actual";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 4);
            this.panel1.TabIndex = 52;
            // 
            // FRM_CambiaContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 251);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.pnlCaptura);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(424, 290);
            this.MinimumSize = new System.Drawing.Size(424, 290);
            this.Name = "FRM_CambiaContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIA CONTRASEÑA";
            this.Load += new System.EventHandler(this.FRM_CambiaContrasenia_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_CambiaContrasenia_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRM_CambiaContrasenia_KeyPress_1);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.pnlCaptura.ResumeLayout(false);
            this.pnlCaptura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblD_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.TextBox txtConfirmaContra;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}