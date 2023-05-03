namespace ProbeMedic.INVENTARIOS
{
    partial class Frm_Captura_Lotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Captura_Lotes));
            this.dgvIngresaLote = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_articulo = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_no_lotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sku = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresaLote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngresaLote
            // 
            this.dgvIngresaLote.AllowUserToAddRows = false;
            this.dgvIngresaLote.AllowUserToDeleteRows = false;
            this.dgvIngresaLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresaLote.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngresaLote.Location = new System.Drawing.Point(12, 152);
            this.dgvIngresaLote.Name = "dgvIngresaLote";
            this.dgvIngresaLote.Size = new System.Drawing.Size(430, 226);
            this.dgvIngresaLote.TabIndex = 0;
            this.dgvIngresaLote.TabStop = false;
            this.dgvIngresaLote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresaLote_CellContentClick);
            this.dgvIngresaLote.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresaLote_CellEnter);
            this.dgvIngresaLote.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIngresaLote_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 420;
            this.label1.Text = "No. de lotes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 421;
            this.label3.Text = "Artículo";
            // 
            // txt_articulo
            // 
            this.txt_articulo.Enabled = false;
            this.txt_articulo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_articulo.Location = new System.Drawing.Point(109, 24);
            this.txt_articulo.MaxLength = 10;
            this.txt_articulo.Name = "txt_articulo";
            this.txt_articulo.Size = new System.Drawing.Size(333, 25);
            this.txt_articulo.TabIndex = 422;
            this.txt_articulo.Tag = "ENTERO";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(272, 381);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(170, 36);
            this.btn_Guardar.TabIndex = 423;
            this.btn_Guardar.Text = "&Guardar [F10]";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_no_lotes
            // 
            this.txt_no_lotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_no_lotes.Location = new System.Drawing.Point(13, 116);
            this.txt_no_lotes.Name = "txt_no_lotes";
            this.txt_no_lotes.Size = new System.Drawing.Size(191, 22);
            this.txt_no_lotes.TabIndex = 0;
            this.txt_no_lotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_lotes_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 425;
            this.label2.Text = "Sku";
            // 
            // txt_sku
            // 
            this.txt_sku.Enabled = false;
            this.txt_sku.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sku.Location = new System.Drawing.Point(109, 57);
            this.txt_sku.MaxLength = 10;
            this.txt_sku.Name = "txt_sku";
            this.txt_sku.Size = new System.Drawing.Size(333, 25);
            this.txt_sku.TabIndex = 426;
            this.txt_sku.Tag = "ENTERO";
            // 
            // Frm_Captura_Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 419);
            this.Controls.Add(this.txt_sku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_no_lotes);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_articulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIngresaLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frm_Captura_Lotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTURA LOTES ORDEN DE COMPRA";
            this.Load += new System.EventHandler(this.Frm_Captura_Lotes_Load);
            this.Shown += new System.EventHandler(this.Frm_Captura_Lotes_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Captura_Lotes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresaLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNoDocto;
        private System.Windows.Forms.Label lblNoDocto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_no_lotes;
        public System.Windows.Forms.DataGridView dgvIngresaLote;
        public System.Windows.Forms.TextBox txt_articulo;
        public System.Windows.Forms.TextBox txt_sku;
    }
}