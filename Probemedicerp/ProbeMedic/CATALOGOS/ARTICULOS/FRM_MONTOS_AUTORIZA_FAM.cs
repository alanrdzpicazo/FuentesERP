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
    public partial class FRM_MONTOS_AUTORIZA_FAM : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable FAMILIAS = new DataTable();
        DataTable FAMILIASS = new DataTable();

        Int32 KFamilia;

        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }

        int res = -1;
        string msg = string.Empty;

        public FRM_MONTOS_AUTORIZA_FAM()
        {
            InitializeComponent();
            cambia_fuente_controles();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;

            ucFamiliaArticulo1.K_Familia_Articulo = KFamilia;
        }

        private void FRM_MONTOS_AUTORIZA_FAM_Load(object sender, EventArgs e)
        {
            ucFamiliaArticulo1.Focus();

            FAMILIAS.Columns.Add("K_Familia_Articulo", typeof(Int32));
            FAMILIAS.Columns.Add("D_Familia", typeof(string));
            FAMILIAS.Columns.Add("Monto_Minimo", typeof(decimal));
            FAMILIAS.Columns.Add("K_Usuario_Actualiza", typeof(Int32));
            FAMILIAS.Columns.Add("D_Usuario", typeof(string));
            FAMILIAS.Columns.Add("F_Actualizacion", typeof(DateTime));

            Limpia();
            LlenaGrid();
        }

     

        private void LlenaGrid()
        {


            FAMILIASS = sql_Catalogos.Sk_Montos_Requiere_Autorizacion();

            if (FAMILIASS != null)
            {

                foreach (DataRow irew in FAMILIASS.Rows)
                {
                    DataRow dtdRow = FAMILIAS.NewRow();
                    dtdRow["K_Familia_Articulo"] = irew["K_Familia_Articulo"].ToString();
                    dtdRow["D_Familia"] = irew["D_Familia"].ToString();
                    dtdRow["Monto_Minimo"] = irew["Monto_Minimo"].ToString();
                    dtdRow["K_Usuario_Actualiza"] = Convert.ToInt32(irew["K_Usuario_Actualiza"].ToString());
                    dtdRow["D_Usuario"] = irew["D_Usuario"].ToString();
                    dtdRow["F_Actualizacion"] = Convert.ToDateTime(irew["F_Actualizacion"].ToString());
                    FAMILIAS.Rows.Add(dtdRow);


                }
                grDatos.DataSource = FAMILIAS;
            }
        }

        private void Limpia()
        {
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
                dt.Clear();
            }

        }

        private void FRM_MONTOS_AUTORIZA_FAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (!BaseFuncionValidaciones())
                    return;

                res = sql_Catalogos.In_Montos_Requiere_Autorizacion(ucFamiliaArticulo1.K_Familia_Articulo, Convert.ToDecimal(txtPrecio.Contenido.Text), GlobalVar.K_Usuario, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpia();
                    LlenaGrid();
                }
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (ucFamiliaArticulo1.K_Familia_Articulo == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UNA FAMILIA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucFamiliaArticulo1.Focus();
                return false;
            }
            if (txtPrecio.Contenido.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL MONTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = sql_Catalogos.In_Montos_Requiere_Autorizacion(ucFamiliaArticulo1.K_Familia_Articulo, Convert.ToDecimal(txtPrecio.Contenido.Text), GlobalVar.K_Usuario, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpia();
                LlenaGrid();
            }
        }
     
    }
}
















