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

namespace ProbeMedic.CXP
{
    public partial class Frm_Usuarios_AutCXP : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLCuentasxPagar sql_CXP = new SQLCuentasxPagar();
        DataTable dtAlmacenesXUsuario = new DataTable();
        public Frm_Usuarios_AutCXP()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = SeguridadSQL.Sk_Usuario();
            CatalogoPropiedadCampoClave = "K_Usuario";
            CatalogoPropiedadCampoDescripcion = "D_Usuario";
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonBorrar.Visible  = false;
            BaseBotonBorrar.Enabled  = false;
            BaseBotonExcel.Visible   = false;
            BaseBotonExcel.Enabled   = false;
            BaseBotonNuevo.Visible   = false;
            BaseBotonNuevo.Enabled   = false;
            base.BaseMetodoInicio();
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
                res = sql_Catalogos.Dl_Pais(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);

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
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;


            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Usuario"].ToString();
            txtDescripcion.Text = ren["D_Usuario"].ToString();
            Motivos();

        }


        private void ucMotivo_Autoriza1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL USUARIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ucMotivo_Autoriza1.K_Motivo_Autoriza == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL MOTIVO DE AUTORIZACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            res = sql_CXP.In_Usuario_Anticipo_Pago(Convert.ToInt32(txtClave.Text), ucMotivo_Autoriza1.K_Motivo_Autoriza, ref msg);
            Motivos();

            if (res == -1)
            {
                BaseErrorResultado = true;
                DialogResult DialogResult = MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK);
            }
        }
        private void Motivos()
        {
            DataTable dtMotivos = new DataTable();
            dtMotivos = sql_CXP.SK_Usuarios_AsignadosAntPagos(Convert.ToInt32(txtClave.Text));
            grdMotivos.DataSource = dtMotivos;

        }

    }
}
