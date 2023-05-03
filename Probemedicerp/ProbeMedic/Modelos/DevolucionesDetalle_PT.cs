using System;

namespace PARIS.Modelos
{
    public class DevolucionesDetalle_PT
    {
        public Int32 K_Factura { get; set; }
        public String UUID { get; set; }
        public String Serie { get; set; }
        public Int32 Folio { get; set; }
        public DateTime F_Factura { get; set; }
        public Decimal Total { get; set; }
        public Int16 K_Tipo_Moneda { get; set; }
        public String D_Tipo_Moneda { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Tipo_Factura { get; set; }
        public String D_Tipo_Factura { get; set; }
        public Int32 K_Cliente { get; set; }
        public String D_Cliente { get; set; }
        public Boolean B_Cancelada { get; set; }
        public Boolean B_Pagada { get; set; }
        public Int32 K_Oficina { get; set; }
        public Int32 Orden { get; set; }
        public Decimal Cantidad { get; set; }
        public Decimal CantidadKgs { get; set; }
        public String Unidad { get; set; }
        public Int32 K_Tipo_Empaque { get; set; }
        public String TipoEmpaque { get; set; }
        public String Descripcion { get; set; }
        public String Detalle { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal Importe { get; set; }
        public String Lote { get; set; }
        public String Comentarios { get; set; }
        public Int32 K_Producto { get; set; }
        public String D_Producto { get; set; }
        public Int32 K_Articulo { get; set; }
        public String K_SolicitudDevolucionDetalle_PT { get; set; }
        public Int32 K_SolicitudDevolucion_PT { get; set; }
        public Int32 K_Movimiento_InventarioPT { get; set; }
        public Decimal Tipo_Cambio { get; set; }
        public String PersonaDevuelve { get; set; }
        public DateTime F_Solicitud { get; set; }
        public String fechasolicitud { get; set; }
        public Int32 K_Oficina1 { get; set; }
        public String D_Oficina1 { get; set; }
        public DateTime Fec_Tramite { get; set; }
        public String fechatramite { get; set; }
        public String ComentarioVendedor { get; set; }
        public string UsuarioRecibe { get; set; }
        public string stream_id { get; set; }
        public string rutaPDF { get; set; }
    }
}
