using System;

namespace ProbeMedic.Modelos
{
    public class Recepcion_Archivos_Proveedores
    {
        public String NombreArchivo { get; set; }
        public String RutaArchivo { get; set; }
        public Int32 K_RecepcionArchivoProveedor { get; set; }
        public Int32 K_Operacion { get; set; }
        public Int32 K_Orden_Compra { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public Int32 K_Estatus { get; set; }
        public Int32 K_CxP { get; set; }
        public Int32 K_Pago_CxP { get; set; }
        public Guid Stream_Id { get; set; }
        public Int32 K_Proveedor { get; set; }
        public Int32 Efiscal { get; set; }
        public Int32 Mes { get; set; }
        public String TipoDocumento { get; set; }
        public Boolean B_Cancelada { get; set; }
        public Boolean B_Cerrada { get; set; }
        public String Comentarios { get; set; }
        public String Usuario { get; set; }
        public Int32 K_Usuario { get; set; }
        public DateTime F_Actualiza { get; set; }
        public String PC_Name { get; set; }
    }
}
