using System;

namespace ProbeMedic.Modelos
{
    public class Articulos
    {
        
        public Int32 K_Articulo { get; set; }
        
        public String D_Articulo { get; set; }
        
        public String C_Articulo { get; set; }
        
        public Int16 K_Tipo_Articulo { get; set; }
        
        public String D_Tipo_Articulo { get; set; }
        
        public Int32 K_Clasificacion_Articulo { get; set; }
        
        public String D_Clasificacion_Articulo { get; set; }
        
        public Int16 K_Unidad_Medida { get; set; }
        
        public String D_Unidad_Medida { get; set; }
        
        public Decimal PrecioUnitario { get; set; }
        
        public Single TasaIVA { get; set; }
        
        public Decimal PrecioTotalUnitario { get; set; }
        
        public Int16 K_Tipo_Moneda { get; set; }
        
        public String D_Tipo_Moneda { get; set; }
        
        public Int16 K_Grupo_Articulo { get; set; }
        
        public String D_Grupo_Articulo { get; set; }
        
        public Int16 Tipo_Costeo { get; set; }
        
        public String D_Tipo_Costeo { get; set; }
        
        public Boolean B_RequiereInventario { get; set; }
        
        public Int32 Inventario { get; set; }
        
        public Int32 Minimo { get; set; }
        
        public Int32 Maximo { get; set; }
        
        public Int32 Punto_Reorden { get; set; }
        
        public Boolean B_RequiereCertificado { get; set; }
        
        public Boolean B_Activo { get; set; }
        
        public DateTime F_Baja { get; set; }
        
        public String Activo { get; set; }
        
        public Int16 Salud { get; set; }
        
        public Int16 Inflamabilidad { get; set; }
        
        public Int16 Reactividad { get; set; }
        
        public String C_Unidad_Medida { get; set; }
        
        public String Fraccion_Arancelaria { get; set; }
        
        public Decimal PrecioVenta { get; set; }
        
        public String CamposBusqueda { get; set; }
        
        public Boolean B_Requiere_Prueba_Calidad { get; set; }
    }
}
