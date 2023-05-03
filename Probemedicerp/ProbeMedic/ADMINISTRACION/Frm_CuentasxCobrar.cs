using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.CUENTASXCOBRAR
{
    public partial class Frm_CuentasxCobrar : FormaBase
    {
        CultureInfo daDK = CultureInfo.CreateSpecificCulture("es-MX");
        SQLCuentasxCobrar sql_cxc = new SQLCuentasxCobrar();

        DataTable dtFacturas_PendientesPago = new DataTable();
        DataTable dtDatos = new DataTable();

        DataTable dtFacturas_PendientesPagoAll = new DataTable();
        DataTable dtFacturas_a_Pagar = new DataTable();

        String strKeyPress = "";
  
        bool B_NoEntrar = false;
        bool blnSeleccionGrid = false;

        int intK_Liquidacion_CXC = 0;
        int intK_Cliente = 0;
        int intK_BancoCliente = 0;

        int res = 0;
        string msg = string.Empty;

        public Frm_CuentasxCobrar()
        {
            InitializeComponent();
         
            dtFacturas_a_Pagar.Columns.Add("K_FacturaPagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("K_Tipo_PagoPagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("Total_FacturaPagar", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("Monto_PagoPagar", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("Monto_PagoPagarCheque", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("Monto_PagoPagarTarjeta", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("Monto_PagoPagarTransferencia", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("EfectivoPagar", (typeof(bool)));
            dtFacturas_a_Pagar.Columns.Add("ChequePagar", (typeof(bool)));
            dtFacturas_a_Pagar.Columns.Add("TransferenciaPagar", (typeof(bool)));
            dtFacturas_a_Pagar.Columns.Add("TarjetaPagar", (typeof(bool)));
            dtFacturas_a_Pagar.Columns.Add("K_Banco_TarjetaPagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("No_Tarjeta_Credito", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("No_Tarjeta_Debito", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("Aprobacion", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("No_Operacion", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("No_Cheque", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("K_Banco_ChequePagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("Cuenta_Cheque", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("No_Transferencia", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("Cuenta_Transferencia", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("K_Banco_TransferenciaPagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("Referencia_TransferenciaPagar", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("K_AlmacenPagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("D_AlmacenPagar", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("DescuentoPagar", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("SubTotalPagar", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("Total_IvaPagar", (typeof(decimal)));
            dtFacturas_a_Pagar.Columns.Add("K_ClientePagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("D_ClientePagar", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("K_OficinaPagar", (typeof(Int32)));
            dtFacturas_a_Pagar.Columns.Add("D_OficinaPagar", (typeof(string)));
            dtFacturas_a_Pagar.Columns.Add("SeriePagar", (typeof(string)));
            ucOficinas1.K_Empresa = GlobalVar.K_Empresa;
        }
        private void txtClaveCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text.Trim().Length > 0)
            {
                pnlCuentas.Enabled = true;
                pnlCheckFormasPago.Enabled = true;
                pnlFormasPago.Enabled = true;
            }

            else
            {
                pnlCuentas.Enabled = false;
                pnlCheckFormasPago.Enabled = false;
                pnlFormasPago.Enabled = false;
            }

        }
      
        public override void BaseMetodoInicio()
        {
            BaseBotonGuardar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso1.Text = "Guardar";
            BaseBotonProceso1.Visible = false;
     
            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnCancelar.Image.png"]));
            BaseBotonProceso2.Text = "Cancelar";
            BaseBotonProceso2.Visible = false;

            grdDatos.AutoGenerateColumns = false;
            grdFacturasPagar.AutoGenerateColumns = false;
            grdFacturasLista.AutoGenerateColumns = false;

            DataTable dtBancosCh = sqlCatalogos.Sk_Bancos();
            if (dtBancosCh != null)
            {
                LlenaCombo(dtBancosCh, ref cmbChequeBanco, "K_Banco", "D_Banco", 0);
                cmbChequeBanco.SelectedIndex = 0;
            }

            DataTable dtBancosT = sqlCatalogos.Sk_Bancos();
            if (dtBancosT != null)
            {
                LlenaCombo(dtBancosT, ref cmbTransferenciaBanco, "K_Banco", "D_Banco", 0);
                cmbTransferenciaBanco.SelectedIndex = 0;
            }

            DataTable dtBancosTarjeta = sqlCatalogos.Sk_Bancos();
            if (dtBancosTarjeta != null)
            {
                LlenaCombo(dtBancosTarjeta, ref cmbTarjetaBanco, "K_Banco", "D_Banco", 0);
                cmbTarjetaBanco.SelectedIndex = 0;
            }
   
            txtK_Usuario.Text = GlobalVar.K_Usuario.ToString();
            txtD_Usuario.Text = GlobalVar.D_Usuario.ToString();

            txtK_Usuario2.Text = GlobalVar.K_Usuario.ToString();
            txtD_Usuario2.Text = GlobalVar.D_Usuario.ToString();

            pnlCuentas.Enabled = false;
            pnlCheckFormasPago.Enabled = false;
            pnlFormasPago.Enabled = false;

            rbEfectivo.Checked = true;

            BuscaLiquidacion();

            //=  FormStartPosition.CenterScreen;
            WindowState= FormWindowState.Normal;

            dtpF_Aplicacion.Value = DateTime.Now;
     
        }
        public override void BaseBotonBuscarClick()
        {
            //if (ucOficinas1.K_Oficina == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UNA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ucOficinas1.Focus();
            //    return;
            //}
            if (txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return;
            }
            MostrarDatos();
                
        }
        public override void BaseBotonProceso1Click()
        {
            if (!BaseFuncionValidaciones())
                return;

            int CampoIdentity = 0;
            res = 0;
            msg = string.Empty;
            short K_Tipo_Pago = 0;

            if (rbEfectivo.Checked)
                K_Tipo_Pago = 1;
            if (rbCheque.Checked)
                K_Tipo_Pago = 2;
            if (rbTransferencia.Checked)
                K_Tipo_Pago = 3;
            if (rbTarjeta.Checked)
                K_Tipo_Pago = 5;
            if (rbAnticipo.Checked)
                K_Tipo_Pago = 4;

            decimal Importe = 0;
            decimal Importe_Cheque = 0;
            decimal Importe_Transferencia = 0;
            decimal Importe_Tarjeta = 0;
            decimal Importe_Anticipo = 0;

            if (rbEfectivo.Checked)
            {
                Importe = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda.Moneda));
            }
            if (rbCheque.Checked)
            {
                Importe_Cheque = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda2.Moneda));
            }
            if (rbTransferencia.Checked)
            {
                Importe_Transferencia = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda3.Moneda));
            }
            if (rbTarjeta.Checked)
            {
                Importe_Tarjeta= Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda4.Moneda));
            }
            if (rbAnticipo.Checked)
            { 
                Importe_Anticipo = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda5.Moneda));
            }

            grdDatos.EndEdit();

            DataTable dtGrid = (DataTable)grdDatos.DataSource;
            DataTable dtDetalle = DetallePagoCXCType;

             foreach (DataRow row in dtGrid.Rows)
             {
                  if (Convert.ToDecimal(row["Aplicado"]) != 0)
                  {
                        DataRow ren = dtDetalle.NewRow();
                        ren["K_Factura"] = row["K_Factura"].ToString();
                        ren["Serie"] = row["D_Serie"].ToString();
                        ren["K_Tipo_Pago"] = K_Tipo_Pago;
                        ren["Total_Factura"] = row["Total_Factura"].ToString();
                        ren["Monto_Pago"] = row["Aplicado"].ToString();
                        ren["K_Banco_Tarjeta"] = K_Tipo_Pago == 5 ? Convert.ToInt32(cmbTarjetaBanco.SelectedValue.ToString()) : 0;
                        ren["No_Tarjeta_Credito"] = K_Tipo_Pago == 5 && Cbx_Tarjeta_Credito.Checked == true ? txtNumTarjeta.Text.Trim().Replace(" ","") : DBNull.Value.ToString();
                        ren["No_Tarjeta_Debito"] = K_Tipo_Pago == 5 && Cbx_Tarjeta_Credito.Checked == false ? txtNumTarjeta.Text.Trim().Replace(" ", "") : DBNull.Value.ToString();
                        ren["Aprobacion"] = K_Tipo_Pago == 5 ? txtAprobacion.Text.Trim() : DBNull.Value.ToString();
                        ren["No_Operacion"] = K_Tipo_Pago == 5 ? txtNumOperacion.Text.Trim() : DBNull.Value.ToString();
                        ren["No_Cheque"] = K_Tipo_Pago == 2 ? txtChequeNoCheque.Text.Trim() : DBNull.Value.ToString();
                        ren["K_Banco_Cheque"] = K_Tipo_Pago == 2 ? Convert.ToInt32(cmbChequeBanco.SelectedValue.ToString()) : 0;
                        ren["Cuenta_Cheque"] = K_Tipo_Pago == 2 ? txtChequeCuenta.Text.Trim() : DBNull.Value.ToString();
                        ren["No_Transferencia"] = K_Tipo_Pago == 3? txtTransferenciaNoTransferencia.Text.Trim() : DBNull.Value.ToString();
                        ren["Cuenta_Transferencia"] = K_Tipo_Pago == 3 ? txtTransferenciaCuenta.Text.Trim() : DBNull.Value.ToString();
                        ren["K_Banco_Transferencia"] = K_Tipo_Pago == 3 ? Convert.ToInt32(cmbTransferenciaBanco.SelectedValue.ToString()) : 0;
                        ren["Referencia_Transferencia"] = K_Tipo_Pago == 3 ? txtTransferenciaReferencia.Text.Trim() : DBNull.Value.ToString();
                        ren["K_Anticipo"] = K_Tipo_Pago == 4 ? Convert.ToInt32(txtK_Anticipo.Text.Trim()) : 0;
                        dtDetalle.Rows.Add(ren);
                  } 
             }
            Cursor = Cursors.WaitCursor;
             Int32 Folio = 0;
             res = sql_cxc.Gp_Pagos_Factura(ref Folio, GlobalVar.K_Oficina, GlobalVar.K_Usuario,intK_Cliente,dtDetalle,intK_Liquidacion_CXC, txtClaveCuentaOrigen.Text.Trim().Length>0 ? Convert.ToInt32(txtClaveCuentaOrigen.Text):0, 
                                            Convert.ToInt32(txtClaveCuentaDeposito.Text), GlobalVar.PC_Name,dtpF_Aplicacion.Value,ref msg);
             if (res == -1)
             {
                 BaseErrorResultado = true;
                 MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
             }
             else
             {
                BaseErrorResultado = false;
                MessageBox.Show("EL PAGO FUE APLICADO CORRECTAMENTE. \r\n" +
                    "No. Operación Interna: " + Folio.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            Cursor = Cursors.Default;
            BaseMetodoInicio();
            BaseBotonProceso2Click();
        }
        public override void BaseBotonProceso2Click()
        {   
            BaseMetodoLimpiaControles();
            LimpiaControlesFormaPago();
            BaseMetodoInicio();
        }
        public override void BaseMetodoLimpiaControles()
        {     
            txtClaveCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            ucOficinas1.K_Oficina = 0;
            ucOficinas1.txt_E_Oficina.Text = string.Empty;
            txtLiquidacion.Text = string.Empty;
            intK_Liquidacion_CXC = 0;
            txtTotalAPagar.Text = string.Empty;
            txtResta.Text = string.Empty;

            dtDatos = null;
            grdDatos.DataSource = null;
        }
        private void LimpiaControlesFormaPago()
        {
            txtPagoTotalTipoMoneda.Moneda.Text = "0.00";

            cmbTransferenciaBanco.SelectedIndex = -1;
            txtTransferenciaCuenta.Text = string.Empty;
            txtTransferenciaNoTransferencia.Text = string.Empty;
            txtTransferenciaReferencia.Text = string.Empty;
            txtPagoTotalTipoMoneda2.Moneda.Text = "0.00";

            cmbChequeBanco.SelectedIndex = -1;
            txtChequeCuenta.Text = string.Empty;
            txtChequeNoCheque.Text = string.Empty;
            txtPagoTotalTipoMoneda3.Moneda.Text = "0.00";

            cmbTarjetaBanco.SelectedIndex = -1;
            Cbx_Tarjeta_Credito.Checked = false;
            txtNumTarjeta.Text = string.Empty;
            txtAprobacion.Text = string.Empty;
            txtNumOperacion.Text = string.Empty;
            txtPagoTotalTipoMoneda4.Moneda.Text = "0.00";

            txtK_Anticipo.Text = string.Empty;
            txtPagoTotalTipoMoneda5.Moneda.Text = "0.00";

            txtTotalAPagar.Text = "$0.00";
            txtResta.Text = "$0.00";

            txtClaveCuentaOrigen.Text = string.Empty;
            txtCuentaOrigen.Text = string.Empty;
            txtCuentaCompletaCliente.Text = string.Empty;

            txtClaveCuentaDeposito.Text = string.Empty;
            txtCuentaDeposito.Text = string.Empty;

            dtDatos = null;
            grdDatos.DataSource = null;

        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (Convert.ToDecimal(TxtImporteToDec(txtTotalAPagar)) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA CUENTA POR PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDatos.Focus();
                return false;
            }

            decimal Resta = 0;
            if (txtResta.Text.Trim().Length > 0)
                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$", "")));

            if (Resta > 0)
            {
                MessageBox.Show("AUN TIENE SALDO DISPONIBLE PARA APLICAR A ALGUNA CUENTA POR PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //if (txtClaveCuentaOrigen.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE ORIGEN DEL CLIENTE\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA ANTES CREARLA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btnBuscaCuentaOrigen.Focus();
            //    return false;
            //}
            if (txtClaveCuentaDeposito.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE DEPOSITO DE LA EMPRESA\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA ANTES CREARLA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCuentaDeposito.Focus();
                return false;
            }          
            BaseErrorResultado = false;
            return true;
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                pnlEfectivo.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = true;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = false;
                pnlAnticipo.Visible = false;
                LimpiaControlesFormaPago();
                MostrarDatos();
            }
        }
        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheque.Checked)
            {
                pnlCheque.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = true;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = false;
                pnlAnticipo.Visible = false;
                LimpiaControlesFormaPago();
                MostrarDatos();
                LlenarInformacionBancos(intK_BancoCliente, txtClaveCuentaOrigen.Text);          
                cmbChequeBanco.Focus();
            }
        }
        private void rbTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransferencia.Checked)
            {
                pnlTransferencia.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = true;
                pnlIncobrable.Visible = false;
                pnlAnticipo.Visible = false;
                LimpiaControlesFormaPago();
                MostrarDatos();
                LlenarInformacionBancos(intK_BancoCliente, txtClaveCuentaOrigen.Text);
                cmbTransferenciaBanco.Focus();
            }
        }
        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            pnlIncobrable.Dock = DockStyle.Fill;
            pnlEfectivo.Visible = false;
            pnlCheque.Visible = false;
            pnlTransferencia.Visible = false;
            pnlIncobrable.Visible = true;
            pnlAnticipo.Visible = false;
            LimpiaControlesFormaPago();
            MostrarDatos();
            LlenarInformacionBancos(intK_BancoCliente, txtClaveCuentaOrigen.Text);
            cmbTarjetaBanco.Focus();
        }
        private void rbAnticipo_CheckedChanged(object sender, EventArgs e)
        {
            pnlAnticipo.Dock = DockStyle.Fill;
            pnlEfectivo.Visible = false;
            pnlCheque.Visible = false;
            pnlTransferencia.Visible = false;
            pnlIncobrable.Visible = false;
            pnlAnticipo.Visible = true;
            LimpiaControlesFormaPago();
            MostrarDatos();
            BtnAnticipo.Focus();
        }
        private void BtnAnticipo_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveCliente.Focus();
                return;
            }
            FRM_MUESTRA_ANTICIPOS_CLIENTE frm_x_anticipos = new FRM_MUESTRA_ANTICIPOS_CLIENTE();
            frm_x_anticipos.K_Cliente = Convert.ToInt32(txtClaveCliente.Text);
            frm_x_anticipos.LlenaDatos();
            frm_x_anticipos.ShowDialog();

            if (frm_x_anticipos.K_Anticipo > 0)
            {
                txtK_Anticipo.Text = frm_x_anticipos.K_Anticipo.ToString();
                txtResta.Text = Convert.ToString(frm_x_anticipos.Monto);
                txtPagoTotalTipoMoneda5.Text = Convert.ToString(frm_x_anticipos.Monto);
            }
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente frm = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);          
            frm.ShowDialog();

            if (frm.K_Cliente_Seleccionado== 0)
            {
                intK_Cliente = 0;
                txtClaveCliente.Text = string.Empty;
                txtCliente.Text = string.Empty;
            }
            else
            {
                intK_Cliente = frm.K_Cliente_Seleccionado;
                txtClaveCliente.Text = Convert.ToString(frm.K_Cliente_Seleccionado);
                txtCliente.Text = frm.D_Cliente_Seleccionado;
            }


        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdDatos.EndEdit();
            if (grdDatos.CurrentRow!=null)
            {         
                if (e.ColumnIndex == 0)
                {
                    if (Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda.Moneda)) == 0 && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda2.Moneda)) == 0
                        && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda3.Moneda)) == 0 && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda4.Moneda)) == 0
                        && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda5.Moneda)) == 0)
                    {
                        MessageBox.Show("DEBE INDICAR EL MONTO A PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPagoTotalTipoMoneda.Focus();
                        DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdDatos.Rows[e.RowIndex].Cells[0];
                        chkCelda.Value = false;
                        return;
                    }

                     if (e.ColumnIndex == this.grdDatos.Columns[0].Index)
                     {
                         DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdDatos.Rows[e.RowIndex].Cells[0];
                         if (Convert.ToBoolean(chkCelda.Value) == true)
                         {
                            decimal Importe = 0;
                            Importe = Convert.ToDecimal(grdDatos.CurrentRow.Cells["Monto_Total_Pendiente"].Value);

                            decimal Resta = 0;
                            if (txtResta.Text.Replace("$", "").Trim().Length > 0)
                                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$", "")));

                            if (Importe <= Resta)
                            {
                                grdDatos.Rows[e.RowIndex].Selected = true;
                                decimal TotalPagar = txtTotalAPagar.Text.Trim().Length > 0 ? Convert.ToDecimal(txtTotalAPagar.Text.Replace("$", "").Trim()) : 0;
                                txtTotalAPagar.Text = Convert.ToString((TotalPagar + Importe));
                                txtTotalAPagar.Text = TxtImporteToStr(ref txtTotalAPagar);
                                decimal TotalResta = txtResta.Text.Trim().Length > 0 ? Convert.ToDecimal(txtResta.Text.Replace("$", "").Trim()) : 0;
                                txtResta.Text = Convert.ToString(TotalResta - Importe);
                                txtResta.Text = TxtImporteToStr(ref txtResta);
                                grdDatos.CurrentRow.Cells["Aplicado"].Value = Importe;
                            }
                            else
                            {
                                if (Resta == 0)
                                {
                                    MessageBox.Show("NO CUENTA SON SALDO SUFICIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                grdDatos.Rows[e.RowIndex].Selected = true;
                                txtTotalAPagar.Text = Convert.ToString(Convert.ToDecimal(TxtImporteToDec(txtTotalAPagar)) + Resta);
                                txtResta.Text = Convert.ToString(Convert.ToDecimal(TxtImporteToDec(txtResta)) - Resta);
                                grdDatos.CurrentRow.Cells["Aplicado"].Value = Resta;
                            }                          
                         }
                         else
                         {
                            grdDatos.Rows[e.RowIndex].Selected = false;
                            decimal TotalPagar = txtTotalAPagar.Text.Trim().Length > 0 ? Convert.ToDecimal(txtTotalAPagar.Text.Replace("$", "").Trim()) : 0;
                            txtTotalAPagar.Text = Convert.ToString(TotalPagar - Convert.ToDecimal(grdDatos.CurrentRow.Cells["Aplicado"].Value));
                            txtTotalAPagar.Text = TxtImporteToStr(ref txtTotalAPagar);
                            decimal TotalResta = txtResta.Text.Trim().Length > 0 ? Convert.ToDecimal(txtResta.Text.Replace("$", "").Trim()) : 0;
                            txtResta.Text = Convert.ToString(TotalResta + Convert.ToDecimal(grdDatos.CurrentRow.Cells["Aplicado"].Value));
                            txtResta.Text = TxtImporteToStr(ref txtResta);
                            grdDatos.CurrentRow.Cells["Aplicado"].Value = 0;
                        }
                     }
                }                
            }
            grdDatos.EndEdit();
        }
       
        private void BuscaLiquidacion()
        {
            DataTable dtLiquidacion = sql_cxc.Gp_Consulta_LiqCXC(GlobalVar.K_Oficina, GlobalVar.K_Usuario);

            if (dtLiquidacion != null)
            {
                DataRow row = dtLiquidacion.Rows[0];

                intK_Liquidacion_CXC = Convert.ToInt32(row["K_Liquidacion_CXC"].ToString());
                if (intK_Liquidacion_CXC > 0)
                {
                    txtLiquidacion.Text = intK_Liquidacion_CXC.ToString();
                    txtLiquidacion2.Text = intK_Liquidacion_CXC.ToString();
                }                  
                else
                {
                    txtLiquidacion.Text = string.Empty;
                    txtLiquidacion2.Text = string.Empty;
                }
                    
            }
        }
        private bool Calculos()
        {
            bool res = false;
            decimal Importe = 0;
            decimal Resta = 0;

            if (rbEfectivo.Checked)
            {
                Importe = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda.Moneda));
            }
            if (rbCheque.Checked)
            {
                Importe = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda3.Moneda));
            }
            if (rbTransferencia.Checked)
            {
                Importe = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda2.Moneda));
            }
            if (rbTarjeta.Checked)
            {
                Importe = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda4.Moneda));
            }
            if (rbAnticipo.Checked)
            {
                Importe = Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda5.Moneda));
            }
 
            //ciclo para sumar los saldos aplicados
            decimal sdos = 0;
            DataTable dtSuma = (DataTable)grdDatos.DataSource;
            if (dtSuma != null)
            {
                var Saldos = dtSuma.AsEnumerable().Sum(p => p.Field<decimal>("Aplicado"));
                sdos = decimal.Round(Convert.ToDecimal(Saldos), 2);
            }

            Resta = Importe - sdos;
            txtTotalAPagar.Text = sdos.ToString("C2");
            txtResta.Text = Resta.ToString("C2");

            return res;
        }
        private void LlenarInformacionBancos(Int32 K_Banco, string Cuenta)
        {

            if (rbTransferencia.Checked)
            {
                cmbTransferenciaBanco.SelectedValue = K_Banco;
                //txtTransferenciaCuenta.Text = txtCuentaOrigen.Text;
            }
            if (rbCheque.Checked)
            {
                cmbChequeBanco.SelectedValue = K_Banco;
                //txtChequeCuenta.Text = txtCuentaOrigen.Text;
            }
            if (rbTarjeta.Checked)
            {
                cmbTarjetaBanco.SelectedValue = K_Banco;
              //  txtNumTarjeta.Text = Cuenta;
            }

        }
        private void MostrarDatos()
        {
            if(/*(ucOficinas1.K_Oficina>0)&&*/(intK_Cliente>0))
            {
                grdDatos.DataSource = null;

                dtDatos = sql_cxc.Sk_Facturas_PendientesPago(ucOficinas1.K_Oficina, intK_Cliente, GlobalVar.K_Empresa);

                if (dtDatos != null)
                {
                    dtDatos.Columns.Add("Aplicado", (typeof(decimal)));
                    dtDatos.Columns.Add("Pago", (typeof(bool)));

                    foreach (DataRow dt in dtDatos.Rows)
                    {
                        dt["Pago"] = false;
                        dt["Aplicado"] = 0.00;
                    }
                    dtDatos.AcceptChanges();

                    grdDatos.DataSource = dtDatos;

                    BaseDtDatos = dtDatos;

                    if (grdDatos.Rows.Count > 0)
                    {
                        grdDatos.Rows[0].Cells["Aplicado"].Selected = true;
                        grdDatos.Focus();
                        B_NoEntrar = true;
                        pnlFormasPago.Enabled = true;
                        groupBox1.Enabled = true;
                        BaseBotonProceso1.Visible = true;
                        BaseBotonProceso1.Enabled = true;
                        BaseBotonProceso2.Visible = true;
                        BaseBotonProceso2.Enabled = true;
                    }
                    else
                    {
                        BaseBotonProceso1.Visible = false;
                        BaseBotonProceso1.Enabled = false;
                        BaseBotonProceso2.Visible = false;
                        BaseBotonProceso2.Enabled = false;
                        pnlFormasPago.Enabled = false;
                        groupBox1.Enabled = false;
                    }
                    txtPagoTotalTipoMoneda.Focus();

                }
                else
                {
                    MessageBox.Show("NO EXISTEN FACTURAS PENDIENTES CON LOS PARAMETROS INGRESADOS!... ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiaControlesFormaPago();
                    txtTotalAPagar.Text = string.Empty;
                    txtResta.Text = string.Empty;
                    BaseBotonProceso1.Visible = false;
                    BaseBotonProceso1.Enabled = false;
                    BaseBotonProceso2.Visible = false;
                    BaseBotonProceso2.Enabled = false;
                    pnlFormasPago.Enabled = false;
                    groupBox1.Enabled = false;

                }
            }
           
        }
        private string TxtImporteToStr(TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(txtImporte));
            if (dblImporte == 0)
            {
                return "";
            }
            else
            {
                return dblImporte.ToString("C2");
            }
        }
        private string TxtImporteToDec(TextBox txtImporte)
        {
            if (txtImporte.Text.Trim().Length == 0)
            {
                return "0";
            }
            else
            {
                return txtImporte.Text.Replace("$", "").Replace(",", "");
            }
        }
        //private void ObtieneImporteTotalPagar(bool bolTipoPago)
        //{ // PESOS:    bolTipoPago = false
        //  // DOLARES:  bolTipoPago = true
        //    double ValorCalculado = 0;
        //    double ImportePagoObtenido = 0;
        //    //string TipoCambio = string.Empty;
        //    int TipoCambio = 1;
        //    string toConvert = string.Empty;
        //    //dtTipoCambio = sqlCatalogos.Sk_Tipo_Cambio();
        //    int TipoPagoSeleccionado = 0;

        //    if (rbEfectivo.Checked)
        //    {
        //        TipoPagoSeleccionado = 1;
        //    }

        //    if (rbCheque.Checked)
        //    {
        //        TipoPagoSeleccionado = 2;
        //    }

        //    if (rbTransferencia.Checked)
        //    {
        //        TipoPagoSeleccionado = 3;
        //    }

        //    if (rbAnticipo.Checked)
        //    {
        //        TipoPagoSeleccionado = 4;
        //    }    
            
        //    if (rbTarjeta.Checked)
        //        TipoPagoSeleccionado = 5;

        //    // PAGO en PESOS
        //    if (bolTipoPago == false)
        //    {
        //        if (TipoPagoSeleccionado == 1)  // Tipo de Pago Seleccionado:  EFECTIVO
        //        {
        //            lblTotalPagoPesos.Text = "Total a Pagar en Pesos";
        //            txtPagoTotalTipoMoneda.Text = "";

        //            toConvert = (txtEfectivoImporte.Text).Replace(",", "");
        //            toConvert = (toConvert).Replace("$", "");
        //            txtEfectivoImporte.Text = toConvert.ToString();
        //            if (txtEfectivoImporte.Text != "")
        //            {
        //                ImportePagoObtenido = Convert.ToDouble(txtEfectivoImporte.Text.ToString());
        //                if (Convert.ToDouble(txtEfectivoImporte.Text) > 0)
        //                {
        //                    ValorCalculado = Convert.ToDouble(txtEfectivoImporte.Text) * Convert.ToDouble(TipoCambio);
        //                    txtPagoTotalTipoMoneda.Text = ValorCalculado.ToString("C");
        //                    txtEfectivoImporte.Text = ImportePagoObtenido.ToString("C");
        //                }
        //            }
        //        }
        //        if (TipoPagoSeleccionado == 2)  // Tipo de Pago Seleccionado:  CHEQUE
        //        {
        //            lblTotalPagoPesos3.Text = "Total a Pagar en Pesos";
        //            txtPagoTotalTipoMoneda3.Text = "";

        //            toConvert = (txtChequeImporte.Text).Replace(",", "");
        //            toConvert = (toConvert).Replace("$", "");
        //            txtChequeImporte.Text = toConvert.ToString();
        //            if (txtChequeImporte.Text != "")
        //            {
        //                ImportePagoObtenido = Convert.ToDouble(txtChequeImporte.Text.ToString());
        //                if (Convert.ToDouble(txtChequeImporte.Text) > 0)
        //                {
        //                    ValorCalculado = Convert.ToDouble(txtChequeImporte.Text) * Convert.ToDouble(TipoCambio);
        //                    txtPagoTotalTipoMoneda3.Text = ValorCalculado.ToString("C");
        //                    txtChequeImporte.Text = ImportePagoObtenido.ToString("C");
        //                }
        //            }
        //        }
        //        if (TipoPagoSeleccionado == 3)  // Tipo de Pago Seleccionado:  TRANSFERENCIA
        //        {
        //            lblTotalPagoPesos2.Text = "Total a Pagar en Pesos";

        //            txtPagoTotalTipoMoneda2.Text = "";

        //            toConvert = (txtTransferenciaImporte.Text).Replace(",", "");
        //            toConvert = (toConvert).Replace("$", "");
        //            txtTransferenciaImporte.Text = toConvert.ToString();
        //            if (txtTransferenciaImporte.Text != "")
        //            {
        //                ImportePagoObtenido = Convert.ToDouble(txtTransferenciaImporte.Text.ToString());
        //                if (Convert.ToDouble(txtTransferenciaImporte.Text) > 0)
        //                {
        //                    ValorCalculado = Convert.ToDouble(txtTransferenciaImporte.Text) * Convert.ToDouble(TipoCambio);
        //                    txtPagoTotalTipoMoneda2.Text = ValorCalculado.ToString("C");
        //                    txtTransferenciaImporte.Text = ImportePagoObtenido.ToString("C");
        //                }
        //            }
        //        }
        //        if (TipoPagoSeleccionado == 5)  // Tipo de Pago Seleccionado: TARJETA
        //        {
        //            lblTotalPagoPesos2.Text = "Total a Pagar en Pesos";

        //            txtPagoTotalTipoMoneda2.Text = "";

        //            toConvert = (txtTarjetaImporte.Text).Replace(",", "");
        //            toConvert = (toConvert).Replace("$", "");
        //            txtTarjetaImporte.Text = toConvert.ToString();
        //            if (txtTarjetaImporte.Text != "")
        //            {
        //                ImportePagoObtenido = Convert.ToDouble(txtTarjetaImporte.Text.ToString());
        //                if (Convert.ToDouble(txtTarjetaImporte.Text) > 0)
        //                {
        //                    ValorCalculado = Convert.ToDouble(txtTarjetaImporte.Text) * Convert.ToDouble(TipoCambio);
        //                    txtPagoTotalTipoMoneda4.Text = ValorCalculado.ToString("C");
        //                    txtTarjetaImporte.Text = ImportePagoObtenido.ToString("C");
        //                }
        //            }
        //        }
        //    }
        //}

        private void SeleccionaCxPGrid(int NoRenglon)
        {
            grdDatos.EndEdit();

            decimal Resta = 0;
            if (txtResta.Text.Trim().Length > 0)
                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$", "")));

            decimal Saldo = 0;
            if (grdDatos.Rows[NoRenglon].Cells["Monto_Total_Pendiente"].Value != null)
                Saldo = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Monto_Total_Pendiente"].Value);

            decimal SaldoAplicado = 0;
            if (grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value != null)
                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value);

            DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[NoRenglon].Cells["Pago"];
            if (Convert.ToBoolean(checkCell.Value) == true)
            {
                if (Resta == 0 && SaldoAplicado == 0)
                {
                    MessageBox.Show("DEBE CAPTURAR EL IMPORTE A PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkCell.Value = false;
                    return;
                }
                if (Resta > 0 && SaldoAplicado == 0)
                {
                    if (Resta < Saldo) //Abono
                    {
                        DialogResult dlg = MessageBox.Show("EL IMPORTE A PAGAR NO CUBRE EL SALDO PENDIENTE DE LA CXC\n" + "¿DESEA GENERAR UN ABONO PARA LA CXP?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlg == DialogResult.Yes)
                        {
                            grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value = Math.Abs(Resta);
                            if (grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value != null)
                                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value);
                            Resta = 0;
                        }
                        else
                        {
                            checkCell.Value = false;
                            grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = 0;
                            if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);

                        }
                    }
                    else //Pago completo y/o importe a pagar mayor
                    {
                        grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = Saldo;
                        if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                            SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);
                        Resta -= Saldo;
                    }
                }
            }
            else
            {
                grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = 0;
            }

    
        }
        private void SeleccionaCxPGridTotal(int NoRenglon, ref TextBox txtImporte)
        {
            grdDatos.EndEdit();
            decimal Resta = 0;
            if (txtResta.Text.Trim().Length > 0)
                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$", "")));

            decimal Saldo = 0;
            if (grdDatos.Rows[NoRenglon].Cells["Monto_Total_Pendiente"].Value != null)
                Saldo = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Monto_Total_Pendiente"].Value);

            decimal SaldoAplicado = 0;
            if (grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value != null)
                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value);

            DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[NoRenglon].Cells["Pago"];
            if (Convert.ToBoolean(checkCell.Value) == true)
            {
                txtImporte.Text = TxtImporteToDec(txtImporte);

                if (grdDatos.ReadOnly)
                    grdDatos.ReadOnly = true;
                grdDatos.Rows[NoRenglon].Cells["Aplicado"].ReadOnly = false;
                grdDatos.Columns["Aplicado"].ReadOnly = false;

                grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value = Saldo;
                if (grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value != null)

                    SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value);

                txtImporte.Text = Convert.ToDouble(Convert.ToDecimal(TxtImporteToDec(txtImporte)) + Saldo).ToString("C");

                Resta += Saldo;
            }
            else
            {
                grdDatos.Rows[NoRenglon].Cells["Aplicado"].Value = 0;

                txtImporte.Text = Convert.ToDouble(Convert.ToDecimal(TxtImporteToDec(txtImporte)) - Saldo).ToString("C");

                if (Convert.ToDecimal((TxtImporteToDec(txtImporte))) == 0)
                {
                    txtImporte.Text = "";
                }
                Resta -= Saldo;
       
            }


            Calculos();


        }
        private bool blnCeldaImportes()
        {
            if (grdDatos.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdDatos.CurrentCell.ColumnIndex == 5);
        }
        private void MtdCalculos()
        {
            decimal Resta = 0;
            //decimal Monto = Convert.ToDecimal(txtMonto.Text.Replace("$", "").Replace(",", ""));

            //ciclo para sumar los saldos aplicados
            decimal sdos = 0;
            DataTable dtSuma = (DataTable)grdDatos.DataSource;
            if (dtSuma != null)
            {
                var Saldos = dtSuma.AsEnumerable().Sum(p => p.Field<decimal>("Aplicado"));
                sdos = decimal.Round(Convert.ToDecimal(Saldos), 2);
            }

            //Resta = Monto - sdos;
            txtResta.Text = Resta.ToString("C");
        }
        private void CambiaCantidades(Int32 IndiceColumna, DataGridViewRow ren, Int32 IndiceRegistro)
        {
            if (!EsNumero(Convert.ToDecimal(ren.Cells["Aplicado"].Value)))
            {
                MessageBox.Show("LA COLUMNA PRECIO UNITARIO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDatos.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }

            Calculos();
        }
     
        private void txtTransferenciaCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtTransferenciaNoTransferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtAprobacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtNumOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtChequeCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtChequeNoCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EsNumero(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if(dtDatos!=null)
            {
                if(dtDatos.Rows.Count>0)
                {
                    if (txtFiltro.Text.Trim().Length > 0)
                    {
                        dtDatos.DefaultView.RowFilter = $"K_Factura = {txtFiltro.Text.Trim()}";
                    }
                    else
                    {
                        dtDatos.DefaultView.RowFilter = null;
                    }
                }
            }
        
        }
        private void btnBuscaCuentaOrigen_Click(object sender, EventArgs e)
        {
            DataTable dtCuentasCliente = sqlCatalogos.Sk_Cliente_Cuentas(Convert.ToInt32(txtClaveCliente.Text.Trim()));

            Busquedas.BuscaClientesCuentas frm = new Busquedas.BuscaClientesCuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentasCliente);
            frm.BusquedaPropiedadTablaFiltra = dtCuentasCliente;

            if(dtCuentasCliente!=null)
            {
                if(dtCuentasCliente.Rows.Count==1)
                {
                    txtClaveCuentaOrigen.Text = dtCuentasCliente.Rows[0]["K_Cuenta_Cliente"].ToString();
                    txtCuentaOrigen.Text = dtCuentasCliente.Rows[0]["Numero_Cuenta"].ToString();
                    intK_BancoCliente = Convert.ToInt32(dtCuentasCliente.Rows[0]["K_Banco"].ToString());
                    txtCuentaCompletaCliente.Text = dtCuentasCliente.Rows[0]["CuentaCompleta"].ToString();
                    LlenarInformacionBancos(intK_BancoCliente, dtCuentasCliente.Rows[0]["Numero_Cuenta"].ToString());

                }
                else if(dtCuentasCliente.Rows.Count>1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Cuentas de Clientes";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        txtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Cliente"].ToString();
                        txtCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["Numero_Cuenta"].ToString();
                        intK_BancoCliente = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Banco"].ToString());
                        txtCuentaCompletaCliente.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
                        LlenarInformacionBancos(intK_BancoCliente, frm.BusquedaPropiedadReglonRes["Numero_Cuenta"].ToString());
                    }
                }
            }

           
        }
        private void btnBuscaCuentaDeposito_Click(object sender, EventArgs e)
        {
            DataTable dtCuentas = sqlCatalogos.Sk_Empresa_Cuentas(GlobalVar.K_Empresa);

            Busquedas.BuscaEmpresa_Cuentas frm = new Busquedas.BuscaEmpresa_Cuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentas);
            frm.BusquedaPropiedadTablaFiltra = dtCuentas;
            frm.BusquedaPropiedadTitulo = "Busca Cuentas de la Empresa";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Empresa"].ToString();
                txtCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();

            }
        }

        private void cbxSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            //grdDatos.EndEdit();


            //if (cbxSeleccionarTodo.Checked == true)
            //    {
            //    foreach (DataGridViewRow row in grdDatos.Rows)
            //    {
            //        grdDatos.ReadOnly = false;
            //        grdDatos.Rows[row.Index].Cells["Pago"].ReadOnly = false;
            //        grdDatos.Columns["Pago"].ReadOnly = false;
            //        MessageBox.Show(row.Cells["Pago"].Value.ToString());
            //        if (Convert.ToBoolean(row.Cells["Pago"]) == false)
            //        {
            //            if (Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda)) == 0 && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda2)) == 0 && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda3)) == 0 && Convert.ToDecimal(TxtImporteToDec(txtPagoTotalTipoMoneda4)) == 0)
            //            {
            //                MessageBox.Show("DEBE INDICAR EL MONTO A PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //            else
            //            {

            //                //if (grdDatos.ReadOnly)
            //                grdDatos.ReadOnly = true;
            //                row.Cells["Pago"].ReadOnly = false;
            //                grdDatos.Columns["Pago"].ReadOnly = false;

                      

            //                decimal Importe = 0;
            //                Importe = Convert.ToDecimal(row.Cells["Monto_Total_Pendiente"].Value);

            //                decimal Resta = 0;
            //                if (txtResta.Text.Trim().Length > 0)
            //                    Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$", "")));

            //                if (Importe <= Resta)
            //                {
            //                    row.Cells["Pago"].Value = true;
            //                    //grdDatos.Rows[row].Selected = true;
            //                    txtTotalAPagar.Text = Convert.ToString(Convert.ToDecimal(TxtImporteToDec(txtTotalAPagar)) + Importe);
            //                    txtResta.Text = Convert.ToString(Convert.ToDecimal(TxtImporteToDec(txtResta)) - Importe);
            //                    row.Cells["Aplicado"].Value = Importe;
            //                }
            //                else
            //                {
            //                    if (Resta == 0)
            //                    {
            //                        return;
            //                    }
            //                    row.Cells["Pago"].Value = true;
            //                    //grdDatos.Rows[e.RowIndex].Selected = true;
            //                    txtTotalAPagar.Text = Convert.ToString(Convert.ToDecimal(TxtImporteToDec(txtTotalAPagar)) + Resta);
            //                    txtResta.Text = Convert.ToString(Convert.ToDecimal(TxtImporteToDec(txtResta)) - Resta);
            //                    row.Cells["Aplicado"].Value = Resta;
            //                }

            //            }
            //        }
            //    }
            //}
        }
        private void txtPagoTotalTipoMoneda_Leave(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda.Moneda.Text;
            }
            if (rbCheque.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda2.Moneda.Text;
            }
            if (rbTransferencia.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda3.Moneda.Text;
            }
            if (rbTarjeta.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda4.Moneda.Text;
            }
            if (rbAnticipo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda5.Moneda.Text;
            }
            Calculos();
        }
        private void txtPagoTotalTipoMoneda2_Leave(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda.Text;
            }
            if (rbCheque.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda3.Text;
            }
            if (rbTransferencia.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda2.Text;
            }
            if (rbTarjeta.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda4.Text;
            }
            if (rbAnticipo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda5.Text;
            }
            Calculos();
        }
        private void txtPagoTotalTipoMoneda3_Leave(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda.Text;
            }
            if (rbCheque.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda3.Text;
            }
            if (rbTransferencia.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda2.Text;
            }
            if (rbTarjeta.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda4.Text;
            }
            if (rbAnticipo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda5.Text;
            }

            Calculos();
        }
        private void txtPagoTotalTipoMoneda4_Leave(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda.Text;
            }
            if (rbCheque.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda3.Text;
            }
            if (rbTransferencia.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda2.Text;
            }
            if (rbTarjeta.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda4.Text;
            }
            if (rbAnticipo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda5.Text;
            }
            Calculos();
        }
        private void txtPagoTotalTipoMoneda5_Leave(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda.Text;
            }
            if (rbCheque.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda3.Text;
            }
            if (rbTransferencia.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda2.Text;
            }
            if (rbTarjeta.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda4.Text;
            }
            if (rbAnticipo.Checked)
            {
                txtResta.Text = txtPagoTotalTipoMoneda5.Text;
            }
            Calculos();
        }

        #region PAGOS MULTICLIENTE
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                BaseBotonBuscar.Enabled = true;
                BaseBotonProceso1.Enabled = true;
                BaseBotonProceso2.Enabled = true;

                BaseBotonAfectar.Visible = false;
                BaseBotonAfectar.Enabled = false;

                dtFacturas_PendientesPagoAll = null;
                grdFacturasLista.DataSource = dtFacturas_PendientesPagoAll;

                dtFacturas_a_Pagar.Rows.Clear();
                grdFacturasPagar.DataSource = dtFacturas_a_Pagar;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                BaseBotonBuscar.Enabled = false;
                BaseBotonProceso1.Enabled = false;
                BaseBotonProceso2.Enabled = false;
                LlenaGridFacturasPendientes();

                if (dtFacturas_PendientesPagoAll != null)
                {
                    if (dtFacturas_PendientesPagoAll.Rows.Count > 0)
                    {
                        BaseBotonAfectar.Visible = true;
                        BaseBotonAfectar.Enabled = false;
                    }
                    else
                    {
                        BaseBotonAfectar.Visible = false;
                        BaseBotonAfectar.Enabled = false;
                    }
                }
                else
                {
                    BaseBotonAfectar.Visible = false;
                    BaseBotonAfectar.Enabled = false;
                }
                txt_Filtrar2.Focus();
            }

        }
        private void grdFacturasLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                AgregarFactura();
        }
        private void grdFacturasPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdFacturasPagar.EndEdit();

            //EFECTIVO
            if (e.ColumnIndex == 7)
            {
                grdFacturasPagar.ReadOnly = false;
                grdFacturasPagar.Rows[e.RowIndex].Cells["EfectivoPagar"].ReadOnly = false;
                grdFacturasPagar.Columns["EfectivoPagar"].ReadOnly = false;
                if (e.ColumnIndex == this.grdDatos.Columns[7].Index)
                {
                    DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdFacturasPagar.Rows[e.RowIndex].Cells[7];
                    if (Convert.ToBoolean(chkCelda.Value) == true)
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Selected = false;
                        ADMINISTRACION.Frm_InformacionPagosCxC frm = new ADMINISTRACION.Frm_InformacionPagosCxC();
                        frm.B_Efectivo = true;
                        frm.ShowDialog();
                        if (frm.txt_G_Efectivo.Text.Trim().Length == 0)
                        {
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }
                        if (ValidaSePuedaAgregarMonto(e.RowIndex, Convert.ToDecimal(frm.txt_G_Efectivo.Text)))
                        {
                            grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagar"].Value = Convert.ToDecimal(frm.txt_G_Efectivo.Text);
                            grdFacturasPagar.EndEdit();
                        }
                        else
                        {
                            MessageBox.Show("EL MONTO TOTAL A PAGAR NO DEBE EXCEDER EL TOTAL DE LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }

                    }
                    else
                    {
                        //grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagar"].Value = grdFacturasPagar.Rows[e.RowIndex].Cells["Total_FacturaPagar"].Value;
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagar"].Value = 0;
                        grdFacturasPagar.EndEdit();

                    }
                }

            }

            //CHEQUE
            if (e.ColumnIndex == 8)
            {
                grdFacturasPagar.ReadOnly = false;
                grdFacturasPagar.Rows[e.RowIndex].Cells["ChequePagar"].ReadOnly = false;
                grdFacturasPagar.Columns["ChequePagar"].ReadOnly = false;

                if (e.ColumnIndex == this.grdDatos.Columns[8].Index)
                {
                    DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdFacturasPagar.Rows[e.RowIndex].Cells[8];
                    if (Convert.ToBoolean(chkCelda.Value) == true)
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Selected = false;
                        ADMINISTRACION.Frm_InformacionPagosCxC frm = new ADMINISTRACION.Frm_InformacionPagosCxC();
                        frm.B_Cheque = true;
                        frm.ShowDialog();
                        if (frm.txt_G_Cheque.Text.Length == 0 || frm.txt_G_No_Cheque.Text.Length == 0 || frm.PropiedadK_Banco_Cheque == 0 || frm.txt_G_Cuenta_Cheque.Text.Trim().Length == 0)
                        {
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }

                        if (ValidaSePuedaAgregarMonto(e.RowIndex, Convert.ToDecimal(frm.txt_G_Cheque.Text)))
                        {
                            grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarCheque"].Value = frm.txt_G_Cheque.Text.Trim().Length > 0 ? Convert.ToDecimal(frm.txt_G_Cheque.Text) : 0;
                            grdFacturasPagar.Rows[e.RowIndex].Cells["No_ChequePagar"].Value = frm.txt_G_No_Cheque.Text.Trim().Length > 0 ? frm.txt_G_No_Cheque.Text : "";
                            grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_ChequePagar"].Value = frm.PropiedadK_Banco_Cheque > 0 ? Convert.ToInt32(frm.PropiedadK_Banco_Cheque) : 0;
                            grdFacturasPagar.Rows[e.RowIndex].Cells["Cuenta_ChequePagar"].Value = frm.txt_G_Cuenta_Cheque.Text.Trim().Length > 0 ? frm.txt_G_Cuenta_Cheque.Text : "";
                            grdFacturasPagar.EndEdit();
                        }
                        else
                        {
                            MessageBox.Show("EL MONTO TOTAL A PAGAR NO DEBE EXCEDER EL TOTAL DE LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }

                    }
                    else
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarCheque"].Value = 0;
                        grdFacturasPagar.Rows[e.RowIndex].Cells["No_ChequePagar"].Value = "";
                        grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_ChequePagar"].Value = Convert.ToInt32(0);
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Cuenta_ChequePagar"].Value = "";
                        grdFacturasPagar.EndEdit();

                    }
                }

            }

            //TRANSFERENCIA
            if (e.ColumnIndex == 9)
            {
                grdFacturasPagar.ReadOnly = false;
                grdFacturasPagar.Rows[e.RowIndex].Cells["TransferenciaPagar"].ReadOnly = false;
                grdFacturasPagar.Columns["TransferenciaPagar"].ReadOnly = false;

                if (e.ColumnIndex == this.grdDatos.Columns[9].Index)
                {
                    DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdFacturasPagar.Rows[e.RowIndex].Cells[9];
                    if (Convert.ToBoolean(chkCelda.Value) == true)
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Selected = false;
                        ADMINISTRACION.Frm_InformacionPagosCxC frm = new ADMINISTRACION.Frm_InformacionPagosCxC();
                        frm.B_Transferencia = true;
                        frm.ShowDialog();
                        if (frm.txt_G_Transferencia.Text.Trim().Length == 0 || frm.txt_G_No_Transferencia.Text.Length == 0 || frm.PropiedadK_Banco_Transferencia == 0 || frm.txt_G_Cuenta_Transferencia.Text.Trim().Length == 0 || frm.txt_G_Referencia_Transferencia.Text.Trim().Length == 0)
                        {
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }

                        if (ValidaSePuedaAgregarMonto(e.RowIndex, Convert.ToDecimal(frm.txt_G_Transferencia.Text)))
                        {
                            grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarTransferencia"].Value = frm.txt_G_Transferencia.Text.Trim().Length > 0 ? Convert.ToDecimal(frm.txt_G_Transferencia.Text) : 0;
                            grdFacturasPagar.Rows[e.RowIndex].Cells["No_TransferenciaPagar"].Value = frm.txt_G_No_Transferencia.Text.Trim().Length > 0 ? frm.txt_G_No_Transferencia.Text : "";
                            grdFacturasPagar.Rows[e.RowIndex].Cells["Cuenta_TransferenciaPagar"].Value = frm.txt_G_Cuenta_Transferencia.Text.Trim().Length > 0 ? frm.txt_G_Cuenta_Transferencia.Text : "";
                            grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_TransferenciaPagar"].Value = Convert.ToInt32(frm.PropiedadK_Banco_Transferencia) > 0 ? Convert.ToInt32(frm.PropiedadK_Banco_Transferencia) : 0;
                            grdFacturasPagar.Rows[e.RowIndex].Cells["Referencia_TransferenciaPagar"].Value = frm.txt_G_Referencia_Transferencia.Text.Trim().Length > 0 ? frm.txt_G_Referencia_Transferencia.Text : "";
                        }
                        else
                        {
                            MessageBox.Show("EL MONTO TOTAL A PAGAR NO DEBE EXCEDER EL TOTAL DE LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }


                    }
                    else
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarTransferencia"].Value = 0;
                        grdFacturasPagar.Rows[e.RowIndex].Cells["No_TransferenciaPagar"].Value = "";
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Cuenta_TransferenciaPagar"].Value = "";
                        grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_TransferenciaPagar"].Value = Convert.ToInt32(0);
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Referencia_TransferenciaPagar"].Value = "";

                    }
                }

            }

            //TARJETA
            if (e.ColumnIndex == 10)
            {
                grdFacturasPagar.ReadOnly = false;
                grdFacturasPagar.Rows[e.RowIndex].Cells["TarjetaPagar"].ReadOnly = false;
                grdFacturasPagar.Columns["TarjetaPagar"].ReadOnly = false;

                if (e.ColumnIndex == this.grdDatos.Columns[10].Index)
                {
                    DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdFacturasPagar.Rows[e.RowIndex].Cells[10];
                    if (Convert.ToBoolean(chkCelda.Value) == true)
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Selected = false;
                        ADMINISTRACION.Frm_InformacionPagosCxC frm = new ADMINISTRACION.Frm_InformacionPagosCxC();
                        frm.B_Tarjeta = true;
                        frm.ShowDialog();

                        if ((frm.PropiedadB_Tarjeta_Credito == true) && (frm.txt_G_NoTarjeta_Credito.Text.Trim().Length == 0) || frm.txt_G_Tarjeta.Text.Trim().Length == 0 || frm.txt_G_Aprobacion.Text.Length == 0 || frm.PropiedadK_Banco_Tarjeta == 0 || frm.txt_G_NumOperacion.Text.Trim().Length == 0)
                        {
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }
                        if ((frm.PropiedadB_Tarjeta_Credito == false) && (frm.txt_G_NoTarjeta_Debito.Text.Trim().Length == 0) || (frm.txt_G_Tarjeta.Text.Trim().Length == 0) || frm.txt_G_Aprobacion.Text.Length == 0 || frm.PropiedadK_Banco_Tarjeta == 0 || frm.txt_G_NumOperacion.Text.Trim().Length == 0)
                        {
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }

                        if (ValidaSePuedaAgregarMonto(e.RowIndex, Convert.ToDecimal(frm.txt_G_Tarjeta.Text)))
                        {
                            if (frm.PropiedadB_Tarjeta_Credito == true)
                            {
                                grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_TarjetaPagar"].Value = Convert.ToInt32(frm.PropiedadK_Banco_Tarjeta) > 0 ? Convert.ToInt32(frm.PropiedadK_Banco_Tarjeta) : 0;
                                grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarTarjeta"].Value = frm.txt_G_Tarjeta.Text.Trim().Length > 0 ? Convert.ToDecimal(frm.txt_G_Tarjeta.Text) : 0;
                                grdFacturasPagar.Rows[e.RowIndex].Cells["No_Tarjeta_CreditoPagar"].Value = frm.txt_G_NoTarjeta_Credito.Text.Trim().Length > 0 ? frm.txt_G_NoTarjeta_Credito.Text : "";
                                grdFacturasPagar.Rows[e.RowIndex].Cells["AprobacionPagar"].Value = frm.txt_G_Aprobacion.Text.Trim().Length > 0 ? frm.txt_G_Aprobacion.Text : "";
                                grdFacturasPagar.Rows[e.RowIndex].Cells["No_OperacionPagar"].Value = frm.txt_G_NumOperacion.Text.Trim().Length > 0 ? frm.txt_G_NumOperacion.Text : "";
                            }
                            else
                            {
                                grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_TarjetaPagar"].Value = Convert.ToInt32(frm.PropiedadK_Banco_Tarjeta) > 0 ? Convert.ToInt32(frm.PropiedadK_Banco_Tarjeta) : 0;
                                grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarTarjeta"].Value = frm.txt_G_Tarjeta.Text.Trim().Length > 0 ? Convert.ToDecimal(frm.txt_G_Tarjeta.Text) : 0;
                                grdFacturasPagar.Rows[e.RowIndex].Cells["No_Tarjeta_DebitoPagar"].Value = frm.txt_G_NoTarjeta_Debito.Text.Trim().Length > 0 ? frm.txt_G_NoTarjeta_Debito.Text : "";
                                grdFacturasPagar.Rows[e.RowIndex].Cells["AprobacionPagar"].Value = frm.txt_G_Aprobacion.Text.Trim().Length > 0 ? frm.txt_G_Aprobacion.Text : "";
                                grdFacturasPagar.Rows[e.RowIndex].Cells["No_OperacionPagar"].Value = frm.txt_G_NumOperacion.Text.Trim().Length > 0 ? frm.txt_G_NumOperacion.Text : "";
                            }

                        }
                        else
                        {
                            MessageBox.Show("EL MONTO TOTAL A PAGAR NO DEBE EXCEDER EL TOTAL DE LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            chkCelda.Value = false;
                            grdFacturasPagar.EndEdit();
                            return;
                        }

                    }
                    else
                    {
                        grdFacturasPagar.Rows[e.RowIndex].Cells["Monto_PagoPagarTarjeta"].Value = 0;
                        grdFacturasPagar.Rows[e.RowIndex].Cells["No_Tarjeta_DebitoPagar"].Value = "";
                        grdFacturasPagar.Rows[e.RowIndex].Cells["AprobacionPagar"].Value = "";
                        grdFacturasPagar.Rows[e.RowIndex].Cells["K_Banco_TarjetaPagar"].Value = Convert.ToInt32(0);
                        grdFacturasPagar.Rows[e.RowIndex].Cells["No_OperacionPagar"].Value = "";

                    }
                }

            }
        }
        public override void BaseBotonAfectarClick()
        {
            if (grdFacturasPagar.Rows.Count == 0)
            {
                MessageBox.Show("ES NECESARIO AGREGAR MINIMO UNA FACTURA PARA PAGAR!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grdFacturasLista.Focus();
                return;
            }

            grdFacturasPagar.EndEdit();

            DataTable dtDetalle = DetallePagoCXCTypeMultiCliente;

            bool B_Entra = true;
            foreach (DataGridViewRow row in grdFacturasPagar.Rows)
            {
                res = 0;
                msg = string.Empty;
                short K_Tipo_Pago = 0;
                int aux = 0;
                //EFECTIVO
                if (row.Cells[7].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[7].Value.ToString()) == true)
                    {
                        K_Tipo_Pago = 1;

                        DataRow ren = dtDetalle.NewRow();
                        ren["K_Oficina"] = row.Cells["K_OficinaPagar"].Value;
                        ren["K_Cliente"] = row.Cells["K_ClientePagar"].Value;
                        ren["K_Liquidacion_CXC"] = DBNull.Value;
                        ren["K_Cuenta_Cliente"] = DBNull.Value;
                        ren["K_Cuenta_Empresa"] = DBNull.Value;
                        ren["K_Factura"] = row.Cells["K_FacturaPagar"].Value;
                        ren["K_Tipo_Pago"] = K_Tipo_Pago;
                        ren["Total_Factura"] = row.Cells["Total_FacturaPagar"].Value;
                        ren["Monto_Pago"] = row.Cells["Monto_PagoPagar"].Value;
                        ren["K_Banco_Tarjeta"] = 0;
                        ren["No_Tarjeta_Credito"] = "";
                        ren["No_Tarjeta_Debito"] = "";
                        ren["Aprobacion"] = "";
                        ren["No_Operacion"] = "";
                        ren["No_Cheque"] = "";
                        ren["K_Banco_Cheque"] = 0;
                        ren["Cuenta_Cheque"] = "";
                        ren["No_Transferencia"] = "";
                        ren["Cuenta_Transferencia"] = "";
                        ren["K_Banco_Transferencia"] = 0;
                        ren["Referencia_Transferencia"] = "";
                        ren["K_Anticipo"] = DBNull.Value;
                        ren["Serie"] = row.Cells["SeriePagar"].Value;
                        dtDetalle.Rows.Add(ren);
                    }
                    else
                    {
                        aux += 1;
                    }
                }
                    

                //CHEQUE
                if (row.Cells[8].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[8].Value.ToString()) == true)
                    {
                        K_Tipo_Pago = 2;

                        DataRow ren = dtDetalle.NewRow();
                        ren["K_Oficina"] = row.Cells["K_OficinaPagar"].Value;
                        ren["K_Cliente"] = row.Cells["K_ClientePagar"].Value;
                        ren["K_Liquidacion_CXC"] = DBNull.Value;
                        ren["K_Cuenta_Cliente"] = DBNull.Value;
                        ren["K_Cuenta_Empresa"] = DBNull.Value;
                        ren["K_Factura"] = row.Cells["K_FacturaPagar"].Value;
                        ren["K_Tipo_Pago"] = K_Tipo_Pago;
                        ren["Total_Factura"] = row.Cells["Total_FacturaPagar"].Value;
                        ren["Monto_Pago"] = Convert.ToDecimal(row.Cells["Monto_PagoPagarCheque"].Value);
                        ren["K_Banco_Tarjeta"] = 0;
                        ren["No_Tarjeta_Credito"] = "";
                        ren["No_Tarjeta_Debito"] = "";
                        ren["Aprobacion"] = "";
                        ren["No_Operacion"] = "";
                        ren["No_Cheque"] = row.Cells["No_ChequePagar"].Value;
                        ren["K_Banco_Cheque"] = row.Cells["K_Banco_ChequePagar"].Value;
                        ren["Cuenta_Cheque"] = row.Cells["Cuenta_ChequePagar"].Value;
                        ren["No_Transferencia"] = "";
                        ren["Cuenta_Transferencia"] = "";
                        ren["K_Banco_Transferencia"] = 0;
                        ren["Referencia_Transferencia"] = "";
                        ren["K_Anticipo"] = DBNull.Value;
                        ren["Serie"] = row.Cells["SeriePagar"].Value;
                        dtDetalle.Rows.Add(ren);
                    }
                    else
                    {
                        aux += 1;
                    }
                }
                    


                //TRANSFERENCIA
                if (row.Cells[9].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[9].Value.ToString()) == true)
                    {
                        K_Tipo_Pago = 3;

                        DataRow ren = dtDetalle.NewRow();
                        ren["K_Oficina"] = row.Cells["K_OficinaPagar"].Value;
                        ren["K_Cliente"] = row.Cells["K_ClientePagar"].Value;
                        ren["K_Liquidacion_CXC"] = DBNull.Value;
                        ren["K_Cuenta_Cliente"] = DBNull.Value;
                        ren["K_Cuenta_Empresa"] = DBNull.Value;
                        ren["K_Factura"] = row.Cells["K_FacturaPagar"].Value;
                        ren["K_Tipo_Pago"] = K_Tipo_Pago;
                        ren["Total_Factura"] = row.Cells["Total_FacturaPagar"].Value;
                        ren["Monto_Pago"] = Convert.ToDecimal(row.Cells["Monto_PagoPagarTransferencia"].Value);
                        ren["K_Banco_Tarjeta"] = 0;
                        ren["No_Tarjeta_Credito"] = "";
                        ren["No_Tarjeta_Debito"] = "";
                        ren["Aprobacion"] = "";
                        ren["No_Operacion"] = "";
                        ren["No_Cheque"] = "";
                        ren["K_Banco_Cheque"] = 0;
                        ren["Cuenta_Cheque"] = "";
                        ren["No_Transferencia"] = row.Cells["No_TransferenciaPagar"].Value;
                        ren["Cuenta_Transferencia"] = row.Cells["Cuenta_TransferenciaPagar"].Value;
                        ren["K_Banco_Transferencia"] = row.Cells["K_Banco_TransferenciaPagar"].Value;
                        ren["Referencia_Transferencia"] = row.Cells["Referencia_TransferenciaPagar"].Value;
                        ren["K_Anticipo"] = DBNull.Value;
                        ren["Serie"] = row.Cells["SeriePagar"].Value;
                        dtDetalle.Rows.Add(ren);
                    }

                    else
                    {
                        aux += 1;
                    }
                }
                    


                //TARJETA
                if (row.Cells[10].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[10].Value.ToString()) == true)
                    {
                        K_Tipo_Pago = 5;

                        DataRow ren = dtDetalle.NewRow();
                        ren["K_Oficina"] = row.Cells["K_OficinaPagar"].Value;
                        ren["K_Cliente"] = row.Cells["K_ClientePagar"].Value;
                        ren["K_Liquidacion_CXC"] = DBNull.Value;
                        ren["K_Cuenta_Cliente"] = DBNull.Value;
                        ren["K_Cuenta_Empresa"] = DBNull.Value;
                        ren["K_Factura"] = row.Cells["K_FacturaPagar"].Value;
                        ren["K_Tipo_Pago"] = K_Tipo_Pago;
                        ren["Total_Factura"] = row.Cells["Total_FacturaPagar"].Value;
                        ren["Monto_Pago"] = Convert.ToDecimal(row.Cells["Monto_PagoPagarTarjeta"].Value);
                        ren["K_Banco_Tarjeta"] = row.Cells["K_Banco_TarjetaPagar"].Value;
                        ren["No_Tarjeta_Credito"] = row.Cells["No_Tarjeta_CreditoPagar"].Value;
                        ren["No_Tarjeta_Debito"] = row.Cells["No_Tarjeta_DebitoPagar"].Value;
                        ren["Aprobacion"] = row.Cells["AprobacionPagar"].Value;
                        ren["No_Operacion"] = row.Cells["No_OperacionPagar"].Value;
                        ren["No_Cheque"] = "";
                        ren["K_Banco_Cheque"] = 0;
                        ren["Cuenta_Cheque"] = "";
                        ren["No_Transferencia"] = "";
                        ren["Cuenta_Transferencia"] = "";
                        ren["K_Banco_Transferencia"] = 0;
                        ren["Referencia_Transferencia"] = "";
                        ren["K_Anticipo"] = DBNull.Value;
                        ren["Serie"] = row.Cells["SeriePagar"].Value;
                        dtDetalle.Rows.Add(ren);
                    }
                    else
                    {
                        aux += 1;
                    }
                }
                if (aux == 4)
                {
                    MessageBox.Show(String.Format("LA FACTURA [{0}] NO TIENE TIPOS DE PAGO ASIGNADOS, \r\n" +
                        "PARA PODER CONTINUAR, DEBE DE AGREGAR POR LO MENOS UN TIPO DE PAGO Y UN MONTO A LAS FACTURA!...", row.Cells["K_FacturaPagar"].Value.ToString()), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    B_Entra = false;
                    break;
                }
            }

            if (!B_Entra)
                return;
            res = sql_cxc.Gp_Pagos_FacturaMultipleCliente(GlobalVar.K_Usuario, GlobalVar.K_Oficina, GlobalVar.PC_Name, intK_Liquidacion_CXC, dtDetalle, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("LA TRANSACCION SE REALIZO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LlenaGridFacturasPendientes();

                dtFacturas_a_Pagar.Rows.Clear();
                grdFacturasPagar.DataSource = dtFacturas_a_Pagar;

            }
            base.BaseBotonAfectarClick();
        }
        private void LlenaGridFacturasPendientes()
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dtFacturas_PendientesPagoAll = sql_cxc.Sk_Facturas_Pte(GlobalVar.K_Empresa);

                if (dtFacturas_PendientesPagoAll != null)
                {
                    if (dtFacturas_PendientesPagoAll.Rows.Count > 0)
                    {
                        grdFacturasLista.DataSource = dtFacturas_PendientesPagoAll;
                    }
                }
                else
                {
                    MessageBox.Show("NO EXISTEN FACTURAS PENDIENTES DE PAGO. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void AgregarFactura()
        {
            DataGridViewRow row = grdFacturasLista.CurrentRow;
            if (row != null)
            {
                int K_Factura = Convert.ToInt32(row.Cells["K_FacturaLista"].Value);

                //Validar que la factura no haya sido agregada ya al grid
                var Existe = dtFacturas_a_Pagar.AsEnumerable().Where(o => o.Field<int>("K_FacturaPagar") == K_Factura);
                if (Existe.Any())
                {
                    MessageBox.Show("La Factura Seleccionada ya está Agregada a las Facturas a Pagar...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dlg = MessageBox.Show("¿DESEA AGREGAR LA FACTURA CON FOLIO: " + K_Factura.ToString().Trim() + "?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    DataRow dr = dtFacturas_a_Pagar.NewRow();

                    dr["K_FacturaPagar"] = row.Cells["K_FacturaLista"].Value;
                    dr["K_Tipo_PagoPagar"] = 0;
                    dr["Total_FacturaPagar"] = (decimal)row.Cells["Total_FacturaLista"].Value;
                    dr["Monto_PagoPagar"] = 0;
                    dr["Monto_PagoPagarCheque"] = 0;
                    dr["Monto_PagoPagarTarjeta"] = 0;
                    dr["Monto_PagoPagarTransferencia"] = 0;
                    dr["EfectivoPagar"] = false;
                    dr["ChequePagar"] = false;
                    dr["TarjetaPagar"] = false;
                    dr["TransferenciaPagar"] = false;
                    dr["K_Banco_TarjetaPagar"] = 0;
                    dr["No_Tarjeta_Credito"] = "";
                    dr["No_Tarjeta_Debito"] = "";
                    dr["Aprobacion"] = "";
                    dr["No_Operacion"] = "";
                    dr["No_Cheque"] = "";
                    dr["K_Banco_ChequePagar"] = 0;
                    dr["Cuenta_Cheque"] = "";
                    dr["No_Transferencia"] = "";
                    dr["Cuenta_Transferencia"] = "";
                    dr["K_Banco_TransferenciaPagar"] = 0;
                    dr["Referencia_TransferenciaPagar"] = "";
                    dr["K_AlmacenPagar"] = row.Cells["K_AlmacenLista"].Value;
                    dr["D_AlmacenPagar"] = row.Cells["D_AlmacenLista"].Value;
                    dr["DescuentoPagar"] = row.Cells["DescuentoLista"].Value;
                    dr["SubTotalPagar"] = row.Cells["SubTotalLista"].Value;
                    dr["Total_IvaPagar"] = row.Cells["Total_IvaLista"].Value;
                    dr["K_ClientePagar"] = row.Cells["K_ClienteLista"].Value;
                    dr["D_ClientePagar"] = row.Cells["D_ClienteLista"].Value;
                    dr["K_OficinaPagar"] = row.Cells["K_OficinaLista"].Value;
                    dr["D_OficinaPagar"] = row.Cells["D_OficinaLista"].Value;
                    dr["SeriePagar"] = row.Cells["SerieLista"].Value;
                    dtFacturas_a_Pagar.Rows.Add(dr);
                    dtFacturas_a_Pagar.AcceptChanges();
           
                    grdFacturasPagar.DataSource = dtFacturas_a_Pagar;
                         
                    ///grdFacturasPagar.EditMode = DataGridViewEditMode.EditOnEnter;
                    grdFacturasPagar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    grdFacturasPagar.MultiSelect = false;

                    if(grdFacturasPagar.Rows.Count>0)
                    {
                        BaseBotonAfectar.Visible = true;
                        BaseBotonAfectar.Enabled = true;
                    }
                    else
                    {
                        BaseBotonAfectar.Visible = true;
                        BaseBotonAfectar.Enabled = false;
                    }
                }


            }
        }
        private bool ValidaSePuedaAgregarMonto(int Renglon, decimal Monto)
        {
            decimal Total_Factura = Convert.ToDecimal(grdFacturasPagar.Rows[Renglon].Cells["Total_FacturaPagar"].Value);
            decimal SaldoTotalAplicado =
                Convert.ToDecimal(grdFacturasPagar.Rows[Renglon].Cells["Monto_PagoPagar"].Value)
                +
                Convert.ToDecimal(grdFacturasPagar.Rows[Renglon].Cells["Monto_PagoPagarCheque"].Value)
                +
                Convert.ToDecimal(grdFacturasPagar.Rows[Renglon].Cells["Monto_PagoPagarTarjeta"].Value)
                +
                Convert.ToDecimal(grdFacturasPagar.Rows[Renglon].Cells["Monto_PagoPagarTransferencia"].Value)
                +
                Monto;

            if (SaldoTotalAplicado > Total_Factura)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        private void txt_Filtrar2_TextChanged(object sender, EventArgs e)
        {
            string Cadena = string.Empty;
            Int32 CadenaNumerica = 0;
            bool Numero = false;
            if (EsNumero(txt_Filtrar2.Text.Trim()))
            {
                Numero = true;
                try { CadenaNumerica = Convert.ToInt32(txt_Filtrar2.Text.Trim()); } catch (Exception) { CadenaNumerica = 0; }

            }
            else
            {
                Numero = false;
                Cadena = txt_Filtrar2.Text.Trim();
            }


            if (txt_Filtrar2.Text.Trim().Length > 0 && Numero == true)
            {
                dtFacturas_PendientesPagoAll.DefaultView.RowFilter = $"K_Cliente ='{CadenaNumerica}' or D_Cliente LIKE '%{CadenaNumerica}%' or K_Factura ='{CadenaNumerica}' ";
            }
            else if (txt_Filtrar2.Text.Trim().Length > 0 && Numero == false)
            {
                dtFacturas_PendientesPagoAll.DefaultView.RowFilter = $"D_Cliente LIKE '%{Cadena}%'";
            }

            else
            {
                dtFacturas_PendientesPagoAll.DefaultView.RowFilter = string.Empty;
            }

        }
        private void txt_Filtrar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)) || (Char.IsLetter(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void grdFacturasLista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdFacturasLista.Cursor = Cursors.Hand;
            else
                grdFacturasLista.Cursor = Cursors.Default;
        }

        #endregion

        private void Frm_CuentasxCobrar_Resize(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            //decimal a = (pnlGeneralMulticliente.Height - pnlEncabezado.Height - pnlFiltrar2.Height) / 2;
            //grdFacturasLista.Height = Convert.ToInt32(a);
            //grdFacturasPagar.Height = Convert.ToInt32(a);
        }

        private void Frm_CuentasxCobrar_Load(object sender, EventArgs e)
        {

        }
    }
}
