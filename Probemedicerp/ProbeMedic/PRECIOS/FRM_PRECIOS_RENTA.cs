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
using ProbeMedic.CATALOGOS.PRECIOS;

namespace ProbeMedic.PRECIOS
{
    public partial class FRM_PRECIOS_RENTA : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLPrecios sql_precios = new SQLPrecios();

        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_DISPONIBLESS = new DataTable();

        DataTable Ar = new DataTable();

        int res = -1, entra = 1;

        string msg = string.Empty;

        private void FRM_PRECIOS_RENTA_Load(object sender, EventArgs e)
        {
            dtpInicial.Focus();

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;



            //FILTRO
            AR_DISPONIBLES.Columns.Add("K_Precio_Articulo", typeof(Int32));
            AR_DISPONIBLES.Columns.Add("K_Articulo", typeof(Int32));
            AR_DISPONIBLES.Columns.Add("D_Articulo", typeof(string));
            AR_DISPONIBLES.Columns.Add("SKU", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Familia", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Laboratorio", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Sustancia_Activa", typeof(string));
            AR_DISPONIBLES.Columns.Add("F_Actualizacion", typeof(DateTime));
            AR_DISPONIBLES.Columns.Add("Precio", typeof(decimal));
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
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

                AR_DISPONIBLESS = sql_Catalogos.Sk_Articulos_Consulta(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text);

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
                        dtdRow3["Precio"] = "0.00";
                        AR_DISPONIBLES.Rows.Add(dtdRow3);
                    }
                    grDatos.DataSource = AR_DISPONIBLES;
                }


            }
            else
            {
                MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpia();
            BuscaPorFechas();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta();
            entra = 0;
            btnAplicaPrecios.Enabled = true;
            gbFiltrar.Enabled = true;
        }

        private void btnAplicaPrecios_Click(object sender, EventArgs e)
        {
            AltaPrecios();
            btnAplicaPrecios.Enabled = false;
            dtpInicial.Focus();
            gbFiltrar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarPrecios();
        }

        public FRM_PRECIOS_RENTA()
        {
            InitializeComponent();
        }
        private void limpia()
        {
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
                dt.Clear();
            }
        }

        public void Alta()
        {
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
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

                AR_DISPONIBLESS = sql_Catalogos.Sk_Articulos_Consulta_Renta(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text);

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
                        dtdRow3["Precio"] = "0.00";
                        AR_DISPONIBLES.Rows.Add(dtdRow3);
                    }
                    grDatos.DataSource = AR_DISPONIBLES;
                }

            }
            else
            {
                MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AltaPrecios()
        {
            DateTime FechaActualizacion = DateTime.Today;
            FechaActualizacion = Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd"));

            Int32 CampoIdentity = 0;
            msg = string.Empty;

            foreach (DataGridViewRow row in grDatos.Rows)
            {
                if (Convert.ToDecimal(row.Cells["Precio"].Value) <= 0)
                {
                    MessageBox.Show("LOS PRECIOS DEBEN DE SER MAYORES A CERO!.. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (DataGridViewRow row in grDatos.Rows)
            {
                res = sql_precios.In_Precios_Renta_Actual(ref CampoIdentity,
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                FechaActualizacion,
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
                limpia();

            }

        }

        private void BuscaPorFechas()
        {
            DateTime FechaInicial = DateTime.Today;
            DateTime FechaFinal = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpInicial.Value.ToString("yyyy/MM/dd"));
            FechaFinal = Convert.ToDateTime(dtpFinal.Value.ToString("yyyy/MM/dd"));

            AR_DISPONIBLESS = sql_precios.Sk_Precios_Renta_Articulos(FechaInicial, FechaFinal);

            if (AR_DISPONIBLESS != null)
            {
                foreach (DataRow irow in AR_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow = AR_DISPONIBLES.NewRow();
                    dtdRow["K_Precio_Articulo"] = irow["K_Precio_Renta_Articulo"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["SKU"] = irow["SKU"].ToString();
                    dtdRow["D_Familia"] = irow["D_Familia"].ToString();
                    dtdRow["D_Laboratorio"] = irow["D_Laboratorio"].ToString();
                    dtdRow["D_Sustancia_Activa"] = irow["D_Sustancia_Activa"].ToString();
                    dtdRow["F_Actualizacion"] = irow["F_Actualizacion"].ToString();
                    dtdRow["Precio"] = irow["Precio"].ToString();
                    AR_DISPONIBLES.Rows.Add(dtdRow);

                }
                grDatos.DataSource = AR_DISPONIBLES;


            }
            else
            {
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }
        }

        private void ModificarPrecios()
        {
            msg = string.Empty;

            if (grDatos.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }
            foreach (DataGridViewRow row in grDatos.Rows)
            {
                res = sql_precios.Up_Precios_Renta_Actual(
                Convert.ToInt32(row.Cells["K_Precio_Articulo"].Value),
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd")),
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
                limpia();
                BuscaPorFechas();
            }

        }
        public override void BaseBotonReporteClick()
        {
            FRM_REPORTE_PRECIOS_RENTA frmrpa = new FRM_REPORTE_PRECIOS_RENTA();
            frmrpa.ShowDialog();

        }
    }
}
