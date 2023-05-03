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
    public partial class ucTipoMovCajaChica : UserControl
    {
        public Int32 K_Tipo_MovCchica = 0;
        public TextBox txt_E_TipoMovCchica
        {
            get { return this.txt_TipoMovCajaChica; }
        }
        public ucTipoMovCajaChica()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_MovCchica frm = new Busquedas.Frm_Busca_Tipo_MovCchica();
            frm.ShowDialog();

            K_Tipo_MovCchica = frm.LLave_Seleccionado;
            txt_TipoMovCajaChica.Text = frm.Descripcion_Seleccionado;
        }
    }
}
