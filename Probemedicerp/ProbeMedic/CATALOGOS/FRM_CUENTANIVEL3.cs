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
    public partial class FRM_CUENTANIVEL3 : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();

        public FRM_CUENTANIVEL3()
        {
            InitializeComponent();
        }


        public override void BaseMetodoInicio()
        {
            txtFocus = this.txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Cuenta_Nivel3();
            CatalogoPropiedadCampoClave = "K_Subcuenta";
            CatalogoPropiedadCampoDescripcion = "D_Subcuenta";
            BaseBotonNuevo.Enabled = true;

            base.BaseMetodoInicio();

            BaseBotonBorrar.Visible = false;
        }
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;


            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Cuenta_Nivel3(ucCuentaNivel21.K_Cuenta_Mayor, ucCuentaNivel21.K_Cuenta, Convert.ToInt32(txtClave.Text), txtDescripcion.Text, txtCuenta.Text, cbxPadre.Checked, ref msg);

            }
            else //Existe. Update
            {
                res = sqlCatalogos.Up_Cuenta_Nivel3(ucCuentaNivel21.K_Cuenta_Mayor, ucCuentaNivel21.K_Cuenta, Convert.ToInt32(txtClave.Text), txtDescripcion.Text, txtCuenta.Text, cbxPadre.Checked, ref msg);
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


        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            this.txtClave.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtCuenta.Text = string.Empty;
            ucCuentaNivel21.K_Cuenta_Mayor = 0;
            ucCuentaNivel21.K_Cuenta = 0;
            ucCuentaNivel21.txt_G_Cuenta.Text = "";
            ucCuentaNivel21.txt_G_Cuenta_Mayor.Text = "";
            txtClave.Text = "";
            cbxPadre.Checked = false;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            ucCuentaNivel21.K_Cuenta_Mayor = Convert.ToInt32(ren["K_Cuenta_Mayor"].ToString());
            ucCuentaNivel21.txt_G_Cuenta_Mayor.Text = ren["D_Cuenta_Mayor"].ToString();
            ucCuentaNivel21.K_Cuenta = Convert.ToInt32(ren["K_Cuenta"].ToString());
            ucCuentaNivel21.txt_G_Cuenta.Text = ren["D_Cuenta"].ToString();
            txtClave.Text = ren["K_Subcuenta"].ToString();
            txtDescripcion.Text = ren["D_Subcuenta"].ToString();
            txtCuenta.Text = ren["Cuenta"].ToString();
            cbxPadre.Checked =  Convert.ToBoolean(ren["Padre"].ToString());
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.ucCuentaNivel21.txt_G_Cuenta_Mayor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA MAYOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCuentaNivel21.Focus();
                return false;
            }
            if (this.ucCuentaNivel21.txt_G_Cuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCuentaNivel21.Focus();
                return false;
            }
            if (this.txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO DE SUBCUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }
            if (this.txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (this.txtCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((fx.EsDatoNumerico(e.KeyChar.ToString())) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
