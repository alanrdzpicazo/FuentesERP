namespace ProbeMedic.PEDIDOS
{
    partial class FRM_MODIFICAR_PAQUETERIA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxPaqueteria = new System.Windows.Forms.ComboBox();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 180);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxPaqueteria);
            this.panel2.Controls.Add(this.txtNoGuia);
            this.panel2.Controls.Add(this.lblPedido);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 152);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // cbxPaqueteria
            // 
            this.cbxPaqueteria.FormattingEnabled = true;
            this.cbxPaqueteria.Location = new System.Drawing.Point(169, 55);
            this.cbxPaqueteria.Name = "cbxPaqueteria";
            this.cbxPaqueteria.Size = new System.Drawing.Size(206, 24);
            this.cbxPaqueteria.TabIndex = 1;
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoGuia.Location = new System.Drawing.Point(169, 91);
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(203, 24);
            this.txtNoGuia.TabIndex = 2;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(163, 26);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(0, 16);
            this.lblPedido.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Número de Guía:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pedido número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Paqueteria:";
            // 
            // sd
            // 
            this.sd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.sd.Dock = System.Windows.Forms.DockStyle.Top;
            this.sd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.ForeColor = System.Drawing.SystemColors.Control;
            this.sd.Location = new System.Drawing.Point(0, 0);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(400, 28);
            this.sd.TabIndex = 27;
            this.sd.Text = "Modificar Paquetería";
            this.sd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_MODIFICAR_PAQUETERIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 257);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_MODIFICAR_PAQUETERIA";
            this.Text = "Modificar Paquetería";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.ComboBox cbxPaqueteria;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}