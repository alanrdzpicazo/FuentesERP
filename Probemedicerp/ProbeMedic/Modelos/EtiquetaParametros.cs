using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PARIS.Modelos
{
    public class EtiquetaParametros
    {
        public int? K_Etiqueta { get; set; }
        public int? Partida { get; set; }
        public int? K_Almacen { get; set; }
        public string D_Almacen { get; set; }
        public int? K_Articulo { get; set; }
        public string D_Articulo { get; set; }
        public int? K_Producto { get; set; }
        public string D_Producto { get; set; }
        public string Lote { get; set; }
        public DateTime F_Inserta { get; set; }
        public int? K_Oficina { get; set; }
        public string D_Oficina { get; set; }
        public int? K_Tipo_Empaque { get; set; }
        public string D_Tipo_Empaque { get; set; }
        public decimal? Peso { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Kg { get; set; }
        public string Ubicacion { get; set; }
        public string Comentario { get; set; }
        public string Origen { get; set; }

    }
}
