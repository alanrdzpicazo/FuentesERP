﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Globalization;
using System.IO;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using InputKey;

namespace ProbeMedic.CXP
{
    public partial class Frm_PagosProveedores : FormaBase
    {
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCuentasxPagar sqlCxP = new SQLCuentasxPagar();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();
        RecepcionBL blRecepcion = new RecepcionBL();
        SQLCompras sqlCompras = new SQLCompras();
       
        DataTable dtProveedores = new DataTable();
        DataTable dtProveedores_Cuentas_Bancarias = new DataTable();
        DataTable dtTipoCambio = new DataTable();
        Funciones fx = new Funciones();
        private int k_Nota_Recepcion;

        bool B_AplicaColores;
        int res = 0;
        string msg = string.Empty;
        bool blnSeleccionGrid = false;
        int K_TipoMoneda = 0;
        decimal TipoCambioGuardar = 0;
    
        public Frm_PagosProveedores()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public override void BaseBotonReporteClick()
        {
            btnReimpresion_Click(btnReimpresion, null);
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            int K_Usuario_Autoriza = 0;

            ////Para incobrable se pide una ventana de login para sacar el usuario autoriza
            //if (rbIncobrable.Checked)
            //{
            //    UsuarioAutoriza frm = new UsuarioAutoriza();
            //    frm.ShowDialog();
            //    if (frm.PropiedadB_EsValido)
            //    {
            //        K_Usuario_Autoriza = frm.PropiedadK_Usuario;
            //    }
            //    else
            //    {
            //        BaseErrorResultado = true;
            //        MessageBox.Show("NO ES POSIBLE GUARDAR, DEBE AUTORIZAR EL MOVIMIENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}

            int CampoIdentity = 0;
            res = 0;
            msg = string.Empty;
            short K_Tipo_Pago = 0;

            if (rbEfectivo.Checked)
                K_Tipo_Pago = 1;
            if (rbCheque.Checked)
                K_Tipo_Pago = 2;
            if (rbTransferencia.Checked)
                K_Tipo_Pago = 3;

            bool B_Dolares = rbDolares.Checked;
            int K_Cuenta_Empresa = 0;
            int K_Cuenta_Proveedor = 0;
            decimal Importe = 0;
            decimal Importe_Cheque = 0;
            decimal Importe_Transferencia = 0;
            decimal Importe_Incobrable = 0;


            if (rbEfectivo.Checked)
            {
                if (txtEfectivoImporte.Text.Trim().Length > 0)
                    Importe = Convert.ToDecimal(TxtImporteToDec(txtEfectivoImporte));
            }
            if (rbCheque.Checked)
            {
                if (txtChequeImporte.Text.Trim().Length > 0)
                    Importe_Cheque = Convert.ToDecimal(TxtImporteToDec(txtChequeImporte));
            }
            if (rbTransferencia.Checked)
            {
                if (txtTransferenciaImporte.Text.Trim().Length > 0)
                    Importe_Transferencia = Convert.ToDecimal(TxtImporteToDec(txtTransferenciaImporte));
            }
            if (rbIncobrable.Checked)
            {
                if (txtIncobrableImporte.Text.Trim().Length > 0)
                    Importe_Incobrable = Convert.ToDecimal(TxtImporteToDec(txtIncobrableImporte));
            }

            if (txtClaveCuentaOrigen.Text.Trim().Length > 0)
                K_Cuenta_Empresa = Convert.ToInt32(txtClaveCuentaOrigen.Text);
            if (txtClaveCuentaDeposito.Text.Trim().Length > 0)
                K_Cuenta_Proveedor = Convert.ToInt32(txtClaveCuentaDeposito.Text);


            grdDatos.EndEdit();

            DataTable dtCxpNoAutorizadas = new DataTable();

            dtCxpNoAutorizadas.Columns.Add("K_Cuenta_Pagar", (typeof(int)));
            dtCxpNoAutorizadas.Columns.Add("Nombre", (typeof(string)));
            dtCxpNoAutorizadas.Columns.Add("Folio_Factura", (typeof(string)));
            dtCxpNoAutorizadas.Columns.Add("TotalFactura", (typeof(decimal)));
            dtCxpNoAutorizadas.Columns.Add("D_Tipo_Moneda", (typeof(string)));
            dtCxpNoAutorizadas.Columns.Add("SaldoAplicado", (typeof(decimal)));
            dtCxpNoAutorizadas.Columns.Add("K_Orden_Compra", (typeof(string)));

            string strCorreosEnviar = "";
            string strTituloCorreo = "";
            string strCuerpoCorreo = "";


            DataTable dtGrid = (DataTable)grdDatos.DataSource;
            DataTable dtDetalle = DetallePagoCxPType;

            foreach (DataRow row in dtGrid.Rows)
            {
                if (Convert.ToDecimal(row["SaldoAplicado"]) != 0)
                {
                    DataRow ren = dtDetalle.NewRow();
                    ren["K_Cuenta_Pagar"] = row["K_Cuenta_Pagar"];
                    ren["Serie"] = row["Serie"];
                    ren["Folio"] = row["Folio"];
                    ren["ImportePagar"] = row["SaldoAplicado"];
                    dtDetalle.Rows.Add(ren);
                }
            }

            foreach (DataGridViewRow grow in grdDatos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grow.Cells["SeleccionaGrid"];
                DataGridViewCheckBoxCell chkAutorizada = (DataGridViewCheckBoxCell)grow.Cells["B_Autorizada"];
                if (Convert.ToDecimal(grow.Cells["SaldoAplicado"].Value) != 0)
                {
                    if ((bool)((chkAutorizada.Value.ToString() == "") ? false : chkAutorizada.Value) == false)
                    {
                        strCorreosEnviar = grow.Cells["CorreosEnviar"].Value.ToString().Replace(";", ",");
                        strTituloCorreo = grow.Cells["TituloCorreo"].Value.ToString();
                        strCuerpoCorreo = grow.Cells["CuerpoCorreo"].Value.ToString();

                        DataRow nRow = dtCxpNoAutorizadas.NewRow();
                        nRow["K_Cuenta_Pagar"] = grow.Cells["K_Cuenta_Pagar"].Value;
                        nRow["Nombre"] = grow.Cells["K_Proveedor"].Value.ToString() + " - " + grow.Cells["Nombre"].Value.ToString();
                        nRow["Folio_Factura"] = grow.Cells["Serie"].Value.ToString() + " " + grow.Cells["Folio"].Value.ToString(); ;
                        nRow["TotalFactura"] = grow.Cells["TotalFactura"].Value;
                        nRow["D_Tipo_Moneda"] = grow.Cells["D_Tipo_Moneda"].Value;
                        nRow["SaldoAplicado"] = grow.Cells["SaldoAplicado"].Value;
                        nRow["K_Orden_Compra"] = grow.Cells["K_Orden_Compra"].Value.ToString().Replace("#", "");

                        dtCxpNoAutorizadas.Rows.Add(nRow);
                    }
                }

            }
            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
                int intConsecutivo = 0;
                res = sqlCxP.Gp_Paga_CxP(ref CampoIdentity, Convert.ToInt32(txtClaveProveedor.Text), K_Tipo_Pago, K_Cuenta_Empresa, K_Cuenta_Proveedor, Importe, Importe_Cheque,
                    txtChequeCuenta.Text, txtChequeNoCheque.Text, Importe_Transferencia, txtTransferenciaCuenta.Text, txtTransferenciaCuenta.Text, txtTransferenciaReferencia.Text, 0, "",
                    Importe_Incobrable, K_Usuario_Autoriza, B_Dolares, TipoCambioGuardar, GlobalVar.K_Usuario, GlobalVar.PC_Name, dtDetalle, ref msg, ref intConsecutivo,
                    Convert.ToInt32(txtK_Anticipo.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtK_Anticipo.Text)));
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    msg = "PAGO GENERADO CORRECTAMENTE CON FOLIO CONSECUTIVO No. " + intConsecutivo.ToString().Trim();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReportePago(intConsecutivo);

                }

                string strOrdenes = "";
                string strNotas = "";
                string Version = string.Empty;

        
                //LuisReyes:  Se desactivan los REPORTES va a ser un REPORTE NUEVO  13Ene2015
                //if (strOrdenes.Trim().Length != 0)
                //{ 

