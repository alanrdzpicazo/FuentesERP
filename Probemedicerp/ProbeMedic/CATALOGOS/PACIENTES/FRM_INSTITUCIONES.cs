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
    public partial class FRM_INSTITUCIONES : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;

        public FRM_INSTITUCIONES()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = CatalogosSQL.Sk_Instituciones();
            CatalogoPropiedadCampoClave = "K_Institucion";
            CatalogoPropiedadCampoDescripcion = "D_Institucion";

            base.BaseMetodoInicio();

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCorto.Text = string.Empty;
            txtRFC.Text = string.Empty;

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Institucion"].ToString();
            txtDescripcion.Text = ren["D_Institucion"].ToString();
            txtCorto.Text = ren["C_Institucion"].ToString();
            txtRFC.Text = ren["RFC_Institucion"].ToString();

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
                res = CatalogosSQL.Dl_Instituciones(Convert.ToInt16(CatalogoPropiedadId_Identity),GlobalVar.K_Usuario, ref msg);

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
                res = CatalogosSQL.In_Instituciones(ref CampoIdentity, txtDescripcion.Text, txtCorto.Text,txtRFC.Text,GlobalVar.K_Usuario, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Instituciones(Convert.ToInt32(txtClave.Text), txtDescripcion.Text, txtCorto.Text,txtRFC.Text, ref msg);
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
                CargaTablasParciales(2);
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
                MessageBox.Show("FALTA CAPTURAR RFC...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

       
    }
}
