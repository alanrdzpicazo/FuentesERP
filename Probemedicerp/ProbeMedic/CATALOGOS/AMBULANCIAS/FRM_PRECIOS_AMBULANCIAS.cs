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
    public partial class FRM_PRECIOS_AMBULANCIAS : FormaCatalogo
    {
        SQLCatalogos catalogoSQL = new SQLCatalogos();

        int res = 0;
        string msg = string.Empty;
      
        Funciones fx = new Funciones();
        public FRM_PRECIOS_AMBULANCIAS()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = catalogoSQL.Sk_Precios_Ambulancia();
            CatalogoPropiedadCampoClave = "K_Precio_Ambulancia";
            CatalogoPropiedadCampoDescripcion = "D_Precio";

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            cbxLocal.Checked = false;
            cbxOxigeno.Checked = false;
            cbxSegundoPiso.Checked = false;
            cbxSencillo.Checked = false;

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Precio_Ambulancia"].ToString();
            cbxSencillo.Checked = Convert.ToBoolean(ren["B_Sencillo"]);
            cbxSegundoPiso.Checked = Convert.ToBoolean(ren["B_Segundo_Piso"]);
            cbxOxigeno.Checked = Convert.ToBoolean(ren["B_Oxigeno"]);
            cbxLocal.Checked = Convert.ToBoolean(ren["B_Local"]);
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
                res = catalogoSQL.Dl_Precios_Ambulancia(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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

            if (cbxLocal.Checked == false) 
               if (cbxOxigeno.Checked == false)
                   if (cbxSegundoPiso.Checked == false)
                      if  (cbxSencillo.Checked == false)
                        {
                            MessageBox.Show("DEBE INDICAR POR LO MENOS UNA CARACTERISTICA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = catalogoSQL.In_Precios_Ambulancia(ref CampoIdentity, cbxSencillo.Checked,cbxLocal.Checked,cbxOxigeno.Checked,cbxSegundoPiso.Checked,GlobalVar.K_Usuario, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = catalogoSQL.Up_Precios_Ambulancia(CampoIdentity, cbxSencillo.Checked, cbxLocal.Checked, cbxOxigeno.Checked, cbxSegundoPiso.Checked, GlobalVar.K_Usuario, ref msg);
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

    }
}
