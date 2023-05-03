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


namespace ProbeMedic.FACTURACION
{
    public partial class FRM_REGISTRO_FACTURAS : FormaBase
    {
        Funciones fx = new Funciones();
        Procesos Procesos = new Procesos();
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sql = new SQLVentas();
        SQLVentas sqlVentas = new SQLVentas();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLPedidos sqlPedidos = new SQLPedidos();

        DataTable dtArticulos = new DataTable();
        DataTable dtEncabezado = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtAseguradora = new DataTable();
        DataTable dtPacientes = new DataTable();
        DataTable dtOficinasEmpresa = new DataTable();
        DataTable dtSerie = new DataTable();

        int KTipoProducto = 0;
        string DTipoProducto = string.Empty;
        int KUnidadMedida = 0;
        string DUnidadMedida = string.Empty;
        string sKU = string.Empty;
        int KArticulo = 0;
        string DArticulo = string.Empty;
        decimal PrecioUnitario = 0;
        decimal PSubtotal = 0;
        decimal pTotalIva = 0;
        Int32 PIva = 0; 

        Int32 K_Oficina = 0;
        private Int32 K_Paciente_Direccion = 0;
        public int K_Paciente_Direccion1 { get => K_Paciente_Direccion; set => K_Paciente_Direccion = value; }

        private Int32 K_Medico = 0;
        public int K_Medico1 { get => K_Medico; set => K_Medico= value; }

        private Int32 k_Cliente_Domicilio_Fiscal = 0;
        public int K_Cliente_Domicilio_Fiscal1 { get => k_Cliente_Domicilio_Fiscal; set => k_Cliente_Domicilio_Fiscal = value; }

        public int K_Uso_CFDIInt { get; set; }
        public string D_Uso_CFDIString { get; set; }
        public string D_SerieString { get; set; }
        public int K_Forma_PagoInt { get; set; }
        public string D_Forma_PagoString { get; set; }

        public int K_FacturaInt { get; set; }

        bool B_Error_Entrar = false;
        bool B_NoEntrar = false;

        int res;
        string msg = string.Empty;

        public FRM_REGISTRO_FACTURAS()
        {
            InitializeComponent();
            ucClientes1.PropertyChanged += new PropertyChangedEventHandler(ucClientes1_PropertyChanged);
        }

