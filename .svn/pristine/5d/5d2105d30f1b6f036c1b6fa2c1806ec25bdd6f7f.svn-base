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
    public partial class Frm_ConsultaCheque : FormaBase
    {
        SQLAdministracion sql = new SQLAdministracion();

        DataTable dtDatos = new DataTable();
        DataTable dtSeguimiento = new DataTable();

        int res = 0;
        string msg = string.Empty;
        public Frm_ConsultaCheque()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;

            //BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["1491254395-returnbackredoarrow_82934.ico"]));
            //BaseBotonProceso1.Text = "Cheque devuelto";
            //BaseBotonProceso1.Visible = true;
            //BaseBotonProceso1.Width = 110;

            //BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["documentediting_editdocuments_text_documentedi_2820.ico"]));
            //BaseBotonProceso2.Text = "Segu";
            //BaseBotonProceso2.Visible = true;

            grdDatos.AutoGenerateColumns = false;
            grdSeguimiento.AutoGenerateColumns = false;
        }
        public override void BaseBotonBuscarClick()
        {
           //if(!cbx_B_Aplicado.Checked && !cbx_B_Aprobado.Checked && !cbx_B_Devuelto.Checked && !cbx_Posfechado.Checked)
           //{
           //     MessageBox.Show("DEBE SELECCIONAR AL MENOS UN FILTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           //     groupBox1.Focus();
           //     return;
           //}
            dtDatos = sql.Sk_Cheques();
            
            grdDatos.DataSource = dtDatos;
        }
        public override void BaseBotonProceso1Click()
        {
            int K_Cheque_Seleccionado = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Cheque"].Value.ToString());

            if (K_Cheque_Seleccionado <= 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CHEQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            res = 0;
            msg = string.Empty;
            //res = sql.Up_Cheques(K_Cheque_Seleccionado,B_A,GlobalVar.K_Usuario, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE DEVOLVIÓ EL CHEQUE CON No. DE FOLIO "+K_Cheque_Seleccionado.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            BaseMetodoInicio();
            BaseBotonProceso2Click();

        }
        public override void BaseBotonProceso2Click()
        {
            //BaseMetodoLimpiaControles();
            //LimpiaControlesFormaPago();

            //txt_No_Cheque.Text = string.Empty;
            //ucOficinas1.K_Oficina = 0;
            //ucOficinas1.txt_E_Oficina.Text = string.Empty;
            //ucOficinas1.K_Oficina = 0;

            //BaseMetodoInicio();

        }
        public override void BaseMetodoLimpiaControles()
        {
            grdDatos.DataSource = null;
        }
        public override bool BaseFuncionValidaciones()
        {
            //BaseErrorResultado = true;

            //decimal Resta = 0;
            //if (txtChequeImporte.Text.Trim().Length > 0)
            //    Resta = Math.Abs(Convert.ToDecimal(txtChequeImporte.Text));

            //if (Resta == 0)
            //{
            //    MessageBox.Show("EL VALOR DEL CHEQUE DEBE DE SER MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtChequeImporte.Focus();
            //    return false;
            //}
            //if (ucOficinas1.txt_E_Oficina.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UNA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ucOficinas1.Focus();
            //    return false;
            //}
            //if (TxtClaveCliente.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtClaveCliente.Focus();
            //    return false;
            //}
            //if (Convert.ToInt32(cmbChequeBanco.SelectedValue) == -1)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UN BANCO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cmbChequeBanco.Focus();
            //    return false;
            //}
            //if (TxtClaveCliente.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtClaveCliente.Focus();
            //    return false;
            //}
            //if (txtChequeCuenta.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE CAPTURAR LA CUENTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtChequeCuenta.Focus();
            //    return false;
            //}
            //if (txtChequeNoCheque.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE CAPTURAR UN NO. DE CHEQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtChequeNoCheque.Focus();
            //    return false;
            //}
            //if (txtChequeImporte.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE CAPTURAR UN IMPORTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtChequeImporte.Focus();
            //    return false;
            //}

            //BaseErrorResultado = false;
            return true;
        }
        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            MtdCambiaSeguimiento();
        }
        private void MtdCambiaSeguimiento()
        {
            int K_Cheque = (Int32)grdDatos.CurrentRow.Cells["K_Cheque"].Value;

            if (K_Cheque > 0)
            {
                DataTable dtSeguimiento = sql.Sk_Seguimiento_Cheque(K_Cheque);

                if ((dtSeguimiento != null))
                {
                    this.grdSeguimiento.DataSource = dtSeguimiento;
                }
                else
                {
                    MessageBox.Show("El cheque no cuenta con seguimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdDatos.Focus();
                    return;
                }

            }
        }
        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void grdDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int K_Cheque_Seleccionado = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Cheque"].Value.ToString());

            ADMINISTRACION.Frm_AplicaSeguimientoCheque frm = new ADMINISTRACION.Frm_AplicaSeguimientoCheque();
            frm.K_ChequeInt = K_Cheque_Seleccionado;
            frm.ShowDialog();
            BaseBotonBuscarClick();
        }

        private void cbx_B_Devuelto_CheckedChanged(object sender, EventArgs e)
        {
            dtDatos = sql.Sk_Cheques(cbx_B_Aplicado.Checked, false, cbx_Posfechado.Checked, cbx_B_Devuelto.Checked);

            grdDatos.DataSource = dtDatos;
        }

        private void cbx_Posfechado_CheckedChanged(object sender, EventArgs e)
        {
            dtDatos = sql.Sk_Cheques(cbx_B_Aplicado.Checked, false, cbx_Posfechado.Checked, cbx_B_Devuelto.Checked);

            grdDatos.DataSource = dtDatos;
        }

        private void cbx_B_Aplicado_CheckedChanged(object sender, EventArgs e)
        {
            dtDatos = sql.Sk_Cheques(cbx_B_Aplicado.Checked, false, cbx_Posfechado.Checked, cbx_B_Devuelto.Checked);

            grdDatos.DataSource = dtDatos;
        }
    }
}
