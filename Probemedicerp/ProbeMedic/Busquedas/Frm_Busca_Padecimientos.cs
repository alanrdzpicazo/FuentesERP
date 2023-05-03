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
    public partial class Frm_Busca_Padecimientos : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_Padecimientos()
        {
            InitializeComponent();
        }

        private void Frm_Busca_Padecimientos_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Padecimientos();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Padecimiento";
                CatalogoPropiedadCampoDescripcion = "D_Padecimiento";
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
