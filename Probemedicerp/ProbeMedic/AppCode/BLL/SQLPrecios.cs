using ProbeMedic.AppCode.DCC;
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
    class SQLPrecios
    {

        //////////////PROGRAMAS ARTICULOS/////////////////////////
        public DataTable Sk_Programas_Articulos_Precios(Int32 K_Programa, Int32 K_Aseguradora, DateTime F_Inicial, DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos_Precios";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Programas_Articulos_Precios(Int32 K_Programa, Int32 K_Aseguradora)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos_Precios";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Programas_ArticuloS(Int32 K_Programa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Programas_Articulos_Precios_Actual(Int32 K_Programa, Int32 K_Aseguradora)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos_Precios_Actual";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Programas_Articulos_Precios(
            ref Int32 K_Programas_Articulos_Precios,
            Int32 K_Programa,
            Int32 K_Articulo,
            Int32 K_Aseguradora,
            decimal Precio,
            DateTime F_Actualizacion,
            Int32 K_Usuario,
            Int32 K_Usuario_Bitacora,
           ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Programas_Articulos_Precios";

            IDataParameter p_K_Programas_Articulos_Precios = new SqlParameter("@K_Programas_Articulos_Precios", SqlDbType.Int);
            p_K_Programas_Articulos_Precios.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Programas_Articulos_Precios);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Programas_Articulos_Precios"].Value = K_Programas_Articulos_Precios;
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            K_Programas_Articulos_Precios = (Int32)p_K_Programas_Articulos_Precios.Value;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Programas_Articulos_Precios(
           Int32 K_Programas_Articulos_Precios,
           Int32 K_Programa,
           Int32 K_Articulo,
           Int32 K_Aseguradora,
           decimal Precio,
           Int32 K_Usuario,
           ref string Mensaje)
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Programas_Articulos_Precios";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Programas_Articulos_Precios", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Programas_Articulos_Precios"].Value = K_Programas_Articulos_Precios;
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        //////////////////PROGRAMAS PACIENTES///////////////////////////
        public int In_Programas_Pacientes(
        Int32 K_Programa,
        Int32 K_Articulo,
        Int32 K_Aseguradora,
        Int32 K_Paciente,
        Int32 K_Usuario,
        ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Programas_Pacientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Gp_Articulos_Programa_Paciente(Int32 K_Programa, Int32 K_Aseguradora, Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Articulos_Programa_Paciente";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Programas_Articulos_Precios_Actual()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos_Precios_Actual";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        //PRECIOS CLIENTES
        public DataTable Sk_Precio_Articulo_Cliente(Int32 K_Cliente, DateTime F_Inicial, DateTime F_Final)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precio_Articulo_Cliente";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Precio_Articulo_Cliente(
          ref Int32 K_Precio_Articulo_Cliente,
          Int32 K_Articulo,
          Int32 K_Cliente,
          decimal Precio,
          DateTime F_Actualizacion,
          Int32 K_Usuario_Aplico,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Precio_Articulo_Cliente";


            IDataParameter p_K_Precio_Articulo_Cliente = new SqlParameter("@K_Precio_Articulo_Cliente", SqlDbType.Int);
            p_K_Precio_Articulo_Cliente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_Articulo_Cliente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplico", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Articulo_Cliente"].Value = K_Precio_Articulo_Cliente;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@K_Usuario_Aplico"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Precio_Articulo_Cliente(
           Int32 K_Precio_Articulo_Cliente,
           Int32 K_Articulo,
           Int32 K_Cliente,
           decimal Precio,
           DateTime F_Actualizacion,
           Int32 K_Usuario_Aplico,
           ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Precio_Articulo_Cliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Articulo_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplico", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Articulo_Cliente"].Value = K_Precio_Articulo_Cliente;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@K_Usuario_Aplico"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Precios_ArticulosCliente_Actual(Int32 K_Cliente)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_ArticulosCliente_Actual";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //PRECIOS PUBLICOS
        public DataTable Sk_Precios_Articulos(DateTime F_Inicial, DateTime F_Final)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Articulos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Precios_Articulos_Actual(Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Articulos_Actual";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));

            if(K_Familia_Articulo==0)
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            }
            if(K_Laboratorio ==0)
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
        public DataTable Sk_Precios_Articulos_Actual(Int32 K_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Articulos_Actual";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Precios_Articulos(
          ref Int32 K_Precio_Articulo,
          Int32 K_Articulo,
          decimal Precio,
          DateTime F_Actualizacion,
          Int32 K_Usuario_Aplico,
          ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Precios_Articulos";

            IDataParameter p_K_Precio_Articulo = new SqlParameter("@K_Precio_Articulo", SqlDbType.Int);
            p_K_Precio_Articulo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_Articulo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplico", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Articulo"].Value = K_Precio_Articulo;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@K_Usuario_Aplico"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public int Up_Precios_Articulos(
          Int32 K_Precio_Articulo,
          Int32 K_Articulo,
          decimal Precio,
          DateTime F_Actualizacion,
          Int32 K_Usuario_Aplico,
           ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Precios_Articulos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplico", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Articulo"].Value = K_Precio_Articulo;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@K_Usuario_Aplico"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable SK_Empleado_Enfermeria()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Empleado_Enfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters["@K_Oficina"].Value = GlobalVar.K_Oficina;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Up_ServiciosContratados_Empleado(Int32 K_Servicio_Contratado_Enfermeria, Int32 K_Empleado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_ServiciosContratados_Empleado";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Elimina_Empleado(Int32 K_Servicio_Contratado_Enfermeria, Int32 K_Empleado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Elimina_Empleado";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Motivo_Cancelacion_ServiciosEnfermeria()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Cancelacion_ServiciosEnfermeria";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_Cancelacion_ServiciosEnferemeria(Int32 K_Servicio_Contratado_Enfermeria, Int32 K_Motivo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Cancelacion_ServiciosEnferemeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratados_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion_ServiciosEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratados_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosEnfermeria"].Value = K_Motivo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Realiza_ServicioEnfermeria(Int32 K_Servicio_Contratado_Enfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UP_Realiza_ServicioEnfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Enfermeria", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Enfermeria"].Value = K_Servicio_Contratado_Enfermeria;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }




        //////////////////////////////////SERVICIOS CONTRATADOS AMBULANCIAS////////////////////////////
       public DataTable SK_Servicios_Ambulancia(bool B_Realizado, DateTime F_Inicial, DateTime F_Final, Int32 K_Cliente,bool B_Pagado,bool B_Cancelado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Servicios_Ambulancia";
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

        public DataTable SK_Detalle_ArticulosAmbulancia(Int32 K_Servicio_Contratado_Ambulancia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Detalle_ArticulosAmbulancia";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int));
            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable SK_Oficina_AtiendeAmbulancia(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Oficina_AtiendeAmbulancia";
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

        public DataTable GP_Extrae_Precio_Ambulancias(bool B_Local, Int32 K_Cliente, Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia, Int32 K_Precio_Ambulancia)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Extrae_Precio_Ambulancias";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;



        }
 
        public int In_Servicios_ContratadosAmb(ref Int32 K_Servicio_Contratado_Ambulancia,
            Int32 K_Cliente,
            Int32 K_Oficina,
            Int32 K_Pais,
            Int32 K_Estado,
            Int32 K_Ciudad,
            Int32 K_Colonia,
            string Calle,
            bool B_Local,
            decimal Precio,
            DateTime F_Servicio,
            bool B_Sencillo,
            bool B_Oxigeno,
            bool B_Segundo_Piso,
            bool B_Piso_Extra,
            bool B_Mas120Kilos,
            Int32 K_Precio_Ambulancia,
            Int32 K_Pais_Recoge,
            Int32 K_Estado_Recoge,
            Int32 K_Ciudad_Recoge,
            Int32 K_Colonia_Recoge,
            String CalleRecoge,
            String TelefonoContacto,
            DataTable Articulos_DetalleAmbulancia,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Servicios_ContratadosAmb";

            IDataParameter p_K_Servicio_Contratado_Ambulancia = new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int);
            p_K_Servicio_Contratado_Ambulancia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Servicio_Contratado_Ambulancia);

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
            cmd.Parameters.Add(new SqlParameter("@CalleNumero", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Pais_Recoge", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado_Recoge", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad_Recoge", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia_Recoge", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@CalleRecoge", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@TelefonoContacto", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Servicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Sencillo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Oxigeno", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Segundo_Piso", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Piso_Extra", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Mas120Kilos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Articulos_DetalleAmbulancia", SqlDbType.Structured));

            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@CalleNumero"].Value = Calle;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@K_Pais_Recoge"].Value = K_Pais_Recoge;
            cmd.Parameters["@K_Estado_Recoge"].Value = K_Estado_Recoge;
            cmd.Parameters["@K_Ciudad_Recoge"].Value = K_Ciudad_Recoge;
            cmd.Parameters["@K_Colonia_Recoge"].Value = K_Colonia_Recoge;
            cmd.Parameters["@CalleRecoge"].Value = CalleRecoge;
            cmd.Parameters["@TelefonoContacto"].Value = TelefonoContacto;
            cmd.Parameters["@F_Servicio"].Value = F_Servicio;
            cmd.Parameters["@B_Sencillo"].Value = B_Sencillo;
            cmd.Parameters["@B_Oxigeno"].Value = B_Oxigeno;
            cmd.Parameters["@B_Segundo_Piso"].Value = B_Segundo_Piso;
            cmd.Parameters["@B_Piso_Extra"].Value = B_Piso_Extra;
            cmd.Parameters["@B_Mas120Kilos"].Value = B_Mas120Kilos;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@Articulos_DetalleAmbulancia"].Value = Articulos_DetalleAmbulancia;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Servicio_Contratado_Ambulancia = (Int32)p_K_Servicio_Contratado_Ambulancia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable GP_Valida_PreciosAmbulancia(bool B_Sencillo, bool B_Local, bool B_Oxigeno, bool B_Segundo_Piso)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Valida_PreciosAmbulancia";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Sencillo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Oxigeno", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Segundo_Piso", SqlDbType.Bit));
            cmd.Parameters["@B_Sencillo"].Value = B_Sencillo;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@B_Oxigeno"].Value = B_Oxigeno;
            cmd.Parameters["@B_Segundo_Piso"].Value = B_Segundo_Piso;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;

        }

        public int In_Servicios_RecurrentesAmbulancia(ref Int32 K_Servicio_Recurrente_Ambulancia,
            Int32 K_Cliente,
            Int32 K_Oficina,
            Int32 K_Pais,
            Int32 K_Estado,
            Int32 K_Ciudad,
            Int32 K_Colonia,
            bool B_Local,
            decimal Precio,
            DateTime F_Servicio,
            bool B_Sencillo,
            bool B_Oxigeno,
            bool B_Segundo_Piso,
            Int32 K_Precio_Ambulancia,
            bool B_Piso_Extra,
            bool B_Mas120Kilos,
            DateTime F_Inicial,
            DateTime F_Final,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Servicios_RecurrentesAmbulancia";

            IDataParameter p_K_Servicio_Recurrente_Ambulancia = new SqlParameter("@K_Servicio_Recurrente_Ambulancia", SqlDbType.Int);
            p_K_Servicio_Recurrente_Ambulancia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Servicio_Recurrente_Ambulancia);

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
            cmd.Parameters.Add(new SqlParameter("@B_Sencillo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Oxigeno", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Segundo_Piso", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Piso_Extra", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Mas120Kilos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Servicio_Recurrente_Ambulancia"].Value = K_Servicio_Recurrente_Ambulancia;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Servicio"].Value = F_Servicio;
            cmd.Parameters["@B_Sencillo"].Value = B_Sencillo;
            cmd.Parameters["@B_Oxigeno"].Value = B_Oxigeno;
            cmd.Parameters["@B_Segundo_Piso"].Value = B_Segundo_Piso;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@B_Piso_Extra"].Value = B_Piso_Extra;
            cmd.Parameters["@B_Mas120Kilos"].Value = B_Mas120Kilos;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Servicio_Recurrente_Ambulancia = (Int32)p_K_Servicio_Recurrente_Ambulancia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        
        public int UP_Realiza_ServicioAmbulancia(Int32 K_Servicio_Contratado_Ambulancia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UP_Realiza_ServicioAmbulancia";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_Cancelacion_ServiciosAmbulancia(Int32 K_Servicio_Contratados_Ambulancia, Int32 K_Motivo_Cancelacion_ServiciosAmbulancia,Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Cancelacion_ServiciosAmbulancia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratados_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion_ServiciosAmbulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratados_Ambulancia"].Value = K_Servicio_Contratados_Ambulancia;
            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosAmbulancia"].Value = K_Motivo_Cancelacion_ServiciosAmbulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Zonificacion_Local_Enf_All(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Local_Enf_All";

            IDataParameter p_pmsMsg = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_pmsMsg.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_pmsMsg);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }
        public int Dl_Zonificacion_Local_Enf_All(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Local_Enf_All";

            IDataParameter p_pmsMsg = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_pmsMsg.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_pmsMsg);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }
        public int In_Zonificacion_Local_Precios_Enf_All(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Local_Precios_Enf_All";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;

            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Inicio"].Value = F_Inicio;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Zonificacion_Local_Amb_All(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Local_Amb_All";

            IDataParameter p_pmsMsg = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_pmsMsg.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_pmsMsg);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }
        public int Dl_Zonificacion_Local_Amb_All(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Local_Amb_All";

            IDataParameter p_pmsMsg = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_pmsMsg.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_pmsMsg);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }
        public int In_Zonificacion_Local_Precios_Amb_All(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Local_Precios_Amb_All";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;

            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Inicio"].Value = F_Inicio;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Motivo_Cancelacion_ServiciosEnfermeria(Int32 K_Motivo_Cancelacion_ServiciosEnfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivo_Cancelacion_ServiciosEnfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion_ServiciosEnfermeria", SqlDbType.SmallInt));

            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosEnfermeria"].Value = K_Motivo_Cancelacion_ServiciosEnfermeria;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Motivo_Cancelacion_ServiciosEnfermeria(Int32 K_Motivo_Cancelacion_ServiciosEnfermeria, string D_Motivo_Cancelacion_ServiciosEnfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivo_Cancelacion_ServiciosEnfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion_ServiciosEnfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Cancelacion_ServiciosEnfermeria", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosEnfermeria"].Value = K_Motivo_Cancelacion_ServiciosEnfermeria;
            cmd.Parameters["@D_Motivo_Cancelacion_ServiciosEnfermeria"].Value = D_Motivo_Cancelacion_ServiciosEnfermeria;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Motivo_Cancelacion_ServiciosEnfermeria(ref Int32 K_Motivo_Cancelacion_ServiciosEnfermeria, string D_Motivo_Cancelacion_ServiciosEnfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivo_Cancelacion_ServiciosEnfermeria";

            IDataParameter p_K_Motivo = new SqlParameter("@K_Motivo_Cancelacion_ServiciosEnfermeria", SqlDbType.SmallInt);
            p_K_Motivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Cancelacion_ServiciosEnfermeria", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosEnfermeria"].Value = K_Motivo_Cancelacion_ServiciosEnfermeria;
            cmd.Parameters["@D_Motivo_Cancelacion_ServiciosEnfermeria"].Value = D_Motivo_Cancelacion_ServiciosEnfermeria;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivo_Cancelacion_ServiciosEnfermeria = (Int16)p_K_Motivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_ServiciosContratados_Ambulancia(Int32 K_Servicio_Contratado_Ambulancia, Int32 K_Ambulancia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_ServiciosContraAmbulancia_Ambulancia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;
            cmd.Parameters["@K_Ambulancia"].Value = K_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Elimina_Ambulancia(Int32 K_Servicio_Contratado_Ambulancia, Int32 K_Ambulancia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Elimina_Ambulancia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;
            cmd.Parameters["@K_Ambulancia"].Value = K_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable SK_Clientes_Apps(string D_Usuario , string Correo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Clientes_Apps";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@D_Usuario", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 100));

            cmd.Parameters["@D_Usuario"].Value = D_Usuario;
            cmd.Parameters["@Correo"].Value = Correo;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable SK_Clientes_Apps()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Clientes_Apps";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int UP_Cliente_UsuarioApp(Int32 K_Usuario, Int32 K_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UP_Cliente_UsuarioApp";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario_App", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));

            cmd.Parameters["@K_Usuario_App"].Value = K_Usuario;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Cliente_UsuarioApp(Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cliente_UsuarioApp";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario_App", SqlDbType.Int));

            cmd.Parameters["@K_Usuario_App"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Zonificacion_LPAmbulancia_Aseg_All(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio,
     DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_LPAmbulancia_Aseg_All";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Inicio"].Value = F_Inicio;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Zonificacion_LocAsegu_Precios_Enfermeria_All(ref Int32 K_Precio_LocAsegu_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_LocAsegu_Precios_Enfermeria_All";


            IDataParameter p_K_Precio_LocAsegu_Enfermeria = new SqlParameter("@K_Precio_LocAsegu_Enfermeria", SqlDbType.Int);
            p_K_Precio_LocAsegu_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_LocAsegu_Enfermeria);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Precio_LocAsegu_Enfermeria"].Value = K_Precio_LocAsegu_Enfermeria;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = F_Inicio;
            cmd.Parameters["@F_Fin_Vigencia"].Value = F_Final;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            K_Precio_LocAsegu_Enfermeria = (Int32)p_K_Precio_LocAsegu_Enfermeria.Value;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        //PRECIOS RENTA
        public DataTable Sk_Precios_Renta_Articulos(DateTime F_Inicial, DateTime F_Final)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Renta_Articulos";
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Precios_Renta_Actual()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Renta_Actual";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Precios_Renta_Actual(
          ref Int32 K_Precio_Articulo,
          Int32 K_Articulo,
          decimal Precio,
          DateTime F_Actualizacion,
          ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Precios_Renta_Actual";

            IDataParameter p_K_Precio_Articulo = new SqlParameter("@K_Precios_Renta_Actual", SqlDbType.Int);
            p_K_Precio_Articulo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_Articulo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Ultima_Actualizacion", SqlDbType.SmallDateTime));


            cmd.Parameters["@K_Precios_Renta_Actual"].Value = K_Precio_Articulo;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@F_Ultima_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

     
        public int Up_Precios_Renta_Actual(
          Int32 K_Precio_Articulo,
          Int32 K_Articulo,
          decimal Precio,
          DateTime F_Actualizacion,
           ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Precios_Renta_Actual";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precios_Renta_Actual", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Ultima_Actualizacion", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Precios_Renta_Actual"].Value = K_Precio_Articulo;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@F_Ultima_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@Precio"].Value = Precio;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Pagos_Ambulancias(
          Int32 K_Servicio_Contratado_Ambulancia,
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
            cmd.CommandText = "In_Pagos_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco_Tarjeta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Trajeta", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_TarjetaCredito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Aprobacion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@No_Operacion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_Tarjeta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplica", SqlDbType.Int));

            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;
            cmd.Parameters["@K_Banco_Tarjeta"].Value = K_Banco_Tarjeta;
            cmd.Parameters["@No_Trajeta"].Value = No_Trajeta;
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


        public DataTable Sk_Pagos_Ambulancias(Int32 K_Servicio_Contratado_Ambulancia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pagos_Ambulancias";
            cmd.Parameters.Add(new SqlParameter("@K_Servicio_Contratado_Ambulancia", SqlDbType.Int));
            cmd.Parameters["@K_Servicio_Contratado_Ambulancia"].Value = K_Servicio_Contratado_Ambulancia;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public int Gp_Carga_ArticulosProvedor(Int32 K_Proveedor, string SKU, decimal Precio_Articulo, string Archivo_Subio, decimal Porcentaje_Descuento)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Carga_ArticulosProvedor";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar,100));
            cmd.Parameters.Add(new SqlParameter("@Precio_Articulo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Archivo_Subio", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@Precio_Articulo"].Value = Precio_Articulo;
            cmd.Parameters["@Archivo_Subio"].Value = Archivo_Subio;
            cmd.Parameters["@F_Actualizacion"].Value = DateTime.Now;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = GlobalVar.PC_Name;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            return res;
        }
        public int Gp_Sube_ArticulosProvedor()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Sube_ArticulosProvedor";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = GlobalVar.PC_Name;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            return res;
        }
        public int Gp_ValidaPrecioGanancia(Int32 K_Articulo, decimal Precio, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaPrecioGanancia";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio_Actual", SqlDbType.Money));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@Precio_Actual"].Value = Precio;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

    }


}
