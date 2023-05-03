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
    public partial class BuscaAsesores : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public BuscaAsesores()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Asesores();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Asesor";
                CatalogoPropiedadCampoDescripcion = "Nombre";
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
