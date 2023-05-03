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
    public partial class ucTemperatura : UserControl
    {
        public Int32 K_Temperatura = 0;
        public TextBox txt_T_D_Temperatura
        {
            get { return this.txtTemperatura; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucTemperatura()
        {
            InitializeComponent();
        }

        private void btn_BuscaTemperatura_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Temperatura frm = new Busquedas.Frm_Busca_Temperatura();
            frm.ShowDialog();

            if (K_Temperatura != frm.LLave_Seleccionado)
            {
               K_Temperatura = frm.LLave_Seleccionado;
                txt_T_D_Temperatura.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
