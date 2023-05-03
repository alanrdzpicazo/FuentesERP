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
    public partial class Geo_Pais : UserControl
    {
        public Int32 K_Pais = 0, K_Estado = 0;
        public TextBox txt_G_Pais
        {
            get { return this.txt_D_Pais; }
        }
        public TextBox txt_G_Estado
        {
            get { return this.txt_D_Estado; }
        }


        public Geo_Pais()
        {
            InitializeComponent();
        }

        private void btn_Estado_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Estado frm = new Busquedas.Frm_Busca_Estado(K_Pais);
            frm.ShowDialog();

            if (K_Estado != frm.LLave_Seleccionado)
            {
                K_Estado = frm.LLave_Seleccionado;
                txt_D_Estado.Text = frm.Descripcion_Seleccionado;

            }
        }


    private void btn_Pais_Click_1(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Pais frm = new Busquedas.Frm_Busca_Pais();
            frm.ShowDialog();


            K_Pais = frm.LLave_Seleccionado;
            txt_D_Pais.Text = frm.Descripcion_Seleccionado;
            K_Estado = 0;
            txt_D_Estado.Text = string.Empty;
        }



    }
}
