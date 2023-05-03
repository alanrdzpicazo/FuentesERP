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
    public partial class ucGrupoArticulo : UserControl
    {
        public Int32 K_Grupo_Articulo = 0;
        public TextBox txt_GA_D_Grupo_Articulo
        {
            get { return this.txtGrupoArticulo; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucGrupoArticulo()
        {
            InitializeComponent();
        }

        private void btn_BuscaTipoArticulo_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Buscar_Grupo_Articulo frm = new Busquedas.Frm_Buscar_Grupo_Articulo();
            frm.ShowDialog();

            if (K_Grupo_Articulo != frm.LLave_Seleccionado)
            {
                K_Grupo_Articulo = frm.LLave_Seleccionado;
                txt_GA_D_Grupo_Articulo.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void txtGrupoArticulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
