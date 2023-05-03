using ProbeMedic.AppCode.DCC;
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
    class SQLRecepcion
    {
        public DataTable Sk_ConsultaEncNotaRecepcion(int K_Nota_Recepcion, int K_Orden_Compra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaEncNotaRecepcion";
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Nota_Recepcion", SqlDbType.Int));
            cmd.Parameters["@K_Nota_Recepcion"].Value = K_Nota_Recepcion;

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }

        #region Detalle Nota Recepcion
        public DataTable Sk_ConsultaNotaRecepcion(int K_Nota_Recepcion, int K_Orden_Compra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsultaNotaRecepcion";
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Nota_Recepcion", SqlDbType.Int));
            cmd.Parameters["@K_Nota_Recepcion"].Value = K_Nota_Recepcion;

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        #endregion

        public int Gp_InsertaNotaRecepcion(ref Int32 K_Nota_Recepcion,
            Int32 K_Orden_Compra,
            Int32 K_Oficina_Recibe,
            Int32 K_Proveedor,
            short Tipo_Documento,
            string NoFactura,
            DateTime F_Factura,
            string NoRemision,
            DateTime F_Remision,
            Int16 K_Tipo_Moneda,
            decimal Tipo_Cambio,
            Decimal SubTotal,
            Decimal TasaIVA,
            Decimal TotalIVA,
            Decimal Total,
            Int32 K_Usuario_Recibe,
            DateTime F_Recepcion,
            bool B_Cancelada,
            Int32 K_Usuario_Cancelada,
            DateTime F_Cancelacion,
            string Observaciones,
            Int32 K_Almacen,
            Decimal TotalFactura,
            bool B_AceptaDiferencias,
            ref string Mensaje,
            DataTable NotaRecepcionDetalle)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_InsertaNotaRecepcion";

            IDataParameter p_K_Nota_Recepcion = new SqlParameter("@K_Nota_Recepcion", SqlDbType.Int);
            p_K_Nota_Recepcion.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_K_Nota_Recepcion);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Documento", SqlDbType.TinyInt));
            cmd.Parameters.Add(new SqlParameter("@NoFactura", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@F_Factura", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@NoRemision", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@F_Remision", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@SubTotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaIVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalIVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 50));
            //cmd.Parameters.Add(new SqlParameter("@F_Recepcion", SqlDbType.SmallDateTime));
            //cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            //cmd.Parameters.Add(new SqlParameter("@K_Usuario_Cancela", SqlDbType.Int));
            //cmd.Parameters.Add(new SqlParameter("@F_Cancelacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 4000));
            cmd.Parameters.Add(new SqlParameter("@K_Almacen", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@B_AceptaDiferencias", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@TotalFactura", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@NotaRecepcionDetalle", SqlDbType.Structured));
            cmd.Parameters.Add(new SqlParameter("@K_Empresa", SqlDbType.Int));
            cmd.Parameters["@K_Nota_Recepcion"].Value = K_Nota_Recepcion;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Oficina_Recibe"].Value = GlobalVar.K_Oficina;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Tipo_Documento"].Value = Tipo_Documento;

            cmd.Parameters["@NoFactura"].Value = NoFactura;
            cmd.Parameters["@F_Factura"].Value = F_Factura;

            cmd.Parameters["@NoRemision"].Value = NoRemision;
            cmd.Parameters["@F_Remision"].Value = F_Remision;

            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;

            cmd.Parameters["@SubTotal"].Value = SubTotal;
            cmd.Parameters["@TasaIVA"].Value = TasaIVA;
            cmd.Parameters["@TotalIVA"].Value = TotalIVA;
            cmd.Parameters["@Total"].Value = Total;

            cmd.Parameters["@K_Usuario_Recibe"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@PC_Name"].Value = GlobalVar.PC_Name;
            //cmd.Parameters["@F_Recepcion"].Value = F_Recepcion;
            //cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            //cmd.Parameters["@K_Usuario_Cancela"].Value = K_Usuario_Cancelada;
            //cmd.Parameters["@F_Cancelacion"].Value = F_Cancelacion;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@K_Almacen"].Value = K_Almacen;
            cmd.Parameters["@TotalFactura"].Value = TotalFactura;
            cmd.Parameters["@B_AceptaDiferencias"].Value = B_AceptaDiferencias;
            cmd.Parameters["@K_Empresa"].Value = GlobalVar.K_Empresa;
            cmd.Parameters["@Mensaje"].Value = Mensaje;
            cmd.Parameters["@NotaRecepcionDetalle"].Value = NotaRecepcionDetalle;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            K_Nota_Recepcion = (Int32)p_K_Nota_Recepcion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        public int Gp_ActualizaNotaRecepcion(Int32 K_Nota_Recepcion,
            Int32 K_Orden_Compra,
            Int32 K_Oficina_Recibe,
            Int32 K_Proveedor,
            short Tipo_Documento,
            string NoFactura,
            DateTime F_Factura,
            string NoRemision,
            DateTime F_Remision,
            Int16 K_Tipo_Moneda,
            decimal Tipo_Cambio,
            Decimal SubTotal,
            Decimal TasaIVA,
            Decimal TotalIVA,
            Decimal Total,
            Int32 K_Usuario_Recibe,
            DateTime F_Recepcion,
            bool B_Cancelada,
            Int32 K_Usuario_Cancelada,
            DateTime F_Cancelacion,
            string Observaciones,
            ref string Mensaje,
            DataTable NotaRecepcionDetalle)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ActualizaNotaRecepcion";

            IDataParameter p_K_Nota_Recepcion = new SqlParameter("@K_Nota_Recepcion", SqlDbType.Int);
            p_K_Nota_Recepcion.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(p_K_Nota_Recepcion);

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 1000);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Oficina_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Documento", SqlDbType.TinyInt));
            cmd.Parameters.Add(new SqlParameter("@NoFactura", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@F_Factura", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@NoRemision", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@F_Remision", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Tipo_Moneda", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Cambio", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@SubTotal", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TasaIVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@TotalIVA", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Total", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Recibe", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Recepcion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@B_Cancelada", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Cancela", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@F_Cancelacion", SqlDbType.SmallDateTime));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 4000));

            cmd.Parameters.Add(new SqlParameter("@NotaRecepcionDetalle", SqlDbType.Structured));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Oficina_Recibe"].Value = K_Oficina_Recibe;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Tipo_Documento"].Value = Tipo_Documento;

            cmd.Parameters["@NoFactura"].Value = NoFactura;
            cmd.Parameters["@F_Factura"].Value = F_Factura;

            cmd.Parameters["@NoRemision"].Value = NoRemision;
            cmd.Parameters["@F_Remision"].Value = F_Remision;

            cmd.Parameters["@K_Tipo_Moneda"].Value = K_Tipo_Moneda;
            cmd.Parameters["@Tipo_Cambio"].Value = Tipo_Cambio;

            cmd.Parameters["@SubTotal"].Value = SubTotal;
            cmd.Parameters["@TasaIVA"].Value = TasaIVA;
            cmd.Parameters["@TotalIVA"].Value = TotalIVA;
            cmd.Parameters["@Total"].Value = Total;

            cmd.Parameters["@K_Usuario_Recibe"].Value = K_Usuario_Recibe;
            cmd.Parameters["@F_Recepcion"].Value = F_Recepcion;

            cmd.Parameters["@B_Cancelada"].Value = B_Cancelada;
            cmd.Parameters["@K_Usuario_Cancela"].Value = K_Usuario_Cancelada;
            cmd.Parameters["@F_Cancelacion"].Value = F_Cancelacion;
            cmd.Parameters["@Observaciones"].Value = Observaciones;
            cmd.Parameters["@Mensaje"].Value = Mensaje;
            cmd.Parameters["@NotaRecepcionDetalle"].Value = NotaRecepcionDetalle;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            //K_Nota_Recepcion = (Int32)p_K_Nota_Recepcion.Value;
            Mensaje = (string)p_Mensaje.Value;

            return res;
        }

        #region Consulta Notas Recepcion
        public IEnumerable<ConsultaNotaRecepcionDTO> Sk_ConsNotaRecepcion2(
            int K_Nota_Recepcion,
            int K_Orden_Compra,
            DateTime? fechaInicial,
            DateTime? fechaFinal,
            int K_Proveedor
            )
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_ConsNotaRecepcion2";
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Nota_Recepcion", SqlDbType.Int));
            cmd.Parameters["@K_Nota_Recepcion"].Value = K_Nota_Recepcion;

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;

            cmd.Parameters.Add(new SqlParameter("@F_Inicial", SqlDbType.SmallDateTime));
            if (fechaInicial.HasValue)
                cmd.Parameters["@F_Inicial"].Value = fechaInicial.Value;
            else
                cmd.Parameters["@F_Inicial"].Value = DBNull.Value;
            cmd.Parameters.Add(new SqlParameter("@F_Final", SqlDbType.SmallDateTime));
            if (fechaFinal.HasValue)
                cmd.Parameters["@F_Final"].Value = fechaFinal.Value;
            else
                cmd.Parameters["@F_Final"].Value = DBNull.Value;

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            if (dt == null)
            {
                return new ConsultaNotaRecepcionDTO[0];
            }
            //return dt;
            IList<ConsultaNotaRecepcionDTO> list = new List<ConsultaNotaRecepcionDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                var obj = new ConsultaNotaRecepcionDTO();
                obj.KNotaRecepcion = Convert.ToInt32(dr["K_Nota_Recepcion"].ToString());
                obj.KOrdenCompra = Convert.ToInt32(dr["K_Orden_Compra"].ToString());
                obj.KOficinaRecibe = Convert.ToInt32(dr["K_Oficina_Recibe"].ToString());
                obj.KProveedor = Convert.ToInt32(dr["K_Proveedor"].ToString());
                obj.KTipoDocumento = Convert.ToInt32(dr["K_Tipo_Documento"].ToString());
                //obj.DTipoDocumento = Convert.ToInt32(dr["Tipo_Documento"].ToString()) == 2 ? "Factura" : "Remision";
                //obj.DTipoDocumento = dr["D_Tipo_Documento"].ToString();
                //obj.NoDocumento = Convert.ToInt32(dr["Tipo_Documento"].ToString()) == 2 ? dr["NoFactura"].ToString() : dr["NoRemision"].ToString();
                //obj.NoDocumento = Convert.ToInt32(dr["Tipo_Documento"].ToString()) == 2 ? dr["NoFactura"].ToString() : dr["NoRemision"].ToString();
                if ((dr["NoFactura"].ToString() != null) && (dr["NoFactura"].ToString() != ""))
                    obj.NoDocumento = dr["NoFactura"].ToString();
                if ((dr["NoRemision"].ToString() != null) && (dr["NoRemision"].ToString() != ""))
                    obj.NoDocumento = dr["NoRemision"].ToString();
                obj.KTipoMoneda = Convert.ToInt32(dr["K_Tipo_Moneda"].ToString());
                obj.DTipoMoneda = Convert.ToInt32(dr["K_Tipo_Moneda"].ToString()) == 2 ? "Pesos" : "Dollares";
                obj.TipoCambio = Convert.ToDecimal(dr["Tipo_Cambio"].ToString());
                obj.SubTotal = Convert.ToDecimal(dr["Subtotal"].ToString());
                obj.TasaIva = Convert.ToDecimal(dr["TasaIVA"].ToString());
                obj.TotalIva = Convert.ToDecimal(dr["TotalIVA"].ToString());
                obj.Total = Convert.ToDecimal(dr["Total"].ToString());
                obj.KUsuarioRecibe = Convert.ToInt32(dr["K_Usuario_Recibe"].ToString());
                obj.DUsuarioRecibe = "";
                obj.FRecepcion = Convert.ToDateTime(dr["F_Recepcion"].ToString());
                obj.BCancelada = Convert.ToBoolean(dr["B_Cancelada"].ToString());
                obj.Observaciones = dr["Observaciones"].ToString();
                obj.DOficinaRecibe = dr["D_Oficina"].ToString();
                obj.DProveedor = dr["D_Proveedor"].ToString();

                //obj.FDocumento = Convert.ToInt32(dr["Tipo_Documento"].ToString()) == 2 ? Convert.ToDateTime(dr["F_Factura"].ToString()) : Convert.ToDateTime(dr["F_Remision"].ToString());
                //if ((dr["F_Factura"].ToString() != null) && (dr["F_Factura"].ToString().Trim() != ""))
                //    obj.FDocumento = Convert.ToDateTime(dr["F_Factura"].ToString());
                //if ((dr["F_Remision"].ToString() != null) && (dr["F_Remision"].ToString().Trim() != ""))
                //    obj.FDocumento = Convert.ToDateTime(dr["F_Remision"].ToString());

                list.Add(obj);
            }


            return list.ToArray<ConsultaNotaRecepcionDTO>();

        }
        #endregion

        #region Detalle Consulta Notas Recepcion
        public IEnumerable<ConsultaNotaRecepcionDetalleDTO> Sk_ConsultaNotaRecepcion(DataTable dt)
        {
            IList<ConsultaNotaRecepcionDetalleDTO> list = new List<ConsultaNotaRecepcionDetalleDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                var obj = new ConsultaNotaRecepcionDetalleDTO();
                obj.K_Detalle_Nota_Recepcion = Convert.ToInt32(dr["K_Detalle_Nota_Recepcion"].ToString());
                obj.K_Nota_Recepcion = Convert.ToInt32(dr["K_Nota_Recepcion"].ToString());
                obj.K_Articulo = Convert.ToInt32(dr["K_Articulo"].ToString());
                obj.Cantidad_Nota = Convert.ToDouble(dr["Cantidad_Nota"].ToString());
                obj.Cantidad_Recibida = Convert.ToDouble(dr["Cantidad_Recibida"].ToString());
                obj.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"].ToString());
                obj.TasaIva = Convert.ToDecimal(dr["TasaIVA"].ToString());
                obj.TotalIva = Convert.ToDecimal(dr["TotalIVA"].ToString());
                obj.TotalDetalle = Convert.ToDecimal(dr["TotalDetalle"].ToString());
                obj.No_Lote = dr["Lote"].ToString();
                obj.B_Recibe_Completa = Convert.ToBoolean(dr["B_Recibe_Completa"].ToString());
                obj.F_Recepcion = Convert.ToDateTime(dr["F_Recepcion"].ToString());
                obj.D_Articulo = dr["D_Articulo"].ToString();
                obj.D_Unidad_Medida = dr["D_Unidad_Medida"].ToString();
                obj.D_Tipo_Articulo = dr["D_Tipo_Producto"].ToString();
                obj.D_Clasificacion_Articulo = dr["D_Categoria_Articulo"].ToString();
                obj.Cantidad_Empaques = Convert.ToInt32(dr["Cantidad"].ToString());
                obj.Imagen = new byte[0];
                list.Add(obj);
            }
            return list.ToArray<ConsultaNotaRecepcionDetalleDTO>();
        }
        #endregion
        public DataTable Sk_Facturas_Proveedor(int K_Proveedor, int K_Orden_Compra, string Factura)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Facturas_Proveedor";
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Factura", SqlDbType.VarChar));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Factura"].Value = Factura;
            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_Actualiza_DocFacturas(Int32 K_Orden_Compra, Int32 K_Proveedor, string Factura, string Archivo, bool B_Xml, bool B_Pdf, bool B_Autroriza, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Actualiza_DocFacturas";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Factura", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Registro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Archivo_Subio", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@B_Xml", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Pdf", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@B_Autoriza_SinFactura", SqlDbType.Bit));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Factura"].Value = Factura;
            cmd.Parameters["@K_Usuario_Registro"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Archivo_Subio"].Value = Archivo;
            cmd.Parameters["@Pc_Name"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@B_Xml"].Value = B_Xml;
            cmd.Parameters["@B_Pdf"].Value = B_Pdf;
            cmd.Parameters["@B_Autoriza_SinFactura"].Value = B_Autroriza;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }



        public int In_Registro_Escaneo_NRecepcion(
            int k_orden_compra,
            string factura,
            DataTable registro_escaneo)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "In_Registro_Escaneo_NRecepcion";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Factura", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario_Registro", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Pc_Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Registra_Escaneo", SqlDbType.Structured));


            cmd.Parameters["@K_Orden_Compra"].Value = k_orden_compra;
            cmd.Parameters["@Factura"].Value = factura;
            cmd.Parameters["@K_Usuario_Registro"].Value = GlobalVar.K_Usuario;
            cmd.Parameters["@Pc_Name"].Value = GlobalVar.PC_Name;
            cmd.Parameters["@Registra_Escaneo"].Value = registro_escaneo;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            return res;

        }

        public DataTable Sk_Registro_Escaneo_NRecepcion(int K_Orden_Compra)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Registro_Escaneo_NRecepcion";

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Gp_Valida_PuntoReOrden(Int32 K_Requisicion, Int32 K_Articulo, Int32 Cantidad_Suma, Int32 Cantidad_Resta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Valida_PuntoReOrden";

            cmd.Parameters.Add(new SqlParameter("@K_Requisicion", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Suma", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Resta", SqlDbType.Int));
            cmd.Parameters["@K_Requisicion"].Value = K_Requisicion;
            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@Cantidad_Suma"].Value = Cantidad_Suma;
            cmd.Parameters["@Cantidad_Resta"].Value = Cantidad_Resta;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public DataTable Gp_Valida_PuntoReOrden(Int32 K_Articulo, Int32 Cantidad_Suma, Int32 Cantidad_Resta)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_Valida_PuntoReOrden";


            cmd.Parameters.Add(new SqlParameter("@K_Articulo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Suma", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Resta", SqlDbType.Int));

            cmd.Parameters["@K_Articulo"].Value = K_Articulo;
            cmd.Parameters["@Cantidad_Suma"].Value = Cantidad_Suma;
            cmd.Parameters["@Cantidad_Resta"].Value = Cantidad_Resta;

            DataTable dt = new DataTable();
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }


        public DataTable Sk_RecepcionFacturasProveedor(DateTime? Fecha_Inicial, DateTime? Fecha_Final, Int32? K_Proveedor, Int32? Tipo_Moneda)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_RecepcionFacturasProveedor";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@Fecha_Inicial", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Final", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Moneda", SqlDbType.Int));

            cmd.Parameters["@Fecha_Inicial"].Value = Fecha_Inicial;
            cmd.Parameters["@Fecha_Final"].Value = Fecha_Final;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Tipo_Moneda"].Value = Tipo_Moneda;

            dt = ConnectionClass.GetTable(ref cmd);



            return dt;
        }

        public int In_RecepcionFacturasProveedor(Int32 K_Proveedor, Int32 K_Orden_Compra, string Serie, Int32 Folio, Int32 Efiscal, Int32 Mes, string NombreArchivo, Int32? K_Estatus, Int32? K_Nota_Credito, Int32? K_CxP, Int32? K_Pago_CxP, string TipoDocumento, Int32? K_Usuario, string Usuario, string PC_Name, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spi_RecepcionFacturasProveedor";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Efiscal", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Mes", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@NombreArchivo", SqlDbType.VarChar, 250));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Nota_Credito", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_CxP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Pago_CxP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Usuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar, 40));
            cmd.Parameters.Add(new SqlParameter("@PC_Name", SqlDbType.VarChar, 60));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@Efiscal"].Value = Efiscal;
            cmd.Parameters["@Mes"].Value = Mes;
            cmd.Parameters["@NombreArchivo"].Value = NombreArchivo;
            cmd.Parameters["@K_Estatus"].Value = K_Estatus;
            cmd.Parameters["@K_Nota_Credito"].Value = K_Nota_Credito;
            cmd.Parameters["@K_CxP"].Value = K_CxP;
            cmd.Parameters["@K_Pago_CxP"].Value = K_Pago_CxP;
            cmd.Parameters["@TipoDocumento"].Value = TipoDocumento;
            cmd.Parameters["@K_Usuario"].Value = K_Usuario;
            cmd.Parameters["@Usuario"].Value = Usuario;
            cmd.Parameters["@PC_Name"].Value = PC_Name;
            cmd.Parameters["@Mensaje"].Value = Mensaje == null ? string.Empty : Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public int Dl_RecepcionFacturasProveedor(Int32 K_Proveedor, Int32 K_Orden_Compra, string TipoDocumento, Int32 K_Operacion, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Dl_RecepcionFacturasProveedor";

            IDataParameter p_Mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);
            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Operacion", SqlDbType.Int));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@TipoDocumento"].Value = TipoDocumento;
            cmd.Parameters["@K_Operacion"].Value = K_Operacion;
            cmd.Parameters["@Mensaje"].Value = Mensaje == null ? string.Empty : Mensaje;

            int res;
            res = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return res;
        }
        public DataTable Sk_Recepcion_Archivos_Proveedores(Int32 K_Proveedor, Int32? K_Orden_Compra, string Serie, Int32? Folio, Int32? K_CxP, string TipoDocumento, Int32 K_Estatus, Int32? K_Operacion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_Recepcion_Archivos_Proveedores";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@Folio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_CxP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar, 30));
            cmd.Parameters.Add(new SqlParameter("@K_Estatus", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Operacion", SqlDbType.Int));

            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@Serie"].Value = Serie;
            cmd.Parameters["@Folio"].Value = Folio;
            cmd.Parameters["@K_CxP"].Value = K_CxP;
            cmd.Parameters["@TipoDocumento"].Value = TipoDocumento;
            cmd.Parameters["@K_Estatus"].Value = K_Estatus;
            cmd.Parameters["@K_Operacion"].Value = K_Operacion;

            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public DataTable Sk_RecepcionesDetalle_XML(Int32 K_Operacion)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sk_RecepcionesDetalle_XML";
            DataTable dt = new DataTable();
            cmd.Parameters.Add(new SqlParameter("@K_Operacion", SqlDbType.Int));
            cmd.Parameters["@K_Operacion"].Value = K_Operacion;
            dt = ConnectionClass.GetTable(ref cmd);
            return dt;
        }
        public int Gp_ValidaFactura(Int32 K_Orden_Compra, Int32 K_Proveedor, string Factura, ref string Mensaje)
        {
            SqlCommand cmd = ConnectionClass.GetCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Gp_ValidaFactura";

            IDataParameter p_RetValue = new SqlParameter("RetValue", SqlDbType.Int);
            p_RetValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p_RetValue);

            IDataParameter p_Mensaje = new SqlParameter("@pmsMsg", SqlDbType.VarChar, 250);
            p_Mensaje.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(p_Mensaje);

            cmd.Parameters.Add(new SqlParameter("@K_Orden_Compra", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@K_Proveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Factura", SqlDbType.VarChar, 30));

            cmd.Parameters["@K_Orden_Compra"].Value = K_Orden_Compra;
            cmd.Parameters["@K_Proveedor"].Value = K_Proveedor;
            cmd.Parameters["@Factura"].Value = Factura;
            cmd.Parameters["@pmsMsg"].Value = Mensaje;

            int ires;
            ires = ConnectionClass.ExecuteNonQuery(ref cmd);

            Mensaje = (string)p_Mensaje.Value;

            return ires;
        }


    }
}
