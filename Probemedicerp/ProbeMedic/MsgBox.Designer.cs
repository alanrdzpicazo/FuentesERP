namespace ProbeMedic
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(561, 217);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(130, 45);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mensaje.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(96, 51);
            this.txt_mensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(592, 157);
            this.txt_mensaje.TabIndex = 1;
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(26)))), ((int)(((byte)(77)))));
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(706, 37);
            this.lbl_titulo.TabIndex = 28;
            this.lbl_titulo.Text = "Título";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.btn_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MsgBox";
            this.Text = "Aviso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}