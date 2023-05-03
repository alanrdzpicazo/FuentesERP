﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Xml;
using System.Xml.Serialization;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Sube_ArchivoFactura : FormaBase
    {
        SQLCuentasxPagar sqlCxP = new SQLCuentasxPagar();

        public string PropiedadRuta { get; set; }
        public XmlDocument PropiedadXML { get; set; }
        public Comprobante PropiedadFactura { get; set; }
        public bool PropiedadEsRFCValido { get; set; }
        public string FolioFiscal { get; set; }
        public string Serie { get; set; }
        public string Folio { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public Int32 K_Tipo_Moneda { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tasa_IVA { get; set; }
        public decimal Total_IVA { get; set; }
        public decimal TasaRetencion_IVA { get; set; }
        public decimal TotalRetencion_IVA { get; set; }
        public decimal Tasa_ISR { get; set; }
        public decimal Total_ISR { get; set; }
        public decimal TotalFactura { get; set; }
        public DateTime F_Factura { get; set; }
        public string VersionXML { get; set; }
        //contador del timer que controlara a la progress bar al cargar los archivos al servidor
        int i = 0;
        bool pdf_ = true;
        bool error = false;

        public string Orden_Compra;
        public string Proveedor;
        public string Factura;
        public string D_Proveedor;
        public bool xml;
        public bool pdf;

        XmlDocument cfdi;
        SQLRecepcion sqlRecepcion = new SQLRecepcion();

        int res = 0;
        string msg = string.Empty;
        int ires = 0;
        string mssg = string.Empty;
        public Frm_Sube_ArchivoFactura()

        {
            InitializeComponent();
        }
        private void Frm_Sube_ArchivoFactura_Load(object sender, EventArgs e)
        {
            txtOC.Text = Orden_Compra;
            txtD_Proveedor.Text = D_Proveedor;
            txtK_Proveedor.Text = Proveedor;
            txtFactura.Text = Factura;
            cbxPDF.Checked = pdf;
            cbxXML.Checked = xml;
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
        }

        private void btnSubirXML_Click(object sender, EventArgs e)
        {
            if (txtOC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOC.Focus();
                return;
            }
            if (txtK_Proveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PROVEEDOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            if (txtFactura.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA FACTURA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFactura.Focus();
                return;
            }
            if ((xml) & (pdf))
            {
                MessageBox.Show("DEBE INDICAR UN TIPO DE ARCHIVO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxXML.Focus();
                return;
            }
            if (CbxAutorizado.Checked)
            {
                MessageBox.Show("SE ENCUENTRA AUTORIZADO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            if (cbxXML.Checked)
            {
                MessageBox.Show("EL ARCHIVO XML SE ENCUENTRA EN RESGUARDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            ires =  sqlRecepcion.Gp_ValidaFactura(Convert.ToInt32(Orden_Compra), Convert.ToInt32(Proveedor), Factura, ref mssg);
            if (ires == -1)
            {
                BaseErrorResultado = true;
                DialogResult DialogResult = MessageBox.Show(mssg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Seleccione los documentos a subir";

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Muestra Archivos XML";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "Archivos XML (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                PropiedadRuta = openFileDialog1.FileName;
                PropiedadEsRFCValido = false;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                    XmlTextReader reader = new XmlTextReader(@PropiedadRuta);
                    Comprobante factura = (Comprobante)serializer.Deserialize(reader);
                    PropiedadFactura = factura;
                    PropiedadXML = new XmlDocument();
                    PropiedadXML.Load(@PropiedadRuta);
                    //si traigo datos XML guardo CXP 
                    FolioFiscal = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();
                    Serie = factura.Serie;
                    Folio = factura.Folio;
                    if (factura.TipoCambio != null)
                        Tipo_Cambio = Truncar(Convert.ToDecimal(factura.TipoCambio), 4);
                    if (factura.Moneda != null)
                    {
                        string Moneda = factura.Moneda;
                        if (Moneda.ToUpper().Contains("USD") || Moneda.ToUpper().Contains("DLL") || Moneda.ToUpper().Contains("DOLAR"))
                            K_Tipo_Moneda = 5;
                        if (Moneda.ToUpper().Contains("PESOS"))
                            K_Tipo_Moneda = 1;

                    }
                    Subtotal = factura.SubTotal;
                    Tasa_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
                    Total_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
                    TasaRetencion_IVA = Convert.ToDecimal(10.66);
                    TotalRetencion_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
                    Tasa_ISR = Convert.ToDecimal(10);
                    Total_ISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));
                    TotalFactura = Convert.ToDecimal(factura.Total);
                    F_Factura = Convert.ToDateTime(factura.Fecha.ToString());
                    pnlEstatus.Visible = true;
                    pdf_ = false;
                    timer1.Start();
                    lblProgreso.Location = new Point(120, 33);
                    lblProgreso.Text = "Procesando, espere porfavor" + "...";
                    backgroundWorker1.RunWorkerAsync();
                    i = 0;
                    progressBar1.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ARCHIVO XML NO CUENTA CON FORMATO CORRECTO CORRESPONDIENTE A UN CFDI...!\r\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSubirPDF_Click(object sender, EventArgs e)
        {
            if (txtOC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOC.Focus();
                return;
            }
            if (txtK_Proveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PROVEEDOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            if (txtFactura.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA FACTURA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFactura.Focus();
                return;
            }
            if ((xml) & (pdf))
            {
                MessageBox.Show("DEBE INDICAR UN TIPO DE ARCHIVO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxXML.Focus();
                return;
            }
            if (CbxAutorizado.Checked)
            {
                MessageBox.Show("SE ENCUENTRA AUTORIZADO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            if (cbxPDF.Checked)
            {
                MessageBox.Show("EL ARCHIVO PDF SE ENCUENTRA EN RESGUARDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            ires=  sqlRecepcion.Gp_ValidaFactura(Convert.ToInt32(Orden_Compra), Convert.ToInt32(Proveedor), Factura, ref mssg);
            if (ires == -1)
            {
                BaseErrorResultado = true;
                DialogResult DialogResult = MessageBox.Show(mssg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Seleccione los documentos a subir";

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Muestra Archivos XML";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                pnlEstatus.Visible = true;
                pdf_ = true;
                timer1.Start();
                lblProgreso.Location = new Point(120, 33);
                lblProgreso.Text = "Procesando, espere porfavor" + "...";
                backgroundWorker1.RunWorkerAsync();
                i = 0;
                progressBar1.Value = 0;
            }
        }

        private void BtnAutorizar_Click(object sender, EventArgs e)
        {
            if (txtOC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOC.Focus();
                return;
            }
            if (txtK_Proveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PROVEEDOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            if (cbxPDF.Checked || cbxXML.Checked)
            {
                MessageBox.Show("SE HA INGRESADO UN ARCHIVO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            if (CbxAutorizado.Checked)
            {
                MessageBox.Show("SE ENCUENTRA AUTORIZADO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK_Proveedor.Focus();
                return;
            }
            res = sqlRecepcion.Gp_Actualiza_DocFacturas(Convert.ToInt32(Orden_Compra), Convert.ToInt32(Proveedor), Factura, null, false, false, true, ref mssg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                DialogResult DialogResult = MessageBox.Show(mssg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("SE AUTORIZO CORRECTAMENTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataTable dt = sqlRecepcion.Sk_Facturas_Proveedor(Convert.ToInt32(Proveedor), Convert.ToInt32(Orden_Compra), Factura);
            if (dt != null)
            {
                cbxXML.Checked = Convert.ToBoolean(dt.Rows[0]["B_xml"].ToString());
                cbxPDF.Checked = Convert.ToBoolean(dt.Rows[0]["B_pdf"].ToString());
                CbxAutorizado.Checked = Convert.ToBoolean(dt.Rows[0]["B_Autoriza_SinFactura"].ToString());
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        void XML()
        {
            ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");
            string dir = string.Empty, dircompleto = string.Empty;
            string[] Nombre = null;
            string[] nCompleto = null;
            try
            {
                nCompleto = openFileDialog1.FileNames;
                Nombre = openFileDialog1.SafeFileNames;
                dir = "Documentos/";

                dircompleto = dir + "/" + Orden_Compra + " " + Factura + " " + Proveedor + "XML" + "/";
                ftpClient.createDirectory(dir);
                ftpClient.createDirectory(dir + "/" + Orden_Compra + " " + Factura + " " + Proveedor + "/");

                if (Nombre.Length > 1)
                {
                    int i = 0;
                    foreach (String file in Nombre)
                    {
                        ftpClient.upload(dircompleto + file, nCompleto[i]);
                        i++;
                    }
                }
                else
                {
                    ftpClient.upload(dircompleto + openFileDialog1.SafeFileName, openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer1.Stop();
                error = true;
                backgroundWorker1.CancelAsync();
            }

            sqlRecepcion.Gp_Actualiza_DocFacturas(Convert.ToInt32(Orden_Compra), Convert.ToInt32(Proveedor), Factura, dircompleto, true, cbxPDF.Checked, false, ref mssg);

            if (res == -1)
            {
                BaseErrorResultado = true;
                DialogResult DialogResult = MessageBox.Show(mssg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                int CampoIdentity = 0;
                res = 0;
                msg = string.Empty;
                DataTable dtDetalle = new DataTable();
                dtDetalle = DetalleCxp_Type;
                dtDetalle.Columns.Remove("B_Manual");
                dtDetalle.Columns.Remove("Id");


                res = sqlCxP.In_CxP(ref CampoIdentity, Convert.ToInt32(Proveedor), FolioFiscal, Serie, Folio, Tipo_Cambio, K_Tipo_Moneda, Subtotal, Tasa_IVA, Total_IVA, TasaRetencion_IVA, TotalRetencion_IVA, Tasa_ISR, Total_ISR, TotalFactura, F_Factura, Convert.ToInt32(Orden_Compra), F_Factura, true, "", VersionXML, "CAPTURA", GlobalVar.K_Usuario, dtDetalle, ref msg);

                timer1.Stop();
                MessageBox.Show("ARCHIVOS GUARDADOS CORRECTAMENTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                backgroundWorker1.CancelAsync();
            }

        }

        void PDF()
        {
            ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");
            string dir = string.Empty, dircompleto = string.Empty;
            string[] Nombre = null;
            string[] nCompleto = null;
            try
            {
                nCompleto = openFileDialog1.FileNames;
                Nombre = openFileDialog1.SafeFileNames;
                dir = "Documentos/";

                dircompleto = dir + "/" + Orden_Compra + " " + Factura + " " + Proveedor + "PDF" + "/";
                ftpClient.createDirectory(dir);
                ftpClient.createDirectory(dir + "/" + Orden_Compra + " " + Factura + " " + Proveedor + "/");

                if (Nombre.Length > 1)
                {
                    int i = 0;
                    foreach (String file in Nombre)
                    {

                        ftpClient.upload(dircompleto + file, nCompleto[i]);
                        i++;
                    }
                }
                else
                {
                    ftpClient.upload(dircompleto + openFileDialog1.SafeFileName, openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer1.Stop();
                error = true;
                backgroundWorker1.CancelAsync();
            }
            
            MessageBox.Show("ARCHIVOS GUARDADOS  CORRECTAMENTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int ires = 0;
            string Mensaje = "";

            res = sqlRecepcion.Gp_Actualiza_DocFacturas(Convert.ToInt32(Orden_Compra), Convert.ToInt32(Proveedor), Factura, dircompleto, false, true, false, ref Mensaje);

            if (ires == -1)
            {
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                timer1.Stop();
                backgroundWorker1.CancelAsync();
            }
        }

        //Este evento es disparado al comienzo de la operación asíncrona y sera donde realicemos las tareas.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pdf_)
            {
                PDF();
            }
            else
            {
                XML();
            }
        }

        //Este evento será disparado al terminar la operación asíncrona.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (error == true)
            {
                lblProgreso.Location = new Point(155, 33);
                lblProgreso.Text = "Error";
                progressBar1.Increment(0);
                return;
            }

            lblProgreso.Location = new Point(155, 33);
            lblProgreso.Text = "COMPLETADO";
            progressBar1.Increment(Convert.ToInt32(Convert.ToInt32(progressBar1.Maximum) - Convert.ToInt32(progressBar1.Value)));
            DataTable dt = sqlRecepcion.Sk_Facturas_Proveedor(Convert.ToInt32(Proveedor), Convert.ToInt32(Orden_Compra), Factura);
            if (dt != null)
            {
                cbxXML.Checked = Convert.ToBoolean(dt.Rows[0]["B_xml"].ToString());
                cbxPDF.Checked = Convert.ToBoolean(dt.Rows[0]["B_pdf"].ToString());
                CbxAutorizado.Checked = Convert.ToBoolean(dt.Rows[0]["B_Autoriza_SinFactura"].ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Controlamos el tiempo de respuesta del servidor, si excede los 60 segundos detenemos el proceso
            if (i >= 60)
            {
                timer1.Stop();
                backgroundWorker1.CancelAsync();
            }
            i = i + 1;
            lblProgreso.Location = new Point(184, 28);
            lblProgreso.Text = i.ToString() + "%";
            progressBar1.Increment(3);
        }

    }
}