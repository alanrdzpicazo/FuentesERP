namespace ProbeMedic.FILTROS
{
    partial class Frm_Filtra_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filtra_Paciente));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucAseguradora1 = new ProbeMedic.Controles.ucAseguradora();
            this.ucEstadoCivil1 = new ProbeMedic.Controles.ucEstadoCivil();
            this.ucGeneros1 = new ProbeMedic.Controles.ucGeneros();
            this.ucNacionalidad1 = new ProbeMedic.Controles.ucNacionalidad();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ucTipoSangre1 = new ProbeMedic.Controles.ucTipoSangre();
            this.label9 = new System.Windows.Forms.Label();
            this.ucTPacientes1 = new ProbeMedic.Controles.ucTPacientes();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoEllipsis = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(257, 331);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(149, 41);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "&Buscar [F11]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nombre.Location = new System.Drawing.Point(141, 73);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(230, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 138;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "Aseguradora";
            // 
            // ucAseguradora1
            // 
            this.ucAseguradora1.K_Aseguradora = 0;
            this.ucAseguradora1.Location = new System.Drawing.Point(137, 103);
            this.ucAseguradora1.Name = "ucAseguradora1";
            this.ucAseguradora1.Size = new System.Drawing.Size(326, 31);
            this.ucAseguradora1.TabIndex = 2;
            // 
            // ucEstadoCivil1
            // 
            this.ucEstadoCivil1.Location = new System.Drawing.Point(139, 282);
            this.ucEstadoCivil1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucEstadoCivil1.Name = "ucEstadoCivil1";
            this.ucEstadoCivil1.Size = new System.Drawing.Size(275, 34);
            this.ucEstadoCivil1.TabIndex = 7;
            // 
            // ucGeneros1
            // 
            this.ucGeneros1.Location = new System.Drawing.Point(139, 245);
            this.ucGeneros1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucGeneros1.Name = "ucGeneros1";
            this.ucGeneros1.Size = new System.Drawing.Size(265, 33);
            this.ucGeneros1.TabIndex = 6;
            // 
            // ucNacionalidad1
            // 
            this.ucNacionalidad1.Location = new System.Drawing.Point(138, 209);
            this.ucNacionalidad1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucNacionalidad1.Name = "ucNacionalidad1";
            this.ucNacionalidad1.Size = new System.Drawing.Size(265, 34);
            this.ucNacionalidad1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 150;
            this.label7.Text = "Tipo Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 149;
            this.label2.Text = "Estado Cívil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 148;
            this.label4.Text = "Nacionalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 147;
            this.label8.Text = "Tipo de Sangre";
            // 
            // ucTipoSangre1
            // 
            this.ucTipoSangre1.Location = new System.Drawing.Point(138, 173);
            this.ucTipoSangre1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.ucTipoSangre1.Name = "ucTipoSangre1";
            this.ucTipoSangre1.Size = new System.Drawing.Size(265, 35);
            this.ucTipoSangre1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 146;
            this.label9.Text = "Género";
            // 
            // ucTPacientes1
            // 
            this.ucTPacientes1.Location = new System.Drawing.Point(138, 137);
            this.ucTPacientes1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.ucTPacientes1.Name = "ucTPacientes1";
            this.ucTPacientes1.Size = new System.Drawing.Size(268, 34);
            this.ucTPacientes1.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Location = new System.Drawing.Point(142, 42);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(119, 23);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 152;
            this.label5.Text = "Clave";
            // 
            // Frm_Filtra_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 410);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ucTPacientes1);
            this.Controls.Add(this.ucEstadoCivil1);
            this.Controls.Add(this.ucGeneros1);
            this.Controls.Add(this.ucNacionalidad1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucTipoSangre1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ucAseguradora1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Frm_Filtra_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Paciente...";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Filtra_Paciente_KeyDown);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_Nombre, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.Controls.SetChildIndex(this.ucAseguradora1, 0);
            this.Controls.SetChildIndex(this.Entrar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.ucTipoSangre1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.ucNacionalidad1, 0);
            this.Controls.SetChildIndex(this.ucGeneros1, 0);
            this.Controls.SetChildIndex(this.ucEstadoCivil1, 0);
            this.Controls.SetChildIndex(this.ucTPacientes1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Entrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Controles.ucAseguradora ucAseguradora1;
        private Controles.ucEstadoCivil ucEstadoCivil1;
        private Controles.ucGeneros ucGeneros1;
        private Controles.ucNacionalidad ucNacionalidad1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Controles.ucTipoSangre ucTipoSangre1;
        private System.Windows.Forms.Label label9;
        private Controles.ucTPacientes ucTPacientes1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label5;
    }
}