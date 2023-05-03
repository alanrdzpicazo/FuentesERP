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
    public partial class Frm_Busca_Colonia : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Pais = 0, K_Estado = 0,K_Ciudad=0;
        public Frm_Busca_Colonia(int pais, int estado,int ciudad)
        {
            InitializeComponent();
            K_Pais = pais;
            K_Estado = estado;
            K_Ciudad = ciudad;
        }
        public override void BaseMetodoInicio()
        {
            if (K_Ciudad == 0)
            {
                MessageBox.Show("PRIMERO DEBE SELECCIONAR LA CIUDAD ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            else
            {
                BaseDtDatos = sql.Sk_Colonia_All(K_Pais, K_Estado,K_Ciudad);
            }

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Colonia";
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
