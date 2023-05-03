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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Generar_Solicitud_Transferencia : FormaBase
    {
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLRecepcion sQLRecepcion = new SQLRecepcion();
        DataTable dtAlmacenSolicita = new DataTable();
        DataTable dtAlmacenOrigen = new DataTable();
        DataTable dtArticulos = new DataTable();
        DataTable dtValida = new DataTable();
        Int32 K_Oficina_Solicita = 0;

        Int32 KArticulo = 0;
        string DArticulo = string.Empty;
        string DTipoProducto = string.Empty;
        string DUnidadMedida = string.Empty;
        string sKU = string.Empty;

        int res;

        public Frm_Generar_Solicitud_Transferencia()
        {
            InitializeComponent();
            Shown += new EventHandler(Principal_Shown);
            sel_OficinaOrigen.PropertyChanged += new PropertyChangedEventHandler(sel_OficinaOrigen_PropertyChanged);
        }

        void Principal_Shown(object sender, EventArgs e)
        {
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;

            dtArticulos = TDetalles;

            K_Oficina_Solicita = GlobalVar.K_Oficina;
            txtOficinaSolicita.Text = GlobalVar.D_Oficina;

            CargaAlmacenSolicita();

            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            Int32 CampoIdentity = 0;
            string msg = string.Empty;

            DataTable dtDetalle = dtArticulos.Copy();
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("D_Unidad_Medida");
            dtDetalle.Columns.Remove("SKU");
            //dtDetalle.Columns.Remove("K_Movimiento_Inventario");
            //dtDetalle.Columns.Remove("Lote");
            //dtDetalle.Columns.Remove("F_Caducidad");
            try
            {
                res = 0;
                res = sqlAlmacen.In_Solicitud_Transferencia(
                    ref CampoIdentity,
                    K_Oficina_Solicita,
                    Convert.ToInt32(CbxAlmacenSolicita.SelectedValue),
                    sel_OficinaOrigen.K_Oficina,
                    Convert.ToInt32(CbxAlmacenOrigen.SelectedValue),
                    ucMotivoTransferencia1.K_Motivo_Transferencia,
                    dtDetalle,
                    GlobalVar.K_Usuario,
                    txtObservaciones.Text.Trim(),          
                    ref msg
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE REALIZO LA SOLICITUD CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (Convert.ToInt32(CbxAlmacenSolicita.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACEN SOLICITA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxAlmacenSolicita.Focus();
                return false;
            }
            if (sel_OficinaOrigen.K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA ORIGEN","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sel_OficinaOrigen.Focus();
                return false;
            }
            if (Convert.ToInt32(CbxAlmacenOrigen.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACEN DE ORIGEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxAlmacenOrigen.Focus();
                return false;
            }
            if (txtObservaciones.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OBSERVACIONES.!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtObservaciones.Focus();
                return false;
            }
            if (ucMotivoTransferencia1.K_Motivo_Transferencia == 0)
            {
                MessageBox.Show("FALTA CAPTURAR MOTIVO TRANSFERENCIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucMotivoTransferencia1.Focus();
                return false;
            }
           
            if (grdDetalle.DataSource == null)
            {
                MessageBox.Show("FALTA AGREGAR ARTICULOS A LA SOLICITUD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulos.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void sel_OficinaOrigen_PropertyChanged(object sender, EventArgs e)
        {
            if (sel_OficinaOrigen.K_Oficina > 0)
            {
                CargaAlmacenOrigen();
            }
            else
            {
                if (sel_OficinaOrigen.K_Oficina == 0)
                {
                    if (dtAlmacenOrigen != null)
                        dtAlmacenOrigen.Rows.Clear();
                }
            }
        }

        private void CargaAlmacenSolicita()
        {
            ////dtAlmacen.Rows.Clear();
            //CbxAlmacenSolicita.DataSource = null;
            //CbxAlmacenSolicita.Items.Clear();
            //CbxAlmacenSolicita.AutoCompleteSource = AutoCompleteSource.None;
            //CbxAlmacenSolicita.AutoCompleteMode = AutoCompleteMode.None;

            //if (K_Oficina_Solicita == 0)
            //{
            //    dtAlmacenSolicita.Rows.Clear();
            //}
            //else
            //{
            //    dtAlmacenSolicita = sqlCatalogo.Sk_Almacenes(K_Oficina_Solicita);
            //}

            //if (dtAlmacenSolicita != null)
            //{
            //    DataRow dr = dtAlmacenSolicita.NewRow();

            //    dr["K_Almacen"] = 0;
            //    dr["K_Oficina"] = 0;
            //    dr["D_Oficina"] = "";
            //    dr["D_Almacen"] = "[Seleccionar]";
            //    dr["B_AceptaDevolucionesCliente"] = false;



            //    dtAlmacenSolicita.Rows.InsertAt(dr, 0);

            //    dtAlmacenSolicita.AcceptChanges();

            //    int indice = -1;
            //    indice = 0;
            //    LlenaCombo(dtAlmacenSolicita, ref CbxAlmacenSolicita, "K_Almacen", "D_Almacen", indice);
            //    CbxAlmacenSolicita.SelectedIndex = 1;
            //}



            //dtAlmacen.Rows.Clear();
            CbxAlmacenSolicita.DataSource = null;
            CbxAlmacenSolicita.Items.Clear();
            CbxAlmacenSolicita.AutoCompleteSource = AutoCompleteSource.None;
            CbxAlmacenSolicita.AutoCompleteMode = AutoCompleteMode.None;

            if (K_Oficina_Solicita == 0)
            {
                dtAlmacenSolicita.Rows.Clear();
            }
            else
            {
                dtAlmacenSolicita = sqlCatalogo.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario,K_Oficina_Solicita,GlobalVar.K_Empresa);
            }

            if (dtAlmacenSolicita != null)
            {
                DataRow dr = dtAlmacenSolicita.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Usuario"] = 0;
                dr["D_Usuario"] = "";
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "[Seleccionar]";
                dr["B_AceptaDevolucionesCliente"] = false;



                dtAlmacenSolicita.Rows.InsertAt(dr, 0);

                dtAlmacenSolicita.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacenSolicita, ref CbxAlmacenSolicita, "K_Almacen", "D_Almacen", indice);
                CbxAlmacenSolicita.SelectedIndex = 1;
            }



        }

        private void CargaAlmacenOrigen()
        {
            //dtAlmacen.Rows.Clear();
            CbxAlmacenOrigen.DataSource = null;
            CbxAlmacenOrigen.Items.Clear();
            CbxAlmacenOrigen.AutoCompleteSource = AutoCompleteSource.None;
            CbxAlmacenOrigen.AutoCompleteMode = AutoCompleteMode.None;

            if (sel_OficinaOrigen.K_Oficina== 0)
            {
                dtAlmacenOrigen.Rows.Clear();
            }
            else
            {
                dtAlmacenOrigen = sqlCatalogo.Sk_Almacenes(sel_OficinaOrigen.K_Oficina);
            }

            if (dtAlmacenOrigen != null)
            {
                DataRow dr = dtAlmacenOrigen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "[Seleccionar]";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacenOrigen.Rows.InsertAt(dr, 0);

                dtAlmacenOrigen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacenOrigen, ref CbxAlmacenOrigen, "K_Almacen", "D_Almacen", indice);
                CbxAlmacenOrigen.SelectedIndex = 1;
            }
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();

           
            KArticulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            DArticulo = frm.Descripcion_Seleccionado;
            sKU = frm.Sku;
            DUnidadMedida = frm.Unidad_Medida;

            if (KArticulo != 0)
            {
                btnAgregar.Enabled = true;
                txtCantidad.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            if (txtArticulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("SELECCIONE UN ARTICULO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtArticulo.Focus();
                return;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE LA CANTIDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            int PuntoReOrden = 0;
            dtValida = sQLRecepcion.Gp_Valida_PuntoReOrden(KArticulo, PuntoReOrden, Convert.ToInt32(txtCantidad.Text));

            DataRow row = dtValida.Rows[0];

            PuntoReOrden = Convert.ToInt32(row["Punto_ReOrden"].ToString());

            if (PuntoReOrden < 0)
            {
                MsgBox msgbox = new MsgBox();
                msgbox.Show("LA CANTIDAD DE ARTICULOS NO ESTA DISPONIBLE EN EL INVENTARIO", "ERROR");
                txtCantidad.Focus();
                return;
            }
          
            DataRow dr;
            dr = dtArticulos.NewRow();

            dr["K_Articulo"] = KArticulo;
            dr["Cantidad"] = txtCantidad.Text; 
            dr["D_Articulo"] = DArticulo;
            dr["SKU"] = sKU;
            dr["D_Unidad_Medida"] = DUnidadMedida;
            dr["K_Movimiento_Inventario"] = DBNull.Value;
            dr["Lote"] = DBNull.Value;
            dr["F_Caducidad"] = DBNull.Value;

            dtArticulos.Rows.Add(dr);

            grdDetalle.DataSource = dtArticulos;

            grdDetalle.Columns["Lote"].Visible = false;
            grdDetalle.Columns["K_Movimiento_Inventario"].Visible = false;
            grdDetalle.Columns["F_Caducidad"].Visible = false;

            LimpiaInformacionArticulo();

            btnAgregar.Enabled = false;
            txtCantidad.Enabled = false;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length > 0)
                if (Convert.ToDecimal(txtCantidad.Text.Trim()) > 1000)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                        "EL VALOR MÁXIMO PERMITDO ES DE " + "1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Text = string.Empty;
                }
        }
        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalle.Columns[e.ColumnIndex].Name == "Mas")
            {
                Incrementar(sender, e);

            }
            else if (grdDetalle.Columns[e.ColumnIndex].Name == "Menos")
            {
                Disminuir(sender, e);
            }

        }

        #region FUNCIONES
        private void LimpiaInformacionArticulo()
        {
            KArticulo = 0;
            DArticulo = string.Empty;
            DTipoProducto = string.Empty;
            DUnidadMedida = string.Empty;
            sKU = string.Empty;
           
            txtArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;

            btnAgregar.Enabled = false;
        }

        public void Incrementar(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r => {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + 1;
            });

            grdDetalle.DataSource = dtArticulos;
        }

        public void Disminuir(object sender, DataGridViewCellEventArgs e)
        {
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r => {
                if (dtArticulos.Rows[e.RowIndex] == r)

                    r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) - 1;
                if (int.Parse(r["Cantidad"].ToString()) == 0)
                {
                    dtArticulos.Rows[e.RowIndex].Delete();
                }
            });

            grdDetalle.DataSource = dtArticulos;
        }
        #endregion

     
    }
}
