using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.COMPRAS
{
    public partial class FRM_CONSULTA_FACTURAS : FormaConsulta
    {
        
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;
        Int32 res = 0;

        public FRM_CONSULTA_FACTURAS()
        {
            InitializeComponent();
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

        public override void BaseMetodoInicio()
        {
            txtFocus = txtNoOrden; //Asignar el textbox que inicia el focus

            grdDatos.AutoGenerateColumns = false;
            this.dtp_Fecha_Factura.Enabled = false;
            this.dtp_Fecha_Inicial.Enabled = false;
            this.dtp_Fecha_Final.Enabled = false;

         
            BaseBotonProceso3.Visible = false;

            DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes();
            if (dtAlmacen != null)
            {
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", 0);
            }

            //llenamos combos


            txtNoOrden.Focus();
            base.BaseMetodoInicio();

            MtdHabilitaBotones();
        }

        void MtdHabilitaBotones()
        {
            BaseBotonExcel.Enabled = (grdDatos.Rows.Count > 0);
            BaseBotonReporte.Enabled = (grdDatos.Rows.Count > 0);
        }

        public override void BaseBotonBuscarClick()
        {
            if (this.check_box_sin_factura .Checked == false && this.checkBox_habilita_fecha_factura .Checked == false && this.checkBox_rango_fechas.Checked == false)
            {
                if (! Valida_campos())
                {
                    MessageBox.Show("DEBE SELECCIONAR AL MENOS UN FILTRO PARA LA BÚSQUEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoOrden.Focus();
                    return;
                }
            }

            int K_Orden_Compra = 0;
            int K_Proveedor = 0;
            string Factura = string.Empty;
            int K_Notas_Credito_Orden_Compra = 0;
            int K_Devolucion = 0;
            DateTime F_Factura, F_Inicial, F_Final, date_los_setentas = new DateTime(1970,1,1);

            K_Orden_Compra = this.txtNoOrden.Text.Length > 0 ? Convert.ToInt32(this.txtNoOrden.Text):0;
            K_Proveedor = txtClaveProveedor.Text.Length > 0?  Convert.ToInt32(this.txtClaveProveedor.Text):0; 
            Factura =  this.txt_Factura.Text;
            K_Notas_Credito_Orden_Compra = this.txt_Nota_de_Credito.Text.Length  > 0 ? Convert.ToInt32(this.txt_Nota_de_Credito.Text):0;
            K_Devolucion = this.txt_no_devolucion.Text.Length > 0 ? Convert.ToInt32(this.txt_no_devolucion.Text):0;

            F_Factura = this.dtp_Fecha_Factura.Enabled? this.dtp_Fecha_Factura.Value: date_los_setentas;
            F_Final = this.dtp_Fecha_Final .Enabled ? this.dtp_Fecha_Final.Value : date_los_setentas;
            F_Inicial = this.dtp_Fecha_Inicial.Enabled?this.dtp_Fecha_Inicial.Value:date_los_setentas ;


            DataTable dt = sqlCompras.Gp_RepFacturas_Proveedor(K_Orden_Compra, Convert.ToInt16(cbxAlmacen.SelectedValue),K_Proveedor,Factura,K_Notas_Credito_Orden_Compra,K_Devolucion,F_Factura,F_Inicial,F_Final,this.check_box_sin_factura.Checked);
            BaseDtDatos = dt;
     
            grdDatos.DataSource = dt;

            MtdHabilitaBotones();

        }

        public override void BaseMetodoLimpiaControles()
        {
            this.txtClaveProveedor.Text = string.Empty;
            this.txtNoOrden.Text = string.Empty;
            this.txt_Factura.Text = string.Empty;
            this.txt_Nota_de_Credito.Text = string.Empty;
            this.txt_no_devolucion.Text = string.Empty;
            this.txtProveedor.Text = string.Empty;
            this.txtClaveProveedor.Text = string.Empty;

            dtp_Fecha_Inicial.Value = Fecha1;
            dtp_Fecha_Final.Value = Fecha2;
            dtp_Fecha_Factura.Value = Fecha1;

            this.checkBox_habilita_fecha_factura.Checked = false;
            this.checkBox_rango_fechas.Checked = false;

            this.dtp_Fecha_Factura.Enabled = false;
            this.dtp_Fecha_Inicial.Enabled = false;
            this.dtp_Fecha_Final.Enabled = false;

            check_box_sin_factura.Checked = false;

            grdDatos.DataSource = null;
            cbxAlmacen.SelectedIndex = -1;
            MtdHabilitaBotones();
        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);
        }

        private bool Valida_campos()
        {
            bool res = true;

            if (this.txtClaveProveedor.Text == string.Empty &&
            this.txtNoOrden.Text == string.Empty &&
            this.txt_Factura.Text == string.Empty &&
            this.txt_Nota_de_Credito.Text == string.Empty &&
            this.txt_no_devolucion.Text == string.Empty &&
            this.txtProveedor.Text == string.Empty &&
            this.txtClaveProveedor.Text == string.Empty)
                res = false;

            return res; 
        }

        public override void BaseBotonReporteClick()
        {

            Cursor = Cursors.WaitCursor;
            DataTable dtReporte = sqlCompras.Gp_RepFacturas_Proveedor(Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Orden_Compra"].Value));

            ReportedtCorreo = null; //dtReporte
            string Version = "";//dtReporte.Rows[0]["Version"].ToString();

            ReportDocument rpt = new ReportDocument();
            rpt = new ProbeMedic.INVENTARIOS.RPT_Factura_Proveedor();

            ReporteTitulo = "Reporte de Factura";
            ReporteModulo = "COMPRAS";

            ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            ReporteRPT = rpt;

            Frm_Reportes frmReporte = new Frm_Reportes();
            frmReporte.P_Titulo = ReporteTitulo;
            frmReporte.P_ReporteRPT = ReporteRPT;
            frmReporte.P_TablaCorreo = ReportedtCorreo;
            Cursor = Cursors.Default;
            frmReporte.ShowDialog();

        }

        private void checkBox_habilita_fecha_factura_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_habilita_fecha_factura.Checked)
                this.dtp_Fecha_Factura.Enabled = true;
            else
                this.dtp_Fecha_Factura.Enabled = false;
        }

        private void checkBox_rango_fechas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rango_fechas.Checked)
                this.dtp_Fecha_Final.Enabled = this.dtp_Fecha_Inicial.Enabled  = true;
            else
                this.dtp_Fecha_Inicial.Enabled = this.dtp_Fecha_Final.Enabled  = false; 
        }

        private void txtNoOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
                this.GetNextControl(ActiveControl, true).Focus();
            }
        }

        private void txt_Nota_de_Credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
               
                this.GetNextControl(ActiveControl, true).Focus();
            }
        }

        private void txt_no_devolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
                
                this.GetNextControl(ActiveControl, true).Focus();
            }
        }

        private void txtClaveProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
               
                this.GetNextControl(ActiveControl, true).Focus();
            }
        }
    }
}
