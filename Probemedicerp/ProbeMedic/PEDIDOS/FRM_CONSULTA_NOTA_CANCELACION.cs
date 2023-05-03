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
    public partial class FRM_CONSULTA_NOTA_CANCELACION : FormaBase
    {
        SQLVentas sql_ventas = new SQLVentas();
        DataTable dtDatos = new DataTable();
        public Int32 K_PedidoInt { get; set; }
        public FRM_CONSULTA_NOTA_CANCELACION()
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
                BaseBotonAfectar.Visible = false;
                BaseBotonAfectar.Enabled = false;
            }
            dtDatos = sql_ventas.Sk_Pedidos_Consulta(K_PedidoInt);

            if ((dtDatos != null) && (dtDatos.Rows.Count != 0))
            {
                DataRow row = dtDatos.Rows[0];
                this.txtNotaCancelacion.Text = row["CanceladoNota"].ToString();
            }

        }

    }
}
