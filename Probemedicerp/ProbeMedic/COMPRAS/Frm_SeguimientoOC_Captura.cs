using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.IO;


namespace ProbeMedic.COMPRAS
{
    public partial class Frm_SeguimientoOC_Captura : FormaBase
    {
        public int P_K_OrdenCompra { get; set; }
        public string P_D_Oficina {get;set;}
        public string P_Nombre {get;set;}
        public string P_D_Estatus_Compra{get;set;}
        public decimal P_Total {get;set;}
        public string P_D_Tipo_Moneda {get;set;}
        public decimal P_Tipo_Cambio {get;set;}
        public string P_F_OrdenCompra { get; set; }
        public int P_TiempoEntrega {get;set;}

        int res = 0;
        string msg = string.Empty;
        SQLCompras sqlCompras = new SQLCompras();
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        

        public Frm_SeguimientoOC_Captura()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BasePropiedadB_EsCataLogo = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonNuevo.Visible = false;

            Image img2 = Image.FromFile(@Path.Combine(GlobalVar.rutaExe, "Imagenes", "Reload.png"));
            BaseBotonCancelar.Image = img2;
            BaseBotonCancelar.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            BaseBotonCancelar.ToolTipText = "Limpiar Datos de Captura";
            BaseBotonCancelar.Text = "Limpiar";

            DataTable dt1 = sqlCatalogos.Sk_Pais();
            DataTable dt2 = sqlCatalogos.Sk_Pais();

            LlenaCombo(dt1, ref cmbPaisOrigen);
            LlenaCombo(dt2, ref cmbPaisProcedencia);
            
            LlenaEncabezado();            

            txtFechaEmbarque.Focus();
            base.BaseMetodoInicio();
            MuestraDatos();
        }

