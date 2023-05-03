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

namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    public partial class FRM_ASIGNA_PROV_ART : FormaBase
    {
        ToolStrip Barra;
        ToolStripItem BtnAsignaExcel = new ToolStripMenuItem();

        Funciones fx = new Funciones();
        Int32 _K_Articulo = 0;

        public FRM_ASIGNA_PROV_ART()
        {
            InitializeComponent();
            Barra = BaseBarraHerramientas;

            //Name that will apear on the menu
            BtnAsignaExcel.Text = "Asignación por Excel";
            //Put in the Name property whatever neccessery to retrive your data on click event
            BtnAsignaExcel.Name = "BtnAsignaExcel";
            //On-Click event
            BtnAsignaExcel.Click += new EventHandler(BtnAsignaExcel_Click);
            //Setup
            BtnAsignaExcel.Image = Properties.Resources.multiple_excel;
            BtnAsignaExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            BtnAsignaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BtnAsignaExcel.ToolTipText = "Asignación de Artículos a Proveedor por Excel";
            BtnAsignaExcel.Width = 80;
            BtnAsignaExcel.Height = 35;
            //BtnAsignaExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            //Add the submenu to the parent menu           
            Barra.Items.Add(BtnAsignaExcel);

            txtPrecio.Moneda.TextChanged += new EventHandler(txtPrecio_TextChanged);
            txtPorcentajeDescuento.Moneda.TextChanged += new EventHandler(txtPorcentajeDescuento_TextChanged);
          

        }

        private void FRM_ASIGNA_PROV_ART_Load(object sender, EventArgs e)
        {
            AR_DISPONIBLES.Columns.Add("K_Articulo", typeof(Int32));
            AR_DISPONIBLES.Columns.Add("D_Articulo", typeof(string));
            AR_DISPONIBLES.Columns.Add("SKU", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Familia", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Laboratorio", typeof(string));
            AR_DISPONIBLES.Columns.Add("D_Sustancia_Activa", typeof(string));
   
            AR_ASIGNADOS.Columns.Add("K_Articulo", typeof(int));
            AR_ASIGNADOS.Columns.Add("D_Articulo", typeof(string));
            AR_ASIGNADOS.Columns.Add("Precio_Articulo", typeof(decimal));

            Limpia();     
        }

        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_ASIGNADOS = new DataTable();

        DataTable AR_DISPONIBLESS = new DataTable();
        DataTable AR_ASIGNADOSS = new DataTable();

        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }

        int res = -1, entra = 1, KProveedor = 0;
        string msg = string.Empty;

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecio.Moneda.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(txtPrecio.Moneda.Text.Trim()) > 1000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrecio.Moneda.Text = "0.00";
                    }
                }
                  
            }
            catch
            {

                return;
            }

        }

        private void txtPorcentajeDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPorcentajeDescuento.Moneda.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(txtPorcentajeDescuento.Moneda.Text.Trim()) > 100)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPorcentajeDescuento.Moneda.Text = "0.00";
                    }
                }
                   
            }
            catch
            {

                return;
            }

        }

        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            cambia_fuente_controles();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;

            ucProveedor1.K_Proveedor = KProveedor;
            ucProveedor1.Focus();
        }

        public override void BaseBotonBuscarClick()
        {
            Limpia();

            if (ucProveedor1.K_Proveedor == 0 || ucProveedor1.txt_D_Proveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROVEEDOR..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProveedor1.Focus();
                return;
            }
            if ((_K_Articulo == 0)&&(txtSKU.Text.Trim().Length==0))
            {
                MessageBox.Show("FALTA SELECCIONAR UN ARTÍCULO O CAPTURAR EL SKU..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulo.Focus();
                return;
            }

            if (ucProveedor1.K_Proveedor != 0)
            {
                if (entra == Convert.ToInt32(0))
                {
                    Limpia();
                }
            }
               
            entra = 0;
            Cursor = Cursors.WaitCursor;
            Llena_Disponible();
            Llena_Asignado();
            Cursor = Cursors.Default;

            base.BaseBotonBuscarClick();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;
            int K_Articulo_Disp = 0;
            string D_Articulo_Disp = string.Empty;
            string SKU = string.Empty;
            decimal Precio_Articulo;
            decimal Porcentaje_Descuento;
            DataGridViewRow row = dgvDisponibles.CurrentRow;
            if (row == null)
                return;
            K_Articulo_Disp = Convert.ToInt32(row.Cells["K_ArticuloDisp"].Value);
            D_Articulo_Disp = row.Cells["D_ArticuloDisp"].Value.ToString();
            SKU = row.Cells["SKUDisp"].Value.ToString();
            Precio_Articulo = Convert.ToDecimal(txtPrecio.Moneda.Text.Trim());
            Porcentaje_Descuento = Convert.ToDecimal(txtPorcentajeDescuento.Moneda.Text.Trim());
            if (K_Articulo_Disp != 0)
            {
                res = sql_Catalogos.In_Proveedores_Articulos(K_Articulo_Disp, SKU, ucProveedor1.K_Proveedor, Precio_Articulo,Porcentaje_Descuento, GlobalVar.K_Usuario, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpia();
                    Cursor = Cursors.WaitCursor;
                    Llena_Asignado();
                    Llena_Disponible();
                    Cursor = Cursors.Default;

                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> Elemento = new List<DataGridViewRow>();

            foreach (DataGridViewRow item in dgvAsignados.SelectedRows)
            {
                Elemento.Add(item);
            }

            //DataGridViewRow row = dtCD_Asignadas.CurrentRow;
            //if (row == null)
            //    return;
            foreach (DataGridViewRow row in Elemento)
            {
                Int32 K_ArticuloAsig = 0;
                Int32 K_ProveedorAsig = 0;

                K_ArticuloAsig= Convert.ToInt32(row.Cells["K_ArticuloAsigna"].Value);
                K_ProveedorAsig = ucProveedor1.K_Proveedor;

                if (K_ArticuloAsig != 0)
                {
                    res = sql_Catalogos.DL_Proveedores_Articulos(K_ArticuloAsig,K_ProveedorAsig, ref msg);

                    if (res == -1)
                    {
                        BaseErrorResultado = true;
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Limpia();
            Cursor = Cursors.WaitCursor;
            Llena_Asignado();
            Llena_Disponible();
            Cursor = Cursors.Default;



        }

        private void BtnAsignaExcel_Click(object sender, EventArgs e)
        {
            FRM_EXCEL_ARTICULOS_PROVEEDOR frm = new FRM_EXCEL_ARTICULOS_PROVEEDOR();
            frm.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_FiltraArticuloNombre frm = new FILTROS.Frm_FiltraArticuloNombre();
            frm.ShowDialog();

            _K_Articulo= frm.K_Articulo_Seleccionado;
            txtArticulo.Text =  frm.D_Articulo_Seleccionado;

        }
 
        private void Limpia()
        {
            if (dgvAsignados.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvAsignados.DataSource;
                dt.Clear();
            }
            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dgvDisponibles.DataSource;
                dt2.Clear();
            }
        }

        private void Llena_Disponible()
        {
            String SKU = null;


            if (txtSKU.Text.Trim() == "")
            {
                SKU = null;
            }


            AR_DISPONIBLESS = sql_Catalogos.Gp_Proveedores_ArticulosDis(ucProveedor1.K_Proveedor, SKU, Convert.ToInt32(_K_Articulo), ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa);

            if (AR_DISPONIBLESS != null)
            {

                foreach (DataRow irew in AR_DISPONIBLESS.Rows)
                {
                    
                    DataRow dtdRow2 = AR_DISPONIBLES.NewRow();
                    dtdRow2["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
                    dtdRow2["D_Articulo"] = irew["D_Articulo"].ToString();
                    dtdRow2["SKU"] = irew["SKU"].ToString();
                    dtdRow2["D_Familia"] = irew["D_Familia"].ToString();
                    dtdRow2["D_Laboratorio"] = irew["D_Laboratorio"].ToString();
                    dtdRow2["D_Sustancia_Activa"] = irew["D_Sustancia_Activa"].ToString();
                    AR_DISPONIBLES.Rows.Add(dtdRow2);
                }
                dgvDisponibles.DataSource = AR_DISPONIBLES;
            }
        }

        private void Llena_Asignado()
        {

            AR_ASIGNADOSS = sql_Catalogos.Sk_Proveedores_Articulos(ucProveedor1.K_Proveedor);

            if (AR_ASIGNADOSS != null)
            {
                foreach (DataRow irow in AR_ASIGNADOSS.Rows)
                {
                    DataRow dtdRow = AR_ASIGNADOS.NewRow();
                    dtdRow["K_Articulo"] = Convert.ToInt32(irow["K_Articulo"]);
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["Precio_Articulo"] = Convert.ToDecimal(irow["Precio_Articulo"].ToString());
                    AR_ASIGNADOS.Rows.Add(dtdRow);
                }
                dgvAsignados.DataSource = AR_ASIGNADOS;
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if(dgvDisponibles.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ARTICULOS DISPONIBLES PARA AGREGAR..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulo.Focus();
                return false;
            }
            if (ucProveedor1.K_Proveedor == 0 || ucProveedor1.txt_D_Proveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROVEEDOR..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProveedor1.Focus();
                return false;
            }
            if (txtPrecio.Moneda.Text.Trim().Length ==0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PRECIO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }
            if(Convert.ToDecimal(txtPrecio.Moneda.Text.Trim()) == 0)
            {
                MessageBox.Show("EL PRECIO ASIGNADO DEBE DE SER MAYOR A CERO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }
            if (txtPorcentajeDescuento.Moneda.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL DESCUENTO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPorcentajeDescuento.Focus();
                return false;
            }

            if ((Convert.ToDecimal(txtPorcentajeDescuento.Moneda.Text.Trim()) > 0) && (Convert.ToDecimal(txtPorcentajeDescuento.Moneda.Text.Trim()) >99))
            {
                MessageBox.Show("EL DESCUENTO DEBE DE ESTAR EN UN RANGO DE ENTRE 0.00 Y 99.00 ..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPorcentajeDescuento.Focus();
                return false;
            }
                  
            BaseErrorResultado = false;
            return true;
        }
    }
}
