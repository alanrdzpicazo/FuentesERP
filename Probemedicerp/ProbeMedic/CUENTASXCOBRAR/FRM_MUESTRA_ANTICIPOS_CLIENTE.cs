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
    public partial class FRM_MUESTRA_ANTICIPOS_CLIENTE : FormaConsulta
    {
        public int K_Cliente;

        SQLCuentasxCobrar  sqlCXC = new SQLCuentasxCobrar();
        DataTable dtDatos = new DataTable();

        public Int32 K_Anticipo { get; set; }
        public decimal Monto { get; set; }
        public FRM_MUESTRA_ANTICIPOS_CLIENTE()
        {
            InitializeComponent();
        }
        public void LlenaDatos()
        {
            this.dbgDatos.DataSource = null;
            dtDatos = this.sqlCXC.Gp_Trae_AnticiposCliente(K_Cliente);
            BaseDtDatos = dtDatos;

            dbgDatos.DataSource = dtDatos;
        }

        private void FRM_MUESTRA_ANTICIPOS_CLIENTE_Load(object sender, EventArgs e)
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
        }
        public override void BaseBotonExcelClick()
        {
            Cursor = Cursors.WaitCursor;
            base.BaseBotonExcelClick();
            Cursor = Cursors.Default;
        }

        private void dbgDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                dbgDatos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = dbgDatos.CurrentRow;
                if (row == null)
                    return;


                K_Anticipo = Convert.ToInt32(dbgDatos.CurrentRow.Cells["K_Anticipo_Cliente"].Value.ToString());
                Monto      = Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Total"].Value.ToString());
                this.Close();
            }
        }

        private void dbgDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            DataGridViewRow row = dbgDatos.CurrentRow;
            if (row == null)
                return;


            K_Anticipo = Convert.ToInt32(dbgDatos.CurrentRow.Cells["K_Anticipo_Cliente"].Value.ToString());
            Monto = Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Total"].Value.ToString());
            this.Close();
        }
    }
}
