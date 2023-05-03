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
    class SQLCompras
    {
        //RE orden Inventario Sk_Inventario_PuntoReOrden
        public DataTable Sk_Inventario_PuntoReOrden(Int32 K_Oficina, Int32 K_Almacen)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Inventario_PuntoReOrden";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }




        //CONSULTA FACTURAS


        public DataTable Gp_RepFacturas_Proveedor(Int32 K_Orden_Compra, Int16 K_Almacen,Int32  K_Proveedor,string Factura,Int32 K_Notas_Credito_Orden_Compra, Int32 K_Devolucion, DateTime F_Factura, DateTime F_Inicial, DateTime F_Final, bool  B_Autoriza_SinFactura)
        {
           
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepFacturas_Proveedor";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Factura", SqlDbType.VarChar,30));
            cmd.Parameters.Add(new SqlParameter("@K_Notas_Credito_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Devolucion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Factura", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Autoriza_SinFactura", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));

            if (K_Orden_Compra > 0 )
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
           if (K_Proveedor > 0)
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
           if (Factura.Length > 0 )
            cmd.Parameters["@Factura"].Value = Factura;

            if (K_Notas_Credito_Orden_Compra > 0)
                cmd.Parameters["@K_Notas_Credito_Orden_Compra"].Value = K_Notas_Credito_Orden_Compra;
            if (K_Devolucion > 0)
                cmd.Parameters["@K_Devolucion"].Value = K_Devolucion;
            if (F_Factura != new DateTime (1970,1,1))
                cmd.Parameters["@F_Factura"].Value = F_Factura;
            if (F_Inicial != new DateTime(1970, 1, 1))
                cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            if (F_Final != new DateTime(1970, 1, 1))
                cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@B_Autoriza_SinFactura"].Value = B_Autoriza_SinFactura;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }


        //APRUEBA CANCELACIÓN REQUISICIÓN

        public int Gp_ApruebaCancelaRequisicion(Int32 K_Requisicion, Int32 K_UsuarioProceso, bool B_Autorizada, bool B_Cancelada, Int32 K_Motivo_Cancelacion,string Observaciones, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ApruebaCancelaRequisicion";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_UsuarioProceso", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancelacion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2147483647));


            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_UsuarioProceso"].Value = K_UsuarioProceso;
            cmd.Parameters["@B_Autorizada"].Value = B_Autorizada;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@Mensaje"].Value = Mensaje;
            cmd.Parameters["@K_Motivo_Cancelacion"].Value = K_Motivo_Cancelacion;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }



        //ORDEN DE COMPRA DIRECTA


        public int Gp_InsertaOrdenCompra_Directa(ref Int32 K_Orden_Compra,
            Int32 K_Oficina_Recibe,
            Int32 K_Almacen,
            Int32 K_Sucursal,
            Int32 K_Proveedor,
            Int16 K_Tipo_Moneda,
            decimal Tipo_Cambio,
            DateTime F_Entrega,
            Int16 TiempoEntrega , 
            Int32 K_Usuario_Elaboro,
            string Observaciones, 
            DataTable DetalleOC,
            ref bool B_ImprimeOC,
            Int32 K_Usuario_Autoriza,
            ref string CorreosAutorizo,
            ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_InsertaOrdenCompra_Directa";

            IDataParameter p_K_Orden_Compra = new SqlParameter("@K_Orden_Compra", SqlDbType.Int);
            p_K_Orden_Compra.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Orden_Compra);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            IDataParameter p_B_ImprimeOC = new SqlParameter("@B_ImprimeOC", SqlDbType.Bit);
            p_B_ImprimeOC.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_B_ImprimeOC);

            IDataParameter p_CorreosAutorizo = new SqlParameter("@CorreosAutorizo", SqlDbType.VarChar, 1000);
            p_CorreosAutorizo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_CorreosAutorizo);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sucursal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@TiempoEntrega", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Elaboro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2147483647));
            cmd.Parameters.Add(new SqlParameter("@DetalleOC", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Autoriza", SqlDbType.Int));
            
            cmd.Parameters["@K_Orden_Compra"].Value = K_Oficina_Recibe;
            cmd.Parameters["@K_Oficina_Recibe"].Value = K_Oficina_Recibe;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Sucursal"].Value = K_Sucursal;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@F_Entrega"].Value = F_Entrega;
            cmd.Parameters["@TiempoEntrega"].Value = TiempoEntrega;
            cmd.Parameters["@K_Usuario_Elaboro"].Value = K_Usuario_Elaboro;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@DetalleOC"].Value = DetalleOC;
            cmd.Parameters["@K_Usuario_Autoriza"].Value = K_Usuario_Autoriza;
            cmd.Parameters["@B_ImprimeOC"].Value = B_ImprimeOC;
            cmd.Parameters["@CorreosAutorizo"].Value = CorreosAutorizo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Orden_Compra = (Int32)p_K_Orden_Compra.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_CancelaOrdenCompra(Int32 K_OrdenCompra, Int32 K_UsuarioCancela, Int32 B_ActivaRequisicion, string MotivoCancela, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_CancelaOrdenCompra";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_UsuarioCancela", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_ActivaRequisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@MotivoCancela", SqlDbType.VarChar, 500));

            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            cmd.Parameters["@K_UsuarioCancela"].Value = K_UsuarioCancela;
            cmd.Parameters["@B_ActivaRequisicion"].Value = B_ActivaRequisicion;
            cmd.Parameters["@MotivoCancela"].Value = MotivoCancela;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_GuardaSeguimientoOrdenCompra(Int32 K_Orden_Compra, DateTime F_EmbarqueConfirmada, DateTime F_RealArribo, Int16 K_Estatus_Orden, string Cruce_Importacion, string Numero_Pedimento, DateTime F_Pedimento, DateTime F_PagoPedimento, decimal TipoCambio_Pedimento, bool B_ReconocimientoAduanero, bool B_MuestrasAduana, bool B_ActasMuestreo, bool B_ResolucionSAT, string Agente_Aduanal, Int16 K_Pais_Origen, Int16 K_Pais_Procedencia, decimal ImporteIVA, decimal ImporteFlete, decimal OtrosNacional, decimal DTA, decimal IGI, decimal Incrementables, decimal HonorariosAA, decimal Prevalidacion, decimal OtrosImportacion, Int32 K_Usuario, string PC_Name, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_GuardaSeguimientoOrdenCompra";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);
            
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_EmbarqueConfirmada", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_RealArribo", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Orden", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Cruce_Importacion", SqlDbType.VarChar, 80));
            cmd.Parameters.Add(new SqlParameter("@Numero_Pedimento", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@F_Pedimento", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_PagoPedimento", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@TipoCambio_Pedimento", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@B_ReconocimientoAduanero", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_MuestrasAduana", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_ActasMuestreo", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_ResolucionSAT", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@Agente_Aduanal", SqlDbType.VarChar, 120));
            cmd.Parameters.Add(new SqlParameter("@K_Pais_Origen", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Pais_Procedencia", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@ImporteIVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@ImporteFlete", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@OtrosNacional", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@DTA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@IGI", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Incrementables", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@HonorariosAA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Prevalidacion", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@OtrosImportacion", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 80));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@F_EmbarqueConfirmada"].Value = F_EmbarqueConfirmada;
            cmd.Parameters["@F_RealArribo"].Value = F_RealArribo;
            cmd.Parameters["@K_Estatus_Orden"].Value = K_Estatus_Orden;
            cmd.Parameters["@Cruce_Importacion"].Value = Cruce_Importacion;
            cmd.Parameters["@Numero_Pedimento"].Value = Numero_Pedimento;
            cmd.Parameters["@F_Pedimento"].Value = F_Pedimento;
            cmd.Parameters["@F_PagoPedimento"].Value = F_PagoPedimento;
            cmd.Parameters["@TipoCambio_Pedimento"].Value = TipoCambio_Pedimento;
            cmd.Parameters["@B_ReconocimientoAduanero"].Value = B_ReconocimientoAduanero;
            cmd.Parameters["@B_MuestrasAduana"].Value = B_MuestrasAduana;
            cmd.Parameters["@B_ActasMuestreo"].Value = B_ActasMuestreo;
            cmd.Parameters["@B_ResolucionSAT"].Value = B_ResolucionSAT;
            cmd.Parameters["@Agente_Aduanal"].Value = Agente_Aduanal;
            cmd.Parameters["@K_Pais_Origen"].Value = K_Pais_Origen;
            cmd.Parameters["@K_Pais_Procedencia"].Value = K_Pais_Procedencia;
            cmd.Parameters["@ImporteIVA"].Value = ImporteIVA;
            cmd.Parameters["@ImporteFlete"].Value = ImporteFlete;
            cmd.Parameters["@OtrosNacional"].Value = OtrosNacional;
            cmd.Parameters["@DTA"].Value = DTA;
            cmd.Parameters["@IGI"].Value = IGI;
            cmd.Parameters["@Incrementables"].Value = Incrementables;
            cmd.Parameters["@HonorariosAA"].Value = HonorariosAA;
            cmd.Parameters["@Prevalidacion"].Value = Prevalidacion;
            cmd.Parameters["@OtrosImportacion"].Value = OtrosImportacion;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_AutorizaCancelaOrdenCompra(Int32 K_OrdenCompra, bool B_Autoriza, bool B_Cancela, Int32 K_Usuario,Int32 K_Motivo_Cancela, string Observaciones, ref string CorreoAvisaAutorizacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_AutorizaCancelaOrdenCompra";

            IDataParameter p_CorreoAvisaAutorizacion = new SqlParameter("@CorreoAvisaAutorizacion", SqlDbType.VarChar, 550);
            p_CorreoAvisaAutorizacion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_CorreoAvisaAutorizacion);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 4000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autoriza", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancela", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 4000));
            cmd.Parameters.Add(new SqlParameter("@K_Motivo_Cancela", SqlDbType.Int));


            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            cmd.Parameters["@B_Autoriza"].Value = B_Autoriza;
            cmd.Parameters["@B_Cancela"].Value = B_Cancela;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Motivo_Cancela"].Value = K_Motivo_Cancela;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@CorreoAvisaAutorizacion"].Value = CorreoAvisaAutorizacion;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);
            if (p_CorreoAvisaAutorizacion.Value.ToString().Trim().Length > 0)
                CorreoAvisaAutorizacion = (string)p_CorreoAvisaAutorizacion.Value;
            else
                CorreoAvisaAutorizacion = string.Empty;

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public DataTable Sk_ConsultaRequisiciones(Int32 K_Requisicion, Int32 K_OficinaRequiere, Int32 K_TipoRequisicion, Int32 K_Estatus_Compra, Int32 K_UsuarioRequiere, bool B_Autorizada, bool B_Cancelada, Int32 K_UsuarioAutoriza, DateTime F_Inicial, DateTime F_Final, Int32 K_TipoArticulo, Int32 K_ClasificacionArticulo, Int32 K_GrupoArticulo)
        {
            //***NO BORRAR ESTA FUNCION PORQUE FUE MODIFICADA AQUI DIRECTAMENTE...
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaRequisiciones";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_OficinaRequiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoRequisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_UsuarioRequiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizada", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_UsuarioAutoriza", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_TipoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_ClasificacionArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_GrupoArticulo", SqlDbType.Int));

            //if (K_Requisicion > 0)
            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            //if(K_OficinaRequiere > 0)
            cmd.Parameters["@K_OficinaRequiere"].Value = K_OficinaRequiere;
            //if (K_TipoRequisicion > 0)
            cmd.Parameters["@K_TipoRequisicion"].Value = K_TipoRequisicion;
            //if (K_Estatus_Compra > 0)
            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            //if (K_UsuarioRequiere > 0)
            cmd.Parameters["@K_UsuarioRequiere"].Value = K_UsuarioRequiere;

            cmd.Parameters["@B_Autorizada"].Value = B_Autorizada;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            //if (K_UsuarioAutoriza > 0)
            cmd.Parameters["@K_UsuarioAutoriza"].Value = K_UsuarioAutoriza;

            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            //if (K_TipoArticulo > 0)
            cmd.Parameters["@K_TipoArticulo"].Value = K_TipoArticulo;
            //if (K_ClasificacionArticulo > 0)
            cmd.Parameters["@K_ClasificacionArticulo"].Value = K_ClasificacionArticulo;
            //if (K_GrupoArticulo > 0)
            cmd.Parameters["@K_GrupoArticulo"].Value = K_GrupoArticulo;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_ReporteOrdenesCompra(Int32 K_OrdenCompra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ReporteOrdenesCompra";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_ConsultaOrdenesCompraDetalle(Int32 K_OrdenCompra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompraDetalle";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        public DataTable Sk_Consulta_SeguimientoOrdenesCompra(Int32 K_OrdenCompra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Consulta_SeguimientoOrdenesCompra";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Consulta_SeguimientoOrdenesCompra(Int32 K_OrdenCompra, Int32 K_Oficina, Int32 K_Proveedor, DateTime F_Inicial, DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Consulta_SeguimientoOrdenesCompra";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));

            cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public DataTable Sk_ConsultaOrdenesCompra(Int32 K_OrdenCompra, Int32 K_Oficina, Int32 K_Proveedor, DateTime? F_Inicial, DateTime? F_Final, bool B_PorRecibir)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompra";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_PorRecibir", SqlDbType.Bit));


            if(K_OrdenCompra==0)
            {
                cmd.Parameters["@K_OrdenCompra"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            }
            if(K_Oficina==0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }
            if(K_Proveedor==0)
            {
                cmd.Parameters["@K_Proveedor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            }
      
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            cmd.Parameters["@B_PorRecibir"].Value = B_PorRecibir;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_ConsultaOrdenesCompra(Int32 K_EstatusCompra, bool B_Cancelada)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompra";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_EstatusCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));

            cmd.Parameters["@K_EstatusCompra"].Value = K_EstatusCompra;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_ConsultaOrdenesCompra(Int32 K_OrdenCompra, Int32 K_Oficina, Int32 K_Proveedor, Int32 K_EstatusCompra, Int16 K_TipoMoneda, bool B_Cancelada, DateTime? F_Inicial, DateTime? F_Final, Int32 K_Requisicion, Int32 K_TipoArticulo, Int32 K_ClasificacionArticulo, Int32 K_GrupoArticulo,bool? B_Directa, bool? B_ConFactura)
        {
            //***NO BORRAR ESTA FUNCION PORQUE FUE MODIFICADA AQUI DIRECTAMENTE...
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompra";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_EstatusCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoMoneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_ClasificacionArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_GrupoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Directa", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_ConFactura", SqlDbType.Bit));

            if (K_OrdenCompra > 0)
                cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            else
                cmd.Parameters["@K_OrdenCompra"].Value = DBNull.Value;
            if (K_Oficina > 0)
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            else
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            if (K_Proveedor > 0)
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            if (K_EstatusCompra > 0)
                cmd.Parameters["@K_EstatusCompra"].Value = K_EstatusCompra;
            if (K_TipoMoneda > 0)
                cmd.Parameters["@K_TipoMoneda"].Value = K_TipoMoneda;

            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            if (K_Requisicion > 0)
                cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            if (K_TipoArticulo > 0)
                cmd.Parameters["@K_TipoArticulo"].Value = K_TipoArticulo;
            if (K_ClasificacionArticulo > 0)
                cmd.Parameters["@K_ClasificacionArticulo"].Value = K_ClasificacionArticulo;
            if (K_GrupoArticulo > 0)
                cmd.Parameters["@K_GrupoArticulo"].Value = K_GrupoArticulo;
            cmd.Parameters["@B_Directa"].Value = B_Directa;
            cmd.Parameters["@B_ConFactura"].Value = B_ConFactura;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_SugiereProveedorRequisicion(Int32 K_Requisicion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_SugiereProveedorRequisicion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public int Gp_InsertaOrdenCompra(ref Int32 K_Orden_Compra, Int32 K_Oficina_Recibe, Int32 K_Almacen, Int32 K_Sucursal_Proveedor, Int32 K_Proveedor, Int16 K_Tipo_Moneda,
                                         decimal Tipo_Cambio, DateTime F_Entrega, Int16 TiempoEntrega, Int32 K_Usuario_Elaboro, string Observaciones,
                                         DataTable DetalleRequisicion, ref bool B_ImprimeOC, ref string CorreosAutorizo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_InsertaOrdenCompra";

            IDataParameter p_K_Orden_Compra = new SqlParameter("@K_Orden_Compra", SqlDbType.Int);
            p_K_Orden_Compra.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Orden_Compra);

            IDataParameter p_B_ImprimeOC = new SqlParameter("@B_ImprimeOC", SqlDbType.Bit);
            p_B_ImprimeOC.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_B_ImprimeOC);

            IDataParameter p_CorreosAutorizo = new SqlParameter("@CorreosAutorizo", SqlDbType.VarChar, 1000);
            p_CorreosAutorizo.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_CorreosAutorizo);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Sucursal_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@F_Entrega", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@TiempoEntrega", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Elaboro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 4000));
            cmd.Parameters.Add(new SqlParameter("@DetalleRequisicion", SqlDbType.Structured));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Oficina_Recibe"].Value = K_Oficina_Recibe;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Sucursal_Proveedor"].Value = K_Sucursal_Proveedor;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;
            cmd.Parameters["@F_Entrega"].Value = F_Entrega;
            cmd.Parameters["@TiempoEntrega"].Value = TiempoEntrega;
            cmd.Parameters["@K_Usuario_Elaboro"].Value = K_Usuario_Elaboro;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@DetalleRequisicion"].Value = DetalleRequisicion;
            cmd.Parameters["@B_ImprimeOC"].Value = B_ImprimeOC;
            cmd.Parameters["@CorreosAutorizo"].Value = CorreosAutorizo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Orden_Compra = (Int32)p_K_Orden_Compra.Value;
            B_ImprimeOC = (bool)p_B_ImprimeOC.Value;
            if (p_CorreosAutorizo.Value.ToString().Trim().Length > 0)
                CorreosAutorizo = (string)p_CorreosAutorizo.Value;
            else
                CorreosAutorizo = string.Empty;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_EditaOrdenCompra(Int32 K_Orden_Compra, Int32 K_Usuario, DataTable DetalleRequisicion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_EditaOrdenCompra";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetalleRequisicion", SqlDbType.Structured));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@DetalleRequisicion"].Value = DetalleRequisicion;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Gp_Sk_ReporteOC(Int32 K_Orden_Compra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Sk_ReporteOC";

            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }



        public int Gp_ValidaPuedeAgregar(Int32 K_RequisicionExiste, Int32 K_RequisicionAgregar, ref bool B_PuedeAgregar, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaPuedeAgregar";

            IDataParameter p_B_PuedeAgregar = new SqlParameter("@B_PuedeAgregar", SqlDbType.Bit);
            p_B_PuedeAgregar.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_B_PuedeAgregar);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 2000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_RequisicionExiste", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_RequisicionAgregar", SqlDbType.Int));

            cmd.Parameters["@K_RequisicionExiste"].Value = K_RequisicionExiste;
            cmd.Parameters["@K_RequisicionAgregar"].Value = K_RequisicionAgregar;
            cmd.Parameters["@B_PuedeAgregar"].Value = B_PuedeAgregar;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            B_PuedeAgregar = (bool)p_B_PuedeAgregar.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Requisicion(Int32 K_Estatus_Compra, bool B_Autorizada, bool B_Cancelada)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            cmd.Parameters["@B_Autorizada"].Value = B_Autorizada;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public DataTable Sk_Requisicion_OC( bool B_Autorizada, bool B_Cancelada)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion_OC";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Autorizada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters["@B_Autorizada"].Value = B_Autorizada;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }


        public DataTable Sk_UsuariosxClasificacionArticulo()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_UsuariosxClasificacionArticulo";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Dl_UsuariosClasificacionArticulos(Int32 K_Usuario, Int32 K_Clasificacion_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_UsuariosClasificacionArticulos";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clasificacion_Articulo", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Clasificacion_Articulo"].Value = K_Clasificacion_Articulo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int In_UsuariosClasificacionArticulos(Int32 K_Usuario, Int32 K_Clasificacion_Articulo, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_UsuariosClasificacionArticulos";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Clasificacion_Articulo", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Clasificacion_Articulo"].Value = K_Clasificacion_Articulo;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_ClasificacionArticulos_Disponibles()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ClasificacionArticulos_Disponibles";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_ClasificacionArticulos_Asignados()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ClasificacionArticulos_Asignados";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_ActualizaRequisicion(Int32 K_Requisicion, Int32 K_Oficina_Requiere, Int32 K_Usuario_Requiere, string Observaciones, decimal TotalRequisicion, DataTable DetalleRequisicion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ActualizaRequisicion";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Requiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Requiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2147483647));
            cmd.Parameters.Add(new SqlParameter("@TotalRequisicion", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@DetalleRequisicion", SqlDbType.Structured));

            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_Oficina_Requiere"].Value = K_Oficina_Requiere;
            cmd.Parameters["@K_Usuario_Requiere"].Value = K_Usuario_Requiere;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@TotalRequisicion"].Value = TotalRequisicion;
            cmd.Parameters["@DetalleRequisicion"].Value = DetalleRequisicion;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_RequisicionDetalle(Int32 K_Requisicion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_RequisicionDetalle";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));

            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_RequisicionDetalle(Int32 K_Requisicion, Int32 K_Proveedor)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_RequisicionDetalle";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }


        public int Gp_InsertaRequisicion(ref Int32 K_Requisicion, Int32 K_Oficina_Requiere, Int32 K_Almacen, Int16 K_Tipo_Requisicion, Int32 K_Usuario_Requiere, Decimal TotalRequisicion, string Observaciones, DataTable DetalleRequisicion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_InsertaRequisicion";

            IDataParameter p_K_Requisicion = new SqlParameter("@K_Requisicion", SqlDbType.Int);
            p_K_Requisicion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Requisicion);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Requiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Requisicion", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Requiere", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@TotalRequisicion", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 2147483647));
            cmd.Parameters.Add(new SqlParameter("@DetalleRequisicion", SqlDbType.Structured));

            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_Oficina_Requiere"].Value = K_Oficina_Requiere;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Tipo_Requisicion"].Value = K_Tipo_Requisicion;
            cmd.Parameters["@K_Usuario_Requiere"].Value = K_Usuario_Requiere;
            cmd.Parameters["@TotalRequisicion"].Value = TotalRequisicion;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@DetalleRequisicion"].Value = DetalleRequisicion;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Requisicion = (Int32)p_K_Requisicion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Requisicion(bool B_Cancelada, Int32 K_UsuarioAutoriza)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_UsuarioAutoriza", SqlDbType.Int));
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@K_UsuarioAutoriza"].Value = K_UsuarioAutoriza;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Requisicion(Int32 K_Estatus_Compra,bool B_Cancelada)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Requisicion(Int32 K_UsuarioRequiere)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_UsuarioRequiere", SqlDbType.Int));
            cmd.Parameters["@K_UsuarioRequiere"].Value = K_UsuarioRequiere;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public DataTable Sk_Requisicion()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_Requisicion_Mod(Int32 K_Requisicion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));


            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;


            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }
        public DataTable Sk_Requisicion(Int32 K_Requisicion, Int32 K_Oficina, Int32 K_Almacen ,Int32 K_Estatus_Compra, bool B_Autorizada, bool B_Cancelada)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Requisicion";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autorizada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));

            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Estatus_Compra"].Value = K_Estatus_Compra;
            cmd.Parameters["@B_Autorizada"].Value = B_Autorizada;
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public int In_Usuario_AutorizaRequisicion( Int32 K_Usuario, bool B_Autoriza, bool B_Autoriza_2,ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Usuario_AutorizaRequisicion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Ingresa", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autoriza", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Autoriza_2", SqlDbType.Bit));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Usuario_Ingresa"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@B_Autoriza"].Value = B_Autoriza;
            cmd.Parameters["@B_Autoriza_2"].Value = B_Autoriza_2;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }


        public int Dl_Usuario_AutorizaRequisicion(Int32 K_Usuario, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_Usuario_AutorizaRequisicion";

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 300);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Elimina", SqlDbType.Int));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@K_Usuario_Elimina"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;
            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

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
        public DataTable Sk_UsuariosxAutorizaArticulos(string D_Usuario)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_UsuariosxAutorizaArticulos";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@D_Usuario", SqlDbType.VarChar));
            cmd.Parameters["@D_Usuario"].Value = D_Usuario;
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



        public void GP_Carga_Requisiciones(
            Int32 K_Oficina,
            Int32 K_Almacen,
            Int32 K_Proveedor,
            string SKU, 
            Int32 Cantidad, 
            string Archivo_Subio,
            Int32 K_Usuario,
            string Pc_Name)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Carga_Requisiciones";

            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@SKU", SqlDbType.VarChar,100));
            cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Archivo_Subio", SqlDbType.VarChar,100));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar,30));

            cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@SKU"].Value = SKU;
            cmd.Parameters["@Cantidad"].Value = Cantidad;
            cmd.Parameters["@Archivo_Subio"].Value = Archivo_Subio;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = Pc_Name;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);


        }

        public int Gp_Sube_Requisiciones(
           Int32 K_Usuario,
           string Pc_Name)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Sube_Requisiciones";

            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = Pc_Name;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;
        }
       
        public DataTable Sk_ConsultaOrdenesCompra(Int32 K_OrdenCompra, Int32 K_Oficina, Int32 K_Proveedor, Int32 K_EstatusCompra, Int16 K_TipoMoneda, bool B_Cancelada, DateTime F_Inicial, DateTime F_Final, Int32 K_Requisicion, Int32 K_TipoArticulo, Int32 K_ClasificacionArticulo, Int32 K_GrupoArticulo, bool bPorRecibir)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompra";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_EstatusCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoMoneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_ClasificacionArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_GrupoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_PorRecibir", SqlDbType.Bit));

            if (K_OrdenCompra > 0)
                cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            if (K_Oficina > 0)
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Proveedor > 0)
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            if (K_EstatusCompra > 0)
                cmd.Parameters["@K_EstatusCompra"].Value = K_EstatusCompra;
            if (K_TipoMoneda > 0)
                cmd.Parameters["@K_TipoMoneda"].Value = K_TipoMoneda;

            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            if (K_Requisicion > 0)
                cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            if (K_TipoArticulo > 0)
                cmd.Parameters["@K_TipoArticulo"].Value = K_TipoArticulo;
            if (K_ClasificacionArticulo > 0)
                cmd.Parameters["@K_ClasificacionArticulo"].Value = K_ClasificacionArticulo;
            if (K_GrupoArticulo > 0)
                cmd.Parameters["@K_GrupoArticulo"].Value = K_GrupoArticulo;

            cmd.Parameters["@B_PorRecibir"].Value = bPorRecibir;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Sk_ConsultaOrdenesCompraInv(Int32 K_OrdenCompra, Int32 K_Oficina, Int32 K_Proveedor, Int32 K_EstatusCompra, Int16 K_TipoMoneda, bool B_Cancelada, DateTime F_Inicial, DateTime F_Final, Int32 K_Requisicion, Int32 K_TipoArticulo, Int32 K_ClasificacionArticulo, Int32 K_GrupoArticulo, bool bPorRecibir)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompraInv";
            DataTable dt = new DataTable();



            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_EstatusCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoMoneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_ClasificacionArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_GrupoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_PorRecibir", SqlDbType.Bit));

            if (K_OrdenCompra > 0)
                cmd.Parameters["@K_OrdenCompra"].Value = K_OrdenCompra;
            if (K_Oficina > 0)
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            if (K_Proveedor > 0)
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            if (K_EstatusCompra > 0)
                cmd.Parameters["@K_EstatusCompra"].Value = K_EstatusCompra;
            if (K_TipoMoneda > 0)
                cmd.Parameters["@K_TipoMoneda"].Value = K_TipoMoneda;

            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            if (K_Requisicion > 0)
                cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            if (K_TipoArticulo > 0)
                cmd.Parameters["@K_TipoArticulo"].Value = K_TipoArticulo;
            if (K_ClasificacionArticulo > 0)
                cmd.Parameters["@K_ClasificacionArticulo"].Value = K_ClasificacionArticulo;
            if (K_GrupoArticulo > 0)
                cmd.Parameters["@K_GrupoArticulo"].Value = K_GrupoArticulo;

            cmd.Parameters["@B_PorRecibir"].Value = bPorRecibir;
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public DataTable Gp_RepFacturas_Proveedor(
            Int32 K_OrdenCompra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_RepFacturas_Proveedor";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Autoriza_SinFactura", SqlDbType.Bit));
            
            cmd.Parameters["@K_Orden_Compra"].Value = K_OrdenCompra;
            cmd.Parameters["@B_Autoriza_SinFactura"].Value = 0;

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }

        public void GP_Bloquea_Movimientos(
          Int32 K_Requisicion,
          Int32 K_Pedido,
          Int32 K_Factura)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GP_Bloquea_Movimientos";

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pedido", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Factura", SqlDbType.Int));

            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_Pedido"].Value = K_Pedido;
            cmd.Parameters["@K_Factura"].Value = K_Factura;


            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

        }
        public DataTable Gp_Ordenes_CompraProv(Int32 K_Proveedor , DateTime F_Inicial, DateTime F_Final)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Ordenes_CompraProv";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.DateTime));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_EditaOrdenCompraDirecta(Int32 K_Orden_Compra, Int32 K_Usuario, DataTable DetalleOC, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_EditaOrdenCompraDirecta";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@DetalleOC", SqlDbType.Structured));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@DetalleOC"].Value = DetalleOC;
            cmd.Parameters["@Mensaje"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_ConsultaOrdenesCompra()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompra";

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_ConsultaOrdenesCompraDetallaado(Int32 K_OrdenCompra,Int32 K_Oficina, Int32 K_Proveedor,Int32 K_EstatusCompra,
            bool B_Cancelada, DateTime F_Inicial,DateTime F_Final, Int32 K_Requisicion, Int32 K_TipoArticulo,Int32 K_ClasificacionArticulo,
            Int32 K_GrupoArticulo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompraDetallaado";
            DataTable dt = new DataTable();

            cmd.Parameters.Add(new SqlParameter("@K_OrdenCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_EstatusCompra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_TipoArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_ClasificacionArticulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_GrupoArticulo", SqlDbType.Int));

            if(K_OrdenCompra == 0)
            {
                cmd.Parameters["@K_Orden_Compra"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Orden_Compra"].Value = K_OrdenCompra;
            }
            if(K_Oficina == 0)
            {
                cmd.Parameters["@K_Oficina"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Oficina"].Value = K_Oficina;
            }
            if(K_Proveedor == 0)
            {
                cmd.Parameters["@K_Proveedor"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            }
            if(K_EstatusCompra == 0)
            {
                cmd.Parameters["@K_EstatusCompra"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_EstatusCompra"].Value = K_EstatusCompra;
            }
            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@F_Inicial"].Value = F_Inicial;
            cmd.Parameters["@F_Final"].Value = F_Final;
            if(K_Requisicion==0)
            {
                cmd.Parameters["@K_Requisicion"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            }
            if(K_TipoArticulo == 0)
            {
                cmd.Parameters["@K_TipoArticulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_TipoArticulo"].Value = K_TipoArticulo;
            }
            if(K_ClasificacionArticulo == 0)
            {
                cmd.Parameters["@K_ClasificacionArticulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_ClasificacionArticulo"].Value = K_ClasificacionArticulo;
            }
            if(K_GrupoArticulo ==0)
            {
                cmd.Parameters["@K_GrupoArticulo"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@K_GrupoArticulo"].Value = K_GrupoArticulo;
            }


            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
        public DataTable Sk_ConsultaOrdenesCompraDetallaado()
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaOrdenesCompraDetallaado";
            DataTable dt = new DataTable();

            dt = ConnectionClass.GetTable(ref cmd);

            return dt;
        }
    }
}
