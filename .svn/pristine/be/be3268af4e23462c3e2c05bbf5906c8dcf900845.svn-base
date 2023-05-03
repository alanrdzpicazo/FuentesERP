using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.ENTREGAS
{
    public partial class FRM_POPUP_PAGOS_LIQUIDACION : Forma
    {
        public int K_Banco_Transferencia;
        public string Cuenta_Transferencia;
        public decimal Cantidad_Transferencia;
        public int K_Banco_Tarjeta;
        public string Numero_Tarjeta;
        public string Aprobacion;
        public string No_Operacion;
        public bool B_TajetaCredito;
        public decimal Cantidad_Tarjeta;
        public int K_Banco_Cheque;
        public string Numero_Cheque;
        public decimal Cantidad_Cheque;
        public decimal Efectivo;
        public string Persona_RecibeGuia;
        public string ID_RecibeGuia;
        public int K_Remision;
        public bool B_Validado = false;
        public decimal total_coaseguro;
        Funciones fn = new Funciones();

        public FRM_POPUP_PAGOS_LIQUIDACION()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Tarjeta = frm.LLave_Seleccionado;
            txtBancoTarjeta.Text = frm.Descripcion_Seleccionado;
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //fn.ValidaSeaNumeroDecimal(ref e);
           
            valida_decimal(sender,ref e);
            if (e.Handled == false)
                Suma_Cantidad_Total();




        }

        private void valida_decimal(object sender,ref KeyPressEventArgs e)
        {
            int res;
            if (e.KeyChar == (char)Keys.Back
            || e.KeyChar == (char)Keys.Delete
            || e.KeyChar == (char)Keys.Left
            || e.KeyChar == (char)Keys.Right
            || int.TryParse(e.KeyChar.ToString(), out res))
            {
                TextBox obj = sender as TextBox;

                if (e.KeyChar == '.' && obj.Text.IndexOf('.') > 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;

           
        }



        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            Cuenta_Transferencia = txtCuentaTransferencia.Text ;
            Cantidad_Transferencia = Convert.ToDecimal( txtCantidadTransferencia.Text.Length > 0 ? txtCantidadTransferencia.Text:"0") ;
            
            Numero_Tarjeta = txtNumTarjeta.Text;
            Aprobacion = txtAprobacion.Text;
            No_Operacion = txtNumOperacion.Text;
            B_TajetaCredito = checkbx_tarjeta_credito.Checked;
            Cantidad_Tarjeta = Convert.ToDecimal(txtCantidadTarjeta.Text.Length > 0? txtCantidadTarjeta.Text:"0");
            
            Numero_Cheque = txtNumeroCheque.Text;
            Cantidad_Cheque = Convert.ToDecimal(txtCantidadCheque.Text.Length > 0? txtCantidadCheque.Text:"0");
            Efectivo = Convert.ToDecimal(txtEfectivo.Text.Length > 0? txtEfectivo.Text:"0");
            Persona_RecibeGuia = txtPersonaRecibe.Text;
            ID_RecibeGuia = txtIdentificacion.Text ;

            

            this.B_Validado = ValidaCampos();
            
                
            if (B_Validado )
                this.Close();
        }

        public bool ValidaCampos()
        {
            bool b_validado = false;

            //si es pago efectivo

            if (this.txtEfectivo.Text.Length > 0 )
            {
                b_validado = true;
            }
            if (this.txtCantidadCheque.Text.Length  >0 )
            {
                b_validado = txtBancoCheque.Text.Length > 0 ? true : false && txtNumeroCheque.Text.Length > 0 ? true : false;

                if (!b_validado)
                {
                    MessageBox.Show("Revisar campos no vacíos en pago Cheque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return b_validado;
                }
               
            }
            if (this.txtCantidadTarjeta.Text.Length > 0 )
            {
                b_validado = txtBancoTarjeta.Text.Length > 0 ? true : false && txtNumTarjeta.Text.Length > 0 ? true : false && txtAprobacion.Text.Length > 0 ? true : false && txtNumOperacion.Text.Length > 0 ? true : false;
                if (!b_validado)
                {
                    MessageBox.Show("Revisar campos no vacíos en pago por tarjeta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return b_validado;
                } 
            }
            if (this.txtCantidadTransferencia.Text.Length > 0)
            {
                b_validado = txtCuentaTransferencia.Text.Length > 0 ? true : false && txtBancoTransferencia.Text.Length > 0 ? true : false;

                if (!b_validado)
                {
                    MessageBox.Show("Revisar campos no vacíos en pago por tarjeta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return b_validado;
                }
            }


            if (this.txtPersonaRecibe.Text.Length > 0 && this.txtIdentificacion.Text.Length > 0 && this.txtTotal.Text.Length > 0)
                b_validado = true;
            else
            {

                MessageBox.Show("Los campos no pueden estar vacíos favor de verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                b_validado = false;
            }

            if (Convert.ToDecimal(this.txtTotal.Text) < total_coaseguro)
            {
                MessageBox.Show("La cantidad registrada es menor a la cantidad de Coaseguro a cobrar, favor de registrar el pago completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                b_validado = false;

                return b_validado;
            }
            return b_validado;
        }
        private void btn_busca_banco_transferencia_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Transferencia = frm.LLave_Seleccionado;
            this.txtBancoTransferencia.Text = frm.Descripcion_Seleccionado;
        }

        private void btn_busca_banco_cheque_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Cheque = frm.LLave_Seleccionado;
            this.txtBancoCheque.Text = frm.Descripcion_Seleccionado;
        }

        private void txtCantidadTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
            
        }

        private void Suma_Cantidad_Total()
        {
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtCantidadCheque.Text.Length > 0 ? txtCantidadCheque.Text:"0" ) + Convert.ToDecimal(txtCantidadTarjeta.Text.Length > 0? txtCantidadTarjeta.Text : "0") + Convert.ToDecimal(txtCantidadTransferencia.Text.Length > 0 ? txtCantidadTransferencia.Text : "0") + Convert.ToDecimal(txtEfectivo.Text.Length > 0 ? txtEfectivo.Text : "0"));
        }

        private void txtCantidadTransferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
           
        }

        private void txtCantidadCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida_decimal(sender, ref e);
           
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            Suma_Cantidad_Total();
        }

        private void txtCantidadTarjeta_TextChanged(object sender, EventArgs e)
        {
            Suma_Cantidad_Total();
        }

        private void txtCantidadTransferencia_TextChanged(object sender, EventArgs e)
        {
            Suma_Cantidad_Total();
        }

        private void txtCantidadCheque_TextChanged(object sender, EventArgs e)
        {
            Suma_Cantidad_Total();
        }

        private void FRM_POPUP_PAGOS_LIQUIDACION_Load(object sender, EventArgs e)
        {
            this.txtNoRemision.Text = K_Remision.ToString();
            this.lblCoaseguro.Text = total_coaseguro.ToString("##.00");


        }
    }
}
