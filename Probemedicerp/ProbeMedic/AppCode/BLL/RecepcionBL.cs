using ProbeMedic.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
namespace ProbeMedic.AppCode.BLL
{
    public class RecepcionBL
    {
        SQLRecepcion sql = new SQLRecepcion();

        public List<RecepcionesDetalle_XML> Sk_RecepcionesDetalle_XML(Int32 K_Operacion)
        {
            List<RecepcionesDetalle_XML> respuesta = new List<RecepcionesDetalle_XML>();
            try
            {
                DataTable dt = sql.Sk_RecepcionesDetalle_XML(K_Operacion);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        RecepcionesDetalle_XML elemento = new RecepcionesDetalle_XML();

                        if (!String.IsNullOrEmpty(row["K_Operacion"].ToString()))
                            elemento.K_Operacion = Int32.Parse(row["K_Operacion"].ToString());
                        if (!String.IsNullOrEmpty(row["Cantidad"].ToString()))
                            elemento.Cantidad = Int16.Parse(row["Cantidad"].ToString());
                        if (!String.IsNullOrEmpty(row["UnidadMedida"].ToString()))
                            elemento.UnidadMedida = row["UnidadMedida"].ToString();
                        if (!String.IsNullOrEmpty(row["Concepto"].ToString()))
                            elemento.Concepto = row["Concepto"].ToString();
                        if (!String.IsNullOrEmpty(row["PrecioUnitario"].ToString()))
                            elemento.PrecioUnitario = decimal.Parse(row["PrecioUnitario"].ToString());
                        if (!String.IsNullOrEmpty(row["ImporteTotal"].ToString()))
                            elemento.ImporteTotal = decimal.Parse(row["ImporteTotal"].ToString());
                        respuesta.Add(elemento);
                    }
                }
            }
            catch
            {
                throw;
            }
            return respuesta;
        }
        public List<Recepcion_Archivos_Proveedores> sps_Recepcion_Archivos_Proveedores(Int32 K_Proveedor, Int32? K_Orden_Compra,string Serie,Int32? Folio, Int32? K_CxP, string TipoDocumento, Int32 K_Estatus,Int32? K_Operacion)
        {
            List<Recepcion_Archivos_Proveedores> respuesta = new List<Recepcion_Archivos_Proveedores>();
            try
            {
                DataTable dt = sql.Sk_Recepcion_Archivos_Proveedores(K_Proveedor, K_Orden_Compra,Serie,Folio,K_CxP, TipoDocumento, K_Estatus,K_Operacion);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Recepcion_Archivos_Proveedores elemento = new Recepcion_Archivos_Proveedores();

                        if (!String.IsNullOrEmpty(row["NombreArchivo"].ToString()))
                            elemento.NombreArchivo = row["NombreArchivo"].ToString();
                        if (!String.IsNullOrEmpty(row["RutaArchivo"].ToString()))
                            elemento.RutaArchivo = row["RutaArchivo"].ToString();
                        if (!String.IsNullOrEmpty(row["K_RecepcionArchivoProveedor"].ToString()))
                            elemento.K_RecepcionArchivoProveedor = Int32.Parse(row["K_RecepcionArchivoProveedor"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Operacion"].ToString()))
                            elemento.K_Operacion = Int32.Parse(row["K_Operacion"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Orden_Compra"].ToString()))
                            elemento.K_Orden_Compra = Int32.Parse(row["K_Orden_Compra"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Estatus"].ToString()))
                            elemento.K_Estatus = Int32.Parse(row["K_Estatus"].ToString());
                        if (!String.IsNullOrEmpty(row["K_CxP"].ToString()))
                            elemento.K_CxP = Int32.Parse(row["K_CxP"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Pago_CxP"].ToString()))
                            elemento.K_Pago_CxP = Int32.Parse(row["K_Pago_CxP"].ToString());
                        if (!String.IsNullOrEmpty(row["Stream_Id"].ToString()))
                            elemento.Stream_Id = (Guid)row["Stream_Id"];
                        if (!String.IsNullOrEmpty(row["K_Proveedor"].ToString()))
                            elemento.K_Proveedor = Int32.Parse(row["K_Proveedor"].ToString());
                        if (!String.IsNullOrEmpty(row["Efiscal"].ToString()))
                            elemento.Efiscal = Int32.Parse(row["Efiscal"].ToString());
                        if (!String.IsNullOrEmpty(row["Mes"].ToString()))
                            elemento.Mes = Int32.Parse(row["Mes"].ToString());
                        if (!String.IsNullOrEmpty(row["TipoDocumento"].ToString()))
                            elemento.TipoDocumento = row["TipoDocumento"].ToString();
                        if (!String.IsNullOrEmpty(row["B_Cancelada"].ToString()))
                            elemento.B_Cancelada = bool.Parse(row["B_Cancelada"].ToString());
                        if (!String.IsNullOrEmpty(row["B_Cerrada"].ToString()))
                            elemento.B_Cerrada = bool.Parse(row["B_Cerrada"].ToString());
                        if (!String.IsNullOrEmpty(row["Comentarios"].ToString()))
                            elemento.Comentarios = row["Comentarios"].ToString();
                        if (!String.IsNullOrEmpty(row["Usuario"].ToString()))
                            elemento.Usuario = row["Usuario"].ToString();
                        if (!String.IsNullOrEmpty(row["K_Usuario"].ToString()))
                            elemento.K_Usuario = Int32.Parse(row["K_Usuario"].ToString());
                        if (!String.IsNullOrEmpty(row["F_Actualiza"].ToString()))
                            elemento.F_Actualiza = DateTime.Parse(row["F_Actualiza"].ToString());
                        if (!String.IsNullOrEmpty(row["PC_Name"].ToString()))
                            elemento.PC_Name = row["PC_Name"].ToString();
                        if (!String.IsNullOrEmpty(row["Serie"].ToString()))
                            elemento.Serie = row["Serie"].ToString();
                        if (!String.IsNullOrEmpty(row["Folio"].ToString()))
                            elemento.Folio = Int32.Parse(row["Folio"].ToString());
                        respuesta.Add(elemento);
                    }
                }
            }
            catch
            {
                throw;
            }
            return respuesta;
        }
        public List<RecepcionFacturasProveedor> Sk_RecepcionFacturasProveedor(DateTime? Fecha_Inicial, DateTime? Fecha_Final, Int32? K_Proveedor, Int32? Tipo_Moneda)
        {
            List<RecepcionFacturasProveedor> respuesta = new List<RecepcionFacturasProveedor>();
            try
            {
                DataTable dt = sql.Sk_RecepcionFacturasProveedor(Fecha_Inicial, Fecha_Final, K_Proveedor, Tipo_Moneda);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        RecepcionFacturasProveedor elemento = new RecepcionFacturasProveedor();

                        if (!String.IsNullOrEmpty(row["K_RecepcionArchivoProveedor"].ToString()))
                            elemento.K_RecepcionArchivoProveedor = Int32.Parse(row["K_RecepcionArchivoProveedor"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Operacion"].ToString()))
                            elemento.K_Operacion = Int32.Parse(row["K_Operacion"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Proveedor"].ToString()))
                            elemento.K_Proveedor = Int32.Parse(row["K_Proveedor"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Orden_Compra"].ToString()))
                            elemento.K_Orden_Compra = Int32.Parse(row["K_Orden_Compra"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Nota_Recepcion"].ToString()))
                            elemento.K_Nota_Recepcion = Int32.Parse(row["K_Nota_Recepcion"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Tipo_Moneda"].ToString()))
                            elemento.K_Tipo_Moneda = Int16.Parse(row["K_Tipo_Moneda"].ToString());
                        if (!String.IsNullOrEmpty(row["D_Tipo_Moneda"].ToString()))
                            elemento.D_Tipo_Moneda = row["D_Tipo_Moneda"].ToString();
                        if (!String.IsNullOrEmpty(row["TipoDocumento"].ToString()))
                            elemento.TipoDocumento = row["TipoDocumento"].ToString();
                        if (!String.IsNullOrEmpty(row["NombreArchivo"].ToString()))
                            elemento.NombreArchivo = row["NombreArchivo"].ToString();
                        if (!String.IsNullOrEmpty(row["Serie"].ToString()))
                            elemento.Serie = row["Serie"].ToString();
                        if (!String.IsNullOrEmpty(row["Folio"].ToString()))
                            elemento.Folio = Int32.Parse(row["Folio"].ToString());
                        if (!String.IsNullOrEmpty(row["K_Estatus"].ToString()))
                            elemento.K_Estatus = Int32.Parse(row["K_Estatus"].ToString());
                        if (!String.IsNullOrEmpty(row["RutaArchivo"].ToString()))
                            elemento.RutaArchivo = row["RutaArchivo"].ToString();
                        respuesta.Add(elemento);
                    }
                }
            }
            catch
            {
                throw;
            }
            return respuesta;
        }
    }
}
