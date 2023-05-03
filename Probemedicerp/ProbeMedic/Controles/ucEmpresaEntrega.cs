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
    public partial class ucEmpresaEntrega : UserControl
    {
        public Int32 K_Empresa_Entrega = 0;
        public TextBox txtEmpresaEntrega
        {
            get { return this.txt_Empresa_Entrega; }
        }
        public ucEmpresaEntrega()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Empresa_Entrega frm = new Busquedas.Frm_Busca_Empresa_Entrega();
            frm.ShowDialog();

            if (K_Empresa_Entrega!= frm.LLave_Seleccionado)
            {
                K_Empresa_Entrega = frm.LLave_Seleccionado;
                txtEmpresaEntrega.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
