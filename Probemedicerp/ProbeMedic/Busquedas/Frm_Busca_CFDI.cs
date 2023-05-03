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
    public partial class Frm_Busca_CFDI : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_ClA = 0;

        public Frm_Busca_CFDI()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Uso_CFDI();

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Uso_CFDI";
                CatalogoPropiedadCampoDescripcion = "D_Uso_CFDI";
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
