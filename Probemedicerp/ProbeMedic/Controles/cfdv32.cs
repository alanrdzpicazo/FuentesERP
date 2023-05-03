﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/cfd/3", IsNullable=false)]
public partial class Comprobante {
    
    private ComprobanteEmisor EmisorField;
    
    private ComprobanteReceptor ReceptorField;
    
    private ComprobanteConcepto[] ConceptosField;
    
    private ComprobanteImpuestos ImpuestosField;
    
    private ComprobanteComplemento ComplementoField;
    
    private ComprobanteAddenda addendaField;

   
    private string VersionField;

    private string SerieField;
    
    private string FolioField;

    private System.DateTime FechaField;

    private string SelloField;
    
    private string FormaPagoField;
    
    private string NoCertificadoField;
    
    private string CondicionesDePagoField;
    
    private decimal SubTotalField;
    
    private decimal DescuentoField;
    
    private bool descuentoFieldSpecified;
    
    private string motivoDescuentoField;
    
    private string TipoCambioField;
    
    private string MonedaField;
    
    private decimal TotalField;
    
    private ComprobanteTipoDeComprobante TipoDeComprobanteField;

    private string MetodoPagoField;
    
    private string LugarExpedicionField;

    // no se encuetra
    private string numCtaPagoField;
    
    private string folioFiscalOrigField;
    
    private string serieFolioFiscalOrigField;
    
    private System.DateTime fechaFolioFiscalOrigField;
    
    private bool fechaFolioFiscalOrigFieldSpecified;
    
    private decimal montoFolioFiscalOrigField;
    
    private bool montoFolioFiscalOrigFieldSpecified;
    
