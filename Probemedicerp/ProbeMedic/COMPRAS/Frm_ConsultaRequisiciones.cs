using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;


namespace ProbeMedic.COMPRAS
{
    public partial class Frm_ConsultaRequisiciones : FormaConsulta
    {
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        DataTable dtRequisiciones = new DataTable();
//        DateTime Fecha1 = new DateTime(2000, 01, 01);
//        DateTime Fecha2 = new DateTime(2050, 01, 01);  
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;


        public Frm_ConsultaRequisiciones()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtClaveRequisicion; //Asignar el textbox que inicia el focus

            grdDatos.AutoGenerateColumns = false;
            grdDetalle.AutoGenerateColumns = false;

            GlobalVar.dtEstatusCompra = sqlCatalogos.Sk_Estatus_Compra();
            LlenaCombo(GlobalVar.dtEstatusCompra, ref cmbEstatusCompra, "K_Estatus_Compra", "D_Estatus_Compra");
            GlobalVar.dtTipoRequisicion = sqlCatalogos.Sk_Tipo_Requisicion();
            LlenaCombo(GlobalVar.dtTipoRequisicion, ref cmbTipoRequisicion, "K_Tipo_Requisicion", "D_Tipo_Requisicion");
            GlobalVar.dtTipoArticulo = sqlCatalogos.Sk_Tipos_Productos();
            LlenaCombo(GlobalVar.dtTipoArticulo, ref cmbTipoArticulo, "K_Tipo_Producto", "D_Tipo_Producto");
            GlobalVar.dtClasificacionArticulo = sqlCatalogos.Sk_Categoria_Articulo();
            LlenaCombo(GlobalVar.dtClasificacionArticulo, ref cmbClasificacion, "K_Categoria_Articulo", "D_Categoria_Articulo");
            GlobalVar.dtGrupoArticulo = sqlCatalogos.Sk_Grupos_Articulos();
            LlenaCombo(GlobalVar.dtGrupoArticulo, ref cmbGrupo, "K_Grupo_Articulo", "D_Grupo_Articulo");

            CBoxAutorizada.SelectedIndex = 0;
            txtClaveRequisicion.Focus();
            base.BaseMetodoInicio();
            BaseBotonReporte.Visible = false;
        }

             

