namespace ProbeMedic
{
    partial class Frm_Impresoras
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
            this.franja_1 = new System.Windows.Forms.PictureBox();
            this.cmbPrinterTicket = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franja_1)).BeginInit();
            this.SuspendLayout();
            // 
            // franja_1
            // 
            this.franja_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.franja_1.Location = new System.Drawing.Point(0, 52);
            this.franja_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.franja_1.Name = "franja_1";
            this.franja_1.Size = new System.Drawing.Size(594, 12);
            this.franja_1.TabIndex = 13;
            this.franja_1.TabStop = false;
            // 
            // cmbPrinterTicket
            // 
            this.cmbPrinterTicket.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrinterTicket.FormattingEnabled = true;
            this.cmbPrinterTicket.Location = new System.Drawing.Point(92, 91);
            this.cmbPrinterTicket.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPrinterTicket.Name = "cmbPrinterTicket";
            this.cmbPrinterTicket.Size = new System.Drawing.Size(304, 24);
            this.cmbPrinterTicket.TabIndex = 0;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 9.5F);
            this.label37.Location = new System.Drawing.Point(25, 93);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 16);
            this.label37.TabIndex = 39;
            this.label37.Text = "Tickets";
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAplicar.Location = new System.Drawing.Point(457, 83);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(103, 44);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Entrar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            this.btnAplicar.MouseEnter += new System.EventHandler(this.btnAplicar_MouseEnter);
            // 
            // Frm_Impresoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 195);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.cmbPrinterTicket);
            this.Controls.Add(this.franja_1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(610, 234);
            this.MinimumSize = new System.Drawing.Size(610, 234);
            this.Name = "Frm_Impresoras";
            this.Text = "IMPRESORAS";
            this.Controls.SetChildIndex(this.franja_1, 0);
            this.Controls.SetChildIndex(this.cmbPrinterTicket, 0);
            this.Controls.SetChildIndex(this.label37, 0);
            this.Controls.SetChildIndex(this.btnAplicar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franja_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox franja_1;
        private System.Windows.Forms.ComboBox cmbPrinterTicket;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnAplicar;
    }
}