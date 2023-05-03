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
    public partial class Frm_Busca_Documentos_Requeridos_Proveedor : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_Documentos_Requeridos_Proveedor()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.sk_Documentos_Proveedor();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Documentos_Requeridos";
                CatalogoPropiedadCampoDescripcion = "D_Documento";
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
