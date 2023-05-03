namespace ProbeMedic
{
    partial class Forma_Asigna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Asigna));
            this.pnlAbajo = new System.Windows.Forms.Panel();
            this.pnlDerecha = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDisponibles = new System.Windows.Forms.Panel();
            this.lbDisponibles = new System.Windows.Forms.ListBox();
            this.cbxTodosDisponibles = new System.Windows.Forms.CheckBox();
            this.txtBuscaDisponibles = new System.Windows.Forms.TextBox();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlSeleccionados = new System.Windows.Forms.Panel();
            this.lbSeleccionados = new System.Windows.Forms.ListBox();
            this.cbxTodosSeleccionados = new System.Windows.Forms.CheckBox();
            this.txtBuscaSeleccionados = new System.Windows.Forms.TextBox();
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.pnlIzquierda = new System.Windows.Forms.Panel();
            this.twEmpresas = new System.Windows.Forms.TreeView();
            this.txtBuscaOpciones = new System.Windows.Forms.TextBox();
            this.lblTituloArbol = new System.Windows.Forms.Label();
            this.pnlArriba = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.pnlAbajo.SuspendLayout();
            this.pnlDerecha.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDisponibles.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlSeleccionados.SuspendLayout();
            this.pnlIzquierda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAbajo
            // 
            this.pnlAbajo.Controls.Add(this.pnlDerecha);
            this.pnlAbajo.Controls.Add(this.pnlIzquierda);
            this.pnlAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbajo.Location = new System.Drawing.Point(0, 79);
            this.pnlAbajo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAbajo.Name = "pnlAbajo";
            this.pnlAbajo.Size = new System.Drawing.Size(999, 428);
            this.pnlAbajo.TabIndex = 10;
            // 
            // pnlDerecha
            // 
            this.pnlDerecha.Controls.Add(this.tableLayoutPanel1);
            this.pnlDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecha.Location = new System.Drawing.Point(199, 0);
            this.pnlDerecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDerecha.Name = "pnlDerecha";
            this.pnlDerecha.Size = new System.Drawing.Size(800, 428);
            this.pnlDerecha.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDisponibles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBotones, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSeleccionados, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlDisponibles
            // 
            this.pnlDisponibles.Controls.Add(this.lbDisponibles);
            this.pnlDisponibles.Controls.Add(this.cbxTodosDisponibles);
            this.pnlDisponibles.Controls.Add(this.txtBuscaDisponibles);
            this.pnlDisponibles.Controls.Add(this.lblDisponibles);
            this.pnlDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisponibles.Location = new System.Drawing.Point(3, 3);
            this.pnlDisponibles.Name = "pnlDisponibles";
            this.pnlDisponibles.Size = new System.Drawing.Size(339, 422);
            this.pnlDisponibles.TabIndex = 0;
            // 
            // lbDisponibles
            // 
            this.lbDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDisponibles.FormattingEnabled = true;
            this.lbDisponibles.ItemHeight = 16;
            this.lbDisponibles.Location = new System.Drawing.Point(0, 68);
            this.lbDisponibles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbDisponibles.Name = "lbDisponibles";
            this.lbDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDisponibles.Size = new System.Drawing.Size(339, 354);
            this.lbDisponibles.TabIndex = 10;
            this.lbDisponibles.SelectedIndexChanged += new System.EventHandler(this.lbDisponibles_SelectedIndexChanged);
            // 
            // cbxTodosDisponibles
            // 
            this.cbxTodosDisponibles.AutoSize = true;
            this.cbxTodosDisponibles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxTodosDisponibles.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTodosDisponibles.ForeColor = System.Drawing.Color.Blue;
            this.cbxTodosDisponibles.Location = new System.Drawing.Point(0, 51);
            this.cbxTodosDisponibles.Name = "cbxTodosDisponibles";
            this.cbxTodosDisponibles.Size = new System.Drawing.Size(339, 17);
            this.cbxTodosDisponibles.TabIndex = 9;
            this.cbxTodosDisponibles.Text = "Seleccionar Todos";
            this.cbxTodosDisponibles.UseVisualStyleBackColor = true;
            this.cbxTodosDisponibles.CheckedChanged += new System.EventHandler(this.cbxTodosDisponibles_CheckedChanged);
            // 
            // txtBuscaDisponibles
            // 
            this.txtBuscaDisponibles.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBuscaDisponibles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaDisponibles.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscaDisponibles.Location = new System.Drawing.Point(0, 27);
            this.txtBuscaDisponibles.Name = "txtBuscaDisponibles";
            this.txtBuscaDisponibles.Size = new System.Drawing.Size(339, 24);
            this.txtBuscaDisponibles.TabIndex = 8;
            this.txtBuscaDisponibles.TextChanged += new System.EventHandler(this.txtBuscaDisponibles_TextChanged);
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisponibles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisponibles.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblDisponibles.Location = new System.Drawing.Point(0, 0);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(339, 27);
            this.lblDisponibles.TabIndex = 7;
            this.lblDisponibles.Text = "Disponibles";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnQuitarTodo);
            this.pnlBotones.Controls.Add(this.btnQuitar);
            this.pnlBotones.Controls.Add(this.btnAgregarTodo);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(348, 3);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(37, 422);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnQuitarTodo
            // 
            this.btnQuitarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuitarTodo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnQuitarTodo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnQuitarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarTodo.Image")));
            this.btnQuitarTodo.Location = new System.Drawing.Point(3, 202);
            this.btnQuitarTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(31, 28);
            this.btnQuitarTodo.TabIndex = 7;
            this.btnQuitarTodo.UseVisualStyleBackColor = true;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuitar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(3, 166);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(31, 28);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarTodo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAgregarTodo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(3, 128);
            this.btnAgregarTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(31, 28);
            this.btnAgregarTodo.TabIndex = 5;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(3, 92);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlSeleccionados
            // 
            this.pnlSeleccionados.Controls.Add(this.lbSeleccionados);
            this.pnlSeleccionados.Controls.Add(this.cbxTodosSeleccionados);
            this.pnlSeleccionados.Controls.Add(this.txtBuscaSeleccionados);
            this.pnlSeleccionados.Controls.Add(this.lblSeleccionados);
            this.pnlSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeleccionados.Location = new System.Drawing.Point(391, 3);
            this.pnlSeleccionados.Name = "pnlSeleccionados";
            this.pnlSeleccionados.Size = new System.Drawing.Size(406, 422);
            this.pnlSeleccionados.TabIndex = 2;
            // 
            // lbSeleccionados
            // 
            this.lbSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSeleccionados.FormattingEnabled = true;
            this.lbSeleccionados.ItemHeight = 16;
            this.lbSeleccionados.Location = new System.Drawing.Point(0, 68);
            this.lbSeleccionados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbSeleccionados.Name = "lbSeleccionados";
            this.lbSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSeleccionados.Size = new System.Drawing.Size(406, 354);
            this.lbSeleccionados.TabIndex = 11;
            this.lbSeleccionados.SelectedIndexChanged += new System.EventHandler(this.lbSeleccionados_SelectedIndexChanged);
            // 
            // cbxTodosSeleccionados
            // 
            this.cbxTodosSeleccionados.AutoSize = true;
            this.cbxTodosSeleccionados.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxTodosSeleccionados.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTodosSeleccionados.ForeColor = System.Drawing.Color.Blue;
            this.cbxTodosSeleccionados.Location = new System.Drawing.Point(0, 51);
            this.cbxTodosSeleccionados.Name = "cbxTodosSeleccionados";
            this.cbxTodosSeleccionados.Size = new System.Drawing.Size(406, 17);
            this.cbxTodosSeleccionados.TabIndex = 10;
            this.cbxTodosSeleccionados.Text = "Seleccionar Todos";
            this.cbxTodosSeleccionados.UseVisualStyleBackColor = true;
            this.cbxTodosSeleccionados.CheckedChanged += new System.EventHandler(this.cbxTodosSeleccionados_CheckedChanged);
            // 
            // txtBuscaSeleccionados
            // 
            this.txtBuscaSeleccionados.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBuscaSeleccionados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaSeleccionados.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscaSeleccionados.Location = new System.Drawing.Point(0, 27);
            this.txtBuscaSeleccionados.Name = "txtBuscaSeleccionados";
            this.txtBuscaSeleccionados.Size = new System.Drawing.Size(406, 24);
            this.txtBuscaSeleccionados.TabIndex = 9;
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeleccionados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeleccionados.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionados.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionados.Location = new System.Drawing.Point(0, 0);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(406, 27);
            this.lblSeleccionados.TabIndex = 8;
            this.lblSeleccionados.Text = "Seleccionados";
            // 
            // pnlIzquierda
            // 
            this.pnlIzquierda.BackColor = System.Drawing.Color.White;
            this.pnlIzquierda.Controls.Add(this.twEmpresas);
            this.pnlIzquierda.Controls.Add(this.txtBuscaOpciones);
            this.pnlIzquierda.Controls.Add(this.lblTituloArbol);
            this.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlIzquierda.Name = "pnlIzquierda";
            this.pnlIzquierda.Size = new System.Drawing.Size(199, 428);
            this.pnlIzquierda.TabIndex = 4;
            // 
            // twEmpresas
            // 
            this.twEmpresas.BackColor = System.Drawing.SystemColors.Control;
            this.twEmpresas.Location = new System.Drawing.Point(0, 51);
            this.twEmpresas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.twEmpresas.Name = "twEmpresas";
            this.twEmpresas.Size = new System.Drawing.Size(199, 377);
            this.twEmpresas.TabIndex = 5;
            // 
            // txtBuscaOpciones
            // 
            this.txtBuscaOpciones.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBuscaOpciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscaOpciones.Location = new System.Drawing.Point(0, 27);
            this.txtBuscaOpciones.Name = "txtBuscaOpciones";
            this.txtBuscaOpciones.Size = new System.Drawing.Size(199, 24);
            this.txtBuscaOpciones.TabIndex = 4;
            this.txtBuscaOpciones.TextChanged += new System.EventHandler(this.txtBuscaOpciones_TextChanged);
            // 
            // lblTituloArbol
            // 
            this.lblTituloArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTituloArbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTituloArbol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloArbol.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArbol.ForeColor = System.Drawing.Color.White;
            this.lblTituloArbol.Location = new System.Drawing.Point(0, 0);
            this.lblTituloArbol.Name = "lblTituloArbol";
            this.lblTituloArbol.Size = new System.Drawing.Size(199, 27);
            this.lblTituloArbol.TabIndex = 2;
            this.lblTituloArbol.Text = "OPCIONES";
            // 
            // pnlArriba
            // 
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 38);
            this.pnlArriba.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(999, 41);
            this.pnlArriba.TabIndex = 9;
            this.pnlArriba.Visible = false;
            // 
            // Forma_Asigna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 546);
            this.Controls.Add(this.pnlAbajo);
            this.Controls.Add(this.pnlArriba);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Forma_Asigna";
            this.Text = "Forma_Asigna";
            this.Load += new System.EventHandler(this.Forma_Asigna_Load);
            this.Controls.SetChildIndex(this.pnlArriba, 0);
            this.Controls.SetChildIndex(this.pnlAbajo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.pnlAbajo.ResumeLayout(false);
            this.pnlDerecha.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlDisponibles.ResumeLayout(false);
            this.pnlDisponibles.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlSeleccionados.ResumeLayout(false);
            this.pnlSeleccionados.PerformLayout();
            this.pnlIzquierda.ResumeLayout(false);
            this.pnlIzquierda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAbajo;
        private System.Windows.Forms.Panel pnlDerecha;
        private System.Windows.Forms.Panel pnlIzquierda;
        private System.Windows.Forms.TreeView twEmpresas;
        private System.Windows.Forms.TextBox txtBuscaOpciones;
        private System.Windows.Forms.Label lblTituloArbol;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlDisponibles;
        private System.Windows.Forms.ListBox lbDisponibles;
        private System.Windows.Forms.CheckBox cbxTodosDisponibles;
        private System.Windows.Forms.TextBox txtBuscaDisponibles;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnQuitarTodo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlSeleccionados;
        private System.Windows.Forms.ListBox lbSeleccionados;
        private System.Windows.Forms.CheckBox cbxTodosSeleccionados;
        private System.Windows.Forms.TextBox txtBuscaSeleccionados;
        private System.Windows.Forms.Label lblSeleccionados;
    }
}