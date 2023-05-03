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

namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    public partial class FRM_TIPO_IVA : FormaCatalogo
    {
        int res = -1;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_TIPO_IVA()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtTipoIva; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = CatalogosSQL.Sk_Tipo_Iva();
            CatalogoPropiedadCampoClave = "K_Iva";
            CatalogoPropiedadCampoDescripcion = "D_Iva";

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtTipoIva.Text = string.Empty;
            txtPorcentaje.Text = string.Empty;

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Iva"].ToString();
            txtTipoIva.Text = ren["D_Iva"].ToString();
            txtPorcentaje.Text = ren["Porcentaje"].ToString();
        }


        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtTipoIva.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = CatalogosSQL.Dl_Tipo_Iva(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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
                res = CatalogosSQL.In_Tipo_Iva(ref CampoIdentity, txtTipoIva.Text, Convert.ToDecimal(txtPorcentaje.Text), ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Tipo_Iva(CampoIdentity, txtTipoIva.Text, Convert.ToDecimal(txtPorcentaje.Text), ref msg);
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

            if (txtTipoIva.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoIva.Focus();
                return false;
            }
            if (txtPorcentaje.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PORCENTAJE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPorcentaje.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
