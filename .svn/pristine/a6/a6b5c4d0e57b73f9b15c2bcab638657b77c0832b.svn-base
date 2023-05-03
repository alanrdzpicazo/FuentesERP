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
    public partial class ucClaveSAT : UserControl
    {
        public Int32 K_Clave_SAT = 0;
        public TextBox txt_D_Clave_SAT
        {
            get { return this.txtClaveSAT; }
        }
        public ucClaveSAT()
        {
            InitializeComponent();
        }

        private void btn_BuscaClaveSAT_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_ClaveSAT frm = new Busquedas.Frm_Busca_ClaveSAT();
            frm.ShowDialog();

            if (K_Clave_SAT != frm.LLave_Seleccionado)
            {
                K_Clave_SAT = frm.LLave_Seleccionado;
                txt_D_Clave_SAT.Text = frm.Descripcion_Seleccionado;
            }
        }

   
    }
}