    public Comprobante() {
        this.VersionField = "3.3";
    }
    // no se que valor toma 
    /// <remarks/>
    public ComprobanteEmisor Emisor {
        get {
            return this.EmisorField;
        }
        set {
            this.EmisorField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteReceptor Receptor {
        get {
            return this.ReceptorField;
        }
        set {
            this.ReceptorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable=false)]
    public ComprobanteConcepto[] Conceptos {
        get {
            return this.ConceptosField;
        }
        set {
            this.ConceptosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteImpuestos Impuestos {
        get {
            return this.ImpuestosField;
        }
        set {
            this.ImpuestosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteComplemento Complemento {
        get {
            return this.ComplementoField;
        }
        set {
            this.ComplementoField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteAddenda Addenda {
        get {
            return this.addendaField;
        }
        set {
            this.addendaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version {
        get {
            return this.VersionField;
        }
        set {
            this.VersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Serie {
        get {
            return this.SerieField;
        }
        set {
            this.SerieField = value;
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Folio {
        get {
            return this.FolioField;
        }
        set {
            this.FolioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime Fecha {
        get {
            return this.FechaField;
        }
        set {
            this.FechaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Sello {
        get {
            return this.SelloField;
        }
        set {
            this.SelloField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormaPago {
        get {
            return this.FormaPagoField;
        }
        set {
            this.FormaPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoCertificado {
        get {
            return this.NoCertificadoField;
        }
        set {
            this.NoCertificadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CondicionesDePago {
        get {
            return this.CondicionesDePagoField;
        }
        set {
            this.CondicionesDePagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SubTotal {
        get {
            return this.SubTotalField;
        }
        set {
            this.SubTotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento {
        get {
            return this.DescuentoField;
        }
        set {
            this.DescuentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool descuentoSpecified {
        get {
            return this.descuentoFieldSpecified;
        }
        set {
            this.descuentoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string motivoDescuento {
        get {
            return this.motivoDescuentoField;
        }
        set {
            this.motivoDescuentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoCambio {
        get {
            return this.
                TipoCambioField;
        }
        set {
            this.TipoCambioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Moneda {
        get {
            return this.MonedaField;
        }
        set {
            this.MonedaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Total {
        get {
            return this.TotalField;
        }
        set {
            this.TotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ComprobanteTipoDeComprobante TipoDeComprobante {
        get {
            return this.TipoDeComprobanteField;
        }
        set {
            this.TipoDeComprobanteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MetodoPago {
        get {
            return this.MetodoPagoField;
        }
        set {
            this.MetodoPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LugarExpedicion {
        get {
            return this.LugarExpedicionField;
        }
        set {
            this.LugarExpedicionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumCtaPago {
        get {
            return this.numCtaPagoField;
        }
        set {
            this.numCtaPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FolioFiscalOrig {
        get {
            return this.folioFiscalOrigField;
        }
        set {
            this.folioFiscalOrigField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SerieFolioFiscalOrig {
        get {
            return this.serieFolioFiscalOrigField;
        }
        set {
            this.serieFolioFiscalOrigField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime FechaFolioFiscalOrig {
        get {
            return this.fechaFolioFiscalOrigField;
        }
        set {
            this.fechaFolioFiscalOrigField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FechaFolioFiscalOrigSpecified {
        get {
            return this.fechaFolioFiscalOrigFieldSpecified;
        }
        set {
            this.fechaFolioFiscalOrigFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal MontoFolioFiscalOrig {
        get {
            return this.montoFolioFiscalOrigField;
        }
        set {
            this.montoFolioFiscalOrigField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MontoFolioFiscalOrigSpecified {
        get {
            return this.montoFolioFiscalOrigFieldSpecified;
        }
        set {
            this.montoFolioFiscalOrigFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteEmisor {
    
    private t_UbicacionFiscal domicilioFiscalField;
    
    private t_Ubicacion expedidoEnField;
    
    private ComprobanteEmisorRegimenFiscal[] regimenFiscalField;
    
    private string rfcField;

    private string RfcField;

    private string NombreField;
    
    /// <remarks/>
    public t_UbicacionFiscal DomicilioFiscal {
        get {
            return this.domicilioFiscalField;
        }
        set {
            this.domicilioFiscalField = value;
        }
    }
    
    /// <remarks/>
    public t_Ubicacion ExpedidoEn {
        get {
            return this.expedidoEnField;
        }
        set {
            this.expedidoEnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RegimenFiscal")]
    public ComprobanteEmisorRegimenFiscal[] RegimenFiscal {
        get {
            return this.regimenFiscalField;
        }
        set {
            this.regimenFiscalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rfc {
        get {
            return this.rfcField;
        }
        set {
            this.rfcField = value;
        }
    }
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rfc
    {
        get
        {
            return this.RfcField;
        }
        set
        {
            this.RfcField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre {
        get {
            return this.NombreField;
        }
        set {
            this.NombreField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class t_UbicacionFiscal {
    
    private string calleField;
    
    private string noExteriorField;
    
    private string noInteriorField;
    
    private string coloniaField;
    
    private string localidadField;
    
    private string referenciaField;
    
    private string municipioField;
    
    private string estadoField;
    
    private string paisField;
    
    private string codigoPostalField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string calle {
        get {
            return this.calleField;
        }
        set {
            this.calleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noExterior {
        get {
            return this.noExteriorField;
        }
        set {
            this.noExteriorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noInterior {
        get {
            return this.noInteriorField;
        }
        set {
            this.noInteriorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string colonia {
        get {
            return this.coloniaField;
        }
        set {
            this.coloniaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string localidad {
        get {
            return this.localidadField;
        }
        set {
            this.localidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string referencia {
        get {
            return this.referenciaField;
        }
        set {
            this.referenciaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string municipio {
        get {
            return this.municipioField;
        }
        set {
            this.municipioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string estado {
        get {
            return this.estadoField;
        }
        set {
            this.estadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string pais {
        get {
            return this.paisField;
        }
        set {
            this.paisField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codigoPostal {
        get {
            return this.codigoPostalField;
        }
        set {
            this.codigoPostalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class t_InformacionAduanera {
    
    private string numeroField;
    
    private System.DateTime fechaField;

    private string aduanaField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime fecha {
        get {
            return this.fechaField;
        }
        set {
            this.fechaField = value;
        }
    }
  

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string aduana {
        get {
            return this.aduanaField;
        }
        set {
            this.aduanaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class t_Ubicacion {
    
    private string calleField;
    
    private string noExteriorField;
    
    private string noInteriorField;
    
    private string coloniaField;
    
    private string localidadField;
    
    private string referenciaField;
    
    private string municipioField;
    
    private string estadoField;
    
    private string paisField;
    
    private string codigoPostalField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string calle {
        get {
            return this.calleField;
        }
        set {
            this.calleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noExterior {
        get {
            return this.noExteriorField;
        }
        set {
            this.noExteriorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noInterior {
        get {
            return this.noInteriorField;
        }
        set {
            this.noInteriorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string colonia {
        get {
            return this.coloniaField;
        }
        set {
            this.coloniaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string localidad {
        get {
            return this.localidadField;
        }
        set {
            this.localidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string referencia {
        get {
            return this.referenciaField;
        }
        set {
            this.referenciaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string municipio {
        get {
            return this.municipioField;
        }
        set {
            this.municipioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string estado {
        get {
            return this.estadoField;
        }
        set {
            this.estadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string pais {
        get {
            return this.paisField;
        }
        set {
            this.paisField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codigoPostal {
        get {
            return this.codigoPostalField;
        }
        set {
            this.codigoPostalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteEmisorRegimenFiscal {
    
    private string regimenField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Regimen {
        get {
            return this.regimenField;
        }
        set {
            this.regimenField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteReceptor {
    
    private t_Ubicacion domicilioField;
    
    private string rfcField;
    
    private string nombreField;
    
    /// <remarks/>
    public t_Ubicacion Domicilio {
        get {
            return this.domicilioField;
        }
        set {
            this.domicilioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rfc {
        get {
            return this.rfcField;
        }
        set {
            this.rfcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nombre {
        get {
            return this.nombreField;
        }
        set {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConcepto {
    
    private object[] itemsField;
    
    private decimal CantidadField;
    
    private string UnidadField;
    
    private string NoIdentificacionField;
    
    private string DescripcionField;
    
    private decimal ValorUnitarioField;
    
    private decimal ImporteField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ComplementoConcepto", typeof(ComprobanteConceptoComplementoConcepto))]
    [System.Xml.Serialization.XmlElementAttribute("CuentaPredial", typeof(ComprobanteConceptoCuentaPredial))]
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera", typeof(t_InformacionAduanera))]
    [System.Xml.Serialization.XmlElementAttribute("Parte", typeof(ComprobanteConceptoParte))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad {
        get {
            return this.CantidadField;
        }
        set {
            this.CantidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Unidad {
        get {
            return this.UnidadField;
        }
        set {
            this.UnidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoIdentificacion {
        get {
            return this.NoIdentificacionField;
        }
        set {
            this.NoIdentificacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion {
        get {
            return this.DescripcionField;
        }
        set {
            this.DescripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ValorUnitario {
        get {
            return this.ValorUnitarioField;
        }
        set {
            this.ValorUnitarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.ImporteField;
        }
        set {
            this.ImporteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptoComplementoConcepto {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptoCuentaPredial {
    
    private string numeroField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptoParte {
    
    private t_InformacionAduanera[] informacionAduaneraField;
    
    private decimal CantidadField;
    
    private string UnidadField;
    
    private string NoIdentificacionField;
    
    private string DescripcionField;
    
    private decimal ValorUnitarioField;
    
    private bool valorUnitarioFieldSpecified;
    
    private decimal ImporteField;
    
    private bool importeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
    public t_InformacionAduanera[] InformacionAduanera {
        get {
            return this.informacionAduaneraField;
        }
        set {
            this.informacionAduaneraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cantidad {
        get {
            return this.CantidadField;
        }
        set {
            this.CantidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unidad {
        get {
            return this.UnidadField;
        }
        set {
            this.UnidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noIdentificacion {
        get {
            return this.NoIdentificacionField;
        }
        set {
            this.NoIdentificacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string descripcion {
        get {
            return this.DescripcionField;
        }
        set {
            this.DescripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal valorUnitario {
        get {
            return this.ValorUnitarioField;
        }
        set {
            this.ValorUnitarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valorUnitarioSpecified {
        get {
            return this.valorUnitarioFieldSpecified;
        }
        set {
            this.valorUnitarioFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal importe {
        get {
            return this.ImporteField;
        }
        set {
            this.ImporteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool importeSpecified {
        get {
            return this.importeFieldSpecified;
        }
        set {
            this.importeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteImpuestos {
    
    private ComprobanteImpuestosRetencion[] retencionesField;
    
    private ComprobanteImpuestosTraslado[] trasladosField;
    
    private decimal totalImpuestosRetenidosField;
    
    private bool totalImpuestosRetenidosFieldSpecified;
    
    private decimal totalImpuestosTrasladadosField;
    
    private bool totalImpuestosTrasladadosFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable=false)]
    public ComprobanteImpuestosRetencion[] Retenciones {
        get {
            return this.retencionesField;
        }
        set {
            this.retencionesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable=false)]
    public ComprobanteImpuestosTraslado[] Traslados {
        get {
            return this.trasladosField;
        }
        set {
            this.trasladosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal totalImpuestosRetenidos {
        get {
            return this.totalImpuestosRetenidosField;
        }
        set {
            this.totalImpuestosRetenidosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool totalImpuestosRetenidosSpecified {
        get {
            return this.totalImpuestosRetenidosFieldSpecified;
        }
        set {
            this.totalImpuestosRetenidosFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal totalImpuestosTrasladados {
        get {
            return this.totalImpuestosTrasladadosField;
        }
        set {
            this.totalImpuestosTrasladadosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool totalImpuestosTrasladadosSpecified {
        get {
            return this.totalImpuestosTrasladadosFieldSpecified;
        }
        set {
            this.totalImpuestosTrasladadosFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteImpuestosRetencion {
    
    private ComprobanteImpuestosRetencionImpuesto impuestoField;
    
    private decimal importeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ComprobanteImpuestosRetencionImpuesto impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public enum ComprobanteImpuestosRetencionImpuesto {
    
    /// <remarks/>
    ISR,
    
    /// <remarks/>
    IVA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteImpuestosTraslado {
    
    private ComprobanteImpuestosTrasladoImpuesto impuestoField;
    
    private decimal tasaField;
    
    private decimal importeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ComprobanteImpuestosTrasladoImpuesto impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal tasa {
        get {
            return this.tasaField;
        }
        set {
            this.tasaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public enum ComprobanteImpuestosTrasladoImpuesto {
    
    /// <remarks/>
    IVA,
    
    /// <remarks/>
    IEPS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteComplemento {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteAddenda {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
//public enum ComprobanteTipoDeComprobante {
    
//    /// <remarks/>
//    ingreso,
    
//    /// <remarks/>
//    egreso,
    
//    /// <remarks/>
//    traslado,
//}
public enum ComprobanteTipoDeComprobante
{

    /// <remarks/>
    I,

    /// <remarks/>
    E,

    /// <remarks/>
    T,
}
