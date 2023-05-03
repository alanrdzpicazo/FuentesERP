﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Consulta_Inventario : FormaBase
    {
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        DataTable dtArticulos = new DataTable();
        DataTable dtEncabezado = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtOficinasEmpresa = new DataTable();
        Funciones fx = new Funciones();
        int K_Oficina = 0;
        int k_Almacen = 0;
        int K_Articulo = 0;
        string strValorEntrada = "";

        public Frm_Consulta_Inventario()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
    
        }

        public override void BaseMetodoInicio()
        {       
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonProceso1.Visible = false;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso3.Visible = false;
          
            grdEncabezado.AutoGenerateColumns = false;

            dtOficinasEmpresa = sqlCatalogos.Sk_Oficina(GlobalVar.K_Empresa);

            MtdCargaOficinaInicial();
            MtdCargaAlmacen();

            this.WindowState = FormWindowState.Maximized;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["application_view_detail.png"]));
            BaseBotonProceso1.Text = "Movimientos";

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["montacargas.png"]));
            BaseBotonProceso2.Text = "Reservados";

        }

        public override void BaseBotonBuscarClick()
        {
            //if ((txtClaveOficina.Text.Trim().Length == 0) && (K_Articulo == 0))
            //{
            //    MessageBox.Show("DEBE SELECCIONAR POR LO MENOS UNA OFICINA O UN ARTICULO, VERIFIQUE...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btnBuscarOficina.Focus();
            //    return;
            //}
            //if ((txtClaveOficina.Text.Trim().Length != 0) && (cbxAlmacen.SelectedIndex == -1))
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UN ALMACEN O EN SU DEFECTO SELECCIONAR 'TODOS'...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cbxAlmacen.Focus();
            //    return;
            //}
            Cursor = Cursors.WaitCursor;
            MtdCargaResultado();
            Cursor = Cursors.Default;
        }

     

        private void btnLimpiaOficina_Click(object sender, EventArgs e)
        {
            K_Oficina = 0;
            txtClaveOficina.Text = "";
            txtOficina.Text = "";
            cbxAlmacen.Enabled = false;
            K_Articulo = 0;
            txtArticulo.Text = "";
            lblActivo.Text = "";
            //MtdCargaOficinaInicial();
            if(grdEncabezado.Rows.Count>0)
            {
                DataTable dt = (DataTable)grdEncabezado.DataSource;
                dt.Clear();
            }
            MtdCargaAlmacen();
            //BaseBotonBuscarClick();
        }

        private void btnLimpiaArticulo_Click(object sender, EventArgs e)
        {
            K_Articulo = 0;
            txtArticulo.Text = "";
            lblActivo.Text = "";
            if (grdEncabezado.Rows.Count > 0)
            {
                DataTable dt = (DataTable)grdEncabezado.DataSource;
                dt.Clear();
            }
            //MtdCargaResultado();

        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {

            if (strValorEntrada != txtClaveOficina.Text)
            {
                K_Oficina = 0;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
                MtdCargaAlmacen();
                
            }
        }

        private void grdEncabezado_DataSourceChanged(object sender, EventArgs e)
        {
            if (grdEncabezado.Rows.Count != 0)
            {
                BaseBotonExcel.Visible = true;
                BaseDtDatos = fx.GetDataTableFromDGV(grdEncabezado);
                BaseBotonProceso1.Visible = true;
                BaseBotonProceso2.Visible = true;
            }
            else
            {
                BaseBotonExcel.Visible = false;
                BaseBotonProceso1.Visible = false;
                BaseBotonProceso2.Visible = false;
            }
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOficinasEmpresa);
            frm.BusquedaPropiedadTablaFiltra = dtOficinasEmpresa;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog(MdiParent);
            if (frm.BusquedaPropiedadReglonRes != null)
            {       
                K_Oficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
                MtdCargaAlmacen();
                cbxAlmacen.Enabled = true;
            }
            else
            {
                K_Oficina = 0;
                txtClaveOficina.Text = string.Empty;
                txtOficina.Text = string.Empty;
                MtdCargaAlmacen();
                cbxAlmacen.Enabled = false;
            }
        }

        void MtdCargaOficinaInicial()
        {
            K_Oficina = GlobalVar.K_Oficina;
            txtClaveOficina.Text = Convert.ToString(K_Oficina);

            txtOficina.Text = GlobalVar.D_Oficina;
            BuscaEnTablaClaveDescripcion(dtOficinasEmpresa, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
            K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
        }

        void MtdCargaResultado()
        {

            grdEncabezado.DataSource = null;
           
            if (cbxAlmacen.SelectedValue != null)
            {
                if (cbxAlmacen.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    k_Almacen = Convert.ToInt32(cbxAlmacen.SelectedValue);
                }
            }

            dtEncabezado = sqlAlmacen.Gp_Inventario(K_Oficina, k_Almacen, K_Articulo, cBoxMostrarTodo.Checked, cbxExistencia.Checked, txtSKU.Text,ucLaboratorio1.K_Laboratorio,ucSustanciaActiva1.K_Sustancia_Activa,GlobalVar.K_Empresa);
            grdEncabezado.DataSource = dtEncabezado;

            if (dtEncabezado == null)
            {
                MessageBox.Show("NO SE ENCONTRÓ INVENTARIO CON LOS PARAMETROS INDICADOS!...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscaProducto.Focus();
                return;
            }
            if (dtEncabezado.Rows.Count > 0 )
            {
                DataRow row = dtEncabezado.Rows[0];

                if(row["Imagen"].ToString() != DBNull.Value.ToString())
                {
                    string cadena = row["Imagen"].ToString();

                    pbImagen.Image = fx.DevuelveImagen(cadena);
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            
            }
            else
            {
                pbImagen.Image = null;
            }

        }

        void MtdCargaAlmacen()
        {
            dtAlmacen = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;
            if (K_Oficina >0)
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes(K_Oficina);
            }
           
            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        void MtdCargaDetalle()
        {
            if (grdEncabezado.CurrentRow != null)
            {
                INVENTARIOS.Frm_Consulta_Inventario_Detalle frm = new INVENTARIOS.Frm_Consulta_Inventario_Detalle();
                frm.K_Articulo = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Articulo1"].Value);
                frm.K_Oficina = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Oficina1"].Value);
                frm.K_Almacen = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Almacen1"].Value);
                frm.Str_Oficina = Convert.ToString(grdEncabezado.CurrentRow.Cells["D_Oficina"].Value);
                frm.Str_Almacen = grdEncabezado.CurrentRow.Cells["D_Almacen"].Value.ToString();
                frm.Str_Articulo = grdEncabezado.CurrentRow.Cells["D_Articulo"].Value.ToString();
                frm.Str_Unidad = grdEncabezado.CurrentRow.Cells["D_Unidad_Medida"].Value.ToString();
                frm.B_MuestraTodo = cBoxMostrarTodo.Checked;
                frm.ShowDialog();
            }
        }
        void MtdCargaDetalleReservados()
        {
            if (grdEncabezado.CurrentRow != null)
            {
                INVENTARIOS.Frm_ConsultaArticulosReservados frm = new INVENTARIOS.Frm_ConsultaArticulosReservados();
                frm.K_Articulo_ = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Articulo1"].Value);
                frm.K_Oficina_ = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Oficina1"].Value);
                frm.K_Almacen_ = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Almacen1"].Value);
                frm.ShowDialog();
            }
        }
        private void cBoxMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cBoxMostrarTodo.Checked == true)
                {
                    if(K_Articulo != 0)
                    {
                        return;
                    }

                    Cursor.Current = Cursors.WaitCursor;
                    FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
                    frm.ShowDialog();
                    K_Articulo = frm.LLave_Seleccionado;
                    txtArticulo.Text = frm.Descripcion_Seleccionado;
                    K_Oficina = 0;
                    k_Almacen = 0;
       

                    if(K_Articulo == 0)
                    {
                        MessageBox.Show("DEBE SELECCIONAR UN ARTICULO, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cBoxMostrarTodo.Checked = false;
                        btnBuscaProducto.Focus();
                        return;         
                    }
                    MtdCargaResultado();
                }
            
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            MtdCargaResultado();
        }

        /*Cargar Detalle*/
        public override void BaseBotonProceso1Click()
        {
            MtdCargaDetalle();
        }

        public override void BaseBotonProceso2Click()
        {
            MtdCargaDetalleReservados();
        }

        private void grdEncabezado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            fx.DibujarColumnaTipoBotonGrid(ref grdEncabezado,imageList1, e, "Lote", "zoom.png");
        }

        private void grdEncabezado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex> -1)
            {
                if (grdEncabezado.Columns[e.ColumnIndex].Name == "Lote")
                {
                    Cursor = Cursors.WaitCursor;
                    INVENTARIOS.FRM_LOTES_INVENTARIO frm = new INVENTARIOS.FRM_LOTES_INVENTARIO();
                    frm.K_Articulo_ = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Articulo1"].Value);
                    frm.K_Oficina_ = Convert.ToInt32(grdEncabezado.CurrentRow.Cells["K_Almacen1"].Value);
                    frm.ShowDialog();
                    Cursor = Cursors.Default;
                }
                if (e.RowIndex > 0)
                {
                    DataRow row = dtEncabezado.Rows[e.RowIndex];

                    if (row["Imagen"].ToString() != DBNull.Value.ToString())
                    {
                        string cadena = row["Imagen"].ToString();
                        pbImagen.Image = fx.DevuelveImagen(cadena);
                        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            
          
        }

        private void btn_ReOrdenInventario_Click(object sender, EventArgs e)
        {
            
            Frm_ReOrden_Inventario frmReOrden = new Frm_ReOrden_Inventario();

            if (Convert.ToInt32(this.txtClaveOficina.Text) > 0 && Convert.ToInt32(this.cbxAlmacen.SelectedValue.ToString()) > 0)
            {
                frmReOrden.K_Oficina = Convert.ToInt32(this.txtClaveOficina.Text);
                frmReOrden.K_Almacen  = Convert.ToInt32(this.cbxAlmacen.SelectedValue.ToString());

                frmReOrden.LlenaDatos();

                frmReOrden.ShowDialog(this);
            }
            else
                MessageBox.Show("DEBE SELECCIONAR OFICINA Y ALMACÉN, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_articulos_a_caducar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Frm_Muestra_Articulos_Por_Caducar frm_x_caducar = new Frm_Muestra_Articulos_Por_Caducar();

            frm_x_caducar.LlenaDatos();

            frm_x_caducar.ShowDialog(this);
            Cursor = Cursors.Default;
        }

        private void Frm_Consulta_Inventario_Load(object sender, EventArgs e)
        {

            Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();

        }

        private void cbxAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void grdEncabezado_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdEncabezado.Cursor = Cursors.Hand;
            else
                grdEncabezado.Cursor = Cursors.Default;
        }

        private void grdEncabezado_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdEncabezado.CurrentRow;
            if (row != null)
            {
                Int32 Pedidos =Convert.ToInt32(row.Cells["Pedidos"].Value.ToString());

                if (Pedidos>0)
                {
                    BaseBotonProceso2.Enabled = true;
                }
                else
                {
                    BaseBotonProceso2.Enabled = false;
                }
            }
        }
    }
}