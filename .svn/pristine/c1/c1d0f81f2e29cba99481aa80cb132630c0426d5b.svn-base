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
    public partial class ucTipoContacto : UserControl
    {
        public Int32 K_Tipo_Contacto = 0;
        public TextBox txt_E_Tipo_Contacto
        {
            get { return this.txt_Tipo_Contacto; }
        }
        public ucTipoContacto()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Contacto frm = new Busquedas.Frm_Busca_Tipo_Contacto(true);
            frm.ShowDialog();

            K_Tipo_Contacto = frm.LLave_Seleccionado;
            txt_Tipo_Contacto.Text = frm.Descripcion_Seleccionado;
        }
    }
}
