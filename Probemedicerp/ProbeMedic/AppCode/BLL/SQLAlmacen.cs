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
    class SQLAlmacen
    {
        //Sk_MercanciaPorCaducar

        public DataTable Sk_MercanciaPorCaducar()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MercanciaPorCaducar";
            DataTable dt = new DataTable();
           

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        // AJuste inventario 

        public int In_AjusteInventario(
             Int32 K_Movimiento_Inventario,
             decimal  CantidadAjuste,
             Int32 K_Motivo_Ajuste_Inventario,
             string Observaciones,
             Int32 K_Oficina,
             Int32 K_Usuario,
             String PC_Name,
             bool B_Suma,
             bool B_Resta,
             ref string Mensaje
        )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_AjusteInventario";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Movimiento_Inventario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@CantidadAjuste", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Ajuste_Inventario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Suma", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Resta", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar));

            cmd.Parameters["@K_Movimiento_Inventario"].Value = K_Movimiento_Inventario;
            cmd.Parameters["@CantidadAjuste"].Value = CantidadAjuste;
            cmd.Parameters["@K_Motivo_Ajuste_Inventario"].Value = K_Motivo_Ajuste_Inventario;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@B_Suma"].Value = B_Suma;
            cmd.Parameters["@B_Resta"].Value = B_Resta;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public DataTable Gp_Inventario(Int32 K_Oficina,Int32 K_Almacen, Int32 K_Articulo,bool B_MostrarTodo,bool B_Exitsencia,string SKU,Int32 K_Laboratorio, Int32 K_Sustancia_Activa,Int32 K_Empresa) { 
        
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Gp_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Exitsencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Laboratorio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sustancia_Activa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            if (K_Oficina==0)
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
            cmd.Parameters["@B_Exitsencia"].Value = B_Exitsencia;

            if(K_Laboratorio == 0)
            {
                cmd.Parameters["@K_Laboratorio"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Laboratorio"].Value = K_Laboratorio;
            }
         
            if(K_Sustancia_Activa == 0)
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
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Inventario(Int32 K_Articulo, bool B_MostrarTodo, bool B_Exitsencia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Exitsencia", SqlDbType.Bit));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;
            cmd.Parameters["@B_Exitsencia"].Value = B_Exitsencia;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Inventario_All()
        {

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Exitsencia", SqlDbType.Bit));

            cmd.Parameters["@K_Empresa"].Value = 1;
            cmd.Parameters["@B_MostrarTodo"].Value = true;
            cmd.Parameters["@B_Exitsencia"].Value = false;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Inventario_Detalle(
            Int32 K_Oficina,
            Int32 K_Articulo,
            Int32 K_Almacen,
            DateTime F_Inicio,
            DateTime F_Final,
            //String NoLote,
            //Int32 K_Nota_Recepcion,
            bool B_MostrarTodo
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario_Detalle";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            //cmd.Parameters.Add(new SqlParameter("@NoLote", SqlDbType.Int));
            //cmd.Parameters.Add(new SqlParameter("@K_Nota_Recepcion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@F_Inicio"].Value = F_Inicio;
            cmd.Parameters["@F_Final"].Value = F_Final;
            //cmd.Parameters["@NoLote"].Value = NoLote;
            //cmd.Parameters["@K_Nota_Recepcion"].Value = K_Nota_Recepcion;
            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Inventario_DetallexLote(
            Int32 K_Oficina,
            Int32 K_Articulo,
            Int32 K_Almacen,
            DateTime F_Inicio,
            DateTime F_Final,
            String NoLote,
            bool B_MostrarTodo
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Inventario_Detalle";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@NoLote", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@F_Inicio"].Value = F_Inicio;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@NoLote"].Value = NoLote;
            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Gp_AjusteInventarioDevolucion(
            ref Int32 K_Devolucion,
            Int32 K_Movimiento_Inventario,
            decimal CantidadAjuste,
            String Observaciones,
            String No_Lote,
            DateTime F_Caducidad,
            Int32 K_Oficina,
            Int32 K_Usuario,
            String PC_Name,
            Int32 K_Motivo_Devolucion,
            ref string Mensaje,
            ref string Correos           
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_AjusteInventarioDevolucion";

            IDataParameter p_K_Devolucion = new SqlParameter("@K_Devolucion", SqlDbType.Int);
            p_K_Devolucion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Devolucion);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 2000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);
           
            cmd.Parameters.Add(new SqlParameter("@K_Movimiento_Inventario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@CantidadAjuste", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@No_Lote", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@F_Caducidad", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar));

            cmd.Parameters["@K_Devolucion"].Value = K_Devolucion;
            cmd.Parameters["@K_Movimiento_Inventario"].Value = K_Movimiento_Inventario;
            cmd.Parameters["@CantidadAjuste"].Value = CantidadAjuste;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@No_Lote"].Value = No_Lote;
            cmd.Parameters["@F_Caducidad"].Value = F_Caducidad;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Motivo_Devolucion"].Value = K_Motivo_Devolucion;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Mensaje"].Value = Mensaje;
       
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Devolucion = (Int32)p_K_Devolucion.Value;
            Mensaje = (string)p_Mensaje.Value;
    
            return res;

       
        }

        public int Gp_AjusteInventario(
          Int32 K_Movimiento_Inventario,
          decimal CantidadAjuste,
          String Observaciones,
          Int32 K_Oficina,
          Int32 K_Usuario,
          String PC_Name,
          ref string Mensaje,
          ref string Correos
          )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_AjusteInventario";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 2000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Movimiento_Inventario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@CantidadAjuste", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar));

            cmd.Parameters["@K_Movimiento_Inventario"].Value = K_Movimiento_Inventario;
            cmd.Parameters["@CantidadAjuste"].Value = CantidadAjuste;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Mensaje"].Value = Mensaje;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;


            return res;


        }
        public DataTable Gp_TraeSobanteFaltante(Int32 K_Orden_Compra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_TraeSobanteFaltante";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }


        public DataTable Gp_InventarioDetalle_Movimiento(
            Int32 K_Movimiento_Inventario
   
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_InventarioDetalle_Movimiento";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Movimiento_Inventario", SqlDbType.Int));

            cmd.Parameters["@K_Movimiento_Inventario"].Value = K_Movimiento_Inventario;
         

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Gp_TransfiereAlmacen(Int32 K_Oficina_Transfiere, Int32 K_Almacen, string Observaciones, DataTable TDetalles, Int32 K_Usuario, string PC_Name, ref string Mensaje, ref Int32 Consecutivo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_TransfiereAlmacen";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 2000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Transfiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 500));
            cmd.Parameters.Add(new SqlParameter("@TDetalles", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Oficina_Transfiere"].Value = K_Oficina_Transfiere;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@TDetalles"].Value = TDetalles;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Mensaje"].Value = Mensaje;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;
            Consecutivo = (Int32)p_Consecutivo.Value;

            return res;
        }

        public DataTable GP_INVENTARIO_DETALLE(Int32 K_Oficina, Int32 K_Articulo, Int32 K_Almacen, DateTime F_Inicio, DateTime F_Final, string NoLote, Int32 K_Nota_Recepcion, bool? B_MostrarTodo,String SKU, String D_Articulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_INVENTARIO_DETALLE";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicio", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@NoLote", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@K_Nota_Recepcion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_MostrarTodo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@D_Articulo", SqlDbType.VarChar, 100));

            if (K_Oficina==0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }
            if(K_Articulo==0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }
            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }

            cmd.Parameters["@F_Inicio"].Value = F_Inicio;
            cmd.Parameters["@F_Final"].Value = F_Final;

            if(NoLote.Length==0)
            {
                cmd.Parameters["@NoLote"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@NoLote"].Value = NoLote;
            }

            if(K_Nota_Recepcion==0)
            {
                cmd.Parameters["@K_Nota_Recepcion"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Nota_Recepcion"].Value = K_Nota_Recepcion;
            }
 
            cmd.Parameters["@B_MostrarTodo"].Value = B_MostrarTodo;

            if(SKU.Length==0)
            {
                cmd.Parameters["@SKU"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@SKU"].Value = SKU;
            }
            if (D_Articulo.Length == 0)
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

        public DataTable Sk_Lotes_Inventario(      
           Int32 K_Articulo,
           Int32 K_Oficina

           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Lotes_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Almacen"].Value = K_Oficina;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Lotes_Inventario(
            Int32 K_Articulo )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Lotes_Inventario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Devoluciones(
           Int32 K_Movimiento_Inventario
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Devoluciones";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Movimiento_Inventario", SqlDbType.Int));
            cmd.Parameters["@K_Movimiento_Inventario"].Value = K_Movimiento_Inventario;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable sk_Devoluciones(
           Int32 K_Devolucion
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Devoluciones";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Devolucion", SqlDbType.Int));
            cmd.Parameters["@K_Devolucion"].Value = K_Devolucion;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Up_Devoluciones(
            Int32 K_Devolucion, 
            Int32 K_Estatus_Devolucion,
            string Nota_Credito,
            DateTime F_Nota_Credito,
            string Archivo_PDF,
            string Archivo_XML,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Devoluciones";

            IDataParameter p_Mensaje = new SqlParameter("@PmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Devolucion", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nota_Credito", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@F_Nota_Credito", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Archivo_PDF", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Archivo_XML", SqlDbType.VarChar,100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));

            cmd.Parameters["@K_Devolucion"].Value = K_Devolucion;
            cmd.Parameters["@K_Estatus_Devolucion"].Value = K_Estatus_Devolucion;
            cmd.Parameters["@Nota_Credito"].Value = Nota_Credito;
            cmd.Parameters["@F_Nota_Credito"].Value = F_Nota_Credito;
            cmd.Parameters["@Archivo_PDF"].Value = Archivo_PDF;
            cmd.Parameters["@Archivo_XML"].Value = Archivo_XML;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@PC_Name"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

        
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public int In_Seguimiento_Devolucion(
         ref Int32 K_Seguimiento_Devolucion,
         Int32 K_Devolucion,
         Int32 K_Estatus_Devolucion,
         string Observaciones,
         Int32 K_Usuario,
         String PC_Name,
         ref string Mensaje
         )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Seguimiento_Devolucion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Seguimiento_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Devolucion", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Devolucion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar));

            cmd.Parameters["@K_Seguimiento_Devolucion"].Value = K_Seguimiento_Devolucion;
            cmd.Parameters["@K_Devolucion"].Value = K_Devolucion;
            cmd.Parameters["@K_Estatus_Devolucion"].Value = K_Estatus_Devolucion;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;

        }

        public DataTable Sk_Seguimiento_Devolucion(
            Int32 K_Devolucion
       )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Seguimiento_Devolucion";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Devolucion", SqlDbType.Int));
            cmd.Parameters["@K_Devolucion"].Value = K_Devolucion;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_transferencia_Almacen(Int32 Consecutivo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_transferencia_Almacen";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@Consecutivo", SqlDbType.Int));

            cmd.Parameters["@Consecutivo"].Value = Consecutivo;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Sk_transferencia_Almacen(Int32 Consecutivo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_transferencia_Almacen";
            DataTable dt = new DataTable();
            int res;

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            //IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            //p_Mensaje.Direction = ParameterDirection.InputOutput;
            //cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@Consecutivo", SqlDbType.Int));

            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            //cmd.Parameters["@Mensaje"].Value = Mensaje;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            //Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_transferencia_Almacen()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_transferencia_Almacen_All";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
    
        public int Gp_RecepcionAlmacen(Int32 Consecutivo, Int32 k_Almacen, Int32 K_Usuario, string PC_Name, DataTable Detalles, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RecepcionAlmacen";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Consecutivo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@k_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@Detalles", SqlDbType.Structured));

            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@k_Almacen"].Value = k_Almacen;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Detalles"].Value = Detalles;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Registro_Escaneo_NRecepcion(
           Int32 K_Orden_Compra
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Registro_Escaneo_NRecepcion";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_ConsultaMovimentosEnTransito(
            Int32 K_OficinaEnvia,
            Int32 K_AlmacenEnvia,
            Int32 K_OficinaRecibe,
            Int32 K_AlmacenRecibe,
            Int32 Anio,
            Int32 Mes,
            Int32 Consecutivo
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaMovimentosEnTransito";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_OficinaEnvia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_AlmacenEnvia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_OficinaRecibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_AlmacenRecibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Anio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Consecutivo", SqlDbType.Int));
            cmd.Parameters["@K_OficinaEnvia"].Value = K_OficinaEnvia;
            cmd.Parameters["@K_AlmacenEnvia"].Value = K_AlmacenEnvia;
            cmd.Parameters["@K_OficinaRecibe"].Value = K_OficinaRecibe;
            cmd.Parameters["@K_AlmacenRecibe"].Value = K_AlmacenRecibe;
            cmd.Parameters["@Anio"].Value = Anio;
            cmd.Parameters["@Mes"].Value = Mes;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Solicitud_Transferencia(
            Int32 K_Oficina_Origen,
            Int32 K_Almacen_Origen,
           DateTime F_Solicitud_Inicial,
           DateTime F_Solicitud_Final
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Solicitud_Transferencia";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Origen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen_Origen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Solicitud_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Solicitud_Final", SqlDbType.SmallDateTime));
            
            cmd.Parameters["@K_Oficina_Origen"].Value = K_Oficina_Origen;
            cmd.Parameters["@K_Almacen_Origen"].Value = K_Almacen_Origen;
            cmd.Parameters["@F_Solicitud_Inicial"].Value = F_Solicitud_Inicial;
            cmd.Parameters["@F_Solicitud_Final"].Value = F_Solicitud_Final;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Solicitud_Transferencia(
            ref Int32 K_Solicitud_Transferencia, 
            Int32 K_Oficina_Solicita, 
            Int32 K_Almacen_Solicita,
            Int32 K_Oficina_Origen,
            Int32 K_Almacen_Origen,
            Int32 K_Motivo_Transferencia,
            DataTable TDetalles,
            Int32 K_Usuario_Solicito,
            String Observaciones, 
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Solicitud_Transferencia";

            IDataParameter p_K_Solicitud_Transferencia = new SqlParameter("@K_Solicitud_Transferencia", SqlDbType.Int);
            p_K_Solicitud_Transferencia.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Solicitud_Transferencia);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Solicita", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen_Solicita", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Origen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen_Origen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@TDetalles", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Solicito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));

            cmd.Parameters["@K_Solicitud_Transferencia"].Value = K_Solicitud_Transferencia;
            cmd.Parameters["@K_Oficina_Solicita"].Value = K_Oficina_Solicita;
            cmd.Parameters["@K_Almacen_Solicita"].Value = K_Almacen_Solicita;
            cmd.Parameters["@K_Oficina_Origen"].Value = K_Oficina_Origen;
            cmd.Parameters["@K_Almacen_Origen"].Value = K_Almacen_Origen;
            cmd.Parameters["@K_Motivo_Transferencia"].Value = K_Motivo_Transferencia;
            cmd.Parameters["@TDetalles"].Value = TDetalles;
            cmd.Parameters["@K_Usuario_Solicito"].Value = K_Usuario_Solicito;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@pmsMsg"].Value =Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            K_Solicitud_Transferencia = (Int32)p_K_Solicitud_Transferencia.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Solicitud_Transferencia(Int32 K_Solicitud_Transferencia, Int32 K_Motivo_Rechazo_Solicitud, string Observaciones)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Solicitud_Transferencia";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Solicitud_Transferencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Rechazo_Solicitud", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Solicitud_Transferencia"].Value = K_Solicitud_Transferencia;
            cmd.Parameters["@K_Motivo_Rechazo_Solicitud"].Value = K_Motivo_Rechazo_Solicitud;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;

        }

        public DataTable Sk_Solicitud_Articulos(
           Int32 K_Solicitud_Transferencia
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Solicitud_Articulos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Solicitud_Transferencia", SqlDbType.Int));
            cmd.Parameters["@K_Solicitud_Transferencia"].Value = K_Solicitud_Transferencia;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Solicitud_Inventario(
            Int32 K_Oficina,
            Int32 K_Almacen,
          Int32 K_Solicitud_Transferencia

          )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Solicitud_Inventario";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Solicitud_Transferencia", SqlDbType.Int));
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Solicitud_Transferencia"].Value = K_Solicitud_Transferencia;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int Gp_TransfiereAlmacen_Solicitud(
          Int32 K_Oficina_Transfiere,
          Int32 K_Almacen,
          String Observaciones,
           DataTable TDetalles,
          Int32 K_Usuario,
           String PC_Name,
          Int32 K_Solicitud_Transferencia,
          ref Int32 Consecutivo,
          ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_TransfiereAlmacen_Solicitud";

            IDataParameter p_Consecutivo = new SqlParameter("@Consecutivo", SqlDbType.Int);
            p_Consecutivo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Consecutivo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 2000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Transfiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@TDetalles", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@K_Solicitud_Transferencia", SqlDbType.Int));
         

            cmd.Parameters["@K_Oficina_Transfiere"].Value = K_Oficina_Transfiere;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@TDetalles"].Value = TDetalles;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@K_Solicitud_Transferencia"].Value = K_Solicitud_Transferencia;
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            Consecutivo = (Int32)p_Consecutivo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_Transferencia_Almacen(
             Int32 Consecutivo,
             Boolean B_Reporte
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Transferencia_Almacen";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@Consecutivo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Reporte", SqlDbType.Bit));
   
            cmd.Parameters["@Consecutivo"].Value = Consecutivo;
            cmd.Parameters["@B_Reporte"].Value = B_Reporte;
  
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_Remisiones_Documentadas(Int32 K_Oficina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Remisiones_Documentadas";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
      
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
       
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Gp_Cancela_Remision(
         Int32 K_Oficina,
         Int32 K_Remision,
         Int32 K_Usuario,
         String PC_Name,
         String Observaciones,
         ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Cancela_Remision";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Remision", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar,50));    
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar,200));
           
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Remision"].Value = K_Remision;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Observaciones"].Value = Observaciones;

            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
    
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
       public DataTable Sk_Inventario_Ubicacion( Int32 K_Oficina, Int32 K_Almacen, Int32 K_Articulo, string SKU, string No_Lote, 
                                                string F_RangoInicial, string F_RangoFinal, bool B_SinUbicacion, bool B_Completo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_Ubicacion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@No_Lote", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Rango_Inicial", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Rango_Final", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_SinUbicacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Completo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@No_Lote"].Value = No_Lote;
            cmd.Parameters["@Rango_Inicial"].Value = F_RangoInicial;
            cmd.Parameters["@Rango_Final"].Value = F_RangoFinal;
            cmd.Parameters["@B_SinUbicacion"].Value = B_SinUbicacion;
            cmd.Parameters["@B_Completo"].Value = B_Completo;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Inventario_Ubicacion(Int32 K_Oficina, Int32 K_Almacen, Int32 K_Articulo, string SKU, string No_Lote,
                                         DateTime F_RecepcionInicial, DateTime F_Recepcion_Final, bool B_SinUbicacion, bool B_Completo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_Ubicacion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@No_Lote", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@F_RecepcionInicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@F_RecepcionFinal", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@B_SinUbicacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Completo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@No_Lote"].Value = No_Lote;
            cmd.Parameters["@F_RecepcionInicial"].Value = F_RecepcionInicial;
            cmd.Parameters["@F_RecepcionFinal"].Value = F_Recepcion_Final;
            cmd.Parameters["@B_SinUbicacion"].Value = B_SinUbicacion;
            cmd.Parameters["@B_Completo"].Value = B_Completo;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Inventario_Ubicacion(Int32 K_Oficina, Int32 K_Almacen, Int32 K_Articulo, string SKU, string No_Lote, bool B_SinUbicacion, bool B_Completo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_Ubicacion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@No_Lote", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@B_SinUbicacion", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Completo", SqlDbType.Bit));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@No_Lote"].Value = No_Lote; cmd.Parameters["@B_SinUbicacion"].Value = B_SinUbicacion;
            cmd.Parameters["@B_Completo"].Value = B_Completo;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Up_Inventario_Ubicacion(Int32 K_Oficina,Int32 K_Almacen, DataTable  TDetalles , string Ubicacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Inventario_Ubicacion";

            IDataParameter p_Mensaje = new SqlParameter("@PmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Ubicacion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Detalle", SqlDbType.Structured));


            cmd.Parameters["@Detalle"].Value = TDetalles;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@Ubicacion"].Value = Ubicacion;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Gp_Pedidos_SinRemision(Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Pedidos_SinRemision";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            if (K_Almacen == 0)
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Movimiento_Medicamentos(Int32 K_Almacen, Int32 Dias)
        
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Movimiento_Medicamentos";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Dias", SqlDbType.Int));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@Dias"].Value = Dias;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Remision(Int32 K_Remision,Int32 K_Almacen,DateTime F_Remision_Inicial,DateTime F_Remision_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Remision";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Remision", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Remision_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Remision_Final", SqlDbType.SmallDateTime));

            if(K_Remision == 0)
            {
                cmd.Parameters["@K_Remision"].Value = DBNull.Value ;
            }
            else
            {
                cmd.Parameters["@K_Remision"].Value = K_Remision;
            }
            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }
            cmd.Parameters["@F_Remision_Inicial"].Value = F_Remision_Inicial;
            cmd.Parameters["@F_Remision_Final"].Value = F_Remision_Final;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_Medicamentos_MasVendidos(Int32 K_Almacen, DateTime F_Inicial, DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Medicamentos_MasVendidos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Reporte_Stock(DataTable Almacenes, DataTable Laboratorios, Int32 K_Articulo, Int32 K_Proveedor, bool B_Laboratorio)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Reporte_Stock";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Laboratorios", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Laboratorio", SqlDbType.Bit));

            cmd.Parameters["@Almacenes"].Value = Almacenes;
            cmd.Parameters["@Laboratorios"].Value = Laboratorios;

            if (K_Articulo == 0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }
            if (K_Proveedor == 0)
            {
                cmd.Parameters["@K_Proveedor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            }

            cmd.Parameters["@B_Laboratorio"].Value = B_Laboratorio;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Reporte_Transito(Int32 K_Articulo,DataTable Almacenes, DataTable Laboratorios)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Reporte_Transito";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@Laboratorios", SqlDbType.Structured));

            if (K_Articulo == 0)
            {
                cmd.Parameters["@K_Articulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            }
            cmd.Parameters["@Almacenes"].Value = Almacenes;
            cmd.Parameters["@Laboratorios"].Value = Laboratorios;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_Remision_Detalle(Int32 K_Remision)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Remision_Detalle";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Remision", SqlDbType.Int));
            cmd.Parameters["@K_Remision"].Value = K_Remision;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_RepMovimientosArticulos(Int32 K_Tipo_Movimiento,Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepMovimientosArticulos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Movimiento", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            if (K_Tipo_Movimiento == 0)
            {
                cmd.Parameters["@K_Tipo_Movimiento"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Movimiento"].Value = K_Tipo_Movimiento;
            }
            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            }


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_RepPedidosParciales()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepPedidosParciales";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_RepVentasPrivadas(Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepVentasPrivadas";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;

            if(K_Almacen==0)
            {
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;

            }
            else
            {
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;

            }

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Gp_ArticulosReservadosInventario(Int32 K_Oficina,Int32 K_Articulo, Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ArticulosReservadosInventario";

            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
    }
}
