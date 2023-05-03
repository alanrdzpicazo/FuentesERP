using System;

namespace PARIS.Modelos
{
    public class DevolucionesComentario_PT
    {
        public Int32 K_DevolucionComentario_PT { get; set; }
        public String Devolucion { get; set; }
        public Int32 K_SolicitudDevolucion_PT { get; set; }        
        public Int32 K_Cliente { get; set; }
        public String D_Cliente { get; set; }
        public String Comentario { get; set; }
        public DateTime F_Visita { get; set; }
        public Int32 K_EmpleadoVisita { get; set; }
        public String D_Empleado { get; set; }
        public String PC_Name { get; set; }
        public DateTime F_Actualiza { get; set; }
        public Int32 K_Usuario { get; set; }
        public String CamposBusqueda { get; set; }
        public string rutaPDF { get; set; }
    }
}
