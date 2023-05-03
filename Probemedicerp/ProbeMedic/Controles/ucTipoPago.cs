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
    public partial class ucTipoPago : UserControl
    {
        public Int32 K_Tipo_Pago = 0;
        public TextBox txt_G_Tipo_Pago
        {
            get { return this.txt_D_Tipo_Pago; }
        }
        public ucTipoPago()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipos_Pago frm = new Busquedas.Frm_Busca_Tipos_Pago();
            frm.ShowDialog();

            if (K_Tipo_Pago != frm.LLave_Seleccionado)
            {
                K_Tipo_Pago = frm.LLave_Seleccionado;
                txt_D_Tipo_Pago.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
