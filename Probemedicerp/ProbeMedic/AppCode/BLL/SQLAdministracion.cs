﻿using ProbeMedic.AppCode.DCC;
using ProbeMedic.Entities.Recepcion;
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
    class SQLAdministracion
    {
        public int In_Presupuestos_Egresos(Int32 K_Oficina, Int32 K_Departamento,
         Int32 K_Tipo_MovCchica, Int32 K_Proyecto, Int32 Year, Int32 Mes, Int32 K_Usuario,
         DateTime F_Cambio, decimal Monto, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Presupuestos_Egresos";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proyecto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Cambio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Money));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@Mes"].Value = Mes;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@F_Cambio"].Value = F_Cambio;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public DataTable Sk_Presupuestos_Egresos(Int32 K_Oficina, Int32 K_Departamento, Int32 K_Tipo_MovCchica,
            Int32 K_Proyecto, Int32 Year, Int32 Mes)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Presupuestos_Egresos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proyecto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));

            if (K_Oficina == 0)
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Departamento == 0)
                cmd.Parameters["@K_Departamento"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            if (K_Tipo_MovCchica == 0)
                cmd.Parameters["@K_Tipo_MovCchica"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            if (K_Proyecto == 0)
                cmd.Parameters["@K_Proyecto"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            if (Year == 0)
                cmd.Parameters["@Year"].Value = DBNull.Value;
            cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@Mes"].Value = DBNull.Value;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Up_Presupuestos_Egresos(Int32 K_Oficina, Int32 K_Departamento,
         Int32 K_Tipo_MovCchica, Int32 K_Proyecto, Int32 Year, Int32 Mes, Int32 K_Usuario,
         DateTime F_Cambio, decimal Monto, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Presupuestos_Egresos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proyecto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Cambio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Money));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@Mes"].Value = Mes;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@F_Cambio"].Value = F_Cambio;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public DataTable Sk_Historico_Presupuesto_Egresos(Int32 K_Oficina, Int32 K_Departamento, Int32 K_Tipo_MovCchica,
        Int32 K_Proyecto, Int32 Year, DateTime F_Inicial, DateTime F_Final)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Historico_Presupuesto_Egresos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_MovCchica", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proyecto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            if (K_Oficina == 0)
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Departamento == 0)
                cmd.Parameters["@K_Departamento"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            if (K_Tipo_MovCchica == 0)
                cmd.Parameters["@K_Tipo_MovCchica"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_MovCchica"].Value = K_Tipo_MovCchica;
            if (K_Proyecto == 0)
                cmd.Parameters["@K_Proyecto"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            if (Year == 0)
                cmd.Parameters["@Year"].Value = DBNull.Value;
            else
                cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Presupuestos_Ingresos(Int32 K_Oficina, Int32 K_Tipo_Venta,
         Int32 K_Familia_Articulo, Int32 K_Cliente, Int32 Year, Int32 Mes, Int32 K_Usuario,
         DateTime F_Cambio, decimal Monto, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Presupuestos_Ingresos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Cambio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Money));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@Mes"].Value = Mes;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@F_Cambio"].Value = F_Cambio;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public DataTable Sk_Presupuestos_Ingresos(Int32 K_Oficina, Int32 K_Tipo_Venta, Int32 K_Familia_Articulo,
            Int32 K_Cliente, Int32 Year, Int32 Mes)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Presupuestos_Ingresos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));

            if (K_Oficina == 0)
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Tipo_Venta == 0)
                cmd.Parameters["@K_Tipo_Venta"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            if (K_Familia_Articulo == 0)
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            if (K_Cliente == 0)
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            if (Year == 0)
                cmd.Parameters["@Year"].Value = DBNull.Value;
            cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@Mes"].Value = DBNull.Value;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Up_Presupuestos_Ingresos(Int32 K_Oficina, Int32 K_Tipo_Venta,
         Int32 K_Familia_Articulo, Int32 K_Cliente, Int32 Year, Int32 Mes, Int32 K_Usuario,
         DateTime F_Cambio, decimal Monto, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Presupuestos_Ingresos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Cambio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Money));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@Mes"].Value = Mes;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@F_Cambio"].Value = F_Cambio;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public DataTable Sk_Historico_Presupuesto_Ingresos(Int32 K_Oficina, Int32 K_Tipo_Venta, Int32 K_Familia_Articulo,
        Int32 K_Cliente, Int32 Year, DateTime F_Inicial, DateTime F_Final)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Historico_Presupuesto_Ingresos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            if (K_Oficina == 0)
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Tipo_Venta == 0)
                cmd.Parameters["@K_Tipo_Venta"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            if (K_Cliente == 0)
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            if (K_Familia_Articulo == 0)
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            if (Year == 0)
                cmd.Parameters["@Year"].Value = DBNull.Value;
            else
                cmd.Parameters["@Year"].Value = Year;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Clientes_Muestra(Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clientes_Muestra";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            if (K_Empresa == 0)
                cmd.Parameters["@K_Empresa"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Clientes_Credito(Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clientes_Credito";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            if (K_Cliente == 0)
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;

            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Detalle_Factura(Int32 K_Factura)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Detalle_Factura";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));

            if (K_Factura == 0)
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Factura"].Value = K_Factura;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Seguimiento_Facturas(ref Int32 K_Seguimiento_Factura, Int32 K_Usuario,
         Int32 K_Cliente, Int32 K_Factura, String Resultado, DateTime F_Registro, DateTime F_Proximo_Contacto,
         String PC_Name, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Seguimiento_Facturas";

            IDataParameter p_K_Seguimiento_Factura = new SqlParameter("@K_Seguimiento_Factura", SqlDbType.Int);
            p_K_Seguimiento_Factura.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Seguimiento_Factura);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Resultado", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@F_Registro", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Proximo_Contacto", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));

            cmd.Parameters["@K_Seguimiento_Factura"].Value = K_Seguimiento_Factura;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@Resultado"].Value = Resultado;
            cmd.Parameters["@F_Registro"].Value = F_Registro;
            cmd.Parameters["@F_Proximo_Contacto"].Value = F_Proximo_Contacto;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Seguimiento_Factura = (Int32)p_K_Seguimiento_Factura.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;




        }

        public DataTable Gp_Contactos_Correos(Int32 K_Cliente, Int32 K_Canal_Distribucion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Contactos_Correos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));

            if (K_Cliente == 0)
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;

            if (K_Canal_Distribucion == 0)
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Seguimiento_Facturas(Int32 K_Factura)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Seguimiento_Facturas";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));

            if (K_Factura == 0)
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Factura"].Value = K_Factura;


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Pagos_CXC(Int32 K_Factura)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pagos_CXC";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));

            if (K_Factura == 0)
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Factura"].Value = K_Factura;


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Nota_Cargo_Interna_Factura(ref Int32 K_Nota_Cargo_Interna, Int32 K_Oficina,
        Int32 K_Almacen, Int32 K_Cliente, Int32 K_Usuario_Genero, Int32 K_Usuario_Autoriza,
        DateTime F_Generacion, decimal Sub_Total, decimal Porcentaje_IVA, decimal IVA,
        decimal Porcentaje_Retencion, decimal Retencion, decimal Monto_Total,
        Int32 K_Motivo_Nota_Cargo, Int32 K_Cuenta_Cliente,  string Observaciones, Int32 K_Factura, ref string Mensaje
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Nota_Cargo_Interna_Factura";

            IDataParameter p_K_Nota_Cargo_Interna = new SqlParameter("@K_Nota_Cargo_Interna", SqlDbType.Int);
            p_K_Nota_Cargo_Interna.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nota_Cargo_Interna);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Autoriza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Generacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Sub_Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_IVA", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Retencion", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@Retencion", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Nota_Cargo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));

            cmd.Parameters["@K_Nota_Cargo_Interna"].Value = K_Nota_Cargo_Interna;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Usuario_Genero"].Value = K_Usuario_Genero;
            cmd.Parameters["@K_Usuario_Autoriza"].Value = K_Usuario_Autoriza;
            if (K_Usuario_Autoriza == 0)
            {
                cmd.Parameters["@K_Usuario_Autoriza"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Usuario_Autoriza"].Value = K_Usuario_Autoriza;
            }

            cmd.Parameters["@F_Generacion"].Value = F_Generacion;
            cmd.Parameters["@Sub_Total"].Value = Sub_Total;
            cmd.Parameters["@Porcentaje_IVA"].Value = Porcentaje_IVA;
            cmd.Parameters["@IVA"].Value = IVA;
            cmd.Parameters["@Porcentaje_Retencion"].Value = Porcentaje_Retencion;
            cmd.Parameters["@Retencion"].Value = Retencion;
            cmd.Parameters["@Monto_Total"].Value = Monto_Total;
            cmd.Parameters["@K_Motivo_Nota_Cargo"].Value = K_Motivo_Nota_Cargo;
            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nota_Cargo_Interna = (Int32)p_K_Nota_Cargo_Interna.Value;
            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public int Dl_Nota_Cargo_Interna_Factura(Int16 K_Nota_Cargo_Interna, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Nota_Cargo_Interna_Factura";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Nota_Cargo_Interna", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Nota_Cargo_Interna"].Value = K_Nota_Cargo_Interna;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

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
        public DataTable Sk_Nota_Cargo_Interna_Factura()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Nota_Cargo_Interna_Factura";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int In_Nota_Credito_Interna_Factura(ref Int32 K_Nota_Credito_Interna, Int32 K_Usuario_Genero, Int32 K_Oficina,
           Int32 K_Almacen, Int32 K_Cliente, DateTime F_Generacion, decimal Sub_Total, decimal Porcentaje_IVA, decimal IVA,
           decimal Porcentaje_Retencion, decimal Retencion, decimal Monto_Total, Int32 K_Motivo_Nota_Credito,
           Int32 K_Tipo_Fiscal, Int32 K_Cuenta_Cliente, string Observaciones, Int32 K_Factura, Int32 K_Usuario_Genera, ref string Mensaje
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Nota_Credito_Interna_Factura";

            IDataParameter p_K_Nota_Credito_Interna = new SqlParameter("@K_Nota_Credito_Interna", SqlDbType.Int);
            p_K_Nota_Credito_Interna.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nota_Credito_Interna);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Generacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Sub_Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_IVA", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Retencion", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@Retencion", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Nota_Credito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Genera", SqlDbType.Int));

            cmd.Parameters["@K_Nota_Credito_Interna"].Value = K_Nota_Credito_Interna;
            cmd.Parameters["@K_Usuario_Genero"].Value = K_Usuario_Genero;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@F_Generacion"].Value = F_Generacion;
            cmd.Parameters["@Sub_Total"].Value = Sub_Total;
            cmd.Parameters["@Porcentaje_IVA"].Value = Porcentaje_IVA;
            cmd.Parameters["@IVA"].Value = IVA;
            cmd.Parameters["@Porcentaje_Retencion"].Value = Porcentaje_Retencion;
            cmd.Parameters["@Retencion"].Value = Retencion;
            cmd.Parameters["@Monto_Total"].Value = Monto_Total;
            cmd.Parameters["@K_Motivo_Nota_Credito"].Value = K_Motivo_Nota_Credito;
            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Usuario_Genera"].Value = K_Usuario_Genera;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nota_Credito_Interna = (Int32)p_K_Nota_Credito_Interna.Value;
            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public DataTable Sk_Nota_Credito_Interna_Factura()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Nota_Credito_Interna_Factura";

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Anticipo_Cliente(ref Int32 K_Anticipo_Cliente, Int32 K_Oficina,
           Int32 K_Almacen, Int32 K_Cliente, Int32 K_Usuario_Genero, Int32 K_Usuario_Autoriza,
           DateTime F_Generacion, decimal Monto_Total, Int32 K_Motivo_Anticipo_Cliente,
           Int32 K_Cuenta_Cliente, Int32 K_Cuenta_Empresa, string Observaciones, ref string Mensaje
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Anticipo_Cliente";

            IDataParameter p_K_Anticipo_Cliente = new SqlParameter("@K_Anticipo_Cliente", SqlDbType.Int);
            p_K_Anticipo_Cliente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Anticipo_Cliente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Autoriza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Generacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Monto_Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Anticipo_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));

            cmd.Parameters["@K_Anticipo_Cliente"].Value = K_Anticipo_Cliente;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Usuario_Genero"].Value = K_Usuario_Genero;
            if (K_Usuario_Autoriza == 0)
            {
                cmd.Parameters["@K_Usuario_Autoriza"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Usuario_Autoriza"].Value = K_Usuario_Autoriza;
            }

            cmd.Parameters["@F_Generacion"].Value = F_Generacion;
            cmd.Parameters["@Monto_Total"].Value = Monto_Total;
            cmd.Parameters["@K_Motivo_Anticipo_Cliente"].Value = K_Motivo_Anticipo_Cliente;
            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@K_Cuenta_Empresa"].Value = K_Cuenta_Empresa;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Anticipo_Cliente = (Int32)p_K_Anticipo_Cliente.Value;
            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public int Dl_Anticipo_Clientes(Int16 K_Anticipo_Cliente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Anticipo_Clientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Anticipo_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Anticipo_Cliente"].Value = K_Anticipo_Cliente;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

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
        public DataTable Sk_Anticipo_Clientes()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Anticipo_Clientes";

            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Cheques(ref Int32 K_Cheque, Int32 K_Oficina, Int32 K_Estado_Cheque, Int32 K_Cliente,
            Int32 K_Banco,decimal Numero_Cuenta, decimal Numero_Cheque,decimal Monto,Int32 K_Usuario_Registro,
            bool B_Posfechado,DateTime F_Posfechado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cheques";

            IDataParameter p_K_Cheque = new SqlParameter("@K_Cheque", SqlDbType.Int);
            p_K_Cheque.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cheque);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado_Cheque", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cheque", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Registro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Posfechado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Posfechado", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Cheque"].Value = K_Cheque;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Estado_Cheque"].Value = K_Estado_Cheque;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Numero_Cheque"].Value = Numero_Cheque;
            cmd.Parameters["@Monto"].Value = Monto;
            cmd.Parameters["@K_Usuario_Registro"].Value = K_Usuario_Registro;
            cmd.Parameters["@B_Posfechado"].Value = B_Posfechado;
            cmd.Parameters["@F_Posfechado"].Value = F_Posfechado;  
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Cheques()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cheques";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Cheques(bool B_Aplicado, bool B_Aprobado, bool B_Posfechado, bool B_Devuelto)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cheques";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Aplicado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aprobado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Posfechado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Devuelto", SqlDbType.Bit));
            cmd.Parameters["@B_Aplicado"].Value = B_Aplicado;
            cmd.Parameters["@B_Aprobado"].Value = B_Aprobado;
            cmd.Parameters["@B_Posfechado"].Value = B_Posfechado;
            cmd.Parameters["@B_Devuelto"].Value = B_Devuelto;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Up_Cheques(Int32 K_Cheque, bool B_Devuleto, bool B_Aplicado, Int32 K_Usuario_Aplica, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cheques";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cheque", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Devuleto", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplicado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplica", SqlDbType.Int));

            cmd.Parameters["@K_Cheque"].Value = K_Cheque;
            cmd.Parameters["@B_Devuleto"].Value = B_Devuleto;
            cmd.Parameters["@B_Aplicado"].Value = B_Aplicado;
            cmd.Parameters["@K_Usuario_Aplica"].Value = K_Usuario_Aplica;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Seguimiento_Cheque(ref Int32 K_Seguimiento_Cheque, Int32 K_Cheque, Int32 K_Tipo_Contacto,
         string Contacto,string Observaciones,string Observaciones2,Int32 K_Usuario_Aprobo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Seguimiento_Cheque";

            IDataParameter p_K_Seguimiento_Cheque = new SqlParameter("@K_Seguimiento_Cheque", SqlDbType.Int);
            p_K_Seguimiento_Cheque.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Seguimiento_Cheque);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cheque", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Contacto", SqlDbType.Int)); 
            cmd.Parameters.Add(new SqlParameter("@Contacto", SqlDbType.VarChar,80));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@Observaciones2", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aprobo", SqlDbType.Int));

            cmd.Parameters["@K_Seguimiento_Cheque"].Value = K_Seguimiento_Cheque;
            cmd.Parameters["@K_Cheque"].Value = K_Cheque;       
            cmd.Parameters["@K_Tipo_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@Contacto"].Value = Contacto;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@Observaciones2"].Value = Observaciones2;
            cmd.Parameters["@K_Usuario_Aprobo"].Value = K_Usuario_Aprobo;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Seguimiento_Cheque(Int32 K_Cheque)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Seguimiento_Cheque";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cheque", SqlDbType.Int));
            cmd.Parameters["@K_Cheque"].Value = K_Cheque;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Devoluciones_Cliente()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Devoluciones_Cliente";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int In_Devoluciones_Cliente(ref Int32 K_Devolucion_Cliente, Int32 K_Cliente,Int32 K_Factura,
            Int32 K_Estatus_Devolucion, Int32 K_Oficina, Int32 K_Almacen, DateTime F_Devolucion, decimal SubTotal,
            decimal IVA, decimal Monto_Total, string PC_Name, Int32 K_Usuario_Genero, string Observaciones, 
            Int32 K_Cuenta_Cliente, Int32 K_Usuario_Bitacora, DataTable Detalle_Articulos, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Devoluciones_Cliente";

            IDataParameter p_K_Devolucion_Cliente = new SqlParameter("@K_Devolucion_Cliente", SqlDbType.Int);
            p_K_Devolucion_Cliente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Devolucion_Cliente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Devolucion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@SubTotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Detalle_Articulos", SqlDbType.Structured));

            cmd.Parameters["@K_Devolucion_Cliente"].Value = K_Devolucion_Cliente;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Estatus_Devolucion"].Value = K_Estatus_Devolucion;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@F_Devolucion"].Value = F_Devolucion;
            cmd.Parameters["@SubTotal"].Value = SubTotal;
            cmd.Parameters["@IVA"].Value = IVA;
            cmd.Parameters["@Monto_Total"].Value = Monto_Total;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Usuario_Genero"].Value = K_Usuario_Genero;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@Detalle_Articulos"].Value = Detalle_Articulos;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Gp_Valida_ArticuloInv(Int32 K_Articulo,Int32 K_Factura,string No_Lote)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Valida_ArticuloInv";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Lote", SqlDbType.VarChar,40));
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@No_Lote"].Value = No_Lote;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Factura(Int32 K_Factura)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Factura";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable GP_Xml_Factura(Int32 No_Folio,string Serie)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Xml_Factura";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@No_Folio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar,10));
            cmd.Parameters["@No_Folio"].Value = No_Folio;
            cmd.Parameters["@Serie"].Value = Serie;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        #region REPORTES GENERALES
        public DataTable Sk_Rep_Nota_Credito_Interna(Int32 K_Factura,Int32 K_Almacen,Int32 K_Cliente,
            DateTime F_Inicial, DateTime F_Final, DataTable Clientes_Type,DataTable Almacenes_Type)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Rep_Nota_Credito_Interna";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Clientes_Type", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Almacenes_Type", SqlDbType.Structured));

            if(K_Factura == 0)
            {
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Factura"].Value = K_Factura;
            }
            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }
            if(K_Cliente==0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }

            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@Clientes_Type"].Value = Clientes_Type;
            cmd.Parameters["@Almacenes_Type"].Value = Almacenes_Type;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Reporte_AnaliticoFacturas(string PC_Name, Int32 K_Usuario, Int32 K_Factura, DataTable Almacenes_Type, DataTable Clientes_Type,
            Int32 K_Canal_Distribucion_Cliente, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Reporte_AnaliticoFacturas";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar,50));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            if (K_Factura == 0)
            {
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Factura"].Value = K_Factura;
            }

            cmd.Parameters["@Almacenes"].Value = Almacenes_Type;
            cmd.Parameters["@Clientes"].Value = Clientes_Type;
      
            if (K_Canal_Distribucion_Cliente == 0)
            {
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            }

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Reporte_AnaliticoArticulos(Int32 K_Factura, Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final,
            DataTable Almacenes_Type, DataTable Clientes_Type, Int32 K_Canal_Distribucion_Cliente)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Reporte_AnaliticoArticulos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
      
            cmd.Parameters["@PC_Name"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            if (K_Factura == 0)
            {
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Factura"].Value = K_Factura;
            }
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@Almacenes"].Value = Almacenes_Type;
            cmd.Parameters["@Clientes"].Value = Clientes_Type;

            if (K_Canal_Distribucion_Cliente == 0)
            {
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            }

 
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Rep_CobranzaAnalitico(Int32 K_Usuario,Int32 K_Factura,Int32 K_Empresa,DateTime F_Inicial,
            DateTime F_Final, DataTable Almacenes, DataTable Clientes,Int32 K_Canal_Distribucion_Cliente, Int32 K_Tipo_Pago)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Rep_CobranzaAnalitico";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Pago", SqlDbType.Int));

            cmd.Parameters["@PC_Name"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            if (K_Factura == 0)
            {
                cmd.Parameters["@K_Factura"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Factura"].Value = K_Factura;
            }
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@Almacenes"].Value = Almacenes;
            cmd.Parameters["@Clientes"].Value = Clientes;

            if (K_Canal_Distribucion_Cliente == 0)
            {
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            }

            if (K_Tipo_Pago == 0)
            {
                cmd.Parameters["@K_Tipo_Pago"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Pago"].Value = K_Tipo_Pago;
            }
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_RepCuenta_Tipo_Pago(Int32 K_Empresa,DateTime F_Inicial,DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepCuenta_Tipo_Pago";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_RepCuentaMeses(Int32 K_Empresa,Int32 Anio)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepCuentaMeses";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Anio", SqlDbType.Int));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@Anio"].Value = Anio;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Rep_FacturasAnalitico(Int32 K_Empresa, DateTime F_Inicial,DateTime F_Final,DataTable Clientes,bool B_Pagada)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Rep_FacturasAnalitico";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@B_Pagada", SqlDbType.Bit));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@Clientes"].Value = Clientes;
            cmd.Parameters["@B_Pagada"].Value = B_Pagada;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Gp_RepFacturasDiasPagos(string PC_Name,Int32 K_Usuario,Int32 K_Factura,Int32 K_Empresa, DateTime F_Inicial, DateTime F_Final,
           DataTable Almacenes, DataTable Clientes, Int32 K_Canal_Distribucion_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepFacturasDiasPagos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar,50));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));

            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Factura"].Value = K_Factura;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@Almacenes"].Value = Almacenes;
            cmd.Parameters["@Clientes"].Value = Clientes;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Gp_Reporte_VentasGlobales (string PC_Name, Int32 K_Usuario, bool B_Farmacia,bool B_VentaPrivada,bool B_Aseguradora, bool B_Coaseguro, DateTime F_Incial,
            DateTime F_Final,DataTable Clientes)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Reporte_VentasGlobales";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Farmacia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_VentaPrivada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aseguradora", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Coaseguro", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));

            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@B_Farmacia"].Value = B_Farmacia;
            cmd.Parameters["@B_VentaPrivada"].Value = B_VentaPrivada;
            cmd.Parameters["@B_Aseguradora"].Value = B_Aseguradora;
            cmd.Parameters["@B_Coaseguro"].Value = B_Coaseguro;
            cmd.Parameters["@F_Inicial"].Value = F_Incial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            if(Clientes.Rows.Count>0)
                cmd.Parameters["@Clientes"].Value = Clientes;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Gp_Consulta_Utilidad(DateTime F_Incial,DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Consulta_Utilidad";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@F_Inicial"].Value = F_Incial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Gp_RepRemisionesPorFacturar()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepRemisionesPorFacturar";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Rpt_PromedioPonderado()
        {
         
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_PromedioPonderado";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Rpt_ReporteCosteo(DateTime F_Incial, DateTime F_Final)
        {
            //Gp_Consulta_Utilidad
            //cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            //cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            //cmd.Parameters["@F_Inicial"].Value = F_Incial;
            //cmd.Parameters["@F_Final"].Value = F_Final;

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ReporteCosteo";
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@F_Inicial"].Value = F_Incial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        #endregion

        public DataTable Gp_Muestra_FacturasTimbradas(Int32 K_Cliente_Paga,DateTime F_Inicial,DateTime F_Final,Int32 K_Tipo_Venta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Muestra_FacturasTimbradas";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Paga", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.Int));

            cmd.Parameters["@K_Cliente_Paga"].Value = K_Cliente_Paga;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public string sNombrePacienteFactura_select(int factura, string serie)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sNombrePacienteFactura_select";
            cmd.Connection = ConnectionClass.GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.Add(new SqlParameter("@factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.NVarChar));
            cmd.Parameters["@factura"].Value = factura;
            cmd.Parameters["@Serie"].Value = serie;



            string nombre = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
            return nombre;
        }
        public string sObservacionesFactura_select(int factura, string serie)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sObservacionesFactura_select";
            cmd.Connection = ConnectionClass.GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.Add(new SqlParameter("@factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.NVarChar));
            cmd.Parameters["@factura"].Value = factura;
            cmd.Parameters["@Serie"].Value = serie;

            string observaciones = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
            return observaciones;
        }

        public int sClienteFactura_select(int factura, string serie)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sClienteFactura_select";
            cmd.Connection = ConnectionClass.GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.Add(new SqlParameter("@factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.NVarChar));
            cmd.Parameters["@factura"].Value = factura;
            cmd.Parameters["@Serie"].Value = serie;

            int cliente = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return cliente;
        }

        public string sFacturaLote_select(int factura, string serie)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sInformacion_xml";
            cmd.Connection = ConnectionClass.GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.NVarChar));
            cmd.Parameters["@K_Factura"].Value = factura;
            cmd.Parameters["@D_Serie"].Value = serie;

            string lote = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
            return lote;
        }


        public string sDireccionesFactura_select(int cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sDireccionesFactura_select";
            cmd.Connection = ConnectionClass.GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.Int));

            cmd.Parameters["@cliente"].Value = cliente;

            string direccion = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
            return direccion;
        }
        public DataTable Gp_Reporte_VentasNetas(string PC_Name, Int32 K_Usuario, bool B_Farmacia, bool B_VentaPrivada, bool B_Aseguradora, bool B_Coaseguro, DateTime F_Incial,
            DateTime F_Final, DataTable Clientes)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Reporte_VentasNetas";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Farmacia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_VentaPrivada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aseguradora", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Coaseguro", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Clientes", SqlDbType.Structured));

            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@B_Farmacia"].Value = B_Farmacia;
            cmd.Parameters["@B_VentaPrivada"].Value = B_VentaPrivada;
            cmd.Parameters["@B_Aseguradora"].Value = B_Aseguradora;
            cmd.Parameters["@B_Coaseguro"].Value = B_Coaseguro;
            cmd.Parameters["@F_Inicial"].Value = F_Incial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            if (Clientes.Rows.Count > 0)
                cmd.Parameters["@Clientes"].Value = Clientes;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int IN_Registra_FacturaGlobal(string D_Serie,Int32 K_Almacen,Int32 K_Oficina, Int32 K_Usuario_Captura,
            Int32 K_Empresa, Int32 K_Cliente,Int32 K_Domicilio_Cliente, string PC_Name, string Correo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "IN_Registra_FacturaGlobal";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar,100));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Domicilio_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 200));

            cmd.Parameters["@D_Serie"].Value = D_Serie;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Domicilio_Cliente"].Value = K_Domicilio_Cliente;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

    }
}