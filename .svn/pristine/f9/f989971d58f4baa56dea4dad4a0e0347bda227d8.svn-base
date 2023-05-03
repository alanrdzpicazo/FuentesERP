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

namespace ProbeMedic.CUENTASXCOBRAR
{
    public partial class FRM_BUSCA_FACTURA : FormaBase
    {
        int res = -1;
        string msg = string.Empty;
        SQLCuentasxCobrar sql_CXC = new SQLCuentasxCobrar();
        public int K_Cliente;
        public string D_Cliente;

        public DataGridViewRow row;

        public FRM_BUSCA_FACTURA()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {

            base.BaseMetodoInicio();
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;

        }

        private void FRM_BUSCA_FACTURA_Shown(object sender, EventArgs e)
        {
            txtK_Cliente.Text = Convert.ToString(K_Cliente);
            txtD_Cliente.Text = D_Cliente;
            res = 0;
            msg = string.Empty;

            if (txtK_Cliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CIRCUITO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaseDtDatos = sql_CXC.Sk_Facturas_PendientesPago(ucOficinas1.K_Oficina, Convert.ToInt32(txtK_Cliente.Text));
            grd_Datos.DataSource = BaseDtDatos;


        }

        private void grd_Datos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            row = grd_Datos.CurrentRow;
            if(row!=null)
            {
               row = grd_Datos.CurrentRow;
            }

            this.Close();

        }

        private void txtK_Factura_TextChanged(object sender, EventArgs e)
        {
            BaseDtDatos.DefaultView.RowFilter = $"Factura  LIKE '%{txtK_Factura.Text}%'";
        }

        public override void BaseBotonBuscarClick()
        {
            if (txtK_Cliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CIRCUITO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaseDtDatos = sql_CXC.Sk_Facturas_PendientesPago(ucOficinas1.K_Oficina, Convert.ToInt32(txtK_Cliente.Text));
            
            grd_Datos.DataSource = BaseDtDatos;

        }

    }
}
