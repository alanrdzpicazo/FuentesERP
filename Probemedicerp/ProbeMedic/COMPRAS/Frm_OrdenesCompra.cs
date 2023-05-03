﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.IO;

namespace ProbeMedic.COMPRAS
{
    public partial class Frm_OrdenesCompra : FormaBase
    {
        int res = 0;
        string msg = string.Empty;
        DataTable dtDatos = new DataTable();
        DataTable dtRequisiciones = new DataTable();
        DataTable dtTipoCambio = new DataTable();
        DataTable dtTipoEmpaque = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtSucursales = new DataTable();
        DataTable dtValida = new DataTable();
        bool B_ProveedorExtranjero = false;
        bool B_NoEntrar = false;

        SQLCompras sqlCompras = new SQLCompras();
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        SQLRecepcion sQLRecepcion = new SQLRecepcion();
        Funciones fx = new Funciones();

        //bool editsuspended;
        String strKeyPress = "";
        decimal gdCant = 0;
        decimal gdUnit = 0;
        decimal gdImp = 0;
        decimal gdTasaIVA = 0;
        int K_OrdenCompra = 0;

        private int k_orden_compra;
        public int K_Orden_Compra
        {
            get
            {
                return k_orden_compra;
            }
            set
            {
                k_orden_compra = value;
            }
        }

        public Frm_OrdenesCompra()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();

