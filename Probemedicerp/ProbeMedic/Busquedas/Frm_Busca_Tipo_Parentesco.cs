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
    public partial class Frm_Busca_Tipo_Parentesco : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Tipo_Parentesco = 0;
        public Frm_Busca_Tipo_Parentesco()
        {
            InitializeComponent();
        }

        private void Frm_Busca_Tipo_Parentesco_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Tipo_Parentesco();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_Parentesco";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_Parentesco";
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
