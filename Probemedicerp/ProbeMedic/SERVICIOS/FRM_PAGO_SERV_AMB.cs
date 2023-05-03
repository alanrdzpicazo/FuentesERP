using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.SERVICIOS
{
    public partial class FRM_PAGO_SERV_AMB : FormaBase
    {
        public Int32 NumServicio { get; set; }
        public String D_Cliente { get; set; }
        public Decimal Monto { get; set; }

        public Int32 K_Banco = 0;
        public bool B_TarjetaCredito;
        public bool B_Tarjeta;

        SQLPrecios sql_precios = new SQLPrecios();
        Funciones fn = new Funciones();

        DataTable dt = new DataTable();

        public FRM_PAGO_SERV_AMB()
        {
            InitializeComponent();
        }

        private void FRM_PAGO_SERV_AMB_Load(object sender, EventArgs e)
        {
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBuscar.Visible = false;

            txtNumServicio.Text = NumServicio.ToString();
            txtCliente.Text = D_Cliente;
            txtMontoServicio.Text = Monto.ToString();

         
        }

        private void cbxForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SI ES EFECTIVO
            if (cbxForma.SelectedIndex == 0 || cbxForma.SelectedIndex == 1)
            {
                pnlTarjeta.Enabled = false;
                B_Tarjeta = false;
            }
            //SI ES TARJETA
            if (cbxForma.SelectedIndex == 2 || cbxForma.SelectedIndex == 3)
            {
                pnlTarjeta.Enabled = true;
                B_Tarjeta = true;
            }


        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco = frm.LLave_Seleccionado;
            txtBanco.Text = frm.Descripcion_Seleccionado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cbxForma.SelectedIndex== 0)
            {
                MessageBox.Show("FALTA SELECCIONAR FORMA DE PAGO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxForma.Focus();
                return;
            }

            if (B_Tarjeta == true)
            {
                if (txtNumTarjeta.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR EL NUMERO DE TARJETA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumTarjeta.Focus();
                    return;
                }
                if (txtAprobacion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR EL NUMERO DE APROBACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAprobacion.Focus();
                    return;
                }
                if (K_Banco == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR EL BANCO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBuscarBanco.Focus();
                    return;
                }
                if (txtNumOperacion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR EL NUMERO DE OPERACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumOperacion.Focus();
                    return;
                }
            }

            if (Convert.ToDecimal(txtTotal.Text) < Monto)
            {
                MessageBox.Show("EL TOTAL PAGADO DEBE SER MAYOR AL MONTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Int32 res = 0;
            string msg = string.Empty;
            res = sql_precios.In_Pagos_Ambulancias(
                NumServicio,
                K_Banco,
                txtNumTarjeta.Text,
                //LA TARJETA DE CREDITO ES EL INDICE 2 DEL COMBO
                cbxForma.SelectedIndex == 2 ? true : false,
                Monto,
                txtAprobacion.Text,
                txtNumOperacion.Text,
                B_Tarjeta,
                GlobalVar.K_Usuario,
                ref msg
                );

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE REGISTRO EL PAGO SATISFACTORIAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("DEBE INDICAR EL TOTAL DE PAGO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(txtTotal.Text) < Monto)
            {
                MessageBox.Show("EL TOTAL PAGADO DEBE SER MAYOR AL MONTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCambio.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) -Monto);
            btnGuardar.Enabled = true;
            btnAceptar.Enabled = false;
        }

        public override void BaseMetodoInicio()
        {     
            dt = sql_precios.Sk_Pagos_Ambulancias(NumServicio);

            if (dt != null)
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(dt.Rows[0].ItemArray[6].ToString()));
                if (Convert.ToBoolean(dt.Rows[0].ItemArray[10].ToString()) == false)
                {
                    cbxForma.SelectedIndex = 1; /*Es Efectivo*/

                }
                else if (Convert.ToBoolean(dt.Rows[0].ItemArray[5].ToString()) == false)
                {
                    cbxForma.SelectedIndex = 3; /*Es Débito*/
                    txtNumTarjeta.Text = dt.Rows[0].ItemArray[4].ToString();
                    txtAprobacion.Text = dt.Rows[0].ItemArray[7].ToString();
                    txtNumOperacion.Text = dt.Rows[0].ItemArray[8].ToString();
                    K_Banco = int.Parse(dt.Rows[0].ItemArray[2].ToString());
                    txtBanco.Text = dt.Rows[0].ItemArray[3].ToString();

                    pnlTarjeta.Enabled = true;
                    txtNumTarjeta.Enabled = false;
                    txtNumOperacion.Enabled = false;
                    txtAprobacion.Enabled = false;
                    txtBanco.Enabled = false;
                    btnBuscarBanco.Enabled = false;
                }
                else
                {
                    cbxForma.SelectedIndex = 2; /*Es Crédito*/
                    cbxForma.SelectedIndex = 2; /*Es Crédito*/
                    txtNumTarjeta.Text = dt.Rows[0].ItemArray[4].ToString();
                    txtAprobacion.Text = dt.Rows[0].ItemArray[7].ToString();
                    txtNumOperacion.Text = dt.Rows[0].ItemArray[8].ToString();
                    K_Banco = int.Parse(dt.Rows[0].ItemArray[2].ToString());
                    txtBanco.Text = dt.Rows[0].ItemArray[3].ToString();

                    pnlTarjeta.Enabled = true;
                    txtNumTarjeta.Enabled = false;
                    txtNumOperacion.Enabled = false;
                    txtAprobacion.Enabled = false;
                    txtBanco.Enabled = false;
                    btnBuscarBanco.Enabled = false;
                }
                txtCambio.Enabled = false;
                txtTotal.Enabled = false;

                txtTotal.Focus();
                cbxForma.Enabled = false;
                btnAceptar.Enabled = false;
                pnlCambio.Visible = false;
                pnlTotal.Location = new Point(350, 270);
            }
            else
            {
                cbxForma.SelectedIndex = 0;
                cbxForma.Focus();
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            fn.ValidaSeaNumeroDecimal(ref e);
                
        }

        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            fn.ValidaSeaNumero(ref e);
        }


        private void txtNumOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            fn.ValidaSeaNumero(ref e);
        }
    }
}
