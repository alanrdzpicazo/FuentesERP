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
    public partial class Frm_Busca_Oficina : Frm_Buscar
    {
        public Int32 PropiedadK_Empresa { get; set; }
        public Frm_Busca_Oficina(Int32 k_empresa)
        {
            InitializeComponent();
            PropiedadK_Empresa = k_empresa;
        }
        SQLCatalogos sql = new SQLCatalogos();
     
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Oficina(PropiedadK_Empresa);
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Oficina";
                CatalogoPropiedadCampoDescripcion = "D_Oficina";
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
