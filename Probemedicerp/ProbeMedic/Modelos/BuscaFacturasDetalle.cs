using System;

namespace ProbeMedic.Modelos
{
    public class DistribucionEtiqueta
    {
        public int K_Producto { get; set; }
        public int Orden { get; set; }
        public int NoEtiqueta { get; set; }
        public string Etiqueta { get; set; }
        public decimal Kgs { get; set; }
    }
    public class BuscaFacturasDetalle
    {
        public bool B_Seleccionar { get; set; }
        public Int32 K_Factura { get; set; }
        
        public String UUID { get; set; }
        
        public String Serie { get; set; }
        
        public Int32 Folio { get; set; }
        
        public DateTime F_Factura { get; set; }
        
        public Decimal Total { get; set; }
        
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
        
        public String TipoEmpaque { get; set; }
        
        public String Descripcion { get; set; }
        
        public String Detalle { get; set; }
        
        public Decimal ValorUnitario { get; set; }
        
        public Decimal Importe { get; set; }
        
        public String Lote { get; set; }
        
        public Int32 K_Producto { get; set; }
        public string D_Producto { get; set; }

        public Int32 K_Articulo { get; set; }
        
        public String FraccionArancelaria { get; set; }
        public int K_Tipo_Producto { get; set; }
        public string D_Tipo_Producto { get; set; }
    }

    public class PartidasRecibidas
    {
        public bool B_Seleccionar { get; set; }
        public Int32 K_Factura { get; set; }

        public String UUID { get; set; }

        public String Serie { get; set; }

        public Int32 Folio { get; set; }

        public DateTime F_Factura { get; set; }

        public Decimal Total { get; set; }

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

        public String TipoEmpaque { get; set; }

        public String Descripcion { get; set; }

        public String Detalle { get; set; }

        public Decimal ValorUnitario { get; set; }

        public Decimal Importe { get; set; }

        public String Lote { get; set; }
        public string Comentarios { get; set; }

        public Int32 K_Producto { get; set; }
        public string D_Producto { get; set; }

        public Int32 K_Articulo { get; set; }

        public String FraccionArancelaria { get; set; }
    }
}
