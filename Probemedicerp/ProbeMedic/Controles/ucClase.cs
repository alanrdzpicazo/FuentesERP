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
    public partial class ucClase : UserControl
    {
        public Int32 K_Clase = 0;
        public TextBox txt_C_D_Clase
        {
            get { return this.txtClase; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucClase()
        {
            InitializeComponent();
        }

        private void btnBuscarClase_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Clase frm = new Busquedas.Frm_Busca_Clase();
            frm.ShowDialog();

            if (K_Clase != frm.LLave_Seleccionado)
            {
                K_Clase= frm.LLave_Seleccionado;
               txt_C_D_Clase.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
