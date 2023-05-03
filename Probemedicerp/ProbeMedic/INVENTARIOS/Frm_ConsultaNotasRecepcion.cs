using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.INVENTARIOS;
using System.IO;
using ProbeMedic.Entities.Recepcion;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_ConsultaNotasRecepcion : ProbeMedic.FormaConsulta
    {
        SQLCatalogos sqlCatalogoS = new SQLCatalogos();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();
        DataTable dtRequisiciones = new DataTable();
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;

        int K_NotaRecepcion = 0;

        public int filaSelccionada { get; set; }

        public Frm_ConsultaNotasRecepcion()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            doFormatGrid();
            doFormatGridDetalle();
            BaseBotonReporte.Visible = false;
        }

        private void doFormatGrid()
        {
            BaseGrid = grdDatos;
            BaseGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            BaseGrid.RowHeadersVisible = false;
            BaseGrid.BackgroundColor = Color.White;
            BaseGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BaseGrid.AllowUserToAddRows = false;
            BaseGrid.AllowUserToDeleteRows = false;
            BaseGrid.BorderStyle = BorderStyle.None;

            BaseGrid.AllowUserToResizeColumns = true;
            BaseGrid.MultiSelect = false;
            BaseGrid.ReadOnly = true;
            BaseGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both;

            BaseGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            BaseGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BaseGrid.EnableHeadersVisualStyles = false;
        }

        void doFormatGridDetalle()
        {
            grdDetalle.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grdDetalle.RowHeadersVisible = false;
            grdDetalle.BackgroundColor = Color.White;
            grdDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDetalle.AllowUserToAddRows = false;
            grdDetalle.AllowUserToDeleteRows = false;
            grdDetalle.BorderStyle = BorderStyle.None;

            grdDetalle.AllowUserToResizeColumns = true;
            grdDetalle.MultiSelect = false;
            grdDetalle.ReadOnly = true;
            grdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;

            grdDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            grdDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grdDetalle.EnableHeadersVisualStyles = false;
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtNoOrden; //Asignar el textbox que inicia el focus
            txtNoOrden.Focus();
      
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonProceso1.Visible = false;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Enabled = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Enabled = false;
            BaseBotonBuscar.Enabled = true;
            BaseBotonBuscar.Visible = true;

            this.WindowState = FormWindowState.Maximized;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["barcode_scanner_4249.ico"]));
            BaseBotonProceso1.Text = "Consulta de Escaneo";
            BaseBotonProceso1.Width = 130;

            txtFecha1.Value = Fecha1;
            txtFecha2.Value = Fecha2;
   
        }

        public override void BaseBotonBuscarClick()
        {
            int K_Nota_Recepcion = 0;
            int K_OrdenCompra = 0;
            int K_Proveedor = 0;

            Fecha1 = txtFecha1.Value;
            Fecha2 = txtFecha2.Value;            

            if (txtNoOrden.Text.Trim().Length > 0)
                K_OrdenCompra = Convert.ToInt32(txtNoOrden.Text);

            if (!string.IsNullOrWhiteSpace(txtNoRecepcion.Text))
                K_Nota_Recepcion = Convert.ToInt32(txtNoRecepcion.Text);

            if (txtClaveProveedor.Text.Trim().Length > 0)
                K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);

            IEnumerable<ConsultaNotaRecepcionDTO> dt =sqlRecepcion.Sk_ConsNotaRecepcion2(K_Nota_Recepcion, K_OrdenCompra, Fecha1, Fecha2, K_Proveedor);

            grdDatos.AutoGenerateColumns = false;
            grdDatos.DataSource = dt;
            grdDatos.ScrollBars = ScrollBars.Both;

            tabControl1.SelectedTab = tpOrdenes;
            if ((dt != null) && (dt.Count() != 0))
            {
                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = true;
            }
            else
            {
                BaseBotonProceso1.Visible = false;
                BaseBotonProceso1.Visible = false;
            }
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtNoOrden.Text = string.Empty;
            txtNoRecepcion.Text = string.Empty;

            /*
            txtClaveOficina.Text = string.Empty;
            txtOficina.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;

            cmbTipoArticulo.SelectedIndex = -1;
            cmbClasificacion.SelectedIndex = -1;
            */
            txtFecha1.Value = Fecha1;
            txtFecha2.Value = Fecha2;

            grdDatos.DataSource = null;
            grdDatos.AutoGenerateColumns = false;
            tabControl1.SelectedTab = tpOrdenes;

            //dtRequisiciones = sqlRecepcion.sps_Requisicion(5, true, false); //5 = Asignada a una compra
        }
                 
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1) //DEtalle
            {
                grdDetalle.AutoGenerateColumns = false;
                grdDetalle.DataSource = null;
                if (grdDatos.DataSource == null)
                    return;
                if (grdDatos.Rows.Count == 0)
                    return;

                int K_NotaRecepcion = 0;
                int K_Orden = 0;
                DataGridViewRow row = grdDatos.CurrentRow;
                if (row != null)
                    K_NotaRecepcion = Convert.ToInt32(row.Cells["colK_Nota_Recepcion"].Value);
                    K_Orden = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);

                DataTable dtDetalle = sqlRecepcion.Sk_ConsultaNotaRecepcion(K_NotaRecepcion, K_Orden);
                IEnumerable<ConsultaNotaRecepcionDetalleDTO> idtDetalle;
                if (dtDetalle != null)
                {
                    idtDetalle = sqlRecepcion.Sk_ConsultaNotaRecepcion(dtDetalle);
                }
                else
                {
                    idtDetalle = new ConsultaNotaRecepcionDetalleDTO[0];
                }
                if (idtDetalle != null)
                {
                    if (idtDetalle.Count() > 0)
                    {
                        grdDetalle.DataSource = idtDetalle;
                    }
                }
            }
        }

        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Immage button click
            //int rowIndex = e.RowIndex;
            //int colIndex = e.ColumnIndex;
            //if ((rowIndex != -1)
            //    // &&(colIndex == 8)
            //    )
            //{
            //    DataGridView source = (DataGridView)(sender);
            //    ConsultaNotaRecepcionDetalleDTO[] rows = ((IEnumerable<ConsultaNotaRecepcionDetalleDTO>)source.DataSource).ToArray<ConsultaNotaRecepcionDetalleDTO>();
            //    ConsultaNotaRecepcionDetalleDTO detalle = rows[rowIndex];
            //    byte[] imagen = sqlRecepcion.sps_ConsultaNotaRecepcionImagen(detalle.K_Detalle_Nota_Recepcion);
            //    if (imagen.Length != 0)
            //    {
            //        MemoryStream mso = (MemoryStream)ImageService.InsertImageToPdf(imagen);
            //        Frm_ReportesAdobe frmReporte = new Frm_ReportesAdobe();
            //        frmReporte.P_Titulo = "Certificado digitalizado";
            //        frmReporte.P_ReporteRPT = mso;
            //        frmReporte.P_TablaCorreo = ReportedtCorreo;
            //        frmReporte.ShowDialog();
            //    }
            //    /*
            //    // Anterior rutina para mostrar la imagen en pantalla.
            //    if (imagen.Length != 0)
            //    {
            //        FormaImagen frm = new FormaImagen();
            //        frm.Imagen = imagen;
            //        frm.ShowDialog();
            //    }
            //     * */
            //}

        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            //DataTable dtProveedores = sqlCatalogos.sps_Proveedores(true);
            //BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);
        }
     
        private void grdDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = grdDatos.CurrentRow;

            //K_NotaRecepcion = Convert.ToInt32(row.Cells["colK_Nota_Recepcion"].Value);
            //if (K_NotaRecepcion != 0)
            //{
            //    BaseBotonReporte.Visible = false;
            //    BaseBotonEtiqueta.Visible = false;
            //    return;
            //}
            //else
            //{
            //    //DataTable dtDetalle = sqlRecepcion.sps_ConsultaNotaRecepcion(K_NotaRecepcion, 0);
            //    bool bImprimeEtiqueta = false;
            //    //foreach (DataRow rpt in dtDetalle.Rows)
            //    //{
            //    //    bImprimeEtiqueta = bImprimeEtiqueta | (Convert.ToInt32(rpt["K_Clasificacion_Articulo"]) == 10);
            //    //    if (bImprimeEtiqueta)
            //    //        break;
            //    //}

            //    BaseBotonEtiqueta.Visible = bImprimeEtiqueta;
            //    BaseBotonReporte.Visible = true;
            //}

        }

        public override void BaseBotonEtiquetaClick()
        {
//            if (K_NotaRecepcion != 0)
//            {
//                //IEnumerable<Entities.ReporteNotaReciboDTO> dtReporte = sqlRecepcion.sps_ReporteNotaRecibo(K_NotaRecepcion);
//                //base.BaseBotonEtiquetaClick();
//                //IEnumerable<Entities.ReporteEtiquetasRecepcionDTO> dtEtiquetas = sqlRecepcion.sps_ReporteEtiquetas(dtReporte);
//                //IEnumerable<Entities.ReporteEtiquetasQrDTO> dtQr = sqlRecepcion.sps_ReporteEtiquetasQr(dtReporte);
//                //ReportDocument rpt2 = new REPORTES.RPT_Etiquetas();
//                ReporteTitulo = "Etiqueta de Materia Prima";
//                ReporteModulo = "Inventarios";

////                if (dtEtiquetas != null)
////                {
////                    if (dtEtiquetas.Count() > 0)
////                    {
////                        rpt2.SetDataSource(dtEtiquetas);
////                        Application.DoEvents();
//////                        MemoryStream ms = (MemoryStream)rpt2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
////                        System.IO.Stream ms = rpt2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
////                        Application.DoEvents();
////                        string[] etiquetas = EtiquetasQrServices.GetXMLFromLable(dtQr);
////                        if (etiquetas.Length != 0)
////                        {
////                            MemoryStream mso = (MemoryStream)EtiquetasQrServices.InsertQRPdfFile2(ms, etiquetas);

////                            Frm_ReportesAdobe frmReporte = new Frm_ReportesAdobe();
////                            frmReporte.P_Titulo = ReporteTitulo;
////                            frmReporte.P_ReporteRPT = mso;
////                            frmReporte.P_TablaCorreo = ReportedtCorreo;
////                            frmReporte.ShowDialog();
////                        }
////                    }
////                }
//            }

        }

        private void btnBuscaProveedor_Click_1(object sender, EventArgs e)
        {
            DataTable dtProveedores = sqlCatalogos.Sk_Proveedores();
            ProbeMedic.Busquedas.BuscaProveedores frm = new ProbeMedic.Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
            }
        }

        public void ConectaReporte2(ref CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, IEnumerable<object> dtReporte, string TituloReporte, string ModuloReporte, string Version = "")
        {
            // ConnectionInfo miConexionInfo = new ConnectionInfo();
            //string sConexion = System.Configuration.ConfigurationManager.AppSettings["cnERP"].ToString();

            string NomFisico = rpt.ToString();
            NomFisico = NomFisico.Replace("PARIS.REPORTES.", "");

            rpt.SetDataSource(dtReporte);


            rpt.SetParameterValue("D_Empresa", Empresa.D_Empresa);
            rpt.SetParameterValue("Leyenda", Empresa.Leyenda);
            rpt.SetParameterValue("Calle", Empresa.Calle);
            rpt.SetParameterValue("Colonia", Empresa.Colonia);
            rpt.SetParameterValue("D_Ciudad", Empresa.D_Ciudad);
            rpt.SetParameterValue("C_Estado", Empresa.C_Estado);
            rpt.SetParameterValue("CodigoPostal", Empresa.CodigoPostal);
            rpt.SetParameterValue("Telefono_Fax", Empresa.Telefono_Fax);
            rpt.SetParameterValue("Version", Version);

            rpt.SetParameterValue("NombreReporte", NomFisico);
            rpt.SetParameterValue("TituloReporte", TituloReporte);
            rpt.SetParameterValue("Modulo", ModuloReporte);
        }

        public override void BaseBotonProceso1Click()
        {
            if (grdDatos.DataSource != null)
            {
                if(grdDatos.Rows.Count>0)
                {
                    if (grdDatos.CurrentRow != null)
                    {
                        INVENTARIOS.Frm_Consulta_Escaneo_NRecepcion frm = new INVENTARIOS.Frm_Consulta_Escaneo_NRecepcion();
                        frm.PK_Orden_Compra = Convert.ToInt32(grdDatos.Rows[filaSelccionada].Cells[0].Value.ToString());
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR UNA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSelccionada = e.RowIndex;
        }

        private void txtNoRecepcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(EsNumero(e.KeyChar.ToString())|| e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNoOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EsNumero(e.KeyChar.ToString()) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNoRecepcion_TextChanged(object sender, EventArgs e)
        {
            if(txtNoRecepcion.Text.Trim().Length>0)
            if(Convert.ToDecimal(txtNoRecepcion.Text.Trim())> Int32.MaxValue)
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoRecepcion.Text = string.Empty;
            }
        }

        private void txtNoOrden_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOrden.Text.Trim().Length > 0)
                if (Convert.ToDecimal(txtNoOrden.Text.Trim()) > Int32.MaxValue)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoOrden.Text = string.Empty;
                }
        }
    }
}
