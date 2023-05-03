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

namespace ProbeMedic.Busquedas
{
    public partial class Frm_Busca_Categoria_Articulo : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Categoria_Articulo = 0;
        public Frm_Busca_Categoria_Articulo()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Categoria_Articulo();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Categoria_Articulo";
                CatalogoPropiedadCampoDescripcion = "D_Categoria_Articulo";
                base.BaseMetodoInicio();
            }
            else
            {

                MessageBox.Show("NO SE ENCONTRO INFORMACION", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
