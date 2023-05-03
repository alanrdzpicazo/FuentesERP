using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Xml.Serialization;
using System.Xml;
using ProbeMedic.AppCode.BLL;
using ProbeMedic.AppCode.DCC;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.Controles;
namespace ProbeMedic
{
    public partial class Forma : Form
    {
        public System.Reflection.Assembly Ensamblado; //Ensamblado para levantar el catálogo
        public DataGridView BaseGrid;
        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        SQLCompras sqlCompras = new SQLCompras();
        SQLVentas sqlVentas = new SQLVentas();
        public string BaseValorBuscar;
        public System.Data.DataTable BaseDtFiltra;
        public string BaseTituloPantalla;
        public DataGridView BaseGridCopiar;
        public bool BaseGridSinFormato = false;
        public bool BaseHabilitaArrastrar = false;
        Funciones fx = new Funciones();

        //TODO: Variables parámetros para reportes
        public string ReporteTitulo { get; set; }
        public string ReporteModulo { get; set; }
        public string ReporteNombreFisico { get; set; }
        public System.Data.DataTable ReportedtCorreo { get; set; }
        public ReportDocument ReporteRPT { get; set; }

        public virtual void CargaTablasParciales(int tabla)
        {
            try
            {
                switch (tabla)
                {
                    case 1:
                        GlobalVar.dtPaises = sqlCatalogos.Sk_Pais();
                        break;
                    case 2:
                        GlobalVar.dtEstados = sqlCatalogos.Sk_Estado();
                        break;
                    case 3:
                        GlobalVar.dtPuestos = sqlCatalogos.Sk_Puesto();
                        break;
                    case 4:
                        GlobalVar.dtOficinas = sqlCatalogos.Sk_Oficina();
                        break;
                    case 5:
                        GlobalVar.dtDepartamentos = sqlCatalogos.Sk_Departamento();
                        break;
                    case 6:
                        GlobalVar.dtUsuarios = sqlSeguridad.Sk_Usuario();
                        break;
                    case 7:
                        GlobalVar.dtEmpleados = sqlCatalogos.Sk_Empleado();
                        break;
                    case 8:
                    //    GlobalVar.dtTipoProveedor = sqlCatalogos.sps_Tipo_Proveedor();
                    //    break;
                    //case 9:
                    //    GlobalVar.dtTipoMoneda = sqlCatalogos.sps_Tipo_Moneda();
                    //    break;
                    //case 10:
                    //    GlobalVar.dtClasifProveedor = sqlCatalogos.sps_Clasificacion_Proveedor();
                    //    break;
                    case 11:
                        GlobalVar.dtTipoArticulo = sqlCatalogos.Sk_Tipos_Productos();
                        break;
                    case 12:
                        GlobalVar.dtClasificacionArticulo = sqlCatalogos.Sk_Categoria_Articulo();
                       break;
                    case 13:
                    //    GlobalVar.dtGrupoArticulo = sqlCatalogos.sps_Grupo_Articulos();
                    //    break;
                    //case 14:
                    //    GlobalVar.dtUnidadMedida = sqlCatalogos.sps_Unidad_Medida();
                    //    break;
                    //case 15:
                    //    GlobalVar.dtTipoRequisicion = sqlCompras.sps_Tipo_Requisicion();
                    //    break;
                    //case 16:
                    //    GlobalVar.dtArticulos = sqlCatalogos.sps_Articulos();
                    //    break;
                    //case 17:
                    //    GlobalVar.dtEstatusCompra = sqlCatalogos.sps_Estatus_Compra();
                    //    break;
                    //case 18:
                    //    GlobalVar.dtTipoCliente = sqlCatalogos.sps_Tipo_Cliente();
                    //    break;
                    //case 19:
                    //    GlobalVar.dtTipoFiscal = sqlCatalogos.sps_Tipo_Fiscal();
                    //    break;
                    //case 20:
                    //    GlobalVar.dtClasificacion = sqlCatalogos.sps_Clasificacion_Cliente();
                    //    break;
                    //case 21:
                    //    GlobalVar.dtImpuestos = sqlCatalogos.sps_Impuestos();
                    //    break;
                    //case 22:
                    //    GlobalVar.dtTipoProducto = sqlCatalogos.sps_Tipo_Producto();
                    //    break;
                    //case 23:
                    //    GlobalVar.dtClaseProducto = sqlCatalogos.sps_Clase_Producto();
                    //    break;
                    //case 24:
                    //    GlobalVar.dtFamiliaProducto = sqlCatalogos.sps_Familia_Producto();
                    //    break;
                    //case 25:
                    //    GlobalVar.dtBancos = sqlCatalogos.sps_Bancos();
                        break;
                    case 26:
                        GlobalVar.dtEmpresa = sqlCatalogos.Sk_empresa();
                        break;
                    //case 27:
                    //    GlobalVar.dtEmpresa_Cuentas = sqlCatalogos.sps_Empresa_Cuentas();
                    //    break;
                    //case 28:
                    //    GlobalVar.dtTipos_Factura = sqlVentas.sps_Tipos_Factura();
                    //    break;
                    default:
                        break;
                }
            }
            catch
            {
            }
        }
        public System.Data.DataTable FormulacionInventario_Produccion_Type
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("K_Movimiento_Inventario", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("Lote", (typeof(string)));
                dt.Columns.Add("CantidadKgs", (typeof(decimal)));

                return dt;
            }
        }

        public System.Data.DataTable DtPreciosConvenio_Type
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("K_Tipo_Empaque", (typeof(int)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("Importe", (typeof(decimal)));

                return dt;
            }
        }

        public System.Data.DataTable DtDocuemntos_Type
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("K_Documento", (typeof(int)));
                dt.Columns.Add("NombreDocumento", (typeof(string)));
                dt.Columns.Add("Documento", (typeof(byte[])));
                dt.Columns.Add("ExtensionArchivo", (typeof(string)));


