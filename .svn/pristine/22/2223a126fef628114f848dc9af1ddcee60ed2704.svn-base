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
using System.IO;


namespace ProbeMedic.COMPRAS
{
    public partial class Frm_SeguimientoOrdenesCompra : FormaConsulta
    {
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        DataTable dtRequisiciones = new DataTable();
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;

        public Frm_SeguimientoOrdenesCompra()
        {            
            BaseGridSinFormato = true;
            InitializeComponent();
            BaseBotonProceso1.Click += new EventHandler(BaseBotonProceso1_Click);
        }

        void BaseBotonProceso1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row != null)
            {
                if (Convert.ToBoolean(row.Cells["B_Cancelada"].Value) == true)
                {
                    MessageBox.Show("NO PUEDE DAR SEGUIMIENTO A ORDENES DE COMPRA CANCELADAS...!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                int K_Orden_Compra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);

                Frm_SeguimientoOC_Captura frm = new Frm_SeguimientoOC_Captura();
                frm.P_K_OrdenCompra = K_Orden_Compra;
                frm.P_D_Oficina = row.Cells["D_Oficina"].Value.ToString();
                frm.P_Nombre = row.Cells["Nombre"].Value.ToString();
                frm.P_D_Estatus_Compra = row.Cells["D_Estatus_Compra"].Value.ToString();
                frm.P_D_Tipo_Moneda = row.Cells["D_Tipo_Moneda"].Value.ToString();
                frm.P_Tipo_Cambio = Convert.ToDecimal(row.Cells["Tipo_Cambio"].Value);
                frm.P_Total = Convert.ToDecimal(row.Cells["Total"].Value);
                frm.P_F_OrdenCompra = row.Cells["F_OrdenCompra"].Value.ToString();
                frm.P_TiempoEntrega = Convert.ToInt32(row.Cells["TiempoEntrega"].Value);
                frm.P_D_Estatus_Compra = row.Cells["D_Estatus_Compra"].Value.ToString();
                
                frm.ShowDialog();

            }


            //Frm_Reclamacion_Documentacion frm = new Frm_Reclamacion_Documentacion();
            //frm.DtDocuemntos = dtDocumentos;
            ////frm.PropiedadK_Producto = Convert.ToInt16(CatalogoPropiedadId_Identity);
            ////frm.PropiedadD_Producto = txtNombreProducto.Text;
            //frm.ShowDialog();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtNoOrden; //Asignar el textbox que inicia el focus

            grdDatos.AutoGenerateColumns = false;
            grdDatosSeguimiento.AutoGenerateColumns = false;

           // Image img = Image.FromFile(@Path.Combine(GlobalVar.rutaExe, "Imagenes", "Seguimiento.png"));
           // BaseBotonProceso1.Image = img;
            BaseBotonProceso1.ImageScaling = ToolStripItemImageScaling.SizeToFit;            
            BaseBotonProceso1.ToolTipText = "Seguimiento de Ordenes de Compra";
            BaseBotonProceso1.Text = "Seguimiento";
            BaseBotonProceso1.Width = 100;
            BaseBotonProceso1.Visible = false;


           // Image img2 = Image.FromFile(@Path.Combine(GlobalVar.rutaExe, "Imagenes", "Reload.png"));
           // BaseBotonCancelar.Image = img2;
            BaseBotonCancelar.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            BaseBotonCancelar.ToolTipText = "Limpiar Datos de Captura";
            BaseBotonCancelar.Text = "Limpiar";


            BaseBotonExcel.Visible = false;

            txtNoOrden.Focus();
            base.BaseMetodoInicio();
            BaseBotonReporte.Visible = false;
        }

        
        public override void BaseBotonBuscarClick()
        {   
            //if (txtNoOrden.Text.Trim().Length == 0 && txtClaveOficina.Text.Trim().Length == 0 && txtClaveProveedor.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR AL MENOS UN FILTRO PARA LA BÚSQUEDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNoOrden.Focus();
            //    return;
            //}

            if (txtFecha1.Value > txtFecha2.Value)
            {
                MessageBox.Show("RANGO DE FECHAS INCORRECTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFecha1.Focus();
                return;
            }


            int K_OrdenCompra = 0;
            int K_Oficina = 0;
            int K_Proveedor = 0;
            

            Fecha1 = txtFecha1.Value;
            Fecha2 = txtFecha2.Value;
            

            if(txtNoOrden.Text.Trim().Length > 0)
                K_OrdenCompra = Convert.ToInt32(txtNoOrden.Text);
            if (txtClaveOficina.Text.Trim().Length > 0)
                K_Oficina = Convert.ToInt32(txtClaveOficina.Text);
            if (txtClaveProveedor.Text.Trim().Length > 0)
                K_Proveedor = Convert.ToInt32(txtClaveProveedor.Text);


            DataTable dt = new DataTable();

            grdDatos.Visible = false;
            grdDatosSeguimiento.Visible = false;
            if(cbxConSeguimiento.Checked)
            {
                dt = sqlCompras.Sk_Consulta_SeguimientoOrdenesCompra(K_OrdenCompra, K_Oficina, K_Proveedor, Fecha1, Fecha2);
                grdDatosSeguimiento.DataSource = dt;
                FormatoGrid(ref grdDatosSeguimiento);
                grdDatosSeguimiento.Visible = true;
                if (dt == null)
                {
                    MessageBox.Show("NO FUE POSIBLE ENCONTRAR DATOS DE SEGUIMIENTO CON LOS PARAMETROS INDICADOS ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                dt = sqlCompras.Sk_ConsultaOrdenesCompra(K_OrdenCompra, K_Oficina, K_Proveedor, Fecha1, Fecha2,false);
                grdDatos.DataSource = dt;
                FormatoGrid(ref grdDatos);
                grdDatos.Visible = true;
                if (dt == null)
                {
                    MessageBox.Show("NO FUE POSIBLE ENCONTRAR DATOS DE ORDENES DE COMPRA CON LOS PARAMETROS INDICADOS ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            BaseDtDatos = dt;            

            BaseBotonExcel.Visible = false;
            BaseBotonProceso1.Visible = false;

            if (dt.Rows.Count > 0)
            {
                if (cbxConSeguimiento.Checked)
                    BaseBotonExcel.Visible = true;

                BaseBotonProceso1.Visible = true;
            }
            else
            {
                MessageBox.Show("NO FUE POSIBLE ENCONTRAR REGISTROS DE ORDENES DE COMPRA CON LOS PARAMETROS INDICADOS ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FormatoGrid(ref DataGridView grd)
        {
            grd.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grd.RowHeadersVisible = false;
            grd.BackgroundColor = Color.White;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.BorderStyle = BorderStyle.None;

            grd.AllowUserToResizeColumns = true;
            grd.MultiSelect = false;
            grd.ReadOnly = true;
            grd.ScrollBars = System.Windows.Forms.ScrollBars.Both;

            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 51, 102);
            grd.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 153, 51);
            grd.EnableHeadersVisualStyles = false;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtNoOrden.Text = string.Empty;
            txtClaveOficina.Text = string.Empty;
            txtOficina.Text = string.Empty;
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;            

            txtFecha1.Value = Fecha1;
            txtFecha2.Value = Fecha2;

            BaseBotonProceso1.Visible = false;

            cbxConSeguimiento.Checked = false;

            grdDatos.DataSource = null;
            grdDatosSeguimiento.DataSource = null;

            grdDatos.Visible = true;
            grdDatosSeguimiento.Visible = false;
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);            
        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtProveedores = sQLCatalogos.Sk_Proveedores();
            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);            
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            DataTable dtProveedores = sQLCatalogos.Sk_Proveedores();
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["Nombre"].ToString();
            }
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row != null)
            {
                //if (Convert.ToBoolean(row.Cells["B_Manual"].Value) == true)
                int K_Orden_Compra = Convert.ToInt32(row.Cells["K_Orden_Compra"].Value);
                lblTitulo.Text = "Seguimiento Orden de Compra No. " + K_Orden_Compra.ToString().Trim();
            }
        }

        private void cbxConSeguimiento_CheckedChanged(object sender, EventArgs e)
        {
            grdDatos.DataSource = null;
            grdDatosSeguimiento.DataSource = null;

            grdDatos.Visible = true;
            grdDatosSeguimiento.Visible = false;

            BaseBotonProceso1.Visible = false;
            BaseBotonExcel.Visible = false;
        }
       
    }
}
