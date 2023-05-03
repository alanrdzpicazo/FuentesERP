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
    public partial class FRM_PROGRAMA_ARTICULO : FormaBase
    {

        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        DataTable articulos= new DataTable();
        DataTable articulos_ = new DataTable();
        int res = -1, entra = 1;
        string msg = string.Empty;
        Int32 _K_Programa = 0;
        Int32 _K_Articulo = 0;

        public FRM_PROGRAMA_ARTICULO()
        {
            InitializeComponent();
            cambia_fuente_controles();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonReporte.Visible = false;
            LlenaGrid();
        }

        private void FRM_PROGRAMA_ARTICULO_Load(object sender, EventArgs e)
        {

            btnBuscarPrograma.Focus();
            articulos.Columns.Add("K_Articulo", typeof(Int32));
            articulos.Columns.Add("D_Articulo", typeof(string));
            articulos.Columns.Add("K_Familia_Articulo", typeof(Int32));
            articulos.Columns.Add("D_Familia", typeof(string));
            articulos.Columns.Add("F_Alta", typeof(DateTime));
            articulos.Columns.Add("K_Laboratorio", typeof(Int32));
            articulos.Columns.Add("D_Laboratorio", typeof(string));
            articulos.Columns.Add("K_Sustancia_Activa", typeof(string));
            articulos.Columns.Add("D_Sustancia_Activa", typeof(string));
        }

        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }

        public object CatalogoPropiedadId_Identity { get; set; }

        private void limpia()
        {
    
            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dgvDisponibles.DataSource;
                dt2.Clear();
            }
        }
      
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Articulos_All();
            Busquedas.Frm_Busca_Articulos frm = new Busquedas.Frm_Busca_Articulos();
            frm.ShowDialog();
            _K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Programas();
            Busquedas.Frm_Busca_Programa frm = new Busquedas.Frm_Busca_Programa();
            frm.ShowDialog();
            _K_Programa = frm.LLave_Seleccionado;
            txtPrograma.Text = frm.Descripcion_Seleccionado;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //if (_K_Programa != 0)

            //    if (entra == Convert.ToInt32(0))
            //    {
            //        limpia();
            //    }
            //entra = 0;
            limpia();
            LlenaGrid();

            if(dgvDisponibles.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADO AL PROGRAMA!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
      
            if (!BaseFuncionValidaciones())
                return;
            
                res = sql_Catalogos.In_Programas_Articulos(_K_Programa,_K_Articulo, GlobalVar.K_Usuario, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpia();
                    LlenaGrid();


                }

            
        }

        private void LlenaGrid()
        {
            
            articulos_ = sql_Catalogos.Sk_Programas_Articulos(_K_Programa);

            if (articulos_ != null)
            {
                foreach (DataRow irow in articulos_.Rows)
                {
                    DataRow dtdRow = articulos.NewRow();
                    dtdRow["K_Articulo"] = Convert.ToInt32(irow["K_Articulo"]);
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["K_Familia_Articulo"] = Convert.ToInt32(irow["K_Familia_Articulo"]);
                    dtdRow["D_Familia"] = irow["D_Familia"].ToString();
                    dtdRow["F_Alta"] = Convert.ToDateTime(irow["F_Alta"]);
                    dtdRow["K_Laboratorio"] = Convert.ToInt32(irow["K_Laboratorio"].ToString());
                    dtdRow["D_Laboratorio"] = irow["D_Laboratorio"];
                    dtdRow["K_Sustancia_Activa"] = Convert.ToInt32(irow["K_Sustancia_Activa"].ToString());
                    dtdRow["D_Sustancia_Activa"] = irow["D_Sustancia_Activa"];
                    articulos.Rows.Add(dtdRow);

                }
                dgvDisponibles.DataSource = articulos;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (_K_Programa == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROGRAMA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPrograma.Focus();
                return false;
            }
            if (_K_Articulo == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ARTICULO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulo.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void txtPrograma_TextChanged(object sender, EventArgs e)
        {
            limpia();
            LlenaGrid();
        }

        public override void BaseBotonNuevoClick()
        {
            _K_Articulo = 0;
            _K_Programa = 0;
            txtArticulo.Text = string.Empty;
            txtPrograma.Text = string.Empty;
            btnBuscarPrograma.Focus();
            BaseBotonCancelar.Visible = false;

        }
       
    }
}
