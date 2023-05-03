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
    public partial class Frm_Busca_Cuenta_Nivel2 : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();

        Int32 K_Cuenta_Mayor = 0;
        public Frm_Busca_Cuenta_Nivel2(Int32 k_cuenta_mayor)
        {
            K_Cuenta_Mayor = k_cuenta_mayor;
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Cuenta_Nivel2(K_Cuenta_Mayor);
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Cuenta";
                CatalogoPropiedadCampoDescripcion = "D_Cuenta";
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
