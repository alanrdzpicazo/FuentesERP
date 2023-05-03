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
    public partial class ucPrograma : UserControl
    {
        public Int32 K_Programa = 0;
        public TextBox txt_D_Programa
        {
            get { return this.txtPrograma; }
        }

        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        public ucPrograma()
        {
            InitializeComponent();
        }

        private void txtCelula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_BuscaPrograma_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Programa frm = new Busquedas.Frm_Busca_Programa();
            frm.ShowDialog();

            if (K_Programa != frm.LLave_Seleccionado)
            {
                K_Programa = frm.LLave_Seleccionado;
                txt_D_Programa.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
