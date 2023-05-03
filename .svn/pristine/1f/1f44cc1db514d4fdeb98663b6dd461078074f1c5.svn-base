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
    public partial class ucCategoriaArticulo : UserControl
    {
        public Int32 K_Categoria_Articulo = 0;
        public TextBox txt_CA_D_Categoria_Articulo
        {
            get { return this.txtCatArt; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucCategoriaArticulo()
        {
            InitializeComponent();
        }

        private void btn_BuscaCatArt_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Categoria_Articulo frm = new Busquedas.Frm_Busca_Categoria_Articulo();
            frm.ShowDialog();

            if (K_Categoria_Articulo != frm.LLave_Seleccionado)
            {
                K_Categoria_Articulo= frm.LLave_Seleccionado;
                txt_CA_D_Categoria_Articulo.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
