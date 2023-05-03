using ProbeMedic.AppCode.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRM_CambiaContrasenia : Form
    {
        int res = 0;
        string msg = string.Empty;
        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public FRM_CambiaContrasenia()
        {
            InitializeComponent();
        }
    
  
        private void Valida()
        {
            if (txtNuevaContra.Text.Trim().Length > 0 && txtConfirmaContra.Text.Trim().Length > 0)
            {
                if (txtNuevaContra.Text.Trim().ToUpper() != txtConfirmaContra.Text.Trim().ToUpper())
                {
                    MessageBox.Show("CONFIRMACION DE NUEVA CONTRASEÑA INCORRECTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmaContra.Text = string.Empty;
                }
            }
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR NUEVA CONTRASEÑA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevaContra.Focus();
                return;
            }
            if (txtConfirmaContra.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CONFIRMACION DE NUEVA CONTRASEÑA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmaContra.Focus();
                return;
            }

            res = sqlSeguridad.Gp_CambiaPassword(GlobalVar.K_Usuario, txtContraActual.Text, txtNuevaContra.Text, ref msg);
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("CONTRASEÑA CAMBIADA CORRECTAMENTE...\r\n   EL SISTEMA SE CERRARA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            Application.ExitThread();
            Application.Exit();
        }

        private void FRM_CambiaContrasenia_Load_1(object sender, EventArgs e)
        {
            txtContraActual.Focus();
            pnlCaptura.Enabled = true;
            txtNuevaContra.Text = string.Empty;
            txtConfirmaContra.Text = string.Empty;

            lblD_Usuario.Text = GlobalVar.D_Usuario;
            lblLogin.Text = GlobalVar.Login;
        }

        private void FRM_CambiaContrasenia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void txtConfirmaContra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Valida();
        }

        private void txtConfirmaContra_Leave_1(object sender, EventArgs e)
        {
            Valida();
        }

        private void FRM_CambiaContrasenia_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116) //GUARDAR
                btnGuardar_Click_1(sender, e);
        }

        private void txtNuevaContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtConfirmaContra.Focus();
                Valida();
            }
        }
    }
}
