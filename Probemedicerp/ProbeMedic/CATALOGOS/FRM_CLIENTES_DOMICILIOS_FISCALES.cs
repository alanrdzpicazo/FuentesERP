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
    public partial class FRM_CLIENTES_DOMICILIOS_FISCALES : FormaCatalogo
    {
        public FRM_CLIENTES_DOMICILIOS_FISCALES()
        {
            InitializeComponent();
        }

        int res = 0;
        string msg = string.Empty;

        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        Funciones fx = new Funciones();

        public int PropiedadK_Cliente { get; set; }
        public string PropiedadD_Cliente{ get; set; }
     
        public override void BaseMetodoInicio()
        {
            BaseBotonModificar.Visible = false;
        
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Cliente_Domicilios_Fiscales(PropiedadK_Cliente);
            CatalogoPropiedadCampoClave = "K_Cliente_Domicilio_Fiscal";
            CatalogoPropiedadCampoDescripcion = "D_Colonia";

            lblCliente.Text = PropiedadD_Cliente;

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            geo_Colonia1.Focus();
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            geo_Colonia1.txt_G_Pais.Text = string.Empty;
            geo_Colonia1.K_Pais = 0;
            geo_Colonia1.txt_G_Estado.Text = string.Empty;
            geo_Colonia1.K_Estado=0;
            geo_Colonia1.txt_G_Ciudad.Text = string.Empty;
            geo_Colonia1.K_Ciudad = 0;
            geo_Colonia1.txt_G_Colonia.Text = string.Empty;
            geo_Colonia1.K_Colonia= 0;
            txtCalle.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtNoExterior.Text = string.Empty;
            txtNoInterior.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbxActivo.Checked = false;      
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            txtClave.Text = ren["K_Cliente_Domicilio_Fiscal"].ToString();
            geo_Colonia1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Colonia1.txt_G_Estado.Text = ren["D_Estado"].ToString();
            geo_Colonia1.txt_G_Ciudad.Text = ren["D_Ciudad"].ToString();
            geo_Colonia1.txt_G_Colonia.Text = ren["D_Colonia"].ToString();
            txtCalle.Text = ren["Calle"].ToString();
            txtCP.Text = ren["Codigo_Postal"].ToString();
            txtNoExterior.Text = ren["Numero_Exterior"].ToString();
            txtNoInterior.Text = ren["Numero_Interior"].ToString();
            txtTelefono.Text = ren["Telefono"].ToString();
            cbxActivo.Checked = Convert.ToBoolean(ren["B_Activo"].ToString());
        
        }

        public override void BaseBotonBorrarClick()
        {
             
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtClave.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Cliente_Domicilios_Fiscales(PropiedadK_Cliente,Convert.ToInt32(txtClave.Text), GlobalVar.K_Usuario, ref msg);
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
                res = sql_Catalogos.In_Cliente_Domicilios_Fiscales(ref CampoIdentity,PropiedadK_Cliente,geo_Colonia1.K_Pais,geo_Colonia1.K_Estado,geo_Colonia1.K_Ciudad,geo_Colonia1.K_Colonia,txtCalle.Text,txtNoExterior.Text,txtNoInterior.Text,txtTelefono.Text,Convert.ToInt32(txtCP.Text), GlobalVar.K_Usuario,DateTime.Now,true, ref msg);
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

            if (geo_Colonia1.txt_G_Pais.Text.Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.Focus();
                return false;
            }
            if (geo_Colonia1.txt_G_Estado.Text.Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.Focus();
                return false;
            }
            if (geo_Colonia1.txt_G_Ciudad.Text.Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CIUDAD..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.Focus();
                return false;
            }
            if (geo_Colonia1.txt_G_Colonia.Text.Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA COLONIA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.Focus();
                return false;
            }

            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR LA CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalle.Focus();
                return false;
            }

            if (txtNoExterior.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR EL NUMERO EXTERIOR..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoExterior.Focus();
                return false;
            }
            if (txtNoInterior.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR EL NUMERO INTERIOR..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoInterior.Focus();
                return false;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR EL TELEFONO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            if (txtCP.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR EL CODIGO POSTAL.!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCP.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(txtCP.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCP.Text = string.Empty;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if ((txtTelefono.Text.Trim().Length == 10))
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

       
    }
}
