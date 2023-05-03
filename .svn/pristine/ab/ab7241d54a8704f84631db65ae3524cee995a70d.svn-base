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
    public partial class Frm_InformacionPagosCxC : Forma
    {
        public bool B_Efectivo {get; set;}
        public bool B_Cheque { get; set; }
        public bool B_Transferencia{ get; set; }
        public bool B_Tarjeta { get; set; }
        public Frm_InformacionPagosCxC()
        {
            InitializeComponent();
        }

        SQLCatalogos sqlCatalogos = new SQLCatalogos();

        public TextBox txt_G_Efectivo
        {
            get { return this.txtPagoTotalTipoMoneda1.Moneda; }
        }


        public TextBox txt_G_Cheque
        {
            get { return this.txtPagoTotalTipoMoneda3.Moneda; }
        }
        public TextBox txt_G_No_Cheque
        {
            get { return this.txtChequeNoCheque; }
        }
        public Int32 PropiedadK_Banco_Cheque
        {
            get { return Convert.ToInt32(this.cmbChequeBanco.SelectedValue.ToString()); }
        }
        public TextBox txt_G_Cuenta_Cheque
        {
            get { return this.txtChequeCuenta; }
        }

        public bool PropiedadB_Tarjeta_Credito
        {
            get { return Convert.ToBoolean(this.Cbx_Tarjeta_Credito.Checked); }
        }
        public Int32 PropiedadK_Banco_Tarjeta
        {
            get { return Convert.ToInt32(this.cmbTarjetaBanco.SelectedValue.ToString()); }
        }

        public TextBox txt_G_Tarjeta
        {
            get { return this.txtPagoTotalTipoMoneda4.Moneda; }
        }
        public TextBox txt_G_NoTarjeta_Credito
        {
            get { return this.txtNumTarjeta; }
        }
        public TextBox txt_G_NoTarjeta_Debito
        {
            get { return this.txtNumTarjeta; }
        }
        public TextBox txt_G_Aprobacion
        {
            get { return this.txtAprobacion; }
        }
        public TextBox txt_G_NumOperacion
        {
            get { return this.txtNumOperacion; }
        }

        public TextBox txt_G_Transferencia
        {
            get { return this.txtPagoTotalTipoMoneda2.Moneda; }
        }
        public Int32 PropiedadK_Banco_Transferencia
        {
            get { return Convert.ToInt32(this.cmbTransferenciaBanco.SelectedValue.ToString()); }
        }
        public TextBox txt_G_No_Transferencia
        {
            get { return this.txtTransferenciaNoTransferencia; }
        }
        public TextBox txt_G_Cuenta_Transferencia
        {
            get { return this.txtTransferenciaCuenta; }
        }
        public TextBox txt_G_Referencia_Transferencia
        {
            get { return this.txtTransferenciaReferencia; }
        }
      
        private void Frm_InformacionPagosCxC_Load(object sender, EventArgs e)
        {
            DataTable dtBancosCh = sqlCatalogos.Sk_Bancos();
            if (dtBancosCh != null)
            {
                LlenaCombo(dtBancosCh, ref cmbChequeBanco, "K_Banco", "D_Banco", 0);
                cmbChequeBanco.SelectedIndex = 0;
            }

            DataTable dtBancosT = sqlCatalogos.Sk_Bancos();
            if (dtBancosT != null)
            {
                LlenaCombo(dtBancosT, ref cmbTransferenciaBanco, "K_Banco", "D_Banco", 0);
                cmbTransferenciaBanco.SelectedIndex = 0;
            }

            DataTable dtBancosTarjeta = sqlCatalogos.Sk_Bancos();
            if (dtBancosTarjeta != null)
            {
                LlenaCombo(dtBancosTarjeta, ref cmbTarjetaBanco, "K_Banco", "D_Banco", 0);
                cmbTarjetaBanco.SelectedIndex = 0;
            }
            pnlFormasPago.Enabled = true;
            if (B_Efectivo == true)
            {
                pnlEfectivo.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = true;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = false;
                txtEfectivoImporte.Focus();
            }
            if (B_Cheque == true)
            {
                pnlCheque.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = true;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = false;
                txtChequeNoCheque.Focus();
            }
            if (B_Transferencia)
            {
                pnlTransferencia.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = true;
                pnlIncobrable.Visible = false;
                txtTransferenciaNoTransferencia.Focus();
            }
            if(B_Tarjeta ==  true)
            {
                pnlIncobrable.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = true;
                txtNumTarjeta.Focus();
            }
            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
