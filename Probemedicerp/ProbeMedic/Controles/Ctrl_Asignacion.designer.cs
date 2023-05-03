namespace ProbeMedic.Controles
{
    partial class Ctrl_Asignacion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_Disponible = new System.Windows.Forms.ListBox();
            this.lst_Asignado = new System.Windows.Forms.ListBox();
            this.iDer = new System.Windows.Forms.Button();
            this.tDer = new System.Windows.Forms.Button();
            this.iLeft = new System.Windows.Forms.Button();
            this.tLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_Disponible
            // 
            this.lst_Disponible.FormattingEnabled = true;
            this.lst_Disponible.ItemHeight = 16;
            this.lst_Disponible.Location = new System.Drawing.Point(420, 43);
            this.lst_Disponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Disponible.Name = "lst_Disponible";
            this.lst_Disponible.Size = new System.Drawing.Size(329, 356);
            this.lst_Disponible.TabIndex = 0;
            // 
            // lst_Asignado
            // 
            this.lst_Asignado.FormattingEnabled = true;
            this.lst_Asignado.ItemHeight = 16;
            this.lst_Asignado.Location = new System.Drawing.Point(7, 43);
            this.lst_Asignado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Asignado.Name = "lst_Asignado";
            this.lst_Asignado.Size = new System.Drawing.Size(338, 356);
            this.lst_Asignado.TabIndex = 1;
            // 
            // iDer
            // 
            this.iDer.Location = new System.Drawing.Point(360, 278);
            this.iDer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iDer.Name = "iDer";
            this.iDer.Size = new System.Drawing.Size(41, 38);
            this.iDer.TabIndex = 2;
            this.iDer.Text = ">";
            this.iDer.UseVisualStyleBackColor = true;
            this.iDer.Click += new System.EventHandler(this.iDer_Click);
            // 
            // tDer
            // 
            this.tDer.Location = new System.Drawing.Point(360, 229);
            this.tDer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tDer.Name = "tDer";
            this.tDer.Size = new System.Drawing.Size(41, 38);
            this.tDer.TabIndex = 3;
            this.tDer.Text = ">>";
            this.tDer.UseVisualStyleBackColor = true;
            this.tDer.Click += new System.EventHandler(this.tDer_Click);
            // 
            // iLeft
            // 
            this.iLeft.Location = new System.Drawing.Point(360, 135);
            this.iLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iLeft.Name = "iLeft";
            this.iLeft.Size = new System.Drawing.Size(41, 38);
            this.iLeft.TabIndex = 4;
            this.iLeft.Text = "<";
            this.iLeft.UseVisualStyleBackColor = true;
            this.iLeft.Click += new System.EventHandler(this.iLeft_Click);
            // 
            // tLeft
            // 
            this.tLeft.Location = new System.Drawing.Point(360, 181);
            this.tLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tLeft.Name = "tLeft";
            this.tLeft.Size = new System.Drawing.Size(41, 38);
            this.tLeft.TabIndex = 5;
            this.tLeft.Text = "<<";
            this.tLeft.UseVisualStyleBackColor = true;
            this.tLeft.Click += new System.EventHandler(this.tLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asignados";
            // 
            // Ctrl_Asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tLeft);
            this.Controls.Add(this.iLeft);
            this.Controls.Add(this.tDer);
            this.Controls.Add(this.iDer);
            this.Controls.Add(this.lst_Asignado);
            this.Controls.Add(this.lst_Disponible);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ctrl_Asignacion";
            this.Size = new System.Drawing.Size(757, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Disponible;
        private System.Windows.Forms.ListBox lst_Asignado;
        private System.Windows.Forms.Button iDer;
        private System.Windows.Forms.Button tDer;
        private System.Windows.Forms.Button iLeft;
        private System.Windows.Forms.Button tLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
