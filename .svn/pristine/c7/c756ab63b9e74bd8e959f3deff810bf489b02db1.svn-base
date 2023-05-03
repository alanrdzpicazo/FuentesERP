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
    public partial class Frm_Busca_Caracteristicas : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();

        public Frm_Busca_Caracteristicas()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Gp_Precios_Ambulancia();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Precio_Ambulancia";
                CatalogoPropiedadCampoDescripcion = "Caracteristicas";
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
