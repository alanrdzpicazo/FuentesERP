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

namespace ProbeMedic.INVENTARIOS.REPORTES
{
    public partial class Frm_Reportes_Inventarios : FormaBase
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
        DataTable DtLaboratorio = new DataTable();
        DataTable dtAlmacen = new DataTable();

        public List<Int32> LstAlmacenesSeleccionados = new List<Int32>();
        public List<Int32> LstLaboratoriosSeleccionados = new List<Int32>();

        List<TabPage> AllTabPages;

        public Frm_Reportes_Inventarios()
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


            rdbSeleccionarTodos.Checked = true;
            rdbSeleccionarTodosLabs.Checked = true;

            DtAlmacen = Almacenes_Type;
            DtLaboratorio = Laboratorios_Type;

            Procesos.CargarTipoReporte(ref cbxTipoReporte);
            cbxTipoReporte.SelectedValue = 3;

            CargaAlmacen();

        }

        private void BtnPreeliminar_Click(object sender, EventArgs e)
        {
            if (cbxReporte.SelectedValue == null)
            {
                MessageBox.Show("FALTA SELECCIONAR UN REPORTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxReporte.Focus();
                return;
            }

            if (cbxReporte.SelectedValue != null)
            {
                if (cbxReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Int32 K_Reporte_Seleccionado = Convert.ToInt32(cbxReporte.SelectedValue.ToString());
                    Cursor = Cursors.WaitCursor;
                    GenerarReporte(K_Reporte_Seleccionado);
                    Cursor = Cursors.Default;
                }
            }
        }

        private void BtnCorreo_Click(object sender, EventArgs e)
        {
            //REPORTES.Frm_EnviaCorreo frm = new REPORTES.Frm_EnviaCorreo();
            //frm.ShowDialog();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

            if (cbxReporte.SelectedValue == null)
            {
                MessageBox.Show("FALTA SELECCIONAR UN REPORTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxReporte.Focus();
                return;
            }

            if (cbxReporte.SelectedValue != null)
            {
                if (cbxReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Int32 K_Reporte_Seleccionado = Convert.ToInt32(cbxReporte.SelectedValue.ToString());
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

        private void cbxTipoReporte_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxReporte.DataSource = null;
            cbxReporte.Items.Clear();
            cbxReporte.AutoCompleteSource = AutoCompleteSource.None;
            cbxReporte.AutoCompleteMode = AutoCompleteMode.None;

            if (cbxTipoReporte.SelectedValue != null)
            {
                if (cbxTipoReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Procesos.CargarReporte(Convert.ToInt32(cbxTipoReporte.SelectedValue.ToString()), ref cbxReporte);
                }
            }
        }

        private void cbxReporte_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxReporte.SelectedValue != null)
            {
                if (cbxReporte.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    CargarFiltros(Convert.ToInt32(cbxReporte.SelectedValue.ToString()));
                }
            }
        }

        private void rdbSeleccionarAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSeleccionarAlmacen.Checked == true)
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
            else if (rdbSeleccionarAlmacen.Checked == false)
            {
                LblAlmacenesSeleccionados.Text = string.Empty;
                LstAlmacenesSeleccionados.Clear();
            }

        }

        private void rdbSeleccionarLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSeleccionarLab.Checked == true)
            {
                LblLaboratoriosSeleccionados.Text = string.Empty;

                ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionLaboratorios Frm = new ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionLaboratorios();
                Frm.ShowDialog();

                DataTable DtPaso = Frm.DtSeleccionados;
                if (DtPaso != null)
                {
                    if (DtPaso.Rows.Count > 0)
                    {
                        int cont = 0;
                        foreach (DataRow row in DtPaso.Rows)
                        {
                            Int32 K_Laboratorio = Convert.ToInt32(row["K_Laboratorio"].ToString());
                            string D_Laboratorio = row["D_Laboratorio"].ToString();
                            LblLaboratoriosSeleccionados.Text = LblLaboratoriosSeleccionados.Text + D_Laboratorio + ",";
                            LstLaboratoriosSeleccionados.Add(K_Laboratorio);
                            cont += 1;
                        }
                        LblLaboratoriosSeleccionados.Text = LblLaboratoriosSeleccionados.Text.TrimEnd(',');

                        if (LblLaboratoriosSeleccionados.Text.Length <= 204)
                        {
                            LblLaboratoriosSeleccionados.Text = LblLaboratoriosSeleccionados.Text + ".";
                        }
                        else
                        {
                            LblLaboratoriosSeleccionados.Text = LblLaboratoriosSeleccionados.Text.Remove(200);
                            LblLaboratoriosSeleccionados.Text = LblLaboratoriosSeleccionados.Text + "....";
                        }

                    }

                }


            }
            else if (rdbSeleccionarLab.Checked == false)
            {
                LblLaboratoriosSeleccionados.Text = string.Empty;
                LstLaboratoriosSeleccionados.Clear();
            }
        }

        private void CargarFiltros(Int32 K_Reporte)
        {
            gbLaboratorios.Visible = false;
            LblLaboratoriosSeleccionados.Visible = false;
            gbAlmacen.Visible = false;
            LblAlmacenesSeleccionados.Visible = false;
            lblAlmacenTitulo.Visible = false;
            cbxAlmacen.Visible = false;
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
                                tabControl1.TabPages.Add(AllTabPages[0]);
                                break;
                            case 2: //ALMACEN
                                gbAlmacen.Visible = true;
                                LblAlmacenesSeleccionados.Visible = true;
                                break;
                            case 3: //CLIENTE
                                PnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[1]);
                                break;
                            case 4: //FACTURA
                                PnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[0]);
                                break;
                            case 5: //FECHAS
                                //PnlFechas.Visible = true;
                                break;
                            case 6: //PROVEEDOR
                                tabControl1.TabPages.Add(AllTabPages[1]);
                                break;
                            case 7: //LABORATORIO
                                gbLaboratorios.Visible = true;
                                LblLaboratoriosSeleccionados.Visible = true;
                                break;
                            case 11: //SOLO ALMACEN
                                lblAlmacenTitulo.Visible = true;
                                cbxAlmacen.Visible = true;
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
                DtAlmacen.Rows.Clear();
                DtLaboratorio.Rows.Clear();
                switch (K_Reporte_Seleccionado)
                {
                    case 5: //ARTICULOS EN TRANSITO
                        Almacenes();
                        Laboratorios();
                        Procesos.Rep_ArticulosTransito(txt_K_Articulo.Text.Trim().Length==0 ? 0 : Convert.ToInt32(txt_K_Articulo.Text.Trim()),DtAlmacen,DtLaboratorio);
                        break;
                    case 7: //STOCK DE LABORATORIOS
                        Almacenes();
                        Laboratorios();
                        Procesos.Rep_Stock(DtAlmacen,DtLaboratorio, txt_K_Articulo.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txt_K_Articulo.Text.Trim()), txtProveedor.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtProveedor.Text.Trim()),true);
                        break;
                    case 8: //STOCK DE LG
                        Almacenes();
                        Laboratorios();
                        Procesos.Rep_Stock(DtAlmacen, DtLaboratorio, txt_K_Articulo.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txt_K_Articulo.Text.Trim()), txtProveedor.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtProveedor.Text.Trim()), false);
                        break;
                    case 32: //PEDIDOS CON PARCIALIDAD
                        Procesos.Rep_PedidosParciales();
                        break;
                    case 34: //FACTURAS REALIZADAS(VENTAS PRIVADO)
                        Int32 K_Almacen = 0;
                        if (Convert.ToInt32(cbxAlmacen.SelectedValue) > 0)
                            K_Almacen = Convert.ToInt32(cbxAlmacen.SelectedValue);
                        else
                            K_Almacen = 0;
                        Procesos.Rep_FacturasVPrivada(K_Almacen);
                        break;
                    case 35: //MEDICAMENTO LENTO DESPLZAMIENTO
                        Procesos.Rep_MovimientosArticulos(false);
                        break;
                    case 36: //MEDICAMENTO SIN MOVIMIENTO
                        Procesos.Rep_MovimientosArticulos(true);
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

        private void TxtK_Articulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtK_Articulo_TextChanged(object sender, EventArgs e)
        {
            if(txt_K_Articulo.Text.Length>0)
            {
                Int32 Valor = 0;
                if(!Int32.TryParse(txt_K_Articulo.Text.Trim(),out Valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_K_Articulo.Text = string.Empty;
                    txt_K_Articulo.Focus();
                }
            }
        }

        private void Almacenes()
        {
            foreach (var item in LstAlmacenesSeleccionados)
            {
                DataRow row = DtAlmacen.NewRow();
                row["K_Almacen"] = item;

                DtAlmacen.Rows.Add(row);
                DtAlmacen.AcceptChanges();
            }
        }

        private void Laboratorios()
        {
            foreach (var item in LstLaboratoriosSeleccionados)
            {
                DataRow row = DtLaboratorio.NewRow();
                row["K_Laboratorio"] = item;

                DtLaboratorio.Rows.Add(row);
                DtLaboratorio.AcceptChanges();
            }
        }


       private void CargaAlmacen()
        {

            //dtAlmacen.Rows.Clear();
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            if (GlobalVar.K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina, GlobalVar.K_Empresa);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["D_Usuario"] = "";
                dr["K_Usuario"] = 0;
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

    }
}
