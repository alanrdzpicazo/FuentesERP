namespace ProbeMedic.FILTROS
{
    partial class Frm_Filtro_Paciente_Pedido
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.K_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sel_Aseguradora = new ProbeMedic.Controles.ucAseguradora();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(112, 118);
            this.Entrar.Margin = new System.Windows.Forms.Padding(6);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 290);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 189);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdDatos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(742, 189);
            this.panel4.TabIndex = 2;
            this.panel4.TabStop = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Paciente,
            this.Nombre_Completo});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(742, 189);
            this.grdDatos.TabIndex = 1;
            this.grdDatos.SelectionChanged += new System.EventHandler(this.grdDatos_SelectionChanged);
            this.grdDatos.DoubleClick += new System.EventHandler(this.grdDatos_DoubleClick);
            this.grdDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
            // 
            // K_Paciente
            // 
            this.K_Paciente.DataPropertyName = "K_Paciente";
            this.K_Paciente.HeaderText = "K_Paciente";
            this.K_Paciente.Name = "K_Paciente";
            this.K_Paciente.Visible = false;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.DataPropertyName = "Nombre_Completo";
            this.Nombre_Completo.HeaderText = "Descripción";
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sel_Aseguradora);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.txt_Buscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 101);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // sel_Aseguradora
            // 
            this.sel_Aseguradora.K_Aseguradora = 0;
            this.sel_Aseguradora.Location = new System.Drawing.Point(136, 11);
            this.sel_Aseguradora.Margin = new System.Windows.Forms.Padding(5);
            this.sel_Aseguradora.Name = "sel_Aseguradora";
            this.sel_Aseguradora.Size = new System.Drawing.Size(482, 39);
            this.sel_Aseguradora.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Aseguradora";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(646, 58);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 33);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Buscar.Location = new System.Drawing.Point(15, 58);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(603, 27);
            this.txt_Buscar.TabIndex = 3;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // Frm_Filtro_Paciente_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 319);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Filtro_Paciente_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Pacientes";
            this.Load += new System.EventHandler(this.Frm_Filtro_Paciente_Pedido_Load);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView grdDatos;
        private Controles.ucAseguradora sel_Aseguradora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
    }
}