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
    public partial class Frm_Busca_Ciudad : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Pais = 0, K_Estado = 0;
        public Frm_Busca_Ciudad(int pais, int estado)
        {
            K_Pais = pais;
            K_Estado = estado;
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            if (K_Estado == 0)
            {
                MessageBox.Show("PRIMERO DEBE SELECCIONAR EL ESTADO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            else
            {
                BaseDtDatos = sql.Sk_Ciudad(K_Pais, K_Estado);
            }

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Ciudad";
                CatalogoPropiedadCampoDescripcion = "D_Ciudad";
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
