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


namespace ProbeMedic.CXP
{
    public partial class Frm_MuestraAnticipos : FormaConsulta
    {
        public int K_Proveedor; 

        SQLCuentasxPagar sQLCuentasxPagar = new SQLCuentasxPagar();
        DataTable dtDatos = new DataTable();

        public Int32 K_Anticipo { get; set; }
        public decimal Monto { get; set; }

        public Frm_MuestraAnticipos()
        {
            InitializeComponent();
        }
        public void LlenaDatos()
        {
            this.dbgDatos.DataSource = null;
            dtDatos = this.sQLCuentasxPagar.Gp_Trae_AnticiposProv(K_Proveedor);
            BaseDtDatos = dtDatos;

            dbgDatos.DataSource = dtDatos;
        }

        private void Frm_MuestraAnticipos_Load(object sender, EventArgs e)
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

        private void dvgDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                dbgDatos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = dbgDatos.CurrentRow;
                if (row == null)
                    return;


                K_Anticipo = Convert.ToInt32(dbgDatos.CurrentRow.Cells["K_Anticipo_Proveedor"].Value.ToString());
                this.Close();
            }
        }
            private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
            {


                dbgDatos.EndEdit();             // if you want to preserve the current commit behavior

                DataGridViewRow row = dbgDatos.CurrentRow;
                if (row == null)
                    return;


                K_Anticipo = Convert.ToInt32(dbgDatos.CurrentRow.Cells["K_Anticipo_Proveedor"].Value.ToString());
            if (Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Anticipo_Efectivo"].Value.ToString()) > 0)
            {
                Monto = Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Anticipo_Efectivo"].Value.ToString());
            }
            if (Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Anticipo_Cheque"].Value.ToString()) > 0)
            {
                Monto = Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Anticipo_Cheque"].Value.ToString());
            }
            if (Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Anticipo_Transferencia"].Value.ToString()) > 0)
            {
                Monto = Convert.ToDecimal(dbgDatos.CurrentRow.Cells["Monto_Anticipo_Transferencia"].Value.ToString());
            }
            this.Close();
            }

        private void dbgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dbgDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
