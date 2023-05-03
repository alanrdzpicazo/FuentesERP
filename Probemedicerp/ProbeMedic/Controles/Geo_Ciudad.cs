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
    public partial class Geo_Ciudad : UserControl
    {
        public Int32 K_Pais = 0, K_Estado = 0, K_Ciudad = 0, K_Municipio;

        public TextBox txt_G_Pais
        {
            get { return this.txt_D_Pais; }
        }
        public TextBox txt_G_Estado
        {
            get { return this.txt_D_Estado; }
        }
        public TextBox txt_G_Ciudad
        {
            get { return this.txt_D_Ciudad; }
        }
        public TextBox txt_G_Municipio
        {
            get { return this.txt_D_Municipio; }
        }
        private void btn_Estado_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Estado frm = new Busquedas.Frm_Busca_Estado(K_Pais);
            frm.ShowDialog();

            if (K_Estado != frm.LLave_Seleccionado)
            {
                K_Estado = frm.LLave_Seleccionado;
                txt_D_Estado.Text = frm.Descripcion_Seleccionado;

                K_Ciudad = 0;
                txt_D_Ciudad.Text = string.Empty;
            }
        }

        private void btn_Municipio_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Municipio frm = new Busquedas.Frm_Busca_Municipio(K_Pais,K_Estado);
            frm.ShowDialog();

            if (K_Municipio != frm.LLave_Seleccionado)
            {
                K_Municipio = frm.LLave_Seleccionado;
                txt_D_Municipio.Text = frm.Descripcion_Seleccionado;

            }
        }

        private void btn_Ciudad_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Ciudad frm = new Busquedas.Frm_Busca_Ciudad(K_Pais, K_Estado);
            frm.ShowDialog();

            if (K_Ciudad != frm.LLave_Seleccionado)
            {
                K_Ciudad = frm.LLave_Seleccionado;
                txt_D_Ciudad.Text = frm.Descripcion_Seleccionado;

                K_Municipio = 0;
                txt_D_Municipio.Text = string.Empty;
            }
        }

        private void btn_Pais_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Pais frm = new Busquedas.Frm_Busca_Pais();
            frm.ShowDialog();


            K_Pais = frm.LLave_Seleccionado;
            txt_D_Pais.Text = frm.Descripcion_Seleccionado;

            K_Estado = 0;
            txt_D_Estado.Text = string.Empty;

            K_Ciudad = 0;
            txt_D_Ciudad.Text = string.Empty;
        }


        public Geo_Ciudad()
        {
            InitializeComponent();
        }


    }
}
