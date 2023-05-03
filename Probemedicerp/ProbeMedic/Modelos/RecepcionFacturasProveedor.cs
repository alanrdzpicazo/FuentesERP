﻿using System;

namespace ProbeMedic.Modelos
{
    public class RecepcionFacturasProveedor
    {
        public Int32 K_RecepcionArchivoProveedor { get; set; }
        public Int32 K_Operacion { get; set; }
        public Int32 K_Orden_Compra { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public Int32 K_Nota_Recepcion { get; set; }
        public int K_Estatus { get; set; }
        public Int32 K_Proveedor { get; set; }
        public string TipoDocumento { get; set; }
        public Int16 K_Tipo_Moneda { get; set; }
        public String D_Tipo_Moneda { get; set; }        
        public String NombreArchivo { get; set; }
        public String RutaArchivo { get; set; }
     
    }
    public class RecepcionesProveedorXML
    {        
        public Boolean B_Seleccion { get; set; }
        public Int32 K_Operacion { get; set; }
        public Int32 K_Proveedor { get; set; }
        public String RFCEmisor { get; set; }
        public String TipoComprobante { get; set; }
        public String TipoDocumento { get; set; }
        public String UUID { get; set; }
        public String Serie { get; set; }
        public String Folio { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 K_Tipo_Moneda { get; set; }
        public String D_Tipo_Moneda { get; set; }
        public Decimal TipoCambio { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal TasaIVA { get; set; }
        public Decimal TotalIVA { get; set; }
        public Decimal TasaRetencion { get; set; }
        public Decimal TotalISR { get; set; }
        public Decimal TasaISR { get; set; }
        public Decimal Total { get; set; }
        public Int32 k_Orden_Compra { get; set; }
        public String SerieReferencia { get; set; }
        public String FolioReferencia { get; set; }
        public String VersionXML { get; set; }
        public String XML { get; set; }
        public String Modulo { get; set; }
        public String RutaArchivo { get; set; }
        public DateTime F_Inserta { get; set; }
        public Int32 K_RecepcionArchivoProveedor { get; set; }
        public String K_Nota_Recepcion { get; set; }
        public Decimal TotalRetencion { get; set; }        
        public String Nombre { get; set; }
       

    }

}
