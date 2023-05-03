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

namespace ProbeMedic.ADMINISTRACION.REPORTES
{
    public partial class Frm_Reportes_CXC : FormaBase
    {
        Procesos Procesos = new Procesos();
        Funciones Fx = new Funciones();

        Generales SqlGenerales = new Generales();
        SQLAdministracion SqlAdministracion = new SQLAdministracion();
        SQLAdministracion SqlAlmacen = new SQLAdministracion();

        DataTable DtFiltro = new DataTable();
        DataTable DtResultado = new DataTable();
        DataTable DtAlmacen = new DataTable();
        DataTable DtCliente = new DataTable();

        DateTime F_Inicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime F_Final = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        public List<Int32> LstAlmacenesSeleccionados = new List<Int32>();
        public List<Int32> LstClientesSeleccionados = new List<Int32>();

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

            DtpF_Inicial.Value = F_Inicial;
            DtpF_Final.Value = F_Final;

            RdbSelecionarTodos.Checked = true;
            RdbTodosClientes.Checked = true;
            RdbFacturasDepositadas.Checked = true;
            DtAlmacen = Almacenes_Type;
            DtCliente = Clientes_Type;

            Procesos.CargarTipoReporte(ref CbxTipoReporte);
            CbxTipoReporte.SelectedValue = 1;
        }

        private void GenerarReporte(Int32 K_Reporte_Seleccionado)
        {
            try
            {
                Int32 K_Factura = txt_K_Factura.Text.Trim().Length > 0 ? Convert.ToInt32(txt_K_Factura.Text.Trim()) : 0;
                DtAlmacen.Rows.Clear();
                DtCliente.Rows.Clear();
                switch (K_Reporte_Seleccionado)
                {
                    case 1: //CONCENTRADO DE NOTAS
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Reporte_Sk_Rep_Nota_Credito_Interna(K_Factura,0,0, DtpF_Inicial.Value, DtpF_Final.Value,DtCliente,DtAlmacen);
                        Cursor = Cursors.Default;
                        break;
                    case 2: //CUENTAS X COBRAR POR CLIENTE Y FACTURA
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Reporte_CxC_Cliente_Factura(GlobalVar.PC_Name, GlobalVar.K_Usuario, 0, DtAlmacen, DtCliente, 0, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value);
                        Cursor = Cursors.Default;
                        break;
                    case 3: //CUENTAS X COBRAR POR CLIENTE
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Reporte_CXC_Por_Cliente(GlobalVar.PC_Name, GlobalVar.K_Usuario, 0, DtAlmacen, DtCliente, 0, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value);
                        Cursor = Cursors.Default;
                        break;
                    case 9: //CXC por Producto, Cliente y Factura
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Reporte_CXC_ProdClieFact(K_Factura, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value, DtAlmacen, DtCliente, ucCanalDistribucionCliente1.K_Canal_Distribucion);
                        Cursor = Cursors.Default;
                        break;
                    case 11: //Dias reales de pago analítico por Cliente
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_DiasRealesPagoAnaliticoPorCliente(GlobalVar.PC_Name,GlobalVar.K_Usuario,K_Factura, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value, DtAlmacen, DtCliente, ucCanalDistribucionCliente1.K_Canal_Distribucion);
                        Cursor = Cursors.Default;
                        break;
                    case 13: //Dias reales de pago Global x Cliente
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_DiasRealesPagoAnaliticoPorCliente(GlobalVar.PC_Name, GlobalVar.K_Usuario, K_Factura, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value, DtAlmacen, DtCliente, ucCanalDistribucionCliente1.K_Canal_Distribucion);
                        Cursor = Cursors.Default;
                        break;
                    case 14: //Dias reales de pago global
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_DiasRealesPagoAnaliticoPorCliente(GlobalVar.PC_Name, GlobalVar.K_Usuario, K_Factura, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value, DtAlmacen, DtCliente, ucCanalDistribucionCliente1.K_Canal_Distribucion);
                        Cursor = Cursors.Default;
                        break;
                    
                    case 15: //Cobranza por Cliente y Folio
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_CobranzaPorClienteYFolio(GlobalVar.K_Usuario,K_Factura, GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value, DtAlmacen, DtCliente, ucCanalDistribucionCliente1.K_Canal_Distribucion,ucTipoPago1.K_Tipo_Pago);
                        Cursor = Cursors.Default;
                        break;
                    case 17: //Cobranza por Cuenta, Tipo y SubTipo
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_CobranzaPorCuentaTipoYSubTipo(GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value);
                        Cursor = Cursors.Default;
                        break;
                    case 19: //Cobranza por Mes
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_CobranzaPorMes(GlobalVar.K_Empresa,Convert.ToInt32(nuAno.Value));
                        Cursor = Cursors.Default;
                        break;
                    case 20: //Consecutivo de Facturas
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_ConsecutivoFacturasVentas(GlobalVar.K_Empresa, DtpF_Inicial.Value,DtpF_Final.Value,DtCliente,RdbFacturasDepositadas.Checked ? true : false);
                        Cursor = Cursors.Default;
                        break;
                    case 21: //Consecutivo de Facturas Desglozado
                        Almacenes();
                        Clientes();
                        Cursor = Cursors.WaitCursor;
                        Procesos.Rep_ConsecutivoFacturasDesglozado(GlobalVar.K_Empresa, DtpF_Inicial.Value, DtpF_Final.Value, DtCliente, RdbFacturasDepositadas.Checked ? true : false);
                        Cursor = Cursors.Default;
                        break;
                    default:

                        break;

                }
            }
            catch (Exception ex) { }
        }

