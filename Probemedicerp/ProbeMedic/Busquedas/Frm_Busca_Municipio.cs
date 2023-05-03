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
    public partial class Frm_Busca_Municipio : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Pais = 0, K_Estado = 0;

        public Frm_Busca_Municipio(int pais, int estado)
        {
            K_Pais = pais;
            K_Estado = estado;

            InitializeComponent();
        }

        public int K_Municipio { get; private set; }

        public override void BaseMetodoInicio()
        {
            if (K_Estado == 0)
            {
                MessageBox.Show("PRIMERO DEBE SELECCIONAR EL ESTADO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            else
            {
                BaseDtDatos = sql.Sk_Municipio_Delegacion(K_Pais,K_Estado);
            }

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Municipio";
                CatalogoPropiedadCampoDescripcion = "D_Municipio";
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
