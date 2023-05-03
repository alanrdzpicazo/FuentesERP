using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbeMedic.Modelos
{
    public class DetalleFactura
    {
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Importe { get; set; }
        public string Detalle { get; set; }
        public int K_Tipo_Empaque { get; set; }
        public string D_Tipo_Empaque { get; set; }
        public decimal CantidadKgs { get; set; }
        public string Lote { get; set; }
        public int K_Producto { get; set; }
        public int K_Articulo { get; set; }
        public string FraccionArancelaria { get; set; }
    }
}
