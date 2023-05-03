﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Collections;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Xml;
using System.Xml.Serialization;

namespace ProbeMedic.CXP
{
    public partial class Frm_CuentasxPagar : FormaBase
    {

        public string PropiedadRuta { get; set; }
        public string[] PropiedadRutas { get; set; }
        public XmlDocument PropiedadXML { get; set; }
        public Comprobante PropiedadFactura { get; set; }

        Funciones fx = new Funciones();
        SQLCompras sqlCompras = new SQLCompras();
        SQLCuentasxPagar sqlCxP = new SQLCuentasxPagar();
        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        DataTable dtOrdenes = new DataTable();
        DataTable dtProveedores = new DataTable();
        DataTable dtDetalle = new DataTable();

        int res = 0;
        string msg = string.Empty;
        decimal gdTasaIva = 0;
        string VersionXML = string.Empty;
        XmlDocument cfdi;

        public Frm_CuentasxPagar()
        {
            BaseHabilitaArrastrar = true;
            BaseGridSinFormato = true;
            InitializeComponent();


            seleccionaArchivoXML1.LabelAquiClick += new Controles.SeleccionaArchivoXML.UserControlClickHandler(seleccionaArchivoXML1_LabelAquiClick);            
        }

        private void FormatoGrid()
        {
            grdDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grdDatos.RowHeadersVisible = false;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDatos.AllowUserToAddRows = false;
            grdDatos.AllowUserToDeleteRows = false;
            grdDatos.BorderStyle = BorderStyle.None;

            grdDatos.AllowUserToResizeColumns = true;
            grdDatos.MultiSelect = false;
            grdDatos.ReadOnly = true;
            grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDatos.EnableHeadersVisualStyles = false;
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList.Images["zoom.png"]));
            BaseBotonProceso1.Text = "OC Sin Factura";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso1.Width = 110;

            grdDatos.AutoGenerateColumns = false;
            FormatoGrid();

            dtOrdenes = sqlCompras.Sk_ConsultaOrdenesCompra(2, false);
            BaseDtDatos = dtOrdenes;


            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            if (dtMoneda != null)
            {
                LlenaCombo(dtMoneda, ref cmbMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 0);
                cmbMoneda.SelectedIndex = 0;

            }

            if (GlobalVar.dtImpuestos != null)
            {
                //LlenaCombo(GlobalVar.dtImpuestos, ref cmbTasaIva, "K_Impuesto", "D_Impuesto");
                //cmbTasaIva.SelectedIndex = 0;
            }

            if (GlobalVar.dtUnidadMedida != null)
            {
                //LlenaCombo(GlobalVar.dtUnidadMedida, ref cmbDetalleUnidadMedida, "K_Unidad_Medida", "D_Unidad_Medida");
                //cmbDetalleUnidadMedida.SelectedIndex = 0;
            }

            dtProveedores = sqlCatalogos.Sk_Proveedores();


