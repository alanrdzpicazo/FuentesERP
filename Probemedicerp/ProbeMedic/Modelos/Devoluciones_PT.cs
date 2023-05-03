using System;

namespace PARIS.Modelos
{
    public class Devoluciones_PT
    {
        public Int32 K_SolicitudDevolucion_PT { get; set; }
        public Int32 K_Oficina { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Cliente { get; set; }
        public String D_Cliente { get; set; }
        public Int32 K_Factura { get; set; }
        public Int32 K_Nota_Credito { get; set; }
        public Int32 K_DevolucionComentario_PT { get; set; }
        public String Comentario { get; set; }
        public Int32 K_Motivo_Devolucion { get; set; }
        public String D_Motivo_Devolucion { get; set; }
        public Int32 K_Estatus { get; set; }
        public String D_Estatus { get; set; }
        public Boolean B_Parcial { get; set; }
        public Boolean B_Cerrada { get; set; }
        public Boolean B_AplicaNC { get; set; }
        public decimal ImporteNC { get; set; }
        public Int16 K_Tipo_Moneda { get; set; }
        public string D_Tipo_Moneda { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public string PersonaDevuelve { get; set; }
        public DateTime F_Solicitud { get; set; }
        public string fechasolicitud { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public string Factura { get; set; }
        public bool B_ConBonificacion { get; set; }
        public string rutaPDF { get; set; }
        public string NC { get; set; }
        public string Bonificacion { get; set; }
        public string D_Usuario { get; set; }
    }
}
