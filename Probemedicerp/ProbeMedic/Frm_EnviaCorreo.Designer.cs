namespace ProbeMedic.REPORTES
{
    partial class Frm_EnviaCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EnviaCorreo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.lbl_Archivos_Seleccionados = new System.Windows.Forms.Label();
            this.cbx_Adjuntar = new System.Windows.Forms.CheckBox();
            this.btn_Adjuntar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Para = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Asunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cuerpo = new System.Windows.Forms.TextBox();
            this.CargarArchivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Titulo);
            this.panel1.Controls.Add(this.lbl_Archivos_Seleccionados);
            this.panel1.Controls.Add(this.cbx_Adjuntar);
            this.panel1.Controls.Add(this.btn_Adjuntar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Para);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Asunto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Cuerpo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 402);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Titulo del Correo";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Titulo.Location = new System.Drawing.Point(11, 128);
            this.txt_Titulo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Titulo.Multiline = true;
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(433, 25);
            this.txt_Titulo.TabIndex = 3;
            // 
            // lbl_Archivos_Seleccionados
            // 
            this.lbl_Archivos_Seleccionados.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Archivos_Seleccionados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Archivos_Seleccionados.Location = new System.Drawing.Point(12, 353);
            this.lbl_Archivos_Seleccionados.Name = "lbl_Archivos_Seleccionados";
            this.lbl_Archivos_Seleccionados.Size = new System.Drawing.Size(433, 32);
            this.lbl_Archivos_Seleccionados.TabIndex = 44;
            // 
            // cbx_Adjuntar
            // 
            this.cbx_Adjuntar.AutoSize = true;
            this.cbx_Adjuntar.Location = new System.Drawing.Point(11, 272);
            this.cbx_Adjuntar.Name = "cbx_Adjuntar";
            this.cbx_Adjuntar.Size = new System.Drawing.Size(136, 21);
            this.cbx_Adjuntar.TabIndex = 5;
            this.cbx_Adjuntar.Text = "Adjuntar Archivos";
            this.cbx_Adjuntar.UseVisualStyleBackColor = true;
            this.cbx_Adjuntar.CheckedChanged += new System.EventHandler(this.cbx_Adjuntar_CheckedChanged);
            // 
            // btn_Adjuntar
            // 
            this.btn_Adjuntar.BackColor = System.Drawing.Color.White;
            this.btn_Adjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Adjuntar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Adjuntar.Image")));
            this.btn_Adjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Adjuntar.Location = new System.Drawing.Point(12, 299);
            this.btn_Adjuntar.Name = "btn_Adjuntar";
            this.btn_Adjuntar.Size = new System.Drawing.Size(100, 44);
            this.btn_Adjuntar.TabIndex = 6;
            this.btn_Adjuntar.Text = "Adjuntar Archivo";
            this.btn_Adjuntar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Adjuntar.UseVisualStyleBackColor = false;
            this.btn_Adjuntar.Click += new System.EventHandler(this.btn_Adjuntar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Para";
            // 
            // txt_Para
            // 
            this.txt_Para.Location = new System.Drawing.Point(12, 26);
            this.txt_Para.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Para.Multiline = true;
            this.txt_Para.Name = "txt_Para";
            this.txt_Para.Size = new System.Drawing.Size(433, 25);
            this.txt_Para.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Asunto del Correo";
            // 
            // txt_Asunto
            // 
            this.txt_Asunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Asunto.Location = new System.Drawing.Point(11, 77);
            this.txt_Asunto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Asunto.Multiline = true;
            this.txt_Asunto.Name = "txt_Asunto";
            this.txt_Asunto.Size = new System.Drawing.Size(433, 25);
            this.txt_Asunto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cuerpo del Correo";
            // 
            // txt_Cuerpo
            // 
            this.txt_Cuerpo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cuerpo.Location = new System.Drawing.Point(11, 180);
            this.txt_Cuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cuerpo.Multiline = true;
            this.txt_Cuerpo.Name = "txt_Cuerpo";
            this.txt_Cuerpo.Size = new System.Drawing.Size(433, 84);
            this.txt_Cuerpo.TabIndex = 4;
            // 
            // CargarArchivo
            // 
            this.CargarArchivo.FileName = "openFileDialog1";
            // 
            // Frm_Envia_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 479);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_EnviaCorreo";
            this.Text = "Enviar Correo";
            this.Load += new System.EventHandler(this.Frm_EnviaCorreo_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Para;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Asunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cuerpo;
        private System.Windows.Forms.Button btn_Adjuntar;
        private System.Windows.Forms.OpenFileDialog CargarArchivo;
        private System.Windows.Forms.Label lbl_Archivos_Seleccionados;
        private System.Windows.Forms.CheckBox cbx_Adjuntar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Titulo;
    }
}