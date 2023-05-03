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
    public partial class Frm_Busca_Cuenta_Mayor : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_Cuenta_Mayor()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Cuentas_Mayor();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Cuenta_Mayor";
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
