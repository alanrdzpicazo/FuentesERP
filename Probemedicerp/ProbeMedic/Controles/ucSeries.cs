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
    public partial class ucSeries : UserControl
    {
        public TextBox txt_D_Serie
        {
            get { return this.txtSerie; }
        }
        public ucSeries()
        {
            InitializeComponent();
        }

        private void btn_BuscaSeries_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Serie frm = new Busquedas.Frm_Busca_Serie();
            frm.ShowDialog();

            if (txtSerie.Text != frm.Descripcion_Seleccionado)
            {
                txtSerie.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
