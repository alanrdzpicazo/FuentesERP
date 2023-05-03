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
    public partial class ucIVA : UserControl
    {
        public Int32 K_Tipo_Iva = 0;
        public TextBox txt_IVA_D_TipoIVA
        {
            get { return this.txtIVA; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucIVA()
        {
            InitializeComponent();
        }

        private void btn_BuscaIVA_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_IVA frm = new Busquedas.Frm_Busca_IVA();
            frm.ShowDialog();

            if (K_Tipo_Iva != frm.LLave_Seleccionado)
            {
                K_Tipo_Iva = frm.LLave_Seleccionado;
               txt_IVA_D_TipoIVA.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
