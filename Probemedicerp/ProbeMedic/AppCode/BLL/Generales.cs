using ProbeMedic.AppCode.DCC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbeMedic.AppCode.BLL
{
     public class Generales
    {
        public DataTable sps_EncabezadoReportes()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sps_EncabezadoReportes";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Tipo_Reporte()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Reporte";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Reportes(Int32 K_Tipo_Reporte)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Reportes";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Reporte", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Reporte"].Value = K_Tipo_Reporte;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Filtros_Reporte(Int32 K_Reporte)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Filtros_Reporte";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Reporte", SqlDbType.Int));
            cmd.Parameters["@K_Reporte"].Value = K_Reporte;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_NotificacionesSolicitudTraspaso(Int32 K_Usuario, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_NotificacionesSolicitudTraspaso";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 5000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }
        public int Gp_NotificacionesTraspasosDirectos(Int32 K_Usuario, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_NotificacionesTraspasosDirectos";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 5000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }
    }
}
