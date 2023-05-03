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
    public partial class FRM_EMPRESAS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        public FRM_EMPRESAS()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            //pnlControles.Enabled = false; //NO Borrar
            DeshabilitaPages(ref tcControles, false);

            BaseDtDatos = CatalogosSQL.Sk_empresa();
            CatalogoPropiedadCampoClave = "K_Empresa";
            CatalogoPropiedadCampoDescripcion = "D_Empresa";


            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["Cuentas.png"]));
            BaseBotonProceso1.Text = "Cuentas";
            BaseBotonProceso1.Width = 120;
            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            //pnlControles.Enabled = B_Habilita;
            DeshabilitaPages(ref tcControles, B_Habilita);
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCorto.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtTipoRegimen.Text = string.Empty;
            //cbxActiva.Checked = true;

            txtColonia.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtCP.Text = string.Empty;

            txtTelefono.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtNoExterior.Text = string.Empty;
            txtNoInterior.Text = string.Empty;
            txtFax.Text = string.Empty;
            tcControles.SelectTab(tpGenerales);

            //geo_Ciudades1.LimpiaControles();
           // BaseBotonProceso1.Visible = true;

            DeshabilitaPages(ref tcControles, false);
            //pnlControles.Enabled = false; //NO Borrar        
        }
        public override void BaseBotonProceso1Click()
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_CUENTAS_EMPRESA frm = new FRM_CUENTAS_EMPRESA();
            frm.PropiedadK_Empresa = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Empresa = txtDescripcion.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text =  ren["K_Empresa"].ToString();
            txtDescripcion.Text = ren["D_Empresa"].ToString();

            txtCorto.Text = ren["C_Empresa"].ToString();
            txtRFC.Text = ren["RFC"].ToString();
            txtTipoRegimen.Text = ren["TipoRegimen"].ToString();
            //cbxActiva.Checked = Convert.ToBoolean(ren["B_Activa"]);

            geo_Ciudades1.K_Pais = Convert.ToInt32(ren["K_Pais"]);
            geo_Ciudades1.K_Estado = Convert.ToInt32(ren["K_Estado"]);
            geo_Ciudades1.K_Ciudad = Convert.ToInt32(ren["K_Ciudad"]);
            geo_Ciudades1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Ciudades1.txt_G_Estado.Text = ren["D_Estado"].ToString();
            geo_Ciudades1.txt_G_Ciudad.Text = ren["D_Ciudad"].ToString();


            txtColonia.Text = ren["Colonia"].ToString();
            txtCalle.Text = ren["Calle"].ToString();
            txtCP.Text = ren["CodigoPostal"].ToString();

            txtTelefono.Text = ren["Telefono"].ToString();

            txtNoExterior.Text = ren["NoExterior"].ToString();
            txtNoInterior.Text = ren["NoInterior"].ToString();

            txtFax.Text = ren["Fax"].ToString();


        }


        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = CatalogosSQL.Dl_Empresas(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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
            int CP = 0;
            if (txtCP.Text.Trim().Length > 0)
                CP = Convert.ToInt32(txtCP.Text);

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = CatalogosSQL.In_Empresa(ref CampoIdentity, txtDescripcion.Text, txtCorto.Text, txtRFC.Text, txtTipoRegimen.Text, Convert.ToInt16(geo_Ciudades1.K_Pais), Convert.ToInt32(geo_Ciudades1.K_Estado), Convert.ToInt32(geo_Ciudades1.K_Ciudad), txtColonia.Text, txtCalle.Text, CP, txtTelefono.Text, txtNoExterior.Text, txtNoInterior.Text, txtFax.Text, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Empresa(CampoIdentity, txtDescripcion.Text, txtCorto.Text, txtRFC.Text, txtTipoRegimen.Text, Convert.ToInt16(geo_Ciudades1.K_Pais), Convert.ToInt32(geo_Ciudades1.K_Estado), Convert.ToInt32(geo_Ciudades1.K_Ciudad), txtColonia.Text, txtCalle.Text, CP, txtTelefono.Text, txtNoExterior.Text, txtNoInterior.Text, txtFax.Text, ref msg);
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

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtCorto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION CORTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorto.Focus();
                return false;
            }
            if (txtRFC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR R.F.C. ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return false;
            }
            if (txtTipoRegimen.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL REGIMEN ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoRegimen.Focus();
                return false;
            }
            if (geo_Ciudades1.K_Pais == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Ciudades1.txt_G_Pais.Focus();
                return false;
            }
            if (geo_Ciudades1.K_Estado == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Ciudades1.txt_G_Estado.Focus();
                return false;
            }
            if (geo_Ciudades1.K_Ciudad == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Ciudades1.txt_G_Ciudad.Focus();
                return false;
            }
            if (txtColonia.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                txtColonia.Focus();
                return false;
            }
            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                txtCalle.Focus();
                return false;
            }
            if (txtCP.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CODIGO POSTAL!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }
        public override void BaseMetodoRecarga()
        {
            GlobalVar.dtPaises = CatalogosSQL.Sk_Pais();
            GlobalVar.dtEstados = CatalogosSQL.Sk_Estado();
            base.BaseMetodoRecarga();
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNoExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
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
