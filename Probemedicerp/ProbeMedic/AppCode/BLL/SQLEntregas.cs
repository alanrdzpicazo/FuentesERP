using ProbeMedic.AppCode.DCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProbeMedic.AppCode.BLL
{
    class SQLEntregas
    {
        //Sk_Consulta_LiqEmpleados

        public DataTable  Sk_Consulta_LiqEmpleados(Int32 K_Liquidacion_Empleado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Consulta_LiqEmpleados";


            cmd.Parameters.Add(new SqlParameter("@K_Liquidacion_Empleado", SqlDbType.Int));

            cmd.Parameters["@K_Liquidacion_Empleado"].Value = K_Liquidacion_Empleado;


            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //Gp_Cierre_Camionetas

        public int Gp_Cierre_Camionetas(Int32 K_Liquidacion,Int32 K_OficinaEntrega, Int32 K_Empleado_Recibe,Int32 K_Usuario, DataTable Pedidos_Liquidacion_Pagos)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Cierre_Camionetas";


            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Liquidacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_OficinaEntrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pedidos_Liquidacion_Pagos", SqlDbType.Structured));

          
            cmd.Parameters["@K_Liquidacion"].Value = K_Liquidacion;
            cmd.Parameters["@K_OficinaEntrega"].Value = K_OficinaEntrega;
            cmd.Parameters["@K_Empleado_Recibe"].Value = K_Empleado_Recibe;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Pedidos_Liquidacion_Pagos"].Value = Pedidos_Liquidacion_Pagos;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

           

            return res;
        }

        public DataTable Sk_Remisiones_Documentadas(Int32 K_Oficina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Remisiones_Documentadas";


            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;


            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //Sk_Liquidacion_Empleados
        public DataTable Sk_Liquidacion_Empleados(Int32 K_Oficina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Liquidacion_Empleados";


            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Liquidacion", SqlDbType.Int));

            cmd.Parameters["@K_Oficina_Liquidacion"].Value = K_Oficina;


            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Gp_In_Liquidacion_Camionetas(ref Int32 K_Liquidacion,
            Int32 K_Empleado_Entrega,
            DateTime F_Apertura_Liquidacion,
            Int32 K_Empleado_Recibe,
            Int32 K_Oficina_Liquidacion,
            DataTable Pedidos_Liquidacion,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_In_Liquidacion_Camionetas";

            IDataParameter p_K_Liquidacion = new SqlParameter("@K_Liquidacion", SqlDbType.Int);
            p_K_Liquidacion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Liquidacion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

          
            cmd.Parameters.Add(new SqlParameter("@K_Empleado_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Apertura_Liquidacion", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Liquidacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pedidos_Liquidacion", SqlDbType.Structured)); //Pedidos_Liquidacion 


            cmd.Parameters["@K_Liquidacion"].Value = K_Liquidacion;
            cmd.Parameters["@K_Empleado_Entrega"].Value = K_Empleado_Entrega;
            cmd.Parameters["@F_Apertura_Liquidacion"].Value = F_Apertura_Liquidacion;
            cmd.Parameters["@K_Empleado_Recibe"].Value = K_Empleado_Recibe;
            cmd.Parameters["@K_Oficina_Liquidacion"].Value = K_Oficina_Liquidacion;
            cmd.Parameters["@Pedidos_Liquidacion"].Value = Pedidos_Liquidacion;
           

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Liquidacion = (Int32)p_K_Liquidacion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Gp_Rep_AsigRemisiones(
          Int32 K_Empleado_Entrega
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Rep_AsigRemisiones";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empleado_Entrega", SqlDbType.Int));
            cmd.Parameters["@K_Empleado_Entrega"].Value = K_Empleado_Entrega;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_RepCierre_Camionetas(
          Int32 K_Cierre_Camionetas_Empleado
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepCierre_Camionetas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cierre_Camionetas_Empleado", SqlDbType.Int));
            cmd.Parameters["@K_Cierre_Camionetas_Empleado"].Value = K_Cierre_Camionetas_Empleado;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Rep_CierreLiq(
        Int32 K_Liquidacion_Empleados,
        Int32 K_Empleado
      )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Rep_CierreLiq";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Liquidacion_Empleados", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters["@K_Liquidacion_Empleados"].Value = K_Liquidacion_Empleados;
            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

    }
}




