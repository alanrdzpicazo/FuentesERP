namespace ProbeMedic.VENTAS
{
    partial class Frm_DatosCancelacionOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DatosCancelacionOC));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_motivo_cancelacion_compra1 = new ProbeMedic.Controles.cbx_motivo_cancelacion_compra();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.txtCancelacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_motivo_cancelacion_compra1);
            this.groupBox1.Controls.Add(this.chkActivar);
            this.groupBox1.Controls.Add(this.txtCancelacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbx_motivo_cancelacion_compra1
            // 
            this.cbx_motivo_cancelacion_compra1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_motivo_cancelacion_compra1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_motivo_cancelacion_compra1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_motivo_cancelacion_compra1.FormattingEnabled = true;
            resources.ApplyResources(this.cbx_motivo_cancelacion_compra1, "cbx_motivo_cancelacion_compra1");
            this.cbx_motivo_cancelacion_compra1.Name = "cbx_motivo_cancelacion_compra1";
            // 
            // chkActivar
            // 
            resources.ApplyResources(this.chkActivar, "chkActivar");
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.UseVisualStyleBackColor = true;
            // 
            // txtCancelacion
            // 
            this.txtCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtCancelacion, "txtCancelacion");
            this.txtCancelacion.Name = "txtCancelacion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_DatosCancelacionOC
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DatosCancelacionOC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.TextBox txtCancelacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private Controles.cbx_motivo_cancelacion_compra cbx_motivo_cancelacion_compra1;
    }
}