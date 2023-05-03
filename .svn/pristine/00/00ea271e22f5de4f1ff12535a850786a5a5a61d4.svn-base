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
    public partial class ucPuestos : UserControl
    {
        public Int32 K_Puesto = 0;
        public TextBox txt_E_Puesto
        {
            get { return this.txt_Puesto; }

        }
        public ucPuestos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Puesto frm = new Busquedas.Frm_Busca_Puesto();
            frm.ShowDialog();

            K_Puesto = frm.LLave_Seleccionado;
            txt_Puesto.Text = frm.Descripcion_Seleccionado;
        }

       
    }
}
