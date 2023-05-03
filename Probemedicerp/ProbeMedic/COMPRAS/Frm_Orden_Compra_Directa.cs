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

namespace ProbeMedic.COMPRAS
{
    public partial class Frm_Orden_Compra_Directa : FormaBase
    {
        DataTable dtDatos = new DataTable();
        DataTable dtValida = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtSucursales = new DataTable();
        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_DISPONIBLESS = new DataTable();

        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();

        Funciones fx = new Funciones();

        int KArticulo = 0;
        decimal PArticulo = 0;
        decimal Porcentaje = 0;
        decimal PPorcentaje_Ieps = 0;

        int K_Almacen = 0;
        int K_OrdenCompra = 0;

        int res = 0;
        string msg = string.Empty;

        bool B_NoEntrar = false;

        String strKeyPress = "";
        decimal gdCant = 0;
        decimal gdUnit = 0;
        decimal gdImp = 0;
        decimal gdTasaIVA = 0;

        private int k_orden_compra;
        public int K_Orden_Compra
        {
            get
            {
                return k_orden_compra;
            }
            set
            {
                k_orden_compra = value;
            }
        }

        bool B_Busqueda = false;
        public Frm_Orden_Compra_Directa()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            AddButtonColumn();
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar Datos Capturados en Pantalla";
            BaseBotonBorrar.Text = "Cancelar";
            BaseBotonBorrar.ToolTipText = "Cancelar Orden...!";

