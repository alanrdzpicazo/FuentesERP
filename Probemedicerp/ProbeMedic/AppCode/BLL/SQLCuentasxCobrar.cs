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
    class SQLCuentasxCobrar
    {
        public DataTable Sk_Facturas_PendientesPago(Int32 K_Oficina,Int32 K_Cliente,Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Facturas_PendientesPago";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            if(K_Oficina==0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }
            if(K_Cliente==0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }
           
            if(K_Empresa==0)
            {
                cmd.Parameters["@K_Empresa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            }

            dt = ConnectionClass.GetTable(ref cmd);


            return dt;
        }
        public DataTable Gp_Consulta_LiqCXC(Int32 K_Oficina, Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Consulta_LiqCXC";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            dt = ConnectionClass.GetTable(ref cmd);


            return dt;
        }
        public int In_Estatus_Remision(ref Int16 K_Estatus_Remision, string D_Estatus_Remision, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estatus_Remision";

            IDataParameter p_K_Estatus_Remision = new SqlParameter("@K_Estatus_Remision", SqlDbType.Int);
            p_K_Estatus_Remision.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estatus_Remision);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Remision", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Remision"].Value = K_Estatus_Remision;
            cmd.Parameters["@D_Estatus_Remision"].Value = D_Estatus_Remision;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                K_Estatus_Remision = 0;

                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            else
            {

                K_Estatus_Remision = Convert.ToInt16(p_K_Estatus_Remision.Value);

            }

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }

        public int Gp_Pagos_Factura(ref Int32 NoOperacion_Interna, Int32 K_Oficina, Int32 K_Usuario,Int32 K_Cliente,DataTable DetallePagoCXCType,Int32 K_Liquidacion_CXC, int K_Cuenta_Cliente, int K_Cuenta_Empresa,  string PC_Name,DateTime F_Aplicacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Pagos_Factura";

            IDataParameter p_NoOperacion_Interna = new SqlParameter("@NoOperacion_Interna", SqlDbType.Int);
            p_NoOperacion_Interna.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_NoOperacion_Interna);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetallePagoCXCType", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Liquidacion_CXC", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Empresa", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@F_Aplicacion", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@DetallePagoCXCType"].Value = DetallePagoCXCType;
            if (K_Liquidacion_CXC > 0)
            {
                cmd.Parameters["@K_Liquidacion_CXC"].Value = K_Liquidacion_CXC;
            }
            else
            {
                cmd.Parameters["@K_Liquidacion_CXC"].Value = DBNull.Value;
            }
            cmd.Parameters["@PC_Name"].Value = PC_Name;

            if(K_Cuenta_Cliente ==0)
            {
                cmd.Parameters["@K_Cuenta_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            }
            cmd.Parameters["@K_Cuenta_Empresa"].Value = K_Cuenta_Empresa;
            cmd.Parameters["@NoOperacion_Interna"].Value = NoOperacion_Interna;
            cmd.Parameters["@F_Aplicacion"].Value = F_Aplicacion;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            NoOperacion_Interna = Convert.ToInt32(p_NoOperacion_Interna.Value);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_Trae_AnticiposCliente(Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Trae_AnticiposCliente";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Motivo_Anticipo_Cliente()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Anticipo_Cliente";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Facturas_Pte(Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Facturas_Pte";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            if(K_Empresa==0)
            {
                cmd.Parameters["@K_Empresa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            }
        
            dt = ConnectionClass.GetTable(ref cmd);


            return dt;
        }
        public int Gp_Pagos_FacturaMultipleCliente(Int32 K_Usuario, Int32 K_Oficina, string PC_Name, Int32 K_Liquidacion_CXC, DataTable DetallePagoCXCTypeMultiCliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Pagos_FacturaMultipleCliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Liquidacion_CXC", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetallePagoCXCTypeMultiCliente", SqlDbType.Structured));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;

            if (K_Liquidacion_CXC > 0)
            {
                cmd.Parameters["@K_Liquidacion_CXC"].Value = K_Liquidacion_CXC;
            }
            else
            {
                cmd.Parameters["@K_Liquidacion_CXC"].Value = DBNull.Value;
            }

            cmd.Parameters["@DetallePagoCXCTypeMultiCliente"].Value = DetallePagoCXCTypeMultiCliente;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

    }
}
