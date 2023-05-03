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
    public partial class Frm_Busca_Tipo_Fiscal : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_Tipo_Fiscal()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Tipo_Fiscal();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_Fiscal";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_Fiscal";
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
