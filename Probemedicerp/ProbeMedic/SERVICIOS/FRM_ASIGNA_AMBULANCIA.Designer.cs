namespace ProbeMedic.SERVICIOS
{
    partial class FRM_ASIGNA_AMBULANCIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ASIGNA_AMBULANCIA));
            this.txtNoServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarAmbulancia = new System.Windows.Forms.Button();
            this.txtAmbulancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoServicio
            // 
            this.txtNoServicio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNoServicio.Location = new System.Drawing.Point(150, 53);
            this.txtNoServicio.Name = "txtNoServicio";
            this.txtNoServicio.ReadOnly = true;
            this.txtNoServicio.Size = new System.Drawing.Size(136, 28);
            this.txtNoServicio.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 119;
            this.label2.Text = "No.Servicio";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(207, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 51);
            this.button2.TabIndex = 118;
            this.button2.Text = "Asignar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarAmbulancia
            // 
            this.btnBuscarAmbulancia.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAmbulancia.Image")));
            this.btnBuscarAmbulancia.Location = new System.Drawing.Point(303, 147);
            this.btnBuscarAmbulancia.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarAmbulancia.Name = "btnBuscarAmbulancia";
            this.btnBuscarAmbulancia.Size = new System.Drawing.Size(33, 32);
            this.btnBuscarAmbulancia.TabIndex = 115;
            this.btnBuscarAmbulancia.UseVisualStyleBackColor = true;
            this.btnBuscarAmbulancia.Click += new System.EventHandler(this.btnBuscarAmbulancia_Click);
            // 
            // txtAmbulancia
            // 
            this.txtAmbulancia.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtAmbulancia.Location = new System.Drawing.Point(56, 147);
            this.txtAmbulancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmbulancia.Name = "txtAmbulancia";
            this.txtAmbulancia.ReadOnly = true;
            this.txtAmbulancia.Size = new System.Drawing.Size(230, 28);
            this.txtAmbulancia.TabIndex = 117;
            this.txtAmbulancia.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 116;
            this.label1.Text = "Ambulancia";
            // 
            // FRM_ASIGNA_AMBULANCIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 325);
            this.Controls.Add(this.txtNoServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscarAmbulancia);
            this.Controls.Add(this.txtAmbulancia);
            this.Controls.Add(this.label1);
            this.Name = "FRM_ASIGNA_AMBULANCIA";
            this.Text = "Asigna Ambulancia";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtAmbulancia, 0);
            this.Controls.SetChildIndex(this.btnBuscarAmbulancia, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNoServicio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarAmbulancia;
        private System.Windows.Forms.TextBox txtAmbulancia;
        private System.Windows.Forms.Label label1;
    }
}