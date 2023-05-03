using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_DatosCancelacionOC : Form
    {
        public string P_MotivoCancelacion { get; set; }
        public bool P_ActivaRequisicion { get; set; }

        public int P_k_motivo_cancelacion { get; set; }

        public Frm_DatosCancelacionOC()
        {
            InitializeComponent();
            this.cbx_motivo_cancelacion_compra1.LlenaDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            P_MotivoCancelacion = "";
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCancelacion.Text.Trim() == "")
            {
                MessageBox.Show("DEBE CAPTURAR UN MOTIVO DE CANCELACIÓN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                P_MotivoCancelacion = txtCancelacion.Text ;
                P_ActivaRequisicion = chkActivar.Checked;
                P_k_motivo_cancelacion = Convert.ToInt32(this.cbx_motivo_cancelacion_compra1.SelectedValue);
                Close();
            }
        }

   
    }
}
