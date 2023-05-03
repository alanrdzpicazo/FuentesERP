using System;

namespace ProbeMedic.Modelos
{
    public class Clientes
    {
        public Int32 K_Cliente { get; set; }
        public String D_Cliente { get; set; }
        public String C_Cliente { get; set; }
        public String RFC { get; set; }
        public Int16 K_Pais { get; set; }
        public Int32 K_Estado { get; set; }
        public Int32 K_Ciudad { get; set; }
        public String D_Pais { get; set; }
        public String D_Estado { get; set; }
        public String D_Ciudad { get; set; }
        public String Poblacion { get; set; }
        public String Colonia { get; set; }
        public String Direccion { get; set; }
        public String Numero { get; set; }
        public String CodigoPostal { get; set; }
        public String Telefono { get; set; }
        public String Fax { get; set; }
        public String PaginaWEB { get; set; }
        public String Correo_Cliente { get; set; }
        public Int16 K_Tipo_Cliente { get; set; }
        public Int16 K_Clasificacion_Cliente { get; set; }
        public Int16 K_Estatus_Cliente { get; set; }
        public Int16 K_Tipo_Fiscal { get; set; }
        public Int16 DiasCredito { get; set; }
        public Decimal LimiteCredito { get; set; }
        public String Cuenta_Contable { get; set; }
        public DateTime F_Alta { get; set; }
        public Boolean B_Activo { get; set; }
        public DateTime F_Baja { get; set; }
        public String Observaciones { get; set; }
        public String CURP { get; set; }
        public String ReferenciaBancaria { get; set; }
        public String NumInterior { get; set; }
        public Int32 K_Oficina { get; set; }
        public String D_Oficina { get; set; }
        public Int32 K_Ejecutivo { get; set; }
        public String D_Empleado { get; set; }
        public Decimal LimiteCreditoDolares { get; set; }
        public Int32 K_Usuario_Modifica { get; set; }
        public String D_Usuario { get; set; }
        public String F_Modificacion { get; set; }
        public String D_Estatus_Cliente { get; set; }
        public String D_Tipo_Cliente { get; set; }
        public String D_Tipo_Fiscal { get; set; }
        public String Observaciones_Estatus { get; set; }
        public String CamposBusqueda { get; set; }
    }
}
