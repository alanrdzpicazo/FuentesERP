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
    public partial class Frm_Busca_Articulo_Venta : FormaBase
    {
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();
        DataTable dtArticulos = new DataTable();
        DataTable dtEncabezado = new DataTable();
        DataTable dtAlmacen = new DataTable();
        Funciones fx = new Funciones();

        int K_Oficina = GlobalVar.K_Oficina;
        int k_Almacen = 0;
        int K_Articulo = 0;
        public string SKU_Salida { get; set; }

        public Frm_Busca_Articulo_Venta()
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
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            grdInventario.AutoGenerateColumns = false;

            MtdCargaAlmacen();


        }

        public override void BaseBotonBuscarClick()
        {
            if (Cbx_Almacen.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALMACEN, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cbx_Almacen.Focus();
                return;
            }
            if (txtArticulo.Text.Length == 0 & txtSKU.Text.Length == 0 & ucLaboratorio1.K_Laboratorio == 0 & ucSustanciaActiva1.K_Sustancia_Activa == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PARAMETRO, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            MtdCargaResultado();
            Cursor = Cursors.Default;
        }

        void MtdCargaAlmacen()
        {
            if (dtAlmacen != null)
            {
                dtAlmacen.Rows.Clear();
            }
            Cbx_Almacen.DataSource = null;
            Cbx_Almacen.Items.Clear();
            Cbx_Almacen.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Almacen.AutoCompleteMode = AutoCompleteMode.None;

            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
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

                Int32 K_Almacen_Usuario = 0;
                obtenerAlmacenIncial(ref K_Almacen_Usuario);

                LlenaCombo(dtAlmacen, ref Cbx_Almacen, "K_Almacen", "D_Almacen", indice);

                DataRow[] results = dtAlmacen.Select("K_Almacen = " + K_Almacen_Usuario);

                if (results != null)
                    Cbx_Almacen.SelectedValue = K_Almacen_Usuario;
            }
        }

        void MtdCargaResultado()
        {
            grdInventario.DataSource = null;

            if (Cbx_Almacen.SelectedValue != null)
            {
                if (Cbx_Almacen.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    k_Almacen = Convert.ToInt32(Cbx_Almacen.SelectedValue);
                }
            }
            Int32 valor = 0;
            if ((Forma.IsNumeric(txtArticulo.Text)) && (Int32.TryParse(txtArticulo.Text.Trim(), out valor)))
            {
                K_Articulo = Convert.ToInt32(txtArticulo.Text.Trim());

                dtEncabezado = sqlVentas.Gp_Inventario_Farmacia(
                   K_Oficina,
                   k_Almacen,
                   K_Articulo,
                   false,
                   true,
                   txtSKU.Text,
                   ucLaboratorio1.K_Laboratorio,
                   ucSustanciaActiva1.K_Sustancia_Activa,
                   string.Empty);

            }
            else if (txtArticulo.Text.Trim().Length > 0)
            {
                K_Articulo = 0;

                dtEncabezado = sqlVentas.Gp_Inventario_Farmacia(
                    K_Oficina,
                    k_Almacen,
                    K_Articulo,
                    false,
                    true,
                    txtSKU.Text,
                    ucLaboratorio1.K_Laboratorio,
                    ucSustanciaActiva1.K_Sustancia_Activa,
                    txtArticulo.Text.Trim());
            }
            else
            {
                K_Articulo = 0;

                dtEncabezado = sqlVentas.Gp_Inventario_Farmacia(
                    K_Oficina,
                    k_Almacen,
                    K_Articulo,
                    false,
                    true,
                    txtSKU.Text,
                    ucLaboratorio1.K_Laboratorio,
                    ucSustanciaActiva1.K_Sustancia_Activa,
                    string.Empty);
            }


            if(dtEncabezado!= null){
                grdInventario.DataSource = dtEncabezado;
                grdInventario.Focus();
            }
            if (dtEncabezado == null)
            {
                MessageBox.Show("EL ARTÍCULO NO TIENE EXISTENCIA DISPONIBLE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pbImagen.Image = null;
                return;
            }
            if (dtEncabezado.Rows.Count > 0)
            {
                DataRow row = dtEncabezado.Rows[0];

                if (row["Imagen"].ToString() != DBNull.Value.ToString())
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

        private void btnBuscaArticulo_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            Cursor = Cursors.WaitCursor;
            MtdCargaResultado();
            Cursor = Cursors.Default;
        }

        private void grdInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdInventario.CurrentRow != null)
            {
                if(e.RowIndex > -1)
                {
                    if (dtEncabezado.Rows.Count != 0)
                    {
                        DataRow row = dtEncabezado.Rows[e.RowIndex];
                        if (row.ToString() == "-1")
                        {
                            return;
                        }
                        if (row["Imagen"].ToString() != DBNull.Value.ToString())
                        {
                            string cadena = row["Imagen"].ToString();
                            pbImagen.Image = fx.DevuelveImagen(cadena);
                            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pbImagen.Image = null;
                            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
                    }
                }
               
            }
        }

        private void grdInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {         
            btnAgregar.PerformClick();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (grdInventario.DataSource == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow fila = grdInventario.CurrentRow;
            SKU_Salida = Convert.ToString(fila.Cells["SKU"].Value);
            this.Close();

        }

  
        private void Frm_Busca_Articulo_Venta_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                btnAgregar.PerformClick();
            }

        }

        private void grdInventario_KeyUp(object sender, KeyEventArgs e)
        {
            //if(grdInventario.CurrentRow!=null)
            //{
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        btnAgregar.PerformClick();
            //    }
            //}
           
        }

        private void grdInventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                grdInventario.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;
                btnAgregar.PerformClick();
            }
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
                    else if (dt.Rows.Count > 0)
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
                    MtdCargaResultado();
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
                    MtdCargaResultado();
                    Cursor = Cursors.Default;
                    txtArticulo.Text = string.Empty;
                }
      
            }
        }

        private void grdInventario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                SendKeys.Send("{Down}");
            }
        }

        private void grdInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (grdInventario.CurrentRow != null)
            {
                if (grdInventario.CurrentRow.Index > -1)
                {
                    if (dtEncabezado.Rows.Count != 0)
                    {
                        DataRow row = dtEncabezado.Rows[grdInventario.CurrentRow.Index];
                        if (row.ToString() == "-1")
                        {
                            return;
                        }
                        if (row["Imagen"].ToString() != DBNull.Value.ToString())
                        {
                            string cadena = row["Imagen"].ToString();
                            pbImagen.Image = fx.DevuelveImagen(cadena);
                            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pbImagen.Image = null;
                            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
                    }
                }

            }
        }
    }
}
