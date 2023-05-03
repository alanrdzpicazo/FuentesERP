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

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_Reportes_CXC : FormaBase
    {
        Funciones fx = new Funciones();

        Generales sqlGenerales = new Generales();
        SQLAdministracion sqlAdministracion = new SQLAdministracion();
        SQLAdministracion sqlAlmacen = new SQLAdministracion();

        DataTable dtTipoReportes = new DataTable();
        DataTable dtReportes = new DataTable();
        DataTable dtFiltros = new DataTable();

        DataTable dtResultado = new DataTable();

        DataTable dtAlmacenes = new DataTable();
        DataTable dtClientes = new DataTable();

        DateTime F_Inicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime F_Final = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        public List<Int32> lstAlmacenesSeleccionados = new List<Int32>();

        List<TabPage> AllTabPages;

    
        public Frm_Reportes_CXC()
        {
            InitializeComponent();
            BaseBotonExcel.Visible = false;       
            AllTabPages = new List<TabPage>();
            AllTabPages.Add(tpFacturas);
            AllTabPages.Add(tpClientes);
            AllTabPages.Add(tpArticulos);
   
        }

        public override void BaseMetodoInicio()
        {

            BaseBotonBuscar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;

            dtp_F_Inicial.Value = F_Inicial;
            dtp_F_Final.Value = F_Final;

            rdb_SeleccionarTodosAlmacenes.Checked = true;

            dtAlmacenes = Almacenes_Type;
            dtClientes = Clientes_Type;

            cargaTiposReportes();

        }

        private void btn_Preeliminar_Click(object sender, EventArgs e)
        {
             
            if (cmb_Reporte.SelectedValue == null)
            {
                MessageBox.Show("FALTA SELECCIONAR UN REPORTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Reporte.Focus();
                return;
            }

            if (cmb_Reporte.SelectedValue != null)
            {
                if (cmb_Reporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Int32 K_Reporte_Seleccionado = Convert.ToInt32(cmb_Reporte.SelectedValue.ToString());

                    if (K_Reporte_Seleccionado == 3) //CONCENTRADO DE NOTAS
                    {
                        //Int32 K_Factura = txt_K_Factura.Text.Trim().Length > 0 ? Convert.ToInt32(txt_K_Factura.Text.Trim()) : 0;
                        //construirTypeAlmacenes();
                        dtResultado = sqlAdministracion.Sk_Nota_Credito_Interna_Factura();
                        if (dtResultado != null)
                        {
                            if (dtResultado.Rows.Count > 0)
                            {
                                Cursor = Cursors.WaitCursor;
                                reporte(3, dtResultado, "CUENTAS POR COBRAR", "CONCENTRADO DE NOTAS");
                                Cursor = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("NO SE ENCONTRÓ INFORMACIÓN CON LOS PARAMETROS CAPTURADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO SE ENCONTRÓ INFORMACIÓN CON LOS PARAMETROS CAPTURADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }

        }

        private void btn_Correo_Click(object sender, EventArgs e)
        {
            REPORTES.Frm_EnviaCorreo frm = new REPORTES.Frm_EnviaCorreo();
            frm.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BaseBotonExcelClick();
            Cursor = Cursors.Default;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_TipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {     
            if (dtTipoReportes != null)
            {
                if(dtTipoReportes.Rows.Count>0)
                {
                    if(cmb_TipoReporte.SelectedValue!=null)
                    {
                        if (cmb_TipoReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                        {
                            cargaReportes(Convert.ToInt32(cmb_TipoReporte.SelectedValue.ToString()));
                        }
                    }
                }
            }

        }

        private void cmb_Reporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtReportes != null)
            {
                if (dtReportes.Rows.Count > 0)
                {
                    if (cmb_Reporte.SelectedValue != null)
                    {
                        if (cmb_Reporte.SelectedValue.ToString() != "System.Data.DataRowView")
                        {
                            cargarFiltros(Convert.ToInt32(cmb_Reporte.SelectedValue.ToString()));
                        }
                    }
                }
            }
        }
        private void rdb_SeleccionarAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_SeleccionarAlmacen.Checked == true)
            {
                lblAlmacenesSeleccionados.Text = string.Empty;
                REPORTES.ASIGNACIONES.Frm_AsignacionAlmacenes frm = new REPORTES.ASIGNACIONES.Frm_AsignacionAlmacenes();
                frm.ShowDialog();

                DataTable dtPaso = frm.dtSeleccionados;
                if(dtPaso!=null)
                {
                    if(dtPaso.Rows.Count>0)
                    {
                        int cont = 0;
                        foreach (DataRow row in dtPaso.Rows)
                        {
                            Int32 K_Almacen =Convert.ToInt32(row["K_Almacen"].ToString());
                            string D_Almacen = row["D_Almacen"].ToString();
                            lblAlmacenesSeleccionados.Text = lblAlmacenesSeleccionados.Text + D_Almacen + ",";
                            lstAlmacenesSeleccionados.Add(K_Almacen);
                            cont += 1;
                        }
                        lblAlmacenesSeleccionados.Text = lblAlmacenesSeleccionados.Text.TrimEnd(',');

                        if(lblAlmacenesSeleccionados.Text.Length <= 204)
                        {
                            lblAlmacenesSeleccionados.Text = lblAlmacenesSeleccionados.Text + ".";
                        }
                        else
                        {
                            lblAlmacenesSeleccionados.Text = lblAlmacenesSeleccionados.Text.Remove(200);
                            lblAlmacenesSeleccionados.Text = lblAlmacenesSeleccionados.Text + "....";
                        }
                      
                    }
                    
                }
               
                
            }
            else if(rdb_SeleccionarAlmacen.Checked == false)
            {
                lblAlmacenesSeleccionados.Text = string.Empty;
                lstAlmacenesSeleccionados.Clear();
            }

        }

        private void txt_K_Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsNumero(e.KeyChar))
            {
                e.Handled = true;
            } 
            if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }


        #region METODOS

        private void cargaTiposReportes()
        {
            dtTipoReportes = sqlGenerales.Sk_Tipo_Reporte();

            if (dtTipoReportes != null)
            {
                if (dtTipoReportes.Rows.Count > 0)
                {
                    int indice = -1;
                    indice = 0;
                    LlenaCombo(dtTipoReportes, ref cmb_TipoReporte, "K_Tipo_Reporte", "D_Tipo_Reporte", indice);
                    cmb_TipoReporte.SelectedValue = 2;   
                      
                }

            }
        }

        private void cargaReportes(Int32 K_Tipo_Reporte)
        {

            pnl_Fechas.Visible = false;
            gbAlmacen.Visible = false;
            tabControl1.TabPages.Remove(AllTabPages[0]);
            tabControl1.TabPages.Remove(AllTabPages[1]);
            tabControl1.TabPages.Remove(AllTabPages[2]);
 
            dtReportes = sqlGenerales.Sk_Reportes(K_Tipo_Reporte);

            if (dtReportes != null)
            {
                if (dtReportes.Rows.Count > 0)
                {
                    int indice = -1;
                    indice = 0;
                    LlenaCombo(dtReportes, ref cmb_Reporte, "K_Reporte", "D_Reporte", indice);
                }

            }
        }
       
        private void cargarFiltros(Int32 K_Reporte)
        {
            dtFiltros = sqlGenerales.Sk_Filtros_Reporte(K_Reporte);

            if (dtFiltros != null)
            {
                pnl_Fechas.Visible = false;
                gbAlmacen.Visible = false;
                pnlAbajo.Visible = false;
                if (dtFiltros.Rows.Count > 0)
                {
                    pnl_Fechas.Visible = false;
                    gbAlmacen.Visible = false;
                    pnlAbajo.Visible = false;
                    foreach (DataRow row in dtFiltros.Rows)
                    {
                        Int32 K_Filtro = Convert.ToInt32(row["K_Filtro"].ToString());

                        switch (K_Filtro)
                        {
                            case 1: //ARTICULO
                                pnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[2]);
                                break;
                            case 2: //ALMACEN
                                gbAlmacen.Visible = true;
                                break;
                            case 1002: //CLIENTE
                                pnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[1]);
                                break;
                            case 1003: //FACTURA
                                pnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[0]);
                                break;
                            case 1004: //FECHAS
                                pnl_Fechas.Visible = true;
                                break;                        
                            default:
                            break;
                        }
                           
                    }
                }
                else
                {
                    //MessageBox.Show("EL REPORTE: " + cmb_Reporte.SelectedText.ToString() + "\r\n NO TIENE FILTROS ASIGNADOS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnl_Fechas.Visible = false;
                    gbAlmacen.Visible = false;
                    pnlAbajo.Visible = false;
                
                }
            }
            else
            {
                pnl_Fechas.Visible = false;
                gbAlmacen.Visible = false;
                pnlAbajo.Visible = false;
                //MessageBox.Show("EL REPORTE: " + cmb_Reporte.SelectedValue.ToString() + "\r\n NO TIENE FILTROS ASIGNADOS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reporte(Int32 K_ReporteInt, DataTable dtResultado, string Titulo, string Modulo)
        {
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new REPORTES.RPT_Concentrado_Notas();
                ReporteTitulo = Titulo;
                ReporteModulo = Modulo;
                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                ProbeMedic.Frm_Reportes frmReporte = new ProbeMedic.Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private ReportDocument obtenerDocumentoReporte(Int32 K_ReporteInt)
        {      
            if (K_ReporteInt == 3) //CONCENTRADO DE NOTAS
            {
                ReportDocument rpt = new REPORTES.RPT_Concentrado_Notas();
                return rpt;
            }
            else
            {
                return null;
            }

        }

        private void construirTypeAlmacenes()
        {
            foreach(var item in lstAlmacenesSeleccionados)
            {
                DataRow row = dtAlmacenes.NewRow();
                row["K_Almacen"] = item;
         
                dtAlmacenes.Rows.Add(row);
                dtAlmacenes.AcceptChanges();
            }
        }

    

        #endregion

    }
}
