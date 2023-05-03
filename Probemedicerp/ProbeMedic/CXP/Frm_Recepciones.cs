using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.AppCode.BLL;
using ProbeMedic.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProbeMedic.CXP
{
    public partial class Frm_Recepciones : FormaBase
    {
        string msg = string.Empty;
        int res = 0;

        decimal gdTasaIva = 0;
        string VersionXML = string.Empty;
        XmlDocument cfdi;
        public string PropiedadRuta { get; set; }
        public XmlDocument PropiedadXML { get; set; }
        public Comprobante PropiedadFactura { get; set; }

        Funciones fx = new Funciones();

        String strKeyPress = "";

        bool B_NoEntrar = false;
        bool blnSeleccionGrid = false;

        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        SQLCuentasxPagar sqlCXP = new SQLCuentasxPagar();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();

        DataTable dtDatos = new DataTable();
        DataTable dtNotaRecepcion = new DataTable();
        DataTable dtRecepciones = new DataTable();
        DataTable dtProveedores = new DataTable();

        RecepcionBL recepcionBL = new RecepcionBL();
        List<RecepcionFacturasProveedor> lstRecepcionesProveedor = new List<RecepcionFacturasProveedor>();
        List<RecepcionesProveedorXML> lstRecepcionesXML = new List<RecepcionesProveedorXML>();

        private int k_Nota_Recepcion;
        public int K_Nota_Recepcion { get { return k_Nota_Recepcion; } set { k_Nota_Recepcion = value; } }
        int K_Recepcion = 0;
        int KOrdenCompra = 0;
        public Frm_Recepciones()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            BaseBotonProceso2.Click += BaseBotonProceso2_Click;  //Mostrar XML     
            BaseBotonProceso3.Click += new EventHandler(BaseBotonProceso3_Click); //Nota de Recepción
            BaseBotonProceso4.Click += BaseBotonProceso4_Click;  //Nota de Recepción   
        }
        public override void BaseMetodoInicio()
        {
            grdRecepciones.AutoGenerateColumns = false;
            try
            {       
                grdDetalle.AutoGenerateColumns = false;
                grdRecepciones.AutoGenerateColumns = false;

                DateTime Fecha2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                txtFechaInicio.Value = Fecha1;
                txtFechaFin.Value = Fecha2;

                //BuscaRecepciones();

                //LlenaRecepciones();

                BaseBotonModificar.Visible = false;
                BaseBotonBorrar.Visible = false;
                BaseBotonExcel.Visible = false;

                BaseBotonAfectar.Text = "Genera Cuenta Por Pagar";
                BaseBotonAfectar.Width = 150;

           
                BaseBotonProceso2.ToolTipText = "Mostrar Detalle de Archivo XML";
                BaseBotonProceso2.Text = "Mostrar XML";
                BaseBotonProceso2.Width = 90;
                BaseBotonProceso2.Visible = true;
                BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["xml.png"]));

                BaseBotonProceso3.Enabled = !(grdRecepciones.Rows.Count == 0);
                BaseBotonProceso3.ToolTipText = "Nota de Recepción";
                BaseBotonProceso3.Text = "Nota de Recepción";
                BaseBotonProceso3.Width = 150;

                BaseBotonProceso4.ToolTipText = "Eliminar una Recepción de XML";
                BaseBotonProceso4.Text = "Eliminar Recepción";
                BaseBotonProceso4.Width = 120;
                BaseBotonProceso4.Visible = true;
                BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["CancelaHoja.png"]));

                BaseBotonReporte.Enabled = !(grdRecepciones.Rows.Count == 0);
                BaseBotonReporte.ToolTipText = "Ordenes de Compra";
                BaseBotonReporte.Text = "Ordenes de Compra";
                BaseBotonReporte.Width = 120;

                this.WindowState = FormWindowState.Maximized;

                dtProveedores = sqlCatalogos.Sk_Proveedores();

                base.BaseMetodoInicio();
                //BaseBotonBuscar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void BaseBotonNuevoClick()
        {
            //Leemos el directorio donde estarán los XML.
            string[] files = Directory.GetFiles(@"C:\PROBEMEDIC\conta\proveedor", "*.xml");
                 
            //Iteramos el arreglo.
            foreach (string file in files)
            {
                this.PropiedadRuta = file;
                XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                XmlTextReader reader = new XmlTextReader(@PropiedadRuta);
                Comprobante Factura = (Comprobante)serializer.Deserialize(reader);
                this.PropiedadFactura = Factura;
                this.PropiedadXML = new XmlDocument();
                this.PropiedadXML.Load(@PropiedadRuta);
                
                Comprobante factura = this.PropiedadFactura;
                cfdi = this.PropiedadXML;
                BaseMetodoArrastrar(factura, cfdi);
            }
            if (grdRecepciones.Rows.Count > 0)
            {                        
                if (grdRecepciones.ReadOnly)
                {
                    B_NoEntrar = true;
                    this.grdRecepciones.ReadOnly = false;
                    this.grdRecepciones.Columns["K_Operacion"].Visible = false;
                    this.grdRecepciones.Columns[0].ReadOnly = false;
                    this.grdRecepciones.Columns[1].ReadOnly = false;
                    this.grdRecepciones.EndEdit();
                }
            }
             
        }
        public override void BaseBotonBuscarClick()
        {
            base.BaseBotonBuscarClick();
        }
        public override void BaseMetodoArrastrar(Comprobante factura, XmlDocument xDoc = null)
        {
            try
            {
                if (factura == null)
                    return;

                if (factura.TipoDeComprobante.ToString().Trim().ToUpper() != "I")
                {
                    MessageBox.Show("EL TIPO DE COMPROBANTE NO ES DE INGRESO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbxTipoComprobante.SelectedIndex < 0)
                {
                    cbxTipoComprobante.SelectedIndex = 0;
                }
                lstRecepcionesXML.Clear();

                RecepcionesProveedorXML rec = new RecepcionesProveedorXML();
                rec.B_Seleccion = false;
                rec.K_Operacion = 0;

                //Proveedores
                string Nombre = string.Empty;
                int K_Proveedor = 0;
                string RFCEmisor = factura.Emisor.Rfc;
                DataRow NombreProv = dtProveedores.AsEnumerable().Where(p => p.Field<string>("RFC") == RFCEmisor).FirstOrDefault();
                if (NombreProv != null)
                {
                    Nombre = NombreProv["D_Proveedor"].ToString();
                    K_Proveedor = Convert.ToInt32(NombreProv["K_Proveedor"]);
                    rec.K_Proveedor = K_Proveedor;
                }
                else
                {
                    MessageBox.Show("EL PROVEEDOR DEL ARCHIVO NO EXISTE REGISTRADO...!\r\nR.F.C.: " + RFCEmisor + "\r\nProveedor: " + factura.Emisor.Nombre + "\r\nDEBERA ENTRAR A LA OPCION DE PROVEEDORES A CAPTURARLO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                rec.RFCEmisor = factura.Emisor.Rfc;
                rec.Nombre = factura.Emisor.Nombre;
                rec.TipoComprobante = factura.TipoDeComprobante.ToString();
                rec.TipoDocumento = "I";
                rec.UUID = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();

                string Serie = string.Empty;
                string Folio = string.Empty;

                if (factura.Serie != null)
                    Serie = factura.Serie;
                if (factura.Folio != null)
                    Folio = factura.Folio;
                rec.Serie = Serie;
                rec.Folio = Folio;
                rec.Fecha = factura.Fecha;

                string TipoCambio = "1.00";
                if (factura.TipoCambio != null)
                    TipoCambio = Truncar(Convert.ToDecimal(factura.TipoCambio), 4).ToString();

                if (factura.Moneda != null)
                {
                    string Moneda = factura.Moneda;
                    rec.D_Tipo_Moneda = factura.Moneda;
                    if (Moneda.ToUpper().Contains("USD") || Moneda.ToUpper().Contains("DLL") || Moneda.ToUpper().Contains("DOLAR"))
                        rec.K_Tipo_Moneda = 5;
                    if (Moneda.ToUpper().Contains("PESO") || Moneda.ToUpper().Contains("MXN"))
                        rec.K_Tipo_Moneda = 1;
                }
                else
                    rec.K_Tipo_Moneda = 1; //Si no viene moneda en el XML, por default pongo PESOS

                rec.TipoCambio = Convert.ToDecimal(factura.TipoCambio);
                rec.Subtotal = factura.SubTotal;
                decimal TasaIVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
                decimal IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
                decimal RetencionIVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
                decimal RetencionISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));

                rec.TasaIVA = TasaIVA;
                rec.TotalIVA = IVA;
                if (RetencionIVA > 0)
                {
                    rec.TasaRetencion = Convert.ToDecimal("10.66");
                    rec.TotalRetencion = Convert.ToDecimal(RetencionIVA.ToString());
                }
                if (RetencionISR > 0)
                {
                    rec.TasaISR = Convert.ToDecimal("10");
                    rec.TotalISR = Convert.ToDecimal(RetencionISR.ToString());
                }
                rec.Total = factura.Total;
                rec.k_Orden_Compra = 0;
                rec.K_Nota_Recepcion = "0";
                rec.SerieReferencia = factura.Serie;
                rec.FolioReferencia = factura.Folio;
                rec.VersionXML = factura.Version;
                rec.XML = string.Empty;
                rec.Modulo = "WEB";
                rec.RutaArchivo = @"C:\PROBEMEDIC\conta\proveedor";
                lstRecepcionesXML.Add(rec);

                if(dtRecepciones!=null)
                {
                    DataTable dtRespaldo = dtRecepciones.Copy();
                    DataTable dtPaso = lstRecepcionesXML.ToDataTable();
                    dtRespaldo.Merge(dtPaso);
                    dtRecepciones = dtRespaldo;
                }
                else
                {
                    dtRecepciones = lstRecepcionesXML.ToDataTable();
                }
               
          
                BasePropiedadCampoClave = "K_Operacion";
                BaseDtDatos = dtRecepciones;
                LlenaRecepciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
       
    
        public override void BaseBotonAfectarClick()
        {
            // FACTURAS XML
            if (grdRecepciones.CurrentRow.Cells["TipoComprobante"].Value.ToString().ToUpper() == "INGRESO")
            {
                try
                {
                    //XmlDocument cfdi = new XmlDocument();

                    for (int i = 0; i <= grdRecepciones.Rows.Count - 1; i++)
                    {
                        if (grdRecepciones.Rows[i].Selected)
                        {
                            //cfdi.LoadXml(grdRecepciones.Rows[i].Cells["XML"].Value.ToString());

                            //XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                            //XmlTextReader reader = new XmlTextReader(new System.IO.StringReader(grdRecepciones.Rows[i].Cells["XML"].Value.ToString())); ;                            
                            //Comprobante factura = (Comprobante)serializer.Deserialize(reader);
                            var rec = lstRecepcionesXML.Where(p => p.K_RecepcionArchivoProveedor == K_Recepcion).FirstOrDefault();
                            Comprobante factura = rec.RutaArchivo.LeerArchivoXML();
                     
                            int K_Cuenta_Pagar = 0;
                            int K_Proveedor = Convert.ToInt32(grdRecepciones.Rows[i].Cells["K_Proveedor"].Value);
                            string FolioFiscal = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();
                            string Serie = "";
                            string Folio = "";
                            if (factura.Serie != null)
                                Serie = factura.Serie;
                            if (factura.Folio != null)
                                Folio = factura.Folio;
                            decimal Tipo_Cambio = Convert.ToDecimal(factura.TipoCambio);
                            int K_Tipo_Moneda = Convert.ToInt32(grdRecepciones.Rows[i].Cells["K_Tipo_Moneda"].Value);
                            if ((K_Tipo_Moneda == 1) && (Tipo_Cambio <= 1))
                                Tipo_Cambio = Convert.ToDecimal(grdRecepciones.Rows[i].Cells["TipoCambio"].Value);
                            decimal Subtotal = factura.SubTotal;
                            decimal Tasa_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
                            decimal Total_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
                            decimal TasaRetencion_IVA = 0;
                            decimal TotalRetencion_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
                            decimal Tasa_ISR = 0;
                            decimal Total_ISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));
                            decimal TotalFactura = factura.Total;
                            DateTime F_Factura = factura.Fecha;
                            //int K_Orden_Compra = 0;
                            DateTime F_Vencimiento = DateTime.Today; ;
                            bool B_CapturaDirecta = true;
                            string Observaciones = "";
                            string VersionXML = factura.Version;
                            //XmlDocument XML = cfdi;
                            string Modulo = "RECEPCIONES_WEB";
                            int K_Usuario = GlobalVar.K_Usuario;
                            DataTable DetalleCxP;
                            DetalleCxP = (DataTable)ComprobantexTipo(factura, "ConceptosTabla");
                            DetalleCxP.Columns.Remove("B_Manual");
                            DetalleCxP.Columns.Remove("Id");


                            //ref string Mensaje;

                            res = sqlCXP.In_CxP(ref K_Cuenta_Pagar, K_Proveedor, FolioFiscal, Serie, Folio, Tipo_Cambio, K_Tipo_Moneda,
                                Subtotal, Tasa_IVA, Total_IVA, TasaRetencion_IVA, TotalRetencion_IVA, Tasa_ISR, Total_ISR, TotalFactura,
                                F_Factura, KOrdenCompra, F_Vencimiento, B_CapturaDirecta, Observaciones, VersionXML, Modulo, K_Usuario
                                , DetalleCxP, ref msg);

                            if (res == -1)
                            {
                                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                var lstArchivos = recepcionBL.sps_Recepcion_Archivos_Proveedores(rec.K_Proveedor, rec.k_Orden_Compra, rec.SerieReferencia, Convert.ToInt32(rec.FolioReferencia), null, rec.TipoDocumento, 1, rec.K_Operacion);
                                foreach (var ele in lstArchivos)
                                {
                                    ele.RutaArchivo.ToString().ToFolder(ele.NombreArchivo, 9);
                                    sqlRecepcion.In_RecepcionFacturasProveedor(ele.K_Proveedor, ele.K_Orden_Compra, ele.Serie, ele.Folio, ele.Efiscal, ele.Mes, ele.NombreArchivo, 9, null, Convert.ToInt32(K_Cuenta_Pagar), null, ele.TipoDocumento, GlobalVar.K_Usuario, string.Empty, GlobalVar.PC_Name, ref msg);
                                }


                                //K_OrdenCompra = CampoIdentity;
                                msg = "CUENTA POR PAGAR GENERADA CORRECTAMENTE CON FOLIO...: " + K_Cuenta_Pagar.ToString().Trim();

                                BaseErrorResultado = false;
                                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                K_Recepcion = 0;
                                KOrdenCompra = 0;

                            }

                            //res = sqlCXP.spd_Recepciones_XML(Convert.ToInt32(grdRecepciones.Rows[i].Cells["K_Operacion"].Value), ref msg);

                            //if (res == -1)
                            //{
                            //    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //    return;
                            //}

                            //grdRecepciones.Rows[i].Selected = false;



                        }
                    }
                    grdRecepciones.DataSource = null;
                    grdDetalle.DataSource = null;

                    //BuscaRecepciones();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                // NOTAS DE CREDITO XML
                try
                {
                    //XmlDocument cfdi = new XmlDocument();

                    for (int i = 0; i <= grdRecepciones.Rows.Count - 1; i++)
                    {
                        if (grdRecepciones.Rows[i].Selected)
                        {
                            //cfdi.LoadXml(grdRecepciones.Rows[i].Cells["XML"].Value.ToString());

                            //XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                            //XmlTextReader reader = new XmlTextReader(new System.IO.StringReader(grdRecepciones.Rows[i].Cells["XML"].Value.ToString())); ;
                            //Comprobante factura = (Comprobante)serializer.Deserialize(reader);
                            var rec = lstRecepcionesXML.Where(p => p.K_RecepcionArchivoProveedor == K_Recepcion).FirstOrDefault();
                            if (rec.RutaArchivo == null)
                                throw new Exception("NO ES POSIBLE APLICAR NOTA DE CREDITO \nDEBIDO A QUE NO SE ENCUENTRA LA RUTA DEL ARCHIVO XML...");

                            Comprobante factura = rec.RutaArchivo.LeerArchivoXML();

                            int K_Nota_Credito = 0;
                            int K_Proveedor = Convert.ToInt32(grdRecepciones.Rows[i].Cells["K_Proveedor"].Value);
                            string FolioFiscal = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();
                            string Serie = "";
                            string Folio = "";
                            if (factura.Serie != null)
                                Serie = factura.Serie;
                            if (factura.Folio != null)
                                Folio = factura.Folio;
                            decimal Tipo_Cambio = Convert.ToDecimal(factura.TipoCambio);
                            int K_Tipo_Moneda = Convert.ToInt32(grdRecepciones.Rows[i].Cells["K_Tipo_Moneda"].Value);
                            decimal Subtotal = factura.SubTotal;
                            decimal Tasa_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
                            decimal Total_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
                            decimal TasaRetencion_IVA = 0;
                            decimal TotalRetencion_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
                            decimal Tasa_ISR = 0;
                            decimal Total_ISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));
                            decimal TotalFactura = factura.Total;
                            DateTime F_Factura = factura.Fecha;
                            int K_Orden_Compra = 0;
                            DateTime F_Vencimiento = DateTime.Today; ;
                            bool B_CapturaDirecta = true;
                            string Observaciones = "";
                            string VersionXML = factura.Version;
                            //XmlDocument XML = cfdi;
                            string Modulo = "RECEPCIONES_WEB";
                            int K_Usuario = GlobalVar.K_Usuario;
                            DataTable DetalleCxP;
                            DetalleCxP = (DataTable)ComprobantexTipo(factura, "ConceptosTabla");
                            DetalleCxP.Columns.Remove("B_Manual");
                            DetalleCxP.Columns.Remove("Id");


                            //ref string Mensaje;

                            res = sqlCXP.In_Nota_Credito_Proveedor(ref K_Nota_Credito, K_Proveedor, FolioFiscal, Serie, Folio, Tipo_Cambio, Convert.ToInt16(K_Tipo_Moneda),
                                Subtotal, Tasa_IVA, Total_IVA, TasaRetencion_IVA, TotalRetencion_IVA, Tasa_ISR, Total_ISR, TotalFactura,
                                F_Factura, grdRecepciones.CurrentRow.Cells["FolioReferencia"].Value.ToString(), Observaciones, VersionXML,
                                Convert.ToInt32(GlobalVar.K_Usuario), Modulo, B_CapturaDirecta, grdRecepciones.Rows[i].Cells["SerieReferencia"].Value.ToString(),
                                grdRecepciones.Rows[i].Cells["FolioReferencia"].Value.ToString(), DetalleCxP, ref msg);

                            if (res == -1)
                            {
                                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                //K_OrdenCompra = CampoIdentity;


                                string Asunto = "Nota de Crédito Aplicada";
                                string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();


                                string html = "Se le informa que ha sido aplicada la nota de crédito con Folio " + K_Nota_Credito.ToString() + " de la cual se anexa detalle a continuaci&oacute;n: </br></br>" + HTMLGrid(grdRecepciones.Rows[i]);
                                string Cuerpo = fx.CuerpoCorreoHTML(html);
                                Cuerpo = Cuerpo.Replace("</style>", ".negrita {font-family:Arial; color: white; background-color:#003366;}td {font-family:Arial;color: #003366;}</style>");



                                //string Recursos = "logo";
                                //string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                                //string Adjuntos = "";
                                //string titulo = "Nota de Crédito Aplicada con Folio " + K_Nota_Credito.ToString();

                                //fx.EnviaCorreo(CorreoDe, "tesoreria@eiffel.com.mx", Asunto, titulo, Cuerpo, Adjuntos, Archivos, Recursos, "", false);

                                var lstArchivos = recepcionBL.sps_Recepcion_Archivos_Proveedores(rec.K_Proveedor, rec.k_Orden_Compra, rec.SerieReferencia, Convert.ToInt32(rec.FolioReferencia), null, rec.TipoDocumento, 1, rec.K_Operacion);
                                foreach (var ele in lstArchivos)
                                {
                                    ele.RutaArchivo.ToString().ToFolder(ele.NombreArchivo, 9);
                                    sqlRecepcion.In_RecepcionFacturasProveedor(ele.K_Proveedor, ele.K_Orden_Compra, ele.Serie, ele.Folio, ele.Efiscal, ele.Mes, ele.NombreArchivo, 9, Convert.ToInt32(K_Nota_Credito), null, null, ele.TipoDocumento, GlobalVar.K_Usuario, string.Empty, GlobalVar.PC_Name, ref msg);
                                }

                                msg = "NOTA APLICADA CORRECTAMENTE CON FOLIO...: " + K_Nota_Credito.ToString().Trim();

                                BaseErrorResultado = false;
                                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                K_Recepcion = 0;
                                KOrdenCompra = 0;

                            }

                            //res = sqlCXP.spd_Recepciones_XML(Convert.ToInt32(grdRecepciones.Rows[i].Cells["K_Operacion"].Value), ref msg);

                            //if (res == -1)
                            //{
                            //    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //    return;
                            //}

                            //grdRecepciones.Rows[i].Selected = false;



                        }
                    }
                    grdRecepciones.DataSource = null;
                    grdDetalle.DataSource = null;

                    //BuscaRecepciones();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            base.BaseBotonAfectarClick();
        }
        public override void BaseBotonGuardarClick()
        {
            base.BaseBotonBuscarClick();
        }

        //Ordenes de Compra
        public override void BaseMetodoMostrarReporte()
        {
            if (grdRecepciones.Rows.Count == 0)
                return;

            int K_OrdenCompra = 0;
            string Version = string.Empty;
            DataGridViewRow row = grdRecepciones.CurrentRow;
            if (row == null)
                return;

            K_OrdenCompra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);

            //DataTable dtReporte = sqlCompras.sps_ReporteOrdenesCompra(K_OrdenCompra);
            //ReportedtCorreo = dtReporte;
            //Version = dtReporte.Rows[0]["DocumentoVersion"].ToString();

            //ReportDocument rpt = new ReportDocument();
            //rpt = new REPORTES.RPT_OrdenCompra();

            //ReporteTitulo = "Orden de Compra / Purchase Order";
            //ReporteModulo = "COMPRAS";

            //ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            //ReporteRPT = rpt;
        }

        //Mostrar XML     
        private void BaseBotonProceso2_Click(object sender, EventArgs e)
        {
            if(grdRecepciones.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE INFORMACION PARA MOSTRAR...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(K_Recepcion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA RECEPCION PARA MOSTRAR EL ARCHIVO XML...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ruta = lstRecepcionesXML.Where(p => p.K_RecepcionArchivoProveedor == K_Recepcion).FirstOrDefault().RutaArchivo;
            XDocument xDoc = ruta.toXDocument();
            Frm_XML frm = new Frm_XML();
            frm.cfdi = xDoc;
            frm.ShowDialog();

        }

        //Nota de Recepción
        void BaseBotonProceso3_Click(object sender, EventArgs e)
        {
            if (grdRecepciones.Rows.Count == 0)
                return;

            DataGridViewRow row = grdRecepciones.CurrentRow;
            if (row == null)
                return;

            string cadena = row.Cells["grdK_Nota_Recepcion"].Value.ToString();

            string[] arNotas = cadena.Split(',');

            for (int i = 0; i <= arNotas.Length - 1; i++)
            {
                int K_Nota = Convert.ToInt32(arNotas[i].ToString());
                if (K_Nota > 0)
                {
                    ReporteNota(K_Nota);
                }
            }

        }

        //Eliminar Recepción
        private void BaseBotonProceso4_Click(object sender, EventArgs e)
        {
            //jorge... Puede ser cualquiera INGRESO o EGRESO
            DataGridViewRow row = grdRecepciones.CurrentRow;
            if (row == null)
                return;

            int K_Operacion = Convert.ToInt32(row.Cells["K_Operacion"].Value);

            DialogResult dlg = MessageBox.Show("¿DESEA ELIMINAR LA RECEPCION NO. " + K_Operacion.ToString() + "?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                var rec = lstRecepcionesXML.Where(p => p.K_RecepcionArchivoProveedor == K_Recepcion).FirstOrDefault();

                var lstArchivos = recepcionBL.sps_Recepcion_Archivos_Proveedores(rec.K_Proveedor, rec.k_Orden_Compra, rec.SerieReferencia, Convert.ToInt32(rec.FolioReferencia), null, rec.TipoDocumento, 1, rec.K_Operacion);
                foreach (var ele in lstArchivos)
                {
                    string nomArchivo = string.Format("{0}{1}{2}", Path.GetFileNameWithoutExtension(ele.NombreArchivo), Guid.NewGuid().ToString(), Path.GetExtension(ele.NombreArchivo));
                    ele.RutaArchivo.ToString().ToFolderMove(nomArchivo, 6);
                    //ele.RutaArchivo.ToString().ToFolder(nomArchivo, 6);
                    //ele.RutaArchivo.BorraArchivo();
                    sqlRecepcion.In_RecepcionFacturasProveedor(ele.K_Proveedor, ele.K_Orden_Compra, ele.Serie, ele.Folio, ele.Efiscal, ele.Mes, nomArchivo, 6, null, null, null, ele.TipoDocumento, GlobalVar.K_Usuario, string.Empty, GlobalVar.PC_Name, ref msg);
                }

                res = sqlRecepcion.Dl_RecepcionFacturasProveedor(rec.K_Proveedor, rec.k_Orden_Compra, rec.TipoDocumento, rec.K_Operacion, ref msg);
                //if (res == -1)
                //{
                //    MessageBox.Show("NO FUE POSIBLE ELIMINAR RECEPCION...INTENTE NUEVAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                //res = sqlCXP.spd_Recepciones_XML(K_Operacion, ref msg);
                //if (res == -1)
                //{
                //    MessageBox.Show("NO FUE POSIBLE ELIMINAR RECEPCION\n" + msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}


                string Asunto = "Recepción XML Eliminada";
                string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();

                string html = "Se le informa que ha sido eliminada la recepción de XML con Folio " + K_Operacion.ToString() + " de la cual se anexa detalle a continuaci&oacute;n: </br></br>" + HTMLGrid(row);
                string Cuerpo = fx.CuerpoCorreoHTML(html);
                Cuerpo = Cuerpo.Replace("</style>", ".negrita {font-family:Arial; color: white; background-color:#003366;}td {font-family:Arial;color: #003366;}</style>");

                string Recursos = "logo";
                string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                string Adjuntos = "";
                string titulo = "Eliminación de Recepción XML Folio " + K_Operacion.ToString();

                fx.EnviaCorreo(CorreoDe, "compras@eiffel.com.mx", Asunto, titulo, Cuerpo, Adjuntos, Archivos, Recursos, "", false);

                MessageBox.Show("RECEPCION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
            }

        }
        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();

                //BuscaRecepciones();
            }


        }


        public void MostrarDetalle(string RutaArchivo)
        {
            var rec = lstRecepcionesXML.Where(p => p.K_RecepcionArchivoProveedor == K_Recepcion).FirstOrDefault();
            if (RutaArchivo == null)
                return;
            Comprobante factura = RutaArchivo.LeerArchivoXML();
            DataTable dtDetalle = factura.Conceptos.ToDataTable();
            dtDatos = DetalleRecepciones_Type;
            foreach(DataRow ren in dtDetalle.Rows)
            {
                DataRow row = dtDatos.NewRow();
                row["K_Operacion"] = rec.K_Operacion;
                row["Cantidad"] = ren["cantidad"];
                row["UnidadMedida"] = ren["unidad"];
                row["Concepto"] = ren["descripcion"];
                row["PrecioUnitario"] = ren["valorUnitario"];
                row["ImporteTotal"] = ren["importe"];
                dtDatos.Rows.Add(row);
            }

            grdDetalle.DataSource = dtDatos;
              
        }

        //private void BuscaRecepciones()
        //{
        //    try
        //    {
        //        int K_Tipo_Moneda = 0;
        //        if (cmbTipoMoneda.SelectedValue != null)
        //        {
        //            if (cmbTipoMoneda.SelectedValue.ToString().Trim() != "System.Data.DataRowView")
        //            {
        //                K_Tipo_Moneda = Convert.ToInt32(cmbTipoMoneda.SelectedValue);
        //            }
        //        }
        //        if (cbxTipoComprobante.SelectedIndex < 0)
        //        {
        //            cbxTipoComprobante.SelectedIndex = 0;
        //        }

        //        int K_Proveedor = 0;
        //        if (txtClaveProveedor.Text.Trim().Length > 0)
        //            K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);

        //        lstRecepcionesXML.Clear();
        //        lstRecepcionesProveedor = recepcionBL.sps_RecepcionFacturasProveedor(Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaFin.Text), K_Proveedor, K_Tipo_Moneda);
        //        foreach (var ele in lstRecepcionesProveedor)
        //        {
        //            if (ele.RutaArchivo == null)
        //                throw new Exception("NO SE ENCUENTRA LA RUTA DEL ARCHIVO XML...");
        //            Comprobante factura = ele.RutaArchivo.LeerArchivoXML();
        //            RecepcionesProveedorXML rec = new RecepcionesProveedorXML();
        //            rec.B_Seleccion = false;
        //            rec.K_RecepcionArchivoProveedor = ele.K_RecepcionArchivoProveedor;
        //            rec.K_Operacion = ele.K_Operacion;
        //            rec.Nombre = factura.Emisor.nombre;
        //            rec.RFCEmisor = factura.Emisor.rfc;
        //            rec.UUID = factura.FolioFiscalOrig;
        //            rec.TipoComprobante = factura.tipoDeComprobante.ToString();
        //            rec.TipoDocumento = ele.TipoDocumento;
        //            rec.Serie = factura.serie;
        //            rec.Folio = factura.folio;
        //            rec.Fecha = factura.fecha;
        //            if (ele.D_Tipo_Moneda == null && Convert.ToDecimal(factura.TipoCambio) == 1)
        //            {
        //                rec.D_Tipo_Moneda = "PESOS";
        //                rec.K_Tipo_Moneda = 2;
        //            }
        //            else
        //            {
        //                rec.D_Tipo_Moneda = ele.D_Tipo_Moneda;
        //                rec.K_Tipo_Moneda = ele.K_Tipo_Moneda;
        //            }
        //            rec.TipoCambio = Convert.ToDecimal(factura.TipoCambio);
        //            rec.Subtotal = factura.subTotal;
        //            rec.TasaIVA = factura.Impuestos.Traslados[0].tasa;
        //            rec.TotalIVA = factura.Impuestos.Traslados[0].importe;
        //            rec.Total = factura.total;
        //            rec.VersionXML = factura.version;
        //            rec.Modulo = "WEB";
        //            rec.RutaArchivo = ele.RutaArchivo;
        //            rec.K_Proveedor = ele.K_Proveedor;
        //            rec.k_Orden_Compra = ele.K_Orden_Compra;
        //            rec.K_Nota_Recepcion = ele.K_Nota_Recepcion.ToString();
        //            rec.SerieReferencia = ele.Serie;
        //            rec.FolioReferencia = ele.Folio.ToString();
        //            lstRecepcionesXML.Add(rec);
        //        }

        //        //dtRecepciones = sqlCXP.sps_Recepciones_XML(Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaFin.Text), K_Proveedor, K_Tipo_Moneda, Convert.ToInt16(cbxTipoComprobante.SelectedIndex));
        //        dtRecepciones = lstRecepcionesXML.ToDataTable();
        //        BasePropiedadCampoClave = "K_Operacion";

        //        BaseDtDatos = dtRecepciones;
        //        LlenaRecepciones();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void LlenaRecepciones()
        {
            if (dtRecepciones != null)
            {
                DataTable dt = new DataTable();
                try
                {
                    var res = from c in dtRecepciones.AsEnumerable()
                              select c;
                    //res = res.Where(o => o.Field<int>("K_Oficina_Requiere") == GlobalVar.K_Oficina && o.Field<bool>("B_Autorizada") == false && o.Field<bool>("B_Cancelada") == false);
                    if (res.Any())
                    {
                        dt = res.CopyToDataTable();
                    }
                }
                finally
                {
                    
                    grdRecepciones.DataSource = dt;
                }
            }
            else
            {
                grdRecepciones.DataSource = null;
                grdDetalle.DataSource = null;

            }

            BaseBotonReporte.Enabled = !(grdRecepciones.Rows.Count == 0);
            BaseBotonProceso3.Enabled = !(grdRecepciones.Rows.Count == 0);
        }


        private string GenerarNombreFichero()
        {
            int ultimoTick = 0;
            while (ultimoTick == Environment.TickCount)
            {
                System.Threading.Thread.Sleep(1);
            }
            ultimoTick = Environment.TickCount;
            return "Documento";// DateTime.Now.ToString("yyyyMMddhhmmss") + "." +
            //ultimoTick.ToString();
        }
        void MtdLeerArchivo(Int32 Indice)
        {
            try
            {
                String strXML = grdRecepciones.Rows[Indice].Cells["XML"].Value.ToString();
                byte[] byteArray = Encoding.ASCII.GetBytes(strXML);
                MemoryStream stream = new MemoryStream(byteArray);

                //DataRow f = stream; //DtDocumento.Rows[0];
                //byte[] bits = ((byte[])(f.ItemArray[0]));
                string sFile = "tmp" + GenerarNombreFichero() + ".xml";

                FileStream fs = new FileStream(sFile, FileMode.Create, FileAccess.Write);
                //Y escribimos en disco el array de bytes que conforman
                //el fichero Word
                fs.Write(byteArray, 0, Convert.ToInt32(byteArray.Length));
                fs.Close();
                System.Diagnostics.Process obj = new System.Diagnostics.Process();
                obj.StartInfo.FileName = sFile;
                obj.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        void ReporteNota(int p_K_Nota_Recepcion)
        {
            //k_Nota_Recepcion = p_K_Nota_Recepcion;

            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //IEnumerable<Entities.ReporteNotaReciboDTO> dtReporte = sqlRecepcion.sps_ReporteNotaRecibo(K_Nota_Recepcion);

            //ReportDocument rpt = new ReportDocument();
            //rpt = new REPORTES.RPT_NotasRecepcion();

            //DataTable tblReporteRecepcion = sqlRecepcion.sps_TablaReporteNotaRecibo(K_Nota_Recepcion);
            //string Version = Version = tblReporteRecepcion.Rows[0]["DocumentoVersion"].ToString();

            //ReporteTitulo = "Entrada de Almacén";
            //ReporteModulo = "Inventarios";

            //ConectaReporte2(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            //ReporteRPT = rpt;

            //ReporteTitulo = "Entrada de Almacén";
            //ReporteModulo = "Inventarios";

            //Frm_Reportes frmReporteNota = new Frm_Reportes();
            //frmReporteNota.P_Titulo = ReporteTitulo;
            //frmReporteNota.P_ReporteRPT = ReporteRPT;
            //frmReporteNota.P_TablaCorreo = ReportedtCorreo;
            //frmReporteNota.ShowDialog();
        }


        public void ConectaReporte2(ref CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, IEnumerable<object> dtReporte, string TituloReporte, string ModuloReporte, string Version = "")
        {
            string NomFisico = rpt.ToString();
            NomFisico = NomFisico.Replace("PARIS.REPORTES.", "");

            rpt.SetDataSource(dtReporte);


            rpt.SetParameterValue("D_Empresa", Empresa.D_Empresa);
            rpt.SetParameterValue("Leyenda", Empresa.Leyenda);
            rpt.SetParameterValue("Calle", Empresa.Calle);
            rpt.SetParameterValue("Colonia", Empresa.Colonia);
            rpt.SetParameterValue("D_Ciudad", Empresa.D_Ciudad);
            rpt.SetParameterValue("C_Estado", Empresa.C_Estado);
            rpt.SetParameterValue("CodigoPostal", Empresa.CodigoPostal);
            rpt.SetParameterValue("Telefono_Fax", Empresa.Telefono_Fax);
            rpt.SetParameterValue("Version", Version);

            rpt.SetParameterValue("NombreReporte", NomFisico);
            rpt.SetParameterValue("TituloReporte", TituloReporte);
            rpt.SetParameterValue("Modulo", ModuloReporte);
        }
        private string HTMLGrid(DataGridViewRow row)
        {
            string html = string.Empty;
            string K_Operacion = string.Empty;
            string Nombre = string.Empty;
            string RFCEmisor = string.Empty;
            string Fecha = string.Empty;
            string Serie = string.Empty;
            string Folio = string.Empty;
            string D_Tipo_Moneda = string.Empty;
            string TipoCambio = string.Empty;
            string Subtotal = string.Empty;
            string TotalIVA = string.Empty;
            string Total = string.Empty;
            string TipoComprobante = string.Empty;
            string RutaArchivo = string.Empty;
            string K_Proveedor = string.Empty;
            string K_Tipo_Moneda = string.Empty;
            string K_Orden_Compra = string.Empty;
            string grdK_Nota_Recepcion = string.Empty;
            string SerieReferencia = string.Empty;
            string FolioReferencia = string.Empty;

            if (row.Cells["K_Operacion"] != null)
                K_Operacion = row.Cells["K_Operacion"].Value.ToString();
            if (row.Cells["Nombre"] != null)
                Nombre = row.Cells["Nombre"].Value.ToString();
            if (row.Cells["RFCEmisor"] != null)
                RFCEmisor = row.Cells["RFCEmisor"].Value.ToString();
            if (row.Cells["Fecha"] != null)
                Fecha = row.Cells["Fecha"].Value.ToString();
            if (row.Cells["Serie"] != null)
                Serie = row.Cells["Serie"].Value.ToString();
            if (row.Cells["Folio"] != null)
                Folio = row.Cells["Folio"].Value.ToString();
            if (row.Cells["D_Tipo_Moneda"] != null)
                D_Tipo_Moneda = row.Cells["D_Tipo_Moneda"].Value.ToString();
            if (row.Cells["TipoCambio"] != null)
                TipoCambio = row.Cells["TipoCambio"].Value.ToString();
            if (row.Cells["Subtotal"] != null)
            {
                decimal sub = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                Subtotal = sub.ToString("C");
            }
            if (row.Cells["TotalIVA"] != null)
            {
                decimal TI = Convert.ToDecimal(row.Cells["TotalIVA"].Value);
                TotalIVA = TI.ToString("C");
            }
            if (row.Cells["Total"] != null)
            {
                decimal tot = Convert.ToDecimal(row.Cells["Total"].Value);
                Total = tot.ToString("C");
            }
            if (row.Cells["TipoComprobante"] != null)
                TipoComprobante = row.Cells["TipoComprobante"].Value.ToString();
            if (row.Cells["RutaArchivo"] != null)
                RutaArchivo = row.Cells["RutaArchivo"].Value.ToString();
            if (row.Cells["K_Proveedor"] != null)
                K_Proveedor = row.Cells["K_Proveedor"].Value.ToString();
            if (row.Cells["K_Tipo_Moneda"] != null)
                K_Tipo_Moneda = row.Cells["K_Tipo_Moneda"].Value.ToString();
            if (row.Cells["K_Orden_Compra"] != null)
                K_Orden_Compra = row.Cells["K_Orden_Compra"].Value.ToString();
            if (row.Cells["grdK_Nota_Recepcion"] != null)
                grdK_Nota_Recepcion = row.Cells["grdK_Nota_Recepcion"].Value.ToString();
            if (row.Cells["SerieReferencia"] != null)
                SerieReferencia = row.Cells["SerieReferencia"].Value.ToString();
            if (row.Cells["FolioReferencia"] != null)
                FolioReferencia = row.Cells["FolioReferencia"].Value.ToString();

            //html = "<style>.negrita {font - family:Arial; color: white; background - color:#003366;}td {                    font - family:Arial; color: #003366;}</ style > ";
            html += "<table width=\"80%\" cellspacing=\"0\" cellpadding=\"5\" border=\"1\" bordercolor=\"#A4D1FF\"><tr>";
            html += "<td class=\"negrita\" width=\"20%\">Folio</td><td width =\"80%\">" + K_Operacion + "</td></tr><tr><td class=\"negrita\">Nombre</td>";
            html += "<td>" + Nombre + "</td></tr><tr><td class=\"negrita\">R.F.C.</td>";
            html += "<td>" + RFCEmisor + "</td></tr><tr><td class=\"negrita\">Fecha</td>";
            html += "<td>" + Fecha + "</td></tr><tr><td class=\"negrita\">Serie XML</td>";
            html += "<td>" + Serie + "</td></tr><tr><td class=\"negrita\">Folio XML</td>";
            html += "<td>" + Folio + "</td></tr><tr><td class=\"negrita\">Moneda</td>";
            html += "<td>" + D_Tipo_Moneda + "</td></tr><tr><td class=\"negrita\">T.C.</td>";
            html += "<td>" + TipoCambio + "</td></tr><tr><td class=\"negrita\">Subtotal</td>";
            html += "<td>" + Subtotal + "</td></tr><tr><td class=\"negrita\">IVA</td>";
            html += "<td>" + TotalIVA + "</td></tr><tr><td class=\"negrita\">Total</td>";
            html += "<td>" + Total + "</td></tr><tr><td class=\"negrita\">Tipo</td>";
            html += "<td>" + TipoComprobante + "</td></tr><tr><td class=\"negrita\">Ruta Archivo</td>";
            html += "<td>" + RutaArchivo + "</td></tr><tr><td class=\"negrita\">Orden Compra</td>";
            html += "<td>" + K_Orden_Compra + "</td></tr><tr><td class=\"negrita\">Entrada Almacén</td>";
            html += "<td>" + grdK_Nota_Recepcion + "</td></tr><tr><td class=\"negrita\">Serie Referencia</td>";
            html += "<td>" + SerieReferencia + "</td></tr><tr><td class=\"negrita\">Folio Referencia</td>";
            html += "<td>" + FolioReferencia + "</td></tr></table>";

            return html;

        }

        private void cbxTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BuscaRecepciones();
        }
        private void cmbTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

            //BuscaRecepciones();

        }
        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {


            if (txtClaveProveedor.Text.Trim() == "")
            {
                txtClaveProveedor.Text = "";
                txtProveedor.Text = "";
                //MessageBox.Show("No Existe la Clave del Proveedor");
            }
            else
            {
                DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
                BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);
                if (txtProveedor.Text.Trim() == "")
                {
                    txtClaveProveedor.Text = "";
                    txtProveedor.Text = "";
                    MessageBox.Show("No Existe la Clave del Proveedor");
                }

            }

            //BuscaRecepciones();
            //txtFechaInicio.Focus();


        }
        private void txtClaveProveedor_TextChanged(object sender, EventArgs e)
        {
            //if (txtClaveProveedor.Text.Trim() == "")
            //{
            //txtClaveProveedor.Text = "";
            //txtProveedor.Text = "";

            //BuscaRecepciones();
            //}

        }
        private void txtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            //BuscaRecepciones();
        }
        private void txtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            //BuscaRecepciones();
        }
        private void grdRecepciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //            if (e.ColumnIndex == 9) //xml
            //            {
            MtdLeerArchivo(e.RowIndex);
            //            }
        }
        private void grdRecepciones_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRecepciones.CurrentRow;
            if (row != null)
            {
                string RutaArchivo = row.Cells[14].Value.ToString();
                //BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                //K_Recepcion = Convert.ToInt32(row.Cells["K_RecepcionArchivoProveedor"].Value);
                //KOrdenCompra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);

                //if (row.Cells["TipoComprobante"].Value.ToString().ToUpper() == "INGRESO")
                //{
                //    BaseBotonAfectar.Text = "Genera Cuenta Por Pagar";
                //    BaseBotonReporte.Enabled = true;
                //    BaseBotonProceso3.Enabled = true;
                //}
                //else
                //{
                //    BaseBotonAfectar.Text = "Aplicar Nota";
                //    BaseBotonReporte.Enabled = false;
                //    BaseBotonProceso3.Enabled = false;
                //}

                MostrarDetalle(RutaArchivo);
            }
        }

        private void grdRecepciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grdRecepciones_KeyPress);
        }
        private void grdRecepciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!grdRecepciones.CurrentCell.IsInEditMode)
            {
                grdRecepciones.BeginEdit(true);
                return;
            }
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                TextBox textBox = (TextBox)sender;
                if (Convert.ToDecimal((Boolean)(textBox.Text.Length == 0) ? "0" : textBox.Text.Replace("$", "0")) == 0)
                {
                    e.Handled = false;
                    return;
                }
                string[] parts = textBox.Text.Split('.'); // result.Split('.');

                if (parts.Length > 1)
                {
                    if ((parts[1].Length > 1 && parts.Length > 2) && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }


            }
            else
                e.Handled = true;
        }
        private void grdRecepciones_KeyDown(object sender, KeyEventArgs e)
        {
            strKeyPress = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void grdRecepciones_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (grdRecepciones[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    if (Keys.Back.ToString() == strKeyPress)
                    {
                        SendKeys.Send("{RIGHT}");
                    }
                }
            }
        }
        private void grdRecepciones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA MONTO APLICADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
        private bool blnCeldaImportes()
        {
            if (grdRecepciones.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdRecepciones.CurrentCell.ColumnIndex == 0|| grdRecepciones.CurrentCell.ColumnIndex == 1);
        }
    }
}
