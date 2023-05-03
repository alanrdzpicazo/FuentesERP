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
    public partial class Frm_Buscar_Dias_Servicio_Enfermeria :Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Buscar_Dias_Servicio_Enfermeria()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Dias_Servicio();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Dias_Servicio";
                CatalogoPropiedadCampoDescripcion = "Dias";
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
