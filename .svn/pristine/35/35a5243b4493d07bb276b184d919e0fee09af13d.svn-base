using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbeMedic.AppCode.BLL;
using System.Windows.Forms;

namespace ProbeMedic.Busquedas
{
    public partial class Frm_Busca_Laboratorio : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Laboratorio = 0;
        public Frm_Busca_Laboratorio()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Laboratorio();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Laboratorio";
                CatalogoPropiedadCampoDescripcion = "D_Laboratorio";
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
