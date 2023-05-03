﻿using System;
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
    public partial class Frm_Filtro_Articulo_Clientes : Frm_Filtro
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLPrecios sql_precios = new SQLPrecios();
        DataTable articulos = new DataTable();
        DataTable articuloss = new DataTable();
        Int32 res = 0;
        string msg;

        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }
        public int K_Tipo_Producto_Seleccioado { get; set; }
        public string D_Tipo_Producto_Seleccionado { get; set; }
        public int K_Unidad_Medida_Seleccionado { get; set; }
        public string D_Unidad_Medida_Seleccionado { get; set; }
        public string SKU_Seleccionado { get; set; }
        public decimal Precio_Unitario_Seleccionado { get; set; }
        public decimal SubTotal_Seleccionado { get; set; }
        public decimal Total_IvaSeleccionado { get; set; }
        public int Iva_Seleccionado { get; set; }

        public Frm_Filtro_Articulo_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Filtro_Articulo_Clientes_Load(object sender, EventArgs e)
        {
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
            articulos.Columns.Add("SubTotal", typeof(decimal));
            articulos.Columns.Add("Total_Iva", typeof(decimal));
            articulos.Columns.Add("Porcentaje", typeof(Int32));
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
                articuloss = sql_precios.Sk_Precios_Articulos_Actual(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text);

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
                        dtdRow3["Precio_Unitario"] = Convert.ToDecimal(irew["Precio"]);
                        dtdRow3["SubTotal"] = Convert.ToDecimal(irew["SubTotal"]);
                        dtdRow3["Total_Iva"] = Convert.ToDecimal(irew["Total_Iva"]);
                        dtdRow3["Porcentaje"] = Convert.ToInt32(irew["Porcentaje"]);
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
                SubTotal_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["SubTotal"].Value.ToString());
                Total_IvaSeleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Total_Iva"].Value.ToString());
                Iva_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["Porcentaje"].Value.ToString());
                if (LLave_Seleccionado != 9999998)
                    ValidaPrecio();
                else
                    Close();
            }
        }

        private void grdArticulos_DoubleClick(object sender, EventArgs e)
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
            SubTotal_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["SubTotal"].Value.ToString());
            Total_IvaSeleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Total_Iva"].Value.ToString());
            Iva_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["Porcentaje"].Value.ToString());

            if (LLave_Seleccionado != 9999998)
                ValidaPrecio();
            else
                Close();
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
        private void Frm_Filtro_Articulo_Clientes_KeyDown(object sender, KeyEventArgs e)
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
                    Cursor = Cursors.WaitCursor;
                    articuloss = sql_precios.Sk_Precios_Articulos_Actual(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text);

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
                            dtdRow3["Precio_Unitario"] = Convert.ToDecimal(irew["Precio"]);
                            dtdRow3["SubTotal"] = Convert.ToDecimal(irew["SubTotal"]);
                            dtdRow3["Total_Iva"] = Convert.ToDecimal(irew["Total_Iva"]);
                            dtdRow3["Porcentaje"] = Convert.ToDecimal(irew["Porcentaje"]);
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
        }

        private void grdArticulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            SubTotal_Seleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["SubTotal"].Value.ToString());
            Total_IvaSeleccionado = Convert.ToDecimal(grdArticulos.CurrentRow.Cells["Total_Iva"].Value.ToString());
            Iva_Seleccionado = Convert.ToInt32(grdArticulos.CurrentRow.Cells["Porcentaje"].Value.ToString());

            if (LLave_Seleccionado != 9999998)
                ValidaPrecio();
            else
                Close();
        }

        private void grdArticulos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                SendKeys.Send("{Down}");
            }
        }
    }
    }
