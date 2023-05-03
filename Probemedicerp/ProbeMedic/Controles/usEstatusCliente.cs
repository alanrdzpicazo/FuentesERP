using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.Controles
{
    public partial class usEstatusCliente : UserControl
    {

        public Int32 K_Estatus_Cliente = 0;
        public TextBox D_Estatus
        {
            get { return this.txt_D_Estatus; }
        }

        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        public usEstatusCliente()
        {
            InitializeComponent();
        }

        private void btn_TipoFiscal_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_EstatusCliente frm = new Busquedas.Frm_Busca_EstatusCliente();
            frm.ShowDialog();

            if (K_Estatus_Cliente != frm.LLave_Seleccionado)
            {
               K_Estatus_Cliente = frm.LLave_Seleccionado;
                txt_D_Estatus.Text = frm.Descripcion_Seleccionado;
            }
        }
    }
}
