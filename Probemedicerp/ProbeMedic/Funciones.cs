//using CrystalDecisions.CrystalReports.Engine;
//using DigitalInvoice.Utilerias.SelladoCS;
//using GeneraCodigoQR;
using ProbeMedic.AppCode.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
//using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using XLSExport;
using System.Text.RegularExpressions;

namespace ProbeMedic
{
    public static class Extensiones
    {
        static Dictionary<int, string> carpetas = new Dictionary<int, string>();
        static SQLCatalogos sql = new SQLCatalogos();
        //static CatalogosBL blCatalogos = new CatalogosBL();
        public enum tablas { ftProveedores, ftBonificaciones, ftDevoluciones, ftDevolucionesComentario }

        static Extensiones()
        {
            carpetas.Clear();
            carpetas.Add(1, "1 Proveedor_Sube");
            carpetas.Add(9, "2 Creacion_CxP");
            carpetas.Add(10, "3 Pago_CxP");
            carpetas.Add(6, "4 Elimina Recepcion");
        }

        public static string ObtieneRutaFileTable()
        {
            return null;
            //  return SQLCatalogos.sps_ObtieneRutaFileTable().FirstOrDefault().ruta;
        }

        public static void BorraArchivo(this string rutaArchivo)
        {
            IntPtr userToken = IntPtr.Zero;
            //if (CredencialesAplicacionValidas(ref userToken))
            //{
            //    WindowsIdentity.Impersonate(userToken);

            //    File.Delete(rutaArchivo);
            //}
        }

        public static void ToFolder(this string rutaOrigen, string nombreNuevo, int kEstatus)
        {
            string nombreCompleto = string.Empty;
            nombreCompleto += Path.Combine(ObtieneRutaFileTable(), "ftProveedores", carpetas[kEstatus], nombreNuevo);
            nombreCompleto.ToLog();

            IntPtr userToken = IntPtr.Zero;
            if (CredencialesAplicacionValidas(ref userToken))
            {
                WindowsIdentity.Impersonate(userToken);

                //file.SaveAs(nombreCompleto);
                System.IO.File.Copy(rutaOrigen, nombreCompleto, true);
            }
        }
        public static void ToFolderMove(this string rutaOrigen, string nombreNuevo, int kEstatus)
        {
            string nombreCompleto = string.Empty;
            nombreCompleto += Path.Combine(ObtieneRutaFileTable(), "ftProveedores", carpetas[kEstatus], nombreNuevo);
            nombreCompleto.ToLog();

            IntPtr userToken = IntPtr.Zero;
            if (CredencialesAplicacionValidas(ref userToken))
            {
                WindowsIdentity.Impersonate(userToken);

                //file.SaveAs(nombreCompleto);
                System.IO.File.Move(rutaOrigen, nombreCompleto);
            }
        }