            grdRequisiciones.AutoGenerateColumns = false;
            grdOrdenCompra.AutoGenerateColumns = false;

            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList2.Images["zoom.png"]));
            BaseBotonProceso1.Text = "&OC Ptes x Surtir [F10]";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonProceso1.Width = 120;

            BaseBotonModificar.Text = "Editar OC [F3]";

            dtRequisiciones = sqlCompras.Sk_Requisicion_OC(true, false);
            BasePropiedadCampoClave = "K_Requisicion";
            grdRequisiciones.DataSource = dtRequisiciones;
            grdRequisiciones.Width = pnlRequisiciones.Width;
            grdRequisiciones.AllowUserToResizeColumns = true;
            //grdRequisiciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdRequisiciones.MultiSelect = false;
            grdRequisiciones.ReadOnly = true;
            grdRequisiciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            /* grdRequisiciones.BackgroundColor = Color.White;
             grdRequisiciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 51, 102);
             grdRequisiciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 153, 51);*/
            grdRequisiciones.EnableHeadersVisualStyles = false;

            BaseDtDatos = dtRequisiciones;

            dtTipoCambio = sqlCatalogos.Sk_Tipo_Moneda();
            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();

            if (dtMoneda != null)
            {
                LlenaCombo(dtMoneda, ref cmbMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 0);
            }
            //DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes();
            //if (dtAlmacen != null)
            //{
            //    DataRow dr = dtAlmacen.NewRow();

            //    dr["K_Almacen"] = 0;
            //    dr["K_Oficina"] = 0;
            //    dr["D_Oficina"] = "";
            //    dr["D_Almacen"] = "";
            //    dr["B_AceptaDevolucionesCliente"] = false;

            //    dtAlmacen.Rows.InsertAt(dr, 0);

            //    dtAlmacen.AcceptChanges();

            //    int indice = -1;
            //    indice = 0;
            //    LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

            //    cbxAlmacen.SelectedValue = 0;
            //}
            //dtTipoEmpaque = sqlCatalogos.sps_TipoEmpaque(true);
            pnlOrdenCompra.Enabled = false;
            pnlRequisiciones.Enabled = false;
            pnlCaptura.Enabled = false;
            txtFechaEntrega.Value = DateTime.Now.AddDays(1);
            base.BaseMetodoInicio();
        }

        public override void BaseBotonProceso1Click()
        {
            DateTime? f1 = new DateTime();
            f1 = fx.PrimerDiaDelMes(DateTime.Now);
            DateTime? f2 = new DateTime();
            f2 = fx.UltimoDiaDelMes(DateTime.Now);

            Cursor = Cursors.WaitCursor;
            DataTable dtOC = sqlCompras.Sk_ConsultaOrdenesCompra(0,0,0,1,1,false,f1,f2,0,0,0,0,null,null);
     
            if (dtOC != null)
            {
                dtOC.DefaultView.Sort = "K_Orden_Compra DESC";
                Busquedas.BuscaOrdenesCompra frm = new Busquedas.BuscaOrdenesCompra();
                frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOC);
                frm.BusquedaPropiedadTablaFiltra = dtOC;

                if (dtOC.Rows.Count == 1)
                {
                    K_Orden_Compra = Convert.ToInt32(dtOC.Rows[0]["K_Orden_Compra"].ToString());
                    LlenaControles(dtOC.Rows[0]);

                    BasePropiedadEsRegistroNuevo = false;
                    BasePropiedadId_Identity = 0;
                    BasePropiedadB_Agregando = false;
                    BasePropiedadB_Editando = true;

                }
                else if (dtOC.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Ordenes de Compra";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Orden_Compra = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Orden_Compra"].ToString());
                        LlenaControles(frm.BusquedaPropiedadReglonRes);
                    }
                    else
                    {
                        K_Orden_Compra = 0;
                    }

                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;

        }

        private void LlenaControles(DataRow row)
        {
            bool B_Directa = Convert.ToBoolean(row["B_Directa"].ToString());
            txtClaveOficina.Text = row["K_Oficina"].ToString();
            txtOficina.Text = row["D_Oficina"].ToString();
            if(txtClaveOficina.Text.Trim().Length>0)
                CargaAlmacenes();
            cbxAlmacen.SelectedValue = Convert.ToInt32(row["K_Almacen"].ToString());
            txtClaveProveedor.Text = row["K_Proveedor"].ToString();
            txtProveedor.Text = row["Nombre"].ToString();
            DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
            if (dtSucursales != null)
            {
                LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", 0);
            }
            cbxSucursales.SelectedValue = Convert.ToInt32(row["K_Sucursal_Proveedor"].ToString());
            txtFechaEntrega.Value = Convert.ToDateTime(row["F_Entrega"].ToString());
            txtTiempoEntrega.Text = row["TiempoEntrega"].ToString();
            txtObservaciones.Text = row["Observaciones"].ToString();

            DataTable dtDetalle = sqlCompras.Sk_ConsultaOrdenesCompraDetalle(K_Orden_Compra);
            if (dtDetalle != null)
            {
                if (dtDetalle.Rows.Count > 0)
                {
                    foreach (DataRow ren in dtDetalle.Rows)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr["K_Requisicion"] = ren["K_Requisicion"];
                        dr["K_Detalle_Requisicion"] = ren["K_Detalle_Requisicion"];
                        dr["K_Articulo"] = ren["K_Articulo"];
                        dr["D_Articulo"] = ren["D_Articulo"];
                        dr["K_Tipo_Empaque"] = 1;
                        dr["Cantidad"] = ren["Cantidad"];
                        dr["Unitario"] = ren["Precio_Unitario"];
                        dr["Subtotal"] = ren["Subtotal"];
                        dr["PrecioTotal"] = ren["PrecioTotal"];
                        dr["TasaIVA"] = ren["IVA"];
                        dr["D_Unidad_Medida"] = ren["D_Unidad_Medida"];
                        dr["D_Tipo_Articulo"] = ren["D_Tipo_Articulo"];
                        dr["D_Clasificacion_Articulo"] = ren["D_Clasificacion_Articulo"];
                        dr["Porcentaje"] = ren["TasaIva"];
                        dr["Porcentaje_Descuento"] = ren["Porcentaje_Descuento"].ToString() != "" ? ren["Porcentaje_Descuento"]: 0;
                        decimal Monto_Descuento = ren["Porcentaje_Descuento"].ToString()!="" ?(Convert.ToDecimal(ren["Porcentaje_Descuento"]) / 100) * Convert.ToDecimal(ren["SubTotal"]):0;
                        dr["Monto_Descuento"] = Monto_Descuento;
                        dr["Porcentaje_Descuento_2"] = ren["Porcentaje_Descuento_2"].ToString()!=""? ren["Porcentaje_Descuento_2"]:0;
                        decimal Monto_Descuento_2 = ren["Porcentaje_Descuento_2"].ToString()!="" ?(Convert.ToDecimal(ren["Porcentaje_Descuento_2"]) / 100) * Convert.ToDecimal(ren["SubTotal"]):0;
                        dr["Monto_Descuento_2"] = Monto_Descuento_2;
                        dtDatos.Rows.Add(dr);
                    }
                     this.grdOrdenCompra.DataSource = dtDatos;
                    B_NoEntrar = true;
                    Calcula();
                }
                this.grdOrdenCompra.DataSource = dtDatos;
                grdOrdenCompra.EditMode = DataGridViewEditMode.EditOnEnter;
                grdOrdenCompra.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                grdOrdenCompra.MultiSelect = false;
                grdOrdenCompra.Rows[0].Cells[0].Selected = true;

                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
                BaseBotonNuevo.Enabled = false;
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
                //if (!B_Directa)
                //{
                //    lblRequisiciones.Text = "Lista de Requisiciones Agregadas a la OC " + K_Orden_Compra;
                //    BuscaRequisiciones(K_Orden_Compra);
                //}                     
                //else
                //{
                //    lblRequisiciones.Text = "Lista de Requisiciones";
                //    grdRequisiciones.DataSource = dtRequisiciones;
                //}   
            }
        }

        public override void BaseBotonCancelarClick()
        {
            cbxAlmacen.SelectedIndex = -1;
            grdOrdenCompra.DataSource = null;


            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseMetodoLimpiaControles();
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = false;
            BasePropiedadId_Identity = 0;
            grdRequisiciones.ClearSelection();

            Calcula();
        }

        public override void BaseBotonModificarClick()
        {
            grdRequisiciones.ClearSelection();

            BasePropiedadEsRegistroNuevo = false;
            //BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = true;

            pnlOrdenCompra.Enabled = true;
            pnlRequisiciones.Enabled = false;
            pnlCaptura.Enabled = false;

            grdOrdenCompra.EditMode = DataGridViewEditMode.EditOnEnter;
            grdOrdenCompra.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdOrdenCompra.MultiSelect = false;

            grdOrdenCompra.Rows[0].Cells[6].Selected = true;
            grdOrdenCompra.Focus();

            base.BaseBotonModificarClick();
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtOficina.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            txtClaveOficina.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            pnlOrdenCompra.Enabled = false;
            pnlRequisiciones.Enabled = false;
            pnlCaptura.Enabled = false;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxSucursales.DataSource = null;
            cbxSucursales.Items.Clear();
            cmbMoneda.SelectedIndex = 0;
            txtTipoCambio.Text = Convert.ToString(0);
            txtTipoCambio.Text = string.Empty;
            txtTiempoEntrega.Text = "1";
            txtFechaEntrega.Value = DateTime.Now.AddDays(1);
            txtTipoCambio.Text = Convert.ToString(0);
            txtTipoCambio.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            lblRequisiciones.Text = "Lista de Requisiciones";
            K_Orden_Compra = 0;
            dtDatos.Rows.Clear();
        }

        public override void BaseBotonNuevoClick()
        {
            grdRequisiciones.ClearSelection();

            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;


            pnlOrdenCompra.Enabled = true;
            pnlRequisiciones.Enabled = true;
            pnlCaptura.Enabled = true;
            //txtClaveOficina.Focus();
            btnBuscarOficina.Focus();
            dtDatos.Rows.Clear();
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            grdOrdenCompra.EndEdit();
            dtDatos.AcceptChanges();

            foreach (DataRow ren in dtDatos.Rows)
            {
                if (Convert.ToInt32(ren["Unitario"]) == 0)
                {
                    MessageBox.Show("NO ES POSIBLE AGREGAR ESTA REQUISICION YA QUE NO CUENTA CON PRECIOS DE PROVEEDOR...\n" + msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            int K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            res = 0;
            msg = string.Empty;

            DateTime Fecha = DateTime.Today;
            if (txtFechaEntrega.Value != null)
                Fecha = txtFechaEntrega.Value;

            short Tiempo = 0;
            if (txtTiempoEntrega.Text.Trim().Length > 0)
                Tiempo = Convert.ToInt16(txtTiempoEntrega.Text);

            bool B_ImprimeOC = true;
            string CorreosAutorizo = string.Empty;
            decimal TipoCambio = 0;
            int CampoIdentity = 0;
            CampoIdentity = K_Orden_Compra;
            short TipoMoneda = Convert.ToInt16(cmbMoneda.SelectedValue);
            if (TipoMoneda == 5) //DLLS
                TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);


            DataTable dtDetalle = dtDatos.Copy();
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("D_Unidad_Medida");
            dtDetalle.Columns.Remove("D_Tipo_Articulo");
            dtDetalle.Columns.Remove("D_Clasificacion_Articulo");
            dtDetalle.Columns.Remove("SubTotal");
            dtDetalle.Columns.Remove("Porcentaje");
            dtDetalle.Columns.Remove("Monto_Descuento");
            dtDetalle.Columns.Remove("Monto_Descuento_2");
            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCompras.Gp_InsertaOrdenCompra(ref CampoIdentity, K_Oficina, Convert.ToInt16(cbxAlmacen.SelectedValue), Convert.ToInt16(cbxSucursales.SelectedValue), K_Proveedor, TipoMoneda, TipoCambio,
                                                       Fecha, Tiempo, GlobalVar.K_Usuario, txtObservaciones.Text, dtDetalle, ref B_ImprimeOC, ref CorreosAutorizo, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "ORDEN DE COMPRA GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte(K_OrdenCompra);
                    Cursor = Cursors.Default;

                    BaseErrorResultado = false;

                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
            else
            {
                res = sqlCompras.Gp_EditaOrdenCompra(CampoIdentity, GlobalVar.K_Usuario,dtDetalle, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "ORDEN DE COMPRA ACTUALIZADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte(K_OrdenCompra);
                    Cursor = Cursors.Default;

                    BaseErrorResultado = false;

                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
         
        }

        public override void BaseMetodoMostrarReporte()
        {
            /* DataTable dtReporte = sqlCompras.Sk_ReporteOrdenesCompra(K_OrdenCompra);
             ReportedtCorreo = dtReporte;
             string Version = dtReporte.Rows[0]["DocumentoVersion"].ToString();

             ReportDocument rpt = new ReportDocument();
             rpt = new REPORTES.RPT_OrdenCompra();

             ReporteTitulo = "Orden de Compra / Purchase Order";
             ReporteModulo = "COMPRAS";

            ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
             ReporteRPT = rpt;*/
        }

        private void CalculaTotales()
        {
            var Cantidad = dtDatos.AsEnumerable().Sum(p => p.Field<decimal>("Cantidad"));
            gdCant = decimal.Round(Convert.ToDecimal(Cantidad), 2);

            var Unitario = dtDatos.AsEnumerable().Sum(p => p.Field<decimal>("Unitario"));
            gdUnit = decimal.Round(Convert.ToDecimal(Unitario), 2);

            var Importe = dtDatos.AsEnumerable().Sum(p => p.Field<decimal>("PrecioTotal"));
            gdImp = decimal.Round(Convert.ToDecimal(Importe), 2);

            var TasaIVA = dtDatos.AsEnumerable().Max(p => p.Field<decimal>("TasaIVA"));
            gdTasaIVA = decimal.Round(Convert.ToDecimal(TasaIVA), 2);
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR LA OFICINA QUE RECIBE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveOficina.Focus();
                return false;
            }
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return false;
            }
            if (cmbMoneda.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN TIPO DE MONEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMoneda.Focus();
                return false;
            }
            if (cbxAlmacen.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }
            if (cbxSucursales.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA SUCURSAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxSucursales.Focus();
                return false;
            }
            else if ((Int32)cbxSucursales.SelectedValue ==0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA SUCURSAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxSucursales.Focus();
                return false;
            }
            if (grdOrdenCompra.Rows.Count == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA REQUISICION PARA GENERAR LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveOficina.Focus();
                return false;
            }
            if (cmbMoneda.SelectedValue.ToString() == "1")
            {
                /* if ( (txtTipoCambio.Text == "") || (txtTipoCambio.Text.ToString().Length <= ) )
                 {
                     MessageBox.Show("PARA PODER GENERAR LA ORDEN DE COMPRA, DEBE INDICAR EL TIPO DE CAMBIO DEL DIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     if (txtTipoCambio.CanFocus)
                     { txtTipoCambio.Focus(); }
                     return false;
                 }*/
            }

            BaseErrorResultado = false;
            return true;
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
            if (txtClaveOficina.Text != "")
            {
                CargaAlmacenes();
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores_Autorizados();
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
                cbxSucursales.DataSource = null;
                cbxSucursales.Items.Clear();
                DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
                if (dtSucursales != null)
                {
                    DataRow dr = dtSucursales.NewRow();

                    dr["K_Sucursal_Proveedor"] = 0;
                    dr["K_Proveedor"] = 0;
                    dr["D_Sucursal_Proveedor"] = "";
                    dr["D_Proveedor"] = "";

                    dtSucursales.Rows.InsertAt(dr, 0);

                    dtSucursales.AcceptChanges();

                    int indice = -1;
                    indice = 0;
                    LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", indice);

                    cbxSucursales.SelectedValue = 0;
                }
            }
            else
            {
                cbxSucursales.DataSource = null;
                cbxSucursales.Items.Clear();
            }
            Cursor = Cursors.Default;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMoneda.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            if (cmbMoneda.SelectedValue == null)
                return;

            txtTipoCambio.Text = string.Empty;
            if (Convert.ToInt32(cmbMoneda.SelectedValue) == 5) //DOLARES
            {
                lblTipoCambio.Visible = true;
                txtTipoCambio.Visible = true;
                if (dtTipoCambio.Rows.Count > 0)
                {
                    txtTipoCambio.Text = dtTipoCambio.Rows[0]["Tipo_Cambio"].ToString();
                }
            }
            else
            {
                txtTipoCambio.Text = "0";
                lblTipoCambio.Visible = false;
                txtTipoCambio.Visible = false;
            }
        }

        private void AgregarRequisicion()
        {
            bool B_PuedeAgregar = false;
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                int K_Requisicion = Convert.ToInt32(row.Cells["K_Requisicion"].Value);
                int K_Almacen_Req = Convert.ToInt32(row.Cells["K_Almacen"].Value);

                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA SELECCIONAR LA OFICINA QUE RECIBE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveOficina.Focus();
                    return;
                }
                if (txtClaveProveedor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE SELECCIONAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProveedor.Focus();
                    return;
                }
                if (cmbMoneda.SelectedValue == null)
                {
                    MessageBox.Show("DEBE SELECCIONAR UN TIPO DE MONEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMoneda.Focus();
                    return;
                }
                if (cbxAlmacen.SelectedValue == null)
                {
                    MessageBox.Show("DEBE SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxAlmacen.Focus();
                    return;
                }

                if (K_Almacen_Req != Convert.ToInt16(cbxAlmacen.SelectedValue))
                {
                    MessageBox.Show("El Almacen de la Requisición es diferente al Seleccionado...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Validar que la requisición no haya sido agregada ya al grid
                var Existe = dtDatos.AsEnumerable().Where(o => o.Field<int>("K_Requisicion") == K_Requisicion);
                if (Existe.Any())
                {
                    MessageBox.Show("La Requisición Seleccionada ya Existe Agregada a la Orden de Compra...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dlg = MessageBox.Show("¿DESEA AGREGAR LA REQUISICION CON FOLIO: " + K_Requisicion.ToString().Trim() + "?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    //A partir de la segunda requisicion agregada, validar si se puede o no agregar
                    if (grdOrdenCompra.Rows.Count > 1)
                    {
                        int K_RequisicionUno = Convert.ToInt32(grdRequisiciones["K_Requisicion", 0].Value);
                        res = sqlCompras.Gp_ValidaPuedeAgregar(K_RequisicionUno, K_Requisicion, ref B_PuedeAgregar, ref msg);
                        if (res == -1)
                        {
                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (B_PuedeAgregar == false)
                        {
                            MessageBox.Show("NO ES POSIBLE AGREGAR ESTA REQUISICION...\n" + msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    res = 0;
                    msg = string.Empty;

                    //DataTable dtDetalle = sqlCompras.Sk_RequisicionDetalle(K_Requisicion, Convert.ToInt32(txtClaveProveedor.Text));
                    DataTable dtDetalle = sqlCompras.Sk_RequisicionDetalle(K_Requisicion, 0);
                    if (dtDetalle != null)
                    {
                        if (dtDetalle.Rows.Count > 0)
                        {
                            foreach (DataRow ren in dtDetalle.Rows)
                            {

                                DataRow dr = dtDatos.NewRow();

                                // 11/ENERO/2019
                                /* POR EL MOMENTO SE DEJARA COMENTARIZADA ESTA PARTE
                                 * DESPUES SE VOLVERA A ESTABLECER */
                                //int PuntoReOrden = 0;
                                //dtValida = sQLRecepcion.Gp_Valida_PuntoReOrden(K_Requisicion, Convert.ToInt32(ren["K_Articulo"]), Convert.ToInt32(ren["CantidadRequerida"]), PuntoReOrden);
                                //DataRow rows = dtValida.Rows[0];
                                //PuntoReOrden = Convert.ToInt32(rows["Punto_ReOrden"].ToString());
                                //if (PuntoReOrden < 0)
                                //{
                                //    MsgBox msgbox = new MsgBox();
                                //    msgbox.Show("EXISTE AL MENOS UN ARTICULO QUE EXCEDE EL INVENTARIO MAXIMO", "ERROR");
                                //    Mtd_Bloquea_Requisicion(K_Requisicion);
                                //    return;
                                //}
                                dr["K_Requisicion"] = ren["K_Requisicion"];
                                dr["K_Detalle_Requisicion"] = ren["K_Detalle_Requisicion"];
                                dr["K_Articulo"] = ren["K_Articulo"];
                                dr["D_Articulo"] = ren["D_Articulo"];
                                dr["K_Tipo_Empaque"] = 1;
                                dr["Cantidad"] = ren["CantidadRequerida"];
                                dr["Unitario"] = ren["Unitario"];
                                dr["Subtotal"] = ren["SubTotal"];
                                dr["PrecioTotal"] = ren["PrecioTotal"];
                                dr["TasaIVA"] = ren["IVA"];
                                dr["D_Unidad_Medida"] = ren["D_Unidad_Medida"];
                                dr["D_Tipo_Articulo"] = ren["D_Tipo_Articulo"];
                                dr["D_Clasificacion_Articulo"] = ren["D_Clasificacion_Articulo"];
                                dr["Porcentaje"] = ren["Porcentaje"];
                                dr["Porcentaje_Descuento"] = ren["Porcentaje_Descuento"];
                                decimal Monto_Descuento = (Convert.ToDecimal(ren["Porcentaje_Descuento"])/100) * Convert.ToDecimal(ren["SubTotal"]);
                                dr["Monto_Descuento"] = Monto_Descuento;
                                dr["Porcentaje_Descuento_2"] = ren["Porcentaje_Descuento_2"];
                                decimal Monto_Descuento_2 = (Convert.ToDecimal(ren["Porcentaje_Descuento_2"]) / 100) * Convert.ToDecimal(ren["SubTotal"]);
                                dr["Monto_Descuento_2"] = Monto_Descuento_2;
                                dtDatos.Rows.Add(dr);
                            }
                            //for (int irow = 0; irow < grdOrdenCompra.Rows.Count; irow++)
                            //{
                            //    DataGridViewComboBoxCell cell =
                            //        (DataGridViewComboBoxCell)(grdOrdenCompra.Rows[irow].Cells["D_Tipo_Empaque"]);
                            //    cell.DataSource = dtTipoEmpaque;
                            //    cell.ValueMember = "K_Tipo_Empaque";
                            //    cell.DisplayMember = "D_Tipo_Empaque";
                            //    B_NoEntrar = false;
                            //    cell.Value = grdOrdenCompra.Rows[irow].Cells["K_Tipo_Empaque"].Value;
                            //    cell = null;
                            //}
                            this.grdOrdenCompra.DataSource = dtDatos;
                            Calcula();
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL PROVEEDOR NO CUENTA CON LOS ARTICULOS DISPONIBLES", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Sugerir proveedor si no lo ha elegido                    
                    B_NoEntrar = true;
                    B_ProveedorExtranjero = false;
                    DataTable dtProveedores = sqlCompras.Sk_SugiereProveedorRequisicion(K_Requisicion);
                    if (dtProveedores != null)
                    {
                        if (dtProveedores.Rows.Count > 0)
                        {
                            if (txtClaveProveedor.Text.Trim().Length == 0)
                            {
                                Busquedas.BuscaProveedoresRequisicion frm = new Busquedas.BuscaProveedoresRequisicion();
                                frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
                                frm.BusquedaPropiedadTablaFiltra = dtProveedores;
                                frm.BusquedaPropiedadTitulo = "Busca Proveedores";
                                frm.ShowDialog();
                                if (frm.BusquedaPropiedadReglonRes != null)
                                {
                                    txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                                    txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
                                    B_ProveedorExtranjero = Convert.ToBoolean(frm.BusquedaPropiedadReglonRes["B_ProveedorExtranjero"].ToString());
                                    if (frm.BusquedaPropiedadReglonRes["TiempoTotalEntrega"] != null)
                                        txtTiempoEntrega.Text = frm.BusquedaPropiedadReglonRes["TiempoTotalEntrega"].ToString();
                                    //if (frm.BusquedaPropiedadReglonRes["TiempoEntrega"] != null)
                                    //    txtTiempoEntrega.Text = frm.BusquedaPropiedadReglonRes["TiempoEntrega"].ToString();

                                    decimal PrecioArticulo = 0;
                                    int K_Articulo = 0;
                                    if (frm.BusquedaPropiedadReglonRes["PrecioArticulo"] != null)
                                        PrecioArticulo = Convert.ToDecimal(frm.BusquedaPropiedadReglonRes["PrecioArticulo"]);
                                    if (frm.BusquedaPropiedadReglonRes["K_Articulo"] != null)
                                        K_Articulo = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Articulo"]);

                                    DataTable dtProveedorSeleccionado;

                                    dtProveedorSeleccionado = dtProveedores.Select("K_Proveedor = " + txtClaveProveedor.Text).CopyToDataTable();

                                    //ModificaPrecioRequisicion(K_Articulo, PrecioArticulo, dtProveedorSeleccionado);

                                    foreach (DataRow drow in dtProveedorSeleccionado.Rows)
                                    {
                                        K_Articulo = Convert.ToInt32(drow["K_Articulo"]);
                                        PrecioArticulo = Convert.ToDecimal(drow["PrecioArticulo"]);

                                        foreach (DataRow ren in dtDatos.Rows)
                                        {
                                            if (Convert.ToInt32(ren["K_Articulo"]) == K_Articulo)
                                            {
                                                ren["Unitario"] = PrecioArticulo;
                                                ren["PrecioTotal"] = Convert.ToDecimal(ren["Cantidad"]) * Convert.ToDecimal(ren["Unitario"]);
                                                if (B_ProveedorExtranjero)
                                                {
                                                    ren["TasaIVA"] = 0;
                                                }
                                            }
                                        }
                                    }



                                    grdOrdenCompra.DataSource = dtDatos;
                                    grdOrdenCompra.EditMode = DataGridViewEditMode.EditOnEnter;
                                    grdOrdenCompra.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                                    grdOrdenCompra.MultiSelect = false;

                                    if (B_ProveedorExtranjero)
                                        CalculaTotales();

                                    //    for (int irow = 0; irow < grdOrdenCompra.Rows.Count; irow++)
                                    //    {
                                    //        DataGridViewComboBoxCell cell =
                                    //            (DataGridViewComboBoxCell)(grdOrdenCompra.Rows[irow].Cells["D_Tipo_Empaque"]);
                                    //        cell.DataSource = dtTipoEmpaque;// sqlCatalogos.sps_TipoEmpaque(true);
                                    //        cell.ValueMember = "K_Tipo_Empaque";
                                    //        cell.DisplayMember = "D_Tipo_Empaque";
                                    //        cell.Value = grdOrdenCompra.Rows[irow].Cells["K_Tipo_Empaque"].Value;
                                    //    }

                                    grdOrdenCompra.Rows[0].Cells[0].Selected = true;
                                }
                            }
                        }
                    }

                }


            }

        }

        private void ModificaPrecioRequisicion(int K_Articulo, decimal Precio, DataTable dtProveedorSeleccionado)
        {
            foreach (DataRow drow in dtProveedorSeleccionado.Rows)
            {

                foreach (DataGridViewRow row in grdOrdenCompra.Rows)
                {
                    if (Convert.ToInt32(row.Cells["K_Articulo"].Value) == K_Articulo)
                    {
                        row.Cells["Unitario"].Value = Precio;
                        CambiaCantidades(row.Cells["K_Articulo"].ColumnIndex, row, row.Cells["K_Articulo"].RowIndex);
                    }
                }
            }
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            //BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);

            //if (txtClaveOficina.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtClaveOficina.Focus();
            //}


        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            //DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            //BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);

            //if (txtClaveProveedor.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtClaveProveedor.Focus();
            //}
        }

        private void grdOrdenCompra_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (blnCeldaImportes() )
            {
                if (grdOrdenCompra[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    if (Keys.Back.ToString() == strKeyPress)
                    {
                        SendKeys.Send("{RIGHT}");
                    }
                }
            }
            BaseBotonGuardar.Enabled = false;
        }

        private bool blnCeldaImportes()
        {
            if (grdOrdenCompra.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdOrdenCompra.CurrentCell.ColumnIndex == 6);
        }

        private bool blnCeldaCantidad()
        {
            if (grdOrdenCompra.CurrentCell == null)
                return false;
            //if (B_NoEntrar == false)
            //    return false;

            return (grdOrdenCompra.CurrentCell.ColumnIndex == 4);
        }

        private bool blnCeldaDescuento()
        {
            if (grdOrdenCompra.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdOrdenCompra.CurrentCell.ColumnIndex == 8);
        }

        private bool blnCeldaDescuento2()
        {
            if (grdOrdenCompra.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdOrdenCompra.CurrentCell.ColumnIndex == 10);
        }

        private void grdOrdenCompra_KeyDown(object sender, KeyEventArgs e)
        {
            strKeyPress = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void grdOrdenCompra_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA PRECIO UNITARIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (blnCeldaCantidad())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA CANTIDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (blnCeldaDescuento())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA DESCUENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (blnCeldaDescuento2())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA DESCUENTO 2...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void grdOrdenCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = grdOrdenCompra.CurrentRow;
            if (ren != null)
            {
                if ((blnCeldaImportes()) ||(blnCeldaCantidad()) ||(blnCeldaDescuento()) ||(blnCeldaDescuento2()))
                {
                    if (ren.Cells["Cantidad"].Value != null)
                    {
                        if(Convert.ToInt32(ren.Cells["Cantidad"].Value) ==0)
                        {
                            dtDatos.Rows[e.RowIndex].Delete();
                            dtDatos.AcceptChanges();
                            Calcula();
                        }
                        else
                        {
                            CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);
                        }
                    }
                    else
                    {
                        CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);
                    }
    
                }
            }
        }

        private void CambiaCantidades(Int32 IndiceColumna, DataGridViewRow ren, Int32 IndiceRegistro)
        {
            if (!EsNumero(Convert.ToDecimal(ren.Cells["Unitario"].Value)))
            {
                MessageBox.Show("LA COLUMNA PRECIO UNITARIO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdOrdenCompra.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }
            if (!EsNumero(Convert.ToInt32(ren.Cells["Cantidad"].Value)))
            {
                MessageBox.Show("LA COLUMNA CANTIDAD SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdOrdenCompra.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }
            try
            {
                if (!EsNumero(Convert.ToDecimal(ren.Cells["Porcentaje_Descuento"].Value)))
                {
                    MessageBox.Show("LA COLUMNA PORCENTAJE DESCUENTO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdOrdenCompra.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
                if (Convert.ToDecimal(ren.Cells["Porcentaje_Descuento"].Value) >= 100)
                {
                    MessageBox.Show("EL PORCENTAJE DE DESCUENTO DEBE SER MENOR A 100", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdOrdenCompra.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
                if (!EsNumero(Convert.ToDecimal(ren.Cells["Porcentaje_Descuento_2"].Value)))
                {
                    MessageBox.Show("LA COLUMNA PORCENTAJE DESCUENTO 2 SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdOrdenCompra.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
                if (Convert.ToDecimal(ren.Cells["Porcentaje_Descuento_2"].Value) >= 100)
                {
                    MessageBox.Show("EL PORCENTAJE DE DESCUENTO 2 DEBE SER MENOR A 100", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdOrdenCompra.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
            }
            catch (Exception) { }

            decimal Unitario = 0;
            Int32 Cantidad = 0;
            decimal Importe = 0;
            decimal SubTotal = 0;
            decimal TotalIVA = 0;
            decimal Porcentaje = 0;
            decimal Porcentaje_Descuento = 0;
            decimal Monto_Descuento = 0;
            decimal Porcentaje_Descuento_2 = 0;
            decimal Monto_Descuento_2 = 0;

            if (ren.Cells["Unitario"].Value != null)
                Unitario = Math.Round(Convert.ToDecimal(ren.Cells["Unitario"].Value), 2);
            if (ren.Cells["Cantidad"].Value != null)
            {
                Cantidad = Convert.ToInt32(ren.Cells["Cantidad"].Value);
            }           
            if (ren.Cells["Porcentaje"].Value != null)
                Porcentaje = Convert.ToDecimal(ren.Cells["Porcentaje"].Value);
            if (ren.Cells["Porcentaje_Descuento"].Value != null)
            {
                Porcentaje_Descuento = Convert.ToDecimal(ren.Cells["Porcentaje_Descuento"].Value);
                Monto_Descuento = (Porcentaje_Descuento / 100) * Convert.ToDecimal(ren.Cells["Subtotal"].Value);
            }
                
            if (ren.Cells["Porcentaje_Descuento_2"].Value != null)
            {
                Porcentaje_Descuento_2 = Convert.ToDecimal(ren.Cells["Porcentaje_Descuento_2"].Value);
                Monto_Descuento_2 = (Porcentaje_Descuento_2 / 100) * Convert.ToDecimal(ren.Cells["Subtotal"].Value);
            }
               
            ren.Cells["Unitario"].Value = Unitario;
            ren.Cells["Cantidad"].Value = Cantidad;
            ren.Cells["Porcentaje"].Value = Porcentaje;
            ren.Cells["Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            ren.Cells["Monto_Descuento"].Value = Monto_Descuento;
            ren.Cells["Porcentaje_Descuento_2"].Value = Porcentaje_Descuento_2;
            ren.Cells["Monto_Descuento_2"].Value = Monto_Descuento_2;

            SubTotal = Math.Round(Cantidad * Unitario, 2);
            TotalIVA = Math.Round((SubTotal-Monto_Descuento-Monto_Descuento_2) * Porcentaje / 100, 2);
            Importe = Math.Round(((SubTotal - Monto_Descuento - Monto_Descuento_2) + TotalIVA),2);

            grdOrdenCompra.Rows[IndiceRegistro].Cells["SubTotal"].Value = SubTotal;
            grdOrdenCompra.Rows[IndiceRegistro].Cells["IVA"].Value = TotalIVA;
            grdOrdenCompra.Rows[IndiceRegistro].Cells["PrecioTotal"].Value = Importe;

            Calcula();
        }

        private void grdOrdenCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grdOrdenCompra_KeyPress);
            e.Control.TextChanged += new EventHandler(grdOrdenCompra_TextChanged);
            DataGridViewComboBoxEditingControl dgvCombo = e.Control as DataGridViewComboBoxEditingControl;

            if (dgvCombo != null)
            {
                // se remueve el handler previo que pudiera tener asociado, a causa ediciones previas de la celda
                // evitando asi que se ejecuten varias veces el evento
                //
                //dgvCombo.SelectedIndexChanged -= new  EventHandler(dvgCombo_SelectedIndexChanged);               

                dgvCombo.SelectedIndexChanged += new EventHandler(dvgCombo_SelectedIndexChanged);
            }
        }

        private void dvgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable temporal;

            temporal = dtDatos.Copy();
            ComboBox combo = sender as ComboBox;
            DataGridViewRow ren = grdOrdenCompra.CurrentRow;
            if (combo.SelectedValue == null)
            {
                return;
            }
            if (combo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            //if (ren != null)
            //{
            //    strTipoEmpaque = combo.Text;
            //    intTipoEmpaque = Convert.ToInt32(combo.SelectedValue);


            //    foreach (DataRow DRow in temporal.Rows)
            //    {
            //        if ( //Convert.ToInt32(ren.Cells["K_Requisicion"].Value) == Convert.ToInt32(DRow["K_Requisicion"]) &&
            //            Convert.ToInt32(ren.Cells["K_Detalle_Requisicion"].Value) == Convert.ToInt32(DRow["K_Detalle_Requisicion"])
            //            )
            //        {

            //            try
            //            {
            //                DRow["K_Tipo_Empaque"]  = combo.SelectedValue;
            //                DRow["D_Tipo_Empaque"] = combo.Text;
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message);
            //            }


            //        }
            //    }

            //    dtDatos = temporal.Copy();
            //}
        }

        private void grdOrdenCompra_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length > 0)
            {
                decimal valor = 0;
                if (!decimal.TryParse(textBox.Text.Trim().Replace("$", ""), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void grdOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!grdOrdenCompra.CurrentCell.IsInEditMode)
                {
                    grdOrdenCompra.BeginEdit(true);
                    return;
                }
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;
                    if ((textBox.Text.Trim().Length == 0) && (e.KeyChar.ToString() == "."))
                    {
                        e.Handled = true;
                    }

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
            if (blnCeldaDescuento())
            {
                if (!grdOrdenCompra.CurrentCell.IsInEditMode)
                {
                    grdOrdenCompra.BeginEdit(true);
                    return;
                }
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;
                    if ((textBox.Text.Trim().Length == 0) && (e.KeyChar.ToString() == "."))
                    {
                        e.Handled = true;
                    }

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
            if(blnCeldaCantidad())
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            if (blnCeldaDescuento2())
            {
                if (!grdOrdenCompra.CurrentCell.IsInEditMode)
                {
                    grdOrdenCompra.BeginEdit(true);
                    return;
                }
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;
                    if ((textBox.Text.Trim().Length == 0) && (e.KeyChar.ToString() == "."))
                    {
                        e.Handled = true;
                    }

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
        }

        private void grdOrdenCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // string algo = "dsasdf";
            BaseBotonGuardar.Enabled = true;
        }

        void Reporte(Int32 K_Orden_Compra)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = sqlCompras.Gp_Sk_ReporteOC(K_Orden_Compra);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportedtCorreo = sqlCatalogos.Sk_Contactos_Proveedor(Convert.ToInt32(dtResultado.Rows[0]["K_Proveedor"].ToString()));

                if (ReportedtCorreo != null)
                {
                    if (ReportedtCorreo.Rows.Count > 0)
                    {
                        ReportedtCorreo.Columns.Add("K_Orden_Compra", typeof(int));
                        ReportedtCorreo.Columns.Add("K_Usuario_Elaboro", typeof(int));
                        ReportedtCorreo.Columns.Add("D_Usuario", typeof(string));
                        ReportedtCorreo.Columns.Add("CorreoUsuario", typeof(string));

                        foreach (DataRow row in ReportedtCorreo.Rows)
                        {
                            row["K_Orden_Compra"] = Convert.ToInt32(K_Orden_Compra);
                            row["K_Usuario_Elaboro"] = Convert.ToInt32(dtResultado.Rows[0]["K_Usuario_Elaboro"]);
                            row["D_Usuario"] = dtResultado.Rows[0]["D_Usuario"];
                            row["CorreoUsuario"] = dtResultado.Rows[0]["E_Mail"];
                            ReportedtCorreo.AcceptChanges();
                        }

                    }
                }


                ReportDocument rpt = new ProbeMedic.COMPRAS.RPT_Orden_Compra();
                ReporteTitulo = "Orden de Compra";
                ReporteModulo = "Orden de Compra";
                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private void grdRequisiciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            fx.DibujarColumnaTipoBotonGrid(ref grdRequisiciones, imageList1, e, "Inventario", "inventario1.png");
        }

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Inventario";
                buttons.Text = "-";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 18;
            }

            grdOrdenCompra.Columns.Add(buttons);

        }

        private void grdOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdOrdenCompra.Columns[e.ColumnIndex].Index == 17)
            {
                COMPRAS.FRM_Inventario_Articulo frm = new COMPRAS.FRM_Inventario_Articulo();
                frm.K_Articulo_ = Convert.ToInt32(grdOrdenCompra.CurrentRow.Cells["K_Articulo"].Value);
                frm.ShowDialog();
            }
        }

        private void grdRequisiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                AgregarRequisicion();
        }

        private bool Mtd_Bloquea_Requisicion(Int32 K_Requisicion)
        {
            try
            {

                sqlCompras.GP_Bloquea_Movimientos(K_Requisicion, 0, 0);
                BaseMetodoInicio();
                return true;
            }
            catch
            {

                return false;
            }


        }

        private void Frm_OrdenesCompra_Load(object sender, EventArgs e)
        {
            //Crea Columnas
            dtDatos.Columns.Clear();
            dtDatos.Columns.Add("K_Requisicion", typeof(int));
            dtDatos.Columns.Add("K_Detalle_Requisicion", typeof(int));
            dtDatos.Columns.Add("K_Articulo", typeof(int));
            dtDatos.Columns.Add("K_Tipo_Empaque", typeof(int));
            dtDatos.Columns.Add("D_Articulo", typeof(string));
            dtDatos.Columns.Add("Cantidad", typeof(int));
            dtDatos.Columns.Add("Unitario", typeof(decimal));
            dtDatos.Columns.Add("SubTotal", typeof(decimal));
            dtDatos.Columns.Add("TasaIVA", typeof(decimal));
            dtDatos.Columns.Add("PrecioTotal", typeof(decimal));
            dtDatos.Columns.Add("D_Unidad_Medida", typeof(string));
            dtDatos.Columns.Add("D_Tipo_Articulo", typeof(string));
            dtDatos.Columns.Add("D_Clasificacion_Articulo", typeof(string));
            dtDatos.Columns.Add("Porcentaje", typeof(decimal));
            dtDatos.Columns.Add("Porcentaje_Descuento", typeof(decimal));
            dtDatos.Columns.Add("Monto_Descuento", typeof(decimal));
            dtDatos.Columns.Add("Porcentaje_Descuento_2", typeof(decimal));
            dtDatos.Columns.Add("Monto_Descuento_2", typeof(decimal));
            txtClaveOficina.Focus();

            AddButtonColumn();
        }

        private void txtFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            if(K_Orden_Compra==0)
            {
                if (txtFechaEntrega.Value < DateTime.Now)
                {
                    MessageBox.Show("LA FECHA DE ENTREGA NO PUEDE SER MENOR A LA ACTUAL!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFechaEntrega.Value = DateTime.Now.AddDays(1);
                    return;
                }
            }
        
        }

        private void txtFechaEntrega_Leave(object sender, EventArgs e)
        {
            DateTime F_Actual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime F_Entrega = new DateTime(txtFechaEntrega.Value.Year, txtFechaEntrega.Value.Month, txtFechaEntrega.Value.Day);

            // Difference in days, hours, and minutes.
            TimeSpan ts = F_Entrega - F_Actual;

            // Difference in days.
            int differenceInDays = ts.Days;

            txtTiempoEntrega.Text = differenceInDays.ToString();
        }

        private void txtTiempoEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTiempoEntrega_TextChanged(object sender, EventArgs e)
        {
            if (txtTiempoEntrega.Text.Trim().Length == 0)
            {
                txtTiempoEntrega.Text = "1";
            }
            if ((Convert.ToDecimal(txtTiempoEntrega.Text.Trim()) <= 0) || (txtTiempoEntrega.Text.Trim().Length == 0))
            {
                MessageBox.Show("EL TIEMPO DE ENTREGA DEBE SER MAYOR A CERO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTiempoEntrega.Text = "1";
                return;
            }
            if (Convert.ToInt32(txtTiempoEntrega.Text.Trim()) > 365)
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                    "EL VALOR MÁXIMO PERMITIDO ES 365 DIAS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiempoEntrega.Text = "1";
            }

        }

        private void txtTiempoEntrega_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtTiempoEntrega.Text != "")
                {
                    DateTime Dt = new DateTime();
                    Dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    Dt = Dt.AddDays(txtTiempoEntrega.Text.Length == 0 ? 0 : Convert.ToDouble(txtTiempoEntrega.Text));

                    txtFechaEntrega.Value = Dt;

                }
            }
        }

        private void grdRequisiciones_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdRequisiciones.Cursor = Cursors.Hand;
            else
                grdRequisiciones.Cursor = Cursors.Default;
        }

        private void txtClaveProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()) || ((e.KeyChar == Convert.ToChar(Keys.Back)))))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cursor = Cursors.WaitCursor;
                DataTable dtProveedores = sqlCatalogos.Sk_Proveedores_Autorizados();
                BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);
                Cursor = Cursors.Default;

                if (txtClaveProveedor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    txtClaveProveedor.Focus();
                }
                else
                {
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
                    if (dtSucursales != null)
                    {
                        DataRow dr = dtSucursales.NewRow();

                        dr["K_Sucursal_Proveedor"] = 0;
                        dr["K_Proveedor"] = 0;
                        dr["D_Sucursal_Proveedor"] = "";
                        dr["D_Proveedor"] = "";

                        dtSucursales.Rows.InsertAt(dr, 0);

                        dtSucursales.AcceptChanges();

                        int indice = -1;
                        indice = 0;
                        LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", indice);

                        cbxSucursales.SelectedValue = 0;
                    }
                    else
                    {
                        cbxSucursales.DataSource = null;
                        cbxSucursales.Items.Clear();
                    }
                }

            }
            else
            {
                e.Handled = true;
            }
           
        }

        private void txtClaveProveedor_TextChanged(object sender, EventArgs e)
        {
            if(txtClaveProveedor.Text.Trim().Length>0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClaveProveedor.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveProveedor.Text = string.Empty;
                    txtClaveProveedor.Focus();
                }
            }
      
        }

        private void txtClaveOficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()) || ((e.KeyChar == Convert.ToChar(Keys.Back)))))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = false;
                Cursor = Cursors.WaitCursor;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                Cursor = Cursors.Default;
                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Focus();
                }
                else
                {
                    CargaAlmacenes();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClaveOficina_TextChanged(object sender, EventArgs e)
        {
            if(txtClaveOficina.Text.Trim().Length>0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClaveOficina.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VÁLIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Text = string.Empty;
                    txtClaveOficina.Focus();
                }
            }
          
        }

        private void Calcula()
        {
            var x = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("SubTotal"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    decimal Total_Subtotal = Convert.ToDecimal(x);
                    txtSubtotal.Text = Math.Round(Total_Subtotal, 2).ToString("N2").Trim();
                }

           }
            var y = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("TasaIva"))).Sum();
            if (y.ToString() != "")
            {
                if (y >= 0)
                {
                    decimal Total_IVA = Convert.ToDecimal(y);
                    txtIVA.Text = Math.Round(Total_IVA, 2).ToString("N2").Trim();
                }

            }
            var z = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("PrecioTotal"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    decimal PrecioTotal = Convert.ToDecimal(z);
                    txtTotal.Text = Math.Round(PrecioTotal, 2).ToString("N2").Trim();
                }

            }
            var w = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Monto_Descuento"))).Sum();
            if (w.ToString() != "")
            {
                if (w >= 0)
                {
                    decimal Monto_Descuento = Convert.ToDecimal(w);
                    txtDesc1.Text = Math.Round(Monto_Descuento, 2).ToString("N2").Trim();
                }

            }
            var p = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Monto_Descuento_2"))).Sum();
            if (p.ToString() != "")
            {
                if (p >= 0)
                {
                    decimal Monto_Descuento_2 = Convert.ToDecimal(p);
                    txtDesc2.Text = Math.Round(Monto_Descuento_2, 2).ToString("N2").Trim();
                }

            }
        }

        private void txtClaveOficina_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Cursor = Cursors.WaitCursor;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                Cursor = Cursors.Default;

                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Focus();
                }
                else
                {
                    CargaAlmacenes();
                }
            }
        }

        private void CargaAlmacenes()
        {
            DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text));
            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                cbxAlmacen.SelectedValue = 0;
            }
        }

        private void txtClaveProveedor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Cursor = Cursors.WaitCursor;
                DataTable dtProveedores = sqlCatalogos.Sk_Proveedores_Autorizados();
                BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);
                Cursor = Cursors.Default;

                if (txtClaveProveedor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    txtClaveProveedor.Focus();
                }
                else
                {
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
                    if (dtSucursales != null)
                    {
                        DataRow dr = dtSucursales.NewRow();

                        dr["K_Sucursal_Proveedor"] = 0;
                        dr["K_Proveedor"] = 0;
                        dr["D_Sucursal_Proveedor"] = "";
                        dr["D_Proveedor"] = "";

                        dtSucursales.Rows.InsertAt(dr, 0);

                        dtSucursales.AcceptChanges();

                        int indice = -1;
                        indice = 0;
                        LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", indice);

                        cbxSucursales.SelectedValue = 0;
                    }
                    else
                    {
                        cbxSucursales.DataSource = null;
                        cbxSucursales.Items.Clear();
                    }
                }
            }
        }

        private void Frm_OrdenesCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F10))
            {
                BaseBotonProceso1Click();
            }
        }

        private void cbxAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void grdOrdenCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = grdOrdenCompra.CurrentRow;
                if (row != null)
                {
                    int K_Detalle_Requisicion = Convert.ToInt32(row.Cells[2].Value);

                    DataRow ren = dtDatos.AsEnumerable().Where(p => p.Field<int>("K_Detalle_Requisicion") == K_Detalle_Requisicion).FirstOrDefault();
                    if (ren != null)
                        dtDatos.Rows.Remove(ren);

                    Calcula();
                }
            }
        }

        private void grdOrdenCompra_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdOrdenCompra.Cursor = Cursors.Hand;
            else
                grdOrdenCompra.Cursor = Cursors.Default;
        }
    }
}
