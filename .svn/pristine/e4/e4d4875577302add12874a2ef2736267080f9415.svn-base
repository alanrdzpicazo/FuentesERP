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
    public partial class Frm_Cheque : FormaBase
    {
        SQLAdministracion sql_cxc = new SQLAdministracion();

        DataTable dtDatos = new DataTable();

        int res = 0;
        string msg = string.Empty;
        public Frm_Cheque()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso1.Text = "Guardar";
            BaseBotonProceso1.Visible = true;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnCancelar.Image.png"]));
            BaseBotonProceso2.Text = "Cancelar";
            BaseBotonProceso2.Visible = true;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["checks_22171.ico"]));
            BaseBotonProceso3.Text = "Consultar Cheques";
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Width = 120;

            grdDatos.AutoGenerateColumns = false;

            txt_Usuario_Captura.Text = GlobalVar.D_Usuario.ToString();

            DataTable dtBancosCh = sqlCatalogos.Sk_Bancos();
            if (dtBancosCh != null)
            {
                LlenaCombo(dtBancosCh, ref cmbChequeBanco, "K_Banco", "D_Banco", 0);
                cmbChequeBanco.SelectedIndex = 0;
            }

            this.WindowState = FormWindowState.Maximized;
            dtp_Fecha_Posfechado.Visible = false;

            Mtd_Cargar_Cheques();



        }
        public override void BaseBotonProceso1Click()
        {
            if (!BaseFuncionValidaciones())
                return;

            int CampoIdentity = 0;
            res = 0;
            msg = string.Empty;
            short K_Tipo_Pago = 0;
  
            decimal Importe_Cheque = 0;

            //REGISTRADO      
            int K_Estado_Cheque = 1;

            Importe_Cheque = Convert.ToDecimal(TxtImporteToDec(ref txtChequeImporte));
                 
            res = sql_cxc.In_Cheques(ref CampoIdentity,ucOficinas1.K_Oficina, K_Estado_Cheque,
                Convert.ToInt32(TxtClaveCliente.Text),Convert.ToInt32(cmbChequeBanco.SelectedValue),
                Convert.ToDecimal(txtChequeCuenta.Text),Convert.ToDecimal(txtChequeNoCheque.Text),
                Convert.ToDecimal(txtChequeImporte.Text),GlobalVar.K_Usuario,cbx_Posfechado.Checked,dtp_Fecha_Posfechado.Value, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE REGISTRÓ EL CHEQUE CORRECTAMENTE CON No. DE FOLIO \n " +
                    CampoIdentity.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_No_Cheque.Text = CampoIdentity.ToString();

            }

            BaseMetodoInicio();
            BaseBotonProceso2Click();

        }
        public override void BaseBotonProceso2Click()
        {
            BaseMetodoLimpiaControles();
            LimpiaControlesFormaPago();

            txt_No_Cheque.Text = string.Empty;
            ucOficinas1.K_Oficina = 0;
            ucOficinas1.txt_E_Oficina.Text = string.Empty;
            ucOficinas1.K_Oficina = 0;
    
            BaseMetodoInicio();

        }
        public override void BaseBotonProceso3Click()
        {
            ADMINISTRACION.Frm_ConsultaCheque frm = new Frm_ConsultaCheque();
            frm.ShowDialog();
        }
        public override void BaseMetodoLimpiaControles()
        {
            grdDatos.DataSource = null;
        }
        private void LimpiaControlesFormaPago()
        {

            TxtClaveCliente.Text = string.Empty;
            TxtCliente.Text = string.Empty;
            cmbChequeBanco.SelectedIndex = -1;
            txtChequeCuenta.Text = string.Empty;
            txtChequeNoCheque.Text = string.Empty;
            txtChequeImporte.Text = string.Empty;
            cbx_Posfechado.Checked = false;
            dtp_Fecha_Posfechado.Value = DateTime.Now;
        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            decimal Resta = 0;
            if (txtChequeImporte.Text.Trim().Length > 0)
                Resta = Math.Abs(Convert.ToDecimal(txtChequeImporte.Text));

            if (Resta == 0)
            {
                MessageBox.Show("EL VALOR DEL CHEQUE DEBE DE SER MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChequeImporte.Focus();
                return false;
            }
            if (ucOficinas1.txt_E_Oficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucOficinas1.Focus();
                return false;
            }
            if (TxtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClaveCliente.Focus();
                return false;
            }
            if (Convert.ToInt32(cmbChequeBanco.SelectedValue) == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR UN BANCO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbChequeBanco.Focus();
                return false;
            }
            if (TxtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClaveCliente.Focus();
                return false;
            }
            if (txtChequeCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR LA CUENTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChequeCuenta.Focus();
                return false;
            }
            if (txtChequeNoCheque.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN NO. DE CHEQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChequeNoCheque.Focus();
                return false;
            }
            if (txtChequeImporte.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN IMPORTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChequeImporte.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
        private void txtChequeCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtChequeNoCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumero(ref e);
        }
        private void txtChequeImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtChequeImporte.Text.Length; i++)
            {
                if (txtChequeImporte.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    if (e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        return;
                    }

                }

            }
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            this.TxtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
            this.TxtCliente.Text = filtra.D_Cliente_Seleccionado;
        }
        private void cbx_Posfechado_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_Posfechado.Checked == true)
            {
                dtp_Fecha_Posfechado.Visible = true;
            }
            else if(cbx_Posfechado.Checked == false)
            {
                dtp_Fecha_Posfechado.Visible = false;
            }
        }
        private void Mtd_Cargar_Cheques()
        {
            dtDatos = sql_cxc.Sk_Cheques();

            grdDatos.DataSource = dtDatos;
        }

        public override void BaseBotonAfectarClick()
        {
            //recorrer grid y poner numero de cheque a afectar
            int K_Cheque_Seleccionado = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Cheque"].Value.ToString());
            bool B_Devuleto = Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Devuelto"].Value.ToString());
            bool B_Aplicado = Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Aplicado"].Value.ToString());

            if (K_Cheque_Seleccionado <= 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CHEQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            res = 0;
            msg = string.Empty;
            res = sql_cxc.Up_Cheques(K_Cheque_Seleccionado, B_Devuleto, B_Aplicado, GlobalVar.K_Usuario, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE DEVOLVIÓ EL CHEQUE CON No. DE FOLIO " + K_Cheque_Seleccionado.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            BaseMetodoInicio();
            BaseBotonProceso2Click();

        }

    }
}
