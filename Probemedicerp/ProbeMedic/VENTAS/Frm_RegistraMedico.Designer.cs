namespace ProbeMedic.VENTAS
{
    partial class Frm_RegistraMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistraMedico));
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(334, 142);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(177, 27);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(90, 139);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(226, 27);
            this.txtCedula.TabIndex = 3;
            // 
            // txtApeMat
            // 
            this.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMat.Location = new System.Drawing.Point(593, 89);
            this.txtApeMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(226, 27);
            this.txtApeMat.TabIndex = 2;
            // 
            // txtApePat
            // 
            this.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePat.Location = new System.Drawing.Point(338, 89);
            this.txtApePat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(233, 27);
            this.txtApePat.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(90, 89);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(226, 27);
            this.txtNom.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 94;
            this.label12.Text = "Nombre(s) Médico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(338, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 93;
            this.label11.Text = "Apellido Paterno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(593, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 92;
            this.label10.Text = "Apellido Materno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 91;
            this.label9.Text = "Cédula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 90;
            this.label6.Text = "Telefono";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(698, 124);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 40);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "F8 Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(576, 126);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(110, 40);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar F7";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Frm_RegistraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 238);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Frm_RegistraMedico";
            this.Text = "REGISTRA MEDICO";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_RegistraMedico_KeyUp);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.txtApePat, 0);
            this.Controls.SetChildIndex(this.txtApeMat, 0);
            this.Controls.SetChildIndex(this.txtCedula, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.BtnGuardar, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
    }
}