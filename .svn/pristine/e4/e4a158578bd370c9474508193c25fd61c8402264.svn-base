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
    public partial class ucTipoSangre : UserControl
    {
        public Int32 K_TipoSangre = 0;
        public TextBox txt_D_TipoSangre
        {
            get { return this.txtTipoSangre; }
        }
        public ucTipoSangre()
        {
            InitializeComponent();
        }

        private void btn_BuscaTipoSangre_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_TipoSangre frm = new Busquedas.Frm_Busca_TipoSangre();
            frm.ShowDialog();

            if (K_TipoSangre != frm.LLave_Seleccionado)
            {
                K_TipoSangre = frm.LLave_Seleccionado;
                txt_D_TipoSangre.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
