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

namespace ProbeMedic.CATALOGOS.LABORATORIOS
{
    public partial class FRM_PRECIO_PROGRAMAS_ART : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable ARTICULOS = new DataTable();
        DataTable ARTICULOSS = new DataTable();
        DataTable ARTICULOSS_ = new DataTable();

        Int32 _K_Programa =0,_K_Articulo =0,_K_Aseguradora=0;
        int res = -1, entra = 1;
        string msg = string.Empty;

        public FRM_PRECIO_PROGRAMAS_ART()
        {
            InitializeComponent();
        }

        private void FRM_PRECIO_PROGRAMAS_ART_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Text = "Precios Actuales";
            BaseBotonReporte.Width = 120;

            ARTICULOS.Columns.Add("K_Programas_Articulos_Precios", typeof(int));
            ARTICULOS.Columns.Add("K_Articulo", typeof(int));
            ARTICULOS.Columns.Add("D_Articulo", typeof(string));
            ARTICULOS.Columns.Add("K_Laboratorio", typeof(int));
            ARTICULOS.Columns.Add("D_Laboratorio", typeof(string));
            ARTICULOS.Columns.Add("K_Aseguradora", typeof(int));
            ARTICULOS.Columns.Add("Precio", typeof(decimal));

            //ARTICULOSS_.Columns.Add("K_Articulo", typeof(int));
            //ARTICULOSS_.Columns.Add("D_Articulo", typeof(string));
            //ARTICULOSS_.Columns.Add("K_Laboratorio", typeof(int));
            //ARTICULOSS_.Columns.Add("D_Laboratorio", typeof(string));
           
            limpia();
        } 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_K_Programa != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            llenaGrid();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (_K_Programa == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROGRAMA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPrograma.Focus();

            }
            if (_K_Programa != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            llenaGridAlta();
            if (ARTICULOS == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADOS AL PROVEEDOR!..");
            }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            Int32 CampoIdentity = 0;
            msg = string.Empty;

            if (grdDatos.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }

            if (ARTICULOSS_ != null)
            {
                
                foreach (DataGridViewRow row in grdDatos.Rows)
                {
                    res = sqlCatalogos.In_Programas_Articulos_Precios(ref CampoIdentity,
                    Convert.ToInt16(_K_Programa),
                    Convert.ToInt32(row.Cells["K_Articulo"].Value),
                    Convert.ToInt32(_K_Aseguradora),
                    Convert.ToDecimal(row.Cells["Precio"].Value),
                    Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd")),
                    Convert.ToInt32(GlobalVar.K_Usuario),
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
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }


            base.BaseBotonAfectarClick();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_K_Programa == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR PROGRAMA!..");
                return;
            }

            if (_K_Aseguradora == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR ASEGURADORA!..");
                return;
            }

            msg = string.Empty;

            if (grdDatos.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }

            if (ARTICULOS != null)
            {
                foreach (DataGridViewRow row in grdDatos.Rows)
                {
                    res = sqlCatalogos.Up_Programas_Articulos_Precios(
                    Convert.ToInt32(row.Cells["K_Programas_Articulos_Precios"].Value),
                    Convert.ToInt16(_K_Programa),
                    Convert.ToInt32(row.Cells["K_Articulo"].Value),
                    Convert.ToInt32(_K_Aseguradora),
                    Convert.ToDecimal(row.Cells["Precio"].Value),
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
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                    limpia();
                    llenaGrid();
                }
            }



            base.BaseBotonAfectarClick();
        }

        private void llenaGrid()
        {
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd"));

            ARTICULOSS = sql_Catalogos.Sk_Programas_Articulos_Precios(_K_Programa, FechaInicial);

            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {

                    DataRow dtdRow = ARTICULOS.NewRow();
                    dtdRow["K_Programas_Articulos_Precios"] = irow["K_Programas_Articulos_Precios"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["K_Laboratorio"] = irow["K_Laboratorio"].ToString();
                    dtdRow["D_Laboratorio"] = irow["D_Laboratorio"].ToString();
                    dtdRow["K_Aseguradora"] = irow["K_Aseguradora"].ToString();
                    dtdRow["Precio"] = irow["Precio"].ToString();
                    ARTICULOS.Rows.Add(dtdRow);
                }
                grdDatos.DataSource = ARTICULOS;
                grdDatos.CurrentCell.Selected = false;
            }
            else
            {
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }
        }

        private void llenaGridAlta()
        {
            ARTICULOSS = sql_Catalogos.Sk_Programas_Articulos_Precios(_K_Programa);

            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {
                    DataRow dtdRow = ARTICULOS.NewRow();

                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["K_Laboratorio"] = irow["K_Laboratorio"].ToString();
                    dtdRow["D_Laboratorio"] = irow["D_Laboratorio"].ToString();
                    dtdRow["Precio"] = "0.00";     
                    ARTICULOS.Rows.Add(dtdRow);
                }
                grdDatos.DataSource = ARTICULOS;
                grdDatos.CurrentCell.Selected = false;
            }
            else
            {
                if (_K_Programa != 0)
                {
                    MessageBox.Show("EL PROGRAMA NO CUENTA CON ARTICULOS ASIGNADOS ...");
                }
            }

        }

        private void grdDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void grdDatos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("SOLO SE PERMITEN NUMEROS DECIMALES!..");
        }

        private void limpia()
        {
            if (grdDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grdDatos.DataSource;
                dt.Clear();
            }
        }
        private void btnBuscaAseguradora_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Aseguradora();
            Busquedas.Frm_Busca_Aseguradora frm = new Busquedas.Frm_Busca_Aseguradora();
            frm.ShowDialog();
            _K_Aseguradora = frm.LLave_Seleccionado;
            txtAseguradora.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {

            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Programas();
            Busquedas.Frm_Busca_Programa frm = new Busquedas.Frm_Busca_Programa();
            frm.ShowDialog();
            _K_Programa = frm.LLave_Seleccionado;
            txtPrograma.Text = frm.Descripcion_Seleccionado;
        }

        public override void BaseBotonReporteClick()
        {
            FRM_REP_PRECIOS_PROG_ACTUAL frmrpa = new FRM_REP_PRECIOS_PROG_ACTUAL();
            frmrpa.ShowDialog();

        }

    }
}