                //    string[] arrOrdenes = strOrdenes.Split(',');

                //    for (int i = 0; i <= arrOrdenes.Length - 1; i++)
                //    {
                //        int K_orden = Convert.ToInt32(arrOrdenes[i].ToString());
                //        if (K_orden > 0)
                //        {
                //            ReporteOrden(K_orden);
                //        }
                //    }
                //}
                //if (strNotas.Trim().Length != 0)
                //    { 
                //    string[] arNotas = strNotas.Split(',');

                //    for (int i = 0; i <= arNotas.Length - 1; i++)
                //    {
                //        int K_Nota = Convert.ToInt32(arNotas[i].ToString());
                //        if (K_Nota > 0)
                //        {
                //            ReporteNota(K_Nota);
                //        }
                //    }
                //}

                //if (dtCxpNoAutorizadas.Rows.Count != 0)
                //    {
                //        string CuerpoDetalle;

                //        CuerpoDetalle = "<table  style=\"width:700px; font-family:Verdana; font-size:small;\"> " +
                //                           "<tr><td>" + strCuerpoCorreo + " </td></tr>" +
                //                            "<tr><td><table style=\"width:900px; border:1 solid black;\"><tr style=\"font-weight:bold; background-color:Green; color:White;\">" +
                //                            "<td style=\"width:50px\" >No. CxP</td><td style=\"width:300px\" >Nombre Proveedor</td><td style=\"width:100px\" >" +
                //                            "Folio Facturas</td><td style=\"width:120px\" >Total Factura</td><td style=\"width:120px\" >Tipo Moneda</td><td style=\"width:120px\" >" +
                //                            "Saldo Aplicado</td><td style=\"width:100px\" >Orden Compra</td></tr>";


                //        foreach (DataRow dRow in dtCxpNoAutorizadas.Rows)
                //        {
                //            CuerpoDetalle = CuerpoDetalle + "<tr>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["K_Cuenta_Pagar"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["Nombre"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["Folio_Factura"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["TotalFactura"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["D_Tipo_Moneda"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["SaldoAplicado"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "<td>" + dRow["K_Orden_Compra"] + " </td>";
                //            CuerpoDetalle = CuerpoDetalle + "</tr>";
                //        }

                //        CuerpoDetalle = CuerpoDetalle + "</table></td></tr><tr><td></td></tr></table>";


                //        if (ConfigurationManager.AppSettings["BaseLocal"].ToString().Trim() == "db_Paris")
                //        {
                //            strCorreosEnviar = strCorreosEnviar.Replace("lureyes@eiffel.com.mx", "rodrigo@eiffel.com.mx");
                //        }
                //        string Asunto = "Productos Eiffel, Pago a Proveedores";
                //        string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();
                //        string Cuerpo = fx.CuerpoCorreoHTML(CuerpoDetalle);
                //        string Recursos = "logo";
                //        string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                //        string Adjuntos = "";

                //        fx.EnviaCorreo(CorreoDe, strCorreosEnviar, Asunto, strTituloCorreo, Cuerpo, Adjuntos, Archivos, Recursos, "", false);

