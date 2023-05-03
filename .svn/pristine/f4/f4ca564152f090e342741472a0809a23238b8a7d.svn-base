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
    public partial class Frm_Busca_Paciente_Direccion :Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        private int k_Paciente = 0;
        public int K_Paciente { get => k_Paciente; set => k_Paciente = value; }

        private int k_Paciente_Direccion = 0;
        public int K_Paciente_Direccion { get => k_Paciente_Direccion; set => k_Paciente_Direccion = value; }

        public Frm_Busca_Paciente_Direccion()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql.Sk_Pacientes_Direcciones(k_Paciente);

   
            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Paciente_Direccion";
                CatalogoPropiedadCampoDescripcion = "Direccion_Completo";
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
