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
    public partial class Frm_Busca_Cliente :Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        Int32 PropiedadK_Empresa { get; set; }
        int K_Cliente = 0;

        public Frm_Busca_Cliente(Int32 k_empresa)
        {
            InitializeComponent();
            PropiedadK_Empresa = k_empresa;
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Clientes(PropiedadK_Empresa);

            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Cliente";
                CatalogoPropiedadCampoDescripcion = "D_Cliente";
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
