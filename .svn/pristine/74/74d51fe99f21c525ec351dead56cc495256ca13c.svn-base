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
    public partial class FRM_CAMBIA_OFICINA : FormaBase
    {
        SQLCatalogos sql_catalogos = new SQLCatalogos();
        int res = 0;
        string msg = string.Empty;
        public FRM_CAMBIA_OFICINA()
        {
            InitializeComponent();
           
        }

        public override void BaseMetodoInicio()
        {
            ucOficinas1.Focus();
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;

            txtClaveUsuario.Text = GlobalVar.K_Usuario.ToString();
            txtUsuario.Text = GlobalVar.D_Usuario;
            txtClaveOficinaActual.Text = GlobalVar.K_Oficina.ToString();
            txtOficinaActual.Text = GlobalVar.D_Oficina;
            ucOficinas1.K_Empresa = GlobalVar.K_Empresa;

        }

        public override void BaseBotonAfectarClick()
        {
            if(ucOficinas1.K_Oficina == 0)
            {
                MessageBox.Show("DEBE INDICAR LA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucOficinas1.Focus();
                return;
            }


            res = 0;
            msg = string.Empty;

            res = sqlCatalogos.Gp_CambiaOficina(GlobalVar.K_Usuario, GlobalVar.K_Oficina,
                  ucOficinas1.K_Oficina, ref msg);

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
                Application.ExitThread();
                Application.Exit();

            }
        }
    }
}
