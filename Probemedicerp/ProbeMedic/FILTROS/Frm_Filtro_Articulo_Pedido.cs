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
    public partial class Frm_Filtro_Articulo_Pedido : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLVentas sql_ventas = new SQLVentas();
        SQLPrecios sql_precios = new SQLPrecios();

        DataTable articulos = new DataTable();
  
        public DataTable dtResultado;
        public DataTable dtTransferidos;
        public int K_Cliente { get; set; }
        public int K_Paciente{ get; set; }
        public string D_Cliente { get; set; }
        public string D_Paciente{ get; set; }
        public Frm_Filtro_Articulo_Pedido()
        {
            InitializeComponent();           
        }
        private void Frm_Filtro_Articulo_Pedido_Load(object sender, EventArgs e)
        {
            if (D_Cliente != null)
            {
                this.Text = "Busca Artículo [CLIENTE:" + D_Cliente + "]";
            }
            else if (D_Paciente != null)
            {
                this.Text = "Busca Artículo [PACIENTE:" + D_Paciente + "]";
            }
       

            this.grdArticulos.AutoGenerateColumns = false;
        }
        private void Frm_Filtro_Articulo_Pedido_Shown(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
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
                articulos = sql_ventas.Sk_Articulos_Pedidos(0,ucFamiliaArticulo1.K_Familia_Articulo,ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text,K_Paciente,K_Cliente);
                
                if (articulos!= null)
                {    
                    articulos.Columns.Add(new DataColumn("Cantidad", typeof(int)));

                    foreach (DataRow dr in articulos.Rows)
                    {
                        dr["Cantidad"] = 0;
                    }
                }
                grdArticulos.DataSource = articulos;

                if (dtTransferidos != null)
                {
                    foreach (DataGridViewRow grow in grdArticulos.Rows)
                    {
                        foreach (DataRow row in dtTransferidos.Rows)
                        {
                            if (grow.Cells["K_Articulo"].Value.ToString() == row["K_Articulo"].ToString())
                            {
                                grow.Cells["Cantidad"].ReadOnly = true;
                                grow.Cells["Cantidad"].Value = row["Cantidad"].ToString();
                                grow.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    articulos= sql_ventas.Sk_Articulos_Pedidos(0, ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text, K_Paciente, K_Cliente);


                }
                else
                {
                    MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if(articulos!=null)
            {
                if(articulos.Rows.Count>0)
                {
                    articulos.DefaultView.RowFilter = $"D_Articulo LIKE '%{txtFiltro.Text}%' or  D_Sustancia_Activa LIKE '%{txtFiltro.Text}%' or  D_Laboratorio LIKE '%{txtFiltro.Text}%' or  SKU LIKE '%{txtFiltro.Text}%'";
                }
            }
           
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dtResultado = articulos.Clone();
            articulos.AcceptChanges();

            String mensaje = string.Empty;

            foreach (DataRow dr in articulos.Rows)
            {
                if (Convert.ToString(dr["Cantidad"]) != "0" && Convert.ToString(dr["Cantidad"]) != "")
                {
                    dr["Total_IVA"] = Convert.ToDecimal(dr["Cantidad"].ToString()) * Convert.ToDecimal(dr["Total_IVA"].ToString());
                    dr["Subtotal"] = Convert.ToDecimal(dr["Cantidad"].ToString()) * Convert.ToDecimal(dr["Subtotal"].ToString());
                    dr["Descuento"] = Convert.ToDecimal(dr["Cantidad"].ToString()) * Convert.ToDecimal(dr["Descuento"].ToString());
                    dr["Total_Detalle"] = Convert.ToDecimal(dr["Cantidad"].ToString()) * Convert.ToDecimal(dr["Total_Detalle"].ToString());
                    articulos.AcceptChanges();
                    dtResultado.ImportRow(dr);
                }
            }
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = grdArticulos.CurrentRow;
            if (ren != null)
            {
                if (blnCeldaImportes())
                {
                    int res = 0;
                    string Mensaje = "";
                    res = sql_precios.Gp_ValidaPrecioGanancia(Convert.ToInt32(ren.Cells["K_Articulo"].Value.ToString()),
                                                              Convert.ToDecimal(ren.Cells["Precio_Unitario"].Value.ToString()), ref Mensaje);
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
            }
        }
        private bool blnCeldaImportes()
        {
            if (grdArticulos.CurrentCell == null)
                return false;

            return (grdArticulos.CurrentCell.ColumnIndex == 15);
        }

    }
}
