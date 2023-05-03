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
    public partial class Frm_Filtra_Articulo_Catalogo : Frm_Filtro
    {
        public DataTable dtFiltra = new DataTable();
        public DataTable dtFiltra2 = new DataTable();
        SQLCatalogos sql_catalogo = new SQLCatalogos();

        public Frm_Filtra_Articulo_Catalogo()
        {
            InitializeComponent();        
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dtFiltra!=null)
            {
                if (dtFiltra.Rows.Count > 0)
                {
                    dtFiltra.Rows.Clear();
                }
            }      
            if (txtSKU.Text.Trim() == "")
            {
                txtSKU.Text = null;
            }
            if (txt_D_Articulo.Text.Trim() == "")
            {
                txt_D_Articulo.Text = null;
            }

            if ((ucFamiliaArticulo1.K_Familia_Articulo > 0) || (ucLaboratorio1.K_Laboratorio > 0) || (ucSustanciaActiva1.K_Sustancia_Activa > 0) || txtSKU.Text != null || txt_D_Articulo.Text != null || txtClave.Text != null)
            {

                dtFiltra = sql_catalogo.Sk_Articulos_All(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text,txtClave.Text.Trim().Length==0?0:Convert.ToInt32(txtClave.Text.Trim()));

                if (dtFiltra != null)
                {
                    this.Close();
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

        private void Frm_Filtra_Articulo_Catalogo_Load(object sender, EventArgs e)
        {        
        }

        private void Frm_Filtra_Articulo_Catalogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                BtnBuscar.PerformClick();

            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if(txtClave.Text.Trim().Length>0)
            {
                Int32 valor = 0;
                if(!Int32.TryParse(txtClave.Text.Trim(),out valor))
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Text = string.Empty;
                    txtClave.Focus();
                }
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsNumber(e.KeyChar)) ||(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
