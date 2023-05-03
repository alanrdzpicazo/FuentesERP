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
    public partial class Frm_Busca_Tipo_Contacto : Frm_Buscar
    {
        //Para saber si es proveedor o paciente
        Boolean _Tipo;
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_Tipo_Contacto(Boolean Tipo)
        {
            InitializeComponent();
            _Tipo = Tipo;
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Tipos_Contacto(_Tipo);


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Tipo_Contacto";
                CatalogoPropiedadCampoDescripcion = "D_Tipo_Contacto";
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