            BaseBotonModificar.Text = "Editar OC [F3]";

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList2.Images["zoom.png"]));
            BaseBotonProceso1.Text = "&OC Ptes x Surtir [F10]";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonProceso1.Width = 120;

            grdDetalle.AutoGenerateColumns = false;

            BaseErrorResultado = true;
            BaseBotonModificar.Visible = false;
            //LblUnidadMedida.Text = "";

            BaseEtiquetaEstatus.Visible = false;

            dtDatos = DetalleOCDirecta_Type;
            //dtDatos.Columns.Add("D_Articulo", typeof(string));

            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            if (dtMoneda != null)
            {
                LlenaCombo(dtMoneda, ref cmbMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 1);
            }

            //DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes();
            //if (dtAlmacen != null)
            //{
            //    LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", 0);
            //}
            //LlenaCombo(sQLCatalogos.sps_TipoEmpaque(true), ref cmbTipoEmpaque, "K_TIpo_Empaque", "D_Tipo_Empaque");

            txtFechaEntrega.Value = DateTime.Now.AddDays(1);

            base.BaseMetodoInicio();
        }
                                        
        public override void BaseBotonNuevoClick()
        {
            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;

            pnlCaptura.Enabled = true;
            tcControl.Enabled = true;
            cbxAlmacen.SelectedValue = 1;

            txtClaveOficina.Focus(   );
            dtDatos.Rows.Clear();
        }                                                                                                                                                                                                                                                                    

        public override void BaseBotonGuardarClick()
        { 
            if (!BaseFuncionValidaciones())
                return;

            grdDetalle.EndEdit();
            dtDatos.AcceptChanges();
            int K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            int K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            int K_Almacen = Convert.ToInt32(txtClaveProveedor.Text);
            res = 0;
            msg = string.Empty;

            DateTime Fecha = DateTime.Today;
            if (txtFechaEntrega.Value != null)
                Fecha = txtFechaEntrega.Value;

            short Tiempo = 0;
            if (txtTiempoEntrega.Text.Trim().Length > 0)
                Tiempo = Convert.ToInt16(txtTiempoEntrega.Text);

            bool B_ImprimeOC = true;
            string CorreosAutorizo = string.Empty;
            decimal TipoCambio = 0;
            int CampoIdentity = 0;
            short TipoMoneda = Convert.ToInt16(cmbMoneda.SelectedValue);
            if (TipoMoneda == 2) //DLLS
                TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);
            CampoIdentity = K_Orden_Compra;
            DataTable dtDetalle = dtDatos.Copy();
            dtDetalle.Columns.Remove("K_Detalle_Compra");
            dtDetalle.Columns.Remove("D_Articulo");
            //dtDetalle.Columns.Remove("Porcentaje");
            //dtDetalle.Columns.Remove("Porcentaje_Descuento");
            //dtDetalle.Columns.Remove("Porcentaje_Descuento_2");
            dtDetalle.Columns.Remove("Monto_Descuento");
            dtDetalle.Columns.Remove("Monto_Descuento_2");
            BaseFuncionValidaciones();

            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCompras.Gp_InsertaOrdenCompra_Directa(ref CampoIdentity, K_Oficina, Convert.ToInt16(cbxAlmacen.SelectedValue), Convert.ToInt16(cbxSucursales.SelectedValue), K_Proveedor, TipoMoneda, TipoCambio, Fecha, Tiempo, GlobalVar.K_Usuario, txtObservaciones.Text, dtDetalle, ref B_ImprimeOC, GlobalVar.K_Usuario, ref CorreosAutorizo, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "ORDEN DE COMPRA GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte(K_OrdenCompra);
                    Cursor = Cursors.Default;
                    BaseErrorResultado = false;
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
            else
            {
                res = sqlCompras.Gp_EditaOrdenCompraDirecta(CampoIdentity, GlobalVar.K_Usuario, dtDetalle, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    K_OrdenCompra = CampoIdentity;
                    msg = "ORDEN DE COMPRA ACTUALIZADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte(K_OrdenCompra);
                    Cursor = Cursors.Default;

                    BaseErrorResultado = false;

                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtOficina.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            txtClaveOficina.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            cbxAlmacen.SelectedIndex = -1;
            cbxSucursales.SelectedIndex = -1;
            pnlCaptura.Enabled = false;
            tcControl.Enabled = false;
            txtCantidad.Text = string.Empty; ;
            txtDetalles.Text = string.Empty;
            cmbMoneda.SelectedIndex = 0;
            txtTipoCambio.Text = string.Empty;
            txtFechaEntrega.Value = DateTime.Now.AddDays(1);
            txtTiempoEntrega.Text = "1";
            txtArticulo.Text = string.Empty;
            dtDatos.Rows.Clear();

            Calcula();
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR LA OFICINA QUE RECIBE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveOficina.Focus();
                return false;
            }
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return false;
            }
            if (cmbMoneda.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN TIPO DE MONEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMoneda.Focus();
                return false;
            }
            if (cbxAlmacen.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }
            if (cbxSucursales.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA SUCURSAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxSucursales.Focus();
                return false;
            }
            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbMoneda.SelectedValue.ToString() == "1")
            {
                /* if ( (txtTipoCambio.Text == "") || (txtTipoCambio.Text.ToString().Length <= ) )
                 {
                     MessageBox.Show("PARA PODER GENERAR LA ORDEN DE COMPRA, DEBE INDICAR EL TIPO DE CAMBIO DEL DIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     if (txtTipoCambio.CanFocus)
                     { txtTipoCambio.Focus(); }
                     return false;
                 }*/
            }

            BaseErrorResultado = false;
            return true;
        }

        public override void BaseBotonCancelarClick()
        {
            grdDetalle.DataSource = null;
            BaseMetodoLimpiaControles();
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }
            FILTROS.Frm_Filtro_Articulo  frm = new FILTROS.Frm_Filtro_Articulo();
            frm.P_K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            frm.ShowDialog();
            KArticulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            LblUnidadMedida.Text = frm.Unidad_Medida;
            PArticulo = frm.Precio;
            Porcentaje = frm.IVA;
            PPorcentaje_Ieps = frm.IEPS;         
            if (KArticulo > 0)
                txtCantidad.Focus();

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
                MessageBox.Show("CAPTURE LA CANTIDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            //if (PArticulo == 0)
            //{
            //    MessageBox.Show("CAPTURE EL PRECIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtCantidad.Focus();
            //    return;
            //}
            //int PuntoReOrden = 0;
            //dtValida = sqlRecepcion.Gp_V alida_PuntoReOrden(0,KArticulo, Convert.ToInt32(txtCantidad.Text), PuntoReOrden);

            //DataRow row = dtValida.Rows[0];

            //PuntoReOrden = Convert.ToInt32(row["Punto_ReOrden"].ToString());
             
            //if (PuntoReOrden < 0)
            //{
            //    MsgBox msgbox = new MsgBox();
            //    msgbox.Show("EL ARTICULO EXCEDE EL INVENTARIO MAXIMO", "ERROR");
            //    txtCantidad.Focus();
            //    return;    
        
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     //}
                                                                             
            int Consecutivo = 1;

            try
            {
                if (dtDatos.Rows.Count == 0)
                {                               
                    dtDatos.Columns.Add("Porcentaje", typeof(decimal));
                    dtDatos.AcceptChanges();
                }
            }
            catch (Exception ex){}
                    
            DataRow dr;
            dr = dtDatos.NewRow();

            if (dtDatos.Rows.Count > 0)
            {
                //checamos si ya se metió el mismo artículo

                if (ChecaMismoArticulo(dtDatos, KArticulo))
                {
                    MessageBox.Show("YA EXISTE AGREGADO EL ARTÍCULO "+ txtArticulo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                var maxVal = dtDatos.AsEnumerable()
                        .Max(r => r.Field<int>("K_Detalle_Compra"));
                Consecutivo = Convert.ToInt32(maxVal) + 1;
            }
            decimal total =
                (Convert.ToDecimal(PArticulo) * Convert.ToDecimal(txtCantidad.Text))  +     
                (Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (Porcentaje / 100))) +
                (Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (PPorcentaje_Ieps / 100))) +
                Convert.ToDecimal(TotalReq.Text);

            dr["K_Detalle_Compra"] = Consecutivo;
            dr["K_Articulo"] = KArticulo;
            dr["D_Articulo"] = txtArticulo.Text;
            dr["CantidadRequerida"] = Convert.ToInt32(txtCantidad.Text);
            dr["Unitario"] = PArticulo;
            dr["Porcentaje"] = Porcentaje.ToString();
            dr["IVA"] = Convert.ToInt32(txtCantidad.Text) * (PArticulo * (Porcentaje / 100));
            dr["SubTotal"] = PArticulo * Convert.ToDecimal(txtCantidad.Text);
            dr["PrecioTotal"] =
                (PArticulo * Convert.ToDecimal(txtCantidad.Text)) +
                (Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (Porcentaje / 100))) +
                (Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (PPorcentaje_Ieps / 100)));
            dr["ObservacionesDetalle"] = txtDetalles.Text;
            dr["Porcentaje_Descuento"] = 0;
            decimal Monto_Descuento = (Convert.ToDecimal(dr["Porcentaje_Descuento"]) / 100) * Convert.ToDecimal(dr["SubTotal"]);
            dr["Monto_Descuento"] = Monto_Descuento;
            dr["Porcentaje_Descuento_2"] = 0;
            decimal Monto_Descuento_2 = (Convert.ToDecimal(dr["Porcentaje_Descuento_2"]) / 100) * Convert.ToDecimal(dr["SubTotal"]);
            dr["Monto_Descuento_2"] = Monto_Descuento_2;
            dr["Porcentaje_Ieps"] = PPorcentaje_Ieps.ToString();
            dr["IEPS"] = (Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (PPorcentaje_Ieps / 100)));

            total = Math.Round(total, 2);

            TotalReq.Text = total.ToString();
            dtDatos.Rows.Add(dr);
            B_NoEntrar = true;
            grdDetalle.DataSource = dtDatos;
            grdDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
            grdDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdDetalle.MultiSelect = false;

            Calcula();

            txtArticulo.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            KArticulo = 0;
            LblUnidadMedida.Text = "";
            txtArticulo.Focus();
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
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
                CargaAlmacenes();
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores_Autorizados();
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
                cbxSucursales.DataSource = null;
                cbxSucursales.Items.Clear();
                DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
                if (dtSucursales != null)
                {
                    DataRow dr = dtSucursales.NewRow();

                    dr["K_Sucursal_Proveedor"] = 0;
                    dr["K_Proveedor"] = 0;
                    dr["D_Sucursal_Proveedor"] = "";
                    dr["D_Proveedor"] = "";

                    dtSucursales.Rows.InsertAt(dr, 0);

                    dtSucursales.AcceptChanges();

                    int indice = -1;
                    indice = 0;
                    LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", indice);

                    cbxSucursales.SelectedValue = 0;
                }
            }
            else
            {
                cbxSucursales.DataSource = null;
                cbxSucursales.Items.Clear();
                txtClaveProveedor.Text = string.Empty;
                txtProveedor.Text = string.Empty;
            }
            Cursor = Cursors.Default;
        }

        private bool ChecaMismoArticulo(DataTable dt, int K_Articulo)
        {
            bool b_mismo = false;

            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32 (dr["K_Articulo"].ToString()) == K_Articulo )
                {
                    b_mismo = true;
                    break;
                }
            }

            return b_mismo;
        }

        private bool blnCeldaImportes()
        {
            if (grdDetalle.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdDetalle.CurrentCell.ColumnIndex == 5);
        }

        private bool blnCeldaCantidad()
        {
            if (grdDetalle.CurrentCell == null)
                return false;
            //if (B_NoEntrar == false)
            //    return false;

            return (grdDetalle.CurrentCell.ColumnIndex == 4);
        }
        private bool blnCeldaDescuento()
        {
            if (grdDetalle.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdDetalle.CurrentCell.ColumnIndex == 6);
        }

        private bool blnCeldaDescuento2()
        {
            if (grdDetalle.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdDetalle.CurrentCell.ColumnIndex == 8);
        }
        private void CambiaCantidades(Int32 IndiceColumna, DataGridViewRow ren, Int32 IndiceRegistro)
        {
            if (!EsNumero(Convert.ToDecimal(ren.Cells["Unitario1"].Value)))
            {
                MessageBox.Show("LA COLUMNA PRECIO UNITARIO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }
            if (!EsNumero(Convert.ToInt32(ren.Cells["CantidadRequerida1"].Value)))
            {
                MessageBox.Show("LA COLUMNA CANTIDAD SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }
            try
            {
                if (!EsNumero(Convert.ToDecimal(ren.Cells["Porcentaje_Descuento"].Value)))
                {
                    MessageBox.Show("LA COLUMNA PORCENTAJE DESCUENTO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
                if (Convert.ToDecimal(ren.Cells["Porcentaje_Descuento"].Value) >= 100)
                {
                    MessageBox.Show("EL PORCENTAJE DE DESCUENTO DEBE SER MENOR A 100", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
                if (!EsNumero(Convert.ToDecimal(ren.Cells["Porcentaje_Descuento_2"].Value)))
                {
                    MessageBox.Show("LA COLUMNA PORCENTAJE DESCUENTO 2 SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
                if (Convert.ToDecimal(ren.Cells["Porcentaje_Descuento_2"].Value) >= 100)
                {
                    MessageBox.Show("EL PORCENTAJE DE DESCUENTO 2 DEBE SER MENOR A 100", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                    return;
                }
            }
            catch (Exception) { }

            decimal Unitario = 0;
            Int32 Cantidad = 0;
            decimal Importe = 0;
            decimal SubTotal = 0;
            decimal TotalIVA = 0;
            decimal Porcentaje = 0;
            decimal Porcentaje_Descuento = 0;
            decimal Monto_Descuento = 0;
            decimal Porcentaje_Descuento_2 = 0;
            decimal Monto_Descuento_2 = 0;
            decimal TotalIEPS= 0;
            decimal Porcentaje_Ieps = 0;
            if (ren.Cells["Unitario1"].Value != null)
                Unitario = Math.Round(Convert.ToDecimal(ren.Cells["Unitario1"].Value), 2);
            if (ren.Cells["CantidadRequerida1"].Value != null)
            {
                Cantidad = Convert.ToInt32(ren.Cells["CantidadRequerida1"].Value);
            }
            if (ren.Cells["Porcentaje_IVA"].Value != null)
                Porcentaje = Convert.ToDecimal(ren.Cells["Porcentaje_IVA"].Value);
            if (ren.Cells["Porcentaje_Descuento"].Value != null)
            {
                Porcentaje_Descuento = Convert.ToDecimal(ren.Cells["Porcentaje_Descuento"].Value);
                Monto_Descuento = (Porcentaje_Descuento / 100) * Convert.ToDecimal(ren.Cells["SubTotal1"].Value);
            }
            if (ren.Cells["Porcentaje_Descuento_2"].Value != null)
            {
                Porcentaje_Descuento_2 = Convert.ToDecimal(ren.Cells["Porcentaje_Descuento_2"].Value);
                Monto_Descuento_2 = (Porcentaje_Descuento_2 / 100) * Convert.ToDecimal(ren.Cells["SubTotal1"].Value);
            }
            if (ren.Cells["Porcentaje_Ieps"].Value != null)
                Porcentaje_Ieps = Convert.ToDecimal(ren.Cells["Porcentaje_Ieps"].Value);
            ren.Cells["Unitario1"].Value = Unitario;
            ren.Cells["CantidadRequerida1"].Value = Cantidad;
            ren.Cells["Porcentaje_IVA"].Value = Porcentaje;
            ren.Cells["Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            ren.Cells["Monto_Descuento"].Value = Monto_Descuento;
            ren.Cells["Porcentaje_Descuento_2"].Value = Porcentaje_Descuento_2;
            ren.Cells["Monto_Descuento_2"].Value = Monto_Descuento_2;
            ren.Cells["Porcentaje_Ieps"].Value = Porcentaje_Ieps;

            SubTotal = Math.Round(Cantidad * Unitario, 4);
            TotalIVA = Math.Round((SubTotal - Monto_Descuento - Monto_Descuento_2) * (Porcentaje / 100), 4);
            TotalIEPS = Math.Round((SubTotal - Monto_Descuento - Monto_Descuento_2) * (PPorcentaje_Ieps / 100), 4);
            Importe = Math.Round(((SubTotal - Monto_Descuento - Monto_Descuento_2) + TotalIVA + TotalIEPS), 4);

            grdDetalle.Rows[IndiceRegistro].Cells["SubTotal1"].Value = SubTotal;
            grdDetalle.Rows[IndiceRegistro].Cells["IVA1"].Value = TotalIVA;
            grdDetalle.Rows[IndiceRegistro].Cells["IEPS1"].Value = TotalIEPS;
            grdDetalle.Rows[IndiceRegistro].Cells["PrecioTotal1"].Value = Importe;

            Calcula();

        }



        private void AddButtonColumn()
        {
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Inventario";
                buttons.Text = "-";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 15;
            }

            grdDetalle.Columns.Add(buttons);

        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = grdDetalle.CurrentRow;

                if (row != null)
                {
                    int K_Detalle_Compra = Convert.ToInt32(row.Cells[1].Value);
                    Decimal pretotal = Convert.ToDecimal(row.Cells[13].Value);
                    DataRow ren = dtDatos.AsEnumerable().Where(p => p.Field<int>("K_Detalle_Compra") == K_Detalle_Compra).FirstOrDefault();
                    if (ren != null)
                        dtDatos.Rows.Remove(ren);
                    Decimal total = Convert.ToDecimal(TotalReq.Text) - pretotal;
                    TotalReq.Text = total.ToString();
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           if((EsNumero(e.KeyChar)) || (e.KeyChar == (char) Keys.Back))
           {
                e.Handled = false;
           }
           else
           {
                if((e.KeyChar == Convert.ToChar(Keys.Enter)) && (txtCantidad.Text.Trim().Length>0))
                {
                    btnAgregar.PerformClick();
                }
                else
                {
                    e.Handled = true;
                }
           }
        }

        private void grdDetalle_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (grdDetalle[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    if (Keys.Back.ToString() == strKeyPress)
                    {
                        SendKeys.Send("{RIGHT}");
                    }
                }
            }
            BaseBotonGuardar.Enabled = false;
        }

        private void grdDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // string algo = "dsasdf";
            BaseBotonGuardar.Enabled = true;
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
            if (blnCeldaCantidad())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA CANTIDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (blnCeldaDescuento())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA DESCUENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (blnCeldaDescuento2())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA DESCUENTO 2...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void grdDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = grdDetalle.CurrentRow;
            if (ren != null)
            {
                if ((blnCeldaImportes()) || (blnCeldaCantidad()) || (blnCeldaDescuento()) || (blnCeldaDescuento2()))
                {
                    if (ren.Cells["CantidadRequerida1"].Value != null)
                    {
                        if (Convert.ToInt32(ren.Cells["CantidadRequerida1"].Value) == 0)
                        {
                            dtDatos.Rows[e.RowIndex].Delete();
                            dtDatos.AcceptChanges();
                            Calcula();
                        }
                        else
                        {
                            CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);
                        }
                    }
                    else
                    {
                        CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);
                    }

                }
            }
        }
        private void Calcula()
        {
            var x = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("SubTotal"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    decimal Total_Subtotal = Convert.ToDecimal(x);
                    txtSubtotal.Text = Math.Round(Total_Subtotal, 4).ToString("N4").Trim();
                }

            }
            var y = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("IVA"))).Sum();
            if (y.ToString() != "")
            {
                if (y >= 0)
                {
                    decimal Total_IVA = Convert.ToDecimal(y);
                    txtIVA.Text = Math.Round(Total_IVA, 4).ToString("N4").Trim();
                }
            }
            var z = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("PrecioTotal"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    decimal PrecioTotal = Convert.ToDecimal(z);
                    txtTotal.Text = Math.Round(PrecioTotal, 4).ToString("N4").Trim();
                }

            }
            var w = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Monto_Descuento"))).Sum();
            if (w.ToString() != "")
            {
                if (w >= 0)
                {
                    decimal Monto_Descuento = Convert.ToDecimal(w);
                    txtDesc1.Text = Math.Round(Monto_Descuento, 4).ToString("N4").Trim();
                }

            }
            var p = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Monto_Descuento_2"))).Sum();
            if (p.ToString() != "")
            {
                if (p >= 0)
                {
                    decimal Monto_Descuento_2 = Convert.ToDecimal(p);
                    txtDesc2.Text = Math.Round(Monto_Descuento_2, 4).ToString("N4").Trim();
                }

            }
            var zz = dtDatos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("IEPS"))).Sum();
            if (zz.ToString() != "")
            {
                if (zz >= 0)
                {
                    decimal Total_IEPS = Convert.ToDecimal(zz);
                    txtIEPS.Text = Math.Round(Total_IEPS, 4).ToString("N4").Trim();
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
            if (blnCeldaDescuento())
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
            if (blnCeldaCantidad())
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            if (blnCeldaDescuento2())
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

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {         
            e.Control.KeyPress += new KeyPressEventHandler(grdDetalle_KeyPress);
            e.Control.TextChanged += new EventHandler(grdDetalle_TextChanged);
            DataGridViewComboBoxEditingControl dgvCombo = e.Control as DataGridViewComboBoxEditingControl;
            e.Control.TextChanged  += new EventHandler(grdDetalle_TextChanged);
            //if (dgvCombo != null)
            //{
            //    // se remueve el handler previo que pudiera tener asociado, a causa ediciones previas de la celda
            //    // evitando asi que se ejecuten varias veces el evento
            //    //
            //    //dgvCombo.SelectedIndexChanged -= new  EventHandler(dvgCombo_SelectedIndexChanged);               

            //    dgvCombo.SelectedIndexChanged += new EventHandler(dvgCombo_SelectedIndexChanged);

            //}
        }
        private void grdDetalle_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length > 0)
            {
                decimal valor = 0;
                if (!decimal.TryParse(textBox.Text.Trim().Replace("$", ""), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = string.Empty;
                }
            }
        }
        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalle.CurrentRow != null)
            {
                if (grdDetalle.Columns[e.ColumnIndex].Index == 15)
                {
                    COMPRAS.FRM_Inventario_Articulo frm = new COMPRAS.FRM_Inventario_Articulo();
                    frm.K_Articulo_ = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Articulo1"].Value);
                    frm.ShowDialog();
                }
            }
        }

        private void grdDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            strKeyPress = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void Reporte(Int32 K_Orden_Compra)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = sqlCompras.Gp_Sk_ReporteOC(K_Orden_Compra);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new ProbeMedic.COMPRAS.RPT_Orden_Compra();
                ReporteTitulo = "Orden de Compra";
                ReporteModulo = "Orden de Compra";
                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length > 0)
                if (Convert.ToDecimal(txtCantidad.Text.Trim()) > 1000)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Text = string.Empty;
                }
        }

        private void txtFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaf = Convert.ToDateTime(txtFechaEntrega.Value.Date);

            if(!BasePropiedadB_Editando)
            {
                if (txtFechaEntrega.Value.Date < DateTime.Now.Date)
                {
                    //aqui tu codigo
                    MessageBox.Show("LA FECHA DE ENTREGA NO PUEDE SER MENOR A LA ACTUAL!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFechaEntrega.Value = DateTime.Now.AddDays(1);
                    return;
                }
            }
              
        }

        private void txtFechaEntrega_Leave(object sender, EventArgs e)
        {
            DateTime F_Actual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime F_Entrega = new DateTime(txtFechaEntrega.Value.Year, txtFechaEntrega.Value.Month, txtFechaEntrega.Value.Day);

            // Difference in days, hours, and minutes.
            TimeSpan ts = F_Entrega - F_Actual;

            // Difference in days.
            int differenceInDays = ts.Days;

            txtTiempoEntrega.Text = differenceInDays.ToString();
        }

        private void txtTiempoEntrega_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTiempoEntrega_TextChanged(object sender, EventArgs e)
        {
            if (txtTiempoEntrega.Text.Trim().Length == 0)
            {
                txtTiempoEntrega.Text = "1";
            }
            if ((Convert.ToDecimal(txtTiempoEntrega.Text.Trim()) <= 0) || (txtTiempoEntrega.Text.Trim().Length == 0))
            {
                MessageBox.Show("EL TIEMPO DE ENTREGA DEBE SER MAYOR A CERO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTiempoEntrega.Text = "1";
                return;
            }
            if (Convert.ToInt32(txtTiempoEntrega.Text.Trim()) > 365)
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                    "EL VALOR MÁXIMO PERMITIDO ES 365 DIAS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiempoEntrega.Text = "1";
            }

        }

        private void txtTiempoEntrega_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtTiempoEntrega.Text != "")
                {
                    DateTime Dt = new DateTime();
                    Dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    Dt = Dt.AddDays(txtTiempoEntrega.Text.Length == 0 ? 0 : Convert.ToDouble(txtTiempoEntrega.Text));

                    txtFechaEntrega.Value = Dt;

                }
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Trim().Length>0)
            {
                if(Convert.ToDecimal(txtCantidad.Text.Trim())==0)
                {
                    MessageBox.Show("VALOR NO VÁLIDO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Text = string.Empty;
                    txtCantidad.Focus();
                }
            }
        }


        private void txtClaveOficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()) || ((e.KeyChar == Convert.ToChar(Keys.Back)))))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = false;
                Cursor = Cursors.WaitCursor;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                Cursor = Cursors.Default;
                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Focus();
                }
                else
                {
                    CargaAlmacenes();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClaveOficina_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Cursor = Cursors.WaitCursor;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                Cursor = Cursors.Default;

                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Focus();
                }
                else
                {
                    CargaAlmacenes();
                }
            }
        }

        private void txtClaveOficina_TextChanged(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Trim().Length > 0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClaveOficina.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VÁLIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Text = string.Empty;
                    txtClaveOficina.Focus();
                }
            }
        }

        private void txtClaveProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()) || ((e.KeyChar == Convert.ToChar(Keys.Back)))))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cursor = Cursors.WaitCursor;
                DataTable dtProveedores = sqlCatalogos.Sk_Proveedores_Autorizados();
                BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);
                Cursor = Cursors.Default;

                if (txtClaveProveedor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    txtClaveProveedor.Focus();
                }
                else
                {
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
                    if (dtSucursales != null)
                    {
                        DataRow dr = dtSucursales.NewRow();

                        dr["K_Sucursal_Proveedor"] = 0;
                        dr["K_Proveedor"] = 0;
                        dr["D_Sucursal_Proveedor"] = "";
                        dr["D_Proveedor"] = "";

                        dtSucursales.Rows.InsertAt(dr, 0);

                        dtSucursales.AcceptChanges();

                        int indice = -1;
                        indice = 0;
                        LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", indice);

                        cbxSucursales.SelectedValue = 0;
                    }
                    else
                    {
                        cbxSucursales.DataSource = null;
                        cbxSucursales.Items.Clear();
                    }
                }

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClaveProveedor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Cursor = Cursors.WaitCursor;
                DataTable dtProveedores = sqlCatalogos.Sk_Proveedores_Autorizados();
                BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "D_Proveedor", ref txtClaveProveedor, ref txtProveedor);
                Cursor = Cursors.Default;

                if (txtClaveProveedor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    txtClaveProveedor.Focus();
                }
                else
                {
                    cbxSucursales.DataSource = null;
                    cbxSucursales.Items.Clear();
                    DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
                    if (dtSucursales != null)
                    {
                        DataRow dr = dtSucursales.NewRow();

                        dr["K_Sucursal_Proveedor"] = 0;
                        dr["K_Proveedor"] = 0;
                        dr["D_Sucursal_Proveedor"] = "";
                        dr["D_Proveedor"] = "";

                        dtSucursales.Rows.InsertAt(dr, 0);

                        dtSucursales.AcceptChanges();

                        int indice = -1;
                        indice = 0;
                        LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", indice);

                        cbxSucursales.SelectedValue = 0;
                    }
                    else
                    {
                        cbxSucursales.DataSource = null;
                        cbxSucursales.Items.Clear();
                    }
                }
            }
        }

        private void txtClaveProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtClaveProveedor.Text.Trim().Length > 0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClaveProveedor.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveProveedor.Text = string.Empty;
                    txtClaveProveedor.Focus();
                }
            }
        }

        private void CargaAlmacenes()
        {
            DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text));
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

                cbxAlmacen.SelectedValue = 0;
            }
        }

        private void cbxAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if(txtArticulo.Text.Trim().Length>0)
                {
                    if (txtClaveProveedor.Text.Trim().Length > 0)
                    {
                        AR_DISPONIBLESS = sqlCatalogos.Sk_Articulos_Consulta_CPrecio(0, 0, 0, txtArticulo.Text.Trim(), "", Convert.ToInt32(txtClaveProveedor.Text.Trim()), 0);

                        if (AR_DISPONIBLESS != null)
                        {
                            foreach (DataRow irew in AR_DISPONIBLESS.Rows)
                            {
                                DataRow dtdRow3 = AR_DISPONIBLES.NewRow();
                                dtdRow3["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
                                dtdRow3["D_Articulo"] = irew["D_Articulo"].ToString();
                                dtdRow3["SKU"] = irew["SKU"].ToString();
                                dtdRow3["D_Familia"] = irew["D_Familia"].ToString();
                                dtdRow3["D_Laboratorio"] = irew["D_Laboratorio"].ToString();
                                dtdRow3["D_Sustancia_Activa"] = irew["D_Sustancia_Activa"].ToString();
                                dtdRow3["Porcentaje"] = Convert.ToDecimal(irew["Porcentaje"]);
                                dtdRow3["D_Unidad_Medida"] = irew["D_Unidad_Medida"].ToString();
                                dtdRow3["Precio_Unitario"] = Convert.ToDecimal(irew["Precio_Unitario"]);

                                AR_DISPONIBLES.Rows.Add(dtdRow3);
                            }
                            KArticulo = Convert.ToInt32(AR_DISPONIBLESS.Rows[0]["K_Articulo"].ToString());
                            txtArticulo.Text = AR_DISPONIBLESS.Rows[0]["D_Articulo"].ToString();
                            PArticulo = Convert.ToDecimal(AR_DISPONIBLESS.Rows[0]["Precio_Unitario"].ToString());
                            Porcentaje = Convert.ToDecimal(AR_DISPONIBLESS.Rows[0]["Porcentaje"].ToString());
                            LblUnidadMedida.Text = AR_DISPONIBLESS.Rows[0]["D_Unidad_Medida"].ToString();
                            txtCantidad.Focus();
                        }
                        else
                        {
                            MessageBox.Show("NO EXISTE INFORMACION!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtArticulo.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                        return;
                    }
                  
                }
                else
                {
                    e.Handled = true;
                }
            
            }
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyCode == Keys.Tab)
            //{
            //    if (txtClaveProveedor.Text.Trim().Length > 0)
            //    {
            //        AR_DISPONIBLESS = sqlCatalogos.Sk_Articulos_Consulta_CPrecio(0, 0, 0, txtArticulo.Text.Trim(), "", Convert.ToInt32(txtClaveProveedor.Text.Trim()), 0);
            //    }
            //    else
            //    {
            //        AR_DISPONIBLESS = sqlCatalogos.Sk_Articulos_Consulta_CPrecio(0, 0, 0, txtArticulo.Text.Trim(), "", 0);
            //    }

            //    if (AR_DISPONIBLESS != null)
            //    {
            //        foreach (DataRow irew in AR_DISPONIBLESS.Rows)
            //        {
            //            DataRow dtdRow3 = AR_DISPONIBLES.NewRow();
            //            dtdRow3["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
            //            dtdRow3["D_Articulo"] = irew["D_Articulo"].ToString();
            //            dtdRow3["SKU"] = irew["SKU"].ToString();
            //            dtdRow3["D_Familia"] = irew["D_Familia"].ToString();
            //            dtdRow3["D_Laboratorio"] = irew["D_Laboratorio"].ToString();
            //            dtdRow3["D_Sustancia_Activa"] = irew["D_Sustancia_Activa"].ToString();
            //            dtdRow3["Porcentaje"] = Convert.ToDecimal(irew["Porcentaje"]);
            //            dtdRow3["D_Unidad_Medida"] = irew["D_Unidad_Medida"].ToString();
            //            dtdRow3["Precio_Unitario"] = Convert.ToDecimal(irew["Precio_Unitario"]);

            //            AR_DISPONIBLES.Rows.Add(dtdRow3);
            //        }
            //        KArticulo = Convert.ToInt32(AR_DISPONIBLESS.Rows[0]["K_Articulo"].ToString());
            //        txtArticulo.Text = AR_DISPONIBLESS.Rows[0]["D_Articulo"].ToString();
            //        PArticulo = Convert.ToDecimal(AR_DISPONIBLESS.Rows[0]["Precio_Unitario"].ToString());
            //        Porcentaje = Convert.ToDecimal(AR_DISPONIBLESS.Rows[0]["Porcentaje"].ToString());
            //        LblUnidadMedida.Text = AR_DISPONIBLESS.Rows[0]["D_Unidad_Medida"].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("NO EXISTE INFORMACION!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }

        private void Frm_Orden_Compra_Directa_Load(object sender, EventArgs e)
        {
            AR_DISPONIBLES.Columns.Add("K_Articulo", typeof(Int32));
            AR_DISPONIBLES.Columns.Add("D_Articulo", typeof(string));
            AR_DISPONIBLES.Columns.Add("SKU", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Familia", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Laboratorio", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Sustancia_Activa", typeof(string));
            AR_DISPONIBLES.Columns.Add("Porcentaje", typeof(decimal));
            AR_DISPONIBLES.Columns.Add("D_Unidad_Medida", typeof(string));
            AR_DISPONIBLES.Columns.Add("Precio_Unitario", typeof(decimal));

        }

        public override void BaseBotonProceso1Click()
        {
            DateTime? f1 = new DateTime();
            f1 = fx.PrimerDiaDelMes(DateTime.Now);
            DateTime? f2 = new DateTime();
            f2 = fx.UltimoDiaDelMes(DateTime.Now);

            Cursor = Cursors.WaitCursor;
            DataTable dtOC = sqlCompras.Sk_ConsultaOrdenesCompra(0, 0, 0, 1, 1, false, f1, f2, 0, 0, 0, 0, null, null);

            if (dtOC != null)
            {
                dtOC.DefaultView.Sort = "K_Orden_Compra DESC";
                Busquedas.BuscaOrdenesCompra frm = new Busquedas.BuscaOrdenesCompra();
                frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOC);
                frm.BusquedaPropiedadTablaFiltra = dtOC;

                if (dtOC.Rows.Count == 1)
                {
                    K_Orden_Compra = Convert.ToInt32(dtOC.Rows[0]["K_Orden_Compra"].ToString());
                    LlenaControles(dtOC.Rows[0]);

                    BasePropiedadEsRegistroNuevo = false;
                    BasePropiedadId_Identity = 0;
                    BasePropiedadB_Agregando = false;
                    BasePropiedadB_Editando = true;

                }
                else if (dtOC.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Ordenes de Compra";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Orden_Compra = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Orden_Compra"].ToString());
                        LlenaControles(frm.BusquedaPropiedadReglonRes);

                        BasePropiedadEsRegistroNuevo = false;
                        BasePropiedadId_Identity = 0;
                        BasePropiedadB_Agregando = false;
                        BasePropiedadB_Editando = true;
                    }
                    else
                    {
                        K_Orden_Compra = 0;

                        BasePropiedadEsRegistroNuevo = true;
                        BasePropiedadId_Identity = 0;
                        BasePropiedadB_Agregando = true;
                        BasePropiedadB_Editando = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                BasePropiedadEsRegistroNuevo = true;
                BasePropiedadId_Identity = 0;
                BasePropiedadB_Agregando = true;
                BasePropiedadB_Editando = false;
            }
            Cursor = Cursors.Default;

        }
        private void LlenaControles(DataRow row)
        {         
            bool B_Directa = Convert.ToBoolean(row["B_Directa"].ToString());
            txtClaveOficina.Text = row["K_Oficina"].ToString();
            txtOficina.Text = row["D_Oficina"].ToString();
            if (txtClaveOficina.Text.Trim().Length > 0)
                CargaAlmacenes();
            cbxAlmacen.SelectedValue = Convert.ToInt32(row["K_Almacen"].ToString());
            txtClaveProveedor.Text = row["K_Proveedor"].ToString();
            txtProveedor.Text = row["Nombre"].ToString();
            DataTable dtSucursales = sqlCatalogos.Sk_Sucursales_Proveedor(Convert.ToInt32(txtClaveProveedor.Text));
            if (dtSucursales != null)
            {
                LlenaCombo(dtSucursales, ref cbxSucursales, "K_Sucursal_Proveedor", "D_Sucursal_Proveedor", 0);
            }
            cbxSucursales.SelectedValue = Convert.ToInt32(row["K_Sucursal_Proveedor"].ToString());
            txtFechaEntrega.Value = Convert.ToDateTime(row["F_Entrega"].ToString());
            txtTiempoEntrega.Text = row["TiempoEntrega"].ToString();
            txtObservaciones.Text = row["Observaciones"].ToString();

            try
            {
                if (dtDatos.Rows.Count == 0)
                {
                    dtDatos.Columns.Add("Porcentaje", typeof(decimal));
                    dtDatos.AcceptChanges();
                }
            }
            catch (Exception ex) { }

            DataTable dtDetalle = sqlCompras.Sk_ConsultaOrdenesCompraDetalle(K_Orden_Compra);
            if (dtDetalle != null)
            {
                if (dtDetalle.Rows.Count > 0)
                {
                    foreach (DataRow ren in dtDetalle.Rows)
                    {
                        DataRow dr = dtDatos.NewRow();
                        //dr["K_Detalle_Compra"] = 0;
                        //dr["K_Articulo"] = ren["K_Articulo"];
                        //dr["D_Articulo"] = ren["D_Articulo"];
                        //dr["CantidadRequerida"] = ren["Cantidad"];
                        //dr["Unitario"] = ren["Precio_Unitario"];
                        //dr["IVA"] = ren["IVA"];
                        //dr["SubTotal"] = ren["Subtotal"];
                        //dr["PrecioTotal"] = ren["PrecioTotal"];
                        //dr["ObservacionesDetalle"] = "";
                        //dr["Porcentaje_Descuento"] = ren["Porcentaje_Descuento"].ToString() != "" ? ren["Porcentaje_Descuento"] : 0;
                        //decimal Monto_Descuento = ren["Porcentaje_Descuento"].ToString() != "" ? (Convert.ToDecimal(ren["Porcentaje_Descuento"]) / 100) * Convert.ToDecimal(ren["SubTotal"]) : 0;
                        //dr["Monto_Descuento"] = Monto_Descuento;
                        //dr["Porcentaje_Descuento_2"] = ren["Porcentaje_Descuento_2"].ToString() != "" ? ren["Porcentaje_Descuento_2"] : 0;
                        //decimal Monto_Descuento_2 = ren["Porcentaje_Descuento_2"].ToString() != "" ? (Convert.ToDecimal(ren["Porcentaje_Descuento_2"]) / 100) * Convert.ToDecimal(ren["SubTotal"]) : 0;
                        //dr["Monto_Descuento_2"] = Monto_Descuento_2;
                        dr["K_Detalle_Compra"] = 0;
                        dr["K_Articulo"] = ren["K_Articulo"];
                        dr["D_Articulo"] = ren["D_Articulo"];
                        dr["CantidadRequerida"] = ren["Cantidad"];
                        dr["Unitario"] = ren["Precio_Unitario"];
                        dr["Porcentaje"] = ren["TasaIva"];
                        dr["IVA"] = ren["IVA"]; ;
                        dr["SubTotal"] = ren["Subtotal"];
                        dr["PrecioTotal"] = ren["PrecioTotal"];
                        dr["ObservacionesDetalle"] = "";
                        dr["Porcentaje_Descuento"] = 0;
                        decimal Monto_Descuento = (Convert.ToDecimal(dr["Porcentaje_Descuento"]) / 100) * Convert.ToDecimal(dr["SubTotal"]);
                        dr["Monto_Descuento"] = Monto_Descuento;
                        dr["Porcentaje_Descuento_2"] = 0;
                        decimal Monto_Descuento_2 = (Convert.ToDecimal(dr["Porcentaje_Descuento_2"]) / 100) * Convert.ToDecimal(dr["SubTotal"]);
                        dr["Monto_Descuento_2"] = Monto_Descuento_2;
                        dr["Porcentaje_Ieps"] = PPorcentaje_Ieps.ToString();
                        dr["IEPS"] = ren["IEPS"];

                        dtDatos.Rows.Add(dr);
                    }
                    grdDetalle.DataSource = dtDatos;
                    B_NoEntrar = true;
                    Calcula();
                }
                grdDetalle.DataSource = dtDatos;
                //grdDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
                //grdDetalle.AutoResizeColumns(Data}GridViewAutoSizeColumnsMode.AllCells);
                //grdDetalle.MultiSelect = false;
                //grdDetalle.Rows[0].Cells[0].Selected = true;

                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
                BaseBotonNuevo.Enabled = false;
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;


            }
        }
        private void Frm_Orden_Compra_Directa_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F10))
            {
                BaseBotonProceso1Click();
            }
        }

        public override void BaseBotonModificarClick()
        {
            grdDetalle.ClearSelection();

            BasePropiedadEsRegistroNuevo = false;
            //BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = true;

            pnlDetalle.Enabled = true;
            pnlCaptura.Enabled = false;
            tcControl.Enabled = true;

            grdDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
            grdDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdDetalle.MultiSelect = false;
            grdDetalle.Rows[0].Cells[4].Selected = true;
            grdDetalle.Focus();
        }
    }
}
