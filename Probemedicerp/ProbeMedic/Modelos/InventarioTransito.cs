using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbeMedic.Modelos
{
    public class InventarioTransito
    {
        
        public String TipoInventario { get; set; }
        
        public Int32 Consecutivo { get; set; }
        
        public Int32 ID_Transito { get; set; }
        
        public Int32 K_Tipo_Movimiento { get; set; }
        
        public String D_Tipo_Movimiento { get; set; }
        
        public Int32 K_Oficina_Envia { get; set; }
        
        public String D_Oficina_Envia { get; set; }
        
        public Int32 K_Almacen_Envia { get; set; }
        
        public String D_Almacen_Envia { get; set; }
        
        public Int32 K_Oficina_Transfiere { get; set; }
        
        public String D_Oficina_Recibe { get; set; }
        
        public Int32 K_Almacen_Transfiere { get; set; }
        
        public String D_Almacen_Recibe { get; set; }
        
        public Int32 PiezasTransfiere { get; set; }
        
        public Decimal KgsTransfiere { get; set; }
        
        public Int32 PiezasRecibidas { get; set; }
        
        public Decimal Kgs_Recibidos { get; set; }
        
        public String TipoRecepcion { get; set; }
        
        public String Observaciones { get; set; }
        
        public Int32 K_Usuario_Movimiento { get; set; }
        
        public String D_Usuario_Movimiento { get; set; }
        
        public String F_Movimiento { get; set; }
        
        public Int32 K_Usuario_Recibe { get; set; }
        
        public String D_Usuario_Recibe { get; set; }
        
        public DateTime F_Recepcion { get; set; }
    }
}
