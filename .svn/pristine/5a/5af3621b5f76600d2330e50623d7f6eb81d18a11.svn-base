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
    public partial class ucTipoProducto : UserControl
    {
        public Int32 K_Tipo_Producto = 0;
        public TextBox txt_TP_D_Tipo_Producto
        {
            get { return this.txt_TP_Tipo_Producto; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucTipoProducto()
        {
            InitializeComponent();
        }

        private void btn_TipoProducto_Click(object sender, EventArgs e)
        {

            Busquedas.Frm_Busca_Tipo_Producto frm = new Busquedas.Frm_Busca_Tipo_Producto();
            frm.ShowDialog();

            if (K_Tipo_Producto != frm.LLave_Seleccionado)
            {
                K_Tipo_Producto = frm.LLave_Seleccionado;
               txt_TP_D_Tipo_Producto.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
