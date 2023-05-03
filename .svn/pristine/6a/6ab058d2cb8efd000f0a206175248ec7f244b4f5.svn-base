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
    public partial class ucPuestosContacto : UserControl
    {
        public Int32 K_Puesto_Contacto= 0;
        public TextBox txt_E_Puesto_Contacto
        {
            get { return this.txt_Puesto_Contacto; }
        }
        public ucPuestosContacto()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_PuestosContacto frm = new Busquedas.Frm_Busca_PuestosContacto();
            frm.ShowDialog();

            K_Puesto_Contacto = frm.LLave_Seleccionado;
            txt_Puesto_Contacto.Text = frm.Descripcion_Seleccionado;
        }
    }
}
