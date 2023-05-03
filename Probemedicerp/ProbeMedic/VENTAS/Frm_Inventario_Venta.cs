using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Inventario_Venta : FormaBase
    {
        int p_K_Oficina { get; set; }
        int p_K_Articulo { get; set; }
        int p_K_Cliente { get; set; }
        int p_K_Almacen_Usuario { get; set; }

        int K_Almacen_Pasa;
        int K_Cliente_Pasa;


        DataTable dtAlmacen = new DataTable();
        DataTable dtInventario = new DataTable();

        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sql_ventas = new SQLVentas();
        Funciones fx = new Funciones();

        public Frm_Inventario_Venta()
        {
            InitializeComponent();
            Dgv_Datos.AutoGenerateColumns = false;

        }
        public override void BaseMetodoInicio()
        {
            p_K_Oficina = GlobalVar.K_Oficina;
            txtOficina.Text = GlobalVar.D_Oficina;
            MtdCargaAlmacen();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = true;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["application_view_detail.png"]));
            BaseBotonProceso1.Text = "Detalle Ubicaciones";
            BaseBotonProceso1.Width = 130;


        }    
        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            p_K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            Txt_Sku.Text = frm.Sku;
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void btnLimpiaArticulo_Click(object sender, EventArgs e)
        {
            p_K_Articulo = 0;
            txtArticulo.Text = "";
            Txt_Sku.Text = "";
            FiltraDetalle();
        }
        void MtdCargaAlmacen()
        {               
            dtAlmacen.Rows.Clear();
            
            dtAlmacen = sqlCatalogo.Sk_Almacenes(p_K_Oficina);
           
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

                Int32 K_Almacen_Usuario = 0;
                obtenerAlmacenIncial(ref K_Almacen_Usuario);

                LlenaCombo(dtAlmacen, ref CbxAlmacen, "K_Almacen", "D_Almacen", indice);

                DataRow[] results = dtAlmacen.Select("K_Almacen = "+K_Almacen_Usuario);

                if (results != null)
                    CbxAlmacen.SelectedValue = K_Almacen_Usuario;                    
            }
        }
        void FiltraDetalle()
        {
            K_Almacen_Pasa = int.Parse(CbxAlmacen.SelectedValue.ToString());
            K_Cliente_Pasa = p_K_Cliente;

            Int32 valor = 0;
            if ((Forma.IsNumeric(txtArticulo.Text)) && (Int32.TryParse(txtArticulo.Text.Trim(), out valor)))
            {
                p_K_Articulo = Convert.ToInt32(txtArticulo.Text.Trim());

                dtInventario = sql_ventas.Gp_Sk_Inventario_Venta(K_Almacen_Pasa, p_K_Articulo, K_Cliente_Pasa,string.Empty);

            }
            else if (txtArticulo.Text.Trim().Length > 0)
            {
                p_K_Articulo = 0;

                dtInventario = sql_ventas.Gp_Sk_Inventario_Venta(K_Almacen_Pasa, p_K_Articulo, K_Cliente_Pasa,txtArticulo.Text.Trim());
            }
            else
            {
                p_K_Articulo = 0;

                dtInventario = sql_ventas.Gp_Sk_Inventario_Venta(K_Almacen_Pasa, p_K_Articulo, K_Cliente_Pasa, string.Empty);
            }
                

            if (dtInventario!= null)
            {
                if(dtInventario.Rows.Count>0)
                {
                    Dgv_Datos.DataSource = dtInventario;
                    Dgv_Datos.Rows[0].Selected = true;
                    BaseBotonProceso1.Visible = true;
                    BaseBotonProceso1.Enabled = true;
                }
         
            }
            else
            {
                Dgv_Datos.DataSource = null;
            }
            Txt_Sku.Focus();
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Cliente frm = new Busquedas.Frm_Busca_Cliente(GlobalVar.K_Empresa);
            Cursor = Cursors.WaitCursor;
            frm.ShowDialog();
            Cursor = Cursors.Default;
            if (p_K_Cliente != frm.LLave_Seleccionado)
            {
                p_K_Cliente = frm.LLave_Seleccionado;
                txtCliente.Text = frm.Descripcion_Seleccionado;
                Cursor = Cursors.WaitCursor;
                FiltraDetalle();
                Cursor = Cursors.Default;
            }
        }
        public override void BaseBotonProceso1Click()
        {
            if (Dgv_Datos.DataSource != null )
            { 
                INVENTARIOS.Frm_Consulta_Inventario_Ubicacion frm = new INVENTARIOS.Frm_Consulta_Inventario_Ubicacion();
                Cursor = Cursors.WaitCursor;
                frm.p_K_Almacen = Convert.ToInt32(Dgv_Datos.CurrentRow.Cells["K_Almacen"].Value.ToString());
                frm.p_D_Almacen = Dgv_Datos.CurrentRow.Cells["D_Almacen"].Value.ToString();
                frm.p_K_Oficina = Convert.ToInt32(Dgv_Datos.CurrentRow.Cells["K_Oficina"].Value.ToString());
                frm.p_D_Oficina = Dgv_Datos.CurrentRow.Cells["D_Oficina"].Value.ToString();
                frm.p_K_Articulo = Convert.ToInt32(Dgv_Datos.CurrentRow.Cells["K_Articulo"].Value.ToString());
                frm.p_D_Articulo = Dgv_Datos.CurrentRow.Cells["D_Articulo"].Value.ToString();
                frm.ShowDialog();
                Cursor = Cursors.Default;
            }

        }
        public override void BaseBotonCancelarClick()
        {
            txtCliente.Text = "";
            K_Cliente_Pasa = 0;
            p_K_Cliente = 0;
            p_K_Articulo = 0;
            txtArticulo.Text = "";
            Txt_Sku.Text = "";
            K_Almacen_Pasa = 0;
            Dgv_Datos.DataSource = null;
            MtdCargaAlmacen();
            base.BaseBotonCancelarClick();
        }

        private void Frm_Inventario_Venta_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }
        public override void BaseBotonBuscarClick()
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
            base.BaseBotonBuscarClick();
        }

        private void obtenerAlmacenIncial(ref Int32 K_Almacen)
        {
            DataTable dt = sqlCatalogo.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina, GlobalVar.K_Empresa);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows.Count == 1)
                    {
                        K_Almacen = Convert.ToInt32(dt.Rows[0]["K_Almacen"].ToString());
                    }
                    else if(dt.Rows.Count>0)
                    {
                        K_Almacen = 0;
                    }
                }
                else
                {
                    K_Almacen = 0;
                }
            }
            else
            {
                K_Almacen = 0;
            }
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtArticulo.Text.Trim().Length>0)
                {
                    Cursor = Cursors.WaitCursor;
                    FiltraDetalle();
                    Cursor = Cursors.Default;
                    txtArticulo.Text = string.Empty;
                }
            
            }
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyValue == Convert.ToChar(Keys.Tab))
            {
                if(txtArticulo.Text.Trim().Length>0)
                {
                    Cursor = Cursors.WaitCursor;
                    FiltraDetalle();
                    Cursor = Cursors.Default;
                    txtArticulo.Text = string.Empty;
                }
              
            }
        }
    }
}
