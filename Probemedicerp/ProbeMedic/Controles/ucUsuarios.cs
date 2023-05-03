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
    public partial class ucUsuarios : UserControl
    {
        public Int32 K_Usuario = 0;

        public TextBox txt_E_Usuario
        {
            get { return this.txt_Usuario; }
        }

       // public TextBox txt_E_Usuario;
        public ucUsuarios()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Usuario frm = new Busquedas.Frm_Busca_Usuario();
            frm.ShowDialog();

            K_Usuario = frm.LLave_Seleccionado;
            txt_Usuario.Text = frm.Descripcion_Seleccionado;
        }
    }
}
