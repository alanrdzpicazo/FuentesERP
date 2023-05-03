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

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_PRECIOS_ART_CLIENTES : FormaBase
    {
        Int32  _K_Cliente = 0;
        string _D_Cliente;
        Int32 _K_Articulo = 9;

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
            BaseBotonReporte.Visible = false;
       
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
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente();
            filtra.ShowDialog();
            _K_Cliente = filtra.K_Cliente_Seleccionado;
            _D_Cliente = filtra.D_Cliente_Seleccionado;
            txtCliente.Text = Convert.ToString(_D_Cliente);
        
        }

        private void btnBusca_Click(object sender, EventArgs e)
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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            gbFiltros.Enabled = false;
            pnlAlta.Enabled = true;
            if(_K_Cliente == 0)
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
            BtnAplicar.Enabled = true;
         
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
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
            if (txtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PRECIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;

            }
            AltaPrecios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                llenaGrid();
            }



            base.BaseBotonAfectarClick();
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

            ARTICULOSS = sql_precios.Sk_Precio_Articulo_Cliente(_K_Cliente,FechaInicial,FechaFinal);

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
               grDatos.DataSource = ARTICULOS;
               grDatos.CurrentCell.Selected = false;

            }
            else
            {
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }

    
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

        private void AltaPrecios()
        {
            DateTime FechaActualizacion = DateTime.Today;
            FechaActualizacion = Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd"));


            Int32 CampoIdentity = 0;
            msg = string.Empty;

            res = sql_precios.In_Precio_Articulo_Cliente(ref CampoIdentity,
                _K_Articulo,_K_Cliente,Convert.ToDecimal(txtPrecio.Text),FechaActualizacion,GlobalVar.K_Usuario, ref msg);


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
    }
}
