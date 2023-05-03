namespace ProbeMedic
{
    partial class FormaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnEtiqueta = new System.Windows.Forms.ToolStripButton();
            this.BarraEstatus = new System.Windows.Forms.StatusStrip();
            this.lblRefrescar = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEspaciosEnBlanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnAfectar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnReporte = new System.Windows.Forms.ToolStripButton();
            this.btnEscanear = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnProceso1 = new System.Windows.Forms.ToolStripButton();
            this.btnProceso3 = new System.Windows.Forms.ToolStripButton();
            this.btnCorreo = new System.Windows.Forms.ToolStripButton();
            this.btnProceso2 = new System.Windows.Forms.ToolStripButton();
            this.btnProceso4 = new System.Windows.Forms.ToolStripButton();
            this.btnProceso5 = new System.Windows.Forms.ToolStripButton();
            this.btnProceso6 = new System.Windows.Forms.ToolStripButton();
            this.btnProceso7 = new System.Windows.Forms.ToolStripButton();
            this.btnImpresora = new System.Windows.Forms.ToolStripButton();
            this.BarraHerramientas.SuspendLayout();
            this.BarraEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnNuevo,
            this.btnModificar,
            this.btnCancelar,
            this.btnBorrar,
            this.btnGuardar,
            this.btnAfectar,
            this.btnBuscar,
            this.btnReporte,
            this.btnEscanear,
            this.btnExcel,
            this.btnProceso1,
            this.btnProceso3,
            this.btnCorreo,
            this.btnProceso2,
            this.btnProceso4,
            this.btnProceso5,
            this.btnProceso6,
            this.btnProceso7,
            this.btnEtiqueta,
            this.btnImpresora});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(822, 38);
            this.BarraHerramientas.TabIndex = 0;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // btnEtiqueta
            // 
            this.btnEtiqueta.AutoSize = false;
            this.btnEtiqueta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEtiqueta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(80, 35);
            this.btnEtiqueta.Text = "&Etiqueta";
            this.btnEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEtiqueta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEtiqueta.Visible = false;
            this.btnEtiqueta.Click += new System.EventHandler(this.btnEtiqueta_Click);
            // 
            // BarraEstatus
            // 
            this.BarraEstatus.AutoSize = false;
            this.BarraEstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.BarraEstatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraEstatus.BackgroundImage")));
            this.BarraEstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarraEstatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraEstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRefrescar,
            this.lblEspaciosEnBlanco,
            this.lblEstatus});
            this.BarraEstatus.Location = new System.Drawing.Point(0, 507);
            this.BarraEstatus.Name = "BarraEstatus";
            this.BarraEstatus.Size = new System.Drawing.Size(822, 39);
            this.BarraEstatus.TabIndex = 1;
            this.BarraEstatus.Text = "statusStrip1";
            // 
            // lblRefrescar
            // 
            this.lblRefrescar.AutoSize = false;
            this.lblRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("lblRefrescar.Image")));
            this.lblRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblRefrescar.IsLink = true;
            this.lblRefrescar.Name = "lblRefrescar";
            this.lblRefrescar.Size = new System.Drawing.Size(40, 34);
            this.lblRefrescar.Tag = "Refrescar Información";
            this.lblRefrescar.ToolTipText = "Refrescar Información";
            this.lblRefrescar.Click += new System.EventHandler(this.lblRefrescar_Click);
            // 
            // lblEspaciosEnBlanco
            // 
            this.lblEspaciosEnBlanco.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEspaciosEnBlanco.ForeColor = System.Drawing.Color.White;
            this.lblEspaciosEnBlanco.Name = "lblEspaciosEnBlanco";
            this.lblEspaciosEnBlanco.Size = new System.Drawing.Size(36, 34);
            this.lblEspaciosEnBlanco.Text = "       ";
            // 
            // lblEstatus
            // 
            this.lblEstatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(53, 34);
            this.lblEstatus.Text = "Estatus";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.ToolTipText = "Salir de Esta Opción";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 35);
            this.btnNuevo.Text = "&Nuevo [F2]";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Nuevo Registro...";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 35);
            this.btnModificar.Text = "&Modificar [F3]";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.ToolTipText = "Modificar Registro...";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Cancelar Captura...!";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AutoSize = false;
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 35);
            this.btnBorrar.Text = "&Borrar [F4]";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.ToolTipText = "Borrar Registro...";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 35);
            this.btnGuardar.Text = "&Guardar [F5]";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.ToolTipText = "Guardar Información...";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAfectar
            // 
            this.btnAfectar.AutoSize = false;
            this.btnAfectar.BackColor = System.Drawing.Color.Transparent;
            this.btnAfectar.Image = ((System.Drawing.Image)(resources.GetObject("btnAfectar.Image")));
            this.btnAfectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAfectar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAfectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAfectar.Name = "btnAfectar";
            this.btnAfectar.Size = new System.Drawing.Size(80, 35);
            this.btnAfectar.Text = "&Afectar [F6]";
            this.btnAfectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAfectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAfectar.ToolTipText = "Aceptar Afectación de Información";
            this.btnAfectar.Click += new System.EventHandler(this.btnAfectar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 35);
            this.btnBuscar.Text = "&Buscar [F7]";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.ToolTipText = "Buscar Información";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AutoSize = false;
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(80, 35);
            this.btnReporte.Text = "&Reporte [F8]";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.ToolTipText = "Mostrar Reporte...";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnEscanear
            // 
            this.btnEscanear.AutoSize = false;
            this.btnEscanear.BackColor = System.Drawing.Color.Transparent;
            this.btnEscanear.Image = ((System.Drawing.Image)(resources.GetObject("btnEscanear.Image")));
            this.btnEscanear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEscanear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEscanear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(80, 35);
            this.btnEscanear.Text = "Esca&near";
            this.btnEscanear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEscanear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEscanear.ToolTipText = "Escanear Documento";
            this.btnEscanear.Visible = false;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AutoSize = false;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 35);
            this.btnExcel.Text = "&Excel [F9]";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcel.ToolTipText = "Enviar Información a un Archivo de Excel...";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnProceso1
            // 
            this.btnProceso1.AutoSize = false;
            this.btnProceso1.BackColor = System.Drawing.Color.Transparent;
            this.btnProceso1.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso1.Image")));
            this.btnProceso1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso1.Name = "btnProceso1";
            this.btnProceso1.Size = new System.Drawing.Size(80, 35);
            this.btnProceso1.Text = "&Detalle";
            this.btnProceso1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso1.Visible = false;
            this.btnProceso1.Click += new System.EventHandler(this.btnProceso1_Click);
            // 
            // btnProceso3
            // 
            this.btnProceso3.AutoSize = false;
            this.btnProceso3.BackColor = System.Drawing.Color.Transparent;
            this.btnProceso3.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso3.Image")));
            this.btnProceso3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso3.Name = "btnProceso3";
            this.btnProceso3.Size = new System.Drawing.Size(80, 35);
            this.btnProceso3.Text = "&Proceso 3";
            this.btnProceso3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso3.Visible = false;
            this.btnProceso3.Click += new System.EventHandler(this.btnProceso3_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.AutoSize = false;
            this.btnCorreo.BackColor = System.Drawing.Color.Transparent;
            this.btnCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnCorreo.Image")));
            this.btnCorreo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(80, 35);
            this.btnCorreo.Text = "Correo";
            this.btnCorreo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCorreo.ToolTipText = "Enviar Correo";
            this.btnCorreo.Visible = false;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // btnProceso2
            // 
            this.btnProceso2.AutoSize = false;
            this.btnProceso2.BackColor = System.Drawing.Color.Transparent;
            this.btnProceso2.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso2.Image")));
            this.btnProceso2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso2.Name = "btnProceso2";
            this.btnProceso2.Size = new System.Drawing.Size(80, 35);
            this.btnProceso2.Text = "&Proceso 2";
            this.btnProceso2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso2.Visible = false;
            this.btnProceso2.Click += new System.EventHandler(this.btnPtoceso2_Click);
            // 
            // btnProceso4
            // 
            this.btnProceso4.AutoSize = false;
            this.btnProceso4.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso4.Image")));
            this.btnProceso4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso4.Name = "btnProceso4";
            this.btnProceso4.Size = new System.Drawing.Size(80, 35);
            this.btnProceso4.Text = "&Proceso 4";
            this.btnProceso4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso4.Visible = false;
            this.btnProceso4.Click += new System.EventHandler(this.btnProceso4_Click);
            // 
            // btnProceso5
            // 
            this.btnProceso5.AutoSize = false;
            this.btnProceso5.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso5.Image")));
            this.btnProceso5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso5.Name = "btnProceso5";
            this.btnProceso5.Size = new System.Drawing.Size(80, 35);
            this.btnProceso5.Text = "&Proceso 5";
            this.btnProceso5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso5.Visible = false;
            this.btnProceso5.Click += new System.EventHandler(this.btnProceso5_Click);
            // 
            // btnProceso6
            // 
            this.btnProceso6.AutoSize = false;
            this.btnProceso6.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso6.Image")));
            this.btnProceso6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso6.Name = "btnProceso6";
            this.btnProceso6.RightToLeftAutoMirrorImage = true;
            this.btnProceso6.Size = new System.Drawing.Size(80, 35);
            this.btnProceso6.Text = "&Proceso 6";
            this.btnProceso6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso6.Visible = false;
            this.btnProceso6.Click += new System.EventHandler(this.btnProceso6_Click);
            // 
            // btnProceso7
            // 
            this.btnProceso7.AutoSize = false;
            this.btnProceso7.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso7.Image")));
            this.btnProceso7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProceso7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProceso7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProceso7.Name = "btnProceso7";
            this.btnProceso7.RightToLeftAutoMirrorImage = true;
            this.btnProceso7.Size = new System.Drawing.Size(80, 35);
            this.btnProceso7.Text = "&Proceso 7";
            this.btnProceso7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProceso7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProceso7.Visible = false;
            this.btnProceso7.Click += new System.EventHandler(this.btnProceso7_Click);
            // 
            // btnImpresora
            // 
            this.btnImpresora.AutoSize = false;
            this.btnImpresora.BackColor = System.Drawing.Color.Transparent;
            this.btnImpresora.Image = global::ProbeMedic.Properties.Resources.impresora;
            this.btnImpresora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImpresora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImpresora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(80, 35);
            this.btnImpresora.Text = "Im&presora [F9]";
            this.btnImpresora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImpresora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImpresora.Visible = false;
            this.btnImpresora.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // FormaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 546);
            this.Controls.Add(this.BarraEstatus);
            this.Controls.Add(this.BarraHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormaBase";
            this.Load += new System.EventHandler(this.FormaBase_Load);
            this.Shown += new System.EventHandler(this.FormaBase_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormaBase_KeyDown);
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.BarraEstatus.ResumeLayout(false);
            this.BarraEstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnReporte;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnAfectar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripStatusLabel lblRefrescar;
        private System.Windows.Forms.ToolStripStatusLabel lblEspaciosEnBlanco;
        private System.Windows.Forms.ToolStripButton btnProceso1;
        private System.Windows.Forms.ToolStripButton btnProceso2;
        private System.Windows.Forms.ToolStripButton btnProceso3;
        private System.Windows.Forms.ToolStripButton btnCorreo;
        private System.Windows.Forms.ToolStripButton btnEscanear;
        private System.Windows.Forms.ToolStripButton btnProceso4;
        private System.Windows.Forms.ToolStripButton btnProceso5;
        private System.Windows.Forms.ToolStripButton btnProceso6;
        private System.Windows.Forms.ToolStripButton btnProceso7;
        private System.Windows.Forms.ToolStripButton btnEtiqueta;
        public System.Windows.Forms.StatusStrip BarraEstatus;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatus;
        private System.Windows.Forms.ToolStripButton btnImpresora;
    }
}