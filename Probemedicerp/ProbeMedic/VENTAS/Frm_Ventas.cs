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
using ProbeMedic.VENTAS;
using ProbeMedic.AppCode.DCC;
using System.IO;
using System.Threading;
using System.Globalization;
using Microsoft.Win32;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Ventas : FormaBase, IVentasFarmacia
    {
        string PrinterTickets = string.Empty;
        RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic");
        bool B_Error_Entrar = false;
        SQLVentas sql_Ventas = new SQLVentas();
        SQLCatalogos sql_Catalogo = new SQLCatalogos();
        SQLPrecios sql_precios = new SQLPrecios();

        DataTable dtDatos = new DataTable();
        DataTable dtAlmacenes = new DataTable();

        DataTable dtArticulos;
        DataTable dtPD;

        DataTable datos = new DataTable();
        DataTable dtLotes = new DataTable();

        int res = 0;
        string msg = string.Empty;

        int K_AlmacenEnt;
        int KArticulo = 0;
        decimal PSubtotal = 0;
        decimal PIva, Precio_Unitario = 0,PPorcentaje =0;
        decimal PrecioAct, PrecioMaximo = 0;
        decimal Descuento = 0;
        Int32 _K_Medico = 0;
        string cadena = "";
        decimal Descuento_Empleado = 0;
        bool B_Credito = false;
        string No_Tarjeta_Capturado = "";
        string Monto_Disponible = "";
        Int32 K_Cliente_Capturado = 0;
        string D_Cliente_Capturado = "";
        string RFC = "";
        string F_UltimoCanje = "";
        string F_UltimoConsumo = "";
        string Correo_Capturado = "";

        public Frm_Ventas()
        {
            InitializeComponent();
            BaseBarraHerramientas.Visible = false;
            BaseEtiquetaEstatus.Visible = false;
            base.BarraEstatus.Visible = false;
            WindowState = FormWindowState.Maximized;
            grdArticulos.AutoGenerateColumns = false;
            PrinterTickets = Registro.GetValue("ProbeMedic_Printer_Tickets").ToString();

            if (PrinterTickets.Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR LAS IMPRESORA DE TICKETS DE VENTA", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Obtengo_Impresoras();
            }

        }

        private void Obtengo_Impresoras()
        {
            Frm_Impresoras frm = new Frm_Impresoras();
            frm.ShowDialog();
            PrinterTickets = frm.PrinterTicket;

            if (PrinterTickets.Length == 0)
            {
                if (frm.error == true)
                {
                    Obtengo_Impresoras();
                }
            }
        }
        public void Imprimir_Ticket(Int32 K_Transaccion)
        {
            string msg = string.Empty;
            string PrinterTicket = string.Empty;
            DataTable dt = sql_Ventas.Gp_Datos_Ticket(K_Transaccion,K_AlmacenEnt, ref msg);
            if(msg.Length>0)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ReportDocument rpt = null;
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in dt.Rows)
                {
                    rpt = new VENTAS.TicketVenta();

                    Forma forma = new Forma();
                    forma.ConectaReporte(ref rpt, dt, "", "", "", false, false);

                    RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic");
                    PrinterTickets = Registro.GetValue("ProbeMedic_Printer_Tickets").ToString();

                    rpt.PrintOptions.PrinterName = PrinterTickets;
                    try { rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto; }
                    catch { }
                    rpt.PrintToPrinter(1, false, 0, 0);//Imprime directamente
                    rpt.Close(); rpt.Dispose();
                    break;

                }
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dt = null;
        }
        private void Frm_Ventas_Shown(object sender, EventArgs e)
        {
            if (!B_Error_Entrar)
            {
                txtSKU.Focus();
                int res = 0;
                string Mensaje = "";
                res = sql_Ventas.Gp_Valida_EntradaVenta(K_AlmacenEnt, ref Mensaje);
                if (res == -1)
                {
                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (res == -2)
                {
                    if (txtD_Medico.Text != null)
                        ValidaCajaChica();
                }
            }
            else
            {
                Close();
            }

        }
        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            dtAlmacenes = sql_Catalogo.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina, GlobalVar.K_Empresa);

            if (dtAlmacenes == null)
            {
                MessageBox.Show("EL USUARIO NO CUENTA CON ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }

            if (dtAlmacenes != null)
            {
                if (dtAlmacenes.Rows.Count > 1)
                {
                    MessageBox.Show("EL USUARIO CUENTA CON MAS DE UN ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    B_Error_Entrar = true;
                }
                if (dtAlmacenes.Rows.Count == 1)
                {
                    WindowState = FormWindowState.Maximized;
                    B_Error_Entrar = false;
                    LblContador.Text = "0";
                    datos = sqlCatalogos.Sk_Imagenes_Venta();
                    timer1.Start();
                    dtDatos = Detalle_Venta_Table;
                    Descuento_Empleado = 0;

                    //Datos Iniciales 
                    DataRow row = dtAlmacenes.Rows[0];
                    LblHora.Text = DateTime.Now.ToLongTimeString();
                    LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    LblSucusal.Text = Convert.ToString(row["D_Oficina"]);
                    LblEmpleado.Text = Convert.ToString(row["D_Usuario"]);
                    LblAlmacen.Text = Convert.ToString(row["D_Almacen"]);
                    K_AlmacenEnt = Convert.ToInt32(row["K_Almacen"]);
                }

            }

        }
        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();

            decimal a = Convert.ToDecimal(grdArticulos.Width -20) / Convert.ToDecimal(10);
            int b = Convert.ToInt32(a);

            grdArticulos.Columns["Menos"].Width = 20;
            grdArticulos.Columns["K_Articulo"].Width = b;
            grdArticulos.Columns["D_Articulo"].Width = b;
            grdArticulos.Columns["SKU"].Width = b;
            grdArticulos.Columns["Cantidad"].Width = b;
            grdArticulos.Columns["F_Caducidad"].Width = b;
            grdArticulos.Columns["Lote"].Width = b;
            grdArticulos.Columns["Sel_Lote"].Width = b;
            grdArticulos.Columns["Precio_Maximo_Publico"].Width = b;
            grdArticulos.Columns["Requiere_Receta"].Width = b;
            grdArticulos.Columns["D_Medico"].Width = b;
        }

        private void grdArticulos_Resize(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(grdArticulos.Width -20) / Convert.ToDecimal(10);
            int b = Convert.ToInt32(a);

            grdArticulos.Columns["Menos"].Width = 20;
            grdArticulos.Columns["K_Articulo"].Width = b;
            grdArticulos.Columns["D_Articulo"].Width = b;
            grdArticulos.Columns["SKU"].Width = b;
            grdArticulos.Columns["Cantidad"].Width = b;
            grdArticulos.Columns["F_Caducidad"].Width = b;
            grdArticulos.Columns["Lote"].Width = b;
            grdArticulos.Columns["Sel_Lote"].Width = b;
            grdArticulos.Columns["Precio_Maximo_Publico"].Width = b;
            grdArticulos.Columns["Requiere_Receta"].Width = b;
            grdArticulos.Columns["D_Medico"].Width = b;
        }
        private void Frm_Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnBuscar.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                BtnLimpiar.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                BtnCalculadora.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                BtnCancelar.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                Btn_Reimpresion.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                BtnPagar.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                BtnNotas.PerformClick();
            }
            if (e.KeyCode == Keys.F9)
            {
                BtnConsulta.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                Btn_Salir.PerformClick();
            }
            if (e.KeyCode == Keys.F11)
            {
                BtnCierre.PerformClick();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Alt) + Convert.ToInt32(Keys.I))
            {
                Frm_Impresoras frm = new Frm_Impresoras();
                frm.ShowDialog();
            }
        }

        #region IVentasFarmacia Members
        public void AddDetalleLotes(DataGridViewRow row)
        {
            this.grdDetalleLotes.Rows.Add(new[] {
                 row.Cells["K_Articulo"].Value.ToString(),
                 row.Cells["K_Movimiento_Inventario"].Value.ToString(),
                 row.Cells["No_Lote"].Value.ToString(),
                 row.Cells["Cantidad_Asignada"].Value.ToString(),
                 row.Cells["F_Caducidad"].Value.ToString(),
            });

        }
        #endregion


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int res = 0;
            string Mensaje = "";
            string Mensaje2 = "";
            res = sql_Ventas.Gp_Valida_EntradaVenta(K_AlmacenEnt, ref Mensaje);
            if (res == -1)
            {
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //BUSCAR ARTICULOS  ASIGNE SKU A PANTALLA PRINCIPAL 
            txtSKU.Text = "";
            if (txtK_Cliente.Text.Trim().Length == 0)
                txtK_Cliente.Text = "0";

            Frm_Busca_Articulo_Venta frm = new Frm_Busca_Articulo_Venta();
            Cursor = Cursors.WaitCursor;
            frm.ShowDialog();
            Cursor = Cursors.Default;
            //txtSKU.Focus();
            txtSKU.Text = frm.SKU_Salida;
            if (txtSKU.Text.Trim().Length > 0)
            {
                //Busca Articulos Exitencia, Precio Desc
                DataTable datos = new DataTable();

                datos = sql_Ventas.Gp_Inventario_Farmacia(GlobalVar.K_Oficina, K_AlmacenEnt, 0, false, true, txtSKU.Text, 0, 0, Convert.ToInt32(txtK_Cliente.Text),ref Mensaje2);

                if(Mensaje2.Length>0)
                {
                    MessageBox.Show(Mensaje2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (datos == null)
                {
                    MessageBox.Show("NO SE ENCONTRO ARTICULO DISPONIBLE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if(datos.Rows.Count>0)
                    {
                        LblK_Articulo.Text = datos.Rows[0]["K_Articulo"].ToString();
                        lblD_Articulo.Text = datos.Rows[0]["D_Articulo"].ToString();
                        LblLoteS.Text = datos.Rows[0]["No_Lote"].ToString();
                        LblF_Caducidad.Text = datos.Rows[0]["F_Caducidad"].ToString();
                        PSubtotal = Convert.ToDecimal(datos.Rows[0]["SubTotal"].ToString());
                        PIva = Convert.ToDecimal(datos.Rows[0]["Iva"].ToString());
                        CbxRequiereReceta.Checked = Convert.ToBoolean(datos.Rows[0]["B_Requiere_Receta"].ToString());
                        Descuento = Convert.ToDecimal(datos.Rows[0]["Descuento"].ToString());
                        Precio_Unitario = Convert.ToDecimal(datos.Rows[0]["Precio_Unitario"].ToString());
                        PrecioAct = Convert.ToDecimal(datos.Rows[0]["Precio"].ToString());
                        PrecioMaximo = Convert.ToDecimal(datos.Rows[0]["Precio_Maximo_Publico"].ToString());
                        PPorcentaje = Convert.ToDecimal(datos.Rows[0]["Porcentaje"].ToString());
                        txtCantidad.Focus();
                    }
               
                }
            }


        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //LIMPIAR DATOS  *
            Cursor = Cursors.WaitCursor;
            txtSKU.Text = "";
            txtCantidad.Text = "";
            LblK_Articulo.Text = "";
            lblD_Articulo.Text = "";
            LblLoteS.Text = "";
            lblSubtotal.Text = "0.00";
            LblIva.Text = "0.00";
            lblPrecio.Text = "0.00";
            txtK_Cliente.Text = "";
            txtD_Cliente.Text = "";
            CbxRequiereReceta.Checked = false;
            txtObservaciones1.Text = "";
            txtObservaciones2.Text = "";
            txtObservaciones3.Text = "";
            txtObservaciones4.Text = "";
            txtObservaciones5.Text = "";
            txtK_Medico.Text = "";
            txtD_Medico.Text = "";
            LblDesc.Text = "0.00";
            cbxDescEmpleado.Checked = false;
            cbxEntregaDomicilio.Checked = false;
            B_Credito = false;
            dtDatos.Clear();
            dtDatos = Detalle_Venta_Table;
            grdArticulos.DataSource = dtDatos;
            LblCantidad.Text = "0";
            LblCantidadDesc.Visible = false;
            LblSigno.Visible = false;
            cbxDescEmpleado.Checked = false;
            Descuento_Empleado = 0;
            grdDetalleLotes.Rows.Clear();
            txtNo_Tarjeta.Text = "";
            Cursor = Cursors.Default;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            int res = 0;
            string Mensaje = "";
            res = sql_Ventas.Gp_Valida_EntradaVenta(K_AlmacenEnt, ref Mensaje);
            if (res == -1)
            {
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //CANCELAR VENTA NUEVA PANTALLA  
            Frm_Cancelacion_Venta frm = new Frm_Cancelacion_Venta();
            Cursor = Cursors.WaitCursor;
            frm.ShowDialog();
            Cursor = Cursors.Default;

        }
        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora frm = new Calculadora();
            Cursor = Cursors.WaitCursor;
            frm.ShowDialog();
            Cursor = Cursors.Default;
        }
        private void BtnNotas_Click(object sender, EventArgs e)
        {
            //Notas
            if (lblPrecio.Text == "0.00")
            {
                MessageBox.Show("NO EXISTEN ARTICULOS AGREGADOS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return;
            }
            Frm_Notas frm = new Frm_Notas();
            Cursor = Cursors.WaitCursor;
            if (txtObservaciones1.Text.Trim().Length > 0)
            {
                frm.txtObservaciones1.Text = txtObservaciones1.Text;
            }
            if (txtObservaciones2.Text.Trim().Length > 0)
            {
                frm.txtObservaciones2.Text = txtObservaciones2.Text;
            }
            if (txtObservaciones3.Text.Trim().Length > 0)
            {
                frm.txtObservaciones3.Text = txtObservaciones3.Text;
            }
            if (txtObservaciones4.Text.Trim().Length > 0)
            {
                frm.txtObservaciones4.Text = txtObservaciones4.Text;
            }
            if (txtObservaciones5.Text.Trim().Length > 0)
            {
                frm.txtObservaciones5.Text = txtObservaciones5.Text;
            }
            frm.ShowDialog();
            Cursor = Cursors.Default;
            txtObservaciones1.Text = frm.Observaciones_1;
            txtObservaciones2.Text = frm.Observaciones_2;
            txtObservaciones3.Text = frm.Observaciones_3;
            txtObservaciones4.Text = frm.Observaciones_4;
            txtObservaciones5.Text = frm.Observaciones_5;
        }
        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            Frm_Inventario_Venta frm = new Frm_Inventario_Venta();
            Cursor = Cursors.WaitCursor;
            frm.ShowDialog();
            Cursor = Cursors.Default;

        }
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (lblPrecio.Text == "0.00")
            {
                MessageBox.Show("NO EXISTEN ARTICULOS AGREGADOS!...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSKU.Focus();
                return;
            }
            //Vuelvo a validar tarjeta y la muestro si no se muestra y no tiene saldo no puedo pagar con ella 
            //Validaciones de Tarjeta
            int K_Cliente_Tarjeta;
            if (txtNo_Tarjeta.Text.Trim().Length > 0)
            {
                DataTable datos = new DataTable();

                datos = sql_Ventas.Sk_ClienteDatosTarjeta(Convert.ToDecimal(txtNo_Tarjeta.Text));

                if (datos == null)
                {
                    MessageBox.Show("LA TARJETA NO SE ENCUENTRA EN EL INVENTARIO ,NO ES VALIDA ...!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNo_Tarjeta.Focus();
                    txtNo_Tarjeta.Text = "";
                    return;
                }
                else
                {
                    K_Cliente_Tarjeta = Convert.ToInt32(datos.Rows[0]["K_Cliente"].ToString());
                    Monto_Disponible = datos.Rows[0]["Monto_Disponible"].ToString();
                }

                if (txtK_Cliente.Text.Trim().Length != 0)
                {
                    if (txtK_Cliente.Text != "0")
                    {
                        if (K_Cliente_Tarjeta != Convert.ToInt32(txtK_Cliente.Text))
                        {
                            MessageBox.Show("EL CLIENTE CAPTURADO ES DIFERENTE AL CLIENTE ASIGNADO A LA TARJETA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNo_Tarjeta.Focus();
                            txtNo_Tarjeta.Text = "";
                            return;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("LA TARJETA NO TIENE CLIENTE ASIGNADO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNo_Tarjeta.Focus();
                    txtNo_Tarjeta.Text = "";
                    return;

                }
            }
            //PAGAR MOSTRAR PANTALLA TIPOS DE PAGO Y GUARDAR VENTA -- paso datos de tarjeta con num tarjeta y puntos 
            Frm_Pagos_Venta frm = new Frm_Pagos_Venta();
            Cursor = Cursors.WaitCursor;
            frm._Monto = Convert.ToDecimal(lblPrecio.Text);
            frm.Credito = B_Credito;
            frm.txtNo_Tarjeta.Text = txtNo_Tarjeta.Text;
            frm.txtxSaldoActual.Text = Convert.ToString(Monto_Disponible);
            frm.ShowDialog();
            Cursor = Cursors.Default;
            this.dbgPagosVentas.DataSource = frm.dtPagos_Completos;

            if (dbgPagosVentas.RowCount > 0)
            {
                // Guarda Venta 
                dtPD = DetallePagoType;
                foreach (DataGridViewRow rowGrid in dbgPagosVentas.Rows)
                {
                    DataRow dr = dtPD.NewRow();

                    dr["K_Tipo_Pago"] = Convert.ToInt32(rowGrid.Cells["K_Tipo_Pago"].Value);
                    dr["D_Tipo_Pago"] = rowGrid.Cells["D_Tipo_Pago"].Value;
                    dr["Monto_Pago"] = Convert.ToDecimal(rowGrid.Cells["Monto_Pago"].Value);
                    dr["K_Banco_Tarjeta"] = rowGrid.Cells["K_Banco_Tarjeta"].Value;
                    dr["No_Tarjeta_Credito"] = rowGrid.Cells["No_Tarjeta_Credito"].Value;
                    dr["No_Tarjeta_Debito"] = rowGrid.Cells["No_Tarjeta_Debito"].Value;
                    dr["Aprobacion"] = rowGrid.Cells["Aprobacion"].Value;
                    dr["No_Operacion"] = rowGrid.Cells["No_Operacion"].Value;
                    dr["No_Cheque"] = rowGrid.Cells["No_Cheque"].Value;
                    dr["K_Banco_Cheque"] = rowGrid.Cells["K_Banco_Cheque"].Value;
                    dr["Cuenta_Cheque"] = rowGrid.Cells["Cuenta_Cheque"].Value;
                    dr["No_Transferencia"] = rowGrid.Cells["No_Transferencia"].Value;
                    dr["Cuenta_Transferencia"] = rowGrid.Cells["Cuenta_Transferencia"].Value;
                    dr["K_Banco_Transferencia"] = rowGrid.Cells["K_Banco_Transferencia"].Value;
                    dr["Referencia_Transferencia"] = rowGrid.Cells["Referencia_Transferencia"].Value;

                    dtPD.Rows.Add(dr);
                }
            }
            else
            {
                decimal suma = 0;
                foreach (DataGridViewRow row in dbgPagosVentas.Rows)
                {
                    suma += (int)row.Cells["Monto_Pago"].Value;
                }
                if (suma > Convert.ToDecimal(lblPrecio.Text) || suma < Convert.ToDecimal(lblPrecio.Text))
                {
                    MessageBox.Show("EL MONTO DE PAGO ES DIFERENTE AL MONTO TOTAL DE LA COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("NO SE ENCONTRARON PAGOS REGISTRADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (grdArticulos.RowCount > 0)
            {// Guarda Articulos  

                bool B_Error = false;

                dtArticulos = DetalleVentaType;

                dtArticulos = Mtd_Construir_Detalle_Venta(ref B_Error);

                if (B_Error)
                    return;

                int ires = 0;
                int int_Consecutivo = 0;
                string strMensaje = "";
                string Folios_Receta = "";
                decimal K_Tarjeta_Venta;

                if (txtNo_Tarjeta.Text.Trim().Length > 0)
                {
                    K_Tarjeta_Venta = Convert.ToDecimal(txtNo_Tarjeta.Text);
                }
                else
                {
                    K_Tarjeta_Venta = Convert.ToDecimal(0);
                }

                if (txtK_Medico.Text.Trim().Length == 0)
                {
                    txtK_Medico.Text = "0";
                }

                ires = sql_Ventas.In_Venta_Articulos(ref int_Consecutivo, K_AlmacenEnt, GlobalVar.K_Usuario, Convert.ToDecimal(lblPrecio.Text), Convert.ToInt32(LblCantidad.Text), Convert.ToInt32(txtK_Medico.Text),
                Convert.ToInt32(txtK_Cliente.Text), CbxRequiereReceta.Checked, txtObservaciones1.Text, txtObservaciones2.Text, txtObservaciones3.Text, txtObservaciones4.Text, txtObservaciones5.Text, cbxEntregaDomicilio.Checked,
                 dtArticulos, dtPD, K_Tarjeta_Venta, ref Folios_Receta, ref strMensaje);

                if (ires == -1)
                {
                    MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("LA VENTA FUE REGISTRADA:   " + int_Consecutivo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Imprimir_Ticket(int_Consecutivo);
                    Cursor = Cursors.Default;
                    if (Folios_Receta != "")
                    {
                        MessageBox.Show("FOLIOS DE RECETAS:   " + Folios_Receta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dtDatos.Rows.Clear();
                    dtArticulos.Rows.Clear();
                    DataTable dt = (DataTable)grdArticulos.DataSource;
                    dt.Clear();
                    grdDetalleLotes.Rows.Clear();

                    txtSKU.Text = "";
                    txtCantidad.Text = "";
                    LblK_Articulo.Text = "";
                    lblD_Articulo.Text = "";
                    LblLoteS.Text = "";
                    lblSubtotal.Text = "0.00";
                    LblIva.Text = "0.00";
                    lblPrecio.Text = "0.00";
                    txtK_Cliente.Text = "";
                    txtD_Cliente.Text = "";
                    CbxRequiereReceta.Checked = false;
                    txtObservaciones1.Text = "";
                    txtObservaciones2.Text = "";
                    txtObservaciones3.Text = "";
                    txtObservaciones4.Text = "";
                    txtObservaciones5.Text = "";
                    txtK_Medico.Text = "0";
                    txtK_Cliente.Text = "0";
                    LblDesc.Text = "0.00";
                    LblCantidad.Text = "0";
                    LblCantidadDesc.Visible = false;
                    LblSigno.Visible = false;
                    cbxDescEmpleado.Checked = false;
                    Descuento_Empleado = 0;
                    txtNo_Tarjeta.Text = "";
                }
            }

        }
        private void BtnCierre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿ ESTA SEGURO DE REALIZAR SU CORTE DE USUARIO? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result== DialogResult.Yes)
            {
                Frm_PreCierre_Empleado frm = new Frm_PreCierre_Empleado();
                frm.p_K_Almacen = K_AlmacenEnt;
                Cursor = Cursors.WaitCursor;
                frm.ShowDialog();
                Cursor = Cursors.Default;
                //CORTE  *

                //if (!BaseFuncionValidaciones())
                //    return;

                //res = 0;
                //msg = string.Empty;
                //int CampoIdentity = 0;


                //// res = SQLVentas.Gp_Aplica_Precierre(ref CampoIdentity, K_AlmacenEnt, ref  msg);
                // if (res == 0)
                // {
                //     msg = "EL PRECIERRE FUE APLICADO....";
                // }

                // if (res == -1)
                // {
                //    BaseErrorResultado = true;
                //    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                // }

                //else
                // {
                //   BaseErrorResultado = false;
                //   MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //   BaseMetodoInicio();
                //   BaseBotonCancelarClick();
                //}
            }

        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            //SALIR
            this.Close();
        }

        //PENDIENTE
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            //AYUDA AUN NO ESTA FORMATO 

        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtSKU_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtSKU_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                if(txtSKU.Text.Trim().Length>0)
                {
                    //Busca Articulos Exitencia, Precio Desc
                    DataTable datos = new DataTable();

                    string Mensaje2 = "";

                    datos = sql_Ventas.Gp_Inventario_Farmacia(GlobalVar.K_Oficina, K_AlmacenEnt, 0, false, true, txtSKU.Text, 0, 0, txtK_Cliente.Text.Trim().Length>0? Convert.ToInt32(txtK_Cliente.Text):0,ref Mensaje2);

                    if(Mensaje2.Length>0)
                    {
                        MessageBox.Show(Mensaje2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (datos == null)
                    {
                        MessageBox.Show("NO SE ENCONTRO ARTICULO DISPONIBLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSKU.Text = "";
                        return;
                    }
                    else
                    {
                        if(datos.Rows.Count==0)
                        {
                            MessageBox.Show("NO SE ENCONTRO ARTICULO DISPONIBLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSKU.Text = "";
                            return;
                        }
                        LblK_Articulo.Text = datos.Rows[0]["K_Articulo"].ToString();
                        lblD_Articulo.Text = datos.Rows[0]["D_Articulo"].ToString();
                        LblLoteS.Text = datos.Rows[0]["No_Lote"].ToString();
                        LblF_Caducidad.Text = datos.Rows[0]["F_Caducidad"].ToString();
                        PSubtotal = Convert.ToDecimal(datos.Rows[0]["SubTotal"].ToString());
                        PIva = Convert.ToDecimal(datos.Rows[0]["Iva"].ToString());
                        CbxRequiereReceta.Checked = Convert.ToBoolean(datos.Rows[0]["B_Requiere_Receta"].ToString());
                        Descuento = Convert.ToDecimal(datos.Rows[0]["Descuento"].ToString());
                        Precio_Unitario = Convert.ToDecimal(datos.Rows[0]["Precio_Unitario"].ToString());
                        PrecioAct = Convert.ToDecimal(datos.Rows[0]["Precio"].ToString());
                        PrecioMaximo = Convert.ToDecimal(datos.Rows[0]["Precio_Maximo_Publico"].ToString());
                        PPorcentaje = Convert.ToDecimal(datos.Rows[0]["Porcentaje"].ToString());
                        if (txtCantidad.Text.Length == 0)
                            txtCantidad.Text = "1";
                        BtnAgergar.PerformClick();
                    }
                }
                
            }
        }
        private void txtSKU_TextChanged(object sender, EventArgs e)
        {
            if (txtSKU.Text.Trim().Length == 0)
            {
                LblK_Articulo.Text = "";
                lblD_Articulo.Text = "";
                LblLoteS.Text = "";
                LblF_Caducidad.Text = "";
            }
            txtSKU.Focus();
        }
        private void txtSKU_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if(txtSKU.Text.Trim().Length>0)
                {
                    string Mensaje2 = "";
                    //Busca Articulos Existencia, Precio Desc
                    DataTable datos = new DataTable();

                    datos = sql_Ventas.Gp_Inventario_Farmacia(GlobalVar.K_Oficina, K_AlmacenEnt, 0, false, true, txtSKU.Text, 0, 0, Convert.ToInt32(txtK_Cliente.Text),ref Mensaje2);

                    if(Mensaje2.Length>0)
                    {
                        MessageBox.Show(Mensaje2 ,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (datos == null)
                    {
                        MessageBox.Show("NO SE ENCONTRO ARTICULO DISPONIBLE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSKU.Text = "";
                        return;
                    }
                    else
                    {
                        LblK_Articulo.Text = datos.Rows[0]["K_Articulo"].ToString();
                        lblD_Articulo.Text = datos.Rows[0]["D_Articulo"].ToString();
                        LblLoteS.Text = datos.Rows[0]["No_Lote"].ToString();
                        LblF_Caducidad.Text = datos.Rows[0]["F_Caducidad"].ToString();
                        PSubtotal = Convert.ToDecimal(datos.Rows[0]["SubTotal"].ToString());
                        PIva = Convert.ToDecimal(datos.Rows[0]["Iva"].ToString());
                        CbxRequiereReceta.Checked = Convert.ToBoolean(datos.Rows[0]["B_Requiere_Receta"].ToString());
                        Descuento = Convert.ToDecimal(datos.Rows[0]["Descuento"].ToString());
                        Precio_Unitario = Convert.ToDecimal(datos.Rows[0]["Precio_Unitario"].ToString());
                        PrecioAct = Convert.ToDecimal(datos.Rows[0]["Precio"].ToString());
                        PrecioMaximo = Convert.ToDecimal(datos.Rows[0]["Precio_Maximo_Publico"].ToString());
                        PPorcentaje = Convert.ToDecimal(datos.Rows[0]["Porcentaje"].ToString());
                        if (txtCantidad.Text.Length == 0)
                            txtCantidad.Text = "1";
                        BtnAgergar.PerformClick();
                    }
                }
                
            }
        }


        private void txtNo_Tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtNo_Tarjeta_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Validaciones de Tarjeta

            int K_Cliente_Tarjeta = 0;

            if (e.KeyCode == Keys.Tab)
            {
                DataTable datos = new DataTable();

                if (txtNo_Tarjeta.Text.Trim().Length > 0)
                {
                    datos = sql_Ventas.Sk_ClienteDatosTarjeta(Convert.ToDecimal(txtNo_Tarjeta.Text));

                    if (datos == null)
                    {
                        MessageBox.Show("LA TARJETA NO SE ENCUENTRA EN EL INVENTARIO ,NO ES VALIDA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNo_Tarjeta.Focus();
                        txtNo_Tarjeta.Text = "";
                        return;
                    }
                    else
                    {
                        K_Cliente_Tarjeta = Convert.ToInt32(datos.Rows[0]["K_Cliente"].ToString());

                        if (K_Cliente_Tarjeta != Convert.ToInt32(txtK_Cliente.Text) & K_Cliente_Tarjeta > 0)
                        {
                            MessageBox.Show("EL CLIENTE ASIGNADO A LA TARJETA ES DIFERENTE AL CAPTURADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNo_Tarjeta.Focus();
                            txtNo_Tarjeta.Text = "";
                            return;
                        }
                    }

                    if (K_Cliente_Tarjeta == 0)
                    {
                        MessageBox.Show("LA TARJETA NO TIENE CLIENTE ASIGNADO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAsignaTarjeta.PerformClick();
                        return;

                    }
                    MessageBox.Show("LA TARJETA ESTA VIGENTE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void txtNo_Tarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            int K_Cliente_Tarjeta = 0;

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {

                DataTable datos = new DataTable();

                if (txtNo_Tarjeta.Text.Trim().Length > 0)
                {
                    datos = sql_Ventas.Sk_ClienteDatosTarjeta(Convert.ToDecimal(txtNo_Tarjeta.Text));

                    if (datos == null)
                    {
                        MessageBox.Show("LA TARJETA NO SE ENCUENTRA EN EL INVENTARIO ,NO ES VALIDA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNo_Tarjeta.Focus();
                        txtNo_Tarjeta.Text = "";
                        return;
                    }
                    else
                    {
                        K_Cliente_Tarjeta = Convert.ToInt32(datos.Rows[0]["K_Cliente"].ToString());

                        if (K_Cliente_Tarjeta != Convert.ToInt32(txtK_Cliente.Text) & K_Cliente_Tarjeta > 0)
                        {
                            MessageBox.Show("EL CLIENTE ASIGNADO A LA TARJETA ES DIFERENTE AL CAPTURADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNo_Tarjeta.Focus();
                            txtNo_Tarjeta.Text = "";
                            return;
                        }
                    }

                    if (K_Cliente_Tarjeta == 0)
                    {
                        MessageBox.Show("LA TARJETA NO TIENE CLIENTE ASIGNADO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNo_Tarjeta.Text = "";
                        return;

                    }
                }
            }
        }
        private void txtAsignaTarjeta_Click(object sender, EventArgs e)
        {
            // ASIGNACION DE TARJETA Y CONSULTA   si tiene cliente y tiene tarjeta valida pasala y mostrar datos


            Frm_Datos_Tarjeta frm = new Frm_Datos_Tarjeta();

            if (txtNo_Tarjeta.Text.Trim().Length != 0) // ESTA CAPTURADA  
            {
                DataTable datos = new DataTable();

                datos = sql_Ventas.Sk_ClienteDatosTarjeta(Convert.ToDecimal(txtNo_Tarjeta.Text));
                if (datos != null)
                {
                    No_Tarjeta_Capturado = datos.Rows[0]["No_Tarjeta"].ToString();
                    Monto_Disponible = datos.Rows[0]["Monto_Disponible"].ToString();
                    K_Cliente_Capturado = Convert.ToInt32(datos.Rows[0]["K_Cliente"].ToString());
                    D_Cliente_Capturado = datos.Rows[0]["D_Cliente"].ToString();
                    RFC = datos.Rows[0]["RFC"].ToString();
                    F_UltimoCanje = datos.Rows[0]["F_Canje"].ToString();
                    F_UltimoConsumo = datos.Rows[0]["F_Acumula"].ToString();
                    Correo_Capturado = datos.Rows[0]["Correo"].ToString();

                    if (K_Cliente_Capturado > 0)  // ESTA ASIGNADA 
                    {
                        frm.txtTarjetaCliente.ReadOnly = true;
                        frm.txtDescripcion.ReadOnly = true;
                        frm.txtRFC.ReadOnly = true;
                        frm.txtCorreo.ReadOnly = true;
                        //frm.PnlAlta.Visible = false;
                        //frm.PnlAlta.Enabled = false;
                        //frm.PnlAlta.AutoSize = false;
                        frm.txtDescripcion.Text = D_Cliente_Capturado;
                        frm.txtRFC.Text = RFC;
                        frm.txtTarjetaCliente.Text = No_Tarjeta_Capturado;
                        frm.txtxSaldoActual.Text = Monto_Disponible;
                        frm.txtUltimoCanje.Text = F_UltimoCanje;
                        frm.txtUltimoConsumo.Text = F_UltimoConsumo;
                        frm.txtCorreo.Text = Correo_Capturado;

                    }
                    else      // NO ESTA ASIGNADA  TIENE O NO TIENE CLIENTE 
                    {
                        DataTable datoss = new DataTable();
                        datoss = sql_Ventas.Sk_ClienteDatosTarjeta(Convert.ToInt32(txtK_Cliente.Text));
                        //si cliente existe 
                        if (txtK_Cliente.Text.Trim().Length != 0)  //CLIENTE REGISTRADO 
                        {
                            if (datoss != null)
                            {
                                No_Tarjeta_Capturado = datoss.Rows[0]["No_Tarjeta"].ToString();
                                Monto_Disponible = datoss.Rows[0]["Monto_Disponible"].ToString();
                                K_Cliente_Capturado = Convert.ToInt32(datoss.Rows[0]["K_Cliente"].ToString());
                                D_Cliente_Capturado = datoss.Rows[0]["D_Cliente"].ToString();
                                RFC = datoss.Rows[0]["RFC"].ToString();
                                F_UltimoCanje = datoss.Rows[0]["F_Canje"].ToString();
                                F_UltimoConsumo = datoss.Rows[0]["F_Acumula"].ToString();
                                Correo_Capturado = datoss.Rows[0]["Correo"].ToString();
                                frm.txtDescripcion.Text = D_Cliente_Capturado;
                                frm.txtRFC.Text = RFC;
                                frm.txtTarjetaCliente.Text = No_Tarjeta_Capturado;
                                frm.txtxSaldoActual.Text = Monto_Disponible;
                                frm.txtUltimoCanje.Text = F_UltimoCanje;
                                frm.txtUltimoConsumo.Text = F_UltimoConsumo;
                                frm.txtCorreo.Text = Correo_Capturado;
                                frm.txtK_Cliente.Text = Convert.ToString(K_Cliente_Capturado);
                                frm.PnlAlta.Visible = true;
                                frm.PnlAlta.Enabled = true;
                                // frm.PnlAlta.AutoSize = true;
                                frm.txtTarjetaCliente.Enabled = true;
                                frm.txtDescripcion.ReadOnly = true;
                                frm.txtRFC.ReadOnly = true;
                                frm.txtCorreo.ReadOnly = true;
                                frm.txtTarjetaCliente.Focus();
                            }
                            else   // CLIENTE NO REGISTRADO 
                            {
                                frm.PnlAlta.Visible = true;
                                frm.PnlAlta.Enabled = true;
                                frm.PnlAlta.AutoSize = true;
                                frm.txtK_Cliente.Text = txtK_Cliente.Text;
                                frm.txtDescripcion.Text = txtD_Cliente.Text;
                            }

                        }
                    }
                }
                else
                {
                    if (txtNo_Tarjeta.Text.Trim().Length != 0 & txtK_Cliente.Text.Trim().Length == 0) // NO HAY TARJETA NI CLIENTE  
                    {
                        frm.PnlAlta.Visible = true;
                        frm.PnlAlta.Enabled = true;
                        //frm.PnlAlta.AutoSize = true;

                    }
                }
            }

            if (txtNo_Tarjeta.Text.Trim().Length == 0 & txtK_Cliente.Text.Trim().Length > 0) // NO HAY TARJETA Y SI CLIENTE 
            {

                DataTable datoss = new DataTable();
                datoss = sql_Ventas.Sk_ClienteDatosTarjeta(Convert.ToInt32(txtK_Cliente.Text));
                //si cliente existe 
                if (txtK_Cliente.Text.Trim().Length != 0)  //CLIENTE REGISTRADO 
                {
                    if (datoss != null)
                    {
                        No_Tarjeta_Capturado = datoss.Rows[0]["No_Tarjeta"].ToString();
                        Monto_Disponible = datoss.Rows[0]["Monto_Disponible"].ToString();
                        K_Cliente_Capturado = Convert.ToInt32(datoss.Rows[0]["K_Cliente"].ToString());
                        D_Cliente_Capturado = datoss.Rows[0]["D_Cliente"].ToString();
                        RFC = datoss.Rows[0]["RFC"].ToString();
                        F_UltimoCanje = datoss.Rows[0]["F_Canje"].ToString();
                        F_UltimoConsumo = datoss.Rows[0]["F_Acumula"].ToString();
                        Correo_Capturado = datoss.Rows[0]["Correo"].ToString();
                        frm.txtDescripcion.Text = D_Cliente_Capturado;
                        frm.txtRFC.Text = RFC;
                        frm.txtTarjetaCliente.Text = No_Tarjeta_Capturado;
                        frm.txtxSaldoActual.Text = Monto_Disponible;
                        frm.txtUltimoCanje.Text = F_UltimoCanje;
                        frm.txtUltimoConsumo.Text = F_UltimoConsumo;
                        frm.txtCorreo.Text = Correo_Capturado;
                        frm.txtK_Cliente.Text = Convert.ToString(K_Cliente_Capturado);
                        frm.PnlAlta.Visible = true;
                        frm.PnlAlta.Enabled = true;
                        // frm.PnlAlta.AutoSize = true;
                        frm.txtTarjetaCliente.Enabled = true;
                        frm.txtDescripcion.ReadOnly = true;
                        frm.txtRFC.ReadOnly = true;
                        frm.txtCorreo.ReadOnly = true;
                        frm.txtTarjetaCliente.Focus();
                    }
                    else   // CLIENTE NO REGISTRADO 
                    {
                        frm.PnlAlta.Visible = true;
                        frm.PnlAlta.Enabled = true;
                        frm.PnlAlta.AutoSize = true;
                        frm.txtK_Cliente.Text = txtK_Cliente.Text;
                        frm.txtDescripcion.Text = txtD_Cliente.Text;
                    }
                }

            }
            frm.ShowDialog();

            // si no tiene tarjeta valida capturada  limpiar datos , si asigna regresar no trajeta y puntos 

        }


        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {

            BtnLimpiar.PerformClick();
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            txtD_Cliente.Text = filtra.D_Cliente_Seleccionado;
            txtK_Cliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
            txtNo_Tarjeta.Text = "";

            if ((filtra.DiasCredito_Seleccionado > 0) & (filtra.LimiteCredito_Seleccionado > 0))
            {
                B_Credito = true;

            }
            else
            {
                B_Credito = false;
            }

        }
        private void BtnBuscaMedico_Click(object sender, EventArgs e)
        {
            if(grdArticulos.Rows.Count==0)
            {
                MessageBox.Show("FALTA AGREGAR ARTICULOS A LA VENTA!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSKU.Focus();
                return;
            }
            bool b_receta = false;
            this.grdArticulos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            Cursor = Cursors.WaitCursor;
            Busquedas.Frm_Busca_Medico frm = new Busquedas.Frm_Busca_Medico();
            frm.ShowDialog();
            Cursor = Cursors.Default;
            if (frm.LLave_Seleccionado != 0)
            {
                DialogResult result = MessageBox.Show("            RETIENE RECETA ?? ", "Agrega Receta", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Guarde 
                    b_receta = true;
                }

                if (_K_Medico != frm.LLave_Seleccionado)
                {
                    _K_Medico = frm.LLave_Seleccionado;
                    txtK_Medico.Text = Convert.ToString(_K_Medico);
                    txtD_Medico.Text = frm.Descripcion_Seleccionado;
                }
                else
                {
                    _K_Medico = 0;
                    txtK_Medico.Text = Convert.ToString(_K_Medico);
                    txtD_Medico.Text = frm.Descripcion_Seleccionado;
                }
                foreach (DataGridViewRow row in grdArticulos.Rows)
                {
                    if ((Convert.ToBoolean(row.Cells["Requiere_Receta"].Value.ToString())) && (row.Cells["K_Medico"].Value.ToString()) == "")
                    {
                        row.Cells["K_Medico"].Value = txtK_Medico.Text;
                        row.Cells["D_Medico"].Value = txtD_Medico.Text;
                    }
                    if (!Convert.ToBoolean(row.Cells["Requiere_Receta"].Value.ToString()))
                    {
                        row.Cells["K_Medico"].Value = "";
                        row.Cells["D_Medico"].Value = "";
                    }
                    row.Cells["Retiene"].Value = b_receta;
                }
                //txtD_Medico.Text = "";
                //txtK_Medico.Text = "";
            }
            else
            {
                _K_Medico = 0;
                txtK_Medico.Text = string.Empty;
                txtD_Medico.Text = string.Empty;
            }




        }
        private void BtnCapturaMedico_Click(object sender, EventArgs e)
        {
            //CAPTURA MEDICO     
            Frm_RegistraMedico frm = new Frm_RegistraMedico();
            Cursor = Cursors.WaitCursor;
            frm.ShowDialog();
            Cursor = Cursors.Default;
            txtK_Medico.Text = frm.K_Medico.ToString();
            txtD_Medico.Text = frm.D_Medico;
        }
        private void cbxSeleccionMedico_CheckedChanged(object sender, EventArgs e)
        {
            grdArticulos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            grdArticulos.EndEdit();

            if (cbxSeleccionMedico.Checked)
            {
                foreach (DataGridViewRow row in grdArticulos.Rows)
                {
                    row.Selected = true;
                    row.Cells["Requiere_Receta"].Value = true;
                }
            }
            else if (!cbxSeleccionMedico.Checked)
            {
                foreach (DataGridViewRow row in grdArticulos.Rows)
                {
                    row.Selected = false;
                    row.Cells["Requiere_Receta"].Value = false;
                    row.Cells["K_Medico"].Value = "";
                    row.Cells["D_Medico"].Value = "";
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string SKU;
            bool B_Existe;
            if (cbxDescEmpleado.Checked)
            {
                Descuento = PSubtotal * (Convert.ToDecimal(LblCantidadDesc.Text) / 100);
                PSubtotal = PSubtotal - Descuento;
                Descuento = Precio_Unitario - PSubtotal;
                if (PIva > 0)
                {
                    PIva = PSubtotal * Convert.ToDecimal(.16);
                }
            }
            else
            {
                LblCantidadDesc.Visible = false;
                LblSigno.Visible = false;
                Descuento_Empleado = 0;
            }
            if (Descuento < 0)
                Descuento = 0;
            if (txtSKU.Text.Trim().Length == 0)
            {
                MessageBox.Show("SELECCIONE UN ARTICULO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSKU.Focus();
                txtSKU.Text = "";
                return;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE LA CANTIDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            if (lblD_Articulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("CONSULTE EL ARTICULO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSKU.Text = "";
                txtSKU.Focus();
                return;
            }
            //if (PrecioAct > PrecioMaximo)
            //{
            //    MessageBox.Show("EL PRECIO ACTUAL NO PUEDE SER MAYOR AL PRECIO MAXIMO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtSKU.Focus();
            //    txtSKU.Text = "";
            //    txtCantidad.Text = "";
            //    CbxRequiereReceta.Checked = false;
            //    return;
            //}
            int res = 0;
            string Mensaje = "";
            res = sql_precios.Gp_ValidaPrecioGanancia(Convert.ToInt32(LblK_Articulo.Text), Precio_Unitario, ref Mensaje);
            if (res == -1)
            {
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSKU.Focus();
                txtSKU.Text = "";
                txtCantidad.Text = "";
                CbxRequiereReceta.Checked = false;
                return;
            }

            //Decimal subtotal = PSubtotal * Convert.ToDecimal(txtCantidad.Text) + Convert.ToDecimal(lblSubtotal.Text);
            //Decimal iva = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text), 2) + Convert.ToDecimal(lblSubtotal.Text);
            //Decimal total = Convert.ToDecimal(PSubtotal * Convert.ToDecimal(txtCantidad.Text)) + Convert.ToDecimal(txtCantidad.Text) * (PIva) + Convert.ToDecimal(lblPrecio.Text);

            if (grdArticulos.RowCount == 0)
            {
                DataRow dr;
                dr = dtDatos.NewRow();

                dr["K_Articulo"] = Convert.ToInt32(LblK_Articulo.Text);
                dr["D_Articulo"] = lblD_Articulo.Text;
                dr["SKU"] = txtSKU.Text;
                dr["Lote"] = LblLoteS.Text;

                DateTime dt = new DateTime();
                dt = Convert.ToDateTime(LblF_Caducidad.Text.Trim());
                string s = dt.ToString("dd/MM/yyyy");

                dr["F_Caducidad"] = s;
                dr["Precio"] = PrecioAct;
                dr["Cantidad"] = Convert.ToInt32(txtCantidad.Text);
                dr["Total"] = (PSubtotal * Convert.ToDecimal(txtCantidad.Text)) + (Convert.ToDecimal(txtCantidad.Text) * PIva);
                dr["Subtotal"] = PSubtotal * Convert.ToDecimal(txtCantidad.Text);
                dr["Iva"] = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text), 2);
                dr["Precio_Maximo_Publico"] = Math.Round(PrecioMaximo, 2);
                dr["Descuento"] = Math.Round(Descuento * Convert.ToDecimal(txtCantidad.Text), 2);
                dr["Receta"] = CbxRequiereReceta.Checked;
                dr["K_Medico"] = "";
                dr["D_Medico"] = "";
                dr["Retiene"] = false;
                dr["Porcentaje"] = PPorcentaje; ;
                dtDatos.Rows.Add(dr);
            }
            else
            {
                B_Existe = false;
                //se encuentra  sumo 
                foreach (DataRow row in dtDatos.Rows)
                {
                    SKU = row["SKU"].ToString();
                    B_Existe = false;

                    if (txtSKU.Text == SKU)
                    {
                        row["Cantidad"] = Convert.ToInt32(txtCantidad.Text) + Convert.ToInt32(row["Cantidad"].ToString());
                        row["Subtotal"] = PSubtotal + Convert.ToDecimal(row["Subtotal"].ToString());
                        row["Iva"] = PIva + Convert.ToDecimal(row["Iva"].ToString());
                        row["Total"] = PrecioAct + Convert.ToDecimal(row["Total"].ToString());
                        row["Descuento"] = Math.Round(Descuento + Convert.ToDecimal(row["Descuento"]), 2);
                        B_Existe = true;
                        break;
                    }
                }
                if (!B_Existe)
                {
                    DataRow dr;
                    dr = dtDatos.NewRow();

                    dr["K_Articulo"] = LblK_Articulo.Text;
                    dr["D_Articulo"] = lblD_Articulo.Text;
                    dr["SKU"] = txtSKU.Text;
                    dr["Lote"] = LblLoteS.Text;

                    DateTime dt = new DateTime();
                    dt = Convert.ToDateTime(LblF_Caducidad.Text.Trim());
                    string s = dt.ToString("dd/MM/yyyy");

                    dr["F_Caducidad"] = s;
                    dr["Precio"] = PSubtotal;
                    dr["Cantidad"] = Convert.ToInt32(txtCantidad.Text);
                    dr["Total"] = (PSubtotal * Convert.ToDecimal(txtCantidad.Text)) +(Convert.ToDecimal(txtCantidad.Text) * PIva);
                    dr["Subtotal"] = PSubtotal * Convert.ToDecimal(txtCantidad.Text);
                    dr["Iva"] = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text), 2);
                    dr["Descuento"] = Math.Round(Descuento * Convert.ToDecimal(txtCantidad.Text), 2);
                    dr["Precio_Maximo_Publico"] = PrecioMaximo;
                    dr["Receta"] = CbxRequiereReceta.Checked;
                    dr["K_Medico"] = "";
                    dr["D_Medico"] = "";
                    dr["Retiene"] = false;
                    dr["Porcentaje"] = PPorcentaje;
                    dtDatos.Rows.Add(dr);
                }
            }
            grdArticulos.DataSource = dtDatos;

            Mtd_Carga_Lotes(Convert.ToInt32(LblK_Articulo.Text));

            //subtotal = Math.Round(subtotal, 2);
            //iva = Math.Round(iva, 2);
            //total = Math.Round(total, 2);

            //lblSubtotal.Text = subtotal.ToString();
            //LblIva.Text = iva.ToString();
            //lblPrecio.Text = total.ToString();

            lblD_Articulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            KArticulo = 0;
            //btnBuscarArticulos.Focus();
            double sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in grdArticulos.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Cantidad"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            LblCantidad.Text = Convert.ToString(sumatoria);

            txtCantidad.Text = "";
            CbxRequiereReceta.Checked = false;
            // Mtd_Eliminar_Lotes(int.Parse(LblK_Articulo.Text));
            LblK_Articulo.Text = "";
            lblD_Articulo.Text = "";
            LblLoteS.Text = "";
            LblF_Caducidad.Text = "";
            txtSKU.Text = "";
            Mtd_Calcula_Totales();
            grdArticulos.Columns["Descuento1"].Visible = false;
            grdArticulos.ClearSelection();

        }

        private void grdArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (grdArticulos.Columns[e.ColumnIndex].Name == "Sel_Lote")
                {
                    Cursor = Cursors.WaitCursor;
                    VENTAS.Frm_Ventas_Asigna_Lotes frm = new Frm_Ventas_Asigna_Lotes();
                    if (Mtd_ValidarTengaMasLotes(Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Articulo"].Value)))
                    {
                        //Si me devuelve true entonces si tiene lotes asignados,por lo que se pasa a la forma de asignación de lotes la info actual
                        frm.p_dtDatosActuales = Mtd_Formar_Lotes_Actuales(Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Articulo"].Value));

                        var rows = grdDetalleLotes.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["cK_Articulo"].Value.ToString() == grdArticulos.CurrentRow.Cells["K_Articulo"].Value.ToString()).ToList();

                        foreach (var row in rows)
                        {
                            grdDetalleLotes.Rows.Remove(row);
                        }
                    }

                    frm.p_K_Almacen = K_AlmacenEnt;
                    frm.p_K_Articulo = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Articulo"].Value);
                    frm.p_Cantidad_Inicial = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Cantidad"].Value);
                    frm.p_D_Articulo = grdArticulos.CurrentRow.Cells["D_Articulo"].Value.ToString();

                    this.AddOwnedForm(frm);
                    frm.Show();
                    Cursor = Cursors.Default;
                    grdArticulos.ClearSelection();
                }
                if (grdArticulos.Columns[e.ColumnIndex].Name == "Menos")
                {
                    Mtd_Disminuir(sender, e);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        #region FUNCIONES
        private void Mtd_Calcula_Totales()
        {
            //Calculamos el IVA de todos los artículos
            if (dtDatos.Rows.Count == 0)
            {
                LblIva.Text = Math.Round(0.00, 2).ToString("N2").Trim();
                lblSubtotal.Text = Math.Round(0.00, 2).ToString("N2").Trim();
                lblPrecio.Text = Math.Round(Convert.ToDecimal(LblIva.Text) + Convert.ToDecimal(lblSubtotal.Text), 2).ToString("N2");
                LblCantidad.Text = "0";
                LblDesc.Text = "0.00";
                return;
            }
            var x = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Iva"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    LblIva.Text = Math.Round(x, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el SUBTOTAL de todos los artículos
            var z = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("SubTotal"))).Sum();
            if (z.ToString() != "")
            {
                lblSubtotal.Text = Math.Round(z, 2).ToString("N2").Trim();

            }
            var y = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Descuento"))).Sum();
            if (y.ToString() != "")
            {
                LblDesc.Text = Math.Round(y, 2).ToString("N2").Trim();

            }

            //Calculamos el TOTAL del pedido
            decimal totalPedido = x + z;
            lblPrecio.Text = Math.Round(totalPedido, 2).ToString("N2");

            double sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in grdArticulos.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Cantidad"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            LblCantidad.Text = Convert.ToString(sumatoria);
        }
        private bool Mtd_ValidarTengaMasLotes(Int32 K_Articulo)
        {
            foreach (DataGridViewRow row in grdDetalleLotes.Rows)
            {
                if (Convert.ToInt32(row.Cells["cK_Articulo"].Value) == K_Articulo)
                {
                    return true;
                }
            }
            return false;
        }
        private DataTable Mtd_Formar_Lotes_Actuales(Int32 K_Articulo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("K_Articulo", typeof(System.Int32));
            dt.Columns.Add("K_Movimiento_Inventario", typeof(System.Int32));
            dt.Columns.Add("No_Lote", typeof(System.String));
            dt.Columns.Add("Cantidad_Asignada", typeof(System.Int32));
            foreach (DataGridViewRow row in grdDetalleLotes.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == K_Articulo)
                {
                    DataRow rowD = dt.NewRow();
                    rowD["K_Articulo"] = Convert.ToInt32(row.Cells["cK_Articulo"].Value.ToString());
                    rowD["K_Movimiento_Inventario"] = Convert.ToInt32(row.Cells["cK_Movimiento_Inventario"].Value);
                    rowD["No_Lote"] = row.Cells["cNo_Lote"].Value;
                    rowD["Cantidad_Asignada"] = Convert.ToInt32(row.Cells["cCantidad"].Value);
                    dt.Rows.Add(rowD);
                }

            }
            return dt;
        }
        private DataTable Mtd_Construir_Detalle_Venta(ref bool B_Error)
        {
            foreach (DataGridViewRow rowGrid in grdArticulos.Rows)
            {
                if (Mtd_ValidarTengaMasLotes(Convert.ToInt32(rowGrid.Cells["K_Articulo"].Value)))
                {
                    var rows = grdDetalleLotes.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["cK_Articulo"].Value.ToString() == rowGrid.Cells["K_Articulo"].Value.ToString()).ToList();

                    foreach (var row in rows)
                    {
                        DataRow dr = dtArticulos.NewRow();
                        dr["K_Articulo"] = Convert.ToInt32(row.Cells["cK_Articulo"].Value);
                        dr["D_Articulo"] = rowGrid.Cells["D_Articulo"].Value;
                        dr["SKU"] = rowGrid.Cells["SKU"].Value;
                        dr["Lote"] = row.Cells["cNo_Lote"].Value;
                        dr["F_Caducidad"] = row.Cells["cF_Caducidad"].Value;
                        dr["Precio"] = Convert.ToDecimal(rowGrid.Cells["Precio"].Value);
                        dr["Cantidad"] = Convert.ToInt32(row.Cells["cCantidad"].Value);
                        dr["Total"] = Convert.ToDecimal(rowGrid.Cells["Total"].Value);
                        dr["Subtotal"] = Convert.ToDecimal(rowGrid.Cells["Subtotal"].Value);
                        dr["Iva"] = Convert.ToDecimal(rowGrid.Cells["Iva"].Value);
                        dr["Iva"] = 1;
                        dr["K_Movimiento_Inventario"] = Convert.ToInt32(row.Cells["cK_Movimiento_Inventario"].Value);
                        if (Convert.ToBoolean(rowGrid.Cells["Requiere_Receta"].Value)  && rowGrid.Cells["K_Medico"].Value.ToString() == "")
                        {
                            MessageBox.Show("DEBE ASIGNAR MEDICO A LOS MEDICAMENTOS QUE REQUIEREN RECETA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            B_Error = true;
                            break;
                        }
                        else if (Convert.ToBoolean(rowGrid.Cells["Requiere_Receta"].Value) == true && rowGrid.Cells["K_Medico"].Value.ToString() != "")
                        {
                            dr["K_Medico"] = Convert.ToInt32(rowGrid.Cells["K_Medico"].Value);
                        }
                        else if (Convert.ToBoolean(rowGrid.Cells["Requiere_Receta"].Value) == false && rowGrid.Cells["K_Medico"].Value.ToString() == "")
                        {
                            dr["K_Medico"] = 0;
                        }
                        dr["Retiene"] = Convert.ToBoolean(rowGrid.Cells["Retiene"].Value);
                        dtArticulos.Rows.Add(dr);
                    }
                }

                else
                {
                    DataRow drx = dtArticulos.NewRow();
                    drx["K_Articulo"] = Convert.ToInt32(rowGrid.Cells["K_Articulo"].Value);
                    drx["D_Articulo"] = rowGrid.Cells["D_Articulo"].Value;
                    drx["SKU"] = rowGrid.Cells["SKU"].Value;
                    drx["Lote"] = rowGrid.Cells["Lote"].Value;
                    drx["F_Caducidad"] = rowGrid.Cells["F_Caducidad"].Value;
                    drx["Precio"] = Convert.ToDecimal(rowGrid.Cells["Precio"].Value);
                    drx["Cantidad"] = Convert.ToInt32(rowGrid.Cells["Cantidad"].Value);
                    drx["Total"] = Convert.ToDecimal(rowGrid.Cells["Total"].Value);
                    drx["Subtotal"] = Convert.ToDecimal(rowGrid.Cells["Subtotal"].Value);
                    drx["Iva"] = Convert.ToDecimal(rowGrid.Cells["Iva"].Value);
                    if (Convert.ToBoolean(rowGrid.Cells["Requiere_Receta"].Value) == true && rowGrid.Cells["K_Medico"].Value.ToString() == "")
                    {
                        MessageBox.Show("DEBE ASIGNAR MEDICO A LOS MEDICAMENTOS QUE REQUIEREN RECETA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else if (Convert.ToBoolean(rowGrid.Cells["Requiere_Receta"].Value) == false && rowGrid.Cells["K_Medico"].Value.ToString() != "")
                    {
                        drx["K_Medico"] = Convert.ToInt32(rowGrid.Cells["K_Medico"].Value);
                    }
                    else if (Convert.ToBoolean(rowGrid.Cells["Requiere_Receta"].Value) == false && rowGrid.Cells["K_Medico"].Value.ToString() == "")
                    {
                        drx["K_Medico"] = 0;
                    }
                    drx["Retiene"] = Convert.ToBoolean(rowGrid.Cells["Retiene"].Value);
                    dtArticulos.Rows.Add(drx);

                }

            }
            return dtArticulos;
        }
        private void Mtd_Eliminar_Lotes(Int32 K_Articulo)
        {
            var rowsx = grdDetalleLotes.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["cK_Articulo"].Value.ToString() == K_Articulo.ToString()).ToList();

            foreach (var rows in rowsx)
            {

                grdDetalleLotes.Rows.Remove(rows);

            }
        }
        private void Mtd_Carga_Lotes(Int32 p_K_Articulo)
        {
            dtLotes = null;
            dtLotes = sql_Ventas.Gp_InventarioxArticulo(GlobalVar.K_Oficina, K_AlmacenEnt, p_K_Articulo);

            if (dtLotes != null)
            {
                //PEDI 3
                int restante = 0;
                int indice = 0;
                restante = int.Parse(txtCantidad.Text);

                foreach (DataRow row in dtLotes.Rows)
                {
                    int CantDisp = int.Parse(row["Cantidad_Disponible"].ToString());

                    if (CantDisp >= restante)
                    {
                        this.grdDetalleLotes.Rows.Add(new[] {
                             row["K_Articulo"].ToString(),
                             row["K_Movimiento_Inventario"].ToString(),
                             row["No_Lote"].ToString(),
                             restante.ToString(),
                             row["F_Caducidad"].ToString(),
                             });
                        restante = 0;

                    }
                    else
                    {
                        this.grdDetalleLotes.Rows.Add(new[] {
                             row["K_Articulo"].ToString(),
                             row["K_Movimiento_Inventario"].ToString(),
                             row["No_Lote"].ToString(),
                             CantDisp.ToString(),
                             row["F_Caducidad"].ToString(),
                             });

                        restante = restante - CantDisp;

                    }

         

                }
            }
            else
            {
                BaseBotonCancelar.Visible = false;
                BaseBotonCancelar.Enabled = false;
                MessageBox.Show("No Existe Inventario Disponible del Artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length > 0)
            {
                if (Convert.ToInt32(txtCantidad.Text.Trim()) > 1000)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Text = "";
                }
            }

        }

        private void grdArticulos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if ((e.ColumnIndex == 7) || (e.ColumnIndex == 0))//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdArticulos.Cursor = Cursors.Hand;
            else
                grdArticulos.Cursor = Cursors.Default;
        }

        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            BtnBuscar.Cursor = Cursors.Hand;
        }

        private void BtnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            BtnLimpiar.Cursor = Cursors.Hand;
        }

        private void BtnCancelar_MouseEnter(object sender, EventArgs e)
        {
            BtnCancelar.Cursor = Cursors.Hand;
        }

        private void BtnCalculadora_MouseEnter(object sender, EventArgs e)
        {
            BtnCalculadora.Cursor = Cursors.Hand;
        }

        private void BtnNotas_MouseEnter(object sender, EventArgs e)
        {
            BtnNotas.Cursor = Cursors.Hand;
        }

        private void BtnConsulta_MouseEnter(object sender, EventArgs e)
        {
            BtnConsulta.Cursor = Cursors.Hand;
        }

        private void BtnPagar_MouseEnter(object sender, EventArgs e)
        {
            BtnPagar.Cursor = Cursors.Hand;
        }

        private void Btn_Salir_MouseEnter(object sender, EventArgs e)
        {
            Btn_Salir.Cursor = Cursors.Hand;
        }

        private void BtnCierre_MouseEnter(object sender, EventArgs e)
        {
            BtnCierre.Cursor = Cursors.Hand;
        }

        private void BtnCapturaMedico_MouseEnter(object sender, EventArgs e)
        {
            BtnCapturaMedico.Cursor = Cursors.Hand;
        }

        private void BtnAgergar_MouseEnter(object sender, EventArgs e)
        {
            BtnAgergar.Cursor = Cursors.Hand;
        }

        private void btnBuscaCliente_MouseEnter(object sender, EventArgs e)
        {
            btnBuscaCliente.Cursor = Cursors.Hand;
        }

        private void BtnBuscaMedico_MouseEnter(object sender, EventArgs e)
        {
            BtnBuscaMedico.Cursor = Cursors.Hand;
        }

        private void txtAsignaTarjeta_MouseEnter(object sender, EventArgs e)
        {
            txtAsignaTarjeta.Cursor = Cursors.Hand;
        }

        private void cbxSeleccionMedico_MouseEnter(object sender, EventArgs e)
        {
            cbxSeleccionMedico.Cursor = Cursors.Hand;
        }

        private void cbxEntregaDomicilio_MouseEnter(object sender, EventArgs e)
        {
            cbxEntregaDomicilio.Cursor = Cursors.Hand;
        }

        private void cbxDescEmpleado_MouseEnter(object sender, EventArgs e)
        {
            cbxDescEmpleado.Cursor = Cursors.Hand;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;
                if(txtCantidad.Text.Trim().Length>0)
                {
                    BtnAgergar.PerformClick();
                }
                Cursor = Cursors.Default;

            }
        }

        private void txtD_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtD_Cliente.Text.Trim().Length>0)
                {
                    Cursor = Cursors.WaitCursor;
                    Int32 valor = 0;
                    if ((Forma.IsNumeric(txtD_Cliente.Text)) && (Int32.TryParse(txtD_Cliente.Text.Trim(), out valor)))
                    {
                        DataTable dt = sqlCatalogos.Sk_Clientes_All(Convert.ToInt32(txtD_Cliente.Text.Trim()), string.Empty, GlobalVar.K_Empresa);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                txtD_Cliente.Text = dt.Rows[0]["D_Cliente"].ToString();
                                txtK_Cliente.Text = dt.Rows[0]["K_Cliente"].ToString();
                                txtNo_Tarjeta.Text = "";
                                if ((Convert.ToInt32(dt.Rows[0]["DiasCredito"].ToString()) > 0) && (Convert.ToDecimal(dt.Rows[0]["LimiteCredito"].ToString()) > 0))
                                    B_Credito = true;
                                else
                                    B_Credito = false;
                            }
                            else
                            {
                                txtD_Cliente.Text = string.Empty;
                                txtK_Cliente.Text = string.Empty;
                                txtNo_Tarjeta.Text = string.Empty;
                                B_Credito = false;
                            }
                        }
                        else
                        {
                            txtD_Cliente.Text = string.Empty;
                            txtK_Cliente.Text = string.Empty;
                            txtNo_Tarjeta.Text = string.Empty;
                            B_Credito = false;
                        }
                    }
                    else if (txtD_Cliente.Text.Trim().Length > 0)
                    {
                        DataTable dt = sqlCatalogos.Sk_Clientes_All(0, txtD_Cliente.Text.Trim(), GlobalVar.K_Empresa);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                txtD_Cliente.Text = dt.Rows[0]["D_Cliente"].ToString();
                                txtK_Cliente.Text = dt.Rows[0]["K_Cliente"].ToString();
                                txtNo_Tarjeta.Text = "";
                                if ((Convert.ToInt32(dt.Rows[0]["DiasCredito"].ToString()) > 0) && (Convert.ToDecimal(dt.Rows[0]["LimiteCredito"].ToString()) > 0))
                                    B_Credito = true;
                                else
                                    B_Credito = false;
                            }
                            else
                            {
                                txtD_Cliente.Text = string.Empty;
                                txtK_Cliente.Text = string.Empty;
                                txtNo_Tarjeta.Text = string.Empty;
                                B_Credito = false;
                            }
                        }
                        else
                        {
                            txtD_Cliente.Text = string.Empty;
                            txtK_Cliente.Text = string.Empty;
                            txtNo_Tarjeta.Text = string.Empty;
                            B_Credito = false;
                        }
                    }
                    else
                    {
                        DataTable dt = sqlCatalogos.Sk_Clientes_All(0, string.Empty, GlobalVar.K_Empresa);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                txtD_Cliente.Text = dt.Rows[0]["D_Cliente"].ToString();
                                txtK_Cliente.Text = dt.Rows[0]["K_Cliente"].ToString();
                                txtNo_Tarjeta.Text = "";
                                if ((Convert.ToInt32(dt.Rows[0]["DiasCredito"].ToString()) > 0) && (Convert.ToDecimal(dt.Rows[0]["LimiteCredito"].ToString()) > 0))
                                    B_Credito = true;
                                else
                                    B_Credito = false;
                            }
                            else
                            {
                                txtD_Cliente.Text = string.Empty;
                                txtK_Cliente.Text = string.Empty;
                                txtNo_Tarjeta.Text = string.Empty;
                                B_Credito = false;
                            }
                        }
                        else
                        {
                            txtD_Cliente.Text = string.Empty;
                            txtK_Cliente.Text = string.Empty;
                            txtNo_Tarjeta.Text = string.Empty;
                            B_Credito = false;
                        }
                    }
                    Cursor = Cursors.Default;
                }
                
            }
        }

        private void txtD_Cliente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab))
            {
                if(txtD_Cliente.Text.Trim().Length>0)
                {
                    Cursor = Cursors.WaitCursor;
                    Int32 valor = 0;
                    if ((Forma.IsNumeric(txtD_Cliente.Text)) && (Int32.TryParse(txtD_Cliente.Text.Trim(), out valor)))
                    {
                        DataTable dt = sqlCatalogos.Sk_Clientes_All(Convert.ToInt32(txtD_Cliente.Text.Trim()), string.Empty, GlobalVar.K_Empresa);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                txtD_Cliente.Text = dt.Rows[0]["D_Cliente"].ToString();
                                txtK_Cliente.Text = dt.Rows[0]["K_Cliente"].ToString();
                                txtNo_Tarjeta.Text = "";
                                if ((Convert.ToInt32(dt.Rows[0]["DiasCredito"].ToString()) > 0) && (Convert.ToDecimal(dt.Rows[0]["LimiteCredito"].ToString()) > 0))
                                    B_Credito = true;
                                else
                                    B_Credito = false;
                            }
                        }
                    }
                    else if (txtD_Cliente.Text.Trim().Length > 0)
                    {
                        DataTable dt = sqlCatalogos.Sk_Clientes_All(0, txtD_Cliente.Text.Trim(), GlobalVar.K_Empresa);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                txtD_Cliente.Text = dt.Rows[0]["D_Cliente"].ToString();
                                txtK_Cliente.Text = dt.Rows[0]["K_Cliente"].ToString();
                                txtNo_Tarjeta.Text = "";
                                if ((Convert.ToInt32(dt.Rows[0]["DiasCredito"].ToString()) > 0) && (Convert.ToDecimal(dt.Rows[0]["LimiteCredito"].ToString()) > 0))
                                    B_Credito = true;
                                else
                                    B_Credito = false;
                            }
                        }
                    }
                    else
                    {
                        DataTable dt = sqlCatalogos.Sk_Clientes_All(0, string.Empty, GlobalVar.K_Empresa);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                txtD_Cliente.Text = dt.Rows[0]["D_Cliente"].ToString();
                                txtK_Cliente.Text = dt.Rows[0]["K_Cliente"].ToString();
                                txtNo_Tarjeta.Text = "";
                                if ((Convert.ToInt32(dt.Rows[0]["DiasCredito"].ToString()) > 0) && (Convert.ToDecimal(dt.Rows[0]["LimiteCredito"].ToString()) > 0))
                                    B_Credito = true;
                                else
                                    B_Credito = false;
                            }
                        }
                    }
                    Cursor = Cursors.Default;
                }
                
            }
        }

        private void txtD_Medico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (grdArticulos.Rows.Count == 0)
            {
                MessageBox.Show("FALTA AGREGAR ARTICULOS A LA VENTA!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSKU.Focus();
                e.Handled = true;
            }

           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtD_Medico.Text.Trim().Length > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    DataTable dt = sqlCatalogos.Sk_Medicos(txtD_Medico.Text.Trim());
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            _K_Medico = Convert.ToInt32(dt.Rows[0]["K_Medico"].ToString());
                            txtK_Medico.Text = Convert.ToString(_K_Medico);
                            txtD_Medico.Text = dt.Rows[0]["D_Medico"].ToString();
                        }
                        else
                        {
                            _K_Medico = 0;
                            txtK_Medico.Text = string.Empty;
                            txtD_Medico.Text = string.Empty;
                        }
                    }
                    Cursor = Cursors.Default;
                }
            }
                    
        }

        private void txtD_Medico_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (grdArticulos.Rows.Count > 0)
            {
                if (e.KeyValue == Convert.ToChar(Keys.Tab))
                {
                    if (txtD_Medico.Text.Trim().Length > 0)
                    {
                        Cursor = Cursors.WaitCursor;
                        DataTable dt = sqlCatalogos.Sk_Medicos(txtD_Medico.Text.Trim());
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                _K_Medico = Convert.ToInt32(dt.Rows[0]["K_Medico"].ToString());
                                txtK_Medico.Text = Convert.ToString(_K_Medico);
                                txtD_Medico.Text = dt.Rows[0]["D_Medico"].ToString();
                            }
                            else
                            {
                                _K_Medico = 0;
                                txtK_Medico.Text = string.Empty;
                                txtD_Medico.Text = string.Empty;
                            }
                        }
                        Cursor = Cursors.Default;
                    }
                }
            }
           
        }

        private void grdArticulos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.TextChanged += new EventHandler(grdArticulos_TextChanged);
        }
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }
        }
        private void grdArticulos_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Trim().Length > 0)
            {
                Int32 valor = 0;

                if(!Int32.TryParse(textBox.Text.Trim(),out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = string.Empty;
                    textBox.Focus();
                }           
            }

        }

        private void grdArticulos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = grdArticulos.CurrentRow;

            if (e.ColumnIndex == 4) //cantidad
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    grdArticulos.CancelEdit();
                    return;
                }

                if (!EsNumero(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                {
                    grdArticulos.CancelEdit();
                    return;
                }
      
            }
        }
        private bool blnCeldaCantidad()
        {
            if (grdArticulos.CurrentCell == null)
                return false;
            //if (B_NoEntrar == false)
            //    return false;

            return (grdArticulos.CurrentCell.ColumnIndex == 4);
        }
        private void grdArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = grdArticulos.CurrentRow;
            if (ren != null)
            {
                if (blnCeldaCantidad())
                {
                    if (ren.Cells["Cantidad"].Value != null)
                    {
                        if (Convert.ToInt32(ren.Cells["Cantidad"].Value) == 0)
                        {
                            dtDatos.Rows[e.RowIndex].Delete();
                            dtDatos.AcceptChanges();

                            double sumatoria = 0;
                            //Método con el que recorreremos todas las filas de nuestro Datagridview
                            foreach (DataGridViewRow row in grdArticulos.Rows)
                            {
                                //Aquí seleccionaremos la columna que contiene los datos numericos.
                                sumatoria += Convert.ToDouble(row.Cells["Cantidad"].Value);
                            }
                            //Por ultimo asignamos el resultado a el texto de nuestro Label
                            LblCantidad.Text = Convert.ToString(sumatoria);

                            Mtd_Calcula_Totales();
                        }
                        else
                        {
                            CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);


                            double sumatoria = 0;
                            //Método con el que recorreremos todas las filas de nuestro Datagridview
                            foreach (DataGridViewRow row in grdArticulos.Rows)
                            {
                                //Aquí seleccionaremos la columna que contiene los datos numericos.
                                sumatoria += Convert.ToDouble(row.Cells["Cantidad"].Value);
                            }
                            //Por ultimo asignamos el resultado a el texto de nuestro Label
                            LblCantidad.Text = Convert.ToString(sumatoria);

                            Mtd_Calcula_Totales();
                        }
                    }
                    else
                    {
                        CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);


                        double sumatoria = 0;
                        //Método con el que recorreremos todas las filas de nuestro Datagridview
                        foreach (DataGridViewRow row in grdArticulos.Rows)
                        {
                            //Aquí seleccionaremos la columna que contiene los datos numericos.
                            sumatoria += Convert.ToDouble(row.Cells["Cantidad"].Value);
                        }
                        //Por ultimo asignamos el resultado a el texto de nuestro Label
                        LblCantidad.Text = Convert.ToString(sumatoria);

                        Mtd_Calcula_Totales();
                    }

                }
            }
        }

        private void btnReimpresion_Click(object sender, EventArgs e)
        {
            Frm_ReimpresionTicket frm = new Frm_ReimpresionTicket(K_AlmacenEnt);
            frm.ShowDialog();
        }

        private void Btn_Reimpresion_MouseEnter(object sender, EventArgs e)
        {
            Btn_Reimpresion.Cursor = Cursors.Hand;
        }

        private void CambiaCantidades(Int32 IndiceColumna, DataGridViewRow ren, Int32 IndiceRegistro)
        {
            if (!EsNumero(Convert.ToInt32(ren.Cells["Cantidad"].Value)))
            {
                MessageBox.Show("LA COLUMNA CANTIDAD SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdArticulos.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }
            decimal Precio = 0;
            Int32 Cantidad = 0;
            decimal Importe = 0;
            decimal Subtotal = 0;
            decimal Iva = 0;
            decimal Porcentaje = 0;

            if (ren.Cells["Cantidad"].Value != null)
                Cantidad = Convert.ToInt32(ren.Cells["Cantidad"].Value);
            if (ren.Cells["Precio"].Value != null)
                Precio = Math.Round(Convert.ToDecimal(ren.Cells["Precio"].Value), 2);
            if (ren.Cells["Porcentaje"].Value != null)
                Porcentaje = Math.Round(Convert.ToDecimal(ren.Cells["Porcentaje"].Value), 2);

            ren.Cells["Cantidad"].Value = Cantidad;
            ren.Cells["Precio"].Value = Precio;
            ren.Cells["Porcentaje"].Value = Porcentaje;

            Subtotal = Math.Round(Cantidad * Precio, 2);
            Iva = Math.Round(Subtotal * (Porcentaje / 100), 2);
            Importe = Math.Round(Subtotal+ Iva, 2);

            grdArticulos.Rows[IndiceRegistro].Cells["Subtotal"].Value = Subtotal;
            grdArticulos.Rows[IndiceRegistro].Cells["Iva"].Value = Iva;
            grdArticulos.Rows[IndiceRegistro].Cells["Total"].Value = Importe;

            //Calcula();
        }
        private void ValidaCajaChica()
        {
            Frm_RegistraCajaChica frm = new Frm_RegistraCajaChica();
            frm.K_Almacen = K_AlmacenEnt;
            frm.D_Almacen = LblAlmacen.Text;
            frm.Show();
        }
        public void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
        {
            int KArticuloSeleccionado = 0;
            KArticuloSeleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Articulo"].Value);

            var rows = dtDatos.Rows.Cast<DataRow>().Where(r => r["K_Articulo"].ToString() == KArticuloSeleccionado.ToString()).ToList();

            foreach (var row in rows)
            {

                dtDatos.Rows.Remove(row);

            }
            grdArticulos.DataSource = dtDatos;

            var rowsx = grdDetalleLotes.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["cK_Articulo"].Value.ToString() == KArticuloSeleccionado.ToString()).ToList();

            foreach (var row in rowsx)
            {

                grdDetalleLotes.Rows.Remove(row);

            }
            Mtd_Calcula_Totales();

        }
        #endregion
    }
}

