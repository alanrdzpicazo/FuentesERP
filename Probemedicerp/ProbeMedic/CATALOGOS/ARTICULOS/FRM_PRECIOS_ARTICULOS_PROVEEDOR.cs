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

namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    public partial class FRM_PRECIOS_ARTICULOS_PROVEEDOR : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable ARTICULOS= new DataTable();
        DataTable ARTICULOSS = new DataTable();

        int res = -1, entra = 1, KProveedor = 0;
        string msg = string.Empty;
       
        public FRM_PRECIOS_ARTICULOS_PROVEEDOR()
        {
            InitializeComponent();
            ucProveedor2.K_Proveedor = KProveedor;   
        }

        private void FRM_PRECIOS_ARTICULOS_PROVEEDOR_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Text = "Precios Actuales";
            BaseBotonReporte.Width = 120;
            ARTICULOS.Columns.Add("K_Precios_Articulo_Proveedor", typeof(int));
            ARTICULOS.Columns.Add("K_Articulo", typeof(int));
            ARTICULOS.Columns.Add("D_Articulo", typeof(string));
            ARTICULOS.Columns.Add("SKU", typeof(string)); 
            ARTICULOS.Columns.Add("F_Actualizacion", typeof(DateTime));
            ARTICULOS.Columns.Add("Precio_Articulo", typeof(decimal));
            ARTICULOS.Columns.Add("Porcentaje_Descuento", typeof(decimal));
            ARTICULOS.Columns.Add("D_Usuario", typeof(string));
   
            limpia();
        }
     
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (ucProveedor2.K_Proveedor == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProveedor2.Focus();
                return;
            }
            if (ucProveedor2.K_Proveedor != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            limpia();
            llenaGrid();
            panel3.Enabled = false;

        }

        private void btn_modificar(object sender, EventArgs e)
        {

            msg = string.Empty;

            if (dgvArticulosAsignados.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }

            if (ARTICULOS != null)
            {
                foreach (DataRow irew in ARTICULOS.Rows)
                {
                    res = sqlCatalogos.Up_Precios_Articulos_Proveedor(
                    Convert.ToInt32(irew["K_Precios_Articulo_Proveedor"]),
                    Convert.ToInt32(irew["K_Articulo"]),
                    Convert.ToInt32(ucProveedor2.K_Proveedor),
                    Convert.ToDecimal(irew["Precio_Articulo"]),
                    Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd")),
                    Convert.ToInt32(GlobalVar.K_Usuario),
                    Convert.ToDecimal(irew["Porcentaje_Descuento"]),
                    ref msg);
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
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }



            base.BaseBotonAfectarClick();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            if (ucProveedor2.K_Proveedor == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProveedor1.Focus();

            }
            if (ucProveedor2.K_Proveedor != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            limpia();
            llenaGridAlta();
            if (ARTICULOS == null)
            {
                panel3.Enabled = false;
                MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADOS AL PROVEEDOR!..");
            }
            else
            {
                panel3.Enabled = true;
            }
        }

        private void btn_aplica_precios_Click(object sender, EventArgs e)
        {
            short CampoIdentity = 0;
            msg = string.Empty;

            if (dgvArticulosAsignados.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }

            if (ARTICULOS != null)
            {
                foreach (DataRow irew in ARTICULOS.Rows)
                {
                    res = sqlCatalogos.In_Precios_Articulos_Proveedor(ref CampoIdentity,
                    Convert.ToInt16(irew["K_Articulo"]),
                    Convert.ToInt32(ucProveedor2.K_Proveedor),
                    Convert.ToString(irew["SKU"]),
                    Convert.ToDecimal(irew["Precio_Articulo"]),
                    Convert.ToDateTime(dtpActualiza.Value.ToString("yyyy/MM/dd")),
                    Convert.ToInt32(GlobalVar.K_Usuario),
                    Convert.ToDecimal(irew["Porcentaje_Descuento"]),
                    ref msg);
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
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    limpia();
                    BaseBotonCancelarClick();
                }
            }


            base.BaseBotonAfectarClick();
        }

        private void btn_sube_precios_Click(object sender, EventArgs e)
        {
            FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR frmrpa = new FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR();
            frmrpa.ShowDialog();
        }

        public override void BaseBotonReporteClick()
        {
            if (ucProveedor2.K_Proveedor == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProveedor2.Focus();
                return;
            }

            FRM_REPORTE_PRECIOS_ACTUALES frmrpa = new FRM_REPORTE_PRECIOS_ACTUALES();
            frmrpa.PropiedadK_Proveedor = Convert.ToInt32(ucProveedor2.K_Proveedor);
            frmrpa.PropiedadD_Proveedor = ucProveedor2.txt_D_Proveedor.Text.ToString();
            frmrpa.ShowDialog();

        }

        private void dgvArticulosAsignados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvArticulosAsignados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("SOLO SE PERMITEN NUMEROS DECIMALES!..");
        }

        private void llenaGrid()
        {
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpInicia.Value.ToString("yyyy/MM/dd"));

            DateTime FechaFinal = DateTime.Today;
            FechaFinal = Convert.ToDateTime(dtpFin.Value.ToString("yyyy/MM/dd"));

            ARTICULOSS = sql_Catalogos.Sk_Precios_Articulos_Proveedor(ucProveedor2.K_Proveedor, FechaInicial,FechaFinal);

            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {
                    DataRow dtdRow = ARTICULOS.NewRow();
                    dtdRow["K_Precios_Articulo_Proveedor"] = irow["K_Precios_Articulo_Proveedor"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["SKU"] = irow["SKU"].ToString();
                    dtdRow["F_Actualizacion"] = irow["F_Actualizacion"].ToString();
                    dtdRow["Precio_Articulo"] = irow["Precio_Articulo"].ToString();
                    if(irow["Porcentaje_Descuento"].ToString() == null || irow["Porcentaje_Descuento"].ToString() == "")
                    {
                        dtdRow["Porcentaje_Descuento"] = "0.00";
                    }
                    else
                    {
                        dtdRow["Porcentaje_Descuento"] = Convert.ToDecimal(irow["Porcentaje_Descuento"].ToString());
                    }

                  
                    dtdRow["D_Usuario"] = irow["D_Usuario"].ToString();
                    ARTICULOS.Rows.Add(dtdRow);
                }
                dgvArticulosAsignados.DataSource = ARTICULOS;
                dgvArticulosAsignados.CurrentCell.Selected = false;
            }
            else
            {
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }
        }

        private void llenaGridAlta()
        {
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpActualiza.Value.ToString("yyyy/MM/dd"));

            ARTICULOSS = sql_Catalogos.Sk_Proveedores_Articulos(ucProveedor2.K_Proveedor);

            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {
                    DataRow dtdRow = ARTICULOS.NewRow();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["SKU"] = irow["SKU"].ToString();
                    dtdRow["Precio_Articulo"] = Convert.ToString("0.00");
                    dtdRow["Porcentaje_Descuento"] = Convert.ToString("0.00");

                    ARTICULOS.Rows.Add(dtdRow);
                }
                dgvArticulosAsignados.DataSource = ARTICULOS;
                dgvArticulosAsignados.Columns["D_Usuario"].Visible = false;
                dgvArticulosAsignados.Columns["F_Actualizacion"].Visible = false;
                dgvArticulosAsignados.CurrentCell.Selected = true;

            }
            else
            {
                if (ucProveedor2.K_Proveedor != 0)
                {
                    MessageBox.Show("EL PROVEEDOR NO CUENTA CON ARTICULOS ASIGNADOS ...");
                }
            }



        }

        private void limpia()
        {
            if (dgvArticulosAsignados.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvArticulosAsignados.DataSource;
                dt.Clear();
            }
            panel3.Enabled = false;
            btn_modifica.Enabled = true;
        }
    }
}
