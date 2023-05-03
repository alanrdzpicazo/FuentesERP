namespace ProbeMedic.VENTAS
{
    partial class Frm_Inventario_Tarjetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Arriba = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Final = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Inicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pnl_General = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dgv_Datos = new System.Windows.Forms.DataGridView();
            this.No_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.F_Captura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Tarjeta_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Asignada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Asignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Usuario_Aplica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Aplicar = new System.Windows.Forms.Button();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Entrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).BeginInit();
            this.Pnl_Arriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pnl_General.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Datos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Arriba
            // 
            this.Pnl_Arriba.Controls.Add(this.panel1);
            this.Pnl_Arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Arriba.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Arriba.Name = "Pnl_Arriba";
            this.Pnl_Arriba.Size = new System.Drawing.Size(669, 77);
            this.Pnl_Arriba.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CbxAlmacen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 75);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.Txt_Final);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Txt_Inicial);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 37);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // Txt_Final
            // 
            this.Txt_Final.Location = new System.Drawing.Point(469, 6);
            this.Txt_Final.MaxLength = 16;
            this.Txt_Final.Name = "Txt_Final";
            this.Txt_Final.Size = new System.Drawing.Size(123, 24);
            this.Txt_Final.TabIndex = 4;
            this.Txt_Final.TextChanged += new System.EventHandler(this.Txt_Final_TextChanged);
            this.Txt_Final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Final_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. Tarjeta Final";
            // 
            // Txt_Inicial
            // 
            this.Txt_Inicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Inicial.Location = new System.Drawing.Point(164, 6);
            this.Txt_Inicial.MaxLength = 16;
            this.Txt_Inicial.Name = "Txt_Inicial";
            this.Txt_Inicial.Size = new System.Drawing.Size(123, 24);
            this.Txt_Inicial.TabIndex = 3;
            this.Txt_Inicial.TextChanged += new System.EventHandler(this.Txt_Inicial_TextChanged);
            this.Txt_Inicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Inicial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Tarjeta Inicial";
            // 
            // CbxAlmacen
            // 
            this.CbxAlmacen.FormattingEnabled = true;
            this.CbxAlmacen.Location = new System.Drawing.Point(164, 7);
            this.CbxAlmacen.Name = "CbxAlmacen";
            this.CbxAlmacen.Size = new System.Drawing.Size(209, 24);
            this.CbxAlmacen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Almacen";
            // 
            // Pnl_General
            // 
            this.Pnl_General.Controls.Add(this.tableLayoutPanel1);
            this.Pnl_General.Controls.Add(this.Pnl_Arriba);
            this.Pnl_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_General.Location = new System.Drawing.Point(0, 38);
            this.Pnl_General.Name = "Pnl_General";
            this.Pnl_General.Size = new System.Drawing.Size(669, 373);
            this.Pnl_General.TabIndex = 0;
            this.Pnl_General.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.22544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.77456F));
            this.tableLayoutPanel1.Controls.Add(this.Dgv_Datos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 296);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Dgv_Datos
            // 
            this.Dgv_Datos.AllowUserToAddRows = false;
            this.Dgv_Datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_Tarjeta,
            this.B_Activa,
            this.F_Captura,
            this.K_Tarjeta_Inventario,
            this.K_Almacen,
            this.D_Almacen,
            this.B_Asignada,
            this.F_Asignacion,
            this.F_Cancelacion,
            this.K_Usuario_Aplica});
            this.Dgv_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Datos.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Datos.MultiSelect = false;
            this.Dgv_Datos.Name = "Dgv_Datos";
            this.Dgv_Datos.RowHeadersWidth = 25;
            this.Dgv_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Datos.Size = new System.Drawing.Size(396, 290);
            this.Dgv_Datos.TabIndex = 33;
            this.Dgv_Datos.TabStop = false;
            // 
            // No_Tarjeta
            // 
            this.No_Tarjeta.DataPropertyName = "No_Tarjeta";
            dataGridViewCellStyle2.NullValue = null;
            this.No_Tarjeta.DefaultCellStyle = dataGridViewCellStyle2;
            this.No_Tarjeta.HeaderText = "No. Tarjeta";
            this.No_Tarjeta.Name = "No_Tarjeta";
            this.No_Tarjeta.ReadOnly = true;
            this.No_Tarjeta.Width = 130;
            // 
            // B_Activa
            // 
            this.B_Activa.DataPropertyName = "B_Activa";
            this.B_Activa.HeaderText = "Disponible";
            this.B_Activa.Name = "B_Activa";
            this.B_Activa.ReadOnly = true;
            this.B_Activa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.B_Activa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.B_Activa.Width = 70;
            // 
            // F_Captura
            // 
            this.F_Captura.DataPropertyName = "F_Captura";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.F_Captura.DefaultCellStyle = dataGridViewCellStyle3;
            this.F_Captura.HeaderText = "Fecha Captura";
            this.F_Captura.Name = "F_Captura";
            this.F_Captura.ReadOnly = true;
            this.F_Captura.Width = 150;
            // 
            // K_Tarjeta_Inventario
            // 
            this.K_Tarjeta_Inventario.DataPropertyName = "K_Tarjeta_Inventario";
            this.K_Tarjeta_Inventario.HeaderText = "K_Tarjeta_Inventario";
            this.K_Tarjeta_Inventario.Name = "K_Tarjeta_Inventario";
            this.K_Tarjeta_Inventario.Visible = false;
            // 
            // K_Almacen
            // 
            this.K_Almacen.DataPropertyName = "K_Almacen";
            this.K_Almacen.HeaderText = "K_Almacen";
            this.K_Almacen.Name = "K_Almacen";
            this.K_Almacen.Visible = false;
            // 
            // D_Almacen
            // 
            this.D_Almacen.DataPropertyName = "D_Almacen";
            this.D_Almacen.HeaderText = "D_Almacen";
            this.D_Almacen.Name = "D_Almacen";
            this.D_Almacen.Visible = false;
            // 
            // B_Asignada
            // 
            this.B_Asignada.DataPropertyName = "B_Asignada";
            this.B_Asignada.HeaderText = "B_Asignada";
            this.B_Asignada.Name = "B_Asignada";
            this.B_Asignada.Visible = false;
            // 
            // F_Asignacion
            // 
            this.F_Asignacion.DataPropertyName = "F_Asignacion";
            this.F_Asignacion.HeaderText = "F_Asignacion";
            this.F_Asignacion.Name = "F_Asignacion";
            this.F_Asignacion.Visible = false;
            // 
            // F_Cancelacion
            // 
            this.F_Cancelacion.DataPropertyName = "F_Cancelacion";
            this.F_Cancelacion.HeaderText = "F_Cancelacion";
            this.F_Cancelacion.Name = "F_Cancelacion";
            this.F_Cancelacion.Visible = false;
            // 
            // K_Usuario_Aplica
            // 
            this.K_Usuario_Aplica.DataPropertyName = "K_Usuario_Aplica";
            this.K_Usuario_Aplica.HeaderText = "K_Usuario_Aplica";
            this.K_Usuario_Aplica.Name = "K_Usuario_Aplica";
            this.K_Usuario_Aplica.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Aplicar);
            this.panel3.Controls.Add(this.Btn_Consulta);
            this.panel3.Controls.Add(this.Btn_Eliminar);
            this.panel3.Controls.Add(this.Btn_Salir);
            this.panel3.Controls.Add(this.Btn_Entrada);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(405, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 290);
            this.panel3.TabIndex = 5;
            this.panel3.TabStop = true;
            // 
            // Btn_Aplicar
            // 
            this.Btn_Aplicar.Location = new System.Drawing.Point(15, 76);
            this.Btn_Aplicar.Name = "Btn_Aplicar";
            this.Btn_Aplicar.Size = new System.Drawing.Size(100, 23);
            this.Btn_Aplicar.TabIndex = 10;
            this.Btn_Aplicar.Text = "Aplicar";
            this.Btn_Aplicar.UseVisualStyleBackColor = true;
            this.Btn_Aplicar.Click += new System.EventHandler(this.Btn_Aplicar_Click);
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.Location = new System.Drawing.Point(15, 47);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(100, 23);
            this.Btn_Consulta.TabIndex = 7;
            this.Btn_Consulta.Text = "Consultar";
            this.Btn_Consulta.UseVisualStyleBackColor = true;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_Consulta_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(129, 47);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 23);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.Text = "Borrar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(129, 76);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(100, 23);
            this.Btn_Salir.TabIndex = 9;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Entrada
            // 
            this.Btn_Entrada.Location = new System.Drawing.Point(15, 16);
            this.Btn_Entrada.Name = "Btn_Entrada";
            this.Btn_Entrada.Size = new System.Drawing.Size(218, 23);
            this.Btn_Entrada.TabIndex = 6;
            this.Btn_Entrada.Text = "ENTRADA TARJETAS";
            this.Btn_Entrada.UseVisualStyleBackColor = true;
            this.Btn_Entrada.Click += new System.EventHandler(this.Btn_Entrada_Click);
            // 
            // Frm_Inventario_Tarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.Pnl_General);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Inventario_Tarjetas";
            this.Text = "INVENTARIO DE TARJETAS";
            this.Controls.SetChildIndex(this.Pnl_General, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasedtDatosConFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDtPermisos)).EndInit();
            this.Pnl_Arriba.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_General.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Datos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Arriba;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_General;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CbxAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Datos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Tarjeta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn B_Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Captura;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Tarjeta_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Asignada;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Asignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Usuario_Aplica;
        private System.Windows.Forms.Button Btn_Aplicar;
    }
}