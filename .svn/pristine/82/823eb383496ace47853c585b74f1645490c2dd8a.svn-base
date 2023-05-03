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
    public partial class ucPacientes : UserControl
    {
        public Int32 K_Paciente = 0;
        public TextBox txt_Paciente
        {
            get { return this.txtPaciente; }
        }
        public ucPacientes()
        {
            InitializeComponent();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Paciente frm = new Busquedas.Frm_Busca_Paciente();
            frm.ShowDialog();

            if (K_Paciente != frm.LLave_Seleccionado)
            {
                K_Paciente= frm.LLave_Seleccionado;
                txt_Paciente.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
