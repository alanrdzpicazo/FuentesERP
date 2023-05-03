using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Cotizacion : FormaBase
    {      
        int res = 0;
        string msg = string.Empty;

        int K_Articuloint = 0;
        int K_Cliente = 0;
        int K_Paciente = 0;

        int K_TipoProducto = 0;

        DateTime FechaVigencia = DateTime.Today.AddDays(30);
      
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();
        SQLPedidos sqlPedidos = new SQLPedidos();
        DataTable dtClientes = new DataTable();
        DataTable dtPacientes = new DataTable();
        DataTable dtTipoMoneda= new DataTable();
        DataTable dtDetalle = new DataTable();
        DataTable dtImpuestos = new DataTable();
        DataTable dtTipoProducto = new DataTable();
        DataTable dtArticulos = new DataTable();  
        
        public Frm_Cotizacion()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonGuardar.Visible= false;
            BaseBotonNuevo.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = true;

            dtDetalle = CotizacionDetalle_Type;
            dtClientes = sqlCatalogo.Sk_Clientes();
            dtPacientes = sqlCatalogo.Sk_Pacientes();
            dtTipoMoneda = sqlCatalogo.Sk_Tipo_Moneda();
            dtImpuestos = sqlCatalogo.Sk_Tipo_Iva();
   
            grdDetalle.AutoGenerateColumns = false;
            grdDetalle.DataSource = dtDetalle;

            //LlenaCombo(sqlCatalogo.Sk_Tipo_Moneda(), ref cbxMoneda, "", "", -1);
            lblTipoMoneda.Text = string.Empty;

            LlenaCombo(sqlCatalogo.Sk_Tipos_Productos(), ref cbxTipoProducto, "", "", -1);
            //txtTipoCambio.Text = "1";

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonAfectar.Image = ((System.Drawing.Image)(imageList1.Images["disk.png"]));
            BaseBotonAfectar.Text = "Guardar [F5]";

            lstCondiciones.SelectedIndex = 0; 

            TasaIVA();
            dtpVigencia.Value = FechaVigencia;
    
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            DataTable dt_pacientes = sqlCatalogo.Sk_Pacientes(GlobalVar.K_Empresa);

            Busquedas.BuscaPacientes frm = new Busquedas.BuscaPacientes();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_pacientes);
            frm.BusquedaPropiedadTablaFiltra = dt_pacientes;

            if (dt_pacientes != null)
            {
                if (dt_pacientes.Rows.Count == 1)
                {
                    K_Cliente = 0;
                    K_Paciente = Convert.ToInt32(dtPacientes.Rows[0]["K_Paciente"].ToString());
                    txtClaveCliente.Text = Convert.ToString(dtPacientes.Rows[0]["K_Paciente"]);
                    txtCliente.Text = dtPacientes.Rows[0]["Nombre_Completo"].ToString();
                    //MtdEstableceTasaIVA(Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Pais"]));
                    MtdEstableceTasaIVA(1);
                    MtdCargaProductos();                
                }
                else if (dt_pacientes.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Pacientes";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Cliente = 0;
                        K_Paciente = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Paciente"]);
                        txtClaveCliente.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Paciente"]);
                        txtCliente.Text = frm.BusquedaPropiedadReglonRes["Nombre_Completo"].ToString();
                        //MtdEstableceTasaIVA(Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Pais"]));
                        MtdEstableceTasaIVA(1);
                        MtdCargaProductos();
                    }
                    else
                    {
                        K_Cliente = 0;
                        K_Paciente = 0;
                        txtClaveCliente.Text = string.Empty;
                        txtCliente.Text = string.Empty;
                        //MtdEstableceTasaIVA(Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Pais"]));
                        MtdEstableceTasaIVA(1);
                        MtdCargaProductos();
                    }

                }
            }
            else
            {
                MessageBox.Show("LA EMPRESA NO TIENE PACIENTES ASIGNADOS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
            }                 
        }

        private void txtClaveCliente_Leave(object sender, EventArgs e)
        {
            //LimpiaDetalle();
            
            //K_Cliente = 0;
            //K_Paciente = 0;
            //BuscaEnTablaClaveDescripcion(dtPacientes, "K_Paciente", "Nombre_Completo", ref txtClaveCliente, ref txtCliente);
            //if (txtClaveCliente.Text.Trim().Length != 0)
            //{
            //     K_Paciente = Convert.ToInt32(txtClaveCliente.Text);
            //     DataRow[] dr;
            //     dr = dtPacientes.Select("K_Paciente= " + txtClaveCliente.Text);

            //     txtCliente.Text = dr[0].ItemArray[1].ToString();
            //     MtdEstableceTasaIVA(1);
            //}      
            MtdCargaProductos();
        }       

        private void txtTasaIVA_Leave(object sender, EventArgs e)
        {
            if (txtTasaIVA.Text == "" || txtTasaIVA.Text == "0")
            {
                txtTasaIVA.Text = "0";
            }
            else
            {
                if (txtTasaIVA.Text != "0" && txtTasaIVA.Text != dtImpuestos.Rows[0]["Porcentaje"].ToString())
                {
                    MessageBox.Show("TASA DE IMPUESTO INCORRECTA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTasaIVA.Text = "0";
                    return;
                }
            }
        }

        private void btnBuscaArticulo_Click(object sender, EventArgs e)
        {
            K_Articuloint = 0;
            txtPrecio.Enabled = true;
         
            if (txtClaveCliente.Text == "")
            {
                MessageBox.Show("FALTA SELECCIONAR UN PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveCliente.Focus();
                return;
            }

            FILTROS.Frm_Filtro_Articulo_PedidoCotizacion frm = new FILTROS.Frm_Filtro_Articulo_PedidoCotizacion();
            if(this.K_Cliente > 0)
            {
                frm.K_Cliente = this.K_Cliente;
                frm.D_Cliente = this.txtCliente.Text.Trim();
            }
            else
            {
                frm.K_Paciente = this.K_Paciente;
                frm.D_Paciente = this.txtCliente.Text.Trim();
            }
    
            frm.ShowDialog();
            if (frm.LLave_Seleccionado > 0)
            {
                K_Articuloint = Convert.ToInt32(frm.LLave_Seleccionado);
                txtClaveArticulo.Text = Convert.ToString(frm.LLave_Seleccionado);
                txtArticulo.Text = frm.Descripcion_Seleccionado.ToString();
                K_TipoProducto = frm.K_Tipo_Producto_Seleccioado;
                txtTipoProducto.Text = frm.D_Tipo_Producto_Seleccionado.ToString();
                LblPiezas.Text = frm.D_Unidad_Medida_Seleccionado.ToString();
                lblUMedida2.Text = LblPiezas.Text;
                txtPrecio.Text = (frm.Precio_Unitario_Seleccionado.ToString());
                this.txtCantidad.Focus();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            MtdSubTotal();
            MtdTotal();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            MtdSubTotal();
            MtdTotal();
        }

        private void txtTasaIVA_TextChanged(object sender, EventArgs e)
        {
            MtdTotal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CANTIDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }
            if (txtArticulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArticulo.Focus();
                return;
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PRECIO DE ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }
            if (txtTasaIVA.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA TASA DEL IVA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTasaIVA.Focus();
                return;
            }
            string SKU;
   
            bool B_Existe;

            if (dtDetalle.Rows.Count == 0)
            {
                DataRow dr;
                dr = dtDetalle.NewRow();
                dr["Cantidad"] = txtCantidad.Text;
                dr["K_Tipo_Producto"] = K_TipoProducto;
                dr["D_Tipo_Producto"] = txtTipoProducto.Text;
                dr["K_Articulo"] = K_Articuloint;
                dr["D_Articulo"] = (K_Articuloint == 0) ? "" : txtArticulo.Text;
                dr["PrecioUnitario"] = txtPrecio.Text;
                dr["PorcentajeDescuento"] = (txtPorcentajeDescuento.Text.Trim() == "") ? "0" : txtPorcentajeDescuento.Text;
                dr["Descuento"] = (txtDescuento.Text.Trim() == "") ? "0" : txtDescuento.Text.Replace("$", "").Replace(",", "");
                txtSubTotal.Text = txtSubTotal.Text.Replace("$", "").Replace(",", "");
                txtTotal.Text = txtTotal.Text.Replace("$", "").Replace(",", "");
                dr["Subtotal"] = txtSubTotal.Text;
                dr["Tasa_IVA"] = txtTasaIVA.Text;
                dr["Total_IVA"] = (Convert.ToDecimal(txtSubTotal.Text)) * (Convert.ToDecimal(txtTasaIVA.Text) / 100);
                dr["Total_Detalle"] = txtTotal.Text;
                dr["Comentarios"] = TxtComentario.Text;
                dtDetalle.Rows.Add(dr);

            }
            else
            {
                B_Existe = false;
                //se encuentra  sumo 
                foreach (DataRow row in dtDetalle.Rows)
                {
              
                    B_Existe = false;

                    if (K_Articuloint == Convert.ToInt32(row["K_Articulo"].ToString()))
                    {
                        row["Cantidad"] = Convert.ToInt32(row["Cantidad"]) + Convert.ToInt32(row["Cantidad"]);
                        row["SubTotal"] = Convert.ToDecimal(row["SubTotal"]) + Convert.ToDecimal(row["SubTotal"]);
                        row["Total_IVA"] = Convert.ToDecimal(row["Total_IVA"]) + Convert.ToDecimal(row["Total_IVA"]);
                        row["Total_Detalle"] = Convert.ToDecimal(row["Total_Detalle"]) + Convert.ToDecimal(row["Total_Detalle"]);
                        row["Descuento"] = Convert.ToDecimal(row["Descuento"]) + Convert.ToDecimal(row["Descuento"]);
                        B_Existe = true;
                        break;
                    }
                }
                if (B_Existe == false)
                {
                    DataRow dr;
                    dr = dtDetalle.NewRow();
                    dr["Cantidad"] = txtCantidad.Text;
                    dr["K_Tipo_Producto"] = K_TipoProducto;
                    dr["D_Tipo_Producto"] = txtTipoProducto.Text;
                    dr["K_Articulo"] = K_Articuloint;
                    dr["D_Articulo"] = (K_Articuloint == 0) ? "" : txtArticulo.Text;
                    dr["PrecioUnitario"] = txtPrecio.Text;
                    dr["PorcentajeDescuento"] = (txtPorcentajeDescuento.Text.Trim() == "") ? "0" : txtPorcentajeDescuento.Text;
                    dr["Descuento"] = (txtDescuento.Text.Trim() == "") ? "0" : txtDescuento.Text.Replace("$", "").Replace(",", "");
                    txtSubTotal.Text = txtSubTotal.Text.Replace("$", "").Replace(",", "");
                    txtTotal.Text = txtTotal.Text.Replace("$", "").Replace(",", "");
                    dr["Subtotal"] = txtSubTotal.Text;
                    dr["Tasa_IVA"] = txtTasaIVA.Text;
                    dr["Total_IVA"] = (Convert.ToDecimal(txtSubTotal.Text)) * (Convert.ToDecimal(txtTasaIVA.Text) / 100);
                    dr["Total_Detalle"] = txtTotal.Text;
                    dr["Comentarios"] = TxtComentario.Text;
                    dtDetalle.Rows.Add(dr);
                }
            }
            grdDetalle.DataSource = dtDetalle;

            TotalEncabezado();

            LimpiaDetalle();

        }

        private void txtPorcentajeDescuento_TextChanged(object sender, EventArgs e)
        {
            txtDescuento.Text =
               (
               (
                   (
                      ((txtPrecio.Text.Length == 0) ? 0 : Convert.ToDecimal(txtPrecio.Text))
                       *
                       ((txtCantidad.Text.Length == 0) ? 0 : Convert.ToDecimal(txtCantidad.Text))
                   )
                   *
                   (
                       ((txtPorcentajeDescuento.Text.Length == 0) ? 0 : Convert.ToDecimal(txtPorcentajeDescuento.Text)) / 100)
                   )
               ).ToString("C");
            MtdSubTotal();
            MtdTotal();
        }

        private void grdDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdDetalle.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                e.Value = imageList1.Images["Eliminar.png"];
            }
        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >-1)
            {
                if (e.ColumnIndex == 0) //Eliminar
                {
                    DataRow dr;
                    dr = dtDetalle.Rows[e.RowIndex];
                    dtDetalle.Rows.Remove(dr);

                    grdDetalle.DataSource = dtDetalle;

                    TotalEncabezado();
                    MtdSubTotal();
                    MtdTotal();
                }
            }
         
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CLIENTE O PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveCliente.Focus();
                return false;
            }
            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("FALTA CAPTURAR UN DETALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
         
            BaseErrorResultado = false;
            return true;
        }

        public override void BaseBotonAfectarClick()
        {
            MtdGuardar();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }

        private void Frm_Cotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116) //F5 Guardar
            {
                MtdGuardar();
            }
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
            if (txtTiempoEntrega.Text.Trim().Length > 0)
            {
                if (Convert.ToInt32(txtTiempoEntrega.Text.Trim()) > 365)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                        "EL VALOR MÁXIMO PERMITDO ES DE 365. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTiempoEntrega.Text = string.Empty;
                }
            }           
        }

        void MtdGuardar()
        {
            if (BaseFuncionValidaciones())
            {
                int K_Cotizacion = 0;
                DataTable dt;

                dt = dtDetalle.Copy();

                //dt.Columns.Remove("D_Tipo_Producto");
                //dt.Columns.Remove("D_Articulo");
                res = sqlPedidos.In_Cotizacion(ref K_Cotizacion, K_Cliente, K_Paciente,
                    Convert.ToDecimal(txtEncDescuento.Text.Replace("$", "").Replace(",", "")),
                    Convert.ToDecimal(txtEncSubtotal.Text.Replace("$", "").Replace(",", "")),
                    Convert.ToDecimal(TxtEncTasaIva.Text),               
                    Convert.ToDecimal(TxtEncIva.Text.Replace("$", "").Replace(",", "")),
                    Convert.ToDecimal(txtEncTotal.Text.Replace("$", "").Replace(",", "")),           
                    GlobalVar.K_Usuario, dtpVigencia.Value, lstCondiciones.SelectedItem.ToString(), Convert.ToInt16(txtTiempoEntrega.Text),
                    txtObservaciones.Text,
                    dt, false, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE" + System.Environment.NewLine + "Se generó el Número de Cotización  " + K_Cotizacion.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Reporte(K_Cotizacion);
                    LimpiaEncabezado();
                    LimpiaDetalle();
                    dtDetalle.Rows.Clear();
                    grdDetalle.DataSource = dtDetalle;
                }
            }
        }

        void MtdCargaProductos(string p_txtProducto = "")
        {
            txtClaveArticulo.Text = "";
            txtArticulo.Text = "";
            K_Articuloint = 0;

            dtArticulos.Rows.Clear();
            DataTable dtPaso;
         
            dtPaso = sqlVentas.Sk_Articulos_Pedidos(0, 0, 0, 0, String.Empty, String.Empty, K_Paciente, 0);
         
            if (dtPaso != null)
            {
                if (p_txtProducto == "")
                {
                    dtArticulos.Merge(dtPaso);
                }
                else
                {
                    dtArticulos.Merge(dtPaso.Select("K_Articulo= " + txtClaveArticulo.Text).CopyToDataTable());
                }
            }
        }

        void MtdEstableceTasaIVA(int p_K_Pais)
        {
            if (p_K_Pais == 1)
            {
                TasaIVA();
                txtTasaIVA.ReadOnly = true;
            }
            else
            {
                txtTasaIVA.ReadOnly = false;
                txtTasaIVA.Text = "0";
                TxtEncTasaIva.Text = "0";
            }
        }

        void TasaIVA()
        {
            try
            {
                //if (cbxMoneda.Text.ToString() != "DOLARES")
                //{
                txtTasaIVA.Text =(Convert.ToDecimal(dtImpuestos.Rows[0]["Porcentaje"]) / 1).ToString("N0");
                TxtEncTasaIva.Text = (Convert.ToDecimal(dtImpuestos.Rows[0]["Porcentaje"]) / 1).ToString("N0");
                //}
                //else
                //{
                //txtTasaIVA.Text = "0";
                //TxtEncTasaIva.Text = "0";
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void MtdSubTotal()
        {
            decimal Cantidad = 0;
            decimal Precio = 0;
            decimal decDescuneto = 0;

            if (txtCantidad.Text.Length > 0)
            {
                Cantidad = Convert.ToDecimal(txtCantidad.Text);
                                   
            }
            if (txtPrecio.Text.Length > 0)
            {
                Precio = Convert.ToDecimal(txtPrecio.Text);
            }
            decDescuneto = (txtDescuento.Text.Trim().Length == 0) ? 0 : Convert.ToDecimal(txtDescuento.Text.Replace("$", "").Replace(",", ""));
        
            txtSubTotal.Text = ((Cantidad * Precio) - decDescuneto).ToString("C");
           
        }

        void MtdTotal()
        {
            decimal Cantidad = 0;
            decimal Precio = 0;
            decimal Iva = 0;
            decimal decDescuneto = 0;

            if (txtCantidad.Text.Length > 0)
            {
                Cantidad = Convert.ToDecimal(txtCantidad.Text);
               
            }
            if (txtPrecio.Text.Length > 0)
            {
                Precio = Convert.ToDecimal(txtPrecio.Text);
            }
            if (txtTasaIVA.Text.Length > 0)
            {
                Iva = Convert.ToDecimal(txtTasaIVA.Text) / 100;
            }
            decDescuneto = (txtDescuento.Text.Trim().Length == 0) ? 0 : Convert.ToDecimal(txtDescuento.Text.Replace("$", "").Replace(",", ""));

            txtTotal.Text = (((Cantidad * Precio) - decDescuneto) * (1 + Iva)).ToString("C");
        }

        void TotalEncabezado()
        {
            decimal subtotal = 0;
            decimal IVA = 0;
            decimal Total = 0;
            decimal decDescuneto = 0;

            foreach (DataGridViewRow grow in grdDetalle.Rows)
            {
                subtotal += Convert.ToDecimal(grow.Cells["SubTotal"].Value);
                IVA += Convert.ToDecimal(grow.Cells["Total_IVA"].Value);
                Total += Convert.ToDecimal(grow.Cells["Total_Detalle"].Value);
                decDescuneto += Convert.ToDecimal(grow.Cells["Descuento"].Value);
            }

            txtEncDescuento.Text = decDescuneto.ToString("C");
            txtEncSubtotal.Text = subtotal.ToString("C");
            TxtEncIva.Text = IVA.ToString("C");
            txtEncTotal.Text = Total.ToString("C");
        }

        void LimpiaDetalle()
        {
            txtCantidad.Text = string.Empty;
            cbxTipoProducto.SelectedIndex = -1;
            txtClaveArticulo.Text = "";
            K_Articuloint = 0;
            txtArticulo.Text = "";
            txtPrecio.Text = "";
            txtPorcentajeDescuento.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            TxtComentario.Text = string.Empty;
            TasaIVA();
            cbxTipoProducto.Enabled = true;
            txtTipoProducto.Text = string.Empty;
            txtPrecio.Enabled = true;
            lblTipoMoneda.Text = string.Empty;
            lstCondiciones.SelectedIndex = 0;
        }

        void LimpiaEncabezado()
        {
            K_Cliente = 0;
            K_Paciente = 0;

            txtClaveCliente.Text = "";
            txtCliente.Text = "";
            txtObservaciones.Text = "";
            //cbxMoneda.SelectedIndex = -1;
            //txtTipoCambio.Text = "";

            dtpVigencia.Value = DateTime.Today;
            lstCondiciones.SelectedIndex = 0;

            txtTiempoEntrega.Text = "0";

            TxtEncIva.Text = "";
            txtEncSubtotal.Text = "";
            TxtEncTasaIva.Text = "";
            txtEncTotal.Text = "";
            txtEncDescuento.Text = "";

        }
   

      
    }
}
