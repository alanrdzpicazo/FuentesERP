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
    public partial class Geo_Estado : UserControl
    {
        public Int32 K_Pais = 1, K_Estado = 0;
        public TextBox txt_G_Estado
        {
            get { return this.txt_Estado; }
        }

        public Geo_Estado()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Estado frm = new Busquedas.Frm_Busca_Estado(K_Pais);
            frm.ShowDialog();

            if (K_Estado != frm.LLave_Seleccionado)
            {
                K_Estado = frm.LLave_Seleccionado;
                txt_Estado.Text = frm.Descripcion_Seleccionado;

                
            }
        }
    }
    }

