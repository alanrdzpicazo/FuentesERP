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

    public partial class Frm_Busca_MotivoCancServ : Frm_Buscar
    {
        SQLPrecios sql = new SQLPrecios();

        public Frm_Busca_MotivoCancServ()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Motivo_Cancelacion_ServiciosEnfermeria();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Motivo_Cancelacion_ServiciosEnfermeria";
                CatalogoPropiedadCampoDescripcion = "D_Motivo_Cancelacion_ServiciosEnfermeria";
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
