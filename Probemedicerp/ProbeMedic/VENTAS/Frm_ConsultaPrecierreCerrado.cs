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

namespace ProbeMedic.VENTAS
{
    public partial class Frm_ConsultaPrecierreCerrado : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        public Frm_ConsultaPrecierreCerrado()
        {
            InitializeComponent();
        }
        public override void BaseBotonBuscarClick()
        {
            //DataTable dtPrecierres = new DataTable();
            //dtPrecierres =sqlVentas
            //Busquedas.BuscaPrecierres frm = new Busquedas.BuscaPrecierres();
            //frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtPrecierres);
            //frm.BusquedaPropiedadTablaFiltra = dtPrecierres;
            //frm.BusquedaPropiedadTitulo = "Busca Precierres";
            //frm.ShowDialog();
            //if (frm.BusquedaPropiedadReglonRes != null)
            //{
            //    txtClaveRequisicion.Text = frm.BusquedaPropiedadReglonRes["K_Requisicion"].ToString();
            //    txtRequisicion.Text = frm.BusquedaPropiedadReglonRes["D_Tipo_Requisicion"].ToString();
            //}
            //base.BaseBotonBuscarClick();
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if(txt_K_Precierre_Empleado.Text.Trim().Length==0)
            {
                MessageBox.Show("DEBE CAPTURAR UN NUMERO DE PRECIERRE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_K_Precierre_Empleado.Focus();
            }
            if(ucUsuarios1.K_Usuario==0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN USUARIO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucUsuarios1.Focus();
            }
            Cursor = Cursors.WaitCursor;
            Reporte_Gp_RepPrecierre(Convert.ToInt32(txt_K_Precierre_Empleado.Text.Trim()), ucUsuarios1.K_Usuario);
            Cursor = Cursors.Default;
        }
        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
        }
        
        void Reporte_Gp_RepPrecierre(Int32 K_Precierre_Empleado, Int32 K_Usuario)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = sqlVentas.Gp_RepPrecierre(K_Precierre_Empleado, K_Usuario);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new VENTAS.RPT_PreCierre_Empleado();
                ReporteTitulo = "REPORTE DE PRECIERRE";
                ReporteModulo = "Ventas";
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
