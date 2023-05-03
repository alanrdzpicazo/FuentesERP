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
    public partial class ucArticulos : UserControl
    {
        public Int32 K_Articulo= 0;
        public TextBox txt_D_Articulo
        {
            get { return this.txtArticulo; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public ucArticulos()
        {
            InitializeComponent();
        }

        private void btn_BuscaArticulo_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Articulos frm = new Busquedas.Frm_Busca_Articulos();
            frm.ShowDialog();

            if (K_Articulo!= frm.LLave_Seleccionado)
            {
                K_Articulo = frm.LLave_Seleccionado;
                txt_D_Articulo.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
