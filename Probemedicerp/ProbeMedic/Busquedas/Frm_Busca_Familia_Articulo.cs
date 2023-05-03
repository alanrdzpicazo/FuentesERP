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
    public partial class Frm_Busca_Familia_Articulo : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Familia_Articulo = 0;
        public Frm_Busca_Familia_Articulo()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Familia_Articulo();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Familia_Articulo";
                CatalogoPropiedadCampoDescripcion = "D_Familia";
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