        public static string ToFolder(this string rutaOrigen, string nombreNuevo, tablas tabla)
        {
            string nombreCompleto = string.Empty;
            nombreCompleto += Path.Combine(ObtieneRutaFileTable(), tabla.ToString(), nombreNuevo);

            try
            {
                IntPtr userToken = IntPtr.Zero;
                if (CredencialesAplicacionValidas(ref userToken))
                {
                    WindowsIdentity.Impersonate(userToken);
                    System.IO.File.Copy(rutaOrigen, nombreCompleto, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Copiado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nombreCompleto;
        }

        public static void FromFolder(this string rutaOrigen, string destino)
        {
            IntPtr userToken = IntPtr.Zero;
            if (CredencialesAplicacionValidas(ref userToken))
            {
                WindowsIdentity.Impersonate(userToken);
                System.IO.File.Copy(rutaOrigen, destino, true);
            }
        }



        public static void ToLog(this string cadena, string log = "LOG.log")
        {
            string directorio = @"C:\LOG";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            string conHora = string.Format("{1} {2} - {0}", cadena, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());

            string rutaLog = Path.Combine(directorio, log);
            try
            {
                TextWriter tw = new StreamWriter(rutaLog, true);
                tw.WriteLine(conHora);
                tw.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "Excepción WEB: " + ex.Message);
            }
        }

        public static DateTime PrimerDiaDelMes(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }
        public static DateTime UltimoDiaDelMes(this DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public static IEnumerable<TreeNode> AddRange(this TreeNode collection, IEnumerable<TreeNode> nodes)
        {
            var items = nodes.ToArray();
            collection.Nodes.AddRange(items);
            return new[] { collection };
        }


        public static XDocument toXDocument(this string ruta)
        {
            XDocument xDoc = new XDocument();
            //ruta = @"C:\ProveedoresOsman\I201409-1-5140-1.xml"; //para borrar probar en el servidor
            IntPtr userToken = IntPtr.Zero;
            if (CredencialesAplicacionValidas(ref userToken))
            {
                WindowsIdentity.Impersonate(userToken);
               // XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                XmlTextReader reader = new XmlTextReader(ruta);
                xDoc = XDocument.Load(ruta);
            }

            return xDoc;
        }

        public static Comprobante LeerArchivoXML(this string ruta)
        {
            Comprobante factura = new Comprobante();
            if (ruta == null)
                return factura;


            //ruta = @"C:\ProveedoresOsman\I201409-1-5140-1.xml"; //para borrar probar en el servidor
            IntPtr userToken = IntPtr.Zero;
            if (CredencialesAplicacionValidas(ref userToken))
            {
                WindowsIdentity.Impersonate(userToken);
                XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                XmlTextReader reader = new XmlTextReader(ruta);
                factura = (Comprobante)serializer.Deserialize(reader);
                reader.Close();

            }

            return factura;
        }

        public static bool CredencialesAplicacionValidas(ref IntPtr userToken)
        {
            bool success = LogonUser(
              "Administrador",
              "PROBEMEDIC",
              "01sistemas01-",
              9,//(int)AdvApi32Utility.LogonType.LOGON32_LOGON_INTERACTIVE, //2
              0,//(int)AdvApi32Utility.LogonProvider.LOGON32_PROVIDER_DEFAULT, //0
              out userToken);

            return success;
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LogonUser(
                string lpszUsername,
                string lpszDomain,
                string lpszPassword,
                int dwLogonType,
                int dwLogonProvider,
                out IntPtr phToken);

        public static decimal TruncateDecimal(this decimal value, int decimalPlaces)
        {
            decimal integralValue = Math.Truncate(value);
            decimal fraction = value - integralValue;
            decimal factor = (decimal)Math.Pow(10, decimalPlaces);
            decimal truncatedFraction = Math.Truncate(fraction * factor) / factor;
            decimal result = integralValue + truncatedFraction;

            return result;
        }
        //public static string toParametrosUrl(this EtiquetaParametros dt)
        //{
        //    string caracter = "/";
        //    string vacio = "VACIO";
        //    string espacio = "ESPACIO";
        //    string parametros = string.Empty;
        //    StringBuilder sb = new StringBuilder();
        //    string dArticulo = espacio;
        //    string ubicacion = espacio;
        //    string comentariopartida = espacio;
        //    if (dt.D_Articulo.Trim().Length > 0)
        //        dArticulo = dt.D_Articulo;
        //    if (dt.Ubicacion.Trim().Length > 0)
        //        ubicacion = dt.Ubicacion;
        //    if (dt.Comentario.Trim().Length > 0)
        //        comentariopartida = dt.Comentario;

        //    sb.Append(dt.K_Etiqueta.ToString()).Append(caracter);
        //    sb.Append(dt.Partida.ToString()).Append(caracter);
        //    sb.Append(dt.K_Almacen.ToString()).Append(caracter);
        //    sb.Append(dt.D_Almacen == null ? vacio : dt.D_Almacen.Replace(" ", espacio)).Append(caracter);
        //    sb.Append(dt.K_Articulo.ToString()).Append(caracter);
        //    sb.Append(dArticulo).Append(caracter);
        //    sb.Append(dt.K_Producto.ToString()).Append(caracter);
        //    sb.Append(dt.D_Producto == null ? vacio : dt.D_Producto.Replace(" ", espacio)).Append(caracter);
        //    sb.Append(dt.Lote == null ? vacio : dt.Lote.Replace(" ", espacio)).Append(caracter);
        //    sb.Append(dt.F_Inserta.ToShortDateString().Replace("/", "-")).Append(caracter);
        //    sb.Append(dt.K_Oficina.ToString()).Append(caracter);
        //    sb.Append(dt.D_Oficina == null ? vacio : dt.D_Oficina.Replace(" ", espacio)).Append(caracter);
        //    sb.Append(dt.K_Tipo_Empaque.ToString()).Append(caracter);
        //    sb.Append(dt.D_Tipo_Empaque == null ? vacio : dt.D_Tipo_Empaque.Replace(" ", espacio)).Append(caracter);
        //    sb.Append(dt.Peso.ToString()).Append(caracter); //peso del empaque
        //    sb.Append(dt.Cantidad.ToString()).Append(caracter);
        //    sb.Append(dt.Kg.ToString()).Append(caracter);
        //    sb.Append(ubicacion).Append(caracter); //Ubicacion
        //    sb.Append(comentariopartida).Append(caracter); //Comentarios
        //    sb.Append(dt.Origen).Append(caracter);
        //    sb.Append("");//en el ultmo renglon no poner el /

        //    parametros = sb.ToString();
        //    return parametros;
        //}

        //public static bool IsRowEmpty<T>(this T o)
        //{
        //    bool b_EsVacio = true;

        //    foreach (PropertyInfo pi in o.GetType().GetProperties())
        //    {
        //        //if (pi.PropertyType == typeof(string))
        //        //{
        //        string value = pi.GetValue(o)?.ToString();
        //        if (value != null)
        //        {
        //            if (!string.IsNullOrEmpty(value))
        //            {
        //                if (value != "0")
        //                {
        //                    b_EsVacio = false;
        //                    break;
        //                }
        //            }
        //        }

        //        //}
        //    }

        //    return b_EsVacio;



        //}

        public static string toTableHTML5(this System.Data.DataTable dt, List<string> campos = null)
        {
            StringBuilder html = new StringBuilder();
            html.Append("<table width=\"60%\" border=\"0\" cellspacing=\"5\">");
            int con = 0;
            foreach (DataColumn myColumn in dt.Columns)
            {
                html.Append("<tr>");

                string nombreColumna = myColumn.ColumnName;
                if (campos != null && con < campos.Count)
                    nombreColumna = campos[con];

                html.Append("<td width=\"30%\" align=\"right\"style=\"font-size:12pt;font-weight:bold\">" + nombreColumna + "</td>");
                html.Append("<td width=\"5%\"></td>");
                html.Append("<td width=\"65%\">" + dt.Rows[0][myColumn.ColumnName].ToString() + "</td>");

                html.Append("</tr>");
                con++;
            }

            html.Append("</table>");

            return html.ToString();
        }



        public static T ToObject<T>(this DataRow datarow) where T : new()
        {
            T data = new T();
            T item = GetItem<T>(datarow);
            data = item;

            return data;
        }


        public static List<T> ToList<T>(this System.Data.DataTable dt) where T : new()
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (column.DataType == typeof(string))
                            pro.SetValue(obj, dr[column.ColumnName] == System.DBNull.Value ? string.Empty : dr[column.ColumnName], null);
                        else
                            pro.SetValue(obj, dr[column.ColumnName] == System.DBNull.Value ? null : dr[column.ColumnName], null);
                    }
                    else
                        continue;
                }
            }
            return obj;
        }
        public static System.Data.DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            System.Data.DataTable table = new System.Data.DataTable();
            table.TableName = "Datos";
            if (data == null)
                return table;

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            if (table.Columns.Contains("ExtensionData"))
                table.Columns.Remove("ExtensionData");

