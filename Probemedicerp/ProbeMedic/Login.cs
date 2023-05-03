﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using ProbeMedic.AppCode.DCC;
using System.Deployment.Application;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Management;
using System.Data.SqlClient;
using System.Xml;
using System.Threading;
using Microsoft.Win32;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic
{
    public partial class Login: Forma
     {
        Generales sqlGenerales = new Generales();
        SQLSeguridad sql = new SQLSeguridad();
        Funciones fx = new Funciones();
        DataTable result;

        private string rutaExe = System.Windows.Forms.Application.ExecutablePath.ToString();
        private XmlDocument configXml = new XmlDocument();
        private string ficConfig;

        public Login()
         {
            InitializeComponent();
            ficConfig = rutaExe + ".config";
            configXml.Load(ficConfig);
            this.KeyDown += new KeyEventHandler(Pulsar);
            CreaRegistro();
         }

        void Pulsar(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.R)
            {
                Settings frmS = new Settings();
                frmS.ShowDialog();
            }
        }

        private void CreaRegistro()
        {
            RegistryKey Registro = Registry.CurrentUser.OpenSubKey(@"Software\ProbeMedic");

            if (Registro == null)
            {
                //MessageBox.Show("No existe");

                Registro = Registry.CurrentUser.CreateSubKey(@"Software\ProbeMedic");

                using (RegistryKey Settings = Registro.CreateSubKey("ProbeMedic"))
                {
                    string version = string.Empty;

                    if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                    {
                        version = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                    }


                    // Create data for the TestSettings subkey.
                    Settings.SetValue("Nombre", "ProbeMedic.exe");
                    Settings.SetValue("Version", version);
                    Settings.SetValue("ProbeMedic_Printer_Tickets", "");

                    //MessageBox.Show("creada");
                }
            }

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txt_User.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR USUARIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_User.Focus();
                return;
            }
            if (txt_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CONTRASEÑA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Pass.Focus();
                return;
            }

            string Cadena = ConnectionClass.ObtieneCadenaConexion();
            if (SqlServerIsRunning(Cadena, 10))
            {

                int res = 0;
                string msg = string.Empty;
                res = sql.Gp_ValidaAccesoUsuario(txt_User.Text, txt_Pass.Text, ref msg);
                if (res == -2)
                {
                    MessageBox.Show("CONEXIÓN NO DISPONIBLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (res == -1)
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = sql.Gp_ValidaAccesoUsuario(txt_User.Text, txt_Pass.Text);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        GlobalVar.SPID = (Int16)dt.Rows[0]["spid"];
                        GlobalVar.K_Empresa = (Int16)dt.Rows[0]["K_Empresa"];
                        GlobalVar.K_Usuario = (Int32)dt.Rows[0]["K_Usuario"];
                        GlobalVar.K_Grupo = (Int32)dt.Rows[0]["K_Grupo"];
                        GlobalVar.K_Empleado = (Int32)dt.Rows[0]["K_Empleado"];
                        GlobalVar.D_Empleado = dt.Rows[0]["D_Empleado"].ToString();
                        GlobalVar.K_Oficina = (Int32)dt.Rows[0]["K_Oficina"];
                        GlobalVar.D_Oficina = dt.Rows[0]["D_Oficina"].ToString();
                        GlobalVar.K_Puesto = (Int32)dt.Rows[0]["K_Puesto"];
                        GlobalVar.D_Puesto = dt.Rows[0]["D_Puesto"].ToString();

                        GlobalVar.K_Pais = (Int32)dt.Rows[0]["K_Pais"];
                        GlobalVar.K_Estado = (Int32)dt.Rows[0]["K_Estado"];
                        GlobalVar.K_Ciudad = (Int32)dt.Rows[0]["K_Ciudad"];

                        GlobalVar.D_Usuario = dt.Rows[0]["D_Usuario"].ToString();
                        GlobalVar.Login = dt.Rows[0]["Login"].ToString();
                        GlobalVar.Contra = dt.Rows[0]["Contrasenia"].ToString();
                        GlobalVar.Grupo = dt.Rows[0]["D_Grupo"].ToString();
                        GlobalVar.rutaExe = Path.GetDirectoryName(rutaExe);
                        GlobalVar.PC_Name = Environment.MachineName;
                        GlobalVar.Tipo_Cambio =Convert.ToDecimal(dt.Rows[0]["Tipo_Cambio"].ToString());
                        GlobalVar.B_ResolucionProduccion = false;
                        if (Screen.PrimaryScreen.Bounds.Width > 1280)
                            GlobalVar.B_ResolucionProduccion = true;
                        GlobalVar.D_Empresa = dt.Rows[0]["D_Empresa"].ToString();
                        GlobalVar.K_Empresa = (Int32)dt.Rows[0]["K_Usuario"];

                        //Carga Variables Globales de la Empresa
                        DataTable dtEmpresa = sqlGenerales.sps_EncabezadoReportes(); ;
                        //Empresa.D_Empresa = dtEmpresa.Rows[0]["D_Empresa"].ToString();
                        Empresa.Leyenda = dtEmpresa.Rows[0]["Leyenda"].ToString();
                        Empresa.Calle = dtEmpresa.Rows[0]["Calle"].ToString();
                        Empresa.Colonia = dtEmpresa.Rows[0]["Colonia"].ToString();
                        Empresa.D_Ciudad = dtEmpresa.Rows[0]["D_Ciudad"].ToString();
                        Empresa.C_Estado = dtEmpresa.Rows[0]["C_Estado"].ToString();
                        Empresa.CodigoPostal = dtEmpresa.Rows[0]["CodigoPostal"].ToString();
                        Empresa.Telefono_Fax = dtEmpresa.Rows[0]["Telefono_Fax"].ToString();

                        Empresa.C_Empresa = dtEmpresa.Rows[0]["C_Empresa"].ToString();
                        Empresa.Telefono = dtEmpresa.Rows[0]["Telefono"].ToString();
                        Empresa.RFC = dtEmpresa.Rows[0]["RFC"].ToString();
                        Empresa.D_Estado = dtEmpresa.Rows[0]["D_Estado"].ToString();
                        Empresa.Fax = dtEmpresa.Rows[0]["Fax"].ToString();
                        Empresa.PaginaWEB = dtEmpresa.Rows[0]["PaginaWEB"].ToString();

                        CargaTablasGlobales();
                        this.Hide();
                        Principal frm = new Principal();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("A ESTA USUARIO AUN NO SE LE HA CONFIGURADO EL ACCESO A NINGUN OPCION DEL SISTEMA ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
            {
                Close();
            }

        private void Inicio_Load(object sender, EventArgs e)
         {
             string Cadena = ConnectionClass.ObtieneCadenaConexion();
             if (SqlServerIsRunning(Cadena, 10))
             {

                    string VersionExe = ConfigurationManager.AppSettings["Version"].ToString().Trim();
                    string Version = string.Empty;
                    DateTime FechaVersion = DateTime.Today;
                    int res = 0;
                    res = sql.Gp_ValidaVersion(ref Version, ref FechaVersion);         

             }
             //CambiaTipoConexion();
        }

            private bool SqlServerIsRunning(string baseConnectionString, int timeoutInSeconds)
            {
                bool result;

                using (SqlConnection sqlConnection = new SqlConnection(baseConnectionString + ";Connection Timeout=" + timeoutInSeconds))
                {
                    Thread thread = new Thread(TryOpen);
                    ManualResetEvent manualResetEvent = new ManualResetEvent(false);
                    thread.Start(new Tuple<SqlConnection, ManualResetEvent>(sqlConnection, manualResetEvent));
                    result = manualResetEvent.WaitOne(timeoutInSeconds * 1000);

                    if (!result)
                    {
                        thread.Abort();
                    }

                    sqlConnection.Close();
                }

                if (result == false)
                    MessageBox.Show("CONEXION NO DISPONIBLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return result;
            }

            private void TryOpen(object input)
            {
                Tuple<SqlConnection, ManualResetEvent> parameters = (Tuple<SqlConnection, ManualResetEvent>)input;

                try
                {
                    parameters.Item1.Open();
                    parameters.Item1.Close();
                    parameters.Item2.Set();
                }
                catch
                {
                    // Eat any exception, we're not interested in it
                }
            }


        //static void ValidaConexionDisponible(string server)
        //{
        //    try
        //    {
        //        using (System.Net.Sockets.TcpClient tcpSocket = new System.Net.Sockets.TcpClient())
        //        {
        //            IAsyncResult async = tcpSocket.BeginConnect(server, 1433, ConnectCallback, null);
        //            DateTime startTime = DateTime.Now;
        //            do
        //            {
        //                System.Threading.Thread.Sleep(500);
        //                if (async.IsCompleted) break;
        //            } while (DateTime.Now.Subtract(startTime).TotalSeconds < 5);
        //            if (async.IsCompleted)
        //            {
        //                tcpSocket.EndConnect(async);
        //                Console.WriteLine("Connection succeeded");
        //            }
        //            tcpSocket.Close();
        //            if (!async.IsCompleted)
        //            {
        //                Console.WriteLine("Server did not respond");
        //                return;
        //            }
        //        }
        //    }
        //    catch (System.Net.Sockets.SocketException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //private static void ConnectCallback(IAsyncResult ar)
        //{
        //    try
        //    {
        //        // Retrieve the socket from the state object.
        //        Socket client = (Socket)ar.AsyncState;

        //        // Complete the connection.
        //        client.EndConnect(ar);

        //        Console.WriteLine("Socket connected to {0}",
        //            client.RemoteEndPoint.ToString());

        //        // Signal that the connection has been made.
        //        connectDone.Set();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}


        //private void CambiaTipoConexion()
        //{
        //    string ConexionActiva = cfgGetValue("configuration/appSettings", "ConexionActiva", "");
        //    if (ConexionActiva.Trim().ToUpper() != "LOCAL")
        //        ConexionActiva = "REMOTA";

        //    if (ConexionActiva.Trim().ToUpper() == "LOCAL")
        //    {
        //        //cbxTipoConexion.Text = "Cambiar a Configuración Remota";
        //        //lblBaseDatos.Text = "BD: " + ConfigurationManager.AppSettings["BaseLocal"].ToString().Trim();
        //    }
        //    else
        //    {
        //        // cbxTipoConexion.Text = "Cambiar a Configuración Local";
        //        //lblBaseDatos.Text = "BD: " + ConfigurationManager.AppSettings["Base"].ToString().Trim();
        //    }
        //    if (lblBaseDatos.Text.ToString().Trim() == "BD: Probemedic")
        //    {
        //        lblBaseDatos.Visible = false;
        //        lblTituloBaseDatos.Visible = false;
        //    }
        //}

        private string cfgGetValue(string seccion, string clave, string predeterminado)
            {
                XmlNode n;
                n = configXml.SelectSingleNode(seccion + "/add[@key=\"" + clave + "\"]");
                if (n != null)
                {
                    return n.Attributes["value"].InnerText;
                }
                else
                {
                    return predeterminado;
                }
            }

            private void cfgSetValue(string seccion, string clave, string valor)
            {
                XmlNode n;
                n = configXml.SelectSingleNode(seccion + "/add[@key=\"" + clave + "\"]");
                if (n != null)
                {
                    n.Attributes["value"].InnerText = valor;
                }
                else
                {
                    n = configXml.SelectSingleNode("//appSettings");
                    XmlElement entry = configXml.CreateElement("add");
                    entry.SetAttribute("key", clave);
                    entry.SetAttribute("value", valor);
                    n.AppendChild(entry);

                }
            }

            //private void cbxTipoConexion_CheckedChanged(object sender, EventArgs e)
            //{
            //    if (cbxTipoConexion.Checked)
            //    {
            //        string ConexionActiva = cfgGetValue("configuration/appSettings", "ConexionActiva", "");
            //        if (ConexionActiva.Trim().ToUpper() == "LOCAL")
            //        {
            //            ConexionActiva = "REMOTA";
            //            lblBaseDatos.Text = ConfigurationManager.AppSettings["BaseLocal"].ToString().Trim();
            //        }
            //        else
            //        {
            //            ConexionActiva = "LOCAL";
            //            lblBaseDatos.Text = ConfigurationManager.AppSettings["Base"].ToString().Trim();
            //        }

            //        cfgSetValue("configuration/appSettings", "ConexionActiva", ConexionActiva);
            //        configXml.Save(ficConfig);


            //        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //        ConfigurationManager.RefreshSection("appSettings");
            //        ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            //        //MessageBox.Show(ConfigurationManager.AppSettings["ConexionActiva"]);


            //        cbxTipoConexion.Checked = false;
            //        CambiaTipoConexion();
            //    }
            //}

            private void Inicio_Shown(object sender, EventArgs e)
            {
                //btnEntrar_Click_1(null, null);
            }

        private void Close_Log_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txt_User.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR USUARIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_User.Focus();
                return;
            }
            if (txt_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CONTRASEÑA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Pass.Focus();
                return;
            }

            string Cadena = ConnectionClass.ObtieneCadenaConexion();

            if (SqlServerIsRunning(Cadena, 10))
            {
                int res = 0;
                string msg = string.Empty;

                res = sql.Gp_ValidaAccesoUsuario(txt_User.Text, txt_Pass.Text, ref msg);

                if (res == -2)
                {
                    MessageBox.Show("CONEXIÓN NO DISPONIBLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (res == -1)
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = sql.Gp_ValidaAccesoUsuario(txt_User.Text, txt_Pass.Text);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        GlobalVar.SPID = (Int16)dt.Rows[0]["spid"];
                        GlobalVar.K_Empresa = (Int32)dt.Rows[0]["K_Empresa"];
                        GlobalVar.K_Usuario = (Int32)dt.Rows[0]["K_Usuario"];
                        GlobalVar.B_CambiaSerie = (bool)dt.Rows[0]["B_CambiaSerie"];
                        GlobalVar.B_CambiaDatosFiscales = (bool)dt.Rows[0]["B_CambiaDatosFiscales"];
                        try
                        {
                            GlobalVar.B_PermiteAjustes = (bool)dt.Rows[0]["B_PermiteAjustes"];
                        }
                        catch (Exception)
                        {

                        }  
                        GlobalVar.K_Grupo = (Int32)dt.Rows[0]["K_Grupo"];
                        GlobalVar.K_Oficina = (Int32)dt.Rows[0]["K_Oficina"];
                        GlobalVar.D_Oficina = dt.Rows[0]["D_Oficina"].ToString();
                        GlobalVar.K_Pais = (Int32)dt.Rows[0]["K_Pais"];
                        GlobalVar.K_Estado = (Int32)dt.Rows[0]["K_Estado"];
                        GlobalVar.K_Ciudad = (Int32)dt.Rows[0]["K_Ciudad"];
                        GlobalVar.D_Usuario = dt.Rows[0]["D_Usuario"].ToString();
                        GlobalVar.Login = dt.Rows[0]["Login"].ToString();
                        GlobalVar.Contra = dt.Rows[0]["Contrasenia"].ToString();
                        GlobalVar.Grupo = dt.Rows[0]["D_Grupo"].ToString();
                        GlobalVar.rutaExe = Path.GetDirectoryName(rutaExe);
                        GlobalVar.PC_Name = Environment.MachineName;
                        GlobalVar.D_Asesor = dt.Rows[0]["D_Asesor"].ToString();
                        GlobalVar.K_Asesor = (int)dt.Rows[0]["K_Asesor"];
                        GlobalVar.B_ResolucionProduccion = false;
                        if (Screen.PrimaryScreen.Bounds.Width > 1280)
                            GlobalVar.B_ResolucionProduccion = true;
                        GlobalVar.D_Empresa = dt.Rows[0]["D_Empresa"].ToString();
                        //GlobalVar.Tipo_Cambio = Convert.ToDecimal(dt.Rows[0]["Tipo_Cambio"].ToString());

                        int entra= Valida_Usuario(txt_User.Text, txt_Pass.Text);
                        if (entra == -1)
                        {
                            return;
                        }
                        //Carga Variables Globales de la Empresa para los REPORTES
                        DataTable dtEmpresa = sqlGenerales.sps_EncabezadoReportes(); ;
                        Empresa.D_Empresa = dtEmpresa.Rows[0]["D_Empresa"].ToString();
                        Empresa.Leyenda = dtEmpresa.Rows[0]["Leyenda"].ToString();
                        Empresa.Calle = dtEmpresa.Rows[0]["Calle"].ToString();
                        Empresa.Colonia = dtEmpresa.Rows[0]["Colonia"].ToString();
                        Empresa.D_Ciudad = dtEmpresa.Rows[0]["D_Ciudad"].ToString();
                        Empresa.C_Estado = dtEmpresa.Rows[0]["C_Estado"].ToString();
                        Empresa.CodigoPostal = dtEmpresa.Rows[0]["CodigoPostal"].ToString();
                        Empresa.Telefono_Fax = dtEmpresa.Rows[0]["Telefono_Fax"].ToString();

                        Empresa.C_Empresa = dtEmpresa.Rows[0]["C_Empresa"].ToString();
                        Empresa.Telefono = dtEmpresa.Rows[0]["Telefono"].ToString();
                        Empresa.RFC = dtEmpresa.Rows[0]["RFC"].ToString();
                        Empresa.D_Estado = dtEmpresa.Rows[0]["D_Estado"].ToString();
                        Empresa.Fax = dtEmpresa.Rows[0]["Fax"].ToString();
                        Empresa.PaginaWEB = dtEmpresa.Rows[0]["PaginaWEB"].ToString();
                        Empresa.NoExterior = dtEmpresa.Rows[0]["NoExterior"].ToString();
                        Empresa.NoInterior = dtEmpresa.Rows[0]["NoInterior"].ToString();

                        GlobalVar.CorreoDe = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["CorreoDe"].ToString());
                        GlobalVar.CorreosmtpServer = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["CorreosmtpServer"].ToString());
                        GlobalVar.CorreoPuerto =Convert.ToInt16(SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["CorreoPuerto"].ToString()));
                        GlobalVar.CorreoUsuario = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["CorreoUsuario"].ToString());
                        GlobalVar.CorreoContrasena = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["CorreoContrasena"].ToString());
                        CargaTablasGlobales();
                        this.Hide();
                        Principal frm = new Principal();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("A ESTA USUARIO AUN NO SE LE HA CONFIGURADO EL ACCESO A NINGUN OPCION DEL SISTEMA ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings frmS = new Settings();
            frmS.ShowDialog();
        }
        private int Valida_Usuario(string user, string pwd)
        {
            int res = -1;
            string msj = string.Empty;

            string Aplicacion = "PROBEMEDIC";
            string IP = GetIP();
            string windows = Environment.OSVersion.ToString();
            string MAC = GetMacAddress();

            res = sql.GP_UsuariosConectados(GlobalVar.K_Usuario, GlobalVar.PC_Name, GlobalVar.D_Usuario, user, GlobalVar.K_Empleado,
                                            GlobalVar.D_Usuario, GlobalVar.K_Oficina, GlobalVar.D_Oficina, Aplicacion, IP, MAC, windows, ref msj);

            if (res == -1)
            { 
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //Obtiene IP
        public string GetIP()
        {
            string Str = "";

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (NetworkInterface adapter in interfaces)
            {
                var ipProps = adapter.GetIPProperties();

                foreach (var ip in ipProps.UnicastAddresses)
                {
                    if ((adapter.OperationalStatus == OperationalStatus.Up)
                        && (ip.Address.AddressFamily == AddressFamily.InterNetwork) && (ip.Address.ToString() != "127.0.0.1"))
                    {
                        Str = adapter.GetPhysicalAddress().ToString();
                        Str = ip.Address.ToString();
                    }
                }
            }

            return Str;

        }
        //Obtengo la MAC Adress
        public string GetMacAddress()
        {
            string Str = "";

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (NetworkInterface adapter in interfaces)
            {
                var ipProps = adapter.GetIPProperties();

                foreach (var ip in ipProps.UnicastAddresses)
                {
                    if ((adapter.OperationalStatus == OperationalStatus.Up)
                        && (ip.Address.AddressFamily == AddressFamily.InterNetwork) && (ip.Address.ToString() != "127.0.0.1"))
                    {
                        Str = adapter.GetPhysicalAddress().ToString();

                    }
                }
            }

            return Str;
        }
    }
}
