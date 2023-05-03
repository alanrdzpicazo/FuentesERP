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

namespace ProbeMedic.CATALOGOS.ENFERMERIA
{
    public partial class FRM_ENFERMERIA : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;

        SQLCatalogos CatalogoSQL = new SQLCatalogos();

        public FRM_ENFERMERIA()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = CatalogosSQL.Sk_Precios_Enfermeria();
            CatalogoPropiedadCampoClave = "K_Precio_Enfermeria";
            CatalogoPropiedadCampoDescripcion = "D_Tipo_Enfermeria";
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
            DataTable dtDias = CatalogoSQL.Sk_Dias_Servicio();
            LlenaCombo(dtDias, ref cmbDias, "K_Dias_Servicio", "Dias");
            DataTable dtClase = CatalogoSQL.Sk_Clasificacion_Servicios_Enfermeria();
            LlenaCombo(dtClase, ref cmbClase, "K_Clase_ServicioEnfermeria", "D_Clase_ServicioEnfermeria");
            DataTable dtTipo = CatalogoSQL.Sk_Tipos_Servicios_Enfermeria();
            LlenaCombo(dtTipo, ref cmbTipos, "K_Tipo_Servicio_Enfermeria", "D_Tipo_Enfermeria");
            DataTable dtHoras = CatalogoSQL.Sk_Duracion_Servicio();
            LlenaCombo(dtHoras, ref cmbHoras, "K_Duracion_Servicio", "Horas");
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            cmbClase.SelectedIndex = -1;
            cmbDias.SelectedIndex = -1;
            cmbHoras.SelectedIndex = -1;
            cmbTipos.SelectedIndex = -1;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Precio_Enfermeria"].ToString();
            cmbClase.SelectedValue = Convert.ToInt32(ren["K_Clase_ServicioEnfermeria"]);
            cmbDias.SelectedValue = Convert.ToInt32(ren["K_Dias_Servicio"]);
            cmbHoras.SelectedValue = Convert.ToInt32(ren["K_Duracion_Servicio"]);
            cmbTipos.SelectedValue = Convert.ToInt32(ren["K_Tipo_Servicio_Enfermeria"]);
            cmbClase.Text = ren["D_Clase_ServicioEnfermeria"].ToString();
            cmbDias.Text = ren["Dias"].ToString();
            cmbHoras.Text = ren["Horas"].ToString();
            cmbTipos.Text = ren["D_Tipo_Enfermeria"].ToString();
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
                res = CatalogosSQL.Dl_Precios_Enfermeria(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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
            CatalogoPropiedadCampoClave = "K_Precio_Enfermeria";
            CatalogoPropiedadCampoDescripcion = "D_Tipo_Enfermeria";
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
                res = CatalogosSQL.In_Precios_Enfermeria(ref CampoIdentity, Convert.ToInt16(cmbDias.SelectedValue),Convert.ToInt16(cmbClase.SelectedValue), Convert.ToInt16(cmbTipos.SelectedValue), Convert.ToInt16(cmbHoras.SelectedValue), ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Precios_Enfermeria(CampoIdentity, Convert.ToInt16(cmbDias.SelectedValue), Convert.ToInt16(cmbClase.SelectedValue), Convert.ToInt16(cmbTipos.SelectedValue), Convert.ToInt16(cmbHoras.SelectedValue), ref msg);
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

            if (cmbTipos.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR EL TIPO DE ENFERMERIA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipos.Focus();
                return false;
            }

            if (cmbClase.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR LA CLASE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClase.Focus();
                return false;
            }
            if (cmbDias.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR LA CANTIDAD DE DIAS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDias.Focus();
                return false;
            }
            if (cmbHoras.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR LA CANTIDAD DE HORAS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHoras.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
    }
}
