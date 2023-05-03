using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbeMedic.Modelos
{
    public class consulta_factura_detalle
    {       
        public Int32 Orden { get; set; }        
        public Decimal cantidad { get; set; }        
        public Decimal cantidadkgs { get; set; }        
        public String unidad { get; set; }
        public int K_Tipo_Empaque { get; set; }
        public String tipoEmpaque { get; set; }        
        public String descripcion { get; set; }        
        public String detalle { get; set; }        
        public Decimal valorunitario { get; set; }        
        public Decimal importe { get; set; }        
        public String lote { get; set; }        
        public Int32 K_Producto { get; set; }        
        public Int32 K_Articulo { get; set; }
    }
}
