using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ProbeMedic.AppCode.DCC
{
    public class ConnectionClass
    {
        public static SqlConnection GetConnection()
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["cnUlsa"].ToString();

            //string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["cnERP"].ToString().Trim();
            //string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["cnERP"].ToString();

            //string ConnectionString = string.Empty;
            //string Servidor = string.Empty;
            //string Base = string.Empty;
            //string Usuario = string.Empty;
            //string Contrasena = string.Empty;
            //string ConexionActiva = ConfigurationManager.AppSettings["ConexionActiva"].ToString();

            //if (ConexionActiva.Trim().ToUpper() == "LOCAL")
            //{
            //    Servidor = ConfigurationManager.AppSettings["ServidorLocal"].ToString();
            //    Base = ConfigurationManager.AppSettings["BaseLocal"].ToString();
            //    Usuario = ConfigurationManager.AppSettings["UsuarioLocal"].ToString();
            //    Contrasena = ConfigurationManager.AppSettings["ContrasenaLocal"].ToString();
            //}
            //else
            //{
            //    Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
            //    Base = ConfigurationManager.AppSettings["Base"].ToString();
            //    Usuario = ConfigurationManager.AppSettings["Usuario"].ToString();
            //    Contrasena = ConfigurationManager.AppSettings["Contrasena"].ToString();
            //}
            //ConnectionString = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + ";Connect Timeout=0; pooling='true'; Max Pool Size=200";

            string ConnectionString = ObtieneCadenaConexion();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            return conn;
        }

        public static SqlConnection GetConnectionSinTiempo()
        {
            string ConnectionString = ObtieneCadenaConexion(false);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            return conn;
        }

        public static string ObtieneCadenaConexion(bool ConTiempo = true, int Tiempo = 380)
        {
            string ConnectionString = string.Empty;
            string Servidor = string.Empty;
            string Base = string.Empty;
            string Usuario = string.Empty;
            string Contrasena = string.Empty;
            //string ConexionActiva = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
            string ConexionActiva = GlobalVar.Conexion;

            if (GlobalVar.Conexion == "PRODUCCION")
            {
                Servidor =  SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["Servidor"].ToString());
                Base = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["Base"].ToString());
                Usuario = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["Usuario"].ToString());
                Contrasena = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["Contrasena"].ToString());
            }
            else if(GlobalVar.Conexion == "PRUEBAS")
            {
                Servidor = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["ServidorPruebas"].ToString());
                Base = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["BasePruebas"].ToString());
                Usuario = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["UsuarioPruebas"].ToString());
                Contrasena = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["ContrasenaPruebas"].ToString());
            }
            else
            {
                Servidor = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["ServidorAltis"].ToString());
                Base = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["BaseAltis"].ToString());
                Usuario = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["UsuarioAltis"].ToString());
                Contrasena = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["ContrasenaAltis"].ToString());
            }
      
            if (ConTiempo == true)
                ConnectionString = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + ";connect timeout=" + Tiempo.ToString().Trim() + "; pooling='true'; Max Pool Size=200";
                //ConnectionString = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + "; pooling='true'; Max Pool Size=200";
            else
                ConnectionString = "User ID=" + Usuario + ";Password=" + Contrasena + ";Initial Catalog=" + Base + ";Data Source=" + Servidor + ";connect timeout=" + Tiempo.ToString().Trim() + "; pooling='true'; Max Pool Size=200";

            return ConnectionString;
        }

        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {                    
                    connection.Open();
                    sps_ObtieneSPID(connection);
                    return true;
                }
                catch (SqlException)
                {                    
                    return false;
                }
                finally
                {
                    // not really necessary
                    connection.Close();
                }
            }
        }

        private static short sps_ObtieneSPID(IDbConnection con)
        {
            short result = 0;
            var sql = con.CreateCommand();
            sql.CommandText = "sps_ObtieneSPID";
            sql.CommandType = CommandType.StoredProcedure;
            try
            {
                result = Convert.ToInt16(sql.ExecuteScalar());
                //GlobalVar.SPID = result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return result;
        }

        public static SqlCommand GetCommand()
        {
            SqlCommand comm = new SqlCommand();
            return comm;
        }

        public static DataTable GetTable(ref SqlCommand command)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            DataTable dtable = new DataTable();

            if (command == null)
            {
                return dtable;
            }

            try
            {
                conn = ConnectionClass.GetConnection();
                command.Connection = conn;
                conn.Open();
                sps_ObtieneSPID(conn);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                    dtable.Load(reader);
                else
                    return null;
            }
            catch (Exception ex)
            {
                string strMensaje = ex.Message;

            }
            finally
            {
                command.Dispose();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (conn != null)
                    conn.Dispose();
            }

            return dtable;
        }

        public static int ExecuteNonQuerySinTiempo(ref SqlCommand command)
        {
            SqlConnection conn = null;
            int result = 0;
            if (command == null)
            {

                return -1;
            }

            try
            {
                conn = ConnectionClass.GetConnectionSinTiempo();
                command.Connection = conn;
                conn.Open();
                sps_ObtieneSPID(conn);
                result = command.ExecuteNonQuery();
                for (int j = 0; j < command.Parameters.Count; j++)
                {
                    if (command.Parameters[j].Direction == ParameterDirection.ReturnValue)
                        result = Convert.ToInt32(command.Parameters[j].Value);
                }
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (conn != null)
                    conn.Dispose();
            }

            return result;
        }

        public static int ExecuteNonQuery(ref SqlCommand command)
        {
            SqlConnection conn = null;
            int result = 0;
            if (command == null)
            {

                return -1;
            }
            try
            { 
                conn = ConnectionClass.GetConnection();
                command.Connection = conn;
                conn.Open();
                sps_ObtieneSPID(conn);

                result = command.ExecuteNonQuery();

                for (int j = 0; j < command.Parameters.Count; j++)
                {
                    if (command.Parameters[j].Direction == ParameterDirection.ReturnValue)
                        result = Convert.ToInt32(command.Parameters[j].Value);
                }
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (conn != null)
                    conn.Dispose();
            }

            return result;
        }
    }
}
