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
    public partial class FRM_PROGRAMAS : FormaCatalogo
    {
        public FRM_PROGRAMAS()
        {
            InitializeComponent();
        }

        private void FRM_PROGRAMAS_Load(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
        }

        int res = 0;

        string msg = string.Empty;

        SQLCatalogos CatalogoSQL = new SQLCatalogos();

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = CatalogoSQL.Sk_Programas();
            CatalogoPropiedadCampoClave = "K_Programa";
            CatalogoPropiedadCampoDescripcion = "D_Programa";
            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCorto.Text = string.Empty;
            txtDesc.Text = string.Empty;
            ucLaboratorio1.txt_L_D_Laboratorio.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Programa"].ToString();
            txtDescripcion.Text = ren["D_Programa"].ToString();
            txtCorto.Text = ren["C_Programa"].ToString();
            txtDesc.Text = ren["Descripcion"].ToString();
            ucLaboratorio1.K_Laboratorio = Convert.ToInt32(ren["K_Laboratorio"].ToString());
            ucLaboratorio1.txt_L_D_Laboratorio.Text = ren["D_Laboratorio"].ToString();


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
                res = CatalogosSQL.Dl_Programas(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);
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
            short CampoIdentity = 0;
            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = CatalogosSQL.In_Programas(ref CampoIdentity, ucLaboratorio1.K_Laboratorio,txtDescripcion.Text,txtCorto.Text,txtDesc.Text, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Programas(CampoIdentity,ucLaboratorio1.K_Laboratorio, txtDescripcion.Text, txtCorto.Text, txtDesc.Text,ref msg);
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
                CargaTablasParciales(3);
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
            if (txtCorto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION CORTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorto.Focus();
                return false;
            }
            if (ucLaboratorio1.txt_L_D_Laboratorio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN LABORATORIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucLaboratorio1.Focus();
                return false;
            }
            if (txtDesc.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();
                return false;
            }
            
            BaseErrorResultado = false;
            return true;
        }
        
    }
}
