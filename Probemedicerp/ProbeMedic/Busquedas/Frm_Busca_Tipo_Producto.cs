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
    public partial class Frm_Busca_Tipo_Producto : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Tipo_Producto = 0;
        public Frm_Busca_Tipo_Producto()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Tipos_Productos();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_Producto";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_Producto";
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
