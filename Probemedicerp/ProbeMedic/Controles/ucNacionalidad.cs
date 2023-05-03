using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.Controles
{
    public partial class ucNacionalidad : UserControl
    {
        public Int32 K_Nacionalidad = 0;
        public TextBox txt_D_Nacionalidad
        {
            get { return this.txtNacionalidad; }
        }
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucNacionalidad()
        {
            InitializeComponent();
        }

        private void btn_BuscaNacionalidad_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Nacionalidad frm = new Busquedas.Frm_Busca_Nacionalidad();
            frm.ShowDialog();

            if (K_Nacionalidad != frm.LLave_Seleccionado)
            {
                K_Nacionalidad = frm.LLave_Seleccionado;
                txt_D_Nacionalidad.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
