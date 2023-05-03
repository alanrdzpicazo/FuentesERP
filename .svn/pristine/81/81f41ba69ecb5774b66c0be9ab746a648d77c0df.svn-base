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
    public partial class FRM_PROVEEDOR_BANCOS: FormaCatalogo
    {
        public TextBox txt_PB_Banco
        {
            get { return this.txtBanco; }
        }
        public Int32 K_Banco;
        int  Cuenta = 0;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public int PropiedadK_Proveedor { get; set; }
        public string PropiedadD_Proveedor { get; set; }
        public FRM_PROVEEDOR_BANCOS()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonModificar.Visible = false;
        
            txtFocus = txtBanco; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos =sql_Catalogos.Sk_Proveedores_Bancos(PropiedadK_Proveedor);
            CatalogoPropiedadCampoClave = "K_Banco";
            CatalogoPropiedadCampoDescripcion = "D_Banco";

            lblProveedor.Text = PropiedadD_Proveedor;

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtBanco.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            cbxActiva.Checked = false;
            cbxDeposito.Checked = false;

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtBanco.Text = ren["D_Banco"].ToString();
            txtCuenta.Text = ren["Cuenta"].ToString();
           cbxDeposito.Checked = Convert.ToBoolean(ren["B_Deposito"]);
            cbxActiva.Checked = Convert.ToBoolean(ren["B_Activa"]);
        }

        public override void BaseBotonBorrarClick()
        {
            if (txtBanco.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtBanco.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Proveedores_Bancos(K_Banco,PropiedadK_Proveedor,GlobalVar.K_Usuario, GlobalVar.K_Usuario, ref msg);
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
                res = sql_Catalogos.In_Proveedores_Bancos(K_Banco, PropiedadK_Proveedor, Cuenta, cbxDeposito.Checked, GlobalVar.K_Usuario, ref msg);
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

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco frm = new Busquedas.Frm_Busca_Banco(PropiedadK_Proveedor);
            frm.ShowDialog();

            if (K_Banco != frm.LLave_Seleccionado)
            {
                K_Banco= frm.LLave_Seleccionado;
                txtBanco.Text = frm.Descripcion_Seleccionado;
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtBanco.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL BANCO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBanco.Focus();
                return false;
            }
            if (txtCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

    }
}
