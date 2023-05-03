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
    public partial class Frm_Busca_Estado : Frm_Buscar
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        int K_Pais = 0;
        public Frm_Busca_Estado(int pais)
        {
            K_Pais = pais;
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            if (K_Pais == 0)
            {
                MessageBox.Show("PRIMERO DEBE SELECCIONAR EL PAIS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else if (K_Pais == 210)
            {
                BaseDtDatos = sql_Catalogos.Sk_Estado(1);
            }
            else
            {
                BaseDtDatos = sql_Catalogos.Sk_Estado(K_Pais);
            }

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Estado";
                CatalogoPropiedadCampoDescripcion = "D_Estado";
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
