using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbeMedic.Modelos
{
    public class ConsultaFactura
    {
        public bool B_Selecciona { get; set; }
        public Int32 K_Factura { get; set; }        
        public Int32 K_Oficina { get; set; }       
        public String D_Oficina { get; set; }        
        public Int32 K_Tipo_Factura { get; set; }        
        public String Serie { get; set; }        
        public Int32 Folio { get; set; }       
        public String Referencia { get; set; }        
        public Int32 K_Cliente { get; set; }        
        public String D_Cliente { get; set; }        
        public Int32 K_Domicilio_Fiscal { get; set; }        
        public String RFC { get; set; }        
        public Int16 K_Tipo_Moneda { get; set; }  
        public string D_Tipo_Moneda { get; set; }
        public Decimal Tipo_Cambio { get; set; }        
        public DateTime F_Factura { get; set; }        
        public Boolean B_Pagada { get; set; }     
        public DateTime F_Pago { get; set; }        
        public Decimal Subtotal { get; set; }        
        public Decimal Iva { get; set; }        
        public Decimal TotalIva { get; set; }        
        public Decimal TotalRetencionISR { get; set; }        
        public Decimal TotalRetencionIVA { get; set; }        
        public Decimal Total { get; set; }        
        public Decimal Total_Abonado { get; set; }        
        public Decimal Saldo { get; set; }        
        public DateTime F_Timbre { get; set; }        
        public String UUID { get; set; }        
        public DateTime F_Vencimiento { get; set; }        
        public Boolean B_Cancelada { get; set; }        
        public DateTime F_Cancela { get; set; }        
        public String DomicilioEstado { get; set; }        
        public String DomicilioLocalidad { get; set; }        
        public String DomicilioColonia { get; set; }        
        public String DomicilioCalle { get; set; }        
        public String DomicilioCodigoPostal { get; set; }        
        public String DomicilioNoInterior { get; set; }        
        public String DomicilioNoExterior { get; set; }        
        public Int32 Dias { get; set; }        
        public Int16 LimiteDias { get; set; }        
        public Boolean B_HacerNota { get; set; }
        public decimal Pagar { get; set; }
        public int Id { get; set; }
    }
}
