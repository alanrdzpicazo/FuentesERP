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

namespace ProbeMedic.COMPRAS
{
    public partial class Frm_ConsultaOrdenesCompra : FormaConsulta
    {
        Funciones fx = new Funciones();

        int filaSeleccionada;
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        DataTable dtRequisiciones = new DataTable();
        //        DateTime Fecha1 = new DateTime(2000, 01, 01);
//        DateTime Fecha2 = new DateTime(2050, 01, 01);
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;
        Int32 res = 0;
        string strMensaje = "";

        public Frm_ConsultaOrdenesCompra()
        {
            InitializeComponent();
            BaseBotonProceso3.Click += new EventHandler(BaseBotonProceso3_Click);
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtNoOrden; //Asignar el textbox que inicia el focus

            grdDatos.AutoGenerateColumns = false;
            grdDetalle.AutoGenerateColumns = false;

            //GlobalVar.dtEstatusCompra = sqlCatalogos.Sk_Estatus_Compra();
            //LlenaCombo(GlobalVar.dtEstatusCompra, ref cmbEstatusCompra, "K_Estatus_Compra", "D_Estatus_Compra");
            //GlobalVar.dtTipoMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            //LlenaCombo(GlobalVar.dtTipoMoneda, ref cmbTipoMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda");
            //GlobalVar.dtTipoArticulo = sqlCatalogos.Sk_Tipos_Productos();
            //LlenaCombo(GlobalVar.dtTipoArticulo, ref cmbTipoArticulo, "K_Tipo_Producto", "D_Tipo_Producto");
            //GlobalVar.dtClasificacionArticulo= sqlCatalogos.Sk_Categoria_Articulo();
            //LlenaCombo(GlobalVar.dtClasificacionArticulo, ref cmbClasificacion, "K_Categoria_Articulo", "D_Categoria_Articulo");
            //GlobalVar.dtGrupoArticulo = sqlCatalogos.Sk_Grupos_Articulos();
            //LlenaCombo(GlobalVar.dtGrupoArticulo, ref cmbGrupo, "K_Grupo_Articulo", "D_Grupo_Articulo");

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            //BaseBotonCancelar.Image = ((System.Drawing.Image)(imageList1.Images["Reload.png"]));
            BaseBotonCancelar.Text = "Limpiar";

            BaseBotonProceso3.ToolTipText = "Cancela Orden";
            BaseBotonProceso3.Text = "Cancelar";
            BaseBotonProceso3.Width = 100;
            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["cancel.png"]));
            BaseBotonProceso3.Visible = true;

            BaseBotonExcel.Visible = true;
            BaseBotonExcel.Enabled = true;
            BaseBotonExcel.ToolTipText = "Tránsito de Artículos";
            BaseBotonExcel.Text = "Tránsito [F9]";

            //llenamos combos

            this.cbx_clasificacion_articulo1.LlenaDatos();
            this.cbx_estatus_compra1.LlenaDatos();
            this.cbx_grupo_articulo1.LlenaDatos();
            this.cbx_tipo_articulo1.LlenaDatos();
            this.cbx_tipo_moneda1.LlenaDatos();

            txtNoOrden.Focus();
            base.BaseMetodoInicio();

