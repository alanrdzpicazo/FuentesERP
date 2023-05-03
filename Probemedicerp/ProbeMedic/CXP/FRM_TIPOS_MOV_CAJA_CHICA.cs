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
    public partial class FRM_TIPOS_MOV_CAJA_CHICA : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCuentasxPagar SQL_CXP = new SQLCuentasxPagar();
        public FRM_TIPOS_MOV_CAJA_CHICA()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = SQL_CXP.SK_Tipos_MovCchica();
            CatalogoPropiedadCampoClave = "K_Tipo_MovCchica";
            CatalogoPropiedadCampoDescripcion = "D_Tipo_MovCchica";

            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;

         

            base.BaseMetodoInicio();
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
                res = SQL_CXP.In_Tipos_MovCchica(ref CampoIdentity,txtDescripcion.Text, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = SQL_CXP.Up_Tipos_MovCchica(CampoIdentity, txtDescripcion.Text, ref msg);

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
            txtClave.Text = ren["K_Tipo_MovCchica"].ToString();
            txtDescripcion.Text = ren["D_Tipo_MovCchica"].ToString();

        }
    }
}
