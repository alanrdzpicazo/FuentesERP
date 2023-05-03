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
    public partial class FRM_REGISTRA_FACTURAS_PEDIDOS : FormaBase
    {
        SQLPedidos sqlPedidos = new SQLPedidos();
        SQLVentas sqlVentas = new SQLVentas();
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        Funciones fx = new Funciones();
        Procesos Procesos = new Procesos();
   
        DataTable dtPedidos = new DataTable();
        DataTable dtSerie = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtLotes = new DataTable();
        DataTable dtArticulosLotes = new DataTable();

        int res;
        string msg = string.Empty;

        bool B_Error_Entrar = false;
        bool B_NoEntrar = false;

        public List<int> LstFolios = new List<int>();

        public int K_FacturaInt { get; set; }

        #region PROPIEDADES GET AND SET
        public int K_Tipo_Venta { get; set; }
        public DataTable dtEncabezado { get; set; }
        public DataTable dtArticulos { get; set; }
        public int K_OficinaInt { get; set; }
        public string D_OficinaString { get; set; }
        public int K_AlmacenInt { get; set; }
        public int K_MedicoInt { get; set; }
        public string D_MedicoString { get; set; }
        public int K_PacienteInt { get; set; }
        public string D_PacienteString { get; set; }
        public int K_Paciente_DireccionInt { get; set; }
        public string D_Paciente_DireccionString { get; set; }
        public int K_ClienteInt { get; set; }
        public string D_ClienteString { get; set; }
        public int K_Cliente_Domicilio_FiscalInt { get; set; }
        public string D_Cliente_Domicilio_FiscalString { get; set; }
        public int K_Uso_CFDIInt { get; set; }
        public string D_Uso_CFDIString { get; set; }
        public string D_SerieString { get; set; }
        public int K_Forma_PagoInt { get; set; }
        public string D_Forma_PagoString { get; set; }
        public int K_Canal_DistribucionInt { get; set; }
        public string D_Canal_DistrbucionString { get; set; }
        public DateTime F_EntregaDate { get; set; }
        public string ObservacionesString { get; set; }
        public int K_PedidoInt { get; set; }
        public string FolioString { get; set; }
        public string SiniestroString { get; set; }
        public string ReclamacionString { get; set; }
        public string CoaseguroString { get; set; }
        public decimal PorcentajeDescuentoDecimal { get; set; }
        public decimal CoaseguroDecimal { get; set; }
        public decimal PorcentajeCoaseguroDecimal { get; set; }
        public decimal SubtotalDecimal { get; set; }
        public decimal Total_IVADecimal { get; set; }
        public decimal DescuentolDecimal { get; set; }
        public decimal Total_PedidoDecimal { get; set; }
        public Int32 K_AsesorInt { get; set; }
        public string NombreString { get; set; }
        public DateTime F_Vencimiento { get; set; }
        public string CartaString { get; set; }
        public string PolizaString { get; set; }
        public string CelulaString { get; set; }
        public int K_CelulaInt { get; set; }
        public bool B_Remisionado { get; set; }
        public bool B_SurtidoCompleto { get; set; }
        public bool B_Precio_Unitario{ get; set; }
        #endregion

        public FRM_REGISTRA_FACTURAS_PEDIDOS()
        {
            InitializeComponent();
            grdDetalle.AutoGenerateColumns = false;
        }

        private void FRM_REGISTRA_FACTURAS_PEDIDOS_Load(object sender, EventArgs e)
        {
            if (!validaTengaSeries())
            {
                MessageBox.Show("EL USUARIO NO TIENE SERIES ASIGNADAS. NO PODRA FACTURAR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }
        }

        private void FRM_REGISTRA_FACTURAS_PEDIDOS_Shown(object sender, EventArgs e)
        {
            if (!B_Error_Entrar)
            {
                cargaAlmacen();
                cargaPedido();

                if (dtArticulos != null)
                {
                    B_NoEntrar =true;
                    if (grdDetalle.ReadOnly)
                        grdDetalle.ReadOnly = false;
                    grdDetalle.DataSource = dtArticulos;
                    grdDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
                    //grdDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    grdDetalle.MultiSelect = false;

                    if ((!cbxRemisionado.Checked) && (!cbxSurtidoCompleto.Checked))
                    {
                        grdDetalle.Columns["Sel_Lote"].Visible = true;
                    }
                    else{
                        grdDetalle.Columns["Sel_Lote"].Visible = false;
                    }
                }
                else
                {
                    B_NoEntrar = false;
                }

                dtPedidos.Columns.Add("K_Pedido", typeof(Int32));

                if(!validaPuedeCambiarSerie())
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
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            base.BaseMetodoInicio();

            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonGuardar.Image = Properties.Resources.Aceptar;
            BaseBotonGuardar.Text = "Facturar [F5]";

            ucCelulas1.txt_D_Celula.BackColor = Color.White;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.BackColor = Color.White;

            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonReporte.Text = "Reimprimir Factura";
            BaseBotonReporte.ToolTipText = "Reimprimir Factura";
            BaseBotonReporte.Width = 120;

            //dtLotes = DetalleVentaPrivadaType;

            if (grdDetalle.Columns["Sel_Lote"].Visible)
            {
                decimal a = Convert.ToDecimal(grdDetalle.Width - 100) / Convert.ToDecimal(12);
                int b = Convert.ToInt32(a);

                grdDetalle.Columns["Cantidad"].Width = b;
                grdDetalle.Columns["K_Articulo"].Width = b;
                grdDetalle.Columns["D_Articulo"].Width = b;
                grdDetalle.Columns["CSKU"].Width = b;
                grdDetalle.Columns["Sel_Lote"].Width = 100;
                grdDetalle.Columns["D_Tipo_Producto"].Width = b;
                grdDetalle.Columns["D_Unidad_Medida"].Width = b;
                grdDetalle.Columns["Precio_Unitario"].Width = b;
                grdDetalle.Columns["Descuento"].Width = b;
                grdDetalle.Columns["Subtotal"].Width = b;
                grdDetalle.Columns["Total_IVA"].Width = b;
                grdDetalle.Columns["Total_Detalle"].Width = b;
                grdDetalle.Columns["Comentarios"].Width = b;
            }
            else
            {
                decimal a = Convert.ToDecimal(grdDetalle.Width) / Convert.ToDecimal(12);
                int b = Convert.ToInt32(a);

                grdDetalle.Columns["Cantidad"].Width = b;
                grdDetalle.Columns["K_Articulo"].Width = b;
                grdDetalle.Columns["D_Articulo"].Width = b;
                grdDetalle.Columns["CSKU"].Width = b;
                grdDetalle.Columns["D_Tipo_Producto"].Width = b;
                grdDetalle.Columns["D_Unidad_Medida"].Width = b;
                grdDetalle.Columns["Precio_Unitario"].Width = b;
                grdDetalle.Columns["Descuento"].Width = b;
                grdDetalle.Columns["Subtotal"].Width = b;
                grdDetalle.Columns["Total_IVA"].Width = b;
                grdDetalle.Columns["Total_Detalle"].Width = b;
                grdDetalle.Columns["Comentarios"].Width = b;

            }

            K_Uso_CFDIInt = 27;
            txtCFDI.Text = "GASTOS EN GENERAL";
            K_Forma_PagoInt = 24;
            txtFormaPago.Text = "POR DEFINIR";

            gbMetodoPago.Visible = false;

        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;
            dtPedidos.Rows.Clear();
            foreach (var item in LstFolios)
            {
                dtPedidos.Rows.Add(item);
            }

            Int32 CampoIdentity = 0;
            string msg = string.Empty;

            DataTable dtDetalle = dtArticulos.Copy();
            dtDetalle.Columns.Remove("K_Pedido_Detalle");
            dtDetalle.Columns.Remove("K_Pedido");
            dtDetalle.Columns.Remove("D_Tipo_Producto");
            dtDetalle.Columns.Remove("K_Sustancia_Activa");
            dtDetalle.Columns.Remove("D_Sustancia_Activa");
            dtDetalle.Columns.Remove("K_Laboratorio");
            dtDetalle.Columns.Remove("D_Laboratorio");
            dtDetalle.Columns.Remove("D_Unidad_Medida");
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("B_Remisionado");
            dtDetalle.Columns["Cantidad"].SetOrdinal(0);
            dtDetalle.Columns["K_Tipo_Producto"].SetOrdinal(1);
            dtDetalle.Columns["K_Unidad_Medida"].SetOrdinal(2);
            dtDetalle.Columns["SKU"].SetOrdinal(3);
            dtDetalle.Columns["K_Articulo"].SetOrdinal(4);
            dtDetalle.Columns["Precio_Unitario"].SetOrdinal(5);
            dtDetalle.Columns["Porcentaje_Descuento"].SetOrdinal(6);
            dtDetalle.Columns["Descuento"].SetOrdinal(7);
            dtDetalle.Columns["Subtotal"].SetOrdinal(8);
            dtDetalle.Columns["Tasa_IVA"].SetOrdinal(9);
            dtDetalle.Columns["Total_IVA"].SetOrdinal(10);
            dtDetalle.Columns["Total_Detalle"].SetOrdinal(11);
            dtDetalle.Columns["Comentarios"].SetOrdinal(12);
            dtDetalle.Columns["B_Facturado"].SetOrdinal(13);
       
            try
            {
                res = 0;

                if ((!cbxRemisionado.Checked) && (!cbxSurtidoCompleto.Checked))
                {
                    DataTable dtLotes = dtArticulosLotes.Copy();
                    dtLotes.Columns.Remove("SKU");
                    dtLotes.Columns.Remove("Cantidad_Disponible");
                    dtLotes.Columns.Remove("Cantidad_Kgs");
                    dtLotes.Columns.Remove("f_movimiento");
                    dtLotes.Columns.Remove("k_almacen");
                    dtLotes.Columns.Remove("d_almacen");

                    dtLotes.Columns["k_articulo"].ColumnName = "K_Articulo";
                    dtLotes.Columns["Cantidad_Asignada"].ColumnName = "Cantidad";
                    dtLotes.Columns["No_Lote"].ColumnName = "Lote";

                    dtLotes.Columns["K_Articulo"].SetOrdinal(0);
                    dtLotes.Columns["Lote"].SetOrdinal(1);
                    dtLotes.Columns["F_Caducidad"].SetOrdinal(2);
                    dtLotes.Columns["Cantidad"].SetOrdinal(3);
                    dtLotes.Columns["K_Movimiento_Inventario"].SetOrdinal(4);
                    dtLotes.Columns["K_Pedido"].SetOrdinal(5);
                    dtLotes.Columns["K_Pedido_Detalle"].SetOrdinal(6);
                    dtLotes.AcceptChanges();

                  
                    res = sqlVentas.In_Registro_Factura(ref CampoIdentity, K_OficinaInt, 1, dtpFechaEntrega.Value, 1, Convert.ToDecimal(1.00), ucClientes1.K_Cliente,
                                K_Cliente_Domicilio_FiscalInt, ucCanalDistribucionCliente1.K_Canal_Distribucion,
                                ucMedicos1.K_medico, Convert.ToDecimal(txtPorcentajeDescuento.Text.Length > 0 ? txtPorcentajeDescuento.Text : "0"),
                                Convert.ToDecimal(txtDescuento.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtTotalIVA.Text),
                                Convert.ToDecimal(txtTotalFactura.Text), GlobalVar.K_Usuario, Convert.ToDecimal(txtCoaseguro.Text),
                                Convert.ToDecimal(txtPorcentajeCoaseguro.Text), txtObservaciones.Text, GlobalVar.PC_Name, cbxRemisionado.Checked,
                                cbxSurtidoCompleto.Checked, Convert.ToInt32(cbxAlmacen.SelectedValue), ucPacientes1.K_Paciente, K_Paciente_DireccionInt,
                                dtDetalle, dtPedidos, ucCelulas1.K_Celula, txtCarta.Text, txtPoliza.Text, true, txtSerie.Text.Trim(), K_Forma_PagoInt, K_Uso_CFDIInt,
                                txtCorreo.Text.Trim(), dtLotes,rdbPPD.Checked ? true : false, ref msg);
                }
                else
                {
                    res = sqlVentas.In_Registro_Factura(ref CampoIdentity, K_OficinaInt, 2, dtpFechaEntrega.Value, 1, Convert.ToDecimal(1.00), ucClientes1.K_Cliente,
                               K_Cliente_Domicilio_FiscalInt, ucCanalDistribucionCliente1.K_Canal_Distribucion,
                               ucMedicos1.K_medico, Convert.ToDecimal(txtPorcentajeDescuento.Text.Length > 0 ? txtPorcentajeDescuento.Text : "0"),
                               Convert.ToDecimal(txtDescuento.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtTotalIVA.Text),
                               Convert.ToDecimal(txtTotalFactura.Text), GlobalVar.K_Usuario, Convert.ToDecimal(txtCoaseguro.Text),
                               Convert.ToDecimal(txtPorcentajeCoaseguro.Text), txtObservaciones.Text, GlobalVar.PC_Name, cbxRemisionado.Checked,
                               cbxSurtidoCompleto.Checked, Convert.ToInt32(cbxAlmacen.SelectedValue), ucPacientes1.K_Paciente, K_Paciente_DireccionInt,
                               dtDetalle, dtPedidos, ucCelulas1.K_Celula, txtCarta.Text, txtPoliza.Text, true, txtSerie.Text.Trim(), K_Forma_PagoInt,K_Uso_CFDIInt,
                               txtCorreo.Text.Trim(), null,null, ref msg);
                }
                

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
                BaseBotonGuardar.Enabled = true;
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("FACTURA GENERADA CORRECTAMENTE CON NUMERO DE FOLIO: " + CampoIdentity.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
                BaseBotonGuardar.Visible = true;
                BaseBotonGuardar.Enabled = false;
                K_FacturaInt = CampoIdentity;
            }
        }

        private void btnBuscarSerie_Click(object sender, EventArgs e)
        {
            if (dtSerie != null)
            {
                Cursor = Cursors.WaitCursor;
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

        private void cargaAlmacen()
        {
            if (K_OficinaInt == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes(K_OficinaInt);
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

        private void cargaPedido()
        {  
            if(LstFolios.Count > 0)
            {
                foreach(var objeto in LstFolios)
                {                
                    txtFolio.Text +=  objeto.ToString()+",";
                }
                txtFolio.Text = txtFolio.Text.TrimEnd(',');
            }

            ucMedicos1.K_medico = K_MedicoInt;
            ucMedicos1.txt_Medico.Text = D_MedicoString;
            ucPacientes1.K_Paciente = K_PacienteInt;
            ucPacientes1.txt_Paciente.Text = D_PacienteString;
            if ((ucPacientes1.K_Paciente > 0) && (K_PacienteInt > 0) && (ucPacientes1.txt_Paciente.Text.Trim().Length > 0) && (D_PacienteString.Length > 0))
            {
                btn_editar_paciente.Enabled = true;
                txtCarta.Enabled = true;
                txtReclamacion.Enabled = true;
                txtSiniestro.Enabled = true;
                txtPoliza.Enabled = true;
                ucCelulas1.Enabled = true;
                gbMetodoPago.Visible = false;
            }            
            else
            {
                btn_editar_paciente.Enabled = false;
                txtCarta.Enabled = false;
                txtReclamacion.Enabled = false;
                txtSiniestro.Enabled = false;
                txtPoliza.Enabled = false;
                ucCelulas1.Enabled = false;
                gbMetodoPago.Visible = true;
                rdbPPD.Checked = true;
            }
              
            txtAsesor.Text = NombreString;
            ucCanalDistribucionCliente1.K_Canal_Distribucion = K_Canal_DistribucionInt;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = D_Canal_DistrbucionString;
            ucCelulas1.K_Celula = K_CelulaInt;
            ucCelulas1.txt_D_Celula.Text = CelulaString;
            txtObservaciones.Text = ObservacionesString;
            cbxSurtidoCompleto.Checked = B_SurtidoCompleto;
            cbxRemisionado.Checked = B_Remisionado;
            txtClaveOficina.Text = K_OficinaInt.ToString();
            txtOficina.Text = D_OficinaString;
            cbxAlmacen.SelectedValue = K_AlmacenInt;
            ucClientes1.K_Cliente = K_ClienteInt;
            ucClientes1.txt_Cliente.Text = D_ClienteString;
            txtDomicilioFiscal.Text = D_Cliente_Domicilio_FiscalString;

            if (K_ClienteInt != 0)
            {
                if (GlobalVar.B_CambiaDatosFiscales)
                    btnCambiarFiscal.Enabled = true;
                else
                    btnCambiarFiscal.Enabled = false;

                DataTable dt = sqlCatalogos.Sk_Clientes_All(ucClientes1.K_Cliente, string.Empty, GlobalVar.K_Empresa);

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
            else
            {
                btnCambiarFiscal.Enabled = false;
                txtRFC.Text = string.Empty;
            }

            dtpVencimiento.Value = F_Vencimiento;
            txtPorcentajeDescuento.Text = PorcentajeDescuentoDecimal.ToString();
            txtDescuento.Text = CoaseguroDecimal.ToString();
            txtCoaseguro.Text = CoaseguroDecimal.ToString();
            txtPorcentajeCoaseguro.Text = PorcentajeCoaseguroDecimal.ToString();
            txtSubtotal.Text = SubtotalDecimal.ToString();
            txtTotalIVA.Text = Total_IVADecimal.ToString();
            txtTotalFactura.Text = Total_PedidoDecimal.ToString();   
            calculaTotales();         
        }

        private void calculaTotales()
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
            decimal totalPedido = x + z - Convert.ToDecimal(txtCoaseguro.Text);
            txtTotalFactura.Text = Math.Round(totalPedido, 2).ToString("N2");

        }

        private bool validaTengaSeries()
        {
            dtSerie = sqlCatalogo.SK_UsuaSerieAsig(GlobalVar.K_Usuario);

            if(dtSerie == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validaPuedeCambiarSerie()
        {
            res = 0;
            res = sqlPedidos.Gp_ValidaPuedaCambiarSerie(GlobalVar.K_Usuario);

            if(res ==-1)
            {
                if(msg.Length>0)
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

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grdDetalle_KeyPress);
            e.Control.TextChanged += new EventHandler(grdDetalle_TextChanged);
        }

        private void grdDetalle_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text.Trim().Length>0)
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

            return ((grdDetalle.CurrentCell.ColumnIndex == 7) || (grdDetalle.CurrentCell.ColumnIndex == 9));
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
            calculaTotales();


        }

        private void btn_editar_paciente_Click(object sender, EventArgs e)
        {
            CATALOGOS.PACIENTES.FRM_EDITAR_PACIENTE frm = new CATALOGOS.PACIENTES.FRM_EDITAR_PACIENTE();
            frm.K_Paciente = ucPacientes1.K_Paciente;
            frm.Nombre_Actual = ucPacientes1.txt_Paciente.Text.Trim();
            frm.ShowDialog();
            if(frm.Nombre_Nuevo!=null)
            {
                ucPacientes1.txt_Paciente.Text = frm.Nombre_Nuevo;
            }
            
        }

        public override void BaseBotonReporteClick()
        {
            Cursor = Cursors.WaitCursor;
            Procesos.Genera_PDF(txtSerie.Text.Trim(),K_FacturaInt.ToString());
            Cursor = Cursors.Default;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if((cbxRemisionado.Checked)&&(cbxSurtidoCompleto.Checked))
            {
                if (ucCelulas1.K_Celula == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR CELULA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ucCelulas1.Focus();
                    return false;
                }          
            }
            else if (dtArticulosLotes == null)
            {
                MessageBox.Show("FALTA ASIGNAR LOTES A LOS ARTICULOS DE LA FACTURA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDetalle.Rows[0].Cells["Sel_Lote"].Selected = true;
                return false;
            }
            else if(dtArticulosLotes.Rows.Count==0)
            {
                MessageBox.Show("FALTA ASIGNAR LOTES A LOS ARTICULOS DE LA FACTURA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDetalle.Rows[0].Cells["Sel_Lote"].Selected = true;
                return false;
            }

            if (ucCanalDistribucionCliente1.K_Canal_Distribucion == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CANAL DE DISTRIBUCION..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCanalDistribucionCliente1.Focus();
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

            BaseErrorResultado = false;
            return true;
        }

        private void grdDetalle_Resize(object sender, EventArgs e)
        {
            if (grdDetalle.Columns["Sel_Lote"].Visible)
            {
                decimal a = Convert.ToDecimal(grdDetalle.Width - 100) / Convert.ToDecimal(12);
                int b = Convert.ToInt32(a);

                grdDetalle.Columns["Cantidad"].Width = b;
                grdDetalle.Columns["K_Articulo"].Width = b;
                grdDetalle.Columns["D_Articulo"].Width = b;
                grdDetalle.Columns["CSKU"].Width = b;
                grdDetalle.Columns["Sel_Lote"].Width = 100;
                grdDetalle.Columns["D_Tipo_Producto"].Width = b;
                grdDetalle.Columns["D_Unidad_Medida"].Width = b;
                grdDetalle.Columns["Precio_Unitario"].Width = b;
                grdDetalle.Columns["Descuento"].Width = b;
                grdDetalle.Columns["Subtotal"].Width = b;
                grdDetalle.Columns["Total_IVA"].Width = b;
                grdDetalle.Columns["Total_Detalle"].Width = b;
                grdDetalle.Columns["Comentarios"].Width = b;

            }
            else
            {
                decimal a = Convert.ToDecimal(grdDetalle.Width) / Convert.ToDecimal(12);
                int b = Convert.ToInt32(a);

                grdDetalle.Columns["Cantidad"].Width = b;
                grdDetalle.Columns["K_Articulo"].Width = b;
                grdDetalle.Columns["D_Articulo"].Width = b;
                grdDetalle.Columns["CSKU"].Width = b;
                grdDetalle.Columns["D_Tipo_Producto"].Width = b;
                grdDetalle.Columns["D_Unidad_Medida"].Width = b;
                grdDetalle.Columns["Precio_Unitario"].Width = b;
                grdDetalle.Columns["Descuento"].Width = b;
                grdDetalle.Columns["Subtotal"].Width = b;
                grdDetalle.Columns["Total_IVA"].Width = b;
                grdDetalle.Columns["Total_Detalle"].Width = b;
                grdDetalle.Columns["Comentarios"].Width = b;

            }
        }

        private void grdDetalle_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 4)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdDetalle.Cursor = Cursors.Hand;
            else
                grdDetalle.Cursor = Cursors.Default;
        }

        private void cargaInventarioArticulo(Int32 p_K_Oficina,Int32 p_K_Almacen,Int32 p_K_Articulo)
        {
            dtLotes = null;
            dtLotes = sqlVentas.Gp_InventarioxArticulo(p_K_Oficina, p_K_Almacen, p_K_Articulo);

            if (dtLotes != null)
            {
                if(dtLotes.Rows.Count>0)
                {
                    grdDetalle.DataSource = dtLotes;
                }              
            }
            else
            {
                BaseBotonCancelar.Visible = false;
                BaseBotonCancelar.Enabled = false;
                MessageBox.Show("No Existe Inventario Disponible del Artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                Int32 K_Articulo = Convert.ToInt32(grdDetalle.Rows[index].Cells["K_Articulo"].Value);
                string D_Articulo = grdDetalle.Rows[index].Cells["D_Articulo"].Value.ToString();
                Int32 K_Pedido = Convert.ToInt32(grdDetalle.Rows[index].Cells["K_Pedido"].Value);
                Int32 K_Pedido_Detalle = Convert.ToInt32(grdDetalle.Rows[index].Cells["K_Pedido_Detalle"].Value);

                if (e.ColumnIndex == 4)
                {
                    Cursor = Cursors.WaitCursor;
                    Frm_VP_Asigna_Inventario frm = new Frm_VP_Asigna_Inventario();
                    frm.p_K_Oficina = Convert.ToInt32(txtClaveOficina.Text.Trim());
                    frm.p_D_Oficina = txtClaveOficina.Text.Trim();
                    frm.p_K_Almacen = Convert.ToInt32(cbxAlmacen.SelectedValue);
                    frm.p_D_Almacen = "( "+cbxAlmacen.SelectedValue.ToString() +" ) - "+ cbxAlmacen.Text.ToString();
                    frm.p_K_Articulo = K_Articulo;
                    frm.p_D_Articulo = D_Articulo;
                    frm.p_Cantidad_Solicitada= Convert.ToInt32(grdDetalle.Rows[index].Cells["Cantidad"].Value.ToString());
                    frm.p_K_Pedido = K_Pedido;
                    frm.p_K_Pedido_Detalle = K_Pedido_Detalle;
                    frm.dtTransferidos = dtArticulosLotes;
                    frm.ShowDialog();
                    if (frm.dtResultado != null)
                    {
                        if (dtArticulosLotes == null)
                        {
                            dtArticulosLotes = frm.dtResultado.Clone();
                        }
                        //dtArticulosLotes.Rows.Clear();
                        dtArticulosLotes.Merge(frm.dtResultado);
                        grdDetalleLotes.DataSource = dtArticulosLotes;
                    }
                }
                Cursor = Cursors.Default;
                //DataTable datos = (DataTable)al_tablas_lotes[index];
                //Frm_Captura_Lotes frm_Captura_lote = new Frm_Captura_Lotes(datos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnBuscarDomiclioFiscal_Click(object sender, EventArgs e)
        {
            if (ucClientes1.K_Cliente == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucClientes1.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            DataTable dt_domicilios_fiscales = sqlCatalogo.Sk_Cliente_Domicilios_Fiscales(ucClientes1.K_Cliente);

            Busquedas.BuscaDomicilioFiscalCliente frm = new Busquedas.BuscaDomicilioFiscalCliente();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_domicilios_fiscales);
            frm.BusquedaPropiedadTablaFiltra = dt_domicilios_fiscales;

            if (dt_domicilios_fiscales != null)
            {
                if (dt_domicilios_fiscales.Rows.Count == 1)
                {
                    K_Cliente_Domicilio_FiscalInt = Convert.ToInt32(dt_domicilios_fiscales.Rows[0]["K_Cliente_Domicilio_Fiscal"]);
                    txtDomicilioFiscal.Text = dt_domicilios_fiscales.Rows[0]["Calle"].ToString() + " EXT. " + dt_domicilios_fiscales.Rows[0]["Numero_Exterior"].ToString() + " INT." + dt_domicilios_fiscales.Rows[0]["Numero_Interior"].ToString() +
                        " COL." + dt_domicilios_fiscales.Rows[0]["D_Colonia"].ToString() + " C.P." + dt_domicilios_fiscales.Rows[0]["Codigo_Postal"].ToString() + " " + dt_domicilios_fiscales.Rows[0]["D_Ciudad"].ToString() + "," + dt_domicilios_fiscales.Rows[0]["D_Estado"].ToString() + "," + dt_domicilios_fiscales.Rows[0]["D_Pais"].ToString();
                }
                else if (dt_domicilios_fiscales.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Domicilios Fiscales del Cliente";
                    frm.ShowDialog();

                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Cliente_Domicilio_FiscalInt = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente_Domicilio_Fiscal"]);
                        txtDomicilioFiscal.Text = frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " EXT. " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"].ToString() + " INT." + frm.BusquedaPropiedadReglonRes["Numero_Interior"].ToString() +
                        " COL." + frm.BusquedaPropiedadReglonRes["D_Colonia"].ToString() + " C.P." + frm.BusquedaPropiedadReglonRes["Codigo_Postal"].ToString() + " " + frm.BusquedaPropiedadReglonRes["D_Ciudad"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Estado"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Pais"].ToString();
                    }
                }
            }
            else
            {

                MessageBox.Show("EL CLIENTE NO TIENE DOMICILIOS FISCALES ASIGNADOS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarDomiclioFiscal.Focus();

            }
            Cursor = Cursors.Default;
        }

        private void btnCambiarFiscal_Click(object sender, EventArgs e)
        {
            CATALOGOS.FRM_EDITAR_CLIENTE frm = new CATALOGOS.FRM_EDITAR_CLIENTE();
            frm.K_Cliente = ucClientes1.K_Cliente;
            frm.Nombre_Actual = ucClientes1.txt_Cliente.Text.Trim();
            frm.RFC_Actual = txtRFC.Text.Trim();
            frm.ShowDialog();
            if (frm.Nombre_Nuevo != null)
            {
                ucClientes1.K_Cliente = ucClientes1.K_Cliente;
                ucClientes1.txt_Cliente.Text = frm.Nombre_Nuevo;

                DataTable dt = sqlCatalogos.Sk_Clientes_All(ucClientes1.K_Cliente, string.Empty, GlobalVar.K_Empresa);

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

        private void txtCoaseguro_Leave(object sender, EventArgs e)
        {
            calculaTotales();
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
