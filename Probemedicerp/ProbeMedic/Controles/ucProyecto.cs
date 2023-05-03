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
    public partial class ucProyecto : UserControl
    {
        public Int32 K_Proyecto= 0;
        public TextBox txt_E_Proyecto
        {
            get { return this.txt_Proyecto; }
        }
        public ucProyecto()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Proyecto frm = new Busquedas.Frm_Busca_Proyecto();
            frm.ShowDialog();

            K_Proyecto = frm.LLave_Seleccionado;
            txt_Proyecto.Text = frm.Descripcion_Seleccionado;
        }
    }
}
