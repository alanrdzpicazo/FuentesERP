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
    public partial class FRM_MODIFICAR_PAQUETERIA : FormaBase
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_catalogos = new SQLCatalogos();
        SQLVentas sql_ventas = new SQLVentas();

        DataTable dtPaqueterias = new DataTable();
        public Int32 K_PedidoInt { get; set; }
        private Int32 K_Empresa_EntregaInt { get; set; }
        public FRM_MODIFICAR_PAQUETERIA()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            this.lblPedido.Text = K_PedidoInt.ToString();
            if(lblPedido.Text.Trim().Length > 0)
            {
                MtdCargaPaqueterias();
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
            Int32 K_Empresa_EntregaIntNueva = Convert.ToInt32(cbxPaqueteria.SelectedValue.ToString());
            if(K_Empresa_EntregaIntNueva == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA PAQUETERIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxPaqueteria.Focus();
                return;
            }
            if (txtNoGuia.Text.Trim().Length ==0)
            {
                MessageBox.Show("DEBE CAPTURAR UN NUMERO DE GUIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoGuia.Focus();
                return;
            }
            if (K_Empresa_EntregaIntNueva!=0)
            {
                res = sql_ventas.Up_Paqueteria_Pedido(K_PedidoInt, K_Empresa_EntregaIntNueva, this.txtNoGuia.Text.Trim(),ref msg);


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
        private void MtdCargaPaqueterias()
        {
            if (K_PedidoInt == 0)
            {
                dtPaqueterias.Rows.Clear();
            }
            else
            {
                dtPaqueterias = sqlCatalogos.Sk_Empresa_Entrega();
            }

            if (dtPaqueterias!= null)
            {
                DataRow dr = dtPaqueterias.NewRow();

                dr["K_Empresa_Entrega"] = 0;
                dr["D_Empresa_Entrega"] = "[SELECCIONAR]";

                dtPaqueterias.Rows.InsertAt(dr, 0);
                dtPaqueterias.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtPaqueterias, ref cbxPaqueteria, "K_Empresa_Entrega", "D_Empresa_Entrega", indice);

                cbxPaqueteria.SelectedIndex = 1;

                if (K_Empresa_EntregaInt != 0)
                {
                    cbxPaqueteria.SelectedValue = K_Empresa_EntregaInt;
                }
                else
                {
                    cbxPaqueteria.SelectedIndex = 1;
                }
            }
        }
    }
}
