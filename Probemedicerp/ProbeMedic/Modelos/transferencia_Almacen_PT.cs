using System;

namespace PARIS.Modelos
{
    public class transferencia_Almacen_PT
    {
        public Int32 Consecutivo { get; set; }
        public Int32 K_Oficina { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Almacen { get; set; }
        public String D_Almacen { get; set; }
        public Int32 K_Producto { get; set; }
        public String D_Producto { get; set; }
        public Int32 K_Tipo_Empaque { get; set; }
        public String D_Tipo_Empaque { get; set; }
        public Int16 Cantidad_Movimiento { get; set; }
        public Decimal CantidadKgs { get; set; }
        public Int16 Cantidad_por_Recibir { get; set; }
        public decimal Kgs_por_Recibir { get; set; }
        public String observaciones { get; set; }
        public Int32 k_usuario_movimiento { get; set; }
        public String Usuario_Movimiento { get; set; }
        public String f_Movimiento { get; set; }
        public Int32 K_Oficina_Transfiere { get; set; }
        public String d_oficina_transfiere { get; set; }
        public String Lote { get; set; }
        public Int32 k_pedido { get; set; }
        public String TipoRecepcion { get; set; }
        public Boolean B_Recibida { get; set; }
        public Boolean B_RecepcionCompleta { get; set; }
        public Boolean B_RecepcionParcial { get; set; }
        public Int32 K_Movimiento_Transito_PT { get; set; }
        public String Direccion { get; set; }
        public Byte[] FirmaDigital { get; set; }
        public String Usuario_Recibe { get; set; }
        public Int32 K_Tipo_Movimiento { get; set; }
        public decimal PesoEmpaque { get; set; }
        public string Producto { get; set; }
        public int K_Tipo_Producto { get; set; }
        public int K_Almacen_Transfiere { get; set; }
        public int K_Tipo_Movimiento_Transito { get; set; }
    }
}
