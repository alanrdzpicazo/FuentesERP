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


namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_MEDICOS : FormaCatalogo
    {
        public FRM_MEDICOS()
        {
            InitializeComponent();
        }

        private void FRM_MEDICOS_Load(object sender, EventArgs e)
        {
        }
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public override void BaseMetodoInicio()
        {
            txtFocus = txtNom; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Medicos();
            CatalogoPropiedadCampoClave = "K_Medico";
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
    
                res = sql_Catalogos.In_Medicos(ref CampoIdentity,usProfesion1.K_Profesion,usEspecialidad1.K_Especialidad, txtNom.Text, txtApePat.Text,txtApeMat.Text,
                    txtCedula.Text,txtTelefono.Text,txtCorreo.Text,cbxTratante.Checked,
                    cbxDictaminador.Checked,GlobalVar.K_Usuario,ucAseguradora1.K_Aseguradora,cbxRedAseguradora.Checked  ,ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sql_Catalogos.Up_Medicos(CampoIdentity, usProfesion1.K_Profesion, usEspecialidad1.K_Especialidad, txtNom.Text, txtApePat.Text, txtApeMat.Text,
                    txtCedula.Text, txtTelefono.Text, txtCorreo.Text, cbxTratante.Checked,
                    cbxDictaminador.Checked, Convert.ToInt32(GlobalVar.K_Usuario),ucAseguradora1.K_Aseguradora,cbxRedAseguradora.Checked, ref msg);
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
                res = sql_Catalogos.Dl_Medicos(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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
            if (usProfesion1.K_Profesion == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ESPECIALIDAD ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usProfesion1.Focus();
                return false;
            }
            if (usEspecialidad1.K_Especialidad == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ESPECIALIDAD ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usEspecialidad1.Focus();
                return false;
            }
            if (txtCedula.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CEDULA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }
         
         
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TELEFONO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CORREO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }
            if (cbxDictaminador.Checked == true && ucAseguradora1.K_Aseguradora == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR LA ASEGURADORA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucAseguradora1.Focus();
                return false;
            }
            if (cbxDictaminador.Checked == true && cbxRedAseguradora.Checked == false)
            {
                MessageBox.Show("LA RED ASEGURADORA DEBE DE ESTAR ACTIVADA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxRedAseguradora.Focus();
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
            usProfesion1.K_Profesion = 0;
            usProfesion1.txt_D_Profesion.Text = string.Empty;
            usEspecialidad1.K_Especialidad= 0;
            usEspecialidad1.txt_D_Especialidad.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            cbxTratante.Checked = false;
            cbxDictaminador.Checked = false;
            cbxRedAseguradora.Checked = false;
            ucAseguradora1.K_Aseguradora = 0;
            ucAseguradora1.txt_Z_Aseguradora.Text = string.Empty;

   
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Medico"].ToString();
            txtNom.Text = ren["Nombre"].ToString();
            txtApeMat.Text = ren["ApeMat"].ToString();
            txtApePat.Text = ren["ApePat"].ToString();

            if(ren["K_Profesion"].ToString() != "")
            {
                usProfesion1.K_Profesion = Convert.ToInt32(ren["K_Profesion"]);
                usProfesion1.txt_D_Profesion.Text = ren["D_Profesion"].ToString();

            }
            else
            {
                usProfesion1.K_Profesion = 0;
                usProfesion1.txt_D_Profesion.Text = string.Empty;
            }

            if (ren["K_Especialidad"].ToString() != "")
            {
                usEspecialidad1.K_Especialidad = Convert.ToInt32(ren["K_Especialidad"]);
                usEspecialidad1.txt_D_Especialidad.Text = ren["D_Especialidad"].ToString();
            }
            else
            {
                usEspecialidad1.K_Especialidad = 0;
                usEspecialidad1.txt_D_Especialidad.Text = "";
            }

            txtCedula.Text = ren["Cedula"].ToString();
            txtTelefono.Text = ren["Telefono"].ToString();
            txtCorreo.Text = ren["Correo"].ToString();
            cbxDictaminador.Checked = Convert.ToBoolean(ren["B_Dictaminador"].ToString());
            cbxTratante.Checked = Convert.ToBoolean(ren["B_Tratante"].ToString());
            cbxRedAseguradora.Checked = Convert.ToBoolean(ren["B_Red_Aseguradora"].ToString());
            ucAseguradora1.K_Aseguradora = ren["K_Aseguradora"].ToString() != ""? Convert.ToInt32(ren["K_Aseguradora"]) : 0;
            ucAseguradora1.txt_Z_Aseguradora.Text = ren["D_Aseguradora"].ToString() != "" ? ren["D_Aseguradora"].ToString() : "";
        }

        private void cbxDictaminador_CheckedChanged(object sender, EventArgs e)
        {
            cbxRedAseguradora.Checked = true;

            if (cbxDictaminador.Checked == false)
                cbxRedAseguradora.Checked = false;
           

        }
    }
}
