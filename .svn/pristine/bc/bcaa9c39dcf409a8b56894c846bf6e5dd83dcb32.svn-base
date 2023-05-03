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
    public partial class FRM_MUNICIPIO : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();


        public FRM_MUNICIPIO()
        {
            InitializeComponent();
            cambia_fuente_controles();
        }


        public override void BaseMetodoInicio()
        {
            geo_Pais1.Focus(); //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = sql_Catalogos.Sk_Municipio_Delegacion();
            CatalogoPropiedadCampoClave = "K_Municipio";
            CatalogoPropiedadCampoDescripcion = "D_Municipio";
            base.BaseMetodoInicio();
            //BaseBotonBuscar.Visible = true;

        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
             pnlControles.Enabled = B_Habilita;
             geo_Pais1.Focus();
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            
            BaseMetodoLimpiaControles();
            sql_Catalogos.Sk_Municipio_Delegacion(Convert.ToInt32(ren["K_Pais"]), Convert.ToInt32(ren["K_Estado"]), Convert.ToInt32(ren["K_Municipio"]));
            txtClave.Text = Convert.ToString(ren["K_Municipio"]); 
            txt_Municipio.Text = ren["D_Municipio"].ToString();
            geo_Pais1.K_Pais= Convert.ToInt32(ren["K_Pais"]);
            geo_Pais1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Pais1.K_Estado = Convert.ToInt32(ren["K_Estado"]);
            geo_Pais1.txt_G_Estado.Text = ren["D_Estado"].ToString();


        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txt_Municipio.Text = string.Empty;

         
            geo_Pais1.K_Pais = 0;
            geo_Pais1.txt_G_Pais.Text = string.Empty;
            geo_Pais1.K_Estado = 0;
            geo_Pais1.txt_G_Estado.Text = string.Empty;

        }


        public override void BaseBotonBorrarClick()
        {
            int CampoIdentity = 0;
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txt_Municipio.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Dl_Municipio_Delegacion(geo_Pais1.K_Pais, geo_Pais1.K_Estado, CampoIdentity, ref msg); ;

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
                res = CatalogosSQL.In_Municipio_Delegacion(geo_Pais1.K_Pais, geo_Pais1.K_Estado, ref CampoIdentity, txt_Municipio.Text, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Municipio_Delegacion(geo_Pais1.K_Pais, geo_Pais1.K_Estado, CampoIdentity, txt_Municipio.Text, ref msg);
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

        private void geo_Pais1_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void geo_Pais1_BindingContextChanged(object sender, EventArgs e)
        {
           
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txt_Municipio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Municipio.Focus();
                return false;
            }
            if (geo_Pais1.K_Pais == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Pais1.txt_G_Pais.Focus();
                return false;
            }
            if (geo_Pais1.K_Estado == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Pais1.txt_G_Estado.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

    


    }
}
