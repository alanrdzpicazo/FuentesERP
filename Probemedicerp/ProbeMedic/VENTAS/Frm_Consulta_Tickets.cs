using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Win32;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Consulta_Tickets : FormaBase
    {
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();

        DataTable dtAlmacen = new DataTable();
        DataTable dtDetalle = new DataTable();

        string PrinterTickets = string.Empty;

        RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic");
        public Frm_Consulta_Tickets()
        {
            InitializeComponent();
            grd_Datos.AutoGenerateColumns = false;
            //grd_Detalle.AutoGenerateColumns = false;
            PrinterTickets = Registro.GetValue("ProbeMedic_Printer_Tickets").ToString();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonExcel.Visible = false;
            base.BaseMetodoInicio();
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonCancelar.Visible = true;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = false;
            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonReporte.Text = "&Ticket [F8]";
            cargaAlmacenes();

        }
        public override void BaseBotonImpresoraClick()
        {
            Frm_Impresoras frm = new Frm_Impresoras();
            frm.ShowDialog();
            PrinterTickets = frm.PrinterTicket;

            if (PrinterTickets.Length == 0)
            {
                if (frm.error == true)
                {
                    BaseBotonImpresoraClick();
                }
            }
        }
        public override void BaseBotonBuscarClick()
        {
            if (grd_Datos.RowCount > 0)
            {
                DataTable Dt = (DataTable)grd_Datos.DataSource;
                Dt.Clear();
            }
            Int32 K_Transaccion = 0;
            Int32 K_Almacen = 0;
            if (txt_K_Transaccion.Text.Trim().Length > 0)
            {
                K_Transaccion = Convert.ToInt32(txt_K_Transaccion.Text.Trim());
            }
            else
            {
                K_Transaccion = 0;
            }
            if (Convert.ToInt32(cbx_Almacen.SelectedValue.ToString()) == 0)
            {
                K_Almacen = 0;
            }
            else
            {
                K_Almacen = Convert.ToInt32(cbx_Almacen.SelectedValue.ToString());
            }

            BaseDtDatos = sqlVentas.Gp_VentaArticulos(K_Transaccion, K_Almacen, dtp_F_Inicial.Value, dtp_F_Final.Value,chk_Canceladas.Checked,chk_Facturadas.Checked,chk_EAD.Checked,chk_Descuento.Checked,chk_Credito.Checked);

            if ((BaseDtDatos == null) || (BaseDtDatos.Rows.Count == 0))
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = false;
            }
            else

            {
                grd_Datos.DataSource = BaseDtDatos;
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
            }

            base.BaseBotonBuscarClick();
        }
        public override void BaseBotonCancelarClick()
        {
            base.BaseBotonCancelarClick();
            dtp_F_Inicial.Value = DateTime.Now;
            dtp_F_Final.Value = DateTime.Now;
            txt_K_Transaccion.Text = string.Empty;
            chk_Canceladas.Checked = false;
            chk_Credito.Checked = false;
            chk_Descuento.Checked = false;
            chk_EAD.Checked = false;
            chk_Facturadas.Checked = false;
            if (grd_Datos.RowCount > 0)
            {
                DataTable Dt = (DataTable)grd_Datos.DataSource;
                Dt.Clear();
            }
            BaseMetodoInicio();
        }
        public override void BaseBotonReporteClick()
        {
            Int32 K_Transaccion = 0;

            if (grd_Datos.Rows.Count > 0)
            {
                if (grd_Datos.CurrentRow != null)
                {
                    if (grd_Datos.CurrentRow.Index >= 0)
                    {
                        K_Transaccion = Convert.ToInt32(grd_Datos.CurrentRow.Cells["K_Transaccion"].Value.ToString());
                        Cursor = Cursors.WaitCursor;
                        Imprimir_Ticket(K_Transaccion, 0);
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grd_Datos.Focus();
                }

            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grd_Datos.Focus();
            }
        }
        private void txt_K_Transaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txt_K_Transaccion_TextChanged(object sender, EventArgs e)
        {
            if (txt_K_Transaccion.Text.Trim().Length > 0)
            {
                Int32 Valor = 0;

                if (!Int32.TryParse(txt_K_Transaccion.Text.Trim(), out Valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_K_Transaccion.Text = string.Empty;
                    txt_K_Transaccion.Focus();
                }
            }

        }
        private void grd_Datos_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_Datos.CurrentRow != null)
            {
                if (grd_Datos.CurrentRow.Index > -1)
                {
                    Int32 K_Transaccion = Convert.ToInt32(grd_Datos.CurrentRow.Cells["K_Transaccion"].Value.ToString());

                    dtDetalle = sqlAlmacen.Gp_Remision_Detalle(K_Transaccion);

                    //grd_Detalle.DataSource = dtDetalle;
                }
            }
        }
        public void Imprimir_Ticket(Int32 K_Transaccion, Int32 K_Almacen)
        {
            string msg = string.Empty;
            string PrinterTicket = string.Empty;
            DataTable dt = sqlVentas.Gp_Datos_Ticket(K_Transaccion, K_Almacen, ref msg);
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReportDocument rpt = null;
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                rpt = new VENTAS.TicketVenta();

                Forma forma = new Forma();
                forma.ConectaReporte(ref rpt, dt, "", "", "", false, false);

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_ReporteRPT = rpt;
                frmReporte.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL TICKET", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dt = null;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = false;
            }
            else
            {
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
            }
        }
        public void cargaAlmacenes()
        {
            dtAlmacen = null;
            cbx_Almacen.DataSource = null;
            cbx_Almacen.Items.Clear();
            cbx_Almacen.AutoCompleteSource = AutoCompleteSource.None;
            cbx_Almacen.AutoCompleteMode = AutoCompleteMode.None;

            dtAlmacen = sqlCatalogos.Sk_Almacenes_Empresa();


            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbx_Almacen, "K_Almacen", "D_Almacen", indice);
            }
        }
    }
}
