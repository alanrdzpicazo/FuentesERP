namespace ProbeMedic.CATALOGOS
{
    partial class FRM_ACTUALIZA_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIA
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Ciudad";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(121, 142);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(233, 24);
            this.dtpFinal.TabIndex = 109;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(121, 110);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(233, 24);
            this.dtpInicial.TabIndex = 108;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(121, 78);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 24);
            this.txtPrecio.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 106;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 104;
            this.label5.Text = "Fecha Final";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtCiudad.Location = new System.Drawing.Point(121, 47);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(300, 24);
            this.txtCiudad.TabIndex = 116;
            // 
            // FRM_ACTUALIZA_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 223);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FRM_ACTUALIZA_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIA";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.FRM_ACTUALIZA_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIA_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiudad;
    }
}