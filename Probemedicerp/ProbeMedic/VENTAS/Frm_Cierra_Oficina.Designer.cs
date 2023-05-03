namespace ProbeMedic.VENTAS
{
    partial class Frm_Cierra_Oficina
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_Clave_Oficina = new System.Windows.Forms.TextBox();
            this.Txt_Clave_Cierre = new System.Windows.Forms.TextBox();
            this.Txt_Almacen = new System.Windows.Forms.TextBox();
            this.Txt_Oficina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Generar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 205);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_Titulo);
            this.panel2.Controls.Add(this.Txt_Clave_Oficina);
            this.panel2.Controls.Add(this.Txt_Clave_Cierre);
            this.panel2.Controls.Add(this.Txt_Almacen);
            this.panel2.Controls.Add(this.Txt_Oficina);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 120);
            this.panel2.TabIndex = 1;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(529, 28);
            this.Lbl_Titulo.TabIndex = 24;
            this.Lbl_Titulo.Text = "Cierre de la Oficina";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Clave_Oficina
            // 
            this.Txt_Clave_Oficina.Location = new System.Drawing.Point(92, 42);
            this.Txt_Clave_Oficina.Name = "Txt_Clave_Oficina";
            this.Txt_Clave_Oficina.Size = new System.Drawing.Size(48, 24);
            this.Txt_Clave_Oficina.TabIndex = 5;
            this.Txt_Clave_Oficina.TabStop = false;
            // 
            // Txt_Clave_Cierre
            // 
            this.Txt_Clave_Cierre.Location = new System.Drawing.Point(92, 76);
            this.Txt_Clave_Cierre.Name = "Txt_Clave_Cierre";
            this.Txt_Clave_Cierre.Size = new System.Drawing.Size(48, 24);
            this.Txt_Clave_Cierre.TabIndex = 4;
            this.Txt_Clave_Cierre.TabStop = false;
            // 
            // Txt_Almacen
            // 
            this.Txt_Almacen.Location = new System.Drawing.Point(146, 76);
            this.Txt_Almacen.Name = "Txt_Almacen";
            this.Txt_Almacen.Size = new System.Drawing.Size(371, 24);
            this.Txt_Almacen.TabIndex = 3;
            this.Txt_Almacen.TabStop = false;
            // 
            // Txt_Oficina
            // 
            this.Txt_Oficina.Location = new System.Drawing.Point(146, 42);
            this.Txt_Oficina.Name = "Txt_Oficina";
            this.Txt_Oficina.Size = new System.Drawing.Size(371, 24);
            this.Txt_Oficina.TabIndex = 2;
            this.Txt_Oficina.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Almacén";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficina";
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Location = new System.Drawing.Point(174, 129);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(200, 56);
            this.Btn_Generar.TabIndex = 2;
            this.Btn_Generar.Text = "Generar Cierre de la Oficina";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // Frm_Cierra_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 205);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cierra_Oficina";
            this.Text = "CIERRE GENERAL DE OFICINA";
            this.Load += new System.EventHandler(this.Frm_Cierra_Oficina_Load);
            this.Shown += new System.EventHandler(this.Frm_Cierra_Oficina_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.TextBox Txt_Clave_Oficina;
        private System.Windows.Forms.TextBox Txt_Clave_Cierre;
        private System.Windows.Forms.TextBox Txt_Almacen;
        private System.Windows.Forms.TextBox Txt_Oficina;
        private System.Windows.Forms.Label Lbl_Titulo;
    }
}