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
    public partial class Frm_Busca_Domicilios_Fiscales_Clientecs : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();

        private int K_Cliente = 0;
        public int K_Cliente1 { get => K_Cliente; set => K_Cliente = value; }

        public Frm_Busca_Domicilios_Fiscales_Clientecs()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Cliente_Domicilios_Fiscales(K_Cliente);


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Cliente_Domicilio_Fiscal";
                CatalogoPropiedadCampoDescripcion = "D_Colonia";
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
