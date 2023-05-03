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
    public partial class ucMotivo_Autoriza : UserControl
    {
        public Int32 K_Motivo_Autoriza = 0;

        public TextBox txt_Z_Motivo_Autoriza
        {
            get { return this.txt_Motivo_Autoriza; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucMotivo_Autoriza()
        {
            InitializeComponent();
        }
    

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_UsuarioAutoriza frm = new Busquedas.Frm_Busca_UsuarioAutoriza();
            frm.ShowDialog();

            if (K_Motivo_Autoriza != frm.LLave_Seleccionado)
            {
                K_Motivo_Autoriza = frm.LLave_Seleccionado;
                txt_Motivo_Autoriza.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
