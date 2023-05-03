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
    public partial class Frm_Busca_Paciente : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        int K_Paciente = 0;
        public Frm_Busca_Paciente()
        {
            InitializeComponent();
        }

        private void Frm_Busca_Paciente_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Pacientes(0,GlobalVar.K_Empresa);
            

            if (BaseDtDatos != null)
            {
     
                CatalogoPropiedadCampoClave = "K_Paciente";
                CatalogoPropiedadCampoDescripcion = "Nombre_Completo";
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
