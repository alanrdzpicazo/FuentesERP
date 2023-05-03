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
    public partial class ucEstatusPedido : UserControl
    {
        private int k_Estatus_Pedido = 0;
        public int K_Estatus_Pedido { get => k_Estatus_Pedido; set => k_Estatus_Pedido = value; }

        public TextBox txt_Estatus_Pedido
        {
            get { return this.txtEstatusPedido; }
        }
        public ucEstatusPedido()
        {
            InitializeComponent();
        }

        private void btnBuscarEstatusPedido_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Estatus_Pedido frm = new Busquedas.Frm_Busca_Estatus_Pedido();
            frm.ShowDialog();

            if (k_Estatus_Pedido!= frm.LLave_Seleccionado)
            {
                K_Estatus_Pedido = frm.LLave_Seleccionado;
                txt_Estatus_Pedido.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
