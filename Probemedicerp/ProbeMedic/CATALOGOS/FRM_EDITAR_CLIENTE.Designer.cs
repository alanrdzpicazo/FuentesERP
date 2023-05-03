namespace ProbeMedic.CATALOGOS
{
    partial class FRM_EDITAR_CLIENTE
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
            this.PnlGeneral = new System.Windows.Forms.Panel();
            this.txt_RFC_Cliente = new System.Windows.Forms.TextBox();
            this.txt_D_Cliente_Nuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_D_Cliente = new System.Windows.Forms.TextBox();
            this.txt_K_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.PnlGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGeneral
            // 
            this.PnlGeneral.Controls.Add(this.txt_RFC_Cliente);
            this.PnlGeneral.Controls.Add(this.txt_D_Cliente_Nuevo);
            this.PnlGeneral.Controls.Add(this.label4);
            this.PnlGeneral.Controls.Add(this.panel1);
            this.PnlGeneral.Controls.Add(this.label3);
            this.PnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.PnlGeneral.Name = "PnlGeneral";
            this.PnlGeneral.Size = new System.Drawing.Size(608, 192);
            this.PnlGeneral.TabIndex = 0;
            this.PnlGeneral.TabStop = true;
            // 
            // txt_RFC_Cliente
            // 
            this.txt_RFC_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_RFC_Cliente.Location = new System.Drawing.Point(130, 152);
            this.txt_RFC_Cliente.Name = "txt_RFC_Cliente";
            this.txt_RFC_Cliente.Size = new System.Drawing.Size(246, 24);
            this.txt_RFC_Cliente.TabIndex = 2;
            // 
            // txt_D_Cliente_Nuevo
            // 
            this.txt_D_Cliente_Nuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_D_Cliente_Nuevo.Location = new System.Drawing.Point(131, 120);
            this.txt_D_Cliente_Nuevo.Name = "txt_D_Cliente_Nuevo";
            this.txt_D_Cliente_Nuevo.Size = new System.Drawing.Size(459, 24);
            this.txt_D_Cliente_Nuevo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "RFC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txt_RFC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_D_Cliente);
            this.panel1.Controls.Add(this.txt_K_Cliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 112);
            this.panel1.TabIndex = 5;
            // 
            // txt_D_Cliente
            // 
            this.txt_D_Cliente.Location = new System.Drawing.Point(132, 41);
            this.txt_D_Cliente.Name = "txt_D_Cliente";
            this.txt_D_Cliente.ReadOnly = true;
            this.txt_D_Cliente.Size = new System.Drawing.Size(459, 24);
            this.txt_D_Cliente.TabIndex = 8;
            this.txt_D_Cliente.TabStop = false;
            // 
            // txt_K_Cliente
            // 
            this.txt_K_Cliente.Location = new System.Drawing.Point(132, 8);
            this.txt_K_Cliente.Name = "txt_K_Cliente";
            this.txt_K_Cliente.ReadOnly = true;
            this.txt_K_Cliente.Size = new System.Drawing.Size(116, 24);
            this.txt_K_Cliente.TabIndex = 7;
            this.txt_K_Cliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "RFC Actual";
            // 
            // txt_RFC
            // 
            this.txt_RFC.Location = new System.Drawing.Point(133, 74);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.ReadOnly = true;
            this.txt_RFC.Size = new System.Drawing.Size(243, 24);
            this.txt_RFC.TabIndex = 10;
            this.txt_RFC.TabStop = false;
            // 
            // FRM_EDITAR_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 269);
            this.Controls.Add(this.PnlGeneral);
            this.MinimumSize = new System.Drawing.Size(624, 308);
            this.Name = "FRM_EDITAR_CLIENTE";
            this.Text = "EDITAR DATOS DE FACTURACION";
            this.Load += new System.EventHandler(this.FRM_EDITAR_CLIENTE_Load);
            this.Controls.SetChildIndex(this.PnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.PnlGeneral.ResumeLayout(false);
            this.PnlGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGeneral;
        private System.Windows.Forms.TextBox txt_RFC_Cliente;
        private System.Windows.Forms.TextBox txt_D_Cliente_Nuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_D_Cliente;
        private System.Windows.Forms.TextBox txt_K_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}