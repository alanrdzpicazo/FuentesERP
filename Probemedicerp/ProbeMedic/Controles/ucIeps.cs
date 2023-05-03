using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    public partial class ucIeps : UserControl
    {
        public Int32 K_Ieps = 0;
        public TextBox txt_E_Ieps
        {
            get { return this.txtIeps; }
        }

        public ucIeps()
        {
            InitializeComponent();
        }

        private void btn_BuscaIeps_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Ieps frm = new Busquedas.Frm_Busca_Ieps();
            frm.ShowDialog();

            if (K_Ieps != frm.LLave_Seleccionado)
            {
                K_Ieps = frm.LLave_Seleccionado;
                txtIeps.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
