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
    public partial class ucUnidadMedida : UserControl
    {
        public Int32 K_Unidad_Medida = 0;
        public TextBox txt_UM_D_Unidad_Medida
        {
            get { return this.txtUnidadMedida; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucUnidadMedida()
        {
            InitializeComponent();
        }

        private void btn_BuscaUnidadMed_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Unidad_Medida frm = new Busquedas.Frm_Busca_Unidad_Medida();
            frm.ShowDialog();

            if (K_Unidad_Medida != frm.LLave_Seleccionado)
            {
                K_Unidad_Medida = frm.LLave_Seleccionado;
                txt_UM_D_Unidad_Medida.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