        public override void BaseBotonBuscarClick()
        {

            if (cbxCanceladas.Checked == false || cbxAutorizadas.Checked == false)
            {
                if (txtClaveUsuarioRequiere.Text.Trim().Length == 0 && txtClaveUsuarioAutoriza.Text.Trim().Length == 0 && txtClaveOficina.Text.Trim().Length == 0 && txtClaveRequisicion.Text.Trim().Length == 0 && cmbEstatusCompra.SelectedValue == null && cmbClasificacion.SelectedValue == null && cmbGrupo.SelectedValue == null && cmbTipoArticulo.SelectedValue == null && cmbTipoRequisicion.SelectedValue == null)
                {
                    MessageBox.Show("DEBE SELECCIONAR AL MENOS UN FILTRO PARA LA BÚSQUEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveRequisicion.Focus();
                    return;
                }
            }


            int K_Requisicion = 0;
            int K_Oficina = 0;
            int K_UsuarioRequiere = 0;
            int K_UsuarioAutoriza = 0;
            int K_EstatusCompra = 0;
            short K_TipoRequisicion = 0;            
            int K_TipoArticulo = 0;
            int K_ClasificacionArticulo = 0;
            int K_GrupoArticulo = 0;
            short TipoAutorizada = 0;
//            short TipoCancelada = 0;

            Fecha1 = txtFecha1.Value;
            Fecha2 = txtFecha2.Value;

            if (txtClaveRequisicion.Text.Trim().Length > 0)
                K_Requisicion = Convert.ToInt32(txtClaveRequisicion.Text);
            if (txtClaveOficina.Text.Trim().Length > 0)
                K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            if(txtClaveUsuarioRequiere.Text.Trim().Length > 0)
                K_UsuarioRequiere = Convert.ToInt32(txtClaveUsuarioRequiere.Text);
            if(txtClaveUsuarioAutoriza.Text.Trim().Length > 0)
                K_UsuarioAutoriza = Convert.ToInt32(txtClaveUsuarioAutoriza.Text);

            if (cmbEstatusCompra.SelectedValue != null)
                K_EstatusCompra = Convert.ToInt32(cmbEstatusCompra.SelectedValue);
            if (cmbTipoRequisicion.SelectedValue != null)
                K_TipoRequisicion = Convert.ToInt16(cmbTipoRequisicion.SelectedValue);
            if(cmbTipoArticulo.SelectedValue != null)
                K_TipoArticulo = Convert.ToInt32(cmbTipoArticulo.SelectedValue);
            if(cmbClasificacion.SelectedValue != null)
                K_ClasificacionArticulo = Convert.ToInt32(cmbClasificacion.SelectedValue);
            if(cmbGrupo.SelectedValue != null)
                K_GrupoArticulo = Convert.ToInt32(cmbGrupo.SelectedValue);
            if (CBoxAutorizada.SelectedValue != null)
                TipoAutorizada = Convert.ToInt16(CBoxAutorizada.SelectedValue);

            DataTable dt = new DataTable();
            dt = sqlCompras.Sk_ConsultaRequisiciones(K_Requisicion, K_Oficina, K_TipoRequisicion, K_EstatusCompra, K_UsuarioRequiere, cbxAutorizadas.Checked, cbxCanceladas.Checked, K_UsuarioAutoriza, Fecha1, Fecha2, K_TipoArticulo, K_ClasificacionArticulo, K_GrupoArticulo);
            BaseDtDatos = dt;
            grdDatos.DataSource = dt;

            tabControl1.SelectedTab = tpOrdenes;
        }

        public override void BaseMetodoLimpiaControles()
        {            
            txtClaveOficina.Text = string.Empty;
            txtOficina.Text = string.Empty;            
            txtClaveRequisicion.Text = string.Empty;
            txtClaveUsuarioAutoriza.Text = string.Empty;
            txtUsuarioAutoriza.Text = string.Empty;
            txtClaveUsuarioRequiere.Text = string.Empty;
            txtUsuarioRequiere.Text = string.Empty;
            txtRequisicion.Text = string.Empty;

            cmbEstatusCompra.SelectedIndex = -1;            
            cmbTipoRequisicion.SelectedIndex = -1;
            cmbTipoArticulo.SelectedIndex = -1;
            cmbClasificacion.SelectedIndex = -1;
            cmbGrupo.SelectedIndex = -1;

            txtFecha1.Value = Fecha1;
            txtFecha2.Value = Fecha2;

            cbxCanceladas.Checked = false;
            cbxAutorizadas.Checked = true;

            grdDatos.DataSource = null;
            tabControl1.SelectedTab = tpOrdenes;

            dtRequisiciones = sqlCompras.Sk_Requisicion(5, true, false); //5 = Asignada a una compra
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);            
        }

       

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
        }

       

        private void btnBuscaRequisicion_Click(object sender, EventArgs e)
        {            
            Busquedas.BuscaRequisiciones frm = new Busquedas.BuscaRequisiciones();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtRequisiciones);
            frm.BusquedaPropiedadTablaFiltra = dtRequisiciones;
            frm.BusquedaPropiedadTitulo = "Busca Requisiciones";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveRequisicion.Text = frm.BusquedaPropiedadReglonRes["K_Requisicion"].ToString();
                txtRequisicion.Text = frm.BusquedaPropiedadReglonRes["D_Tipo_Requisicion"].ToString();
            }
        }

        private void txtClaveRequisicion_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(dtRequisiciones, "K_Requisicion", "D_Tipo_Requisicion", ref txtClaveRequisicion, ref txtRequisicion);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) //DEtalle
            {
                grdDetalle.DataSource = null;
                if (grdDatos.DataSource == null)
                    return;
                if (grdDatos.Rows.Count == 0)
                    return;

                int K_Requisicion = 0;
                DataGridViewRow row = grdDatos.CurrentRow;
                if (row != null)
                    K_Requisicion = Convert.ToInt32(row.Cells["K_RequisicionCol"].Value);

                DataTable dtDetalle = sqlCompras.Sk_RequisicionDetalle(K_Requisicion);
                if (dtDetalle != null)
                {
                    if (dtDetalle.Rows.Count > 0)
                    {
                        grdDetalle.DataSource = dtDetalle;
                    }
                }             
            }
        }

        private void txtClaveUsuarioRequiere_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtUsuarios, "K_Usuario", "D_Usuario", ref txtClaveUsuarioRequiere, ref txtUsuarioRequiere);            
        }

        private void txtClaveUsuarioAutoriza_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtUsuarios, "K_Usuario", "D_Usuario", ref txtClaveUsuarioAutoriza, ref txtUsuarioAutoriza);            
        }

        private void btnBuscaUsuarioRequiere_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaUsuarios frm = new Busquedas.BuscaUsuarios();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtUsuarios);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtUsuarios;
            frm.BusquedaPropiedadTitulo = "Busca Usuarios";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveUsuarioRequiere.Text = frm.BusquedaPropiedadReglonRes["K_Usuario"].ToString();
                txtUsuarioRequiere.Text = frm.BusquedaPropiedadReglonRes["D_Usuario"].ToString();
            }
        }

        private void btnBuscaUsuarioAutoriza_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaUsuarios frm = new Busquedas.BuscaUsuarios();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtUsuarios);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtUsuarios;
            frm.BusquedaPropiedadTitulo = "Busca Usuarios Autorizaron";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveUsuarioAutoriza.Text = frm.BusquedaPropiedadReglonRes["K_Usuario"].ToString();
                txtUsuarioAutoriza.Text = frm.BusquedaPropiedadReglonRes["D_Usuario"].ToString();
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        



    }
}