            return table;

        }
    }
    public class Funciones
    {

        public System.Data.DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = ((System.Data.DataTable)dgv.DataSource).Copy();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (!column.Visible)
                {
                    if (column.IsDataBound)
                    {
                        dt.Columns.Remove(column.DataPropertyName);
                    }
                }
            }
            return dt;
        }

        //public string ObtieneCadenaConexion()
        //{
        //    string cadena = string.Empty;
        //    Conexion cn = new Conexion();
        //    string ConexionActiva = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
        //    if (ConexionActiva.Trim().ToUpper() == "LOCAL")
        //    {
        //        cn.Servidor = ConfigurationManager.AppSettings["ServidorLocal"].ToString();
        //        cn.Base = ConfigurationManager.AppSettings["BaseLocal"].ToString();
        //        cn.Usuario = ConfigurationManager.AppSettings["UsuarioLocal"].ToString();
        //        cn.Contrasena = ConfigurationManager.AppSettings["ContrasenaLocal"].ToString();
        //    }
        //    else
        //    {
        //        cn.Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
        //        cn.Base = ConfigurationManager.AppSettings["Base"].ToString();
        //        cn.Usuario = ConfigurationManager.AppSettings["Usuario"].ToString();
        //        cn.Contrasena = ConfigurationManager.AppSettings["Contrasena"].ToString();
        //    }
        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //    builder.InitialCatalog = cn.Base;
        //    builder.DataSource = cn.Servidor;
        //    builder.UserID = cn.Usuario;
        //    builder.Password = cn.Contrasena;
        //    builder.Pooling = true;
        //    builder.MaxPoolSize = 200;
        //    cadena = builder.ConnectionString;

        //    return cadena;

        //}

        public string QuitaCaracteresIlegalesXML(string sValorXml)
        {
            sValorXml = sValorXml.Replace("Á", "A");
            sValorXml = sValorXml.Replace("É", "E");
            sValorXml = sValorXml.Replace("Í", "I");
            sValorXml = sValorXml.Replace("Ó", "O");
            sValorXml = sValorXml.Replace("Ú", "U");
            sValorXml = sValorXml.Replace("á", "a");
            sValorXml = sValorXml.Replace("é", "e");
            sValorXml = sValorXml.Replace("í", "i");
            sValorXml = sValorXml.Replace("ó", "o");
            sValorXml = sValorXml.Replace("ú", "u");
            sValorXml = sValorXml.Replace("'", "");

            sValorXml = sValorXml.Replace("&", "&amp;");
            //sValorXml = sValorXml.Replace("\"", "&quot;");
            //sValorXml = sValorXml.Replace("<", "&lt;");
            //sValorXml = sValorXml.Replace(">", "&gt;");
            sValorXml = sValorXml.Replace("'", "&apos;");
            return sValorXml;
        }

        public string CuerpoCorreoHTML(string Mensaje, bool? B_SinCuentaCorreo = false, bool? B_CXC = false)
        {
            string HTML = string.Empty;

            string strCuentaCorreo = "<a href=mailto:probemedic@probemedic.com.com.mx>probemedic@probemedic.com.mx </a> ";

            if (B_CXC == true)
            {
                strCuentaCorreo = "<a href=mailto:cobranza@probemedic.com.com.mx>cobranza@probemedic.com.mx </a> ";
            }

            if (B_SinCuentaCorreo == true)
            {
                HTML = "<html><head><title>Correo Paris</title><meta http-equiv=Content-Type content=text/html; charset=iso-8859-1><style type=text/css>.style11 {font-family: Tahoma; font-size: 16pt; font-weight: bold; color: #004B97;}.estilo1{font-size: 12pt;font-weight: bold;}.estilo2{font-family: Tahoma;font-size: 8pt;font-style: italic;}.estilo3{font-size: 8pt; font-family: Tahoma;}.estilo4 {font-family: Tahoma;font-size: 12pt;font-weight: bold;color: red;}.estilo5 {font-family: Tahoma;font-size: 10pt;}.estilocuerpo{font-family: Tahoma;font-size: 12pt;color: #004B97;}</style></head><body><table width=100%  border=0 cellspacing=5 cellpadding=0> <tr> <td><span class=style11>Titulo Correo </span></td>  </tr> <tr> <td height=3 bgcolor=#004B97></td> </tr> <tr> <td height=140> <p><span class=estilocuerpo>CuerpoCorreo</span></p></td> </tr> <tr> <td> <table width=100%  border=0 cellspacing=0 cellpadding=0> <tr> <td width=15%>&nbsp;</td> <td width=85% ><span class=estilo5> Favor de no responder a este correo, debido a que la cuenta no est&aacute; habilitada para recibir respuesta.</span> </td> </tr> </table> " +
                              "</br> <table width=100%  border=0 cellspacing=0 cellpadding=0> <tr> <td width=15% align=center valign=middle><img src=cid:logo width=100 height=100></td> <td width=85% ><table width=100%  border=0 cellspacing=0 cellpadding=0> <tr> <td><hr/><span class=estilo1>Productos Eiffel S.A. de C.V.</span></td></tr>" +
                              "<tr> <td><span class=estilo2>Piensa en Poliuretano… Piensa en Productos Eiffel </span></td> </tr>" +
                              "<tr> <td><span class=estilo3>AV. SIGLO 21 NO. 50 INT 102, SANTA CRUZ DE LAS FLORES </span></td> </tr>" +
                              "<tr> <td><span class=estilo3>TLAJOMULCO DE ZU&Ntilde;IGA, JAL CP: 45640 </span> </td> </tr>" +
                              "<tr> <td><span class=estilo3>Tel&eacute;fono: (33)-4777-0200 / Fax : (33)-4777-0201 </span> </td> </tr>" +
                              "<tr> <td><span class=estilo3><a href='www.eiffel.com.mx'>www.eiffel.com.mx </a> </span> </td> </tr>" +
                              "</table> </td> </tr> </table></td> </tr> <tr> <td height=5 bgcolor=#FF9933></td> </tr> <tr> <td height=20 bgcolor=#003366></td> </tr></table></body></html>";
                HTML = HTML.Replace("CuerpoCorreo", Mensaje);
            }
            else
            {
                HTML = "<html>" +
                       "<head>" +
                       "<title>Correo Probemedic</title>" +
                       "<meta http-equiv=Content-Type content=text/html; charset=iso-8859-1>" +
                       "<style type=text/css>.style11 {font-family: Tahoma; font-size: 16pt; font-weight: bold; color: #004B97;}" +
                       ".estilo1{font-size: 12pt;font-weight: bold;}" +
                       ".estilo2{font-family: Tahoma;font-size: 8pt;font-style: italic;}" +
                       ".estilo3{font-size: 8pt; font-family: Tahoma;}" +
                       ".estilo4 {font-family: Tahoma;font-size: 12pt;font-weight: bold;color: red;}" +
                       ".estilo5 {font-family: Tahoma;font-size: 10pt;}" +
                       ".estilocuerpo{font-family: Tahoma;font-size: 12pt;color: #004B97;}" +
                       "</style>" +
                       "" +
                       "</head>" +
                       "<body>" +
                       "<table width=100% border=0 cellspacing=5 cellpadding=0> " +
                       "<tr> <td> <spanddsds class=style11>Titulo Correo </span> </td> </tr> " +
                       "<tr> <td height=3 bgcolor=#004B97></td> </tr> " +
                       "<tr> <td height=140> <p><span class=estilocuerpo>CuerpoCorreo</span></p></td> </tr> <tr> <td> " +
                       "<table width=100% border=0 cellspacing=0 cellpadding=0> " +
                       "<tr> <td width=15% align=center valign=middle><img src='https://drive.google.com/uc?export=view&id=0B3egfnJA-KAseVlYQmNCUVUwV28'width=100 height=50> <td width=85% ><table width=100%  border=0 cellspacing=0 cellpadding=0> <tr> <td><hr/><span class=estilo1>Probemedic Distribuciones S.A</span></td></tr>" +
                       "<tr> <td><span class=estilo3>ORQUÍDEA 412, REAL CUMBRES </span></td> </tr>" +
                       "<tr> <td><span class=estilo3>MONTERREY, N.L CP: 64346 </span> </td> </tr>" +
                       "<tr> <td><span class=estilo3>Tel&eacute;fono: (33)-4777-0200 / Fax : (33)-4777-0201 </span> </td> </tr>" +
                       "<tr> <td><span class=estilo3><a href='www.probemedic.mx'>www.probemedic.mx </a> </span> </td> </tr>" +
                       "</table> </td> </tr> " +
                       "</table></td> </tr> <tr> <td height=5 bgcolor=#c41a4d></td> </tr> <tr> <td height=20 bgcolor=#2e46d1></td> </tr></table>" +
                       "</body>" +
                       "</html>";
                HTML = HTML.Replace("CuerpoCorreo", Mensaje);
            }

            return HTML;
        }

        public bool EnviaCorreo(string De, string Para, string Asunto, string Titulo, string Cuerpo, string Adjuntos = "", string Archivos = "", string Recursos = "", string ConCopiaPara = "", bool B_ConMensaje = true)
        {
            bool res = true;
            string[] aRecursos = Recursos.Split(',');
            string[] aArchivos = Archivos.Split(',');
            string[] aAdjuntos = Adjuntos.Split(',');
            string[] aConCopia = ConCopiaPara.Split(',');
            string[] aPara = Para.Split(',');

            string smtpServer = GlobalVar.CorreosmtpServer;
            int Puerto = GlobalVar.CorreoPuerto;
            Cuerpo = Cuerpo.Replace("Titulo Correo", Titulo);

            try
            {
                MailMessage mnsj = new MailMessage();
                //AlternateView html = AlternateView.CreateAlternateViewFromString(@Cuerpo, Encoding.UTF8, "text/html");
                AlternateView html = AlternateView.CreateAlternateViewFromString(@Cuerpo, null, MediaTypeNames.Text.Html);

                if (aRecursos.Length > 0)
                {
                    for (int a = 0; a < aRecursos.Length; a++)
                    {
                        if(@aRecursos[a].ToString().Trim().Length>0)
                        {
                            LinkedResource recurso = new LinkedResource(@aRecursos[a].ToString().Trim());
                            recurso.ContentId = aRecursos[a].ToString().Trim();
                            //recurso.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
                            html.LinkedResources.Add(recurso);
                        }          
                    }
                }

                mnsj.AlternateViews.Add(html);
                if (Adjuntos.Trim().Length > 0)
                {
                    for (int a = 0; a < aAdjuntos.Length; a++)
                    {
                        mnsj.Attachments.Add(new Attachment(aAdjuntos[a].ToString().Trim()));
                    }
                }

                mnsj.Subject = Asunto;

                if (Para.Length > 0)
                {
                    for (int a = 0; a < aPara.Length; a++)
                    {
                        mnsj.To.Add(new MailAddress(@aPara[a].ToString().Trim()));
                    }
                }

                //mnsj.From = new MailAddress(De, De);
                mnsj.From = new MailAddress(De,De);
                mnsj.IsBodyHtml = true;
                //mnsj.Body = Cuerpo;
                mnsj.BodyEncoding = System.Text.Encoding.Unicode;

                if (ConCopiaPara.Length > 0)
                {
                    for (int a = 0; a < aConCopia.Length; a++)
                    {
                        mnsj.CC.Add(new MailAddress(@aConCopia[a].ToString().Trim()));
                    }
                }
                //if (ConCopiaPara.Trim().Length > 0)
                //    mnsj.CC.Add(new MailAddress(ConCopiaPara));

                SmtpClient server = new SmtpClient(smtpServer, Puerto);

                string CorreoUsuario = GlobalVar.CorreoUsuario;
                string CorreoContrasena = GlobalVar.CorreoContrasena;

                if (CorreoUsuario.Trim().Length > 0)
                {
                    server.Credentials = new System.Net.NetworkCredential(CorreoUsuario, CorreoContrasena);
                    server.EnableSsl = true;
                }
                server.Send(mnsj);
                if (B_ConMensaje == true)
                    MessageBox.Show("CORREO ENVIADO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                server.Dispose();
                mnsj.Dispose();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
                MessageBox.Show("ERROR AL ENVIAR CORREO...\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (aArchivos.Length > 0)
                {
                    for (int a = 0; a < aAdjuntos.Length; a++)
                    {
                        if (File.Exists(@aAdjuntos[a].ToString().Trim()))
                            File.Delete(@aAdjuntos[a].ToString().Trim());
                    }
                }
            }
            return res;
        }

        public void ValidaSeaNumero(ref KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void ValidaSeaNumeroDecimal(ref KeyPressEventArgs e)
        {
            // Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }

            int codigo = Convert.ToInt32(e.KeyChar); //la tecla retroceso me devuelve un valor 8
            if (codigo == 8)
            {
                e.Handled = false;
                return;
            }

            bool punto = false;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator) //permitir punto decimal
            {
                if (punto != true)
                {
                    e.Handled = false;
                }
                e.Handled = false;
                punto = true;

            }

            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        public bool EsDatoNumerico(string inputvalue)
        {
            try
            {
                Int32.Parse(inputvalue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void LlenaGrid(ref Form frm, ref DataGridView grd, System.Data.DataTable dtGrid, string Titulo = "", bool ColumnasAutomaticas = false, bool MultipleSeleccion = false, bool SoloLectura = true)
        {
            if (dtGrid == null)
                return;


            if (Titulo.Trim().Length > 0)
                frm.Text = Titulo + " -  " + dtGrid.Rows.Count.ToString() + " Registros Encontrados...";

            grd.AutoGenerateColumns = ColumnasAutomaticas;
            grd.DataSource = dtGrid;
            grd.MultiSelect = MultipleSeleccion;
            grd.ReadOnly = SoloLectura;
            grd.AllowUserToResizeColumns = true;
            grd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //Por lo pronto puse que si solo son 2 columnas en el grid entonces se trata
            //de clave y descripción, configuro manual el ancho
            //Conforme vayamos avanzando veo si es necesario mandar configuración de ancho de columnas
            if (grd.Columns.Count == 2)
            {
                Form fr = (Form)grd.GetContainerControl();
                grd.Columns[0].Width = 50;
                grd.Columns[1].Width = fr.Width - 50;
            }

            grd.Refresh();
        }

        public DateTime PrimerDiaDelMes(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }
        public DateTime UltimoDiaDelMes(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }


        public string NombreMes(int NumMes, bool B_NombreCorto = false)
        {
            string Mes = string.Empty;
            if (B_NombreCorto)
            {
                switch (NumMes)
                {
                    case 1:
                        Mes = "Ene";
                        break;
                    case 2:
                        Mes = "Feb";
                        break;
                    case 3:
                        Mes = "Mar";
                        break;
                    case 4:
                        Mes = "Abr";
                        break;
                    case 5:
                        Mes = "May";
                        break;
                    case 6:
                        Mes = "Jun";
                        break;
                    case 7:
                        Mes = "Jul";
                        break;
                    case 8:
                        Mes = "Ago";
                        break;
                    case 9:
                        Mes = "Sep";
                        break;
                    case 10:
                        Mes = "Oct";
                        break;
                    case 11:
                        Mes = "Nov";
                        break;
                    case 12:
                        Mes = "Dic";
                        break;
                }
            }
            else
            {
                switch (NumMes)
                {
                    case 1:
                        Mes = "Enero";
                        break;
                    case 2:
                        Mes = "Febrero";
                        break;
                    case 3:
                        Mes = "Marzo";
                        break;
                    case 4:
                        Mes = "Abril";
                        break;
                    case 5:
                        Mes = "Mayo";
                        break;
                    case 6:
                        Mes = "Junio";
                        break;
                    case 7:
                        Mes = "Julio";
                        break;
                    case 8:
                        Mes = "Agosto";
                        break;
                    case 9:
                        Mes = "Septiembre";
                        break;
                    case 10:
                        Mes = "Octubre";
                        break;
                    case 11:
                        Mes = "Noviembre";
                        break;
                    case 12:
                        Mes = "Diciembre";
                        break;
                }
            }

            return Mes;
        }
        public void LlenaMeses(ref ComboBox cmb)
        {
            System.Data.DataTable tabla = new System.Data.DataTable();
            tabla.Columns.Add("Mostrar", typeof(string));
            tabla.Columns.Add("Valor", typeof(int));

            for (int i = 1; i <= 12; i++)
            {
                DataRow ren = tabla.NewRow();
                ren["Mostrar"] = NombreMes(i);
                ren["Valor"] = i;
                tabla.Rows.Add(ren);
            }

            cmb.DataSource = tabla;
            cmb.DisplayMember = "Mostrar";
            cmb.ValueMember = "Valor";
            cmb.SelectedIndex = 0;
        }

        public void LlenaAños(ref ComboBox cmb, int AñosAdelante = 5, int AñosAtras = 0)
        {
            System.Data.DataTable tabla = new System.Data.DataTable();
            tabla.Columns.Add("Mostrar", typeof(string));
            tabla.Columns.Add("Valor", typeof(int));

            int añoactual = DateTime.Now.Year;

            if (AñosAtras > 0)
            {
                for (int i = AñosAtras; i > 0; i--)
                {
                    int año = añoactual - i;
                    DataRow ren = tabla.NewRow();
                    ren["Mostrar"] = año.ToString();
                    ren["Valor"] = año;
                    tabla.Rows.Add(ren);

                }

            }

            //Agregar Año Actual
            DataRow ren3 = tabla.NewRow();
            ren3["Mostrar"] = añoactual.ToString();
            ren3["Valor"] = añoactual;
            tabla.Rows.Add(ren3);

            if (AñosAdelante > 0)
            {
                for (int i = 1; i <= AñosAdelante; i++)
                {
                    int año = añoactual + i;
                    DataRow ren2 = tabla.NewRow();
                    ren2["Mostrar"] = año.ToString();
                    ren2["Valor"] = año;
                    tabla.Rows.Add(ren2);
                }
            }

            cmb.DataSource = tabla;
            cmb.DisplayMember = "Mostrar";
            cmb.ValueMember = "Valor";
            cmb.SelectedIndex = 0;
        }

        public void LlenaDias(ref ComboBox cmb, int Año, int Mes)
        {
            if (Año == 0)
                return;
            if (Mes == 0)
                return;

            System.Data.DataTable tabla = new System.Data.DataTable();
            tabla.Columns.Add("Mostrar", typeof(string));
            tabla.Columns.Add("Valor", typeof(int));

            int Dias = DateTime.DaysInMonth(Año, Mes);
            for (int i = 1; i <= Dias; i++)
            {
                DataRow ren = tabla.NewRow();
                ren["Mostrar"] = i.ToString();
                ren["Valor"] = i;
                tabla.Rows.Add(ren);
            }
            cmb.DataSource = tabla;
            cmb.DisplayMember = "Mostrar";
            cmb.ValueMember = "Valor";
            cmb.SelectedIndex = 0;
        }


        public void FechaEnBlanco(ref DateTimePicker txtFecha)
        {
            if (!txtFecha.Checked)
            {
                // hide date value since it's not set
                txtFecha.CustomFormat = " ";
                txtFecha.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                txtFecha.CustomFormat = null;
                txtFecha.Format = DateTimePickerFormat.Short;
            }
        }

        public void FiltraGeograficos(ref ComboBox cmbPais, ref ComboBox cmbEstado, ref ComboBox cmbCiudad, System.Data.DataTable dtPaises, System.Data.DataTable dtEstados, System.Data.DataTable dtCiudades)
        {
            short KPais = 0;
            short KEstado = 0;
            short KCiudad = 0;

            if (KCiudad > 0)
            {
                //Quiere decir que ya tiene llenos y seleccionados todos los combos, incluso ya ni debió haber mandado la función
                return;
            }

            if (cmbPais.SelectedValue != null)
            {
                KPais = Convert.ToInt16(cmbPais.SelectedValue);
                dtEstados = dtEstados.AsEnumerable().Where(p => p.Field<short>("K_Pais") == KPais).CopyToDataTable<DataRow>();
            }
            if (cmbEstado.SelectedValue != null)
            {
                KEstado = Convert.ToInt16(cmbEstado.SelectedValue);
            }



            //Filtra Estados
            if (KPais > 0 && KEstado == 0)
            {
                cmbCiudad.DataSource = null;
                LlenaCombo(dtEstados, ref cmbEstado, "K_Estado", "D_Estado", -1);
            }


            //Filtra Ciudades
            if (KPais > 0 && KEstado > 0)
            {
                LlenaCombo(dtCiudades, ref cmbCiudad, "K_Ciudad", "D_Ciudad", -1);
            }


        }


        public void LlenaCombo(System.Data.DataTable dt, ref ComboBox cmb, string CampoValor = "", string CampoDescripcion = "", int Index = -1)
        {
            if (dt.Rows.Count == 0)
                return;

            //Si no mandan campos valor y descripción quiere decir que puedo tomar los campos 0 y 1
            cmb.DataSource = dt;
            if (CampoValor.Trim().Length > 0 && CampoDescripcion.Trim().Length > 0)
            {
                cmb.ValueMember = CampoValor;
                cmb.DisplayMember = CampoDescripcion;
            }
            else
            {
                cmb.ValueMember = dt.Columns[0].ColumnName;
                cmb.DisplayMember = dt.Columns[1].ColumnName;
            }
            cmb.SelectedIndex = Index;
            cmb.Leave += new EventHandler(cmb_Leave);

            if (CampoDescripcion.Trim().Length > 0)
                AutoCompletar(ref cmb, dt, CampoDescripcion);
        }

        void cmb_Leave(object sender, EventArgs e)
        {
            ComboBox cmbpaso = (ComboBox)sender;
            if (cmbpaso.SelectedValue == null)
                cmbpaso.Text = string.Empty;
        }

        public void AutoCompletar(ref ComboBox cmb, System.Data.DataTable dt, string Campo)
        {
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    AutoCompleteStringCollection ColeccionColonias = new AutoCompleteStringCollection();
                    List<DataRow> list = dt.AsEnumerable().ToList();
                    string[] st = list.Select(ss => ss[Campo].ToString()).ToArray();
                    cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    ColeccionColonias.AddRange(st);
                    cmb.AutoCompleteCustomSource = ColeccionColonias;
                    cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        public void ExportToExcel(System.Data.DataTable dt, string archivo, string hoja = "Datos")
        {
            if (dt == null)
                return;

            Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet xlsSheet;
            Microsoft.Office.Interop.Excel.Workbook xlsBook;
            xlsApp.Visible = false;
            xlsApp.DisplayAlerts = false;
            try
            {
                xlsBook = xlsApp.Workbooks.Add(true);
                xlsSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlsBook.ActiveSheet;
                xlsSheet.Name = hoja;

                int iCol = 0;
                foreach (DataColumn column in dt.Columns)
                {
                    xlsSheet.Cells[1, ++iCol] = column.ColumnName;
                }
                int ren = 0;
                int col = 0;
                foreach (DataRow row in dt.Rows)
                {
                    col = 0;
                    iCol = 0;
                    foreach (DataColumn column in dt.Columns)
                    {
                        xlsSheet.Cells[ren + 2, ++iCol] = dt.Rows[ren][col];
                        col++;
                    }
                    ren++;
                }

                xlsSheet.Columns.AutoFit();
                xlsApp.Visible = false;
                xlsBook.SaveCopyAs(archivo);
                xlsBook.Close(Type.Missing, Type.Missing, Type.Missing);
                xlsBook = null;
                MessageBox.Show("INFORMACION EXPORTADA A EXCEL CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xlsApp.Workbooks.Close();
                xlsApp.Quit();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }


        }

        public void ExportToOpenExcel(System.Data.DataTable dt, string archivo, string hoja = "Datos")
        {
            if (dt == null)
                return;

            ExcelDocument document = new ExcelDocument();
            document.UserName = "PROBEMEDIC";
            document.CodePage = CultureInfo.CurrentCulture.TextInfo.ANSICodePage;
            try
            {
                int iCol = -1;

                foreach (DataColumn column in dt.Columns)
                {
                    document[0, ++iCol].Value = column.ColumnName.ToString();

                }
                int ren = 0;
                int col = 0;
                foreach (DataRow row in dt.Rows)
                {
                    col = 0;
                    iCol = 0;
                    foreach (DataColumn column in dt.Columns)
                    {
                        document[ren + 1, iCol].Value = dt.Rows[ren][col];

                        col++;
                        iCol++;
                    }
                    ren++;
                }

                FileStream stream = new FileStream(archivo, FileMode.Create);

                document.Save(stream);
                stream.Close();

                MessageBox.Show("INFORMACION EXPORTADA A EXCEL CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

            }


        }

        public string DevuelveMesNombre(int NumeroMes)
        {
            string MesNombre = "SIN MES";
            switch (NumeroMes)
            {
                case 1:
                    {
                        MesNombre = "Enero";
                        break;
                    }
                case 2:
                    {
                        MesNombre = "Febrero";
                        break;
                    }
                case 3:
                    {
                        MesNombre = "Marzo";
                        break;
                    }
                case 4:
                    {
                        MesNombre = "Abril";
                        break;
                    }
                case 5:
                    {
                        MesNombre = "Mayo";
                        break;
                    }
                case 6:
                    {
                        MesNombre = "Junio";
                        break;
                    }
                case 7:
                    {
                        MesNombre = "Julio";
                        break;
                    }
                case 8:
                    {
                        MesNombre = "Agosto";
                        break;
                    }
                case 9:
                    {
                        MesNombre = "Septiembre";
                        break;
                    }
                case 10:
                    {
                        MesNombre = "Octubre";
                        break;
                    }
                case 11:
                    {
                        MesNombre = "Noviembre";
                        break;
                    }
                case 12:
                    {
                        MesNombre = "Diciembre";
                        break;
                    }
            }
            return MesNombre;
        }

        public void DibujarColumnaTipoBotonGrid(ref DataGridView grd,ImageList imagelist, DataGridViewCellPaintingEventArgs e, string nombreColumna, string nombreIcono)
        {          
            if (e.ColumnIndex >= 0 && grd.Columns[e.ColumnIndex].Name == nombreColumna && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = grd.Rows[e.RowIndex].Cells[nombreColumna] as DataGridViewButtonCell;
                Image imagen = imagelist.Images[nombreIcono];
                e.Graphics.DrawImage(imagen, e.CellBounds.Left + 18, e.CellBounds.Top + 3);
                grd.Rows[e.RowIndex].Height = imagen.Height + 4;
                grd.Columns[e.ColumnIndex].Width = imagen.Width + 4;
                e.Handled = true;
            }
        }

        public Image DevuelveImagen(string cadena)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(cadena);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);

            return image;
        }

        public Boolean ValidaEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
