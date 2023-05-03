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
    public partial class Frm_Inventario_Tarjetas : FormaBase
    {
    
        DataTable dtAlmacen = new DataTable();
        DataTable dtInventarioTarjetas = new DataTable();
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLVentas sql_ventas = new SQLVentas();
        Funciones fx = new Funciones();

        int p_K_Oficina { get; set; }

        int res = 0;
        string msg = string.Empty;
        public Frm_Inventario_Tarjetas()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBarraHerramientas.Visible = false;
            p_K_Oficina = GlobalVar.K_Oficina;
            MtdCargaAlmacen();
            Btn_Consulta.PerformClick();
            panel2.Enabled = false;
            Btn_Aplicar.Enabled = false;
        }

        private void Btn_Entrada_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            Btn_Aplicar.Enabled = true;
            Txt_Inicial.Focus();
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            dtInventarioTarjetas = sql_ventas.Sk_Inventario_Tarjetas(int.Parse(CbxAlmacen.SelectedValue.ToString()));

            if(dtInventarioTarjetas!=null)
            {
                Dgv_Datos.DataSource = dtInventarioTarjetas;
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int k_Tarjeta_Inventario = Convert.ToInt32(this.Dgv_Datos.CurrentRow.Cells["K_Tarjeta_Inventario"].Value.ToString());
            if(this.Dgv_Datos.CurrentRow == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN FOLIO DE TARJETA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            res = sql_ventas.Dl_Inventario_Tarjetas(k_Tarjeta_Inventario, ref msg);
            if (res == -1)
            {

                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("El Folio ["+ this.Dgv_Datos.CurrentRow.Cells["No_Tarjeta"].Value.ToString() + "] fue eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();

            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MtdCargaAlmacen()
        {
            if (p_K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes(p_K_Oficina);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref CbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void Txt_Inicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar))||(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_Final_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_Aplicar_Click(object sender, EventArgs e)
        {
            if (Txt_Inicial.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR FOLIO INICIAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Inicial.Focus();
                return;
            }
            if (Txt_Final.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR FOLIO FINAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Final.Focus();
                return;
            }
            if (int.Parse(CbxAlmacen.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("FALTA CAPTURAR ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Final.Focus();
                return;
            }
            string Folios = this.Txt_Inicial.Text.Trim() + "-" + this.Txt_Final.Text.Trim();
            res = sql_ventas.In_Inventario_Tarjetas(int.Parse(CbxAlmacen.SelectedValue.ToString()), Folios, GlobalVar.K_Usuario, ref msg);

            if (res == -1)
            {

                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("LOS FOLIOS FUERON REGISTRADOS CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();

            }
        }

        private void Txt_Inicial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Inicial.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(Txt_Inicial.Text.Trim()) > Int32.MaxValue)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Inicial.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex){throw;}                  
        }

        private void Txt_Final_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Final.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(Txt_Final.Text.Trim()) > Int32.MaxValue)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Final.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
