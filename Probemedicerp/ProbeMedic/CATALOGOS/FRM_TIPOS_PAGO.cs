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
    public partial class FRM_TIPOS_PAGO : FormaCatalogo
    {
        int res = 0;

        string msg = string.Empty;

        SQLCatalogos CatalogoSQL = new SQLCatalogos();

        public FRM_TIPOS_PAGO()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = CatalogoSQL.Sk_Tipos_Pago();
            CatalogoPropiedadCampoClave = "K_Tipo_Pago";
            CatalogoPropiedadCampoDescripcion = "D_Tipo_Pago";
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
            Chk_CxC.Checked = false;
            Chk_CxP.Checked = false;
            Chk_Incobrable.Checked = false;
            Chk_Nota_Credito.Checked = false;
            Chk_Venta.Checked = false;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Tipo_Pago"].ToString();
            txtDescripcion.Text = ren["D_Tipo_Pago"].ToString();
            Chk_CxC.Checked = Convert.ToBoolean(ren["B_Aplica_CXC"].ToString());
            Chk_CxP.Checked = Convert.ToBoolean(ren["B_Aplica_CXP"].ToString());
            Chk_Incobrable.Checked = Convert.ToBoolean(ren["B_Incobrable"].ToString());
            Chk_Nota_Credito.Checked = Convert.ToBoolean(ren["B_NotaCredito"].ToString());
            Chk_Venta.Checked = Convert.ToBoolean(ren["B_Aplica_Venta"].ToString());
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
                //res = CatalogosSQL.Dl_Clientes(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);
                //if (res == -1)
                //{
                //    BaseErrorResultado = true;
                //    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //else
                //{
                //    BaseErrorResultado = false;
                //    MessageBox.Show("INFORMACION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    BaseMetodoInicio();
                //    BaseBotonCancelarClick();
                //}
            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;
            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0;
            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = CatalogosSQL.In_Tipos_Pago(
                    ref CampoIdentity, 
                    txtDescripcion.Text,
                    Chk_CxP.Checked,
                    Chk_CxC.Checked,
                    Chk_Nota_Credito.Checked,
                    Chk_Incobrable.Checked,
                    Chk_Venta.Checked,
                    GlobalVar.K_Usuario, 
                    ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Tipos_Pago(
                    CampoIdentity,
                    txtDescripcion.Text,
                    Chk_CxP.Checked,
                    Chk_CxC.Checked,
                    Chk_Nota_Credito.Checked,
                    Chk_Incobrable.Checked,
                    Chk_Venta.Checked,
                    GlobalVar.K_Usuario, 
                    ref msg);
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
                CargaTablasParciales(3);
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
