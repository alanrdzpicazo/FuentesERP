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
    public partial class ucTipoFiscal : UserControl
    {
        public Int32 K_Tipo_Fiscal = 0;
        public TextBox txt_TF_D_Tipo_Fiscal
        {
            get { return this.txt_D_Tipo_Fiscal; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucTipoFiscal()
        {
            InitializeComponent();
        }

        private void btn_TipoFiscal_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Fiscal frm = new Busquedas.Frm_Busca_Tipo_Fiscal();
            frm.ShowDialog();

            if (K_Tipo_Fiscal != frm.LLave_Seleccionado)
            {
                K_Tipo_Fiscal= frm.LLave_Seleccionado;
                txt_D_Tipo_Fiscal.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
