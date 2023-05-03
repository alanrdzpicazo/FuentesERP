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
    public partial class usEspecialidad : UserControl
    {
        public Int32 K_Especialidad = 0;
        public TextBox txt_D_Especialidad
        {
            get { return this.txt_Especialidad; }
        }

        public usEspecialidad()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Especialidad frm = new Busquedas.Frm_Busca_Especialidad();
            frm.ShowDialog();

            if (K_Especialidad != frm.LLave_Seleccionado)
            {
                K_Especialidad = frm.LLave_Seleccionado;
                txt_D_Especialidad.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
