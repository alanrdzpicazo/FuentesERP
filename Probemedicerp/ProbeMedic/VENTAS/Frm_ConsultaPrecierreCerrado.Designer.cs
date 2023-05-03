namespace ProbeMedic.VENTAS
{
    partial class Frm_ConsultaPrecierreCerrado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_K_Precierre_Empleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ucUsuarios1 = new ProbeMedic.Controles.ucUsuarios();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Consultar);
            this.panel1.Controls.Add(this.ucUsuarios1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_K_Precierre_Empleado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 169);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Precierre";
            // 
            // txt_K_Precierre_Empleado
            // 
            this.txt_K_Precierre_Empleado.Location = new System.Drawing.Point(129, 40);
            this.txt_K_Precierre_Empleado.Name = "txt_K_Precierre_Empleado";
            this.txt_K_Precierre_Empleado.Size = new System.Drawing.Size(100, 24);
            this.txt_K_Precierre_Empleado.TabIndex = 1;
            this.txt_K_Precierre_Empleado.Tag = "ENTERO";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precierres Cerrados";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucUsuarios1
            // 
            this.ucUsuarios1.Location = new System.Drawing.Point(126, 71);
            this.ucUsuarios1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucUsuarios1.Name = "ucUsuarios1";
            this.ucUsuarios1.Size = new System.Drawing.Size(273, 27);
            this.ucUsuarios1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Usuario";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(164, 117);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(96, 32);
            this.btn_Consultar.TabIndex = 35;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // Frm_ConsultaPrecierreCerrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 246);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ConsultaPrecierreCerrado";
            this.Text = "CONSULTA PRECIERRE FARMACIA";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_K_Precierre_Empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Controles.ucUsuarios ucUsuarios1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Consultar;
    }
}