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
    public partial class Frm_Busca_Banco : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Proveedor = 0;
        public Frm_Busca_Banco(int k_proveedor)
        {
            InitializeComponent();
            K_Proveedor = k_proveedor;
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Proveedores_Bancos(K_Proveedor);


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Banco";
                CatalogoPropiedadCampoDescripcion = "D_Banco";
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
