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
using ProbeMedic.INVENTARIOS;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_ConsultaOCPorSurtir : FormaConsulta
    {
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        SQLRecepcion sQLRecepcion = new SQLRecepcion();
        DataTable dtRequisiciones = new DataTable();
        DataTable dt = new DataTable();
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
        DateTime Fecha2 = new DateTime(2050, 01, 01);

        public Frm_ConsultaOCPorSurtir()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            doFormatGrid();
            WindowState = FormWindowState.Maximized;
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtNoOrden; //Asignar el textbox que inicia el focus

            grdDatos.AutoGenerateColumns = false;
            grdDetalle.AutoGenerateColumns = false;

            LlenaCombo(GlobalVar.dtTipoArticulo, ref cmbTipoArticulo, "K_Tipo_Producto", "D_Tipo_Producto");
            LlenaCombo(GlobalVar.dtClasificacionArticulo, ref cmbClasificacion, "K_Categoria_Articulo", "D_Categoria_Articulo");
            cbx_estatus_compra1.LlenaDatos();
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
        
            txtNoOrden.Focus();
            base.BaseMetodoInicio();
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            txtClaveOficina.Text = GlobalVar.K_Oficina.ToString();
            txtOficina.Text = GlobalVar.D_Oficina.ToString();
        }

        public override void BaseBotonCancelarClick()
        {
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseMetodoLimpiaControles();
        }

        public override void BaseMetodoMostrarReporte()
        {
            /*
            if (grdDatos.Rows.Count == 0)
                return;

            int K_OrdenCompra = 0;
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row == null)
                return;

            K_OrdenCompra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);

            DataTable dtReporte = sqlCompras.sps_ReporteOrdenesCompra(K_OrdenCompra);

            ReportDocument rpt = new ReportDocument();
            rpt = new PARIS.REPORTES.RPT_OrdenCompra();
            ReporteTitulo = "Orden de Compra";
            ReporteModulo = "COMPRAS";
            ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo);
            ReporteRPT = rpt;
             * */
        }

        private void doFormatGrid()
        {
            BaseGrid = grdDatos;
            BaseGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            BaseGrid.RowHeadersVisible = false;
            BaseGrid.BackgroundColor = Color.White;
            BaseGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BaseGrid.AllowUserToAddRows = false;
            BaseGrid.AllowUserToDeleteRows = false;
            BaseGrid.BorderStyle = BorderStyle.None;

            BaseGrid.AllowUserToResizeColumns = true;
            //BaseGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            BaseGrid.MultiSelect = false;
            BaseGrid.ReadOnly = true;
            BaseGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            BaseGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            BaseGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//Color.FromArgb(255, 153, 51);
            BaseGrid.EnableHeadersVisualStyles = false;        
        }
     
        public override void BaseBotonBuscarClick()
        {

            int K_OrdenCompra = 0;
            int K_Oficina = 0;
            int K_Proveedor = 0;
            int K_EstatusCompra = 0;
            short K_TipoMoneda = 0;
            int K_Requisicion = 0;
            int K_TipoArticulo = 0;
            int K_ClasificacionArticulo = 0;
            int K_GrupoArticulo = 0;
            bool bPorRecibir = true;

            Fecha1 = txtFecha1.Value;
            Fecha2 = txtFecha2.Value;


            if (txtNoOrden.Text.Trim().Length > 0)
                K_OrdenCompra = Convert.ToInt32(txtNoOrden.Text);
            if (txtClaveOficina.Text.Trim().Length > 0)
                K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            if (txtClaveProveedor.Text.Trim().Length > 0)
                K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);

            if (cmbTipoArticulo.SelectedValue != null)
                K_TipoArticulo = Convert.ToInt32(cmbTipoArticulo.SelectedValue);
            if (cmbClasificacion.SelectedValue != null)
                K_ClasificacionArticulo = Convert.ToInt32(cmbClasificacion.SelectedValue);


            DataTable dt = sqlCompras.Sk_ConsultaOrdenesCompraInv(K_OrdenCompra, K_Oficina, K_Proveedor, K_EstatusCompra, K_TipoMoneda, false, Fecha1, Fecha2, K_Requisicion, K_TipoArticulo, K_ClasificacionArticulo, K_GrupoArticulo, bPorRecibir);
            BaseDtDatos = dt;
            grdDatos.AutoGenerateColumns = false;
            grdDatos.DataSource = dt;

            tabControl1.SelectedTab = tpOrdenes;

            if ((dt != null) && (dt.Rows.Count != 0))
            {
                BaseBotonCancelar.Visible = true;
                BaseBotonExcel.Visible = true;
            }
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtNoOrden.Text = string.Empty;
            txtClaveOficina.Text = string.Empty;
            txtOficina.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;

            cmbTipoArticulo.SelectedIndex = -1;
            cmbClasificacion.SelectedIndex = -1;
            cbx_estatus_compra1.SelectedIndex = -1;

            txtFecha1.Value = Fecha1;
            txtFecha2.Value = DateTime.Now;

            grdDatos.DataSource = null;
            grdDatos.AutoGenerateColumns = false;
            tabControl1.SelectedTab = tpOrdenes;

            dtRequisiciones = sqlCompras.Sk_Requisicion(5, true, false); //5 = Asignada a una compra
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

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            ProbeMedic.Busquedas.BuscaProveedores frm = new ProbeMedic.Busquedas.BuscaProveedores();
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

        private void btnBuscaRequisicion_Click(object sender, EventArgs e)
        {
            ProbeMedic.Busquedas.BuscaRequisiciones frm = new ProbeMedic.Busquedas.BuscaRequisiciones();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtRequisiciones);
            frm.BusquedaPropiedadTablaFiltra = dtRequisiciones;
            frm.BusquedaPropiedadTitulo = "Busca Requisiciones";
            frm.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            if (tabControl1.SelectedIndex == 1) //DEtalle
            {
                grdDetalle.DataSource = null;
                if (grdDetalle.Columns.Count == 0)
                {
                    this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.K_Requisicion,
                        this.TotalDetalle,
                        this.PrecioUnitario,
                        this.D_Grupo_Articulo,
                        this.D_Clasificacion_Articulo,
                        this.colK_Grupo_Articulo,
                        this.colK_Clasificacion_Articulo,
                        this.colK_Tipo_Articulo,
                        this.colK_Unidad_Medida,
                        this.colK_Detalle_Requisicion,
                        this.D_Tipo_Articulo,
                        this.D_Unidad_Medida,
                        this.D_Articulo,
                        this.K_Articulo,
                        this.Cantidad,
                        this.K_Orden_CompraDetalle
                    });
                }
                if (grdDatos.DataSource == null)
                    return;
                if (grdDatos.Rows.Count == 0)
                    return;

                int K_OrdenCompra = 0;
                DataGridViewRow row = grdDatos.CurrentRow;
                if (row != null)
                    K_OrdenCompra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);


                DataTable dtDetalle = sqlCompras.Sk_ConsultaOrdenesCompraDetalle(K_OrdenCompra);
                if (dtDetalle != null)
                {
                    if (dtDetalle.Rows.Count > 0)
                    {
                        grdDetalle.DataSource = dtDetalle;
                    }
                }
            }
        }

        private void grdDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string D_Estatus_Compra = string.Empty;
            DataGridViewRow row = grdDatos.CurrentRow;
            DataGridViewRow rows = grdDetalle.CurrentRow;

            if(row!= null)
            {
                if(e.RowIndex>-1)
                {
                    D_Estatus_Compra = row.Cells["K_Oficina"].Value.ToString();
                    //if (D_Estatus_Compra == "AUTORIZADA")
                    //{
                    //    return;
                    //}
                    DataGridView dbg = ((DataGridView)sender);
                    dbg.Cursor = Cursors.WaitCursor;
                    DataGridViewRow dr = dbg.Rows[e.RowIndex];
                    DataGridViewCell dc = dr.Cells[0];
                    int K_No_Orden = Convert.ToInt32(dc.Value);


                    Frm_NotasRecepcion frm = new Frm_NotasRecepcion(K_No_Orden);
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BaseMetodoInicio();
                    frm.Show();
                    this.Close();
                }
               
            }

          

        }

        private void txtNoOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EsNumero(e.KeyChar.ToString()) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNoOrden_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOrden.Text.Trim().Length > 0)
                if (Convert.ToDecimal(txtNoOrden.Text.Trim()) > Int32.MaxValue)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoOrden.Text = string.Empty;
                }
        }
    }
}
