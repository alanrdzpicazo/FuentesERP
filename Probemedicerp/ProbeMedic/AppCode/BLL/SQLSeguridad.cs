﻿using ProbeMedic.AppCode.DCC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbeMedic.AppCode.BLL
{
    public class SQLSeguridad
    {
        public DataTable Gp_ConsultaAccesoUsuario(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ConsultaAccesoUsuario";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_UsuariosSeleccionadosxGrupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_UsuariosSeleccionadosxGrupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_UsuariosDisponiblesxGrupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_UsuariosDisponiblesxGrupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_UsuariosxGrupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_UsuariosxGrupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Dl_UsuarioxGrupo(Int32 K_Usuario, Int32 K_Grupo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_UsuarioxGrupo";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue; 
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Grupo"].Value = K_Grupo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            return res;
        }

        public int In_UsuarioxGrupo(Int32 K_Usuario, Int32 K_Grupo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_UsuarioxGrupo";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Grupo"].Value = K_Grupo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            return res;
        }

        public DataTable Gp_ObtieneSPID()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ObtieneSPID";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_CambiaPassword(Int32 K_Usuario, string ContraseniaActual, string ContraseniaNueva, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_CambiaPassword";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ContraseniaActual", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@ContraseniaNueva", SqlDbType.VarChar, 20));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@ContraseniaActual"].Value = ContraseniaActual;
            cmd.Parameters["@ContraseniaNueva"].Value = ContraseniaNueva;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Grupo(Int32 K_Grupo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Grupo";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));

            cmd.Parameters["@K_Grupo"].Value = K_Grupo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_Grupo(Int32 K_Grupo, string D_Grupo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Grupo";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Grupo", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Grupo"].Value = K_Grupo;
            cmd.Parameters["@D_Grupo"].Value = D_Grupo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Grupo(ref Int32 K_Grupo, string D_Grupo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Grupo";

            IDataParameter p_K_Grupo = new SqlParameter("@K_Grupo", SqlDbType.Int);
            p_K_Grupo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Grupo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Grupo", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Grupo"].Value = K_Grupo;
            cmd.Parameters["@D_Grupo"].Value = D_Grupo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Grupo = (Int32)p_K_Grupo.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Grupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Grupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Grupo(Int32 K_Grupo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Grupo";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));
            cmd.Parameters["@K_Grupo"].Value = K_Grupo;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Up_Usuario(Int32 K_Usuario, string D_Usuario, string Login, string Contrasenia, string E_Mail, Int32 K_Empresa, Int32 K_Oficina,DataTable Usuarios_Almacenes_Type,bool B_CambiaSerie,bool B_Transferencia, bool B_CambiaDatosFiscales, bool B_PermiteAjustes,  ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Usuario";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Usuario", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@E_Mail", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Usuarios_Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@B_CambiaSerie", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Transferencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_CambiaDatosFiscales", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_PermiteAjustes", SqlDbType.Bit));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@D_Usuario"].Value = D_Usuario;
            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@Contrasenia"].Value = Contrasenia;
            cmd.Parameters["@E_Mail"].Value = E_Mail;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@Usuarios_Almacenes"].Value = Usuarios_Almacenes_Type;
            cmd.Parameters["@B_CambiaSerie"].Value = B_CambiaSerie;
            cmd.Parameters["@B_Transferencia"].Value = B_Transferencia;
            cmd.Parameters["@B_CambiaDatosFiscales"].Value = B_CambiaDatosFiscales;
            cmd.Parameters["@B_PermiteAjustes"].Value = B_PermiteAjustes;
            cmd.Parameters["@Mensaje"].Value = Mensaje;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Usuario(ref Int32 K_Usuario, string D_Usuario, string Login, string Contrasenia, string E_Mail, Int32 K_Empresa, Int32 K_Oficina,DataTable Usuarios_Almacenes_Type,bool B_CambiaSerie,bool B_Transferencia,bool B_CambiaDatosFiscales,bool B_PermiteAjustes, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Usuario";

            IDataParameter p_K_Usuario = new SqlParameter("@K_Usuario", SqlDbType.Int);
            p_K_Usuario.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Usuario);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@D_Usuario", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@E_Mail", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Usuarios_Almacenes", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@B_CambiaSerie", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Transferencia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_CambiaDatosFiscales", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_PermiteAjustes", SqlDbType.Bit));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@D_Usuario"].Value = D_Usuario;
            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@Contrasenia"].Value = Contrasenia;
            cmd.Parameters["@E_Mail"].Value = E_Mail;
            cmd.Parameters["@K_Empresa"].Value = K_Empresa;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@Usuarios_Almacenes"].Value = Usuarios_Almacenes_Type;
            cmd.Parameters["@B_CambiaSerie"].Value = B_CambiaSerie;
            cmd.Parameters["@B_Transferencia"].Value = B_Transferencia;
            cmd.Parameters["@B_CambiaDatosFiscales"].Value = B_CambiaDatosFiscales;
            cmd.Parameters["@B_PermiteAjustes"].Value = B_PermiteAjustes;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Usuario = (Int32)p_K_Usuario.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Usuario(Int32 K_Usuario, bool B_DarBaja, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Usuario";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_DarBaja", SqlDbType.Bit));


            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@B_DarBaja"].Value = B_DarBaja;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Usuario()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Usuario";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Usuario_Alamcenes(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Usuario_Alamcenes";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        

        public DataTable Sk_ConsultaAccesoUsuario(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaAccesoUsuario";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Permisos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Permisos";

            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusxUsuarioBits()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusxUsuarioBits";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusxGrupoBits()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusxGrupoBits";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Up_MenusxUsuario(Int32 K_Usuario, Int32 K_Menu, bool B_Nuevo, bool B_Modificar, bool B_Borrar, bool B_Guardar, bool B_Afectar, bool B_Reporte, bool B_Excel, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_MenusxUsuario";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Nuevo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Modificar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Borrar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Guardar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Afectar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Reporte", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Excel", SqlDbType.Bit));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Menu"].Value = K_Menu;
            cmd.Parameters["@B_Nuevo"].Value = B_Nuevo;
            cmd.Parameters["@B_Modificar"].Value = B_Modificar;
            cmd.Parameters["@B_Borrar"].Value = B_Borrar;
            cmd.Parameters["@B_Guardar"].Value = B_Guardar;
            cmd.Parameters["@B_Afectar"].Value = B_Afectar;
            cmd.Parameters["@B_Reporte"].Value = B_Reporte;
            cmd.Parameters["@B_Excel"].Value = B_Excel;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Up_MenusxGrupo(Int32 K_Grupo, Int32 K_Menu, bool B_Nuevo, bool B_Modificar, bool B_Borrar, bool B_Guardar, bool B_Afectar, bool B_Reporte, bool B_Excel, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_MenusxGrupo";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Nuevo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Modificar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Borrar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Guardar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Afectar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Reporte", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Excel", SqlDbType.Bit));

            cmd.Parameters["@K_Grupo"].Value = K_Grupo;
            cmd.Parameters["@K_Menu"].Value = K_Menu;
            cmd.Parameters["@B_Nuevo"].Value = B_Nuevo;
            cmd.Parameters["@B_Modificar"].Value = B_Modificar;
            cmd.Parameters["@B_Borrar"].Value = B_Borrar;
            cmd.Parameters["@B_Guardar"].Value = B_Guardar;
            cmd.Parameters["@B_Afectar"].Value = B_Afectar;
            cmd.Parameters["@B_Reporte"].Value = B_Reporte;
            cmd.Parameters["@B_Excel"].Value = B_Excel;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_MenusxUsuario(Int32 K_Menu, Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_MenusxUsuario";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Menu"].Value = K_Menu;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            return res;
        }

        public int Dl_MenusxGrupo(Int32 K_Menu, Int32 K_Grupo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_MenusxGrupo";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Grupo", SqlDbType.Int));

            cmd.Parameters["@K_Menu"].Value = K_Menu;
            cmd.Parameters["@K_Grupo"].Value = K_Grupo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            return res;
        }
        public int In_MenusxUsuario(Int32 KUsuario, Int32 KMenu)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_MenusxUsuario";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@KUsuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@KMenu", SqlDbType.Int));

            cmd.Parameters["@KUsuario"].Value = KUsuario;
            cmd.Parameters["@KMenu"].Value = KMenu;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            return res;
        }

        public int In_MenusxGrupo(Int32 KGrupo, Int32 KMenu)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_MenusxGrupo";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@KGrupo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@KMenu", SqlDbType.Int));

            cmd.Parameters["@KGrupo"].Value = KGrupo;
            cmd.Parameters["@KMenu"].Value = KMenu;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);



            return res;
        }


        public DataTable Sk_MenusSeleccionadosxUsuario()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusSeleccionadosxUsuario";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusDisponiblesxUsuario()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusDisponiblesxUsuario";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusxUsuario()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusxUsuario";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusSeleccionadosxGrupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusSeleccionadosxGrupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusDisponiblesxGrupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusDisponiblesxGrupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_MenusxGrupo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_MenusxGrupo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Up_CreaMenu(Int32 KMenu, Int32 KMenuPadre, string Descripcion, Int32 Posicion, string FormularioAsociado, string Tipo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_CreaMenu";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@KMenu", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@KMenuPadre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@Posicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FormularioAsociado", SqlDbType.VarChar, 250));
            cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar, 30));

            cmd.Parameters["@KMenu"].Value = KMenu;
            cmd.Parameters["@KMenuPadre"].Value = KMenuPadre;
            cmd.Parameters["@Descripcion"].Value = Descripcion;
            cmd.Parameters["@Posicion"].Value = Posicion;
            cmd.Parameters["@FormularioAsociado"].Value = FormularioAsociado;
            cmd.Parameters["@Tipo"].Value = Tipo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_CreaMenu(Int32 KMenuPadre, string Descripcion, Int32 Posicion, string FormularioAsociado, string Tipo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_CreaMenu";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@KMenuPadre", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@Posicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@FormularioAsociado", SqlDbType.VarChar, 250));
            cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar, 30));

            cmd.Parameters["@KMenuPadre"].Value = KMenuPadre;
            cmd.Parameters["@Descripcion"].Value = Descripcion;
            cmd.Parameters["@Posicion"].Value = Posicion;
            cmd.Parameters["@FormularioAsociado"].Value = FormularioAsociado;
            cmd.Parameters["@Tipo"].Value = Tipo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_Menus(Int32 K_Menu, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Menus";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));

            cmd.Parameters["@K_Menu"].Value = K_Menu;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_MenusOrdenado()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_MenusOrdenado";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_ValidaVersion(ref string Version, ref DateTime Fecha)
        {
            //if (ConnectionClass.IsServerConnected(ConnectionClass.ObtieneCadenaConexion(false,5)) == false)
            //{
            //    return -2;
            //}

            int res;
            try
            {
                SqlCommand cmd = ConnectionClass.GetCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Gp_ValidaVersion";
                cmd.CommandTimeout = 10;

                IDataParameter p_Version = new SqlParameter("@Version", SqlDbType.VarChar, 10);
                p_Version.Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add(p_Version);

                IDataParameter p_Fecha = new SqlParameter("@Fecha", SqlDbType.DateTime);
                p_Fecha.Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add(p_Fecha);

                IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
                p_RetValue.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(p_RetValue);

                cmd.Parameters["@Version"].Value = Version;
                cmd.Parameters["@Fecha"].Value = Fecha;

                res = ConnectionClass.ExecuteNonQuery(ref cmd);

                Version = (string)p_Version.Value;
                Fecha = (DateTime)p_Fecha.Value;
            }
            //            catch(SqlException ex)
            catch (SqlException)
            {
                res = -2;
            }

            return res;
        }
        public DataTable Gp_ValidaAccesoUsuario(string Login, string Contrasenia)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaAccesoUsuario";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar, 20));

            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@Contrasenia"].Value = Contrasenia;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public int Gp_ValidaAccesoUsuario(string Login, string Contrasenia, ref string Mensaje)
        {
            if (ConnectionClass.IsServerConnected(ConnectionClass.ObtieneCadenaConexion()) == false)
            {
                return -2;
            }

            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaAccesoUsuario";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar, 20));

            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@Contrasenia"].Value = Contrasenia;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_Ingresa_Opcion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Ingresa_Opcion";

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Menu", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@K_Oficina"].Value = GlobalVar.K_Oficina;
            cmd.Parameters["@K_Menu"].Value = GlobalVar.K_Menu;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;
        }

        public int Dl_Usuario_AutorizaRequisicion(Int32 K_Usuario, Int32 K_Usuario_Elimina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Usuario_AutorizaRequisicion";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Elimina", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Usuario_Elimina"].Value = K_Usuario_Elimina;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;
        }
        public int In_Usuario_AutorizaRequisicion(Int32 K_Usuario, Int32 K_Usuario_Elimina)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Usuario_AutorizaRequisicion";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Elimina", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Usuario_Elimina"].Value = K_Usuario_Elimina;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;
        }
     


        public DataTable Sk_UsuariosxAutorizaArticulos()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_UsuariosxAutorizaArticulos";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_SeleccionadosxUsuario()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_SeleccionadosxUsuario";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Valida_Usuario(string Login, string Contrasenia, string Version)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Valida_Usuario_Internet_empleado";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar, 35));
            cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar, 35));
            cmd.Parameters.Add(new SqlParameter("@Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Empleado", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Version", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@pmsMsg", SqlDbType.VarChar, 254));

            cmd.Parameters["@K_Usuario"].Value = null;
            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@Contrasenia"].Value = Contrasenia;
            cmd.Parameters["@Oficina"].Value = null;
            cmd.Parameters["@K_Empleado"].Value = null;
            cmd.Parameters["@D_Empleado"].Value = null;
            cmd.Parameters["@Aplicacion"].Value = null;
            cmd.Parameters["@Version"].Value = Version;
            cmd.Parameters["@pmsMsg"].Value = null;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int GP_UsuariosConectados(Int32 K_Usuario, string PC_Name, string D_Usuario, string Login, Int32 K_Empleado, string D_Empleado, Int32 K_Oficina, string D_Oficina, string Aplicacion, string IP, string Mac_Address, string Ver_Win, ref string Msj)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_UsuariosConectados";

            IDataParameter p_Msj = new SqlParameter("@Msj", SqlDbType.VarChar, 300);
            p_Msj.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Msj);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@D_Usuario", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar, 35));
            cmd.Parameters.Add(new SqlParameter("@K_Empleado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Empleado", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@D_Oficina", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@IP", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Mac_Address", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@Ver_Win", SqlDbType.VarChar, 60));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@D_Usuario"].Value = D_Usuario;
            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@K_Empleado"].Value = K_Empleado;
            cmd.Parameters["@D_Empleado"].Value = D_Empleado;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@D_Oficina"].Value = D_Oficina;
            cmd.Parameters["@Aplicacion"].Value = Aplicacion;
            cmd.Parameters["@IP"].Value = IP;
            cmd.Parameters["@Mac_Address"].Value = Mac_Address;
            cmd.Parameters["@Ver_Win"].Value = Ver_Win;
            cmd.Parameters["@Msj"].Value = Msj;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Msj = (string)p_Msj.Value;

            return res;
        }
        public int GP_LIBERA_USUARIO(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_LIBERA_USUARIO";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;
        }

    }
}