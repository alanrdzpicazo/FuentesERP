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


namespace ProbeMedic
{
    public partial class FRM_REGISTRO_FACTURAS : FormaBase
    {
        int res;
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sqlventas = new SQLVentas();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLPedidos sqlPedidos = new SQLPedidos();
        DataTable dtArticulos = new DataTable();
        DataTable dtEncabezado = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtAseguradora = new DataTable();


        int KTipoProducto = 0;
        string DTipoProducto = string.Empty;
        int KUnidadMedida = 0;
        string DUnidadMedida = string.Empty;
        string sKU = string.Empty;
        int KArticulo = 0;
        string DArticulo = string.Empty;
        decimal PrecioUnitario = 0;
        Int32 K_Oficina = 0;

        private Int32 K_Paciente_Direccion = 0;
        public int K_Paciente_Direccion1 { get => K_Paciente_Direccion; set => K_Paciente_Direccion = value; }

        private Int32 k_Cliente_Domicilio_Fiscal = 0;
        public int K_Cliente_Domicilio_Fiscal1 { get => k_Cliente_Domicilio_Fiscal; set => k_Cliente_Domicilio_Fiscal = value; }

        private Int32 K_Celula = 0;
        public int K_Celula1 { get => K_Celula; set => K_Celula = value; }

        private Int32 K_Aseguradora = 0;

        public FRM_REGISTRO_FACTURAS()
        {
            InitializeComponent();
        }

        private void FRM_REGISTRO_FACTURAS_Load(object sender, EventArgs e)
        {

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
        void MtdCargaAlmacen()
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
                dr["D_Almacen"] = "[SELECCIONAR]";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void btnBuscarPacienteDireccion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Paciente_Direccion frm = new Busquedas.Frm_Busca_Paciente_Direccion();
            frm.K_Paciente = ucPacientes1.K_Paciente;
            frm.ShowDialog();

            K_Paciente_Direccion1 = frm.LLave_Seleccionado;
            txtPacienteDireccion.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscarDomiclioFiscal_Click(object sender, EventArgs e)
        {
            DataTable dt_domicilios_fiscales = new DataTable();

            dt_domicilios_fiscales = sqlCatalogo.Sk_Cliente_Domicilios_Fiscales(ucClientes1.K_Cliente);

            Busquedas.BuscaDomicilioFiscalCliente frm = new Busquedas.BuscaDomicilioFiscalCliente();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_domicilios_fiscales);
            frm.BusquedaPropiedadTablaFiltra = dt_domicilios_fiscales;
            frm.BusquedaPropiedadTitulo = "Busca domicilios fiscales cliente";
            frm.ShowDialog();

            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente_Domicilio_Fiscal"]);
                txtDomicilioFiscal.Text = frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"] + " " + frm.BusquedaPropiedadReglonRes["D_Colonia"] + ", " + frm.BusquedaPropiedadReglonRes["D_Ciudad"] + " " + frm.BusquedaPropiedadReglonRes["D_Estado"];

            }
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

            btnAgregar.Enabled = true;
            txtCantidad.Enabled = true;
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



            DataRow dr;
            dr = dtArticulos.NewRow();

            decimal subtotal = (Convert.ToDecimal(txtCantidad.Text) * PrecioUnitario);
            decimal totaliva = subtotal * Convert.ToDecimal((0 + (decimal.Parse(txtTasaIVA.Text) / 100)));
            dr["Cantidad"] = txtCantidad.Text;
            dr["K_Tipo_Producto"] = KTipoProducto;
            dr["K_Unidad_Medida"] = KUnidadMedida;
            dr["SKU"] = sKU;
            dr["K_Articulo"] = KArticulo;
            dr["Precio_Unitario"] = Convert.ToDecimal(PrecioUnitario);
            dr["PorcentajeDescuento"] = 0;
            dr["Descuento"] = 0;
            dr["Subtotal"] = subtotal;
            dr["Tasa_IVA"] = txtTasaIVA.Text;
            dr["Total_IVA"] = totaliva;
            dr["Total_Detalle"] = (subtotal + totaliva);
            dr["Comentarios"] = "";
            dr["B_Facturado"] = 0;
            //dr["D_Articulo"] = DArticulo;
            //dr["D_Tipo_Producto"] = DTipoProducto;
            //dr["D_Unidad_Medida"] = DUnidadMedida;