        private void MuestraDatos()
        {
            DataTable dt = sqlCompras.Sk_Consulta_SeguimientoOrdenesCompra(P_K_OrdenCompra);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow ren = dt.Rows[0];
                    if ((ren["F_EmbarqueConfirmada"] != null) && (ren["F_EmbarqueConfirmada"].ToString().Length > 2))
                        txtFechaEmbarque.Value = Convert.ToDateTime(ren["F_EmbarqueConfirmada"]);
                    if ((ren["F_RealArribo"] != null) && (ren["F_RealArribo"].ToString().Length > 2))
                        txtFechaArribo.Value = Convert.ToDateTime(ren["F_RealArribo"]);
                    if ((ren["F_Pedimento"] != null) && (ren["F_Pedimento"].ToString().Length > 2))
                        txtFechaPedimento.Value = Convert.ToDateTime(ren["F_Pedimento"]);
                    if ((ren["F_PagoPedimento"] != null) && (ren["F_PagoPedimento"].ToString().Length > 2))
                        txtFechaPagoPedimento.Value = Convert.ToDateTime(ren["F_PagoPedimento"]);
                    if (ren["D_Estatus_Orden"] != null)
                        cmbEstatus.Text = ren["D_Estatus_Orden"].ToString();
                    if (ren["Cruce_Importacion"] != null)
                        txtCruceImportacion.Text = ren["Cruce_Importacion"].ToString();
                    if ( (ren["K_Pais_Origen"] != null) && (ren["K_Pais_Origen"].ToString().Length > 0) )
                        cmbPaisOrigen.SelectedValue = Convert.ToInt32(ren["K_Pais_Origen"]);
                    if ( (ren["K_Pais_Procedencia"] != null) && (ren["K_Pais_Procedencia"].ToString().Length > 0) )
                        cmbPaisProcedencia.SelectedValue = Convert.ToInt32(ren["K_Pais_Procedencia"]);
                    if ( (ren["B_ReconocimientoAduanero"] != null) && (ren["B_ReconocimientoAduanero"].ToString().Length > 0) )
                        cbxReconocimientoAduanero.Checked = Convert.ToBoolean(ren["B_ReconocimientoAduanero"]);
                    if ( (ren["B_MuestrasAduana"] != null) && (ren["B_MuestrasAduana"].ToString().Length > 0) )
                        cbxMuestrasAduana.Checked = Convert.ToBoolean(ren["B_MuestrasAduana"]);
                    if ( (ren["B_ActasMuestreo"] != null) && (ren["B_ActasMuestreo"].ToString().Length > 0) )
                        cbxActaMuestreo.Checked = Convert.ToBoolean(ren["B_ActasMuestreo"]);
                    if ( (ren["B_ResolucionSAT"] != null) && (ren["B_ResolucionSAT"].ToString().Length > 0) )
                        cbxResolucionSAT.Checked = Convert.ToBoolean(ren["B_ResolucionSAT"]);
                    if ((ren["Numero_Pedimento"] != null) && (ren["Numero_Pedimento"].ToString().Length > 2))
                    {
                        cbxConPedimento.Checked = true;
                        txtNoPedimento.Text = ren["Numero_Pedimento"].ToString();
                    }
                    if (ren["TipoCambio_Pedimento"] != null)
                        txtTipoCambioPedimento.Text = ren["TipoCambio_Pedimento"].ToString();
                    if (ren["Referencia_Aduanal"] != null)
                        txtReferenciaAduanal.Text = ren["Referencia_Aduanal"].ToString();


                    if (ren["ImporteIVA"] != null)
                        txtGI_ImporteIVA.Text = ren["ImporteIVA"].ToString();
                    if (ren["ImporteFlete"] != null)
                        txtGI_ImporteFlete.Text = ren["ImporteFlete"].ToString();

                    if (ren["OtrosNacional"] != null)
                        txtGI_OtrosNacinal.Text = ren["OtrosNacional"].ToString();
                    if (ren["DTA"] != null)
                        txtGI_DTA.Text = ren["DTA"].ToString();
                    if (ren["IGI"] != null)
                        txtGI_IGI.Text = ren["IGI"].ToString();
                    if (ren["Incrementables"] != null)
                        txtGI_Incrementables.Text = ren["Incrementables"].ToString();
                    if (ren["HonorariosAA"] != null)
                        txtGI_HonorariosAA.Text = ren["HonorariosAA"].ToString();
                    if (ren["Prevalidacion"] != null)
                        txtGI_Prevalidacion.Text = ren["Prevalidacion"].ToString();
                    if (ren["OtrosImportacion"] != null)
                        txtGI_OtrosImportacion.Text = ren["OtrosImportacion"].ToString();
                }
            }
        }

        public override void BaseBotonCancelarClick()
        {
            BaseMetodoLimpiaControles();
            txtFechaEmbarque.Focus();
        }

        private void LlenaEncabezado()
        {
            this.Text = "Captura Seguimiento a Orden de Compra No. " + P_K_OrdenCompra.ToString();            
            lblNoOrden.Text = P_K_OrdenCompra.ToString();
            lblFecha.Text = P_F_OrdenCompra;
            lblTiempoEntrega.Text = P_TiempoEntrega.ToString() + " Dias";
            lblOficina.Text = P_D_Oficina;
            lblNombre.Text = P_Nombre;
            lblTipoMoneda.Text = P_D_Tipo_Moneda;
            lblTipoCambio.Text = P_Tipo_Cambio.ToString();            
            lblEstatus.Text = P_D_Estatus_Compra;
            lblTotal.Text = P_Total.ToString("c");
        }

        public override void BaseMetodoLimpiaControles()
        {
            cbxConPedimento.Checked = false;
            pnlPedimentoCaptura.Enabled = false;
            txtNoPedimento.Text = string.Empty;
            txtFechaPedimento.Text = string.Empty;
            txtFechaPagoPedimento.Text = string.Empty;
            txtTipoCambioPedimento.Text = string.Empty;
            txtReferenciaAduanal.Text = string.Empty;

            txtFechaEmbarque.Text = string.Empty;
            txtFechaArribo.Text = string.Empty;
            cmbEstatus.Text = string.Empty;
            txtCruceImportacion.Text = string.Empty;

            cmbPaisOrigen.SelectedIndex = -1;
            cmbPaisProcedencia.SelectedIndex = -1;

            cbxReconocimientoAduanero.Checked = false;
            cbxMuestrasAduana.Checked = false;
            cbxActaMuestreo.Checked = false;
            cbxResolucionSAT.Checked = false;

            txtGI_ImporteIVA.Text = string.Empty;
            txtGI_ImporteFlete.Text = string.Empty;
            txtGI_OtrosNacinal.Text = string.Empty;
            txtGI_OtrosImportacion.Text = string.Empty;
            txtGI_DTA.Text = string.Empty;
            txtGI_IGI.Text = string.Empty;
            txtGI_Incrementables.Text = string.Empty;
            txtGI_HonorariosAA.Text = string.Empty;
            txtGI_Prevalidacion.Text = string.Empty;

            BaseBotonGuardar.Enabled = true;
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            int CampoIdentity = 0;
            short K_Estatus = 0;
            decimal TipoCambio = 0;
            short K_Pais_Origen = 0;
            short K_Pais_Procedencia = 0;

            if (cmbEstatus.Text == "CONFIRMADA")
                K_Estatus = 8;
            if (cmbEstatus.Text == "NO CONFIRMADA")
                K_Estatus = 9;
            if (cmbEstatus.Text == "EN TRANSITO")
                K_Estatus = 10;

            if(txtTipoCambioPedimento.Text.Trim().Length > 0)
                TipoCambio = Convert.ToDecimal(txtTipoCambioPedimento.Text);

            if(cmbPaisOrigen.SelectedValue != null)
                K_Pais_Origen = Convert.ToInt16(cmbPaisOrigen.SelectedValue);
            if(cmbPaisProcedencia.SelectedValue != null)
                K_Pais_Procedencia = Convert.ToInt16(cmbPaisProcedencia.SelectedValue);
            if (txtGI_ImporteIVA.Text == "")
                txtGI_ImporteIVA.Text = "0";
            if (txtGI_ImporteFlete.Text == "")
                txtGI_ImporteFlete.Text = "0";
            if (txtGI_OtrosNacinal.Text == "")
                txtGI_OtrosNacinal.Text = "0";
            if (txtGI_DTA.Text == "")
                txtGI_DTA.Text = "0";
            if (txtGI_IGI.Text == "")
                txtGI_IGI.Text = "0";
            if (txtGI_Incrementables.Text == "")
                txtGI_Incrementables.Text = "0";
            if (txtGI_HonorariosAA.Text == "")
                txtGI_HonorariosAA.Text = "0";
            if (txtGI_Prevalidacion.Text == "")
                txtGI_Prevalidacion.Text = "0";
            if (txtGI_OtrosImportacion.Text == "")
                txtGI_OtrosImportacion.Text = "0";

            res = sqlCompras.Gp_GuardaSeguimientoOrdenCompra(P_K_OrdenCompra, txtFechaEmbarque.Value, txtFechaArribo.Value, K_Estatus, txtCruceImportacion.Text, txtNoPedimento.Text, txtFechaPedimento.Value, txtFechaPagoPedimento.Value, TipoCambio, cbxReconocimientoAduanero.Checked, cbxMuestrasAduana.Checked, cbxActaMuestreo.Checked, cbxResolucionSAT.Checked, txtReferenciaAduanal.Text, K_Pais_Origen, K_Pais_Procedencia,Convert.ToDecimal(txtGI_ImporteIVA.Text),Convert.ToDecimal(txtGI_ImporteFlete.Text),Convert.ToDecimal(txtGI_OtrosNacinal.Text),Convert.ToDecimal(txtGI_DTA.Text),Convert.ToDecimal(txtGI_IGI.Text),Convert.ToDecimal(txtGI_Incrementables.Text),Convert.ToDecimal(txtGI_HonorariosAA.Text),Convert.ToDecimal(txtGI_Prevalidacion.Text),Convert.ToDecimal(txtGI_OtrosImportacion.Text), GlobalVar.K_Usuario, GlobalVar.PC_Name, ref msg);


            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
                BaseBotonCancelarClick();
                this.Close();
            }          
        }


        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (cmbEstatus.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR ESTATUS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstatus.Focus();
                return false;
            }

            if (cbxConPedimento.Checked)
            {
                if (txtNoPedimento.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR NO. DE PEDIMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoPedimento.Focus();
                    return false;
                }
                if (txtTipoCambioPedimento.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR TIPO DE CAMBIO DE PEDIMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoCambioPedimento.Focus();
                    return false;
                }
                if (txtReferenciaAduanal.Text.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA CAPTURAR REFERENCIA ADUANAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReferenciaAduanal.Focus();
                    return false;
                }     
            }

            BaseErrorResultado = false;
            return true;
        }

        private void cbxConPedimento_CheckedChanged(object sender, EventArgs e)
        {
            txtNoPedimento.Text = string.Empty;
            txtFechaPedimento.Text = string.Empty;
            txtFechaPagoPedimento.Text = string.Empty;
            txtTipoCambioPedimento.Text = string.Empty;
            txtReferenciaAduanal.Text = string.Empty;
            if (cbxConPedimento.Checked)
                pnlPedimentoCaptura.Enabled = true;
            else
                pnlPedimentoCaptura.Enabled = false;

            txtNoPedimento.Focus();
        }
    }
}
