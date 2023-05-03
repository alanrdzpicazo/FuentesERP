using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_TEMPERATURA: FormaCatalogo
    {
        public FRM_TEMPERATURA()
        {
            InitializeComponent();
        }

      
        int res = 0;
        string msg = string.Empty;
        
        Funciones fx = new Funciones();

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
          
            BaseDtDatos = sqlCatalogos.Sk_Temperatura();
            CatalogoPropiedadCampoClave = "K_Temperatura";
            CatalogoPropiedadCampoDescripcion = "D_Temperatura";


            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            
        }

        public override void BaseMetodoLimpiaControles()
        {
            //K_JefeOficina = 0;
            //txtClave.Text = string.Empty;
            //txtDescripcion.Text = string.Empty;
            //txtCorto.Text = string.Empty;
            //txtCentroCosto.Text = string.Empty;
            //txtJefeOficina.Text = string.Empty;
            //cbxFrontera.Checked = false;
            //cbxActiva.Checked = true;



            //txtCalle.Text = string.Empty;
            //txtNumInt.Text = "";
            //TxtNumExt.Text = "";

            //txtCP.Text = string.Empty;

            //txtTelefono.Text = string.Empty;
            //txtTelefono2.Text = string.Empty;
            //txtFax.Text = string.Empty;
            //tcControles.SelectTab(tpGenerales);

            /////geo_Ciudad1.LimpiaControles();

            //DeshabilitaPages(ref tcControles, false);
            //cbxActiva.Enabled = false;
            /////pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Temperatura"].ToString();
            txtDescripcion.Text = ren["D_Temperatura"].ToString();
            txtInicial.Text = ren["Inicial"].ToString();
            txtFinal.Text = ren["Final"].ToString();
            

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
                res = sqlCatalogos.Dl_Temperatura(Convert.ToInt32(CatalogoPropiedadId_Identity),GlobalVar.K_Usuario, ref msg);

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
                res = sqlCatalogos.In_Temperatura(ref CampoIdentity, txtDescripcion.Text, Convert.ToInt32(txtInicial.Text), Convert.ToInt32(txtFinal.Text), GlobalVar.K_Usuario, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Temperatura(CampoIdentity, txtDescripcion.Text, Convert.ToInt32(txtInicial.Text), Convert.ToInt32(txtFinal.Text), ref msg);

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
                    CargaTablasParciales(4);
                }
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
            if (txtInicial.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR INICIAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInicial.Focus();
                return false;
            }
            if (txtFinal.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR FINAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinal.Focus();
                return false;
            }
            if (txtFinal.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR FINAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinal.Focus();
                return false;
            }
            if(int.Parse(txtFinal.Text) > int.Parse(txtInicial.Text))
            {
                MessageBox.Show("LA CANTIDAD FINAL NO PUEDE SER MENOR A LA INICIAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinal.Focus();
                return false;

            }

            //TODO: Habilitar cuando ya sea obligatorio el campo en la tabla
      


            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoRecarga()
        {
            //GlobalVar.dtEmpleados = sqlCatalogos.sps_empleado();
            base.BaseMetodoRecarga();
        }

       
    }
}
