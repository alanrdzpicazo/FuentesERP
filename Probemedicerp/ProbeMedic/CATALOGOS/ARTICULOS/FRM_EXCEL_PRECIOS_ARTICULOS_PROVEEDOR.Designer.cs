namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    partial class FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR
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
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.franja_1 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.franja_1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRuta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(81, 32);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(601, 22);
            this.txtRuta.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.franja_1);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 108);
            this.panel1.TabIndex = 43;
            // 
            // franja_1
            // 
            this.franja_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(187)))));
            this.franja_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.franja_1.Location = new System.Drawing.Point(0, 0);
            this.franja_1.Name = "franja_1";
            this.franja_1.Size = new System.Drawing.Size(694, 21);
            this.franja_1.TabIndex = 46;
            this.franja_1.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(21, 35);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 16);
            this.label37.TabIndex = 47;
            this.label37.Text = "Archivo";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(79, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 17);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "lblStatus";
            // 
            // FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 185);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR";
            this.Text = "Precios Artìculos Proveedor";
            this.Load += new System.EventHandler(this.FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.franja_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox franja_1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblStatus;
    }
}