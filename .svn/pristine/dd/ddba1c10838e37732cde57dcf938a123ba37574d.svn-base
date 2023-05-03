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
    public partial class Frm_Busca_Enfermera : Frm_Buscar
    {
        SQLPrecios sql = new SQLPrecios();
        public Frm_Busca_Enfermera()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.SK_Empleado_Enfermeria();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Empleado";
                CatalogoPropiedadCampoDescripcion = "D_Empleado";
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
