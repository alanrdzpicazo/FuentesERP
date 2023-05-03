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
    public partial class Frm_Busca_Canal_Distribucion : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_Canal_Distribucion()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Canal_Distribucion_Cliente();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Canal_Distribucion_Cliente";
                CatalogoPropiedadCampoDescripcion = "D_Canal_Distribucion_Cliente";
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
