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
    public partial class FRM_CIUDAD : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
     
        SQLCatalogos CatalogoSQL = new SQLCatalogos();

        public FRM_CIUDAD()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = CatalogosSQL.Sk_Ciudad(1,1);
            CatalogoPropiedadCampoClave = "K_Ciudad";
            CatalogoPropiedadCampoDescripcion = "D_Ciudad";
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
            DataTable dtPais = CatalogoSQL.Sk_Pais();
            LlenaCombo(dtPais, ref cmbPais, "K_Pais", "D_Pais");

        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cmbPais.SelectedIndex = -1;
            cmbEstados.SelectedIndex = -1;
            cbxFrontera.Checked = false;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Ciudad"].ToString();
            txtDescripcion.Text = ren["D_Ciudad"].ToString();

            cmbPais.SelectedValue = Convert.ToInt32(ren["K_Pais"]);
            cmbEstados.SelectedValue = Convert.ToInt32(ren["K_Estado"]);

            cmbPais.Text = ren["D_Pais"].ToString();
            cmbEstados.Text = ren["D_Estado"].ToString();

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
                res = CatalogosSQL.Dl_Ciudad(Convert.ToInt32(cmbEstados.SelectedValue), Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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

        public override void BaseBotonBuscarClick()
        {
            FILTROS.Frm_Filtra_Ciudades frm = new FILTROS.Frm_Filtra_Ciudades();
            frm.ShowDialog();

            BaseDtDatos = frm.dtFiltra;
            CatalogoPropiedadCampoClave = "K_Ciudad";
            CatalogoPropiedadCampoDescripcion = "D_Ciudad";
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
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
                res = CatalogosSQL.In_Ciudad(Convert.ToInt16(cmbPais.SelectedValue), Convert.ToInt32(cmbEstados.SelectedValue), ref CampoIdentity, txtDescripcion.Text, cbxFrontera.Checked, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Ciudad(Convert.ToInt16(cmbPais.SelectedValue), Convert.ToInt32(cmbEstados.SelectedValue), CampoIdentity, txtDescripcion.Text, cbxFrontera.Checked, ref msg);
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
            if (cmbPais.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPais.Focus();
                return false;
            }
            if (cmbEstados.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstados.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoRecarga()
        {
            GlobalVar.dtPaises = CatalogosSQL.Sk_Pais();
            GlobalVar.dtEstados = CatalogosSQL.Sk_Estado();
            base.BaseMetodoRecarga();
        }

        private void LlenaEstados(int K_Pais)
        {
            DataTable dtEstados = CatalogosSQL.Sk_Estado(K_Pais);
            LlenaCombo(dtEstados, ref cmbEstados, "K_Estado", "D_Estado");
        }


        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   if (cmbEstados.SelectedValue != null && cmbEstados.SelectedValue.ToString().Trim() != "System.Data.DataRowView")

        }


        private void cmbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbEstados.DataSource = null;
            cmbEstados.SelectedText = string.Empty;
            BaseDtDatos = null;
            if (cmbPais.SelectedValue != null && cmbPais.SelectedValue.ToString().Trim() != "System.Data.DataRowView")
                LlenaEstados(Convert.ToInt32(cmbPais.SelectedValue));
        }
    }
}
