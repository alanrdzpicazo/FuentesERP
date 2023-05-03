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
    public partial class ucMotivoTransferencia : UserControl
    {
        public Int32 K_Motivo_Transferencia = 0;
        public TextBox txt_Motivo_Transferencia
        {
            get { return this.txtMotivoTransferencia; }
        }
        public ucMotivoTransferencia()
        {
            InitializeComponent();
        }

        private void btnBuscarMotivoTransferencia_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Motivos_Transferencia frm = new Busquedas.Frm_Busca_Motivos_Transferencia();
            frm.ShowDialog();

            if (K_Motivo_Transferencia != frm.LLave_Seleccionado)
            {
                K_Motivo_Transferencia = frm.LLave_Seleccionado;
                txtMotivoTransferencia.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
