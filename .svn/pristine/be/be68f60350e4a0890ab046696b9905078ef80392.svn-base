using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.COMPRAS.REPORTES
{
    public partial class Frm_Reportes_Compras : FormaBase
    {
        Procesos Procesos = new Procesos();
        Funciones Fx = new Funciones();

        Generales SqlGenerales = new Generales();
        SQLAdministracion SqlAdministracion = new SQLAdministracion();
        SQLAdministracion SqlAlmacen = new SQLAdministracion();
        SQLCompras SqlCompras = new SQLCompras();

        DataTable DtFiltro = new DataTable();
        DataTable DtResultado = new DataTable();
        DataTable DtAlmacen = new DataTable();
        DataTable DtCliente = new DataTable();

        DateTime F_Inicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime F_Final = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        public List<Int32> LstAlmacenesSeleccionados = new List<Int32>();

        List<TabPage> AllTabPages;

        public Frm_Reportes_Compras()
        {
            InitializeComponent();
            BaseBotonExcel.Visible = false;
            AllTabPages = new List<TabPage>();
            AllTabPages.Add(tpArticulos);
            AllTabPages.Add(tpProveedor);
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

            //DtpF_Inicial.Value = F_Inicial;
            //DtpF_Final.Value = F_Final;

            RdbSelecionarTodos.Checked = true;

            DtAlmacen = Almacenes_Type;
            DtCliente = Clientes_Type;

            Procesos.CargarTipoReporte(ref CbxTipoReporte);
            CbxTipoReporte.SelectedValue = 2;

        }

        private void BtnPreeliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCorreo_Click(object sender, EventArgs e)
        {
            //REPORTES.Frm_EnviaCorreo frm = new REPORTES.Frm_EnviaCorreo();
            //frm.ShowDialog();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
         
            if (CbxReporte.SelectedValue == null)
            {
                MessageBox.Show("FALTA SELECCIONAR UN REPORTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxReporte.Focus();
                return;
            }

            if (CbxReporte.SelectedValue != null)
            {
                if (CbxReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Int32 K_Reporte_Seleccionado = Convert.ToInt32(CbxReporte.SelectedValue.ToString());
                    Cursor = Cursors.WaitCursor;
                    GenerarReporte(K_Reporte_Seleccionado);         
                    Cursor = Cursors.Default;

                }
            }
        
          
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxTipoReporte_SelectedValueChanged(object sender, EventArgs e)
        {
            CbxReporte.DataSource = null;
            CbxReporte.Items.Clear();
            CbxReporte.AutoCompleteSource = AutoCompleteSource.None;
            CbxReporte.AutoCompleteMode = AutoCompleteMode.None;

            if (CbxTipoReporte.SelectedValue != null)
            {
                if (CbxTipoReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Procesos.CargarReporte(Convert.ToInt32(CbxTipoReporte.SelectedValue.ToString()), ref CbxReporte);
                }
            }
        }

        private void CbxReporte_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbxReporte.SelectedValue != null)
            {
                if (CbxReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    CargarFiltros(Convert.ToInt32(CbxReporte.SelectedValue.ToString()));
                }
            }
        }

        private void RdbSeleccionarAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSeleccionarAlmacen.Checked == true)
            {
                LblAlmacenesSeleccionados.Text = string.Empty;

                ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionAlmacenes frm = new ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionAlmacenes();
                frm.ShowDialog();

                DataTable dtPaso = frm.dtSeleccionados;
                if (dtPaso != null)
                {
                    if (dtPaso.Rows.Count > 0)
                    {
                        int cont = 0;
                        foreach (DataRow row in dtPaso.Rows)
                        {
                            Int32 K_Almacen = Convert.ToInt32(row["K_Almacen"].ToString());
                            string D_Almacen = row["D_Almacen"].ToString();
                            LblAlmacenesSeleccionados.Text = LblAlmacenesSeleccionados.Text + D_Almacen + ",";
                            LstAlmacenesSeleccionados.Add(K_Almacen);
                            cont += 1;
                        }
                        LblAlmacenesSeleccionados.Text = LblAlmacenesSeleccionados.Text.TrimEnd(',');

                        if (LblAlmacenesSeleccionados.Text.Length <= 204)
                        {
                            LblAlmacenesSeleccionados.Text = LblAlmacenesSeleccionados.Text + ".";
                        }
                        else
                        {
                            LblAlmacenesSeleccionados.Text = LblAlmacenesSeleccionados.Text.Remove(200);
                            LblAlmacenesSeleccionados.Text = LblAlmacenesSeleccionados.Text + "....";
                        }

                    }

                }


            }
            else if (RdbSeleccionarAlmacen.Checked == false)
            {
                LblAlmacenesSeleccionados.Text = string.Empty;
                LstAlmacenesSeleccionados.Clear();
            }

        }

        private void TxtK_Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsNumero(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void CargarFiltros(Int32 K_Reporte)
        {
            tabControl1.TabPages.Clear();
            DtFiltro = SqlGenerales.Sk_Filtros_Reporte(K_Reporte);

            if (DtFiltro != null)
            {
                if (DtFiltro.Rows.Count > 0)
                {

                    foreach (DataRow row in DtFiltro.Rows)
                    {
                        Int32 K_Filtro = Convert.ToInt32(row["K_Filtro"].ToString());


                        switch (K_Filtro)
                        {
                            case 1: //ARTICULO
                                PnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[2]);
                                break;
                            case 2: //ALMACEN
                                GbxAlmacen.Visible = true;
                                break;
                            //case 3: //CLIENTE
                            //    PnlAbajo.Visible = true;
                            //    tabControl1.TabPages.Add(AllTabPages[1]);
                            //    break;
                            //case 4: //FACTURA
                            //    PnlAbajo.Visible = true;
                            //    tabControl1.TabPages.Add(AllTabPages[0]);
                            //    break;
                            case 5: //FECHAS
                                //PnlFechas.Visible = true;
                                break;
                            case 6: //PROVEEDOR
                                tabControl1.TabPages.Add(AllTabPages[1]);
                                break;
                            default:
                                break;
                        }

                    }
                }
            }

        }

        private void GenerarReporte(Int32 K_Reporte_Seleccionado)
        {
            try
            {
                switch (K_Reporte_Seleccionado)
                {
                    case 4: //ORDENES DE COMPRA
                        if(txtClaveProveedor.Text.Trim().Length==0)
                        {
                            MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        //BaseDtDatos = SqlCompras.Gp_Ordenes_CompraProv(Convert.ToInt32(txtClaveProveedor.Text.Trim()), DtpF_Inicial.Value, DtpF_Final.Value);
                        if ((BaseDtDatos == null) || (BaseDtDatos.Rows.Count == 0))
                        {
                            MessageBox.Show("NO SE ENCONTRÓ INFORMACIÓN CON LOS PARAMETROS CAPTURADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            BaseBotonExcelClick();
                        }
                        break;
                    default:
                        break;


                }
            }
            catch (Exception) { }

       
                         
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

        private void RdbSeleccionarLaboratorio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
