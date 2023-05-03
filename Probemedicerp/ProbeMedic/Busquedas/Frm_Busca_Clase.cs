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
    public partial class Frm_Busca_Clase : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Clase = 0;
        public Frm_Busca_Clase()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Clase();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Clase";
                CatalogoPropiedadCampoDescripcion = "D_Clase";
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
