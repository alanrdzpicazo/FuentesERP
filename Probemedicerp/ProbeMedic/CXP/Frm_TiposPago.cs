using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PARIS.App_Code.BLL;


namespace PARIS.CXP
{
    public partial class Frm_TiposPago : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        clsCuentasxPagar sqlCxP = new clsCuentasxPagar();

        public Frm_TiposPago()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sqlCxP.sps_Tipos_Pago();
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
            cbxAplicaCXC.Checked = false;
            cbxAplicaCXP.Checked = false;
            cbxIncobrable.Checked = false;
            cbxNotaCredito.Checked = false; 

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Tipo_Pago"].ToString();
            txtDescripcion.Text = ren["D_Tipo_Pago"].ToString();
            cbxAplicaCXC.Checked = Convert.ToBoolean(ren["B_Aplica_CxC"]);
            cbxAplicaCXP.Checked = Convert.ToBoolean(ren["B_Aplica_CxP"]);
            cbxIncobrable.Checked = Convert.ToBoolean(ren["B_Incobrable"]);
            cbxNotaCredito.Checked = Convert.ToBoolean(ren["B_NotaCredito"]);
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
                res = sqlCxP.spd_Tipos_Pago(Convert.ToInt16(CatalogoPropiedadId_Identity),ref msg);

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
            short CampoIdentity = 0;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCxP.spi_Tipos_Pago(ref CampoIdentity, txtDescripcion.Text,cbxAplicaCXP.Checked,cbxAplicaCXC.Checked,cbxNotaCredito.Checked,cbxIncobrable.Checked, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCxP.spu_Tipos_Pago(CampoIdentity, txtDescripcion.Text, cbxAplicaCXP.Checked, cbxAplicaCXC.Checked, cbxNotaCredito.Checked, cbxIncobrable.Checked, ref msg);
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