        private void FRM_REGISTRO_FACTURAS_Load(object sender, EventArgs e)
        {
            if (!ValidaTengaSeries())
            {
                MessageBox.Show("EL USUARIO NO TIENE SERIES ASIGNADAS. NO PODRA FACTURAR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }
        }

        private void FRM_REGISTRO_FACTURAS_Shown(object sender, EventArgs e)
        {
            if (!B_Error_Entrar)
            {
                CargaAlmacen();

                if (!ValidaPuedeCambiarSerie())
                {
                    txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                    btnBuscarSerie.Enabled = false;
                    txtSerie.Enabled = false;
                }
                else
                {
                    txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                    btnBuscarSerie.Enabled = true;
                    txtSerie.Enabled = true;
                }
                if (GlobalVar.B_CambiaDatosFiscales)
                    btnCambiarFiscal.Enabled = true;
                else
                    btnCambiarFiscal.Enabled = false;
                dtOficinasEmpresa = sqlCatalogos.Sk_Oficina(GlobalVar.K_Empresa);
                CargaOficinaInicial();
                CargaAlmacen();
                //WindowState = FormWindowState.Maximized;
            }
            else
            {
                Close();
            }
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            base.BaseMetodoInicio();

            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonGuardar.Text = "Facturar [F5]";
            BaseBotonGuardar.Image = Properties.Resources.Aceptar;

            BaseBotonCancelar.Visible = true;
            BaseBotonCancelar.Enabled = true;

            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonReporte.Text = "Reimprimir Factura";
            BaseBotonReporte.ToolTipText = "Reimprimir Factura";
            BaseBotonReporte.Width = 120;

            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar Datos Capturados en Pantalla";
            dtArticulos = FacturaDetalle_Type;

            ucClientes1.txt_Cliente.BackColor = Color.White;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.BackColor = Color.White;

            pnlCoaseguro.Enabled = false;
            //pnlDetalle.Enabled = false;

            grdDetalle.AutoGenerateColumns = false;

            btn_editar_paciente.Enabled = false;
            btnCambiarFiscal.Enabled = false;
            btnBuscaPaciente.Focus();

            decimal a = Convert.ToDecimal(grdDetalle.Width - 40) / Convert.ToDecimal(11);
            int b = Convert.ToInt32(a);

            grdDetalle.Columns["Mas"].Width = 20;
            grdDetalle.Columns["Menos"].Width = 20;
            grdDetalle.Columns["Cantidad"].Width = b;
            grdDetalle.Columns["K_Articulo"].Width = b;
            grdDetalle.Columns["D_Articulo"].Width = b;
            grdDetalle.Columns["CSKU"].Width = b;
            grdDetalle.Columns["D_Unidad_Medida"].Width = b;
            grdDetalle.Columns["Precio_Unitario"].Width = b;
            grdDetalle.Columns["Descuento"].Width = b;
            grdDetalle.Columns["Subtotal"].Width = b;
            grdDetalle.Columns["Total_IVA"].Width = b;
            grdDetalle.Columns["Total_Detalle"].Width = b;
            grdDetalle.Columns["Comentarios"].Width = b;

            //WindowState = FormWindowState.Maximized;

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarOficina.Focus();
                return false;
            }
            if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }
            if(txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaPaciente.Focus();
                return false;
            }
            if (K_Paciente_Direccion1== 0)
            {
                MessageBox.Show("FALTA SELECCIONAR DIRECCION DEL PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPacienteDireccion.Focus();
                return false;
            }
            if (K_Medico1 == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR MÉDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaMedico.Focus();
                return false;
            }
            if ((txtClaveCliente.Text.Trim().Length == 0) && (txtCliente.Text.Trim().Length==0))
            {
                MessageBox.Show("FALTA SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return false;
            }
            if (K_Cliente_Domicilio_Fiscal1 == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN DOMICILIO FISCAL DEL CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarDomiclioFiscal.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }
            if (!fx.ValidaEmail(txtCorreo.Text))
            {
                MessageBox.Show("Debe capturar una dirección de correo valida...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Text = string.Empty;
                txtCorreo.Focus();
                return false;
            }
            if (grdDetalle.DataSource == null)
            {
                MessageBox.Show("FALTA AGREGAR ARTICULOS A LA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulos.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }


        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())      
                return;
      
            Int32 CampoIdentity = 0;
            K_FacturaInt = 0;
            string msg = string.Empty;

            DataTable dtDetalle = dtArticulos.Copy();
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("D_Unidad_Medida");

            try
            {
                res = 0;
                res = sqlVentas.In_Registro_Factura(ref CampoIdentity, K_Oficina, 4 ,dtpFechaEntrega.Value, 1, 
                    txtTipoCambio.Text.Length > 0 ? Convert.ToDecimal(txtTipoCambio.Text.Trim()) : Convert.ToDecimal(0.00), Convert.ToInt32(txtClaveCliente.Text.Trim()),
                    K_Cliente_Domicilio_Fiscal1, ucCanalDistribucionCliente1.K_Canal_Distribucion, K_Medico1, 
                    txtPorcentajeDescuento.Text.Length > 0 ? Convert.ToDecimal(txtPorcentajeDescuento.Text) : Convert.ToDecimal(0.00),
                    Convert.ToDecimal(txtDescuento.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtTotalIVA.Text),
                    Convert.ToDecimal(txtTotalFactura.Text), GlobalVar.K_Usuario, Convert.ToDecimal(TxtImporteToDec(txtCoaseguro2)),
                    Convert.ToDecimal(txtPorcentajeCoaseguro2.Text), txtObservaciones.Text, GlobalVar.PC_Name,
                    chkRemisionado.Checked, chkSurtidoCompleto.Checked, Convert.ToInt32(cbxAlmacen.SelectedValue),
                    Convert.ToInt32(txtClavePaciente.Text.Trim()), K_Paciente_Direccion1, dtDetalle, null, 0 , "", "" ,false,
                    txtSerie.Text.Trim(),K_Forma_PagoInt,K_Uso_CFDIInt, txtCorreo.Text.Trim(),null,null,ref msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BaseBotonReporte.Visible = false;
                BaseBotonReporte.Enabled = false;
                BaseBotonGuardar.Visible = true;
                BaseBotonGuardar.Enabled = false;
                return;
            }
            else
            {
                BaseErrorResultado = true;
                MessageBox.Show("FACTURA GENERADA CORRECTAMENTE CON NUMERO DE FOLIO: " + CampoIdentity.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
                K_FacturaInt = CampoIdentity;
                BaseBotonGuardar.Visible = true;
                BaseBotonGuardar.Enabled = false;
                //BaseMetodoLimpiaControles();
                //BaseMetodoInicio();
            }
        }

        private void btnBuscarSerie_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dtSerie != null)
            {
                dtSerie.Columns["D_Serie"].SetOrdinal(1);
                dtSerie.Columns["Orden"].SetOrdinal(0);
                dtSerie.AcceptChanges();

                Busquedas.BuscaSeries frm = new Busquedas.BuscaSeries();
                frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtSerie);
                frm.BusquedaPropiedadTablaFiltra = dtSerie;
                if (dtSerie.Rows.Count == 1)
                {
                    D_SerieString = dtSerie.Rows[0]["D_Serie"].ToString();
                    txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();

                    if (!GlobalVar.B_CambiaSerie)
                        btnBuscarSerie.Enabled = false;
                }
                else if (dtSerie.Rows.Count > 1)
                {
                    if (!GlobalVar.B_CambiaSerie)
                    {
                        D_SerieString = dtSerie.Rows[0]["D_Serie"].ToString();
                        txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                        btnBuscarSerie.Enabled = false;
                    }
                    else
                    {
                        frm.BusquedaPropiedadTitulo = "Busca Series";
                        frm.ShowDialog();
                        if (frm.BusquedaPropiedadReglonRes != null)
                        {
                            D_SerieString = frm.BusquedaPropiedadReglonRes[1].ToString();
                            txtSerie.Text = frm.BusquedaPropiedadReglonRes[1].ToString();
                        }
                        else
                        {
                            D_SerieString = string.Empty;
                            txtSerie.Text = string.Empty;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("EL USUARIO NO TIENE ASIGNADAS SERIES!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarSerie.Focus();
            }
            Cursor = Cursors.Default;
        }

        private void btnCFDI_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dt_cfdi = sqlCatalogo.Sk_Uso_CFDI();

            Busquedas.BuscaCFDI frm = new Busquedas.BuscaCFDI();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_cfdi);
            frm.BusquedaPropiedadTablaFiltra = dt_cfdi;

            if (dt_cfdi != null)
            {
                if (dt_cfdi.Rows.Count == 1)
                {
                    K_Uso_CFDIInt = Convert.ToInt32(dt_cfdi.Rows[0]["K_Uso_CFDI"].ToString());
                    D_Uso_CFDIString = dt_cfdi.Rows[0]["D_Uso_CFDI"].ToString();
                    txtCFDI.Text = dt_cfdi.Rows[0]["D_Uso_CFDI"].ToString();
                }
                else if (dt_cfdi.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca USO CFDI";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Uso_CFDIInt = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Uso_CFDI"].ToString());
                        D_Uso_CFDIString = frm.BusquedaPropiedadReglonRes["D_Uso_CFDI"].ToString();
                        txtCFDI.Text = frm.BusquedaPropiedadReglonRes["D_Uso_CFDI"].ToString();
                    }
                    else
                    {
                        K_Uso_CFDIInt = 0;
                        D_Uso_CFDIString = string.Empty;
                        txtCFDI.Text = string.Empty;
                    }

                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCFDI.Focus();
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscaFormaPago_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dt_formapago = sqlCatalogo.Sk_Forma_Pago();

            Busquedas.BuscaFormaPagoFactura frm = new Busquedas.BuscaFormaPagoFactura();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_formapago);
            frm.BusquedaPropiedadTablaFiltra = dt_formapago;

            if (dt_formapago != null)
            {
                if (dt_formapago.Rows.Count == 1)
                {
                    K_Forma_PagoInt = Convert.ToInt32(dt_formapago.Rows[0]["K_Forma_Pago"].ToString());
                    D_Forma_PagoString = dt_formapago.Rows[0]["D_Forma_Pago"].ToString();
                    txtFormaPago.Text = dt_formapago.Rows[0]["D_Forma_Pago"].ToString();
                }
                else if (dt_formapago.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Forma Pago";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Forma_PagoInt = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Forma_Pago"].ToString());
                        D_Forma_PagoString = frm.BusquedaPropiedadReglonRes["D_Forma_Pago"].ToString();
                        txtFormaPago.Text = frm.BusquedaPropiedadReglonRes["D_Forma_Pago"].ToString();
                    }
                    else
                    {
                        K_Forma_PagoInt = 0;
                        D_Forma_PagoString = string.Empty;
                        txtFormaPago.Text = string.Empty;
                    }

                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaFormaPago.Focus();
            }
            Cursor = Cursors.Default;
        }

        public override void BaseBotonCancelarClick()
        {
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClavePaciente.Text = string.Empty;
            txtPaciente.Text = string.Empty;
            txtPacienteDireccion.Text = string.Empty;
            ucMedicos1.K_medico = 0;
            ucMedicos1.txt_Medico.Text = string.Empty;
            K_Medico1 = 0;
            txtMedico.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            ucClientes1.K_Cliente = 0;
            ucClientes1.txt_Cliente.Text = string.Empty;
            txtClaveCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtRFC.Text = string.Empty;
            K_Cliente_Domicilio_Fiscal1 = 0;
            txtDomicilioFiscal.Text = string.Empty;
            ucCanalDistribucionCliente1.K_Canal_Distribucion = 0;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = string.Empty;
            rdbPct.Checked = false;
            rdbFijo.Checked = false;
            rdbSinCoaseguro.Checked = false;
            txtPorcentajeCoaseguro2.Text = string.Empty;
            txtCoaseguro2.Text = string.Empty;
            dtArticulos = null;
            grdDetalle.DataSource = null;
            txtSubtotal.Text = "0.00";
            txtTotalIVA.Text = "0.00";
            txtTotalFactura.Text = "0.00";
            if (!ValidaPuedeCambiarSerie())
            {
                if(dtSerie!=null)
                {
                    if(dtSerie.Rows.Count>0)
                    {
                        txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                        btnBuscarSerie.Enabled = false;
                        txtSerie.Enabled = false;
                    }
                }       
            }
            else
            {
                if (dtSerie != null)
                {
                    if (dtSerie.Rows.Count > 0)
                    {

                        txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                        btnBuscarSerie.Enabled = true;
                        txtSerie.Enabled = true;
                    }
                }
            }
            K_Forma_PagoInt = 0;
            D_Forma_PagoString = string.Empty;
            txtFormaPago.Text = string.Empty;
            K_Uso_CFDIInt = 0;
            D_Uso_CFDIString= string.Empty;
            txtCFDI.Text = string.Empty;
            cbxAlmacen.SelectedValue = 0;

        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOficinasEmpresa);
            frm.BusquedaPropiedadTablaFiltra = dtOficinasEmpresa;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_Oficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
                CargaAlmacen();
            }
            else
            {
                K_Oficina =0;
                txtClaveOficina.Text = string.Empty;
                txtOficina.Text = string.Empty;
                CargaAlmacen();
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FILTROS.Frm_Filtro_Paciente_Pedido frm = new FILTROS.Frm_Filtro_Paciente_Pedido();
            frm.ShowDialog();
            Cursor = Cursors.Default;
            if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                txtClavePaciente.Text = frm.LLave_Seleccionado.ToString();
                txtPaciente.Text = frm.Descripcion_Seleccionado.ToString();
                btn_editar_paciente.Enabled = true;
            }
            else
            {
                txtClavePaciente.Text = string.Empty;
                txtPaciente.Text = string.Empty;
                btn_editar_paciente.Enabled = false;
                BaseMetodoLimpiaControles();
            }
        }

