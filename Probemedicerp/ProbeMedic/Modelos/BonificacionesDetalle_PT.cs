using System;

namespace ProbeMedic.Modelos
{
    public class BonificacionesDetalle_PT
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
        public String FraccionArancelaria { get; set; }
        public Int32 K_Bonificacion_PT { get; set; }
        public Int32 K_BonificacionDetalle_PT { get; set; }
        public Int32 K_SolicitudDevolucion_PT { get; set; }
        public Decimal Tipo_Cambio { get; set; }
        public decimal PUFactura { get; set; }
        public string stream_id { get; set; }
        public string rutaPDF { get; set; }
    }
}
