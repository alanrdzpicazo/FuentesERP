namespace ProbeMedic.CATALOGOS.PACIENTES
{
    partial class FRM_EDITAR_PACIENTE
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
            this.PnlGeneral = new System.Windows.Forms.Panel();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreActual = new System.Windows.Forms.TextBox();
            this.txtClavePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.PnlGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGeneral
            // 
            this.PnlGeneral.Controls.Add(this.txtApePat);
            this.PnlGeneral.Controls.Add(this.txtApeMat);
            this.PnlGeneral.Controls.Add(this.txtNombre);
            this.PnlGeneral.Controls.Add(this.label5);
            this.PnlGeneral.Controls.Add(this.label4);
            this.PnlGeneral.Controls.Add(this.panel1);
            this.PnlGeneral.Controls.Add(this.label3);
            this.PnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGeneral.Location = new System.Drawing.Point(0, 38);
            this.PnlGeneral.Name = "PnlGeneral";
            this.PnlGeneral.Size = new System.Drawing.Size(608, 192);
            this.PnlGeneral.TabIndex = 1;
            this.PnlGeneral.TabStop = true;
            // 
            // txtApePat
            // 
            this.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePat.Location = new System.Drawing.Point(130, 119);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(195, 24);
            this.txtApePat.TabIndex = 3;
            // 
            // txtApeMat
            // 
            this.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMat.Location = new System.Drawing.Point(131, 151);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(195, 24);
            this.txtApeMat.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(131, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(459, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido Paterno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtNombreActual);
            this.panel1.Controls.Add(this.txtClavePaciente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 77);
            this.panel1.TabIndex = 5;
            // 
            // txtNombreActual
            // 
            this.txtNombreActual.Location = new System.Drawing.Point(132, 41);
            this.txtNombreActual.Name = "txtNombreActual";
            this.txtNombreActual.ReadOnly = true;
            this.txtNombreActual.Size = new System.Drawing.Size(459, 24);
            this.txtNombreActual.TabIndex = 8;
            this.txtNombreActual.TabStop = false;
            // 
            // txtClavePaciente
            // 
            this.txtClavePaciente.Location = new System.Drawing.Point(132, 8);
            this.txtClavePaciente.Name = "txtClavePaciente";
            this.txtClavePaciente.ReadOnly = true;
            this.txtClavePaciente.Size = new System.Drawing.Size(116, 24);
            this.txtClavePaciente.TabIndex = 7;
            this.txtClavePaciente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // FRM_EDITAR_PACIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 269);
            this.Controls.Add(this.PnlGeneral);
            this.MaximumSize = new System.Drawing.Size(624, 308);
            this.MinimumSize = new System.Drawing.Size(624, 308);
            this.Name = "FRM_EDITAR_PACIENTE";
            this.Text = "EDITAR PACIENTE";
            this.Controls.SetChildIndex(this.PnlGeneral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.PnlGeneral.ResumeLayout(false);
            this.PnlGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreActual;
        private System.Windows.Forms.TextBox txtClavePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}