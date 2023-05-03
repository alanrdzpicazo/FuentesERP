using System;

namespace PARIS.Modelos
{
    //****NO BORRAR PORQUE SE MODIFICO MANUAL
    public class EtiquetaRecepciones
    {
        public Int32 K_Tipo_Etiqueta { get; set; }
        public Int32 Color { get; set; }
        public String D_Producto { get; set; }
        public String D_Componente { get; set; }
        public String NombreSistema { get; set; }
        public String Lote { get; set; }
        public String F_Fabricacion { get; set; }
        public string PesoBruto { get; set; }
        public String D_Cliente { get; set; }
        public string PesoNeto { get; set; }
        public Boolean B_EvitarcontactoAgua { get; set; }
        public String Conductividad { get; set; }
        public String MedidaConductividad { get; set; }
        public String ResistenciaTermica { get; set; }
        public String MedidaResistencia { get; set; }
        public Boolean TieneConductividad { get; set; }
        public String Salud { get; set; }
        public String Inflamabilidad { get; set; }
        public String Reactividad { get; set; }
        public String MesLetra { get; set; }
        public String Version { get; set; }
        public Int32 K_Oficina { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Almacen { get; set; }
        public String D_Almacen { get; set; }
        public Int32 ClaveProducto { get; set; }
        public String Producto { get; set; }
        public DateTime FechaProduccion { get; set; }
        public Int32 CveEnvase { get; set; }
        public String Envase { get; set; }
        public Decimal CantKgs { get; set; }
        public Int32 Mes { get; set; }
        public Int32 K_Solicitud_Produccion { get; set; }
        public Int32 Cantidad { get; set; }
        public Int32 ColorMes { get; set; }
        public Int32 ColorFont { get; set; }
        public String FechaCaducidad { get; set; }
        public String Salud1 { get; set; }
        public String Inflamabilidad1 { get; set; }
        public String Reactividad1 { get; set; }
        public Int32 K_Inventario { get; set; }
        public Int32 Partida { get; set; }
        public DateTime F_Etiqueta { get; set; }
        public String imagen { get; set; }
        public int NivelSalud { get; set; }
        public int NivelInflamabilidad { get; set; }
        public int NivelReactividad { get; set; }
        public int MesColorRojo { get; set; }
        public int MesColorGreen { get; set; }
        public int MesColorBlue { get; set; }
        public int MesFontColorRojo { get; set; }
        public int MesFontColorGreen { get; set; }
        public int MesFontColorBlue { get; set; }
        public String Sistema { get; set; }
        public String FechaFabricacion { get; set; }
        public string Cliente { get; set; }
    }
}
