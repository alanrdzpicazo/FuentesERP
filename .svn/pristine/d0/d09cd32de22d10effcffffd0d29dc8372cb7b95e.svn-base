using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.SEGURIDAD
{
    public partial class USUARIO_BLOQUEADO : FormaBase
    {
        SQLSeguridad SQL = new SQLSeguridad();
        int res = -1;
        public USUARIO_BLOQUEADO()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {

            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;


        }

        private void btnLibera_Click(object sender, EventArgs e)
        {
            if (ucUsuario1.K_Usuario != 0)
            {
                if (ucUsuario1.K_Usuario == GlobalVar.K_Usuario)
                {
                    MessageBox.Show("NO PUEDE LIBERAR SU PROPIO USUARIO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                res = SQL.GP_LIBERA_USUARIO(ucUsuario1.K_Usuario);

                if (res == 0)
                {
                    MessageBox.Show("USUARIO LIBERADO CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("EL USUARIO NO SE ENCUENTRA DENTRO DEL SISTEMA, VERIFIQUE.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN USUARIO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucUsuario1.Focus();
            }
        }
    }
}
