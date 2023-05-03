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
    public partial class    Frm_Factura_Farmacia : FormaBase
    {
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLPedidos sqlPedidos = new SQLPedidos();

        DataTable dtArticulos = new DataTable();
        DataTable dtEncabezado = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtAseguradora = new DataTable();
        DataTable dtSerie = new DataTable();
        int K_Oficina = 0;

        private Int32 k_Cliente_Domicilio_Fiscal = 0;
        public int K_Cliente_Domicilio_Fiscal1 { get => k_Cliente_Domicilio_Fiscal; set => k_Cliente_Domicilio_Fiscal = value; }
        public int K_Uso_CFDIInt { get; set; }
        public string D_Uso_CFDIString { get; set; }
        public string D_SerieString { get; set; }
        public int K_Forma_PagoInt { get; set; }
        public string D_Forma_PagoString { get; set; }
        public int K_ClienteInt { get; set; }
        public string D_ClienteString { get; set; }

        int res;
        string msg = string.Empty;
        bool B_Error_Entrar = false;
        bool B_NoEntrar = false;

        public Frm_Factura_Farmacia()
        {
            InitializeComponent();
        }

        private void Frm_Factura_Farmacia_Load(object sender, EventArgs e)
        {
            if (!ValidaTengaSeries())
            {
                MessageBox.Show("EL USUARIO NO TIENE SERIES ASIGNADAS. NO PODRA FACTURAR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }
        }

        private void Frm_Factura_Farmacia_Shown(object sender, EventArgs e)
        {
            if (!B_Error_Entrar)
            {
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
                CargaOficinaInicial();
                CargaAlmacen();            
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
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            base.BaseMetodoInicio();
            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonCancelar.Visible = true;
            BaseBotonCancelar.Enabled = true;
            grdDetalle.AutoGenerateColumns = false;

            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar Datos Capturados en Pantalla";
            dtArticulos = FacturaDetalle_Type;

            ucClientes1.txt_Cliente.BackColor = Color.White;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.BackColor = Color.White;


        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }

            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (txtDomicilioFiscal.Text =="")
            {
                MessageBox.Show("FALTA CAPTURAR DOMICILIO FISCAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDomicilioFiscal.Focus();
                return false;
            }
            if (ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text == "")
            {
                MessageBox.Show("FALTA CAPTURAR CANAL DE DISTRIBUCIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCanalDistribucionCliente1.Focus();
                return false;
            }

            if (txtSerie.Text == "")
            {
                MessageBox.Show("FALTA CAPTURAR LA SERIE DE FACTURACIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }

            if (txtFormaPago.Text == "")
            {
                MessageBox.Show("FALTA CAPTURAR LA FORMA DE PAGO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFormaPago.Focus();
                return false;
            }

            if (txtCFDI.Text == "")
            {
                MessageBox.Show("FALTA CAPTURAR EL USO DE CFDI..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCFDI.Focus();
                return false;
            }




            return true;
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            Int32 CampoIdentity = 0;
            string msg = string.Empty;

            DataTable dtDetalle = dtArticulos.Copy();
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("D_Unidad_Medida");
            dtDetalle.Columns.Remove("K_Detalle_Venta_Articulos");
            dtDetalle.Columns.Remove("K_Transaccion");
            dtDetalle.Columns.Remove("K_Almacen");
            dtDetalle.Columns.Remove("D_Almacen");
            dtDetalle.Columns.Remove("K_Cliente");
            dtDetalle.Columns.Remove("D_Cliente");
            dtDetalle.Columns.Remove("F_Transaccion");
            dtDetalle.Columns.Remove("D_Tipo_Producto");
            dtDetalle.Columns.Remove("K_Oficina");
            dtDetalle.Columns.Remove("D_Oficina");
            dtDetalle.Columns.Remove("B_Credito");
            dtDetalle.Columns.Remove("Total_Factura");
            dtDetalle.Columns.Remove("Subtotal_Factura");
            dtDetalle.Columns.Remove("Descuento_Factura");
            dtDetalle.Columns.Remove("IVA_Factura");
            dtDetalle.Columns.Remove("K_Canal_Distribucion_Cliente");
            dtDetalle.Columns.Remove("D_Canal_Distribucion_Cliente");

            try
            {
                res = 0;
                res = sqlVentas.In_Registro_Factura(ref CampoIdentity, K_Oficina, 3, dtpFechaEntrega.Value, 1,
                                Convert.ToDecimal(0), K_ClienteInt, k_Cliente_Domicilio_Fiscal, ucCanalDistribucionCliente1.K_Canal_Distribucion,
                                0, 0, Convert.ToDecimal(txtDescuento.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtTotalIVA.Text),
                                Convert.ToDecimal(txtTotalFactura.Text), GlobalVar.K_Usuario, Convert.ToDecimal(0), Convert.ToDecimal(0), txtObservaciones.Text,
                                GlobalVar.PC_Name, false, true, Convert.ToInt32(cbxAlmacen.SelectedValue), 0, 0, CbxCredito.Checked, dtDetalle, 
                                txtSerie.Text.Trim(), K_Forma_PagoInt, K_Uso_CFDIInt, txtCorreo.Text.Trim(),Convert.ToInt32(txtTransaccion.Text.Trim() ),ref msg);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE REALIZO EL REGISTRO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtPedido.Text = CampoIdentity.ToString();
                this.Close();
            }
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarDomiclioFiscal_Click(object sender, EventArgs e)
        {
            //DataTable dtDomiciliosFiscales = new DataTable();
            //dtDomiciliosFiscales = sqlCatalogo.Sk_Cliente_Domicilios_Fiscales(K_ClienteInt);

            //Busquedas.BuscaDomicilioFiscalCliente frm = new Busquedas.BuscaDomicilioFiscalCliente();
            //frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtDomiciliosFiscales);
            //frm.BusquedaPropiedadTablaFiltra = dtDomiciliosFiscales;
            //frm.BusquedaPropiedadTitulo = "Busca Domicilios Fiscales Cliente";
            //frm.ShowDialog();

            //if (frm.BusquedaPropiedadReglonRes != null)
            //{
            //    K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente_Domicilio_Fiscal"]);
            //    txtDomicilioFiscal.Text = frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"] + " " + frm.BusquedaPropiedadReglonRes["D_Colonia"] + ", " + frm.BusquedaPropiedadReglonRes["D_Ciudad"] + " " + frm.BusquedaPropiedadReglonRes["D_Estado"];
            //}

            if (K_ClienteInt == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            DataTable dtDomiciliosFiscales = sqlCatalogo.Sk_Cliente_Domicilios_Fiscales(K_ClienteInt);

            Busquedas.BuscaDomicilioFiscalCliente frm = new Busquedas.BuscaDomicilioFiscalCliente();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtDomiciliosFiscales);
            frm.BusquedaPropiedadTablaFiltra = dtDomiciliosFiscales;

            if (dtDomiciliosFiscales != null)
            {
                if (dtDomiciliosFiscales.Rows.Count == 1)
                {
                    K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(dtDomiciliosFiscales.Rows[0]["K_Cliente_Domicilio_Fiscal"]);
                    txtDomicilioFiscal.Text = dtDomiciliosFiscales.Rows[0]["Calle"].ToString() + " EXT. " + dtDomiciliosFiscales.Rows[0]["Numero_Exterior"].ToString() + " INT." + dtDomiciliosFiscales.Rows[0]["Numero_Interior"].ToString() +
                        " COL." + dtDomiciliosFiscales.Rows[0]["D_Colonia"].ToString() + " C.P." + dtDomiciliosFiscales.Rows[0]["Codigo_Postal"].ToString() + " " + dtDomiciliosFiscales.Rows[0]["D_Ciudad"].ToString() + "," + dtDomiciliosFiscales.Rows[0]["D_Estado"].ToString() + "," + dtDomiciliosFiscales.Rows[0]["D_Pais"].ToString();
                }
                else if (dtDomiciliosFiscales.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Domicilios Fiscales del Cliente";
                    frm.ShowDialog();

                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente_Domicilio_Fiscal"]);
                        txtDomicilioFiscal.Text = frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " EXT. " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"].ToString() + " INT." + frm.BusquedaPropiedadReglonRes["Numero_Interior"].ToString() +
                        " COL." + frm.BusquedaPropiedadReglonRes["D_Colonia"].ToString() + " C.P." + frm.BusquedaPropiedadReglonRes["Codigo_Postal"].ToString() + " " + frm.BusquedaPropiedadReglonRes["D_Ciudad"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Estado"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Pais"].ToString();
                    }
                }
            }
            else
            {

                MessageBox.Show("EL CLIENTE NO TIENE DOMICILIOS FISCALES ASIGNADAS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();

            }
            Cursor = Cursors.Default;

        }

        private void btnBuscarSerie_Click(object sender, EventArgs e)
        {
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
        }

        private void btnCFDI_Click(object sender, EventArgs e)
        {
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
        }

        private void btnBuscaFormaPago_Click(object sender, EventArgs e)
        {
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
        }

        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtTransaccion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                //Busca Articulos Existencia, Precio Desc

                dtArticulos = sqlVentas.Sk_Datos_Transaccion(Convert.ToInt32(txtTransaccion.Text));

                if (dtArticulos == null)
                {
                    MessageBox.Show("LA TRANSACCION NO SE ENCUENTRA REGISTRADA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTransaccion.Text = "";
                    txtTransaccion.Focus();
                    return;
                }
                else
                {
                    txtClaveOficina.Text = dtArticulos.Rows[0]["K_Oficina"].ToString();
                    txtOficina.Text = dtArticulos.Rows[0]["D_Oficina"].ToString();
                    cbxAlmacen.SelectedValue = Convert.ToInt32(dtArticulos.Rows[0]["K_Almacen"].ToString());
                    cbxAlmacen.Text = dtArticulos.Rows[0]["D_Almacen"].ToString();
                    if (dtArticulos.Rows[0]["K_Cliente"].ToString() != "")
                    {
                        K_ClienteInt= Convert.ToInt32(dtArticulos.Rows[0]["K_Cliente"].ToString());
                        D_ClienteString = dtArticulos.Rows[0]["D_Cliente"].ToString();
                        txtCliente.Text = dtArticulos.Rows[0]["D_Cliente"].ToString();
                    }
                    //if (dtArticulos.Rows[0]["k_Cliente_Domicilio_Fiscal"].ToString() != "")
                    //{
                    //    k_Cliente_Domicilio_Fiscal = Convert.ToInt32(dtArticulos.Rows[0]["k_Cliente_Domicilio_Fiscal"].ToString());
                    //    txtDomicilioFiscal.Text = dtArticulos.Rows[0]["D_Domicilio_Fiscal"].ToString();
                    //}
                    if (dtArticulos.Rows[0]["K_Canal_Distribucion_Cliente"].ToString() != "")
                    {
                        ucCanalDistribucionCliente1.K_Canal_Distribucion = Convert.ToInt32(dtArticulos.Rows[0]["K_Canal_Distribucion_Cliente"].ToString());
                        ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = dtArticulos.Rows[0]["D_Canal_Distribucion_Cliente"].ToString();
                    }
                    //txtTotalIVA.Text = dtArticulos.Rows[0]["Total_Iva"].ToString();
                    //txtDescuento.Text = dtArticulos.Rows[0]["Descuento_Factura"].ToString();
                    //txtSubtotal.Text = dtArticulos.Rows[0]["Subtotal_Factura"].ToString();
                    //txtTotalFactura.Text = dtArticulos.Rows[0]["Total_Factura"].ToString();
                    if (Convert.ToBoolean(dtArticulos.Rows[0]["B_Credito"].ToString()) == true)
                    {
                        CbxCredito.Checked = true;
                        CbxPagado.Checked = false;
                    }
                    else
                    {
                        CbxCredito.Checked = false;
                        CbxPagado.Checked = true;
                    }
                    grdDetalle.DataSource = dtArticulos;
                    CalculaTotales();

                }
            }
        }

        private void txtTransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)) ||(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTransaccion_TextChanged(object sender, EventArgs e)
        {
            if(txtTransaccion.Text.Trim().Length>0)
            {
                Int32 valor = 0;
                if(!Int32.TryParse(txtTransaccion.Text,out valor))
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransaccion.Text = string.Empty;
                }
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

        private void CargaAlmacen()
        {
            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes(K_Oficina);
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

        private void CalculaTotales()
        {

            //Calculamos el IVA de todos los artículos
            var x = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("IVA_Factura"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    txtTotalIVA.Text = Math.Round(x, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el SUBTOTAL de todos los artículos
            var z = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Subtotal_Factura"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    txtSubtotal.Text = Math.Round(z, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el TOTAL del pedido
            //decimal totalPedido = x + z;
            //txtTotalFactura.Text = Math.Round(totalPedido, 2).ToString("N2");
            var y = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Total_Factura"))).Sum();
            if (y.ToString() != "")
            {
                if (z >= 0)
                {
                    txtTotalFactura.Text = Math.Round(y, 2).ToString("N2").Trim();
                }
            }
       

        }

        private void Mtd_Incrementar(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r =>
            {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(txtTasaIVA.Text) / 100)));
                r["Total_Detalle"] = decimal.Parse(r["Subtotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());

            });

            CalculaTotales();

            grdDetalle.DataSource = dtArticulos;
        }

        private void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r =>
            {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) - 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(txtTasaIVA.Text) / 100)));
                r["Total_Detalle"] = decimal.Parse(r["Subtotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());
                if (int.Parse(r["Cantidad"].ToString()) == 0)
                {
                    dtArticulos.Rows[e.RowIndex].Delete();
                }
            });


            CalculaTotales();

            grdDetalle.DataSource = dtArticulos;
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

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog(); 
            
            if ((filtra.K_Cliente_Seleccionado > 0) && (filtra.D_Cliente_Seleccionado.Length > 0))
            {
                K_ClienteInt = filtra.K_Cliente_Seleccionado;
                txtCliente.Text = filtra.D_Cliente_Seleccionado;
                D_ClienteString = filtra.D_Cliente_Seleccionado;
            }
            else
            {
                K_ClienteInt = 0;
                txtCliente.Text = string.Empty;
                D_ClienteString = string.Empty;
            }
        }
    }
}
