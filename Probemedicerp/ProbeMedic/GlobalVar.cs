﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbeMedic
{
    public static class Empresa
    {
        public static string D_Empresa = string.Empty;
        public static string Leyenda = string.Empty;
        public static string Calle = string.Empty;
        public static string Colonia = string.Empty;
        public static string D_Ciudad = string.Empty;
        public static string C_Estado = string.Empty;
        public static string CodigoPostal = string.Empty;
        public static string Telefono_Fax = string.Empty;
        public static string NoExterior = string.Empty;
        public static string NoInterior= string.Empty;

        public static string C_Empresa = string.Empty;
        public static string Telefono = string.Empty;
        public static string RFC = string.Empty;
        public static string D_Estado = string.Empty;
        public static string Fax = string.Empty;
        public static string PaginaWEB = string.Empty;     
    }
    public static class GlobalVar
    {
        public static string NombrePuertoCom = "COM1";
        public static string RespuestaPesa = string.Empty;
        public static string rutaExe = System.Windows.Forms.Application.ExecutablePath.ToString();
        public static int K_Usuario = 0;
        public static bool B_CambiaSerie = false;
        public static bool B_CambiaDatosFiscales = false;
        public static bool B_PermiteAjustes = false;
        public static int K_Asesor = 0;
        public static string D_Asesor = "";
        public static int K_Grupo = 0;
        public static int K_Oficina = 0;
        public static int K_Empresa = 0;
        public static int K_Empleado = 0;
        public static string Version = "1.0";
        public static string Conexion = "PRODUCCION";
        public static int K_Puesto = 0;
        public static int K_Pais = 0;
        public static int K_Estado = 0;
        public static int K_Ciudad = 0;
        public static int K_Menu = 0;
        public static short SPID = 0;
        public static string D_Oficina = string.Empty;
        public static string Grupo = string.Empty;
        public static string D_Usuario = string.Empty;
        public static string Login = string.Empty;
        public static string Contra = string.Empty;
        public static string D_Empleado = string.Empty;
        public static string D_Puesto = string.Empty;
        public static string Servidor = string.Empty;
        public static string D_Empresa = string.Empty;
        public static string LogoURL = string.Empty;
        public static string NombreForma = string.Empty;
        public static string PC_Name = string.Empty;
        public static decimal Tipo_Cambio = 0;
        public static bool B_SistemaEnProduccion = false;
        public static bool B_ResolucionProduccion = false;
        public static string CorreoDe = string.Empty;
        public static string CorreosmtpServer = string.Empty;
        public static int CorreoPuerto = 0;
        public static string CorreoUsuario = string.Empty;
        public static string CorreoContrasena = string.Empty;

        public static DataTable dtPaises = new DataTable();
        public static DataTable dtEstados = new DataTable();
        public static DataTable dtCiudades = new DataTable();
        public static DataTable dtPuestos = new DataTable();
        public static DataTable dtOficinas = new DataTable();
        public static DataTable dtOficinasEmpresa = new DataTable();
        public static DataTable dtDepartamentos = new DataTable();
        public static DataTable dtUsuarios = new DataTable();
        public static DataTable dtEmpleados = new DataTable();
        public static DataTable dtTipoProveedor = new DataTable();
        public static DataTable dtTipoMoneda = new DataTable();
        public static DataTable dtClasifProveedor = new DataTable();
        public static DataTable dtTipoArticulo = new DataTable();
        public static DataTable dtClasificacionArticulo = new DataTable();
        public static DataTable dtGrupoArticulo = new DataTable();
        public static DataTable dtUnidadMedida = new DataTable();
        public static DataTable dtTipoRequisicion = new DataTable();
        public static DataTable dtArticulos = new DataTable();
        public static DataTable dtArticulosNombreInterno = new DataTable();
        public static DataTable dtEstatusCompra = new DataTable();
        public static DataTable dtTipoCliente = new DataTable();
        public static DataTable dtTipoFiscal = new DataTable();
        public static DataTable dtClasificacion = new DataTable();
        public static DataTable dtServicios = new DataTable();
        public static DataTable dtImpuestos = new DataTable();
        public static DataTable dtPreciosAmbulancia = new DataTable();
        public static DataTable dtPreciosEnfermeria = new DataTable();
        public static DataTable dtTipoProducto = new DataTable();
        public static DataTable dtClaseProducto = new DataTable();
        public static DataTable dtFamiliaProducto = new DataTable();
        public static DataTable dtSerieProducto = new DataTable();
        public static DataTable dtBancos = new DataTable();
        public static DataTable dtEmpresa = new DataTable();
        public static DataTable dtEmpresa_Cuentas = new DataTable();
        public static DataTable dtTipos_Factura = new DataTable();
        public static DataTable dtTraspasos = new DataTable();
        public static DataTable dtTraspasosPT = new DataTable();

        public static bool CatalogoPropiedadB_Editando = false;
        public static bool CatalogoPropiedadB_Agregando = false;

    }
}