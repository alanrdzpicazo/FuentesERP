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

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtra_Cliente_Catalogo : Frm_Filtro
    {
        public DataTable dtFiltra = new DataTable();
        public DataTable dtFiltra2 = new DataTable();
        SQLCatalogos sql_catalogo = new SQLCatalogos();
        public Frm_Filtra_Cliente_Catalogo()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (dtFiltra != null)
            {
                if (dtFiltra.Rows.Count > 0)
                {
                    dtFiltra.Rows.Clear();
                }
            }
            if (txt_D_Cliente.Text.Trim() == "")
            {
                txt_D_Cliente.Text = null;
            }

            if ((txtClave.valor.Text.Trim().Length>0)||(ucTipoFiscal1.K_Tipo_Fiscal> 0) || (usEstatusCliente1.K_Estatus_Cliente > 0) || (ucCanalDistribucionCliente1.K_Canal_Distribucion > 0) || txt_D_Cliente.Text != null)
            {
                dtFiltra = sql_catalogo.Sk_Clientes(GlobalVar.K_Empresa, txtClave.valor.Text.Length>0 ? Convert.ToInt32(txtClave.valor.Text):0,txt_D_Cliente.Text.Trim(),ucTipoFiscal1.K_Tipo_Fiscal,usEstatusCliente1.K_Estatus_Cliente,ucCanalDistribucionCliente1.K_Canal_Distribucion);

                if (dtFiltra != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("NO EXISTEN CLIENTES CON LOS PARAMETROS INDICADOS ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_Filtra_Cliente_Catalogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                BtnBuscar.PerformClick();

            }
        }
    }
}
