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
    public partial class ucMotivosAnticipoCliente : UserControl
    {
        public Int32 K_Motivo = 0;
        public TextBox txt_Motivo
        {
            get { return this.txtMotivo; }
        }
        public ucMotivosAnticipoCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarMotivo_Click(object sender, EventArgs e)
        {
            Busquedas.Busca_Motivo_AnticipoCliente frm = new Busquedas.Busca_Motivo_AnticipoCliente();
            frm.ShowDialog();

            if (K_Motivo != frm.LLave_Seleccionado)
            {
                K_Motivo = frm.LLave_Seleccionado;
                txtMotivo.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
