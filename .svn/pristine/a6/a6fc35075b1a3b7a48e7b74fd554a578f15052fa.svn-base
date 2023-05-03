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
    public partial class FRM_PRECIOS_ARTICULOS_PROVEEDOR : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable ARTICULOS= new DataTable();
        DataTable ARTICULOSS = new DataTable();

        int res = -1, entra = 1, KProveedor = 0;
        string msg = string.Empty;

        bool B_NoEntrar;

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
            BaseBotonReporte.Width = 100;
            ARTICULOS.Columns.Add("K_Precios_Articulo_Proveedor", typeof(int));
            ARTICULOS.Columns.Add("K_Articulo", typeof(int));
            ARTICULOS.Columns.Add("D_Articulo", typeof(string));
            ARTICULOS.Columns.Add("SKU", typeof(string)); 
            ARTICULOS.Columns.Add("F_Actualizacion", typeof(DateTime));
            ARTICULOS.Columns.Add("Precio_Articulo", typeof(decimal));
            ARTICULOS.Columns.Add("Porcentaje_Descuento", typeof(decimal));
            ARTICULOS.Columns.Add("D_Usuario", typeof(string));
   
            Limpia();
        }

        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dtpInicia.Value = inicio;
            dtpFin.Value = fin;
            pnlFechaActualiza.Enabled = false;
            gbFechasConsulta.Enabled = false;
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
            {
                if (entra == Convert.ToInt32(0))
                {
                    Limpia();
                }
            }
               
            entra = 0;
            Limpia();
            Cursor = Cursors.WaitCursor;
            llenaGrid();
            Cursor = Cursors.Default;
            pnlFechaActualiza.Enabled = false;
            gbFechasConsulta.Enabled = true;

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
            {
                if (entra == Convert.ToInt32(0))
                {
                    Limpia();
                }
            }         
            entra = 0;
            Limpia();
            Cursor = Cursors.WaitCursor;
            llenaGridAlta();
            Cursor = Cursors.Default;
            if (ARTICULOS == null)
            {
                pnlFechaActualiza.Enabled = false;
                gbFechasConsulta.Enabled = false;
                MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADOS AL PROVEEDOR!..");
            }
            else
            {
                pnlFechaActualiza.Enabled = true;
                gbFechasConsulta.Enabled = false;
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
                    Limpia();
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

        private void btnLimpia_Click(object sender, EventArgs e)
        {

        }

        public override void BaseBotonReporteClick()
        {
            if (ucProveedor2.K_Proveedor == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProveedor2.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            PRECIOS.FRM_REPORTE_PRECIOS_ACTUALES frmrpa = new PRECIOS.FRM_REPORTE_PRECIOS_ACTUALES();
            frmrpa.PropiedadK_Proveedor = Convert.ToInt32(ucProveedor2.K_Proveedor);
            frmrpa.PropiedadD_Proveedor = ucProveedor2.txt_D_Proveedor.Text.ToString();
            frmrpa.ShowDialog();
            Cursor = Cursors.Default;

        }

        private void llenaGrid()
        {
            //DateTime FechaInicial = DateTime.Today;
            //FechaInicial = Convert.ToDateTime(dtpInicia.Value.ToString("yyyy/MM/dd"));

            //DateTime FechaFinal = DateTime.Today;
            //FechaFinal = Convert.ToDateTime(dtpFin.Value.ToString("yyyy/MM/dd"));

            ARTICULOSS = sql_Catalogos.Sk_Precios_Articulos_Proveedor(ucProveedor2.K_Proveedor,dtpInicia.Value,dtpFin.Value);

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
                B_NoEntrar = true;
                dgvArticulosAsignados.DataSource = ARTICULOS;
                dgvArticulosAsignados.EditMode = DataGridViewEditMode.EditOnEnter;
                dgvArticulosAsignados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvArticulosAsignados.MultiSelect = false;
                dgvArticulosAsignados.Rows[0].Cells[5].Selected = true;

            }
            else
            {
                B_NoEntrar = false;
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }
        }

        private void dgvArticulosAsignados_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dgvArticulosAsignados_KeyPress);
            e.Control.TextChanged += new EventHandler(dgvArticulosAsignados_TextChanged);
        }

        private void dgvArticulosAsignados_TextChanged(object sender, EventArgs e)
        {
            if(blnCeldaDescuento())
            {
                try
                {
                    TextBox textBox = (TextBox)sender;
                    if (textBox.Text.Trim().Length > 0)
                    {
                        if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100)
                        {
                            MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex) { }
            }
            else
            {
                try
                {
                    TextBox textBox = (TextBox)sender;
                    if (textBox.Text.Trim().Length > 0)
                    {
                        if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= Int32.MaxValue)
                        {
                            MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex) { }
            }
           

        }

        private void dgvArticulosAsignados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!dgvArticulosAsignados.CurrentCell.IsInEditMode)
                {
                    dgvArticulosAsignados.BeginEdit(true);
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
            if (dgvArticulosAsignados.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return ((dgvArticulosAsignados.CurrentCell.ColumnIndex == 5) || (dgvArticulosAsignados.CurrentCell.ColumnIndex == 6));
        }

        private bool blnCeldaDescuento()
        {
            if (dgvArticulosAsignados.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (dgvArticulosAsignados.CurrentCell.ColumnIndex == 6);
        }

        private void dgvArticulosAsignados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if ((e.ColumnIndex == 5)|| (e.ColumnIndex == 6)) 
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    dgvArticulosAsignados.CancelEdit();

                    return;
                }
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
                B_NoEntrar = true;
                dgvArticulosAsignados.DataSource = ARTICULOS;
                dgvArticulosAsignados.EditMode = DataGridViewEditMode.EditOnEnter;
                dgvArticulosAsignados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvArticulosAsignados.MultiSelect = false;
                dgvArticulosAsignados.Rows[0].Cells[5].Selected = true;
                dgvArticulosAsignados.Columns["D_Usuario"].Visible = false;
                dgvArticulosAsignados.Columns["F_Actualizacion"].Visible = false;

            }
            else
            {
                if (ucProveedor2.K_Proveedor != 0)
                {
                    MessageBox.Show("EL PROVEEDOR NO CUENTA CON ARTICULOS ASIGNADOS ...");
                    pnlFechaActualiza.Enabled = false;
                    gbFechasConsulta.Enabled = false;
                    B_NoEntrar = false;
                }
            }



        }

        private void Limpia()
        {
            if (dgvArticulosAsignados.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvArticulosAsignados.DataSource;
                dt.Clear();
            }
            pnlFechaActualiza.Enabled = false;
            btn_modifica.Enabled = true;

        }
    }
}
