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
    public partial class FRM_DIAS_FESTIVOS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_DIAS_FESTIVOS()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtMotivo; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Dias_Inhabiles();
            CatalogoPropiedadCampoClave = "K_Dias_inhabiles";
            CatalogoPropiedadCampoDescripcion = "F_Dia_inhabil";
            BaseBotonNuevo.Enabled  = true;

            base.BaseMetodoInicio();
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0; //

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Dias_Inhabiles(ref CampoIdentity, this.dtp_dia_festivo.Value, this.txtMotivo.Text,GlobalVar.K_Usuario, ref  msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Dias_Inhabiles(CampoIdentity, this.dtp_dia_festivo.Value, this.txtMotivo.Text, GlobalVar.K_Usuario, ref msg);
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
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON DESCRIPCIÓN :\n" + this.txtMotivo.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Dias_Inhabiles(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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
            this.txtMotivo.Text = string.Empty;
            this.dtp_dia_festivo.Value = DateTime.Now;

            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            this.txtClave.Text = ren["K_Dias_inhabiles"].ToString();
            this.txtMotivo.Text = ren["D_Motivo_inhabil"].ToString();
            this.dtp_dia_festivo.Value  = Convert.ToDateTime(ren["F_Dia_inhabil"].ToString());
           
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.txtMotivo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR MOTIVO DE DÍA INHÁBIL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivo.Focus();
                return false;
            }
            if (this.dtp_dia_festivo.Value < DateTime.Now )
            {
                MessageBox.Show("LA FECHA SELECCIONADA NO PUEDE SER MENOR A HOY ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtp_dia_festivo.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void dtp_dia_festivo_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_dia_festivo.Value.Year>=2079)
            {
                MessageBox.Show("FECHA NO VÁLIDA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_dia_festivo.Value = DateTime.Now;
            }
        }
    }
}