            MtdHabilitaBotones();
        }

        public override void BaseBotonBuscarClick()
        {
            if (cbxCanceladas.Checked == false)
            {
                if (txtNoOrden.Text.Trim().Length == 0 && txtClaveOficina.Text.Trim().Length == 0 && txtClaveProveedor.Text.Trim().Length == 0 && txtClaveRequisicion.Text.Trim().Length == 0 && this.cbx_estatus_compra1.SelectedValue == null && this.cbx_clasificacion_articulo1.SelectedValue == null && this.cbx_grupo_articulo1.SelectedValue == null && this.cbx_tipo_articulo1.SelectedValue == null && this.cbx_tipo_moneda1.SelectedValue == null)
                {
                    MessageBox.Show("DEBE SELECCIONAR AL MENOS UN FILTRO PARA LA BÚSQUEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoOrden.Focus();
                    return;
                }
            }
            int K_OrdenCompra = 0;
            int K_Oficina = 0;
            int K_Proveedor = 0;
            int K_EstatusCompra = 0;
            short K_TipoMoneda = 0;
            int K_Requisicion = 0;
            int K_TipoArticulo = 0;
            int K_ClasificacionArticulo = 0;
            int K_GrupoArticulo = 0;

            Fecha1 = txtFecha1.Value;
            Fecha2 = txtFecha2.Value;

            if (txtNoOrden.Text.Trim().Length > 0)
                K_OrdenCompra = Convert.ToInt32(txtNoOrden.Text);
            if (txtClaveOficina.Text.Trim().Length > 0)
                K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            if (txtClaveProveedor.Text.Trim().Length > 0)
                K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            if (txtClaveRequisicion.Text.Trim().Length > 0)
                K_Requisicion = Convert.ToInt32(txtClaveRequisicion.Text);

            if (this.cbx_estatus_compra1.SelectedValue != null)
                K_EstatusCompra = Convert.ToInt32(cbx_estatus_compra1.SelectedValue);
            if (this.cbx_tipo_moneda1.SelectedValue != null)
                K_TipoMoneda = Convert.ToInt16(cbx_tipo_moneda1.SelectedValue);
            if (this.cbx_tipo_articulo1.SelectedValue != null)
                K_TipoArticulo = Convert.ToInt32(cbx_tipo_articulo1.SelectedValue);
            if (this.cbx_clasificacion_articulo1.SelectedValue != null)
                K_ClasificacionArticulo = Convert.ToInt32(cbx_clasificacion_articulo1.SelectedValue);
            if (this.cbx_grupo_articulo1.SelectedValue != null)
                K_GrupoArticulo = Convert.ToInt32(cbx_grupo_articulo1.SelectedValue);

            DataTable dt = sqlCompras.Sk_ConsultaOrdenesCompra(K_OrdenCompra, K_Oficina, K_Proveedor, K_EstatusCompra, K_TipoMoneda, cbxCanceladas.Checked, Fecha1, Fecha2, K_Requisicion, K_TipoArticulo, K_ClasificacionArticulo, K_GrupoArticulo,null,null);
            BaseDtDatos = dt;

            if (dt != null)
            {
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
            }

            grdDatos.DataSource = dt;

            MtdHabilitaBotones();

            tabControl1.SelectedTab = tpOrdenes;
        }

        public override void BaseBotonReporteClick()
        {
            if (grdDatos.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;
                Reporte(Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells[0].Value.ToString()));
                Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        public override void BaseMetodoLimpiaControles()
        {
            txtNoOrden.Text = string.Empty;
            txtClaveOficina.Text = string.Empty;
            txtOficina.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtClaveRequisicion.Text = string.Empty;
            txtRequisicion.Text = string.Empty;

            this.cbx_estatus_compra1.SelectedIndex = -1;
            this.cbx_tipo_moneda1.SelectedIndex = -1;
            this.cbx_tipo_articulo1.SelectedIndex = -1;
            this.cbx_clasificacion_articulo1.SelectedIndex = -1;
            this.cbx_grupo_articulo1.SelectedIndex =-1;

            txtFecha1.Value = Fecha1;
            txtFecha2.Value = Fecha2;

            cbxCanceladas.Checked = false;

            grdDatos.DataSource = null;
            tabControl1.SelectedTab = tpOrdenes;
            MtdHabilitaBotones();
            dtRequisiciones = sqlCompras.Sk_Requisicion(5, true, false); //5 = Asignada a una compra
        }

        public override void BaseMetodoMostrarReporte()
        {
            if (grdDatos.Rows.Count == 0)
                return;

            int K_OrdenCompra = 0;
            string Version = string.Empty;
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row == null)
                return;

            K_OrdenCompra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);

            DataTable dtReporte = sqlCompras.Sk_ReporteOrdenesCompra(K_OrdenCompra);
            ReportedtCorreo = dtReporte;
            Version = dtReporte.Rows[0]["DocumentoVersion"].ToString();

            ReportDocument rpt = new ReportDocument();
            // rpt = new REPORTES.RPT_OrdenCompra();

            ReporteTitulo = "Orden de Compra / Purchase Order";
            ReporteModulo = "COMPRAS";

            /*ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            ReporteRPT = rpt;*/
        }

        public override void BaseBotonExcelClick()
        {
            //if (cbxCanceladas.Checked == false)
            //{
            //    if (txtNoOrden.Text.Trim().Length == 0 && txtClaveOficina.Text.Trim().Length == 0 && txtClaveProveedor.Text.Trim().Length == 0 && txtClaveRequisicion.Text.Trim().Length == 0 && this.cbx_estatus_compra1.SelectedValue == null && this.cbx_clasificacion_articulo1.SelectedValue == null && this.cbx_grupo_articulo1.SelectedValue == null && this.cbx_tipo_articulo1.SelectedValue == null && this.cbx_tipo_moneda1.SelectedValue == null)
            //    {
            //        MessageBox.Show("DEBE SELECCIONAR AL MENOS UN FILTRO PARA LA BÚSQUEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtNoOrden.Focus();
            //        return;
            //    }
            //}
            //int K_OrdenCompra = 0;
            //int K_Oficina = 0;
            //int K_Proveedor = 0;
            //int K_EstatusCompra = 0;
            //short K_TipoMoneda = 0;
            //int K_Requisicion = 0;
            //int K_TipoArticulo = 0;
            //int K_ClasificacionArticulo = 0;
            //int K_GrupoArticulo = 0;

            //Fecha1 = txtFecha1.Value;
            //Fecha2 = txtFecha2.Value;

            //if (txtNoOrden.Text.Trim().Length > 0)
            //    K_OrdenCompra = Convert.ToInt32(txtNoOrden.Text);
            //if (txtClaveOficina.Text.Trim().Length > 0)
            //    K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            //if (txtClaveProveedor.Text.Trim().Length > 0)
            //    K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            //if (txtClaveRequisicion.Text.Trim().Length > 0)
            //    K_Requisicion = Convert.ToInt32(txtClaveRequisicion.Text);

            //if (cbx_estatus_compra1.SelectedValue != null)
            //    K_EstatusCompra = Convert.ToInt32(cbx_estatus_compra1.SelectedValue);
            //if (cbx_tipo_moneda1.SelectedValue != null)
            //    K_TipoMoneda = Convert.ToInt16(cbx_tipo_moneda1.SelectedValue);
            //if (cbx_tipo_articulo1.SelectedValue != null)
            //    K_TipoArticulo = Convert.ToInt32(cbx_tipo_articulo1.SelectedValue);
            //if (cbx_clasificacion_articulo1.SelectedValue != null)
            //    K_ClasificacionArticulo = Convert.ToInt32(cbx_clasificacion_articulo1.SelectedValue);
            //if (cbx_grupo_articulo1.SelectedValue != null)
            //    K_GrupoArticulo = Convert.ToInt32(cbx_grupo_articulo1.SelectedValue);

            Cursor = Cursors.WaitCursor;
            BaseDtDatos = sqlCompras.Sk_ConsultaOrdenesCompraDetallaado();

            Cursor = Cursors.Default;
            base.BaseBotonExcelClick();
        }

        void BaseBotonProceso3_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("SE CANCELARÁ LA ORDEN DE COMPRA NÚMERO " + grdDatos.CurrentRow.Cells["K_Orden_Compra"].Value.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                ProbeMedic.VENTAS.Frm_DatosCancelacionOC frm = new VENTAS.Frm_DatosCancelacionOC();
                frm.ShowDialog();
                if (frm.P_MotivoCancelacion != "")
                {
                    string Correos = "";
                    //res = sqlCompras.Gp_CancelaOrdenCompra(Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Orden_Compra"].Value), GlobalVar.K_Usuario, Convert.ToInt32(frm.P_ActivaRequisicion), frm.P_MotivoCancelacion, ref strMensaje);
                    res = sqlCompras.Gp_AutorizaCancelaOrdenCompra(Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Orden_Compra"].Value), false, true, GlobalVar.K_Usuario, frm.P_k_motivo_cancelacion, frm.P_MotivoCancelacion, ref Correos, ref strMensaje);
                    if (res < 0)
                    {
                        MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("SE CANCELO CORRECTAMENTE LA ORDEN DE COMPRA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BaseMetodoLimpiaControles();
                        txtNoOrden.Focus();
                    }
                }
                else
                { }
            }
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
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
        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);
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
            }
        }

        private void txtClaveRequisicion_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(dtRequisiciones, "K_Requisicion", "D_Tipo_Requisicion", ref txtClaveRequisicion, ref txtRequisicion);
        }

        private void btnBuscaRequisicion_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaRequisiciones frm = new Busquedas.BuscaRequisiciones();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtRequisiciones);
            frm.BusquedaPropiedadTablaFiltra = dtRequisiciones;
            frm.BusquedaPropiedadTitulo = "Busca Requisiciones";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveRequisicion.Text = frm.BusquedaPropiedadReglonRes["K_Requisicion"].ToString();
                txtRequisicion.Text = frm.BusquedaPropiedadReglonRes["D_Tipo_Requisicion"].ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) //DEtalle
            {
                grdDetalle.DataSource = null;
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

        private void txtNoOrden_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoOrden_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOrden.Text.Trim().Length > 0)
            {
                try
                {
                    Int32 Valor = Convert.ToInt32(txtNoOrden.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoOrden.Text = "";
                }
            }

        }

        void MtdHabilitaBotones()
        {
            BaseBotonProceso3.Enabled = (grdDatos.Rows.Count > 0);
            BaseBotonReporte.Enabled = (grdDatos.Rows.Count > 0);
            //BaseBotonExcel.Enabled = (grdDatos.Rows.Count > 0);
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        void Reporte(Int32 K_Orden_Compra)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = sqlCompras.Gp_Sk_ReporteOC(K_Orden_Compra);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportedtCorreo = sQLCatalogos.Sk_Contactos_Proveedor(Convert.ToInt32(dtResultado.Rows[0]["K_Proveedor"].ToString()));

                if(ReportedtCorreo!=null)
                {
                    if(ReportedtCorreo.Rows.Count>0)
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
    }
}
