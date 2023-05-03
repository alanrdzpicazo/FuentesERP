using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ProbeMedic.AppCode.DCC;

namespace ProbeMedic.AppCode.BLL
{
    public class SQLPedidos
    {
        public DataTable Sk_Historia_Pedido(Int32 K_Pedido)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Historia_Pedido";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;

        }


        public DataTable Sk_Pedidos(
           Int32 K_Pedido,
           Int32 K_Oficina,
           Int32 K_Almacen,
           bool B_Todos,
           bool B_Cancelado,
           bool B_Remisionado,
           Int32 K_Paciente,
           Int32 K_Aseguradora,
           Int32 K_Cliente,
           DateTime F_Inicial,
           DateTime F_Final,
           Int32 K_Tipo_Moneda,
           Int32 K_Estatus_Pedido,
           Int32 K_Ejecutivo,
           bool B_ParaFacturar,
           Int32 K_Cotizacion
           )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pedidos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Todos", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Remisionado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Ejecutivo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_ParaFacturar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));

            if(K_Pedido==0)
            {
                cmd.Parameters["@K_Pedido"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            }
            
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
       
            cmd.Parameters["@B_Todos"].Value = B_Todos;
            cmd.Parameters["@B_Cancelado"].Value = B_Cancelado;
            cmd.Parameters["@B_Remisionado"].Value = B_Remisionado;

            if(K_Paciente==0)
            {
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            }

            if(K_Aseguradora==0)
            {
                cmd.Parameters["@K_Aseguradora"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
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

            if(K_Tipo_Moneda==0)
            {
                cmd.Parameters["@K_Tipo_Moneda"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            }
            if(K_Estatus_Pedido==0)
            {
                cmd.Parameters["@K_Estatus_Pedido"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            }
            if(K_Ejecutivo==0)
            {
                cmd.Parameters["@K_Ejecutivo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Ejecutivo"].Value = K_Ejecutivo;
            }

            cmd.Parameters["@B_ParaFacturar"].Value = B_ParaFacturar;

            if(K_Cotizacion==0)
            {
                cmd.Parameters["@K_Cotizacion"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;
            }

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int In_Estatus_Pedido(ref Int16 K_Estatus_Pedido, string D_Estatus_Pedido,bool B_Aplica_Pedido,Int32 K_Usuario, ref string Mensaje)
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
        public int Dl_Estatus_Pedido(Int16 K_Estatus_Pedido,Int32 K_Usuario, ref string Mensaje)
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
        public int Up_Estatus_Pedido(Int16 K_Estatus_Pedido, string D_Estatus_Pedido, bool B_Aplica_Pedido, Int32 K_Usuario, ref string Mensaje)
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


        public int In_Pedidos(
              ref Int32 K_Pedido, Int32 K_Cotizacion, string Folio, Int32 K_Oficina, Int32 K_Almacen, Int32 K_Paciente, Int32 K_Paciente_Direccion, Int32 K_Medico, Int32 K_Celula,
              Int32 K_Aseguradora, Int32 K_Estatus_Pedido, DateTime F_Entrega, Int32 K_Cliente, Int32 K_Domicilio_Entrega, decimal Porcentaje_Descuento, decimal Descuento,
              decimal Subtotal, decimal Tasa_IVA, decimal Total_IVA, decimal Total_Pedido, Int32 K_Tipo_Moneda, decimal Tipo_Cambio, Int32 K_Usuario_Captura, DataTable PedidosDetalle,
              string PC_Name, bool B_PedidoCero, Int32 K_Tipo_Entrega, Int32 K_Empresa_Entrega, string No_Guia, DateTime H_Entrega, string Nota,
              bool B_Parcial, bool B_Quimioterapia, bool B_Programado, Int32 K_Paciente_Telefono, string Reclamacion, Int32 K_Asesor, string Carta_Pedido, decimal Monto_Carta,
              string Siniestro_Pedido, string Reclamacion_Pedido, decimal Coaseguro_Porcentaje_Pedido, decimal Coaseguro_Pedido, string Poliza_Pedido, bool B_ConCoaseguro,
              Int32 K_Tipo_PagoCoaseguro, string PacienteCartaPedido, string Siniestro, string Carta, bool B_CoaCobReq, Int32 K_Celula_Pedido,bool? B_CallCenter,ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Pedidos";

            IDataParameter p_K_Pedido = new SqlParameter("@K_Pedido", SqlDbType.Int);
            p_K_Pedido.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Pedido);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Aseguradora", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Domicilio_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Captura", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PedidosDetalle", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@B_PedidoCero", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Guia", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@H_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Nota", SqlDbType.VarChar, 400));
            cmd.Parameters.Add(new SqlParameter("@B_Parcial", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Quimioterapia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Programado", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Telefono", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Reclamacion", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@K_Asesor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Carta_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Monto_Carta", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Siniestro_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Reclamacion_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro_Porcentaje_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Poliza_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@B_ConCoaseguro", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_PagoCoaseguro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PacienteCartaPedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Siniestro", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Carta", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@B_CoaCobReq", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Celula_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_CallCenter", SqlDbType.Bit));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;

            if (K_Cotizacion == 0)
                cmd.Parameters["@K_Cotizacion"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;
            if (Folio == string.Empty)
                cmd.Parameters["@Folio"].Value = DBNull.Value;
            else
                cmd.Parameters["@Folio"].Value = Folio;
            if (K_Oficina == 0)
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Almacen == 0)
                cmd.Parameters["@K_Almacen"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            if (K_Paciente == 0)
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            if (K_Paciente_Direccion == 0)
                cmd.Parameters["@K_Paciente_Direccion"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Paciente_Direccion"].Value = K_Paciente_Direccion;
            if (K_Medico == 0)
                cmd.Parameters["@K_Medico"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Medico"].Value = K_Medico;
            if (K_Celula == 0)
                cmd.Parameters["@K_Celula"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Celula"].Value = K_Celula;
            if (K_Aseguradora == 0)
                cmd.Parameters["@K_Aseguradora"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Aseguradora"].Value = K_Aseguradora;
            if (K_Estatus_Pedido == 0)
                cmd.Parameters["@K_Estatus_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Estatus_Pedido"].Value = K_Estatus_Pedido;
            if (F_Entrega == null)
                cmd.Parameters["@F_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@F_Entrega"].Value = F_Entrega;
            if (K_Cliente == 0)
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            if (K_Domicilio_Entrega == 0)
                cmd.Parameters["@K_Domicilio_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Domicilio_Entrega"].Value = K_Domicilio_Entrega;

            cmd.Parameters["@Porcentaje_Descuento"].Value = Porcentaje_Descuento;
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Pedido"].Value = Total_Pedido;

            if (K_Tipo_Moneda == 0)
                cmd.Parameters["@K_Tipo_Moneda"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            if (Tipo_Cambio == 0)
                cmd.Parameters["@Tipo_Cambio"].Value = DBNull.Value;
            else
                cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            if (K_Usuario_Captura == 0)
                cmd.Parameters["@K_Usuario_Captura"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Usuario_Captura"].Value = K_Usuario_Captura;

            cmd.Parameters["@PedidosDetalle"].Value = PedidosDetalle;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@B_PedidoCero"].Value = B_PedidoCero;

            if (K_Tipo_Entrega == 0)
                cmd.Parameters["@K_Tipo_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
            if (K_Empresa_Entrega == 0)
                cmd.Parameters["@K_Empresa_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            if (No_Guia == string.Empty)
                cmd.Parameters["@No_Guia"].Value = DBNull.Value;
            else
                cmd.Parameters["@No_Guia"].Value = No_Guia;
            if (H_Entrega == null)
                cmd.Parameters["@H_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@H_Entrega"].Value = H_Entrega;
            if (Nota == string.Empty)
                cmd.Parameters["@Nota"].Value = DBNull.Value;
            else
                cmd.Parameters["@Nota"].Value = Nota;

            cmd.Parameters["@B_Parcial"].Value = B_Parcial;
            cmd.Parameters["@B_Quimioterapia"].Value = B_Quimioterapia;
            cmd.Parameters["@B_Programado"].Value = B_Programado;

            if (K_Paciente_Telefono == 0)
                cmd.Parameters["@K_Paciente_Telefono"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Paciente_Telefono"].Value = K_Paciente_Telefono;
            if (Reclamacion == string.Empty)
                cmd.Parameters["@Reclamacion"].Value = DBNull.Value;
            else
                cmd.Parameters["@Reclamacion"].Value = Reclamacion;
            if (K_Asesor == 0)
                cmd.Parameters["@K_Asesor"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Asesor"].Value = K_Asesor;
            if (Carta_Pedido == string.Empty)
                cmd.Parameters["@Carta_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Carta_Pedido"].Value = Carta_Pedido;
            if (Monto_Carta == 0)
                cmd.Parameters["@Monto_Carta"].Value = DBNull.Value;
            else
                cmd.Parameters["@Monto_Carta"].Value = Monto_Carta;
            if (Siniestro_Pedido == string.Empty)
                cmd.Parameters["@Siniestro_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Siniestro_Pedido"].Value = Siniestro_Pedido;
            if (Reclamacion_Pedido == string.Empty)
                cmd.Parameters["@Reclamacion_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Reclamacion_Pedido"].Value = Reclamacion_Pedido;
            if (Coaseguro_Porcentaje_Pedido == 0)
                cmd.Parameters["@Coaseguro_Porcentaje_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Coaseguro_Porcentaje_Pedido"].Value = Coaseguro_Porcentaje_Pedido;
            if (Coaseguro_Pedido == 0)
                cmd.Parameters["@Coaseguro_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Coaseguro_Pedido"].Value = Coaseguro_Pedido;
            if (Poliza_Pedido == string.Empty)
                cmd.Parameters["@Poliza_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Poliza_Pedido"].Value = Poliza_Pedido;

            cmd.Parameters["@B_ConCoaseguro"].Value = B_ConCoaseguro;
            if (K_Tipo_PagoCoaseguro == 0)
                cmd.Parameters["@K_Tipo_PagoCoaseguro"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_PagoCoaseguro"].Value = K_Tipo_PagoCoaseguro;
            if (PacienteCartaPedido == string.Empty)
                cmd.Parameters["@PacienteCartaPedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@PacienteCartaPedido"].Value = PacienteCartaPedido;
            if (Siniestro == string.Empty)
                cmd.Parameters["@Siniestro"].Value = DBNull.Value;
            else
                cmd.Parameters["@Siniestro"].Value = Siniestro;
            if (Carta == string.Empty)
                cmd.Parameters["@Carta"].Value = DBNull.Value;
            else
                cmd.Parameters["@Carta"].Value = Carta;
            cmd.Parameters["@B_CoaCobReq"].Value = B_CoaCobReq;
            if (K_Celula_Pedido == 0)
                cmd.Parameters["@K_Celula_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Celula_Pedido"].Value = K_Celula_Pedido;

            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@B_CallCenter"].Value = B_CallCenter;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Pedido = (Int32)p_K_Pedido.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Pedidos_Consulta(Int32 K_Pedido)
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
        public int Up_Pedidos(Int32 K_Pedido, Int32 K_Paciente_Direccion, Int32 K_Medico, Int32 K_Celula, DateTime F_Entrega, Int32 K_Tipo_Entrega, Int32 K_Empresa_Entrega, string No_Guia
       , DateTime H_Entrega, string Nota,bool B_Quimioterapia, Int32 K_Paciente_Telefono, string Reclamacion, string Carta_Pedido, decimal Monto_Carta,string Siniestro_Pedido,
         string Reclamacion_Pedido, decimal Coaseguro_Porcentaje_Pedido, decimal Coaseguro_Pedido, string Poliza_Pedido, bool B_ConCoaseguro,
         Int32 K_Tipo_PagoCoaseguro, string PacienteCartaPedido, string Siniestro, string Carta, bool B_CoaCobReq, Int32 K_Celula_Pedido, decimal Deduccion_Porcentaje_Pedido, decimal Deduccion_Pedido,
         bool B_ConDeduccion,  ref string Mensaje)

        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Up_Pedidos";


            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Direccion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Medico", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Celula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa_Entrega", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@No_Guia", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@H_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Nota", SqlDbType.VarChar, 400));
            cmd.Parameters.Add(new SqlParameter("@B_Quimioterapia", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente_Telefono", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Reclamacion", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Carta_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Monto_Carta", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Siniestro_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Reclamacion_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro_Porcentaje_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Coaseguro_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Poliza_Pedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@B_ConCoaseguro", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_PagoCoaseguro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PacienteCartaPedido", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Siniestro", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Carta", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@B_CoaCobReq", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Celula_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Deduccion_Porcentaje_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Deduccion_Pedido", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@B_ConDeduccion", SqlDbType.Bit));

            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@K_Paciente_Direccion"].Value = K_Paciente_Direccion;
            cmd.Parameters["@K_Medico"].Value = K_Medico;
            cmd.Parameters["@K_Celula"].Value = K_Celula;
            cmd.Parameters["@F_Entrega"].Value = F_Entrega;
            cmd.Parameters["@K_Tipo_Entrega"].Value = K_Tipo_Entrega;
             if (K_Empresa_Entrega == 0)
                cmd.Parameters["@K_Empresa_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Empresa_Entrega"].Value = K_Empresa_Entrega;
            if (No_Guia == string.Empty)
                cmd.Parameters["@No_Guia"].Value = DBNull.Value;
            else
                cmd.Parameters["@No_Guia"].Value = No_Guia;
            if (H_Entrega == null)
                cmd.Parameters["@H_Entrega"].Value = DBNull.Value;
            else
                cmd.Parameters["@H_Entrega"].Value = H_Entrega;
            if (Nota == string.Empty)
                cmd.Parameters["@Nota"].Value = DBNull.Value;
            else
                cmd.Parameters["@Nota"].Value = Nota;
            cmd.Parameters["@B_Quimioterapia"].Value = B_Quimioterapia;
            if (K_Paciente_Telefono == 0)
                cmd.Parameters["@K_Paciente_Telefono"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Paciente_Telefono"].Value = K_Paciente_Telefono;
            if (Reclamacion == string.Empty)
                cmd.Parameters["@Reclamacion"].Value = DBNull.Value;
            else
                cmd.Parameters["@Reclamacion"].Value = Reclamacion;
            if (Carta_Pedido == string.Empty)
                cmd.Parameters["@Carta_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Carta_Pedido"].Value = Carta_Pedido;
            if (Monto_Carta == 0)
                cmd.Parameters["@Monto_Carta"].Value = DBNull.Value;
            else
                cmd.Parameters["@Monto_Carta"].Value = Monto_Carta;
            if (Siniestro_Pedido == string.Empty)
                cmd.Parameters["@Siniestro_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Siniestro_Pedido"].Value = Siniestro_Pedido;
            if (Reclamacion_Pedido == string.Empty)
                cmd.Parameters["@Reclamacion_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Reclamacion_Pedido"].Value = Reclamacion_Pedido;
            if (Coaseguro_Porcentaje_Pedido == 0)
                cmd.Parameters["@Coaseguro_Porcentaje_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Coaseguro_Porcentaje_Pedido"].Value = Coaseguro_Porcentaje_Pedido;
            if (Coaseguro_Pedido == 0)
                cmd.Parameters["@Coaseguro_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Coaseguro_Pedido"].Value = Coaseguro_Pedido;
            if (Poliza_Pedido == string.Empty)
                cmd.Parameters["@Poliza_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Poliza_Pedido"].Value = Poliza_Pedido;

            cmd.Parameters["@B_ConCoaseguro"].Value = B_ConCoaseguro;
            if (K_Tipo_PagoCoaseguro == 0)
                cmd.Parameters["@K_Tipo_PagoCoaseguro"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Tipo_PagoCoaseguro"].Value = K_Tipo_PagoCoaseguro;
            if (PacienteCartaPedido == string.Empty)
                cmd.Parameters["@PacienteCartaPedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@PacienteCartaPedido"].Value = PacienteCartaPedido;
            if (Siniestro == string.Empty)
                cmd.Parameters["@Siniestro"].Value = DBNull.Value;
            else
                cmd.Parameters["@Siniestro"].Value = Siniestro;
            if (Carta == string.Empty)
                cmd.Parameters["@Carta"].Value = DBNull.Value;
            else
                cmd.Parameters["@Carta"].Value = Carta;
            cmd.Parameters["@B_CoaCobReq"].Value = B_CoaCobReq;
            if (K_Celula_Pedido == 0)
                cmd.Parameters["@K_Celula_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@K_Celula_Pedido"].Value = K_Celula_Pedido;
            if (Deduccion_Porcentaje_Pedido == 0)
                cmd.Parameters["@Deduccion_Porcentaje_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Deduccion_Porcentaje_Pedido"].Value = Coaseguro_Porcentaje_Pedido;
            if (Deduccion_Pedido == 0)
                cmd.Parameters["@Deduccion_Pedido"].Value = DBNull.Value;
            else
                cmd.Parameters["@Deduccion_Pedido"].Value = Coaseguro_Pedido;
            cmd.Parameters["@B_ConDeduccion"].Value = B_CoaCobReq;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Gp_ActualizaEstatus_Pedidos(Int32 K_Pedido, bool B_Aprobar, bool B_Activar, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ActualizaEstatus_Pedidos";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Aprobar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Activar", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Pedido"].Value  = K_Pedido;
            cmd.Parameters["@K_Oficina"].Value = GlobalVar.K_Oficina;
            cmd.Parameters["@B_Aprobar"].Value = B_Aprobar;
            cmd.Parameters["@B_Activar"].Value = B_Activar;
            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Pacientes_ArticulosProg(Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Pacientes_ArticulosProg";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters["@K_Paciente"].Value = K_Paciente;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;

        }
        public DataTable Sk_Detalle_Cotizacion(Int32 K_Cotizacion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Detalle_Cotizacion";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cotizacion", SqlDbType.Int));
            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;

        }
        public int In_Cotizacion(
                   ref Int32 K_Cotizacion,
                   Int32 K_Cliente,
                   Int32 K_Paciente,
                   Decimal Descuento,
                   Decimal Subtotal,
                   Decimal Tasa_IVA,
                   Decimal Total_IVA,
                   Decimal Total_Cotizacion,
                   Int32 K_Usuario_Cotiza,
                   DateTime F_Vigencia,
                   String Condiciones,
                   Int32 TiempoEntrega,
                   string Observaciones,
                   DataTable CotizacionDetalle,
                   bool B_Programada,
                   ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Cotizacion";

            IDataParameter p_K_Cotizacion = new SqlParameter("@K_Cotizacion", SqlDbType.Int);
            p_K_Cotizacion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Cotizacion);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);
            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Tasa_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_IVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total_Cotizacion", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Cotiza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Vigencia", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Condiciones", SqlDbType.VarChar, 60));
            cmd.Parameters.Add(new SqlParameter("@TiempoEntrega", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@CotizacionDetalle", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@B_Programada", SqlDbType.Bit));

            cmd.Parameters["@K_Cotizacion"].Value = K_Cotizacion;

            if (K_Cliente == 0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }
            if (K_Paciente == 0)
            {
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            }
           
            cmd.Parameters["@Descuento"].Value = Descuento;
            cmd.Parameters["@Subtotal"].Value = Subtotal;
            cmd.Parameters["@Tasa_IVA"].Value = Tasa_IVA;
            cmd.Parameters["@Total_IVA"].Value = Total_IVA;
            cmd.Parameters["@Total_Cotizacion"].Value = Total_Cotizacion;
            cmd.Parameters["@K_Usuario_Cotiza"].Value = K_Usuario_Cotiza;
            cmd.Parameters["@F_Vigencia"].Value = F_Vigencia;
            cmd.Parameters["@Condiciones"].Value = Condiciones;
            cmd.Parameters["@TiempoEntrega"].Value = TiempoEntrega;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@CotizacionDetalle"].Value = CotizacionDetalle;
            cmd.Parameters["@B_Programada"].Value = B_Programada;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Cotizacion = (Int32)p_K_Cotizacion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable SK_Pedidos_Factura(Int32 K_Cliente, Int32 K_Paciente)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Pedidos_Factura";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));

            if (K_Paciente == 0)
            {
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            }
            cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable SK_Pedidos_Factura(Int32 K_Cliente, Int32 K_Paciente, Int32 K_Pedido, Int32 K_Remision,DateTime F_Pedido_Inicial,DateTime F_Pedido_Final,Int32 K_Tipo_Pedido,Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Pedidos_Factura";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Cliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Paciente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Remision", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Pedido_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Pedido_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            if (K_Paciente == 0)
            {
                cmd.Parameters["@K_Paciente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Paciente"].Value = K_Paciente;
            }
            if (K_Cliente == 0)
            {
                cmd.Parameters["@K_Cliente"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Cliente"].Value = K_Cliente;
            }
            if (K_Pedido == 0)
            {
                cmd.Parameters["@K_Pedido"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            }
            if (K_Remision == 0)
            {
                cmd.Parameters["@K_Remision"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Remision"].Value = K_Remision;
            }
            if (K_Tipo_Pedido == 0)
            {
                cmd.Parameters["@K_Tipo_Pedido"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Tipo_Pedido"].Value = K_Tipo_Pedido;
            }
            cmd.Parameters["@F_Pedido_Inicial"].Value = F_Pedido_Inicial;
            cmd.Parameters["@F_Pedido_Final"].Value = F_Pedido_Final;

            if (K_Almacen == 0)
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
        public DataTable SK_Pedidos_Factura(Int32 K_Pedido)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SK_Pedidos_Factura";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_Trae_Coaseguro(Int32 K_Pedido)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Trae_Coaseguro";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public int Gp_ValidaPuedaCambiarSerie(Int32 K_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaPuedaCambiarSerie";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = GlobalVar.K_Usuario;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);


            return res;
        }


    }
}
