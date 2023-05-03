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
    public partial class ucTipoMoneda : UserControl
    {
        public Int32 K_Tipo_Moneda=0;
        public TextBox txt_TP_D_Tipo_Moneda
        {
            get { return this.txtTipoMoneda; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucTipoMoneda()
        {
            InitializeComponent();
        }

        private void btn_BuscaTipoMoneda_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Buscar_Tipo_Moneda frm = new Busquedas.Frm_Buscar_Tipo_Moneda();
            frm.ShowDialog();

            if (K_Tipo_Moneda != frm.LLave_Seleccionado)
            {
                K_Tipo_Moneda = frm.LLave_Seleccionado;
                txt_TP_D_Tipo_Moneda.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
