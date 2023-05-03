namespace ProbeMedic.Busquedas
{
    partial class Frm_Busca_Articulos_SOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca_Articulos_SOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_D_Articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 534;
            // 
            // txt_D_Articulo
            // 
            this.txt_D_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_D_Articulo.Location = new System.Drawing.Point(93, 50);
            this.txt_D_Articulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_D_Articulo.Name = "txt_D_Articulo";
            this.txt_D_Articulo.Size = new System.Drawing.Size(230, 23);
            this.txt_D_Articulo.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 119;
            this.label1.Text = "Nombre";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoEllipsis = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(372, 41);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 41);
            this.BtnBuscar.TabIndex = 120;
            this.BtnBuscar.Text = "Buscar [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Visible = false;
            // 
            // grDatos
            // 
            this.grDatos.AllowUserToAddRows = false;
            this.grDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Articulo,
            this.D_Articulo,
            this.Subtotal,
            this.Iva,
            this.Precio});
            this.grDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDatos.Location = new System.Drawing.Point(0, 29);
            this.grDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grDatos.Name = "grDatos";
            this.grDatos.RowTemplate.Height = 24;
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(1049, 365);
            this.grDatos.TabIndex = 121;
            this.grDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellContentClick);
            this.grDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 93.65079F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Iva
            // 
            this.Iva.DataPropertyName = "Iva";
            this.Iva.FillWeight = 93.65079F;
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.FillWeight = 93.65079F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // D_Articulo
            // 
            this.D_Articulo.DataPropertyName = "D_Articulo";
            this.D_Articulo.FillWeight = 168.2862F;
            this.D_Articulo.HeaderText = "Articulo";
            this.D_Articulo.Name = "D_Articulo";
            // 
            // K_Articulo
            // 
            this.K_Articulo.DataPropertyName = "K_Articulo";
            this.K_Articulo.FillWeight = 50.76142F;
            this.K_Articulo.HeaderText = "Clave";
            this.K_Articulo.Name = "K_Articulo";
            // 
            // Frm_Busca_Articulos_SOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 394);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txt_D_Articulo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_Busca_Articulos_SOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos SOS";
            this.Load += new System.EventHandler(this.Frm_Busca_Articulos_SOS_Load);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_D_Articulo, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.Controls.SetChildIndex(this.grDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txt_D_Articulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}