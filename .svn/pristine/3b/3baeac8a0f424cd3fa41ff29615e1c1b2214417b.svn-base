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
    public partial class usProfesion : UserControl
    {
        public Int32 K_Profesion = 0;
        public TextBox txt_D_Profesion
          {
            get { return this.txt_Profesion; }
}
public usProfesion()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Profesion frm = new Busquedas.Frm_Busca_Profesion();
            frm.ShowDialog();

            if (K_Profesion != frm.LLave_Seleccionado)
            {
                K_Profesion = frm.LLave_Seleccionado;
                txt_D_Profesion.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void txt_Especialidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
