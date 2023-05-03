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

namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class Frm_Agrega_Cliente : Form
    {
        public string D_Cliente;
        public Int32 K_Cliente;
        int res = 0;
        string msg = string.Empty;
        Int32 CampoIdentity = 0;
        SQLCatalogos CatalogoSQL = new SQLCatalogos();

        public Frm_Agrega_Cliente()
        {
           
            InitializeComponent();
            txtCorto.Focus();
        }
        public void Limpia()
        {
            txtDescripcion.Text = string.Empty;
            txtComercial.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCorto.Text = string.Empty;
            txtCURP.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtURL.Text = string.Empty;
            ucCanalDistribucionCliente1.K_Canal_Distribucion = 0;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = String.Empty;

        }
            private void BtnAgergar_Click(object sender, EventArgs e)
        {
            res = 0;
            msg = string.Empty;
            res = CatalogoSQL.In_Clientes(ref CampoIdentity, txtDescripcion.Text, txtCorto.Text, txtComercial.Text, txtRFC.Text, txtCURP.Text, Convert.ToInt16(0),
                    Convert.ToDecimal(0), txtURL.Text, txtCorreo.Text, GlobalVar.K_Usuario,ucCanalDistribucionCliente1.K_Canal_Distribucion, true,1, ucTipoFiscal1.K_Tipo_Fiscal,1,0,0, ref msg);
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                D_Cliente = txtDescripcion.Text;
                K_Cliente = CampoIdentity;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpia();
            Close();

        }
    }
}
