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

namespace ProbeMedic.PEDIDOS
{

    public partial class FRM_CANCELACION_PEDIDOS : FormaBase
    {
        int res = 0;
        string msg = string.Empty;

        SQLVentas sql_ventas = new SQLVentas();
        public Int32 K_PedidoInt { get; set; }

        public FRM_CANCELACION_PEDIDOS()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            this.lblPedido.Text = K_PedidoInt.ToString();
            if (lblPedido.Text.Trim().Length > 0)
            {
                BaseBotonBuscar.Visible = false;
                BaseBotonNuevo.Visible = false;
                BaseBotonModificar.Visible = false;
                BaseBotonBorrar.Visible = false;
                BaseBotonExcel.Visible = false;
                BaseBotonReporte.Visible = false;
                BaseBotonCancelar.Visible = false;
                BaseBotonGuardar.Visible = false;
            }

        }
        public override void BaseBotonAfectarClick()
        {
       
            if (K_PedidoInt != 0)
            {
                if(txtNotaCancelacion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE CAPTURAR UNA NOTA DE CANCELACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNotaCancelacion.Focus();
                    return;
                }
                res = sql_ventas.Up_Cancelacion_Pedidos(K_PedidoInt, this.txtNotaCancelacion.Text.Trim(), GlobalVar.K_Usuario, ref msg);


                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    this.Close();

                }
            }

        }


    }
}
