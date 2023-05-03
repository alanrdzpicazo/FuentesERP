using System;

namespace ProbeMedic.Modelos
{
    public class RecepcionesDetalle_XML
    {
        public Int32 K_Operacion { get; set; }
        public Int16 Cantidad { get; set; }
        public String UnidadMedida { get; set; }
        public String Concepto { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public Decimal ImporteTotal { get; set; }
    }
}
