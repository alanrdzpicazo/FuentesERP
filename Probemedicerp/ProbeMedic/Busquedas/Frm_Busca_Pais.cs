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
    public partial class Frm_Busca_Pais : Frm_Buscar
    {

            SQLCatalogos sql = new SQLCatalogos();
            public Frm_Busca_Pais()
            {
                InitializeComponent();
            }

        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Pais();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Pais";
                CatalogoPropiedadCampoDescripcion = "D_Pais";
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
    
