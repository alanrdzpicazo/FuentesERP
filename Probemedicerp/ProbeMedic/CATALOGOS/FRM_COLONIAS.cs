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
    public partial class FRM_COLONIAS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_COLONIAS()
        {
            InitializeComponent();
            cambia_fuente_controles();
        }

        public override void BaseMetodoInicio()
        {
            BaseDtDatos = sql_Catalogos.Sk_Colonia();
            pnlControles.Enabled = false;
            CatalogoPropiedadCampoClave = "K_Colonia";
            CatalogoPropiedadCampoDescripcion = "D_Colonia";
    
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            geo_Ciudad1.Focus();
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {

            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Colonia"].ToString();
            txtDescripcion.Text = ren["D_Colonia"].ToString();
            txtCodigoPostal.Text = ren["Codigo_Postal"].ToString();
            geo_Ciudad1.K_Pais = (Int32)ren["K_Pais"];
            geo_Ciudad1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Ciudad1.K_Estado = (Int32)ren["K_Estado"];
            geo_Ciudad1.txt_G_Estado.Text = ren["D_Estado"].ToString();
            geo_Ciudad1.K_Ciudad = (Int32)ren["K_Ciudad"];
            geo_Ciudad1.txt_G_Ciudad.Text = ren["D_Ciudad"].ToString();
            geo_Ciudad1.K_Municipio = (Int32)ren["K_Municipio"];
            geo_Ciudad1.txt_G_Municipio.Text = ren["D_Municipio"].ToString();

        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCodigoPostal.Text = string.Empty;

            geo_Ciudad1.K_Pais = 0;
            geo_Ciudad1.txt_G_Pais.Text = string.Empty;
            geo_Ciudad1.K_Estado = 0;
            geo_Ciudad1.txt_G_Estado.Text = string.Empty;
            geo_Ciudad1.K_Ciudad = 0;
            geo_Ciudad1.txt_G_Ciudad.Text = string.Empty;
            geo_Ciudad1.K_Municipio = 0;
            geo_Ciudad1.txt_G_Municipio.Text = string.Empty;
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
                res = CatalogosSQL.Dl_Colonia(geo_Ciudad1.K_Ciudad, geo_Ciudad1.K_Estado,Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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
                res = CatalogosSQL.In_Colonia(geo_Ciudad1.K_Pais, geo_Ciudad1.K_Ciudad, geo_Ciudad1.K_Municipio, geo_Ciudad1.K_Estado, ref CampoIdentity, txtDescripcion.Text, Convert.ToInt32( txtCodigoPostal.Text), ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Colonia(geo_Ciudad1.K_Pais, geo_Ciudad1.K_Ciudad, geo_Ciudad1.K_Municipio, geo_Ciudad1.K_Estado, Convert.ToInt32(txtClave.Text), txtDescripcion.Text, Convert.ToInt32(txtCodigoPostal.Text), ref msg);
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
            if (geo_Ciudad1.K_Pais == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Ciudad1.txt_G_Pais.Focus();
                return false;
            }
            if (geo_Ciudad1.K_Estado== 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Ciudad1.txt_G_Estado.Focus();
                return false;
            }
            if (geo_Ciudad1.K_Ciudad== 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Ciudad1.txt_G_Ciudad.Focus();
                return false;
            }
            if (geo_Ciudad1.K_Municipio == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL MUNICIPIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Ciudad1.txt_G_Municipio.Focus();
                return false;
            }
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtCodigoPostal.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CODIGO POSTAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoPostal.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        public override void BaseBotonBuscarClick()
        {
            FILTROS.Frm_Filtra_Colonia frm = new FILTROS.Frm_Filtra_Colonia();
            frm.ShowDialog();

            BaseDtDatos = frm.dtFiltra;
            CatalogoPropiedadCampoClave = "K_Colonia";
            CatalogoPropiedadCampoDescripcion = "D_Colonia";
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar== Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigoPostal.Text.Trim().Length>0)
            {
                if(Convert.ToInt32(txtCodigoPostal.Text.Trim()) > 100000)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoPostal.Text = string.Empty;
                }
            }
        }
    }
}
