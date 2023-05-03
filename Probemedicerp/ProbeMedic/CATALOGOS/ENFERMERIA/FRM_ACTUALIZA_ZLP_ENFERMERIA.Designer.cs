namespace ProbeMedic.CATALOGOS.ENFERMERIA
{
    partial class FRM_ACTUALIZA_ZLP_ENFERMERIA
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
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCiudad.Location = new System.Drawing.Point(156, 69);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(385, 28);
            this.txtCiudad.TabIndex = 132;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(156, 194);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(298, 28);
            this.dtpFinal.TabIndex = 131;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(156, 152);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(298, 28);
            this.dtpInicial.TabIndex = 130;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(156, 110);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 28);
            this.txtPrecio.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 128;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 127;
            this.label6.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 126;
            this.label5.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 125;
            this.label4.Text = "Ciudad";
            // 
            // FRM_ACTUALIZA_ZLP_ENFERMERIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 293);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FRM_ACTUALIZA_ZLP_ENFERMERIA";
            this.Text = "Actualiza Precio Enfermería";
            this.Load += new System.EventHandler(this.FRM_ACTUALIZA_ZLP_ENFERMERIA_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.dtpInicial, 0);
            this.Controls.SetChildIndex(this.dtpFinal, 0);
            this.Controls.SetChildIndex(this.txtCiudad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}