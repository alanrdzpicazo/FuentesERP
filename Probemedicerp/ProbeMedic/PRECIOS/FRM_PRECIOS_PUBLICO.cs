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
    public partial class FRM_PRECIOS_PUBLICO : FormaBase
    {
        int res = -1, entra = 1;
        string msg = string.Empty;
        bool B_NoEntrar;

        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLPrecios sql_precios = new SQLPrecios();

        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_DISPONIBLESS = new DataTable();
        DataTable Ar = new DataTable();

        public FRM_PRECIOS_PUBLICO()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }
        private void FRM_PRECIOS_PUBLICO_Load(object sender, EventArgs e)
        {
            dtpInicial.Focus();

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = true;
            BaseBotonReporte.Text = "Prec. Actuales";
            BaseBotonReporte.Width = 100;

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

        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dtpInicial.Value = inicio;
            dtpFinal.Value = fin;

            decimal a = Convert.ToDecimal(grDatos.Width - 100) / Convert.ToDecimal(6);
            int b = Convert.ToInt32(a);

            grDatos.Columns["K_Articulo"].Width = b;
            grDatos.Columns["D_Articulo"].Width = b;
            grDatos.Columns["SKU"].Width = b;
            grDatos.Columns["D_Laboratorio"].Width = b;
            grDatos.Columns["F_Actualizacion"].Width = b;
            grDatos.Columns["Precio"].Width = b;

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
                    grDatos.EditMode = DataGridViewEditMode.EditOnEnter;
                    grDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    grDatos.Rows[0].Cells[8].Selected = true;
                    B_NoEntrar = true;
                    btnAplicaPrecios.Enabled = true;
                }
            }
            else
            {
                B_NoEntrar = false;
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
            //gbFiltrar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarPrecios();
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
                    grDatos.EditMode = DataGridViewEditMode.EditOnEnter;
                    grDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    grDatos.MultiSelect = false;
                    grDatos.Rows[0].Cells[8].Selected = true;
                    B_NoEntrar = true;
                }

            }
            else
            {
                B_NoEntrar = false;
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
                if(Convert.ToDecimal(row.Cells["Precio"].Value) <= 0)
                {
                    MessageBox.Show("LOS PRECIOS DEBEN DE SER MAYORES A CERO!.. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }         
            }

            foreach (DataGridViewRow row in grDatos.Rows)
            {
                res = sql_precios.In_Precios_Articulos(ref CampoIdentity,
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                FechaActualizacion,
                Convert.ToInt32(GlobalVar.K_Usuario),
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

            AR_DISPONIBLESS = sql_precios.Sk_Precios_Articulos(FechaInicial, FechaFinal);

            if (AR_DISPONIBLESS != null)
            {
                foreach (DataRow irow in AR_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow = AR_DISPONIBLES.NewRow();
                    dtdRow["K_Precio_Articulo"] = irow["K_Precio_Articulo"].ToString();
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
                res = sql_precios.Up_Precios_Articulos(
                Convert.ToInt32(row.Cells["K_Precio_Articulo"].Value),
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                Convert.ToDateTime(row.Cells["F_Actualizacion"].Value),
                Convert.ToInt32(GlobalVar.K_Usuario),
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

        private void grDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grDatos_KeyPress);
            e.Control.TextChanged += new EventHandler(grDatos_TextChanged);
        }
        private void grDatos_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length > 0)
            {
                decimal valor = 0;

                if (!Decimal.TryParse((textBox.Text.Trim().Replace("$", "")),out valor))
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void grDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!grDatos.CurrentCell.IsInEditMode)
                {
                    grDatos.BeginEdit(true);
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
        private bool blnCeldaImportes()
        {
            if (grDatos.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grDatos.CurrentCell.ColumnIndex == 8);
        }

        private void grDatos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    grDatos.CancelEdit();

                    return;
                }
            }
        }

        private void grDatos_Resize(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(grDatos.Width - 100) / Convert.ToDecimal(6);
            int b = Convert.ToInt32(a);

            grDatos.Columns["K_Articulo"].Width = b;
            grDatos.Columns["D_Articulo"].Width = b;
            grDatos.Columns["SKU"].Width = b;
            grDatos.Columns["D_Laboratorio"].Width = b;
            grDatos.Columns["F_Actualizacion"].Width = b;
            grDatos.Columns["Precio"].Width = b;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void BaseBotonReporteClick()
        {
            Cursor = Cursors.WaitCursor;
            PRECIOS.FRM_PRECIOS_ACTUALES_PUBLICOS frmrpa = new PRECIOS.FRM_PRECIOS_ACTUALES_PUBLICOS();
            frmrpa.ShowDialog();
            Cursor = Cursors.Default;
        }
    }
}
