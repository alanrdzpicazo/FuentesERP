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
    public partial class ucTPacientes : UserControl
    {
        public Int32 K_TipoPaciente = 0;
        public TextBox txt_D_TipoPaciente
        {
            get { return this.txtTipoPaciente; }
        }

        public ucTPacientes()
        {
            InitializeComponent();
        }

        private void btn_BuscaTipoPaciente_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_TipoPaciente frm = new Busquedas.Frm_Busca_TipoPaciente();
            frm.ShowDialog();

            if (K_TipoPaciente != frm.LLave_Seleccionado)
            {
                K_TipoPaciente = frm.LLave_Seleccionado;
                txt_D_TipoPaciente.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
