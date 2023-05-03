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

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_CUENTAS_EMPRESA : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;

        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public int PropiedadK_Empresa { get; set; }
        public string PropiedadD_Empresa { get; set; }

        Funciones fx = new Funciones();

        public FRM_CUENTAS_EMPRESA()

        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {

            txtNoCuenta.Focus();
            pnlControles.Enabled = false; //NO Borrar

            txtK_Empresa.Text = Convert.ToString(PropiedadK_Empresa);
            txtD_Empresa.Text = PropiedadD_Empresa;

            BaseDtDatos = sql_Catalogos.Sk_Empresa_Cuentas(Convert.ToInt32(txtK_Empresa.Text));
            CatalogoPropiedadCampoClave = "K_Cuenta_Empresa";
            CatalogoPropiedadCampoDescripcion = "D_Banco";


            DataTable dtBancosCh = sqlCatalogos.Sk_Bancos();
            if (dtBancosCh != null)
            {
                LlenaCombo(dtBancosCh, ref cmbBanco, "K_Banco", "D_Banco", 0);
                cmbBanco.SelectedIndex = -1;
            }

            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            cmbBanco.SelectedIndex = -1;
            txtCuentaClabe.Text = string.Empty;
            txtNoCuenta.Text = string.Empty;
            txtSucursal.Text = string.Empty;
            txtPlaza.Text = string.Empty;

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Cuenta_Empresa"].ToString();
            cmbBanco.SelectedValue = ren["K_Banco"].ToString();
            txtNoCuenta.Text = ren["Numero_Cuenta"].ToString();
            txtSucursal.Text = ren["Sucursal"].ToString();
            txtPlaza.Text = ren["Plaza"].ToString();
            txtCuentaClabe.Text = ren["Cuenta_Clabe"].ToString();

        }

        public override void BaseBotonBorrarClick()
        {

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtClave.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Empresa_Cuentas( Convert.ToInt16(txtClave.Text), ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            int CampoIdentity = 0;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sql_Catalogos.In_Empresa_Cuentas(ref CampoIdentity, PropiedadK_Empresa, Convert.ToInt32(cmbBanco.SelectedValue), txtNoCuenta.Text, txtCuentaClabe.Text, txtPlaza.Text,
                    txtSucursal.Text, ref msg);
            }
            else
            {
                    CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                    res = CatalogosSQL.Up_Empresa_Cuentas(CampoIdentity, Convert.ToInt32(cmbBanco.SelectedValue), txtNoCuenta.Text, txtCuentaClabe.Text, txtPlaza.Text,
                    txtSucursal.Text, ref msg);

            }

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
                BaseBotonCancelarClick();
            }

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtK_Empresa.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR LA EMPRESA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNoCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR EL NUMERO DE CUENTA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbBanco.SelectedValue == null)
            {
                MessageBox.Show("DEBE CAPTURAR EL BANCO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtNoCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar))||(e.KeyChar ==Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNoCuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