            pnlArriba.Enabled = false;
            txtNoOrden.Focus();
            base.BaseMetodoInicio();
        }
        public override void BaseBotonProceso1Click()
        {
            DateTime? f1 = new DateTime();
            f1 = fx.PrimerDiaDelMes(DateTime.Now);
            DateTime? f2 = new DateTime();
            f2 = fx.UltimoDiaDelMes(DateTime.Now);

            Cursor = Cursors.WaitCursor;
            DataTable dtOC = sqlCompras.Sk_ConsultaOrdenesCompra(0, GlobalVar.K_Oficina, 0, 6, 1, false, f1, f2, 0, 0, 0, 0, null,true);
            if(dtOC!=null)
                dtOC.DefaultView.Sort = "K_Orden_Compra DESC";
            Busquedas.BuscaOrdenesCompra frm = new Busquedas.BuscaOrdenesCompra();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOC);
            frm.BusquedaPropiedadTablaFiltra = dtOC;

            if (dtOC != null)
            {
                if (dtOC.Rows.Count == 1)
                {
                    txtNoOrden.Text = dtOC.Rows[0]["K_Orden_Compra"].ToString();
                }
                else if (dtOC.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Ordenes de Compra Sin Factura";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        txtNoOrden.Text = frm.BusquedaPropiedadReglonRes["K_Orden_Compra"].ToString();
                    }
                    else
                    {
                        txtNoOrden.Text = string.Empty;
                    }

                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;

        }
        public override void BaseMetodoLimpiaControles()
        {
            txtNoOrden.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtFolio.Text = string.Empty;
            txtFolioFiscal.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            //cmbMoneda.Text = string.Empty;
            //txtTipoCambio.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            //cmbTasaIva.Text = string.Empty;
            txtTotalIVA.Text = string.Empty;
            txtTasaRetencionIVA.Text = "0";
            txtTotalRetencionIVA.Text = "0";
            txtTasaISR.Text = "0";
            txtTotalISR.Text = "0";
            txtTotal.Text = string.Empty;            
            //cmbTasaIva.SelectedIndex = 0;            
            pnlArriba.Enabled = false;

            dtDetalle = DetalleCxp_Type;
            grdDatos.DataSource = null;
            LimpiaControlesDetalle();
        }

        public override void BaseBotonNuevoClick()
        {
            //grdRequisiciones.ClearSelection();

            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;

            pnlArriba.Enabled = true;

            txtNoOrden.Focus();

            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            //dtDatos.Rows.Clear();
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            int CampoIdentity = 0;
            int K_OrdenCompra = 0;
            int K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            decimal TipoCambio = 1;
            decimal Subtotal = 0;
            decimal TotalIVA = 0;
            decimal TasaRetencionIVA = 0;
            decimal TotalRetencionIVA = 0;
            decimal TasaISR = 0;
            decimal TotalISR = 0;
            decimal TotalFactura = 0;

            res = 0;
            msg = string.Empty;

            if (txtNoOrden.Text.Trim().Length > 0)
                K_OrdenCompra = Convert.ToInt32(txtNoOrden.Text);
            short TipoMoneda = Convert.ToInt16(cmbMoneda.SelectedIndex);
            // Cuenta x PAGAR en DLLS
            if ((TipoMoneda == 1) && (txtTipoCambio.Text.ToString().Length <= 0))
            {
                MessageBox.Show("PARA LAS FACTURAS RECIBIDAS EN DOLARES SE DEBE INDICAR EL TIPO DE CAMBIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipoCambio.Focus();
                return;
            }
            TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);
            if ((TipoMoneda == 1) && (TipoCambio <= 1))
            {
                MessageBox.Show("PARA LAS FACTURAS RECIBIDAS EN DOLARES SE DEBE INDICAR UN TIPO DE CAMBIO VALIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipoCambio.Focus();
                return;
            }
            if (TipoMoneda == 1) //DLLS
                TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);

            DateTime Fecha = DateTime.Today;
            if (txtFechaFactura.Value != null)
                Fecha = Convert.ToDateTime(txtFechaFactura.Value.ToShortDateString());
            DateTime Vencimiento = DateTime.Today;
            if (txtFechaVencimiento.Value != null)
                Vencimiento = Convert.ToDateTime(txtFechaVencimiento.Value.ToShortDateString());

            if (txtSubtotal.Text.Trim().Length > 0)
                Subtotal = Convert.ToDecimal(txtSubtotal.Text.Replace('$', ' '));
            if (txtTotalIVA.Text.Trim().Length > 0)
                TotalIVA = Convert.ToDecimal(txtTotalIVA.Text.Replace('$', ' '));
            if (txtTasaRetencionIVA.Text.Trim().Length > 0)
                TasaRetencionIVA = Convert.ToDecimal(txtTasaRetencionIVA.Text.Replace('$', ' '));
            if (txtTotalRetencionIVA.Text.Trim().Length > 0)
                TotalRetencionIVA = Convert.ToDecimal(txtTotalRetencionIVA.Text.Replace('$', ' '));
            if (txtTasaISR.Text.Trim().Length > 0)
                TasaISR = Convert.ToDecimal(txtTasaISR.Text.Replace('$', ' '));
            if (txtTotalISR.Text.Trim().Length > 0)
                TotalISR = Convert.ToDecimal(txtTotalISR.Text.Replace('$', ' '));
            if (txtTotal.Text.Trim().Length > 0)
                TotalFactura = Convert.ToDecimal(txtTotal.Text.Replace('$', ' '));

            DataTable dtDet = new DataTable();
            dtDet = dtDetalle;
            dtDet.Columns.Remove("B_Manual");
            dtDet.Columns.Remove("Id");

            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCxP.In_CxP(ref CampoIdentity, Convert.ToInt32(txtClaveProveedor.Text), txtFolioFiscal.Text, txtSerie.Text, txtFolio.Text, TipoCambio, Convert.ToInt32(cmbMoneda.SelectedValue), Subtotal, gdTasaIva, TotalIVA, TasaRetencionIVA, TotalRetencionIVA, TasaISR, TotalISR, TotalFactura, Fecha, K_OrdenCompra, Vencimiento, true, txtObservaciones.Text, VersionXML, "CAPTURA", GlobalVar.K_Usuario, dtDet, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "CUENTA POR PAGAR GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();

                    BaseErrorResultado = false;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveProveedor.Focus();
                return false;
            }
            if (txtSubtotal.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL SUBTOTAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubtotal.Focus();
                return false;
            }
            if (txtTotal.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TOTAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Focus();
                return false;
            }
            if (txtNoOrden.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoOrden.Focus();
                return false;
            }
            if (grdDatos.Rows.Count == 0)
            {
                MessageBox.Show("NO HA CAPTURADO DETALLES PARA LA CUENTA POR PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDetalleCantidad.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        public override void BaseBotonCancelarClick()
        {
            //grdOrdenCompra.DataSource = null;

            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseMetodoLimpiaControles();
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = false;
            BasePropiedadId_Identity = 0;


            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = false;
            //grdRequisiciones.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (txtDetalleCantidad.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR CANTIDAD..!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    txtDetalleCantidad.Focus();
            //    return;
            //}
            //if (txtDetalleConcepto.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR CONCEPTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDetalleConcepto.Focus();
            //    return;
            //}
            //if (txtDetallePrecioUnitario.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR PRECIO UNITARIO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDetallePrecioUnitario.Focus();
            //    return;
            //}
            //if (txtDetalleImporte.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR IMPORTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDetalleImporte.Focus();
            //    return;
            //}
            //AgregaDetalle();
            //CalculaTotales();
            //txtDetalleCantidad.Focus();
        }

        private void btnBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            if (txtNoOrden.Text.Trim().Length > 0)
            {
                MuestraDatosOC();
                return;
            }

            //Busquedas.BuscaOrdenesCompra frm = new Busquedas.BuscaOrdenesCompra();
            //frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOrdenes);
            //frm.BusquedaPropiedadTablaFiltra = dtOrdenes;
            //frm.BusquedaPropiedadTitulo = "Busca Ordenes de Compra";
            //frm.ShowDialog();
            //if (frm.BusquedaPropiedadReglonRes != null)
            //{
            //    txtNoOrden.Text = frm.BusquedaPropiedadReglonRes["K_Orden_Compra"].ToString();
            //    MuestraDatosOC();
            //}
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
            }
        }

        private void seleccionaArchivoXML1_Load(object sender, EventArgs e)
        {
            if (seleccionaArchivoXML1.PropiedadRuta != null)
            {
                //BaseBotonNuevoClick();
                Comprobante factura = seleccionaArchivoXML1.PropiedadFactura;
                cfdi = seleccionaArchivoXML1.PropiedadXML;
                BaseMetodoArrastrar(factura, cfdi);
            }
        }

        public override void BaseMetodoArrastrar(Comprobante factura, XmlDocument xDoc = null)
        {
            if (factura == null)
                return;

            if (factura.TipoDeComprobante.ToString().Trim().ToUpper() != "I")
            {
                MessageBox.Show("EL TIPO DE COMPROBANTE NO ES DE INGRESO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // base.BaseMetodoArrastrar(factura);
            // BaseBotonNuevoClick();
            cfdi = xDoc;
            //btnNuevo_Click(this, null);
            DateTime FechaNva;
            string Serie = string.Empty;
            string Folio = string.Empty;
            if (factura.Serie != null)
                Serie = factura.Serie;
            if (factura.Folio != null)
                Folio = factura.Folio;
            txtSerie.Text = Serie;
            txtFolio.Text = Folio;
            txtFolioFiscal.Text = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();

            string RFCEmisor = factura.Emisor.Rfc;

            txtSubtotal.Text = factura.SubTotal.ToString();
            txtTotal.Text = factura.Total.ToString("C");
            txtFechaFactura.Value = factura.Fecha;
            txtFechaVencimiento.Value = factura.Fecha.AddDays(30);
            VersionXML = factura.Version;

            //factura.Impuestos.Traslados.AsEnumerable
            //dtArticulos = GlobalVar.dtArticulos.AsEnumerable().Where(p => p.Field<bool>("B_Activo") == true).CopyToDataTable<DataRow>();            

            txtTipoCambio.Text = "0.00";
            if (factura.TipoCambio != null)
                txtTipoCambio.Text = Truncar(Convert.ToDecimal(factura.TipoCambio), 4).ToString();

            decimal IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
            decimal TasaIVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
            decimal RetencionIVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
            decimal RetencionISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));

            DataTable dtPaso = (DataTable)ComprobantexTipo(factura, "ConceptosTabla");
            dtDetalle.Merge(dtPaso);
            grdDatos.DataSource = dtDetalle;

            txtTotalIVA.Text = IVA.ToString();

            if (RetencionIVA > 0)
            {
                txtTasaRetencionIVA.Text = "10.66";
                txtTotalRetencionIVA.Text = RetencionIVA.ToString();
            }
            if (RetencionISR > 0)
            {
                txtTasaISR.Text = "10";
                txtTotalISR.Text = RetencionISR.ToString();
            }

            //Buscar tipo iva si normal o frontera, con la TasaIVA
            var Impuestos = GlobalVar.dtImpuestos.AsEnumerable().Where(p => p.Field<decimal>("Porcentaje") == gdTasaIva);
            //short K_Impuesto = Impuestos.Min(p => p.Field<short>("K_Impuesto"));

            //DataRow ren = dtDatos.AsEnumerable().Where(p => p.Field<int>("K_Detalle_Requisicion") == K_Detalle_Requisicion).FirstOrDefault();
            //string D_Impuesto = string.Empty;
            //DataRow NombreImp = Impuestos.Where(p => p.Field<short>("K_Impuesto") == K_Impuesto).FirstOrDefault();
            //if (NombreImp != null)
            //    D_Impuesto = NombreImp["D_Impuesto"].ToString();

            //cmbTasaIva.SelectedValue = K_Impuesto;
            //cmbTasaIva.Text = D_Impuesto;

            //Proveedores
            string Nombre = string.Empty;
            int K_Proveedor = 0;
            DataRow NombreProv = dtProveedores.AsEnumerable().Where(p => p.Field<string>("RFC") == RFCEmisor).FirstOrDefault();
            if (NombreProv != null)
            {
                Nombre = NombreProv["D_Proveedor"].ToString();
                K_Proveedor = Convert.ToInt32(NombreProv["K_Proveedor"]);
                txtClaveProveedor.Text = K_Proveedor.ToString();
                txtClaveProveedor_Leave(null, null);
                txtProveedor.Text = Nombre;
            }
            else
            {
                MessageBox.Show("EL PROVEEDOR DEL ARCHIVO NO EXISTE REGISTRADO...!\r\nR.F.C.: " + RFCEmisor + "\r\nProveedor: " + factura.Emisor.Nombre + "\r\nDEBERA ENTRAR A LA OPCION DE PROVEEDORES A CAPTURARLO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void seleccionaArchivoXML1_LabelAquiClick(object sender, EventArgs e)
        {
            if (seleccionaArchivoXML1.PropiedadRutas != null)
            {
                try
                {
                    foreach (string archivo in seleccionaArchivoXML1.PropiedadRutas)
                    {
                        this.PropiedadRuta = archivo;
                        XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                        XmlTextReader reader = new XmlTextReader(@PropiedadRuta);
                        Comprobante Factura = (Comprobante)serializer.Deserialize(reader);
                        this.PropiedadFactura = Factura;
                        this.PropiedadXML = new XmlDocument();
                        this.PropiedadXML.Load(@PropiedadRuta);

                        //BaseBotonNuevoClick();
                        Comprobante factura = this.PropiedadFactura;
                        cfdi = this.PropiedadXML;
                        BaseMetodoArrastrar(factura, cfdi);
                        //if (dtEmpresa.Rows[0]["RFC"].ToString().Trim().ToUpper() == factura.Receptor.rfc.Trim().ToUpper())
                        //    PropiedadEsRFCValido = true;
                        //else
                        //    MessageBox.Show("EL R.F.C. RECEPTOR DEL ARCHIVO XML NO CORRESPONDE AL DE LA EMPRESA...!" , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ARCHIVO XML NO CUENTA CON FORMATO CORRECTO CORRESPONDIENTE A UN CFDI...!\r\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MuestraDatosOC()
        {
            int K_Orden_Compra = 0;

            if (txtNoOrden.Text.Trim().Length > 0)
                K_Orden_Compra = Convert.ToInt32(txtNoOrden.Text);

            if (K_Orden_Compra == 0)
                return;

            DataTable dtOC = new DataTable();
            bool B_Acepta = false;
            res = 0;
            msg = string.Empty;
            res = sqlCxP.Gp_BuscaOC_CuentaxPagar(K_Orden_Compra, B_Acepta, ref msg);
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoOrden.Text = string.Empty;
                return;
            }

            if (res == -2)
            {
                DialogResult dlg = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    B_Acepta = true;
                    res = sqlCxP.Gp_BuscaOC_CuentaxPagar(K_Orden_Compra, B_Acepta, ref msg);
                }
                else
                    return;
            }


            dtOC = sqlCxP.Gp_BuscaOC_CuentaxPagar(K_Orden_Compra, B_Acepta);

            if (dtOC != null)
            {
                DataRow ren = dtOC.Rows[0];
                //txtClaveProveedor.Text = ren["K_Proveedor"].ToString(); 
                //txtClaveProveedor_Leave(null, null);
                //txtProveedor.Text = ren["Nombre"].ToString();

                //txtTipoCambio.Text = "0.00";
                //if (ren["Tipo_Cambio"] != null)
                //    txtTipoCambio.Text = Truncar(Convert.ToDecimal(ren["Tipo_Cambio"]), 4).ToString();

                //if (ren["K_Tipo_Moneda"] != null)
                //    cmbMoneda.SelectedValue = Convert.ToInt32(ren["K_Tipo_Moneda"]);
                //else
                //    cmbMoneda.SelectedValue = 3; //si no viene valor, por default pongo pesos

                //if (ren["K_Tipo_Moneda"] != null)
                //{
                //    string Moneda = ren["D_Tipo_Moneda"].ToString();
                //    if (Moneda.ToUpper().Contains("USD") || Moneda.ToUpper().Contains("DLL") || Moneda.ToUpper().Contains("DOLAR"))
                //        cmbMoneda.SelectedValue = 1;
                //    if (Moneda.ToUpper().Contains("PESO"))
                //    {
                //        cmbMoneda.Text = Moneda;
                //        cmbMoneda.SelectedValue = 0;
                //    }
                //}
                //else
                //    cmbMoneda.SelectedValue = 0;


                if (ren["Observaciones"] != null)
                    txtObservaciones.Text = ren["Observaciones"].ToString();

                //System.Data.DataTable dt = DetalleCxp_Type;
                ////Conceptos
                //foreach (DataRow row in dtOC.Rows)
                //{
                //    DataRow ren2 = dt.NewRow();
                //    ren2["Cantidad"] = Convert.ToDecimal(row["Cantidad"]);
                //    ren2["UnidadMedida"] = row["D_Unidad_Medida"].ToString();
                //    ren2["Concepto"] = row["D_Articulo"].ToString();
                //    ren2["PrecioUnitario"] = Convert.ToDecimal(row["PrecioUnitarioDetalle"]);
                //    ren2["ImporteTotal"] = Convert.ToDecimal(row["TotalDetalle"]);
                //    ren2["B_Manual"] = true;
                //    dt.Rows.Add(ren2);
                //}
                //dtDetalle = dt;
                //grdDatos.DataSource = dtDetalle;
                //CalculaTotales();
                ////txtDetalleCantidad.Focus();
                ////decimal Subtotal = Convert.ToDecimal(txtSubtotal.Text.Replace('$', ' '));
                ////decimal TotalIVA = Convert.ToDecimal(txtTotalIVA.Text.Replace('$', ' '));
                ////txtSubtotal.Text = Subtotal.ToString("C");
                ////txtTotalIVA.Text = TotalIVA.ToString("C");
            }
            else
            {
                MessageBox.Show("LA ORDEN DE COMPRA NO EXISTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoOrden.Text = string.Empty;
                return;
            }
        }

        private void AgregaDetalle()
        {
            //DataRow ren = dtDetalle.NewRow();
            //txtDetalleCantidad.Text = (txtDetalleCantidad.Text.Replace('$', ' '));
            //txtDetallePrecioUnitario.Text =  (txtDetallePrecioUnitario.Text.Replace('$', ' '));
            //txtDetalleImporte.Text = (txtDetalleImporte.Text.Replace('$', ' '));

            //ren["Cantidad"] = Convert.ToDecimal(txtDetalleCantidad.Text);
            //ren["UnidadMedida"] = cmbDetalleUnidadMedida.Text;
            //ren["Concepto"] = txtDetalleConcepto.Text;
            //ren["PrecioUnitario"] = Convert.ToDecimal(txtDetallePrecioUnitario.Text);
            //ren["ImporteTotal"] = Convert.ToDecimal(txtDetalleImporte.Text);
            //ren["B_Manual"] = true;
            //dtDetalle.Rows.Add(ren);
            //grdDatos.DataSource = dtDetalle;            
            //LimpiaControlesDetalle();
        }

        private void CalculaTotales()
        {
            decimal Subtotal = 0;
            decimal TotalIVA = 0;
            decimal Total = 0;
            var Importe = dtDetalle.AsEnumerable().Sum(p => p.Field<decimal>("ImporteTotal"));
            Subtotal = decimal.Round(Convert.ToDecimal(Importe), 2);
            TotalIVA = decimal.Round(Subtotal * (gdTasaIva / 100), 2);
            Total = Subtotal + TotalIVA;
            txtSubtotal.Text = Subtotal.ToString("C");
            txtTotalIVA.Text = TotalIVA.ToString("C");
            txtTotal.Text = Total.ToString("C");
        }

        private void LimpiaControlesDetalle()
        {
            //cmbDetalleUnidadMedida.SelectedIndex = -1;
            //txtDetalleCantidad.Text = string.Empty;
            //txtDetalleConcepto.Text = string.Empty;
            //txtDetalleImporte.Text = string.Empty;
            //txtDetallePrecioUnitario.Text = string.Empty;
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = grdDatos.CurrentRow;
                if (row != null)
                {
                    if (Convert.ToBoolean(row.Cells["B_Manual"].Value) == true)
                    {
                        int Id = Convert.ToInt32(row.Cells["Id"].Value);
                        DataRow ren = dtDetalle.AsEnumerable().Where(p => p.Field<int>("Id") == Id).FirstOrDefault();
                        if (ren != null)
                        {
                            dtDetalle.Rows.Remove(ren);
                            CalculaTotales();
                        }                            
                    }
                    else
                    {
                        MessageBox.Show("SOLO ES POSIBLE QUITAR RENGLONES QUE FUERON AGREGADOS MANUALMENTE...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMoneda.SelectedValue == null)
                return;
            if (cmbMoneda.SelectedValue.ToString().Trim() == "System.Data.DataRowView")
                return;

            //txtTipoCambio.Text = string.Empty;
            if (Convert.ToInt32(cmbMoneda.SelectedValue) == 1) //DOLARES
            {
                lblTipoCambio.Visible = true;
                txtTipoCambio.Visible = true;
            }
            else
            {
                lblTipoCambio.Visible = false;
                txtTipoCambio.Visible = false;
            }
        }

        private void txtNoOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == 13)
                MuestraDatosOC();
        }

        private void txtNoOrden_Leave(object sender, EventArgs e)
        {
            if (txtNoOrden.Text.Trim().Length > 0)
                MuestraDatosOC();
        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);
            Cursor = Cursors.Default;
        }

        private void txtTipoCambio_Leave(object sender, EventArgs e)
        {
            if (txtTipoCambio.Text != null)
            {
                if (txtTipoCambio.Text != "")
                {
                    try
                    { decimal TipoCambio = Convert.ToDecimal(txtTipoCambio.Text); }
                    catch
                    {
                        MessageBox.Show("EL TIPO DE CAMBIO INDICADO NO ES VALIDO ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void txtDetallePrecioUnitario_Leave(object sender, EventArgs e)
        {
//            if ((txtDetalleCantidad.Text != null) && (txtDetalleCantidad.Text.ToString() != ""))
//            {
//                if ((txtDetallePrecioUnitario.Text != null) && (txtDetallePrecioUnitario.Text.ToString() != ""))
//                { 
//                    decimal DetalleImporte = 0;
//                    decimal PrecioUnitarioDetalle = Convert.ToDecimal(txtDetallePrecioUnitario.Text.ToString());
//                    DetalleImporte = (Convert.ToDecimal(txtDetalleCantidad.Text) * PrecioUnitarioDetalle );
//                    txtDetalleImporte.Text = DetalleImporte.ToString("C");
////                    txtDetallePrecioUnitario.Text = PrecioUnitarioDetalle.ToString("C");
//                }
//            }
        }

        private void txtDetalleCantidad_Leave(object sender, EventArgs e)
        {
            //if ((txtDetalleCantidad.Text != null) && (txtDetalleCantidad.Text.ToString() != ""))
            //{
            //    if ((txtDetallePrecioUnitario.Text != null) && (txtDetallePrecioUnitario.Text.ToString() != ""))
            //    {
            //        decimal DetalleImporte = 0;
            //        decimal PrecioUnitarioDetalle = Convert.ToDecimal(txtDetallePrecioUnitario.Text.ToString());
            //        DetalleImporte = (Convert.ToDecimal(txtDetalleCantidad.Text) * PrecioUnitarioDetalle);
            //        txtDetalleImporte.Text = DetalleImporte.ToString("C");
            //    }
            //}
        }

        private void Frm_CuentasxPagar_Load(object sender, EventArgs e)
        {

        }
    }
}
