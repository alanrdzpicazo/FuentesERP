using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic.PEDIDOS
{
    public partial class Frm_Pedidos_Capturados : FormaBase
    {
        int res = 0;
        string msg = string.Empty;

        int intK_Cliente = 0;
        int intK_Prospecto = 0;
        int intK_Ejecutivo = 0;
        int int_K_Oficina = 0;
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();

        DataTable dtClientes = new DataTable();
        DataTable dtProspectos = new DataTable();
        DataTable dtPedidos = new DataTable();
        DataTable dtPedidosDetalle = new DataTable();

        public Frm_Pedidos_Capturados()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            grdEncabezado.AutoGenerateColumns = false;
            grdDetalle.AutoGenerateColumns = false;

            dtClientes = sqlCatalogo.Sk_Clientes();
            //dtProspectos = sqlCatalogo.sps_Prospectos();


            int var_mesActual = DateTime.Now.Month;
            int var_anio = DateTime.Now.Year;
            dtpFecInicio.Value = Convert.ToDateTime("01/" + var_mesActual + "/" + var_anio);

            DataTable dtEstatus = new DataTable();
            dtEstatus.Columns.Add(new DataColumn("K_Estatus_Pedido", typeof(Int16)));
            dtEstatus.Columns.Add(new DataColumn("D_Estatus_Pedido", typeof(string)));
            dtEstatus.Columns.Add(new DataColumn("B_AplicaPedido", typeof(bool)));
            dtEstatus.Columns.Add(new DataColumn("B_AplicaCotizacion", typeof(bool)));
            dtEstatus.Columns.Add(new DataColumn("CamposBusqueda", typeof(string)));

            DataRow drEmp;

            drEmp = dtEstatus.NewRow();

            drEmp["K_Estatus_Pedido"] = "0";
            drEmp["D_Estatus_Pedido"] = "TODAS";

            dtEstatus.Rows.Add(drEmp);


            DataTable dtMoneda = new DataTable();
            dtMoneda.Columns.Add(new DataColumn("K_Tipo_Moneda", typeof(Int16)));
            dtMoneda.Columns.Add(new DataColumn("D_Tipo_Moneda", typeof(string)));
            dtMoneda.Columns.Add(new DataColumn("CamposBusqueda", typeof(string)));

            DataRow dr;

            dr = dtMoneda.NewRow();

            dr["K_Tipo_Moneda"] = "0";
            dr["D_Tipo_moneda"] = "TODAS";

            dtMoneda.Rows.Add(dr);

            try
            {
                dtMoneda.Merge(sqlCatalogo.Sk_Tipo_Moneda());
                dtEstatus.Merge(sqlCatalogo.Sk_Estatus_Pedido());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LlenaCombo(dtMoneda, ref cbxTipoMoneda, "", "", 0);
            LlenaCombo(dtEstatus, ref cbxEstatusPedido, "", "", 0);

            //si el puesto del usuario es ejecutivo de venta, queda fijo el filtro de ejecutivo
            if (GlobalVar.K_Puesto == 17)
            {
                txtCveEjecutivo.Text = GlobalVar.K_Empleado.ToString();
                txtEjecutivo.Text = GlobalVar.D_Empleado.ToString();

                txtCveEjecutivo.Enabled = false;
                txtEjecutivo.Enabled = false;
                btnBuscaEjecutivo.Enabled = false;

                txtCveEjecutivo_Leave(null, null);
            }

            txtClaveOficina.Enabled = (GlobalVar.K_Oficina == 1);
            txtOficina.Enabled = (GlobalVar.K_Oficina == 1);
            btnBuscarOficina.Enabled = (GlobalVar.K_Oficina == 1);
            txtClaveOficina.Text = GlobalVar.K_Oficina.ToString();
            txtOficina.Text = GlobalVar.D_Oficina;
            int_K_Oficina = GlobalVar.K_Oficina;

            ConsultaPedidos();
        }

        //public override void BaseBotonReporteClick()
        //{
        //    if (grdEncabezado.Rows.Count != 0)
        //    {
        //        int intK_Pedido = 0;
        //        intK_Pedido = Convert.ToInt32(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["K_Pedido"].Value);

        //        Reporte(intK_Pedido);
        //    }
        //}
        //void Reporte(int P_K_Pedido)
        //{
        //    DataTable dtReporte = sqlVentas.sps_Reporte_Pedido(P_K_Pedido);
        //    ReportedtCorreo = dtReporte;
        //    string Version = dtReporte.Rows[0]["Version"].ToString();

        //    ReportDocument rpt = new ReportDocument();
        //    rpt = new REPORTES.RPT_Pedido();

        //    ReporteTitulo = "PEDIDO";
        //    ReporteModulo = "VENTAS";

        //    ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version, false);
        //    ReporteRPT = rpt;

        //    Frm_Reportes frmReporte = new Frm_Reportes();
        //    frmReporte.P_Titulo = ReporteTitulo;
        //    frmReporte.P_ReporteRPT = ReporteRPT;
        //    frmReporte.P_TablaCorreo = ReportedtCorreo;
        //    frmReporte.ShowDialog();
        //}

        public override void BaseBotonBuscarClick()
        {
            ConsultaPedidos();

            base.BaseBotonBuscarClick();
        }

        void ConsultaPedidos()
        {
            int intk_Pedidos = 0;
            if (TxtClave.Text != "")
            {
                intk_Pedidos = Convert.ToInt32(TxtClave.Text);
            }

            //dtPedidos = sqlVentas.sps_pedidos(intk_Pedidos, Convert.ToInt32(cbxEstatusPedido.SelectedValue), intK_Cliente, intK_Prospecto, dtpFecInicio.Value, dtpFecTermino.Value, Convert.ToInt32(cbxTipoMoneda.SelectedValue));


            // dtCotizaciones = sqlVentas.sps_Cotizacion(intk_cotizacion, intK_Cliente, intK_Prospecto, 1, dtpFecInicio.Value, dtpFecTermino.Value);
            //Int32 K_Pedido, Int32 K_Estatus_Pedido, Int32 K_Cotizacion, Int32 K_Cliente, DateTime F_Inicial, DateTime F_Final, Int32 K_Tipo_Moneda)
            //public DataTable sps_pedidos(Int32 K_Pedido, Int32 K_Cotizacion, Int32 K_Cliente, DateTime F_Inicial, DateTime F_Final, Int32 K_Tipo_Moneda, Int32 K_Estatus_Pedido, Int32 K_Ejecutivo)
            dtPedidos = sqlVentas.Sk_pedidos(intk_Pedidos, int_K_Oficina, 0, intK_Cliente, dtpFecInicio.Value, dtpFecTermino.Value, Convert.ToInt32(cbxEstatusPedido.SelectedValue), Convert.ToInt32(cbxTipoMoneda.SelectedValue), intK_Ejecutivo, false);
            grdEncabezado.DataSource = null;
            grdEncabezado.DataSource = dtPedidos;

        }
        private void rbProspecto_CheckedChanged(object sender, EventArgs e)
        {
            intK_Cliente = 0;
            intK_Prospecto = 0;
            txtClaveCliente.Text = "";
            txtCliente.Text = "";
        }

        private void txtClaveCliente_Leave(object sender, EventArgs e)
        {


            intK_Cliente = 0;
            intK_Prospecto = 0;
            BuscaEnTablaClaveDescripcion(dtClientes, "K_Cliente", "D_Cliente", ref txtClaveCliente, ref txtCliente);
            if (txtClaveCliente.Text.Trim().Length != 0)
            {
                intK_Cliente = Convert.ToInt32(txtClaveCliente.Text);
            }

        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {

            ////todo: limpiar
            //intK_Cliente = 0;
            //Busquedas.Frm_Busca_Cliente frm = new Busquedas.Frm_Busca_Cliente();
            //frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtClientes);
            //frm.BusquedaPropiedadTablaFiltra = dtClientes;
            //frm.BusquedaPropiedadTitulo = "Busca Clientes";
            //frm.ShowDialog();
            //if (frm.BusquedaPropiedadReglonRes != null)
            //{
            //    intK_Cliente = 0;
            //    intK_Cliente = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente"]);
            //    txtClaveCliente.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Cliente"]);
            //    txtCliente.Text = frm.BusquedaPropiedadReglonRes["D_Cliente"].ToString();

            //}

        }

        private void grdEncabezado_SelectionChanged(object sender, EventArgs e)
        {
            int intK_Pedido = 0;
            intK_Pedido = Convert.ToInt32(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["K_Pedido"].Value);

            dtPedidosDetalle = sqlVentas.Sk_pedidos_detalle(intK_Pedido);

            grdDetalle.DataSource = null;
            grdDetalle.DataSource = dtPedidosDetalle;

            if (dtPedidosDetalle != null)
            {
                if (dtPedidosDetalle.Rows[0]["K_Articulo"] is System.DBNull)
                {
                    grdDetalle.Columns["D_Articulo"].Visible = false;
                    grdDetalle.Columns["D_Producto"].Visible = true;
                    grdDetalle.Columns["D_Tipo_Producto"].Visible = true;
                }
                else
                {
                    grdDetalle.Columns["D_Articulo"].Visible = true;
                    grdDetalle.Columns["D_Producto"].Visible = false;
                    grdDetalle.Columns["D_Tipo_Producto"].Visible = false;
                }

            }
        }

        private void grdEncabezado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdEncabezado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CargaDatosExcel();
        }
        void CargaDatosExcel()
        {

            if (tabControl1.SelectedIndex == 0)
            {
                BaseBotonExcel.Visible = (grdEncabezado.Rows.Count != 0);
                if (grdEncabezado.Rows.Count != 0)
                {
                    BaseDtDatos = GetDataTableFromDGV(grdEncabezado);
                }
                else
                {
                    BaseDtDatos.Rows.Clear();
                }
            }
            else
            {
                BaseBotonExcel.Visible = (grdDetalle.Rows.Count != 0);
                if (grdDetalle.Rows.Count != 0)
                {
                    BaseDtDatos = GetDataTableFromDGV(grdDetalle);
                }
                else
                {
                    BaseDtDatos.Rows.Clear();
                }
            }

        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = ((DataTable)dgv.DataSource).Copy();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (!column.Visible)
                {
                    if (column.IsDataBound)
                    {
                        dt.Columns.Remove(column.DataPropertyName);
                    }
                }
            }
            return dt;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void grdDetalle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CargaDatosExcel();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void grdEncabezado_DataSourceChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void grdDetalle_DataSourceChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void btnBuscaEjecutivo_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Empleado frm = new Busquedas.Frm_Busca_Empleado();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtEmpleados);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtEmpleados;
            frm.BusquedaPropiedadTitulo = "Busca Empleados";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                intK_Ejecutivo = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Empleado"]);
                txtCveEjecutivo.Text = intK_Ejecutivo.ToString();
                txtEjecutivo.Text = frm.BusquedaPropiedadReglonRes["D_Empleado"].ToString();
            }
        }

        private void txtCveEjecutivo_Leave(object sender, EventArgs e)
        {
            intK_Ejecutivo = 0;
            txtEjecutivo.Text = "";

            if (txtCveEjecutivo.Text.Length != 0)
            {
                intK_Ejecutivo = 0;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtEmpleados, "K_Empleado", "D_Empleado", ref txtCveEjecutivo, ref txtEjecutivo);
                if (txtCveEjecutivo.Text.Trim().Length != 0)
                {
                    intK_Ejecutivo = Convert.ToInt32(txtCveEjecutivo.Text);
                }
            }
            else
            {
                intK_Ejecutivo = 0;
            }

            ConsultaPedidos();
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
                int_K_Oficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
                //MtdCargaAlmacen();

            }
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            int_K_Oficina = 0;
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
            int_K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
        }
    }
}
