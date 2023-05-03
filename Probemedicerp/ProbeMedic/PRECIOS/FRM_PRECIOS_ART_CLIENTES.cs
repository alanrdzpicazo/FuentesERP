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
using ProbeMedic.PRECIOS;

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_PRECIOS_ART_CLIENTES : FormaBase
    {
        Int32  _K_Cliente = 0;
        string _D_Cliente;
        Int32 _K_Articulo = 9;
        bool B_NoEntrar = false;

        SQLPrecios sql_precios = new SQLPrecios();

        DataTable ARTICULOS = new DataTable();
        DataTable ARTICULOSS = new DataTable();

        int res = -1, entra = 1;
        string msg = string.Empty;

        private void FRM_PRECIOS_ART_CLIENTES_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Text = "Precios Actuales";
            BaseBotonReporte.Width = 100;

            ARTICULOS.Columns.Add("K_Precio_Articulo_Cliente", typeof(int));
            ARTICULOS.Columns.Add("K_Articulo", typeof(int));
            ARTICULOS.Columns.Add("D_Articulo", typeof(string));
            ARTICULOS.Columns.Add("SKU", typeof(string));
            ARTICULOS.Columns.Add("K_Cliente", typeof(int));
            ARTICULOS.Columns.Add("Precio", typeof(decimal));
            ARTICULOS.Columns.Add("F_Actualizacion", typeof(DateTime));

            limpia();
        }

        public FRM_PRECIOS_ART_CLIENTES()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dtpInicial.Value = inicio;
            dtpFinal.Value = fin;
        }

        public override void BaseBotonReporteClick()
        {
            FRM_PRECIOS_ACTUALES_CLIENTES frmrpa = new FRM_PRECIOS_ACTUALES_CLIENTES();
            frmrpa.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            _K_Cliente = filtra.K_Cliente_Seleccionado;
            _D_Cliente = filtra.D_Cliente_Seleccionado;
            txtCliente.Text = Convert.ToString(_D_Cliente);
        }

        private void btnBuscaArticulo_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            _K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_K_Cliente == 0)
            {
                MessageBox.Show("DEBE INDICAR EL CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarCliente.Focus();
                return;

            }

            if (_K_Cliente != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            limpia();
            llenaGrid();


        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            gbFiltros.Enabled = false;
            pnlAlta.Enabled = true;
            if (_K_Cliente == 0)
            {
                MessageBox.Show("DEBE INDICAR EL CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarCliente.Focus();
                return;

            }
            if (_K_Cliente != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            btnAplicaPrecios.Enabled = true;

        }

        private void btnAplicaPrecios_Click(object sender, EventArgs e)
        {
            if (_K_Cliente == 0)
            {
                MessageBox.Show("DEBE INDICAR EL CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarCliente.Focus();
                return;

            }
            if (_K_Articulo == 0)
            {
                MessageBox.Show("DEBE INDICAR EL ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaArticulo.Focus();
                return;

            }
            if (txtPrecio.Contenido.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PRECIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;

            }
            AltaPrecios();

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            msg = string.Empty;

            if (grDatos.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }
            foreach (DataGridViewRow row in grDatos.Rows)
            {
                res = sql_precios.Up_Precio_Articulo_Cliente(
                Convert.ToInt32(row.Cells["K_Precio_Articulo_Cliente"].Value),
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToInt32(_K_Cliente),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                dtpActualizacion.Value,
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
                llenaGrid();
                dtpActualizacion.Enabled = false;
                gbFiltros.Enabled = true;
            }



            base.BaseBotonAfectarClick();
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Text = "Precios Actuales";
            BaseBotonReporte.Width = 120;
            limpia();
            dtpActualizacion.Enabled = false;
            gbFiltros.Enabled = true;
        }

        private void AltaPrecios()
        {
            DateTime FechaActualizacion = DateTime.Today;
            FechaActualizacion = Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd"));


            Int32 CampoIdentity = 0;
            msg = string.Empty;

            res = sql_precios.In_Precio_Articulo_Cliente(ref CampoIdentity,
                _K_Articulo,_K_Cliente,Convert.ToDecimal(txtPrecio.Contenido.Text.Replace(",","")),FechaActualizacion,GlobalVar.K_Usuario, ref msg);


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
                llenaGrid();
            }

        }

        //METODOS
        private void limpia()
        {
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
                dt.Clear();
            }
        }

        //CUANDO SE CONSULTA POR FECHAS LOS ARTICULOS DE UN CLIENTE
        private void llenaGrid()
        {
            DateTime FechaInicial = DateTime.Today;
            DateTime FechaFinal = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpInicial.Value.ToString("yyyy/MM/dd"));
            FechaFinal = Convert.ToDateTime(dtpFinal.Value.ToString("yyyy/MM/dd"));

            ARTICULOSS = sql_precios.Sk_Precio_Articulo_Cliente(_K_Cliente, FechaInicial, FechaFinal);

            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {
                    DataRow dtdRow = ARTICULOS.NewRow();
                    dtdRow["K_Precio_Articulo_Cliente"] = irow["K_Precio_Articulo_Cliente"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["SKU"] = irow["SKU"].ToString();
                    dtdRow["K_Cliente"] = irow["K_Cliente"].ToString();
                    dtdRow["Precio"] = irow["Precio"].ToString();
                    dtdRow["F_Actualizacion"] = irow["F_Actualizacion"].ToString();
                    ARTICULOS.Rows.Add(dtdRow);
                }
                B_NoEntrar = true;
                grDatos.DataSource = ARTICULOS;
                grDatos.CurrentCell.Selected = false;
                dtpActualizacion.Enabled = true;
                gbFiltros.Enabled = false;

            }
            else
            {
                B_NoEntrar = false;
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }


        }

        private void grDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grDatos_KeyPress);
            e.Control.TextChanged += new EventHandler(grDatos_TextChanged);
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

        private void grDatos_TextChanged(object sender, EventArgs e)
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
            catch
            {

            }
        }

        private bool blnCeldaImportes()
        {
            if (grDatos.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grDatos.CurrentCell.ColumnIndex == 6);
        }

    
    }
}