                return dt;
            }
        }

        public System.Data.DataTable Detalle_UbicacionType
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Lote", (typeof(string)));

                return dt;
            }
        }

        public System.Data.DataTable CotizacionDetalle_Type
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Cantidad", (typeof(decimal)));
                dt.Columns.Add("K_Tipo_Producto", (typeof(int)));
                dt.Columns.Add("D_Tipo_Producto", (typeof(string)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("PrecioUnitario", (typeof(decimal)));
                dt.Columns.Add("PorcentajeDescuento", (typeof(decimal)));
                dt.Columns.Add("Descuento", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("Tasa_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_Detalle", (typeof(decimal)));
                dt.Columns.Add("Comentarios", (typeof(string)));

                return dt;
            }
        }

        public System.Data.DataTable Pedidos_Type
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Cantidad", (typeof(decimal)));
                dt.Columns.Add("CantidadKgs", (typeof(decimal)));
                dt.Columns.Add("K_Tipo_Empaque", (typeof(int)));
                dt.Columns.Add("D_Tipo_Empaque", (typeof(string)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("D_Producto", (typeof(string)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("PrecioUnitario", (typeof(decimal)));
                dt.Columns.Add("PorcentajeDescuento", (typeof(decimal)));
                dt.Columns.Add("Descuento", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("Tasa_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_Detalle", (typeof(decimal)));
                dt.Columns.Add("Comentarios", (typeof(string)));
                dt.Columns.Add("B_Producido", (typeof(bool)));
                dt.Columns.Add("B_Facturado", (typeof(bool)));

                return dt;
            }
        }

        public System.Data.DataTable Pedidos_Type2
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Cantidad", (typeof(decimal)));
                dt.Columns.Add("CantidadKgs", (typeof(decimal)));
                dt.Columns.Add("K_Tipo_Empaque", (typeof(int)));
                dt.Columns.Add("D_Tipo_Empaque", (typeof(string)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("D_Producto", (typeof(string)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("PrecioUnitario", (typeof(decimal)));
                dt.Columns.Add("PorcentajeDescuento", (typeof(decimal)));
                dt.Columns.Add("Descuento", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("Tasa_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_Detalle", (typeof(decimal)));
                dt.Columns.Add("Comentarios", (typeof(string)));
                dt.Columns.Add("B_Producido", (typeof(bool)));
                dt.Columns.Add("B_Facturado", (typeof(bool)));
                dt.Columns.Add("K_Pedido", (typeof(int)));
                dt.Columns.Add("K_Pedido_Detalle", (typeof(int)));

                return dt;
            }
        }

        public System.Data.DataTable Dt_Meses
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Num_Mes", (typeof(int)));
                dt.Columns.Add("D_Mes", (typeof(string)));

                DataRow dr;

                dr = dt.NewRow();
                dr["Num_Mes"] = 1;
                dr["D_Mes"] = "Enero";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 2;
                dr["D_Mes"] = "Febrero";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["Num_Mes"] = 3;
                dr["D_Mes"] = "Marzo";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 4;
                dr["D_Mes"] = "Abril";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr["Num_Mes"] = 5;
                dr["D_Mes"] = "Mayo";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 6;
                dr["D_Mes"] = "Junio";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 7;
                dr["D_Mes"] = "Julio";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 8;
                dr["D_Mes"] = "Agosto";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 9;
                dr["D_Mes"] = "Septiembre";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 10;
                dr["D_Mes"] = "Octubre";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 11;
                dr["D_Mes"] = "Noviembre";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["Num_Mes"] = 12;
                dr["D_Mes"] = "Diciembre";
                dt.Rows.Add(dr);

                return dt;
            }
        }

        public System.Data.DataTable DtAños
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Año", (typeof(int)));

                DataRow dr;
                int año;
                for (año = DateTime.Today.Year; año <= DateTime.Today.Year + 50; año++)
                {
                    dr = dt.NewRow();
                    dr["Año"] = año;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }

        public System.Data.DataTable DetalleCxp_Type
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Cantidad", (typeof(short)));
                dt.Columns.Add("UnidadMedida", (typeof(string)));
                dt.Columns.Add("Concepto", (typeof(string)));
                dt.Columns.Add("PrecioUnitario", (typeof(decimal)));
                dt.Columns.Add("ImporteTotal", (typeof(decimal)));
                dt.Columns.Add("B_Manual", (typeof(bool)));


                DataColumn column = new DataColumn();
                column.ColumnName = "Id";
                column.DataType = System.Type.GetType("System.Int32");
                column.AutoIncrement = true;
                dt.Columns.Add(column);

                return dt;
            }
        }

        public Forma()
        {
            InitializeComponent();

            this.DragEnter += new DragEventHandler(Forma_DragEnter);
            this.DragDrop += new DragEventHandler(Forma_DragDrop);

        }
        private void Forma_Load(object sender, EventArgs e)
        {
            this.AllowDrop = BaseHabilitaArrastrar;

            Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            GetAllControls(this);

            Text = Text.ToUpper();

        }
        void Forma_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string s = a.GetValue(0).ToString();
                    //Arrastrar(s);
                    this.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible Arrastrar Archivos...!\n " + ex.Message);

                // don't show MessageBox here - Explorer is waiting !
            }
        }

        void Forma_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public void HabilitaTodosLosControlesHijos(Control parentControl, bool enable)
        {
            foreach (Control control in parentControl.Controls)
            {
                control.Enabled = enable;
                HabilitaTodosLosControlesHijos(control, enable);
            }
        }


        public void FormatoGrid(ref DataGridView grd)
        {
            grd.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grd.RowHeadersVisible = false;
            grd.BackgroundColor = Color.White;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.BorderStyle = BorderStyle.None;

            grd.AllowUserToResizeColumns = true;
            grd.MultiSelect = false;
            grd.ReadOnly = false;
            grd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 51, 102);
            grd.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 153, 51);
            grd.EnableHeadersVisualStyles = false;
        }


        public void SoloLecturaTodosLosControlesHijos(Control parentControl, bool readOnly, List<Control> Controles = null)
        {
            //Controles: Por si quieres omitir controles que no se pongan solo lectura
            if (parentControl is TextBoxBase || parentControl is System.Windows.Forms.TextBox)
            {
                System.Windows.Forms.TextBoxBase txt = ((TextBoxBase)parentControl);

                if (!ExisteControl(txt, Controles))
                {
                    txt.ReadOnly = readOnly;
                    txt.BackColor = Color.White;
                    txt.Text = string.Empty;
                }

            }
            foreach (Control control in parentControl.Controls)
                SoloLecturaTodosLosControlesHijos(control, readOnly, Controles);
        }

        public bool ExisteControl(Control ctrl, List<Control> ListaControles)
        {
            bool b_res = false;
            //foreach (TextBox textBox in textBoxes)
            foreach (Control c in ListaControles)
                if (c.Name == ctrl.Name)
                    b_res = true;

            return b_res;
        }


        public void RemoverColumnasTabla(List<string> clmnames, System.Data.DataTable datatable)
        {
            DataColumnCollection dcCollection = datatable.Columns;
            foreach (string dcName in clmnames)
            {
                if (dcCollection.Contains(dcName))
                {
                    dcCollection.Remove(dcName);
                }
            }
        }


        public object ComprobantexTipo(Comprobante factura, string Tipo)
        {
            object res = new object();


            if (Tipo == "RetencionIVA")
            {
                decimal RetencionIVA = 0;
                if (factura.Impuestos.Retenciones != null)
                {
                    //foreach (ComprobanteImpuestosRetencion imp in factura.Impuestos.Retenciones)
                    //{
                    //    if (imp.impuesto.ToString() == "IVA")
                    //        RetencionIVA += imp.importe;
                    //}
                }
                res = RetencionIVA;
            }

            if (Tipo == "RetencionISR")
            {
                decimal RetencionISR = 0;
                //if (factura.Impuestos.Retenciones != null)
                //{
                //    foreach (ComprobanteImpuestosRetencion imp in factura.Impuestos.Retenciones)
                //    {
                //        if (imp.impuesto.ToString() == "ISR")
                //            RetencionISR += imp.importe;
                //    }
                //}
                res = RetencionISR;
            }


            if (Tipo == "IVA")
            {
                decimal IVA = 0;
                if (factura.Impuestos.Traslados != null)
                {
                    //foreach (ComprobanteImpuestosTraslado imp in factura.Impuestos.Traslados)
                    //{
                    //    if (imp.impuesto.ToString() == "IVA")
                    //        IVA += imp.importe;
                    //}
                }
                res = IVA;
            }
            if (Tipo == "TasaIVA")
            {
                decimal TasaIVA = 0;
                if (factura.Impuestos.Traslados != null)
                {
                    //foreach (ComprobanteImpuestosTraslado imp in factura.Impuestos.Traslados)
                    //{
                    //    if (imp.impuesto.ToString() == "IVA")
                    //    {
                    //        TasaIVA = imp.tasa;
                    //    }
                    //}
                }
                res = TasaIVA;
            }

            if (Tipo == "Conceptos")
            {
                StringBuilder sb = new StringBuilder();
                string newLine = ((char)13).ToString() + ((char)10).ToString();
                //Conceptos
                //foreach (ComprobanteConcepto con in factura.Conceptos)
                //{
                //    sb.Append(con.descripcion);
                //    sb.Append(newLine);
                //}
                res = sb;
            }
            if (Tipo == "ConceptosTabla")
            {
                System.Data.DataTable dt = DetalleCxp_Type;
                //Conceptos
                    foreach (ComprobanteConcepto con in factura.Conceptos)
                {
                    int CantidadValidar = 0;
                    bool B_Error = false;
                    DataRow ren = dt.NewRow();
                    // Por el PROVEEDOR DE POLIOLES se hace este DESMADRE
                    if (con.Cantidad.ToString().Length > 0)
                    {
                        try
                        {
                            CantidadValidar = Convert.ToInt16(con.Cantidad);
                        }
                        catch
                        {
                            B_Error = true;
                        }
                        if (B_Error)
                        {
                            CantidadValidar = 1;
                        }
                    }
                    //                    ren["Cantidad"] = Convert.ToInt16(con.cantidad);
                    ren["Cantidad"] = CantidadValidar;
                    ren["UnidadMedida"] = con.Unidad;
                    ren["Concepto"] = con.Descripcion;
                    ren["PrecioUnitario"] = con.ValorUnitario;
                    ren["ImporteTotal"] = con.Importe;
                    ren["B_Manual"] = false;
                    dt.Rows.Add(ren);

                }
                res = dt;
            }


            return res;
        }

        private void Arrastrar(string ruta)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(ruta);

            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
            XmlTextReader reader = new XmlTextReader(ruta);
            Comprobante factura = (Comprobante)serializer.Deserialize(reader);
            BaseMetodoArrastrar(factura, xDoc);
        }

        public virtual void BaseMetodoArrastrar(Comprobante factura, XmlDocument xDoc = null)
        {

        }

        public virtual void CambiaEtiquetaEstatus()
        {

        }

        public virtual void ProcesoBuscar()
        {

        }
        public virtual bool ProcesoFiltrar()
        {
            //Form frm = (Form)sender;
            //fx.LlenaGrid(ref frm, ref grdDatos, dtConceptos);

            if (BaseDtFiltra == null)
            {
                MessageBox.Show("FALTA ASIGNAR LA TABLA DE DATOS A LA VARIABLE GLOBAL: BaseDtFiltra");
                return false;
            }

            DataGridView grd = new DataGridView();
            Form frm = (Form)this;
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            foreach (Control c in frm.Controls)
            {
                if (c is DataGridView)
                    grd = (DataGridView)c;
            }

            txt = (System.Windows.Forms.TextBox)base.Controls["pnlFiltro"].Controls["txtBuscar"];

            if (grd == null || txt == null)
                return true;


            if (txt.Text.Trim().Length == 0)
            {

                fx.LlenaGrid(ref frm, ref grd, BaseDtFiltra, BaseTituloPantalla);
                return false;
            }


            return true;
        }

        //TODO: *****AQUI SE CREAN TODAS LAS TABLAS GLOBALES    
        public virtual void CargaTablasGlobales()
        {
            try
            {
                GlobalVar.dtPaises = sqlCatalogos.Sk_Pais();
                GlobalVar.dtEstados = sqlCatalogos.Sk_Estado();
                //GlobalVar.dtCiudades = sqlCatalogos.sps_Ciudad();
                GlobalVar.dtPuestos = sqlCatalogos.Sk_Puesto();
                GlobalVar.dtOficinas = sqlCatalogos.Sk_Oficina();
                GlobalVar.dtOficinasEmpresa = sqlCatalogos.Sk_Oficina(GlobalVar.K_Empresa);
                GlobalVar.dtDepartamentos = sqlCatalogos.Sk_Departamento();
                GlobalVar.dtUsuarios = sqlSeguridad.Sk_Usuario();
                GlobalVar.dtEmpleados = sqlCatalogos.Sk_Empleado();
                //GlobalVar.dtTipoProveedor = sqlCatalogos.sps_Tipo_Proveedor();
                //GlobalVar.dtTipoMoneda = sqlCatalogos.sps_Tipo_Moneda();
                //GlobalVar.dtClasifProveedor = sqlCatalogos.sps_Clasificacion_Proveedor();
                GlobalVar.dtTipoArticulo = sqlCatalogos.Sk_Tipos_Productos();
                GlobalVar.dtClasificacionArticulo = sqlCatalogos.Sk_Categoria_Articulo();
                //GlobalVar.dtGrupoArticulo = sqlCatalogos.sps_Grupo_Articulos();
                //GlobalVar.dtUnidadMedida = sqlCatalogos.sps_Unidad_Medida();
                //GlobalVar.dtTipoRequisicion = sqlCompras.sps_Tipo_Requisicion();
                //GlobalVar.dtArticulos = sqlCatalogos.sps_Articulos();
                //GlobalVar.dtArticulosNombreInterno = sqlCatalogos.sps_Articulos(true, true);
                //GlobalVar.dtEstatusCompra = sqlCatalogos.sps_Estatus_Compra();
                //GlobalVar.dtTipoCliente = sqlCatalogos.sps_Tipo_Cliente();
                //GlobalVar.dtTipoFiscal = sqlCatalogos.sps_Tipo_Fiscal();
                //GlobalVar.dtClasificacion = sqlCatalogos.sps_Clasificacion_Cliente();
                //GlobalVar.dtImpuestos = sqlCatalogos.sps_Impuestos();
                //GlobalVar.dtTipoProducto = sqlCatalogos.sps_Tipo_Producto();
                //GlobalVar.dtClaseProducto = sqlCatalogos.sps_Clase_Producto();
                //GlobalVar.dtFamiliaProducto = sqlCatalogos.sps_Familia_Producto();
                //GlobalVar.dtBancos = sqlCatalogos.sps_Bancos();
                //GlobalVar.dtEmpresa = sqlCatalogos.sps_empresa();
                //GlobalVar.dtEmpresa_Cuentas = sqlCatalogos.sps_Empresa_Cuentas();
                //GlobalVar.dtTipos_Factura = sqlVentas.sps_Tipos_Factura();
            }
            catch
            {
            }
        }


        #region "Busquedas Especificas"
        //Solo funciona para búsquedas por clave y me devuelve descripción
        //El primer textbox debe ser la clave, el segundo el campo donde se muestra la descripción
        //public void BuscaOficinas(ref System.Windows.Forms.TextBox txtClave, ref System.Windows.Forms.TextBox txtDescripcion)
        //{
        //    if (txtClave.Text.Trim().Length == 0)
        //    {
        //        txtDescripcion.Text = string.Empty;
        //        return;
        //    }

        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    dt = LINQTablaFiltraMultiple(GlobalVar.dtOficinas, txtClave.Text, "K_Oficina");
        //    if (dt.Rows.Count > 0)
        //        txtDescripcion.Text = dt.Rows[0]["D_Oficina"].ToString();
        //}
        public System.Data.DataTable BuscaEnTablaClaveDescripcion(System.Data.DataTable dtBusca, string CampoClave, string CampoDescripcion, ref System.Windows.Forms.TextBox txtClave, ref System.Windows.Forms.TextBox txtDescripcion)
        {
            bool B_BusquedaExacta = false;
            System.Data.DataTable dt = new System.Data.DataTable();


            if (dtBusca == null)
            {
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (dtBusca.Rows.Count == 0)
            {
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (txtClave.Text.Trim().Length == 0)
            {
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (CampoClave.Trim().Length == 0)
            {
                MessageBox.Show("FALTA VALOR PARA CAMPO CLAVE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (CampoDescripcion.Trim().Length == 0)
            {
                MessageBox.Show("FALTA VALOR PARA CAMPO DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = string.Empty;
                return dt;
            }

            if (txtClave.Text.Trim().Length > 0)
            { B_BusquedaExacta = true; }
            //LUIS REYES  06Ene2015
            if (B_BusquedaExacta == true)
            { dt = LINQTablaFiltroExactoMultiple(dtBusca, txtClave.Text, CampoClave); }
            else
            { dt = LINQTablaFiltraMultiple(dtBusca, txtClave.Text, CampoClave); }
            if (dt.Rows.Count > 0)
                txtDescripcion.Text = dt.Rows[0][CampoDescripcion].ToString();
            else
            {
                txtClave.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
            }

            return dt;
        }

        public System.Data.DataTable BuscaEnTablaClaveDescripcion(System.Data.DataTable dtBusca, string CampoClave, string CampoDescripcion, ref System.Windows.Forms.TextBox txtClave, ref System.Windows.Forms.Label lblDescripcion)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            if (dtBusca == null)
            {
                lblDescripcion.Text = string.Empty;
                return dt;
            }
            if (dtBusca.Rows.Count == 0)
            {
                lblDescripcion.Text = string.Empty;
                return dt;
            }
            if (txtClave.Text.Trim().Length == 0)
            {
                lblDescripcion.Text = string.Empty;
                return dt;
            }
            if (CampoClave.Trim().Length == 0)
            {
                MessageBox.Show("FALTA VALOR PARA CAMPO CLAVE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDescripcion.Text = string.Empty;
                return dt;
            }
            if (CampoDescripcion.Trim().Length == 0)
            {
                MessageBox.Show("FALTA VALOR PARA CAMPO DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDescripcion.Text = string.Empty;
                return dt;
            }


            dt = LINQTablaFiltraMultiple(dtBusca, txtClave.Text, CampoClave);
            if (dt.Rows.Count > 0)
                lblDescripcion.Text = dt.Rows[0][CampoDescripcion].ToString();
            else
            {
                txtClave.Text = string.Empty;
                lblDescripcion.Text = string.Empty;
            }

            return dt;
        }
        #endregion



        public static string Left(string param, int length)
        {

            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {

            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        public static string Mid(string param, int startIndex)
        {
            string result = param.Substring(startIndex);
            return result;

        }

        public string CentrarCadena(int Ancho, string Cadena)
        {
            string res = string.Empty;
            int Posiciones = (Ancho - Cadena.Length) / 2;
            res = Repeat(' ', Posiciones) + Cadena.Trim() + Repeat(' ', Ancho - Cadena.Trim().Length - Posiciones);
            return res;
        }

        public string Repeat(char instr, int n)
        {
            int totalLength = n;//instr.Length * n;
            StringBuilder resultString = new StringBuilder(totalLength);
            for (var i = 0; i < n; i++)
                resultString.Append(instr);

            return resultString.ToString();
        }


        public string DevuelveCamposBusqueda(System.Data.DataTable dt)
        {
            string Campos = string.Empty;
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Columns.Contains("CamposBusqueda"))
                    {
                        if (dt.Rows[0]["CamposBusqueda"] != null)
                        {
                            if (dt.Rows[0]["CamposBusqueda"].ToString().Length > 0)
                                Campos = dt.Rows[0]["CamposBusqueda"].ToString();
                            else
                                Campos = IdentificaCamposBuqueda(dt);
                        }
                        else
                            Campos = IdentificaCamposBuqueda(dt);
                    }
                    else
                        Campos = IdentificaCamposBuqueda(dt);
                }
            }

            //Quitar espacios, se supone no hay espacios en los nombres de los campos
            Campos = Campos.Replace(" ", "");

            return Campos;

        }
        private string IdentificaCamposBuqueda(System.Data.DataTable dt)
        {
            string Campos = string.Empty;
            var colTypes = dt.Columns.Cast<DataColumn>()
                   .Where(c => c.DataType == typeof(int) || c.DataType == typeof(Int16) || c.DataType == typeof(Int32) || c.DataType == typeof(Int64) || c.DataType == typeof(decimal) || c.DataType == typeof(string) && (c.ColumnName != "CamposBusqueda"))
                   .Select(c => new
                   {
                       c.ColumnName,
                       c.DataType
                   })
                   .ToDictionary(key => key.ColumnName, val => val.DataType);

            Campos = string.Join(",", colTypes.Select(c => c.Key.ToString()));
            //var cam = colTypes.Select( dc=> string.Join(",", dc.Key.ToString()));

            return Campos;
        }


        public void BorraColumnaCamposBusqueda(ref System.Data.DataTable dt)
        {
            if (dt.Columns.Contains("CamposBusqueda"))
                dt.Columns.Remove("CamposBusqueda");
        }

        //Utilizar cuando se trate de tablas de cruces regularme con 2 campos
        public System.Data.DataTable LINQTablaCrucesFiltra(System.Data.DataTable dtAFiltrar, int ValorLlave1, int ValorLlave2)
        {

            System.Data.DataTable dtRes = new System.Data.DataTable();

            var res = from c in dtAFiltrar.AsEnumerable()
                      select c;

            res = res.Where(o => o.Field<int>(0) == ValorLlave1 && o.Field<int>(1) == ValorLlave2);

            if (res.Any())
            {
                dtRes = res.CopyToDataTable();
            }


            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);

            return dtRes;
        }

        public System.Data.DataTable LINQTablaFiltra(System.Data.DataTable dtAFiltrar, object ValorBuscar, string Campo, string CampoLlave = "", object ValorCampoLlave = null)
        {
            System.Data.DataTable dtRes = new System.Data.DataTable();
            if (ValorBuscar.ToString().Trim() == "System.Data.DataRowView")
                return dtRes;
            if (ValorBuscar.ToString().Trim().Length == 0)
                return dtRes;

            if (!dtAFiltrar.Columns.Contains(Campo))
            {
                MessageBox.Show("CAMPO INDICADO NO EXISTE DENTRO DE LA TABLA...FAVOR DE VERIFICAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dtRes;
            }

            var res = from c in dtAFiltrar.AsEnumerable()
                      select c;

            try
            {

                if (CampoLlave.Trim().Length > 0)
                {
                    //if (EsNumero(ValorCampoLlave) && EsNumero(ValorBuscar))
                    // res = res.Where(o => o.Field<int>(CampoLlave) != null && o.Field<int>(CampoLlave) == Convert.ToInt32(ValorCampoLlave) && o.Field<int>(Campo) == Convert.ToInt32(ValorBuscar));
                    //else
                    //{
                    //    res = res.Where(o => o.Field<string>(Campo) != null && o.Field<string>(Campo).ToUpper().Contains(ValorBuscar.ToString().ToUpper()) && o.Field<string>(CampoLlave).ToUpper() == ValorCampoLlave.ToString());
                    //}
                }
                else
                {
                    if (ValorBuscar.GetType() == typeof(int))
                    {
                      //  res = res.Where(o => o.Field<int>(Campo) != null && o.Field<int>(Campo) == Convert.ToInt32(ValorBuscar));
                    }
                    if (ValorBuscar.GetType() == typeof(string))
                    {
                        res = res.Where(o => o.Field<string>(Campo) != null && o.Field<string>(Campo).ToUpper().Contains(ValorBuscar.ToString().ToUpper()));
                    }
                    if (ValorBuscar.GetType() == typeof(Boolean))
                    {
                      //  res = res.Where(o => o.Field<bool>(Campo) != null && o.Field<bool>(Campo) == Convert.ToBoolean(ValorBuscar));
                    }
                }


                if (res.Any())
                {
                    dtRes = res.CopyToDataTable();
                }
            }
            catch
            {
                MessageBox.Show("ERROR AL FILTRAR BUSQUEDA LINQ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);

            return dtRes;
        }

        public System.Data.DataTable TablaColumnasTipoString(System.Data.DataTable dt)
        {
            System.Data.DataTable dtRes = dt.Clone();
            foreach (DataColumn col in dtRes.Columns)
                col.DataType = typeof(string);

            foreach (DataRow ren in dt.Rows)
                dtRes.ImportRow(ren);



            return dtRes;
        }


        public System.Data.DataTable LINQTablaFiltraMultiple(System.Data.DataTable dtAFiltrar, string ValorBuscar, string CamposBusqueda = "")
        {
            System.Data.DataTable dtRes = dtAFiltrar.Clone();
            string[] campos = CamposBusqueda.Split(',');

            //var colTypes = dtAFiltrar.Columns.Cast<DataColumn>()           
            //      .Select(c => new
            //      {
            //          c.ColumnName,
            //          c.DataType
            //      })
            //      .ToDictionary(key => key.ColumnName, val => val.DataType);

            var cols = dtAFiltrar.Columns.Cast<DataColumn>().Where(c => campos.Contains(c.ColumnName)); //Valida que existan los campos a buscar
            if (cols.Any())
            {
                var fuente = from c in TablaColumnasTipoString(dtAFiltrar).AsEnumerable()
                             select c;

                var filtro = fuente;

                for (int a = 0; a < campos.Length; a++)
                {
                    filtro = fuente.Where(o => o.Field<string>(campos[a]) != null && o.Field<string>(campos[a]).Contains(ValorBuscar.ToUpper()));
                    if (filtro.Any())
                    {
                        foreach (var row in filtro)
                        {
                            dtRes.ImportRow(row);
                        }
                    }
                }
            }

            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);
            //dtRes = dtRes.AsEnumerable().Distinct().CopyToDataTable(); NO marca error, pero hace el distinct
            return dtRes;
        }

        public System.Data.DataTable LINQTablaFiltroExactoMultiple(System.Data.DataTable dtAFiltrar, string ValorBuscar, string CamposBusqueda = "")
        {
            System.Data.DataTable dtRes = dtAFiltrar.Clone();
            string[] campos = CamposBusqueda.Split(',');

            //var colTypes = dtAFiltrar.Columns.Cast<DataColumn>()           
            //      .Select(c => new
            //      {
            //          c.ColumnName,
            //          c.DataType
            //      })
            //      .ToDictionary(key => key.ColumnName, val => val.DataType);

            var cols = dtAFiltrar.Columns.Cast<DataColumn>().Where(c => campos.Contains(c.ColumnName)); //Valida que existan los campos a buscar
            if (cols.Any())
            {
                var fuente = from c in TablaColumnasTipoString(dtAFiltrar).AsEnumerable()
                             select c;

                var filtro = fuente;

                for (int a = 0; a < campos.Length; a++)
                {
                    filtro = fuente.Where(o => o.Field<string>(campos[a]) != null && o.Field<string>(campos[a]).Equals(ValorBuscar.ToUpper()));
                    if (filtro.Any())
                    {
                        foreach (var row in filtro)
                        {
                            dtRes.ImportRow(row);
                        }
                    }
                }

            }



            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);
            //dtRes = dtRes.AsEnumerable().Distinct().CopyToDataTable(); NO marca error, pero hace el distinct
            return dtRes;
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (BaseGrid == null)
                return false;
            if ((!BaseGrid.Focused))
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData != Keys.Enter)
                return base.ProcessCmdKey(ref msg, keyData);

            ProcesoSeleccionaRegistro();
            return true;
        }

        public virtual void ProcesoSeleccionaRegistro(string NombreColumna = "")
        {

        }

        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);
                if (c is System.Windows.Forms.TextBox || c is ComboBox || c is DateTimePicker || c is System.Windows.Forms.CheckBox || c is DataGridView)
                {
                    //ControlList.Add(c);
                    c.KeyUp += new KeyEventHandler(Control_KeyUp);
                }

                if (c is System.Windows.Forms.TextBox || c is ComboBox || c is DateTimePicker)
                {
                    c.Enter += new EventHandler(c_Enter);
                    c.Leave += new EventHandler(c_Leave);
                }

                if (c is System.Windows.Forms.TextBox)
                {
                    c.KeyPress += new KeyPressEventHandler(c_KeyPress);
                }

                if (c is ComboBox)
                {
                    ComboBox combo = (ComboBox)c;
                    combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);
                }

                //Encontrar el grid en la forma para copiar renglones
                if (c is DataGridView)
                {
                    if (BaseGridSinFormato == false)
                    {
                        ////TODO: *****AQUI SE CONFIGURAN LAS PROPIEDADES GENERALES PARA TODOS LOS GRIDS
                        //BaseGrid = (DataGridView)c;
                        //BaseGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                        //BaseGrid.RowHeadersVisible = false;
                        //BaseGrid.BackgroundColor = Color.White;
                        //BaseGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        //BaseGrid.AllowUserToAddRows = false;
                        //BaseGrid.AllowUserToDeleteRows = false;
                        //BaseGrid.BorderStyle = BorderStyle.None;

                        //BaseGrid.AllowUserToResizeColumns = true;
                        //BaseGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        //BaseGrid.MultiSelect = false;
                        //BaseGrid.ReadOnly = true;
                        //BaseGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

                        //BaseGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 51, 102);
                        //BaseGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 153, 51);
                        //BaseGrid.EnableHeadersVisualStyles = false;

                        //BaseGrid.CellFormatting += new DataGridViewCellFormattingEventHandler(BaseGrid_CellFormatting);
                    }
                }

            }
        }

        void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (combo.SelectedValue == null)
                return;
            if (combo.SelectedValue.ToString().Trim() == "System.Data.DataRowView")
                return;
        }

        void BaseGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grd = (DataGridView)sender;
            foreach (DataGridViewColumn column in grd.Columns)
            {
                if (column.ReadOnly == true)
                    column.DefaultCellStyle.BackColor = Color.White;
            }

        }

        void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            if (txt.Tag != null)
            {
                if (txt.Tag.ToString().Trim().ToUpper() == "ENTERO")
                {
                    ValidaSeaNumero(ref e);
                }
                if (txt.Tag.ToString().Trim().ToUpper() == "DECIMAL")
                {
                    ValidaSeaNumeroDecimal(ref e);
                }
                if (txt.Tag.ToString().Trim().ToUpper() == "DECIMAL2")
                {
                    ValidaSeaNumeroDecimal(ref sender, ref e, 2);
                }
                if (txt.Tag.ToString().Trim().ToUpper() == "DECIMAL3")
                {
                    ValidaSeaNumeroDecimal(ref sender, ref e, 3);
                }
            }
        }

        void c_Enter(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString().Trim() == "DateTimePicker")
            {
                DateTimePicker txt = (DateTimePicker)sender;
                FormatoTextoEntra(ref txt);
            }
            if (sender.GetType().Name.ToString().Trim() == "TextBox")
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                FormatoTextoEntra(ref txt);
            }
            if (sender.GetType().Name.ToString().Trim() == "ComboBox")
            {
                ComboBox cmb = (ComboBox)sender;
                FormatoTextoEntra(ref cmb);
            }
        }

        void c_Leave(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString().Trim() == "DateTimePicker")
            {
                DateTimePicker txt = (DateTimePicker)sender;
                FormatoTextoSale(ref txt);
            }
            if (sender.GetType().Name.ToString().Trim() == "TextBox")
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                FormatoTextoSale(ref txt);
                if (txt.Tag != null)
                {
                    if (txt.Tag.ToString().Trim().ToUpper() == "DECIMAL")
                    {
                        if (!EsNumero(txt.Text))
                            txt.Text = string.Empty;
                    }
                }

            }
            if (sender.GetType().Name.ToString().Trim() == "ComboBox")
            {
                ComboBox cmb = (ComboBox)sender;
                FormatoTextoSale(ref cmb);
            }
        }

        public bool EsNumero(object Expression)
        {
            bool isNum; 
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void FormatoTextoEntra(ref System.Windows.Forms.TextBox txt)
        {
            if (GlobalVar.NombreForma != "SEGURIDAD.FRM_MENUS")
                txt.CharacterCasing = CharacterCasing.Upper;
            //txt.BackColor = Color.FromArgb(59, 89, 152);
            //txt.BackColor = Color.FromArgb(0, 51, 102);
            //txt.ForeColor = Color.White;
        }
        private void FormatoTextoSale(ref System.Windows.Forms.TextBox txt)
        {
            if (GlobalVar.NombreForma != "SEGURIDAD.FRM_MENUS")
                txt.CharacterCasing = CharacterCasing.Upper;
            //txt.ForeColor = Color.Black;
            //txt.BackColor = Color.White;
        }

        private void FormatoTextoEntra(ref ComboBox cmb)
        {
            cmb.KeyPress += cmb_KeyPres;
            // cmb.BackColor = Color.FromArgb(0, 51, 102);
            //cmb.ForeColor = Color.White;
        }
        private void cmb_KeyPres(object sender, KeyPressEventArgs e)
        {
           if(GlobalVar.NombreForma!= "SEGURIDAD.FRM_MENUS")
                e.Handled = true;
        }
        private void FormatoTextoEntra(ref DateTimePicker txt)
        {
            //txt.BackColor = Color.FromArgb(0, 51, 102);
            //txt.ForeColor = Color.White;
        }

        private void FormatoTextoSale(ref ComboBox cmb)
        {
            //cmb.ForeColor = Color.Black;
            //cmb.BackColor = Color.White;
        }
        private void FormatoTextoSale(ref DateTimePicker txt)
        {
            //txt.ForeColor = Color.Black;
            //txt.BackColor = Color.White;
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {

                //if (sender.GetType().Name.ToString().Trim() != "DataGridView")
                //{
                //    this.SelectNextControl((Control)sender, true, true, true, true);
                //}
                //else
                //{
                //    SendKeys.Send("{TAB}");
                //}

            }
        }


        public void LlenaCombo(System.Data.DataTable dt, ref ComboBox cmb, string CampoValor = "", string CampoDescripcion = "", int Index = -1)
        {
            //Si no mandan campos valor y descripción quiere decir que puedo tomar los campos 0 y 1
            cmb.DataSource = dt;
            if (CampoValor.Trim().Length > 0 && CampoDescripcion.Trim().Length > 0)
            {
                cmb.ValueMember = CampoValor;
                cmb.DisplayMember = CampoDescripcion;
            }
            else
            {
                cmb.ValueMember = dt.Columns[0].ColumnName;
                cmb.DisplayMember = dt.Columns[1].ColumnName;
            }
            cmb.SelectedIndex = Index;
            cmb.Leave += new EventHandler(cmb_Leave);

            if (CampoDescripcion.Trim().Length > 0)
            {
                if (cmb.Tag != "SINCLASE")
                    AutoCompletar(ref cmb, dt, CampoDescripcion);
            }
        }



        public void AutoCompletar(ref ComboBox cmb, System.Data.DataTable dt, string Campo)
        {
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    AutoCompleteStringCollection ColeccionColonias = new AutoCompleteStringCollection();
                    List<DataRow> list = dt.AsEnumerable().ToList();
                    string[] st = list.Select(ss => ss[Campo].ToString()).ToArray();
                    cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    ColeccionColonias.AddRange(st);
                    cmb.AutoCompleteCustomSource = ColeccionColonias;
                    cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        void cmb_Leave(object sender, EventArgs e)
        {
            ComboBox cmbpaso = (ComboBox)sender;
            if (cmbpaso.SelectedValue == null)
                cmbpaso.Text = string.Empty;
        }

        public void ValidaSeaNumero(ref KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void ValidaSeaNumeroDecimal(ref KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 46) //46 = . (punto)
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void ValidaSeaNumeroDecimal(ref object sender, ref KeyPressEventArgs e, int longitud = 0)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (textBox.Text.Length == 1)
                {
                    if (textBox.Text == ".")
                    {
                        e.Handled = false;
                        return;
                    }
                }
                //alue = "1,643.57";
                //if (Decimal.TryParse(value, out number))
                 //  Console.WriteLine(number);
                //else
                //    
                //Console.WriteLine("Unable to parse '{0}'.", value);

                //if (Convert.ToDecimal((Boolean)(textBox.Text.Length == 0) ? "0" : textBox.Text.Replace("$", "0")) >= Convert.ToDecimal((float.MaxValue)))
                //{
                //    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    e.Handled = true;
                //}
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
                    if ((parts[1].Length > (longitud - 1) && longitud != 0) && e.KeyChar != (char)Keys.Back)
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

        private void Forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) //Escape
            {
                //if (GlobalVar.CatalogoPropiedadB_Editando == false && GlobalVar.CatalogoPropiedadB_Agregando == false)
                string pregunta = string.Empty;
                if (GlobalVar.CatalogoPropiedadB_Editando)
                    pregunta = "ESTA EN MODO EDICION, SE PERDERA LA NUEVA INFORMACION CAPTURADA";
                if (GlobalVar.CatalogoPropiedadB_Agregando)
                    pregunta = "ESTA AGREGANDO NUEVA INFORMACION Y SE PERDERAN LOS CAMBIOS";
             
                if (pregunta.Trim().Length > 0)
                {
                    pregunta += "\n¿DESEA SALIR DE LA PANTALLA DE TODAS FORMAS?";
                    DialogResult dlg = MessageBox.Show(pregunta, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.No)
                    {
                        return;
                    }
                }

                BaseMetodoSalir();
            }
        }

        public virtual void BaseMetodoSalir()
        {
            Close();
        }

        public void cambia_fuente_controles()
        {
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c.Name != "txt_Buscar" && c.Name != "lbl_Buscar" && c.Name != "txtweb")
                {
                    if (c is System.Windows.Forms.TextBox)
                    {

                        c.Font = new System.Drawing.Font("Arial", 10.50F, FontStyle.Regular);
                        System.Windows.Forms.TextBox tb2 = (System.Windows.Forms.TextBox)c;
                        tb2.CharacterCasing = CharacterCasing.Upper;
                    }
                    if (c is System.Windows.Forms.Label)
                    {
                        c.Font = new System.Drawing.Font("Arial", 9.5F, FontStyle.Regular);

                    }
                    if (c is System.Windows.Forms.ComboBox)
                    {

                        c.Font = new System.Drawing.Font("Arial", 10.50F, FontStyle.Regular);

                    }
                }
            }
        }

        private void Forma_Resize(object sender, EventArgs e)
        {
            ////check if the child form has been resized and is visible so that the code only executes when the child form is
            ////being minimized.
            //if (this.WindowState == FormWindowState.Minimized && this.Visible)
            //{
            //    //Form1 is the MDI Parent form. You should replace this with the name of your MDI Parent form.
            //    Principal frmMain;


            //    //typecast the MDIParent of the child form that is being minimized so that we can call the
            //    //MinimizeWindowsOnStausBar function on the MDI Parent.
            //    frmMain = (Principal)this.MdiParent;


            //    ////Call the MinimizeWindowsOnStausBar function which will create the effect of window being minimized onto the
            //    ////status bar.
            //    //frmMain.MinimizeWindowsOnStausBar(this);
            //}
        }

        public decimal Truncar(decimal value, int length)
        {

            string[] param = value.ToString().Split('.');

            if (param.Length > 1)
            {
                if (param[1].Length >= length)
                    return Convert.ToDecimal(param[0] + "." + param[1].Substring(0, length));
                else
                    return Convert.ToDecimal(param[0] + "." + param[1].Substring(0, param[1].Length));
            }
            else
                return Convert.ToDecimal(param[0]);
        }

        public void ConectaReporte(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt)
        {
            ConnectionInfo miConexionInfo = new ConnectionInfo();
            //string sConexion = System.Configuration.ConfigurationManager.AppSettings["cnERP"].ToString();

            string sConexion = string.Empty;
            string Servidor = string.Empty;
            string Base = string.Empty;
            string Usuario = string.Empty;
            string Contrasena = string.Empty;


            string ConexionActiva = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
            if (ConexionActiva.Trim().ToUpper() == "LOCAL")
            {
                Servidor = ConfigurationManager.AppSettings["ServidorLocal"].ToString();
                Base = ConfigurationManager.AppSettings["BaseLocal"].ToString();
                Usuario = ConfigurationManager.AppSettings["UsuarioLocal"].ToString();
                Contrasena = ConfigurationManager.AppSettings["ContrasenaLocal"].ToString();
            }
            else
            {
                Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
                Base = ConfigurationManager.AppSettings["Base"].ToString();
                Usuario = ConfigurationManager.AppSettings["Usuario"].ToString();
                Contrasena = ConfigurationManager.AppSettings["Contrasena"].ToString();
            }

            sConexion = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + ";Connect Timeout=0; pooling='true'; Max Pool Size=200";


            System.Data.SqlClient.SqlConnectionStringBuilder sqlsbuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(sConexion);

            miConexionInfo.DatabaseName = sqlsbuilder.InitialCatalog;
            miConexionInfo.UserID = sqlsbuilder.UserID;
            miConexionInfo.Password = sqlsbuilder.Password;
            miConexionInfo.ServerName = sqlsbuilder.DataSource;
            miConexionInfo.IntegratedSecurity = false;

            Tables myTables = rpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table myTable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = myTable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = miConexionInfo;
                myTable.ApplyLogOnInfo(myTableLogonInfo);
            }
        }

      

        public void ConectaReporte(ref ReportDocument rpt, System.Data.DataTable dtReporte, string TituloReporte, string ModuloReporte, string Version = "V1", bool B_ConSubReportes = true, bool B_ConectaSubReporte = false)
        {
            bool ConTiempo = true;
            int Tiempo = 0;
            ConnectionInfo miConexionInfo = new ConnectionInfo();
            //string sConexion = System.Configuration.ConfigurationManager.AppSettings["cnERP"].ToString();

            string sConexion = string.Empty;
            string Servidor = string.Empty;
            string Base = string.Empty;
            string Usuario = string.Empty;
            string Contrasena = string.Empty;

            //string ConexionActiva = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
            string ConexionActiva = GlobalVar.Conexion;
            if (GlobalVar.Conexion == "PRODUCCION")
            {
                Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
                Base = ConfigurationManager.AppSettings["Base"].ToString();
                Usuario = ConfigurationManager.AppSettings["Usuario"].ToString();
                Contrasena = ConfigurationManager.AppSettings["Contrasena"].ToString();
            }
            else
            {
                Servidor = ConfigurationManager.AppSettings["ServidorPruebas"].ToString();
                Base = ConfigurationManager.AppSettings["BasePruebas"].ToString();
                Usuario = ConfigurationManager.AppSettings["UsuarioPruebas"].ToString();
                Contrasena = ConfigurationManager.AppSettings["ContrasenaPruebas"].ToString();
            }

            //sConexion = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + ";Connect Timeout=0; pooling='true'; Max Pool Size=200";

            if (ConTiempo == true)
                sConexion = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + ";connect timeout=" + Tiempo.ToString().Trim() + "; pooling='true'; Max Pool Size=200";
            else
                sConexion= "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + "; pooling='true'; Max Pool Size=200";

            System.Data.SqlClient.SqlConnectionStringBuilder sqlsbuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(sConexion);
  
            miConexionInfo.DatabaseName = sqlsbuilder.InitialCatalog;
            miConexionInfo.UserID = sqlsbuilder.UserID;
            miConexionInfo.Password = sqlsbuilder.Password;
            miConexionInfo.ServerName = sqlsbuilder.DataSource;
            miConexionInfo.IntegratedSecurity = false;

            Tables myTables = rpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table myTable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = myTable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = miConexionInfo;
                myTable.ApplyLogOnInfo(myTableLogonInfo);
            }

            if (B_ConectaSubReporte)
            {
                Sections sections = rpt.ReportDefinition.Sections;

                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;

                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;

                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);

                            Tables myTablesSR = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table myTable in myTablesSR)
                            {
                                TableLogOnInfo myTableLogonInfo = myTable.LogOnInfo;
                                myTableLogonInfo.ConnectionInfo = miConexionInfo;
                                myTable.ApplyLogOnInfo(myTableLogonInfo);
                            }
                        }
                    }
                }
            }


            string NomFisico = rpt.ToString();
            NomFisico = NomFisico.Replace("ProbeMedic.REPORTES.", "");

            if (dtReporte != null)
            {
                rpt.SetDataSource(dtReporte);
            }

            if (B_ConSubReportes)
            {
                rpt.SetParameterValue("D_Empresa", Empresa.D_Empresa);
                rpt.SetParameterValue("RFC", Empresa.RFC);
                rpt.SetParameterValue("D_Pais", "MEXICO");
                rpt.SetParameterValue("C_Estado", Empresa.C_Estado);
                rpt.SetParameterValue("D_Ciudad", Empresa.D_Ciudad);
                rpt.SetParameterValue("Colonia", Empresa.Colonia);
                rpt.SetParameterValue("Calle", Empresa.Calle);    
                rpt.SetParameterValue("CodigoPostal", Empresa.CodigoPostal);    
                rpt.SetParameterValue("NoExterior",Empresa.NoExterior);
                //rpt.SetParameterValue("NoInterior", Empresa.NoInterior);
                rpt.SetParameterValue("Telefono", Empresa.Telefono);
                rpt.SetParameterValue("Telefono_Fax", Empresa.Telefono_Fax);
                rpt.SetParameterValue("Fax", 0);
                rpt.SetParameterValue("Version", "");
                rpt.SetParameterValue("NombreReporte", NomFisico);
                rpt.SetParameterValue("Modulo", ModuloReporte);
                rpt.SetParameterValue("TituloReporte", TituloReporte);
            }
        }

        public string TxtImporteToStr(ref System.Windows.Forms.TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(ref txtImporte));
            //if (dblImporte == 0)
            //{
            //    return "";
            //}
            //else
            //{
                return dblImporte.ToString("C");
            //}
        }
        public string TxtImporteToDec(ref System.Windows.Forms.TextBox txtImporte)
        {
            if (txtImporte.Text.Trim().Length == 0)
            {
                return "0";
            }
            else
            {
                return txtImporte.Text.Replace("$", "").Replace(",", "");
            }
        }

        public string LblImporteToStr(ref System.Windows.Forms.Label lblImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(LblImporteToDec(ref lblImporte));
            //if (dblImporte == 0)
            //{
            //    return "";
            //}
            //else
            //{
                return dblImporte.ToString("C");
            //}
        }
        public string LblImporteToDec(ref System.Windows.Forms.Label lblImporte)
        {
            if (lblImporte.Text.Trim().Length == 0)
            {
                return "0";
            }
            else
            {
                return lblImporte.Text.Replace("$", "").Replace(",", "");
            }
        }

        public static bool IsNumeric(string value)
        {

            try
            {

                char[] chars = value.ToCharArray();

                foreach (char c in chars)
                {

                    if (!char.IsNumber(c))

                        return false;

                }

                return true;

            }
            catch (Exception) { return false; }
        }
    }
}
