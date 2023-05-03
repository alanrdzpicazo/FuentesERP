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
    public partial class FRM_CLIENTES_CONTACTOS : FormaCatalogo
    {
        Funciones fx = new Funciones();
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos SqlCatalogos = new SQLCatalogos();
        public int PropiedadK_Cliente { get; set; }
        public string PropiedadD_Cliente { get; set; }
        public FRM_CLIENTES_CONTACTOS()
        {
            InitializeComponent();
        }
   
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = SqlCatalogos.Sk_Contactos_Cliente(PropiedadK_Cliente);
            CatalogoPropiedadCampoClave = "K_Contacto_Cliente";
            CatalogoPropiedadCampoDescripcion = "D_Contacto_Cliente";

            lblCliente.Text = PropiedadD_Cliente;

            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            ucPuestosContacto1.K_Puesto_Contacto = 0;
            ucPuestosContacto1.txt_E_Puesto_Contacto.Text = string.Empty;
            TxtLada.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            CbxActivo.Checked = false;
            txtTelefono2.Text = string.Empty;
            txtTelefono3.Text = string.Empty;
            txtExt.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Contacto_Cliente"].ToString();
            txtDescripcion.Text = ren["D_Contacto_Cliente"].ToString();
            ucPuestosContacto1.K_Puesto_Contacto = Convert.ToInt32(ren["K_Puesto_Contacto"].ToString());
            ucPuestosContacto1.txt_E_Puesto_Contacto.Text = ren["D_Puesto_Contacto"].ToString();
            TxtLada.Text = ren["Lada"].ToString();
            txtTelefono.Text = ren["Telefono"].ToString();
            txtCorreo.Text = ren["Correo"].ToString();
            CbxActivo.Checked = Convert.ToBoolean(ren["B_Activo"].ToString());
            txtTelefono2.Text = ren["Telefono2"].ToString();
            txtTelefono3.Text = ren["Telefono3"].ToString();
            txtExt.Text = ren["Ext"].ToString() != "" ? ren["Ext"].ToString() : "";
        }
        public override void BaseBotonBorrarClick()
        {

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtClave.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = SqlCatalogos.Dl_Contactos_Cliente(Convert.ToInt32(txtClave.Text), GlobalVar.K_Usuario, ref msg);
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
                res = SqlCatalogos.In_Contactos_Cliente(ref CampoIdentity, PropiedadK_Cliente, ucPuestosContacto1.K_Puesto_Contacto, txtDescripcion.Text.Trim(),TxtLada.Text, txtTelefono.Text, txtCorreo.Text.Trim(), GlobalVar.K_Usuario,txtTelefono2.Text.Trim(),txtTelefono3.Text.Trim(),txtExt.Text.Trim().Length>0? txtExt.Text.Trim() : "", ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = SqlCatalogos.Up_Contactos_Cliente(CampoIdentity, PropiedadK_Cliente, ucPuestosContacto1.K_Puesto_Contacto, txtDescripcion.Text.Trim(), TxtLada.Text, txtTelefono.Text, txtCorreo.Text.Trim(), GlobalVar.K_Usuario, txtTelefono2.Text.Trim(), txtTelefono3.Text.Trim(), txtExt.Text.Trim().Length > 0 ? txtExt.Text.Trim() : "", ref msg);
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

            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN NOMBRE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (ucPuestosContacto1.K_Puesto_Contacto == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PUESTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPuestosContacto1.Focus();
                return false;
            }
            if (TxtLada.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UNA LADA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLada.Focus();
                return false;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN TELEFONO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN CORREO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }
            //if (txtExt.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE CAPTURAR UNA EXTENSIÓN..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtExt.Focus();
            //    return false;
            //}
            if (!fx.ValidaEmail(txtCorreo.Text))
            {
                MessageBox.Show("Debe capturar una dirección de correo valida...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Text = string.Empty;
                txtCorreo.Focus();
                return false;
            }
         

            BaseErrorResultado = false;
            return true;
        }
        private void TxtLada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar))||(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TxtLada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtLada.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(TxtLada.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!... " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtLada.Text = string.Empty;
                return;
            }

        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if ((txtTelefono.Text.Trim().Length == 10))
                {
                    if(e.KeyChar == Convert.ToChar(Keys.Back))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
 
            }
            else
            {
                e.Handled = true;
            }
            
        }
        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if ((txtTelefono2.Text.Trim().Length == 10))
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Back))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTelefono3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if ((txtTelefono3.Text.Trim().Length == 10))
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Back))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
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
