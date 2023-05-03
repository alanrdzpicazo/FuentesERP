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

namespace ProbeMedic.VENTAS
{
    public partial class Frm_RegistraMedico : FormaBase
    {
        int res = 0;
        string msg = string.Empty;
        public Int32 CampoIdentity = 0;
        public int K_Medico { get; set; }
        public string D_Medico { get; set; }

        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public Frm_RegistraMedico()
        {
            BaseBarraHerramientas.Visible = false;
            InitializeComponent();

        }
        void Limpia()
        {
            txtNom.Text = "";
            txtApeMat.Text = "";
            txtApePat.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NOMBRE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return ;
            }
            if (txtApeMat.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO MATERNO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApeMat.Focus();
                return ;
            }
            if (txtApePat.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL APELLIDO PATERNO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApePat.Focus();
                return ;
            }
            if (txtCedula.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CEDULA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return ;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TELEFONO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }
            res = sql_Catalogos.In_Medicos_Venta(ref CampoIdentity, txtNom.Text, txtApePat.Text, txtApeMat.Text,txtCedula.Text, txtTelefono.Text, ref msg);

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (res == 0)
            {
                // regerseo valor K_MEDICO 
                K_Medico = CampoIdentity;
                D_Medico =  (txtNom.Text + " "+txtApeMat.Text+" "+ txtApePat.Text);
                this.Close();

            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_RegistraMedico_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                BtnGuardar.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                BtnSalir.PerformClick();
            }
        }
    }
}
