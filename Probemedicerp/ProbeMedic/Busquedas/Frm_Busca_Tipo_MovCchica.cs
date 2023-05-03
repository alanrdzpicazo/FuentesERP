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
    public partial class Frm_Busca_Tipo_MovCchica : Frm_Buscar
    {
        SQLCuentasxPagar sql = new SQLCuentasxPagar();
        public Frm_Busca_Tipo_MovCchica()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.SK_Tipos_MovCchica();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_MovCchica";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_MovCchica";
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
