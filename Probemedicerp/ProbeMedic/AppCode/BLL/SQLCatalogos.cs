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
    public class SQLCatalogos
    {
        //ESTATUS REMISIÓN

        public DataTable Sk_Estatus_Remision()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estatus_Remision";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Estatus_Remision(Int16 K_Estatus_Remision, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estatus_Remision";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Remision", SqlDbType.Int));
            cmd.Parameters["@K_Estatus_Remision"].Value = K_Estatus_Remision;

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
        public int Up_Estatus_Remision(Int16 K_Estatus_Remision, string D_Estatus_Remision, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estatus_Remision";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Remision", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Remision", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Remision"].Value = K_Estatus_Remision;
            cmd.Parameters["@D_Estatus_Remision"].Value = D_Estatus_Remision;
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

        //EMPRESA ENTREGA
        public DataTable Sk_Empresa_Entrega()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Empresa_Entrega";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Empresa_Entrega(Int16 K_Empresa_Entrega, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Empresa_Entrega";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));
            cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;

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
        public int Up_Empresa_Entrega(Int16 K_Empresa_Entrega, string D_Empresa_Entrega, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Empresa_Entrega";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Empresa_Entrega", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));

            cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            cmd.Parameters["@D_Empresa_Entrega"].Value = D_Empresa_Entrega;
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
        public int In_Empresa_Entrega(ref Int16 K_Empresa_Entrega, string D_Empresa_Entrega, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Empresa_Entrega";

            IDataParameter p_K_Empresa_Entrega = new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int);
            p_K_Empresa_Entrega.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Empresa_Entrega);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Empresa_Entrega", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            cmd.Parameters["@D_Empresa_Entrega"].Value = D_Empresa_Entrega;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                K_Empresa_Entrega = 0;

                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            else
            {

                K_Empresa_Entrega = Convert.ToInt16(p_K_Empresa_Entrega.Value);

            }

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }




        //MOTIVO CANCELACIÓN
        public DataTable Sk_Motivos_Cancelacion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivos_Cancelacion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Motivos_Cancelacion(Int16 K_Motivo_Cancelacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivos_Cancelacion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion", SqlDbType.Int));
            cmd.Parameters["@K_Motivo_Cancelacion"].Value = K_Motivo_Cancelacion;

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

        public int Up_Motivos_Cancelacion(Int16 K_Motivo_Cancelacion, string D_Motivo_Cancelacion, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivos_Cancelacion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Cancelacion", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Cancelacion"].Value = K_Motivo_Cancelacion;
            cmd.Parameters["@D_Motivo_Cancelacion"].Value = D_Motivo_Cancelacion;
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

        public int In_Motivos_Cancelacion(ref Int16 K_Motivo_Cancelacion, string D_Motivo_Cancelacion, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivos_Cancelacion";

            IDataParameter p_K_Motivo_Cancelacion = new SqlParameter("@K_Motivo_Cancelacion", SqlDbType.Int);
            p_K_Motivo_Cancelacion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Cancelacion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Cancelacion", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Cancelacion"].Value = K_Motivo_Cancelacion;
            cmd.Parameters["@D_Motivo_Cancelacion"].Value = D_Motivo_Cancelacion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                K_Motivo_Cancelacion = 0;

                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            else
            {

                K_Motivo_Cancelacion = Convert.ToInt16(p_K_Motivo_Cancelacion.Value);

            }

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }



        //MOTIVO INVENTARIO

        public DataTable Sk_Motivo_Ajuste_Inventario()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Ajuste_Inventario";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Motivo_Ajuste_Inventario(Int16 K_Motivo_Ajuste_Inventario,Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivo_Ajuste_Inventario";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Ajuste_Inventario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Ajuste_Inventario"].Value = @K_Motivo_Ajuste_Inventario;
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

        public int Up_Motivo_Ajuste_Inventario(Int16 K_Motivo_Ajuste_Inventario, string D_Motivo_Ajuste_Inventario, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivo_Ajuste_Inventario";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Ajuste_Inventario", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Ajuste_Inventario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Ajuste_Inventario"].Value = K_Motivo_Ajuste_Inventario;
            cmd.Parameters["@D_Motivo_Ajuste_Inventario"].Value = D_Motivo_Ajuste_Inventario;
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

        public int In_Motivo_Ajuste_Inventario(ref Int16 K_Motivo_Ajuste_Inventario, string D_Motivo_Ajuste_Inventario, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivo_Ajuste_Inventario";

            IDataParameter p_K_Motivo_Ajuste_Inventario = new SqlParameter("@K_Motivo_Ajuste_Inventario", SqlDbType.Int);
            p_K_Motivo_Ajuste_Inventario.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Ajuste_Inventario);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Ajuste_Inventario", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Ajuste_Inventario"].Value = K_Motivo_Ajuste_Inventario;
            cmd.Parameters["@D_Motivo_Ajuste_Inventario"].Value = D_Motivo_Ajuste_Inventario;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                K_Motivo_Ajuste_Inventario = 0;

                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            else
            {

                K_Motivo_Ajuste_Inventario = Convert.ToInt16(p_K_Motivo_Ajuste_Inventario.Value);

            }

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }


        //DIAS FESTIVOS
        public DataTable Sk_Dias_Inhabiles()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Dias_Inhabiles";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Dias_Inhabiles(ref Int32 K_Dias_inhabiles, DateTime F_Dia_inhabil, string D_Motivo_inhabil, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Dias_Inhabiles";

            IDataParameter p_K_Dias_inhabiles = new SqlParameter("@K_Dias_inhabiles", SqlDbType.Int);
            p_K_Dias_inhabiles.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Dias_inhabiles);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@F_Dia_inhabil", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_inhabil", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Dias_inhabiles"].Value = K_Dias_inhabiles;
            cmd.Parameters["@F_Dia_inhabil"].Value = F_Dia_inhabil;
            cmd.Parameters["@D_Motivo_inhabil"].Value = D_Motivo_inhabil;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Dias_inhabiles = (Int32)p_K_Dias_inhabiles.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public int Up_Dias_Inhabiles(Int32 K_Dias_inhabiles, DateTime F_Dia_inhabil, string D_Motivo_inhabil, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Dias_Inhabiles";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@F_Dia_inhabil", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_inhabil", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Dias_inhabiles", SqlDbType.Int));

            cmd.Parameters["@F_Dia_inhabil"].Value = F_Dia_inhabil;
            cmd.Parameters["@D_Motivo_inhabil"].Value = D_Motivo_inhabil;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Dias_inhabiles"].Value = K_Dias_inhabiles;
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

        public int Dl_Dias_Inhabiles(Int32 K_Dias_inhabiles, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Dias_Inhabiles";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Dias_inhabiles", SqlDbType.Int));
            cmd.Parameters["@K_Dias_inhabiles"].Value = K_Dias_inhabiles;
            cmd.Parameters["@pmsMsg"].Value=Mensaje;

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


        public int Dl_Empresas(Int16 K_Empresa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Empresa";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.TinyInt));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Empresa(Int16 K_Empresa, bool B_DarBaja, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Empresa";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.TinyInt));
            cmd.Parameters.Add(new SqlParameter("@B_DarBaja", SqlDbType.Bit));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@B_DarBaja"].Value = B_DarBaja;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Empresa(Int32 K_Empresa, string D_Empresa, string C_Empresa, string RFC, string TipoRegimen, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, string Colonia, string Calle, Int32 CodigoPostal, string Telefono, string NoExterior, string NoInterior, string Fax, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Empresa";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.TinyInt));
            cmd.Parameters.Add(new SqlParameter("@D_Empresa", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Empresa", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@TipoRegimen", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Colonia", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@CodigoPostal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@NoExterior", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@NoInterior", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@D_Empresa"].Value = D_Empresa;
            cmd.Parameters["@C_Empresa"].Value = C_Empresa;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@TipoRegimen"].Value = TipoRegimen;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@Colonia"].Value = Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@CodigoPostal"].Value = CodigoPostal;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@NoExterior"].Value = NoExterior;
            cmd.Parameters["@NoInterior"].Value = NoInterior;
            cmd.Parameters["@Fax"].Value = Fax;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Empresa(ref Int32 K_Empresa, string D_Empresa, string C_Empresa, string RFC, string TipoRegimen, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, string Colonia, string Calle, Int32 CodigoPostal, string Telefono, string NoExterior, string NoInterior, string Fax, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Empresa";

            IDataParameter p_K_Empresa = new SqlParameter("@K_Empresa", SqlDbType.Int);
            p_K_Empresa.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Empresa);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Empresa", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Empresa", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@TipoRegimen", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Colonia", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@CodigoPostal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@NoExterior", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@NoInterior", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@D_Empresa"].Value = D_Empresa;
            cmd.Parameters["@C_Empresa"].Value = C_Empresa;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@TipoRegimen"].Value = TipoRegimen;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@Colonia"].Value = Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@CodigoPostal"].Value = CodigoPostal;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@NoExterior"].Value = NoExterior;
            cmd.Parameters["@NoInterior"].Value = NoInterior;
            cmd.Parameters["@Fax"].Value = Fax;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Empresa = (Int32)p_K_Empresa.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_empresa()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_empresa";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        #region Geograficos   
        public int Dl_Colonia(Int32 K_Ciudad, Int32 K_Estado, Int32 K_Colonia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Colonia";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Ciudad"].Value = K_Estado;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Colonia(Int32 K_Pais, Int32 K_Ciudad, Int32 K_Municipio, Int32 K_Estado, Int32 K_Colonia, string D_Colonia, Int32 Codigo_Postal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Colonia";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Municipio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Colonia", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Municipio"].Value = K_Municipio;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@D_Colonia"].Value = D_Colonia;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Colonia(Int32 K_Pais, Int32 K_Ciudad, Int32 K_Municipio, Int32 K_Estado, ref Int32 K_Colonia, string D_Colonia, Int32 Codigo_Postal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Colonia";

            IDataParameter p_K_Colonia = new SqlParameter("@K_Colonia", SqlDbType.Int);
            p_K_Colonia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Colonia);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Municipio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Colonia", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Municipio"].Value = K_Municipio;
            cmd.Parameters["@D_Colonia"].Value = D_Colonia;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Colonia = (Int32)p_K_Colonia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Colonia(Int32 K_Colonia, string D_Colonia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Colonia";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Colonia", SqlDbType.VarChar, 120));

            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Colonia"].Value = D_Colonia;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Colonia_All(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Colonia_All";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Colonia_All(Int32 K_Colonia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Colonia_All";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Colonia()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Colonia";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable SK_Colonia(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, string D_Colonia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Colonia";
            DataTable dt = new DataTable();

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);

            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            IDataParameter p_K_Ciudad = new SqlParameter("@K_Ciudad", SqlDbType.Int);

            cmd.Parameters.Add(p_K_Ciudad);



            IDataParameter p_D_Colonia = new SqlParameter("@D_Colonia", SqlDbType.VarChar, 80);

            cmd.Parameters.Add(p_D_Colonia);



            if (K_Pais == 0)
            {
                cmd.Parameters["@K_Pais"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Pais"].Value = K_Pais;
            }

            if (K_Estado == 0)
            {
                cmd.Parameters["@K_Estado"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Estado"].Value = K_Estado;
            }

            if (K_Ciudad == 0)
            {
                cmd.Parameters["@K_Ciudad"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            }

            if (D_Colonia.Length == 0)
            {
                cmd.Parameters["@D_Colonia"].Value = DBNull.Value;
            }
            else
            {

                cmd.Parameters["@D_Colonia"].Value = "%" + D_Colonia + "%";
            }


            dt = ConnectionClass.GetTable(ref cmd);


            return dt;
        }
        ///
        public int Dl_Municipio_Delegacion(Int32 K_Pais, Int32 K_Estado, Int32 K_Municipio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Municipio_Delegacion";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Municipio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Estado;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Municipio"].Value = K_Municipio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Municipio_Delegacion(Int32 K_Pais, Int32 K_Estado, Int32 K_Municipio, string D_Municipio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Municipio_Delegacion";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Municipio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Municipio", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Municipio"].Value = K_Municipio;
            cmd.Parameters["@D_Municipio"].Value = D_Municipio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Municipio_Delegacion(Int32 K_Pais, Int32 K_Estado, ref Int32 K_Municipio, string D_Municipio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Municipio_Delegacion";

            IDataParameter p_K_Municipio = new SqlParameter("@K_Municipio", SqlDbType.Int);
            p_K_Municipio.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Municipio);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Municipio", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Municipio"].Value = K_Municipio;
            cmd.Parameters["@D_Municipio"].Value = D_Municipio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Municipio = (Int32)p_K_Municipio.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Municipio_Delegacion(Int32 K_Pais, Int32 K_Estado, Int32 K_Municipio)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Municipio_Delegacion";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@K_Municipio", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Municipio"].Value = K_Municipio;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Municipio_Delegacion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Municipio_Delegacion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Municipio_Delegacion(Int32 K_Pais, Int32 K_Estado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Municipio_Delegacion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        ///
        public int Dl_Ciudad(Int32 K_Estado, Int32 K_Ciudad, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Ciudad";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Ciudad(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, string D_Ciudad, bool B_Frontera, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Ciudad";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Ciudad", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@B_Frontera", SqlDbType.Bit));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@D_Ciudad"].Value = D_Ciudad;
            cmd.Parameters["@B_Frontera"].Value = B_Frontera;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Ciudad(Int16 K_Pais, Int32 K_Estado, ref Int32 K_Ciudad, string D_Ciudad, bool B_Frontera, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Ciudad";

            IDataParameter p_K_Ciudad = new SqlParameter("@K_Ciudad", SqlDbType.Int);
            p_K_Ciudad.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Ciudad);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Ciudad", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@B_Frontera", SqlDbType.Bit));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@D_Ciudad"].Value = D_Ciudad;
            cmd.Parameters["@B_Frontera"].Value = B_Frontera;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Ciudad = (Int32)p_K_Ciudad.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Ciudad(Int32 K_Pais, Int32 K_Estado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudad";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Ciudad()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudad";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Estado(Int32 K_Estado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estado";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Ciudad(Int32 K_Pais, Int32 K_Estado, string D_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudad";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Ciudad", SqlDbType.VarChar, 60));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@D_Ciudad"].Value = D_Ciudad;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Up_Estado(Int16 K_Pais, Int32 K_Estado, string D_Estado, string C_Estado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estado";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Estado", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Estado", SqlDbType.VarChar, 40));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@D_Estado"].Value = D_Estado;
            cmd.Parameters["@C_Estado"].Value = C_Estado;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Estado(Int16 K_Pais, ref Int32 K_Estado, string D_Estado, string C_Estado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estado";

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Estado", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Estado", SqlDbType.VarChar, 40));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@D_Estado"].Value = D_Estado;
            cmd.Parameters["@C_Estado"].Value = C_Estado;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Estado = (Int32)p_K_Estado.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Estado(Int32 K_Pais)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estado";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Estado()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estado";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Pais(Int16 K_Pais, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pais";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Pais(Int16 K_Pais, string D_Pais, string C_Pais, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Pais";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Pais", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Pais", SqlDbType.VarChar, 40));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@D_Pais"].Value = D_Pais;
            cmd.Parameters["@C_Pais"].Value = C_Pais;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Pais(ref Int16 K_Pais, string D_Pais, string C_Pais, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pais";

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.SmallInt);
            p_K_Pais.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Pais", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Pais", SqlDbType.VarChar, 40));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@D_Pais"].Value = D_Pais;
            cmd.Parameters["@C_Pais"].Value = C_Pais;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Pais = (Int16)p_K_Pais.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Pais()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pais";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Aseguradora(Int16 K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Aseguradora";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Aseguradora(Int16 K_Aseguradora, string D_Aseguradora, string C_Aseguradora, int K_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Aseguradora";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Aseguradora", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Aseguradora", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.SmallInt));

            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@D_Aseguradora"].Value = D_Aseguradora;
            cmd.Parameters["@C_Aseguradora"].Value = C_Aseguradora;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Aseguradora(ref Int16 K_Aseguradora, string D_Aseguradora, string C_Aseguradora, int K_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Aseguradora";

            IDataParameter p_K_Aseguradora = new SqlParameter("@K_Aseguradora", SqlDbType.SmallInt);
            p_K_Aseguradora.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Aseguradora);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Aseguradora", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Aseguradora", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.SmallInt));

            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@D_Aseguradora"].Value = D_Aseguradora;
            cmd.Parameters["@C_Aseguradora"].Value = C_Aseguradora;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Aseguradora = (Int16)p_K_Aseguradora.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Aseguradora()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Aseguradora";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        # endregion Geograficos

        public int Dl_Puesto(Int16 K_Puesto, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Puesto";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Puesto", SqlDbType.SmallInt));

            cmd.Parameters["@K_Puesto"].Value = K_Puesto;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Puesto(Int16 K_Puesto, string D_Puesto, bool B_Enfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Puesto";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Puesto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Puesto", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Enfermera", SqlDbType.Bit));

            cmd.Parameters["@K_Puesto"].Value = K_Puesto;
            cmd.Parameters["@D_Puesto"].Value = D_Puesto;
            cmd.Parameters["@B_Enfermera"].Value = B_Enfermeria;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Puesto(ref Int16 K_Puesto, string D_Puesto, bool B_Enfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Puesto";

            IDataParameter p_K_Puesto = new SqlParameter("@K_Puesto", SqlDbType.SmallInt);
            p_K_Puesto.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Puesto);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Puesto", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Enfermera", SqlDbType.Bit));

            cmd.Parameters["@K_Puesto"].Value = K_Puesto;
            cmd.Parameters["@D_Puesto"].Value = D_Puesto;
            cmd.Parameters["@B_Enfermera"].Value = B_Enfermeria;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Puesto = (Int16)p_K_Puesto.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Puesto()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Puesto";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Departamento(Int16 K_Departamento, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Departamento";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.SmallInt));

            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Departamento(Int32 K_Departamento, string D_Departamento, string Centro_Costos,string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Departamento";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Departamento", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Centro_Costos", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));

            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@D_Departamento"].Value = D_Departamento;
            cmd.Parameters["@Centro_Costos"].Value = Centro_Costos;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Departamento(ref Int32 K_Departamento, string D_Departamento, string Centro_Costos,string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Departamento";

            IDataParameter p_K_Departamento = new SqlParameter("@K_Departamento", SqlDbType.SmallInt);
            p_K_Departamento.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Departamento);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Departamento", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Centro_Costos", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));

            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@D_Departamento"].Value = D_Departamento;
            cmd.Parameters["@Centro_Costos"].Value = Centro_Costos;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Departamento = (Int16)p_K_Departamento.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Departamento()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Departamento";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //ENFERMERIA 
        public int Dl_Clasificacion_Servicios_Enfermeria(Int16 K_Clasificacion_Servicios_Enfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Clasificacion_Servicios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clasificacion_Servicios_Enfermeria;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Clasificacion_Servicios_Enfermeria(Int16 K_Clasificacion_Servicios_Enfermeria, string D_Clasificacion_Servicios_Enfermeria, string Descripcion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Clasificacion_Servicios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Clase_ServicioEnfermeria", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Servicio", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clasificacion_Servicios_Enfermeria;
            cmd.Parameters["@D_Clase_ServicioEnfermeria"].Value = D_Clasificacion_Servicios_Enfermeria;
            cmd.Parameters["@Descripcion_Servicio"].Value = Descripcion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Clasificacion_Servicios_Enfermeria(ref Int16 K_Clasificacion_Servicios_Enfermeria, string D_Clasificacion_Servicios_Enfermeria, string Descripcion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Clasificacion_Servicios_Enfermeria";

            IDataParameter p_K_Clasificacion_Servicios_Enfermeria = new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.SmallInt);
            p_K_Clasificacion_Servicios_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Clasificacion_Servicios_Enfermeria);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Clase_ServicioEnfermeria", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Servicio", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clasificacion_Servicios_Enfermeria;
            cmd.Parameters["@D_Clase_ServicioEnfermeria"].Value = D_Clasificacion_Servicios_Enfermeria;
            cmd.Parameters["@Descripcion_Servicio"].Value = Descripcion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Clasificacion_Servicios_Enfermeria = (Int16)p_K_Clasificacion_Servicios_Enfermeria.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Clasificacion_Servicios_Enfermeria()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clasificacion_Servicios_Enfermeria";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //
        public int Dl_Precios_Enfermeria(Int16 K_Precios_Enfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precios_Enfermeria;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Precios_Enfermeria(Int32 K_Precio_Enfermeria, Int16 K_Dias_Servicio, Int16 K_Clase_ServicioEnfermeria, Int16 K_Tipo_Servicio_Enfermeria, Int16 K_Duracion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Precios_Enfermeria(ref Int32 K_Precio_Enfermeria, Int16 K_Dias_Servicio, Int16 K_Clase_ServicioEnfermeria, Int16 K_Tipo_Servicio_Enfermeria, Int16 K_Duracion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Precios_Enfermeria";

            IDataParameter p_K_Precio_Enfermeria = new SqlParameter("@K_Precio_Enfermeria", SqlDbType.SmallInt);
            p_K_Precio_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_Enfermeria);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Precio_Enfermeria = (Int16)p_K_Precio_Enfermeria.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Precios_Enfermeria()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Enfermeria";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //
        public int Dl_Duracion_Servicio(Int16 K_Duracion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Duracion_Servicio";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Duracion_Servicio(Int16 K_Duracion_Servicio, Int32 Horas, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Duracion_Servicio";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Duracion_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Horas", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@Horas"].Value = Horas;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Duracion_Servicio(ref Int16 K_Duracion_Servicio, Int32 Horas, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Duracion_Servicio";

            IDataParameter p_K_Duracion_Servicio = new SqlParameter("@K_Duracion_Servicio", SqlDbType.SmallInt);
            p_K_Duracion_Servicio.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Duracion_Servicio);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Horas", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Duracion_Servicio"].Value = K_Duracion_Servicio;
            cmd.Parameters["@Horas"].Value = Horas;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Duracion_Servicio = (Int16)p_K_Duracion_Servicio.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Duracion_Servicio()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Duracion_Servicio";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        // AQUI
        public int Dl_Tipos_Servicios_Enfermeria(Int16 K_Tipos_Servicios_Enfermeria, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Servicios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipos_Servicios_Enfermeria;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipos_Servicios_Enfermeria(Int16 K_Tipos_Servicios_Enfermeria, string D_Tipos_Servicios_Enfermeria, string Descripcion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Servicios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Enfermeria", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Servicio", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipos_Servicios_Enfermeria;
            cmd.Parameters["@D_Tipo_Enfermeria"].Value = D_Tipos_Servicios_Enfermeria;
            cmd.Parameters["@Descripcion_Servicio"].Value = Descripcion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Tipos_Servicios_Enfermeria(ref Int16 K_Tipos_Servicios_Enfermeria, string D_Tipos_Servicios_Enfermeria, string Descripcion_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Servicios_Enfermeria";

            IDataParameter p_K_Tipos_Servicios_Enfermeria = new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.SmallInt);
            p_K_Tipos_Servicios_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipos_Servicios_Enfermeria);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Enfermeria", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Servicio", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));


            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipos_Servicios_Enfermeria;
            cmd.Parameters["@D_Tipo_Enfermeria"].Value = D_Tipos_Servicios_Enfermeria;
            cmd.Parameters["@Descripcion_Servicio"].Value = Descripcion_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipos_Servicios_Enfermeria = (Int16)p_K_Tipos_Servicios_Enfermeria.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Servicios_Enfermeria()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Tipos_Servicios_Enfermeria";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //
        public int Dl_Tipo_Moneda(Int16 K_Tipo_Moneda, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Moneda";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipo_Moneda(Int16 K_Tipo_Moneda, string D_Tipo_Moneda, decimal Tipo_Cambio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Moneda";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Moneda", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@D_Tipo_Moneda"].Value = D_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Tipo_Moneda(ref Int16 K_Tipo_Moneda, string D_Tipo_Moneda, decimal Tipo_Cambio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Moneda";

            IDataParameter p_K_Tipo_Moneda = new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt);
            p_K_Tipo_Moneda.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Moneda);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Moneda", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Decimal));


            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@D_Tipo_Moneda"].Value = D_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Moneda = (Int16)p_K_Tipo_Moneda.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipo_Moneda()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Moneda";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //Sk_Estatus_Compra

        public DataTable Sk_Estatus_Compra()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estatus_Compra";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Tipo_Iva(Int16 K_Tipo_Iva, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Iva";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Iva", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Iva"].Value = K_Tipo_Iva;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipo_Iva(Int16 K_Iva, string D_Iva, decimal Porcentaje, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Iva";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Iva", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Iva", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Iva"].Value = K_Iva;
            cmd.Parameters["@D_Iva"].Value = D_Iva;
            cmd.Parameters["@Porcentaje"].Value = Porcentaje;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Tipo_Iva(ref Int16 K_Iva, string D_Iva, decimal Porcentaje, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Iva";

            IDataParameter p_K_Iva = new SqlParameter("@K_Iva", SqlDbType.SmallInt);
            p_K_Iva.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Iva);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Iva", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje", SqlDbType.Decimal));


            cmd.Parameters["@K_Iva"].Value = K_Iva;
            cmd.Parameters["@D_Iva"].Value = D_Iva;
            cmd.Parameters["@Porcentaje"].Value = Porcentaje;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Iva = (Int16)p_K_Iva.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipo_Iva()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Iva";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //
        public int Dl_Grupos_Articulos(Int16 K_Grupo_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Grupos_Articulos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Grupo_Articulo", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Grupo_Articulo"].Value = K_Grupo_Articulo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Grupos_Articulos(Int16 K_Grupo_Articulo, string D_Grupo_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Grupos_Articulos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Grupo_Articulo", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Grupo_Articulo", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Grupo_Articulo"].Value = K_Grupo_Articulo;
            cmd.Parameters["@D_Grupo_Articulo"].Value = D_Grupo_Articulo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Grupos_Articulos(ref Int16 K_Grupo_Articulo, string D_Grupo_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Grupos_Articulos";

            IDataParameter p_K_Grupo_Articulo = new SqlParameter("@K_Grupo_Articulo", SqlDbType.SmallInt);
            p_K_Grupo_Articulo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Grupo_Articulo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Grupo_Articulo", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Grupo_Articulo"].Value = K_Grupo_Articulo;
            cmd.Parameters["@D_Grupo_Articulo"].Value = D_Grupo_Articulo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Grupo_Articulo = (Int16)p_K_Grupo_Articulo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Grupos_Articulos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Grupos_Articulos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //
        public int Dl_Categoria_Articulo(Int16 K_Categoria_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Categoria_Articulo";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Categoria_Articulo", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Baja", SqlDbType.SmallInt));

            cmd.Parameters["@K_Categoria_Articulo"].Value = K_Categoria_Articulo;
            cmd.Parameters["@K_Usuario_Baja"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Categoria_Articulo(Int16 K_Categoria_Articulo, string D_Categoria_Articulo, bool B_Requiere_Receta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Categoria_Articulo";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Categoria_Articulo", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Categoria_Articulo", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Receta", SqlDbType.Bit, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Categoria_Articulo"].Value = K_Categoria_Articulo;
            cmd.Parameters["@D_Categoria_Articulo"].Value = D_Categoria_Articulo;
            cmd.Parameters["@B_Requiere_Receta"].Value = B_Requiere_Receta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Categoria_Articulo(ref Int16 K_Categoria_Articulo, string D_Categoria_Articulo, bool B_Requiere_Receta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Categoria_Articulo";

            IDataParameter p_K_Categoria_Articulo = new SqlParameter("@K_Categoria_Articulo", SqlDbType.SmallInt);
            p_K_Categoria_Articulo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Categoria_Articulo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Categoria_Articulo", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Receta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Alta", SqlDbType.SmallInt));

            cmd.Parameters["@K_Categoria_Articulo"].Value = K_Categoria_Articulo;
            cmd.Parameters["@D_Categoria_Articulo"].Value = D_Categoria_Articulo;
            cmd.Parameters["@B_Requiere_Receta"].Value = B_Requiere_Receta;
            cmd.Parameters["@K_Usuario_Alta"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Categoria_Articulo = (Int16)p_K_Categoria_Articulo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Categoria_Articulo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Categoria_Articulo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //

        public int Dl_Dias_Servicio(Int16 K_Dias_Servicio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Dias_Servicio";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Dias_Servicio(Int16 K_Dias_Servicio, Int32 Dias, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Dias_Servicio";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Dias_Servicio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Dias", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@Dias"].Value = Dias;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Dias_Servicio(ref Int16 K_Dias_Servicio, Int32 Dias, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Dias_Servicio";

            IDataParameter p_K_Dias_Servicio = new SqlParameter("@K_Dias_Servicio", SqlDbType.SmallInt);
            p_K_Dias_Servicio.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Dias_Servicio);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Dias", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Dias_Servicio"].Value = K_Dias_Servicio;
            cmd.Parameters["@Dias"].Value = Dias;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Dias_Servicio = (Int16)p_K_Dias_Servicio.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Dias_Servicio()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Dias_Servicio";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //EMPLEADO

        public int Dl_empleado(Int32 K_Empleado, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_empleado";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));

            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_empleado(Int32 K_Empleado, bool B_DarBaja, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_empleado";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_DarBaja", SqlDbType.Bit));

            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@B_DarBaja"].Value = B_DarBaja;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Empleado(Int32 K_Empleado, string D_Empleado, string RFC, Int32 K_Oficina, Int16 K_Puesto, Int16 K_Departamento, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, string Colonia, string Calle, Int32 Codigo_Postal, string Telefono, string Numero_Nomina, string Numero_SeguroSocial, Int32 K_Usuario, Int32 K_Empresa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Empleado";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Empleado", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Puesto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Colonia", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Numero_Nomina", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Numero_SeguroSocial", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@D_Empleado"].Value = D_Empleado;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Puesto"].Value = K_Puesto;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@Colonia"].Value = Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Numero_Nomina"].Value = Numero_Nomina;
            cmd.Parameters["@Numero_SeguroSocial"].Value = Numero_SeguroSocial;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Empleado(ref Int32 K_Empleado, string D_Empleado, string RFC, Int32 K_Oficina, Int16 K_Puesto, Int16 K_Departamento, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, string Colonia, string Calle, Int32 Codigo_Postal, string Telefono, string Numero_Nomina, string Numero_SeguroSocial, Int32 K_Usuario, Int32 K_Empresa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Empleado";

            IDataParameter p_K_Empleado = new SqlParameter("@K_Empleado", SqlDbType.Int);
            p_K_Empleado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Empleado);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Empleado", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Puesto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Colonia", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Numero_Nomina", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Numero_SeguroSocial", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@D_Empleado"].Value = D_Empleado;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Puesto"].Value = K_Puesto;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@Colonia"].Value = Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Numero_Nomina"].Value = Numero_Nomina;
            cmd.Parameters["@Numero_SeguroSocial"].Value = Numero_SeguroSocial;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Empleado = (Int32)p_K_Empleado.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Empleado(Int32 K_Empleado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Empleado";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Empleado()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_empleado";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //OFICINA
        public int In_oficina(ref Int32 K_Oficina, string D_Oficina, string C_Oficina, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 Colonia, string Calle, string NumExterior, string NumInterior, Int32 Codigo_Postal, string Telefono, string Telefono2, string Fax, Int32 K_Jefe_Oficina, string Centro_Costos, bool B_Frontera,
                   bool B_Sucursal, bool B_Servicio_SOS, DateTime Horario_Inicial, DateTime Horario_FInal, Int32 K_Empresa, string Latitud, string Longitud, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Oficina";

            IDataParameter p_K_Oficina = new SqlParameter("@K_Oficina", SqlDbType.Int);
            p_K_Oficina.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Oficina);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Oficina", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Oficina", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@NumExterior", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@NumInterior", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Telefono2", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Jefe_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Centro_Costos", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@B_Frontera", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Sucursal", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Servicio_SOS", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Horario_Inicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@Horario_Final", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Longitud", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Latitud", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@D_Oficina"].Value = D_Oficina;
            cmd.Parameters["@C_Oficina"].Value = C_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@NumExterior"].Value = NumExterior;
            cmd.Parameters["@NumInterior"].Value = NumInterior;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Telefono2"].Value = Telefono2;
            cmd.Parameters["@Fax"].Value = Fax;
            cmd.Parameters["@K_Jefe_Oficina"].Value = K_Jefe_Oficina;
            cmd.Parameters["@Centro_Costos"].Value = Centro_Costos;
            cmd.Parameters["@B_Frontera"].Value = B_Frontera;
            cmd.Parameters["@B_Sucursal"].Value = B_Sucursal;
            cmd.Parameters["@B_Servicio_SOS"].Value = B_Servicio_SOS;
            cmd.Parameters["@Horario_Inicial"].Value = Horario_Inicial;
            cmd.Parameters["@Horario_Final"].Value = Horario_FInal;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@Latitud"].Value = Latitud;
            cmd.Parameters["@Longitud"].Value = Longitud;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Oficina = (Int32)p_K_Oficina.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Oficina(Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Oficina";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_oficina(Int32 K_Oficina, bool B_DarBaja, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_oficina";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_DarBaja", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@B_DarBaja"].Value = B_DarBaja;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Oficina(Int32 K_Oficina, string D_Oficina, string C_Oficina, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 Colonia, string Calle, string NumExterior, string NumInterior, Int32 Codigo_Postal, string Telefono, string Telefono2, string Fax, Int32 K_Jefe_Oficina, string Centro_Costos, bool B_Frontera,
                   bool B_Sucursal, bool B_Servicio_SOS, DateTime Horario_Inicial, DateTime Horario_FInal, Int32 K_Empresa, string Latitud, string Longitud, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Oficina";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Oficina", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Oficina", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@NumExterior", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@NumInterior", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Telefono2", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Jefe_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Centro_Costos", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@B_Frontera", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Sucursal", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Servicio_SOS", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Horario_Inicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@Horario_Final", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Longitud", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Latitud", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@D_Oficina"].Value = D_Oficina;
            cmd.Parameters["@C_Oficina"].Value = C_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@NumExterior"].Value = NumExterior;
            cmd.Parameters["@NumInterior"].Value = NumInterior;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Telefono2"].Value = Telefono2;
            cmd.Parameters["@Fax"].Value = Fax;
            cmd.Parameters["@K_Jefe_Oficina"].Value = K_Jefe_Oficina;
            cmd.Parameters["@Centro_Costos"].Value = Centro_Costos;
            cmd.Parameters["@B_Frontera"].Value = B_Frontera;
            cmd.Parameters["@B_Sucursal"].Value = B_Sucursal;
            cmd.Parameters["@B_Servicio_SOS"].Value = B_Servicio_SOS;
            cmd.Parameters["@Horario_Inicial"].Value = Horario_Inicial;
            cmd.Parameters["@Horario_Final"].Value = Horario_FInal;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@Latitud"].Value = Latitud;
            cmd.Parameters["@Longitud"].Value = Longitud;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Oficina()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Oficina";
            cmd.CommandTimeout = 0;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Oficina(Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Oficina";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            if(K_Empresa == 0)
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
        //TEMPERATURA
        public int In_Temperatura(ref Int32 K_Temperatura, string D_Temperatura, Int32 Inicial, Int32 Final, Int32 K_Usuario_Alta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Temperatura";

            IDataParameter p_K_Temperatura = new SqlParameter("@K_Temperatura", SqlDbType.Int);
            p_K_Temperatura.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Temperatura);

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Temperatura", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Inicial", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Final", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Alta", SqlDbType.Int));

            cmd.Parameters["@K_Temperatura"].Value = K_Temperatura;
            cmd.Parameters["@D_Temperatura"].Value = D_Temperatura;
            cmd.Parameters["@Inicial"].Value = Inicial;
            cmd.Parameters["@Final"].Value = Final;
            cmd.Parameters["@K_Usuario_Alta"].Value = K_Usuario_Alta;

            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Temperatura = (Int32)p_K_Temperatura.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Temperatura(Int32 K_Temperatura, string D_Temperatura, Int32 Inicial, Int32 Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Temperatura";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Temperatura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Temperatura", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Inicial", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Final", SqlDbType.Int));


            cmd.Parameters["@K_Temperatura"].Value = K_Temperatura;
            cmd.Parameters["@D_Temperatura"].Value = D_Temperatura;
            cmd.Parameters["@Inicial"].Value = Inicial;
            cmd.Parameters["@Final"].Value = Final;


            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Temperatura(Int32 K_Temperatura, Int32 K_Usuario_Baja, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Temperatura";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Temperatura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Temperatura"].Value = K_Temperatura;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario_Baja;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Temperatura()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Temperatura";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        //UNIDAD DE MEDIDA
        public DataTable Sk_Unidad_Medida()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Unidad_Medida";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Unidad_Medida(ref Int32 K_Unidad_Medida, string D_Unidad_Medida, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Unidad_Medida";

            IDataParameter p_K_Unidad_Medida = new SqlParameter("@K_Unidad_Medida", SqlDbType.Int);
            p_K_Unidad_Medida.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Unidad_Medida);

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Unidad_Medida", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Unidad_Medida"].Value = K_Unidad_Medida;
            cmd.Parameters["@D_Unidad_Medida"].Value = D_Unidad_Medida;


            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Unidad_Medida = (Int32)p_K_Unidad_Medida.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Unidad_Medida(Int32 K_Unidad_Medida, string D_Unidad_Medida, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Unidad_Medida";



            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Unidad_Medida", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Unidad_Medida", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Unidad_Medida"].Value = K_Unidad_Medida;
            cmd.Parameters["@D_Unidad_Medida"].Value = D_Unidad_Medida;


            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);


            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Unidad_Medida(Int32 K_Unidad_Medida, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Unidad_Medida";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Unidad_Medida", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Unidad_Medida"].Value = K_Unidad_Medida;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //SUSTANCIA ACTIVA
        public DataTable Sk_Sustancia_Activa()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Sustancia_Activa";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Sustancia_Activa(ref Int32 K_Sustancia_Activa, string D_Sustancia_Activa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Sustancia_Activa";

            IDataParameter p_K_Sustancia_Activa = new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int);
            p_K_Sustancia_Activa.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Sustancia_Activa);

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Sustancia_Activa", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@D_Sustancia_Activa"].Value = D_Sustancia_Activa;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;


            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Sustancia_Activa = (Int32)p_K_Sustancia_Activa.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Sustancia_Activa(Int32 K_Sustancia_Activa, string D_Sustancia_Activa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Sustancia_Activa";

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Sustancia_Activa", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            cmd.Parameters["@D_Sustancia_Activa"].Value = D_Sustancia_Activa;

            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Sustancia_Activa(Int32 K_Sustancia_Activa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Sustancia_Activa";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //FAMILIA ARTICULOS

        public DataTable Sk_Familia_Articulo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Familia_Articulo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Famila_Articulo(ref Int32 K_Familia_Articulo, string D_Familia, bool B_Requiere_Autorizacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Familia_Articulo";

            IDataParameter p_K_Familia_Articulo = new SqlParameter("@K_Familia_Articulo", SqlDbType.Int);
            p_K_Familia_Articulo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Familia_Articulo);

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Alta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Familia", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Autorizacion", SqlDbType.Bit));
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Usuario_Alta"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@D_Familia"].Value = D_Familia;
            cmd.Parameters["@B_Requiere_Autorizacion"].Value = B_Requiere_Autorizacion;


            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Familia_Articulo = (Int32)p_K_Familia_Articulo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Familia_Articulos(Int32 K_Familia_Articulo, string D_Familia, bool B_Requiere_Autorizacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Familia_Articulo";



            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Familia", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Autorizacion", SqlDbType.Bit));
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@D_Familia"].Value = D_Familia;
            cmd.Parameters["@B_Requiere_Autorizacion"].Value = B_Requiere_Autorizacion;

            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);


            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Familia_Articulos(Int32 K_Familia_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Familia_Articulo";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Baja", SqlDbType.Int));

            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Usuario_Baja"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        //COBERTURAS 
        //public DataTable Sk_Zonificacion_Local_AmbulanciaAsig(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado)
        //{
        //    SqlCommand cmd = ConnectionClass.GetCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "Sk_Zonificacion_Local_Ambulancia";
        //    DataTable dt = new DataTable();

        //    IDataParameter p_K_Oficina = new SqlParameter("@K_Oficina", SqlDbType.Int);
        //    p_K_Oficina.Direction = ParameterDirection.InputOutput;
        //    cmd.Parameters.Add(p_K_Oficina);

        //    IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);
        //    p_K_Pais.Direction = ParameterDirection.InputOutput;
        //    cmd.Parameters.Add(p_K_Pais);

        //    IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
        //    p_K_Estado.Direction = ParameterDirection.InputOutput;
        //    cmd.Parameters.Add(p_K_Estado);

        //    cmd.Parameters["@K_Oficina"].Value = K_Oficina;
        //    cmd.Parameters["@K_Pais"].Value = K_Pais;
        //    cmd.Parameters["@K_Estado"].Value = K_Estado;
        //    dt = ConnectionClass.GetTable(ref cmd);

        //    K_Oficina = (Int32)p_K_Oficina.Value;
        //    K_Pais = (Int32)p_K_Pais.Value;
        //    K_Estado = (Int32)p_K_Estado.Value;
        //}

        public DataTable Sk_Ciudades_Disp_Local(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudades_Disp_Local";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }


        public int In_Zonificacion_Local_Ambulancia(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "in_Zonificacion_Local_Ambulancia";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }



        public int Dl_Zonificacion_Local_Ambulancia(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Local_Ambulancia";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }
        public DataTable SK_Zonificacion_Foranea_Ambulancia(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Zonificacion_Foranea_Ambulancia";
            DataTable dt = new DataTable();

            IDataParameter p_K_Oficina = new SqlParameter("@K_Oficina", SqlDbType.Int);
            p_K_Oficina.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Oficina);

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);
            p_K_Pais.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            dt = ConnectionClass.GetTable(ref cmd);

            K_Oficina = (Int32)p_K_Oficina.Value;
            K_Pais = (Int32)p_K_Pais.Value;
            K_Estado = (Int32)p_K_Estado.Value;

            return dt;
        }

        public DataTable Sk_Ciudades_Disp_Foranea(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudades_Disp_Foranea";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            //cmd.Parameters.Add(new SqlParameter("@Orden", SqlDbType.VarChar, 256));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            //cmd.Parameters["@Orden"].Value = Orden;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }


        public int In_Zonificacion_Foranea_Ambulancia(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Foranea_Ambulancia";

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



        public int Dl_Zonificacion_Foranea_Ambulancia(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Foranea_Ambulancia";

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
        // ZONFICACION ENFERMERIA
        public DataTable SK_Zonificacion_Local_Enfermeria(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Zonificacion_Local_Enfermeria";
            DataTable dt = new DataTable();

            IDataParameter p_K_Ciudad = new SqlParameter("@K_Ciudad", SqlDbType.Int);
            p_K_Ciudad.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Ciudad);

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);
            p_K_Pais.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            IDataParameter p_K_Colonia = new SqlParameter("@K_Colonia", SqlDbType.Int);
            p_K_Colonia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Colonia);

            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            dt = ConnectionClass.GetTable(ref cmd);

            K_Ciudad = (Int32)p_K_Ciudad.Value;
            K_Pais = (Int32)p_K_Pais.Value;
            K_Estado = (Int32)p_K_Estado.Value;
            K_Colonia = (Int32)p_K_Colonia.Value;

            return dt;
        }
        public DataTable SK_Zonificacion_Local_Enfermeria_Asig(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Zonificacion_Local_Enfermeria_Asig";
            DataTable dt = new DataTable();

            IDataParameter p_K_Oficina = new SqlParameter("@K_Oficina", SqlDbType.Int);
            p_K_Oficina.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Oficina);

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);
            p_K_Pais.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            IDataParameter p_K_Ciudad = new SqlParameter("@K_Ciudad", SqlDbType.Int);
            p_K_Ciudad.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Ciudad);

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            dt = ConnectionClass.GetTable(ref cmd);

            K_Oficina = (Int32)p_K_Oficina.Value;
            K_Pais = (Int32)p_K_Pais.Value;
            K_Estado = (Int32)p_K_Estado.Value;
            K_Ciudad = (Int32)p_K_Ciudad.Value;
            return dt;
        }


        public DataTable Sk_Ciudades_Disp_LocalEnfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudades_Disp_LocalEnfermeria";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }


        public int In_Zonificacion_Local_Enfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "in_Zonificacion_Local_Enfermeria";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }



        public int Dl_Zonificacion_Local_Enfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Local_Enfermeria";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }
        public DataTable SK_Zonificacion_Foranea_Enfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Zonificacion_Foranea_Enfermeria";
            DataTable dt = new DataTable();

            IDataParameter p_K_Oficina = new SqlParameter("@K_Oficina", SqlDbType.Int);
            p_K_Oficina.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Oficina);

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);
            p_K_Pais.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            dt = ConnectionClass.GetTable(ref cmd);

            K_Oficina = (Int32)p_K_Oficina.Value;
            K_Pais = (Int32)p_K_Pais.Value;
            K_Estado = (Int32)p_K_Estado.Value;

            return dt;
        }

        public DataTable Sk_Ciudades_Disp_ForaneaEnfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ciudades_Disp_ForaneaEnfermeria";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            //cmd.Parameters.Add(new SqlParameter("@Orden", SqlDbType.VarChar, 256));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            //cmd.Parameters["@Orden"].Value = Orden;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }


        public int In_Zonificacion_Foranea_Enfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Foranea_Enfermeria";

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



        public int Dl_Zonificacion_Foranea_Enfermeria(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Usuario_Bitacora, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Foranea_Enfermeria";

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
        //PRECIOS AMBULANCIA
        public DataTable Sk_Precios_Ambulancia()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Ambulancias";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Precios_Ambulancia(ref Int32 K_Precio_Ambulancia, bool B_Sencillo, bool B_Local, bool B_Oxigeno, bool B_Segundo_Piso, int K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Precios_Ambulancias";

            IDataParameter p_K_Precio_Ambulancia = new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int);
            p_K_Precio_Ambulancia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_Ambulancia);

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@B_Sencillo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Oxigeno", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Segundo_Piso", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@B_Sencillo"].Value = B_Sencillo;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@B_Oxigeno"].Value = B_Oxigeno;
            cmd.Parameters["@B_Segundo_Piso"].Value = B_Segundo_Piso;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Precio_Ambulancia = (Int32)p_K_Precio_Ambulancia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Precios_Ambulancia(Int32 K_Precio_Ambulancia, bool B_Sencillo, bool B_Local, bool B_Oxigeno, bool B_Segundo_Piso, int K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Precios_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Sencillo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Local", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Oxigeno", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Segundo_Piso", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@B_Sencillo"].Value = B_Sencillo;
            cmd.Parameters["@B_Local"].Value = B_Local;
            cmd.Parameters["@B_Oxigeno"].Value = B_Oxigeno;
            cmd.Parameters["@B_Segundo_Piso"].Value = B_Segundo_Piso;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;



            cmd.Parameters["pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);


            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Precios_Ambulancia(Int32 K_Precio_Ambulancia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Precios_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        //ZONIFICACION LOCAL PRECIOS AMBULANCIA
        public int In_Zonificacion_Local_Precios_Ambulancias(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, Int32 K_Colonia, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Local_Precios_Ambulancias";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
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
        public int Up_Zonificacion_Local_Precios_Ambulancias(Int16 K_Precio_Local_Ambulancias, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Colonia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_Local_Precios_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Local_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Local_Ambulancia"].Value = K_Precio_Local_Ambulancias;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
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
        public int Dl_Zonificacion_Local_Precios_Ambulancias(Int16 K_Precio_Local_Ambulancias, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Local_Precios_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Local_Ambulancia", SqlDbType.Int));

            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Precio_Local_Ambulancia"].Value = K_Precio_Local_Ambulancias;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_Precios_Ambulancia()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Precios_AMbulancia";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_Local_Precios_Ambulancias()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Local_Precios_Ambulancias";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_Local_Ambulancia(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Local_Ambulancia";
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
        public DataTable SK_Zonificacion_Local_Precios_Ambulancias(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, Int32 K_Colonia, DateTime FechaInicial, DateTime FechaFinal)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Local_Precios_Ambulancias";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;



        }

        public DataTable SK_Zonificacion_Local_Ambulancia(Int32 K_Oficina, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Zonificacion_Local_Ambulancia";
            DataTable dt = new DataTable();

            IDataParameter p_K_Oficina = new SqlParameter("@K_Oficina", SqlDbType.Int);
            p_K_Oficina.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Oficina);

            IDataParameter p_K_Pais = new SqlParameter("@K_Pais", SqlDbType.Int);
            p_K_Pais.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pais);

            IDataParameter p_K_Estado = new SqlParameter("@K_Estado", SqlDbType.Int);
            p_K_Estado.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado);

            IDataParameter p_K_Ciudad = new SqlParameter("@K_Ciudad", SqlDbType.Int);
            p_K_Ciudad.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Ciudad);

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            dt = ConnectionClass.GetTable(ref cmd);

            K_Oficina = (Int32)p_K_Oficina.Value;
            K_Pais = (Int32)p_K_Pais.Value;
            K_Estado = (Int32)p_K_Estado.Value;
            K_Ciudad = (Int32)p_K_Ciudad.Value;
            return dt;
        }

        //ZONIFICACION FORANEA PRECIOS AMBULANCIA

        public int In_Zonificacion_Foranea_Precios_Ambulancias(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Foranea_Precios_Ambulancias";

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
        public int Up_Zonificacion_Foranea_Precios_Ambulancias(Int16 K_Precio_Foraneo_Ambulancia, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_Foranea_Precios_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Foraneo_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Foraneo_Ambulancia"].Value = K_Precio_Foraneo_Ambulancia;
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
        public int Dl_Zonificacion_Foranea_Precios_Ambulancias(Int16 K_Precio_Foraneo_Ambulancias, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Foranea_Precios_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Foraneo_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Foraneo_Ambulancia"].Value = K_Precio_Foraneo_Ambulancias;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //PARA MOSTRAR LOS PRECIOS DE AMBULANCIA O LAS CARACTERISTICAS
        //USO EL Gp_Precios_Ambulancia de ZONIFICACION LOCAL PRECIOS AMBULANCIA

        public DataTable Sk_Zonificacion_Foranea_Precios_Ambulancias()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Foranea_Precios_Ambulancias";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_Foranea_Ambulancia(Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Foranea_Ambulancia";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable SK_Zonificacion_Foranea_Precios_Ambulancias(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, DateTime FechaInicial, DateTime FechaFinal)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Foranea_Precios_Ambulancias";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;



        }

        //PRECIOS ENFERMERIA
        public int In_Zonificacion_Local_Precios_Enfermeria(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, Int32 K_Colonia, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Local_Precios_Enfermeria";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
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

        public int Up_Zonificacion_Local_Precios_Enfermeria(Int16 K_Precio_Local_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Colonia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_Local_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Local_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Local_Enfermeria"].Value = K_Precio_Local_Enfermeria;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
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


        public int Dl_Zonificacion_Local_Precios_Enfermeria(Int16 K_Precio_Local_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Local_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Local_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Precio_Local_Enfermeria"].Value = K_Precio_Local_Enfermeria;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Zonificacion_Local_Precios_Enfermeria()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Local_Precios_Enfermeria";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable SK_Zonificacion_Local_Precios_Enfermeria(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, Int32 K_Colonia, DateTime FechaInicial, DateTime FechaFinal)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Local_Precios_Enfermeria";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        //PRECIOS ENFERMERIA
        public int In_Zonificacion_Foranea_Precios_Enfermeria(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_Foranea_Precios_Enfermeria";

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
        public int Up_Zonificacion_Foranea_Precios_Enfermeria(Int16 K_Precio_Local_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_Foranea_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Foraneo_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Foraneo_Enfermeria"].Value = K_Precio_Local_Enfermeria;
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
        public int Dl_Zonificacion_Foranea_Precios_Enfermeria(Int16 K_Precio_Foraneo_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_Foranea_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Foraneo_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Precio_Foraneo_Enfermeria"].Value = K_Precio_Foraneo_Enfermeria;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Zonificacion_Foranea_Precios_Enfermeria()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Foranea_Precios_Enfermeria";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable SK_Zonificacion_Foranea_Precios_Enfermeria(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, DateTime FechaInicial, DateTime FechaFinal)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_Foranea_Precios_Enfermeria";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        //
        public int In_Zonificacion_LPAmbulancia_Aseg(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, Int32 K_Colonia, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_LPAmbulancia_Aseg";

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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
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
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
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
        public int Up_Zonificacion_LPAmbulancia_Aseg(Int16 K_Precio_Local_AmbAseg, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_LPAmbulancia_Aseg";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Local_AmbAseg", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Local_AmbAseg"].Value = K_Precio_Local_AmbAseg;
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
        public int Dl_Zonificacion_LPAmbulancia_Aseg(Int16 K_Precio_Local_AmbAseg, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_LPAmbulancia_Aseg";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Local_AmbAseg", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Local_AmbAseg"].Value = K_Precio_Local_AmbAseg;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Zonificacion_LPAmbulancia_Aseg()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_LPAmbulancia_Aseg";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_LPAmbulancia_Aseg(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, DateTime FechaInicial, DateTime FechaFinal, int K_Aseguradora)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_LPAmbulancia_Aseg";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;



        }


        //ZONIFICACION FORANEA PRECIOS AMBULANCIA ASEGURADORA
        public int In_Zonificacion_FPAmbulancia_Aseg(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_FPAmbulancia_Aseg";

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
        public int Up_Zonificacion_FPAmbulancia_Aseg(Int16 K_Precio_Foraneo_AmbAseg, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_FPAmbulancia_Aseg";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Foraneo_AmbAseg", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Foraneo_AmbAseg"].Value = K_Precio_Foraneo_AmbAseg;
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
        public int Dl_Zonificacion_FPAmbulancia_Aseg(Int16 K_Precio_Foraneo_AmbAseg, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Zonificacion_FPAmbulancia_Aseg";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_Foraneo_AmbAseg", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Precio_Foraneo_AmbAseg"].Value = K_Precio_Foraneo_AmbAseg;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Zonificacion_FPAmbulancia_Aseg()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_FPAmbulancia_Aseg";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_FPAmbulancia_Aseg(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, Int32 K_Oficina, DateTime FechaInicial, DateTime FechaFinal, int K_Aseguradora)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_FPAmbulancia_Aseg";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Precio_Ambulancia"].Value = K_Precio_Ambulancia;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;

        }
        //BANCOS
        public int In_Bancos(ref Int16 K_Banco, string D_Banco, string C_Banco,string RfcBanco, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Bancos";

            IDataParameter p_K_Banco = new SqlParameter("@K_Banco", SqlDbType.SmallInt);
            p_K_Banco.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Banco);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Banco", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Banco", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@RfcBanco", SqlDbType.VarChar,30));

            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@D_Banco"].Value = D_Banco;
            cmd.Parameters["@C_Banco"].Value = C_Banco;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@RfcBanco"].Value = RfcBanco;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Banco = (Int16)p_K_Banco.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Bancos(Int16 K_Banco, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Bancos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Bancos(Int16 K_Banco, string D_Banco, string C_Banco, string RfcBanco, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Bancos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Banco", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Banco", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@RfcBanco", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@D_Banco"].Value = D_Banco;
            cmd.Parameters["@C_Banco"].Value = C_Banco;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@RfcBanco"].Value = RfcBanco;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Bancos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Bancos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        //TIPO FISCAL
        public int In_Tipo_Fiscal(ref Int16 K_Tipo_Fiscal, string D_Tipo_Fiscal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Fiscal";

            IDataParameter p_K_Tipo_Fiscal = new SqlParameter("@K_Tipo_Fiscal", SqlDbType.SmallInt);
            p_K_Tipo_Fiscal.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Fiscal);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Fiscal", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@D_Tipo_Fiscal"].Value = D_Tipo_Fiscal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Fiscal = (Int16)p_K_Tipo_Fiscal.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Tipo_Fiscal(Int16 K_Tipo_Fiscal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Fiscal";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipo_Fiscal(Int16 K_Tipo_Fiscal, string D_Tipo_Fiscal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Fiscal";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Fiscal", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@D_Tipo_Fiscal"].Value = D_Tipo_Fiscal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipo_Fiscal()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Fiscal";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        // DOCUMENTOS REQUERIDOS
        public int In_Documentos_Requeridos(ref Int16 K_Documentos_Requeridos, string D_Documento, Boolean B_Aplica_Proveedor, Boolean B_Aplica_Aseguradora, Boolean B_Requisito, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Documentos_Requeridos";

            IDataParameter p_K_Documentos_Requeridos = new SqlParameter("@K_Documentos_Requeridos", SqlDbType.SmallInt);
            p_K_Documentos_Requeridos.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Documentos_Requeridos);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Documento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Proveedor", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Aseguradora", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Requisito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Documentos_Requeridos"].Value = K_Documentos_Requeridos;
            cmd.Parameters["@D_Documento"].Value = D_Documento;
            cmd.Parameters["@B_Aplica_Proveedor"].Value = B_Aplica_Proveedor;
            cmd.Parameters["@B_Aplica_Aseguradora"].Value = B_Aplica_Aseguradora;
            cmd.Parameters["@B_Requisito"].Value = B_Requisito;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Documentos_Requeridos = (Int16)p_K_Documentos_Requeridos.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Documentos_Requeridos(Int16 K_Documentos_Requeridos, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Documentos_Requeridos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Documentos_Requeridos", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Documentos_Requeridos"].Value = K_Documentos_Requeridos;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Documentos_Requeridos(Int16 K_Documentos_Requeridos, string D_Documento, Boolean B_Aplica_Proveedor, Boolean B_Aplica_Aseguradora, Boolean B_Requisito, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Documentos_Requeridos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Documentos_Requeridos", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Documento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Proveedor", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Aseguradora", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Requisito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Documentos_Requeridos"].Value = K_Documentos_Requeridos;
            cmd.Parameters["@D_Documento"].Value = D_Documento;
            cmd.Parameters["@B_Aplica_Proveedor"].Value = B_Aplica_Proveedor;
            cmd.Parameters["@B_Aplica_Aseguradora"].Value = B_Aplica_Aseguradora;
            cmd.Parameters["@B_Requisito"].Value = B_Requisito;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Documentos_Requeridos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Documentos_Requeridos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //TIPOS CONTACTO
        public int In_Tipos_Contacto(ref Int16 K_Tipo_Contacto, string D_Tipo_Contacto, Boolean B_Proveedor, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Contacto";

            IDataParameter p_K_Tipos_Contacto = new SqlParameter("@K_Tipo_Contacto", SqlDbType.SmallInt);
            p_K_Tipos_Contacto.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipos_Contacto);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Contacto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Proveedor", SqlDbType.Bit));

            cmd.Parameters["@K_Tipo_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@D_Tipo_Contacto"].Value = D_Tipo_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@B_Proveedor"].Value = B_Proveedor;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Contacto = (Int16)p_K_Tipos_Contacto.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Tipos_Contacto(Int16 K_Tipo_Contacto, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Contacto";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipos_Contacto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipos_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipos_Contacto(Int16 K_Tipo_Contacto, string D_Tipo_Contacto, Boolean B_Proveedor, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Contacto";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Contacto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Proveedor", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@D_Tipo_Contacto"].Value = D_Tipo_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@B_Proveedor"].Value = B_Proveedor;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Contacto(Boolean B_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Contacto";
            cmd.Parameters.Add(new SqlParameter("@B_Proveedor", SqlDbType.Bit));
            cmd.Parameters["@B_Proveedor"].Value = B_Proveedor;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Tipos_Contacto()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Contacto";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //LABORATORIO
        public int In_Laboratorio(ref Int16 K_Laboratorio, string D_Laboratorio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Laboratorio";

            IDataParameter p_K_Laboratorio = new SqlParameter("@K_Laboratorio", SqlDbType.SmallInt);
            p_K_Laboratorio.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Laboratorio);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Laboratorio", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@D_Laboratorio"].Value = D_Laboratorio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Laboratorio = (Int16)p_K_Laboratorio.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Laboratorio(Int16 K_Laboratorio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Laboratorio";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Laboratorio(Int16 K_Laboratorio, string D_Laboratorio, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Laboratorio";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Laboratorio", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@D_Laboratorio"].Value = D_Laboratorio;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Laboratorio()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Laboratorio";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //PRESENTACIONES 
        public int In_Presentaciones(ref Int16 K_Presentacion, string D_Presentacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Presentaciones";

            IDataParameter p_K_Presentacion = new SqlParameter("@K_Presentacion", SqlDbType.SmallInt);
            p_K_Presentacion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Presentacion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Presentacion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Presentacion"].Value = K_Presentacion;
            cmd.Parameters["@D_Presentacion"].Value = D_Presentacion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Presentacion = (Int16)p_K_Presentacion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Presentaciones(Int16 K_Presentacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Presentaciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Presentacion", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Presentacion"].Value = K_Presentacion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Presentaciones(Int16 K_Presentacion, string D_Presentacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Presentaciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Presentacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Presentacion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Presentacion"].Value = K_Presentacion;
            cmd.Parameters["@D_Presentacion"].Value = D_Presentacion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Presentaciones()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Presentaciones";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //TIPOS PRODUCTOS
        public int In_Tipos_Productos(ref Int16 K_Tipo_Producto, string D_Tipo_Producto, Boolean B_Requiere_Inventario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Productos";

            IDataParameter p_K_Tipo_Producto = new SqlParameter("@K_Tipo_Producto", SqlDbType.SmallInt);
            p_K_Tipo_Producto.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Producto);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Producto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Inventario", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Alta", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Producto"].Value = K_Tipo_Producto;
            cmd.Parameters["@D_Tipo_Producto"].Value = D_Tipo_Producto;
            cmd.Parameters["@B_Requiere_Inventario"].Value = B_Requiere_Inventario;
            cmd.Parameters["@K_Usuario_Alta"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Producto = (Int16)p_K_Tipo_Producto.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Tipos_Productos(Int16 K_Tipo_Producto, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Productos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Producto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Producto"].Value = K_Tipo_Producto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipos_Productos(Int16 K_Tipo_Producto, string D_Tipo_Producto, Boolean B_Requiere_Inventario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Productos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Producto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Producto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Inventario", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Producto"].Value = K_Tipo_Producto;
            cmd.Parameters["@D_Tipo_Producto"].Value = D_Tipo_Producto;
            cmd.Parameters["@B_Requiere_Inventario"].Value = B_Requiere_Inventario;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Productos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Productos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //CLASE ARTICULO
        public int In_Clase(ref Int16 K_Clase, string D_Clase, Boolean B_Requiere_Receta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Clase";

            IDataParameter p_K_Clase = new SqlParameter("@K_Clase", SqlDbType.SmallInt);
            p_K_Clase.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Clase);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Clase", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Receta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Clase"].Value = K_Clase;
            cmd.Parameters["@D_Clase"].Value = D_Clase;
            cmd.Parameters["@B_Requiere_Receta"].Value = B_Requiere_Receta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Clase = (Int16)p_K_Clase.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Clase(Int16 K_Clase, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Clase";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Clase", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Clase"].Value = K_Clase;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Clase(Int16 K_Clase, string D_Clase, Boolean B_Requiere_Receta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Clase";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Clase", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Clase", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Receta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Clase"].Value = K_Clase;
            cmd.Parameters["@D_Clase"].Value = D_Clase;
            cmd.Parameters["@B_Requiere_Receta"].Value = B_Requiere_Receta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Clase()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clase";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //PROVEEDORES



        public int In_Proveedores(ref Int32 K_Proveedor, int K_Tipo_Fiscal, string D_Proveedor, string C_Proveedor, Int16 K_Pais, string RFC, Int32 K_Estado, Int32 K_Ciudad,
            Int32 K_Colonia, string Calle, string Numero_Exterior, String Numero_Interior, Int32 Codigo_Postal, DateTime F_Alta, DateTime F_Baja, bool B_Otorga_Credito, int Dias_Credito, decimal Monto_Credito, bool B_Acepta_Devoluciones,
            bool B_Autorizado, bool B_Rechazado, string Observaciones,bool B_SOS, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Proveedores";

            IDataParameter p_K_Proveedor = new SqlParameter("@K_Proveedor", SqlDbType.Int);
            p_K_Proveedor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Proveedor);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Proveedor", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Proveedor", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 13));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Numero_Exterior", SqlDbType.VarChar,50));

            if (Numero_Interior != "")
            {
                cmd.Parameters.Add(new SqlParameter("@Numero_Interior", SqlDbType.VarChar));
            }

            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Alta", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Baja", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Otorga_Credito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Dias_Credito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Credito", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@B_Acepta_Devoluciones", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Rechazado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_SOS", SqlDbType.Bit));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@D_Proveedor"].Value = D_Proveedor;
            cmd.Parameters["@C_Proveedor"].Value = C_Proveedor;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@Numero_Exterior"].Value = Numero_Exterior;
            if (Numero_Interior != "")
            {
                cmd.Parameters["@Numero_Interior"].Value = Numero_Interior;
            }
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@F_Alta"].Value = F_Alta;
            cmd.Parameters["@F_Baja"].Value = F_Baja;
            cmd.Parameters["@B_Otorga_Credito"].Value = B_Otorga_Credito;
            cmd.Parameters["@Dias_Credito"].Value = Dias_Credito;
            cmd.Parameters["@Monto_Credito"].Value = Monto_Credito;
            cmd.Parameters["@B_Acepta_Devoluciones"].Value = B_Acepta_Devoluciones;
            cmd.Parameters["@B_Autorizado"].Value = B_Autorizado;
            cmd.Parameters["@B_Rechazado"].Value = B_Rechazado;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@B_SOS"].Value = B_SOS;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Proveedor = (Int32)p_K_Proveedor.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Proveedores(Int32 K_Proveedor, int K_Tipo_Fiscal, string D_Proveedor, string C_Proveedor, Int16 K_Pais, string RFC, Int32 K_Estado, Int32 K_Ciudad,
            Int32 K_Colonia, string Calle, string Numero_Exterior, String Numero_Interior, Int32 Codigo_Postal, DateTime F_Alta, DateTime F_Baja, bool B_Otorga_Credito, int Dias_Credito, decimal Monto_Credito, bool B_Acepta_Devoluciones,
            bool B_Autorizado, bool B_Rechazado, string Observaciones, bool B_SOS,ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Proveedores";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Proveedor", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Proveedor", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 13));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Numero_Exterior", SqlDbType.VarChar, 50));
            if (Numero_Interior != "")
            {
                cmd.Parameters.Add(new SqlParameter("@Numero_Interior", SqlDbType.VarChar));
            }
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Alta", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Baja", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Otorga_Credito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Dias_Credito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Credito", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@B_Acepta_Devoluciones", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Rechazado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_SOS", SqlDbType.Bit));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@D_Proveedor"].Value = D_Proveedor;
            cmd.Parameters["@C_Proveedor"].Value = C_Proveedor;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@Numero_Exterior"].Value = Numero_Exterior;
            if (Numero_Interior != "")
            {
                cmd.Parameters["@Numero_Interior"].Value = Numero_Interior;
            }
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@F_Alta"].Value = F_Alta;
            cmd.Parameters["@F_Baja"].Value = F_Baja;
            cmd.Parameters["@B_Otorga_Credito"].Value = B_Otorga_Credito;
            cmd.Parameters["@Dias_Credito"].Value = Dias_Credito;
            cmd.Parameters["@Monto_Credito"].Value = Monto_Credito;
            cmd.Parameters["@B_Acepta_Devoluciones"].Value = B_Acepta_Devoluciones;
            cmd.Parameters["@B_Autorizado"].Value = B_Autorizado;
            cmd.Parameters["@B_Rechazado"].Value = B_Rechazado;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@B_SOS"].Value =B_SOS;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Proveedores(Int32 K_Proveedor, int K_Tipo_Fiscal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Proveedores";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Proveedores(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_CXP", SqlDbType.Bit));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@B_CXP"].Value = true;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Proveedores(bool B_SOS)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_SOS", SqlDbType.Bit));
            cmd.Parameters["@B_SOS"].Value =B_SOS;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Proveedores()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Proveedores_Autorizados()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores_Autorizados";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //CONTACTOS PROVEEDOR
        public int In_Contactos_Proveedor(ref Int32 K_Contacto_Proveedor, Int32 K_Tipo_Contacto, Int32 K_Proveedor, string Telefono_Contacto, string Correo_Contacto, string Puesto, string D_Contacto, Int32 K_Usuario, string Telefono_Contacto2, Int32 Extension, String Numero_Movil, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Contactos_Proveedor";

            IDataParameter p_K_Contacto_Proveedor = new SqlParameter("@K_Contacto_Proveedor", SqlDbType.Int);
            p_K_Contacto_Proveedor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Contacto_Proveedor);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono_Contacto", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Telefono_Contacto2", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Extension", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Movil", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo_Contacto", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@Puesto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Contacto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Contacto_Proveedor"].Value = K_Contacto_Proveedor;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@Telefono_Contacto"].Value = Telefono_Contacto;
            cmd.Parameters["@Telefono_Contacto2"].Value = Telefono_Contacto2;
            if(Extension==0)
            {
                cmd.Parameters["@Extension"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Extension"].Value = Extension;
            }         
            cmd.Parameters["@Numero_Movil"].Value = Numero_Movil;
            cmd.Parameters["@Correo_Contacto"].Value = Correo_Contacto;
            cmd.Parameters["@Puesto"].Value = Puesto;
            cmd.Parameters["@D_Contacto"].Value = D_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Contacto_Proveedor = (Int32)p_K_Contacto_Proveedor.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Contactos_Proveedor(
           Int32 K_Contacto_Proveedor,
           Int32 K_Tipo_Contacto,
           Int32 K_Proveedor,
           string Telefono_Contacto,
           string Correo_Contacto,
           string Puesto,
           string D_Contacto,
           string Telefono_Contacto2,
           Int32 Extension,
           String Numero_Movil,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Contactos_Proveedor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Contacto_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono_Contacto", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Telefono_Contacto2", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Extension", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Movil", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo_Contacto", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@Puesto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Contacto", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Contacto_Proveedor"].Value = K_Contacto_Proveedor;
            cmd.Parameters["@K_Tipo_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Telefono_Contacto"].Value = Telefono_Contacto;
            cmd.Parameters["@Telefono_Contacto2"].Value = Telefono_Contacto2;
            if (Extension == 0)
            {
                cmd.Parameters["@Extension"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Extension"].Value = Extension;
            }
            cmd.Parameters["@Numero_Movil"].Value = Numero_Movil;
            cmd.Parameters["@Correo_Contacto"].Value = Correo_Contacto;
            cmd.Parameters["@Puesto"].Value = Puesto;
            cmd.Parameters["@D_Contacto"].Value = D_Contacto;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Contactos_Proveedor(Int32 K_Contacto_Proveedor, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Contactos_Proveedor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Contacto_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Contacto_Proveedor"].Value = K_Contacto_Proveedor;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Contactos_Proveedor(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Contactos_Proveedor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //SUCURSALES PROVEEDOR
        public int In_Sucursales_Proveedor(ref Int32 K_Sucursal_Proveedor,
            Int32 K_Proveedor,
            string D_Sucursal_Proveedor,
            Int32 K_Usuario,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Sucursales_Proveedor";

            IDataParameter p_K_Sucursal_Proveedor = new SqlParameter("@K_Sucursal_Proveedor", SqlDbType.Int);
            p_K_Sucursal_Proveedor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Sucursal_Proveedor);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Sucursal_Proveedor", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Sucursal_Proveedor"].Value = K_Sucursal_Proveedor;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@D_Sucursal_Proveedor"].Value = D_Sucursal_Proveedor;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Sucursal_Proveedor = (Int32)p_K_Sucursal_Proveedor.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Sucursales_Proveedor(
            Int32 K_Sucursal_Proveedor,
            Int32 K_Proveedor,
            string D_Sucursal_Proveedor,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Sucursales_Proveedor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Sucursal_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Sucursal_Proveedor", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Sucursal_Proveedor"].Value = K_Sucursal_Proveedor;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@D_Sucursal_Proveedor"].Value = D_Sucursal_Proveedor;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Sucursales_Proveedor(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Sucursales_Proveedor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        //BANCOS PROVEEDOR
        public int In_Proveedores_Bancos(Int32 K_Banco, Int32 K_Proveedor, Int32 Cuenta, bool B_Deposito, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Proveedores_Bancos";
            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Deposito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@B_Deposito"].Value = B_Deposito;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Proveedores_Bancos(Int32 K_Banco, Int32 K_Proveedor, Int32 K_Usuario_Bitacora, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Proveedores_BancoS";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));


            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Proveedores_Bancos(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores_Bancos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //DOCUMENTOS PROVEEDOR
        //DOCUMENTOS PROVEEDOR
        public int In_Documentos_Proveedor(Int32 K_Documentos_Requeridos, Int32 K_Proveedor, bool B_Resguardado, Int32 K_Usuario, string Observaciones, PictureBox imagen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Documentos_Proveedor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Documentos_Requeridos", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Resguardado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add("@Documento", System.Data.SqlDbType.Text);

            cmd.Parameters["@K_Documentos_Requeridos"].Value = K_Documentos_Requeridos;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@B_Resguardado"].Value = B_Resguardado;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Observaciones"].Value = Observaciones;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            // Asignando el valor de la imagen
            if (imagen.Image != null)
            {            // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                //cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.Parameters["@Documento"].Value = Convert.ToBase64String(ms.GetBuffer());
            }

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Documentos_Proveedor(Int32 K_Documentos_Requeridos, Int32 K_Proveedor, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Documentos_Proveedor";
            cmd.CommandTimeout = 0;

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);
            
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Documentos_Requeridos", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Documentos_Requeridos"].Value = K_Documentos_Requeridos;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Documentos_Proveedor(
            Int32 K_Documento_Proveedor,
            Int32 K_Documentos_Requeridos,
            Int32 K_Proveedor,
            bool B_Resguardado,
            Int32 K_Usuario,
            DateTime F_Registro,
            string Observaciones,
            PictureBox imagen,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Documentos_Proveedor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);
                                             
            cmd.Parameters.Add(new SqlParameter("@K_Documento_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Documentos_Requeridos", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Resguardado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Registro", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add("@Documento", System.Data.SqlDbType.Text);

            cmd.Parameters["@K_Documento_Proveedor"].Value = K_Documento_Proveedor;
            cmd.Parameters["@K_Documentos_Requeridos"].Value = K_Documentos_Requeridos;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@B_Resguardado"].Value = B_Resguardado;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@F_Registro"].Value = F_Registro;
            cmd.Parameters["@Observaciones"].Value = Observaciones;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            // Asignando el valor de la imagen
            if (imagen.Image != null)
            {            // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                //cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.Parameters["@Documento"].Value = Convert.ToBase64String(ms.GetBuffer());
            }


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Documentos_Proveedor(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Documentos_Proveedor";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Variant));


            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable sk_Documentos_Proveedor()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sk_Documentos_Requeridos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Articulos(ref Int32 K_Articulo, string D_Articulo, string C_Articulo, Int32 K_Tipo_Producto, Int32 K_Clase,
            Int32 K_Presentacion, Int32 K_Familia_Articulo, Int32 K_Laboratorio,
            Int32 K_Sustancia_Activa, Int32 K_Tipo_Moneda, Int32 K_Grupo_Articulo,
            Int32 K_Iva, Int32 K_Categoria_Articulo, Int32 K_Unidad_Medid,
            Int32 K_Temperatura, string SKU, decimal Precio_Unitario, decimal Precio_Maximo_Publico, bool B_Activo,
            bool B_Requiere_Inventario, bool B_BFFS, bool B_SolicitaLote, bool B_SolicitaCaducidad, Int32 K_UsuariO, PictureBox imagen, bool B_Requiere_Autorizacion,
            bool B_VentaSOS, bool B_EnRenta, Int32 K_Clave_SAT, string Lote, int Minimo_Inventario, int Maximo_Inventario,
            DateTime F_Caducidad, bool B_Fragil, bool B_Refrigerado,Int32 K_Ieps, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Articulos";

            IDataParameter p_K_Articulo = new SqlParameter("@K_Articulo", SqlDbType.Int);
            p_K_Articulo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Articulo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Articulo", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Producto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Presentacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Grupo_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Iva", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Categoria_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Unidad_Medida", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Temperatura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Lote", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@F_Caducidad", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Precio_Unitario", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Precio_Maximo_Publico", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@B_Activo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Inventario", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_BFFS", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_SolicitaLote", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_SolicitaCaducidad", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Autorizacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_VentaSOS", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_EnRenta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Fragil", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Refrigerado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Clave_SAT", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Minimo_Inventario", SqlDbType.Variant));
            cmd.Parameters.Add(new SqlParameter("@Maximo_Inventario", SqlDbType.Int));
            cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.Text);
            cmd.Parameters.Add(new SqlParameter("@K_Ieps", SqlDbType.Int));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            cmd.Parameters["@C_Articulo"].Value = C_Articulo;
            cmd.Parameters["@K_Tipo_Producto"].Value = K_Tipo_Producto;
            cmd.Parameters["@K_Clase"].Value = K_Clase;
            cmd.Parameters["@K_Presentacion"].Value = K_Presentacion;
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@K_Grupo_Articulo"].Value = K_Grupo_Articulo;
            cmd.Parameters["@K_Iva"].Value = K_Iva;
            cmd.Parameters["@K_Categoria_Articulo"].Value = K_Categoria_Articulo;
            cmd.Parameters["@K_Unidad_Medida"].Value = K_Unidad_Medid;
            cmd.Parameters["@K_Temperatura"].Value = K_Temperatura;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@Lote"].Value = Lote;
            cmd.Parameters["@F_Caducidad"].Value = F_Caducidad;
            cmd.Parameters["@Precio_Unitario"].Value = Precio_Unitario;
            cmd.Parameters["@Precio_Maximo_Publico"].Value = Precio_Maximo_Publico;
            cmd.Parameters["@B_Activo"].Value = B_Activo;
            cmd.Parameters["@B_Requiere_Inventario"].Value = B_Requiere_Inventario;
            cmd.Parameters["@B_BFFS"].Value = B_BFFS;
            cmd.Parameters["@B_SolicitaLote"].Value = B_SolicitaLote;
            cmd.Parameters["@B_SolicitaCaducidad"].Value = B_SolicitaCaducidad;
            cmd.Parameters["@B_Requiere_Autorizacion"].Value = B_SolicitaCaducidad;
            cmd.Parameters["@B_VentaSOS"].Value = B_VentaSOS;
            if (K_Clave_SAT == 0)
            {
                cmd.Parameters["@K_Clave_SAT"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Clave_SAT"].Value = K_Clave_SAT;
            }
            
            cmd.Parameters["@B_EnRenta"].Value = B_EnRenta;
            cmd.Parameters["@B_Fragil"].Value = B_Fragil;
            cmd.Parameters["@B_Refrigerado"].Value = B_Refrigerado;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            if(Minimo_Inventario==0)
            {
                cmd.Parameters["@Minimo_Inventario"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Minimo_Inventario"].Value = Minimo_Inventario;
            }
            if(Maximo_Inventario==0)
            {
                cmd.Parameters["@Maximo_Inventario"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Maximo_Inventario"].Value = Maximo_Inventario;
            }
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            // Asignando el valor de la imagen
            if (imagen.Image != null)
            {            // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                //cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.Parameters["@Imagen"].Value = Convert.ToBase64String(ms.GetBuffer());
            }
            cmd.Parameters["@K_Ieps"].Value = K_Ieps;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Articulo = (Int32)p_K_Articulo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Articulos(Int32 K_Articulo, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Articulos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Articulos(Int32 K_Articulo, string D_Articulo, string C_Articulo, Int32 K_Tipo_Producto, Int32 K_Clase, Int32 K_Presentacion, Int32 K_Familia_Articulo,
            Int32 K_Laboratorio, Int32 K_Sustancia_Activa, Int32 K_Tipo_Moneda, Int32 K_Grupo_Articulo, Int32 K_Iva, Int32 K_Categoria_Articulo, Int32 K_Unidad_Medid, Int32 K_Temperatura,
            string SKU, decimal Precio_Unitario, decimal Precio_Maximo_Publico, bool B_Activo, bool B_Requiere_Inventario, bool B_BFFS, bool B_SolicitaLote, bool B_SolicitaCaducidad,
            Int32 K_Usuario, PictureBox imagen, bool B_Requiere_Autorizacion, bool B_VentaSOS, bool B_EnRenta, Int32 K_Clave_SAT,
            string Lote, int Minimo_Inventario, int Maximo_Inventario, DateTime F_Caducidad, bool B_Refrigerado, bool B_Fragil, Int32 K_Ieps, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Articulos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Articulo", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Producto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Presentacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Grupo_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Iva", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Categoria_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Unidad_Medida", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Temperatura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Lote", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Fragil", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Refrigerado", SqlDbType.Bit));
            //  cmd.Parameters.Add(new SqlParameter("@F_Caducidad", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Precio_Unitario", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Precio_Maximo_Publico", SqlDbType.Money));

            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Inventario", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_BFFS", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_SolicitaLote", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_SolicitaCaducidad", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Requiere_Autorizacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_VentaSOS", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_EnRenta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Minimo_Inventario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Maximo_Inventario", SqlDbType.Int));
            cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.Text);
            cmd.Parameters.Add(new SqlParameter("@K_Clave_SAT", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ieps", SqlDbType.Int));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            cmd.Parameters["@C_Articulo"].Value = C_Articulo;
            cmd.Parameters["@K_Tipo_Producto"].Value = K_Tipo_Producto;
            cmd.Parameters["@K_Clase"].Value = K_Clase;
            cmd.Parameters["@K_Presentacion"].Value = K_Presentacion;
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@K_Grupo_Articulo"].Value = K_Grupo_Articulo;
            cmd.Parameters["@K_Iva"].Value = K_Iva;
            cmd.Parameters["@K_Categoria_Articulo"].Value = K_Categoria_Articulo;
            cmd.Parameters["@K_Unidad_Medida"].Value = K_Unidad_Medid;
            cmd.Parameters["@K_Temperatura"].Value = K_Temperatura;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@Lote"].Value = Lote;
            cmd.Parameters["@Precio_Unitario"].Value = Precio_Unitario;
            cmd.Parameters["@Precio_Maximo_Publico"].Value = Precio_Maximo_Publico;
            cmd.Parameters["@B_VentaSOS"].Value = B_VentaSOS;
            cmd.Parameters["@B_EnRenta"].Value = B_EnRenta;
            if (K_Clave_SAT == 0)
            {
                cmd.Parameters["@K_Clave_SAT"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Clave_SAT"].Value = K_Clave_SAT;
            }
            cmd.Parameters["@B_Requiere_Inventario"].Value = B_Requiere_Inventario;
            cmd.Parameters["@B_BFFS"].Value = B_BFFS;
            cmd.Parameters["@B_SolicitaLote"].Value = B_SolicitaLote;
            cmd.Parameters["@B_SolicitaCaducidad"].Value = B_SolicitaCaducidad;
            cmd.Parameters["@B_EnRenta"].Value = B_EnRenta;
            cmd.Parameters["@B_Fragil"].Value = B_Fragil;
            cmd.Parameters["@B_Refrigerado"].Value = B_Refrigerado;
            cmd.Parameters["@B_Requiere_Autorizacion"].Value = B_Requiere_Autorizacion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            if (Minimo_Inventario == 0)
            {
                cmd.Parameters["@Minimo_Inventario"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Minimo_Inventario"].Value = Minimo_Inventario;
            }
            if (Maximo_Inventario == 0)
            {
                cmd.Parameters["@Maximo_Inventario"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Maximo_Inventario"].Value = Maximo_Inventario;
            }
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            // Asignando el valor de la imagen
            if (imagen.Image != null)
            {
                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                //cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.Parameters["@Imagen"].Value = Convert.ToBase64String(ms.GetBuffer());
            }
            cmd.Parameters["@K_Ieps"].Value = K_Ieps;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Articulos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos(Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters["@K_Empresa"].Value =K_Empresa;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos_All()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos_Consulta(Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_Consulta";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos_Consulta_CPrecio(Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo, Int32 K_Proveedor,Int32 K_Articulo=0)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_Consulta_CPrecio";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));

            if(K_Familia_Articulo==0)
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
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
            if(K_Proveedor==0)
            {
                cmd.Parameters["@K_Proveedor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
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
            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos_Consulta_CPrecio(Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo, Int32 K_Articulo = 0)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_Consulta_CPrecio";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));

            if(K_Familia_Articulo==0)
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            }
            if(K_Laboratorio==0)
            {
                cmd.Parameters["@K_Laboratorio"].Value = DBNull.Value;
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
            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos_Consulta_Renta(Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_Consulta_Renta";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Articulos_All(Int32 K_Familia_Articulo, Int32 K_Laboratorio, Int32 K_Sustancia_Activa, string SKU, string D_Articulo,Int32 K_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_All";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));

            if(K_Familia_Articulo==0)
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
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
            if(SKU.Length==0)
            {
                cmd.Parameters["@SKU"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@SKU"].Value = SKU;
            }
            if (D_Articulo.Length == 0) {
                cmd.Parameters["@D_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            }
            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }
        

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //ESTADO CIVIL 
        public int In_Estado_Civil(ref Int16 K_Estado_Civil, string D_Estado_Civil, string C_Estado_Civil, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estado_Civil";

            IDataParameter p_K_Estado_Civil = new SqlParameter("@K_Estado_Civil", SqlDbType.SmallInt);
            p_K_Estado_Civil.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estado_Civil);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Estado_Civil", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Estado_Civil", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado_Civil"].Value = K_Estado_Civil;
            cmd.Parameters["@D_Estado_Civil"].Value = D_Estado_Civil;
            cmd.Parameters["@C_Estado_Civil"].Value = C_Estado_Civil;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Estado_Civil = (Int16)p_K_Estado_Civil.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public int Dl_Estado_Civil(Int16 K_Estado_Civil, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estado_Civil";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado_Civil", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado_Civil"].Value = K_Estado_Civil;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Estado_Civil(Int16 K_Estado_Civil, string D_Estado_Civil, string C_Estado_Civil, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estado_Civil";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estado_Civil", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Estado_Civil", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Estado_Civil", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estado_Civil"].Value = K_Estado_Civil;
            cmd.Parameters["@D_Estado_Civil"].Value = D_Estado_Civil;
            cmd.Parameters["@C_Estado_Civil"].Value = C_Estado_Civil;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Estado_Civil()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estado_Civil";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //CELULAS
        public int In_Celulas(ref Int16 K_Celula, string D_Celula, string C_Celula, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Celulas";

            IDataParameter p_K_Celula = new SqlParameter("@K_Celula", SqlDbType.SmallInt);
            p_K_Celula.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Celula);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Celula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Celula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@D_Celula"].Value = D_Celula;
            cmd.Parameters["@C_Celula"].Value = C_Celula;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Celula = (Int16)p_K_Celula.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Celulas(ref Int16 K_Celula, string D_Celula, string C_Celula, Int32 K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Celulas";

            IDataParameter p_K_Celula = new SqlParameter("@K_Celula", SqlDbType.SmallInt);
            p_K_Celula.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Celula);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Celula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Celula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@D_Celula"].Value = D_Celula;
            cmd.Parameters["@C_Celula"].Value = C_Celula;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Celula = (Int16)p_K_Celula.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Celulas(Int16 K_Celula, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Celulas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Celulas(Int16 K_Celula, string D_Celula, string C_Celula, Int32 K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Celulas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Celula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Celula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@D_Celula"].Value = D_Celula;
            cmd.Parameters["@C_Celula"].Value = C_Celula;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Celulas()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Celulas";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Celulas(Int32 K_Celula)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Celulas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters["@K_Celula"].Value = K_Celula;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //GENEROS
        public int In_Generos(ref Int16 K_Genero, string D_Genero, string C_Genero, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Generos";

            IDataParameter p_K_Genero = new SqlParameter("@K_Genero", SqlDbType.SmallInt);
            p_K_Genero.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Genero);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Genero", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Genero", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Genero"].Value = K_Genero;
            cmd.Parameters["@D_Genero"].Value = D_Genero;
            cmd.Parameters["@C_Genero"].Value = C_Genero;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Genero = (Int16)p_K_Genero.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Generos(Int16 K_Genero, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Generos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Genero", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Genero"].Value = K_Genero;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Generos(Int16 K_Genero, string D_Genero, string C_Genero, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Generos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Genero", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Genero", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Genero"].Value = K_Genero;
            cmd.Parameters["@D_Genero"].Value = D_Genero;
            cmd.Parameters["@C_Genero"].Value = C_Genero;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Generos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Generos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //NACIONALIDAD
        public int In_Nacionalidad(ref Int16 K_Nacionalidad, string D_Nacionalidad, string C_Nacionalidad, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Nacionalidad";

            IDataParameter p_K_Nacionalidad = new SqlParameter("@K_Nacionalidad", SqlDbType.SmallInt);
            p_K_Nacionalidad.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nacionalidad);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Nacionalidad", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Nacionalidad", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Nacionalidad"].Value = K_Nacionalidad;
            cmd.Parameters["@D_Nacionalidad"].Value = D_Nacionalidad;
            cmd.Parameters["@C_Nacionalidad"].Value = C_Nacionalidad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nacionalidad = (Int16)p_K_Nacionalidad.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Nacionalidad(Int16 K_Genero, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Nacionalidad";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Nacionalidad", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Nacionalidad"].Value = K_Genero;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Nacionalidad(Int16 K_Nacionalidad, string D_Nacionalidad, string C_Nacionalidad, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Nacionalidad";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Nacionalidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Nacionalidad", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Nacionalidad", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Nacionalidad"].Value = K_Nacionalidad;
            cmd.Parameters["@D_Nacionalidad"].Value = D_Nacionalidad;
            cmd.Parameters["@C_Nacionalidad"].Value = C_Nacionalidad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Nacionalidad()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Nacionalidad";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //TIPOS DE PACIENTE 
        public int In_Tipos_Paciente(ref Int16 K_Tipo_Paciente, string D_Tipo_Paciente, string C_Tipo_Paciente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Paciente";

            IDataParameter p_K_Tipo_Paciente = new SqlParameter("@K_Tipo_Paciente", SqlDbType.SmallInt);
            p_K_Tipo_Paciente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Paciente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Paciente", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Paciente", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Paciente"].Value = K_Tipo_Paciente;
            cmd.Parameters["@D_Tipo_Paciente"].Value = D_Tipo_Paciente;
            cmd.Parameters["@C_Tipo_Paciente"].Value = C_Tipo_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Paciente = (Int16)p_K_Tipo_Paciente.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Tipos_Paciente(Int16 K_Tipo_Paciente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Paciente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Paciente", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Paciente"].Value = K_Tipo_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipos_Paciente(Int16 K_Tipo_Paciente, string D_Tipo_Paciente, string C_Tipo_Paciente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Paciente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Paciente", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Paciente", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Paciente"].Value = K_Tipo_Paciente;
            cmd.Parameters["@D_Tipo_Paciente"].Value = D_Tipo_Paciente;
            cmd.Parameters["@C_Tipo_Paciente"].Value = C_Tipo_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Paciente()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Paciente";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //TIPOS DE POLIZAS 
        public int In_Tipos_Poliza(ref Int16 K_Tipo_Poliza, string D_Tipo_Poliza, string C_Tipo_Poliza, Int32 K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Poliza";

            IDataParameter p_K_Tipo_Poliza = new SqlParameter("@K_Tipo_Poliza", SqlDbType.SmallInt);
            p_K_Tipo_Poliza.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Poliza);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Poliza", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Poliza", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@D_Tipo_Poliza"].Value = D_Tipo_Poliza;
            cmd.Parameters["@C_Tipo_Poliza"].Value = C_Tipo_Poliza;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Poliza = (Int16)p_K_Tipo_Poliza.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Tipos_Poliza(Int16 K_Tipo_Poliza, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Poliza";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Poliza", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipos_Poliza(Int16 K_Tipo_Poliza, string D_Tipo_Poliza, string C_Tipo_Poliza, Int32 K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Poliza";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Poliza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Poliza", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Poliza", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@D_Tipo_Poliza"].Value = D_Tipo_Poliza;
            cmd.Parameters["@C_Tipo_Poliza"].Value = C_Tipo_Poliza;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Poliza()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Poliza";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //TIPOS DE SANGRE 
        public int In_TiposSangre(ref Int16 K_Tipo_Sangre, string D_Tipo_Sangre, string C_Tipo_Sangre, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_TiposSangre";

            IDataParameter p_K_Tipo_Sangre = new SqlParameter("@K_Tipo_Sangre", SqlDbType.SmallInt);
            p_K_Tipo_Sangre.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Sangre);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Sangre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Sangre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Sangre"].Value = K_Tipo_Sangre;
            cmd.Parameters["@D_Tipo_Sangre"].Value = D_Tipo_Sangre;
            cmd.Parameters["@C_Tipo_Sangre"].Value = C_Tipo_Sangre;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Sangre = (Int16)p_K_Tipo_Sangre.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_TiposSangre(Int16 K_Tipo_Sangre, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_TiposSangre";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Sangre", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Sangre"].Value = K_Tipo_Sangre;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_TiposSangre(Int16 K_Tipo_Sangre, string D_Tipo_Sangre, string C_Tipo_Sangre, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_TiposSangre";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Sangre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Sangre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Sangre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Sangre"].Value = K_Tipo_Sangre;
            cmd.Parameters["@D_Tipo_Sangre"].Value = D_Tipo_Sangre;
            cmd.Parameters["@C_Tipo_Sangre"].Value = C_Tipo_Sangre;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_TiposSangre()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_TiposSangre";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //PACIENTES 
        public int In_Pacientes(ref Int32 K_Paciente, string Nombre, string ApePat, string ApeMat, string RFC, string CURP,
                   Int32 K_Tipo_Paciente, Int32 K_Genero, Int32 K_Nacionalidad, Int32 K_Estado_Civil, Int32 K_Tipo_Sangre,
                   Int32 K_Celula, Int32 K_Tipo_Poliza, string Poliza, string Reclamacion, string Siniestro, Int16 Coaseguro, bool B_VIP, Int32 K_Cliente,ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes";

            IDataParameter p_K_Paciente = new SqlParameter("@K_Paciente", SqlDbType.SmallInt);
            p_K_Paciente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Paciente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 13));
            cmd.Parameters.Add(new SqlParameter("@CURP", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Poliza", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Reclamacion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Siniestro", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Coaseguroporcentaje", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Sangre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Nacionalidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Poliza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado_Civil", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_VIP", SqlDbType.Bit));

            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@CURP"].Value = CURP;
            cmd.Parameters["@Poliza"].Value = Poliza;
            cmd.Parameters["@Reclamacion"].Value = Reclamacion;
            cmd.Parameters["@Siniestro"].Value = Siniestro;
            cmd.Parameters["@Coaseguroporcentaje"].Value = Coaseguro;
            cmd.Parameters["@K_Genero"].Value = K_Genero;
            cmd.Parameters["@K_Tipo_Sangre"].Value = K_Tipo_Sangre;
            cmd.Parameters["@K_Nacionalidad"].Value = K_Nacionalidad;
            cmd.Parameters["@K_Tipo_Paciente"].Value = K_Tipo_Paciente;
            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@K_Estado_Civil"].Value = K_Estado_Civil;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@B_VIP"].Value = B_VIP;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente  ;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Paciente = (Int32)p_K_Paciente.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Pacientes(Int32 K_Paciente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Pacientes(Int32 K_Paciente, string Nombre, string ApePat, string ApeMat, string RFC, string CURP,
                   Int32 K_Tipo_Paciente, Int32 K_Genero, Int32 K_Nacionalidad, Int32 K_Estado_Civil, Int32 K_Tipo_Sangre,
                   Int32 K_Celula, Int32 K_Tipo_Poliza, string Poliza, string Reclamacion, string Siniestro, Int16 Coaseguro, bool B_IVA,Int32 K_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Pacientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 13));
            cmd.Parameters.Add(new SqlParameter("@CURP", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@Poliza", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Reclamacion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Siniestro", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Coaseguroporcentaje", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Sangre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Nacionalidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Poliza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado_Civil", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_VIP", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));

            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@CURP"].Value = CURP;
            cmd.Parameters["@Poliza"].Value = Poliza;
            cmd.Parameters["@Reclamacion"].Value = Reclamacion;
            cmd.Parameters["@Siniestro"].Value = Siniestro;
            cmd.Parameters["@Coaseguroporcentaje"].Value = Coaseguro;
            cmd.Parameters["@K_Genero"].Value = K_Genero;
            cmd.Parameters["@K_Tipo_Sangre"].Value = K_Tipo_Sangre;
            cmd.Parameters["@K_Nacionalidad"].Value = K_Nacionalidad;
            cmd.Parameters["@K_Tipo_Paciente"].Value = K_Tipo_Paciente;
            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@K_Estado_Civil"].Value = K_Estado_Civil;
            cmd.Parameters["@B_VIP"].Value = B_IVA;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_ActualizaNombrePaciente(Int32 K_Paciente, string Nombre, string ApePat, string ApeMat, ref string Nombre_Nuevo,ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ActualizaNombrePaciente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_Nombre_Nuevo = new SqlParameter("@Nombre_Nuevo", SqlDbType.VarChar, 300);
            p_Nombre_Nuevo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Nombre_Nuevo);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
           
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat; 
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            cmd.Parameters["@Nombre_Nuevo"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;
            Nombre_Nuevo=(string)p_Nombre_Nuevo.Value;

            return res;
        }
        public DataTable Sk_Pacientes(Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Pacientes()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        //CLIENTES
        public int In_Clientes(
            ref Int32 K_Cliente,
            string D_Cliente,
            string C_Cliente,
            string D_Comercial,
            string RFC,
            string CURP,
            int DiasCredito,
            decimal LimiteCredito,
            string URL,
            string Correo,
            int K_Usuario,
            int K_Canal_Distribucion_Cliente,
            bool B_Cliente_Tarjeta,
            int K_Estatus_Cliente,
            int K_Tipo_Fiscal,
            Int32 K_Empresa,
            Int32 K_Asesor_1,
            Int32 K_Asesor_2,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Clientes";

            IDataParameter p_K_Cliente = new SqlParameter("@K_Cliente", SqlDbType.Int);
            p_K_Cliente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cliente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Cliente", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@C_Cliente", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Comercial", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@CURP", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@DiasCredito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@LimiteCredito", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@URL", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Cliente_Tarjeta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Asesor_1", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Asesor_2", SqlDbType.Int));

            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@D_Cliente"].Value = D_Cliente;
            cmd.Parameters["@C_Cliente"].Value = C_Cliente;
            cmd.Parameters["@D_Comercial"].Value = D_Comercial;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@CURP"].Value = CURP;
            cmd.Parameters["@DiasCredito"].Value = DiasCredito;
            cmd.Parameters["@LimiteCredito"].Value = LimiteCredito;
            cmd.Parameters["@URL"].Value = URL;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Estatus_Cliente"].Value = K_Estatus_Cliente;
            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@B_Cliente_Tarjeta"].Value = B_Cliente_Tarjeta;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            if(K_Asesor_1==0)
            {
                cmd.Parameters["@K_Asesor_1"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Asesor_1"].Value = K_Asesor_1;
            }
            if(K_Asesor_2==0)
            {
                cmd.Parameters["@K_Asesor_2"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Asesor_2"].Value = K_Asesor_2;
            }
       
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cliente = (Int32)p_K_Cliente.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Clientes(
           Int32 K_Cliente,
           string D_Cliente,
           string C_Cliente,
           string D_Comercial,
           string RFC,
           string CURP,
           int DiasCredito,
           decimal LimiteCredito,
           string URL,
           string Correo,
           int K_Usuario,
           int K_Canal_Distribucion_Cliente,
           bool B_Cliente_Tarjeta,
           int K_Estatus_Cliente,
           int K_Tipo_Fiscal,
           Int32 K_Empresa,
           Int32 K_Asesor_1,
           Int32 K_Asesor_2,
           ref string Mensaje
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Clientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cliente", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@C_Cliente", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@D_Comercial", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@CURP", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@DiasCredito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@LimiteCredito", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@URL", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Cliente_Tarjeta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Asesor_1", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Asesor_2", SqlDbType.Int));

            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@D_Cliente"].Value = D_Cliente;
            cmd.Parameters["@C_Cliente"].Value = C_Cliente;
            cmd.Parameters["@D_Comercial"].Value = D_Comercial;
            cmd.Parameters["@RFC"].Value = RFC;
            cmd.Parameters["@CURP"].Value = CURP;
            cmd.Parameters["@DiasCredito"].Value = DiasCredito;
            cmd.Parameters["@LimiteCredito"].Value = LimiteCredito;
            cmd.Parameters["@URL"].Value = URL;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Estatus_Cliente"].Value = K_Estatus_Cliente;
            cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@B_Cliente_Tarjeta"].Value = B_Cliente_Tarjeta;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            if (K_Asesor_1 == 0)
            {
                cmd.Parameters["@K_Asesor_1"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Asesor_1"].Value = K_Asesor_1;
            }
            if (K_Asesor_2 == 0)
            {
                cmd.Parameters["@K_Asesor_2"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Asesor_2"].Value = K_Asesor_2;
            }
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }



        public int Dl_Clientes(Int16 K_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Clientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Clientes(Int32 K_Empresa = 0)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clientes";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            if (K_Empresa == 0)
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
        public DataTable Sk_Clientes(Int32 K_Empresa,Int32 K_Cliente,string D_Cliente,Int32 K_Tipo_Fiscal,Int32 K_Estatus_Cliente,Int32 K_Canal_Distribucion_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clientes";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cliente", SqlDbType.VarChar,120));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));

            if (K_Empresa == 0)
            {
                cmd.Parameters["@K_Empresa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            }

            if (K_Cliente == 0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }

            if (D_Cliente.Length == 0)
            {
                cmd.Parameters["@D_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@D_Cliente"].Value = D_Cliente;
            }

            if (K_Tipo_Fiscal == 0)
            {
                cmd.Parameters["@K_Tipo_Fiscal"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Fiscal"].Value = K_Tipo_Fiscal;
            }

            if (K_Estatus_Cliente == 0)
            {
                cmd.Parameters["@K_Estatus_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Estatus_Cliente"].Value = K_Estatus_Cliente;
            }

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
        public DataTable Sk_Clientes_All(Int32 K_Cliente, string D_Cliente,Int32 K_Empresa=0)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clientes_All";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cliente", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));

            if(K_Cliente==0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;

            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;

            }

            try
            {
                if (D_Cliente.Length == 0 || D_Cliente == null)
                {
                    cmd.Parameters["@D_Cliente"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@D_Cliente"].Value = D_Cliente;
                }
            }
            catch (Exception) { }
  
           
            if(K_Empresa == 0)
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
        public DataTable Sk_Articulos_All(string D_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Articulos_All";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 120));
            cmd.Parameters["@D_Articulo"].Value = D_Articulo;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //ESTATUS DE COMPRA

        public int In_Estatus_Compra(ref Int16 K_Estatus_Compra, string D_Estatus_Compra, bool B_Aplica_Requisicion, int K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estatus_Compra";

            IDataParameter p_K_Estatus_Compra = new SqlParameter("@K_Estatus_Compra", SqlDbType.SmallInt);
            p_K_Estatus_Compra.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estatus_Compra);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Compra", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Requisicion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            cmd.Parameters["@D_Estatus_Compra"].Value = D_Estatus_Compra;
            cmd.Parameters["@B_Aplica_Requisicion"].Value = B_Aplica_Requisicion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Estatus_Compra = (Int16)p_K_Estatus_Compra.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Estatus_Compra(Int16 K_Estatus_Compra, string D_Estatus_Compra, bool B_Aplica_Requisicion, int K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estatus_Compra";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Compra", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Requisicion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            cmd.Parameters["@D_Estatus_Compra"].Value = D_Estatus_Compra;
            cmd.Parameters["@B_Aplica_Requisicion"].Value = B_Aplica_Requisicion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Estatus_Compra(Int16 K_Estatus_Compra, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estatus_Compra";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Compra", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }



        //TIPOS DE REQUISICION

        public int In_Tipo_Requisicion(
          ref Int16 K_Tipo_Requisicion,
          string D_Tipo_Requisicion,
          int K_Usuario,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Requisicion";

            IDataParameter p_K_Tipo_Requisicion = new SqlParameter("@K_Tipo_Requisicion", SqlDbType.SmallInt);
            p_K_Tipo_Requisicion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Requisicion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Requisicion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Requisicion"].Value = K_Tipo_Requisicion;
            cmd.Parameters["@D_Tipo_Requisicion"].Value = D_Tipo_Requisicion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Requisicion = (Int16)p_K_Tipo_Requisicion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipo_Requisicion(
            Int16 K_Tipo_Requisicion,
           string D_Tipo_Requisicion,
           int K_Usuario,
           ref string Mensaje
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Requisicion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Requisicion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Requisicion"].Value = K_Tipo_Requisicion;
            cmd.Parameters["@D_Tipo_Requisicion"].Value = D_Tipo_Requisicion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipo_Requisicion(Int16 K_Tipo_Requisicion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Requisicion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Requisicion", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Requisicion"].Value = K_Tipo_Requisicion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipo_Requisicion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Requisicion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //ZONIFICACION LOCAL PRECIOS ENFERMERIA ASEGURADORA
        public int In_Zonificacion_LocAsegu_Precios_Enfermeria(ref Int32 K_Precio_LocAsegu_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, Int32 K_Colonia, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_LocAsegu_Precios_Enfermeria";


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
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
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
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
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
        public int Up_Zonificacion_LocAsegu_Precios_Enfermeria(Int16 K_Precio_LocAsegu_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_LocAsegu_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_LocAsegu_Enfermeria", SqlDbType.Int));
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
            res = ConnectionClass.ExecuteNonQuery(ref cmd);


            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Zonificacion_LPEnfermeria_Aseg()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_LPEnfermeria_Aseg";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_LPEnfermeria_Aseg(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, Int32 K_Colonia, DateTime FechaInicial, DateTime FechaFinal, int K_Aseguradora)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_LPEnfermeria_Aseg";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;

        }

        //ZONIFICACION FORANEA PRECIOS ENFERMERIA ASEGURADORA

        public int In_Zonificacion_ForAsegu_Precios_Enfermeria(ref Int32 K_Precio_ForAsegu_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Zonificacion_ForAsegu_Precios_Enfermeria";


            IDataParameter p_K_Precio_ForAsegu_Enfermeria = new SqlParameter("@K_Precio_ForAsegu_Enfermeria", SqlDbType.Int);
            p_K_Precio_ForAsegu_Enfermeria.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precio_ForAsegu_Enfermeria);

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

            cmd.Parameters["@K_Precio_ForAsegu_Enfermeria"].Value = K_Precio_ForAsegu_Enfermeria;
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

            K_Precio_ForAsegu_Enfermeria = (Int32)p_K_Precio_ForAsegu_Enfermeria.Value;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Zonificacion_ForAsegu_Precios_Enfermeria(Int16 K_Precio_ForAsegu_Enfermeria, Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, decimal Precio, DateTime F_Inicio, DateTime F_Final, int K_Aseguradora, ref string Mensaje)
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Zonificacion_ForAsegu_Precios_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precio_ForAsegu_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aeguradora", SqlDbType.Int));

            cmd.Parameters["@K_Precio_ForAsegu_Enfermeria"].Value = K_Precio_ForAsegu_Enfermeria;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
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
        public DataTable Sk_Zonificacion_FPEnfermeria_Aseg()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_FPEnfermeria_Aseg";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Zonificacion_FPEnfermeria_Aseg(Int16 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, Int32 K_Oficina, DateTime FechaInicial, DateTime FechaFinal, int K_Aseguradora)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Zonificacion_FPEnfermeria_Aseg";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Precio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Fin_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Precio_Enfermeria"].Value = K_Precio_Enfermeria;
            cmd.Parameters["@F_Inicio_Vigencia"].Value = FechaInicial;
            cmd.Parameters["@F_Fin_Vigencia"].Value = FechaFinal;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;

        }

        //ARTICULOS PROVEEDOR DISPONIBLES
        public DataTable Gp_Proveedores_ArticulosDis(Int32? K_Proveedor, string SKU, Int32 K_Articulo, Int32 K_Familia_Articulo,
            Int32 K_Laboratorio, Int32 K_Sustancia_Activa)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Proveedores_ArticulosDis";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@K_Sustancia_Activa"].Value = K_Sustancia_Activa;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //ARTICULOS PROVEEDOR ASIGNADOS
        public DataTable Sk_Proveedores_Articulos(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores_Articulos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Proveedores_Articulos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proveedores_Articulos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Proveedores_Articulos(Int32 K_Articulo, string SKU, Int32 K_Proveedor, decimal Precio_Articulo, decimal Porcentaje_Descuento, Int32 K_Usuario, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Proveedores_Articulos";

            IDataParameter p_pmsMsg = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_pmsMsg.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_pmsMsg);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio_Articulo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Precio_Articulo"].Value = Precio_Articulo;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }

        public int DL_Proveedores_Articulos(Int32 K_Articulo,Int32 K_Proveedor, ref string pmsMsg)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DL_Proveedores_Articulos";

            IDataParameter p_pmsMsg = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_pmsMsg.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_pmsMsg);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Mensaje"].Value = pmsMsg;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            pmsMsg = (string)p_pmsMsg.Value;

            return res;
        }

        //SUBE PRECIOS POR EXCEL
        public void GP_Carga_PreciosProveedor(Int32 K_Proveedor, string SKU, decimal Precio_Articulo, string Archivo_Subio, DateTime F_Actualizacion, Int32 K_Usuario, decimal Porcentaje_Descuento, string Pc_Name)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Carga_PreciosProveedor";

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Precio_Articulo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Archivo_Subio", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 30));


            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@Precio_Articulo"].Value = Precio_Articulo;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@Archivo_Subio"].Value = Archivo_Subio;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = GlobalVar.PC_Name;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

        }

        public void Gp_Sube_PreciosProvedor(Int32 K_Usuario, string Pc_Name)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Sube_PreciosProvedor";

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = GlobalVar.PC_Name;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

        }

        //SUBE PRECIOS NORMAL
        public int Up_Precios_Articulos_Proveedor(
            Int32 K_Precios_Articulo_Proveedor,
            Int32 K_Articulo,
            Int32 K_Proveedor,
            decimal Precio_Articulo,
            DateTime F_Actualizacion,
            Int32 K_Usuario_Aplico,
            decimal Porcentaje_Descuento,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Precios_Articulos_Proveedor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Precios_Articulo_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Precio_Articulo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));


            cmd.Parameters["@K_Precios_Articulo_Proveedor"].Value = K_Precios_Articulo_Proveedor;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Precio_Articulo"].Value = Precio_Articulo;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@K_Usuario_Aplico"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Precios_Articulos_Proveedor(Int32 K_Proveedor, DateTime F_Inicial, DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Articulos_Proveedor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Precios_Articulos_Proveedor(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Articulos_Proveedor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //BUSCA PRECIOS POR SKU
        public DataTable Sk_Precios_Articulos_Proveedor(String SKU)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Precios_Articulos_Proveedor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters["@SKU"].Value = SKU;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //PROGRAMAS
        public int In_Programas(ref Int16 K_Programa, Int32 K_Laboratorio, string D_Programa, string C_Programa, string Descripcion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Programas";

            IDataParameter p_K_Programa = new SqlParameter("@K_Programa", SqlDbType.SmallInt);
            p_K_Programa.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Programa);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Programa", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Programa", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 510));

            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@D_Programa"].Value = D_Programa;
            cmd.Parameters["@C_Programa"].Value = C_Programa;
            cmd.Parameters["@Descripcion"].Value = Descripcion;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Programa = (Int16)p_K_Programa.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Programas(Int16 K_Programa, Int32 K_Laboratorio, string D_Programa, string C_Programa, string Descripcion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Programas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Programa", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Programa", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 510));

            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            cmd.Parameters["@D_Programa"].Value = D_Programa;
            cmd.Parameters["@C_Programa"].Value = C_Programa;
            cmd.Parameters["@Descripcion"].Value = Descripcion;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Programas(Int16 K_Programa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Programas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Programas()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Precios_Articulos_Proveedor(ref Int16 K_Precios_Articulo_Proveedor, Int16 K_Articulo, Int32 K_Proveedor, string SKU, decimal Precio_Articulo,
            DateTime F_Actualizacion, Int32 K_Usuario_Aplico, decimal Porcentaje_Descuento, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Precios_Articulos_Proveedor";


            IDataParameter p_K_Precios_Articulo_Proveedor = new SqlParameter("@K_Precios_Articulo_Proveedor", SqlDbType.Int);
            p_K_Precios_Articulo_Proveedor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Precios_Articulo_Proveedor);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Precio_Articulo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Aplico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));


            cmd.Parameters["@K_Precios_Articulo_Proveedor"].Value = K_Precios_Articulo_Proveedor;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@Precio_Articulo"].Value = Precio_Articulo;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            cmd.Parameters["@K_Usuario_Aplico"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            K_Precios_Articulo_Proveedor = (Int16)p_K_Precios_Articulo_Proveedor.Value;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        //MONTOS AUTORIZA X FAMILIA 
        public DataTable Sk_Montos_Requiere_Autorizacion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Montos_Requiere_Autorizacion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Montos_Requiere_Autorizacion(
           Int32 K_Familia_Articulo,
           decimal Monto_Minimo,
           Int32 K_Usuario,
          ref string Mensaje
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Montos_Requiere_Autorizacion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Minimo", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Familia_Articulo"].Value = K_Familia_Articulo;
            cmd.Parameters["@Monto_Minimo"].Value = Monto_Minimo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Montos_Requiere_Autorizacion(Int32 K_Familia_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Montos_Requiere_Autorizacion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Familia_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Programa"].Value = K_Familia_Articulo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        //PROGRAMA ARTICULO
        public int In_Programas_Articulos(
        Int32 K_Programa,
        Int32 K_Articulo,
        Int32 K_Usuario,
        ref string Mensaje
         )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Programas_Articulos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;

            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Programas_Articulos(Int32 K_Programa)
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


        //PRECIO PROGRAMA ARTICULO

        public DataTable Sk_Programas_Articulos_Precios(Int32 K_Programa, DateTime F_Actualizacion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos_Precios";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Actualizacion", SqlDbType.SmallDateTime));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
            cmd.Parameters["@F_Actualizacion"].Value = F_Actualizacion;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Programas_Articulos_Precios(Int32 K_Programa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Programas_Articulos_Precios";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Programa", SqlDbType.Int));
            cmd.Parameters["@K_Programa"].Value = K_Programa;
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

        //ESPECIALIDADES 
        public int Dl_Especialidades(Int16 K_Especialidad, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Especialidades";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Especialidad", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Especialidad"].Value = K_Especialidad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Especialidades(Int32 K_Especialidad, string D_Especialidad, string C_Especialidad, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Especialidades";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Especialidad", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Especialidad", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Especialidad", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Especialidad"].Value = K_Especialidad;
            cmd.Parameters["@D_Especialidad"].Value = D_Especialidad;
            cmd.Parameters["@C_Especialidad"].Value = C_Especialidad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Especialidades(ref Int32 K_Especialidad, string D_Especialidad, string C_Especialidad, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Especialidades";

            IDataParameter p_K_Especialidad = new SqlParameter("@K_Especialidad", SqlDbType.SmallInt);
            p_K_Especialidad.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Especialidad);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Especialidad", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@C_Especialidad", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Especialidad"].Value = K_Especialidad;
            cmd.Parameters["@D_Especialidad"].Value = D_Especialidad;
            cmd.Parameters["@C_Especialidad"].Value = C_Especialidad;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Especialidad = (Int16)p_K_Especialidad.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Especialidades()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Especialidades";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //PROFESIONES
        public int Dl_Profesiones(Int16 K_Profecion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Profesiones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Profesion", SqlDbType.TinyInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Profesion"].Value = K_Profecion;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Profesiones(Int32 K_Profecion, string D_Profecion, string C_Profecion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Profesiones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Profesion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Profesion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Profesion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Profesion"].Value = K_Profecion;
            cmd.Parameters["@D_Profesion"].Value = D_Profecion;
            cmd.Parameters["@C_Profesion"].Value = C_Profecion;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Profesiones(ref Int32 K_Profecion, string D_Profecion, string C_Profecion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Profesiones";

            IDataParameter p_K_Profecion = new SqlParameter("@K_Profesion", SqlDbType.Int);
            p_K_Profecion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Profecion);
            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Profesion", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@C_Profesion", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Profesion"].Value = K_Profecion;
            cmd.Parameters["@D_Profesion"].Value = D_Profecion;
            cmd.Parameters["@C_Profesion"].Value = C_Profecion;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Profecion = (Int32)p_K_Profecion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Profesiones()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Profesiones";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //MEDICOS
        public int Dl_Medicos(Int32 K_Medico, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Medicos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Medicos(
            Int32 K_Medico,
            Int32 K_Profesion,
            Int32 K_Especialidad,
            string Nombre,
            string ApePat,
            string ApeMat,
            string Cedula,
            string Telefono,
            string Correo,
            bool B_Tratante,
            bool B_Dictaminador,
            Int32 K_Usuario,
              Int32 K_Aseguradora,
            bool B_Red_Aseguradora,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Medicos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Profesion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Especialidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cedula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Tratante", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Dictaminador", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Red_Aseguradora", SqlDbType.Bit));

            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@K_Profesion"].Value = K_Profesion;
            cmd.Parameters["@K_Especialidad"].Value = K_Especialidad;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@Cedula"].Value = Cedula;
            cmd.Parameters["@Codigo_Celula"].Value = DBNull.Value;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@B_Tratante"].Value = B_Tratante;
            cmd.Parameters["@B_Dictaminador"].Value = B_Dictaminador;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@B_Red_Aseguradora"].Value = B_Red_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Medicos(
            ref Int32 K_Medico,
            Int32 K_Profesion,
            Int32 K_Especialidad,
            string Nombre,
            string ApePat,
            string ApeMat,
            string Cedula,
            string Telefono,
            string Correo,
            bool B_Tratante,
            bool B_Dictaminador,
            Int32 K_Usuario,
            Int32 K_Aseguradora,
            bool B_Red_Aseguradora,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Medicos";

            IDataParameter p_K_Medico = new SqlParameter("@K_Medico", SqlDbType.SmallInt);
            p_K_Medico.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Medico);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Profesion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Especialidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cedula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Tratante", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Dictaminador", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Red_Aseguradora", SqlDbType.Bit));

            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@K_Profesion"].Value = K_Profesion;
            cmd.Parameters["@K_Especialidad"].Value = K_Especialidad;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@Cedula"].Value = Cedula;
            cmd.Parameters["@Codigo_Celula"].Value = DBNull.Value;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@B_Tratante"].Value = B_Tratante;
            cmd.Parameters["@B_Dictaminador"].Value = B_Dictaminador;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@B_Red_Aseguradora"].Value = B_Red_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Medico = (Int16)p_K_Medico.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Medicos_Venta(ref Int32 K_Medico, string Nombre, string ApePat, string ApeMat, string Cedula, string Telefono, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Medicos";

            IDataParameter p_K_Medico = new SqlParameter("@K_Medico", SqlDbType.SmallInt);
            p_K_Medico.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Medico);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cedula", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@B_Tratante", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@Cedula"].Value = Cedula;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@B_Tratante"].Value = true;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Medico = (Int16)p_K_Medico.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Medicos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Medicos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Medicos(string Cedula)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Medicos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@Cedula", SqlDbType.Int));

            if(Cedula.Length==0)
            {
                cmd.Parameters["@Cedula"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Cedula"].Value = Cedula;
            }
           
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Pacientes_Medicos(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Medicos";
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Pacientes_Medicos(
            Int32 K_Medico,
            Int32 K_Paciente,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Medicos";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));


            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Pacientes_Medicos(Int32 K_Medico, Int32 K_Paciente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Medicos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //TIPO PARENTESCO
        public DataTable Sk_Tipo_Parentesco()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Parentesco";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Tipo_Parentesco(Int32 K_Tipo_Parentesco, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Parentesco";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Parentesco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Parentesco"].Value = K_Tipo_Parentesco;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipo_Parentesco(
            Int32 K_Tipo_Parentesco,
            string D_Tipo_Parentesco,
            string C_Tipo_Parentesco,
            Int32 K_Usuario,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Parentesco";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Parentesco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Parentesco", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Parentesco", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Tipo_Parentesco"].Value = K_Tipo_Parentesco;
            cmd.Parameters["@D_Tipo_Parentesco"].Value = D_Tipo_Parentesco;
            cmd.Parameters["@C_Tipo_Parentesco"].Value = C_Tipo_Parentesco;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Tipo_Parentesco(
            ref Int32 K_Tipo_Parentesco,
            string D_Tipo_Parentesco,
            string C_Tipo_Parentesco,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Parentesco";

            IDataParameter p_K_Tipo_Parentesco = new SqlParameter("@K_Tipo_Parentesco", SqlDbType.Int);
            p_K_Tipo_Parentesco.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Parentesco);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Parentesco", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Parentesco", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Parentesco"].Value = K_Tipo_Parentesco;
            cmd.Parameters["@D_Tipo_Parentesco"].Value = D_Tipo_Parentesco;
            cmd.Parameters["@C_Tipo_Parentesco"].Value = C_Tipo_Parentesco;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Parentesco = (Int32)p_K_Tipo_Parentesco.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //PACIENTES CONTACTOS

        public DataTable Sk_Pacientes_Contactos(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Contactos";

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Pacientes_Contactos(Int32 K_Pacientes_Contactos, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Contactos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pacientes_Contactos", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pacientes_Contactos"].Value = K_Pacientes_Contactos;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Pacientes_Contactos(
            ref Int32 K_Pacientes_Contactos,
            Int32 K_Paciente,
            Int32 K_Tipo_Parentesco,
            Int32 K_Tipo_Contacto,
            string Nombre,
            string Apellido_Paterno,
             string Apellido_Materno,
            string Telefono,
             string Correo,
            Int32 K_Usuario,
            ref string Mensaje

            )
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Contactos";

            IDataParameter p_K_Pacientes_Contactos = new SqlParameter("@K_Pacientes_Contactos", SqlDbType.Int);
            p_K_Pacientes_Contactos.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pacientes_Contactos);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Parentesco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Apellido_Paterno", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Apellido_Materno", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pacientes_Contactos"].Value = K_Pacientes_Contactos;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Tipo_Parentesco"].Value = K_Tipo_Parentesco;
            cmd.Parameters["@K_Tipo_Contacto"].Value = K_Tipo_Contacto;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@Apellido_Paterno"].Value = Apellido_Paterno;
            cmd.Parameters["@Apellido_Materno"].Value = Apellido_Materno;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Pacientes_Contactos = (Int32)p_K_Pacientes_Contactos.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //PACIENTES PADECIMIENTOS
        public DataTable Sk_Pacientes_Padecimientos(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Padecimiento";

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Pacientes_Padecimientos(Int32 K_Paciente, string ICD, Int32 K_Padecimiento)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Padecimiento";

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ICD", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@K_Padecimiento", SqlDbType.Int));

            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@ICD"].Value = ICD;
            cmd.Parameters["@K_Padecimiento"].Value = K_Padecimiento;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Pacientes_Padecimiento(Int32 K_Padecimiento, Int32 K_Paciente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Padecimiento";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Padecimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Padecimiento"].Value = K_Padecimiento;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Pacientes_Padecimiento(
            Int32 K_Padecimiento, Int32 K_Paciente, Int32 K_Usuario, ref string Mensaje

            )
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Padecimiento";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Padecimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Padecimiento"].Value = K_Padecimiento;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;



            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        //PADECIMIENTOS
        public DataTable Sk_Padecimientos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Padecimientos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Padecimientos(Int32 K_Padecimiento, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Padecimientos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Padecimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Padecimiento"].Value = K_Padecimiento;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Padecimientos(
            ref Int32 K_Padecimiento,
            string D_Padecimiento,
            string C_Padecimiento,
            string Descripcion_Padecimiento,
            Int32 K_Usuario_Bitacora,
            string ICD,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Padecimientos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Padecimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Padecimiento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Padecimiento", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Padecimiento", SqlDbType.VarChar, 510));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ICD", SqlDbType.VarChar, 10));

            cmd.Parameters["@K_Padecimiento"].Value = K_Padecimiento;
            cmd.Parameters["@D_Padecimiento"].Value = D_Padecimiento;
            cmd.Parameters["@C_Padecimiento"].Value = C_Padecimiento;
            cmd.Parameters["@Descripcion_Padecimiento"].Value = Descripcion_Padecimiento;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@ICD"].Value = ICD;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Padecimientos(
            ref Int32 K_Padecimiento,
            string D_Padecimiento,
            string C_Padecimiento,
            string Descripcion_Padecimiento,
            Int32 K_Usuario,
            string ICD,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Padecimientos";

            IDataParameter p_K_Padecimiento = new SqlParameter("@K_Padecimiento", SqlDbType.Int);
            p_K_Padecimiento.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Padecimiento);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Padecimiento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Padecimiento", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Padecimiento", SqlDbType.VarChar, 510));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ICD", SqlDbType.VarChar, 10));

            cmd.Parameters["@K_Padecimiento"].Value = K_Padecimiento;
            cmd.Parameters["@D_Padecimiento"].Value = D_Padecimiento;
            cmd.Parameters["@C_Padecimiento"].Value = C_Padecimiento;
            cmd.Parameters["@Descripcion_Padecimiento"].Value = Descripcion_Padecimiento;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@ICD"].Value = ICD;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Padecimiento = (Int32)p_K_Padecimiento.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        ///////////////INSTITUCIONES///////////////////////
        public int In_Instituciones(
           ref Int32 K_Institucion,
           string D_Institucion,
           string C_Institucion,
           string RFC_Institucion,
           Int32 K_Usuario,
           ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Instituciones";

            IDataParameter p_K_Institucion = new SqlParameter("@K_Institucion", SqlDbType.Int);
            p_K_Institucion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Institucion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Institucion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@C_Institucion", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@RFC_Institucion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Institucion"].Value = K_Institucion;
            cmd.Parameters["@D_Institucion"].Value = D_Institucion;
            cmd.Parameters["@C_Institucion"].Value = C_Institucion;
            cmd.Parameters["@RFC_Institucion"].Value = RFC_Institucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Institucion = (Int32)p_K_Institucion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Instituciones(Int32 K_Institucion, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Instituciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Institucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Institucion"].Value = K_Institucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Instituciones(
           Int32 K_Institucion,
           string D_Institucion,
           string C_Institucion,
           string RFC_Institucion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Instituciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Institucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Institucion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@C_Institucion", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@RFC_Institucion", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Institucion"].Value = K_Institucion;
            cmd.Parameters["@D_Institucion"].Value = D_Institucion;
            cmd.Parameters["@C_Institucion"].Value = C_Institucion;
            cmd.Parameters["@RFC_Institucion"].Value = RFC_Institucion;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Instituciones()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Instituciones";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        ///////////////TIPO DOCUMENTO///////////////////////
        public int In_Tipo_Documento(
          ref Int32 K_Tipo_Documento,
          string D_Tipo_Documento,
          string C_Tipo_Documento,
          Int32 K_Usuario,
          ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Documento";

            IDataParameter p_K_Tipo_Documento = new SqlParameter("@K_Tipo_Documento", SqlDbType.Int);
            p_K_Tipo_Documento.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Documento);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Documento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Documento", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Documento"].Value = K_Tipo_Documento;
            cmd.Parameters["@D_Tipo_Documento"].Value = D_Tipo_Documento;
            cmd.Parameters["@C_Tipo_Documento"].Value = C_Tipo_Documento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Documento = (Int32)p_K_Tipo_Documento.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipo_Documento(Int32 K_Tipo_Documento, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Documento";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Documento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Documento"].Value = K_Tipo_Documento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipo_Documento(
          Int32 K_Tipo_Documento,
          string D_Tipo_Documento,
          string C_Tipo_Documento,
          Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Documento";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Documento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Documento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@C_Tipo_Documento", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Documento"].Value = K_Tipo_Documento;
            cmd.Parameters["@D_Tipo_Documento"].Value = D_Tipo_Documento;
            cmd.Parameters["@C_Tipo_Documento"].Value = C_Tipo_Documento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipo_Documento()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Documento";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        ///////////////PACIENTES INSTITUCIONES///////////////////////
        public int In_Pacientes_Instituciones(
         Int32 K_Paciente,
         Int32 K_Institucion,
         Int32 K_Usuario,
         ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Instituciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Institucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Institucion"].Value = K_Institucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Pacientes_Instituciones(Int32 K_Paciente,
         Int32 K_Institucion,
         Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Instituciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Institucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Institucion"].Value = K_Institucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pacientes_Instituciones(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Instituciones";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //////////////TIPOS DATOS PACIENTES///////////////////////
        public int In_Tipos_Datos_Pacientes(ref Int32 K_Tipo_Dato, string D_Tipo_Dato, Int32 K_Usuario, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Datos_Pacientes";

            IDataParameter p_K_Tipo_Dato = new SqlParameter("@K_Tipo_Dato", SqlDbType.Int);
            p_K_Tipo_Dato.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Dato);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Dato", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Dato"].Value = K_Tipo_Dato;
            cmd.Parameters["@D_Tipo_Dato"].Value = D_Tipo_Dato;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Dato = (Int32)p_K_Tipo_Dato.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipos_Datos_Pacientes(Int32 K_Tipo_Dato, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Datos_Pacientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Dato", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Dato"].Value = K_Tipo_Dato;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipos_Datos_Pacientes(
           Int32 K_Tipo_Dato,
        string D_Tipo_Dato,
        Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Datos_Pacientes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Dato", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Dato", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Dato"].Value = K_Tipo_Dato;
            cmd.Parameters["@D_Tipo_Dato"].Value = D_Tipo_Dato;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipos_Datos_Pacientes()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Datos_Pacientes";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //Pacientes Telefonos 
        public int In_Pacientes_Telefonos(Int32 K_Paciente, Int32 K_Tipo_Dato, string Codigo_Pais, Int32 Lada, Int32 Telefono, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Telefonos";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Dato", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Pais", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Lada", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Tipo_Dato"].Value = K_Tipo_Dato;
            cmd.Parameters["@Codigo_Pais"].Value = Codigo_Pais;
            cmd.Parameters["@Lada"].Value = Lada;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Pacientes_Telefonos(Int32 K_Paciente_Telefono, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Telefonos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Telefono", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Telefono"].Value = K_Paciente_Telefono;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pacientes_Telefonos(Int32 K_Paciente_Telefono)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Telefonos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente_Telefono;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //Pacientes Direcciones 
        public int In_Pacientes_Direcciones(Int32 K_Paciente, Int32 K_Tipo_Direccion, Int32 K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Colonia,
                     Int32 Codigo_Postal, string Calle, string Numero_Exterior, string Numero_Interior, string Entre_Calles,
                     string Edificio, Int32 Piso, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Direcciones";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Numero_Exterior", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Numero_Interior", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Entre_Calles", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Edificio", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Piso", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Tipo_Direccion"].Value = K_Tipo_Direccion;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@Numero_Exterior"].Value = Numero_Exterior;
            cmd.Parameters["@Numero_Interior"].Value = Numero_Interior;
            cmd.Parameters["@Entre_Calles"].Value = Entre_Calles;
            cmd.Parameters["@Edificio"].Value = Edificio;
            cmd.Parameters["@Piso"].Value = Piso;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }

        public int Dl_Pacientes_Direcciones(Int32 K_Paciente_Direccion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Direcciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Telefono"].Value = K_Paciente_Direccion;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pacientes_Direcciones(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Direcciones";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Pacientes_Direcciones(Int32 K_Paciente, Int32 K_Tipo_Direccion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Direcciones";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Direccion", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Tipo_Direccion"].Value = K_Tipo_Direccion;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //////////////////////PACIENTES CORREOS///////////////////////
        public int In_Pacientes_Correos(
        ref Int32 K_Paciente_Correo,
        Int32 K_Paciente,
        Int32 K_Tipo_Dato,
        string Correo,
        Int32 K_Usuario,
        ref string Mensaje)
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Correos";

            IDataParameter p_K_Paciente_Correo = new SqlParameter("@K_Paciente_Correo", SqlDbType.Int);
            p_K_Paciente_Correo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Paciente_Correo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Dato", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Correo"].Value = K_Paciente_Correo;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Tipo_Dato"].Value = K_Tipo_Dato;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Paciente_Correo = (Int32)p_K_Paciente_Correo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Pacientes_Correos(Int32 K_Paciente,
         Int32 K_Paciente_Correo,
         Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Correos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Correo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Correo"].Value = K_Paciente_Correo;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pacientes_Correos(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Correos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //////////////////////PACIENTES MEDICAMENTOS///////////////////////
        public int In_Pacientes_Medicamentos(
      ref Int32 K_Paciente_Medicamento,
      Int32 K_Paciente,
      Int32 K_Articulo,
      Int32 Cantidad,
      Int32 K_Usuario,
      ref string Mensaje)
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Medicamentos";

            IDataParameter p_K_Paciente_Medicamento = new SqlParameter("@K_Paciente_Medicamento", SqlDbType.Int);
            p_K_Paciente_Medicamento.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Paciente_Medicamento);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Medicamento"].Value = K_Paciente_Medicamento;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@Cantidad"].Value = Cantidad;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Paciente_Medicamento = (Int32)p_K_Paciente_Medicamento.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public int Dl_Pacientes_Medicamentos(Int32 K_Paciente,
         Int32 K_Paciente_Medicamento,
         Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Medicamentos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Medicamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Medicamento"].Value = K_Paciente_Medicamento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pacientes_Medicamentos(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Medicamentos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //////////////////////PACIENTES NOTAS///////////////////////
        public int In_Pacientes_Notas(
        ref Int32 K_Paciente_Nota,
        Int32 K_Paciente,
        string Nota,
       Int32 K_Usuario,
       ref string Mensaje)
        {


            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pacientes_Notas";

            IDataParameter p_K_Paciente_Nota = new SqlParameter("@K_Paciente_Nota", SqlDbType.Int);
            p_K_Paciente_Nota.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Paciente_Nota);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nota", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Nota"].Value = K_Paciente_Nota;
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            cmd.Parameters["@Nota"].Value = Nota;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Paciente_Nota = (Int32)p_K_Paciente_Nota.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Pacientes_Notas(Int32 K_Paciente_Nota,
         Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Pacientes_Notas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Nota", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Paciente_Nota"].Value = K_Paciente_Nota;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Pacientes_Notas(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Notas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //////////////////////TIPOS DIRECCIONES///////////////////////
        public int In_Tipos_Direcciones(ref Int32 K_Tipo_Direccion, string D_Tipo_Direccion, Int32 K_Usuario, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Direcciones";

            IDataParameter p_K_Tipo_Direccion = new SqlParameter("@K_Tipo_Direccion", SqlDbType.Int);
            p_K_Tipo_Direccion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Direccion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Direccion", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Direccion"].Value = K_Tipo_Direccion;
            cmd.Parameters["@D_Tipo_Direccion"].Value = D_Tipo_Direccion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Direccion = (Int32)p_K_Tipo_Direccion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipos_Direcciones(Int32 K_Tipo_Direccion, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Direcciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Direccion"].Value = K_Tipo_Direccion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipos_Direcciones(Int32 K_Tipo_Direccion, string D_Tipo_Direccion, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Direcciones";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Direccion", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Direccion", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Direccion"].Value = K_Tipo_Direccion;
            cmd.Parameters["@D_Tipo_Direccion"].Value = D_Tipo_Direccion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipos_Direcciones()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Direcciones";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //////////////////////PARAMETROS GENERALES///////////////////////
        public int In_Parametros_Generales(ref Int32 K_Parametros_Generales, decimal Monto_Maximo_OCompra, decimal Monto_Maximo_Dif_OCompra, decimal Monto_Autoriza_Req_Nivel1, decimal Monto_Autoriza_Req_Nivel2,
                                          decimal Monto_TercerPiso, decimal Monto_DescEmp, Int32 K_Usuario, decimal Porcentaje_Monedero,decimal Porcentaje_Margen_Ganancia, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Parametros_Generales";

            IDataParameter p_K_Parametros_Generales = new SqlParameter("@K_Parametros_Generales", SqlDbType.Int);
            p_K_Parametros_Generales.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Parametros_Generales);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Monto_Maximo_OCompra", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Maximo_Dif_OCompra", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Autoriza_Req_Nivel1", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Autoriza_Req_Nivel2", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_TercerPiso", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Descuento_Empleado", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Monedero", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Margen_Ganancia", SqlDbType.Money));

            cmd.Parameters["@K_Parametros_Generales"].Value = K_Parametros_Generales;
            cmd.Parameters["@Monto_Maximo_OCompra"].Value = Monto_Maximo_OCompra;
            cmd.Parameters["@Monto_Maximo_Dif_OCompra"].Value = Monto_Maximo_Dif_OCompra;
            cmd.Parameters["@Monto_Autoriza_Req_Nivel1"].Value = Monto_Autoriza_Req_Nivel1;
            cmd.Parameters["@Monto_Autoriza_Req_Nivel2"].Value = Monto_Autoriza_Req_Nivel2;
            cmd.Parameters["@Monto_TercerPiso"].Value = Monto_TercerPiso;
            cmd.Parameters["@Monto_Descuento_Empleado"].Value = Monto_DescEmp;
            cmd.Parameters["@Porcentaje_Monedero"].Value = Porcentaje_Monedero;
            cmd.Parameters["@Porcentaje_Margen_Ganancia"].Value = Porcentaje_Margen_Ganancia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Parametros_Generales = (Int32)p_K_Parametros_Generales.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Parametros_Generales(Int32 K_Parametros_Generales, decimal Monto_Maximo_OCompra, decimal Monto_Maximo_Dif_OCompra, decimal Monto_Autoriza_Req_Nivel1, decimal Monto_Autoriza_Req_Nivel2,
                                           decimal Monto_TercerPiso, decimal Monto_DescEmp, Int32 K_Usuario, decimal Porcentaje_Monedero, decimal Porcentaje_Margen_Ganancia, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Parametros_Generales";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Parametros_Generales", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Monto_Maximo_OCompra", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Maximo_Dif_OCompra", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Autoriza_Req_Nivel1", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Autoriza_Req_Nivel2", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_TercerPiso", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Monto_Descuento_Empleado", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Monedero", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Margen_Ganancia", SqlDbType.Money));

            cmd.Parameters["@K_Parametros_Generales"].Value = K_Parametros_Generales;
            cmd.Parameters["@Monto_Maximo_OCompra"].Value = Monto_Maximo_OCompra;
            cmd.Parameters["@Monto_Maximo_Dif_OCompra"].Value = Monto_Maximo_Dif_OCompra;
            cmd.Parameters["@Monto_Autoriza_Req_Nivel1"].Value = Monto_Autoriza_Req_Nivel1;
            cmd.Parameters["@Monto_Autoriza_Req_Nivel2"].Value = Monto_Autoriza_Req_Nivel2;
            cmd.Parameters["@Monto_TercerPiso"].Value = Monto_TercerPiso;
            cmd.Parameters["@Monto_Descuento_Empleado"].Value = Monto_DescEmp;
            cmd.Parameters["@Porcentaje_Monedero"].Value = Porcentaje_Monedero;
            cmd.Parameters["@Porcentaje_Margen_Ganancia"].Value = Porcentaje_Margen_Ganancia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Parametros_Generales()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Parametros_Generales";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        //////////////////////MOTIVOS CANCELACION SERVICIOS AMBULANCIA///////////////////////
        public int In_Motivo_Cancelacion_ServiciosAmbulancia(ref Int32 K_Motivo_Cancelacion_ServiciosAmbulancia, string D_Motivo_Cancelacion_ServiciosAmbulancia, Int32 K_Usuario, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivo_Cancelacion_ServiciosAmbulancia";

            IDataParameter p_K_Motivo_Cancelacion_ServiciosAmbulancia = new SqlParameter("@K_Motivo_Cancelacion_ServiciosAmbulancia", SqlDbType.Int);
            p_K_Motivo_Cancelacion_ServiciosAmbulancia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Cancelacion_ServiciosAmbulancia);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Cancelacion_ServiciosAmbulancia", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosAmbulancia"].Value = K_Motivo_Cancelacion_ServiciosAmbulancia;
            cmd.Parameters["@D_Motivo_Cancelacion_ServiciosAmbulancia"].Value = D_Motivo_Cancelacion_ServiciosAmbulancia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivo_Cancelacion_ServiciosAmbulancia = (Int32)p_K_Motivo_Cancelacion_ServiciosAmbulancia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Motivo_Cancelacion_ServiciosAmbulancia(Int32 K_Motivo_Cancelacion_ServiciosAmbulancia, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivo_Cancelacion_ServiciosAmbulancia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion_ServiciosAmbulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosAmbulancia"].Value = K_Motivo_Cancelacion_ServiciosAmbulancia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Motivo_Cancelacion_ServiciosAmbulancia(Int32 K_Motivo_Cancelacion_ServiciosAmbulancia, string D_Motivo_Cancelacion_ServiciosAmbulancia, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivo_Cancelacion_ServiciosAmbulancia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion_ServiciosAmbulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Cancelacion_ServiciosAmbulancia", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Cancelacion_ServiciosAmbulancia"].Value = K_Motivo_Cancelacion_ServiciosAmbulancia;
            cmd.Parameters["@D_Motivo_Cancelacion_ServiciosAmbulancia"].Value = D_Motivo_Cancelacion_ServiciosAmbulancia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Motivo_Cancelacion_ServiciosAmbulancia()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Cancelacion_ServiciosAmbulancia";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        ///////////////AMBULANCIAS///////////////////////
        public int In_Ambulancias(ref Int32 K_Ambulancia, string D_Economico, Int32 K_Usuario, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Ambulancias";

            IDataParameter p_K_Ambulancia = new SqlParameter("@K_Ambulancia", SqlDbType.Int);
            p_K_Ambulancia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Ambulancia);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Economico", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Ambulancia"].Value = K_Ambulancia;
            cmd.Parameters["@D_Economico"].Value = D_Economico;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Ambulancia = (Int32)p_K_Ambulancia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Ambulancias(Int32 K_Ambulancia, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Ambulancia"].Value = K_Ambulancia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Ambulancias(Int32 K_Ambulancia, string D_Economico, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Ambulancias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Ambulancia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Economico", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Ambulancia"].Value = K_Ambulancia;
            cmd.Parameters["@D_Economico"].Value = D_Economico;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Ambulancias()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Ambulancias";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Kits_Enfermeria(Int32 K_Clase_ServicioEnfermeria, Int32 K_Tipo_Servicio_Enfermeria, Int32 K_Articulo, Int32 Cantidad, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Kits_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@Cantidad"].Value = Cantidad;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable SK_Kits_Enfermeria_Disponiblesbulancias(Int32 K_Clase_ServicioEnfermeria, Int32 K_Tipo_Servicio_Enfermeria)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Kits_Enfermeria_Disponibles";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable SK_Kits_Enfermeria(Int32 K_Clase_ServicioEnfermeria, Int32 K_Tipo_Servicio_Enfermeria)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Kits_Enfermeria";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Kits_Enfermeria(Int32 K_Clase_ServicioEnfermeria, Int32 K_Tipo_Servicio_Enfermeria, Int32 K_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Kits_Enfermeria";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Servicio_Enfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clase_ServicioEnfermeria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Servicio_Enfermeria"].Value = K_Tipo_Servicio_Enfermeria;
            cmd.Parameters["@K_Clase_ServicioEnfermeria"].Value = K_Clase_ServicioEnfermeria;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        ///////////////ALMACENES///////////////////////
        public int In_Almacenes(
            ref Int32 K_Almacen,
            Int32 K_Oficina,
            string D_Almacen,
            bool B_AceptaDevolucionesCliente,
            Int32 K_Usuario,
            string Cuenta,
            string C_Almacen,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Almacenes";

            IDataParameter p_K_Almacen = new SqlParameter("@K_Almacen", SqlDbType.Int);
            p_K_Almacen.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Almacen);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Almacen", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_AceptaDevolucionesCliente", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@C_Almacen", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@D_Almacen"].Value = D_Almacen;
            cmd.Parameters["@B_AceptaDevolucionesCliente"].Value = B_AceptaDevolucionesCliente;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@C_Almacen"].Value = C_Almacen;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Almacen = (Int32)p_K_Almacen.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Almacenes(
            Int32 K_Almacen,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Almacenes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Almacenes(
            Int32 K_Almacen,
            Int32 K_Oficina,
            string D_Almacen,
            bool B_AceptaDevolucionesCliente,
            Int32 K_Usuario,
            string Cuenta,
            string C_Almacen,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Almacenes";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Almacen", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_AceptaDevolucionesCliente", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@C_Almacen", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@D_Almacen"].Value = D_Almacen;
            cmd.Parameters["@B_AceptaDevolucionesCliente"].Value = B_AceptaDevolucionesCliente;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@C_Almacen"].Value = C_Almacen;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Almacenes()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Almacenes";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Almacenes(Int32 K_Oficina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Almacenes";
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
        public DataTable Sk_Almacenes_Empresa()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Almacenes";
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Almacenes_x_Usuario(Int32 K_Usuario, Int32 K_Oficina,Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Almacenes_x_Usuario";
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            if(K_Usuario==0)
            {
                cmd.Parameters["@K_Usuario"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            }
            if (K_Oficina == 0)
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            if(K_Empresa ==0)
            {
                cmd.Parameters["@K_Empresa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            }
            
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Almacenes(Int32 K_Oficina, Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Almacenes";
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        ///////////////TIPOS MOVIMIENTO ALMACEN///////////////////////
        public int In_Tipos_Movimiento_Almacen(
            ref Int32 K_Tipo_Movimiento,
            string D_Tipo_Movimiento,
            bool B_Entrada,
            bool B_Salida,
            bool B_Traspaso,
            bool B_Ajuste,
            bool B_Reservado,
            Int32 K_Usuario,
            ref string Mensaje)

        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Movimiento_Almacen";

            IDataParameter p_K_Tipo_Movimiento = new SqlParameter("@K_Tipo_Movimiento", SqlDbType.Int);
            p_K_Tipo_Movimiento.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Movimiento);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Movimiento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Entrada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Salida", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Traspaso", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Ajuste", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Reservado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Movimiento"].Value = K_Tipo_Movimiento;
            cmd.Parameters["@D_Tipo_Movimiento"].Value = D_Tipo_Movimiento;
            cmd.Parameters["@B_Entrada"].Value = B_Entrada;
            cmd.Parameters["@B_Salida"].Value = B_Salida;
            cmd.Parameters["@B_Traspaso"].Value = B_Traspaso;
            cmd.Parameters["@B_Ajuste"].Value = B_Ajuste;
            cmd.Parameters["@B_Reservado"].Value = B_Reservado;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Movimiento = (Int32)p_K_Tipo_Movimiento.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipos_Movimiento_Almacen(
            Int32 K_Tipo_Movimiento,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Movimiento_Almacen";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Movimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Movimiento"].Value = K_Tipo_Movimiento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipos_Movimiento_Almacen(
            Int32 K_Tipo_Movimiento,
            string D_Tipo_Movimiento,
            bool B_Entrada,
            bool B_Salida,
            bool B_Traspaso,
            bool B_Ajuste,
            bool B_Reservado,
            Int32 K_Usuario,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Movimiento_Almacen";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Movimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Movimiento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Entrada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Salida", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Traspaso", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Ajuste", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Reservado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Movimiento"].Value = K_Tipo_Movimiento;
            cmd.Parameters["@D_Tipo_Movimiento"].Value = D_Tipo_Movimiento;
            cmd.Parameters["@B_Entrada"].Value = B_Entrada;
            cmd.Parameters["@B_Salida"].Value = B_Salida;
            cmd.Parameters["@B_Traspaso"].Value = B_Traspaso;
            cmd.Parameters["@B_Ajuste"].Value = B_Ajuste;
            cmd.Parameters["@B_Reservado"].Value = B_Reservado;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipos_Movimiento_Almacen()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Movimiento_Almacen";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        ////////////////MOTIVOS DEVOLUCION/////////////////////
        public int In_Motivos_Devolucion(
            ref Int32 K_Motivo_Devolucion,
            string D_Motivo_Devolucion,
            Int32 K_Usuario,
            ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivos_Devolucion";

            IDataParameter p_K_Motivo_Devolucion = new SqlParameter("@K_Motivo_Devolucion", SqlDbType.Int);
            p_K_Motivo_Devolucion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Devolucion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Devolucion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Devolucion"].Value = K_Motivo_Devolucion;
            cmd.Parameters["@D_Motivo_Devolucion"].Value = D_Motivo_Devolucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivo_Devolucion = (Int32)p_K_Motivo_Devolucion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Motivos_Devolucion(
            Int32 K_Motivo_Devolucion,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivos_Devolucion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Devolucion"].Value = K_Motivo_Devolucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Motivos_Devolucion(
            Int32 K_Motivo_Devolucion,
            string D_Motivo_Devolucion,
            Int32 K_Usuario,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivos_Devolucion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Devolucion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Devolucion"].Value = K_Motivo_Devolucion;
            cmd.Parameters["@D_Motivo_Devolucion"].Value = D_Motivo_Devolucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Motivos_Devolucion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivos_Devolucion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        ////////////////ESTATUS DEVOLUCION/////////////////////
        public int In_Estatus_Devolucion(
            ref Int32 K_Estatus_Devolucion,
            string D_Estatus_Devolucion,
            Int32 K_Usuario,
            ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estatus_Devolucion";

            IDataParameter p_K_Estatus_Devolucion = new SqlParameter("@K_Estatus_Devolucion", SqlDbType.Int);
            p_K_Estatus_Devolucion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estatus_Devolucion);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Devolucion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Devolucion"].Value = K_Estatus_Devolucion;
            cmd.Parameters["@D_Estatus_Devolucion"].Value = D_Estatus_Devolucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Estatus_Devolucion = (Int32)p_K_Estatus_Devolucion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Estatus_Devolucion(
            Int32 K_Estatus_Devolucion,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estatus_Devolucion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Devolucion"].Value = K_Estatus_Devolucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Estatus_Devolucion(
            Int32 K_Estatus_Devolucion,
            string D_Estatus_Devolucion,
            Int32 K_Usuario,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estatus_Devolucion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Devolucion", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Devolucion"].Value = K_Estatus_Devolucion;
            cmd.Parameters["@D_Estatus_Devolucion"].Value = D_Estatus_Devolucion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Estatus_Devolucion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estatus_Devolucion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Estatus_Pedido(ref Int32 K_Estatus_Pedido, string D_Estatus_Pedido, bool B_Aplica_Pedido, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estatus_Pedido";

            IDataParameter p_K_Estatus_Pedido = new SqlParameter("@K_Estatus_Pedido", SqlDbType.SmallInt);
            p_K_Estatus_Pedido.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estatus_Pedido);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Pedido", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Pedido", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            cmd.Parameters["@D_Estatus_Pedido"].Value = D_Estatus_Pedido;
            cmd.Parameters["@B_Aplica_Pedido"].Value = B_Aplica_Pedido;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Estatus_Pedido = (Int16)p_K_Estatus_Pedido.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Estatus_Pedido(Int32 K_Estatus_Pedido, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estatus_Pedido";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Estatus_Pedido(Int32 K_Estatus_Pedido, string D_Estatus_Pedido, bool B_Aplica_Pedido, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estatus_Pedido";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Pedido", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Pedido", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            cmd.Parameters["@D_Estatus_Pedido"].Value = D_Estatus_Pedido;
            cmd.Parameters["@B_Aplica_Pedido"].Value = B_Aplica_Pedido;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Estatus_Pedido()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estatus_Pedido";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public int In_Cliente_Domicilios_Fiscales(
            ref Int32 K_Cliente_Domicilio_Fiscal,
            Int32 K_Cliente,
            Int32 K_Pais,
            Int32 K_Estado,
            Int32 K_Ciudad,
            Int32 K_Colonia,
            string Calle,
            string Numero_Exterior,
            string Numero_Interior,
            string Telefono,
            Int32 Codigo_Postal,
            Int32 K_Usuario,
            DateTime Ultima_Modificacion,
            bool B_Activo,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cliente_Domicilios_Fiscales";

            IDataParameter p_K_Cliente_Domicilio_Fiscal = new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.SmallInt);
            p_K_Cliente_Domicilio_Fiscal.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cliente_Domicilio_Fiscal);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pais", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ciudad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Colonia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Numero_Exterior", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Numero_Interior", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Postal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Ultima_Modificacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Activo", SqlDbType.Bit));

            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Pais"].Value = K_Pais;
            cmd.Parameters["@K_Estado"].Value = K_Estado;
            cmd.Parameters["@K_Ciudad"].Value = K_Ciudad;
            cmd.Parameters["@K_Colonia"].Value = K_Colonia;
            cmd.Parameters["@Calle"].Value = Calle;
            cmd.Parameters["@Numero_Exterior"].Value = Numero_Exterior;
            cmd.Parameters["@Numero_Interior"].Value = Numero_Interior;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Codigo_Postal"].Value = Codigo_Postal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Ultima_Modificacion"].Value = Ultima_Modificacion;
            cmd.Parameters["@B_Activo"].Value = B_Activo;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cliente_Domicilio_Fiscal = (Int16)p_K_Cliente_Domicilio_Fiscal.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Cliente_Domicilios_Fiscales(Int32 K_Cliente, Int32 K_Cliente_Domicilio_Fiscal, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cliente_Domicilios_Fiscales";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente_Domicilio_Fiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Cliente_Domicilio_Fiscal"].Value = K_Cliente_Domicilio_Fiscal;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Cliente_Domicilios_Fiscales(Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cliente_Domicilios_Fiscales";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Gp_CambiaOficina(
           Int32 K_Usuario,
           Int32 K_Oficina_Pertence,
           Int32 K_Oficina,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_CambiaOficina";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Pertenece", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Oficina_Pertenece"].Value = K_Oficina_Pertence;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Motivo_Transferencia(ref Int32 K_Motivo_Transferencia, string D_Motivo_Transferencia, Int32 K_Usuario, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivo_Transferencia";

            IDataParameter p_K_Motivo_Transferencia = new SqlParameter("@K_Motivo_Transferencia", SqlDbType.Int);
            p_K_Motivo_Transferencia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Transferencia);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Transferencia", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Transferencia"].Value = K_Motivo_Transferencia;
            cmd.Parameters["@D_Motivo_Transferencia"].Value = D_Motivo_Transferencia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivo_Transferencia = (Int32)p_K_Motivo_Transferencia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Motivo_Transferencia(Int32 K_Motivo_Transferencia, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivo_Transferencia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Transferencia"].Value = K_Motivo_Transferencia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Motivo_Transferencia(Int32 K_Motivo_Transferencia, string D_Motivo_Transferencia, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivo_Transferencia";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Transferencia", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Transferencia"].Value = K_Motivo_Transferencia;
            cmd.Parameters["@D_Motivo_Transferencia"].Value = D_Motivo_Transferencia;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Motivos_Transferencia()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivos_Transferencia";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Motivo_Rechazo_Solicitud(ref Int16 K_Motivo_Rechazo_Solicitud, string D_Motivo_Rechazo_Solicitud, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivo_Rechazo_Solicitud";

            IDataParameter p_K_Motivo_Rechazo_Solicitud = new SqlParameter("@K_Motivo_Rechazo_Solicitud", SqlDbType.SmallInt);
            p_K_Motivo_Rechazo_Solicitud.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Rechazo_Solicitud);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Rechazo_Solicitud", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Rechazo_Solicitud"].Value = K_Motivo_Rechazo_Solicitud;
            cmd.Parameters["@D_Motivo_Rechazo_Solicitud"].Value = D_Motivo_Rechazo_Solicitud;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Motivo_Rechazo_Solicitud = (Int16)p_K_Motivo_Rechazo_Solicitud.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Motivo_Rechazo_Solicitud(Int16 K_Motivo_Rechazo_Solicitud, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivo_Rechazo_Solicitud";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Rechazo_Solicitud", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Rechazo_Solicitud"].Value = K_Motivo_Rechazo_Solicitud;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Motivo_Rechazo_Solicitud(Int16 K_Motivo_Rechazo_Solicitud, string D_Motivo_Rechazo_Solicitud, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivo_Rechazo_Solicitud";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Rechazo_Solicitud", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Rechazo_Solicitud", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Rechazo_Solicitud"].Value = K_Motivo_Rechazo_Solicitud;
            cmd.Parameters["@D_Motivo_Rechazo_Solicitud"].Value = D_Motivo_Rechazo_Solicitud;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Motivo_Rechazo_Solicitud()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Rechazo_Solicitud";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Tipo_Entrega(
            ref Int32 K_Tipo_Entrega,
            string D_Tipo_Entrega,
            Int32 K_Usuario,
            ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Entrega";

            IDataParameter p_K_Tipo_Entrega = new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int);
            p_K_Tipo_Entrega.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Entrega);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Entrega", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
            cmd.Parameters["@D_Tipo_Entrega"].Value = D_Tipo_Entrega;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Entrega = (Int32)p_K_Tipo_Entrega.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Tipo_Entrega(
            Int32 K_Tipo_Entrega,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipo_Entrega";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipo_Entrega(
            Int32 K_Tipo_Entrega,
            string D_Tipo_Entrega,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Entrega";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Entrega", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
            cmd.Parameters["@D_Tipo_Entrega"].Value = D_Tipo_Entrega;


            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipo_Entrega()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Entrega";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //public DataTable Sk_Empresa_Entrega()
        //{
        //    SqlCommand cmd = ConnectionClass.GetCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "Sk_Empresa_Entrega";
        //    DataTable dt = new DataTable();
        //    dt = ConnectionClass.GetTable(ref cmd);
        //    return dt;
        //}

        public int In_Proveedores_Cuentas_Bancarias(
            ref int K_Cuenta_Proveedor,
            Int32 K_Banco,
            Int32 K_Proveedor,
            string  Numero_Cuenta,
            string Cuenta_Clabe,
            bool B_Transferencia,
            bool B_Cheque,
            bool B_Dolares,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Proveedores_Cuentas_Bancarias";

            IDataParameter p_K_Cuenta_Proveedor = new SqlParameter("@K_Cuenta_Proveedor", SqlDbType.Int);
            p_K_Cuenta_Proveedor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cuenta_Proveedor);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.VarChar,50));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Clabe", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@B_Transferencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cheque", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Dolares", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Proveedor"].Value = K_Cuenta_Proveedor;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Cuenta_Clabe"].Value = Cuenta_Clabe;
            cmd.Parameters["@B_Transferencia"].Value = B_Transferencia;
            cmd.Parameters["@B_Cheque"].Value = B_Cheque;
            cmd.Parameters["@B_Dolares"].Value = B_Dolares;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            K_Cuenta_Proveedor = (Int32)p_K_Cuenta_Proveedor.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Proveedores_Cuentas_Bancarias(
            Int32 K_Cuenta_Proveedor,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Proveedores_Cuentas_Bancarias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));


            cmd.Parameters["@K_Cuenta_Proveedor"].Value = K_Cuenta_Proveedor;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_proveedores_cuentas_bancarias(Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_proveedores_cuentas_bancarias";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));


            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Up_Proveedores_Cuentas_Bancarias(
            Int32 K_Cuenta_Proveedor,
            Int32 K_Banco,
            Int32 K_Proveedor,
            Int32 Numero_Cuenta,
            Int32 Cuenta_Clabe,
            bool B_Transferencia,
            bool B_Cheque,
             bool B_Dolares,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Proveedores_Cuentas_Bancarias";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Clabe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Transferencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cheque", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Dolares", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Proveedor"].Value = K_Cuenta_Proveedor;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Cuenta_Clabe"].Value = Cuenta_Clabe;
            cmd.Parameters["@B_Transferencia"].Value = B_Transferencia;
            cmd.Parameters["@B_Cheque"].Value = B_Cheque;
            cmd.Parameters["@B_Dolares"].Value = B_Dolares;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;


            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Empresa_Cuentas(bool B_SoloActivos)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Empresa_Cuentas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_SoloActivos", SqlDbType.Bit));
            cmd.Parameters["@B_SoloActivos"].Value = B_SoloActivos;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Tipos_Pago()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Pago";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Tipos_Pago(bool B_Aplica_CXC)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Pago";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXC", SqlDbType.Bit));
            cmd.Parameters["@B_Aplica_CXC"].Value = B_Aplica_CXC;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Tipos_Pago(
          ref Int32 K_Tipo_Pago,
          String D_Tipo_Pago,
          Boolean B_Aplica_CXP,
          Boolean B_Aplica_CXC,
          Boolean B_NotaCredito,
          Boolean B_Incobrable,
          Boolean B_Aplica_Venta,
          Int32 K_Usuario,
         ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Pago";

            IDataParameter p_K_Tipo_Pago = new SqlParameter("@K_Tipo_Pago", SqlDbType.Int);
            p_K_Tipo_Pago.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Pago);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Pago", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXP", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXC", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_NotaCredito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Incobrable", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Venta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Pago"].Value = K_Tipo_Pago;
            cmd.Parameters["@D_Tipo_Pago"].Value = D_Tipo_Pago;
            cmd.Parameters["@B_Aplica_CXP"].Value = B_Aplica_CXP;
            cmd.Parameters["@B_Aplica_CXC"].Value = B_Aplica_CXC;
            cmd.Parameters["@B_NotaCredito"].Value = B_NotaCredito;
            cmd.Parameters["@B_Incobrable"].Value = B_Incobrable;
            cmd.Parameters["@B_Aplica_Venta"].Value = B_Aplica_Venta;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Pago(
          Boolean B_Aplica_CXP,
          Boolean B_Aplica_CXC,
          Boolean B_NotaCredito,
          Boolean B_Incobrable,
          Boolean B_Aplica_Venta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Pago";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXP", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXC", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_NotaCredito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Incobrable", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Venta", SqlDbType.Bit));

            cmd.Parameters["@B_Aplica_CXP"].Value = B_Aplica_CXP;
            cmd.Parameters["@B_Aplica_CXC"].Value = B_Aplica_CXC;
            cmd.Parameters["@B_NotaCredito"].Value = B_NotaCredito;
            cmd.Parameters["@B_Incobrable"].Value = B_Incobrable;
            cmd.Parameters["@B_Aplica_Venta"].Value = B_Aplica_Venta;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Up_Tipos_Pago(
          Int32 K_Tipo_Pago,
          String D_Tipo_Pago,
          Boolean B_Aplica_CXP,
          Boolean B_Aplica_CXC,
          Boolean B_NotaCredito,
          Boolean B_Incobrable,
          Boolean B_Aplica_Venta,
          Int32 K_Usuario,
         ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Pago";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Pago", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXP", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_CXC", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_NotaCredito", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Incobrable", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Aplica_Venta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Tipo_Pago"].Value = K_Tipo_Pago;
            cmd.Parameters["@D_Tipo_Pago"].Value = D_Tipo_Pago;
            cmd.Parameters["@B_Aplica_CXP"].Value = B_Aplica_CXP;
            cmd.Parameters["@B_Aplica_CXC"].Value = B_Aplica_CXC;
            cmd.Parameters["@B_NotaCredito"].Value = B_NotaCredito;
            cmd.Parameters["@B_Incobrable"].Value = B_Incobrable;
            cmd.Parameters["@B_Aplica_Venta"].Value = B_Aplica_Venta;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public DataTable Sk_Empresa_Cuentas(Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Empresa_Cuentas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Imagenes_Venta(ref Int16 K_Imagen_Venta, string D_Imagen_Venta, PictureBox imagen, ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Imagenes_Venta";

            IDataParameter p_K_Imagen_Venta = new SqlParameter("@K_Imagen_Venta", SqlDbType.SmallInt);
            p_K_Imagen_Venta.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Imagen_Venta);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Imagen_Venta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.Text);
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Imagen_Venta"].Value = K_Imagen_Venta;
            cmd.Parameters["@D_Imagen_Venta"].Value = D_Imagen_Venta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;


            // Asignando el valor de la imagen
            if (imagen.Image != null)
            {            // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                //cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.Parameters["@Imagen"].Value = Convert.ToBase64String(ms.GetBuffer());
            }


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Imagen_Venta = (Int16)p_K_Imagen_Venta.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Imagenes_Venta(Int16 K_Imagen_Venta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Imagenes_Venta";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Imagen_Venta", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Imagen_Venta"].Value = K_Imagen_Venta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Imagenes_Venta(Int16 K_Imagen_Venta, string D_Imagen_Venta, PictureBox imagen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Imagenes_Venta";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Imagen_Venta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Imagen_Venta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.Text);

            cmd.Parameters["@K_Imagen_Venta"].Value = K_Imagen_Venta;
            cmd.Parameters["@D_Imagen_Venta"].Value = D_Imagen_Venta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            // Asignando el valor de la imagen
            if (imagen.Image != null)
            {
                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                //cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.Parameters["@Imagen"].Value = Convert.ToBase64String(ms.GetBuffer());
            }
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Imagenes_Venta()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Imagenes_Venta";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Asesores(ref Int32 K_Asesor, Int32 K_Usuario, string D_Asesor, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Asesores";

            IDataParameter p_K_Asesor = new SqlParameter("@K_Asesor", SqlDbType.Int);
            p_K_Asesor.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Asesor);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            cmd.Parameters["@Nombre"].Value = D_Asesor;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Asesor = (Int32)p_K_Asesor.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Asesores(
            Int32 K_Asesor,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Asesores";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Asesores(
            Int32 K_Asesor, string D_Asesor, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Asesores";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            cmd.Parameters["@Nombre"].Value = D_Asesor;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Asesores()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Asesores";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //
        public int In_Asesores_TipoComision(Int32 K_Asesor, Int32 Cantidad_Dias, decimal Porcentaje_Comision, ref string Mensaje)
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Asesores_TipoComision";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Dias", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Comision", SqlDbType.Decimal));

            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            cmd.Parameters["@Cantidad_Dias"].Value = Cantidad_Dias;
            cmd.Parameters["@Porcentaje_Comision"].Value = Porcentaje_Comision;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Asesores_TIpoComision(
            Int32 K_Asesor,
            Int32 Dias,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Asesores_TIpoComision";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Dias", SqlDbType.Int));

            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            cmd.Parameters["@Cantidad_Dias"].Value = Dias;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Asesores_TipoComision(Int32 K_Asesor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Asesores_TipoComision";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Pacientes(Int32 K_Aseguradora, Int32 K_Empresa)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            if(K_Aseguradora == 0)
            {
                cmd.Parameters["@K_Aseguradora"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            }
            if(K_Empresa == 0)
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
     
        public DataTable Sk_Pacientes_Top(Int32 K_Aseguradora, Int32 K_Empresa,string Nombre, Int32 K_Paciente, Int32 K_Tipo_Paciente,Int32 K_Genero,Int32 K_Nacionalidad,Int32 K_Estado_Civil,Int32 K_Tipo_Sangre)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_Top";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar,100));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Genero", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Nacionalidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estado_Civil", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Sangre", SqlDbType.Int));

            if (K_Aseguradora == 0)
            {
                cmd.Parameters["@K_Aseguradora"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            }

            if (K_Empresa == 0)
            {
                cmd.Parameters["@K_Empresa"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            }

            if (Nombre.Length == 0)
            {
                cmd.Parameters["@Nombre"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Nombre"].Value = Nombre;
            }

            if (K_Paciente == 0)
            {
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            }

            if (K_Tipo_Paciente == 0)
            {
                cmd.Parameters["@K_Tipo_Paciente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Paciente"].Value = K_Tipo_Paciente;
            }

            if (K_Genero == 0)
            {
                cmd.Parameters["@K_Genero"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Genero"].Value = K_Genero;
            }

            if (K_Nacionalidad == 0)
            {
                cmd.Parameters["@K_Nacionalidad"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Nacionalidad"].Value = K_Nacionalidad;
            }

            if (K_Estado_Civil == 0)
            {
                cmd.Parameters["@K_Estado_Civil"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Estado_Civil"].Value = K_Estado_Civil;
            }

            if (K_Tipo_Sangre == 0)
            {
                cmd.Parameters["@K_Tipo_Sangre"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Sangre"].Value = K_Tipo_Sangre;
            }
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Medicos_Dictaminadores(Int32 K_Medico_Dictaminador, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Medicos_Dictaminadores";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Medico_Dictaminador", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Medico_Dictaminador"].Value = K_Medico_Dictaminador;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Medicos_Dictaminadores(
            Int32 K_Medico_Dictaminador,
            string Nombre,
            string ApePat,
            string ApeMat,
            Int32 K_Aseguradora,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Medicos_Dictaminadores";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Medico_Dictaminador", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Medico_Dictaminador"].Value = K_Medico_Dictaminador;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Medicos_Dictaminadores(
            ref Int32 K_Medico_Dictaminador,
            string Nombre,
            string ApePat,
            string ApeMat,
            Int32 K_Aseguradora,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Medicos_Dictaminadores";

            IDataParameter p_K_Medico_Dictaminador = new SqlParameter("@K_Medico_Dictaminador", SqlDbType.SmallInt);
            p_K_Medico_Dictaminador.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Medico_Dictaminador);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApePat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@ApeMat", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Medico_Dictaminador"].Value = K_Medico_Dictaminador;
            cmd.Parameters["@Nombre"].Value = Nombre;
            cmd.Parameters["@ApePat"].Value = ApePat;
            cmd.Parameters["@ApeMat"].Value = ApeMat;
            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Medico_Dictaminador = (Int16)p_K_Medico_Dictaminador.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Medicos_Dictaminadores()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Medicos_Dictaminadores";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Medicos_Dictaminadores(Int32 K_Aseguradora)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Medicos_Dictaminadores";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));

            cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //CUENTAS EMPRESA 

        public int Dl_Empresa_Cuentas(Int16 K_Cuenta_Empresa, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Empresa_Cuentas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Empresa"].Value = K_Cuenta_Empresa;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario ;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;


        }


        public int Up_Empresa_Cuentas(Int32 K_Cuenta_Empresa, Int32 K_Banco, string Numero_Cuenta, string Cuenta_Clabe,
                                       string Plaza, string Sucursal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Empresa_Cuentas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Clabe", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Plaza", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Sucursal", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Empresa"].Value = K_Cuenta_Empresa;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Cuenta_Clabe"].Value = Cuenta_Clabe;
            cmd.Parameters["@Plaza"].Value = Plaza;
            cmd.Parameters["@Sucursal"].Value = Sucursal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int In_Empresa_Cuentas(ref Int32 K_Cuenta_Empresa, Int32 K_Empresa, Int32 K_Banco, string Numero_Cuenta, string Cuenta_Clabe,
                               string Plaza, string Sucursal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Empresa_Cuentas";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            IDataParameter p_K_Cuenta = new SqlParameter("@K_Cuenta_Empresa", SqlDbType.SmallInt);
            p_K_Cuenta.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cuenta);

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Clabe", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Plaza", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Sucursal", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@K_Cuenta_Empresa"].Value = K_Cuenta_Empresa;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Cuenta_Clabe"].Value = Cuenta_Clabe;
            cmd.Parameters["@Plaza"].Value = Plaza;
            cmd.Parameters["@Sucursal"].Value = Sucursal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cuenta_Empresa = (Int16)p_K_Cuenta.Value;
            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int Dl_Cliente_Cuentas(Int16 K_Cuenta_Cliente, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cliente_Cuentas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;


        }


        public int Up_Cliente_Cuentas(Int32 K_Cuenta_Cliente, Int32 K_Banco, decimal Numero_Cuenta, string Cuenta_Clabe,
                                       string Plaza, string Sucursal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cliente_Cuentas";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Clabe", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Plaza", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Sucursal", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Cuenta_Clabe"].Value = Cuenta_Clabe;
            cmd.Parameters["@Plaza"].Value = Plaza;
            cmd.Parameters["@Sucursal"].Value = Sucursal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;
        }
        public int In_Cliente_Cuentas(ref Int32 K_Cuenta_Cliente, Int32 K_Cliente, Int32 K_Banco, decimal Numero_Cuenta, string Cuenta_Clabe,
                               string Plaza, string Sucursal, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cliente_Cuentas";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            IDataParameter p_K_Cuenta = new SqlParameter("@K_Cuenta_Cliente", SqlDbType.SmallInt);
            p_K_Cuenta.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cuenta);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Banco", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Numero_Cuenta", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Cuenta_Clabe", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Plaza", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@Sucursal", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Cuenta_Cliente"].Value = K_Cuenta_Cliente;
            cmd.Parameters["@K_Banco"].Value = K_Banco;
            cmd.Parameters["@Numero_Cuenta"].Value = Numero_Cuenta;
            cmd.Parameters["@Cuenta_Clabe"].Value = Cuenta_Clabe;
            cmd.Parameters["@Plaza"].Value = Plaza;
            cmd.Parameters["@Sucursal"].Value = Sucursal;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cuenta_Cliente = (Int16)p_K_Cuenta.Value;
            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public DataTable Sk_Cliente_Cuentas(Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cliente_Cuentas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Dl_Tipos_Venta(Int32 K_Tipo_Venta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Tipos_Venta";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Tipos_Venta(Int32 K_Tipo_Venta, string D_Tipo_Venta, string Serie, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipos_Venta";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Venta", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Venta", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@D_Tipo_Venta"].Value = D_Tipo_Venta;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Tipos_Venta(ref Int32 K_Tipo_Venta, string D_Tipo_Venta, string Serie, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipos_Venta";

            IDataParameter p_K_Tipo_Venta = new SqlParameter("@K_Tipo_Venta", SqlDbType.SmallInt);
            p_K_Tipo_Venta.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Venta);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Venta", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Tipo_Venta"].Value = K_Tipo_Venta;
            cmd.Parameters["@D_Tipo_Venta"].Value = D_Tipo_Venta;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Venta = (Int16)p_K_Tipo_Venta.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Tipos_Venta()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipos_Venta";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_Proyecto(Int32 K_Proyecto,Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Proyecto";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proyecto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Proyecto(Int32 K_Proyecto, string D_Proyecto, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Proyecto";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proyecto", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@D_Proyecto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.SmallInt));

            cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            cmd.Parameters["@D_Proyecto"].Value = D_Proyecto;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Proyecto(ref Int32 K_Proyecto, string D_Proyecto, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Proyecto";

            IDataParameter p_K_Proyecto = new SqlParameter("@K_Proyecto", SqlDbType.SmallInt);
            p_K_Proyecto.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Proyecto);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Proyecto", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Proyecto"].Value = K_Proyecto;
            cmd.Parameters["@D_Proyecto"].Value = D_Proyecto;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Proyecto = (Int16)p_K_Proyecto.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Proyectos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Proyectos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public int In_Puestos_Contacto(ref Int32 K_Puesto_Contacto, string D_Puesto_Contacto, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Puestos_Contacto";

            IDataParameter p_K_Puesto_Contacto = new SqlParameter("@K_Puesto_Contacto", SqlDbType.Int);
            p_K_Puesto_Contacto.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Puesto_Contacto);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Puesto_Contacto", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Puesto_Contacto"].Value = K_Puesto_Contacto;
            cmd.Parameters["@D_Puesto_Contacto"].Value = D_Puesto_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Puesto_Contacto = (Int32)p_K_Puesto_Contacto.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Puestos_Contacto(Int32 K_Puesto_Contacto, string D_Puesto_Contacto, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Puestos_Contacto";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Puesto_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Puesto_Contacto", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Puesto_Contacto"].Value = K_Puesto_Contacto;
            cmd.Parameters["@D_Puesto_Contacto"].Value = D_Puesto_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Puestos_Contacto(Int32 K_Puesto_Contacto, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Puestos_Contacto";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Puesto_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Puesto_Contacto"].Value = K_Puesto_Contacto;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Puestos_Contacto()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Puestos_Contacto";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public int In_Contactos_Cliente(ref Int32 K_Contacto_Cliente, Int32 K_Cliente, Int32 K_Puesto_Contacto, string D_Contacto_Cliente, string Lada, string Telefono,string Correo, Int32 K_Usuario,string Telefono2,string Telefono3, string Ext, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Contactos_Cliente";

            IDataParameter p_K_Contacto_Cliente = new SqlParameter("@K_Contacto_Cliente", SqlDbType.Int);
            p_K_Contacto_Cliente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Contacto_Cliente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Puesto_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Contacto_Cliente", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono2", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Telefono3", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Ext", SqlDbType.VarChar,5));
            cmd.Parameters.Add(new SqlParameter("@Lada", SqlDbType.VarChar, 5));

            cmd.Parameters["@K_Contacto_Cliente"].Value = K_Contacto_Cliente;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Puesto_Contacto"].Value = K_Puesto_Contacto;
            cmd.Parameters["@D_Contacto_Cliente"].Value = D_Contacto_Cliente;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Telefono2"].Value = Telefono2;
            cmd.Parameters["@Telefono3"].Value = Telefono3;
            cmd.Parameters["@Ext"].Value = Ext;
            cmd.Parameters["@Lada"].Value = Lada;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Contacto_Cliente = (Int32)p_K_Contacto_Cliente.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Contactos_Cliente(Int32 K_Contacto_Cliente, Int32 K_Cliente, Int32 K_Puesto_Contacto, string D_Contacto_Cliente, string Lada, string Telefono, string Correo, Int32 K_Usuario, string Telefono2, string Telefono3, string Ext, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Contactos_Cliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Contacto_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Puesto_Contacto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Contacto_Cliente", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Lada", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Telefono2", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Telefono3", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Ext", SqlDbType.VarChar,5));

            cmd.Parameters["@K_Contacto_Cliente"].Value = K_Contacto_Cliente;
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@K_Puesto_Contacto"].Value = K_Puesto_Contacto;
            cmd.Parameters["@D_Contacto_Cliente"].Value = D_Contacto_Cliente;
            cmd.Parameters["@Lada"].Value = Lada;
            cmd.Parameters["@Telefono"].Value = Telefono;
            cmd.Parameters["@Correo"].Value = Correo;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Telefono2"].Value = Telefono2;
            cmd.Parameters["@Telefono3"].Value = Telefono3;
            cmd.Parameters["@Ext"].Value = Ext;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Contactos_Cliente(Int32 K_Contacto_Cliente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Contactos_Cliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Contacto_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Contacto_Cliente"].Value = K_Contacto_Cliente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Contactos_Cliente(Int32 K_Cliente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Contactos_Cliente";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Canal_Distribucion_Cliente(ref Int32 K_Canal_Distribucion_Cliente, string D_Canal_Distribucion_Cliente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Canal_Distribucion_Cliente";

            IDataParameter p_K_Canal_Distribucion_Cliente = new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int);
            p_K_Canal_Distribucion_Cliente.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Canal_Distribucion_Cliente);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Canal_Distribucion_Cliente", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@D_Canal_Distribucion_Cliente"].Value =D_Canal_Distribucion_Cliente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Canal_Distribucion_Cliente = (Int32)p_K_Canal_Distribucion_Cliente.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Canal_Distribucion_Cliente(Int32 K_Canal_Distribucion_Cliente, string D_Canal_Distribucion_Cliente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Canal_Distribucion_Cliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Canal_Distribucion_Cliente", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@D_Canal_Distribucion_Cliente"].Value = D_Canal_Distribucion_Cliente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Canal_Distribucion_Cliente(Int32 K_Canal_Distribucion_Cliente, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Canal_Distribucion_Cliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Canal_Distribucion_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Canal_Distribucion_Cliente"].Value = K_Canal_Distribucion_Cliente;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Canal_Distribucion_Cliente()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Canal_Distribucion_Cliente";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Motivos_Nota_Cargo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivos_Nota_Cargo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Motivos_Nota_Cargo(Int16 K_Motivo_Nota_Cargo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivos_Nota_Cargo";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Nota_Cargo", SqlDbType.Int));
            cmd.Parameters["@K_Motivo_Nota_Cargo"].Value = K_Motivo_Nota_Cargo;

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
        public int Up_Motivos_Nota_Cargo(Int16 K_Motivo_Nota_Cargo, string D_Motivo_Nota_Cargo, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivos_Nota_Cargo";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Nota_Cargo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Nota_Cargo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Nota_Cargo"].Value = K_Motivo_Nota_Cargo;
            cmd.Parameters["@D_Motivo_Nota_Cargo"].Value = D_Motivo_Nota_Cargo;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
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
        public int In_Motivos_Nota_Cargo(ref Int16 K_Motivo_Nota_Cargo, string D_Motivo_Nota_Cargo, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivos_Nota_Cargo";

            IDataParameter p_K_Motivo_Nota_Cargo = new SqlParameter("@K_Motivo_Nota_Cargo", SqlDbType.Int);
            p_K_Motivo_Nota_Cargo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Nota_Cargo);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Nota_Cargo", SqlDbType.VarChar, 300));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Nota_Cargo"].Value = K_Motivo_Nota_Cargo;
            cmd.Parameters["@D_Motivo_Nota_Cargo"].Value = D_Motivo_Nota_Cargo;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                K_Motivo_Nota_Cargo = 0;

                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            else
            {

                K_Motivo_Nota_Cargo = Convert.ToInt16(p_K_Motivo_Nota_Cargo.Value);

            }

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public DataTable Sk_Motivos_Nota_Credito()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivos_Nota_Credito";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Motivos_Nota_Credito(Int16 K_Motivo_Nota_Credito, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Motivos_Nota_Credito";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Nota_Credito", SqlDbType.Int));
            cmd.Parameters["@K_Motivo_Nota_Credito"].Value = K_Motivo_Nota_Credito;

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
        public int Up_Motivos_Nota_Credito(Int16 K_Motivo_Nota_Credito, string D_Motivo_Nota_Credito, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Motivos_Nota_Credito";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Nota_Credito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Nota_Credito", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Nota_Credito"].Value = K_Motivo_Nota_Credito;
            cmd.Parameters["@D_Motivo_Nota_Credito"].Value = D_Motivo_Nota_Credito;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
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
        public int In_Motivos_Nota_Credito(ref Int16 K_Motivo_Nota_Credito, string D_Motivo_Nota_Credito, Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Motivos_Nota_Credito";

            IDataParameter p_K_Motivo_Nota_Credito = new SqlParameter("@K_Motivo_Nota_Credito", SqlDbType.Int);
            p_K_Motivo_Nota_Credito.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Motivo_Nota_Credito);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Motivo_Nota_Credito", SqlDbType.VarChar, 300));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Motivo_Nota_Credito"].Value = K_Motivo_Nota_Credito;
            cmd.Parameters["@D_Motivo_Nota_Credito"].Value = D_Motivo_Nota_Credito;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                K_Motivo_Nota_Credito = 0;

                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            else
            {

                K_Motivo_Nota_Credito= Convert.ToInt16(p_K_Motivo_Nota_Credito.Value);

            }

            Mensaje = (string)p_Mensaje.Value;
            return res;
        }
        public DataTable Sk_Motivo_Anticipo_Pago()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Motivo_Anticipo_Pago";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Estatus_Nota(
        ref Int32 K_Estatus_Nota,
        string D_Estatus_Nota,
        Int32 K_Usuario,
        ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Estatus_Nota";

            IDataParameter p_K_Estatus_Nota = new SqlParameter("@K_Estatus_Nota", SqlDbType.Int);
            p_K_Estatus_Nota.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Estatus_Nota);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Nota", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Nota"].Value = K_Estatus_Nota;
            cmd.Parameters["@D_Estatus_Nota"].Value = D_Estatus_Nota;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Estatus_Nota = (Int32)p_K_Estatus_Nota.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Dl_Estatus_Nota(
            Int32 K_Estatus_Nota,
            Int32 K_Usuario,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Estatus_Nota";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Nota", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Nota"].Value = K_Estatus_Nota;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Estatus_Nota(
            Int32 K_Estatus_Nota,
            string D_Estatus_Nota,
            Int32 K_Usuario,
           ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Estatus_Nota";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Nota", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Estatus_Nota", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Estatus_Nota"].Value = K_Estatus_Nota;
            cmd.Parameters["@D_Estatus_Nota"].Value = D_Estatus_Nota;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Estatus_Nota()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estatus_Nota";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Estatus_Cliente()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Estatus_Cliente";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //public DataTable Sk_Motivo_Anticipo_Pago()
        //{
        //    SqlCommand cmd = ConnectionClass.GetCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "Sk_Motivo_Anticipo_Pago";
        //    DataTable dt = new DataTable();
        //    dt = ConnectionClass.GetTable(ref cmd);
        //    return dt;
        //}
        public int Gp_CambiaEmpresa(Int32 K_Usuario, Int32 K_Empresa_Pertence, Int32 K_Empresa,Int32 K_Oficina, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_CambiaEmpresa";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Pertenece", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Empresa_Pertenece"].Value = K_Empresa_Pertence;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Tipo_Poliza(
        ref Int32 K_Tipo_Poliza,
        string D_Tipo_Poliza,
        ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Poliza";

            IDataParameter p_K_Tipo_Poliza = new SqlParameter("@K_Tipo_Poliza", SqlDbType.Int);
            p_K_Tipo_Poliza.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Poliza);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Poliza", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@D_Tipo_Poliza"].Value = D_Tipo_Poliza;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Poliza = (Int32)p_K_Tipo_Poliza.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipo_Poliza(
            Int32 K_Tipo_Poliza,
            string D_Tipo_Poliza,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Poliza";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Poliza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Poliza", SqlDbType.VarChar, 100));

            cmd.Parameters["@K_Tipo_Poliza"].Value = K_Tipo_Poliza;
            cmd.Parameters["@D_Tipo_Poliza"].Value = D_Tipo_Poliza;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipo_Poliza()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Poliza";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Tipo_Movimiento(
        ref Int32 K_Tipo_Movimiento,
        string D_Tipo_Movimiento,
        bool B_Suma,
        ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Tipo_Movimiento";

            IDataParameter p_K_Tipo_Movimiento = new SqlParameter("@K_Tipo_Movimiento", SqlDbType.Int);
            p_K_Tipo_Movimiento.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Tipo_Movimiento);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Movimiento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Suma", SqlDbType.Bit));

            cmd.Parameters["@K_Tipo_Movimiento"].Value = K_Tipo_Movimiento;
            cmd.Parameters["@D_Tipo_Movimiento"].Value = D_Tipo_Movimiento;
            cmd.Parameters["@B_Suma"].Value = B_Suma;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Tipo_Movimiento = (Int32)p_K_Tipo_Movimiento.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Up_Tipo_Movimiento(
            Int32 K_Tipo_Movimiento,
            string D_Tipo_Movimiento,
            bool B_Suma,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Tipo_Movimiento";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Movimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Tipo_Movimiento", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@B_Suma", SqlDbType.Bit));

            cmd.Parameters["@K_Tipo_Movimiento"].Value = K_Tipo_Movimiento;
            cmd.Parameters["@D_Tipo_Movimiento"].Value = D_Tipo_Movimiento;
            cmd.Parameters["@B_Suma"].Value = B_Suma;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Tipo_Movimiento()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Movimiento";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int In_Clave_SAT(ref Int32 K_Clave_SAT, string D_Clave_SAT, Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Clave_SAT";

            IDataParameter p_K_Clave_SAT = new SqlParameter("@K_Clave_SAT", SqlDbType.Int);
            p_K_Clave_SAT.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Clave_SAT);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@D_Clave_SAT", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Clave_SAT"].Value = K_Clave_SAT;
            cmd.Parameters["@D_Clave_SAT"].Value = D_Clave_SAT;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Clave_SAT = (Int32)p_K_Clave_SAT.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Clave_SAT(Int32 K_Clave_SAT,Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Clave_SAT";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Clave_SAT", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Clave_SAT"].Value = K_Clave_SAT;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Clave_SAT;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Clave_SAT(Int32 K_Clave_SAT, string D_Clave_SAT, Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Clave_SAT";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Clave_SAT", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Clave_SAT", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Clave_SAT"].Value = K_Clave_SAT;
            cmd.Parameters["@D_Clave_SAT"].Value = D_Clave_SAT;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Clave_SAT()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Clave_SAT";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public int IN_Serie(string D_Serie, Int32 K_Usuario_Alta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "IN_Serie";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Alta", SqlDbType.Int));

            cmd.Parameters["@D_Serie"].Value = D_Serie;
            cmd.Parameters["@K_Usuario_Alta"].Value = K_Usuario_Alta;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int DL_Serie(string D_Serie, Int32 K_Usuario_Baja, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DL_Serie";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar,30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Baja", SqlDbType.Int));

            cmd.Parameters["@D_Serie"].Value = D_Serie;
            cmd.Parameters["@K_Usuario_Baja"].Value = K_Usuario_Baja;
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }     
        public DataTable Sk_Serie()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Serie";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable SK_UsuaSerieDisp(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_UsuaSerieDisp";
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable SK_UsuaSerieAsig(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_UsuaSerieAsig";
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int DL_Usuarios_Serie(Int32 K_Usuario,string D_Serie, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DL_Usuarios_Serie";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@D_Serie"].Value = D_Serie;         
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Usuarios_Serie(Int32 K_Usuario, string D_Serie, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Usuarios_Serie";

            IDataParameter p_Mensaje = new SqlParameter("@Pmsmsg", SqlDbType.VarChar, 100);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Serie", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@D_Serie"].Value = D_Serie; 
            cmd.Parameters["@Pmsmsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int In_Forma_Pago(ref Int32 K_Forma_Pago,string D_Forma_Pago,string Clave_Sat, Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Forma_Pago";

            IDataParameter p_K_Forma_Pago = new SqlParameter("@K_Forma_Pago", SqlDbType.Int);
            p_K_Forma_Pago.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Forma_Pago);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Forma_Pago", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Clave_Sat", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Forma_Pago"].Value = K_Forma_Pago;
            cmd.Parameters["@D_Forma_Pago"].Value = D_Forma_Pago;
            cmd.Parameters["@Clave_Sat"].Value = Clave_Sat;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Forma_Pago(Int32 K_Forma_Pago, Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Forma_Pago";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Forma_Pago", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Forma_Pago"].Value = K_Forma_Pago;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Forma_Pago()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Forma_Pago";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int In_Uso_CFDI(ref Int32 K_Uso_CFDI, string D_Uso_CFDI, string Clave_Sat, Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Uso_CFDI";

            IDataParameter p_K_Uso_CFDI = new SqlParameter("@K_Uso_CFDI", SqlDbType.Int);
            p_K_Uso_CFDI.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Uso_CFDI);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Uso_CFDI", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Clave_Sat", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Uso_CFDI"].Value = K_Uso_CFDI;
            cmd.Parameters["@D_Uso_CFDI"].Value = D_Uso_CFDI;
            cmd.Parameters["@Clave_Sat"].Value = Clave_Sat;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Uso_CFDI(Int32 K_Uso_CFDI, Int32 K_Usuario_Bitacora, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Uso_CFDI";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Uso_CFDI", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Uso_CFDI"].Value = K_Uso_CFDI;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = K_Usuario_Bitacora;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Uso_CFDI()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Uso_CFDI";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_ActualizaNombreCliente(Int32 K_Cliente, string D_Cliente, ref string D_Cliente_Nuevo,  string RFC_Nuevo,Int32 K_Usuario,Int32 K_Menu, ref string Mensaje)
        {     
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ActualizaNombreCliente";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_D_Cliente_Nuevo = new SqlParameter("@D_Cliente_Nuevo", SqlDbType.VarChar, 120);
            p_D_Cliente_Nuevo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_D_Cliente_Nuevo);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cliente", SqlDbType.VarChar,120));
            cmd.Parameters.Add(new SqlParameter("@RFC_Nuevo", SqlDbType.VarChar, 16));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));

            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            cmd.Parameters["@D_Cliente"].Value = D_Cliente;
            cmd.Parameters["@RFC_Nuevo"].Value = RFC_Nuevo;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Menu"].Value = K_Menu;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            cmd.Parameters["@D_Cliente_Nuevo"].Value = D_Cliente_Nuevo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;
            D_Cliente_Nuevo = (string)p_D_Cliente_Nuevo.Value;

            return res;
        }
        public DataTable Sk_Tipo_Ieps()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Tipo_Ieps";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        //CONTABVILIDAD
        public DataTable Sk_Cuentas_Mayor()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuentas_Mayor";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Cuentas_Mayor(Int32 K_Cuenta_Mayor, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cuentas_Mayor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

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
        public int Up_Cuentas_Mayor(Int32 K_Cuenta_Mayor, string D_Cuenta_Mayor, string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cuentas_Mayor";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cuenta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 1));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@D_Cuenta"].Value = D_Cuenta_Mayor;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int In_Cuentas_Mayor(Int32 K_Cuenta_Mayor, string D_Cuenta_Mayor, string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cuentas_Mayor";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cuenta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 1));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@D_Cuenta"].Value = D_Cuenta_Mayor;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            return res;
        }
        public DataTable Sk_Cuenta_Nivel2(Int32 K_Cuenta_Mayor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel2";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));

            if (K_Cuenta_Mayor == 0)
            {
                cmd.Parameters["@K_Cuenta_Mayor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            }
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Cuenta_Nivel2()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel2";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Cuenta_Nivel2(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cuenta_Nivel2";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

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
        public int Up_Cuenta_Nivel2(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, string D_Cuenta, string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cuenta_Nivel2";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cuenta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@D_Cuenta"].Value = D_Cuenta;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int In_Cuenta_Nivel2(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, string D_Cuenta, string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cuenta_Nivel2";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Cuenta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@D_Cuenta"].Value = D_Cuenta;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            return res;
        }
        public DataTable Sk_Cuenta_Nivel3(Int32 K_Cuenta_Mayor, Int32 K_Cuenta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel3";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));

            if (K_Cuenta_Mayor == 0)
            {
                cmd.Parameters["@K_Cuenta_Mayor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            }
            if (K_Cuenta == 0)
            {
                cmd.Parameters["@K_Cuenta"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            }
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Cuenta_Nivel3()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel3";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Cuenta_Nivel3(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cuenta_Nivel3";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

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
        public int Up_Cuenta_Nivel3(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, string D_Subcuenta, string Cuenta, bool Padre, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cuenta_Nivel3";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Subcuenta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@Padre", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Hijo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@D_Subcuenta"].Value = D_Subcuenta;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            if (Padre == true)
            {
                cmd.Parameters["@Padre"].Value = true;
                cmd.Parameters["@Hijo"].Value = false;
            }
            else
            {
                cmd.Parameters["@Padre"].Value = false;
                cmd.Parameters["@Hijo"].Value = true;
            }
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int In_Cuenta_Nivel3(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, string D_Subcuenta, string Cuenta, bool Padre, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cuenta_Nivel3";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Subcuenta", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Padre", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Hijo", SqlDbType.Bit));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@D_Subcuenta"].Value = D_Subcuenta;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            if (Padre == true)
            {
                cmd.Parameters["@Padre"].Value = true;
                cmd.Parameters["@Hijo"].Value = false;
            }
            else
            {
                cmd.Parameters["@Padre"].Value = false;
                cmd.Parameters["@Hijo"].Value = true;
            }
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            return res;
        }
        public DataTable Sk_Cuenta_Nivel4(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel4";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));

            if (K_Cuenta_Mayor == 0)
            {
                cmd.Parameters["@K_Cuenta_Mayor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            }
            if (K_Cuenta == 0)
            {
                cmd.Parameters["@K_Cuenta"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            }
            if (K_Subcuenta == 0)
            {
                cmd.Parameters["@K_Subcuenta"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            }
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Cuenta_Nivel4()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel4";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Cuenta_Nivel4(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, Int32 K_Departamento, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cuenta_Nivel4";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

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
        public int Up_Cuenta_Nivel4(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, Int32 K_Departamento, string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cuenta_Nivel4";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int In_Cuenta_Nivel4(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, Int32 K_Departamento, string Cuenta, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cuenta_Nivel4";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar, 3));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@Cuenta"].Value = Cuenta;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            return res;
        }
        public DataTable Sk_Cuenta_Nivel5()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Cuenta_Nivel5";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_Cuenta_Nivel5(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, Int32 K_Departamento, Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Cuenta_Nivel5";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));
            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

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
        public int Up_Cuenta_Nivel5(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, Int32 K_Departamento, Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Cuenta_Nivel5";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }

            return res;

        }
        public int In_Cuenta_Nivel5(Int32 K_Cuenta_Mayor, Int32 K_Cuenta, Int32 K_Subcuenta, Int32 K_Departamento, Int32 K_Almacen, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cuenta_Nivel5";


            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);


            cmd.Parameters.Add(new SqlParameter("@K_Cuenta_Mayor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Subcuenta", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Departamento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Bitacora", SqlDbType.Int));

            cmd.Parameters["@K_Cuenta_Mayor"].Value = K_Cuenta_Mayor;
            cmd.Parameters["@K_Cuenta"].Value = K_Cuenta;
            cmd.Parameters["@K_Subcuenta"].Value = K_Subcuenta;
            cmd.Parameters["@K_Departamento"].Value = K_Departamento;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Usuario_Bitacora"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            if (res == -1)
            {
                Mensaje = (string)p_Mensaje.Value;
                return -1;
            }
            return res;
        }
    }
 }



