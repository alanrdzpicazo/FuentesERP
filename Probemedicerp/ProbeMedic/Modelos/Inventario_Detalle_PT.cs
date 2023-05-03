using System;

namespace PARIS.Modelos
{
    public class Inventario_Detalle_PT
    {
        public Int32 K_Pedido { get; set; }
        public Int32 K_Pedido_Detalle { get; set; }
        public Int32 K_Producto { get; set; }
        public String D_Producto { get; set; }
        public Int16 K_Clase_Producto { get; set; }
        public Int32 K_Oficina_Movimiento { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Tipo_Empaque { get; set; }
        public String D_Tipo_Empaque { get; set; }
        public Decimal KgsEmpaque { get; set; }
        public Int16 Cantidad_Entrada { get; set; }
        public Decimal Cantidad_Kgs { get; set; }
        public Int16 Cantidad_Movimiento { get; set; }
        public Decimal Cantidad_Movimiento_Kgs { get; set; }
        public Int16 Cantidad_Disponible { get; set; }
        public Decimal Cantidad_Disponible_Kgs { get; set; }
        public String Lote { get; set; }
        public Decimal CostoProduccion { get; set; }
        public Int32 K_Tipo_Movimiento { get; set; }
        public String D_Tipo_Movimiento { get; set; }
        public String F_Movimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public String F_Entrada_Lote { get; set; }
        public Int32 K_Movimiento_Inventariopt { get; set; }
        public Int32 k_cliente { get; set; }
        public String D_Cliente { get; set; }
        public String F_Pedido { get; set; }
        public Int32 Consecutivo { get; set; }
        public Int32 K_Almacen { get; set; }
        public String Lote_Hoja { get; set; }
    }
}
