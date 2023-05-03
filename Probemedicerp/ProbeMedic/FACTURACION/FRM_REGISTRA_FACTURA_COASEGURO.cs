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
using ProbeMedic.AppCode.DCC;

namespace ProbeMedic.FACTURACION
{
    public partial class FRM_REGISTRA_FACTURA_COASEGURO : FormaBase
    {
        int res;
        string msg = string.Empty;

        SQLPedidos sqlPedidos = new SQLPedidos();
        SQLVentas sqlVentas = new SQLVentas();
        SQLCatalogos sqlCatalogos = new SQLCatalogos();

        public DataTable dtDatos = new DataTable();
        public Int32 K_Oficina { get; set; }
        public Int32 K_Cliente_Domicilio_Fiscal { get; set; }
        public Int32 K_Paciente_Direccion { get; set; }
        public DateTime F_Entrega { get; set; }

        DataTable dtAlmacen = new DataTable();

        public FRM_REGISTRA_FACTURA_COASEGURO()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;

            cargaCoaseguro(dtDatos.Rows[0]);
            WindowState = FormWindowState.Normal;
          
        }
        public override void BaseBotonGuardarClick()
        {
            if (ucCanalDistribucionCliente1.K_Canal_Distribucion == 0)
            {
                MessageBox.Show("DEBE CAPTURAR EL CANAL DE DISTRIBUCION!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCanalDistribucionCliente1.Focus();
                BaseBotonGuardar.Visible = true;
                BaseBotonGuardar.Enabled = true;
                BasePropiedadEsRegistroNuevo = false;
                BasePropiedadB_EsCataLogo = false;
                return;
            }
            Int32 CampoIdentity = 0;
            string msg = string.Empty;

            try
            {
                res = 0;
                res = sqlVentas.In_Registro_FacturaCoaseguro(
                    ref CampoIdentity, 
                    K_Oficina, 
                    ucClientes1.K_Cliente,
                    K_Cliente_Domicilio_Fiscal,
                    txtPorcentajeDescuento.Text.Length > 0 ? Convert.ToDecimal(txtPorcentajeDescuento.Text) : Convert.ToDecimal("0.00"),
                    Convert.ToDecimal(txtDescuento.Text.Replace("$","")), 
                    Convert.ToDecimal(txtSubtotal.Text.Replace("$", "")), 
                    Convert.ToDecimal(txtTotalIVA.Text.Replace("$", "")),
                    Convert.ToDecimal(txtTotalFactura.Text.Replace("$", "")), 
                    GlobalVar.K_Usuario,
                    "",
                    GlobalVar.PC_Name,
                    Convert.ToInt32(cbxAlmacen.SelectedValue),
                    ucPacientes1.K_Paciente, 
                    K_Paciente_Direccion,
                    Convert.ToInt32(txtFolio.Text.Trim()), 
                    Convert.ToDecimal(txtbox_coaseguro.Text.Replace("$", "")),
                    Convert.ToDecimal(txt_box_porcentaje_coaseguro.Text.Replace("$", "")),
                    4,
                    ucCanalDistribucionCliente1.K_Canal_Distribucion,
                    F_Entrega,
                    ref msg);
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
                MessageBox.Show("FACTURA GENERADA CORRECTAMENTE CON NUMERO DE FOLIO: " + CampoIdentity.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cargaCoaseguro(DataRow row)
        {
            txtFolio.Text = row["K_Pedido"].ToString() != null ? row["K_Pedido"].ToString() : "";
            ucPacientes1.K_Paciente = row["K_Paciente"].ToString() != null ? Convert.ToInt32(row["K_Paciente"].ToString()) : 0;
            ucPacientes1.txt_Paciente.Text = row["Nombre_Paciente"].ToString() != null ? row["Nombre_Paciente"].ToString() : "";
            K_Cliente_Domicilio_Fiscal = row["K_Cliente_Domicilio_Fiscal"].ToString() != null ? Convert.ToInt32(row["K_Cliente_Domicilio_Fiscal"].ToString()) : 0;
            K_Paciente_Direccion = row["K_Paciente_Direccion"].ToString() != null ? Convert.ToInt32(row["K_Paciente_Direccion"].ToString()) : 0;
            txtRFC.Text = row["RFC"].ToString() != null ? row["RFC"].ToString() : "";
            txtClaveOficina.Text = row["K_Oficina"].ToString() != null ? row["K_Oficina"].ToString() : "";
            K_Oficina = row["K_Oficina"].ToString() != null ? Convert.ToInt32(row["K_Oficina"].ToString()) : 0;
            txtOficina.Text = row["D_Oficina"].ToString() != null ? row["D_Oficina"].ToString() : "";
            cbxAlmacen.SelectedValue = row["K_Almacen"].ToString() != null ? Convert.ToInt32(row["K_Almacen"].ToString()) : 0;
            ucClientes1.K_Cliente = row["K_Cliente"].ToString() != null ? Convert.ToInt32(row["K_Cliente"].ToString()) : 0;
            ucClientes1.txt_Cliente.Text = row["D_Cliente"].ToString() != null ? row["D_Cliente"].ToString() : "";
            txtbox_coaseguro.Text = row["Coaseguro_Pedido"].ToString() != null ? row["Coaseguro_Pedido"].ToString() : "";
            txtbox_coaseguro.Text = TxtImporteToStr(txtbox_coaseguro);
            txt_box_porcentaje_coaseguro.Text = "0.00";
            txtSubtotal.Text = row["Coaseguro_Pedido"].ToString() != null ? row["Coaseguro_Pedido"].ToString() : "";
            txtSubtotal.Text = TxtImporteToStr(txtSubtotal);
            txtTotalIVA.Text = "0.00";
            txtTotalIVA.Text = TxtImporteToStr(txtTotalIVA);      
            txtDescuento.Text = "0.00";
            txtTotalFactura.Text = row["Coaseguro_Pedido"].ToString() != null ? row["Coaseguro_Pedido"].ToString() : "";
            txtTotalFactura.Text = TxtImporteToStr(txtTotalFactura);
            F_Entrega = row["F_Entrega"].ToString() != null ? Convert.ToDateTime(row["F_Entrega"].ToString()) : DateTime.Now;
        }
        private void cargaAlmacen()
        {
            if (Convert.ToInt32(txtClaveOficina.Text.Trim()) == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text.Trim()));
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private string TxtImporteToStr(TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(txtImporte));
            //if (dblImporte == 0)
            //{
            //    return "";
            //}
            //else
            //{
                return dblImporte.ToString("C");
            //}
        }
        private string TxtImporteToDec(TextBox txtImporte)
        {
            //if (txtImporte.Text.Trim().Length == 0)
            //{
            //    return "0";
            //}
            //else
            //{
                return txtImporte.Text.Replace("$", "").Replace(",", "");
            //}
        }

        private void txtClaveOficina_TextChanged(object sender, EventArgs e)
        {
            if(txtClaveOficina.Text.Trim().Length>0)
            {
                cargaAlmacen();
            }
        }


    }
}
