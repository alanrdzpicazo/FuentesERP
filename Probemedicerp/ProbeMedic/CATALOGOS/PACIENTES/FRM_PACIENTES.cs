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
using ProbeMedic.CATALOGOS.LABORATORIOS;

namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_PACIENTES : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;

        public string Nombre, RFC, CURP;
        
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_PACIENTES()
        {
            InitializeComponent();
        }
        private void FRM_PACIENTES_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtNombre; //Asignar el textbox que inicia el focus
            pnlControl.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Pacientes_Top(0,0,string.Empty,0,0,0,0,0,0);
            CatalogoPropiedadCampoClave = "K_Paciente";
            CatalogoPropiedadCampoDescripcion = "Nombre_Completo";


            base.BaseMetodoInicio();
            cambia_fuente_controles();
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBuscar.Visible = true;
   
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
                res = sql_Catalogos.In_Pacientes(ref CampoIdentity, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtRFC.Text, txtCurp.Text,
                   ucTPacientes1.K_TipoPaciente, ucGeneros2.K_Genero, ucNacionalidad2.K_Nacionalidad, ucEstadoCivil3.K_Estado_Civil,ucTipoSangre1.K_TipoSangre,
                   ucCelulas1.K_Celula, ucTiposPoliza1.K_TipoPoliza, txtPoliza.Text, txtReclamacion.Text , txtSiniestro.Text, Convert.ToInt16(txtCoaseguro.Text), 
                   cbxVIP.Checked,txtK_Cliente.Text.Trim().Length > 0 ? Convert.ToInt32(txtK_Cliente.Text.Trim()) : 0, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = sql_Catalogos.Up_Pacientes(CampoIdentity, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtRFC.Text, txtCurp.Text,
                   ucTPacientes1.K_TipoPaciente, ucGeneros2.K_Genero, ucNacionalidad2.K_Nacionalidad, ucEstadoCivil3.K_Estado_Civil, ucTipoSangre1.K_TipoSangre,
                   ucCelulas1.K_Celula, ucTiposPoliza1.K_TipoPoliza, txtPoliza.Text, txtReclamacion.Text, txtSiniestro.Text, Convert.ToInt16(txtCoaseguro.Text), 
                   cbxVIP.Checked, txtK_Cliente.Text.Trim().Length > 0 ? Convert.ToInt32(txtK_Cliente.Text.Trim()) : 0, ref msg);
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
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtNombre.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NOMBRE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (txtMaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO MATERNO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaterno.Focus();
                return false;
            }
            if (txtPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO PATERNO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (txtRFC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL RFC ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (txtCurp.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CURP ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurp.Focus();
                return false;
            }
            if (ucTiposPoliza1.K_TipoPoliza == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE POLIZA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTiposPoliza1.Focus();
                return false;
            }
            if (txtReclamacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA RECLAMACIÓN ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReclamacion.Focus();
                return false;
            }
            if (txtSiniestro.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL SINIESTRO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSiniestro.Focus();
                return false;
            }
            if (ucCelulas1.K_Celula == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CELULA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCelulas1.Focus();
                return false;
            }
            if (ucTPacientes1.K_TipoPaciente == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE PACIENTE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTPacientes1.Focus();
                return false;
            }
            if (ucTipoSangre1.K_TipoSangre == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE SANGRE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoSangre1.Focus();
                return false;
            }
            if (ucNacionalidad2.K_Nacionalidad == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA NACIONALIDAD ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucNacionalidad2.Focus();
                return false;
            }
            if (ucGeneros2.K_Genero == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL GENERO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucGeneros2.Focus();
                return false;
            }
            if (ucEstadoCivil3.K_Estado_Civil == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ESTADO CIVIL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucEstadoCivil3.Focus();
                return false;
            }
            if  (txtCoaseguro.Text == "")
            {
                txtCoaseguro.Text = "0";
            }
            BaseErrorResultado = false;
            return true;
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControl.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMaterno.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtCurp.Text = string.Empty;
            txtPoliza.Text = string.Empty;
            txtReclamacion.Text = string.Empty;
            txtSiniestro.Text = string.Empty;
            txtCoaseguro.Text = "0";
            ucTiposPoliza1.K_TipoPoliza = 0;
            ucTiposPoliza1.txt_D_TipoPoliza.Text = string.Empty;
            ucTiposPoliza1.K_TipoPoliza = 0;
            ucTiposPoliza1.txt_D_TipoPoliza.Text = string.Empty;
            ucCelulas1.K_Celula = 0;
            ucCelulas1.txt_D_Celula.Text = string.Empty;
            ucTPacientes1.K_TipoPaciente = 0;
            ucTPacientes1.txt_D_TipoPaciente.Text = string.Empty;
            ucTipoSangre1.K_TipoSangre = 0;
            ucTipoSangre1.txt_D_TipoSangre.Text = string.Empty;
            ucNacionalidad2.K_Nacionalidad = 0;
            ucNacionalidad2.txt_D_Nacionalidad.Text = string.Empty;
            ucGeneros2.K_Genero = 0;
            ucGeneros2.txt_D_Genero.Text = string.Empty;
            ucEstadoCivil3.K_Estado_Civil = 0;
            ucEstadoCivil3.txt_D_EstadoCivil.Text = string.Empty;
            cbxVIP.Checked = false;
            txtK_Cliente.Text = String.Empty;
            txtD_Cliente.Text = String.Empty;
            pnlControl.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Paciente"].ToString();
            txtNombre.Text = ren["Nombre"].ToString();
            txtMaterno.Text = ren["ApeMat"].ToString();
            txtPaterno.Text = ren["ApePat"].ToString();
            txtRFC.Text = ren["RFC"].ToString();
            txtCurp.Text = ren["CURP"].ToString();
            ucTiposPoliza1.K_TipoPoliza = Convert.ToInt32(ren["K_Tipo_Poliza"]);
            ucTiposPoliza1.txt_D_TipoPoliza.Text = ren["D_Tipo_Poliza"].ToString();
            txtPoliza.Text = ren["Poliza"].ToString();
            txtReclamacion.Text = ren["Reclamacion"].ToString();
            txtSiniestro.Text = ren["Siniestro"].ToString();
            txtCoaseguro.Text = ren["Coaseguroporcentaje"].ToString();
            ucCelulas1.K_Celula = Convert.ToInt32(ren["K_Celula"]);
            ucCelulas1.txt_D_Celula.Text = ren["D_Celula"].ToString();
            if(ren["K_Cliente"].ToString() != "")
            {
                txtK_Cliente.Text = ren["K_Cliente"].ToString();
                txtD_Cliente.Text = ren["D_Cliente"].ToString();
            }
            else
            {
                txtK_Cliente.Text = string.Empty;
                txtD_Cliente.Text = string.Empty;
            }
            ucTPacientes1.K_TipoPaciente = Convert.ToInt32(ren["K_Tipo_Paciente"]);
            ucTPacientes1.txt_D_TipoPaciente.Text = ren["D_Tipo_Paciente"].ToString();
            ucTipoSangre1.K_TipoSangre = Convert.ToInt32(ren["K_Tipo_Sangre"]);
            ucTipoSangre1.txt_D_TipoSangre.Text = ren["D_Tipo_Sangre"].ToString();
            ucNacionalidad2.K_Nacionalidad = Convert.ToInt32(ren["K_Nacionalidad"]);
            ucNacionalidad2.txt_D_Nacionalidad.Text = ren["D_Nacionalidad"].ToString();
            ucGeneros2.K_Genero = Convert.ToInt32(ren["K_Genero"]);
            ucGeneros2.txt_D_Genero.Text = ren["D_Genero"].ToString();
            ucEstadoCivil3.K_Estado_Civil = Convert.ToInt32(ren["K_Estado_Civil"]);
            ucEstadoCivil3.txt_D_EstadoCivil.Text = ren["D_Estado_Civil"].ToString();
            cbxVIP.Checked = Convert.ToBoolean(ren["B_VIP"].ToString());
            if (txtCoaseguro.Text != null) 
            {
               txtK_Cliente.Text = ren["K_Cliente"].ToString();
               txtD_Cliente.Text = ren["D_Cliente"].ToString();
            }
        }

        private void txtCoaseguro_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtCoaseguro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCoaseguro.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(txtCoaseguro.Text.Trim()) > 100)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCoaseguro.Text = "0";
                        txtCoaseguro.Focus();
                        return;
                    }
                }
            }
            catch(Exception ex) { }

            if ((txtCoaseguro.Text != null) && (txtCoaseguro.Text != "" ))
            {

                if( Convert.ToInt32(txtCoaseguro.Text) > 0)
                {
                    txtK_Cliente.Visible = true;
                    txtD_Cliente.Visible = true;
                    BtnAgregar.Visible = true;
                    BtnBuscar.Visible = true;
                    LblCliente.Visible = true;
                }
                else
                {
                    txtK_Cliente.Visible = false;
                    txtD_Cliente.Visible = false;
                    BtnAgregar.Visible = false;
                    BtnBuscar.Visible = false;
                    LblCliente.Visible = false;
                }
            }
            else
            {
                txtK_Cliente.Visible = false;
                txtD_Cliente.Visible = false;
                BtnAgregar.Visible = false;
                BtnBuscar.Visible = false;
                LblCliente.Visible = false;
            }
        }
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_MEDICOS frm = new FRM_PACIENTES_MEDICOS();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text +" "+ txtPaterno.Text +" "+ txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void btnContacto_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;
      
            FRM_PACIENTES_CONTACTOS frm = new FRM_PACIENTES_CONTACTOS();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void btnPadecimienti_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_PADECIMIENTO frm = new FRM_PACIENTES_PADECIMIENTO();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void BtnProgramas_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PROGRAMA_PACIENTES frm = new FRM_PROGRAMA_PACIENTES();
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void btnInstituciones_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_INSTITUCIONES frm = new FRM_PACIENTES_INSTITUCIONES();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en las institucion se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_TELEFONOS frm = new FRM_PACIENTES_TELEFONOS();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en las institucion se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void BtnDirecciones_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_DIRECCIONES frm = new FRM_PACIENTES_DIRECCIONES();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en las institucion se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void BtnMedicamentos_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_MEDICAMENTOS frm = new FRM_PACIENTES_MEDICAMENTOS();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en las institucion se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void BtnNotas_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_NOTAS frm = new FRM_PACIENTES_NOTAS();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en las institucion se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        private void BtnCorreos_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PACIENTES_CORREOS frm = new FRM_PACIENTES_CORREOS();
            frm.PropiedadK_Paciente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Paciente = txtNombre.Text + " " + txtPaterno.Text + " " + txtMaterno.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en las institucion se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(0);
            filtra.ShowDialog();
            if (filtra.K_Cliente_Seleccionado == 0)
            {
                txtK_Cliente.Text = string.Empty;
                txtD_Cliente.Text = string.Empty;
            }
            else if (filtra.K_Cliente_Seleccionado != 0 && filtra.D_Cliente_Seleccionado != "")
            {
                txtK_Cliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
                txtD_Cliente.Text = filtra.D_Cliente_Seleccionado;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Frm_Agrega_Cliente frm = new Frm_Agrega_Cliente();
            frm.txtDescripcion.Text = txtNombre.Text + ' ' + txtMaterno.Text + ' ' + txtPaterno.Text;
            frm.txtRFC.Text = txtRFC.Text;
            frm.txtCURP.Text = txtCurp.Text;
            frm.ShowDialog();
            if (frm.K_Cliente == 0)
            {
                txtK_Cliente.Text = string.Empty;
                txtD_Cliente.Text = string.Empty;
            }
            else if (frm.K_Cliente != 0 && frm.D_Cliente != "")
            {
                txtK_Cliente.Text = Convert.ToString(frm.K_Cliente);
                txtD_Cliente.Text = frm.D_Cliente;
            }
           
        }

        private void txtNoExterior_KeyPress(object sender, KeyPressEventArgs e)
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


        public override void BaseBotonBuscarClick()
        {
            FILTROS.Frm_Filtra_Paciente frm = new FILTROS.Frm_Filtra_Paciente();
            frm.ShowDialog();

            if(frm.dtFiltra!=null)
            {
                if (frm.dtFiltra.Rows.Count > 0)
                {
                    BaseDtDatos = frm.dtFiltra;
                    CatalogoPropiedadCampoClave = "K_Paciente";
                    CatalogoPropiedadCampoDescripcion = "Nombre_Completo";
                    base.BaseMetodoInicio();
                    BaseBotonBuscar.Visible = true;
                }
            }
          

        }



    }
}
