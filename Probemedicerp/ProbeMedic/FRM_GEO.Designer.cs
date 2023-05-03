namespace ProbeMedic
{
    partial class FRM_GEO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_GEO));
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.tbZoom);
            this.pnlDatos.Controls.Add(this.btnAceptar);
            this.pnlDatos.Controls.Add(this.btnRelieve);
            this.pnlDatos.Controls.Add(this.btnNormal);
            this.pnlDatos.Controls.Add(this.btnSatelite);
            this.pnlDatos.Controls.Add(this.btnLimpiar);
            this.pnlDatos.Controls.Add(this.btnBuscar);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.txtLongitud);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.txtLatitud);
            this.pnlDatos.Controls.Add(this.txtDireccion);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(988, 119);
            this.pnlDatos.TabIndex = 0;
            this.pnlDatos.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Zoom";
            // 
            // tbZoom
            // 
            this.tbZoom.Location = new System.Drawing.Point(398, 52);
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(254, 45);
            this.tbZoom.TabIndex = 53;
            this.tbZoom.ValueChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(878, 10);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 35);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRelieve
            // 
            this.btnRelieve.Location = new System.Drawing.Point(878, 73);
            this.btnRelieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(91, 35);
            this.btnRelieve.TabIndex = 6;
            this.btnRelieve.Text = "Relieve";
            this.btnRelieve.UseVisualStyleBackColor = true;
            this.btnRelieve.Click += new System.EventHandler(this.btnRelieve_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(671, 73);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(91, 35);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnSatelite
            // 
            this.btnSatelite.Location = new System.Drawing.Point(771, 73);
            this.btnSatelite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(91, 35);
            this.btnSatelite.TabIndex = 5;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(772, 10);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar \r\n";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(671, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dirección:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(100, 84);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.Size = new System.Drawing.Size(211, 24);
            this.txtLongitud.TabIndex = 50;
            this.txtLongitud.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Longitud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Latitud:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(100, 49);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.ReadOnly = true;
            this.txtLatitud.Size = new System.Drawing.Size(211, 24);
            this.txtLatitud.TabIndex = 51;
            this.txtLatitud.TabStop = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(100, 15);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(545, 24);
            this.txtDireccion.TabIndex = 0;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(988, 379);
            this.gMapControl1.TabIndex = 4;
            this.gMapControl1.TabStop = false;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gMapControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 389);
            this.panel1.TabIndex = 53;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_GEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FRM_GEO";
            this.Text = "Geolocalización";
            this.Load += new System.EventHandler(this.FRM_GEO_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Button btnAceptar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}