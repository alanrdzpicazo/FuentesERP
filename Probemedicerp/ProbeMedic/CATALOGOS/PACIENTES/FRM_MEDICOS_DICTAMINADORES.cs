﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_MEDICOS_DICTAMINADORES : FormaCatalogo
    {
        public FRM_MEDICOS_DICTAMINADORES()
        {
            InitializeComponent();
        }

        private void FRM_MEDICOS_DICTAMINADORES_Load(object sender, EventArgs e)
        {

        }
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public override void BaseMetodoInicio()
        {
            txtFocus = txtNom; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Medicos_Dictaminadores();
            CatalogoPropiedadCampoClave = "K_Medico_Dictaminador";
            CatalogoPropiedadCampoDescripcion = "D_Medico";

            base.BaseMetodoInicio();

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
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

                res = sql_Catalogos.In_Medicos_Dictaminadores(ref CampoIdentity, txtNom.Text, txtApePat.Text, txtApeMat.Text,ucAseguradora1.K_Aseguradora, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sql_Catalogos.Up_Medicos_Dictaminadores(CampoIdentity, txtNom.Text, txtApePat.Text, txtApeMat.Text,ucAseguradora1.K_Aseguradora, ref msg);
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
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtNom.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Medicos_Dictaminadores(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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

            if (txtNom.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NOMBRE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }
            if (txtApeMat.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO MATERNO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApeMat.Focus();
                return false;
            }
            if (txtApePat.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO PATERNO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApePat.Focus();
                return false;
            }
            if (ucAseguradora1.K_Aseguradora == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UNA ASEGURADORA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucAseguradora1.Focus();
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
            txtNom.Text = string.Empty;
            txtApeMat.Text = string.Empty;
            txtApePat.Text = string.Empty;
            ucAseguradora1.K_Aseguradora = 0;
            ucAseguradora1.txt_Z_Aseguradora.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Medico_Dictaminador"].ToString();
            txtNom.Text = ren["Nombre"].ToString();
            txtApeMat.Text = ren["ApeMat"].ToString();
            txtApePat.Text = ren["ApePat"].ToString();
            ucAseguradora1.K_Aseguradora = Convert.ToInt32(ren["K_Aseguradora"].ToString());
            ucAseguradora1.txt_Z_Aseguradora.Text = ren["D_Aseguradora"].ToString();
        }
    }
}
