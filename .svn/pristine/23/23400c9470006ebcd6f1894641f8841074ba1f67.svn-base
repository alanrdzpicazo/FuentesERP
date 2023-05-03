using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.CXP
{
    public partial class Frm_CajaChica : FormaBase
    {
        SQLCatalogos sql_catalogos = new SQLCatalogos();
        SQLCuentasxPagar sql_cxp = new SQLCuentasxPagar();

        DataTable dtAlmacen = new DataTable();
        DataTable dtProveedores = new DataTable();
        DataTable dtDetalle = new DataTable();
        DataTable DtCaja_ChicaCxPSinOrden = new DataTable();
        DataTable dtCXP = new DataTable();

        int K_Almacen = 0;

        int res = 0;
        string msg = string.Empty;

        decimal gdTasaIva = 0;
        string VersionXML = string.Empty;
        int CajaChica = 0;
        int CXP = 0;

        bool EsCancelar = false;


        XmlDocument cfdi;

        public Frm_CajaChica()
        {
            InitializeComponent();
            seleccionaArchivoXML1.LabelAquiClick += new Controles.SeleccionaArchivoXML.UserControlClickHandler(seleccionaArchivoXML1_LabelAquiClick);
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonProceso6.Image = ((System.Drawing.Image)(imageList1.Images["btnRealizado.Image.png"]));
            BaseBotonProceso6.Text = "Cierre";
            BaseBotonProceso6.ToolTipText = "Cierre";
            BaseBotonProceso6.Visible = true;
            BaseBotonProceso6.Enabled = true;

            //BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnBuscar.Image.png"]));
            //BaseBotonProceso2.Text = "Buscar CXP";
            //BaseBotonProceso2.ToolTipText = "Buscar CXP Sin Orden";
            //BaseBotonProceso2.Visible = true;
            //BaseBotonProceso2.Enabled = true;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["btnAfectar.Image.png"]));
            BaseBotonProceso3.Text = "Autorizar";
            BaseBotonProceso3.ToolTipText = "Autorizar CXP Sin Orden";
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;

            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso4.Text = "No Autorizar";
            BaseBotonProceso4.ToolTipText = "No Autorizar CXP Sin Orden";
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = true;

            BaseBotonProceso5.Image = ((System.Drawing.Image)(imageList1.Images["if_to-do-list_checked3_15154.png"]));
            BaseBotonProceso5.Text = "Consulta CXP";
            BaseBotonProceso5.ToolTipText = "Consulta Cuenta por Pagar sin Orden";
            BaseBotonProceso5.Visible = true;
            BaseBotonProceso5.Enabled = true;



            Dgv_Datos.AutoGenerateColumns = false;
            FormatoGrid();

            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            if (dtMoneda != null)
            {
                LlenaCombo(dtMoneda, ref Cbx_Moneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 0);
                Cbx_Moneda.SelectedIndex = 0;

            }

            dtCXP = sql_cxp.Gp_ValidaUsuarioCajaChica(GlobalVar.K_Usuario);
            if ((dtCXP == null) || (dtCXP.Rows.Count == 0))
            {
                BtnUsuario.Enabled = false;
                txtK_Usuario.Text = Convert.ToString(GlobalVar.K_Usuario);
                txtD_Usuario.Text = GlobalVar.D_Usuario;

            }
            else
            {
                DataRow dr = dtCXP.Rows[0];
                txtK_Usuario.Text = dr["K_Usuario"].ToString();
                txtD_Usuario.Text = dr["D_Usuario"].ToString();
                BtnUsuario.Enabled = true;

            }
            dtProveedores = sqlCatalogos.Sk_Proveedores();

            Pnl_Datos_Factura.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            CbxCajaChica.Checked = true;
            RbtnTodos.Checked = true;
        }

        //Nuevo
        public override void BaseBotonProceso1Click()
        {
            BasePropiedadEsRegistroNuevo = true;
            Pnl_Datos_Factura.Enabled = true;
            cbxAlmacen.Focus();
            base.BaseBotonProceso1Click();
        }

        //Buscar CXP Sin Orden
        public override void BaseBotonProceso2Click()
        {
            DtCaja_ChicaCxPSinOrden = null;
            Dgv_Datos.DataSource = null;
            int NoCajaChica = 0;

            if (Txt_Caja_Chica.Text.Trim().Length > 0)
            {
                NoCajaChica = Convert.ToInt32(Txt_Caja_Chica.Text);
            }
            if (NoCajaChica > 0)
            {
                DtCaja_ChicaCxPSinOrden = sql_cxp.Sk_Caja_Chica(Convert.ToInt32(cbxAlmacen.SelectedValue), NoCajaChica, RbtnAutorizados.Checked, RbtNoAutorizados.Checked, RbtnTodos.Checked, RbtnPendientes.Checked);
            }



            Dgv_Datos.DataSource = DtCaja_ChicaCxPSinOrden;
            if (Dgv_Datos.DataSource != null)
            {
                if (DtCaja_ChicaCxPSinOrden.Rows.Count > 0)
                {
                    txtClaveOficina.Text = Convert.ToString(DtCaja_ChicaCxPSinOrden.Rows[0]["K_Oficina"]);
                    txtOficina.Text = Convert.ToString(DtCaja_ChicaCxPSinOrden.Rows[0]["D_Oficina"]);
                    cbxAlmacen.SelectedValue = Convert.ToInt32(DtCaja_ChicaCxPSinOrden.Rows[0]["K_Almacen"].ToString());
                    txtK_Usuario.Text = Convert.ToString(DtCaja_ChicaCxPSinOrden.Rows[0]["K_Usuario_Caja"]);
                    txtD_Usuario.Text = Convert.ToString(DtCaja_ChicaCxPSinOrden.Rows[0]["D_Usuario_Caja"]);
                    ucDepartamentos1.txt_E_Departamento.Text = Convert.ToString(DtCaja_ChicaCxPSinOrden.Rows[0]["D_Departamento"]);
                    CbxCajaChica.Checked = Convert.ToBoolean(DtCaja_ChicaCxPSinOrden.Rows[0]["B_Caja_Chica"]);
                    CbxViaticos.Checked = Convert.ToBoolean(DtCaja_ChicaCxPSinOrden.Rows[0]["B_Viaticos"]);
                    CbxReposicion.Checked = Convert.ToBoolean(DtCaja_ChicaCxPSinOrden.Rows[0]["B_Reposicion"]);
                    PnlArchivo.Enabled = true;
                    PnlCuenta.Enabled = true;
                    PnlFiltrar.Enabled = true;
                    Pnl_Datos_Factura.Enabled = true;
                    pnlAbajo.Enabled = true;
                }
            }

            base.BaseBotonProceso2Click();
        }

        public override void BaseBotonNuevoClick()
        {
            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;
            BaseMetodoLimpiaControles();
            Pnl_Datos_Factura.Enabled = true;
            PnlArchivo2.Enabled = true;
            PnlCuenta.Enabled = true;
            PnlFiltrar.Enabled = true;
            PnlCuenta.Enabled = true;
            PnlArchivo.Enabled = true;
            //Captura Alta
            BtnOficina.Enabled = false;
            BtnUsuario.Enabled = false;
            cbxAlmacen.Enabled = false;
            ucDepartamentos1.Enabled = false;
            CbxCajaChica.Enabled = false;
            CbxReposicion.Enabled = false;
            CbxViaticos.Enabled = false;
            BtnAgregar.Enabled = true;
            cbxAlmacen.Focus();
        }
        public override void BaseBotonBuscarClick()
        {
            EsCancelar = false; 
            Frm_ConsultaCajaChica frm = new Frm_ConsultaCajaChica();
            frm.ShowDialog();
            RbtnTodos.Checked = true;
            if (Convert.ToInt32(frm.Caja_Chica) > 0)
            {
                Txt_Caja_Chica.Text = frm.Caja_Chica;
            }
        }


        public override void BaseBotonCancelarClick()
        {
            EsCancelar = true;
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            Pnl_Datos_Factura.Enabled = false;
            PnlCuenta.Enabled = false;
            PnlFiltrar.Enabled = false;
            PnlArchivo.Enabled = false;
            //Captura Alta
            BtnOficina.Enabled = true;
            if ((dtCXP == null) || (dtCXP.Rows.Count == 0))
            {
                BtnUsuario.Enabled = false;
            }
            else
            {
                BtnUsuario.Enabled = true;
                txtK_Usuario.Text = "";
                txtD_Usuario.Text = "";
            }
            cbxAlmacen.Enabled = true;
            ucDepartamentos1.Enabled = true;
            CbxCajaChica.Enabled = true;
            CbxReposicion.Enabled = true;
            CbxViaticos.Enabled = true;
            PnlArchivo2.Enabled = true;
            Dgv_Datos.DataSource = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Focus();
            BtnAgregar.Enabled = true;
            txtClaveOficina.Text = "";
            txtOficina.Text = "";
            //txtK_Usuario.Text = "";
            //txtD_Usuario.Text = "";
            ucDepartamentos1.txt_E_Departamento.Text = string.Empty;
            ucDepartamentos1.K_Departamento = 0;
            Txt_Observaciones.Text = "";
            Txt_Caja_Chica.Text = "";
            Txt_Clave_Proveedor.Text = string.Empty;
            Txt_Proveedor.Text = string.Empty;
            Txt_Serie.Text = string.Empty;
            Txt_Folio.Text = string.Empty;
            Txt_Folio_Fiscal.Text = string.Empty;
            Txt_Subtotal.Text = string.Empty;
            Txt_Total_IVA.Text = string.Empty;
            Txt_Tasa_Retencion_IVA.Text = string.Empty;
            Txt_Total_Retencion_IVA.Text = string.Empty;
            Txt_Tasa_ISR.Text = string.Empty;
            Txt_Total_ISR.Text = string.Empty;
            Txt_Total_Factura.Text = string.Empty;
            Txt_Observaciones.Text = string.Empty;

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
                Txt_Clave_Proveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                Txt_Proveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
            }
        }

        private void FormatoGrid()
        {
            Dgv_Datos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            Dgv_Datos.RowHeadersVisible = false;
            Dgv_Datos.BackgroundColor = Color.White;
            Dgv_Datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Datos.AllowUserToAddRows = false;
            Dgv_Datos.AllowUserToDeleteRows = false;
            Dgv_Datos.BorderStyle = BorderStyle.None;

            Dgv_Datos.AllowUserToResizeColumns = true;
            Dgv_Datos.MultiSelect = false;
            Dgv_Datos.ReadOnly = true;
            Dgv_Datos.ScrollBars = System.Windows.Forms.ScrollBars.Both;

            Dgv_Datos.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            Dgv_Datos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Dgv_Datos.EnableHeadersVisualStyles = false;
        }


        private void seleccionaArchivoXML1_Load(object sender, EventArgs e)
        {
            if (seleccionaArchivoXML1.PropiedadRuta != null)
            {
                Comprobante factura = seleccionaArchivoXML1.PropiedadFactura;
                cfdi = seleccionaArchivoXML1.PropiedadXML;
                BaseMetodoArrastrar(factura, cfdi);

            }
        }

        public override void BaseMetodoArrastrar(Comprobante factura, XmlDocument xDoc = null)
        {
            if (factura == null)
                return;

            if (factura.TipoDeComprobante.ToString().Trim().ToUpper() != "I")
            {
                MessageBox.Show("EL TIPO DE COMPROBANTE NO ES DE INGRESO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // base.BaseMetodoArrastrar(factura);
            // BaseBotonNuevoClick();
            cfdi = xDoc;
            //btnNuevo_Click(this, null);
            string Serie = string.Empty;
            string Folio = string.Empty;
            if (factura.Serie != null)
                Serie = factura.Serie;
            if (factura.Folio != null)
                Folio = factura.Folio;
            Txt_Serie.Text = Serie;
            Txt_Folio.Text = Folio;
            Txt_Folio_Fiscal.Text = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();

            string RFCEmisor = factura.Emisor.Rfc;

            Txt_Subtotal.Text = factura.SubTotal.ToString();
            Txt_Total_Factura.Text = factura.Total.ToString("C");
            Dtp_Fecha_Factura.Value = factura.Fecha;
            Dtp_Fecha_Vencimiento.Value = factura.Fecha.AddDays(30);
            VersionXML = factura.Version;

            //factura.Impuestos.Traslados.AsEnumerable
            //dtArticulos = GlobalVar.dtArticulos.AsEnumerable().Where(p => p.Field<bool>("B_Activo") == true).CopyToDataTable<DataRow>();            

            Txt_Tipo_Cambio.Text = "0.00";
            if (factura.TipoCambio != null)
                Txt_Tipo_Cambio.Text = Truncar(Convert.ToDecimal(factura.TipoCambio), 4).ToString();

            decimal IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
            decimal TasaIVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
            decimal RetencionIVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
            decimal RetencionISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));

            //dtDetalle = (DataTable)ComprobantexTipo(factura, "ConceptosTabla");
            //grdDatos.DataSource = dtDetalle;

            Txt_Total_IVA.Text = IVA.ToString();

            if (RetencionIVA > 0)
            {
                Txt_Tasa_Retencion_IVA.Text = "10.66";
                Txt_Total_Retencion_IVA.Text = RetencionIVA.ToString();
            }
            if (RetencionISR > 0)
            {
                Txt_Tasa_ISR.Text = "10";
                Txt_Total_ISR.Text = RetencionISR.ToString();
            }

            //Buscar tipo iva si normal o frontera, con la TasaIVA
            var Impuestos = GlobalVar.dtImpuestos.AsEnumerable().Where(p => p.Field<decimal>("Porcentaje") == gdTasaIva);
            //short K_Impuesto = Impuestos.Min(p => p.Field<short>("K_Impuesto"));

            //DataRow ren = dtDatos.AsEnumerable().Where(p => p.Field<int>("K_Detalle_Requisicion") == K_Detalle_Requisicion).FirstOrDefault();
            //string D_Impuesto = string.Empty;
            //DataRow NombreImp = Impuestos.Where(p => p.Field<short>("K_Impuesto") == K_Impuesto).FirstOrDefault();
            //if (NombreImp != null)
            //    D_Impuesto = NombreImp["D_Impuesto"].ToString();

            //cmbTasaIva.SelectedValue = K_Impuesto;
            //cmbTasaIva.Text = D_Impuesto;

            //Proveedores
            string Nombre = string.Empty;
            int K_Proveedor = 0;
            DataRow NombreProv = dtProveedores.AsEnumerable().Where(p => p.Field<string>("RFC") == RFCEmisor).FirstOrDefault();
            if (NombreProv != null)
            {
                Nombre = NombreProv["D_Proveedor"].ToString();
                K_Proveedor = Convert.ToInt32(NombreProv["K_Proveedor"]);
                Txt_Clave_Proveedor.Text = K_Proveedor.ToString();
                Txt_Clave_Proveedor_Leave(null, null);
                Txt_Proveedor.Text = Nombre;
            }
            else
            {
                MessageBox.Show("EL PROVEEDOR DEL ARCHIVO NO EXISTE REGISTRADO...!\r\nR.F.C.: " + RFCEmisor + "\r\nProveedor: " + factura.Emisor.Nombre + "\r\nDEBERA ENTRAR A LA OPCION DE PROVEEDORES A CAPTURARLO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void seleccionaArchivoXML1_LabelAquiClick(object sender, EventArgs e)
        {
            if (seleccionaArchivoXML1.PropiedadRuta != null)
            {
               
                Comprobante factura = seleccionaArchivoXML1.PropiedadFactura;
                cfdi = seleccionaArchivoXML1.PropiedadXML;
                BaseMetodoArrastrar(factura, cfdi);


            }
        }

        private void Txt_Clave_Proveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref Txt_Clave_Proveedor, ref Txt_Proveedor);
        }

        void Mtd_Llenar_Grid()
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        public override bool BaseFuncionValidaciones()
        {
            //BaseErrorResultado = true;

            if (Txt_Clave_Proveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Clave_Proveedor.Focus();
                return false;
            }
            if (Txt_Subtotal.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL SUBTOTAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Subtotal.Focus();
                return false;
            }
            if (Txt_Total_Factura.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TOTAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Total_Factura.Focus();
                return false;
            }

            //BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoLimpiaControles()
        {
            Txt_Clave_Proveedor.Text = string.Empty;
            Txt_Proveedor.Text = string.Empty;
            Txt_Serie.Text = string.Empty;
            Txt_Folio.Text = string.Empty;
            Txt_Folio_Fiscal.Text = string.Empty;
            Txt_Subtotal.Text = string.Empty;
            //cmbTasaIva.Text = string.Empty;
            Txt_Total_IVA.Text = string.Empty;
            Txt_Tasa_Retencion_IVA.Text = string.Empty;
            Txt_Total_Retencion_IVA.Text = string.Empty;
            Txt_Tasa_ISR.Text = string.Empty;
            Txt_Total_ISR.Text = string.Empty;
            Txt_Total_Factura.Text = string.Empty;
            Txt_Observaciones.Text = string.Empty;
            //cmbTasaIva.SelectedIndex = 0;
            //Pnl_Datos_Factura.Enabled = false;
            PnlArchivo.Enabled = false;
            PnlCuenta.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            txtClaveOficina.Text = "";
            txtOficina.Text = "";
            ucDepartamentos1.txt_E_Departamento.Text = string.Empty;
            ucDepartamentos1.K_Departamento = 0;
            txtK_Usuario.Text = "";
            txtD_Usuario.Text = "";
            Txt_Observaciones.Text = "";
            Txt_Caja_Chica.Text = "";
            BtnAgregar.Enabled = true;
            Dgv_Datos.DataSource = null;
            cbxAlmacen.DataSource = null;
            EsCancelar = false;
            RbtnTodos.Checked = true;

        }

        private void Cbx_Moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_Moneda.SelectedValue == null)
                return;
            if (Cbx_Moneda.SelectedValue.ToString().Trim() == "System.Data.DataRowView")
                return;

            ////txtTipoCambio.Text = string.Empty;
            //if (Convert.ToInt32(Cbx_Moneda.SelectedValue) == 1) //DOLARES
            //{
            //    lblTipoCambio.Visible = true;
            //    Txt_Tipo_Cambio.Visible = true;
            //}
            //else
            //{
            //    lblTipoCambio.Visible = false;
            //    Txt_Tipo_Cambio.Visible = false;
            //}
        }

        private void Btn_Guardar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_Guardar.PerformClick();
            }
        }

        public override void BaseBotonProceso4Click()  //No Autoriza
        {
            if (Dgv_Datos.CurrentRow == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (Convert.ToBoolean(Dgv_Datos.CurrentRow.Cells["B_Autorizada"].Value.ToString()) == true)
                {
                    MessageBox.Show("LA CUENTA POR PAGAR ESTA AUTORIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((Dgv_Datos.CurrentRow.Cells["K_Motivos_NoAutorizacion"].Value.ToString() != String.Empty))//|| (Dgv_Datos.CurrentRow.Cells["K_Motivos_NoAutorizacion"].Value.ToString() == null))
                {
                    MessageBox.Show("LA CUENTA POR PAGAR SE ENCUENTRA NO AUTORIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Frm_CapturaMotivoNoAutoriza frm = new Frm_CapturaMotivoNoAutoriza();
                frm.LblClave.Text = Dgv_Datos.CurrentRow.Cells["K_Cuenta_SinOrden"].Value.ToString();
                frm.Lbl_CajaChica.Text = Dgv_Datos.CurrentRow.Cells["K_Caja_Chica"].Value.ToString();
                frm.txtClaveProveedor.Text = Dgv_Datos.CurrentRow.Cells["K_Proveedor"].Value.ToString();
                frm.txtProveedor.Text = Dgv_Datos.CurrentRow.Cells["D_Proveedor"].Value.ToString();
                frm.txtFolio.Text = Dgv_Datos.CurrentRow.Cells["Folio"].Value.ToString();
                frm.txtSerie.Text = Dgv_Datos.CurrentRow.Cells["Serie"].Value.ToString();
                frm.ShowDialog();
               // base.BaseBotonProceso4Click();
                //BaseBotonProceso2Click();
            }
        }
        public override void BaseBotonProceso3Click() //Autoriza
        {
            if (Dgv_Datos.CurrentRow == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (Convert.ToBoolean(Dgv_Datos.CurrentRow.Cells["B_Autorizada"].Value.ToString()) == true)
                {
                    MessageBox.Show("LA CUENTA POR PAGAR ESTA AUTORIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((Dgv_Datos.CurrentRow.Cells["K_Motivos_NoAutorizacion"].Value.ToString() != String.Empty))
                {
                   
                    MessageBox.Show("LA CUENTA POR PAGAR SE ENCUENTRA NO AUTORIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CajaChica = Convert.ToInt32(Dgv_Datos.CurrentRow.Cells["K_Caja_Chica"].Value.ToString());
                CXP = Convert.ToInt32(Dgv_Datos.CurrentRow.Cells["K_Cuenta_SinOrden"].Value.ToString());

                res = sql_cxp.Up_Autoriza_CxP_SinOrden(CXP, CajaChica, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    msg = "LA CUENTA POR PAGAR SE A AUTORIZADO ...: ";

                    BaseErrorResultado = false;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseBotonProceso2Click();
                }

            }
        }
        public override void BaseBotonProceso5Click()
        {
            if (Dgv_Datos.CurrentRow == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dgv_Datos.Focus();
                return;
            }
            if(Dgv_Datos.CurrentRow.Cells["K_Cuenta_SinOrden"].Value.ToString() == "")
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CXP VALIDA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dgv_Datos.Focus();
                return;
            }
            else
            {   
                Frm_ConsultaCXPsinOrden frm = new Frm_ConsultaCXPsinOrden();
                frm.K_Clave = Convert.ToInt32(Dgv_Datos.CurrentRow.Cells["K_Cuenta_SinOrden"].Value.ToString());
                frm.ShowDialog();
            }
        }

        private void RbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            BaseBotonProceso2Click();
        }

        private void RbtnAutorizados_CheckedChanged(object sender, EventArgs e)
        {
            BaseBotonProceso2Click();
        }

        private void RbtNoAutorizados_CheckedChanged(object sender, EventArgs e)
        {
            BaseBotonProceso2Click();
        }

        private void RbtnPendientes_CheckedChanged(object sender, EventArgs e)
        {
            BaseBotonProceso2Click();
        }
        public override void BaseBotonProceso6Click()
        {
            if (Txt_Caja_Chica.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR LA CAJA CHICA A LIQUIDAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtCXP = sql_cxp.Gp_Trae_MontosCajaChica(Convert.ToInt32(Txt_Caja_Chica.Text));
            if ((dtCXP == null) || (dtCXP.Rows.Count == 0))
            {
                MessageBox.Show("NO EXISTE INFORMACION DE  LA CAJA CHICA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                DataRow dr = dtCXP.Rows[0];
                decimal Monto_CajaChica;
                Monto_CajaChica = Convert.ToDecimal(dr["Total_Factura"].ToString());
                if (Monto_CajaChica == 0)
                {
                    MessageBox.Show("NO EXISTE FACTURAS AUTORIZADAS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                res = sql_cxp.Gp_ValidaLiquida_Caja(Convert.ToInt32(Txt_Caja_Chica.Text), Monto_CajaChica, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Frm_PagoCajaChica frm = new Frm_PagoCajaChica();
                    frm.Txt_Caja_Chica.Text = Txt_Caja_Chica.Text;
                    frm.LblTotal.Text = Convert.ToString(Math.Round(Monto_CajaChica, 2));
                    frm.LblResta.Text = Convert.ToString(Math.Round(Monto_CajaChica, 2));
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }



        private void BtnOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
            if (txtClaveOficina.Text != "")
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text));
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen");
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaUsuarios frm = new Busquedas.BuscaUsuarios();
            frm.BusquedaPropiedadTitulo = "Busca Usuarios";
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtUsuarios);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtUsuarios;
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtK_Usuario.Text = frm.BusquedaPropiedadReglonRes["K_Usuario"].ToString();
                txtD_Usuario.Text = frm.BusquedaPropiedadReglonRes["D_Usuario"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA OFICINA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveOficina.Focus();
                return;
            }
            if (txtK_Usuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN USUARIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Usuario.Focus();
                return;
            }
            if (cbxAlmacen.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return;
            }
            if (ucDepartamentos1.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL DEPARTAMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucDepartamentos1.Focus();
                return;
            }
            int CampoIdentity = 0;
            int res = 0;
            string msg = string.Empty;
            res = sql_cxp.In_Caja_Chica(ref CampoIdentity, Convert.ToInt16(cbxAlmacen.SelectedValue), GlobalVar.K_Usuario, Convert.ToInt32(txtK_Usuario.Text), Convert.ToInt16(ucDepartamentos1.K_Departamento), CbxCajaChica.Checked, CbxViaticos.Checked, CbxReposicion.Checked, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE ABRIO LA CAJA CHICA DEL ALMACEN [" + K_Almacen.ToString() + "][" + cbxAlmacen.SelectedText + "] CON NUMERO DE FOLIO " + CampoIdentity, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Caja_Chica.Text = CampoIdentity.ToString();
            }


        }
        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
          if (!BaseFuncionValidaciones())
                return;

            int CampoIdentity = 0;
            int K_OrdenCompra = 0;
            int K_Proveedor = Convert.ToInt32(Txt_Clave_Proveedor.Text);
            decimal TipoCambio = 1;
            decimal Subtotal = 0;
            decimal TotalIVA = 0;
            decimal TasaRetencionIVA = 0;
            decimal TotalRetencionIVA = 0;
            decimal TasaISR = 0;
            decimal TotalISR = 0;
            decimal TotalFactura = 0;

            res = 0;
            msg = string.Empty;


            short TipoMoneda = Convert.ToInt16(Cbx_Moneda.SelectedIndex);
            // Cuenta x PAGAR en DLLS
            if ((TipoMoneda == 1) && (Txt_Tipo_Cambio.Text.ToString().Length <= 0))
            {
                MessageBox.Show("PARA LAS FACTURAS RECIBIDAS EN DOLARES SE DEBE INDICAR EL TIPO DE CAMBIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Tipo_Cambio.Focus();
                return;
            }
            if(Txt_Caja_Chica.Text.Trim().Length ==0 )
            {
                MessageBox.Show("DEBE INDICAR EL NUMERO DE CAJA CHICA ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Caja_Chica.Focus();
                return;
            }
            TipoCambio = Convert.ToDecimal(Txt_Tipo_Cambio.Text);
            if ((TipoMoneda == 1) && (TipoCambio <= 1))
            {
                MessageBox.Show("PARA LAS FACTURAS RECIBIDAS EN DOLARES SE DEBE INDICAR UN TIPO DE CAMBIO VALIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Tipo_Cambio.Focus();
                return;
            }
            if (TipoMoneda == 1) //DLLS
                TipoCambio = Convert.ToDecimal(Txt_Tipo_Cambio.Text);

            DateTime Fecha = DateTime.Today;
            if (Dtp_Fecha_Factura.Value != null)
                Fecha = Convert.ToDateTime(Dtp_Fecha_Factura.Value.ToShortDateString());
            DateTime Vencimiento = DateTime.Today;
            if (Dtp_Fecha_Vencimiento.Value != null)
                Vencimiento = Convert.ToDateTime(Dtp_Fecha_Vencimiento.Value.ToShortDateString());

            if (Txt_Subtotal.Text.Trim().Length > 0)
                Subtotal = Convert.ToDecimal(Txt_Subtotal.Text.Replace('$', ' '));
            if (Txt_Total_IVA.Text.Trim().Length > 0)
                TotalIVA = Convert.ToDecimal(Txt_Total_IVA.Text.Replace('$', ' '));
            if (Txt_Tasa_Retencion_IVA.Text.Trim().Length > 0)
                TasaRetencionIVA = Convert.ToDecimal(Txt_Tasa_Retencion_IVA.Text.Replace('$', ' '));
            if (Txt_Total_Retencion_IVA.Text.Trim().Length > 0)
                TotalRetencionIVA = Convert.ToDecimal(Txt_Total_Retencion_IVA.Text.Replace('$', ' '));
            if (Txt_Tasa_ISR.Text.Trim().Length > 0)
                TasaISR = Convert.ToDecimal(Txt_Tasa_ISR.Text.Replace('$', ' '));
            if (Txt_Total_ISR.Text.Trim().Length > 0)
                TotalISR = Convert.ToDecimal(Txt_Total_ISR.Text.Replace('$', ' '));
            if (Txt_Total_Factura.Text.Trim().Length > 0)
                TotalFactura = Convert.ToDecimal(Txt_Total_Factura.Text.Replace('$', ' '));

            //DataTable dtDet = new DataTable();
            //dtDet = dtDetalle;
            //dtDet.Columns.Remove("B_Manual");
            //dtDet.Columns.Remove("Id");
            //if (BasePropiedadEsRegistroNuevo) // Nuevo
            //{
                res = sql_cxp.In_CxP_SinOrden(
                    ref CampoIdentity,
                    Convert.ToInt32(Txt_Caja_Chica.Text),
                    Convert.ToInt32(Txt_Clave_Proveedor.Text),
                    Txt_Folio_Fiscal.Text,
                    Txt_Serie.Text,
                    Txt_Folio.Text,
                    TipoCambio,
                    Convert.ToInt32(Cbx_Moneda.SelectedValue),
                    Subtotal,
                    gdTasaIva,
                    TotalIVA,
                    TasaRetencionIVA,
                    TotalRetencionIVA,
                    TasaISR,
                    TotalISR,
                    TotalFactura,
                    Fecha,
                    Vencimiento,
                    true,
                    Txt_Observaciones.Text,
                    VersionXML,
                    "CAPTURA",
                    1/*REEMBOLSO DE CAJAS CHICAS*/,
                    GlobalVar.K_Usuario,
                    ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "CUENTA POR PAGAR SIN ORDEN GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                    //BaseMetodoLimpiaControles();
                    BaseErrorResultado = false;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseBotonProceso2Click();

        }
    }



        private void BtnModificar_Click(object sender, EventArgs e)
        {
            PnlArchivo.Enabled = true;
            PnlCuenta.Enabled = true;
            PnlFiltrar.Enabled = true;
            Pnl_Datos_Factura.Enabled = true;
            pnlAbajo.Enabled = true;

        }
        private void Txt_Caja_Chica_TextChanged_1(object sender, EventArgs e)
        {
            if (EsCancelar == false)
            //Habilitar agregar cuenta
            {
                PnlCuenta.Visible = true;
                PnlCuenta.Enabled = true;
                PnlFiltrar.Visible = true;
                PnlFiltrar.Enabled = true;
                PnlArchivo.Visible = true;
                PnlArchivo.Enabled = true;
                BtnOficina.Enabled = false;
                BtnUsuario.Enabled = false;
                cbxAlmacen.Enabled = false;
                ucDepartamentos1.Enabled = false;
                CbxCajaChica.Enabled = false;
                CbxReposicion.Enabled = false;
                CbxViaticos.Enabled = false;
                BtnAgregar.Enabled = false;
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
                BaseBotonNuevo.Visible = false;
                BaseBotonNuevo.Enabled = false;
                BaseBotonProceso2Click();
            }
        }

        private void txtClaveOficina_TextChanged_1(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Trim().Length != 0)
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text));
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen");
            }

        }

        private void BtnOficina_Click_1(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
            if (txtClaveOficina.Text != "")
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text));
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen");
            }


        }

        private void BtnUsuario_Click_1(object sender, EventArgs e)
        {
            Busquedas.BuscaUsuarios frm = new Busquedas.BuscaUsuarios();
            frm.BusquedaPropiedadTitulo = "Busca Usuarios";
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtUsuarios);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtUsuarios;
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtK_Usuario.Text = frm.BusquedaPropiedadReglonRes["K_Usuario"].ToString();
                txtD_Usuario.Text = frm.BusquedaPropiedadReglonRes["D_Usuario"].ToString();
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA OFICINA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveOficina.Focus();
                return;
            }
            if (txtK_Usuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN USUARIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Usuario.Focus();
                return;
            }
            if (cbxAlmacen.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return;
            }
            if (ucDepartamentos1.K_Departamento == 0)
            {
                MessageBox.Show("DEBE INDICAR EL DEPARTAMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucDepartamentos1.Focus();
                return;
            }
            int CampoIdentity = 0;
            int res = 0;
            string msg = string.Empty;
            res = sql_cxp.In_Caja_Chica(ref CampoIdentity, Convert.ToInt16(cbxAlmacen.SelectedValue), GlobalVar.K_Usuario, Convert.ToInt32(txtK_Usuario.Text), Convert.ToInt16(ucDepartamentos1.K_Departamento), CbxCajaChica.Checked, CbxViaticos.Checked, CbxReposicion.Checked, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE ABRIO LA CAJA CHICA DEL ALMACEN [" + K_Almacen.ToString() + "][" + cbxAlmacen.SelectedText + "] CON NUMERO DE FOLIO " + CampoIdentity, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Caja_Chica.Text = CampoIdentity.ToString();
            }
            Dgv_Datos.DataSource = null;

        }
    }

}

