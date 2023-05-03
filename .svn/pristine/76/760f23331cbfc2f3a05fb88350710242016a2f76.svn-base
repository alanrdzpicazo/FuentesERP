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
    public partial class FRM_TIPO_POLIZA : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_TIPO_POLIZA()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = this.txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Tipo_Poliza();
            CatalogoPropiedadCampoClave = "K_Tipo_Poliza";
            CatalogoPropiedadCampoDescripcion = "D_Tipo_Poliza";
            BaseBotonNuevo.Enabled = true;

            base.BaseMetodoInicio();

            BaseBotonBorrar.Visible = false;
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0; //

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Tipo_Poliza(ref CampoIdentity, txtDescripcion.Text.Trim(), ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Tipo_Poliza(CampoIdentity, txtDescripcion.Text.Trim(), ref msg);
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

      
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            this.txtDescripcion.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            this.txtClave.Text = ren["K_Tipo_Poliza"].ToString();
            this.txtDescripcion.Text = ren["D_Tipo_Poliza"].ToString();



        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

    }
}
