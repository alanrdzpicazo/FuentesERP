namespace ProbeMedic.VENTAS
{
    partial class Frm_ReimpresionTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.btnReimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "#Ticket";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(93, 52);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(220, 24);
            this.txtTicket.TabIndex = 3;
            this.txtTicket.Tag = "ENTERO";
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Location = new System.Drawing.Point(134, 91);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(96, 32);
            this.btnReimprimir.TabIndex = 4;
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.UseVisualStyleBackColor = true;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // Frm_ReimpresionTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 188);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(369, 227);
            this.MinimumSize = new System.Drawing.Size(369, 227);
            this.Name = "Frm_ReimpresionTicket";
            this.Text = "REIMPRESION TICKET";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ReimpresionTicket_KeyDown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTicket, 0);
            this.Controls.SetChildIndex(this.btnReimprimir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Button btnReimprimir;
    }
}