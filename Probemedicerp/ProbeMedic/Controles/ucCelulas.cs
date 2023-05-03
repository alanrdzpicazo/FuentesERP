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
    public partial class ucCelulas : UserControl
    {
        public Int32 K_Celula = 0;
        public TextBox txt_D_Celula
        {
            get { return this.txtCelula; }
        }

        public ucCelulas()
        {
            InitializeComponent();
        }

        private void btn_BuscaCelula_Click(object sender, EventArgs e)
        {
                Busquedas.Frm_Busca_Celulas frm = new Busquedas.Frm_Busca_Celulas();
                frm.ShowDialog();

                if (K_Celula != frm.LLave_Seleccionado)
                {
                    K_Celula = frm.LLave_Seleccionado;
                    txt_D_Celula.Text = frm.Descripcion_Seleccionado;
                }
        }
    }
}
