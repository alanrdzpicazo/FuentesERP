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

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtro_Articulo : Frm_Filtro
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        DataTable AR_DISPONIBLES = new DataTable();

        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }
        public string Unidad_Medida { get; set; }
        public string Sku { get; set; }
        public decimal Precio { get; set; }
        public int K_Iva_Seleccionado { get; set; }
        public decimal IVA { get; set; }
        public int K_Ieps_Seleccionado{ get; set; }
        public decimal IEPS { get; set; }
        public int P_K_Proveedor { get; set; }

        public Frm_Filtro_Articulo()
        {
            InitializeComponent();
            dgvDisponibles.AutoGenerateColumns = false;
            ucFamiliaArticulo1.PropertyChanged += new PropertyChangedEventHandler(ucFamiliaArticulo1_PropertyChanged);
            ucLaboratorio1.PropertyChanged += new PropertyChangedEventHandler(ucLaboratorio1_PropertyChanged);
            ucSustanciaActiva1.PropertyChanged += new PropertyChangedEventHandler(ucSustanciaActiva1_PropertyChanged);
        }

        private void Frm_Filtro_Articulo_Load(object sender, EventArgs e)
        {
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvDisponibles.DataSource;
                dt.Clear();
            }
            if (txtSKU.Text.Trim() == "")
            {
                txtSKU.Text = null;
            }
            if (txt_D_Articulo.Text.Trim() == "")
            {
                txt_D_Articulo.Text = null;
            }

            if ((ucFamiliaArticulo1.K_Familia_Articulo > 0) || (ucLaboratorio1.K_Laboratorio > 0) || (ucSustanciaActiva1.K_Sustancia_Activa > 0) || txtSKU.Text != null || txt_D_Articulo.Text != null || txtClave.Text.Length > 0)
            {
                if (P_K_Proveedor != 0)
                {
                    AR_DISPONIBLES = sql_Catalogos.Sk_Articulos_Consulta_CPrecio(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text, P_K_Proveedor, txtClave.Text.Trim().Length > 0 ? Convert.ToInt32(txtClave.Text.Trim()) : 0);
                }
                else
                {
                    AR_DISPONIBLES = sql_Catalogos.Sk_Articulos_Consulta_CPrecio(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text, txtClave.Text.Trim().Length > 0 ? Convert.ToInt32(txtClave.Text.Trim()) : 0);
                }

                if (AR_DISPONIBLES != null)
                {
                    if(AR_DISPONIBLES.Rows.Count>0)
                    {
                        dgvDisponibles.DataSource = AR_DISPONIBLES;
                        dgvDisponibles.Focus();
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTEN ARTICULOS CON LOS PARAMETROS INDICADOS ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("NO EXISTEN ARTICULOS CON LOS PARAMETROS INDICADOS ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
        }
        private void dgvDisponibles_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDisponibles.CurrentRow;
            if (row == null)
                return;
            LLave_Seleccionado = (Convert.ToInt32(row.Cells["K_Articulo"].Value));
            Descripcion_Seleccionado = (row.Cells["D_Articulo"].Value.ToString());
            Unidad_Medida = (row.Cells["D_Unidad_Medida"].Value.ToString());
            Sku = (row.Cells["SKU"].Value.ToString());
            Precio = (Convert.ToDecimal(row.Cells["Precio_Unitario"].Value));
            K_Iva_Seleccionado = (Convert.ToInt32(row.Cells["K_Iva"].Value));
            IVA = (Convert.ToDecimal(row.Cells["Porcentaje"].Value));   
            K_Ieps_Seleccionado = (Convert.ToInt32(row.Cells["K_Ieps"].Value));
            IEPS = (Convert.ToDecimal(row.Cells["Porcentaje_Ieps"].Value));
            Close();
        }


        private void Frm_Filtro_Articulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                BtnBuscar.PerformClick();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || ((e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = false; 

                
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    e.Handled = false;
                    BtnBuscar.PerformClick();
                }
                else
                {
                    e.Handled = true;
                }
      
            }
        }
       
        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim().Length > 0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClave.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Text = string.Empty;
                    txtClave.Focus();
                }
            }
        }

        private void dgvDisponibles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                dgvDisponibles.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = dgvDisponibles.CurrentRow;
                if (row == null)
                    return;
                LLave_Seleccionado = (Convert.ToInt32(row.Cells["K_Articulo"].Value));
                Descripcion_Seleccionado = (row.Cells["D_Articulo"].Value.ToString());
                Unidad_Medida = (row.Cells["D_Unidad_Medida"].Value.ToString());
                Sku = (row.Cells["SKU"].Value.ToString());
                Precio = (Convert.ToDecimal(row.Cells["Precio_Unitario"].Value));
                K_Iva_Seleccionado = (Convert.ToInt32(row.Cells["K_Iva"].Value));
                IVA = (Convert.ToDecimal(row.Cells["Porcentaje"].Value));
                K_Ieps_Seleccionado = (Convert.ToInt32(row.Cells["K_Ieps"].Value));
                IEPS = (Convert.ToDecimal(row.Cells["Porcentaje_Ieps"].Value));
                Close();
            }
           
        }

        private void dgvDisponibles_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                SendKeys.Send("{Down}");
            }
        }
        private void ucFamiliaArticulo1_PropertyChanged(object sender, EventArgs e)
        {
            if (ucFamiliaArticulo1.K_Familia_Articulo> 0)
            {
                BtnBuscar.PerformClick();
            }
            else
            {
                if (ucFamiliaArticulo1.K_Familia_Articulo == 0)
                {
                    BtnBuscar.PerformClick();
                    ucFamiliaArticulo1.Focus();
                }
            }
        }
        private void ucLaboratorio1_PropertyChanged(object sender, EventArgs e)
        {
            if (ucLaboratorio1.K_Laboratorio > 0)
            {
                BtnBuscar.PerformClick();
            }
            else
            {
                if (ucLaboratorio1.K_Laboratorio == 0)
                {
                    BtnBuscar.PerformClick();
                    ucLaboratorio1.Focus();
                }
            }
        }
        private void ucSustanciaActiva1_PropertyChanged(object sender, EventArgs e)
        {
            if (ucSustanciaActiva1.K_Sustancia_Activa > 0)
            {
                BtnBuscar.PerformClick();
            }
            else
            {
                if (ucSustanciaActiva1.K_Sustancia_Activa == 0)
                {
                    BtnBuscar.PerformClick();
                    ucSustanciaActiva1.Focus();
                }
            }
        }

        private void txt_D_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnBuscar.PerformClick();
            }
        }

   
    }
    
}
