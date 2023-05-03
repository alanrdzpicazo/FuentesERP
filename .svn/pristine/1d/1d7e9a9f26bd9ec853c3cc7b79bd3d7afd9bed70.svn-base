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
    public partial class Frm_Busca_Motivos_Devolucion : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Motivo_Devolucion = 0;
        public Frm_Busca_Motivos_Devolucion()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Motivos_Devolucion();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Motivo_Devolucion";
                CatalogoPropiedadCampoDescripcion = "D_Motivo_Devolucion";
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
