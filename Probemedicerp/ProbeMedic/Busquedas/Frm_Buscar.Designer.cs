namespace ProbeMedic
{
    partial class Frm_Buscar
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
            this.button3 = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 77;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_Buscar.Location = new System.Drawing.Point(18, 32);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(415, 26);
            this.txt_Buscar.TabIndex = 75;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            this.txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscar_KeyPress);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grdDatos.Location = new System.Drawing.Point(-1, 64);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(509, 157);
            this.grdDatos.TabIndex = 78;
            this.grdDatos.SelectionChanged += new System.EventHandler(this.grdDatos_SelectionChanged);
            this.grdDatos.DoubleClick += new System.EventHandler(this.grdDatos_DoubleClick);
            this.grdDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 26);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_Buscar);
            this.Name = "Frm_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Frm_Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_Buscar;


    }
}