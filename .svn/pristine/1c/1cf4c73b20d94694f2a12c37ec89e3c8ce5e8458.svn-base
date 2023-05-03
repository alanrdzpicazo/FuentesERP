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
    public partial class Busca_Motivo_AnticipoCliente : Frm_Buscar
    {
        SQLCuentasxCobrar sql = new SQLCuentasxCobrar();

        public Busca_Motivo_AnticipoCliente()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Motivo_Anticipo_Cliente();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Motivo_Anticipo_Cliente";
                CatalogoPropiedadCampoDescripcion = "D_Motivo_Anticipo_Cliente";
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
