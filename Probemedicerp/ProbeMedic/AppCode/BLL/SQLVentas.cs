﻿using ProbeMedic.AppCode.DCC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.AppCode.BLL
{
    ////// INSERTA REGISTRO FACTURAS /////


    class SQLVentas
    {
        // INSERTA FACTURA PEDIDOS
        public int In_Registro_Factura(ref Int32 K_Factura,Int32 K_Oficina, Int32 K_Tipo_Venta, DateTime F_Entrega,Int32 K_Tipo_Moneda,
            decimal Tipo_Cambio,Int32 K_Cliente,Int32 K_Cliente_Domicilio_Fiscal, Int32 K_Canal_Distribucion,Int32 K_Medico,decimal Porcentaje_Descuento,
            decimal Descuento,decimal Subtotal,decimal Total_IVA,decimal Total_Factura,Int32 K_Usuario_Captura,decimal Coaseguro,
            decimal PorcentajeCoaseguro,string Observaciones,string PC_Name,bool B_Remisionado,bool B_SurtidoCompleto,
            Int32 K_Almacen,Int32 K_Paciente,Int32 K_Paciente_Direccion,DataTable FacturaDetalle,DataTable Pedidos,
            int K_Celula,string Carta,string Poliza, bool B_Credito,string D_Serie,Int32 K_Forma_Pago,Int32 K_Uso_CFDI,string Correo,
            DataTable DetalleVentaPrivada,bool? B_PPD, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Registro_Factura";

            IDataParameter p_K_Factura = new SqlParameter("@K_Factura", SqlDbType.Int);
            p_K_Factura.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Factura);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Factura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@PorcentajeCoaseguro", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 1024));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Remisionado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_SurtidoCompleto", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FacturaDetalle", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Pedidos", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Carta", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Poliza", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Credito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar,30));
            cmd.Parameters.Add(new SqlParameter("@K_Forma_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Uso_CFDI", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@DetalleVentaPrivada", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@B_PPD", SqlDbType.Bit));

            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@F_Entrega"].Value = F_Entrega;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion;
            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Factura"].Value = Total_Factura;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@Coaseguro"].Value = K_Usuario_Captura;
            cmd.Parameters["@PorcentajeCoaseguro"].Value = K_Usuario_Captura;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@B_Remisionado"].Value = B_Remisionado;
            cmd.Parameters["@B_SurtidoCompleto"].Value = B_SurtidoCompleto;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Paciente_Direccion"].Value = K_Paciente_Direccion;
            cmd.Parameters["@FacturaDetalle"].Value = FacturaDetalle;
            cmd.Parameters["@Pedidos"].Value = Pedidos;
            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@Carta"].Value = Carta;
            cmd.Parameters["@Poliza"].Value = Poliza;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@B_Credito"].Value = B_Credito;
            if (D_Serie.Length == 0)
            {
                cmd.Parameters["@D_Serie"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@D_Serie"].Value = D_Serie;
            }
            if(K_Forma_Pago == 0)
            {
                cmd.Parameters["@K_Forma_Pago"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Forma_Pago"].Value = K_Forma_Pago;
            }
           if(K_Uso_CFDI ==0)
            {
                cmd.Parameters["@K_Uso_CFDI"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Uso_CFDI"].Value = K_Uso_CFDI;
            }
            cmd.Parameters["@Correo"].Value = Correo;

            if(K_Tipo_Venta==1)
            {
                cmd.Parameters["@DetalleVentaPrivada"].Value = DetalleVentaPrivada;
            }
            cmd.Parameters["@B_PPD"].Value = B_PPD;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Factura = Convert.ToInt32(p_K_Factura.Value);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        //INSERTA FACTURA FARMACIA
        public int In_Registro_Factura(ref Int32 K_Factura, Int32 K_Oficina, Int32 K_Tipo_Venta, DateTime F_Entrega, Int32 K_Tipo_Moneda,
            decimal Tipo_Cambio, Int32 K_Cliente, Int32 K_Cliente_Domicilio_Fiscal, Int32 K_Canal_Distribucion, Int32 K_Medico, decimal Porcentaje_Descuento,
            decimal Descuento, decimal Subtotal, decimal Total_IVA, decimal Total_Factura, Int32 K_Usuario_Captura, decimal Coaseguro,
            decimal PorcentajeCoaseguro, string Observaciones, string PC_Name, bool B_Remisionado, bool B_SurtidoCompleto,
            Int32 K_Almacen, Int32 K_Paciente, Int32 K_Paciente_Direccion, bool B_Credito, DataTable FacturaDetalle, string D_Serie, Int32 K_Forma_Pago, Int32 K_Uso_CFDI, 
            string Correo, Int32 K_Transaccion,ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Registro_Factura";

            IDataParameter p_K_Factura = new SqlParameter("@K_Factura", SqlDbType.Int);
            p_K_Factura.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Factura);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Factura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@PorcentajeCoaseguro", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 400));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Remisionado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_SurtidoCompleto", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FacturaDetalle", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Credito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Forma_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Uso_CFDI", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));

            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@F_Entrega"].Value = F_Entrega;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion;
            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Factura"].Value = Total_Factura;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@Coaseguro"].Value = K_Usuario_Captura;
            cmd.Parameters["@PorcentajeCoaseguro"].Value = K_Usuario_Captura;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@B_Remisionado"].Value = B_Remisionado;
            cmd.Parameters["@B_SurtidoCompleto"].Value = B_SurtidoCompleto;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Paciente_Direccion"].Value = K_Paciente_Direccion;
            cmd.Parameters["@FacturaDetalle"].Value = FacturaDetalle;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@B_Credito"].Value = B_Credito;

            if (D_Serie.Length == 0)
            {
                cmd.Parameters["@D_Serie"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@D_Serie"].Value = D_Serie;
            }
            if (K_Forma_Pago == 0)
            {
                cmd.Parameters["@K_Forma_Pago"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Forma_Pago"].Value = K_Forma_Pago;
            }
            if (K_Uso_CFDI == 0)
            {
                cmd.Parameters["@K_Uso_CFDI"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Uso_CFDI"].Value = K_Uso_CFDI;
            }
            if (K_Transaccion == 0)
            {
                cmd.Parameters["@K_Transaccion"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;
            }

            cmd.Parameters["@Correo"].Value = Correo;


            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Factura = Convert.ToInt32(p_K_Factura.Value);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        //////////////////////SERVICIOS CONTRATADOS ENFERMERIA//////////////////////////
        public DataTable SK_Servicios_Enfermeria(bool B_Realizado, DateTime F_Inicial, DateTime F_Final, Int32 K_Cliente, bool B_Pagado, bool B_Cancelado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Servicios_Enfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Realizado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Pagado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelado", SqlDbType.Bit));
            cmd.Parameters["@B_Realizado"].Value = B_Realizado;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@B_Pagado"].Value = B_Pagado;
            cmd.Parameters["@B_Cancelado"].Value = B_Cancelado;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable SK_Detalle_ArticulosEnfermeria(Int32 K_Servicio_Contratado_Enfermeria)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Detalle_ArticulosEnfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));
            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable GP_Valida_PreciosEnfermeria(Int32 K_Dias_Servicio, Int32 K_Clase_ServicioEnfermeria, Int32 K_Tipo_Servicio_Enfermeria, Int32 K_Duracion_Servicio)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Valida_PreciosEnfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.Int));
            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;



        }

        public DataTable GP_Extrae_OficinaEnfermeria(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Extrae_OficinaEnfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;



        }

        public DataTable GP_Extrae_Precio_Enfermeria(bool B_Local, Int32 K_Cliente, Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia, Int32 K_Precio_Enfermeria)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Extrae_Precio_Enfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;



        }

        public int In_Servicios_Contratados(ref Int32 K_Servicio_Contratado_Enfermeria,
            Int32 K_Cliente,
            Int32 K_Oficina,
            Int32 K_Pais,
            Int32 K_Estado,
            Int32 K_Ciudad,
            Int32 K_Colonia,
            bool B_Local,
            decimal Precio,
            DateTime F_Servicio,
            Int32 K_Dias_Servicio,
            Int32 K_Clase_ServicioEnfermeria,
            Int32 K_Tipo_ServicioEnfermeria,
            Int32 K_Duracion_Servicio,
            Int32 K_Precio_Enfermeria,
            string Calle,
            bool B_Masculino,
            bool B_Mas120Kilos,
            String TelefonoContacto,
            DataTable Articulos_DetalleEnfermeria,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Servicios_Contratados";

            IDataParameter p_K_Servicio_Contratado_Enfermeria = new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int);
            p_K_Servicio_Contratado_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Servicio_Contratado_Enfermeria);

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@CalleNumero", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Servicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Masculino", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Mas120Kilos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@TelefonoContacto", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Articulos_DetalleEnfermeria", SqlDbType.Structured));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@CalleNumero"].Value = Calle;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Servicio"].Value = F_Servicio;
            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Tipo_ServicioEnfermeria"].Value = K_Tipo_ServicioEnfermeria;
            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Duracion_Servicio;
            cmd.Parameters["@B_Masculino"].Value = B_Masculino;
            cmd.Parameters["@B_Mas120Kilos"].Value = B_Mas120Kilos;
            cmd.Parameters["@TelefonoContacto"].Value = TelefonoContacto;
            cmd.Parameters["@Articulos_DetalleEnfermeria"].Value = Articulos_DetalleEnfermeria;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Servicio_Contratado_Enfermeria = (Int32)p_K_Servicio_Contratado_Enfermeria.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Servicios_RecurrentesEnfermeria(ref Int32 K_Servicio_Contratado_Enfermeria,
           Int32 K_Cliente,
           Int32 K_Oficina,
           Int32 K_Pais,
           Int32 K_Estado,
           Int32 K_Ciudad,
           Int32 K_Colonia,
           bool B_Local,
           decimal Precio,
           DateTime F_Servicio,
           Int32 K_Dias_Servicio,
           Int32 K_Clase_ServicioEnfermeria,
           Int32 K_Tipo_ServicioEnfermeria,
           Int32 K_Duracion_Servicio,
           Int32 K_Precio_Enfermeria,
           DateTime F_Inicio_Servicio,
           DateTime F_Fin_Servicio,
           bool B_Mas120Kilos,
           bool B_Masculino,
           ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Servicios_RecurrentesEnfermeria";

            IDataParameter p_K_Servicio_Contratado_Enfermeria = new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int);
            p_K_Servicio_Contratado_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Servicio_Contratado_Enfermeria);

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Servicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Servicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Servicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Mas120Kilos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Masculino", SqlDbType.Bit));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Servicio"].Value = F_Servicio;
            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Tipo_ServicioEnfermeria"].Value = K_Tipo_ServicioEnfermeria;
            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Duracion_Servicio;
            cmd.Parameters["@F_Inicio_Servicio"].Value = F_Inicio_Servicio;
            cmd.Parameters["@F_Fin_Servicio"].Value = F_Fin_Servicio;
            cmd.Parameters["@B_Mas120Kilos"].Value = B_Mas120Kilos;
            cmd.Parameters["@B_Masculino"].Value = B_Masculino;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Servicio_Contratado_Enfermeria = (Int32)p_K_Servicio_Contratado_Enfermeria.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable SK_Articulos_SOS()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Articulos_SOS";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Gp_RepPedidosPtes(Int32 K_Oficina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepPedidosPtes";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));

            if(K_Oficina==0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Pagos_Enfermeria(
        Int32 K_Servicio_Contratado_Enfermeria,
        Int32 K_Banco_Tarjeta,
        String No_Trajeta,
        bool B_TarjetaCredito,
        decimal Monto,
        String Aprobacion,
        String No_Operacion,
        bool B_Tarjeta,
        Int32 K_Usuario_Aplica,
        ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pagos_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco_Tarjeta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Tarjeta", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_TarjetaCredito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Aprobacion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@No_Operacion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_Tarjeta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplica", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@K_Banco_Tarjeta"].Value = K_Banco_Tarjeta;
            cmd.Parameters["@No_Tarjeta"].Value = No_Trajeta;
            cmd.Parameters["@B_TarjetaCredito"].Value = B_TarjetaCredito;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@Aprobacion"].Value = Aprobacion;
            cmd.Parameters["@No_Operacion"].Value = No_Operacion;
            cmd.Parameters["@B_Tarjeta"].Value = B_Tarjeta;
            cmd.Parameters["@K_Usuario_Aplica"].Value = K_Usuario_Aplica;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pagos_Enfermeria(Int32 K_Servicio_Contratado_Enfermeria)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pagos_Enfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));
            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_ConsultaPedidoporAsignar(Int32 K_Pedido, Int32 k_Oficina, ref Int32 Consecutivo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaPedidoporAsignar";
            DataTable dt = new DataTable();

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@k_Oficina"].Value = k_Oficina;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            dt = ConnectionClass.GetTable(ref cmd);

            Consecutivo = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return dt;
        }
        public DataTable Sk_consulta_Pedido_detalle_Inventario(Int32 k_pedido, Int32 k_pedido_detalle, Int32 k_tipo_Venta, Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_consulta_Pedido_detalle_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@k_pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_pedido_detalle", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@k_pedido"].Value = k_pedido;
            cmd.Parameters["@k_pedido_detalle"].Value = k_pedido_detalle;
            cmd.Parameters["@k_tipo_Venta"].Value = k_tipo_Venta;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int In_pedido_inventario(DataTable Pd_Inventario, Int32 Tipo_Venta, Int32 k_usuario, string PcName, Int32 K_PEDIDO, string Observaciones, ref Int32 Consecutivo, Int32 K_Tipo_Entrega,
                                        Int32 K_Empresa_Entrega, String No_Guia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_pedido_inventario";

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Pd_Inventario", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PcName", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_PEDIDO", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 500));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Guia", SqlDbType.VarChar, 50));

            cmd.Parameters["@Pd_Inventario"].Value = Pd_Inventario;
            cmd.Parameters["@Tipo_Venta"].Value = Tipo_Venta;
            cmd.Parameters["@k_usuario"].Value = k_usuario;
            cmd.Parameters["@PcName"].Value = PcName;
            cmd.Parameters["@K_PEDIDO"].Value = K_PEDIDO;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
            cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            cmd.Parameters["@No_Guia"].Value = No_Guia;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Consecutivo = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Gp_RepRemision(Int32 K_Remision)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepRemision";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Remision", SqlDbType.Int));
            cmd.Parameters["@K_Remision"].Value = K_Remision;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_consulta_Factura_detalle_Inventario(Int32 K_Factura, Int32 K_Factura_detalle)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_consulta_Factura_detalle_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura_detalle", SqlDbType.Int));

            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Factura_detalle"].Value = K_Factura_detalle;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Factura_inventario(
            DataTable Pd_Inventario,
            Int32 Tipo_Venta,
            Int32 k_usuario,
            string PcName,
            Int32 K_Factura,
            Int32 K_Tipo_Entrega,
            Int32 K_Empresa_Entrega,
            String No_Guia,
            string Observaciones,
            ref Int32 Consecutivo,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Factura_inventario";

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Pd_Inventario", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PcName", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 500));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Guia", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            cmd.Parameters["@Pd_Inventario"].Value = Pd_Inventario;
            cmd.Parameters["@Tipo_Venta"].Value = Tipo_Venta;
            cmd.Parameters["@k_usuario"].Value = k_usuario;
            cmd.Parameters["@PcName"].Value = PcName;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
            cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            cmd.Parameters["@No_Guia"].Value = No_Guia;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Consecutivo = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_ConsultaFacturaporAsignar(Int32 K_Factura, Int32 k_Oficina, ref Int32 Consecutivo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaFacturaporAsignar";
            DataTable dt = new DataTable();

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@k_Oficina"].Value = k_Oficina;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            dt = ConnectionClass.GetTable(ref cmd);

            Consecutivo = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return dt;
        }

        public DataTable Gp_Pedidos_Bloqueados()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Pedidos_Bloqueados";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Gp_ApruebaPedido(
           Int32 K_Pedido,
           Int32 K_Estatus_Pedido,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ApruebaPedido";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.Int));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_Inventario_Farmacia(Int32 K_Oficina, Int32 K_Almacen, Int32 K_Articulo, Boolean B_MostrarTodo, Boolean B_Existencia,
                                                string SKU, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, Int32 K_Cliente ,  ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario_Farmacia";
            DataTable dt = new DataTable();

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Existencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));

            if(K_Oficina==0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }

            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }

            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }

            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;
            cmd.Parameters["@B_Existencia"].Value = B_Existencia;

            if (SKU.Length == 0)
            {
                cmd.Parameters["@SKU"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@SKU"].Value = SKU;
            }

            if(K_Laboratorio==0)
            {
                cmd.Parameters["@K_Laboratorio"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            }

            if(K_Sustancia_Activa==0)
            {
                cmd.Parameters["@K_Sustancia_Activa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            }
            if(K_Cliente==0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            dt = ConnectionClass.GetTable(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return dt;
        }
        public DataTable Gp_Inventario_Farmacia(Int32 K_Almacen, Int32 K_Articulo, Boolean B_MostrarTodo, Boolean B_Existencia,
                                        string SKU, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario_Farmacia";
            DataTable dt = new DataTable();

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Existencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));

            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }
            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }
            
            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;
            cmd.Parameters["@B_Existencia"].Value = B_Existencia;

            if(SKU.Length==0)
            {
                cmd.Parameters["@SKU"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@SKU"].Value = SKU;
            }
            if(K_Laboratorio==0)
            {
                cmd.Parameters["@K_Laboratorio"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            }

            if(K_Sustancia_Activa==0)
            {
                cmd.Parameters["@K_Sustancia_Activa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            }
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            dt = ConnectionClass.GetTable(ref cmd);

            Mensaje = (string)p_Mensaje.Value;
            return dt;
        }
        public int In_Venta_Articulos(ref Int32 Transaccion, Int32 K_Almacen, Int32 K_Usuario, decimal Monto_Transaccion, Int32 Cantidad_Articulos, Int32 K_Medico, Int32 K_Cliente, bool B_Requiere_Receta,
                                      string Observaciones1, string Observaciones2, string Observaciones3, string Observaciones4, string Observaciones5, bool B_Entrega_Domicilio, DataTable Detalle_Articulos,
                                      DataTable Detalle_Pagos, decimal No_Tarjeta, ref string Folios_Receta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Venta_Articulos";

            IDataParameter p_Consecutivo = new SqlParameter("@K_Transaccion", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Folios = new SqlParameter("@Folios_Ingreso_Receta", SqlDbType.VarChar, 1000);
            p_Folios.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Folios);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Transaccion", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Articulos", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Receta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Observaciones_1", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Observaciones_2", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Observaciones_3", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Observaciones_4", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Observaciones_5", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Entrega_Domicilio", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Detalle_Venta", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Detalle_Pago", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@No_Tarjeta", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Transaccion"].Value = Transaccion;
            cmd.Parameters["@Folios_Ingreso_Receta"].Value = Folios_Receta;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Monto_Transaccion"].Value = Monto_Transaccion;
            cmd.Parameters["@Cantidad_Articulos"].Value = Cantidad_Articulos;
            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@B_Requiere_Receta"].Value = B_Requiere_Receta;
            cmd.Parameters["@Observaciones_1"].Value = Observaciones1;
            cmd.Parameters["@Observaciones_2"].Value = Observaciones2;
            cmd.Parameters["@Observaciones_3"].Value = Observaciones3;
            cmd.Parameters["@Observaciones_4"].Value = Observaciones4;
            cmd.Parameters["@Observaciones_5"].Value = Observaciones5;
            cmd.Parameters["@B_Entrega_Domicilio"].Value = B_Entrega_Domicilio;
            cmd.Parameters["@Detalle_Venta"].Value = Detalle_Articulos;
            cmd.Parameters["@Detalle_Pago"].Value = Detalle_Pagos;
            cmd.Parameters["@No_Tarjeta"].Value = No_Tarjeta;
            cmd.Parameters["@PC_Name"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Transaccion = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;
            Folios_Receta = (string)p_Folios.Value;

            return res;
        }
        public int Gp_Aplica_Cierre(ref Int32 K_Cierre_Ingresos, Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Aplica_Cierre";

            IDataParameter p_Consecutivo = new SqlParameter("@K_Cierre_Ingresos", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Cierre_Ingresos"].Value = K_Cierre_Ingresos;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cierre_Ingresos = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_Aplica_Precierre(ref Int32 K_Precierre_Empleado_Oficina, Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Aplica_Precierre";

            IDataParameter p_Consecutivo = new SqlParameter("@K_Precierre_Empleado_Oficina", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Empleado"].Value = GlobalVar.K_Empleado;
            cmd.Parameters["@K_Precierre_Empleado_Oficina"].Value = K_Precierre_Empleado_Oficina;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Precierre_Empleado_Oficina = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_Entrada_CajaChica(ref Int32 K_Caja_Chica_Venta, Int32 K_Almacen, decimal Monto_Transaccion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Entrada_CajaChica";

            IDataParameter p_Consecutivo = new SqlParameter("@K_Caja_Chica_Venta", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Transaccion", SqlDbType.Decimal));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Empleado"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Monto_Transaccion"].Value = Monto_Transaccion;
            cmd.Parameters["@K_Caja_Chica_Venta"].Value = K_Caja_Chica_Venta;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Caja_Chica_Venta = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_Up_Servicios_Contratados_Enfermeria(
        Int32 K_Servicio_Contratado_Enfermeria,
        Decimal Precio,
        DataTable Articulos_DetalleEnfermeria,
      ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Up_Servicios_Contratados_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Articulos_DetalleEnfermeria", SqlDbType.Structured));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@Articulos_DetalleEnfermeria"].Value = Articulos_DetalleEnfermeria;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Gp_Inventario_Farmacia(
            Int32 K_Oficina,
            Int32 K_Almacen,
            Int32 K_Articulo,
            bool B_MostrarTodo,
            bool B_Existencia,
            string SKU,
            Int32 K_Laboratorio,
            Int32 K_Sustancia_Activa,
            string D_Articulo)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario_Farmacia";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Existencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar,100));

            if(K_Oficina==0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }
            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }

            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }  
            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;
            cmd.Parameters["@B_Existencia"].Value = B_Existencia;

            if(K_Laboratorio==0)
            {
                cmd.Parameters["@K_Laboratorio"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            }
            if(K_Sustancia_Activa==0)
            {
                cmd.Parameters["@K_Sustancia_Activa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            }
            if(SKU.Length==0)
            {
                cmd.Parameters["@SKU"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@SKU"].Value = SKU;
            }

            if(D_Articulo.Length==0)
            {
                cmd.Parameters["@D_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            }
  
        

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_RepCajaChica(
           Int32 K_Usuario,
           Int32 K_Almacen,
           Int32 K_Caja_Chica_Venta)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepCajaChica";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Caja_Chica_Venta", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Caja_Chica_Venta"].Value = K_Caja_Chica_Venta;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_RepPrecierre(
           Int32 K_Precierre_Empleado,
           Int32 K_Usuario)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepPrecierre";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Precierre_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precierre_Empleado"].Value = K_Precierre_Empleado;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_RepCierreOficina(
          Int32 K_Almacen,
          Int32 K_Cierre_Ingresos)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepCierreOficina";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cierre_Ingresos", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Cierre_Ingresos"].Value = K_Cierre_Ingresos;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Gp_Trae_Precierre(Int32 K_Almacen, Int32 K_Usuario, ref Int32 K_Precierre_Empleado, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Trae_Precierre";
            DataTable dt = new DataTable();

            IDataParameter p_K_Precierre_Empleado = new SqlParameter("@K_Precierre_Empleado", SqlDbType.Int);
            p_K_Precierre_Empleado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precierre_Empleado);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 200);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Precierre_Empleado"].Value = K_Precierre_Empleado;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if ((Int32)p_K_Precierre_Empleado.Value != 0)
                K_Precierre_Empleado = (Int32)p_K_Precierre_Empleado.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipos_PagoVenta(
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_PagoVenta";

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Gp_Aplica_Precierre(
       Int32 K_Almacen,
       Int32 K_Usuario,
       DataTable PagosPrecierre,
        ref Int32 K_Precierre_Empleado_Oficina,
        ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Aplica_Precierre";

            IDataParameter p_K_Precierre_Empleado_Oficina = new SqlParameter("@K_Precierre_Empleado_Oficina", SqlDbType.Int);
            p_K_Precierre_Empleado_Oficina.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precierre_Empleado_Oficina);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PagosPrecierre", SqlDbType.Structured));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PagosPrecierre"].Value = PagosPrecierre;
            cmd.Parameters["@K_Precierre_Empleado_Oficina"].Value = K_Precierre_Empleado_Oficina;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            K_Precierre_Empleado_Oficina = (Int32)p_K_Precierre_Empleado_Oficina.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_Valida_EntradaVenta(Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Valida_EntradaVenta";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_GeneraCierreOficina(Int32 K_Almacen_Cierre, Int32 K_Usuario_Genera, ref Int32 NoCierre, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_GeneraCierreOficina";

            IDataParameter p_NoCierre = new SqlParameter("@NoCierre", SqlDbType.Int);
            p_NoCierre.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_NoCierre);


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen_Cierre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Genera", SqlDbType.Int));

            cmd.Parameters["@K_Almacen_Cierre"].Value = K_Almacen_Cierre;
            cmd.Parameters["@K_Usuario_Genera"].Value = K_Usuario_Genera;
            cmd.Parameters["@NoCierre"].Value = NoCierre;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            NoCierre = (Int32)p_NoCierre.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public DataTable Gp_InventarioxArticulo(
          Int32 K_Oficina,
          Int32 K_Almacen,
          Int32 K_Articulo
          )
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_InventarioxArticulo";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));


            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Consulta_Venta(
         Int32 K_Transaccion
         )
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Consulta_Venta";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));

            cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Gp_Cancela_Venta(Int32 K_Transaccion, String Observaciones, DataTable Detalle_Cancelacion,Int32 K_Usuario,string PC_Name, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Cancela_Venta";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@dtDetalle", SqlDbType.Structured));

            cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@dtDetalle"].Value = Detalle_Cancelacion;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_Up_ClientesTarjeta(decimal No_TarjetaCapturada, Int32 K_Cliente, string D_Cliente, string RFC, string Correo, decimal Puntos, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Up_ClientesTarjeta";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@No_TarjetaCapturada", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cliente", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Puntos", SqlDbType.Decimal));

            cmd.Parameters["@No_TarjetaCapturada"].Value = No_TarjetaCapturada;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@D_Cliente"].Value = D_Cliente;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@Puntos"].Value = 0;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public int Gp_Up_ClientesTarjeta(Int32 No_TarjetaCapturada, Int32 K_Cliente, decimal Puntos, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Up_ClientesTarjeta";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("No_TarjetaCapturada", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Puntos", SqlDbType.Decimal));

            cmd.Parameters["No_TarjetaCapturada"].Value = No_TarjetaCapturada;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@Puntos"].Value = Puntos;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;
            return res;
        }

        public DataTable Sk_ClienteDatosTarjeta(decimal No_Tarjeta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ClienteDatosTarjeta";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@No_Tarjeta", SqlDbType.Decimal));
            cmd.Parameters["@No_Tarjeta"].Value = No_Tarjeta;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_ClienteDatosTarjeta(Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ClienteDatosTarjeta";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Decimal));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Inventario_Ubicacion(
     Int32 K_Oficina,
     Int32 K_Almacen,
     bool B_SinUbicacion,
     bool B_Completo
     )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_Ubicacion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_SinUbicacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Completo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@B_SinUbicacion"].Value = B_SinUbicacion;
            cmd.Parameters["@B_Completo"].Value = B_Completo;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Inventario_Tarjetas(
          Int32 K_Almacen,
          String Folios,
          Int32 K_Usuario_Aplica,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Inventario_Tarjetas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Folios", SqlDbType.VarChar, 5000));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplica", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@Folios"].Value = Folios;
            cmd.Parameters["@K_Usuario_Aplica"].Value = K_Usuario_Aplica;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Inventario_Tarjetas(
          Int32 K_Almacen
          )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_Tarjetas";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Inventario_Tarjetas(Int32 K_Tarjeta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Inventario_Tarjetas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tarjeta", SqlDbType.Int));
            cmd.Parameters["@K_Tarjeta"].Value = K_Tarjeta;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            Mensaje = (string)p_Mensaje.Value;

            return res;


        }

        public DataTable Sk_Inventario_Ubicacion(
           Int32 K_Oficina,
           Int32 K_Almacen,
           Int32 K_Articulo,
           bool B_SinUbicacion,
           bool B_Completo
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_Ubicacion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_SinUbicacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Completo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@B_SinUbicacion"].Value = B_SinUbicacion;
            cmd.Parameters["@B_Completo"].Value = B_Completo;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Gp_Sk_Inventario_Venta(
          Int32 K_Almacen,
          Int32 K_Articulo,
          Int32 K_Cliente,
          string D_Articulo
          )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Sk_Inventario_Venta";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar,60));

            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }
            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }
            if(K_Cliente==0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }
            if(D_Articulo.Length==0)
            {
                cmd.Parameters["@D_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            }
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Tipos_PagoPrecierre(
         Int32 K_Precierre_Empleado
         )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_PagoPrecierre";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Precierre_Empleado", SqlDbType.Int));
            cmd.Parameters["@K_Precierre_Empleado"].Value = K_Precierre_Empleado;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public DataTable Sk_ConsultaPedidoAsignados(Int32 K_Pedido, Int32 k_Oficina, ref Int32 Consecutivo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaPedidosAsignados";
            DataTable dt = new DataTable();

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@k_Oficina"].Value = k_Oficina;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            dt = ConnectionClass.GetTable(ref cmd);

            Consecutivo = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return dt;
        }
        public int Gp_CancelaPedidosAsignacion(Int32 K_Pedido, Int32 k_usuario, string PcName, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_CancelaPedidosAsignaciones";
            DataTable dt = new DataTable();


            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PcName", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@k_usuario"].Value = k_usuario;
            cmd.Parameters["@PcName"].Value = PcName;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_pedidos(Int32 K_Pedido, Int32 K_Oficina, Int32 K_Cotizacion, Int32 K_Cliente, DateTime F_Inicial, DateTime F_Final, Int32 K_Tipo_Moneda, Int32 K_Estatus_Pedido, Int32 K_Ejecutivo, bool B_ParaFacturar)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pedidos";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ejecutivo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_ParaFacturar", SqlDbType.Bit));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            cmd.Parameters["@K_Ejecutivo"].Value = K_Ejecutivo;
            cmd.Parameters["@B_ParaFacturar"].Value = B_ParaFacturar;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public DataTable Sk_pedidos_detalle(Int32 K_Pedido)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_pedidos_detalle";

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
     /*   public DataTable Sk_Articulos_Pedidos(Int32 K_Articulo, Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo, Int32 K_Cliente , Int32 K_Paciente)
        {
                SqlCommand cmd = ConnectionClass.GetCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sk_Precios_Articulos_Actual";
                DataTable dt = new DataTable();
                cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
                cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
                cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
                cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
                cmd.Parameters["@SKU"].Value = SKU;
                cmd.Parameters["@D_Articulo"].Value = D_Articulo;
                dt = ConnectionClass.GetTable(ref cmd);
                return dt;
        }*/
        public DataTable Sk_Pedidos_Obtiene(Int32 K_Cotizacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pedidos_Obtiene";
            DataTable dt = new DataTable();

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));

            cmd.Parameters["@K_Pedido"].Value = K_Cotizacion;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            dt = ConnectionClass.GetTable(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return dt;
        }
        public int Up_Pedidos(ref Int32 K_Pedido, Int32 K_Oficina, Int32 K_Almacen, Int32 K_Estatus_Pedido, Int32 K_Cotizacion, Int32 K_Paciente, Int32 K_Cliente, Int32 K_Domicilio_Entrega, decimal Descuento, 
                             decimal Subtotal, decimal Tasa_IVA, decimal Total_IVA, decimal Total_Pedido, Int32 K_Tipo_Moneda, decimal Tipo_Cambio, Int32 K_Usuario_Captura, string Observaciones,
                             DataTable PedidosDetalle, Int16 TiempoEntrega, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Pedidos";

            IDataParameter p_K_Pedido = new SqlParameter("@K_Pedido", SqlDbType.Int);
            p_K_Pedido.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pedido);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Domicilio_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 400));
            cmd.Parameters.Add(new SqlParameter("@PedidosDetalle", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@TiempoEntrega", SqlDbType.SmallInt));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Domicilio_Entrega"].Value = K_Domicilio_Entrega;
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Pedido"].Value = Total_Pedido;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@PedidosDetalle"].Value = PedidosDetalle;
            cmd.Parameters["@TiempoEntrega"].Value = TiempoEntrega;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Pedido = (Int32)p_K_Pedido.Value;
            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public DataTable Sk_Articulos_Pedidos(Int32 K_Articulo,Int32 K_Familia_Articulo, Int32 K_Laboratorio,
                                              Int32 K_Sustancia_Activa, String SKU,  String D_Articulo,Int32 K_Paciente,Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_Pedidos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));

            if (K_Articulo == 0)
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            if (K_Familia_Articulo == 0)
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            if (K_Laboratorio == 0)
                cmd.Parameters["@K_Laboratorio"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            if (K_Sustancia_Activa == 0)
                cmd.Parameters["@K_Sustancia_Activa"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            if (SKU == string.Empty)
                cmd.Parameters["@SKU"].Value = DBNull.Value;
            else
                cmd.Parameters["@SKU"].Value = SKU;
            if (D_Articulo == string.Empty)
                cmd.Parameters["@D_Articulo"].Value = DBNull.Value;
            else
                cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            cmd.Parameters["@D_Articulo"].Value = D_Articulo;

            if (K_Paciente == 0)
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            if (K_Cliente == 0)
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

  

        public DataTable Sk_ReporteCotizacion(
           Int32 K_Cotizacion
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cotizacion_Detalle ";
            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Cotizacion(
        Int32 K_Cotizacion
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cotizacion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Cotizacion(
       )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cotizacion";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Cotizacion_Detalle(
       Int32 K_Cotizacion
       )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cotizacion_Detalle";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

    
        public DataTable Sk_Consulta_Paciente(
           Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Consulta_Paciente";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Up_Paqueteria_Pedido(
        Int32 K_Pedido,
        Int32 K_Empresa_Entrega,
        String No_Guia,
        ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Paqueteria_Pedido";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Guia", SqlDbType.VarChar, 50));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            cmd.Parameters["@No_Guia"].Value = No_Guia;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Cancelacion_Pedidos(
          Int32 K_Pedido,
          String CanceladoNota,
          Int32 K_Usuario_Cancelo,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cancelacion_Pedidos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@CanceladoNota", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Cancelo", SqlDbType.Int));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@CanceladoNota"].Value = CanceladoNota;
            cmd.Parameters["@K_Usuario_Cancelo"].Value = K_Usuario_Cancelo;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pedidos_Consulta(
           Int32 K_Pedido
         )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pedidos_Consulta";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Gp_RepComisionesAsesor(Int32 K_Asesor,DateTime F_Inicial,DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepComisionesAsesor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //        public int In_Registro_Factura(
        //           ref Int32 K_Factura,
        //           Int32 K_Oficina,
        //           Int32 K_Tipo_Venta,
        //           DateTime F_Entrega,
        //           Int32 K_Tipo_Moneda,
        //           decimal Tipo_Cambio,
        //           Int32 K_Cliente,
        //           Int32 K_Cliente_Domicilio_Fiscal,
        //           Int32 K_Medico,
        //           decimal Porcentaje_Descuento,
        //           decimal Descuento,
        //           decimal Subtotal,
        //           decimal Total_IVA,
        //           decimal Total_Factura,
        //           Int32 K_Usuario_Captura,
        //           decimal Coaseguro,
        //           decimal PorcentajeCoaseguro,
        //           string Observaciones,
        //           string PC_Name,
        //           bool B_Remisionado,
        //           bool B_SurtidoCompleto,
        //           Int32 K_Almacen,
        //           Int32 K_Paciente,
        //           Int32 K_Paciente_Direccion,
        //           DataTable FacturaDetalle,
        //           ref string Mensaje
        //)
        //        {
        //            SqlCommand cmd = ConnectionClass.GetCommand();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "In_Registro_Factura";

        //            IDataParameter p_K_Factura = new SqlParameter("@K_Factura", SqlDbType.SmallInt);
        //            p_K_Factura.Direction = ParameterDirection.InputOutput;
        //            cmd.Parameters.Add(p_K_Factura);

        //            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
        //            p_Mensaje.Direction = ParameterDirection.InputOutput;
        //            cmd.Parameters.Add(p_Mensaje);

        //            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
        //            p_RetValue.Direction = ParameterDirection.ReturnValue;
        //            cmd.Parameters.Add(p_RetValue);

        //            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));
        //            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@Total_Factura", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@Coaseguro", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@PorcentajeCoaseguro", SqlDbType.Money));
        //            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 400));
        //            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
        //            cmd.Parameters.Add(new SqlParameter("@B_Remisionado", SqlDbType.Bit));
        //            cmd.Parameters.Add(new SqlParameter("@B_SurtidoCompleto", SqlDbType.Bit));
        //            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
        //            cmd.Parameters.Add(new SqlParameter("@FacturaDetalle", SqlDbType.Structured));

        //            cmd.Parameters["@K_Factura"].Value = K_Factura;
        //            cmd.Parameters["@K_Oficina"].Value = K_Oficina;

        //            cmd.Parameters["@F_Entrega"].Value = F_Entrega;
        //            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
        //            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
        //            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
        //            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
        //            cmd.Parameters["@K_Medico"].Value = K_Medico;
        //            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
        //            cmd.Parameters["@Descuento"].Value = Descuento;
        //            cmd.Parameters["@Subtotal"].Value = Subtotal;
        //            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
        //            cmd.Parameters["@Total_Factura"].Value = Total_Factura;
        //            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
        //            cmd.Parameters["@Coaseguro"].Value = K_Usuario_Captura;
        //            cmd.Parameters["@PorcentajeCoaseguro"].Value = K_Usuario_Captura;
        //            cmd.Parameters["@Observaciones"].Value = Observaciones;
        //            cmd.Parameters["@PC_Name"].Value = PC_Name;
        //            cmd.Parameters["@B_Remisionado"].Value = B_Remisionado;
        //            cmd.Parameters["@B_SurtidoCompleto"].Value = B_SurtidoCompleto;
        //            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
        //            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
        //            cmd.Parameters["@K_Paciente_Direccion"].Value = K_Paciente_Direccion;
        //            cmd.Parameters["@FacturaDetalle"].Value = FacturaDetalle;
        //            cmd.Parameters["@Mensaje"].Value = Mensaje;

        //            int res;
        //            res = ConnectionClass.ExecuteNonQuery(ref cmd);

        //            K_Factura = Convert.ToInt32(p_K_Factura.Value);
        //            Mensaje = (string)p_Mensaje.Value;

        //            return res;
        //        }

        public int In_Registro_FacturaCoaseguro(ref Int32 K_Factura, Int32 K_Oficina, Int32 K_Cliente, Int32 K_Cliente_Domicilio_Fiscal,
           decimal Porcentaje_Descuento, decimal Descuento, decimal Subtotal, decimal Total_IVA, decimal Total_Factura, 
           Int32 K_Usuario_Captura, string Observaciones, string PC_Name, Int32 K_Almacen, Int32 K_Paciente, Int32 K_Paciente_Direccion, 
           Int32 K_Pedido, decimal Coaseguro, decimal PorcentajeCoaseguro,Int32 K_Tipo_Venta,Int32 K_Canal_Distribucion_Cliente,DateTime F_Entrega, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Registro_FacturaCoaseguro";

            IDataParameter p_K_Factura = new SqlParameter("@K_Factura", SqlDbType.Int);
            p_K_Factura.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Factura);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Factura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 400));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@PorcentajeCoaseguro", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;  
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Factura"].Value = Total_Factura;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Paciente_Direccion"].Value = 2;
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@Coaseguro"].Value = K_Usuario_Captura;
            cmd.Parameters["@PorcentajeCoaseguro"].Value = K_Usuario_Captura;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@F_Entrega"].Value =F_Entrega;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Factura = Convert.ToInt32(p_K_Factura.Value);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Factura_Farmacia(ref Int32 K_Factura, Int32 K_Transaccion, Int32 K_Oficina, Int32 K_Almacen, Int32 K_Cliente, Int32 K_Cliente_Domicilio_Fiscal,
        decimal Descuento, decimal Subtotal, decimal Total_IVA, decimal Total_Factura, Int32 K_Usuario_Captura, string Observaciones, string PC_Name, bool B_Pagada,
        bool B_Credito, Int32 K_Canal_Distribucion_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Factura_Farmacia";

            IDataParameter p_K_Factura = new SqlParameter("@K_Factura", SqlDbType.SmallInt);
            p_K_Factura.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Factura);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Factura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 400));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Pagada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Credito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Factura"].Value = Total_Factura;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@B_Pagada"].Value = B_Pagada;
            cmd.Parameters["@B_Credito"].Value = B_Credito;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Factura = Convert.ToInt32(p_K_Factura.Value);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Datos_Transaccion(Int32 K_Transaccion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Datos_Transaccion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));
            cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Gp_Trae_DatosFactura(Int32 K_Oficina, Int32 K_Factura,string D_Serie)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Trae_DatosFactura";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar,30));
            cmd.Parameters["@K_Oficina_Factura"].Value = K_Oficina;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@D_Serie"].Value = D_Serie;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Gp_Cancela_Factura(Int32 K_Factura,string D_Serie, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Cancela_Factura";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Cancelo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar,30));

            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Usuario_Cancelo"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@D_Serie"].Value = D_Serie;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_ConsultaPrecierresPendientes()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ConsultaPrecierresPendientes";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Datos_Ticket(Int32 K_Transaccion,Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Datos_Ticket";
            DataTable dt = new DataTable();

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;

            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }


            dt = ConnectionClass.GetTable(ref cmd);

            try
            {
                Mensaje = (string)p_Mensaje.Value;
            }
            catch (Exception)
            {

                Mensaje = "";
            }
      
            return dt;
        }
        public DataTable Gp_ConsultaPrecierres()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ConsultaPrecierres";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_VentaArticulos (Int32 K_Transaccion, Int32 K_Almacen, DateTime F_Transaccion_Inicial, DateTime F_Transaccion_Final,
            bool B_Cancelada,bool B_Facturada,bool B_Entrega_Domicilio,bool B_Descuento_Empleado,bool B_Credito)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_VentaArticulos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Transaccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Transaccion_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Transaccion_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Facturada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Entrega_Domicilio", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Descuento_Empleado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Credito", SqlDbType.Bit));

            if (K_Transaccion == 0)
            {
                cmd.Parameters["@K_Transaccion"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Transaccion"].Value = K_Transaccion;
            }
            if (K_Almacen == 0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }
            cmd.Parameters["@F_Transaccion_Inicial"].Value = F_Transaccion_Inicial;
            cmd.Parameters["@F_Transaccion_Final"].Value = F_Transaccion_Final;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@B_Facturada"].Value = B_Facturada;
            cmd.Parameters["@B_Entrega_Domicilio"].Value = B_Entrega_Domicilio;
            cmd.Parameters["@B_Descuento_Empleado"].Value = B_Descuento_Empleado;
            cmd.Parameters["@B_Credito"].Value = B_Credito;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
    }
}