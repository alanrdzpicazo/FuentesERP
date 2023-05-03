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
    public partial class ucProveedor : UserControl
    {
        public Int32 K_Proveedor = 0;
        public TextBox txt_D_Proveedor
        {
            get { return this.txtProveedor; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public ucProveedor()
        {
            InitializeComponent();
        }

        private void btn_BuscaProveedor_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Proveedor frm = new Busquedas.Frm_Busca_Proveedor();
            frm.ShowDialog();

            if (K_Proveedor != frm.LLave_Seleccionado)
            {
                K_Proveedor = frm.LLave_Seleccionado;
                txt_D_Proveedor.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
