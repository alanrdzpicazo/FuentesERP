using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.FACTURACION
{
    public partial class FRM_REGISTRO_FACTURA_GLOBAL : FormaBase
    {
        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLPedidos sqlPedidos = new SQLPedidos();
        SQLAdministracion sqlAdministracion = new SQLAdministracion();

        DataTable dtSerie = new DataTable();

        public int K_ClienteInt { get; set; }
        public string D_ClienteString { get; set; }
        private Int32 k_Cliente_Domicilio_Fiscal = 0;
        public int K_Cliente_Domicilio_Fiscal1 { get => k_Cliente_Domicilio_Fiscal; set => k_Cliente_Domicilio_Fiscal = value; }
        public string D_SerieString { get; set; }
        Int32 p_K_Oficina { get; set; }
        String p_D_Oficina { get; set; }

        Int32 p_K_Almacen { get; set; }
        String p_D_Almacen { get; set; }

        int res;
        string msg = string.Empty;
        bool B_Error_Entrar = false;

        public FRM_REGISTRO_FACTURA_GLOBAL()
        {
            InitializeComponent();
            p_K_Oficina = GlobalVar.K_Oficina;
            p_D_Oficina = GlobalVar.D_Oficina;
        }

        private void FRM_REGISTRO_FACTURA_GLOBAL_Load(object sender, EventArgs e)
        {
            if (!validaTengaSeries())
            {
                MessageBox.Show("EL USUARIO NO TIENE SERIES ASIGNADAS. NO PODRA FACTURAR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }

            DataTable dt = sqlCatalogos.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina, GlobalVar.K_Empresa);

            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("EL USUARIO NO CUENTA CON ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    B_Error_Entrar = true;
                }
                else if (dt.Rows.Count == 1)
                {
                    p_K_Almacen = Convert.ToInt32(dt.Rows[0]["K_Almacen"].ToString());
                    p_D_Almacen = dt.Rows[0]["D_Almacen"].ToString();
                }
                else if (dt.Rows.Count > 1)
                {
                    MessageBox.Show("EL USUARIO CUENTA CON MAS DE UN ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    B_Error_Entrar = true;
                }
            }
            else
            {
                MessageBox.Show("EL USUARIO NO CUENTA CON ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }
        }

        private void FRM_REGISTRO_FACTURA_GLOBAL_Shown(object sender, EventArgs e)
        {
            if (!B_Error_Entrar)
            {
                if (!validaPuedeCambiarSerie())
                {
                    txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                    btnBuscarSerie.Enabled = false;
                    txtSerie.Enabled = false;
                }
                else
                {
                    txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                    btnBuscarSerie.Enabled = true;
                    txtSerie.Enabled = true;
                }
             
                txtClaveOficina.Text = p_K_Oficina.ToString();
                txtOficina.Text = p_D_Oficina;
                txtClaveAlmacen.Text = p_K_Almacen.ToString();
                txtAlmacen.Text = p_D_Almacen;
            }
            else
            {
                Close();
            }
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            base.BaseMetodoInicio();

            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonGuardar.Image = Properties.Resources.Aceptar;
            BaseBotonGuardar.Text = "Facturar [F5]";

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (p_K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (p_K_Almacen ==0)
            {
                MessageBox.Show("FALTA CAPTURAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (txtDomicilioFiscal.Text == "")
            {
                MessageBox.Show("FALTA CAPTURAR DOMICILIO FISCAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDomicilioFiscal.Focus();
                return false;
            }
            if (txtSerie.Text == "")
            {
                MessageBox.Show("FALTA CAPTURAR LA SERIE DE FACTURACIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }       
            return true;
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            Cursor = Cursors.WaitCursor;
            res = sqlAdministracion.IN_Registra_FacturaGlobal(txtSerie.Text.Trim(),Convert.ToInt32(p_K_Almacen),
                         p_K_Oficina,GlobalVar.K_Usuario,GlobalVar.K_Empresa,K_ClienteInt,K_Cliente_Domicilio_Fiscal1,GlobalVar.PC_Name,
                         txtCorreo.Text.Trim(), ref msg);
            Cursor = Cursors.Default;

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BaseBotonGuardar.Visible = true;
                BaseBotonGuardar.Enabled = true;
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("FACTURA GLOBAL CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseBotonGuardar.Visible = true;
                BaseBotonGuardar.Enabled = false;
            }
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();

            if ((filtra.K_Cliente_Seleccionado > 0) && (filtra.D_Cliente_Seleccionado.Length > 0))
            {
                K_ClienteInt = filtra.K_Cliente_Seleccionado;
                txtCliente.Text = filtra.D_Cliente_Seleccionado;
                D_ClienteString = filtra.D_Cliente_Seleccionado;
            }
            else
            {
                K_ClienteInt = 0;
                txtCliente.Text = string.Empty;
                D_ClienteString = string.Empty;
            }
        }

        private void btnBuscarDomiclioFiscal_Click(object sender, EventArgs e)
        {
            if (K_ClienteInt == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            DataTable dtDomiciliosFiscales = sqlCatalogos.Sk_Cliente_Domicilios_Fiscales(K_ClienteInt);

            Busquedas.BuscaDomicilioFiscalCliente frm = new Busquedas.BuscaDomicilioFiscalCliente();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtDomiciliosFiscales);
            frm.BusquedaPropiedadTablaFiltra = dtDomiciliosFiscales;

            if (dtDomiciliosFiscales != null)
            {
                if (dtDomiciliosFiscales.Rows.Count == 1)
                {
                    K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(dtDomiciliosFiscales.Rows[0]["K_Cliente_Domicilio_Fiscal"]);
                    txtDomicilioFiscal.Text = dtDomiciliosFiscales.Rows[0]["Calle"].ToString() + " EXT. " + dtDomiciliosFiscales.Rows[0]["Numero_Exterior"].ToString() + " INT." + dtDomiciliosFiscales.Rows[0]["Numero_Interior"].ToString() +
                        " COL." + dtDomiciliosFiscales.Rows[0]["D_Colonia"].ToString() + " C.P." + dtDomiciliosFiscales.Rows[0]["Codigo_Postal"].ToString() + " " + dtDomiciliosFiscales.Rows[0]["D_Ciudad"].ToString() + "," + dtDomiciliosFiscales.Rows[0]["D_Estado"].ToString() + "," + dtDomiciliosFiscales.Rows[0]["D_Pais"].ToString();
                }
                else if (dtDomiciliosFiscales.Rows.Count > 1)
                {
                    frm.BusquedaPropiedadTitulo = "Busca Domicilios Fiscales del Cliente";
                    frm.ShowDialog();

                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        K_Cliente_Domicilio_Fiscal1 = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Cliente_Domicilio_Fiscal"]);
                        txtDomicilioFiscal.Text = frm.BusquedaPropiedadReglonRes["Calle"].ToString() + " EXT. " + frm.BusquedaPropiedadReglonRes["Numero_Exterior"].ToString() + " INT." + frm.BusquedaPropiedadReglonRes["Numero_Interior"].ToString() +
                        " COL." + frm.BusquedaPropiedadReglonRes["D_Colonia"].ToString() + " C.P." + frm.BusquedaPropiedadReglonRes["Codigo_Postal"].ToString() + " " + frm.BusquedaPropiedadReglonRes["D_Ciudad"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Estado"].ToString() + "," + frm.BusquedaPropiedadReglonRes["D_Pais"].ToString();
                    }
                }
            }
            else
            {

                MessageBox.Show("EL CLIENTE NO TIENE DOMICILIOS FISCALES ASIGNADAS!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();

            }
            Cursor = Cursors.Default;
        }

        private void btnBuscarSerie_Click(object sender, EventArgs e)
        {
            if (dtSerie != null)
            {
                dtSerie.Columns["D_Serie"].SetOrdinal(1);
                dtSerie.Columns["Orden"].SetOrdinal(0);
                dtSerie.AcceptChanges();
                Busquedas.BuscaSeries frm = new Busquedas.BuscaSeries();
                frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtSerie);
                frm.BusquedaPropiedadTablaFiltra = dtSerie;
                if (dtSerie.Rows.Count == 1)
                {
                    D_SerieString = dtSerie.Rows[0]["D_Serie"].ToString();
                    txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();

                    if (!GlobalVar.B_CambiaSerie)
                        btnBuscarSerie.Enabled = false;
                }
                else if (dtSerie.Rows.Count > 1)
                {
                    if (!GlobalVar.B_CambiaSerie)
                    {
                        D_SerieString = dtSerie.Rows[0]["D_Serie"].ToString();
                        txtSerie.Text = dtSerie.Rows[0]["D_Serie"].ToString();
                        btnBuscarSerie.Enabled = false;
                    }
                    else
                    {
                        frm.BusquedaPropiedadTitulo = "Busca Series";
                        frm.ShowDialog();
                        if (frm.BusquedaPropiedadReglonRes != null)
                        {
                            D_SerieString = frm.BusquedaPropiedadReglonRes[1].ToString();
                            txtSerie.Text = frm.BusquedaPropiedadReglonRes[1].ToString();
                        }
                        else
                        {
                            D_SerieString = string.Empty;
                            txtSerie.Text = string.Empty;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("EL USUARIO NO TIENE ASIGNADAS SERIES!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarSerie.Focus();
            }
        }

        private bool validaTengaSeries()
        {
            dtSerie = sqlCatalogos.SK_UsuaSerieAsig(GlobalVar.K_Usuario);

            if (dtSerie == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validaPuedeCambiarSerie()
        {
            res = 0;
            res = sqlPedidos.Gp_ValidaPuedaCambiarSerie(GlobalVar.K_Usuario);

            if (res == -1)
            {
                if (msg.Length > 0)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            return true;

        }

     
    }
}
