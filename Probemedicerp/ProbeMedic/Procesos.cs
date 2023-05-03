using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Drawing;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic
{
    public class Procesos
    {
        Generales SqlGenerales = new Generales();
        SQLAdministracion SqlAdministracion = new SQLAdministracion();
        SQLAlmacen SqlAlmacen = new SQLAlmacen();
        SQLVentas SqlVentas = new SQLVentas();
        Funciones Fx = new Funciones();

        DataTable DtReporte = new DataTable();
        DataTable DtTipoReporte = new DataTable();
        DataTable DtAlmacen = new DataTable();

        public void CargarTipoReporte(ref ComboBox CbxTipoReporte)
        {
            DtTipoReporte =SqlGenerales.Sk_Tipo_Reporte();

            if (DtTipoReporte != null)
            {
                if (DtTipoReporte.Rows.Count > 0)
                {
                    int indice = -1;
                    indice = 0;
                    Fx.LlenaCombo(DtTipoReporte, ref CbxTipoReporte, "K_Tipo_Reporte", "D_Tipo_Reporte",indice);
                }

            }
        }

        public void CargarReporte(Int32 K_Tipo_Reporte,ref ComboBox CbxReporte)
        {
            DtReporte = SqlGenerales.Sk_Reportes(K_Tipo_Reporte);

            if (DtReporte != null)
            {
                if (DtReporte.Rows.Count > 0)
                {
                    int indice = -1;
                    indice = 0;
                    Fx.LlenaCombo(DtReporte, ref CbxReporte, "K_Reporte", "D_Reporte", indice);
                }

            }
        }
        
        public DataTable ConstruirTypeAlmacenes(List<Int32> LstAlmacenesSeleccionados)
        {
            foreach (var item in LstAlmacenesSeleccionados)
            {
                DataRow row = DtAlmacen.NewRow();
                row["K_Almacen"] = item;

                DtAlmacen.Rows.Add(row);
                DtAlmacen.AcceptChanges();
            }
            return DtAlmacen;
        }

        public void Reporte_Sk_Rep_Nota_Credito_Interna(Int32 K_Factura,Int32 K_Almacen,Int32 K_Cliente, DateTime F_Inicial, DateTime F_Final,DataTable DtCliente, DataTable DtAlmacen)
        {
            ADMINISTRACION.REPORTES.RPT_Concentrado_Notas Rpt = new ADMINISTRACION.REPORTES.RPT_Concentrado_Notas();
            DataTable Dt = SqlAdministracion.Sk_Rep_Nota_Credito_Interna(K_Factura,K_Almacen,K_Cliente, F_Inicial, F_Final,DtCliente,DtAlmacen);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "Concentrado de Notas";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void Reporte_CxC_Cliente_Factura(string PC_Name , Int32 K_Usuario, Int32 K_Factura, DataTable DtAlmacen, DataTable DtCliente, Int32 K_Canal_Distribucion, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final)
        {
            ADMINISTRACION.REPORTES.RPT_CxC_ClienteFactura Rpt = new ADMINISTRACION.REPORTES.RPT_CxC_ClienteFactura();
            DataTable Dt = SqlAdministracion.Gp_Reporte_AnaliticoFacturas(PC_Name,K_Usuario, K_Factura, DtAlmacen, DtCliente, K_Canal_Distribucion, K_Empresa,F_Inicial,F_Final);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "Cuentas x Cobrar por Cliente y Factura";
                Frm.P_ReporteRPT =Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void Reporte_CXC_Por_Cliente(string PC_Name, Int32 K_Usuario, Int32 K_Factura, DataTable DtAlmacen, DataTable DtCliente, Int32 K_Canal_Distribucion, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final)
        {
            ADMINISTRACION.REPORTES.RPT_CXC_Por_Cliente Rpt = new ADMINISTRACION.REPORTES.RPT_CXC_Por_Cliente();
            DataTable Dt = SqlAdministracion.Gp_Reporte_AnaliticoFacturas(PC_Name, K_Usuario, K_Factura, DtAlmacen, DtCliente, K_Canal_Distribucion, K_Empresa, F_Inicial, F_Final);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "Cuentas x Cobrar por Cliente";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_ArticulosTransito(Int32 K_Articulo, DataTable DtAlmacen,DataTable DtLaboratorio)
        {
            INVENTARIOS.REPORTES.RPT_Articulos_En_Transito Rpt = new INVENTARIOS.REPORTES.RPT_Articulos_En_Transito();
            DataTable Dt = SqlAlmacen.Gp_Reporte_Transito(K_Articulo,DtAlmacen,DtLaboratorio);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "Artículos en Transito";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_Stock(DataTable DtAlmacen, DataTable DtLaboratorio,Int32 K_Articulo,Int32 K_Proveedor,bool B_Laboratorio)
        {
            INVENTARIOS.REPORTES.RPT_Stock_Lab_Lg Rpt = new INVENTARIOS.REPORTES.RPT_Stock_Lab_Lg();
            DataTable Dt = SqlAlmacen.Gp_Reporte_Stock(DtAlmacen, DtLaboratorio,K_Articulo,K_Proveedor,B_Laboratorio);
            try
            {
                if ((Dt != null) || (Dt.Rows.Count == 0))
                {
                    Frm_Reportes Frm = new Frm_Reportes();
                    Rpt.SetDataSource(Dt);
                    if (B_Laboratorio)
                    {
                        Rpt.SetParameterValue("Tipo_Stock", "Laboratorio");
                        Frm.P_Titulo = "Stock de Laboratorios";
                    }

                    else
                    {
                        Rpt.SetParameterValue("Tipo_Stock", "LG");
                        Frm.P_Titulo = "Stock de LG";
                    }

                    Frm.P_ReporteRPT = Rpt;
                  
                    Frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception) { }

            
        }

        public void Reporte_CXC_ProdClieFact(Int32 K_Factura, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final, DataTable DtAlmacen, DataTable DtCliente,Int32 K_Canal_Distribucion_Cliente)
        {
            ADMINISTRACION.REPORTES.RPT_CXC_ProdClieFact Rpt = new ADMINISTRACION.REPORTES.RPT_CXC_ProdClieFact();
            DataTable Dt = SqlAdministracion.Gp_Reporte_AnaliticoArticulos(K_Factura,K_Empresa,F_Inicial,F_Final,DtCliente,DtAlmacen,K_Canal_Distribucion_Cliente);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "CXC por Producto, Cliente y Factura";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataSet Generatabla_Factura(DataSet DS, string Empresa,string Cadena_Original,string qrCode)
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
                    dtdRow["QrCode"] = GlobalVar.rutaExe + "/_temp/" +  DS.Tables["Comprobante"].Rows[0]["Serie"].ToString() + "-" + DS.Tables["Comprobante"].Rows[0]["Folio"].ToString() + ".jpg";
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

        public void Genera_PDF(string Serie, string Folio)
        {
            DataTable Dt = SqlAdministracion.GP_Xml_Factura(Convert.ToInt32(Folio), Serie);

            string Cadena_XML = Dt.Rows[0]["Cadena_XML"].ToString();
            string Cadena_Original = Dt.Rows[0]["Cadena_Original"].ToString();

            string qrCode = Dt.Rows[0]["qrCode"].ToString();

            DataSet ds = new DataSet();
            ds.ReadXml(new StringReader(Cadena_XML));

            //Genera PDF
            DataSet dsComprobante = Generatabla_Factura(ds, Dt.Rows[0]["Empresa"].ToString(), Dt.Rows[0]["Cadena_Original"].ToString(),qrCode);
            Imprimir_eFactura(Convert.ToInt32(Folio), dsComprobante, qrCode,Serie);

        }
        public void Imprimir_eFactura(decimal K_Factura, DataSet Ds, string QR,string serie)
        {
            FACTURACION.Formato objRpt = new FACTURACION.Formato();

            Ds.Tables[0].TableName = "dtFactura";
            //QR = Ds.Tables[0].Rows[0]["QrCode"].ToString();
            //Guardo QR

            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrEncoder.Encode(QR);
            var renderer = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);


            using (var stream = new FileStream(@"" + Ds.Tables[0].Rows[0]["QrCode"].ToString(), FileMode.Create))
            {
                renderer.WriteToStream(qrCode.Matrix, System.Drawing.Imaging.ImageFormat.Jpeg, stream);
            }

            //objRpt.SetDataSource(Ds);

            // System.IO.File.Delete(Ds.Tables[0].Rows[0]["QrCode"].ToString());
            try
            {
                objRpt.SetDataSource(Ds);

                ProbeMedic.AppCode.BLL.SQLAdministracion o = new ProbeMedic.AppCode.BLL.SQLAdministracion();

                int k_cliente;

                k_cliente = o.sClienteFactura_select(Convert.ToInt32(K_Factura), serie);

                objRpt.SetParameterValue("paciente", o.sNombrePacienteFactura_select(Convert.ToInt32(K_Factura), serie));
                objRpt.SetParameterValue("observaciones", o.sObservacionesFactura_select(Convert.ToInt32(K_Factura), serie));
                objRpt.SetParameterValue("direccion", o.sDireccionesFactura_select(Convert.ToInt32(k_cliente)));
                objRpt.SetParameterValue("Lote", o.sFacturaLote_select(Convert.ToInt32(K_Factura), serie));

                //objRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"" + Program.Escritorio + "/_temp/" + Ds.Tables[0].Rows[0]["Serie"].ToString() + "-" + Ds.Tables[0].Rows[0]["Folio"].ToString() + ".pdf");
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "";
                Frm.P_ReporteRPT = objRpt;
                Frm.ShowDialog();


            }
            catch (Exception ex)
            {
                string ass = ex.ToString();
            }
            try
            {
                System.IO.File.Delete(Ds.Tables[0].Rows[0]["QrCode"].ToString());
            }
            catch { }

            objRpt.Close(); objRpt.Dispose();
        }


        public void Rep_CobranzaPorClienteYFolio(Int32 K_Usuario,Int32 K_Factura, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final, DataTable DtAlmacen, DataTable DtCliente, Int32 K_Canal_Distribucion_Cliente,Int32 K_Tipo_Pago)
        {
            ADMINISTRACION.REPORTES.CobPorClienteYFolio Rpt = new ADMINISTRACION.REPORTES.CobPorClienteYFolio();
            DataTable Dt = SqlAdministracion.Rep_CobranzaAnalitico(K_Usuario,K_Factura, K_Empresa, F_Inicial, F_Final, DtAlmacen,DtCliente, K_Canal_Distribucion_Cliente,K_Tipo_Pago);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "COBRANZA POR CLIENTE Y FOLIO";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_CobranzaPorCuentaTipoYSubTipo(Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final)
        {
            ADMINISTRACION.REPORTES.COB_POR_CTA_TIPO_SUBTIPO Rpt = new ADMINISTRACION.REPORTES.COB_POR_CTA_TIPO_SUBTIPO();
            DataTable Dt = SqlAdministracion.Gp_RepCuenta_Tipo_Pago(K_Empresa, F_Inicial, F_Final);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "COBRANZA POR CUENTA, TIPO Y SUBTIPO";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_CobranzaPorMes(Int32 K_Empresa, Int32 Anio)
        {
            ADMINISTRACION.REPORTES.COB_POR_MES Rpt = new ADMINISTRACION.REPORTES.COB_POR_MES();
            DataTable Dt = SqlAdministracion.Gp_RepCuentaMeses(K_Empresa, Anio);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "COBRANZA POR MES";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_ConsecutivoFacturasVentas(Int32 K_Empresa, DateTime F_Inicial,DateTime F_Final,DataTable Clientes,bool B_Pagada)
        {
            ADMINISTRACION.REPORTES.CONSECUTIVO_FACTURAS Rpt = new ADMINISTRACION.REPORTES.CONSECUTIVO_FACTURAS();
            DataTable Dt = SqlAdministracion.Rep_FacturasAnalitico(K_Empresa,F_Inicial,F_Final,Clientes,B_Pagada);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                if(B_Pagada)
                {
                    Rpt.SetParameterValue("P_Estatus_Facturas", "PAGADAS");
                }
                else
                {
                    Rpt.SetParameterValue("P_Estatus_Facturas", "NO PAGADAS");
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "CONSECUTIVO DE FACTURAS";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_ConsecutivoFacturasDesglozado(Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final, DataTable Clientes, bool B_Pagada)
        {
            ADMINISTRACION.REPORTES.CONSECUTIVO_FACTURAS_DESGLOZADO Rpt = new ADMINISTRACION.REPORTES.CONSECUTIVO_FACTURAS_DESGLOZADO();
            DataTable Dt = SqlAdministracion.Rep_FacturasAnalitico(K_Empresa, F_Inicial, F_Final, Clientes, B_Pagada);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                if (B_Pagada)
                {
                    Rpt.SetParameterValue("P_Estatus_Facturas", "PAGADAS");
                }
                else
                {
                    Rpt.SetParameterValue("P_Estatus_Facturas", "NO PAGADAS");
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "CONSECUTIVO DE FACTURAS DESGLOZADO DE VENTAS";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_DiasRealesPagoAnaliticoPorCliente(string PC_Name,Int32 K_Usuario,Int32 K_Factura, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final,
            DataTable Almacenes,DataTable Clientes, Int32 K_Canal_Distribucion_Cliente)
        {
            ADMINISTRACION.REPORTES.RPT_DIAS_REALES_PAGO_ANALITICO Rpt = new ADMINISTRACION.REPORTES.RPT_DIAS_REALES_PAGO_ANALITICO();
            DataTable Dt = SqlAdministracion.Gp_RepFacturasDiasPagos(PC_Name,GlobalVar.K_Usuario,K_Factura, K_Empresa, F_Inicial, F_Final, 
                Almacenes,Clientes, K_Canal_Distribucion_Cliente);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "DIAS REALES DE PAGO ANALITICO POR CLIENTE";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_DiasRealesPagoGlobalPorCliente(string PC_Name, Int32 K_Usuario, Int32 K_Factura, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final,
        DataTable Almacenes, DataTable Clientes, Int32 K_Canal_Distribucion_Cliente)
        {
            ADMINISTRACION.REPORTES.DIAS_REALES_PAGO_GLOBAL_CLIENTE Rpt = new ADMINISTRACION.REPORTES.DIAS_REALES_PAGO_GLOBAL_CLIENTE();
            DataTable Dt = SqlAdministracion.Gp_RepFacturasDiasPagos(PC_Name, GlobalVar.K_Usuario, K_Factura, K_Empresa, F_Inicial, F_Final,
                Almacenes, Clientes, K_Canal_Distribucion_Cliente);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "DIAS REALES DE PAGO GLOBAL POR CLIENTE";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_DiasRealesPagoGlobal(string PC_Name, Int32 K_Usuario, Int32 K_Factura, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final,
     DataTable Almacenes, DataTable Clientes, Int32 K_Canal_Distribucion_Cliente)
        {
            ADMINISTRACION.REPORTES.RPT_DIAS_REALES_PAGO_GLOBAL Rpt = new ADMINISTRACION.REPORTES.RPT_DIAS_REALES_PAGO_GLOBAL();
            DataTable Dt = SqlAdministracion.Gp_RepFacturasDiasPagos(PC_Name, GlobalVar.K_Usuario, K_Factura, K_Empresa, F_Inicial, F_Final,
                Almacenes, Clientes, K_Canal_Distribucion_Cliente);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "DIAS REALES DE PAGO GLOBAL";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void Rep_MovimientosArticulos(bool B_SinMovimiento)
        {
            DataTable Dt = new DataTable();
            
            if (B_SinMovimiento)
            {
                INVENTARIOS.REPORTES.MEDICAMENTO_SIN_MOVIMIENTOrpt Rpt = new INVENTARIOS.REPORTES.MEDICAMENTO_SIN_MOVIMIENTOrpt();
                Dt = SqlAlmacen.Gp_RepMovimientosArticulos(1,0);

                try
                {
                    if ((Dt != null) || (Dt.Rows.Count == 0))
                    {
                        Frm_Reportes Frm = new Frm_Reportes();
                        Rpt.SetDataSource(Dt);
                        Frm.P_ReporteRPT = Rpt;
                        Frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception) { }
            }
            else
            {
                INVENTARIOS.REPORTES.MEDICAMENTO_LENTO_DESPLAZAMIENTO Rpt = new INVENTARIOS.REPORTES.MEDICAMENTO_LENTO_DESPLAZAMIENTO();
                Dt = SqlAlmacen.Gp_RepMovimientosArticulos(2, 0);


                try
                {
                    if ((Dt != null) || (Dt.Rows.Count == 0))
                    {
                        Frm_Reportes Frm = new Frm_Reportes();
                        Rpt.SetDataSource(Dt);
                        Frm.P_ReporteRPT = Rpt;
                        Frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception) { }
            }
      
          


        }


        public void Rep_PedidosParciales()
        {
            INVENTARIOS.REPORTES.PEDIDOS_CON_PARCIALIDAD Rpt = new INVENTARIOS.REPORTES.PEDIDOS_CON_PARCIALIDAD();
            DataTable Dt = SqlAlmacen.Gp_RepPedidosParciales();
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "PEDIDOS CON PARCIALIDAD";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void Rep_FacturasVPrivada(Int32 K_Almacen)
        {
            INVENTARIOS.REPORTES.FACTURAS_REALIZADAS_VENTAS_PRIVADAS Rpt = new INVENTARIOS.REPORTES.FACTURAS_REALIZADAS_VENTAS_PRIVADAS();
            DataTable Dt = SqlAlmacen.Gp_RepVentasPrivadas(K_Almacen);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "FACTURAS REALIZADAS VENTAS PRIVADAS";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        public void Rep_PedidosSinRemision(Int32 K_Almacen)
        {
            INVENTARIOS.REPORTES.PEDIDOS_SIN_REMISION Rpt = new INVENTARIOS.REPORTES.PEDIDOS_SIN_REMISION();
            DataTable Dt = SqlAlmacen.Gp_Pedidos_SinRemision(K_Almacen);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "PEDIDOS SIN REMISION X ALMACEN";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_VentasGlobales(string PC_Name, Int32 K_Usuario, bool B_Farmacia,bool B_VentaPrivada,bool B_Aseguradora,bool B_Coaseguro,
            DateTime F_Inicial, DateTime F_Final,DataTable Clientes)
        {
            ADMINISTRACION.REPORTES.RPT_FACTURACION Rpt = new ADMINISTRACION.REPORTES.RPT_FACTURACION();
            DataTable Dt = SqlAdministracion.Gp_Reporte_VentasGlobales(PC_Name, GlobalVar.K_Usuario,B_Farmacia,B_VentaPrivada,B_Aseguradora,B_Coaseguro,
                F_Inicial, F_Final, Clientes);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                var x = Dt.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<decimal>("Total_Pedido"))).Sum();
      
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "REPORTE DE FACTURACIÓN";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Rpt.SetParameterValue("@Total_Acumulado", Convert.ToDecimal(x));
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_RemisionesPorFacturar()
        {
            ADMINISTRACION.REPORTES.REMISIONES_POR_FACTURAR Rpt = new ADMINISTRACION.REPORTES.REMISIONES_POR_FACTURAR();
            DataTable Dt = SqlAdministracion.Gp_RepRemisionesPorFacturar();
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "REMISIONES PENDIENTES POR FACTURAR";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Rep_ConsultaUtilidad(DateTime F_Inicial, DateTime F_Final)
        {
            ADMINISTRACION.REPORTES.MARGEN_UTILIDAD Rpt = new ADMINISTRACION.REPORTES.MARGEN_UTILIDAD();
            DataTable Dt = SqlAdministracion.Gp_Consulta_Utilidad(F_Inicial,F_Final);
            if (Dt != null)
            {
                if (Dt.Rows.Count == 0)
                {
                    return;
                }
                Frm_Reportes Frm = new Frm_Reportes();
                Frm.P_Titulo = "UTILIDAD DE VENTA DE ARTICULOS";
                Frm.P_ReporteRPT = Rpt;
                Rpt.SetDataSource(Dt);
                Frm.ShowDialog();
            }
            else
            {
                //this.Cursor = Cursors.Default;
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }





    }
}
