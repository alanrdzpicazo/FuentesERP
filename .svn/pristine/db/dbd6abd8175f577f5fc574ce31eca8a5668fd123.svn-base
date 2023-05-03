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
    public partial class FRM_TIPOS_MOVIMIENTO_ALMACEN : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos CatalogoSQL = new SQLCatalogos();
        public FRM_TIPOS_MOVIMIENTO_ALMACEN()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = CatalogosSQL.Sk_Tipos_Movimiento_Almacen();
            CatalogoPropiedadCampoClave = "K_Tipo_Movimiento";
            CatalogoPropiedadCampoDescripcion = "D_Tipo_Movimiento";

            base.BaseMetodoInicio();
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
                res = sqlCatalogos.In_Tipos_Movimiento_Almacen(ref CampoIdentity,
                     txtDescripcion.Text,
                     cbxEntrada.Checked,
                     cbxSalida.Checked,
                     cbxTraspaso.Checked,
                     cbxAjuste.Checked,
                     cbxReservado.Checked,
                     GlobalVar.K_Usuario, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Tipos_Movimiento_Almacen(CampoIdentity, txtDescripcion.Text,
                    cbxEntrada.Checked,cbxSalida.Checked,cbxTraspaso.Checked,cbxAjuste.Checked,cbxReservado.Checked, GlobalVar.K_Usuario, ref msg);
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
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCatalogos.Dl_Tipos_Movimiento_Almacen(Convert.ToInt16(CatalogoPropiedadId_Identity), GlobalVar.K_Usuario, ref msg);

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

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
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
            txtDescripcion.Text = string.Empty;
            cbxEntrada.Checked = false;
            cbxSalida.Checked = false;
            cbxTraspaso.Checked = false;
            cbxAjuste.Checked = false;
            cbxReservado.Checked = false;
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Tipo_Movimiento"].ToString();
            txtDescripcion.Text = ren["D_Tipo_Movimiento"].ToString();
            cbxEntrada.Checked = Convert.ToBoolean(ren["B_Entrada"].ToString());
            cbxSalida.Checked = Convert.ToBoolean(ren["B_Salida"].ToString());
            cbxAjuste.Checked = Convert.ToBoolean(ren["B_Ajuste"].ToString());
            cbxTraspaso.Checked = Convert.ToBoolean(ren["B_Traspaso"].ToString());
            cbxReservado.Checked = Convert.ToBoolean(ren["B_Reservado"].ToString());

        }

    }
}
