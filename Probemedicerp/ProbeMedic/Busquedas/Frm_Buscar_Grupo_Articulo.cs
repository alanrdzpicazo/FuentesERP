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
    public partial class Frm_Buscar_Grupo_Articulo : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Grupo_Articulo = 0;
        public Frm_Buscar_Grupo_Articulo()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Grupos_Articulos();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Grupo_Articulo";
                CatalogoPropiedadCampoDescripcion = "D_Grupo_Articulo";
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
