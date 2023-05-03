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

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtro_Articulo_PedidoCotizacion : Frm_Filtro
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLVentas sql_ventas = new SQLVentas();
        SQLPrecios sql_precios = new SQLPrecios();

        DataTable articulos = new DataTable();
        DataTable articuloss = new DataTable();

        public int K_Cliente { get; set; }
        public int K_Paciente { get; set; }
        public string D_Cliente { get; set; }
        public string D_Paciente { get; set; }
        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }
        public int K_Tipo_Producto_Seleccioado { get; set; }
        public string D_Tipo_Producto_Seleccionado { get; set; }
        public int K_Unidad_Medida_Seleccionado { get; set; }
        public string D_Unidad_Medida_Seleccionado { get; set; }
        public string SKU_Seleccionado { get; set; }
        public decimal Precio_Unitario_Seleccionado { get; set; }
        public decimal Descuento_Seleccionado { get; set; }
        public decimal Porcentaje_Descuento_Seleccionado { get; set; }
        public decimal Tasa_IVA_Seleccionado { get; set; }
        public decimal Total_IVA_Seleccionado { get; set; }

        public Frm_Filtro_Articulo_PedidoCotizacion()
        {
            InitializeComponent();
            grdArticulos.AutoGenerateColumns = false;
        }

        private void Frm_Filtro_Articulo_PedidoCotizacion_Load(object sender, EventArgs e)
        {
            if (D_Cliente != null)
            {
                this.Text = "Busca Artículo [CLIENTE:" + D_Cliente + "]";
            }
            else if (D_Paciente != null)
            {
                this.Text = "Busca Artículo [PACIENTE:" + D_Paciente + "]";
            }
            articulos.Columns.Add("K_Articulo", typeof(Int32));
            articulos.Columns.Add("D_Articulo", typeof(string));
            articulos.Columns.Add("K_Tipo_Producto", typeof(Int32));
            articulos.Columns.Add("D_Tipo_Producto", typeof(string));
            articulos.Columns.Add("K_Unidad_Medida", typeof(Int32));
            articulos.Columns.Add("D_Unidad_Medida", typeof(string));
            articulos.Columns.Add("SKU", typeof(string));
            articulos.Columns.Add("D_Familia", typeof(string));
            articulos.Columns.Add("D_Laboratorio", typeof(string));
            articulos.Columns.Add("D_Sustancia_Activa", typeof(string));
            articulos.Columns.Add("Precio_Unitario", typeof(decimal));
            articulos.Columns.Add("Descuento", typeof(decimal));
            articulos.Columns.Add("Porcentaje_Descuento", typeof(decimal));
            articulos.Columns.Add("Tasa_IVA", typeof(decimal));
            articulos.Columns.Add("Total_IVA", typeof(decimal));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (grdArticulos.RowCount > 0)
            {
                DataTable dt = (DataTable)grdArticulos.DataSource;
                dt.Clear();
            }
            if (txtSKU.Text.Trim() == "")
            {
                txtSKU.Text = null;
            }
            if (txt_D_Articulo.Text.Trim() == "")
            {
                txt_D_Articulo.Text = null;
            }

            if ((ucFamiliaArticulo1.K_Familia_Articulo > 0) || (ucLaboratorio1.K_Laboratorio > 0) || (ucSustanciaActiva1.K_Sustancia_Activa > 0) || txtSKU.Text != null || txt_D_Articulo.Text != null)
            {
                Cursor = Cursors.WaitCursor;
                articuloss = sql_ventas.Sk_Articulos_Pedidos(0, ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text, K_Paciente, K_Cliente);

                if (articuloss != null)
                {
                    foreach (DataRow irew in articuloss.Rows)
                    {
                        DataRow dtdRow3 = articulos.NewRow();
                        dtdRow3["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
                        dtdRow3["D_Articulo"] = irew["D_Articulo"].ToString();
                        dtdRow3["SKU"] = irew["SKU"].ToString();
                        dtdRow3["D_Familia"] = irew["D_Familia"].ToString();
                        dtdRow3["D_Laboratorio"] = irew["D_Laboratorio"].ToString();
                        dtdRow3["D_Sustancia_Activa"] = irew["D_Sustancia_Activa"].ToString();
                        dtdRow3["K_Unidad_Medida"] = Convert.ToInt32(irew["K_Unidad_Medida"]);
                        dtdRow3["D_Unidad_Medida"] = irew["D_Unidad_Medida"].ToString();
                        dtdRow3["K_Tipo_Producto"] = Convert.ToInt32(irew["K_Tipo_Producto"]);
                        dtdRow3["D_Tipo_Producto"] = irew["D_Tipo_Producto"].ToString();
                        dtdRow3["Precio_Unitario"] = Convert.ToDecimal(irew["Precio_Unitario"]);
                        dtdRow3["Descuento"] = Convert.ToDecimal(irew["Descuento"]);
                        dtdRow3["Porcentaje_Descuento"] = Convert.ToDecimal(irew["PorcentajeDescuento"]);
                        dtdRow3["Tasa_IVA"] = Convert.ToDecimal(irew["Tasa_IVA"]);
                        dtdRow3["Total_IVA"] = Convert.ToDecimal(irew["Total_IVA"]);
                        articulos.Rows.Add(dtdRow3);
                    }
                    grdArticulos.DataSource = articulos;
                    grdArticulos.Focus();
                    
                }
                Cursor = Cursors.Default;


            }
            else
            {
                MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                grdArticulos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = grdArticulos.CurrentRow;
                if (row == null)
                    return;

                LLave_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Articulo"].Value.ToString());
                Descripcion_Seleccionado = grdArticulos.CurrentRow.Cells["D_Articulo"].Value.ToString();
                K_Tipo_Producto_Seleccioado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Tipo_Producto"].Value.ToString());
                D_Tipo_Producto_Seleccionado = grdArticulos.CurrentRow.Cells["D_Tipo_Producto"].Value.ToString();
                K_Unidad_Medida_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Unidad_Medida"].Value.ToString());
                D_Unidad_Medida_Seleccionado = grdArticulos.CurrentRow.Cells["D_Unidad_Medida"].Value.ToString();
                SKU_Seleccionado = grdArticulos.CurrentRow.Cells["SKU"].Value.ToString();
                Precio_Unitario_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Precio_Unitario"].Value.ToString());
                Descuento_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Descuento"].Value.ToString());
                Porcentaje_Descuento_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Porcentaje_Descuento"].Value.ToString());
                Tasa_IVA_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Tasa_IVA"].Value.ToString());
                Total_IVA_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Total_IVA"].Value.ToString());
                this.Close();
            }
        }

        private void Frm_Filtro_Articulo_Pedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {

                if (grdArticulos.RowCount > 0)
                {
                    DataTable dt = (DataTable)grdArticulos.DataSource;
                    dt.Clear();
                }
                if (txtSKU.Text.Trim() == "")
                {
                    txtSKU.Text = null;
                }
                if (txt_D_Articulo.Text.Trim() == "")
                {
                    txt_D_Articulo.Text = null;
                }

                if ((ucFamiliaArticulo1.K_Familia_Articulo > 0) || (ucLaboratorio1.K_Laboratorio > 0) || (ucSustanciaActiva1.K_Sustancia_Activa > 0) || txtSKU.Text != null || txt_D_Articulo.Text != null)
                {

                    articuloss = sql_ventas.Sk_Articulos_Pedidos(0, ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text, K_Paciente, K_Cliente);

                    if (articuloss != null)
                    {
                        foreach (DataRow irew in articuloss.Rows)
                        {
                            DataRow dtdRow3 = articulos.NewRow();
                            dtdRow3["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
                            dtdRow3["D_Articulo"] = irew["D_Articulo"].ToString();
                            dtdRow3["SKU"] = irew["SKU"].ToString();
                            dtdRow3["D_Familia"] = irew["D_Familia"].ToString();
                            dtdRow3["D_Laboratorio"] = irew["D_Laboratorio"].ToString();
                            dtdRow3["D_Sustancia_Activa"] = irew["D_Sustancia_Activa"].ToString();
                            dtdRow3["K_Unidad_Medida"] = Convert.ToInt32(irew["K_Unidad_Medida"]);
                            dtdRow3["D_Unidad_Medida"] = irew["D_Unidad_Medida"].ToString();
                            dtdRow3["K_Tipo_Producto"] = Convert.ToInt32(irew["K_Tipo_Producto"]);
                            dtdRow3["D_Tipo_Producto"] = irew["D_Tipo_Producto"].ToString();
                            dtdRow3["Precio"] = Convert.ToDecimal(irew["Precio"]);
                            dtdRow3["Descuento"] = Convert.ToDecimal(irew["Descuento"]);
                            dtdRow3["Porcentaje_Descuento"] = Convert.ToDecimal(irew["Porcentaje_Descuento"]);
                            dtdRow3["Tasa_IVA"] = Convert.ToDecimal(irew["Tasa_IVA"]);
                            dtdRow3["Total_IVA"] = Convert.ToDecimal(irew["Total_IVA"]);
                            articulos.Rows.Add(dtdRow3);
                        }
                        grdArticulos.DataSource = articulos;
                        grdArticulos.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsLetter(e.KeyChar)) ||(e.KeyChar == Convert.ToChar(Keys.Back)))
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
            articulos.DefaultView.RowFilter = $"D_Articulo LIKE '%{txtFiltro.Text}%' or  D_Laboratorio LIKE '%{txtFiltro.Text}%' or  D_Familia LIKE '%{txtFiltro.Text}%' or  D_Sustancia_Activa LIKE '%{txtFiltro.Text}%'";
        }

        private void grdArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdArticulos.CurrentRow;
            if (row == null)
                return;
            LLave_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Articulo"].Value.ToString());
            Descripcion_Seleccionado = grdArticulos.CurrentRow.Cells["D_Articulo"].Value.ToString();
            K_Tipo_Producto_Seleccioado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Tipo_Producto"].Value.ToString());
            D_Tipo_Producto_Seleccionado = grdArticulos.CurrentRow.Cells["D_Tipo_Producto"].Value.ToString();
            K_Unidad_Medida_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["K_Unidad_Medida"].Value.ToString());
            D_Unidad_Medida_Seleccionado = grdArticulos.CurrentRow.Cells["D_Unidad_Medida"].Value.ToString();
            SKU_Seleccionado = grdArticulos.CurrentRow.Cells["SKU"].Value.ToString();
            Precio_Unitario_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Precio_Unitario"].Value.ToString());
            Descuento_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Descuento"].Value.ToString());
            Porcentaje_Descuento_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Porcentaje_Descuento"].Value.ToString());
            Tasa_IVA_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Tasa_IVA"].Value.ToString());
            Total_IVA_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Total_IVA"].Value.ToString());
            ValidaPrecio();
        }
        private void ValidaPrecio()
        {
            int res = 0;
            string Mensaje = "";
            res = sql_precios.Gp_ValidaPrecioGanancia(LLave_Seleccionado, Precio_Unitario_Seleccionado, ref Mensaje);
            if (res == -1)
            {
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void grdArticulos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                SendKeys.Send("{Down}");
            }
        }

        private void grdArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
