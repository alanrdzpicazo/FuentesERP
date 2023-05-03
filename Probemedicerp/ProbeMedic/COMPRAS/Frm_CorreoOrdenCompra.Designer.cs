namespace ProbeMedic.COMPRAS
{
    partial class Frm_CorreoOrdenCompra
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            this.lblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(0, 38);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(477, 23);
            this.lblProveedor.TabIndex = 11;
            this.lblProveedor.Text = "Contacto";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContacto.Location = new System.Drawing.Point(89, 83);
            this.txtContacto.MaxLength = 60;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(353, 24);
            this.txtContacto.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(89, 124);
            this.txtCorreo.MaxLength = 60;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(353, 24);
            this.txtCorreo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Correo:";
            // 
            // Frm_CorreoOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 250);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProveedor);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CorreoOrdenCompra";
            this.Text = "ENVIAR CORREO";
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtContacto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
    }
}