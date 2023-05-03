using System;
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



namespace ProbeMedic.CXP
{
    public partial class Frm_NotasCredito : FormaBase
    {
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
        

        public Frm_NotasCredito()
        {
            BaseHabilitaArrastrar = true;
            BaseGridSinFormato = true;
            InitializeComponent();

            seleccionaArchivoXML1.LabelAquiClick += new Controles.SeleccionaArchivoXML.UserControlClickHandler(seleccionaArchivoXML1_LabelAquiClick);            
        }

        public override void BaseMetodoArrastrar(Comprobante factura,XmlDocument xDoc = null)
        {
            if (factura == null)
                return;

            if (factura.TipoDeComprobante.ToString().Trim().ToUpper() != "E")
            {
                MessageBox.Show("EL TIPO DE COMPROBANTE NO ES DE EGRESO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //base.BaseMetodoArrastrar(factura);
            //BaseBotonNuevoClick();
            cfdi = xDoc;
            btnNuevo_Click(this, null);
            string Serie = string.Empty;
            string Folio = string.Empty;
            if (factura.Serie != null)
                Serie = factura.Serie;
            if (factura.Folio != null)
                Folio = factura.Folio;
            txtSerie.Text = Serie;
            txtFolio.Text = Folio;
            txtFolioFiscal.Text = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();

            string RFCEmisor = factura.Emisor.rfc;

            txtSubtotal.Text = factura.SubTotal.ToString();
            txtTotal.Text = factura.Total.ToString("C");
            txtFechaFactura.Value = factura.Fecha;
            VersionXML = factura.Version;

            //factura.Impuestos.Traslados.AsEnumerable
            //dtArticulos = GlobalVar.dtArticulos.AsEnumerable().Where(p => p.Field<bool>("B_Activo") == true).CopyToDataTable<DataRow>();            

            txtTipoCambio.Text = "1.00";
            if (factura.TipoCambio != null)
                txtTipoCambio.Text = Truncar(Convert.ToDecimal(factura.TipoCambio), 4).ToString();
                        
            if (factura.Moneda != null)
            {
                string Moneda = factura.Moneda;
                if (Moneda.ToUpper().Contains("USD") || Moneda.ToUpper().Contains("DLL") || Moneda.ToUpper().Contains("DOLAR"))
                    cmbMoneda.SelectedIndex = 1;
                if (Moneda.ToUpper().Contains("PESO"))
                    cmbMoneda.SelectedIndex = 2;
            }
            else            
                cmbMoneda.SelectedValue = 2; //si no viene moneda en el xml, por default pongo pesos
            
            decimal IVA = Convert.ToDecimal(ComprobantexTipo(factura,"IVA"));
            decimal TasaIVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
            decimal RetencionIVA = Convert.ToDecimal(ComprobantexTipo(factura,"RetencionIVA"));
            decimal RetencionISR = Convert.ToDecimal(ComprobantexTipo(factura,"RetencionISR"));


            dtDetalle = (DataTable)ComprobantexTipo(factura, "ConceptosTabla");
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
            
            ////Buscar tipo iva si normal o frontera, con la TasaIVA
            //var Impuestos = Dti.AsEnumerable().Where(p => p.Field<decimal>("Porcentaje") == TasaIVA);            
            //short K_Impuesto = Impuestos.Min(p => p.Field<short>("K_Impuesto"));

            ////DataRow ren = dtDatos.AsEnumerable().Where(p => p.Field<int>("K_Detalle_Requisicion") == K_Detalle_Requisicion).FirstOrDefault();
            //string D_Impuesto = string.Empty;
            //DataRow NombreImp = Impuestos.Where(p => p.Field<short>("K_Impuesto") == K_Impuesto).FirstOrDefault();
            //if(NombreImp != null)
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
            }
            else
            {
                MessageBox.Show("EL PROVEEDOR DEL ARCHIVO NO EXISTE REGISTRADO...!\r\nR.F.C.: " + RFCEmisor + "\r\nProveedor: " +factura.Emisor.Nombre + "\r\nDEBERA ENTRAR A LA OPCION DE PROVEEDORES A CAPTURARLO","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        void seleccionaArchivoXML1_LabelAquiClick(object sender, EventArgs e)
        {
            if (seleccionaArchivoXML1.PropiedadRuta != null)
            {
                //BaseBotonNuevoClick();
                Comprobante factura = seleccionaArchivoXML1.PropiedadFactura;
                cfdi = seleccionaArchivoXML1.PropiedadXML;
                BaseMetodoArrastrar(factura,cfdi);
            }
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

        //    grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 51, 102);
        //    grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = White
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

            grdDatos.AutoGenerateColumns = false;
            FormatoGrid();

            //dtOrdenes = sqlCompras.sps_ConsultaOrdenesCompra(2, false);
            BaseDtDatos = dtOrdenes;

            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            if (dtMoneda != null)
            {
                LlenaCombo(dtMoneda, ref cmbMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 0);
            }

            DataTable dtTipoIva  = sqlCatalogos.Sk_Tipo_Iva();
            if (dtTipoIva != null)
            {
                LlenaCombo(dtTipoIva, ref cmbTasaIva, "K_Iva", "D_Iva");
                cmbTasaIva.SelectedIndex = 0;
            }
            //DataTable dtUnidadMedida = sqlCatalogos.Sk_Unidad_Medida();
            //if (dtUnidadMedida != null)
            //{
            //    LlenaCombo(dtUnidadMedida, ref cmbDetalleUnidadMedida, "K_Unidad_Medida", "D_Unidad_Medida", 0);
            //}

            dtProveedores = sqlCatalogos.Sk_Proveedores();

            pnlArriba.Enabled = false;
            //txtSerieFactura.Focus();
            base.BaseMetodoInicio();
        }

        public override void BaseMetodoLimpiaControles()
        {
           // txtNoFactura.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtFolio.Text = string.Empty;
            txtFolioFiscal.Text = string.Empty;
            cmbMoneda.Text = string.Empty;
            txtTipoCambio.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            cmbTasaIva.Text = string.Empty;
            txtTotalIVA.Text = string.Empty;
            txtTasaRetencionIVA.Text = string.Empty;
            txtTotalRetencionIVA.Text = string.Empty;
            txtTasaISR.Text = string.Empty;
            txtTotalISR.Text = string.Empty;
            txtTotal.Text = string.Empty;            
            txtObservaciones.Text = string.Empty;
            //cmbTasaIva.SelectedIndex = 0;            
            pnlArriba.Enabled = false;

            dtDetalle = DetalleNotaProveedor_Type;
            grdDatos.DataSource = null;
            //LimpiaControlesDetalle();
        }

        //private void LimpiaControlesDetalle()
        //{
        //    cmbDetalleUnidadMedida.SelectedIndex = -1;
        //    txtDetalleCantidad.Text = string.Empty;
        //    txtDetalleConcepto.Text = string.Empty;
        //    txtDetalleImporte.Text = string.Empty;
        //    txtDetallePrecioUnitario.Text = string.Empty;
        //}

        private void btnBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            //Busquedas.BuscaOrdenesCompra frm = new Busquedas.BuscaOrdenesCompra();
            //frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOrdenes);
            //frm.BusquedaPropiedadTablaFiltra = dtOrdenes;
            //frm.BusquedaPropiedadTitulo = "Busca Ordenes de Compra";
            //frm.ShowDialog();
            //if (frm.BusquedaPropiedadReglonRes != null)
            //{
            //    txtNoFactura.Text = frm.BusquedaPropiedadReglonRes["K_Orden_Compra"].ToString();                
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

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);            
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

        private void cmbTasaIva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTasaIva.SelectedValue == null)
                return;
            if (cmbTasaIva.SelectedValue.ToString().Trim() == "System.Data.DataRowView")
                return;

            DataTable dt = LINQTablaFiltraMultiple(GlobalVar.dtImpuestos, cmbTasaIva.SelectedValue.ToString(), "K_Impuesto");
            if (dt.Rows.Count > 0)
            {
                lblTasaIva.Text = dt.Rows[0]["Porcentaje"].ToString() + " %";
                gdTasaIva = Convert.ToDecimal(dt.Rows[0]["Porcentaje"]);
            }
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
            decimal TasaRetencionIVA  = 0;
            decimal TotalRetencionIVA = 0;
            decimal TasaISR = 0;
            decimal TotalISR = 0;
            decimal TotalFactura = 0;

            res = 0;
            msg = string.Empty;

            //if (txtNoFactura.Text.Trim().Length > 0)
            //    K_OrdenCompra = Convert.ToInt32(txtNoFactura.Text);
            short TipoMoneda = Convert.ToInt16(cmbMoneda.SelectedValue);
            if (TipoMoneda == 1) //DLLS
            {
                if(txtTipoCambio.Text.Trim().Length > 0)
                    TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);
            }
            DateTime Fecha = DateTime.Today;
            if (txtFechaFactura.Value != null)
                Fecha = txtFechaFactura.Value;
            DateTime Vencimiento = DateTime.Today;
            if (txtFechaVencimiento.Value != null)
                Vencimiento = txtFechaVencimiento.Value;

            if(txtSubtotal.Text.Trim().Length > 0)
                Subtotal = Convert.ToDecimal(txtSubtotal.Text.Replace('$',' '));
            if(txtTotalIVA.Text.Trim().Length > 0)
                TotalIVA = Convert.ToDecimal(txtTotalIVA.Text.Replace('$', ' '));
            if(txtTasaRetencionIVA.Text.Trim().Length > 0)
                TasaRetencionIVA = Convert.ToDecimal(txtTasaRetencionIVA.Text.Replace('$', ' '));
            if(txtTotalRetencionIVA.Text.Trim().Length > 0)
                TotalRetencionIVA = Convert.ToDecimal(txtTotalRetencionIVA.Text.Replace('$', ' '));
            if(txtTasaISR.Text.Trim().Length > 0)
                TasaISR = Convert.ToDecimal(txtTasaISR.Text.Replace('$', ' '));
            if(txtTotalISR.Text.Trim().Length > 0)
                TotalISR = Convert.ToDecimal(txtTotalISR.Text.Replace('$', ' '));
            if(txtTotal.Text.Trim().Length > 0)
                TotalFactura = Convert.ToDecimal(txtTotal.Text.Replace('$', ' '));


            DataTable dtDet = new DataTable();
            dtDet = dtDetalle;

            if(dtDetalle.Columns.Contains("B_Manual"))
                dtDet.Columns.Remove("B_Manual");
            if(dtDetalle.Columns.Contains("Id"))
                dtDet.Columns.Remove("Id");

          
            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
               //// string Referencia = txtSerieFactura.ToString() + txtNoFactura.ToString();
               // if (Referencia.ToString().Length <= 0)
               //     Referencia = "";
             //   res = sqlCxP.In_Nota_Credito_Proveedor(ref CampoIdentity, Convert.ToInt32(txtClaveProveedor.Text), txtFolioFiscal.Text, txtSerie.Text, txtFolio.Text, TipoCambio, Convert.ToInt16(cmbMoneda.SelectedValue), Subtotal, gdTasaIva, TotalIVA, TasaRetencionIVA, TotalRetencionIVA, TasaISR, TotalISR, TotalFactura, Fecha, 1, txtObservaciones.Text, VersionXML, GlobalVar.K_Usuario, dtDet, txtSerieFactura.Text, txtNoFactura.Text, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "NOTA DE CREIDTO GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();

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

            //if (txtNoFactura.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR UN NÚMERO DE FACTURA COMO REFERENCIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNoFactura.Focus();
            //    return false;
            //}            

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
            //if (grdDatos.Rows.Count == 0)
            //{
            //    MessageBox.Show("NO HA CAPTURADO DETALLES PARA LA CUENTA POR PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDetalleCantidad.Focus();
            //    return false;
            //}

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
            //grdRequisiciones.ClearSelection();
        }