            if (ChecaMismoArticulo(dtArticulos, KArticulo))
            {
                MessageBox.Show("YA EXISTE AGREGADO EL ARTÍCULO " + txtArticulo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else
            dtArticulos.Rows.Add(dr);

            grdDetalle.DataSource = dtArticulos;

            Mtd_Calcula_Totales();
            Mtd_Limpia_Informacion_Articulo();

            btnAgregar.Enabled = false;
            txtCantidad.Enabled = false;
        }
        void Mtd_Limpia_Informacion_Articulo()
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

        void Mtd_Calcula_Totales()
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
            decimal totalPedido = x + z + Convert.ToDecimal(this.txtbox_coaseguro.Text);
            txtTotalFactura.Text = Math.Round(totalPedido, 2).ToString("N2");

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

        public void Mtd_Incrementar(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r =>
            {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(txtTasaIVA.Text) / 100)));
                r["Total_Detalle"] = decimal.Parse(r["Subtotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());

            });

            Mtd_Calcula_Totales();

            grdDetalle.DataSource = dtArticulos;
        }

        public void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
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


            Mtd_Calcula_Totales();

            grdDetalle.DataSource = dtArticulos;
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = true;
            BaseBotonCancelar.Enabled = true;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            grdDetalle.AutoGenerateColumns = false;
            MtdCargaOficinaInicial();
            MtdCargaAlmacen();
            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar Datos Capturados en Pantalla";
            dtArticulos = FacturaDetalle_Type;
            this.WindowState = FormWindowState.Maximized;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));


        }
        void MtdCargaOficinaInicial()
        {
            K_Oficina = GlobalVar.K_Oficina;
            txtClaveOficina.Text = Convert.ToString(K_Oficina);

            txtOficina.Text = GlobalVar.D_Oficina;
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
            K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
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
            if (ucMedicos1.K_Medico == 0)
            {
                MessageBox.Show("FALTA CAPTURAR MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucMedicos1.Focus();
                return false;
            }
            if (ucTipoMoneda1.K_Tipo_Moneda == 0)
            {
                MessageBox.Show("FALTA CAPTURAR TIPO DE MONEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoMoneda1.Focus();
                return false;
            }
            if (txtTipoCambio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE CAMBIO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoCambio.Focus();
                return false;
            }
            if (ucPacientes1.K_Paciente == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPacientes1.Focus();
                return false;
            }
            if (K_Paciente_Direccion == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR DIRECCION DEL PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPacienteDireccion.Focus();
                return false;
            }
     
            if (ucClientes1.K_Cliente == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucClientes1.Focus();
                return false;
            }
            if (k_Cliente_Domicilio_Fiscal == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN DOMICILIO FISCAL DEL CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarDomiclioFiscal.Focus();
                return false;
            }
            if (grdDetalle.DataSource == null)
            {
                MessageBox.Show("FALTA AGREGAR ARTICULOS AL PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string msg = string.Empty;

            DataTable dtDetalle = dtArticulos.Copy();
           
            try
            {
                res = 0;
                res = sqlventas.In_Registro_Factura(
                               ref CampoIdentity,
                               K_Oficina,
                               dtpFechaEntrega.Value,
                               ucTipoMoneda1.K_Tipo_Moneda,
                               Convert.ToDecimal(txtTipoCambio.Text.Length > 0 ? txtTipoCambio.Text : "0" ),
                               ucClientes1.K_Cliente,
                               k_Cliente_Domicilio_Fiscal,
                               ucMedicos1.K_Medico,
                                Convert.ToDecimal(txtPorcentajeDescuento.Text.Length > 0 ? txtPorcentajeDescuento.Text:"0"),
                                Convert.ToDecimal(txtDescuento.Text),
                                Convert.ToDecimal(txtSubtotal.Text),
                                Convert.ToDecimal(txtTotalIVA.Text),
                                Convert.ToDecimal(txtTotalFactura.Text),
                                GlobalVar.K_Usuario,
                                Convert.ToDecimal(txtbox_coaseguro.Text), 
                                Convert.ToDecimal(txt_box_porcentaje_coaseguro.Text),
                                txtObservaciones.Text,
                                GlobalVar.PC_Name,
                                check_box_remisionado.Checked,
                                check_box_surtido_completo.Checked,
                                Convert.ToInt32(cbxAlmacen.SelectedValue),
                                ucPacientes1.K_Paciente,
                                K_Paciente_Direccion,
                                dtDetalle,
                                ref msg );
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

        private void txtPorcentajeDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
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
    }
}
