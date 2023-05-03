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

    public partial class Frm_Busca_Tipo_Dato : Frm_Buscar
    {
        SQLCatalogos sql_catalogos = new SQLCatalogos();
        public Frm_Busca_Tipo_Dato()
        {
            InitializeComponent();
        }

        private void Frm_Busca_Tipo_Dato_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql_catalogos.Sk_Tipos_Datos_Pacientes();
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_Dato";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_Dato";
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
