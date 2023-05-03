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
    public partial class ucMedicos : UserControl
    {
        private int k_medico = 0;
        public int K_medico { get => k_medico; set =>k_medico= value; }

        public Int32 K_Medico = 0;

        public TextBox txt_Medico
        {
            get { return this.txtMedico; }
        }

        public ucMedicos()
        {
            InitializeComponent();
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {

            Busquedas.Frm_Busca_Medico frm = new Busquedas.Frm_Busca_Medico();
            frm.ShowDialog();

            if (K_Medico != frm.LLave_Seleccionado)
            {
                K_Medico = frm.LLave_Seleccionado;
                txt_Medico.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
