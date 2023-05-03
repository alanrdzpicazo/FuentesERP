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

namespace ProbeMedic.FACTURACION
{
    public partial class FRM_CANCELACION_FACTURA : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        DataTable dtVentas = new DataTable();
        string Detalle_Articulos = string.Empty;
        public FRM_CANCELACION_FACTURA()
        {
            InitializeComponent();
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = true;
            BaseBotonCancelar.Enabled = true;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            grdDetalle.AutoGenerateColumns = false;
        }
        public override void BaseBotonCancelarClick()
        {
            if (dtVentas == null)
            {
                MessageBox.Show("DEBE INDICAR LA FACTURA. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFactura.Focus();
                return;
            }
            //Update 
            string msg = string.Empty;
            int res = 0;
            res = sqlVentas.Gp_Cancela_Factura(Convert.ToInt32(txtFactura.Text.Trim()),ucSeries1.txt_D_Serie.Text.Trim(), ref msg);
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("LA FACTURA SE CANCELÓ CORRECTAMENTE!..", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpia();
            }

        }
        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            //Validar captura de factura 
            //buscar factura si existe y llenar los campo y grid 
            //Aplicar la factura como cancelada liberar remision y marcar como cancelada  
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ucOficinas1.txt_E_Oficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR LA OFICINA DE LA FACTURA!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFactura.Focus();
                return;
            }
            if (txtFactura.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR LA FACTURA!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFactura.Focus();
                return;
            }
            if (ucSeries1.txt_D_Serie.Text.Trim().Length==0)
            {
                MessageBox.Show("DEBE INDICAR LA SERIE!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucSeries1.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            dtVentas = sqlVentas.Gp_Trae_DatosFactura(ucOficinas1.K_Oficina, Convert.ToInt32(txtFactura.Text),ucSeries1.txt_D_Serie.Text);

            if (dtVentas != null)
            {
                if(dtVentas.Rows.Count>0)
                {
                    DataRow dr = dtVentas.Rows[0];
                    ucOficinas1.K_Oficina = Convert.ToInt32(dr["K_Oficina"].ToString());
                    ucOficinas1.txt_E_Oficina.Text = dr["D_Oficina"].ToString();
                    txtK_Almacen.Text = dr["K_Almacen"].ToString();
                    txtD_Almacen.Text = dr["D_Almacen"].ToString();
                    txtK_Cliente.Text = dr["K_Cliente"].ToString();
                    txtD_Cliente.Text = dr["D_Cliente"].ToString();
                    txtD_DomicilioFiscal.Text = dr["DF"].ToString();
                    txtD_CanalDistribucion.Text = dr["D_Canal_Distribucion_Cliente"].ToString();
                    txtObservaciones.Text = dr["Observaciones"].ToString();
                    txtTotalIVA.Text = dr["Total_Iva_Factura"].ToString();
                    txtSubtotal.Text = dr["SubTotal_Factura"].ToString();
                    txtPorcentajeCoaseguro2.Text = dr["PorcentajeCoaseguro"].ToString();
                    txtCoaseguro2.Text = dr["Coaseguro"].ToString();
                    txtTotalFactura.Text = dr["Total_Factura"].ToString();
                    txtDescuento.Text = dr["Descuento"].ToString();
                    grdDetalle.DataSource = dtVentas;
                    BaseBotonCancelar.Visible = true;
                    BaseBotonCancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("LA FACTURA NO EXISTE. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFactura.Focus();
                }
            }
            else
            {
                MessageBox.Show("LA FACTURA NO EXISTE. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFactura.Focus();
            }
            Cursor = Cursors.Default;
        }
        private void Limpia()
        {
            txtFactura.Text = string.Empty;
            ucOficinas1.K_Oficina = 0;
            ucOficinas1.txt_E_Oficina.Text = string.Empty;
            ucSeries1.txt_D_Serie.Text = string.Empty;
            txtK_Almacen.Text = string.Empty;
            txtD_Almacen.Text = string.Empty;
            txtK_Cliente.Text = string.Empty;
            txtD_Cliente.Text = string.Empty;
            txtD_DomicilioFiscal.Text = string.Empty;
            txtD_CanalDistribucion.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            txtTasaIVA.Text = "0.00";
            txtPorcentajeDescuento.Text = "0.00";
            txtSubtotal.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtTotalIVA.Text =  "0.00";
            txtTotalFactura.Text = "0.00";
            txtPorcentajeCoaseguro2.Text = "0.00";
            txtCoaseguro2.Text = "0.00";
            DataTable dt = (DataTable)grdDetalle.DataSource;
            dt.Clear();
        }
        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFactura.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(txtFactura.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!... " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFactura.Text = string.Empty ;
                return;
            }
        }

        private void txtTasaIVA_TextChanged(object sender, EventArgs e)
        {
            if(txtTasaIVA.Text.Trim().Length>0)
            {
                decimal DValor = Convert.ToDecimal(txtTasaIVA.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtTasaIVA.Text = DValor.ToString();
            }
            else
            {
                txtTasaIVA.Text = "0.00";
            }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            if (txtSubtotal.Text.Trim().Length > 0)
            {
                decimal DValor = Convert.ToDecimal(txtSubtotal.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtSubtotal.Text = DValor.ToString();
            }
            else
            {
                txtSubtotal.Text = "0.00";
            }
               
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if(txtDescuento.Text.Trim().Length>0)
            {
                decimal DValor = Convert.ToDecimal(txtDescuento.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtDescuento.Text = DValor.ToString();
            }
            else
            {
                txtDescuento.Text = "0.00";
            }
        }

        private void txtTotalIVA_TextChanged(object sender, EventArgs e)
        {
            if(txtTotalIVA.Text.Trim().Length>0)
            {
                decimal DValor = Convert.ToDecimal(txtTotalIVA.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtTotalIVA.Text = DValor.ToString();
            }
            else
            {
                txtTotalIVA.Text = "0.00";
            }
 
        }

        private void txtTotalFactura_TextChanged(object sender, EventArgs e)
        {
            if(txtTotalFactura.Text.Trim().Length>0)
            {
                decimal DValor = Convert.ToDecimal(txtTotalFactura.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtTotalFactura.Text = DValor.ToString();
            }
            else
            {
                txtTotalFactura.Text = "0.00";
            }
        }

        private void txtPorcentajeCoaseguro2_TextChanged(object sender, EventArgs e)
        {
            if(txtPorcentajeCoaseguro2.Text.Trim().Length>0)
            {
                decimal DValor = Convert.ToDecimal(txtPorcentajeCoaseguro2.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtPorcentajeCoaseguro2.Text = DValor.ToString();
            }
            else
            {
                txtPorcentajeCoaseguro2.Text = "0.00"; 
            }
        }

        private void txtCoaseguro2_TextChanged(object sender, EventArgs e)
        {
            if(txtCoaseguro2.Text.Trim().Length>0)
            {
                decimal DValor = Convert.ToDecimal(txtCoaseguro2.Text.Trim());
                DValor = Math.Round(DValor, 2);
                txtCoaseguro2.Text = DValor.ToString();
            }
            else
            {
                txtCoaseguro2.Text = "0.00";
            }
        }

        private void txtFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }
    }
}
