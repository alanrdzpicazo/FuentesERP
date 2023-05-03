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

namespace ProbeMedic.PRECIOS
{
    public partial class FRM_PRECIOS_ACTUALES_PUBLICOS : FormaBase
    {
        Funciones fx = new Funciones();
        SQLPrecios sql_Precios = new SQLPrecios();
        DataTable excel = new DataTable();
        DataTable datos = new DataTable();
        DataTable datoss = new DataTable();
        public FRM_PRECIOS_ACTUALES_PUBLICOS()
        {
            InitializeComponent();
        }

        private void FRM_PRECIOS_ACTUALES_PUBLICOS_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;

            datos.Columns.Add("K_Precio_Articulo_Actual", typeof(int));
            datos.Columns.Add("K_Articulo", typeof(int));
            datos.Columns.Add("D_Articulo", typeof(string));
            datos.Columns.Add("Precio", typeof(decimal));
            datos.Columns.Add("F_Ultima_Actualizacion", typeof(DateTime));

            LlenaGrid();
        }
        public void LlenaGrid()
        {
            datoss = sql_Precios.Sk_Precios_Articulos_Actual(0,0,0,"","");

            if (datos != null)
            {
                foreach (DataRow irow in datoss.Rows)
                {
                    DataRow dtdRow = datos.NewRow();
                    dtdRow["K_Precio_Articulo_Actual"] = irow["K_Precio_Articulo_Actual"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["Precio"] = irow["Precio"].ToString();
                    dtdRow["F_Ultima_Actualizacion"] = irow["F_Ultima_Actualizacion"].ToString();

                    datos.Rows.Add(dtdRow);
                }
                dgvPreciosActuales.DataSource = datos;

            }
            else
            {

                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }
        private void Limpia()
        {
            if (dgvPreciosActuales.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvPreciosActuales.DataSource;
                dt.Clear();
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (datos != null)
            {
                if (datos.Rows.Count > 0)
                {
                    datos.DefaultView.RowFilter = String.Format("D_Articulo LIKE '%{0}%'", txtFiltrar.Text.Trim());
                }
            }
        }
    }
    }

