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
    public partial class FRM_PACIENTES_CONTACTOS : FormaCatalogo
    {
        public FRM_PACIENTES_CONTACTOS()
        {
            InitializeComponent();
         
        }

        private void FRM_PACIENTES_CONTACTOS_Load(object sender, EventArgs e)
        {
     
        }
      
        public Int32 K_Tipo_Contacto;
        public Int32 K_Tipo_Parentesco;

        //Para saber si es de proveedor o paciente
        public Boolean Tipo = false;
   
        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public override void BaseMetodoInicio()
        {
            BaseBotonModificar.Visible = false;
            txtFocus = txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            
            BaseDtDatos = sql_Catalogos.Sk_Pacientes_Contactos(PropiedadK_Paciente);
            CatalogoPropiedadCampoClave = "K_Pacientes_Contactos";
            CatalogoPropiedadCampoDescripcion = "Nombre_Contacto";

            lblPaciente.Text = PropiedadD_Paciente;

            base.BaseMetodoInicio();

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApeMat.Text = string.Empty;
            txtApePat.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCorr.Text = string.Empty;
            K_Tipo_Contacto = 0;
            K_Tipo_Parentesco = 0;
            txtTipoContacto.Text = string.Empty;
            txtTipoParentesco.Text = string.Empty;
    

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Pacientes_Contactos"].ToString();
            txtNombre.Text = ren["Nombre_Contacto"].ToString();
            txtApeMat.Text = ren["Apellido_Materno"].ToString();
            txtApePat.Text = ren["Apellido_Paterno"].ToString();
            txtTel.Text = ren["Telefono"].ToString();
            txtCorr.Text  = ren["Correo"].ToString();
            K_Tipo_Contacto = Convert.ToInt32(ren["K_Tipo_Contacto"].ToString());
            K_Tipo_Parentesco = Convert.ToInt32(ren["K_Tipo_Parentesco"].ToString());
            txtTipoContacto.Text = ren["D_Tipo_Contacto"].ToString();
            txtTipoParentesco.Text = ren["D_Tipo_Parentesco"].ToString();



        }

        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtNombre.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Contactos(Convert.ToInt32(txtClave.Text), ref msg);
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
                res = sql_Catalogos.In_Pacientes_Contactos(ref CampoIdentity, PropiedadK_Paciente, K_Tipo_Parentesco,K_Tipo_Contacto,
                   txtNombre.Text,txtApePat.Text,txtApeMat.Text,txtTel.Text,txtCorr.Text,GlobalVar.K_Usuario , ref msg);
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

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NOMBRE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
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
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO PATERNO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApePat.Focus();
                return false;
            }
            if (txtTel.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TELEFONO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return false;

            }
            if (txtTipoContacto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL TIPO DE CONTACTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarTipoContacto.Focus();
                return false;
            }
            if (txtTipoParentesco.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL TIPO DE PARENTESCO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaTipoParentesco.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void btnBuscarTipoContacto_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Contacto frm = new Busquedas.Frm_Busca_Tipo_Contacto(Tipo);
            frm.ShowDialog();

            if (K_Tipo_Contacto != frm.LLave_Seleccionado)
            {
                K_Tipo_Contacto = frm.LLave_Seleccionado;
                txtTipoContacto.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void btnBuscaTipoParentesco_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Parentesco frm = new Busquedas.Frm_Busca_Tipo_Parentesco();
            frm.ShowDialog();

            if (K_Tipo_Parentesco != frm.LLave_Seleccionado)
            {
                K_Tipo_Parentesco = frm.LLave_Seleccionado;
                txtTipoParentesco.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
