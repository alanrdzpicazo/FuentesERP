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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Pedidos_Ptes : FormaConsulta
    {
        SQLVentas sQLVentas = new SQLVentas();
        public DataTable dtDatos = new DataTable();
        public Int32 K_Pedido{ get; set; }
        public Int32 K_Almacen { get; set; }

        private void Frm_Pedidos_Ptes_Load(object sender, EventArgs e)
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
        public Frm_Pedidos_Ptes()
        {
            InitializeComponent();
        }
        public override void BaseBotonExcelClick()
        {
            Cursor = Cursors.WaitCursor;
            base.BaseBotonExcelClick();
            Cursor = Cursors.Default;
        }
        public void LlenaDatos()
        {
            this.dgv_datos.DataSource = null;
            this.dgv_datos.AutoGenerateColumns = false;
            dtDatos = this.sQLVentas.Gp_RepPedidosPtes(0);
            if(dtDatos!=null)
            {
                if(dtDatos.Rows.Count>0)
                {
                    dtDatos.DefaultView.Sort = "F_Pedido ASC,Pedido ASC";
                }
            }
            BaseDtDatos = dtDatos;

            dgv_datos.DataSource = dtDatos;

        }
        private void dgv_datos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                dgv_datos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = dgv_datos.CurrentRow;
                if (row == null)
                    return;

                K_Pedido = Convert.ToInt32(dgv_datos.CurrentRow.Cells["Pedido"].Value.ToString());
                K_Almacen = Convert.ToInt32(dgv_datos.CurrentRow.Cells["cK_Almacen"].Value.ToString());
                this.Close();
            }
        }

        private void dgv_datos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_datos.EndEdit();             // if you want to preserve the current commit behavior

            DataGridViewRow row = dgv_datos.CurrentRow;
            if (row == null)
                return;

            K_Pedido = Convert.ToInt32(dgv_datos.CurrentRow.Cells["Pedido"].Value.ToString());
            K_Almacen = Convert.ToInt32(dgv_datos.CurrentRow.Cells["cK_Almacen"].Value.ToString());
            this.Close();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (dtDatos != null)
            {
                if (dtDatos.Rows.Count > 0)
                {
                    dtDatos.DefaultView.RowFilter = String.Format("Convert(Pedido, 'System.String') LIKE '{0}%' OR Estatus LIKE '%{0}%' OR Almacen LIKE '%{0}%' OR Oficina LIKE '%{0}%' OR D_Cliente LIKE '%{0}%' OR Nombre LIKE '%{0}%'", txtFiltrar.Text.Trim());
                }
            }
        }

        private void txtNoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }
    }
}
