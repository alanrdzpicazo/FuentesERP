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
    public partial class ucCuentaNivel4 : UserControl
    {
        public Int32 K_Cuenta_Mayor = 0;
        public Int32 K_Cuenta = 0;
        public Int32 K_SubCuenta = 0;
        public Int32 K_Departamento = 0;

        public TextBox txt_G_Cuenta_Mayor
        {
            get { return this.txt_D_Cuenta_Mayor; }
        }

        public TextBox txt_G_Cuenta
        {
            get { return this.txt_D_Cuenta; }
        }
        public TextBox txt_G_Subcuenta
        {
            get { return this.txt_D_SubCuenta; }
        }
        public TextBox txt_G_Departamento 
        {
            get { return this.txt_D_Departamento; }
        }
        public ucCuentaNivel4()
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
            K_SubCuenta = 0;
            txt_D_SubCuenta.Text = string.Empty;
            K_Departamento = 0;
            txt_D_Departamento.Text = string.Empty;
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

            K_SubCuenta = 0;
            txt_D_SubCuenta.Text = string.Empty;
            K_Departamento = 0;
            txt_D_Departamento.Text = string.Empty;
        }

        private void btn_BuscaSubCuenta_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Cuenta_Nivel3 frm = new Busquedas.Frm_Busca_Cuenta_Nivel3(K_Cuenta_Mayor, K_Cuenta);
            frm.ShowDialog();

            if (K_SubCuenta != frm.LLave_Seleccionado)
            {
                K_SubCuenta = frm.LLave_Seleccionado;
                txt_D_SubCuenta.Text = frm.Descripcion_Seleccionado;
            }
            K_Departamento = 0;
            txt_D_Departamento.Text = string.Empty;
        }

        private void btn_BuscaDepartamento_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Cuenta_Nivel4 frm = new Busquedas.Frm_Busca_Cuenta_Nivel4(K_Cuenta_Mayor, K_Cuenta, K_SubCuenta);
            frm.ShowDialog();

            if (K_Departamento != frm.LLave_Seleccionado)
            {
                K_Departamento = frm.LLave_Seleccionado;
                txt_D_Departamento.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
