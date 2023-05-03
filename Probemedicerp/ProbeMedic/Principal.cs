﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProbeMedic.AppCode.DCC;
using ProbeMedic.AppCode.BLL;
using System.Reflection;
using System.Configuration;

namespace ProbeMedic
{
    public partial class Principal : Form
    {
        #region Miembros de la clase        
        private string descripcionmenu;
        private string urlmenu;

        private int K_Grupo = 0;
        private int K_Usuario = 0;
        private string condicionadicional;
        private bool bdescripcionmenu;
        private bool burlmenu;
        #endregion

        #region Propiedades de la Clase           
        public string DescripcionMenu
        {
            get
            {
                return descripcionmenu;
            }
            set
            {
                descripcionmenu = value;
                bdescripcionmenu = true;
            }
        }
        public string CondicionAdicional
        {
            get
            {
                return condicionadicional;
            }
            set
            {
                condicionadicional = value;
            }
        }
        public string UrlMenu
        {
            get
            {
                return urlmenu;
            }
            set
            {
                urlmenu = value;
                burlmenu = true;
            }
        }

        #endregion

        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        Generales gen = new Generales();

        private System.Reflection.Assembly Ensamblado;
        private DataTable dtMenus;

        int res = 0;
        string msg = string.Empty;

        public Principal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ActualizaSPID()
        {
            lblEstatusSPID.Text = "SPID: " + GlobalVar.SPID.ToString();
            Application.DoEvents();
            BarraEstatus.Update();
            Application.DoEvents();
        }
        private void MenuItemClicked(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                string NombreFormulario = ((ToolStripItem)sender).Tag.ToString();

                // FORMULARIOS PARA NO VISITAR
                if ((NombreFormulario == "SISTEMA.SALIR"))
                {
                    Application.Exit();
                    return;
                }
                if (NombreFormulario.Trim().ToUpper() == "SALIR")
                {
                    Close();
                    return;
                }
                else
                if (NombreFormulario == "SEGURIDAD.FRMS_SPID")
                {
                    DataTable dt = sqlSeguridad.Gp_ObtieneSPID();
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            GlobalVar.SPID = Convert.ToInt16(dt.Rows[0]["SPID"]);

                        }
                    }
                    ActualizaSPID();
                    MessageBox.Show("SPID ACTUALIZADO CORRECTAMENTE..." + System.Environment.NewLine + "SPID No.  " + GlobalVar.SPID.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                    GlobalVar.K_Menu = Convert.ToInt32(((ToolStripItem)sender).Name);

                string NombreTabla = string.Empty;
                string[] vec = NombreFormulario.Split(',');
                string NombreForma = NombreFormulario;
                if (vec.Length > 1)
                {
                    NombreFormulario = vec[1];
                    NombreForma = vec[0];
                }
                Object ObjFrm;
                //Type tipo = default(Type);
                Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + NombreFormulario);
                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario", "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        try
                        {

                            GrabaOpcionIngresa();
                            ObjFrm = Activator.CreateInstance(tipo);
                            Form Ventana = (Form)ObjFrm;
                            GlobalVar.NombreForma = NombreFormulario;
                            if ((NombreFormulario == "VENTAS.Frm_Ventas"))
                            {
                                MenuPrincipal.Visible = false;
                                //BarraEstatus.Visible = false;
                                Ventana.FormClosing += new FormClosingEventHandler(form_FormClosing);
                            }
                            Ventana.MdiParent = this;
                            Ventana.Show();

                        }
                        catch (Exception ex)
                        {
                            string msg;
                            if (ex.InnerException != null)
                                msg = ex.InnerException.Message;
                            else
                                msg = ex.Message;
                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            if (this.MdiChildren.Length > 0)
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name.ToUpper().Trim() == NombreDelFrm.ToUpper().Substring(NombreDelFrm.ToUpper().IndexOf("FRM_"), NombreDelFrm.ToUpper().Length - NombreDelFrm.ToUpper().IndexOf("FRM_")))
                    {
                        MessageBox.Show("La opción seleccionada ya se encuentra abierta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        private void CargarMenus(Int32 K_Grupo, Int32 K_Usuario)
        {
            SQLSeguridad sqlSeg = new SQLSeguridad();
            dtMenus = new DataTable();
            dtMenus = MenusWindowsDelGrupo(K_Grupo, K_Usuario);

            foreach (DataRow MenuPadre in dtMenus.Select("K_MenuPadre=0", "PosicionMenu ASC"))
            {
                ToolStripItem[] Menu = new ToolStripItem[1];
                Menu[0] = new ToolStripMenuItem();
                Menu[0].Name = MenuPadre["K_Menu"].ToString();
                Menu[0].Text = MenuPadre["DescripcionMenu"].ToString();
                Menu[0].Tag = MenuPadre["FormularioAsociado"].ToString();

                //Averiguando si tiene Hijos o no
                if (dtMenus.Select("K_MenuPadre=" + MenuPadre["K_Menu"]).Length == 0)
                {
                    //Sino tiene hijos lo agrego a la barra de menu principal
                    //mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"], null, new EventHandler(MenuItemClicked));
                    Menu[0].Click += new EventHandler(MenuItemClicked);

                    MenuPrincipal.Items.Add(Menu[0]);
                }
                else
                {
                    //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                    //AgregarMenuHijo(mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"]));
                    MenuPrincipal.Items.Add(Menu[0]);
                    AgregarMenuHijo(Menu[0]);
                }

            }
            timer1.Start();

        }

        private void AgregarMenuHijo(ToolStripItem MenuItemPadre)
        {
            ToolStripMenuItem MenuPadre = (ToolStripMenuItem)MenuItemPadre;

            //Obtengo el ID del menu Enviado para saber si tiene hijos o no
            //int Id = (int)(dtMenus.Select("DescripcionMenu='" +MenuPadre.Text+"'")[0]["Id_Menu"]);
            string Id = MenuPadre.Name;

            //Averiguando si tiene Hijos o no
            if (dtMenus.Select("K_MenuPadre=" + Id).Length == 0)
            {
                //Si No tiene Hijos Solo Agrego el Evento
                MenuPadre.Click += new EventHandler(MenuItemClicked);
            }
            else
            {
                //Si Aun tiene Hijos
                foreach (DataRow Menu in dtMenus.Select("K_MenuPadre=" + Id, "DescripcionMenu ASC"))
                {
                    ToolStripItem[] NuevoMenu = new ToolStripItem[1];
                    NuevoMenu[0] = new ToolStripMenuItem();
                    NuevoMenu[0].Name = Menu["K_Menu"].ToString();
                    NuevoMenu[0].Text = Menu["DescripcionMenu"].ToString();
                    NuevoMenu[0].Tag = Menu["FormularioAsociado"].ToString();

                    //Averiguo se es un separador
                    if (Menu["DescripcionMenu"].ToString() == "-")
                    {
                        //MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"]);
                        MenuPadre.DropDownItems.Add(NuevoMenu[0].Text);
                    }
                    else
                    {
                        //Obtengo el ID del Menu del foreach
                        //int IdMenu = (int)dtMenus.Select("DescripcionMenu='" + Menu["DescripcionMenu"]+"'")[0]["Id_Menu"];
                        //int IdMenu = (int)Menu["Id_Menu"];
                        //Averiguando si tiene Hijos o no
                        if (dtMenus.Select("K_MenuPadre=" + Menu["K_Menu"]).Length == 0)
                        {
                            //Sino tiene hijos lo agrego al Menu Padre
                            //MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"], null, new EventHandler(MenuItemClicked));
                            NuevoMenu[0].Click += new EventHandler(MenuItemClicked);
                            MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                        }
                        else
                        {
                            //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                            //AgregarMenuHijo(MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"]));
                            MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                            AgregarMenuHijo(NuevoMenu[0]);
                        }
                    }
                }
            }
        }

        public DataTable BuscarMenusdelGrupo()
        {
            DataTable dt = new DataTable();
            dt = sqlSeguridad.Gp_ConsultaAccesoUsuario(K_Usuario);
            return dt;


        }

        public DataTable MenusWindowsDelGrupo(Int32 k_Grupo, Int32 k_Usuario)
        {
            K_Grupo = k_Grupo;
            K_Usuario = k_Usuario;
            DescripcionMenu = "";
            UrlMenu = "";
            CondicionAdicional = "";
            return BuscarMenusdelGrupo();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (GlobalVar.K_Empresa != 1)
            {
                BackgroundImage = Properties.Resources.fondo;
            }
            Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            this.MenuPrincipal.Items.Clear();
            this.CargarMenus(GlobalVar.K_Grupo, GlobalVar.K_Usuario);

            string Servidor = string.Empty;
            string Base = string.Empty;

            string ConexionActiva = GlobalVar.Conexion; //ConfigurationManager.AppSettings["ConexionActiva"].ToString();
            if (ConexionActiva.Trim().ToUpper() == "PRODUCCION")
            {
                Servidor = SISEM_PACK.ConnectionSecure.descifrar( ConfigurationManager.AppSettings["Servidor"].ToString());
                Base = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["Base"].ToString());
            }
            else if (ConexionActiva.Trim().ToUpper() == "PRUEBAS")
            {
                Servidor = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["ServidorPruebas"].ToString());
                Base = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["BasePruebas"].ToString());
            }
            else
            {
                Servidor = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["ServidorAltis"].ToString());
                Base = SISEM_PACK.ConnectionSecure.descifrar(ConfigurationManager.AppSettings["BaseAltis"].ToString());
            }


