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
    public partial class FRM_CONTACTOS_PROVEEDOR : FormaCatalogo
    {
        Funciones fx = new Funciones();
        DateTime FechaInicial = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;

        public Boolean Tipo = true;

        public Int32 K_Tipo_Contacto;
        public TextBox txt_P_Tipo_Contacto
        {
            get { return this.txtTP; }
        }
        public Int32 K_Contacto_Proveedor;
        public int PropiedadK_Proveedor { get; set; }
        public string PropiedadD_Proveedor { get; set; }
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_CONTACTOS_PROVEEDOR()
        {
            InitializeComponent();

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Contacto frm = new Busquedas.Frm_Busca_Tipo_Contacto(Tipo);
            frm.ShowDialog();

            if (K_Tipo_Contacto != frm.LLave_Seleccionado)
            {
                K_Tipo_Contacto = frm.LLave_Seleccionado;
                txtTP.Text = frm.Descripcion_Seleccionado;
            }
        }
        public override void BaseMetodoInicio()
        {
   
            txtFocus = txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Contactos_Proveedor(PropiedadK_Proveedor);
            CatalogoPropiedadCampoClave = "K_Contacto_Proveedor";
            CatalogoPropiedadCampoDescripcion = "D_Contacto";

            lblProveedor.Text = PropiedadD_Proveedor;

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;

            txtDescripcion.Focus();
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtTP.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtPuesto.Text = string.Empty;
            dtpAlta.Value = DateTime.Now;
            dtpBaja.Value = DateTime.Now;
            txtTelefono2.Text = string.Empty;
            txtExtension.Text = string.Empty;
            txtCelular.Text = string.Empty;
    
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Contacto_Proveedor"].ToString();
            txtDescripcion.Text = ren["D_Contacto"].ToString();
            K_Tipo_Contacto = Convert.ToInt32(ren["K_Tipo_Contacto"].ToString());
            txtTP.Text = ren["D_Tipo_Contacto"].ToString();
            txtTelefono.Text = ren["Telefono_Contacto"].ToString();
            txtCorreo.Text = ren["Correo_Contacto"].ToString();
            txtPuesto.Text = ren["Puesto"].ToString();
            dtpAlta.Format = DateTimePickerFormat.Custom;
            dtpAlta.CustomFormat = "yyyy-MM-dd";
            dtpAlta.Value = Convert.ToDateTime(ren["F_Alta"]);
            txtTelefono2.Text = ren["Telefono_Contacto2"].ToString();
            txtExtension.Text = ren["Extension"].ToString();
            txtCelular.Text = ren["Numero_Movil"].ToString();

            if (Convert.ToBoolean(ren["B_Activo"])==false)
            {
                label7.Visible = true;
                dtpBaja.Visible = true;
                dtpBaja.Format = DateTimePickerFormat.Custom;
                dtpBaja.CustomFormat = "yyyy-MM-dd";
                dtpBaja.Value = Convert.ToDateTime(ren["F_Baja"]);
            }
          


            
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
                res = sql_Catalogos.Dl_Contactos_Proveedor(Convert.ToInt32(txtClave.Text), GlobalVar.K_Usuario, ref msg);
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
                res = sql_Catalogos.In_Contactos_Proveedor(ref CampoIdentity, K_Tipo_Contacto, PropiedadK_Proveedor, txtTelefono.Text, txtCorreo.Text, txtPuesto.Text, txtDescripcion.Text, GlobalVar.K_Usuario,txtTelefono2.Text.Trim(), txtExtension.Text.Trim().Length==0?0: Convert.ToInt32(txtExtension.Text),txtCelular.Text.Trim(), ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Contactos_Proveedor(CampoIdentity, K_Tipo_Contacto, PropiedadK_Proveedor, txtTelefono.Text, txtCorreo.Text, txtPuesto.Text, txtDescripcion.Text, txtTelefono2.Text.Trim(), txtExtension.Text.Trim().Length==0 ?0 : Convert.ToInt32(txtExtension.Text), txtCelular.Text.Trim(), ref msg);
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
                MessageBox.Show("FALTA CAPTURAR EL CONTACTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtTP.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR TIPO DE CONTACTO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTP.Focus();
                return false;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TELEFONO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }
            if (txtPuesto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PUESTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
               
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(fx.EsDatoNumerico(e.KeyChar.ToString()))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }
    }

}
