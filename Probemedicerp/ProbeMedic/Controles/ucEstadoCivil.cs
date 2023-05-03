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
    public partial class ucEstadoCivil : UserControl
    {
        public Int32 K_Estado_Civil = 0;
        public TextBox txt_D_EstadoCivil
        {
            get { return this.txtEstadoCivil; }
        }
        public ucEstadoCivil()
        {
            InitializeComponent();
        }

        private void btn_BuscaEstadoCivil_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_EstadoCivil frm = new Busquedas.Frm_Busca_EstadoCivil();
            frm.ShowDialog();

            if (K_Estado_Civil != frm.LLave_Seleccionado)
            {
                K_Estado_Civil = frm.LLave_Seleccionado;
                txt_D_EstadoCivil.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
