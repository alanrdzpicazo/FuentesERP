using System;

namespace ProbeMedic.Modelos
{
    public class Bonificaciones_PT
    {
        public Int32 K_Bonificacion_PT { get; set; }
        public Int32 K_SolicitudDevolucion_PT { get; set; }
        public Int32 K_Oficina { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Cliente { get; set; }
        public String D_Cliente { get; set; }
        public Int32 K_Factura { get; set; }
        public Int32 K_Nota_Credito { get; set; }
        public Int32 K_Motivo_Bonificacion { get; set; }
        public String D_Motivo_Bonificacion { get; set; }
        public String Observaciones { get; set; }
        public Int32 K_Estatus { get; set; }
        public String D_Estatus { get; set; }
        public Boolean B_Cerrada { get; set; }
        public Boolean B_AplicaNC { get; set; }
        public Decimal ImporteNC { get; set; }
        public Int16 K_Tipo_Moneda { get; set; }
        public String D_Tipo_Moneda { get; set; }
        public Decimal Tipo_Cambio { get; set; }
        public DateTime F_Bonificacion { get; set; }
        public String fechabonificacion { get; set; }
        public String Serie { get; set; }
        public Int32 Folio { get; set; }
        public String Factura { get; set; }
        public String rutaPDF { get; set; }
        public string NC { get; set; }
        public string D_Usuario { get; set; }
    }
}
