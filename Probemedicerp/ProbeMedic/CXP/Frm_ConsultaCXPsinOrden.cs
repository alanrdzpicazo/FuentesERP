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


namespace ProbeMedic.CXP
{
    public partial class Frm_ConsultaCXPsinOrden : FormaBase
    {
        DataTable dtMotivos = new DataTable();
        SQLCuentasxPagar sQLCXP = new SQLCuentasxPagar();
        public int K_Clave { get; set; }


        public Frm_ConsultaCXPsinOrden()
        {
            InitializeComponent();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
        }

        private void Frm_ConsultaCXPsinOrden_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(K_Clave) != "")
            {

                DataTable dtCXP =   sQLCXP.SK_CxP_SinOrden(K_Clave);
                if ((dtCXP == null) || (dtCXP.Rows.Count == 0))
                {
                    Close();

                }
                else
                {
                    DataRow dr = dtCXP.Rows[0];
                    txtCXP.Text = Convert.ToString(K_Clave);
                    //txtCajaChica.Text = dr["K_Caja_Chica"].ToString();
                    txtClaveProveedor.Text = dr["K_Proveedor"].ToString();
                    txtProveedor.Text = dr["D_Proveedor"].ToString();
                    txtFolio.Text = dr["Folio"].ToString();
                    txtSerie.Text = dr["Serie"].ToString();
                    //txtAlmacen.Text = dr["D_Almacen"].ToString();
                    txtFolioFiscal.Text = dr["FolioFiscal"].ToString();
                    txtFechaFactura.Text = dr["F_Factura"].ToString();
                    txtFechaVencimiento.Text = dr["F_Vencimiento"].ToString();
                    txtTipoMovimiento.Text = dr["D_Tipo_MovCchica"].ToString();
                    txtUsuarioAutoriza.Text = dr["D_Usuario"].ToString();
                    txtSubtotal.Text = dr["Subtotal"].ToString();
                    txtTasaRetencionIVA.Text = dr["TasaRetencion_Iva"].ToString();
                    txtTasaISR.Text = dr["Tasa_ISR"].ToString();
                    txtTotalRetencionIVA.Text = dr["TotalRetencion_IVA"].ToString();
                    txtTotalISR.Text = dr["Total_isr"].ToString();
                    txtTotal.Text = dr["TotalFactura"].ToString();
                    txtTotalIVA.Text = dr["Total_IVA"].ToString();
                    txtTasaRetencionIVA.Text = dr["TasaRetencion_Iva"].ToString();
                    txtFechaIngreso.Text = dr["F_Inserta"].ToString();
                    txtFechaAutorizacion.Text = dr["F_Autorizacion"].ToString();
                    cbxPagada.Checked = Convert.ToBoolean(dr["B_Pagada"].ToString());
                }


            }
        }
    }
}
