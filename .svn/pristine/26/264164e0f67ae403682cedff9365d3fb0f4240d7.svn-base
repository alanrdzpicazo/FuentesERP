using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    public partial class ucTipoVenta : UserControl
    {
        public Int32 K_Tipo_Venta = 0;
        public TextBox txt_E_Tipo_Venta
        {
            get { return this.txt_Tipo_Venta; }
        }
        public ucTipoVenta()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Venta frm = new Busquedas.Frm_Busca_Tipo_Venta();
            frm.ShowDialog();

            K_Tipo_Venta = frm.LLave_Seleccionado;
            txt_Tipo_Venta.Text = frm.Descripcion_Seleccionado;
        }
    }
}
