using System;

namespace ProbeMedic.Modelos
{
    public class CFDI_Impresion
    {
        
        public String ListaOficinas { get; set; }
        
        public String Pagina { get; set; }
        
        public String LeyendaRegimen { get; set; }
        
        public String VersionDocumento { get; set; }
        
        public String Agente { get; set; }
        
        public String Transporte { get; set; }
        
        public String Almacen { get; set; }
        
        public String Pedido { get; set; }
        
        public String Referencia { get; set; }
        
        public String OrdenCompra { get; set; }
        
        public String Observaciones { get; set; }
        
        public String ObservacionesDocumento { get; set; }
        
        public String PagareEmpresa { get; set; }
        
        public String PagareFecha { get; set; }
        
        public String Titulo { get; set; }
        
        public String DatosEnvio { get; set; }
        
        public Decimal Total_Efecto_Pago { get; set; }
        
        public Decimal TotalIva { get; set; }
        
        public Decimal TasaIva { get; set; }
        
        public Decimal Total_Retencion { get; set; }
        
        public Int32 Total_Inspeccion { get; set; }
        
        public Int32 Total_SFP { get; set; }
        
        public Byte[] cbba { get; set; }
        
        public Int32 id { get; set; }
        
        public String serie { get; set; }
        
        public String folio { get; set; }
        
        public DateTime fecha { get; set; }
        
        public String sello { get; set; }
        
        public String formaDePago { get; set; }
        
        public String noCertificado { get; set; }
        
        public String certificado { get; set; }
        
        public String condicionesDePago { get; set; }
        
        public Decimal subTotal { get; set; }
        
        public Decimal descuento { get; set; }
        
        public Decimal total { get; set; }
        
        public String Moneda { get; set; }
        
        public Decimal TipoCambio { get; set; }
        
        public String metodoDePago { get; set; }
        
        public String tipoDeComprobante { get; set; }
        
        public String LugarExpedicion { get; set; }
        
        public String NumCtaPago { get; set; }
        
        public String noAprobacion { get; set; }
        
        public DateTime F_Aprobacion { get; set; }
        
        public String CadenaOriginal { get; set; }
        
        public String EmisorRFC { get; set; }
        
        public String EmisorNombre { get; set; }
        
        public String EmisorDomicilioCalle { get; set; }
        
        public String EmisorDomicilioNoExterior { get; set; }
        
        public String EmisorDomicilioNoInterior { get; set; }
        
        public String EmisorDomicilioColonia { get; set; }
        
        public String EmisorDomicilioLocalidad { get; set; }
        
        public String EmisorDomicilioMunicipio { get; set; }
        
        public String EmisorDomicilioEstado { get; set; }
        
        public String EmisorDomicilioPais { get; set; }
        
        public String EmisorDomicilioCodigoPostal { get; set; }
        
        public String EmisorRegimenFiscalRegimen { get; set; }
        
        public String ReceptorRFC { get; set; }
        
        public String ReceptorNombre { get; set; }
        
        public String ReceptorDomicilioCalle { get; set; }
        
        public String ReceptorDomicilioNoExterior { get; set; }
        
        public String ReceptorDomicilioNoInterior { get; set; }
        
        public String ReceptorDomicilioColonia { get; set; }
        
        public String ReceptorDomicilioLocalidad { get; set; }
        
        public String ReceptorDomicilioMunicipio { get; set; }
        
        public String ReceptorDomicilioEstado { get; set; }
        
        public String ReceptorDomicilioPais { get; set; }
        
        public String ReceptorDomicilioCodigoPostal { get; set; }
        
        public Decimal ConceptosCantidad { get; set; }
        
        public String ConceptosUnidad { get; set; }
        
        public String ConceptosNoIdentificacion { get; set; }
        
        public Decimal ConceptosValorUnitario { get; set; }
        
        public Decimal ConceptosImporte { get; set; }
        
        public String ConceptosDescripcion { get; set; }
        
        public String TimbreSelloSAT { get; set; }
        
        public String TimbreNoCertificadoSAT { get; set; }
        
        public String TimbreSelloCFD { get; set; }
        
        public DateTime TimbreFecha { get; set; }
        
        public String TimbreUUID { get; set; }
        
        public String TimbreVersion { get; set; }
        
        public Decimal CantidadKgs { get; set; }
        
        public String TipoEmpaque { get; set; }
        
        public String Detalle { get; set; }
        
        public Int32 K_PAC { get; set; }
        
        public String Observaciones1 { get; set; }
        
        public String OrigenSerie { get; set; }
        
        public Int32 OrigenFolio { get; set; }
        
        public String Total_Letra { get; set; }
        
        public Boolean B_Cancelada { get; set; }
        
        public String TipoNotaCredito { get; set; }
        
        public String Elaboro { get; set; }
        
        public String Autorizo { get; set; }
        
        public Byte[] FirmaDigitalAutoriza { get; set; }
    }
}
