using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.DCC;
using ProbeMedic.AppCode.BLL;
using Microsoft.Win32;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_ReimpresionTicket : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        string PrinterTickets = string.Empty;

        RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic");

        public Int32 K_Almacen { get; set; }

        public Frm_ReimpresionTicket(Int32 p_K_Almacen)
        {
            InitializeComponent();
            PrinterTickets = Registro.GetValue("ProbeMedic_Printer_Tickets").ToString();
            if (PrinterTickets.Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR LAS IMPRESORA DE TICKETS DE VENTA", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Obtengo_Impresoras();
            }
            K_Almacen = p_K_Almacen;
        }

        private void Obtengo_Impresoras()
        {
            Frm_Impresoras frm = new Frm_Impresoras();
            frm.ShowDialog();
            PrinterTickets = frm.PrinterTicket;

            if (PrinterTickets.Length == 0)
            {
                if (frm.error == true)
                {
                    Obtengo_Impresoras();
                }
            }
        }
        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
        }
        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if(txtTicket.Text.Trim().Length==0)
            {
                 MessageBox.Show("DEBE CAPTURAR UN NUMERO DE TICKET", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;             
            }
            Cursor = Cursors.WaitCursor;
            Imprimir_Ticket(Convert.ToInt32(txtTicket.Text.Trim()),K_Almacen);
            Cursor = Cursors.Default;
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
                foreach (DataRow row in dt.Rows)
                {
                    rpt = new VENTAS.TicketVenta();

                    Forma forma = new Forma();
                    forma.ConectaReporte(ref rpt, dt, "", "", "", false, false);

                    RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic");
                    PrinterTickets = Registro.GetValue("ProbeMedic_Printer_Tickets").ToString();

                    rpt.PrintOptions.PrinterName = PrinterTickets;
                    try { rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto; }
                    catch { }
                    rpt.PrintToPrinter(1, false, 0, 0);//Imprime directamente
                    rpt.Close(); rpt.Dispose();
                    break;
                }
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL TICKET", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dt = null;
        }

        private void Frm_ReimpresionTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Alt) + Convert.ToInt32(Keys.I))
            {
                Frm_Impresoras frm = new Frm_Impresoras();
                frm.ShowDialog();
            }
        }
    }
}
