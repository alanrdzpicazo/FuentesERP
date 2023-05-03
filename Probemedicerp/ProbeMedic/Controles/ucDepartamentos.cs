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
    public partial class ucDepartamentos : UserControl
    {
        public Int32 K_Departamento = 0;
        public TextBox txt_E_Departamento
        {
            get { return this.txt_Departamento; }
        }
        public ucDepartamentos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Departamento frm = new Busquedas.Frm_Busca_Departamento();
            frm.ShowDialog();

            K_Departamento= frm.LLave_Seleccionado;
            txt_Departamento.Text = frm.Descripcion_Seleccionado;
        }
    }
}
