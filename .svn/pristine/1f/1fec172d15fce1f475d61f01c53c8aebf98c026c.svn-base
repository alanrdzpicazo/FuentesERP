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
    public partial class ucCanalDistribucionCliente : UserControl
    {
        public Int32 K_Canal_Distribucion = 0;
        public TextBox txt_E_Canal_Distribucion
        {
            get { return this.txt_Canal_Distribucion; }
        }
        public ucCanalDistribucionCliente()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Canal_Distribucion frm = new Busquedas.Frm_Busca_Canal_Distribucion();
            frm.ShowDialog();

            K_Canal_Distribucion = frm.LLave_Seleccionado;
            txt_Canal_Distribucion.Text = frm.Descripcion_Seleccionado;
        }
    }
}