                //        MessageBox.Show("Se ha enviado un correo de las cuentas no autorizadas incluidas en este pago.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //                    BaseErrorResultado = false;
                //                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
                BaseBotonCancelarClick();


            }

            //void ReporteOrden(int p_K_OrdenCompra)
            //{           
            //    int K_OrdenCompra = 0;
            //    string Version = string.Empty;

            //    K_OrdenCompra = p_K_OrdenCompra;

            //    DataTable dtReporte = sqlCompras.sps_ReporteOrdenesCompra(K_OrdenCompra);
            //    ReportedtCorreo = dtReporte;
            //    Version = dtReporte.Rows[0]["DocumentoVersion"].ToString();

            //    ReportDocument rpt = new ReportDocument();
            //    rpt = new REPORTES.RPT_OrdenCompra();

            //    ReporteTitulo = "Orden de Compra / Purchase Order";
            //    ReporteModulo = "COMPRAS";

            //    ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            //    ReporteRPT = rpt;

            //    Frm_Reportes frmReporte = new Frm_Reportes();
            //    frmReporte.P_Titulo = ReporteTitulo;
            //    frmReporte.P_ReporteRPT = ReporteRPT;
            //    frmReporte.P_TablaCorreo = ReportedtCorreo;
            //    frmReporte.ShowDialog();

            //}
            //void ReporteNota(int p_K_Nota_Recepcion)
            //{
            //    k_Nota_Recepcion = p_K_Nota_Recepcion;

            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //    IEnumerable<Entities.ReporteNotaReciboDTO> dtReporte = sqlRecepcion.sps_ReporteNotaRecibo(k_Nota_Recepcion);

            //    ReportDocument rpt = new ReportDocument();
            //    rpt = new REPORTES.RPT_NotasRecepcion();

            //    DataTable tblReporteRecepcion = sqlRecepcion.sps_TablaReporteNotaRecibo(k_Nota_Recepcion);
            //    string Version = Version = tblReporteRecepcion.Rows[0]["DocumentoVersion"].ToString();

            //    ReporteTitulo = "Entrada de Almacén";
            //    ReporteModulo = "Inventarios";

            //    ConectaReporte2(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            //    ReporteRPT = rpt;

            //    ReporteTitulo = "Entrada de Almacén";
            //    ReporteModulo = "Inventarios";

            //    Frm_Reportes frmReporteNota = new Frm_Reportes();
            //    frmReporteNota.P_Titulo = ReporteTitulo;
            //    frmReporteNota.P_ReporteRPT = ReporteRPT;
            //    frmReporteNota.P_TablaCorreo = ReportedtCorreo;
            //    frmReporteNota.ShowDialog();
            //}
            //public void ConectaReporte2(ref CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, IEnumerable<object> dtReporte, string TituloReporte, string ModuloReporte, string Version = "")
            //{
            //    string NomFisico = rpt.ToString();
            //    NomFisico = NomFisico.Replace("PARIS.REPORTES.", "");

            //    rpt.SetDataSource(dtReporte);

            //    rpt.SetParameterValue("D_Empresa", Empresa.D_Empresa);
            //    rpt.SetParameterValue("Leyenda", Empresa.Leyenda);
            //    rpt.SetParameterValue("Calle", Empresa.Calle);
            //    rpt.SetParameterValue("Colonia", Empresa.Colonia);
            //    rpt.SetParameterValue("D_Ciudad", Empresa.D_Ciudad);
            //    rpt.SetParameterValue("C_Estado", Empresa.C_Estado);
            //    rpt.SetParameterValue("CodigoPostal", Empresa.CodigoPostal);
            //    rpt.SetParameterValue("Telefono_Fax", Empresa.Telefono_Fax);
            //    rpt.SetParameterValue("Version", Version);

            //    rpt.SetParameterValue("NombreReporte", NomFisico);
            //    rpt.SetParameterValue("TituloReporte", TituloReporte);
            //    rpt.SetParameterValue("Modulo", ModuloReporte);
            //}
        }

        void ReportePago(int p_Consecutivo)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dt = sqlCxP.Gp_RepAplicacionCXP(p_Consecutivo);

            if(dt!=null)
            {
                if(dt.Rows.Count>0)
                {
                    ReportDocument rpt = new ReportDocument();
                    rpt = new CXP.RPT_AplicacionPagoProveedor();

                    ReporteTitulo = "Aplicación de Pago";
                    ReporteModulo = "Cuentas x Pagar";
                    ConectaReporte(ref rpt, dt, ReporteTitulo, ReporteModulo, "", true);
                    ReporteRPT = rpt;

                    Frm_Reportes frmReporte = new Frm_Reportes();
                    frmReporte.P_Titulo = ReporteTitulo;
                    frmReporte.P_ReporteRPT = ReporteRPT;
                    frmReporte.P_TablaCorreo = ReportedtCorreo;
                    frmReporte.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION PARA GENERAR EL REPORTE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROVEEDOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveProveedor.Focus();
                return false;
            }
            if (txtTotalAPagar.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA CUENTA POR PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal Resta = 0;
            if (txtResta.Text.Trim().Length > 0)
                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$","")));
            if (Resta > 0)
            {
                MessageBox.Show("AUN TIENE SALDO DISPONIBLE PARA APLICAR A ALGUNA CUENTA POR PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rbEfectivo.Checked == false)
            {
                if (txtClaveCuentaDeposito.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE DEPOSITO\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA ANTES CREARLA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (txtClaveCuentaOrigen.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE ORIGEN DE LA EMPRESA\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA ANTES CREARLA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtClaveCuentaDeposito.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CUENTA DE DEPOSITO DEL PROVEEDOR\nSI NO APARECE NINGUNA PARA SELECCIONAR DEBERA ANTES CREARLA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMontoAnticipo.Text.Trim().Length > 0)
            {
                if ((Convert.ToDecimal(txtMontoAnticipo.Text)) != (Convert.ToDecimal(txtIncobrableImporte.Text.Replace("$", ""))))
                {
                    MessageBox.Show("EL MONTO DE ANTICIPO DEBE SER IGUAL AL IMPORTE A PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            BaseErrorResultado = false;
            return true;
        }

        private void FormatoGrid()
        {
            grdDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grdDatos.RowHeadersVisible = false;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDatos.AllowUserToAddRows = false;
            grdDatos.AllowUserToDeleteRows = false;
            grdDatos.BorderStyle = BorderStyle.None;

            grdDatos.AllowUserToResizeColumns = true;
            grdDatos.MultiSelect = false;
            
            grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            grdDatos.EnableHeadersVisualStyles = false;
            grdDatos.ScrollBars = ScrollBars.Both;
        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                BaseMetodoLimpiaControles();
                return;
            }
            
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            DataTable dtBusca =  BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);

            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                BaseMetodoLimpiaControles();
                return;
            }
            if(dtBusca!=null)
            {
                if(dtBusca.Rows.Count>0)
                {
                    LlenaDatosProveedor(dtBusca.Rows[0]);
                }
            }
   
            txtClaveCuentaOrigen.Focus();
        }

        private void LlenaDatosProveedor(DataRow ren)
        {
            decimal credito = 0;
            txtClaveProveedor.Text = ren["K_Proveedor"].ToString();
            txtProveedor.Text = ren["D_Proveedor"].ToString();
            //txtTipoProveedor.Text = ren[" "].ToString();
            txtTipoFiscal.Text = ren["D_Tipo_Fiscal"].ToString();
            txtDiasCredito.Text = ren["Dias_Credito"].ToString();
            credito = Convert.ToDecimal(ren["Monto_Credito"]);
            txtLimiteCredito.Text = credito.ToString("C");
            pnlAbajo.Enabled = true;

            Saldos();
            MostrarDatos();
            LlenaCuentasProveedor(Convert.ToInt32(ren["K_Proveedor"]));
            LimpiaControlesFormaPago();
        }

        private void LlenaCuentasProveedor(int K_Proveedor)
        {
            dtProveedores_Cuentas_Bancarias = sqlCatalogos.Sk_proveedores_cuentas_bancarias(K_Proveedor);
            if (dtProveedores_Cuentas_Bancarias != null)
            {
                if (dtProveedores_Cuentas_Bancarias.Rows.Count == 1)
                {
                    txtClaveCuentaDeposito.Text = dtProveedores_Cuentas_Bancarias.Rows[0]["K_Cuenta_Proveedor"].ToString();
                    txtCuentaDeposito.Text = dtProveedores_Cuentas_Bancarias.Rows[0]["CuentaCompleta"].ToString();
                    ActualizaFormaPago(dtProveedores_Cuentas_Bancarias.Rows[0]);
                }
            }
        }

        private void ActualizaFormaPago(DataRow ren)
        {
            bool B_Dolares = Convert.ToBoolean(ren["B_Dolares"]);
            bool B_Transferencia = Convert.ToBoolean(ren["B_Transferencia"]);
            bool B_Cheque = Convert.ToBoolean(ren["B_Cheque"]);
            int K_Banco = Convert.ToInt32(ren["K_Banco"]);
            
            rbTransferencia.Checked = B_Transferencia;
            rbCheque.Checked = B_Cheque;
            rbDolares.Checked = B_Dolares;
            if (B_Transferencia)
            {
                cmbTransferenciaBanco.SelectedValue = K_Banco;
                txtTransferenciaCuenta.Text = ren["Cuenta_Clabe"].ToString();
            }
            if (B_Cheque)
            {
                cmbChequeBanco.SelectedValue = K_Banco;
                txtChequeCuenta.Text = ren["Numero_Cuenta"].ToString();
            }            
        }

        private void SeleccionaCxPGrid(int NoRenglon)
        {
            grdDatos.EndEdit();
            //int CuantosSeleccionados = 0;
            decimal Resta = 0;
            if (txtResta.Text.Trim().Length > 0)                
                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$","")));

            decimal Saldo = 0;
            if (grdDatos.Rows[NoRenglon].Cells["Saldo"].Value != null)
                Saldo = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Saldo"].Value);

            decimal SaldoAplicado = 0;
            if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);


            DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[NoRenglon].Cells["SeleccionaGrid"];
            if (Convert.ToBoolean(checkCell.Value) == true)
            {
                if (Resta == 0 && SaldoAplicado == 0)
                {
                    MessageBox.Show("DEBE CAPTURAR EL IMPORTE A PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkCell.Value = false;
                    return;
                }
                if (Resta > 0 && SaldoAplicado == 0)
                {
                    if (Resta < Saldo) //Abono
                    {
                        DialogResult dlg = MessageBox.Show("EL IMPORTE A PAGAR NO CUBRE EL SALDO PENDIENTE DE LA CXP\n" +"¿DESEA GENERAR UN ABONO PARA LA CXP?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlg == DialogResult.Yes)
                        {
                            grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = Math.Abs(Resta);
                            if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);
                            Resta = 0;
                        }
                        else
                        {
                            checkCell.Value = false;
                            grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = 0;
                            if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);
                            
                        }
                    }
                    else //Pago completo y/o importe a pagar mayor
                    {
                        grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = Saldo;
                        if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                            SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);
                        Resta -= Saldo;                        
                    }
                }
            }
            else
            {
                grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = 0;
                //if (SaldoAplicado > 0)
                //{
                //    Resta += SaldoAplicado;
                //}
            }
            
            //txtResta.Text = Resta.ToString();

            //foreach (DataGridViewRow dr in grdDatos.Rows)
            //{
            //    decimal Saldo = 0;
            //    if (dr.Cells["Saldo"].Value != null)
            //        Saldo = Convert.ToDecimal(dr.Cells["Saldo"].Value);

            //    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dr.Cells["SeleccionaGrid"];
            //    if (Convert.ToBoolean(checkCell.Value) == true)
            //    {
            //        CuantosSeleccionados++;
            //        if(Resta == 0 && Convert.ToDecimal(dr.Cells["SaldoAplicado"].Value) == 0)
            //            checkCell.Value = false;

            //        if (Resta > 0 && Convert.ToDecimal(dr.Cells["SaldoAplicado"].Value) == 0)
            //        {
            //            if (Resta < Saldo)
            //            {

            //            }
            //        }
            //        //MessageBox.Show("entro");
            //    }
            //}

            //if (CuantosSeleccionados > 0 && Resta == 0)
            //{
            //    MessageBox.Show("ANTES DE SELECCIONAR UNA CXP, DEBE CAPTURAR EL IMPORTE A PAGAR...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    return;
            //}

            Calculos();
        }

        private void SeleccionaCxPGridTotal(int NoRenglon, ref TextBox txtImporte)
        {
            grdDatos.EndEdit();
            //int CuantosSeleccionados = 0;
            decimal Resta = 0;
            if (txtResta.Text.Trim().Length > 0)
                Resta = Math.Abs(Convert.ToDecimal(txtResta.Text.Replace("$", "")));

            decimal Saldo = 0;
            if (grdDatos.Rows[NoRenglon].Cells["Saldo"].Value != null)
                Saldo = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["Saldo"].Value);

            decimal SaldoAplicado = 0;
            if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);

            DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[NoRenglon].Cells["SeleccionaGrid"];
            if (Convert.ToBoolean(checkCell.Value) == true)
            {
                //if (Resta == 0 && SaldoAplicado == 0)
                //{
                //    MessageBox.Show("DEBE CAPTURAR EL IMPORTE A PAGAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    checkCell.Value = false;
                //    return;
                //}
                K_TipoMoneda = Convert.ToInt32(grdDatos.Rows[NoRenglon].Cells["K_Tipo_Moneda"].Value);
                txtImporte.Text = TxtImporteToDec(txtImporte);
                //LuisReyes  AQUI AQUI AQUI 
                if (grdDatos.ReadOnly)
                    grdDatos.ReadOnly = false;
                grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].ReadOnly = false;
                grdDatos.Columns["SaldoAplicado"].ReadOnly = false;
                // Fin Correcion 21Junio2015

                grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = Saldo;
                if (grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value != null)
                    SaldoAplicado = Convert.ToDecimal(grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value);

                txtImporte.Text = Convert.ToDouble(Convert.ToDecimal(TxtImporteToDec(txtImporte) )+ Saldo).ToString("C");
                
                Resta += Saldo;                 
            }
            else
            {
                grdDatos.Rows[NoRenglon].Cells["SaldoAplicado"].Value = 0;

                txtImporte.Text = Convert.ToDouble(Convert.ToDecimal(TxtImporteToDec(txtImporte) )- Saldo).ToString("C");

                if (Convert.ToDecimal((TxtImporteToDec(txtImporte))) == 0)
                {
                    txtImporte.Text = "";
                }
                Resta -= Saldo;


                //if (SaldoAplicado > 0)
                //{
                //    Resta += SaldoAplicado;
                //}
            }

            //txtResta.Text = Resta.ToString();

            //foreach (DataGridViewRow dr in grdDatos.Rows)
            //{
            //    decimal Saldo = 0;
            //    if (dr.Cells["Saldo"].Value != null)
            //        Saldo = Convert.ToDecimal(dr.Cells["Saldo"].Value);

            //    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dr.Cells["SeleccionaGrid"];
            //    if (Convert.ToBoolean(checkCell.Value) == true)
            //    {
            //        CuantosSeleccionados++;
            //        if(Resta == 0 && Convert.ToDecimal(dr.Cells["SaldoAplicado"].Value) == 0)
            //            checkCell.Value = false;

            //        if (Resta > 0 && Convert.ToDecimal(dr.Cells["SaldoAplicado"].Value) == 0)
            //        {
            //            if (Resta < Saldo)
            //            {

            //            }
            //        }
            //        //MessageBox.Show("entro");
            //    }
            //}

            //if (CuantosSeleccionados > 0 && Resta == 0)
            //{
            //    MessageBox.Show("ANTES DE SELECCIONAR UNA CXP, DEBE CAPTURAR EL IMPORTE A PAGAR...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    return;
            //}

            Calculos();
            if (rbPesos.Checked == true)
                ObtieneImporteTotalPagar(false);
            if (rbDolares.Checked == true)
                ObtieneImporteTotalPagar(true);
        }
   
        private void MostrarDatos()
        {
            if (blnSeleccionGrid)
            {
                txtEfectivoImporte.Text = "";
                txtChequeImporte.Text = "";
                txtTransferenciaImporte.Text = "";
                txtIncobrableImporte.Text = "";

                txtEfectivoImporte.ReadOnly = false;
                txtChequeImporte.ReadOnly = false;
                txtTransferenciaImporte.ReadOnly = false;
                txtIncobrableImporte.ReadOnly = false;

                blnSeleccionGrid = false;
            }

            grdDatos.DataSource = null;
            if (txtClaveProveedor.Text.Trim().Length == 0)            
                return;
                
            DataTable dtDatos = sqlCxP.Gp_Consulta_Facturas_PtePago(Convert.ToInt32(txtClaveProveedor.Text), chkCxpAutorizadas.Checked);

            if (dtDatos != null)
            {
                grdDatos.DataSource = dtDatos;
                BaseDtDatos = dtDatos;
                //LuisReyes
                BaseDtDatos.Columns["SaldoAplicado"].ReadOnly = false;
                Saldos();
            }
            else
            {
                if (chkCxpAutorizadas.Checked)
                {
                    MessageBox.Show("NO HAY CUENTAS POR PAGAR AUTORIZADAS PARA ESTE PROVEEDOR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiaControlesFormaPago();
                    txtSaldoDolares.Text        = string.Empty;
                    txtSaldoVencerDolares.Text  = string.Empty;
                    txtFacturasDolares.Text     = string.Empty;
                    BtnAnticipado.Text          = string.Empty;
                    txtSaldoVencerPesos.Text    = string.Empty;
                    txtFacturasPesos.Text       = string.Empty;
                    txtTotalAPagar.Text         = string.Empty;
                    txtResta.Text               = string.Empty;
                }
                else
                {
                    MessageBox.Show("NO HAY CUENTAS POR PAGAR REGISTRADAS PARA ESTE PROVEEDOR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiaControlesFormaPago();
                    txtSaldoDolares.Text        = string.Empty;
                    txtSaldoVencerDolares.Text  = string.Empty;
                    txtFacturasDolares.Text     = string.Empty;
                    BtnAnticipado.Text          = string.Empty;
                    txtSaldoVencerPesos.Text    = string.Empty;
                    txtFacturasPesos.Text       = string.Empty;
                    txtTotalAPagar.Text         = string.Empty;
                    txtResta.Text               = string.Empty;
                }
            }
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonExcel.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;
            
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = true;

            grdDatos.AutoGenerateColumns = false;
            FormatoGrid();

            DataTable dtFolio = sqlCxP.Sk_ObtieneUltimoFolioPagosCxP();
            if (dtFolio != null)
            {
                if (dtFolio.Rows.Count > 0)
                {
                    txtUltimoFolio.Text = dtFolio.Rows[0]["Consecutivo"].ToString();
                }
            }

            dtProveedores = sqlCatalogos.Sk_Proveedores();
            //FiltraTiposPagos();

            DataTable dtBancosCh = sqlCatalogos.Sk_Bancos();
            if (dtBancosCh != null)
            {
                DataRow dr = dtBancosCh.NewRow();

                dr["K_Banco"] = 0;
                dr["D_Banco"] = "";
                dr["C_Banco"] = "";

                dtBancosCh.Rows.InsertAt(dr, 0);
                dtBancosCh.AcceptChanges();

                int indice = -1;
                indice = 0;

                LlenaCombo(dtBancosCh, ref cmbChequeBanco, "K_Banco", "D_Banco", 0);
                cmbChequeBanco.SelectedValue = 0;
     
            }

            DataTable dtBancosT = sqlCatalogos.Sk_Bancos();
            if (dtBancosT != null)
            {
                DataRow dr = dtBancosT.NewRow();

                dr["K_Banco"] = 0;
                dr["D_Banco"] = "";
                dr["C_Banco"] = "";

                dtBancosT.Rows.InsertAt(dr, 0);
                dtBancosT.AcceptChanges();

                int indice = -1;
                indice = 0;

                LlenaCombo(dtBancosT, ref cmbTransferenciaBanco, "K_Banco", "D_Banco", 0);
                cmbTransferenciaBanco.SelectedValue = 0;
            }

            pnlArriba.Enabled = false;
            txtClaveProveedor.Focus();
            base.BaseMetodoInicio();

            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = true;
        }

        private void FiltraTiposPagos()
        {
            //DataTable dtTipos = sqlCxP.sps_Tipos_Pago();
            //var Tipos = dtTipos.AsEnumerable().Where(p => p.Field<bool>("B_Aplica_CxP") == true);
            //if (Tipos.Any())
            //{
            //    LlenaCombo(Tipos.CopyToDataTable(), ref cmbTipoPago, "K_Tipo_Pago", "D_Tipo_Pago");
            //}
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtTipoFiscal.Text = string.Empty;
            BtnAnticipado.Text = string.Empty;
            txtSaldoVencerPesos.Text = string.Empty;
            txtSaldoDolares.Text = string.Empty;
            txtSaldoVencerDolares.Text = string.Empty;
            txtDiasCredito.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            txtTipoFiscal.Text = string.Empty;
            txtTipoProveedor.Text = string.Empty;
            txtFacturasPesos.Text = string.Empty;
            txtFacturasDolares.Text = string.Empty;
            
            rbEfectivo.Checked = true;
            rbTransferencia.Checked = false;
            rbCheque.Checked = false;
            rbIncobrable.Checked = false;
            pnlAbajo.Enabled = false;

            txtClaveCuentaOrigen.Text = string.Empty;
            txtCuentaOrigen.Text = string.Empty;
            txtClaveCuentaDeposito.Text = string.Empty;
            txtCuentaDeposito.Text = string.Empty;

            LimpiaControlesFormaPago();
            

            grdDatos.DataSource = null;
        }

        private void LimpiaControlesFormaPago()
        {
            txtTotalAPagar.Text = string.Empty;
            txtResta.Text = string.Empty;

            txtEfectivoImporte.Text = string.Empty;
            cmbChequeBanco.SelectedIndex = -1;
            txtChequeCuenta.Text = string.Empty;
            txtChequeNoCheque.Text = string.Empty;
            txtChequeImporte.Text = string.Empty;

            cmbTransferenciaBanco.SelectedIndex = -1;
            txtTransferenciaCuenta.Text = string.Empty;
            txtTransferenciaNoTransferencia.Text = string.Empty;
            txtTransferenciaReferencia.Text = string.Empty;
            txtTransferenciaImporte.Text = string.Empty;
            txtIncobrableImporte.Text = string.Empty;

            rbPesos.Checked = true;
            rbDolares.Checked = false;

            K_TipoMoneda = 0;
            txtTipoCambio.Text = string.Empty;
            txtPagoTotalTipoMoneda.Text = string.Empty;
            txtTipoCambio2.Text = string.Empty;
            txtPagoTotalTipoMoneda2.Text = string.Empty;
            txtTipoCambio3.Text = string.Empty;
            txtPagoTotalTipoMoneda3.Text = string.Empty;
            txtMontoAnticipo.Text = string.Empty;
        }

        public override void BaseBotonCancelarClick()
        {
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseMetodoLimpiaControles();
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = false;
            BasePropiedadId_Identity = 0;
            pnlAbajo.Enabled = false;
            pnlArriba.Enabled = false;
        }

        public override void BaseBotonNuevoClick()
        {            
            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;
            pnlArriba.Enabled = true;
            chkCxpAutorizadas.Checked = true;
            txtClaveProveedor.Focus();         
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                LlenaDatosProveedor(frm.BusquedaPropiedadReglonRes);                
            }
        }

        private void Saldos()
        {
            BtnAnticipado.Text      = string.Empty;
            txtSaldoVencerPesos.Text = string.Empty;
            txtFacturasPesos.Text   = string.Empty;
            txtSaldoDolares.Text    = string.Empty;
            txtSaldoVencerDolares.Text = string.Empty;
            txtFacturasDolares.Text = string.Empty;
            if (txtClaveProveedor.Text.Trim().Length == 0)
                return;

            DataTable dtSaldos = sQLCatalogos.Sk_Proveedores(Convert.ToInt32(txtClaveProveedor.Text) );
            if (dtSaldos != null)
            {
                if (dtSaldos.Rows.Count > 0)
                {
                    if (dtSaldos.Rows[0]["SaldoPesos"] != null)
                    {
                        if (dtSaldos.Rows[0]["SaldoPesos"].ToString().Trim().Length > 0)
                        {
                            Decimal saldoPesos = Convert.ToDecimal(dtSaldos.Rows[0]["SaldoPesos"]);
                            BtnAnticipado.Text = saldoPesos.ToString("C");
                        }
                    }
                    if (dtSaldos.Rows[0]["SaldoVencerPesos"] != null)
                    {
                        if (dtSaldos.Rows[0]["SaldoVencerPesos"].ToString().Trim().Length > 0)
                        {
                            Decimal saldoPesos = Convert.ToDecimal(dtSaldos.Rows[0]["SaldoVencerPesos"]);
                            txtSaldoVencerPesos.Text = saldoPesos.ToString("C");
                        }
                    }
                    if (dtSaldos.Rows[0]["FacturasPesos"] != null)
                    {
                        if (dtSaldos.Rows[0]["FacturasPesos"].ToString().Trim().Length > 0)
                        {
                            int facturasPesos = Convert.ToInt32(dtSaldos.Rows[0]["FacturasPesos"]);
                            txtFacturasPesos.Text = facturasPesos.ToString();
                        }
                    }


                    if (dtSaldos.Rows[0]["SaldoDolares"] != null)
                    {
                        if (dtSaldos.Rows[0]["SaldoDolares"].ToString().Trim().Length > 0)
                            txtSaldoDolares.Text = Convert.ToDecimal(dtSaldos.Rows[0]["SaldoDolares"]).ToString("C");
                    }
                    if (dtSaldos.Rows[0]["SaldoVencerDolares"] != null)
                    {
                        if (dtSaldos.Rows[0]["SaldoVencerDolares"].ToString().Trim().Length > 0)
                            txtSaldoVencerDolares.Text = Convert.ToDecimal(dtSaldos.Rows[0]["SaldoVencerDolares"]).ToString("C");
                    }
                    if (dtSaldos.Rows[0]["FacturasDolares"] != null)
                    {
                        if (dtSaldos.Rows[0]["FacturasDolares"].ToString().Trim().Length > 0)
                        {
                            int facturasDolares = Convert.ToInt32(dtSaldos.Rows[0]["FacturasDolares"]);
                            txtFacturasDolares.Text = facturasDolares.ToString();
                        }
                    }
                }
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Para revisar el EVENTO de CLICK de una COLUMNA  LuisReyes
            //if (grdDatos.Columns[e.ColumnIndex].Name == "SeleccionaGrid")
            //{
            //    grdDatos.EndEdit();
            //     Se toma la fila seleccionada
            //    DataGridViewRow row = grdDatos.Rows[e.RowIndex];

            //     Se selecciona la celda del checkbox
            //    DataGridViewCheckBoxCell cellSelecion = row.Cells["SeleccionaGrid"] as DataGridViewCheckBoxCell;

            //    if (Convert.ToBoolean(cellSelecion.Value))
            //    {
            //        string mensaje = string.Format("Evento CellContentClick.\n\nSe ha seccionado, \nCuentaxPagar: '{0}', \nProveedor: '{1}', \nTotalFactura: '{2}', \nSaldoAplicado: '{3}'",
            //                                            row.Cells["K_Cuenta_Pagar"].Value,
            //                                            row.Cells["Nombre"].Value,
            //                                            row.Cells["TotalFactura"].Value,
            //                                            row.Cells["SaldoAplicado"].Value);
            //        MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        string mensaje = string.Format("Evento CellContentClick.\n\nSe ha quitado la seleccion, \nCuentaxPagar: '{0}', \nProveedor: '{1}', \nTotalFactura: '{2}', \nSaldoAplicado: '{3}'",
            //                                            row.Cells["K_Cuenta_Pagar"].Value,
            //                                            row.Cells["Nombre"].Value,
            //                                            row.Cells["TotalFactura"].Value,
            //                                            row.Cells["SaldoAplicado"].Value);
            //        MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            if (e.ColumnIndex == 0)
            {
                TextBox txtImporte ;
                txtImporte = null;

                if (rbEfectivo.Checked)
                    txtImporte = txtEfectivoImporte;
                if (rbCheque.Checked)
                    txtImporte = txtChequeImporte;
                if (rbTransferencia.Checked)
                    txtImporte = txtTransferenciaImporte;
                if (rbIncobrable.Checked)
                    txtImporte = txtIncobrableImporte;

                if (txtImporte.Text.Trim().Length == 0 && blnSeleccionGrid == false)
                {
                    blnSeleccionGrid = true;
                    txtImporte.ReadOnly = true;
                }
               
                if (blnSeleccionGrid)
                {
                    SeleccionaCxPGridTotal(e.RowIndex, ref txtImporte);

                    bool blnSeleccion = false;
                    DataTable dtGrid = (DataTable)grdDatos.DataSource;
                    DataTable dtDetalle = DetallePagoCxPType;
                    foreach (DataRow row in dtGrid.Rows)
                    {
                        if (Convert.ToDecimal(row["SaldoAplicado"]) != 0)
                        {
                            blnSeleccion = true;    
                        }
                    }
                    if (blnSeleccion == false)
                    {
                        txtImporte.ReadOnly = false;
                        blnSeleccionGrid = false;
                    }
                }
                else
                {
                    SeleccionaCxPGrid(e.RowIndex);
                }
            }
        }

        private bool Calculos()
        {
            bool res = false;
            decimal Importe = 0;
            decimal Resta = 0;

            if (rbEfectivo.Checked)
            {
                if (txtEfectivoImporte.Text.Trim().Length > 0)
                    Importe = Convert.ToDecimal(TxtImporteToDec(txtEfectivoImporte));
            }
            if (rbCheque.Checked)
            {
                if (txtChequeImporte.Text.Trim().Length > 0)
                    Importe = Convert.ToDecimal(TxtImporteToDec(txtChequeImporte));
            }
            if (rbTransferencia.Checked)
            {
                if (txtTransferenciaImporte.Text.Trim().Length > 0)
                    Importe = Convert.ToDecimal(TxtImporteToDec(txtTransferenciaImporte));
            }
            if (rbIncobrable.Checked)
            {
                if (txtIncobrableImporte.Text.Trim().Length > 0)
                    Importe = Convert.ToDecimal(TxtImporteToDec(txtIncobrableImporte));
            }

            //if (txtResta.Text.Trim().Length > 0)
            //    Resta = Math.Abs(Convert.ToDecimal(txtResta.Text));

            //ciclo para sumar los saldos aplicados
            decimal sdos = 0;
            DataTable dtSuma = (DataTable)grdDatos.DataSource;
            if (dtSuma != null)
            {
                var Saldos = dtSuma.AsEnumerable().Sum(p => p.Field<decimal>("SaldoAplicado"));
                sdos = decimal.Round(Convert.ToDecimal(Saldos), 2);
            }

            Resta = Importe - sdos;
            txtResta.Text = Resta.ToString("C");
            txtTotalAPagar.Text = sdos.ToString("C");

            return res;
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                pnlEfectivo.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = true;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = false;
                LimpiaControlesFormaPago();
                MostrarDatos();
                if (rbPesos.Checked == true)
                    ObtieneImporteTotalPagar(false);
                if (rbDolares.Checked == true)
                    ObtieneImporteTotalPagar(true);
                txtEfectivoImporte.Focus();
            }
        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheque.Checked)
            {
                pnlCheque.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = true;
                pnlTransferencia.Visible = false;
                pnlIncobrable.Visible = false;
                LimpiaControlesFormaPago();
                MostrarDatos();
                if (rbPesos.Checked == true)
                    ObtieneImporteTotalPagar(false);
                if (rbDolares.Checked == true)
                    ObtieneImporteTotalPagar(true);
                cmbChequeBanco.Focus();
            }
        }

        private void rbTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransferencia.Checked)
            {
                pnlTransferencia.Dock = DockStyle.Fill;
                pnlEfectivo.Visible = false;
                pnlCheque.Visible = false;
                pnlTransferencia.Visible = true;
                pnlIncobrable.Visible = false;
                LimpiaControlesFormaPago();
                MostrarDatos();
                if (rbPesos.Checked == true)
                    ObtieneImporteTotalPagar(false);
                if (rbDolares.Checked == true)
                    ObtieneImporteTotalPagar(true);
                cmbTransferenciaBanco.Focus();
            }
        }

        private void grdDatos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
