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
    public partial class Frm_Busca_Usuario : Frm_Buscar
    {
        SQLSeguridad sql = new SQLSeguridad();
        public Frm_Busca_Usuario()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Usuario();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Usuario";
                CatalogoPropiedadCampoDescripcion = "D_Usuario";
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
