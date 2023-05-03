using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Sube_NotaCredito : FormaBase
    {
        //contador del timer que controlara a la progress bar al cargar los archivos al servidor
        int i = 0;

        bool pdf = true;
        bool error = false;

        public Int32 pK_Devolucion { get; set; }
        public Int32 pK_Proveedor { get; set; }
        public String pD_Proveedor { get; set; }
        public Int32 pK_Estatus_Devolucion { get; set; }
        SQLAlmacen sqlalmacen = new SQLAlmacen();
        SQLCuentasxPagar sqlCxP = new SQLCuentasxPagar();
        public DataTable dtResultado = new DataTable();

        public string PropiedadRuta { get; set; }
        public XmlDocument PropiedadXML { get; set; }
        public Comprobante PropiedadFactura { get; set; }
        public bool PropiedadEsRFCValido { get; set; }

        string msg = string.Empty;
        int res;

        #region PROPIEDADES_NOTA_CREDITO
        public String pFolioFiscal { get; set; }
        public String pSerie { get; set; }
        public String pFolio { get; set; }
        public Decimal pTipo_Cambio { get; set; }
        public Int16 pK_Tipo_Moneda { get; set; }
        public Decimal pSubtotal { get; set; }
        public Decimal pTasa_IVA { get; set; }
        public Decimal pTotal_IVA { get; set; }
        public Decimal pTasaRetencion_IVA { get; set; }
        public Decimal pTotalRetencion_IVA { get; set; }
        public Decimal pTasa_ISR { get; set; }
        public Decimal pTotal_ISR { get; set; }
        public Decimal pTotalNota { get; set; }
        public DateTime pF_Nota { get; set; }
        public String pVersionXML { get; set; }
        public String pModulo { get; set; }
        public Boolean pB_CapturaDirecta { get; set; }
        public String pSerieReferencia { get; set; }
        public String pFolioReferencia { get; set; }
        #endregion PROPIEDADES_NOTA_CREDITO

        public Frm_Sube_NotaCredito()
        {
            InitializeComponent();
        }

        private void Frm_Sube_NotaCredito_Load(object sender, EventArgs e)
        {
            txtDevolucion.Text = pK_Devolucion.ToString();
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

            dtResultado = sqlalmacen.sk_Devoluciones(pK_Devolucion);

            DataRow row = dtResultado.Rows[0];

            if ((Convert.ToBoolean(row["B_Xml"])) || ((Convert.ToBoolean(row["B_Pdf"])) == true))
            {
                txtNota.Text = row["K_Notas_Credito_Orden_Compra"].ToString();
                txtNota.ReadOnly = true;
                txtNota.Enabled = false;

                //dtpFechaNota.Format = DateTimePickerFormat.Short;
                //dtpFechaNota.CustomFormat = "yyyy-MM-dd";
                //dtpFechaNota.Value = Convert.ToDateTime(row["F_Nota_Credito"]);
                //dtpFechaNota.Enabled = false;

                if ((Convert.ToBoolean(row["B_Xml"]) == true))
                {
                    cbxXML.Checked = true;
                    btnSubirPDF.Focus();
                }
                if ((Convert.ToBoolean(row["B_Pdf"]) == true))
                {
                    cbxPDF.Checked = true;
                    btnSubirXML.Focus();
                }
            }

            else
            {
                txtNota.Focus();
            }

        }

        private void btnSubirXML_Click(object sender, EventArgs e)
        {
            if (txtNota.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO DE LA NOTA DE CREDITO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNota.Focus();
                return;
            }

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Seleccione los documentos a subir";

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
   
            if (result == DialogResult.OK) // Test result.
            {
                PropiedadRuta = openFileDialog1.FileName;
                PropiedadEsRFCValido = false;
                XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                XmlTextReader reader = new XmlTextReader(@PropiedadRuta);
                Comprobante factura = (Comprobante)serializer.Deserialize(reader);
                PropiedadFactura = factura;
                PropiedadXML = new XmlDocument();
                PropiedadXML.Load(@PropiedadRuta);
                //si traigo datos XML guardo CXP

                if (factura.TipoDeComprobante.ToString().Trim().ToUpper() != "E")
                {
                    MessageBox.Show("EL TIPO DE COMPROBANTE NO ES DE EGRESO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pFolioFiscal = factura.Complemento.Any[0].Attributes["UUID"].Value.ToString();
                pSerie = factura.Serie;
                pFolio = factura.Folio;
                if (factura.TipoCambio != null)
                    //pTipo_Cambio = Truncar(Convert.ToDecimal(factura.TipoCambio), 4);
                    pTipo_Cambio = 1;
                if (factura.Moneda != null)
                {
                    string Moneda = factura.Moneda;
                    if (Moneda.ToUpper().Contains("USD") || Moneda.ToUpper().Contains("DLL") || Moneda.ToUpper().Contains("DOLAR"))
                        pK_Tipo_Moneda= 5;
                    if (Moneda.ToUpper().Contains("MXN"))
                        pK_Tipo_Moneda = 1;
                }
                pSubtotal= factura.SubTotal;
                pVersionXML = factura.Version;
                pTasa_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "TasaIVA"));
                pTotal_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "IVA"));
                pTasaRetencion_IVA = Convert.ToDecimal(10.66);
                pTotalRetencion_IVA = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionIVA"));
                pTasa_ISR = Convert.ToDecimal(10);
                pTotal_ISR = Convert.ToDecimal(ComprobantexTipo(factura, "RetencionISR"));
                pTotalNota = Convert.ToDecimal(factura.Total);
                pF_Nota = Convert.ToDateTime(factura.Fecha.ToString());

                pnlEstatus.Visible = true;
                pdf = false;

                timer1.Start();
                lblProgreso.Location = new Point(120, 33);
                lblProgreso.Text = "Procesando, espere porfavor" + "...";
                backgroundWorker1.RunWorkerAsync();
                i = 0;
                progressBar1.Value = 0;

            }
            
        }

        private void btnSubirPDF_Click(object sender, EventArgs e)
        {
            if (txtNota.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO DE LA NOTA DE CREDITO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNota.Focus();
                return;
            }

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Seleccione los documentos a subir";

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                pnlEstatus.Visible = true;
                pdf = true;
                timer1.Start();
                lblProgreso.Location = new Point(120, 33);
                lblProgreso.Text = "Procesando, espere porfavor" + "...";
                backgroundWorker1.RunWorkerAsync();
                i = 0;
                progressBar1.Value = 0;
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Este evento es disparado al comienzo de la operación asíncrona y sera donde realicemos las tareas.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {    
            if(pdf == true)
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
            if(error == true)
            {
                lblProgreso.Location = new Point(155, 33);
                lblProgreso.Text = "Error";
                progressBar1.Increment(0);
                return;
            }

            lblProgreso.Location = new Point(155, 33);
            lblProgreso.Text = "COMPLETADO";
            progressBar1.Increment(Convert.ToInt32(Convert.ToInt32(progressBar1.Maximum) - Convert.ToInt32(progressBar1.Value)));
  
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Controlamos el tiempo de respuesta del servidor, si excede los 60 segundos detenemos el proceso
            if(i>=60)
            {
                timer1.Stop();
                backgroundWorker1.CancelAsync();
            }

            i = i + 1;
            lblProgreso.Location = new Point(187, 32);
            lblProgreso.Text = i.ToString() + "%";
            progressBar1.Increment(1);
        }

        void XML()
        {
            //ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");
            //string dir = string.Empty;
            //string dircompleto = string.Empty;
            //string[] Nombre = null;
            //string[] nCompleto = null;
            //try
            //{
            //    nCompleto = openFileDialog1.FileNames;
            //    Nombre = openFileDialog1.SafeFileNames;
            //    dir = "Documentos/Devoluciones/";
            //    dircompleto = dir + "/" + pK_Devolucion + "/" + nCompleto[0] + "/";

            //    ftpClient.createDirectory(dir);
            //    ftpClient.upload(dircompleto + openFileDialog1.SafeFileName, openFileDialog1.FileName);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //string msg = string.Empty;
            //sqlalmacen.Up_Devoluciones(pK_Devolucion, pK_Estatus_Devolucion, txtNota.Text, dtpFechaNota.Value,DBNull.Value.ToString(), Nombre[0], ref msg);
            //if (msg != string.Empty)
            //{
            //    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    timer1.Stop();
            //    error = true;
            //    backgroundWorker1.CancelAsync();
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    BaseMetodoInicio();
            //}
            //timer1.Stop();
            //backgroundWorker1.CancelAsync();

            /*-----------------------------------------------------------------------------------------------------------------------------*/
            ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");
            string dir = string.Empty, dircompleto = string.Empty;
            string[] Nombre = null;
            string[] nCompleto = null;

            String errores = String.Empty;
            try
            {
                nCompleto = openFileDialog1.FileNames;
                Nombre = openFileDialog1.SafeFileNames;
                dir = "Documentos/Devoluciones/";
                dircompleto = dir + "/" + pK_Devolucion + "/" + nCompleto[0] + "/";

                ftpClient.createDirectory(dir);
                ftpClient.upload(dircompleto + openFileDialog1.SafeFileName, openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                errores += ex;
            }

            if(errores!=string.Empty)
            {
                MessageBox.Show(errores, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CampoIdentity = 0;
            res = 0;     
            msg = string.Empty;

            DataTable dtDetalle = new DataTable();
            dtDetalle = DetalleNotaProveedor_Type;

            dtDetalle = sqlalmacen.sk_Devoluciones(pK_Devolucion);
            dtDetalle.Columns.Remove("K_Devolucion");
            dtDetalle.Columns.Remove("K_Orden_Compra");
            dtDetalle.Columns.Remove("No_Documento");
            dtDetalle.Columns.Remove("K_Movimiento_Detalle");
            dtDetalle.Columns.Remove("K_Movimiento_Inventario");
            dtDetalle.Columns.Remove("No_Lote");
            dtDetalle.Columns.Remove("K_Motivo_Devolucion");
            dtDetalle.Columns.Remove("D_Motivo_Devolucion");
            dtDetalle.Columns.Remove("K_Oficina");
            dtDetalle.Columns.Remove("D_Oficina");
            dtDetalle.Columns.Remove("K_Almacen");
            dtDetalle.Columns.Remove("D_Almacen");
            dtDetalle.Columns.Remove("F_Devolucion");
            dtDetalle.Columns.Remove("K_Usuario");
            dtDetalle.Columns.Remove("D_Usuario");
            dtDetalle.Columns.Remove("PC_Name");
            dtDetalle.Columns.Remove("K_Estatus_Devolucion");
            dtDetalle.Columns.Remove("D_Estatus_Devolucion");
            dtDetalle.Columns.Remove("K_Laboratorio");
            dtDetalle.Columns.Remove("D_Laboratorio");
            dtDetalle.Columns.Remove("SKU");
            dtDetalle.Columns.Remove("K_Unidad_Medida");
            dtDetalle.Columns.Remove("K_Proveedor");
            dtDetalle.Columns.Remove("D_Proveedor");
            dtDetalle.Columns.Remove("K_Nota_Recepcion");
            dtDetalle.Columns.Remove("F_Recepcion");
            dtDetalle.Columns.Remove("Tipo_Documento");
            dtDetalle.Columns.Remove("K_Articulo");
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("B_Pdf");
            dtDetalle.Columns.Remove("B_Xml");
            dtDetalle.Columns.Remove("K_Notas_Credito_Orden_Compra");
            dtDetalle.Columns.Remove("Archivo_PDF");
            dtDetalle.Columns.Remove("Archivo_XML");
            dtDetalle.Columns.Remove("B_Xml1");

            string Referencia =  txtNota.Text.ToString();
            //if (Referencia.ToString().Length <= 0)
            //    Referencia = "";

            res =sqlCxP.In_Nota_Credito_Proveedor(
                ref CampoIdentity,
                pK_Proveedor,
                pFolioFiscal,
                pSerie,
                pFolio,
                pTipo_Cambio,
                pK_Tipo_Moneda,
                pSubtotal,
                pTasa_IVA,
                pTotal_IVA,
                pTasaRetencion_IVA,
                pTotalRetencion_IVA,
                pTasa_ISR,
                pTotal_ISR,
                pTotalNota,
                pF_Nota,
                Referencia,
                "",
                pVersionXML,
                GlobalVar.K_Usuario,
                dtDetalle,
                pSerie,
                txtNota.Text,
                ref msg);

            if (res == -1)
            {
                timer1.Stop();
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);     
                backgroundWorker1.CancelAsync();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("NOTA DE CREDITO GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backgroundWorker1.CancelAsync();
                sqlalmacen.Up_Devoluciones(pK_Devolucion, 2, txtNota.Text, dtpFechaNota.Value, DBNull.Value.ToString(), Nombre[0], ref msg);
            }
        }

        void PDF()
        {
            
            ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");
            string dir = string.Empty;
            string dircompleto = string.Empty;
            string[] Nombre = null;
            string[] nCompleto = null;
            try
            {
                nCompleto = openFileDialog1.FileNames;
                Nombre = openFileDialog1.SafeFileNames;

                dir = "Documentos/Devoluciones/";
                dircompleto = dir + "/" + pK_Devolucion + "/" + nCompleto[0] + "/";
                ftpClient.createDirectory(dir);

                ftpClient.upload(dircompleto + openFileDialog1.SafeFileName, openFileDialog1.FileName);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string msg = string.Empty;
            sqlalmacen.Up_Devoluciones(pK_Devolucion, pK_Estatus_Devolucion, txtNota.Text, dtpFechaNota.Value, Nombre[0], DBNull.Value.ToString(), ref msg);
            if (msg != string.Empty)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer1.Stop();
                error = true;
                backgroundWorker1.CancelAsync();
                return;
            }
            else
            {
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
            }
            timer1.Stop();
            backgroundWorker1.CancelAsync();

        }

    }
}