//            DataGridViewRow row = grdDatos.Rows[e.RowIndex];
//            DataGridViewRow ren = grdDatos.CurrentRow;
//            int indice = ren.Index;

//            if (Convert.ToBoolean(row.Cells["B_Vencida"].Value) == true)
//            {
//                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 50, 0);   
//                row.DefaultCellStyle.SelectionForeColor = Color.White;
//                row.DefaultCellStyle.BackColor = Color.White;
//                row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 50, 0);             
//            }

//            if (Convert.ToBoolean(row.Cells["B_PorVencer"].Value) == true)
//            {
////                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 45);   
//                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(115, 50, 160);
//                row.DefaultCellStyle.SelectionForeColor = Color.White;
//                row.DefaultCellStyle.BackColor = Color.White;
////                row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 45);
//                row.DefaultCellStyle.ForeColor = Color.FromArgb(115, 50, 160);
//            }

//            row.Cells["SaldoAplicado"].Style.BackColor = Color.Green;
//            row.Cells["SaldoAplicado"].Style.ForeColor = Color.White;
        }

        private void rbIncobrable_CheckedChanged(object sender, EventArgs e)
        {
            pnlIncobrable.Dock = DockStyle.Fill;
            pnlEfectivo.Visible = false;
            pnlCheque.Visible = false;
            pnlTransferencia.Visible = false;
            pnlIncobrable.Visible = true;
            LimpiaControlesFormaPago();
            MostrarDatos();
        }

        private void txtEfectivoImporte_Leave(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = string.Empty;
            txtResta.Text = string.Empty;
            MostrarDatos();
            Calculos();
            txtEfectivoImporte.Text = TxtImporteToStr(txtEfectivoImporte);
        }

        private void txtChequeImporte_Leave(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = string.Empty;
            txtResta.Text = string.Empty;
            MostrarDatos();
            Calculos();
            txtChequeImporte.Text = TxtImporteToStr(txtChequeImporte);
        }

        private void txtTransferenciaImporte_Leave(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = string.Empty;
            txtResta.Text = string.Empty;
            MostrarDatos();
            Calculos();
            txtTransferenciaImporte.Text = TxtImporteToStr(txtTransferenciaImporte);
        }

        private void txtIncobrableImporte_Leave(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = string.Empty;
            txtResta.Text = string.Empty;
            MostrarDatos();
            Calculos();
            txtIncobrableImporte.Text = TxtImporteToStr(txtIncobrableImporte);           
        }

        private void btnBuscaCuentaDeposito_Click(object sender, EventArgs e)
        {
            if (txtClaveProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR ANTES UN PROVEEDOR...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtClaveProveedor.Focus();
                return;
            }
            DataTable dtProveedores_Cuentas_Bancarias = sqlCatalogos.Sk_proveedores_cuentas_bancarias(Convert.ToInt32(txtClaveProveedor.Text));

            Busquedas.BuscaProveedorCuentas frm = new Busquedas.BuscaProveedorCuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores_Cuentas_Bancarias);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores_Cuentas_Bancarias;
            frm.BusquedaPropiedadTitulo = "Busca Cuentas del Proveedor";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Proveedor"].ToString();
                txtCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
                ActualizaFormaPago(frm.BusquedaPropiedadReglonRes);
            }

        }

        private void txtClaveCuentaOrigen_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtEmpresa_Cuentas, "K_Cuenta_Empresa", "CuentaCompleta", ref txtClaveCuentaOrigen, ref txtCuentaOrigen);            
        }

        private void txtClaveCuentaDeposito_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(dtProveedores_Cuentas_Bancarias, "K_Cuenta_Proveedor", "CuentaCompleta", ref txtClaveCuentaDeposito, ref txtCuentaDeposito);                           
        }

        private void btnBuscaCuentaOrigen_Click(object sender, EventArgs e)
        {
            DataTable dtCuentas = sqlCatalogos.Sk_Empresa_Cuentas(GlobalVar.K_Empresa);

            Busquedas.BuscaEmpresa_Cuentas frm = new Busquedas.BuscaEmpresa_Cuentas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentas);
            frm.BusquedaPropiedadTablaFiltra = dtCuentas;
            frm.BusquedaPropiedadTitulo = "Busca Cuentas de la Empresa";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Empresa"].ToString();
                txtCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
            }
        }

        private void chkCxpAutorizadas_CheckedChanged(object sender, EventArgs e)
        {     
            MostrarDatos();
            Calculos();
        }

        private string TxtImporteToStr(TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(txtImporte));
            if (dblImporte == 0)
            {
                return "";
            }
            else
            {
                return dblImporte.ToString("C");
            }                        
        }

        private string TxtImporteToDec(TextBox txtImporte)
        {
            if (txtImporte.Text.Trim().Length == 0)
            {
                return "0";
            }
            else
            {
                return txtImporte.Text.Replace("$", "").Replace(",", "");
            }            
        }

        private void ObtieneImporteTotalPagar(bool bolTipoPago)
        { // PESOS:    bolTipoPago = false
          // DOLARES:  bolTipoPago = true
            double ValorCalculado = 0;
            double ImportePagoObtenido = 0;
            string TipoCambio = string.Empty;
            string toConvert = string.Empty;
            //dtTipoCambio = sqlCatalogos.Sk_Tipo_Cambio();
            int TipoPagoSeleccionado = 0;
            if (rbEfectivo.Checked)
            {
                TipoPagoSeleccionado = 1;
                TipoCambio = txtTipoCambio.Text.ToString();
            }
            if (rbCheque.Checked)
            {
                TipoPagoSeleccionado = 2;
                TipoCambio = txtTipoCambio3.Text.ToString();
            }

            if (rbTransferencia.Checked)
            {
                TipoPagoSeleccionado = 3;
                TipoCambio = txtTipoCambio2.Text.ToString();
            }
                
            if (rbIncobrable.Checked)
                TipoPagoSeleccionado = 4;

            // PAGO en PESOS
            if (bolTipoPago == false)
            {
                if (K_TipoMoneda == 1) // Detalle de Pago Seleccionado en DOLARES
                {
                    if (dtTipoCambio.Rows.Count > 0)
                    {
                        if (TipoCambio.ToString().Length <= 2)
                        { TipoCambio = dtTipoCambio.Rows[0]["Tipo_Cambio"].ToString(); }
                        
                        if (TipoCambio != "")
                        {
                            if (Convert.ToDouble(TipoCambio) > 0)
                            {
                                TipoCambioGuardar = Convert.ToDecimal(TipoCambio);
                                if (TipoPagoSeleccionado == 1)  // Tipo de Pago Seleccionado:  EFECTIVO
                                {
                                    lblTotalPagoPesos.Text = "Total a Pagar en Pesos";
                                    txtTipoCambio.Text = TipoCambio;
                                    txtPagoTotalTipoMoneda.Text = "";

                                    toConvert = (txtEfectivoImporte.Text).Replace(",", "");
                                    toConvert = (toConvert).Replace("$", "");
                                    txtEfectivoImporte.Text = toConvert.ToString();
                                    if (txtEfectivoImporte.Text != "")
                                    {
                                        ImportePagoObtenido = Convert.ToDouble(txtEfectivoImporte.Text.ToString());
                                        if (Convert.ToDouble(txtEfectivoImporte.Text) > 0)
                                        {
                                            ValorCalculado = Convert.ToDouble(txtEfectivoImporte.Text) * Convert.ToDouble(TipoCambio);
                                            txtPagoTotalTipoMoneda.Text = ValorCalculado.ToString("C");
                                            txtEfectivoImporte.Text = ImportePagoObtenido.ToString("C");
                                        }
                                    }
                                }
                                if (TipoPagoSeleccionado == 2)  // Tipo de Pago Seleccionado:  CHEQUE
                                {
                                    lblTotalPagoPesos3.Text = "Total a Pagar en Pesos";
                                    txtTipoCambio3.Text = TipoCambio;
                                    txtPagoTotalTipoMoneda3.Text = "";

                                    toConvert = (txtChequeImporte.Text).Replace(",", "");
                                    toConvert = (toConvert).Replace("$", "");
                                    txtChequeImporte.Text = toConvert.ToString();
                                    if (txtChequeImporte.Text != "")
                                    {
                                        ImportePagoObtenido = Convert.ToDouble(txtChequeImporte.Text.ToString());
                                        if (Convert.ToDouble(txtChequeImporte.Text) > 0)
                                        {
                                            ValorCalculado = Convert.ToDouble(txtChequeImporte.Text) * Convert.ToDouble(TipoCambio);
                                            txtPagoTotalTipoMoneda3.Text = ValorCalculado.ToString("C");
                                            txtChequeImporte.Text = ImportePagoObtenido.ToString("C");
                                        }
                                    }
                                }
                                if (TipoPagoSeleccionado == 3)  // Tipo de Pago Seleccionado:  TRANSFERENCIA
                                {
                                    lblTotalPagoPesos2.Text = "Total a Pagar en Pesos";
                                    txtTipoCambio2.Text = TipoCambio;
                                    txtPagoTotalTipoMoneda2.Text = "";

                                    toConvert = (txtTransferenciaImporte.Text).Replace(",", "");
                                    toConvert = (toConvert).Replace("$", "");
                                    txtTransferenciaImporte.Text = toConvert.ToString();
                                    if (txtTransferenciaImporte.Text != "")
                                    {
                                        ImportePagoObtenido = Convert.ToDouble(txtTransferenciaImporte.Text.ToString());
                                        if (Convert.ToDouble(txtTransferenciaImporte.Text) > 0)
                                        {
                                            ValorCalculado = Convert.ToDouble(txtTransferenciaImporte.Text) * Convert.ToDouble(TipoCambio);
                                            txtPagoTotalTipoMoneda2.Text = ValorCalculado.ToString("C");
                                            txtTransferenciaImporte.Text = ImportePagoObtenido.ToString("C");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (K_TipoMoneda == 2) // Detalle de Pago Seleccionado en PESOS
                {
                    if (TipoPagoSeleccionado == 1)
                        txtTipoCambio.Text = "1";
                    if (TipoPagoSeleccionado == 2)
                        txtTipoCambio3.Text = "1";
                    if (TipoPagoSeleccionado == 3)
                        txtTipoCambio2.Text = "1";
                    TipoCambio = "1";
                    TipoCambioGuardar = Convert.ToDecimal(TipoCambio);

                    if (TipoCambio != "")
                    {
                        if (Convert.ToDouble(TipoCambio) > 0)
                        {
                            // Tipo de Pago Seleccionado:  EFECTIVO
                            toConvert = (txtEfectivoImporte.Text).Replace(",", "");
                            toConvert = (toConvert).Replace("$", "");
                            txtEfectivoImporte.Text = toConvert.ToString();
                            if (txtEfectivoImporte.Text != "")
                            {
                                ImportePagoObtenido = Convert.ToDouble(txtEfectivoImporte.Text.ToString());
                                if (Convert.ToDouble(txtEfectivoImporte.Text) > 0)
                                {
                                    ValorCalculado = Convert.ToDouble(txtEfectivoImporte.Text) * Convert.ToDouble(TipoCambio);
                                    txtPagoTotalTipoMoneda.Text = ValorCalculado.ToString("C");
                                    txtEfectivoImporte.Text = ImportePagoObtenido.ToString("C");
                                }
                            }
                            // Tipo de Pago Seleccionado:  CHEQUE
                            toConvert = (txtChequeImporte.Text).Replace(",", "");
                            toConvert = (toConvert).Replace("$", "");
                            txtChequeImporte.Text = toConvert.ToString();
                            if (txtChequeImporte.Text != "")
                            {
                                ImportePagoObtenido = Convert.ToDouble(txtChequeImporte.Text.ToString());
                                if (Convert.ToDouble(txtChequeImporte.Text) > 0)
                                {
                                    ValorCalculado = Convert.ToDouble(txtChequeImporte.Text) * Convert.ToDouble(TipoCambio);
                                    txtPagoTotalTipoMoneda3.Text = ValorCalculado.ToString("C");
                                    txtChequeImporte.Text = ImportePagoObtenido.ToString("C");
                                }
                            }
                            // Tipo de Pago Seleccionado:  TRANSFERENCIA
                            toConvert = (txtTransferenciaImporte.Text).Replace(",", "");
                            toConvert = (toConvert).Replace("$", "");
                            txtTransferenciaImporte.Text = toConvert.ToString();
                            if (txtTransferenciaImporte.Text != "")
                            {
                                ImportePagoObtenido = Convert.ToDouble(txtTransferenciaImporte.Text.ToString());
                                if (Convert.ToDouble(txtTransferenciaImporte.Text) > 0)
                                {
                                    ValorCalculado = Convert.ToDouble(txtTransferenciaImporte.Text) * Convert.ToDouble(TipoCambio);
                                    txtPagoTotalTipoMoneda2.Text = ValorCalculado.ToString("C");
                                    txtTransferenciaImporte.Text = ImportePagoObtenido.ToString("C");
                                }
                            }
                        }
                    }
                }
            }

            // PAGO en DOLARES
            if (bolTipoPago == true)
            {
                if (K_TipoMoneda == 2) // Detalle de Pago Seleccionado en PESOS
                {
                    TipoCambio = "1";
                    txtTipoCambio.Text = "1";
                    TipoCambioGuardar = Convert.ToDecimal(TipoCambio);

                    if (TipoCambio != "")
                    {
                        txtPagoTotalTipoMoneda.Text = "";
                        txtPagoTotalTipoMoneda2.Text = "";
                        txtPagoTotalTipoMoneda3.Text = "";
                    }
                    if (TipoPagoSeleccionado == 1)
                        lblTotalPagoPesos.Text = "Total a Pagar en Dolares";
                    if (TipoPagoSeleccionado == 3)
                        lblTotalPagoPesos2.Text = "Total a Pagar en Dolares";
                    if (TipoPagoSeleccionado == 2)
                        lblTotalPagoPesos3.Text = "Total a Pagar en Dolares";
                    MessageBox.Show("NO ES POSIBLE PAGAR FACTURAS DE DOLARES CON EL TIPO DE MONEDA PESOS ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (K_TipoMoneda == 1) // Detalle de Pago Seleccionado en DOLARES
                {
                    TipoCambio = "1";
                    TipoCambioGuardar = Convert.ToDecimal(TipoCambio);

                    if (TipoCambio != "")
                    {
                        if (Convert.ToDouble(TipoCambio) > 0)
                        {
                            // Tipo de Pago Seleccionado:  EFECTIVO
                            if (TipoPagoSeleccionado == 1)
                            {
                                txtTipoCambio.Text = TipoCambio;
                                lblTotalPagoPesos.Text = "Total a Pagar en Dolares";
                                txtPagoTotalTipoMoneda.Text = "";

                                toConvert = (txtEfectivoImporte.Text).Replace(",", "");
                                toConvert = (toConvert).Replace("$", "");
                                txtEfectivoImporte.Text = toConvert.ToString();
                                if (txtEfectivoImporte.Text != "")
                                {
                                    ImportePagoObtenido = Convert.ToDouble(txtEfectivoImporte.Text.ToString());
                                    if (Convert.ToDouble(txtEfectivoImporte.Text) > 0)
                                    {
                                        ValorCalculado = Convert.ToDouble(txtEfectivoImporte.Text) * Convert.ToDouble(TipoCambio);
                                        txtPagoTotalTipoMoneda.Text = ValorCalculado.ToString("C");
                                        txtEfectivoImporte.Text = ImportePagoObtenido.ToString("C");
                                    }
                                }
                            }
                            // Tipo de Pago Seleccionado:  CHEQUE
                            if (TipoPagoSeleccionado == 2)
                            {
                                txtTipoCambio3.Text = TipoCambio;
                                lblTotalPagoPesos3.Text = "Total a Pagar en Dolares";
                                txtPagoTotalTipoMoneda3.Text = "";

                                toConvert = (txtChequeImporte.Text).Replace(",", "");
                                toConvert = (toConvert).Replace("$", "");
                                txtChequeImporte.Text = toConvert.ToString();
                                if (txtChequeImporte.Text != "")
                                {
                                    ImportePagoObtenido = Convert.ToDouble(txtChequeImporte.Text.ToString());
                                    if (Convert.ToDouble(txtChequeImporte.Text) > 0)
                                    {
                                        ValorCalculado = Convert.ToDouble(txtChequeImporte.Text) * Convert.ToDouble(TipoCambio);
                                        txtPagoTotalTipoMoneda3.Text = ValorCalculado.ToString("C");
                                        txtChequeImporte.Text = ImportePagoObtenido.ToString("C");
                                    }
                                }
                            }
                            // Tipo de Pago Seleccionado:  TRANSFERENCIA
                            if (TipoPagoSeleccionado == 3)
                            {
                                txtTipoCambio2.Text = TipoCambio;
                                lblTotalPagoPesos2.Text = "Total a Pagar en Dolares";
                                txtPagoTotalTipoMoneda2.Text = "";

                                toConvert = (txtTransferenciaImporte.Text).Replace(",", "");
                                toConvert = (toConvert).Replace("$", "");
                                txtTransferenciaImporte.Text = toConvert.ToString();
                                if (txtTransferenciaImporte.Text != "")
                                {
                                    ImportePagoObtenido = Convert.ToDouble(txtTransferenciaImporte.Text.ToString());
                                    if (Convert.ToDouble(txtTransferenciaImporte.Text) > 0)
                                    {
                                        ValorCalculado = Convert.ToDouble(txtTransferenciaImporte.Text) * Convert.ToDouble(TipoCambio);
                                        txtPagoTotalTipoMoneda2.Text = ValorCalculado.ToString("C");
                                        txtTransferenciaImporte.Text = ImportePagoObtenido.ToString("C");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtTipoCambio_Leave(object sender, EventArgs e)
        {
            if (rbPesos.Checked == true)
                ObtieneImporteTotalPagar(false);
            if (rbDolares.Checked == true)
                ObtieneImporteTotalPagar(true);
        }

        private void txtTipoCambio2_Leave(object sender, EventArgs e)
        {
            if (rbPesos.Checked == true)
                ObtieneImporteTotalPagar(false);
            if (rbDolares.Checked == true)
                ObtieneImporteTotalPagar(true);
        }

        private void txtTipoCambio3_Leave(object sender, EventArgs e)
        {
            if (rbPesos.Checked == true)
                ObtieneImporteTotalPagar(false);
            if (rbDolares.Checked == true)
                ObtieneImporteTotalPagar(true);
        }

        private void rbPesos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPesos.Checked == true)
                ObtieneImporteTotalPagar(false);
        }

        private void rbDolares_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDolares.Checked == true)
                ObtieneImporteTotalPagar(true);
        }

        private void btnReimpresion_Click(object sender, EventArgs e)
        {
            string Consecutivo = "0";
            Consecutivo = InputDialog.mostrar("No Consecutivo: ", "Reimprime Reporte Pagos CxP", InputDialog.ACEPTAR_CANCELAR_BOTON, InputDialog.MENSAJE_PREGUNTA);
            Consecutivo = Consecutivo.ToString().Trim();
            if ((Consecutivo != "0") && (Consecutivo != ""))
            {
                try { Convert.ToInt32(Consecutivo); }
                catch
                {
                    MessageBox.Show("El valor indicado no es un número valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                ReportePago(Convert.ToInt32(Consecutivo));
            }
        }

        private void BtnAnticipo_Click(object sender, EventArgs e)
        {
            Frm_MuestraAnticipos frm_x_anticipos = new Frm_MuestraAnticipos();
            frm_x_anticipos.K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);
            frm_x_anticipos.LlenaDatos();
            frm_x_anticipos.ShowDialog();

            if (frm_x_anticipos.K_Anticipo > 0)
            {
                txtK_Anticipo.Text = frm_x_anticipos.K_Anticipo.ToString();
                txtMontoAnticipo.Text = Convert.ToString(frm_x_anticipos.Monto);

            }


        }

        private void txtEfectivoImporte_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 0;
            if(txtEfectivoImporte.Text.Trim().Length>0)
            {
                if (!decimal.TryParse(txtEfectivoImporte.Text.Trim().Replace("$",""), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEfectivoImporte.Text = string.Empty;
                    txtResta.Text = string.Empty;
                    txtTotalAPagar.Text = string.Empty;
                    txtEfectivoImporte.Focus();
                }
            }
           
        }

        private void txtTransferenciaImporte_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (txtTransferenciaImporte.Text.Trim().Length > 0)
            {
                if (!decimal.TryParse(txtTransferenciaImporte.Text.Trim().Replace("$", ""), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransferenciaImporte.Text = string.Empty;
                    txtResta.Text = string.Empty;
                    txtTotalAPagar.Text = string.Empty;
                    txtTransferenciaImporte.Focus();
                }
            }
              
        }

        private void txtChequeImporte_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 0;

            if(txtChequeImporte.Text.Trim().Length>0)
            {
                if (!decimal.TryParse(txtChequeImporte.Text.Trim().Replace("$", ""), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChequeImporte.Text = string.Empty;
                    txtResta.Text = string.Empty;
                    txtTotalAPagar.Text = string.Empty;
                    txtChequeImporte.Focus();
                }
            }
          
        }

        private void txtIncobrableImporte_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 0;

            if(txtIncobrableImporte.Text.Trim().Length>0)
            {
                if (!decimal.TryParse(txtIncobrableImporte.Text.Trim().Replace("$", ""), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIncobrableImporte.Text = string.Empty;
                    txtResta.Text = string.Empty;
                    txtTotalAPagar.Text = string.Empty;
                    txtIncobrableImporte.Focus();
                }
            }
           
        }
    }
}