using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PARIS.Modelos
{
    public class Tipo_Empaque
    {
        public Int32 K_Tipo_Empaque { get; set; }
        public String D_Tipo_Empaque { get; set; }
        public Boolean B_Proveedor { get; set; }
        public Boolean B_Interno { get; set; }
        public Decimal PesoNeto { get; set; }
        public Decimal PesoBruto { get; set; }
        public String CamposBusqueda { get; set; }
    }
}
