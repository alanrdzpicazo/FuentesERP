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
    public partial class FRM_DEPARTAMENTOS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_DEPARTAMENTOS()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Departamento();
            CatalogoPropiedadCampoClave = "K_Departamento";
            CatalogoPropiedadCampoDescripcion = "D_Departamento";

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
                res = sql_Catalogos.In_Departamento(ref CampoIdentity, txtDescripcion.Text,TxtCentroCostos.Text,TxtCuenta.Text, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = sql_Catalogos.Up_Departamento(CampoIdentity, txtDescripcion.Text,TxtCentroCostos.Text,TxtCuenta.Text, ref msg);
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
                res = sql_Catalogos.Dl_Departamento(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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
            if (TxtCentroCostos.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CENTRO DE COSTOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCentroCostos.Focus();
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
            TxtCentroCostos.Text = string.Empty;

            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Departamento"].ToString();
            txtDescripcion.Text = ren["D_Departamento"].ToString();
            TxtCentroCostos.Text = ren["Centro_Costos"].ToString();
            TxtCuenta.Text= ren["Cuenta"].ToString();

        }
        private void TxtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)||(e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtCuenta.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(TxtCuenta.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCuenta.Text = string.Empty;
                return;
            }
        }

        
    }
}
