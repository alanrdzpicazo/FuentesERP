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

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_NotaCredito : FormaBase
    {
        bool PropiedadEsRegistroNuevo = false;

        int res = 0;
        string msg = string.Empty;

        int K_Oficina = 0;
        int k_Almacen = 0;

        SQLAdministracion SQLADMINISTRACION = new SQLAdministracion();
        SQLCatalogos SQLCATALOGOS = new SQLCatalogos();

        DataTable dtAlmacen = new DataTable();
        DataTable dtTiposMotivos = new DataTable();
        DataTable dtTipoFiscal = new DataTable();
        DataTable dtImpuestos = new DataTable();

        public Frm_NotaCredito()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            pnlGeneral.Enabled = false;

            PropiedadEsRegistroNuevo = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnNuevo.Image.png"]));
            BaseBotonProceso1.Text = "Nuevo";
            BaseBotonProceso1.ToolTipText = "Nuevo";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso2.Text = "Guardar";
            BaseBotonProceso2.ToolTipText = "Guardar Presupuesto";
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = false;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso3.Text = "Cancelar";
            BaseBotonProceso3.ToolTipText = "Cancelar Captura";
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;

            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["btnBorrar.Image.png"]));
            BaseBotonProceso4.Text = "Borrar";
            BaseBotonProceso4.ToolTipText = "Borrar";
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = false;

            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;

            DataTable dtImpuestosPaso = SQLCATALOGOS.Sk_Tipo_Iva();
            
            IEnumerable<DataRow> query = from fila in dtImpuestosPaso.AsEnumerable()
                                         where fila.Field<String>("D_IVA") == "NORMAL"
                                         select fila;
            dtImpuestos = query.CopyToDataTable<DataRow>();
        }

        //NUEVO
        public override void BaseBotonProceso1Click()
        {
            BaseBotonBuscar.Enabled = false;

            BaseMetodoLimpiaControles();
            PropiedadEsRegistroNuevo = true;
            pnlGeneral.Enabled = true;

            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso4.Enabled = false;

            TxtImporte.Text = "0.00";
            Txt_Subtotal.Text = "0.00";
            Txt_Porcentaje_IVA.Text = "0.00";
            Txt_Total_IVA.Text = "0.00";
            Txt_Porcentaje_Retencion.Text = "0.00";
            Txt_Total_Retencion.Text = "0.00";
            TxtTotal.Text = "0.00";

            MtdCargaTiposMotivos();
            MtdCargaTipoFiscal();
               

            Cbx_Motivo_Nota_Credito.Focus();

        }
        //GUARDAR 
        public override void BaseBotonProceso2Click()

        {
            if (!BaseFuncionValidaciones())
                return;

            if (PropiedadEsRegistroNuevo) // Nuevo
            {
                res = 0;
                msg = string.Empty;
                Int32 CampoIdentity = 0;

                Int32 K_Oficina = 0;
                Int32 K_Cliente = 0;

                if (txtClaveOficina.Text.Trim().Length > 0)
                {
                    K_Oficina = Convert.ToInt32(txtClaveOficina.Text.Trim().ToString());
                }
                if (txtClaveCliente.Text.Trim().Length > 0)
                {
                    K_Cliente = Convert.ToInt32(txtClaveCliente.Text.Trim().ToString());
                }
                res = SQLADMINISTRACION.In_Nota_Credito_Interna_Factura(ref CampoIdentity, GlobalVar.K_Usuario, K_Oficina,
                    Convert.ToInt32(cbxAlmacen.SelectedValue), K_Cliente, DtpFechaGeneracion.Value,
                    Convert.ToDecimal(Txt_Subtotal.Text), Convert.ToDecimal(Txt_Porcentaje_IVA.Text),
                    Convert.ToDecimal(Txt_Total_IVA.Text), Convert.ToDecimal(Txt_Porcentaje_Retencion.Text),
                    Convert.ToDecimal(Txt_Total_Retencion.Text), Convert.ToDecimal(TxtTotal.Text), Convert.ToInt32(Cbx_Motivo_Nota_Credito.SelectedValue),
                    Convert.ToInt32(Cbx_Tipo_Fiscal.SelectedValue), Convert.ToInt32(txtClaveCuentaOrigen.Text), this.TxtObservaciones.Text, 
                    Convert.ToInt32(txtFactura.Text), GlobalVar.K_Usuario, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("Nota de Crédito Generada Correctamente con No. de Folio [" + CampoIdentity.ToString() + "]", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
            else //Existe. Update
            {

            }

            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
            base.BaseBotonProceso1Click();
        }
        //CANCELAR
        public override void BaseBotonProceso3Click()
        {
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
        }
        //BORRAR
        public override void BaseBotonProceso4Click()
        {
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso4.Enabled = false;
            PropiedadEsRegistroNuevo = false;
            pnlEncabezado.Enabled = false;
        }
        public override void BaseBotonBuscarClick()
        {

            BaseBotonProceso4.Enabled = true;

            DataTable Dt_NotasCredito= new DataTable();

            Dt_NotasCredito = SQLADMINISTRACION.Sk_Nota_Credito_Interna_Factura();

            Busquedas.BuscaNotaCreditoInternaFactura frm = new Busquedas.BuscaNotaCreditoInternaFactura();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(Dt_NotasCredito);
            frm.BusquedaPropiedadTablaFiltra = Dt_NotasCredito;
            frm.BusquedaPropiedadTitulo = "Busca Nota Crédito Interna";
            frm.ShowDialog();

            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_Oficina = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString());
                k_Almacen = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Almacen"].ToString());
                MtdCargaTiposMotivos();
                MtdCargaAlmacen();
                this.txtClave.Text = frm.BusquedaPropiedadReglonRes["K_Nota_Credito_Factura"].ToString();
                this.Txt_Usuario_Genero.Text = frm.BusquedaPropiedadReglonRes["D_Usuario_Genero"].ToString();
                this.Txt_Usuario_Autoriza.Text = frm.BusquedaPropiedadReglonRes["D_Usuario_Autorizo"].ToString();
                this.Cbx_Motivo_Nota_Credito.SelectedValue = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Motivo_Nota_Credito"]);
                this.DtpFechaGeneracion.Value = Convert.ToDateTime(frm.BusquedaPropiedadReglonRes["F_Generacion"].ToString());
                this.txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                this.txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
                this.cbxAlmacen.SelectedValue = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Almacen"]);
                this.txtClaveCliente.Text = frm.BusquedaPropiedadReglonRes["K_Cliente"].ToString();
                this.txtCliente.Text = frm.BusquedaPropiedadReglonRes["D_Cliente"].ToString();
                this.txtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Cliente"].ToString();
                this.txtCuentaCompletaCliente.Text = frm.BusquedaPropiedadReglonRes["Numero_Cuenta"].ToString();
                this.TxtObservaciones.Text = frm.BusquedaPropiedadReglonRes["Observaciones"].ToString();
                this.TxtImporte.Text = frm.BusquedaPropiedadReglonRes["SubTotal"].ToString();
                decimal Importe = Math.Round(Convert.ToDecimal(TxtImporte.Text.Trim()), 2);
                this.TxtImporte.Text = String.Format("{0:N2}", Importe);
                this.Txt_Subtotal.Text = frm.BusquedaPropiedadReglonRes["SubTotal"].ToString();
                decimal Subtotal = Math.Round(Convert.ToDecimal(Txt_Subtotal.Text.Trim()), 2);
                this.Txt_Subtotal.Text = String.Format("{0:N2}", Subtotal);
                this.Txt_Porcentaje_IVA.Text = frm.BusquedaPropiedadReglonRes["Porcentaje_Iva"].ToString();
                this.Txt_Total_IVA.Text = frm.BusquedaPropiedadReglonRes["IVA"].ToString();
                this.Txt_Porcentaje_Retencion.Text = frm.BusquedaPropiedadReglonRes["Porcentaje_Retencion"].ToString();
                this.Txt_Total_Retencion.Text = frm.BusquedaPropiedadReglonRes["Retencion"].ToString();
                this.TxtTotal.Text = frm.BusquedaPropiedadReglonRes["Monto_Total"].ToString();
                decimal PorcentajeIVA = Convert.ToDecimal(Txt_Porcentaje_IVA.Text.ToString());
                decimal IVA = Convert.ToDecimal(Txt_Total_IVA.Text);
                decimal PorcentajeRetencion = Convert.ToDecimal(Txt_Porcentaje_Retencion.Text.ToString());
                decimal Retencion = Convert.ToDecimal(Txt_Porcentaje_Retencion.Text);
                decimal Total = Convert.ToDecimal(TxtTotal.Text);
                this.Txt_Porcentaje_IVA.Text = Math.Round(PorcentajeIVA, 2).ToString();
                this.Txt_Total_IVA.Text = Math.Round(IVA, 2).ToString();
                this.Txt_Porcentaje_Retencion.Text = Math.Round(PorcentajeRetencion, 2).ToString();
                this.Txt_Total_Retencion.Text = Math.Round(Retencion, 2).ToString();
                this.TxtTotal.Text = Math.Round(Total, 2).ToString();
                LblUsuarioAutorizo.Visible = true;
                Txt_Usuario_Autoriza.Visible = true;
                LblUsuarioGenero.Visible = true;
                Txt_Usuario_Genero.Visible = true;
            }

        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (Convert.ToInt32(Cbx_Motivo_Nota_Credito.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL MOTIVO DE NOTA DE CARGO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbx_Motivo_Nota_Credito.Focus();
                return false;
            }
            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarOficina.Focus();
                return false;
            }
            if (Convert.ToInt32(cbxAlmacen.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR ALMACÉN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }
            if (txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return false;
            }
            //if (txtClaveCuentaOrigen.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA SELECCIONAR LA CUENTA ORIGEN DE CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btnBuscaCuentaOrigen.Focus();
            //    return false;
            //}
            if (Convert.ToDecimal(TxtImporte.Text) <= 0)
            {
                MessageBox.Show("EL TOTAL DE LA NOTA DEBE DE SER MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtImporte.Focus();
                return false;
            }
            if (txtFactura.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFactura.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            Txt_Usuario_Genero.Text = string.Empty;
            Txt_Usuario_Autoriza.Text = string.Empty;
            DtpFechaGeneracion.Value = DateTime.Now;
            txtClaveOficina.Text = string.Empty;
            txtOficina.Text = string.Empty;
            K_Oficina = 0;
            k_Almacen = 0;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;
            Cbx_Motivo_Nota_Credito.DataSource = null;
            Cbx_Motivo_Nota_Credito.Items.Clear();
            Cbx_Motivo_Nota_Credito.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Motivo_Nota_Credito.AutoCompleteMode = AutoCompleteMode.None;
            Cbx_Tipo_Fiscal.DataSource = null;
            Cbx_Tipo_Fiscal.Items.Clear();
            Cbx_Tipo_Fiscal.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Tipo_Fiscal.AutoCompleteMode = AutoCompleteMode.None;
            txtClaveCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtClaveCuentaOrigen.Text = string.Empty;
            txtCuentaCompletaCliente.Text = string.Empty;
            TxtObservaciones.Text = string.Empty;
            TxtImporte.Text = string.Empty;
            Txt_Subtotal.Text = string.Empty;
            Txt_Porcentaje_IVA.Text = string.Empty;
            Txt_Total_IVA.Text = string.Empty;
            Txt_Porcentaje_Retencion.Text = string.Empty;
            Txt_Total_Retencion.Text = string.Empty;
            TxtTotal.Text = string.Empty;

        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_Oficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
                MtdCargaAlmacen();
            }
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            if (filtra.K_Cliente_Seleccionado == 0)
            {
                txtClaveCliente.Text = string.Empty;
                txtCliente.Text = string.Empty;
            }
            else if (filtra.K_Cliente_Seleccionado != 0 && filtra.D_Cliente_Seleccionado != "")
            {
                txtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
                txtCliente.Text = filtra.D_Cliente_Seleccionado;
            }
        }
        private void btnBuscaCuentaOrigen_Click(object sender, EventArgs e)
        {
            if(txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL CLIENTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbx_Motivo_Nota_Credito.Focus();
                return;
            }
            DataTable dtCuentasCliente = sqlCatalogos.Sk_Cliente_Cuentas(Convert.ToInt32(txtClaveCliente.Text.Trim()));

            Busquedas.BuscaClientesCuentas frm = new Busquedas.BuscaClientesCuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentasCliente);
            frm.BusquedaPropiedadTablaFiltra = dtCuentasCliente;
            frm.BusquedaPropiedadTitulo = "Busca Cuentas de Clientes";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Cliente"].ToString();
                txtCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["Numero_Cuenta"].ToString();
                txtCuentaCompletaCliente.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();

            }
        }
        private void TxtImporte_Enter(object sender, EventArgs e)
        {
            this.TxtImporte.BackColor = Color.FromArgb(128, 255, 128);
            this.TxtImporte.ForeColor = Color.Black;
        }
        private void TxtImporte_Leave(object sender, EventArgs e)
        {
            this.TxtImporte.ForeColor = Color.Black;
            this.TxtImporte.BackColor = Color.White;
            decimal Importe = Math.Round(Convert.ToDecimal(TxtImporte.Text.Trim()), 2);
            this.TxtImporte.Text = String.Format("{0:N2}", Importe);
            this.Txt_Subtotal.Text = String.Format("{0:N2}", Importe);
            DataRow rowImpuestos = dtImpuestos.Rows[0];
            decimal PorcentajeIVA = Convert.ToDecimal(rowImpuestos[2].ToString());
            decimal IVA = (PorcentajeIVA / 100) * Convert.ToDecimal(Txt_Subtotal.Text);
            decimal Total = IVA + Convert.ToDecimal(Txt_Subtotal.Text);
            this.Txt_Porcentaje_IVA.Text = Math.Round(PorcentajeIVA, 2).ToString();
            this.Txt_Total_IVA.Text = Math.Round(IVA, 2).ToString();
            this.TxtTotal.Text = Math.Round(Total, 2).ToString();


        }
        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref e);
        }
        private void MtdCargaAlmacen()
        {
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;
            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = SQLCATALOGOS.Sk_Almacenes(K_Oficina);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "[Seleccionar[";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
                cbxAlmacen.SelectedIndex = 1;
            }

        }
        private void MtdCargaTiposMotivos()
        {
            Cbx_Motivo_Nota_Credito.DataSource = null;
            Cbx_Motivo_Nota_Credito.Items.Clear();
            Cbx_Motivo_Nota_Credito.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Motivo_Nota_Credito.AutoCompleteMode = AutoCompleteMode.None;

            dtTiposMotivos = SQLCATALOGOS.Sk_Motivos_Nota_Credito();

            if (dtTiposMotivos != null)
            {
                DataRow dr = dtTiposMotivos.NewRow();

                dr["K_Motivo_Nota_Credito"] = 0;
                dr["D_Motivo_Nota_Credito"] = "[Seleccionar]";
          
                dtTiposMotivos.Rows.InsertAt(dr, 0);
                dtTiposMotivos.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtTiposMotivos, ref Cbx_Motivo_Nota_Credito, "K_Motivo_Nota_Credito", "D_Motivo_Nota_Credito", indice);

                Cbx_Motivo_Nota_Credito.SelectedIndex = 1;
            }
        }
        private void MtdCargaTipoFiscal()
        {
            Cbx_Tipo_Fiscal.DataSource = null;
            Cbx_Tipo_Fiscal.Items.Clear();
            Cbx_Tipo_Fiscal.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Tipo_Fiscal.AutoCompleteMode = AutoCompleteMode.None;

            dtTipoFiscal = SQLCATALOGOS.Sk_Tipo_Fiscal();

            if (dtTiposMotivos != null)
            {
                DataRow dr = dtTipoFiscal.NewRow();

                dr["K_Tipo_Fiscal"] = 0;
                dr["D_Tipo_Fiscal"] = "[Seleccionar]";

                dtTipoFiscal.Rows.InsertAt(dr, 0);
                dtTipoFiscal.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtTipoFiscal, ref Cbx_Tipo_Fiscal, "K_Tipo_Fiscal", "D_Tipo_Fiscal", indice);

                Cbx_Tipo_Fiscal.SelectedIndex = 1;
            }
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveCliente.Focus();
                return;
            }

            CUENTASXCOBRAR.FRM_BUSCA_FACTURA frm = new CUENTASXCOBRAR.FRM_BUSCA_FACTURA();
            frm.K_Cliente = Convert.ToInt32(txtClaveCliente.Text);
            frm.D_Cliente = txtCliente.Text;
            frm.ShowDialog();

        }
        private void Txt_Porcentaje_IVA_Enter(object sender, EventArgs e)
        {
            this.Txt_Porcentaje_IVA.BackColor = Color.FromArgb(128, 255, 128);
            this.Txt_Porcentaje_IVA.ForeColor = Color.Black;
        }
        private void Txt_Porcentaje_IVA_Leave(object sender, EventArgs e)
        {
            this.Txt_Porcentaje_IVA.ForeColor = Color.Black;
            this.Txt_Porcentaje_IVA.BackColor = Color.White;
            decimal PorcentajeIVA = Convert.ToDecimal(Txt_Porcentaje_IVA.Text);
            decimal IVA = (PorcentajeIVA / 100) * Convert.ToDecimal(Txt_Subtotal.Text);
            decimal Total = IVA + Convert.ToDecimal(Txt_Subtotal.Text);
            this.Txt_Porcentaje_IVA.Text = Math.Round(PorcentajeIVA, 2).ToString();
            this.Txt_Total_IVA.Text = Math.Round(IVA, 2).ToString();
            this.TxtTotal.Text = Math.Round(Total, 2).ToString();
        }
        private void Txt_Porcentaje_IVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref e);
        }
        private void Txt_Porcentaje_Retencion_Enter(object sender, EventArgs e)
        {
            this.Txt_Porcentaje_Retencion.BackColor = Color.FromArgb(128, 255, 128);
            this.Txt_Porcentaje_Retencion.ForeColor = Color.Black;
        }
        private void Txt_Porcentaje_Retencion_Leave(object sender, EventArgs e)
        {
            this.Txt_Porcentaje_Retencion.ForeColor = Color.Black;
            this.Txt_Porcentaje_Retencion.BackColor = Color.White;
            decimal PorcentajeRetencion = Convert.ToDecimal(Txt_Porcentaje_Retencion.Text);
            decimal Retencion = (PorcentajeRetencion / 100) * Convert.ToDecimal(Txt_Subtotal.Text);
            decimal Total = Retencion + Convert.ToDecimal(Txt_Total_IVA.Text) + Convert.ToDecimal(Txt_Subtotal.Text);
            this.Txt_Porcentaje_Retencion.Text = Math.Round(PorcentajeRetencion, 2).ToString();
            this.Txt_Total_Retencion.Text = Math.Round(Retencion, 2).ToString();
            this.TxtTotal.Text = Math.Round(Total, 2).ToString();
        }
        private void Txt_Porcentaje_Retencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref e);
        }
    }
}
