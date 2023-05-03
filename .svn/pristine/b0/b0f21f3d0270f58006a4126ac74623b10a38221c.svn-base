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

namespace ProbeMedic.CXP
{
    public partial class Frm_AnticiposProveedores : FormaBase
    {
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCuentasxPagar sqlCxP = new SQLCuentasxPagar();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();
        RecepcionBL blRecepcion = new RecepcionBL();
        SQLCompras sqlCompras = new SQLCompras();

        DataTable dtProveedores = new DataTable();
        DataTable dtProveedores_Cuentas_Bancarias = new DataTable();
        DataTable dtTipoCambio = new DataTable();

 

        Funciones fx = new Funciones();
        //private int k_Nota_Recepcion;

        //bool B_AplicaColores;
        int res = 0;
        string msg = string.Empty;
        bool blnSeleccionGrid = false;
        //int K_TipoMoneda = 0;
        //decimal TipoCambioGuardar = 0;

        private int p_K_Motivo_Anticipo_Pago { get; set; }
        public object LlenaDatos { get; internal set; }

        public Frm_AnticiposProveedores()
        {
            BaseGridSinFormato =true;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormatoGrid()
        {
            grdDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grdDatos.RowHeadersVisible = false;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDatos.AllowUserToAddRows = false;
            grdDatos.AllowUserToDeleteRows = false;
            grdDatos.BorderStyle = BorderStyle.None;

            grdDatos.AllowUserToResizeColumns = true;
            grdDatos.MultiSelect = false;


            grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDatos.EnableHeadersVisualStyles = false;
            grdDatos.ScrollBars = ScrollBars.Both;
        }

        void Principal_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonNuevo.Enabled = true;
            BaseBotonNuevo.Visible = true;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;


            grdDatos.AutoGenerateColumns = false;
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonExcel.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;

            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;

            grdDatos.AutoGenerateColumns = false;
            FormatoGrid();

            dtProveedores = sqlCatalogos.Sk_Proveedores();

            //FiltraTiposPagos();

            DataTable dtBancosCh = sqlCatalogos.Sk_Bancos();
            if (dtBancosCh != null)
            {
                LlenaCombo(dtBancosCh, ref cmbChequeBanco, "K_Banco", "D_Banco", 0);
                cmbChequeBanco.SelectedIndex = -1;
            }
            DataTable dtBancosT = sqlCatalogos.Sk_Bancos();
            if (dtBancosT != null)
            {
                LlenaCombo(dtBancosT, ref cmbTransferenciaBanco, "K_Banco", "D_Banco", 0);
                cmbTransferenciaBanco.SelectedIndex = -1;
            }

            if (GlobalVar.dtEmpresa_Cuentas.Rows.Count == 1)
            {
                txtClaveCuentaOrigen.Text = GlobalVar.dtEmpresa_Cuentas.Rows[0]["K_Cuenta_Empresa"].ToString();
                txtCuentaOrigen.Text = GlobalVar.dtEmpresa_Cuentas.Rows[0]["CuentaCompleta"].ToString();
            }
            pnlArriba.Enabled = false;
            pnlAbajo.Enabled = false;
            txtClaveProveedor.Focus();
            base.BaseMetodoInicio();

            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;

         
        }

        public override void BaseBotonGuardarClick()
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

            int K_Cuenta_Empresa = 0;
            int K_Cuenta_Proveedor = 0;

            decimal Importe = 0;
            decimal Importe_Cheque = 0;
            decimal Importe_Transferencia = 0;
            int Numero_Transferencia = 0;
            int Numero_Cheque = 0;

            int Cuenta_Transferencia = 0;
            int Cuenta_Cheque = 0;