        private void btnBuscarPacienteDireccion_Click(object sender, EventArgs e)
        {

            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PACIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClavePaciente.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            DataTable dtPacientes_direcciones = sqlCatalogo.Sk_Pacientes_Direcciones(Convert.ToInt32(txtClavePaciente.Text.Trim()));

            Busquedas.BuscaPacientesDirecciones frm = new Busquedas.BuscaPacientesDirecciones();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtPacientes_direcciones);
            frm.BusquedaPropiedadTablaFiltra = dtPacientes_direcciones;

            if(dtPacientes_direcciones!=null)
            {
                if(dtPacientes_direcciones.Rows.Count==1)
                {
                    K_Paciente_Direccion1 = Convert.ToInt32(dtPacientes_direcciones.Rows[0]["K_Paciente_Direccion"].ToString());
                    //txtPacienteDireccion.Text = dtPacientes_direcciones.Rows[0]["Direccion_Completo"].ToString();
                    txtPacienteDireccion.Text = dtPacientes_direcciones.Rows[0]["Calle"].ToString() + " EXT. " + dtPacientes_direcciones.Rows[0]["Numero_Exterior"].ToString() + " INT." + dtPacientes_direcciones.Rows[0]["Numero_Interior"].ToString() +
                           " COL." + dtPacientes_direcciones.Rows[0]["D_Colonia"].ToString() + " C.P." + dtPacientes_direcciones.Rows[0]["Codigo_Postal"].ToString() + " " + dtPacientes_direcciones.Rows[0]["D_Ciudad"].ToString() + "," + dtPacientes_direcciones.Rows[0]["D_Estado"].ToString() + "," + dtPacientes_direcciones.Rows[0]["D_Pais"].ToString();
                }
                else if (dtPacientes_direcciones.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Direcciones del Paciente";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Paciente_Direccion1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Paciente_Direccion"].ToString());
                        //txtPacienteDireccion.Text = frm.BusquedaPropiedadReglonRes["Direccion_Completo"].ToString();
                        txtPacienteDireccion.Text = frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " EXT. " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"].ToString() + " INT." + frm.BusquedaPropiedadReglonRes["Numero_Interior"].ToString() +
                          " COL." + frm.BusquedaPropiedadReglonRes["D_Colonia"].ToString() + " C.P." + frm.BusquedaPropiedadReglonRes["Codigo_Postal"].ToString() + " " + frm.BusquedaPropiedadReglonRes["D_Ciudad"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Estado"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Pais"].ToString();
                    }
                    else
                    {
                        K_Paciente_Direccion1 = 0;
                        txtPacienteDireccion.Text = string.Empty;
                    }

                }
            }
            else
            {
                MessageBox.Show("EL PACIENTE NO TIENE DIRECCIONES ASIGNADAS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaPaciente.Focus();
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {

            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PACIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClavePaciente.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            DataTable dtPacientes_medicos = sqlCatalogo.Sk_Pacientes_Medicos(Convert.ToInt32(txtClavePaciente.Text.Trim()));

            Busquedas.BuscaMedicos frm = new Busquedas.BuscaMedicos();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtPacientes_medicos);
            frm.BusquedaPropiedadTablaFiltra = dtPacientes_medicos;

            if (dtPacientes_medicos != null)
            {
                if (dtPacientes_medicos.Rows.Count == 1)
                {
                    K_Medico1 = Convert.ToInt32(dtPacientes_medicos.Rows[0]["K_Medico"].ToString());
                    txtMedico.Text = dtPacientes_medicos.Rows[0]["Medico"].ToString();
                }
                else if (dtPacientes_medicos.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Medicos del Paciente";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Medico1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Medico"].ToString());
                        txtMedico.Text = frm.BusquedaPropiedadReglonRes["Medico"].ToString();
                    }
                    else
                    {
                        K_Medico1 = 0;
                        txtMedico.Text = string.Empty;
                    }

                }
            }
            else
            {
                MessageBox.Show("EL PACIENTE NO TIENE MEDICOS ASIGNADOS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaPaciente.Focus();
            }
            Cursor = Cursors.Default;

        }

        private void btnBuscarDomiclioFiscal_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text.Trim().Length==0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            DataTable dt_domicilios_fiscales = sqlCatalogo.Sk_Cliente_Domicilios_Fiscales(Convert.ToInt32(txtClaveCliente.Text.Trim()));

            Busquedas.BuscaDomicilioFiscalCliente frm = new Busquedas.BuscaDomicilioFiscalCliente();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_domicilios_fiscales);
            frm.BusquedaPropiedadTablaFiltra = dt_domicilios_fiscales;

            if (dt_domicilios_fiscales != null)
            {
                if (dt_domicilios_fiscales.Rows.Count == 1)
                {
                    K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(dt_domicilios_fiscales.Rows[0]["K_Cliente_Domicilio_Fiscal"]);
                    txtDomicilioFiscal.Text = dt_domicilios_fiscales.Rows[0]["Calle"].ToString() + " EXT. " + dt_domicilios_fiscales.Rows[0]["Numero_Exterior"].ToString() + " INT." + dt_domicilios_fiscales.Rows[0]["Numero_Interior"].ToString() +
                        " COL." + dt_domicilios_fiscales.Rows[0]["D_Colonia"].ToString() + " C.P." + dt_domicilios_fiscales.Rows[0]["Codigo_Postal"].ToString() + " " + dt_domicilios_fiscales.Rows[0]["D_Ciudad"].ToString() + "," + dt_domicilios_fiscales.Rows[0]["D_Estado"].ToString() + ","+ dt_domicilios_fiscales.Rows[0]["D_Pais"].ToString();
                }
                else if (dt_domicilios_fiscales.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Domicilios Fiscales del Cliente";
                    frm.ShowDialog();

                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente_Domicilio_Fiscal"]);
                        txtDomicilioFiscal.Text= frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " EXT. " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"].ToString() + " INT." + frm.BusquedaPropiedadReglonRes["Numero_Interior"].ToString() +
                        " COL." + frm.BusquedaPropiedadReglonRes["D_Colonia"].ToString() + " C.P." + frm.BusquedaPropiedadReglonRes["Codigo_Postal"].ToString() + " " + frm.BusquedaPropiedadReglonRes["D_Ciudad"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Estado"].ToString() + ","+frm.BusquedaPropiedadReglonRes["D_Pais"].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("EL CLIENTE NO TIENE DOMICILIOS FISCALES ASIGNADAS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaPaciente.Focus();        
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscaCelula_Click(object sender, EventArgs e)
        {
            //Busquedas.Frm_Busca_Celulas frm = new Busquedas.Frm_Busca_Celulas();
            //frm.ShowDialog();

            //K_Celula1 = frm.LLave_Seleccionado;
            //txtKCelula.Text = frm.LLave_Seleccionado.ToString();
            //txtCelula.Text = frm.Descripcion_Seleccionado;

            //MtdCargaAseguradora();
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo_Clientes frm = new FILTROS.Frm_Filtro_Articulo_Clientes();
            frm.ShowDialog();

            KTipoProducto = frm.K_Tipo_Producto_Seleccioado;
            DTipoProducto = frm.D_Tipo_Producto_Seleccionado;
            KUnidadMedida = frm.K_Unidad_Medida_Seleccionado;
            DUnidadMedida = frm.D_Unidad_Medida_Seleccionado;
            sKU = frm.SKU_Seleccionado;
            KArticulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            DArticulo = frm.Descripcion_Seleccionado;
            PrecioUnitario = Convert.ToDecimal(frm.Precio_Unitario_Seleccionado);
            PSubtotal = Convert.ToDecimal(frm.SubTotal_Seleccionado);
            pTotalIva = Convert.ToDecimal(frm.Total_IvaSeleccionado);
            PIva = frm.Iva_Seleccionado;

            btnAgregar.Enabled = true;
            txtCantidad.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("SELECCIONE UN ARTICULO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtArticulo.Focus();
                return;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR LA CANTIDAD DE ARTICULOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            if (txtCantidad.Text.Trim().Length == 0 )
            {
                MessageBox.Show("CAPTURE LA CANTIDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }


            DataRow dr;
            dr = dtArticulos.NewRow();

            dr["Cantidad"] = txtCantidad.Text;
            dr["K_Tipo_Producto"] = KTipoProducto;
            dr["K_Unidad_Medida"] = KUnidadMedida;
            dr["SKU"] = sKU;
            dr["K_Articulo"] = KArticulo;
            dr["Precio_Unitario"] = Convert.ToDecimal(PrecioUnitario);
            dr["PorcentajeDescuento"] = 0;
            dr["Descuento"] = 0;
            dr["Subtotal"] = (PSubtotal * Convert.ToInt32(txtCantidad.Text)); 
            dr["Tasa_IVA"] = (Convert.ToDecimal(PIva)); 
            dr["Total_IVA"] = (Convert.ToDecimal(pTotalIva) * Convert.ToInt32(txtCantidad.Text)); 
            dr["Total_Detalle"] = (Convert.ToDecimal(PrecioUnitario) * Convert.ToInt32(txtCantidad.Text));
            dr["Comentarios"] = "";
            dr["B_Facturado"] = 0;
            dr["D_Articulo"] = DArticulo;
            dr["D_Unidad_Medida"] = DUnidadMedida;


            if (ChecaMismoArticulo(dtArticulos, KArticulo))
            {
                MessageBox.Show("YA EXISTE AGREGADO EL ARTÍCULO " + txtArticulo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                dtArticulos.Rows.Add(dr);

            grdDetalle.DataSource = dtArticulos;
            

            B_NoEntrar = true;
            grdDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
            //grdDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdDetalle.MultiSelect = false;

            Calcula_Totales();
            LimpiaInformacionArticulo();

            btnAgregar.Enabled = false;
            txtCantidad.Enabled = false;

            CargarPacientes();
            rdbPct.Checked = true;
            pnlCoaseguro.Enabled = true;
        }

        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                if (grdDetalle.Columns[e.ColumnIndex].Name == "Mas")
                {
                    Mtd_Incrementar(sender, e);

                }
                else if (grdDetalle.Columns[e.ColumnIndex].Name == "Menos")
                {
                    Mtd_Disminuir(sender, e);
                }
            }
           
        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void txtTasaIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void txtPorcentajeDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void txtbox_coaseguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void txt_box_porcentaje_coaseguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void txtPorcentajeCoaseguro2_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }

        private void txtCoaseguro2_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
        }

        private void rdbPct_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPct.Checked == true)
            {
                txtCoaseguro2.ReadOnly = true;
                CargarPacientes();
                CalculaCoaseguroPct(Convert.ToDecimal(txtPorcentajeCoaseguro2.Text.Trim()));
            }
        }

        private void rdbFijo_CheckedChanged(object sender, EventArgs e)
        {

            txtPorcentajeCoaseguro2.Text = "0";
            txtCoaseguro2.Text = "0";
            txtCoaseguro2.ReadOnly = false;
            txtCoaseguro2.Text = TxtImporteToStr(txtCoaseguro2);
            txtCoaseguro2.Focus();
        }

        private void rdbSinCoaseguro_CheckedChanged(object sender, EventArgs e)
        {
            txtPorcentajeCoaseguro2.Text = "0";
            txtCoaseguro2.Text = "0.00";
            txtCoaseguro2.Text = TxtImporteToStr(txtCoaseguro2);
        }

        private void txtClavePaciente_TextChanged(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void txtCoaseguro2_Leave(object sender, EventArgs e)
        {
            if (rdbFijo.Checked == true)
            {
                decimal TotalCoaseguro = Convert.ToDecimal(TxtImporteToDec(txtCoaseguro2));
                decimal TotalFactura = Convert.ToDecimal(TxtImporteToDec(txtTotalFactura));
                decimal PorcentajeCoaseguro = ((TotalCoaseguro * 100) / TotalFactura);
                txtPorcentajeCoaseguro2.Text = Convert.ToString(Math.Round(PorcentajeCoaseguro));
                txtCoaseguro2.Text = TxtImporteToStr(txtCoaseguro2);
            }
            if (txtCoaseguro2.Text.Trim().Length == 0)
            {
                txtCoaseguro2.Text = "0.00";
                txtCoaseguro2.Text = TxtImporteToStr(txtCoaseguro2);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            //if (txtCantidad.Text.Trim().Length > 0)
            //{
            //    if (Convert.ToDecimal(txtCantidad.Text.Trim()) == 0)
            //    {
            //        MessageBox.Show("VALOR NO VÁLIDO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtCantidad.Text = string.Empty;
            //        txtCantidad.Focus();
            //    }
            //}
        }

        private void CargaAlmacen()
        {
            dtAlmacen = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;
            if (K_Oficina > 0)
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(K_Oficina);
            }
        
            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void CargaOficinaInicial()
        {
            K_Oficina = GlobalVar.K_Oficina;
            txtClaveOficina.Text = Convert.ToString(K_Oficina);

            txtOficina.Text = GlobalVar.D_Oficina;
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
            K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
        }

        private void CargarPacientes()
        {
            if (txtClavePaciente.Text.Trim().Length > 0)
            {
                int K_PacienteInt = Convert.ToInt32(txtClavePaciente.Text.Trim());

                dtPacientes = sqlVentas.Sk_Consulta_Paciente(K_PacienteInt);

                if ((dtPacientes != null))
                {
                    if((dtPacientes.Rows.Count > 0))
                    {
                        DataRow row = dtPacientes.Rows[0];
                        if (row["K_Paciente_Direccion"].ToString() == "")
                        {
                            MessageBox.Show("EL PACIENTE NO TIENE DIRECCIONES ASIGNADAS. \r\n" +
                               "CAPTURE DIRECCIONES EN EL CATALOGO DE PACIENTES. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        K_Paciente_Direccion = Convert.ToInt32(row["K_Paciente_Direccion"].ToString());
                        txtPacienteDireccion.Text = row["Calle"].ToString()+ " EXT. "+ row["Numero_Exterior"].ToString()+ " INT."+ row["Numero_Interior"].ToString()+
                            " COL."+ row["D_Colonia"].ToString()+ " C.P."+ row["Codigo_Postal"].ToString()+ " " +row["D_Ciudad"].ToString() + "," + row["D_Estado"].ToString() + "," + row["D_Pais"].ToString();                      
                        ucMedicos1.K_medico = row["K_Medico"].ToString() != "" ? Convert.ToInt32(row["K_Medico"].ToString()) : 0;
                        ucMedicos1.txt_Medico.Text = row["Nombre_Medico"].ToString() != "" ? row["Nombre_Medico"].ToString() : string.Empty;
                        K_Medico1 = row["K_Medico"].ToString() != "" ? Convert.ToInt32(row["K_Medico"].ToString()) : 0;
                        txtMedico.Text = row["Nombre_Medico"].ToString() != "" ? row["Nombre_Medico"].ToString() : string.Empty;
                        //ucClientes1.K_Cliente = row["K_Cliente"].ToString() != "" ? Convert.ToInt32(row["K_Cliente"].ToString()) : 0;
                        //ucClientes1.txt_Cliente.Text = row["D_Cliente"].ToString() != "" ? row["D_Cliente"].ToString() : string.Empty;
                        //txtClaveCliente.Text = row["K_Cliente"].ToString() != "" ? row["K_Cliente"].ToString() : string.Empty;
                        //txtCliente.Text = row["D_Cliente"].ToString() != "" ? row["D_Cliente"].ToString() : string.Empty;
                        //ucCanalDistribucionCliente1.K_Canal_Distribucion = row["K_Canal_Distribucion"].ToString() != null ? Convert.ToInt32(row["K_Canal_Distribucion"].ToString()) : 0;
                        //ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = row["D_Canal_Distribucion"].ToString() != null ? row["D_Canal_Distribucion"].ToString() : string.Empty;
                        //k_Cliente_Domicilio_Fiscal = row["K_Cliente_Domicilio_Fiscal"].ToString() != "" ? Convert.ToInt32(row["K_Cliente_Domicilio_Fiscal"].ToString()) : 0;
                        //txtDomicilioFiscal.Text = row["D_Domicilio_Fiscal"].ToString() != "" ? row["D_Domicilio_Fiscal"].ToString() : string.Empty;
                        //pnlDetalle.Enabled = true;
                        if (dtArticulos != null)
                        {
                            if (dtArticulos.Rows.Count > 0)
                            {
                                decimal Porcentaje_Coaseguro = row["Porcentaje_Coaseguro"].ToString() != "" ? Math.Round(Convert.ToDecimal(row["Porcentaje_Coaseguro"].ToString()), 0) : 0;
                                txtPorcentajeCoaseguro2.Text = Convert.ToString(Porcentaje_Coaseguro);
                            }
                        }
                    }
                                                            
                }
            }
        }

        private void CalculaCoaseguroPct(decimal Porcentaje_Coaseguro)
        {
            decimal Total_Pedido = Convert.ToDecimal(txtTotalFactura.Text);
            decimal Coaseguro = (Porcentaje_Coaseguro / 100) * (Total_Pedido);
            txtCoaseguro2.Text =  Convert.ToString(Coaseguro);
            txtCoaseguro2.Text = TxtImporteToStr(txtCoaseguro2);
        }

        private bool ChecaMismoArticulo(DataTable dt, int K_Articulo)
        {
            bool b_mismo = false;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["K_Articulo"].ToString()) == K_Articulo)
                {
                    b_mismo = true;
                    break;
                }
            }
            return b_mismo;
        }

        private void Calcula_Totales()
        {

            //Calculamos el IVA de todos los artículos
            var x = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Total_IVA"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    txtTotalIVA.Text = Math.Round(x, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el SUBTOTAL de todos los artículos
            var z = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Subtotal"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    txtSubtotal.Text = Math.Round(z, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el TOTAL del pedido
            decimal totalPedido = x + z;
            txtTotalFactura.Text = Math.Round(totalPedido, 2).ToString("N2");

            if (rdbPct.Checked == true)
            {
                CalculaCoaseguroPct(Convert.ToDecimal(txtPorcentajeCoaseguro2.Text));
            }


        }

        private bool ValidaTengaSeries()
        {
            dtSerie = sqlCatalogo.SK_UsuaSerieAsig(GlobalVar.K_Usuario);

            if (dtSerie == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidaPuedeCambiarSerie()
        {
            res = 0;
            res = sqlPedidos.Gp_ValidaPuedaCambiarSerie(GlobalVar.K_Usuario);

            if (res == -1)
            {
                if (msg.Length > 0)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            return true;

        }

        private void LimpiaInformacionArticulo()
        {
            KTipoProducto = 0;
            DTipoProducto = string.Empty;
            KUnidadMedida = 0;
            DUnidadMedida = string.Empty;
            sKU = string.Empty;
            KArticulo = 0;
            PrecioUnitario = 0;
            txtArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void valida_decimal(object sender, ref KeyPressEventArgs e)
        {
            int res;
            if (e.KeyChar == (char)Keys.Back
            || e.KeyChar == (char)Keys.Delete
            || e.KeyChar == (char)Keys.Left
            || e.KeyChar == (char)Keys.Right
            || int.TryParse(e.KeyChar.ToString(), out res))
            {
                TextBox obj = sender as TextBox;

                if (e.KeyChar == '.' && obj.Text.IndexOf('.') > 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;


        }

        public void Mtd_Incrementar(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r =>
            {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + decimal.Parse(r["Tasa_IVA"].ToString())));
                r["Total_Detalle"] = decimal.Parse(r["Subtotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());

            });

            Calcula_Totales();

            grdDetalle.DataSource = dtArticulos;
        }

        public void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r =>
            {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) - 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + decimal.Parse(r["Tasa_IVA"].ToString())));
                r["Total_Detalle"] = decimal.Parse(r["Subtotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());
                if (int.Parse(r["Cantidad"].ToString()) == 0)
                {
                    dtArticulos.Rows[e.RowIndex].Delete();
                }
            });


            Calcula_Totales();

            grdDetalle.DataSource = dtArticulos;
        }

        public string TxtImporteToStr(System.Windows.Forms.TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(ref txtImporte));
          
            return dblImporte.ToString("C");
            
        }

        public string TxtImporteToDec(System.Windows.Forms.TextBox txtImporte)
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

        private void grdDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA PRECIO UNITARIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void grdDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = grdDetalle.CurrentRow;
            if (ren != null)
            {
                if (blnCeldaImportes())
                {
                    CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);
                }
            }
        }

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grdDetalle_KeyPress);
            e.Control.TextChanged += new EventHandler(grdDetalle_TextChanged);
        }

        private void grdDetalle_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length > 0)
            {
                decimal valor = 0;
                if (!Decimal.TryParse(textBox.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = "0.00";
                }
            }

        }

        private void grdDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!grdDetalle.CurrentCell.IsInEditMode)
                {
                    grdDetalle.BeginEdit(true);
                    return;
                }
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;
                    if ((textBox.Text.Trim().Length == 0) && (e.KeyChar.ToString() == "."))
                    {
                        e.Handled = true;
                    }

                    if (Convert.ToDecimal((Boolean)(textBox.Text.Length == 0) ? "0" : textBox.Text.Replace("$", "0")) == 0)
                    {
                        e.Handled = false;
                        return;
                    }
                    string[] parts = textBox.Text.Split('.'); // result.Split('.');

                    if (parts.Length > 1)
                    {
                        if ((parts[1].Length > 1 && parts.Length > 2) && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }


                }
                else
                    e.Handled = true;
            }
        }

        private bool blnCeldaImportes()
        {
            if (grdDetalle.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return ((grdDetalle.CurrentCell.ColumnIndex == 7));
        }
        private void CambiaCantidades(Int32 IndiceColumna, DataGridViewRow ren, Int32 IndiceRegistro)
        {
            if (!EsNumero(Convert.ToDecimal(ren.Cells["Precio_Unitario"].Value)))
            {
                MessageBox.Show("LA COLUMNA PRECIO UNITARIO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }
            decimal Unitario = 0;
            decimal Cantidad = 0;
            decimal Importe = 0;
            decimal SubTotal = 0;
            decimal TotalIVA = 0;
            decimal Porcentaje = 0;

            if (ren.Cells["Precio_Unitario"].Value != null)
                Unitario = Math.Round(Convert.ToDecimal(ren.Cells["Precio_Unitario"].Value), 2);
            if (ren.Cells["Cantidad"].Value != null)
                Cantidad = Convert.ToDecimal(ren.Cells["Cantidad"].Value);
            if (ren.Cells["Tasa_IVA"].Value != null)
                Porcentaje = Convert.ToDecimal(ren.Cells["Tasa_IVA"].Value);

            ren.Cells["Precio_Unitario"].Value = Unitario;

            SubTotal = Math.Round(Cantidad * Unitario, 2);
            TotalIVA = Math.Round(SubTotal * Porcentaje / 100, 2);
            Importe = SubTotal + TotalIVA;

            grdDetalle.Rows[IndiceRegistro].Cells["Subtotal"].Value = SubTotal;
            grdDetalle.Rows[IndiceRegistro].Cells["Total_Detalle"].Value = Importe;
            grdDetalle.Rows[IndiceRegistro].Cells["Total_IVA"].Value = TotalIVA;
            Calcula_Totales();
        }

        private void btn_editar_paciente_Click(object sender, EventArgs e)
        {
            CATALOGOS.PACIENTES.FRM_EDITAR_PACIENTE frm = new CATALOGOS.PACIENTES.FRM_EDITAR_PACIENTE();
            frm.K_Paciente = Convert.ToInt32(txtClavePaciente.Text.Trim());
            frm.Nombre_Actual = txtPaciente.Text.Trim();
            frm.ShowDialog();
            if (frm.Nombre_Nuevo != null)
            {
                txtPaciente.Text = frm.Nombre_Nuevo;
            }
        }

        public override void BaseBotonReporteClick()
        {
            Cursor = Cursors.WaitCursor;
            Procesos.Genera_PDF(txtSerie.Text.Trim(), K_FacturaInt.ToString());
            Cursor = Cursors.Default;
        }

        private void grdDetalle_Resize(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(grdDetalle.Width - 40) / Convert.ToDecimal(11);
            int b = Convert.ToInt32(a);

            grdDetalle.Columns["Mas"].Width = 20;
            grdDetalle.Columns["Menos"].Width = 20;
            grdDetalle.Columns["Cantidad"].Width = b;
            grdDetalle.Columns["K_Articulo"].Width = b;
            grdDetalle.Columns["D_Articulo"].Width = b;
            grdDetalle.Columns["CSKU"].Width = b;
            grdDetalle.Columns["D_Unidad_Medida"].Width = b;
            grdDetalle.Columns["Precio_Unitario"].Width = b;
            grdDetalle.Columns["Descuento"].Width = b;
            grdDetalle.Columns["Subtotal"].Width = b;
            grdDetalle.Columns["Total_IVA"].Width = b;
            grdDetalle.Columns["Total_Detalle"].Width = b;
            grdDetalle.Columns["Comentarios"].Width = b;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Length>0)
            {
                Int32 valor = 0;

                if(!Int32.TryParse(txtCantidad.Text.Trim(),out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Text = string.Empty;
                    txtCantidad.Focus();
                }
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                btnAgregar.PerformClick();
            }
        }

        private void btnCambiarFiscal_Click(object sender, EventArgs e)
        {
            CATALOGOS.FRM_EDITAR_CLIENTE frm = new CATALOGOS.FRM_EDITAR_CLIENTE();
            frm.K_Cliente = Convert.ToInt32(txtClaveCliente.Text.Trim());
            frm.Nombre_Actual = txtCliente.Text.Trim();
            frm.RFC_Actual = txtRFC.Text.Trim();
            frm.ShowDialog();
            if (frm.Nombre_Nuevo != null)
            {
                txtClaveCliente.Text = txtClaveCliente.Text.Trim();
                txtCliente.Text = frm.Nombre_Nuevo;

                DataTable dt = sqlCatalogos.Sk_Clientes_All(Convert.ToInt32(txtClaveCliente.Text.Trim()), string.Empty, GlobalVar.K_Empresa);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtRFC.Text = dt.Rows[0]["RFC"].ToString();
                    }
                    else
                    {
                        txtRFC.Text = string.Empty;
                    }
                }
                else
                {
                    txtRFC.Text = string.Empty;
                }
            }

        }
        private void ucClientes1_PropertyChanged(object sender, EventArgs e)
        {
            if (ucClientes1.K_Cliente != 0)
            {
                if(GlobalVar.B_CambiaDatosFiscales)
                     btnCambiarFiscal.Enabled = true;
                else
                    btnCambiarFiscal.Enabled = false;

                DataTable dt = sqlCatalogos.Sk_Clientes_All(ucClientes1.K_Cliente, string.Empty, GlobalVar.K_Empresa);

                if(dt!=null)
                {
                    if(dt.Rows.Count>0)
                    {
                        txtRFC.Text = dt.Rows[0]["RFC"].ToString();
                    }
                    else
                    {
                        txtRFC.Text = string.Empty;
                    }
                }
                else
                {
                    txtRFC.Text = string.Empty;
                }
                K_Cliente_Domicilio_Fiscal1 = 0;
                txtDomicilioFiscal.Text = string.Empty;
                
            }
            else
            {
                btnCambiarFiscal.Enabled = false;
                txtRFC.Text = string.Empty;
                K_Cliente_Domicilio_Fiscal1 = 0;
                txtDomicilioFiscal.Text = string.Empty;
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
                btnCambiarFiscal.Enabled = false;
                txtRFC.Text = string.Empty;
                K_Cliente_Domicilio_Fiscal1 = 0;
                txtDomicilioFiscal.Text = string.Empty;
            }
            else if (filtra.K_Cliente_Seleccionado != 0 && filtra.D_Cliente_Seleccionado != "")
            {
                txtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
                txtCliente.Text = filtra.D_Cliente_Seleccionado.ToString();

                if (GlobalVar.B_CambiaDatosFiscales)
                    btnCambiarFiscal.Enabled = true;
                else
                    btnCambiarFiscal.Enabled = false;

                DataTable dt = sqlCatalogos.Sk_Clientes_All(filtra.K_Cliente_Seleccionado, string.Empty, GlobalVar.K_Empresa);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtRFC.Text = dt.Rows[0]["RFC"].ToString();
                    }
                    else
                    {
                        txtRFC.Text = string.Empty;
                    }
                }
                else
                {
                    txtRFC.Text = string.Empty;
                }
                K_Cliente_Domicilio_Fiscal1 = 0;
                txtDomicilioFiscal.Text = string.Empty;
            }
        }
    }
}
