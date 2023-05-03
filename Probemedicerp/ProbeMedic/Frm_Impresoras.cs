using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Win32;
using System.Reflection;
using System.Diagnostics;

namespace ProbeMedic
{
    public partial class Frm_Impresoras : FormaBase
    {
        public string PrinterTicket= string.Empty;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public bool error = true;

        public Frm_Impresoras()
        {
            InitializeComponent();
        }
        
        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;

            RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic");

            PrinterTicket = Registro.GetValue("ProbeMedic_Printer_Tickets").ToString();

            crea_rango_combo();
        }

        public class Rango
        {
            public string Nombre { get; set; }
            public int Valor { get; set; }
        }

        private void crea_rango_combo()
        {
            var dataSource = new List<Rango>();
            var dataSource2 = new List<Rango>();
            var dataSource3 = new List<Rango>();
            int x = 0;

            foreach (String strPrinter in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {            
                dataSource.Add(new Rango() { Nombre = strPrinter, Valor = x });
                dataSource2.Add(new Rango() { Nombre = strPrinter, Valor = x });
                dataSource3.Add(new Rango() { Nombre = strPrinter, Valor = x });
                x++;
            }

            this.cmbPrinterTicket.DataSource = dataSource;
            this.cmbPrinterTicket.DisplayMember = "Nombre";
            this.cmbPrinterTicket.ValueMember = "Valor";
            this.cmbPrinterTicket.DropDownStyle = ComboBoxStyle.DropDownList;

            if (PrinterTicket.Length > 0)
            {
                foreach (Rango item in cmbPrinterTicket.Items)
                {
                    if (item.Nombre == PrinterTicket)
                    {
                        cmbPrinterTicket.SelectedIndex = item.Valor;
                    }
                }       
            }
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic\ProbeMedic", true);

            Registro.SetValue("ProbeMedic_Printer_Tickets", cmbPrinterTicket.Text);

            PrinterTicket = cmbPrinterTicket.Text;

            error = false;
            this.Close();
        }

        private void btnAplicar_MouseEnter(object sender, EventArgs e)
        {
            btnAplicar.Cursor = Cursors.Hand;          
        }

     
    }
}
