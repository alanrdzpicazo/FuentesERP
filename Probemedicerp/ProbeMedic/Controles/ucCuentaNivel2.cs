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
    public partial class ucCuentaNivel2 : UserControl
    {
        public Int32 K_Cuenta_Mayor = 0;
        public Int32 K_Cuenta= 0;

        public TextBox txt_G_Cuenta_Mayor
        {
            get { return this.txt_D_Cuenta_Mayor; }
        }

        public TextBox txt_G_Cuenta
        {
            get { return this.txt_D_Cuenta; }
        }
        public ucCuentaNivel2()
        {
            InitializeComponent();
        }

        private void btn_BuscaCuentaMayor_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Cuenta_Mayor frm = new Busquedas.Frm_Busca_Cuenta_Mayor();
            frm.ShowDialog();

            if (K_Cuenta_Mayor != frm.LLave_Seleccionado)
            {
                K_Cuenta_Mayor = frm.LLave_Seleccionado;
                txt_D_Cuenta_Mayor.Text = frm.Descripcion_Seleccionado;
            }

            K_Cuenta = 0;
            txt_D_Cuenta.Text = string.Empty;
        }

        private void btn_BuscaCuenta_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Cuenta_Nivel2 frm = new Busquedas.Frm_Busca_Cuenta_Nivel2(K_Cuenta_Mayor);
            frm.ShowDialog();

            if (K_Cuenta != frm.LLave_Seleccionado)
            {
                K_Cuenta = frm.LLave_Seleccionado;
                txt_D_Cuenta.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
