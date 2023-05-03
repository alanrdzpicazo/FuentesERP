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
    public partial class Frm_Busca_Unidad_Medida : Frm_Buscar
    {

        SQLCatalogos sql = new SQLCatalogos();
        int K_Unidad_Medida= 0;
        public Frm_Busca_Unidad_Medida()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Unidad_Medida();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Unidad_Medida";
                CatalogoPropiedadCampoDescripcion = "D_Unidad_Medida";
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