        public override void BaseBotonNuevoClick()
        {
            //grdRequisiciones.ClearSelection();

            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;

            pnlArriba.Enabled = true;
         //   txtSerieFactura.Focus();
            //dtDatos.Rows.Clear();
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    if (txtDetalleCantidad.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("FALTA CAPTURAR CANTIDAD..!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //        txtDetalleCantidad.Focus();
        //        return;
        //    }
        //    if (txtDetalleConcepto.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("FALTA CAPTURAR CONCEPTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtDetalleConcepto.Focus();
        //        return;
        //    }
        //    if (txtDetallePrecioUnitario.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("FALTA CAPTURAR PRECIO UNITARIO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtDetallePrecioUnitario.Focus();
        //        return;
        //    }
        //    if (txtDetalleImporte.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("FALTA CAPTURAR IMPORTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtDetalleImporte.Focus();
        //        return;
        //    }
        //    AgregaDetalle();
        //    CalculaTotales();
        //    txtDetalleCantidad.Focus();
        //}

//        private void AgregaDetalle()
//        {
//            DataRow ren = dtDetalle.NewRow();
//            ren["Cantidad"] = Convert.ToInt16(txtDetalleCantidad.Text);
//            ren["UnidadMedida"] = cmbDetalleUnidadMedida.Text;
//            ren["Concepto"] = txtDetalleConcepto.Text;
//            ren["PrecioUnitario"] = Convert.ToDecimal(txtDetallePrecioUnitario.Text);
//            ren["ImporteTotal"] = Convert.ToDecimal(txtDetalleImporte.Text);
////            ren["B_Manual"] = true;
//            dtDetalle.Rows.Add(ren);
//            grdDatos.DataSource = dtDetalle;            
//            LimpiaControlesDetalle();
//        }

        //private void CalculaTotales()
        //{
        //    decimal Subtotal = 0;
        //    decimal TotalIVA = 0;
        //    decimal Total = 0;
        //   // var Importe = dtDetalle.AsEnumerable().Sum(p => p.Field<decimal>("ImporteTotal"));            
        //    Subtotal = decimal.Round(Convert.ToDecimal(Importe), 2);
        //    TotalIVA = decimal.Round(Subtotal * (gdTasaIva / 100), 2);
        //    Total = Subtotal + TotalIVA;
        //    txtSubtotal.Text = Subtotal.ToString();
        //    txtTotalIVA.Text = TotalIVA.ToString();
        //    txtTotal.Text = Total.ToString("C");                
        //}

        
//        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.ColumnIndex == 0)
//            {
//                DataGridViewRow row = grdDatos.CurrentRow;
//                if (row != null)
//                {
////                    if (Convert.ToBoolean(row.Cells["B_Manual"].Value) == true)
////                    {
//                        int Id = Convert.ToInt32(row.Cells["Id"].Value);
//                        if (Id > 0)
//                        {
//                            DialogResult result = MessageBox.Show("¿ DESEA BORRAR EL REGISTRO DEL DETALLE SELECCIONADO ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                            if (result == DialogResult.Yes)
//                            {
//                                DataRow ren = dtDetalle.AsEnumerable().Where(p => p.Field<int>("Id") == Id).FirstOrDefault();
//                                if (ren != null)
//                                    dtDetalle.Rows.Remove(ren); 
//                            }
//                        }
////                    }
//                    else
//                    {
//                        MessageBox.Show("SOLO ES POSIBLE QUITAR RENGLONES QUE FUERON AGREGADOS MANUALMENTE...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
//                    }
//                }
//            }
//        }

        //private void txtDetallePrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if ((e.KeyChar == Convert.ToChar(Keys.Enter)) || (e.KeyChar == Convert.ToChar(Keys.Tab)))
        //    //{
        //    //    bool B_Decimal = (txtDetallePrecioUnitario.Text.Contains("."));
        //    //    if (B_Decimal == false)
        //    //    {
        //    //        decimal PrecioUnitarioDetalle = Convert.ToDecimal(txtDetallePrecioUnitario.Text);
        //    //        txtDetallePrecioUnitario.Text = txtDetallePrecioUnitario.Text + "00";
        //    //        txtDetalleImporte.Text = Convert.ToString(Convert.ToDecimal(txtDetalleCantidad.Text) * PrecioUnitarioDetalle);
        //    //        txtDetalleImporte.Text = txtDetalleImporte.Text + "00";
        //    //        txtDetalleImporte.Focus();
        //    //    }
        //    //}
        //}

    }
}
