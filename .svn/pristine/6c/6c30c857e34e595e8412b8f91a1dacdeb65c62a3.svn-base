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
    public partial class Frm_Busca_Motivo_Anticipo : Frm_Buscar
    {
        SQLCuentasxPagar sql = new SQLCuentasxPagar();

        public Frm_Busca_Motivo_Anticipo()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Motivo_Anticipo_Pago();

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Motivo_Anticipo_Pago";
                CatalogoPropiedadCampoDescripcion = "D_Motivo_Anticipo_Pago";
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