        private void BtnPreeliminar_Click(object sender, EventArgs e)
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

        private void BtnCorreo_Click(object sender, EventArgs e)
        {
            //REPORTES.Frm_EnviaCorreo frm = new REPORTES.Frm_EnviaCorreo();
            //frm.ShowDialog();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BaseBotonExcelClick();
            Cursor = Cursors.Default;
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

        private void TxtK_Factura_KeyPress(object sender, KeyPressEventArgs e)
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
  
        private void CargarFiltros(Int32 K_Reporte)
        {
            tabControl1.TabPages.Clear();
            GbxAlmacen.Visible = false;
            PnlFechas.Visible = false;
            lbl_Tipo_Pago.Visible = false;
            ucTipoPago1.Visible = false;
            lbl_Pedido.Visible = false;
            TxtPedidoInicialRemision.Visible = false;
            lbl_al_Pedido.Visible = false;
            TxtPedidoFinalRemision.Visible = false;
            lbl_Remision.Visible = false;
            TxtRangoInicialRemision.Visible = false;
            lbl_al_remision.Visible = false;
            TxtRangoFinalRemision.Visible = false;
            lbl_Ano.Visible = false;
            nuAno.Visible = false;
            pnl_Estado_Factura.Visible = false;
            lbl_K_Factura.Visible = false;
            txt_K_Factura.Visible = false;
            lbl_Canal_Distribucion.Visible = false;
            ucCanalDistribucionCliente1.Visible = false;
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
                            case 3: //CLIENTE
                                PnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[1]);                             
                                break;
                            case 4: //FACTURA
                                PnlAbajo.Visible = true;
                                tabControl1.TabPages.Add(AllTabPages[0]);
                                break;
                            case 5: //FECHAS
                                PnlFechas.Visible = true;
                                break;
                            case 8: //TIPO DE PAGO
                                lbl_Tipo_Pago.Visible = true;
                                ucTipoPago1.Visible = true;
                                break;
                            case 9: //ANO
                                lbl_Ano.Visible = true;
                                nuAno.Visible = true;
                                break;
                            case 10: //ESTADO FACTURA
                                pnl_Estado_Factura.Visible = true;
                                break;
                            default:
                            break;
                        }
                           
                    }
                }         
            }
      
        }

        private void RdbSeleccionarClientes_Click(object sender, EventArgs e)
        {
            LblClientes.Text = string.Empty;

            Cursor = Cursors.WaitCursor;
            ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionClientes frm = new ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionClientes();
            frm.ShowDialog();
            Cursor = Cursors.Default;

            DataTable dtPaso = frm.dtSeleccionados;
            if (dtPaso != null)
            {
                if (dtPaso.Rows.Count > 0)
                {
                    int cont = 0;
                    foreach (DataRow row in dtPaso.Rows)
                    {
                        Int32 K_Cliente = Convert.ToInt32(row["K_Cliente"].ToString());
                        string D_Cliente = row["D_Cliente"].ToString();
                        LblClientes.Text = LblClientes.Text + K_Cliente + ",";
                        LstClientesSeleccionados.Add(K_Cliente);
                        cont += 1;
                    }
                    LblClientes.Text = LblClientes.Text.TrimEnd(',');

                    if (LblClientes.Text.Length <= 204)
                    {
                        LblClientes.Text = LblClientes.Text + ".";
                    }
                    else
                    {
                        LblClientes.Text = LblClientes.Text.Remove(200);
                        LblClientes.Text = LblClientes.Text + "....";
                    }

                }

            }
        }

        private void RdbTodosClientes_Click(object sender, EventArgs e)
        {
            LblClientes.Text = string.Empty;
            LstClientesSeleccionados.Clear();
        }

        private void RdbSelecionarTodos_Click(object sender, EventArgs e)
        {
            LblAlmacenesSeleccionados.Text = string.Empty;
            LstAlmacenesSeleccionados.Clear();
        }

        private void RdbSeleccionarAlmacen_Click(object sender, EventArgs e)
        {
            LblAlmacenesSeleccionados.Text = string.Empty;

            Cursor = Cursors.WaitCursor;
            ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionAlmacenes frm = new ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionAlmacenes();
            frm.ShowDialog();
            Cursor = Cursors.Default;

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

        private void Clientes()
        {
            foreach (var item in LstClientesSeleccionados)
            {
                DataRow row = DtCliente.NewRow();
                row["K_Cliente"] = item;

                DtCliente.Rows.Add(row);
                DtCliente.AcceptChanges();
            }
        }
    
    }
}
