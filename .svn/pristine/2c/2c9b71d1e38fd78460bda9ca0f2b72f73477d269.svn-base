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
    public partial class ucGeneros : UserControl
    {
        public Int32 K_Genero = 0;
        public TextBox txt_D_Genero 
        {
            get { return this.txtGenero; }
        }

        public ucGeneros()
        {
            InitializeComponent();
        }

        private void btn_BuscaGenero_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Generos frm = new Busquedas.Frm_Busca_Generos();
            frm.ShowDialog();

            if (K_Genero != frm.LLave_Seleccionado)
            {
                K_Genero = frm.LLave_Seleccionado;
                txt_D_Genero.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
