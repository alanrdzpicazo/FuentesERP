﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using ProbeMedic;
using ProbeMedic.Busquedas;
using CrystalDecisions.CrystalReports.Engine;
//using ProbeMedic.Scanner;
using System.Configuration;
using System.IO;
// using ProbeMedic.Services;
//using CrystalDecisions.CrystalReports;


namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_NotasRecepcion : FormaBase
    {
        int res = 0;
        string msg = string.Empty;
        bool xml, pdf, B_Autoriza = false;
        int K_Oficina = 0;
        int K_Almacen = 0;
        string Factura = string.Empty;
        DataTable dtDetalle = new DataTable();
        DataTable dtDetallePaso = new DataTable();
        DataTable dtNotaRecepcion = new DataTable();
        DataTable dtDatos = new DataTable();
        DataTable dtAlmacen = new DataTable();
        SQLCompras sqlCompras = new SQLCompras();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();
        SQLCatalogos sQLCatalogos = new SQLCatalogos();

        private bool correPrimeraVez = true;

        private int k_Nota_Recepcion;
        // private bool bIsCertRequired;
        public int K_Nota_Recepcion { get { return k_Nota_Recepcion; } set { k_Nota_Recepcion = value; } }
        // public int B_Acepta { get { return B_Acepta; } set { B_Acepta = value; } }
        public int K_Orden_Compra { get; set; }

        public Frm_NotasRecepcion( int KOrdenCompra)
        {
            BaseGridSinFormato = true;
            K_Orden_Compra = KOrdenCompra;
            InitializeComponent();
        }
        private class EmpaqueModel
        {
            public int K_Tipo_Empaque { get; set; }
            public string D_Tipo_Empaque { get; set; }
        }
        private void doActualizaDatosNotaRecepcion()
        {
            dtNotaRecepcion = sqlRecepcion.Sk_ConsultaEncNotaRecepcion(k_Nota_Recepcion, K_Orden_Compra);
            BaseDtDatos = dtNotaRecepcion;
            doDespliegaDatosIniciales();
            doActualizaDatosNotaRecepcionDetalle();  
        }
        private void doDespliegaDatosIniciales()
        {
            if ((dtNotaRecepcion == null) || (dtNotaRecepcion.Rows.Count == 0))
                return;
            DataRow dr = dtNotaRecepcion.Rows[0];
            txtNoOrden.Text = Convert.ToString(K_Orden_Compra);
            txtClaveOficina.Text = dr["K_Oficina_Recibe"].ToString();
            txtOficina.Text = dr["D_Oficina"].ToString();
            txtClaveProveedor.Text = dr["K_Proveedor"].ToString();
            txtProveedor.Text = dr["D_Proveedor"].ToString();
            txtClaveTipoDocto.Text = dr["Tipo_Documento"].ToString();
            txtTipoDocto.Text = dr["D_Tipo_Documento"].ToString();
            int tipoDocto = Convert.ToInt32(dr["Tipo_Documento"].ToString());
            doChangeTipoDocto(tipoDocto);
            string factura = dr["Factura"].ToString();
            DateTime FFactura = new DateTime(2000, 01, 01);
            if (dr["F_Factura"].ToString().Length > 5)
            { FFactura = Convert.ToDateTime(dr["F_Factura"].ToString()); }
            string remison = dr["NoRemision"].ToString();
            DateTime FRemision = new DateTime(2000, 01, 01);
            if (dr["F_Remision"].ToString().Length > 5)
            { FRemision = Convert.ToDateTime(dr["F_Remision"].ToString()); }
            txtNoDocto.Text = factura;
            txtFDocto.Value = FFactura;
            doMuestraCamposTipoDocto(tipoDocto == 1);
            cmbMoneda.SelectedValue = Convert.ToInt32(dr["K_Tipo_Moneda"].ToString());
            cbxAlmacen.SelectedValue = Convert.ToInt32(dr["K_Almacen"].ToString());
            txtTipoCambio.Text = dr["Tipo_Cambio"].ToString();
            txtSubTotal.Text = dr["SubTotal"].ToString();
            //txtSubTotal.Text = TxtImporteToStr(txtSubTotal);
            txtTasaIVA.Text = dr["TasaIVA"].ToString();
            txtIVA.Text = dr["TotalIVA"].ToString();
            //txtIVA.Text = TxtImporteToStr(txtIVA);
            txtTotal.Text = dr["Total"].ToString();
            //txtTotal.Text= TxtImporteToStr(txtTotal);
            txtTotalFactura.Text = dr["Total"].ToString();
            //txtTotalFactura.Text = TxtImporteToStr(txtTotalFactura);
            txtObservaciones.Text = dr["Observaciones"].ToString();
            if (txtNoDocto.Text != "")
            {
                txtNoDocto.ReadOnly  = true;
                txtFDocto.Enabled = false;
                txtObservaciones.ReadOnly = true;
            }
        }
        private void doChangeTipoDocto(int tipoDocto)
        {
                    lblNoDocto.Text = "No. Factura";
                    lblFDocto.Text = "F Factura";
                    doMuestraCamposTipoDocto(true);
        }
        private void doMuestraTipoCambio(bool isVisible)
        {
            if (isVisible)
            {
                var dtTipoCambio = sqlCatalogos.Sk_Tipo_Moneda();
                if (dtTipoCambio.Rows.Count == 0)
                {
                    MessageBox.Show("Para el día de hoy no fue posible localizar Tipo de cambio registrado...");
                    return;
                }

                txtTipoCambio.Text = dtTipoCambio.Rows[0]["Tipo_Cambio"].ToString();
            }

        }
        private void doMuestraCamposTipoDocto(bool isVisible)
        {
            cmbMoneda.Visible = isVisible;
            if (isVisible && cmbMoneda.SelectedIndex != 1)
            {
                lblTipoCambio.Visible = isVisible;
                txtTipoCambio.Visible = isVisible;
                doMuestraTipoCambio(isVisible);
            }
            else
            {
                lblTipoCambio.Visible = false;
                txtTipoCambio.Visible = false;
            }
            txtSubTotal.Visible = isVisible;
            txtIVA.Visible = isVisible;
            txtTasaIVA.Visible = isVisible;
            txtTotal.Visible = isVisible;
            lblMoneda.Visible = isVisible;
            lblSubTotal.Visible = isVisible;
            lblTasaIVA.Visible = isVisible;
            lblIVA.Visible = isVisible;
            lblTotal.Visible = isVisible;
        }
        private void doLlenaDetalle()
        {         
            dtDetallePaso = sqlRecepcion.Sk_ConsultaNotaRecepcion(k_Nota_Recepcion, K_Orden_Compra);

            if(dtDetallePaso!=null)
            {
                dtDetalle = dtDetallePaso.Clone();
           
                dtDetallePaso.AcceptChanges();

                bool B_Existe;
                int K_ArticuloAux;
                foreach (DataRow row in dtDetallePaso.Rows)
                {
                    K_ArticuloAux = Convert.ToInt32(row["K_Articulo"].ToString());

                    if (dtDetalle.Rows.Count == 0)
                    {
                        dtDetalle.ImportRow(row);
                        dtDetalle.Columns["Cantidad_Nota"].ReadOnly = false;
                        dtDetalle.Columns["Cantidad_Recibida"].ReadOnly = false;
                        dtDetalle.Columns["PrecioUnitario"].ReadOnly = false;
                        dtDetalle.Columns["TasaIVA"].ReadOnly = false;
                        dtDetalle.Columns["TotalIVA"].ReadOnly = false;
                        dtDetalle.Columns["TotalDetalle"].ReadOnly = false;
                    }
                    else
                    {
                        B_Existe = false;
                        //se encuentra  sumo 
                        foreach (DataRow row2 in dtDetalle.Rows)
                        {
                            B_Existe = false;

                            if (K_ArticuloAux == Convert.ToInt32(row2["K_Articulo"].ToString()))
                            {
                                row2["Cantidad_Nota"] = Convert.ToInt32(row2["Cantidad_Nota"]) + Convert.ToInt32(row["Cantidad_Nota"]);
                                row2["TotalIVA"] = Convert.ToDecimal(row2["TotalIVA"]) + Convert.ToDecimal(row["TotalIVA"]);
                                row2["TotalDetalle"] = Convert.ToDecimal(row2["TotalDetalle"]) + Convert.ToDecimal(row["TotalDetalle"]);
                                B_Existe = true;
                                break;
                            }
                        }
                        if (B_Existe == false)
                        {
                            dtDetalle.ImportRow(row);

                        }
                    }
                }







                grdDatos.DataSource = dtDetalle;




            }
            else
            {
                dtDetalle = null;
            }
         
        
        }
        private DataTable Transformar(IEnumerable<IGrouping<string, DataRow>> datos)
        {
            //
            // Se define la estructura del DataTable
            //
            DataTable dt = new DataTable();
            dt.Columns.Add("Documento");
            dt.Columns.Add("CantRegistros");
            dt.Columns.Add("Total");

            //
            // Se recorre cada valor agruparo por linq y se vuelca el resultado 
            // en un nuevo registro del datatable
            //
            foreach (IGrouping<string, DataRow> item in datos)
            {
                DataRow row2 = dt.NewRow();
                row2["Documento"] = item.Key;
                row2["CantRegistros"] = item.Count();
                row2["Total"] = item.Sum<DataRow>(x => Convert.ToInt32(x["Total"]));

                dt.Rows.Add(row2);
            }

            return dt;
        }
        private void doCreaCamposDetalle()
        {
            dtDetalle.Columns.Clear();
            dtDetalle.Columns.Add("K_Detalle_Nota_Recepcion", typeof(int));
            dtDetalle.Columns.Add("K_Nota_Recepcion", typeof(int));
            dtDetalle.Columns.Add("K_Articulo", typeof(int));
            dtDetalle.Columns.Add("Cantidad_Nota", typeof(double));
            dtDetalle.Columns.Add("Cantidad_Recibida", typeof(double));
            dtDetalle.Columns.Add("PrecioUnitario", typeof(double));
            dtDetalle.Columns.Add("TasaIVA", typeof(double));
            dtDetalle.Columns.Add("TotalIVA", typeof(double));
            dtDetalle.Columns.Add("TotalDetalle", typeof(double));
            dtDetalle.Columns.Add("No_Lote", typeof(string));
            dtDetalle.Columns.Add("B_Recibe_Completa", typeof(bool));
            dtDetalle.Columns.Add("K_Usuario_Recibe", typeof(int));
            dtDetalle.Columns.Add("F_Recepcion", typeof(DateTime));
            dtDetalle.Columns.Add("Cantidad_Empaques", typeof(short));
            dtDetalle.Columns.Add("D_Articulo", typeof(string));
            dtDetalle.Columns.Add("D_Unidad_Medida", typeof(string));
            dtDetalle.Columns.Add("D_Tipo_Articulo", typeof(string));
            dtDetalle.Columns.Add("K_Clasificacion_Articulo", typeof(int));
            dtDetalle.Columns.Add("D_Clasificacion_Articulo", typeof(string));
            dtDetalle.Columns.Add("B_RequiereInventario", typeof(bool));
            dtDetalle.Columns.Add("SKU", typeof(string));
        }
        private void doActualizaDatosNotaRecepcionDetalle()
        {

            doCreaCamposDetalle();
            doLlenaDetalle();
            grdDatos.DataSource = dtDetalle;
         

        }
        void MtdCargaAlmacen()
        {
            if (dtAlmacen != null)
                dtAlmacen.Rows.Clear();
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            K_Oficina = Convert.ToInt32(txtClaveOficina.Text);

            dtAlmacen = sqlCatalogos.Sk_Almacenes(K_Oficina);

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 1;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }
        private static DataTable doCreaTipoDocto()
        {
            DataTable dtTipoDocto = new DataTable();
            dtTipoDocto.Columns.Clear();
            dtTipoDocto.Columns.Add("K_Tipo_Docto", typeof(int));
            dtTipoDocto.Columns.Add("D_Tipo_Docto", typeof(string));
            DataRow dr = dtTipoDocto.NewRow();
            dr["K_Tipo_Docto"] = 1;
            dr["D_Tipo_Docto"] = "FACTURA";
            dtTipoDocto.Rows.Add(dr);
            return dtTipoDocto;
        }
        private void LlenaEmpaque()
        {
            //  throw new NotImplementedException();
        }
        private bool validaCantidadRecibida()
        {
            foreach (DataRow dr in dtDetalle.Rows)
            {
                double cantidadRecibida = Convert.ToDouble(dr["Cantidad_Recibida"].ToString());
                double cantidadNota = Convert.ToDouble(dr["Cantidad_Nota"].ToString());
                if (cantidadRecibida != 0 && cantidadNota != 0)
                {
                    return false;
                }
            }
            string msg = String.Format("Para poder guardar la nota de recepción se debe recibir al menos un artículo");
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();

            #region botones e inicialización

            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonCancelar.Visible = false;

            #region Inicialización de la Nota Recepción
            #endregion

            #endregion

            #region combos
            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            if (dtMoneda != null && cmbMoneda.SelectedIndex == -1)
            {
                LlenaCombo(dtMoneda, ref cmbMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 1);
            }
            dtAlmacen = sqlCatalogos.Sk_Almacenes();
            if (dtAlmacen != null && cbxAlmacen.SelectedIndex == -1)
            {
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen");
            }
            #endregion

            pnlDetalleRecepcion.Enabled = false;

            txtNoOrden.Focus();

            base.BaseMetodoInicio();
            BaseMetodoLimpiaControles();
            HabilitaBotones(this, false);
            BaseBotonNuevoClick();
            BaseBotonCancelar.Visible = false;
            txtNoDocto.Focus();
            this.WindowState = FormWindowState.Maximized;
        }
        public override void BaseBotonNuevoClick()
        {
            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;

            pnlDetalleRecepcion.Enabled = true;

            txtNoOrden.Focus();
        }
        public override void BaseBotonCancelarClick()
        {
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseMetodoLimpiaControles();
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = false;
            BasePropiedadId_Identity = 0;
        }
        public override void BaseMetodoLimpiaControles()
        {
            if (correPrimeraVez)
            {
                txtNoOrden.Text = string.Empty;
                txtClaveOficina.Text = string.Empty;
                txtOficina.Text = string.Empty;
                txtClaveProveedor.Text = string.Empty;
                txtProveedor.Text = string.Empty;
                txtClaveTipoDocto.Text = string.Empty;
                txtTipoDocto.Text = string.Empty;
                lblNoDocto.Text = "No Factura";
                txtNoDocto.Text = string.Empty;
                lblFDocto.Text = "F Factura";
                txtFDocto.Value = DateTime.Now;
                txtTipoCambio.Text = string.Empty;
                txtSubTotal.Text = string.Empty;
                txtTasaIVA.Text = string.Empty;
                txtIVA.Text = string.Empty;
                txtTotal.Text = string.Empty;
                txtTotalFactura.Text = string.Empty;
                txtObservaciones.Text = string.Empty;
                doActualizaDatosNotaRecepcion();
                correPrimeraVez = false;
            }
        }
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;
            if (validaCantidadRecibida())
            {
                BaseErrorResultado = true;
                return;
            }

            //B_Acepta = 0;

                COMPRAS.FRM_MuestraSobFaltantes frm = new COMPRAS.FRM_MuestraSobFaltantes();
                frm.K_Orden_Compra_ = Convert.ToInt32(txtNoOrden.Text);
                frm.ShowDialog();

                // K_Orden_Compra from constructor
                int K_Oficina_Recibe = Convert.ToInt32(txtClaveOficina.Text);
                int K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
                short Tipo_Documento = Convert.ToInt16(txtClaveTipoDocto.Text);
                string NoFactura = string.Empty;
                DateTime FFactura = DateTime.Now;
                string NoRemision = string.Empty;
                DateTime FRemision = DateTime.Now;
                decimal Tipo_Cambio = 0;
                short K_TipoMoneda = 1;
                decimal SubTotal = 0;
                decimal TasaIva = 0;
                decimal TotalIva = 0;
                decimal Total = 0;
                decimal TotalFactura = 0;
                // Checo si es factura o remisión
                if (Tipo_Documento == 1)
                {
                    NoFactura = txtNoDocto.Text;
                    FFactura = txtFDocto.Value;

                    Tipo_Cambio = 0;
                    K_TipoMoneda = Convert.ToInt16(cmbMoneda.SelectedValue);
                    if (K_TipoMoneda == 1) //DLLS
                        Tipo_Cambio = Convert.ToDecimal(txtTipoCambio.Text);

                    SubTotal = Convert.ToDecimal(txtSubTotal.Text);
                    TasaIva = Convert.ToDecimal(txtTasaIVA.Text);
                    TotalIva = Convert.ToDecimal(txtIVA.Text);
                    Total = Convert.ToDecimal(txtTotal.Text);
                    TotalFactura = Convert.ToDecimal(txtTotalFactura.Text);
                }
                K_Almacen = 0;
                if (cbxAlmacen.SelectedValue != null)
                {
                    if (cbxAlmacen.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        K_Almacen = Convert.ToInt32(cbxAlmacen.SelectedValue);
                    }
                }

                string Observaciones = txtObservaciones.Text;

                bool bCancelada = chkCancelada.Checked;

                res = 0;
                msg = string.Empty;
                DateTime Fecha = DateTime.Today;

                DataTable dtDatos = dtDetalle;
                if (dtDatos.Columns.Contains("D_Articulo"))
                { dtDatos.Columns.Remove("D_Articulo"); }
                if (dtDatos.Columns.Contains("D_Unidad_Medida"))
                { dtDatos.Columns.Remove("D_Unidad_Medida"); }
                if (dtDatos.Columns.Contains("D_Tipo_Articulo"))
                { dtDatos.Columns.Remove("D_Tipo_Articulo"); }
                if (dtDatos.Columns.Contains("K_Clasificacion_Articulo"))
                { dtDatos.Columns.Remove("K_Clasificacion_Articulo"); }
                if (dtDatos.Columns.Contains("D_Clasificacion_Articulo"))
                { dtDatos.Columns.Remove("D_Clasificacion_Articulo"); }
                if (dtDatos.Columns.Contains("D_Tipo_Empaque"))
                { dtDatos.Columns.Remove("D_Tipo_Empaque"); }
                if (dtDatos.Columns.Contains("Cantidad"))
                { dtDatos.Columns.Remove("Cantidad"); }
                if (dtDatos.Columns.Contains("F_Recepcion"))
                { dtDatos.Columns.Remove("F_Recepcion"); }
                if (dtDatos.Columns.Contains("SKU"))
                { dtDatos.Columns.Remove("SKU"); }
                if (dtDatos.Columns.Contains("D_Tipo_Producto"))
                { dtDatos.Columns.Remove("D_Tipo_Producto"); }
                if (dtDatos.Columns.Contains("D_Categoria_Articulo"))
                { dtDatos.Columns.Remove("D_Categoria_Articulo"); }
                // { dtDatos.Columns.Remove("B_RequiereInventario"); }
                if (dtDatos.Columns.Contains("C_Unidad_Medida"))
                { dtDatos.Columns.Remove("C_Unidad_Medida"); }
                if (dtDatos.Columns.Contains("D_Temperatura"))
                { dtDatos.Columns.Remove("D_Temperatura"); }
                if (dtDatos.Columns.Contains("Inicial"))
                { dtDatos.Columns.Remove("Inicial"); }
                if (dtDatos.Columns.Contains("Final"))
                { dtDatos.Columns.Remove("Final"); }

                DataTable tabla = sqlRecepcion.Sk_Registro_Escaneo_NRecepcion(K_Orden_Compra);
                if (BasePropiedadEsRegistroNuevo) // Nuevo
                {
                    res = sqlRecepcion.Gp_InsertaNotaRecepcion(
                        ref k_Nota_Recepcion,
                        K_Orden_Compra,
                        K_Oficina_Recibe,
                        K_Proveedor,
                        Tipo_Documento,
                        NoFactura,
                        FFactura,
                        NoRemision,
                        FRemision,
                        K_TipoMoneda,
                        Tipo_Cambio,
                        SubTotal,
                        TasaIva,
                        TotalIva,
                        Total,
                        GlobalVar.K_Usuario,
                        DateTime.Now,
                        bCancelada,
                        GlobalVar.K_Usuario,
                        DateTime.Now,
                        Observaciones,
                        K_Almacen,
                        TotalFactura,
                        false,
                        ref msg,
                        dtDatos
                        );
                    if (res == -2)
                    {
                        BaseErrorResultado = true;
                        DialogResult DialogResult = MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult == DialogResult.No)
                        {
                            //    DataColumn newCol = new DataColumn("B_RequiereInventario", typeof(bool));
                            //    newCol.AllowDBNull = true;
                            //    dtDetalle.Columns.Add(newCol);
                            //    foreach (DataRow row in dtDetalle.Rows)
                            //    {
                            //        row["B_RequiereInventario"] = B_RequiereInventario;
                            //    }
                            //    newCol.AllowDBNull = false;
                            //    return;
                        }
                        else
                        {
                            res = sqlRecepcion.Gp_InsertaNotaRecepcion(ref k_Nota_Recepcion, K_Orden_Compra, K_Oficina_Recibe, K_Proveedor, Tipo_Documento, NoFactura, FFactura, NoRemision, FRemision, K_TipoMoneda, Tipo_Cambio, SubTotal, TasaIva, TotalIva, Total, GlobalVar.K_Usuario, DateTime.Now, bCancelada, GlobalVar.K_Usuario, DateTime.Now, Observaciones, K_Almacen, TotalFactura, true, ref msg, dtDatos);
                        }
                    }
                }

                else
                { // actualizo los cambios
                    res = sqlRecepcion.Gp_ActualizaNotaRecepcion(
                        k_Nota_Recepcion,
                        K_Orden_Compra,
                        K_Oficina_Recibe,
                        K_Proveedor,
                        Tipo_Documento,
                        NoFactura,
                        FFactura,
                        NoRemision,
                        FRemision,
                        K_TipoMoneda,
                        Tipo_Cambio,
                        SubTotal,
                        TasaIva,
                        TotalIva,
                        Total,
                        GlobalVar.K_Usuario,
                        DateTime.Now,
                        bCancelada,
                        GlobalVar.K_Usuario,
                        DateTime.Now,
                        Observaciones,
                        ref msg,
                        dtDatos
                        );
                    if (string.IsNullOrWhiteSpace(msg))
                        msg = "NOTA DE RECEPCION GENERADA CORRECTAMENTE CON FOLIO...: " + k_Nota_Recepcion.ToString().Trim();
                }
            

            if (res != -1)
            {
                // TODO: Actualizar el detalle si el resultado es != -1
                //doActualizaDatosNotaRecepcion();
                //doCreaCamposDetalle();
                //doLlenaDetalle();
            }

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                BasePropiedadEsRegistroNuevo = false;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseBotonCancelarClick();
            }

            base.BaseBotonGuardarClick();
            BaseErrorResultado = true;
            // BaseBotonReporteClick();
            Close();
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
            if (txtNoDocto.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL NUMERO DE FACTURA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoDocto.Focus();
                return false;
            }
            if (cmbMoneda.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN TIPO DE MONEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMoneda.Focus();
                return false;
            }

            if (dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA REQUISICION PARA GENERAR LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveOficina.Focus();
                return false;
            }
            if (txtTotalFactura.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL TOTAL DE LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalFactura.Focus();
                return false;
            }


            BaseErrorResultado = false;
            return true;
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            BuscaOficinas frm = new BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
        }
        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaProveedores frm = new BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["Nombre"].ToString();
            }
        }
        private void btnBuscaTipoDocto_Click(object sender, EventArgs e)
        {
            DataTable dtTipoDocto = doCreaTipoDocto();
            BuscaTipoDocto frm = new BuscaTipoDocto();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtTipoDocto);
            frm.BusquedaPropiedadTablaFiltra = dtTipoDocto;
            frm.BusquedaPropiedadTitulo = "Busca Tipos de Documentos";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveTipoDocto.Text = frm.BusquedaPropiedadReglonRes["K_Tipo_Docto"].ToString();
                txtTipoDocto.Text = frm.BusquedaPropiedadReglonRes["D_Tipo_Docto"].ToString();

                int tipoDocto = Convert.ToInt32(txtClaveTipoDocto.Text);
                doChangeTipoDocto(tipoDocto);
            }
        }
        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
        }
        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);
        }
        private void txtClaveTipoDocto_Leave(object sender, EventArgs e)
        {
            DataTable dtTipoDocto = doCreaTipoDocto();
            BuscaEnTablaClaveDescripcion(dtTipoDocto, "K_Tipo_Docto", "D_Tipo_Docto", ref txtClaveTipoDocto, ref txtTipoDocto);
            try
            {
                int tipoDocto = Convert.ToInt32(txtClaveTipoDocto.Text);
                doChangeTipoDocto(tipoDocto);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        private void Frm_NotasRecepcion_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }
        private void txtSubTotal_Leave(object sender, EventArgs e)
        {

            //Double subTotal = 0;
            //Double tasaIva = 0;
            //Double iva = 0;
            //Double total = 0;
            //try { subTotal = Convert.ToDouble(txtSubTotal.Text); } catch { }
            //try { tasaIva = Convert.ToDouble(txtTasaIVA.Text); } catch { }
            //try { iva = Convert.ToDouble(txtIVA.Text); } catch { }
            //try { total = Convert.ToDouble(txtTotal.Text); } catch { }

            //iva = subTotal * tasaIva / 100;
            //total = subTotal + iva;

            //txtIVA.Text = iva.ToString("0.00");
            //txtTotal.Text = total.ToString("0.00");
            //LR: 8 / 12 / 2014
            //if (iva != 0.0)
            //{
            //    foreach (DataRow dr in dtDetalle.Rows)
            //    {
            //        dr["TasaIVA"] = tasaIva;
            //    }
            //}
        }
        private void txtNoDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bool IsDec = false;
            //int nroDec = 0;

            //for (int i = 0; i < txtNoDocto.Text.Length; i++)
            //{
            //    if (e.KeyChar == 8)
            //    {
            //        e.Handled = false;
            //        return;
                
            //    }
            //    if (IsDec && nroDec++ >= 2)
            //    {
            //        e.Handled = true;
            //        return;
            //    }
            
            //    if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //    e.Handled = false;
            //    else if (e.KeyChar == 46)
            //        e.Handled = (IsDec) ? true : false;
            //    else
            //        e.Handled = true;
            //}
        }
        private void txtTotalFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void btn_escaneo_Click(object sender, EventArgs e)
        {
            if (txtNoDocto.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL NUMERO DE FACTURA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoDocto.Focus();
                return;
            }
            DataTable dt = sqlRecepcion.Sk_Facturas_Proveedor(Convert.ToInt32(txtClaveProveedor.Text), K_Orden_Compra, txtNoDocto.Text);
            if (dt != null)
            {
                xml = Convert.ToBoolean(dt.Rows[0]["B_xml"].ToString());
                pdf = Convert.ToBoolean(dt.Rows[0]["B_pdf"].ToString());
                B_Autoriza = Convert.ToBoolean(dt.Rows[0]["B_Autoriza_SinFactura"].ToString());
                Factura = dt.Rows[0]["Factura"].ToString();
            }
            else
            {
                xml = false;
                pdf = false;
                B_Autoriza = false;
            }
            if (Factura != "")
            {
                if (Factura != txtNoDocto.Text)
                {
                    MessageBox.Show("SE ENCUENTRA REGISTRADA UNA FACTURA PARA LA ORDEN DE COMPRA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoDocto.Focus();
                    return;
                }
            }
            if ((xml) & (pdf) || B_Autoriza)
            {
                //Llamos ventana de escaneo

                Frm_Escaneo_Entrada_Almacen frm_escaneo = new Frm_Escaneo_Entrada_Almacen();
                frm_escaneo.Orden_Compra = this.txtNoOrden.Text;
                frm_escaneo.Clave_Proveedor = this.txtClaveProveedor.Text;
                frm_escaneo.Nombre_Proveedor = this.txtProveedor.Text;
                frm_escaneo.Numero_Factura = this.txtNoDocto.Text;
                frm_escaneo.dtDetalle = this.dtDetalle;

                frm_escaneo.ShowDialog();

                doLlenaDetalle();
            }
            else
            {
                MessageBox.Show("DEBE REGISTRAR LOS ARCHIVOS DE LA FACTURA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_Sube_ArchivoFactura frm = new Frm_Sube_ArchivoFactura();
                frm.Orden_Compra = Convert.ToString(K_Orden_Compra);
                frm.Factura = txtNoDocto.Text;
                frm.Proveedor = txtClaveProveedor.Text;
                frm.D_Proveedor = txtProveedor.Text;
                frm.xml = xml;
                frm.pdf = pdf;
                frm.ShowDialog();
            }

        }

        private string TxtImporteToStr(TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(txtImporte));
            if (dblImporte == 0)
            {
                return "";
            }
            else
            {
                return dblImporte.ToString("C");
            }
        }
        private string TxtImporteToDec(TextBox txtImporte)
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
    }

}
