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
    public partial class FRM_ESTATUS_REMISION : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public FRM_ESTATUS_REMISION()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = this.txtEstatusRemision ; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Estatus_Remision();
            CatalogoPropiedadCampoClave = "K_Estatus_Remision";
            CatalogoPropiedadCampoDescripcion = "D_Estatus_Remision";
            BaseBotonNuevo.Enabled = true;



            base.BaseMetodoInicio();
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            short CampoIdentity = 0; //

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Estatus_Remision(ref CampoIdentity, this.txtEstatusRemision.Text, GlobalVar.K_Usuario, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Estatus_Remision(CampoIdentity, this.txtEstatusRemision.Text, GlobalVar.K_Usuario, ref msg);
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
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON DESCRIPCIÓN :\n" + this.txtEstatusRemision.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Estatus_Remision(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            this.txtEstatusRemision.Text = string.Empty;


            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            this.txtClave.Text = ren["K_Estatus_Remision"].ToString();
            this.txtEstatusRemision.Text = ren["D_Estatus_Remision"].ToString();



        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.txtEstatusRemision.Text.Trim().Length == 0)
            {
                MessageBox.Show("Se debe capturar el 'Estatus de la remisión' ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstatusRemision.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
    }


}

   

