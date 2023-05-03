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

namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_PADECIMIENTOS : FormaCatalogo
    {
        public FRM_PADECIMIENTOS()
        {
            InitializeComponent();
        }

        private void FRM_PADECIMIENTOS_Load(object sender, EventArgs e)
        {

        }

        int res = -1;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Padecimientos();
            CatalogoPropiedadCampoClave = "K_Padecimiento";
            CatalogoPropiedadCampoDescripcion = "D_Padecimiento";

            base.BaseMetodoInicio();

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
        }
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0; //ESTE ME DEVOLVERA LA CLAVE DEL PAIS YA QUE ES IDENTITY

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sql_Catalogos.In_Padecimientos(ref CampoIdentity, txtDescripcion.Text, txtDescCorta.Text,txtDesripcionLarga.Text,GlobalVar.K_Usuario,txtICD.Text,ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sql_Catalogos.Up_Padecimientos(ref CampoIdentity, txtDescripcion.Text, txtDescCorta.Text,txtDesripcionLarga.Text,GlobalVar.K_Usuario, txtICD.Text,ref msg);
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
                res = sql_Catalogos.Dl_Padecimientos(Convert.ToInt16(CatalogoPropiedadId_Identity),GlobalVar.K_Usuario, ref msg);

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
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtDescCorta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION CORTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescCorta.Focus();
                return false;
            }
            if (txtDesripcionLarga.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION LARGA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesripcionLarga.Focus();
                return false;
            }
            if (txtICD.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ICD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtICD.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar  
            txtDescCorta.Text = string.Empty;
            txtDesripcionLarga.Text = string.Empty;
            txtICD.Text = string.Empty;
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Padecimiento"].ToString();
            txtDescripcion.Text = ren["D_Padecimiento"].ToString();
            txtDescCorta.Text = ren["C_Padecimiento"].ToString();
            txtDesripcionLarga.Text = ren["Descripcion_Padecimiento"].ToString();
            txtICD.Text = ren["ICD"].ToString();
        }
    }
}
