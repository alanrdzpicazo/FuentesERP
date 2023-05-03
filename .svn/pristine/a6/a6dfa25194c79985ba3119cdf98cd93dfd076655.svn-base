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

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRM_GRUPOS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;


        public FRM_GRUPOS()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = SeguridadSQL.Sk_Grupo();
            CatalogoPropiedadCampoClave = "K_Grupo";
            CatalogoPropiedadCampoDescripcion = "D_Grupo";

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

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Grupo"].ToString();
            txtDescripcion.Text = ren["D_Grupo"].ToString();
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
                res = SeguridadSQL.Dl_Grupo(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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
                res = SeguridadSQL.In_Grupo(ref CampoIdentity, txtDescripcion.Text, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = SeguridadSQL.Up_Grupo(CampoIdentity, txtDescripcion.Text, ref msg);
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
            BaseErrorResultado = false;
            return true;
        }

    }
}