            if (rbEfectivo.Checked)
            {
                if (txtEfectivoImporte.Text.Trim().Length > 0)
                    Importe = Convert.ToDecimal(TxtImporteToDec(txtEfectivoImporte));

            }
            if (rbCheque.Checked)
            {
                if (txtChequeImporte.Text.Trim().Length > 0)
                    Importe_Cheque = Convert.ToDecimal(TxtImporteToDec(txtChequeImporte));

                if (txtChequeNoCheque.Text.Trim().Length > 0)
                {
                    Numero_Cheque = Convert.ToInt32(txtChequeNoCheque.Text);
                }
                if (txtChequeCuenta.Text.Trim().Length > 0)
                {
                    Cuenta_Cheque = Convert.ToInt32(txtChequeCuenta.Text);
                }
            }
            if (rbTransferencia.Checked)
            {
                if (txtTransferenciaImporte.Text.Trim().Length > 0)
                    Importe_Transferencia = Convert.ToDecimal(TxtImporteToDec(txtTransferenciaImporte));

                if(txtTransferenciaNoTransferencia.Text.Trim().Length >0)
                {
                    Numero_Transferencia = Convert.ToInt32(txtTransferenciaNoTransferencia.Text);
                }
                if (txtTransferenciaCuenta.Text.Trim().Length > 0)
                {
                   Cuenta_Transferencia = Convert.ToInt32(txtTransferenciaCuenta.Text);
                }

            }
            

            if (txtClaveCuentaOrigen.Text.Trim().Length > 0)
                K_Cuenta_Empresa = Convert.ToInt32(txtClaveCuentaOrigen.Text);
            if (txtClaveCuentaDeposito.Text.Trim().Length > 0)
                K_Cuenta_Proveedor = Convert.ToInt32(txtClaveCuentaDeposito.Text);


            grdDatos.EndEdit();

            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCxP.In_Anticipos_Proveedores(
                    ref CampoIdentity,
                    K_Tipo_Pago,
                    Convert.ToInt32(txtClaveProveedor.Text),
                    K_Cuenta_Proveedor,
                    Importe,
                    Importe_Cheque,
                    Convert.ToInt32(cmbChequeBanco.SelectedValue),
                Cuenta_Cheque,
                   Numero_Cheque,
                    Importe_Transferencia,
                    Convert.ToInt32(cmbTransferenciaBanco.SelectedValue),
                    Cuenta_Transferencia,
                    Numero_Transferencia,
                    txtTransferenciaReferencia.Text, 
                    0, 
                    p_K_Motivo_Anticipo_Pago,
                    GlobalVar.K_Usuario,
                    GlobalVar.K_Usuario,      
                    ref msg);
                    if (res == -1)
                    {
                        BaseErrorResultado = true;
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
              

            }

            BaseErrorResultado = false;
            msg = "PAGO GENERADO CORRECTAMENTE CON FOLIO CONSECUTIVO "+CampoIdentity;
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BaseMetodoInicio();
            BaseBotonCancelarClick();


        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveProveedor.Focus();
                return false;
            }
            if (p_K_Motivo_Anticipo_Pago  == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MOTIVO DE ANTICIPO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    
            if (rbEfectivo.Checked == false)
            {
                if (txtClaveCuentaDeposito.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE DEPOSITO\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA CREARLA PREVIAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (txtClaveCuentaOrigen.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE ORIGEN DE LA EMPRESA\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA CREARLA PREVIAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtClaveCuentaDeposito.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE DEPOSITO DEL PROVEEDOR\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA CREARLA PREVIAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;

            rbEfectivo.Checked = true;
            rbTransferencia.Checked = false;
            rbCheque.Checked = false;

            txtClaveCuentaOrigen.Text = string.Empty;
            txtCuentaOrigen.Text = string.Empty;
            txtClaveCuentaDeposito.Text = string.Empty;
            txtCuentaDeposito.Text = string.Empty;

            LimpiaControlesFormaPago();

            grdDatos.DataSource = null;
        }

        public override void BaseBotonCancelarClick()
        {
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseMetodoLimpiaControles();
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = false;
            BasePropiedadId_Identity = 0;

            pnlArriba.Enabled = false;
            pnlAbajo.Enabled = false;

        }

        public override void BaseBotonNuevoClick()
        {         
            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;
            pnlArriba.Enabled = true;
            txtClaveProveedor.Focus();     
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                LlenaDatosProveedor(frm.BusquedaPropiedadReglonRes);
            }
        }

        private void btnBuscarMotivo_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Motivo_Anticipo frm = new Busquedas.Frm_Busca_Motivo_Anticipo();
            frm.ShowDialog();

            p_K_Motivo_Anticipo_Pago = frm.LLave_Seleccionado;
            this.txtMotivo.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscaCuentaOrigen_Click(object sender, EventArgs e)
        {
            DataTable dtCuentas = sqlCatalogos.Sk_Empresa_Cuentas(GlobalVar.K_Empresa);

            Busquedas.BuscaEmpresa_Cuentas frm = new Busquedas.BuscaEmpresa_Cuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtEmpresa_Cuentas);
            frm.BusquedaPropiedadTablaFiltra = dtCuentas;
            frm.BusquedaPropiedadTitulo = "Busca Cuentas de la Empresa";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Empresa"].ToString();
                txtCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
            }
        }

