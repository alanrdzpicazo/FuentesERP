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

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRM_ASIGNA_USUARIOCLIENTE : FormaBase
    {
        SQLPrecios sqlPrecios = new SQLPrecios();
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        Int32 K_Usuario_App, K_Usuario_Selecciona, K_Cliente_Sel;
        int res;
        string Mensaje;

        public FRM_ASIGNA_USUARIOCLIENTE()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;

        }
        private void BtnAsignaCliente_Click(object sender, EventArgs e)
        {

            if (grdDatos.RowCount > 0)
            {


                if ((grdDatos.CurrentRow.Cells["D_Usuario"].Value != null) || (grdDatos.CurrentRow.Cells["K_Usuario"].Value != DBNull.Value))

                {
                    if (txtCliente.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("DEBE SELECCIONAR UN CLIENTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    K_Usuario_Selecciona = int.Parse(grdDatos.CurrentRow.Cells["K_Usuario"].Value.ToString());

                    res = 0;
                    Mensaje = string.Empty;
  
                    res = sqlPrecios.UP_Cliente_UsuarioApp(K_Usuario_Selecciona, K_Cliente_Sel, ref Mensaje);
                    if (res == -1)
                    {

                        MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        K_Cliente_Sel = 0;
                        txtCliente.Text = string.Empty;
                        BaseBotonBuscarClick();

                    }


                }
                else
                {

                    MessageBox.Show("EL USUARIO TIENE UN CLIENTE ASIGNADO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            BaseBotonBuscarClick();

        }

        private void btnEliminaCliente_Click(object sender, EventArgs e)
        {
            if (grdDatos.RowCount > 0)
            {

                if ((grdDatos.CurrentRow.Cells["K_Cliente"].Value != null) || (grdDatos.CurrentRow.Cells["K_Cliente"].Value != DBNull.Value))

                {
                    K_Usuario_Selecciona = int.Parse(grdDatos.CurrentRow.Cells["K_Usuario"].Value.ToString());

                    res = 0;
                    Mensaje = string.Empty;
    
                    res = sqlPrecios.Dl_Cliente_UsuarioApp(K_Usuario_Selecciona, ref Mensaje);
                    if (res == -1)
                    {

                        MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BaseBotonBuscarClick();


                    }


                }
                else
                {

                    MessageBox.Show("EL USUARIO NO TIENE UN CLIENTE ASIGNADO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            K_Cliente_Sel = 0;

            Busquedas.Frm_Busca_Cliente frm = new Busquedas.Frm_Busca_Cliente(GlobalVar.K_Empresa);
            frm.ShowDialog();
            K_Cliente_Sel = frm.LLave_Seleccionado;
            txtCliente.Text = frm.Descripcion_Seleccionado;

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            K_Usuario_App = 0;

            Busquedas.Frm_Busca_Usuario frm = new Busquedas.Frm_Busca_Usuario();
            frm.ShowDialog();
            K_Usuario_App = frm.LLave_Seleccionado;
            txtUsuario.Text = frm.Descripcion_Seleccionado;
        }
        public override void BaseBotonBuscarClick()
        {

            DataTable datos = new DataTable();

            datos = sqlPrecios.SK_Clientes_Apps(txtUsuario.Text, txtCorreo.Text);
            if (datos == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (datos.Rows.Count > 0)
            {
                grdDatos.DataSource = datos;

            }
            else
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
