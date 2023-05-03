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
    public partial class ucAgente : UserControl
    {
        public Int32 K_Asesor = 0;
        public TextBox txt_Nombre
        {
            get { return this.txtNombre; }
        }

        public ucAgente()
        {
            InitializeComponent();
        }

        private void btnBuscaraAsesor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaAsesores frm = new Busquedas.BuscaAsesores();
            frm.ShowDialog();
            if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                K_Asesor = Convert.ToInt32(frm.LLave_Seleccionado.ToString());
                txtNombre.Text = frm.Descripcion_Seleccionado.ToString();
            }
            else
            {
                K_Asesor = 0;
                txtNombre.Text = string.Empty;
            }
        }
    }
}
