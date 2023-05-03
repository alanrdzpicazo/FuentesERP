using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ProbeMedic.AppCode.BLL;
namespace ProbeMedic.FACTURACION
{
    public partial class FRM_CONSULTA_FACTURAS : FormaBase
    {
        ToolStrip barra;
        ToolStripItem btn_Correo = new ToolStripMenuItem();
        ToolStripItem btn_XML = new ToolStripMenuItem();

        SQLAdministracion sql = new SQLAdministracion();
        DataTable dtDatos = new DataTable();
        public FRM_CONSULTA_FACTURAS()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
            barra = BaseBarraHerramientas;
            addbtn_Correo();
            addbtn_XML();


        }

        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = false;
            btn_Correo.Visible = true;
            btn_Correo.Enabled = false;
            btn_XML.Visible = true;
            btn_XML.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonCancelar.Visible = false;

            BaseBotonBuscar.Text = "Buscar [F7]";

            BaseBotonReporte.Image = Properties.Resources.PDF;
            BaseBotonReporte.Text = "PDF [F8]";

            dtp_F_Inicial.Value = DateTime.Now.PrimerDiaDelMes();
            dtp_F_Final.Value = DateTime.Now;


        }
        public override void BaseBotonBuscarClick()
        {
            if (txtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CLIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return;
            }
            if (ucTipoVenta1.K_Tipo_Venta == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE VENTA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoVenta1.Focus();
                return;
            }
            dtDatos = sql.Gp_Muestra_FacturasTimbradas(Convert.ToInt32(txtClaveCliente.Text.Trim()),dtp_F_Inicial.Value,dtp_F_Final.Value,ucTipoVenta1.K_Tipo_Venta);

            if (dtDatos == null)
            {
                if (grdDatos.Rows.Count > 0)
                {
                    DataTable Dt = (DataTable)grdDatos.DataSource;
                    Dt.Clear();
                }
            }
            else
            {
                grdDatos.DataSource = dtDatos;
                grdDatos.Focus();
            }

            base.BaseBotonBuscarClick();
        }
        public override void BaseBotonReporteClick()
        {
            if ((grdDatos.CurrentRow == null) || (grdDatos.CurrentRow.Index < 0))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FACTURA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDatos.Focus();
                return;
            }
            else
            {
                string D_Serie = grdDatos.CurrentRow.Cells["D_Serie"].Value.ToString();
                Int32 K_Factura = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Factura"].Value);

                Procesos procesos = new Procesos();
                Cursor = Cursors.WaitCursor;
                procesos.Genera_PDF(D_Serie,K_Factura.ToString());
                Cursor = Cursors.Default;
            }
        }

        private void addbtn_Correo()
        {
            //Name that will apear on the menu
            btn_Correo.Text = "Enviar a Correo";
            //Put in the Name property whatever neccessery to retrive your data on click event
            btn_Correo.Name = "btn_Correo";
            //On-Click event
            btn_Correo.Click += new EventHandler(btn_Correo_Click);
            //Setup
            btn_Correo.Image = Properties.Resources.sendbymail_enviar_1541;
            btn_Correo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_Correo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_Correo.ToolTipText = "Enviar a Correo";
            btn_Correo.Width = 130;
            btn_Correo.Height = 35;
            //BtnCips.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            //Add the submenu to the parent menu           
            barra.Items.Add(btn_Correo);
        }
        private void addbtn_XML()
        {
            //Name that will apear on the menu
            btn_XML.Text = "Descargar XML";
            //Put in the Name property whatever neccessery to retrive your data on click event
            btn_XML.Name = "btn_XML";
            //On-Click event
            btn_XML.Click += new EventHandler(btn_XML_Click);
            //Setup
            btn_XML.Image = Properties.Resources.XML;
            btn_XML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_XML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_XML.ToolTipText = "Descargar XML";
            btn_XML.Width = 130;
            btn_XML.Height = 35;
            //BtnCips.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            //Add the submenu to the parent menu           
            barra.Items.Add(btn_XML);
        }
        public void sendmail(string Serie, string Folio, string adjunto, string destino)
        {
            try
            {
                using (MailMessage objeto_mail = new MailMessage())
                {
                    SmtpClient client = new SmtpClient();

                    client.Port = 2525;
                    client.Host = "smtp.gmail.com";
                    client.Timeout = 25000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("probemedicerp1@gmail.com", "s1st3m@s");
                    objeto_mail.From = new MailAddress("facturacion@probemedic.mx", "Probemedic");
                    if (destino.IndexOf(";") > -1)
                    {
                        string[] list = destino.Split(';');
                        for (int i = 0; i < list.Length; i++)
                        {
                            if (list[i].Length > 0)
                            {
                                objeto_mail.To.Add(new MailAddress(list[i].ToString()));
                            }
                        }

                    }
                    else
                    {
                        objeto_mail.To.Add(new MailAddress(destino));
                    }

                    objeto_mail.Subject = "Factura Probemedic (Factura " + Serie + "-" + Folio + ")";
                    objeto_mail.Body = "Se adjunta su factura.";


                    if (adjunto.Length > 0)
                    {
                        Attachment attachment = new System.Net.Mail.Attachment(@"" + adjunto + ".xml");
                        attachment.Name = adjunto + ".xml";
                        objeto_mail.Attachments.Add(attachment);

                        Attachment attachment2 = new System.Net.Mail.Attachment(@"" + adjunto + ".pdf");
                        attachment2.Name = adjunto + ".pdf";
                        objeto_mail.Attachments.Add(attachment2);
                    }

                    client.Send(objeto_mail);

                }


                System.IO.File.Delete(@"" + adjunto + ".xml");
                System.IO.File.Delete(@"" + adjunto + ".pdf");
            }
            catch (Exception ex)
            {
                //Error
                string error = ex.ToString();
                System.Console.WriteLine("\nError: {0}", error);
                System.IO.File.Delete(@"" + adjunto + ".xml");
                System.IO.File.Delete(@"" + adjunto + ".pdf");
            }
        }

        private void btn_XML_Click(object sender, EventArgs e)
        {
            if ((grdDatos.CurrentRow == null) || (grdDatos.CurrentRow.Index < 0))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FACTURA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDatos.Focus();
                return;
            }
            else
            {       
                Int32 K_Factura = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Factura"].Value);
                string D_Serie = grdDatos.CurrentRow.Cells["D_Serie"].Value.ToString();
                Cursor = Cursors.WaitCursor;
                DataTable dt = sql.GP_Xml_Factura(K_Factura,D_Serie);

                string XML_Timbrado = dt.Rows[0]["Cadena_XML"].ToString();
                string Cadena_Original = dt.Rows[0]["Cadena_Original"].ToString();
                string qrCode = dt.Rows[0]["qrCode"].ToString();

                // Create the XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(XML_Timbrado);

                DataSet ds = new DataSet();
                ds.ReadXml(new StringReader(XML_Timbrado));

                //Genera PDF
                DataSet dsComprobante = Generatabla_Factura(ds,dt.Rows[0]["Empresa"].ToString(), dt.Rows[0]["Cadena_Original"].ToString(), qrCode);

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    bool B_Error = false;
                    try
                    {
                        // Save the document to a file. White space is
                        // preserved (no white space).
                        doc.PreserveWhitespace = true;
                        doc.Save(folderBrowserDialog1.SelectedPath + "/" + dsComprobante.Tables[0].Rows[0]["Serie"].ToString() + "-" + dsComprobante.Tables[0].Rows[0]["Folio"].ToString() + ".xml");
                        B_Error = false;
                    }
                    catch (Exception) { B_Error = true; }

                    if (!B_Error)
                    {
                        MessageBox.Show("EL ARCHIVO XML SE DESCARGO CORRECTAMENTE!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

                Cursor = Cursors.Default;
            }

        }
        private void btn_Correo_Click(object sender, EventArgs e)
        {
            if ((grdDatos.CurrentRow == null) || (grdDatos.CurrentRow.Index < 0))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FACTURA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDatos.Focus();
                return;
            }
            else if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN CORREO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }
            else
            {
                string D_Serie = grdDatos.CurrentRow.Cells["D_Serie"].Value.ToString();
                Int32 K_Factura = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Factura"].Value);
                Cursor = Cursors.WaitCursor;
                Procesos procesos = new Procesos();
                MessageBox.Show("FACTURA ENVIADA CORRECTAMTE!");
                Cursor = Cursors.Default;

            }

        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row != null)
            {
                string FolioUDDI = row.Cells["UUID"].Value.ToString();

                if (FolioUDDI.Length != 0)
                {
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = true;
                    btn_Correo.Visible = true;
                    btn_Correo.Enabled = true;
                    btn_XML.Visible = true;
                    btn_XML.Enabled = true;
                }
                else
                {
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = false;
                    btn_Correo.Visible = true;
                    btn_Correo.Enabled = false;
                    btn_XML.Visible = true;
                    btn_XML.Enabled = false;
                }
            }
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();

            if ((filtra.K_Cliente_Seleccionado > 0) && (filtra.D_Cliente_Seleccionado.Length > 0))
            {
                txtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
                txtCliente.Text = filtra.D_Cliente_Seleccionado;
            }
            else
            {
                txtClaveCliente.Text = string.Empty;
                txtCliente.Text = string.Empty;
            }
        }

        public DataSet Generatabla_Factura(DataSet DS, string Empresa, string Cadena_Original, string qrCode)
        {
            Conversion c = new Conversion();
            DataTable dtComprobante = new DataTable();

            dtComprobante.Columns.Add("Empresa", typeof(string));
            dtComprobante.Columns.Add("Serie", typeof(string));
            dtComprobante.Columns.Add("Folio", typeof(string));
            dtComprobante.Columns.Add("Fecha", typeof(string));
            dtComprobante.Columns.Add("Sello", typeof(string));
            dtComprobante.Columns.Add("NoCertificado", typeof(string));
            dtComprobante.Columns.Add("Certificado", typeof(string));
            dtComprobante.Columns.Add("SubTotal", typeof(string));
            dtComprobante.Columns.Add("Moneda", typeof(string));
            dtComprobante.Columns.Add("Total", typeof(string));
            dtComprobante.Columns.Add("TipoDeComprobante", typeof(string));
            dtComprobante.Columns.Add("FormaPago", typeof(string));
            dtComprobante.Columns.Add("MetodoPago", typeof(string));
            dtComprobante.Columns.Add("CondicionesDePago", typeof(string));
            dtComprobante.Columns.Add("Descuento", typeof(string));
            dtComprobante.Columns.Add("TipoCambio", typeof(string));
            dtComprobante.Columns.Add("LugarExpedicion", typeof(string));

            dtComprobante.Columns.Add("Emisor_Rfc", typeof(string));
            dtComprobante.Columns.Add("Emisor_Nombre", typeof(string));
            dtComprobante.Columns.Add("RegimenFiscal", typeof(string));

            dtComprobante.Columns.Add("UsoCFDI", typeof(string));
            dtComprobante.Columns.Add("Receptor_Rfc", typeof(string));
            dtComprobante.Columns.Add("Receptor_Nombre", typeof(string));

            dtComprobante.Columns.Add("ClaveProdServ", typeof(string));
            dtComprobante.Columns.Add("ClaveUnidad", typeof(string));
            dtComprobante.Columns.Add("NoIdentificacion", typeof(string));
            dtComprobante.Columns.Add("Cantidad", typeof(string));
            dtComprobante.Columns.Add("Unidad", typeof(string));
            dtComprobante.Columns.Add("Descripcion", typeof(string));
            dtComprobante.Columns.Add("ValorUnitario", typeof(string));
            dtComprobante.Columns.Add("Importe", typeof(string));

            dtComprobante.Columns.Add("IVA_Base", typeof(string));
            dtComprobante.Columns.Add("IVA_Impuesto", typeof(string));
            dtComprobante.Columns.Add("IVA_TipoFactor", typeof(string));
            dtComprobante.Columns.Add("IVA_TasaOCuota", typeof(string));
            dtComprobante.Columns.Add("IVA_Importe", typeof(string));

            dtComprobante.Columns.Add("Retenecion_Base", typeof(string));
            dtComprobante.Columns.Add("Retenecion_Impuesto", typeof(string));
            dtComprobante.Columns.Add("Retenecion_TipoFactor", typeof(string));
            dtComprobante.Columns.Add("Retenecion_TasaOCuota", typeof(string));
            dtComprobante.Columns.Add("Retenecion_Importe", typeof(string));

            dtComprobante.Columns.Add("TotalImpuestosRetenidos", typeof(string));
            dtComprobante.Columns.Add("TotalImpuestosTrasladados", typeof(string));

            dtComprobante.Columns.Add("UUID", typeof(string));
            dtComprobante.Columns.Add("FechaTimbrado", typeof(string));
            dtComprobante.Columns.Add("RfcProvCertif", typeof(string));
            dtComprobante.Columns.Add("SelloCFD", typeof(string));
            dtComprobante.Columns.Add("NoCertificadoSAT", typeof(string));
            dtComprobante.Columns.Add("SelloSAT", typeof(string));
            dtComprobante.Columns.Add("QrCode", typeof(string));
            dtComprobante.Columns.Add("Importe_Letra", typeof(string));
            dtComprobante.Columns.Add("Cadena_Original", typeof(string));
            dtComprobante.Columns.Add("UUID_Anterior", typeof(string));
            dtComprobante.Columns.Add("Num_Factura", typeof(string));
            dtComprobante.Columns.Add("ArmadoGuias", typeof(string));

            int fila = 0;
            foreach (DataRow row in DS.Tables["Concepto"].Rows)
            {
                if (fila < DS.Tables["Concepto"].Rows.Count)
                {
                    DataRow dtdRow = dtComprobante.NewRow();
                    dtdRow["Empresa"] = Empresa;
                    dtdRow["Serie"] = DS.Tables["Comprobante"].Rows[0]["Serie"].ToString();
                    dtdRow["Folio"] = DS.Tables["Comprobante"].Rows[0]["Folio"].ToString();
                    dtdRow["Fecha"] = DS.Tables["Comprobante"].Rows[0]["Fecha"].ToString();
                    dtdRow["Sello"] = DS.Tables["Comprobante"].Rows[0]["Sello"].ToString();
                    dtdRow["NoCertificado"] = DS.Tables["Comprobante"].Rows[0]["NoCertificado"].ToString();
                    dtdRow["Certificado"] = DS.Tables["Comprobante"].Rows[0]["Certificado"].ToString();
                    dtdRow["SubTotal"] = DS.Tables["Comprobante"].Rows[0]["SubTotal"].ToString();
                    dtdRow["Moneda"] = DS.Tables["Comprobante"].Rows[0]["Moneda"].ToString();
                    dtdRow["Total"] = DS.Tables["Comprobante"].Rows[0]["Total"].ToString();
                    dtdRow["TipoDeComprobante"] = DS.Tables["Comprobante"].Rows[0]["TipoDeComprobante"].ToString();
                    dtdRow["FormaPago"] = DS.Tables["Comprobante"].Rows[0]["FormaPago"].ToString();
                    dtdRow["MetodoPago"] = DS.Tables["Comprobante"].Rows[0]["MetodoPago"].ToString();
                    //dtdRow["CondicionesDePago"] = DS.Tables["Comprobante"].Rows[0]["CondicionesDePago"].ToString();
                    try { dtdRow["Descuento"] = DS.Tables["Comprobante"].Rows[0]["Descuento"].ToString(); }
                    catch
                    {
                        dtdRow["Descuento"] = "0";
                    }
                    dtdRow["TipoCambio"] = DS.Tables["Comprobante"].Rows[0]["TipoCambio"].ToString();
                    dtdRow["LugarExpedicion"] = DS.Tables["Comprobante"].Rows[0]["LugarExpedicion"].ToString();
                    dtdRow["Emisor_Rfc"] = DS.Tables["Emisor"].Rows[0]["Rfc"].ToString();
                    dtdRow["Emisor_Nombre"] = DS.Tables["Emisor"].Rows[0]["Nombre"].ToString();
                    dtdRow["RegimenFiscal"] = DS.Tables["Emisor"].Rows[0]["RegimenFiscal"].ToString();
                    dtdRow["UsoCFDI"] = DS.Tables["Receptor"].Rows[0]["UsoCFDI"].ToString();
                    dtdRow["Receptor_Rfc"] = DS.Tables["Receptor"].Rows[0]["Rfc"].ToString();
                    dtdRow["Receptor_Nombre"] = DS.Tables["Receptor"].Rows[0]["Nombre"].ToString();

                    dtdRow["ClaveProdServ"] = row["ClaveProdServ"].ToString();
                    dtdRow["ClaveUnidad"] = row["ClaveUnidad"].ToString();
                    //dtdRow["NoIdentificacion"] = row["NoIdentificacion"].ToString();BETO
                    dtdRow["Cantidad"] = row["Cantidad"].ToString();
                    dtdRow["Unidad"] = row["Unidad"].ToString();
                    dtdRow["Descripcion"] = row["Descripcion"].ToString();
                    dtdRow["ValorUnitario"] = row["ValorUnitario"].ToString();
                    dtdRow["Importe"] = row["Importe"].ToString();

                    dtdRow["IVA_Base"] = DS.Tables["Traslado"].Rows[fila]["Base"].ToString();
                    dtdRow["IVA_Impuesto"] = DS.Tables["Traslado"].Rows[fila]["Impuesto"].ToString();
                    dtdRow["IVA_TipoFactor"] = DS.Tables["Traslado"].Rows[fila]["TipoFactor"].ToString();
                    dtdRow["IVA_TasaOCuota"] = DS.Tables["Traslado"].Rows[fila]["TasaOCuota"].ToString();
                    dtdRow["IVA_Importe"] = DS.Tables["Traslado"].Rows[fila]["Importe"].ToString();

                    try
                    {
                        dtdRow["Retenecion_Base"] = DS.Tables["Retencion"].Rows[fila]["Base"].ToString();
                        dtdRow["Retenecion_Impuesto"] = DS.Tables["Retencion"].Rows[fila]["Impuesto"].ToString();
                        dtdRow["Retenecion_TipoFactor"] = DS.Tables["Retencion"].Rows[fila]["TipoFactor"].ToString();
                        dtdRow["Retenecion_TasaOCuota"] = DS.Tables["Retencion"].Rows[fila]["TasaOCuota"].ToString();
                        dtdRow["Retenecion_Importe"] = DS.Tables["Retencion"].Rows[fila]["Importe"].ToString();
                    }
                    catch { }

                    foreach (DataRow raw in DS.Tables["Impuestos"].Rows)
                    {
                        dtdRow["TotalImpuestosTrasladados"] = raw["TotalImpuestosTrasladados"].ToString();
                        try { dtdRow["TotalImpuestosRetenidos"] = raw["TotalImpuestosRetenidos"].ToString(); } catch { dtdRow["TotalImpuestosRetenidos"] = 0.00; }
                    }

                    dtdRow["UUID"] = DS.Tables["TimbreFiscalDigital"].Rows[0]["UUID"].ToString();
                    dtdRow["FechaTimbrado"] = DS.Tables["TimbreFiscalDigital"].Rows[0]["FechaTimbrado"].ToString();
                    dtdRow["RfcProvCertif"] = DS.Tables["TimbreFiscalDigital"].Rows[0]["RfcProvCertif"].ToString();
                    dtdRow["SelloCFD"] = DS.Tables["TimbreFiscalDigital"].Rows[0]["SelloCFD"].ToString();
                    dtdRow["NoCertificadoSAT"] = DS.Tables["TimbreFiscalDigital"].Rows[0]["NoCertificadoSAT"].ToString();
                    dtdRow["SelloSAT"] = DS.Tables["TimbreFiscalDigital"].Rows[0]["SelloSAT"].ToString();
                    dtdRow["QrCode"] = GlobalVar.rutaExe + "/_temp/" + DS.Tables["Comprobante"].Rows[0]["Serie"].ToString() + "-" + DS.Tables["Comprobante"].Rows[0]["Folio"].ToString() + ".jpg";
                    string letras = c.enletras(DS.Tables["Comprobante"].Rows[0]["Total"].ToString()).ToLower() + "MXN.";
                    dtdRow["Importe_Letra"] = letras;
                    dtdRow["Cadena_Original"] = Cadena_Original;

                    dtComprobante.Rows.Add(dtdRow);
                    fila++;
                }
            }



            DataSet ds = new DataSet();

            ds.Tables.Add(dtComprobante);

            return ds;
        }
    }
}
