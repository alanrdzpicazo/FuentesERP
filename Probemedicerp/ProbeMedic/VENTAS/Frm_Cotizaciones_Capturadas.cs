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
using ProbeMedic.PEDIDOS;


namespace ProbeMedic.VENTAS
{
    public partial class Frm_Cotizaciones_Capturadas : FormaBase
    {

        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();
              
        public DataTable dtCotizaciones { get; set; }
        public DataTable dtCotizacionesDetalle { get; set; }
        public Int32 K_CotizacionPasa { get; set; }
        public Int32 K_PacientePasa { get; set; }
        public string D_PacientePasa { get; set; }
        public bool B_DesdePedidos { get; set; }


        public Frm_Cotizaciones_Capturadas()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonGuardar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            grdEncabezado.AutoGenerateColumns = false;
            grdDetalle.AutoGenerateColumns = false;

            ConsultaCotizaciones();
            WindowState = FormWindowState.Maximized;

        }

        public override void BaseBotonBuscarClick()
        {
            ConsultaCotizaciones();

            base.BaseBotonBuscarClick();
        }
        public override void BaseBotonReporteClick()
        {
            if (grdEncabezado.Rows.Count != 0)
            {
                int intK_Cotizacion = 0;
                intK_Cotizacion = Convert.ToInt32(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["K_Cotizacion"].Value);
            }          
        }

        private void grdEncabezado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int intK_Cotizacion = 0;
                intK_Cotizacion = Convert.ToInt32(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["K_Cotizacion"].Value);
                TxtClave.Text = intK_Cotizacion.ToString();
                dtCotizacionesDetalle = sqlVentas.Sk_Cotizacion_Detalle(intK_Cotizacion);

                grdDetalle.DataSource = null;
                grdDetalle.DataSource = dtCotizacionesDetalle;

                if (dtCotizacionesDetalle != null)
                {
                    if (dtCotizacionesDetalle.Rows[0]["K_Articulo"] is System.DBNull)
                    {
                        grdDetalle.Columns["D_Articulo"].Visible = false;

                    }
                    else
                    {
                        grdDetalle.Columns["D_Articulo"].Visible = true;

                    }

                }
            }
            catch (Exception ex)
            {
                return;
            }

        }
        private void grdEncabezado_DataSourceChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void grdDetalle_DataSourceChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDatosExcel();
        }

        private void Reporte(int P_K_Cotizacion)
        {
            //DataTable dtReporte = sqlVentas.sps_ReporteCotizacion(P_K_Cotizacion);
            //ReportedtCorreo = dtReporte;
            //string Version = "";//dtReporte.Rows[0]["Version"].ToString();

            //ReportDocument rpt = new ReportDocument();
            //rpt = new REPORTES.RPT_COTIZACIONES();
            

            //ReporteTitulo = "COTIZACIÓN";
            //ReporteModulo = "VENTAS";

            //ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version, B_ConectaSubReporte: true);
            //ReporteRPT = rpt;

            //Frm_Reportes frmReporte = new Frm_Reportes();
            //frmReporte.P_Titulo = ReporteTitulo;
            //frmReporte.P_ReporteRPT = ReporteRPT;
            //frmReporte.P_TablaCorreo = ReportedtCorreo;
            //frmReporte.ShowDialog();
        }

        private void ConsultaCotizaciones()
        {

            dtCotizaciones = sqlVentas.Sk_Cotizacion();

            grdEncabezado.DataSource = null;
            grdEncabezado.DataSource = dtCotizaciones;

        }      
  
        private void CargaDatosExcel()
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

        private void grdEncabezado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(B_DesdePedidos)
           {
                K_CotizacionPasa = Convert.ToInt32(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["K_Cotizacion"].Value);
                K_PacientePasa = Convert.ToInt32(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["K_Paciente"].Value);
                D_PacientePasa = Convert.ToString(grdEncabezado.Rows[grdEncabezado.CurrentRow.Index].Cells["D_Paciente"].Value);
                B_DesdePedidos = false;
                this.Close();
            }
          
        }
    }
}
