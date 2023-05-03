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
    public partial class ucPresentacion : UserControl
    {
        public Int32 K_Presentacion = 0;
        public TextBox txt_P_D_Presentacion
        {
            get { return this.txtPresentacion; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucPresentacion()
        {
            InitializeComponent();
        }

        private void btn_BuscaPresentacion_Click(object sender, EventArgs e)
        {

            Busquedas.Frm_Busca_Presentacion frm = new Busquedas.Frm_Busca_Presentacion();
            frm.ShowDialog();

            if (K_Presentacion != frm.LLave_Seleccionado)
            {
                K_Presentacion = frm.LLave_Seleccionado;
                txt_P_D_Presentacion.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
