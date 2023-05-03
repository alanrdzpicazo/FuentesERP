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
    public partial class Frm_Busca_Enfermeria : Frm_Buscar
    {
        public Frm_Busca_Enfermeria()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            SQLCatalogos sql = new SQLCatalogos();

            BaseDtDatos = sql.Sk_Precios_Enfermeria();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Precio_Enfermeria";
                CatalogoPropiedadCampoDescripcion = "D_Enfermeria";
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
