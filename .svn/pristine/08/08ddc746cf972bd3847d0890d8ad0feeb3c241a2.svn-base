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
    public partial class Frm_Buscar_Tipo_Moneda : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Tipo_Moneda = 0;
        public Frm_Buscar_Tipo_Moneda()
        {
            InitializeComponent();
        }
         public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Tipo_Moneda();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_Moneda";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_Moneda";
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
