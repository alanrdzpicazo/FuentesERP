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
    public partial class FRM_CANAL_DISTRIBUCION_CLIENTE : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public FRM_CANAL_DISTRIBUCION_CLIENTE()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion;
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = sql_Catalogos.Sk_Canal_Distribucion_Cliente();
            CatalogoPropiedadCampoClave = "K_Canal_Distribucion_Cliente";
            CatalogoPropiedadCampoDescripcion = "D_Canal_Distribucion_Cliente";
            base.BaseMetodoInicio();

        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {

            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Canal_Distribucion_Cliente"].ToString();
            txtDescripcion.Text = ren["D_Canal_Distribucion_Cliente"].ToString();
            CbxActivo.Checked = Convert.ToBoolean(ren["B_Activo"].ToString());

        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            CbxActivo.Checked = false;

       
        }
        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtClave.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = CatalogosSQL.Dl_Canal_Distribucion_Cliente(Convert.ToInt32(CatalogoPropiedadId_Identity),GlobalVar.K_Usuario,ref msg);

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
                res = CatalogosSQL.In_Canal_Distribucion_Cliente(ref CampoIdentity, txtDescripcion.Text, GlobalVar.K_Usuario, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Canal_Distribucion_Cliente(Convert.ToInt32(txtClave.Text), txtDescripcion.Text,GlobalVar.K_Usuario,ref msg);
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
                MessageBox.Show("FALTA CAPTURAR DESCRIPCIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            
            BaseErrorResultado = false;
            return true;
        }
    }
}
