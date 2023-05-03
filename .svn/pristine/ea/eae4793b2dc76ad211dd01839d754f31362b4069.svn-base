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
    public partial class ucTipoEntrega : UserControl
    {
        public Int32 K_Tipo_Entrega = 0;
        public TextBox txtTipoEntrega
        {
            get { return this.txt_Tipo_Entrega; }
        }
        public ucTipoEntrega()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Entrega frm = new Busquedas.Frm_Busca_Tipo_Entrega();
            frm.ShowDialog();

            if (K_Tipo_Entrega != frm.LLave_Seleccionado)
            {
                K_Tipo_Entrega = frm.LLave_Seleccionado;
                txtTipoEntrega.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
