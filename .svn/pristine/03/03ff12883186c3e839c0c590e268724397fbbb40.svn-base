using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_AplicaSeguimientoCheque : Forma
    {
        int res = 0;
        string msg = string.Empty;

        SQLAdministracion sql_cxc = new SQLAdministracion();
        public Int32 K_ChequeInt { get; set; }
        public Frm_AplicaSeguimientoCheque()
        {
            InitializeComponent();
        }
        private void Frm_AplicaSeguimientoCheque_Load(object sender, EventArgs e)
        {
            txt_K_Cheque.Text = K_ChequeInt.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CampoIdentity = 0;
            res = 0;
            msg = string.Empty;

            res = sql_cxc.In_Seguimiento_Cheque(ref CampoIdentity,K_ChequeInt,ucTipoContacto1.K_Tipo_Contacto,txt_Contacto.Text,txt_Observaciones.Text,txt_Observaciones2.Text,GlobalVar.K_Usuario , ref msg);
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("SE REGISTRÓ EL SEGUIMIENTO CORRECTAMENTE CORRECTAMENTE.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
