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
    public partial class ucPacienteDireccion : UserControl
    {
        private int k_paciente = 0;
        public int K_paciente { get => k_paciente; set => k_paciente = value; }

        public Int32 K_Paciente_Direccion = 0;

        public TextBox txt_Paciente_Direccion
        {
            get { return this.txtPacienteDireccion; }
        }

      
        public ucPacienteDireccion()
        {
            InitializeComponent();
        }

        private void btnBuscarPacienteDireccion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Paciente_Direccion frm = new Busquedas.Frm_Busca_Paciente_Direccion();
            frm.K_Paciente = k_paciente;
            frm.ShowDialog();

            if (K_Paciente_Direccion != frm.LLave_Seleccionado)
            {
                K_Paciente_Direccion = frm.LLave_Seleccionado;
                txt_Paciente_Direccion.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
