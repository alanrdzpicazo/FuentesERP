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
    public partial class FRM_PRECIOS_ACTUALES_CLIENTES :FormaBase
    {
        Funciones fx = new Funciones();
        SQLPrecios sql_Precios = new SQLPrecios();

        DataTable excel = new DataTable();
        DataTable datos = new DataTable();
        DataTable datoss = new DataTable();

        Int32 intK_Cliente = 0;

        public FRM_PRECIOS_ACTUALES_CLIENTES()
        {
            InitializeComponent();
        }
        private void FRM_PRECIOS_ACTUALES_CLIENTES_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;

            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonBuscar.ToolTipText = "Buscar Artículos";
            BaseBotonBuscar.Text = "Buscar";
            BaseBotonBuscar.Width = 80;

            datos.Columns.Add("K_Precio_ArticuloCliente_Actual", typeof(int));
            datos.Columns.Add("K_Cliente", typeof(int));
            datos.Columns.Add("D_Cliente", typeof(string));
            datos.Columns.Add("K_Articulo", typeof(int));
            datos.Columns.Add("D_Articulo", typeof(string));
            datos.Columns.Add("Precio", typeof(decimal));
            datos.Columns.Add("F_Ultima_Actualizacion", typeof(DateTime));       
        }

        public void llenaGrid()
        {
            datoss = sql_Precios.Sk_Precios_ArticulosCliente_Actual(intK_Cliente);

            if (datoss != null)
            {
                foreach (DataRow irow in datoss.Rows)
                {
                    DataRow dtdRow = datos.NewRow();
                    dtdRow["K_Precio_ArticuloCliente_Actual"] = irow["K_Precio_ArticuloCliente_Actual"].ToString();
                    dtdRow["K_Cliente"] = irow["K_Cliente"].ToString();
                    dtdRow["D_Cliente"] = irow["D_Cliente"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["Precio"] = irow["Precio"].ToString();
                    dtdRow["F_Ultima_Actualizacion"] = irow["F_Ultima_Actualizacion"].ToString();

                    datos.Rows.Add(dtdRow);
                }
                BaseDtDatos = datos;
                dgvPreciosActuales.DataSource = datos;
                
            }
            else
            {

                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
        }
        public override void BaseBotonBuscarClick()
        {
            if(intK_Cliente == 0)
            {
                MessageBox.Show("DEBE INDICAR EL CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus() ;
                return;
            }
            limpia();
            llenaGrid();
        }

        private void limpia()
        {
            if (dgvPreciosActuales.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvPreciosActuales.DataSource;
                dt.Clear();
            }
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente frm = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            frm.ShowDialog();

            if (frm.K_Cliente_Seleccionado == 0)
            {
                intK_Cliente = 0;
                txtClaveCliente.Text = string.Empty;
                txtCliente.Text = string.Empty;
            }
            else
            {
                intK_Cliente = frm.K_Cliente_Seleccionado;
                txtClaveCliente.Text = Convert.ToString(frm.K_Cliente_Seleccionado);
                txtCliente.Text = frm.D_Cliente_Seleccionado;
            }
        }
    }
}