            if (Base.Trim().ToUpper() == "PROBEMEDIC")
                GlobalVar.B_SistemaEnProduccion = true;
            else
                GlobalVar.B_SistemaEnProduccion = false;

            string Version = System.Configuration.ConfigurationManager.AppSettings["Version"].ToString().Trim();
            string Fecha = System.Configuration.ConfigurationManager.AppSettings["Fecha"].ToString().Trim();
            if (Servidor == "probemedic.dyndns.org")
                lblEstatusServidor.Text = "Servidor: Producción";
            else
            lblEstatusServidor.Text = "Servidor: " + GlobalVar.Conexion;
            lblEstatusVersion.Text = "Ver: " + Version.Trim();
            lblEstatusGrupo.Text = GlobalVar.Grupo;
            lblEstatusUsuario.Text = "[ " + GlobalVar.Login + " ] " + GlobalVar.D_Usuario;
            lblEstatusBaseDatos.Text = "BD: " + Base;
            lblOficina.Text = "Of: " + GlobalVar.D_Oficina;
            Lblempresa.Text = GlobalVar.D_Empresa;
            ActualizaSPID();
            this.Refresh();
            Application.DoEvents();
                    
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show(" ¿ DESEA SALIR DEL SISTEMA ? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Application.ExitThread();
                Application.Exit();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
                //e.Cancel = true;
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                //if (GlobalVar.CatalogoPropiedadB_Editando == false && GlobalVar.CatalogoPropiedadB_Agregando == false)
                Application.Exit();
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
        private void GrabaOpcionIngresa()
        {
            res = 0;
            msg = string.Empty;

            try
            {
                res = sqlSeguridad.In_Ingresa_Opcion();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE GUARDO EL REGISTRO DE LA OPCION", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuPrincipal.Visible = true;
            this.BarraEstatus.Visible = true;
        }

        private void Principal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                MenuPrincipal.Focus();
            }
        }
        protected override void OnClientSizeChanged(EventArgs e)
        {
            //if(WindowState==FormWindowState.Minimized)
            //{
            //    TamañoCambiado(e);
            //}
            //base.OnClientSizeChanged(e);
        }

        private void TamañoCambiado(EventArgs e)
        {
            //timer1.Start();
            //notifyIcon1.ShowBalloonTip(3000);
            //timer1.Stop();

        }
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string Notifica = string.Empty;
            int res = 0;
            res = gen.Gp_NotificacionesTraspasosDirectos(GlobalVar.K_Usuario, ref Notifica);

            if(Notifica.Length>0)
            {
                Probemedic.Visible = true;
                Probemedic.BalloonTipText = Notifica;
                Probemedic.BalloonTipTitle = "Probemedic";
                Probemedic.Text = "Probemedic";
                Probemedic.ShowBalloonTip(120000);
            }
            else
            {
                Probemedic.Visible = false;
            }
        }
    }
}
