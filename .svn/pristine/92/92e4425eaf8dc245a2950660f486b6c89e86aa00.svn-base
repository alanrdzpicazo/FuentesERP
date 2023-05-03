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
    public partial class ucTiposPoliza : UserControl
    {
        public Int32 K_TipoPoliza = 0;
        public TextBox txt_D_TipoPoliza
        {
            get { return this.txtTipoPoliza; }
        }
        public ucTiposPoliza()
        {
            InitializeComponent();
        }

        private void btn_BuscaPoliza_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_TipoPoliza frm = new Busquedas.Frm_Busca_TipoPoliza();
            frm.ShowDialog();

            if (K_TipoPoliza != frm.LLave_Seleccionado)
            {
                K_TipoPoliza = frm.LLave_Seleccionado;
                txt_D_TipoPoliza.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
