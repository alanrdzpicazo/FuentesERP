﻿using ProbeMedic.AppCode.DCC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.AppCode.BLL
{
    class SQLCuentasxPagar
    {
        public DataTable Gp_BuscaOC_CuentaxPagar(Int32 K_OrdenCompra, bool B_Acepta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_BuscaOC_CuentaxPagar";
            DataTable dt = new DataTable();

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Acepta", SqlDbType.Bit));

            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            cmd.Parameters["@B_Acepta"].Value = B_Acepta;

            dt = ConnectionClass.GetTable(ref cmd);


            return dt;
        }
        public int In_CxP(ref Int32 K_Cuenta_Pagar, Int32 K_Proveedor, string FolioFiscal, string Serie, string Folio, decimal Tipo_Cambio, Int32 K_Tipo_Moneda, decimal Subtotal, decimal Tasa_IVA, decimal Total_IVA, decimal TasaRetencion_IVA, decimal TotalRetencion_IVA, decimal Tasa_ISR, decimal Total_ISR, decimal TotalFactura, DateTime F_Factura, Int32 K_Orden_Compra, DateTime F_Vencimiento, bool B_CapturaDirecta, string Observaciones, string VersionXML, string Modulo, Int32 K_Usuario, DataTable DetalleCxP, ref string Mensaje)
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_CxP";

            IDataParameter p_K_Cuenta_Pagar = new SqlParameter("@K_Cuenta_Pagar", SqlDbType.Int);
            p_K_Cuenta_Pagar.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cuenta_Pagar);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FolioFiscal", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalFactura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Factura", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Vencimiento", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_CapturaDirecta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@VersionXML", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Modulo", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetalleCxP", SqlDbType.Structured));
            cmd.Parameters["@K_Cuenta_Pagar"].Value = K_Cuenta_Pagar;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@FolioFiscal"].Value = FolioFiscal;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@TasaRetencion_IVA"].Value = TasaRetencion_IVA;
            cmd.Parameters["@TotalRetencion_IVA"].Value = TotalRetencion_IVA;
            cmd.Parameters["@Tasa_ISR"].Value = Tasa_ISR;
            cmd.Parameters["@Total_ISR"].Value = Total_ISR;
            cmd.Parameters["@TotalFactura"].Value = TotalFactura;
            cmd.Parameters["@F_Factura"].Value = F_Factura;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@F_Vencimiento"].Value = F_Vencimiento;
            cmd.Parameters["@B_CapturaDirecta"].Value = B_CapturaDirecta;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@Modulo"].Value = "MANUAL";
            cmd.Parameters["@Modulo"].Value = Modulo;
            cmd.Parameters["@VersionXML"].Value = VersionXML;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@DetalleCxP"].Value = DetalleCxP;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cuenta_Pagar = (Int32)p_K_Cuenta_Pagar.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_Autoriza_CxP(DataTable Generico, Int32 K_Usuario, string PC_Name, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Autoriza_CxP";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Generico", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));

            cmd.Parameters["@Generico"].Value = Generico;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_ConsultaCxP_PorAutorizar(Int32 K_Proveedor, Int16 K_Tipo_Moneda, DateTime F_Inicial, DateTime F_Final, Int32 K_Orden_Compra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaCxP_PorAutorizar";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Gp_Paga_CxP(ref Int32 K_Pago, Int32 K_Proveedor, Int16 K_Tipo_Pago, Int32 K_Cuenta_Empresa, Int32 K_Cuenta_Proveedor, decimal Importe_Efectivo,
            decimal Importe_Cheque, string Cuenta_Cheques, string Numero_Cheque, decimal Importe_Transferencia, string Cuenta_Transferencia, string Numero_Transferencia, 
            string Referencia_Transferencia, decimal Importe_NotaCredito, string Numero_NotaCredito, decimal Importe_Incobrable, Int32 K_Usuario_Autoriza, bool B_Dolares, 
            decimal TipoCambio, Int32 K_Usuario_Registra, string PC_Name, DataTable DetallePago, ref string Mensaje, ref Int32 Consecutivo, Int32 K_Anticipo_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Paga_CxP";

            IDataParameter p_K_Pago = new SqlParameter("@K_Pago", SqlDbType.Int);
            p_K_Pago.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pago);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Pago", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Importe_Efectivo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Importe_Cheque", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Cheques", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cheque", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Importe_Transferencia", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Transferencia", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Numero_Transferencia", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Referencia_Transferencia", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Importe_NotaCredito", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Numero_NotaCredito", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Importe_Incobrable", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Autoriza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Dolares", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@TipoCambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Registra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Anticipo_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetallePago", SqlDbType.Structured));

            cmd.Parameters["@K_Pago"].Value = K_Pago;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Pago"].Value = K_Tipo_Pago;
            cmd.Parameters["@K_Cuenta_Empresa"].Value = K_Cuenta_Empresa;
            cmd.Parameters["@K_Cuenta_Proveedor"].Value = K_Cuenta_Proveedor;
            cmd.Parameters["@Importe_Efectivo"].Value = Importe_Efectivo;
            cmd.Parameters["@Importe_Cheque"].Value = Importe_Cheque;
            cmd.Parameters["@Cuenta_Cheques"].Value = Cuenta_Cheques;
            cmd.Parameters["@Numero_Cheque"].Value = Numero_Cheque;
            cmd.Parameters["@Importe_Transferencia"].Value = Importe_Transferencia;
            cmd.Parameters["@Cuenta_Transferencia"].Value = Cuenta_Transferencia;
            cmd.Parameters["@Numero_Transferencia"].Value = Numero_Transferencia;
            cmd.Parameters["@Referencia_Transferencia"].Value = Referencia_Transferencia;
            cmd.Parameters["@Importe_NotaCredito"].Value = Importe_NotaCredito;
            cmd.Parameters["@Numero_NotaCredito"].Value = Numero_NotaCredito;
            cmd.Parameters["@Importe_Incobrable"].Value = Importe_Incobrable;
            cmd.Parameters["@K_Usuario_Autoriza"].Value = K_Usuario_Autoriza;
            cmd.Parameters["@B_Dolares"].Value = B_Dolares;
            cmd.Parameters["@TipoCambio"].Value = TipoCambio;
            cmd.Parameters["@K_Usuario_Registra"].Value = K_Usuario_Registra;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@DetallePago"].Value = DetallePago;
            if (K_Anticipo_Proveedor == 0)
            {
                cmd.Parameters["@K_Anticipo_Proveedor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Anticipo_Proveedor"].Value = K_Anticipo_Proveedor;
            }
            cmd.Parameters["@Mensaje"].Value = Mensaje;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Pago = (Int32)p_K_Pago.Value;
            Mensaje = (string)p_Mensaje.Value;
            Consecutivo = (Int32)p_Consecutivo.Value;

            return res;
        }
        public DataTable Sk_Recepcion_Archivos_Proveedores(Int32 K_Proveedor, Int32? K_Orden_Compra, string Serie, Int32? Folio, Int32? K_CxP, string TipoDocumento, Int32 K_Estatus, Int32? K_Operacion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Recepcion_Archivos_Proveedores";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_CxP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Operacion", SqlDbType.Int));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@K_CxP"].Value = K_CxP;
            cmd.Parameters["@TipoDocumento"].Value = TipoDocumento;
            cmd.Parameters["@K_Estatus"].Value = K_Estatus;
            cmd.Parameters["@K_Operacion"].Value = K_Operacion;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_proveedores_cuentas_bancarias(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_proveedores_cuentas_bancarias";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Consulta_Facturas_PtePago(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Consulta_Facturas_PtePago";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_ObtieneUltimoFolioPagosCxP()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ObtieneUltimoFolioPagosCxP";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Consulta_Facturas_PtePago(Int32 K_Proveedor, bool B_Autorizadas)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Consulta_Facturas_PtePago";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizadas", SqlDbType.Bit));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@B_Autorizadas"].Value = B_Autorizadas;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public int Gp_BuscaOC_CuentaxPagar(Int32 K_OrdenCompra, bool B_Acepta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_BuscaOC_CuentaxPagar";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Acepta", SqlDbType.Bit));

            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            cmd.Parameters["@B_Acepta"].Value = B_Acepta;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Nota_Credito_Proveedor(ref Int32 K_Nota_Credito, Int32 K_Proveedor, string FolioFiscal, string Serie, string Folio, decimal Tipo_Cambio, Int16 K_Tipo_Moneda, decimal Subtotal, decimal Tasa_IVA, decimal Total_IVA, decimal TasaRetencion_IVA, decimal TotalRetencion_IVA, decimal Tasa_ISR, decimal Total_ISR, decimal TotalNota, DateTime F_Nota, string Referencia, string Observaciones, string VersionXML, Int32 K_Usuario, DataTable DetalleNotaProveedor,
                                              string SerieReferencia, string FolioReferencia, ref string Mensaje)
        {
            //***NO BORRAR ESTE METODO PORQUE TIENE CODIGO QUE NO PONE EL GENERACODIGOBLL
            //SqlXml misqlxml;
            //string sSXML = XML.InnerXml;
            //sSXML = @fx.QuitaCaracteresIlegalesXML(sSXML);
            //misqlxml = new SqlXml(new System.Xml.XmlTextReader(sSXML, System.Xml.XmlNodeType.Document, null));

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Nota_Credito_Proveedor";

            IDataParameter p_K_Nota_Credito = new SqlParameter("@K_Nota_Credito", SqlDbType.Int);
            p_K_Nota_Credito.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nota_Credito);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FolioFiscal", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalNota", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Nota", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Referencia", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@VersionXML", SqlDbType.VarChar, 10));
            //cmd.Parameters.Add(new SqlParameter("@XML", SqlDbType.Xml));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetalleNotaProveedor", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@SerieReferencia", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@FolioReferencia", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Nota_Credito"].Value = K_Nota_Credito;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@FolioFiscal"].Value = FolioFiscal;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@TasaRetencion_IVA"].Value = TasaRetencion_IVA;
            cmd.Parameters["@TotalRetencion_IVA"].Value = TotalRetencion_IVA;
            cmd.Parameters["@Tasa_ISR"].Value = Tasa_ISR;
            cmd.Parameters["@Total_ISR"].Value = Total_ISR;
            cmd.Parameters["@TotalNota"].Value = TotalNota;
            cmd.Parameters["@F_Nota"].Value = F_Nota;
            cmd.Parameters["@Referencia"].Value = Referencia;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@VersionXML"].Value = VersionXML;
            //cmd.Parameters["@XML"].Value = misqlxml;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@DetalleNotaProveedor"].Value = DetalleNotaProveedor;
            cmd.Parameters["@SerieReferencia"].Value = SerieReferencia;
            cmd.Parameters["@FolioReferencia"].Value = FolioReferencia;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nota_Credito = (Int32)p_K_Nota_Credito.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int spi_Nota_Credito_Proveedor(ref Int32 K_Nota_Credito, Int32 K_Proveedor, string FolioFiscal, string Serie, string Folio, decimal Tipo_Cambio, Int16 K_Tipo_Moneda, decimal Subtotal, decimal Tasa_IVA, decimal Total_IVA, decimal TasaRetencion_IVA, decimal TotalRetencion_IVA, decimal Tasa_ISR, decimal Total_ISR, decimal TotalNota, DateTime F_Nota, string Referencia, string Observaciones, string VersionXML, Int32 K_Usuario, DataTable DetalleNotaProveedor,
                                              string SerieReferencia, string FolioReferencia, ref string Mensaje)
        {
            //***NO BORRAR ESTE METODO PORQUE TIENE CODIGO QUE NO PONE EL GENERACODIGOBLL
            //SqlXml misqlxml;
            //string sSXML = XML.InnerXml;
            //sSXML = @fx.QuitaCaracteresIlegalesXML(sSXML);
            //misqlxml = new SqlXml(new System.Xml.XmlTextReader(sSXML, System.Xml.XmlNodeType.Document, null));

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spi_Nota_Credito_Proveedor";

            IDataParameter p_K_Nota_Credito = new SqlParameter("@K_Nota_Credito", SqlDbType.Int);
            p_K_Nota_Credito.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nota_Credito);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FolioFiscal", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalNota", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Nota", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Referencia", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@VersionXML", SqlDbType.VarChar, 10));
            //cmd.Parameters.Add(new SqlParameter("@XML", SqlDbType.Xml));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetalleNotaProveedor", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@SerieReferencia", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@FolioReferencia", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Nota_Credito"].Value = K_Nota_Credito;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@FolioFiscal"].Value = FolioFiscal;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@TasaRetencion_IVA"].Value = TasaRetencion_IVA;
            cmd.Parameters["@TotalRetencion_IVA"].Value = TotalRetencion_IVA;
            cmd.Parameters["@Tasa_ISR"].Value = Tasa_ISR;
            cmd.Parameters["@Total_ISR"].Value = Total_ISR;
            cmd.Parameters["@TotalNota"].Value = TotalNota;
            cmd.Parameters["@F_Nota"].Value = F_Nota;
            cmd.Parameters["@Referencia"].Value = Referencia;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@VersionXML"].Value = VersionXML;
            //cmd.Parameters["@XML"].Value = misqlxml;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@DetalleNotaProveedor"].Value = DetalleNotaProveedor;
            cmd.Parameters["@SerieReferencia"].Value = SerieReferencia;
            cmd.Parameters["@FolioReferencia"].Value = FolioReferencia;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nota_Credito = (Int32)p_K_Nota_Credito.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Nota_Credito_Proveedor(ref Int32 K_Nota_Credito, Int32 K_Proveedor, string FolioFiscal, string Serie, string Folio, decimal Tipo_Cambio, Int16 K_Tipo_Moneda, decimal Subtotal, decimal Tasa_IVA, decimal Total_IVA, decimal TasaRetencion_IVA, decimal TotalRetencion_IVA, decimal Tasa_ISR, decimal Total_ISR, decimal TotalNota, DateTime F_Nota, string Referencia, string Observaciones, string VersionXML, Int32 K_Usuario, string Modulo, bool B_CapturaDirecta, string SerieReferencia, string FolioReferencia, DataTable DetalleNotaProveedor, ref string Mensaje)
        {
            //***NO BORRAR ESTE METODO PORQUE TIENE CODIGO QUE NO PONE EL GENERACODIGOBLL
            //SqlXml misqlxml;
            //string sSXML = XML.InnerXml;
            //sSXML = @fx.QuitaCaracteresIlegalesXML(sSXML);
            //misqlxml = new SqlXml(new System.Xml.XmlTextReader(sSXML, System.Xml.XmlNodeType.Document, null));

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spi_Nota_Credito_Proveedor";

            IDataParameter p_K_Nota_Credito = new SqlParameter("@K_Nota_Credito", SqlDbType.Int);
            p_K_Nota_Credito.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nota_Credito);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FolioFiscal", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalNota", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Nota", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Referencia", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@VersionXML", SqlDbType.VarChar, 10));
            //cmd.Parameters.Add(new SqlParameter("@XML", SqlDbType.Xml));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Modulo", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@B_CapturaDirecta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@SerieReferencia", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@FolioReferencia", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@DetalleNotaProveedor", SqlDbType.Structured));

            cmd.Parameters["@K_Nota_Credito"].Value = K_Nota_Credito;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@FolioFiscal"].Value = FolioFiscal;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@TasaRetencion_IVA"].Value = TasaRetencion_IVA;
            cmd.Parameters["@TotalRetencion_IVA"].Value = TotalRetencion_IVA;
            cmd.Parameters["@Tasa_ISR"].Value = Tasa_ISR;
            cmd.Parameters["@Total_ISR"].Value = Total_ISR;
            cmd.Parameters["@TotalNota"].Value = TotalNota;
            cmd.Parameters["@F_Nota"].Value = F_Nota;
            cmd.Parameters["@Referencia"].Value = Referencia;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@VersionXML"].Value = VersionXML;
            //cmd.Parameters["@XML"].Value = misqlxml;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Modulo"].Value = Modulo;
            cmd.Parameters["@B_CapturaDirecta"].Value = B_CapturaDirecta;
            cmd.Parameters["@SerieReferencia"].Value = SerieReferencia;
            cmd.Parameters["@FolioReferencia"].Value = FolioReferencia;
            cmd.Parameters["@DetalleNotaProveedor"].Value = DetalleNotaProveedor;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nota_Credito = (Int32)p_K_Nota_Credito.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_RecepcionesError_XML(DateTime Fecha_Inicial, DateTime Fecha_Final, string NombreEmisor, Int32 Tipo_Moneda)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_RecepcionesError_XML";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@Fecha_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@NombreEmisor", SqlDbType.VarChar, 220));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Moneda", SqlDbType.Int));

            cmd.Parameters["@Fecha_Inicial"].Value = Fecha_Inicial;
            cmd.Parameters["@Fecha_Final"].Value = Fecha_Final;
            cmd.Parameters["@NombreEmisor"].Value = NombreEmisor;
            cmd.Parameters["@Tipo_Moneda"].Value = Tipo_Moneda;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public DataTable Sk_RecepcionesDetalleError_XML(Int32 K_Operacion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_RecepcionesDetalleError_XML";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Operacion", SqlDbType.Int));

            cmd.Parameters["@K_Operacion"].Value = K_Operacion;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_ConsultaCxP_PorAutorizar(Int32 K_Proveedor, Int16 K_Tipo_Moneda, Int32 K_Orden_Compra, bool B_Vencidos, bool B_PorVencer)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaCxP_PorAutorizar";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Vencidos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_PorVencer", SqlDbType.Bit));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@B_Vencidos"].Value = B_Vencidos;
            cmd.Parameters["@B_PorVencer"].Value = B_PorVencer;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public DataTable Sk_ConsultaCxP_PorAutorizar(Int32 K_Proveedor, Int16 K_Tipo_Moneda, DateTime F_Inicial, DateTime F_Final, Int32 K_Orden_Compra, bool B_Vencidos, bool B_PorVencer)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaCxP_PorAutorizar";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Vencidos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_PorVencer", SqlDbType.Bit));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@B_Vencidos"].Value = B_Vencidos;
            cmd.Parameters["@B_PorVencer"].Value = B_PorVencer;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }


        public int In_Motivo_Anticipo_Pago(
        ref Int32 K_Motivo_Anticipo_Pago,
        string D_Motivo_Anticipo_Pago,
        ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivo_Anticipo_Pago";

            IDataParameter p_K_Motivo_Anticipo_Pago = new SqlParameter("@K_Motivo_Anticipo_Pago", SqlDbType.Int);
            p_K_Motivo_Anticipo_Pago.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Anticipo_Pago);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Anticipo_Pago", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Motivo_Anticipo_Pago"].Value = K_Motivo_Anticipo_Pago;
            cmd.Parameters["@D_Motivo_Anticipo_Pago"].Value = D_Motivo_Anticipo_Pago;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivo_Anticipo_Pago = (Int32)p_K_Motivo_Anticipo_Pago.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Motivo_Anticipo_Pago(
            Int32 K_Motivo_Anticipo_Pago,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivo_Anticipo_Pago";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Anticipo_Pago", SqlDbType.Int));
            cmd.Parameters["@K_Motivo_Anticipo_Pago"].Value = K_Motivo_Anticipo_Pago;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Motivo_Anticipo_Pago(
            Int32 K_Motivo_Anticipo_Pago,
            string D_Motivo_Anticipo_Pago,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivo_Anticipo_Pago";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Anticipo_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Anticipo_Pago", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Motivo_Anticipo_Pago"].Value = K_Motivo_Anticipo_Pago;
            cmd.Parameters["@D_Motivo_Anticipo_Pago"].Value = D_Motivo_Anticipo_Pago;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Motivo_Anticipo_Pago()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Anticipo_Pago";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public DataTable Sk_Tipos_Pagos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Pagos";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Usuario_Anticipo_Pago(Int32 K_Usuario, Int32 K_Motivo_Anticipo_Pago, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Usuario_Anticipo_Pago";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Anticipo_Pago", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Motivo_Anticipo_Pago"].Value = K_Motivo_Anticipo_Pago;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipo_Documento(Int32 K_Tipo_Documento, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Documento";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Documento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Documento"].Value = K_Tipo_Documento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable SK_Usuarios_AsignadosAntPagos(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Usuarios_AsignadosAntPagos";
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Anticipos_Proveedores(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Anticipos_Proveedores";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Anticipos_Proveedores(
          ref Int32 K_Anticipo_Proveedor,
          Int32 K_Tipo_Pago,
          Int32 K_Proveedor,
          Int32 K_Cuenta_Proveedor,
          Decimal Monto_Anticipo_Efectivo,
          Decimal Monto_Anticipo_Cheque,
          Int32 K_Banco_Cheques,
          Int32 Cuenta_Cheque,
          Int32 Numero_Cheque,
          Decimal Monto_Anticipo_Transferencia,
          Int32 K_Banco_Transferencia,
          Int32 Cuenta_Transferencia,
          Int32 Numero_Transferencia,
          String Referencia_Transferencia,
          Int32 K_Orden_Compra,
          Int32 K_Motivo_Anticipo_Pago,
          Int32 K_Usuario_Captura,
          Int32 K_Usuario_Autoriza,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Anticipos_Proveedores";

            IDataParameter p_K_Anticipo_Proveedor = new SqlParameter("@K_Anticipo_Proveedor", SqlDbType.Int);
            p_K_Anticipo_Proveedor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Anticipo_Proveedor);

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Anticipo_Efectivo", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Monto_Anticipo_Cheque", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Banco_Cheques", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Cheque", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cheque", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Anticipo_Transferencia", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Banco_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Referencia_Transferencia", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Anticipo_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Autoriza", SqlDbType.Int));

            cmd.Parameters["@K_Anticipo_Proveedor"].Value = K_Anticipo_Proveedor;
            cmd.Parameters["@K_Tipo_Pago"].Value = K_Tipo_Pago;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Cuenta_Proveedor"].Value = K_Cuenta_Proveedor;
            cmd.Parameters["@Monto_Anticipo_Efectivo"].Value = Monto_Anticipo_Efectivo;
            cmd.Parameters["@Monto_Anticipo_Cheque"].Value = Monto_Anticipo_Cheque;
            cmd.Parameters["@K_Banco_Cheques"].Value = K_Banco_Cheques;
            cmd.Parameters["@Cuenta_Cheque"].Value = Cuenta_Cheque;
            cmd.Parameters["@Numero_Cheque"].Value = Numero_Cheque;
            cmd.Parameters["@Monto_Anticipo_Transferencia"].Value = Monto_Anticipo_Transferencia;
            cmd.Parameters["@K_Banco_Transferencia"].Value = K_Banco_Transferencia;
            cmd.Parameters["@Cuenta_Transferencia"].Value = Cuenta_Transferencia;
            cmd.Parameters["@Numero_Transferencia"].Value = Numero_Transferencia;
            cmd.Parameters["@Referencia_Transferencia"].Value = Referencia_Transferencia;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Motivo_Anticipo_Pago"].Value = K_Motivo_Anticipo_Pago;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@K_Usuario_Autoriza"].Value = K_Usuario_Autoriza;

            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Anticipo_Proveedor = (Int32)p_K_Anticipo_Proveedor.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_Trae_AnticiposProv(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Trae_AnticiposProv";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Caja_Chica(Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Caja_Chica";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Caja_Chica(Int32 K_Almacen, Int32 K_Caja_Chica, bool B_Autorizada, bool B_NoAutorizado, bool B_Todos, bool B_Pendientes)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Caja_Chica";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_NoAutorizada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Todos", SqlDbType.Bit));
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            if (B_Pendientes == true)
            {
                cmd.Parameters["@B_Autorizada"].Value = false;
                cmd.Parameters["@B_NoAutorizada"].Value = false;
                cmd.Parameters["@B_Todos"].Value = false;
            }
            else
            {
                if (B_Todos == true)
                {
                    cmd.Parameters["@B_Autorizada"].Value = false;
                    cmd.Parameters["@B_NoAutorizada"].Value = false;
                    cmd.Parameters["@B_Todos"].Value = true;
                }
                else
                {
                    cmd.Parameters["@B_Autorizada"].Value = B_Autorizada;
                    cmd.Parameters["@B_NoAutorizada"].Value = B_NoAutorizado;
                    cmd.Parameters["@B_Todos"].Value = B_Todos;
                }
            }


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Caja_Chica(ref Int32 K_Caja_Chica, Int32 K_Almacen, Int32 K_Usuario_Abre, Int32 K_Usuario_Caja, Int16 K_Departamento, bool B_Caja_Chica, bool B_Viaticos, bool B_Reposicion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Caja_Chica";

            IDataParameter p_K_Caja_Chica = new SqlParameter("@K_Caja_Chica", SqlDbType.Int);
            p_K_Caja_Chica.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Caja_Chica);


            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Abre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Caja", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Caja_Chica", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Viaticos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Reposicion", SqlDbType.Bit));

            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario_Abre"].Value = K_Usuario_Abre;
            cmd.Parameters["@K_Usuario_Caja"].Value = K_Usuario_Caja;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@B_Caja_Chica"].Value = B_Caja_Chica;
            cmd.Parameters["@B_Viaticos"].Value = B_Viaticos;
            cmd.Parameters["@B_Reposicion"].Value = B_Reposicion;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Caja_Chica = (Int32)p_K_Caja_Chica.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_CxP_SinOrden(
            ref Int32 K_Cuenta_SinOrden,
            Int32 K_Caja_Chica,
            Int32 K_Proveedor,
            string FolioFiscal,
            string Serie,
            string Folio,
            decimal Tipo_Cambio,
            Int32 K_Tipo_Moneda,
            decimal Subtotal,
            decimal Tasa_IVA,
            decimal Total_IVA,
            decimal TasaRetencion_IVA,
            decimal TotalRetencion_IVA,
            decimal Tasa_ISR,
            decimal Total_ISR,
            decimal TotalFactura,
            DateTime F_Factura,
            DateTime F_Vencimiento,
            bool B_CapturaDirecta,
            string Observaciones,
            string VersionXML,
            string Modulo,
            Int32 K_Tipo_MovCchica,
            Int32 K_Usuario,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_CxP_SinOrden";

            IDataParameter p_K_Cuenta_SinOrden = new SqlParameter("@K_Cuenta_SinOrden", SqlDbType.Int);
            p_K_Cuenta_SinOrden.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cuenta_SinOrden);

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FolioFiscal", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalRetencion_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_ISR", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalFactura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Factura", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Vencimiento", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_CapturaDirecta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@VersionXML", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Modulo", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_SinOrden"].Value = K_Cuenta_SinOrden;
            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@FolioFiscal"].Value = FolioFiscal;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@TasaRetencion_IVA"].Value = TasaRetencion_IVA;
            cmd.Parameters["@TotalRetencion_IVA"].Value = TotalRetencion_IVA;
            cmd.Parameters["@Tasa_ISR"].Value = Tasa_ISR;
            cmd.Parameters["@Total_ISR"].Value = Total_ISR;
            cmd.Parameters["@TotalFactura"].Value = TotalFactura;
            cmd.Parameters["@F_Factura"].Value = F_Factura;
            cmd.Parameters["@F_Vencimiento"].Value = F_Vencimiento;
            cmd.Parameters["@B_CapturaDirecta"].Value = B_CapturaDirecta;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@VersionXML"].Value = VersionXML;
            cmd.Parameters["@Modulo"].Value = "MANUAL";
            //cmd.Parameters["@Modulo"].Value = Modulo;
            cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cuenta_SinOrden = (Int32)p_K_Cuenta_SinOrden.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Tipos_MovCchica(
      ref Int32 K_Tipo_MovCchica,
      string D_Tipo_MovCchica,
      ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_MovCchica";

            IDataParameter p_K_Tipo_MovCchica = new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int);
            p_K_Tipo_MovCchica.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_MovCchica);

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_MovCchica", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            cmd.Parameters["@D_Tipo_MovCchica"].Value = D_Tipo_MovCchica;

            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_MovCchica = (Int32)p_K_Tipo_MovCchica.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }



        public int Up_Tipos_MovCchica(
            Int32 K_Tipo_MovCchica,
            string D_Tipo_MovCchica,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_MovCchica";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_MovCchica", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            cmd.Parameters["@D_Tipo_MovCchica"].Value = D_Tipo_MovCchica;

            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable SK_Tipos_MovCchica()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Tipos_MovCchica";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int IN_Motivos_NoAutorizacion(ref Int32 K_Motivos_NoAutorizacion, string D_Motivos_NoAutorizcion, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "IN_Motivos_NoAutorizacion";

            IDataParameter p_K_Motivos_NoAutorizacion = new SqlParameter("@K_Motivos_NoAutorizacion", SqlDbType.Int);
            p_K_Motivos_NoAutorizacion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivos_NoAutorizacion);

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Motivos_NoAutorizcion", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Motivos_NoAutorizacion"].Value = K_Motivos_NoAutorizacion;
            cmd.Parameters["@D_Motivos_NoAutorizcion"].Value = D_Motivos_NoAutorizcion;

            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivos_NoAutorizacion = (Int32)p_K_Motivos_NoAutorizacion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }



        public int Up_Motivos_NoAutorizacion(
            Int32 K_Motivos_NoAutorizacion,
            string D_Motivos_NoAutorizcion,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivos_NoAutorizacion";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivos_NoAutorizacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivos_NoAutorizcion", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Motivos_NoAutorizacion"].Value = K_Motivos_NoAutorizacion;
            cmd.Parameters["@D_Motivos_NoAutorizcion"].Value = D_Motivos_NoAutorizcion;

            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable SK_Motivos_NoAutorizacion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Motivos_NoAutorizacion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable SK_CxP_SinOrden(int K_Cuenta_SinOrden)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_CxP_SinOrden";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_SinOrden", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_SinOrden"].Value = K_Cuenta_SinOrden;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int UP_NoAutoriza_Orden(Int32 K_Motivos_NoAutorizacion, Int32 K_Caja_Chica, Int32 K_Cuenta_SinOrden, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UP_NoAutoriza_Orden";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivos_NoAutorizacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_SinOrden", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivos_NoAutorizacion"].Value = K_Motivos_NoAutorizacion;
            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            cmd.Parameters["@K_Cuenta_SinOrden"].Value = K_Cuenta_SinOrden;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Autoriza_CxP_SinOrden(Int32 K_Cuenta_SinOrden, Int32 K_Caja_Chica, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Autoriza_CxP_SinOrden";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_SinOrden", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Autoriza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name_Autoriza", SqlDbType.VarChar));

            cmd.Parameters["@K_Cuenta_SinOrden"].Value = K_Cuenta_SinOrden;
            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            cmd.Parameters["@K_Usuario_Autoriza"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@PC_Name_Autoriza"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_ValidaLiquida_Caja(Int32 K_Caja_Chica, Decimal Monto_Pendiente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaLiquida_Caja";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Pendiente", SqlDbType.Decimal));

            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            cmd.Parameters["@Monto_Pendiente"].Value = Monto_Pendiente;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_Trae_MontosCajaChica(int K_Caja_Chica)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Trae_MontosCajaChica";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Gp_Liquida_Caja(DataTable Detalle_Pagos, Int32 K_Caja_Chica, decimal Monto, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Liquida_Caja";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);


            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@DetalleLiquidacionCxP", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Decimal));

            cmd.Parameters["@DetalleLiquidacionCxP"].Value = Detalle_Pagos;
            cmd.Parameters["@K_Caja_Chica"].Value = K_Caja_Chica;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Consulta_CajaChica(int K_Almacen, int K_Usuario_Caja, bool B_Liquidada, bool B_Caja_Chica, bool B_Viaticos, bool B_Reposicion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Consulta_CajaChica";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Caja", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Liquidada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Caja_Chica", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Viaticos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Reposicion", SqlDbType.Bit));
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario_Caja"].Value = K_Usuario_Caja;
            cmd.Parameters["@B_Liquidada"].Value = B_Liquidada;
            cmd.Parameters["@B_Caja_Chica"].Value = B_Caja_Chica;
            cmd.Parameters["@B_Viaticos"].Value = B_Viaticos;
            cmd.Parameters["@B_Reposicion"].Value = B_Reposicion;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_ValidaUsuarioCajaChica(int K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaUsuarioCajaChica";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;

        }
        public int In_Usuario_AutorizaCajaChica(Int32 K_Usuario, Int32 K_Usuario_Asigna, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Usuario_AutorizaCajaChica";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Asigna", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Usuario_Asigna"].Value = K_Usuario_Asigna;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Usuario_AutorizaCajaChica(Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Usuario_AutorizaCajaChica";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_AutorizaCajaChicaAsig()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_AutorizaCajaChicaAsig";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_AutorizaCajaChicaDis()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_AutorizaCajaChicaDis";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_AutorizaCajaChicaDis(TextBox txt_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_AutorizaCajaChicaDis";
            cmd.Parameters.Add(new SqlParameter("@D_Usuario", SqlDbType.VarChar, 100));
            cmd.Parameters["@D_Usuario"].Value = txt_Usuario.Text;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_RepAplicacionCXP(Int32 Consecutivo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepAplicacionCXP";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@Consecutivo", SqlDbType.Int));

            cmd.Parameters["@Consecutivo"].Value = Consecutivo;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
    }
}