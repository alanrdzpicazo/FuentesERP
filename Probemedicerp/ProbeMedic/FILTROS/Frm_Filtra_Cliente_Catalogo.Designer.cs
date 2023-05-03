namespace ProbeMedic.FILTROS
{
    partial class Frm_Filtra_Cliente_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filtra_Cliente_Catalogo));
            this.txt_D_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.usEstatusCliente1 = new ProbeMedic.Controles.usEstatusCliente();
            this.LblTipoFiscal = new System.Windows.Forms.Label();
            this.ucTipoFiscal1 = new ProbeMedic.Controles.ucTipoFiscal();
            this.ucCanalDistribucionCliente1 = new ProbeMedic.Controles.ucCanalDistribucionCliente();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClave = new ProbeMedic.Controles.ucInteger32();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_D_Cliente
            // 
            this.txt_D_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_D_Cliente.Location = new System.Drawing.Point(144, 76);
            this.txt_D_Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_D_Cliente.Name = "txt_D_Cliente";
            this.txt_D_Cliente.Size = new System.Drawing.Size(230, 23);
            this.txt_D_Cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 129;
            this.label1.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 135;
            this.label12.Text = "Estatus ";
            // 
            // usEstatusCliente1
            // 
            this.usEstatusCliente1.Location = new System.Drawing.Point(143, 139);
            this.usEstatusCliente1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usEstatusCliente1.Name = "usEstatusCliente1";
            this.usEstatusCliente1.Size = new System.Drawing.Size(318, 35);
            this.usEstatusCliente1.TabIndex = 3;
            // 
            // LblTipoFiscal
            // 
            this.LblTipoFiscal.AutoSize = true;
            this.LblTipoFiscal.Location = new System.Drawing.Point(59, 111);
            this.LblTipoFiscal.Name = "LblTipoFiscal";
            this.LblTipoFiscal.Size = new System.Drawing.Size(76, 17);
            this.LblTipoFiscal.TabIndex = 134;
            this.LblTipoFiscal.Text = "Tipo Fiscal";
            // 
            // ucTipoFiscal1
            // 
            this.ucTipoFiscal1.Location = new System.Drawing.Point(143, 107);
            this.ucTipoFiscal1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTipoFiscal1.Name = "ucTipoFiscal1";
            this.ucTipoFiscal1.Size = new System.Drawing.Size(318, 29);
            this.ucTipoFiscal1.TabIndex = 2;
            // 
            // ucCanalDistribucionCliente1
            // 
            this.ucCanalDistribucionCliente1.Location = new System.Drawing.Point(139, 169);
            this.ucCanalDistribucionCliente1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCanalDistribucionCliente1.Name = "ucCanalDistribucionCliente1";
            this.ucCanalDistribucionCliente1.Size = new System.Drawing.Size(328, 36);
            this.ucCanalDistribucionCliente1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 133;
            this.label11.Text = "Canal Distribución";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(145, 43);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(94, 23);
            this.txtClave.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 137;
            this.label2.Text = "Número de Cliente";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoEllipsis = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(307, 215);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 41);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "&Buscar [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Frm_Filtra_Cliente_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 268);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.usEstatusCliente1);
            this.Controls.Add(this.LblTipoFiscal);
            this.Controls.Add(this.ucTipoFiscal1);
            this.Controls.Add(this.ucCanalDistribucionCliente1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_D_Cliente);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Filtra_Cliente_Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Cliente..";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Filtra_Cliente_Catalogo_KeyDown);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_D_Cliente, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.ucCanalDistribucionCliente1, 0);
            this.Controls.SetChildIndex(this.ucTipoFiscal1, 0);
            this.Controls.SetChildIndex(this.LblTipoFiscal, 0);
            this.Controls.SetChildIndex(this.usEstatusCliente1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_D_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private Controles.usEstatusCliente usEstatusCliente1;
        private System.Windows.Forms.Label LblTipoFiscal;
        private Controles.ucTipoFiscal ucTipoFiscal1;
        private Controles.ucCanalDistribucionCliente ucCanalDistribucionCliente1;
        private System.Windows.Forms.Label label11;
        private Controles.ucInteger32 txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
    }
}