        private void btnBuscaCuentaDeposito_Click(object sender, EventArgs e)
        {
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR ANTES UN PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveProveedor.Focus();
                return;
            }

            Busquedas.BuscaProveedorCuentas frm = new Busquedas.BuscaProveedorCuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores_Cuentas_Bancarias);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores_Cuentas_Bancarias;
            frm.BusquedaPropiedadTitulo = "Busca Cuentas del Proveedor";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Proveedor"].ToString();
                txtCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
                ActualizaFormaPago(frm.BusquedaPropiedadReglonRes);
            }

        }

        private void LimpiaControlesFormaPago()
        {
            p_K_Motivo_Anticipo_Pago = 0;
            txtMotivo.Text = string.Empty;

            txtEfectivoImporte.Text = string.Empty;
            cmbChequeBanco.SelectedIndex = -1;
            txtChequeCuenta.Text = string.Empty;
            txtChequeNoCheque.Text = string.Empty;
            txtChequeImporte.Text = string.Empty;

            cmbTransferenciaBanco.SelectedIndex = -1;
            txtTransferenciaCuenta.Text = string.Empty;
            txtTransferenciaNoTransferencia.Text = string.Empty;
            txtTransferenciaReferencia.Text = string.Empty;
            txtTransferenciaImporte.Text = string.Empty;


            //rbPesos.Checked = true;
            //rbDolares.Checked = false;

            //K_TipoMoneda = 0;
            txtTipoCambio.Text = string.Empty;
            txtPagoTotalTipoMoneda.Text = string.Empty;
            txtTipoCambio2.Text = string.Empty;
            txtPagoTotalTipoMoneda2.Text = string.Empty;
            txtTipoCambio3.Text = string.Empty;
            txtPagoTotalTipoMoneda3.Text = string.Empty;
        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                BaseMetodoLimpiaControles();
                return;
            }

            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            DataTable dtBusca = BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);

            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                BaseMetodoLimpiaControles();
                return;
            }

            if(dtBusca!=null)
            {
                if(dtBusca.Rows.Count>0)
                {
                    LlenaDatosProveedor(dtBusca.Rows[0]);
                }
            }
          
            txtClaveCuentaOrigen.Focus();
        }

        private void LlenaDatosProveedor(DataRow ren)
        {
            txtClaveProveedor.Text = ren["K_Proveedor"].ToString();
            txtProveedor.Text = ren["D_Proveedor"].ToString();
            pnlAbajo.Enabled = true;
            MostrarDatos();
            LlenaCuentasProveedor(Convert.ToInt32(ren["K_Proveedor"]));
            LimpiaControlesFormaPago();
        }

        private void LlenaCuentasProveedor(int K_Proveedor)
        {
            dtProveedores_Cuentas_Bancarias = sqlCatalogos.Sk_proveedores_cuentas_bancarias(K_Proveedor);
            if (dtProveedores_Cuentas_Bancarias != null)
            {
                if (dtProveedores_Cuentas_Bancarias.Rows.Count == 1)
                {
                    txtClaveCuentaDeposito.Text = dtProveedores_Cuentas_Bancarias.Rows[0]["K_Cuenta_Proveedor"].ToString();
                    txtCuentaDeposito.Text = dtProveedores_Cuentas_Bancarias.Rows[0]["CuentaCompleta"].ToString();
                    ActualizaFormaPago(dtProveedores_Cuentas_Bancarias.Rows[0]);
                }
            }
        }

        private void ActualizaFormaPago(DataRow ren)
        {
            bool B_Dolares = Convert.ToBoolean(ren["B_Dolares"]);
            bool B_Transferencia = Convert.ToBoolean(ren["B_Transferencia"]);
            bool B_Cheque = Convert.ToBoolean(ren["B_Cheque"]);
            int K_Banco = Convert.ToInt32(ren["K_Banco"]);

            rbTransferencia.Checked = B_Transferencia;
            rbCheque.Checked = B_Cheque;

            if (B_Transferencia)
            {
                cmbTransferenciaBanco.SelectedValue = K_Banco;
                txtTransferenciaCuenta.Text = ren["Cuenta_Clabe"].ToString();
            }
            if (B_Cheque)
            {
                cmbChequeBanco.SelectedValue = K_Banco;
                txtChequeCuenta.Text = ren["Numero_Cuenta"].ToString();
            }
        }

        private void MostrarDatos()
        {
            if (blnSeleccionGrid)
            {
                txtEfectivoImporte.Text = "";
                txtChequeImporte.Text = "";
                txtTransferenciaImporte.Text = "";
    

                txtEfectivoImporte.ReadOnly = false;
                txtChequeImporte.ReadOnly = false;
                txtTransferenciaImporte.ReadOnly = false;
          

                blnSeleccionGrid = false;
            }

            grdDatos.DataSource = null;
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {

                return;
            }

            DataTable dtDatos = sqlCxP.Sk_Anticipos_Proveedores(Convert.ToInt32(txtClaveProveedor.Text));

            if (dtDatos != null)
            {
                grdDatos.DataSource = dtDatos;
                BaseDtDatos = dtDatos;
                grdDatos.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY ANTICIPOS AUTORIZADOS PARA ESTE PROVEEDOR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiaControlesFormaPago();
            }
        }

      
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                pnlEfectivo.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = true;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = false;
              
                //LimpiaControlesFormaPago();
                //MostrarDatos();
    
                txtEfectivoImporte.Focus();
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

                //LimpiaControlesFormaPago();
                //MostrarDatos();  
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
         
                //LimpiaControlesFormaPago();
                //MostrarDatos();
         
                cmbTransferenciaBanco.Focus();
            }
        }


        private void txtEfectivoImporte_Leave(object sender, EventArgs e)
        {
            //txtTotalAPagar.Text = string.Empty;
            //txtResta.Text = string.Empty;
            //MostrarDatos();
            //Calculos();
            //txtEfectivoImporte.Text = TxtImporteToStr(txtEfectivoImporte);
        }

        private void txtChequeImporte_Leave(object sender, EventArgs e)
        {
            //txtTotalAPagar.Text = string.Empty;
            //txtResta.Text = string.Empty;
            //MostrarDatos();
            //Calculos();
            //txtChequeImporte.Text = TxtImporteToStr(txtChequeImporte);
        }

        private void txtTransferenciaImporte_Leave(object sender, EventArgs e)
        {
            //txtTotalAPagar.Text = string.Empty;
            //txtResta.Text = string.Empty;
            //MostrarDatos();
            //Calculos();
            //txtTransferenciaImporte.Text = TxtImporteToStr(txtTransferenciaImporte);            
        }

  
        private void txtClaveCuentaOrigen_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtEmpresa_Cuentas, "K_Cuenta_Empresa", "CuentaCompleta", ref txtClaveCuentaOrigen, ref txtCuentaOrigen);
        }

        private void txtClaveCuentaDeposito_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(dtProveedores_Cuentas_Bancarias, "K_Cuenta_Proveedor", "CuentaCompleta", ref txtClaveCuentaDeposito, ref txtCuentaDeposito);
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
                return dblImporte.ToString("C");
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

        private void txtEfectivoImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtTransferenciaImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtTipoCambio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtChequeImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtTipoCambio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtClaveProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (fx.EsDatoNumerico(e.KeyChar.ToString()))
            {
                e.Handled = false;
            }
            else if(!fx.EsDatoNumerico(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}

    
