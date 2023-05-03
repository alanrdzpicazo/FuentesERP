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
using ProbeMedic.Entities.Recepcion;

namespace ProbeMedic.COMPRAS
{
    public partial class FRM_REPCOMPRAS_PROV : ProbeMedic.FormaConsulta
    {
        DataTable dtDatos = new DataTable();
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;

        SQLCompras sqlCompras = new SQLCompras();

        public FRM_REPCOMPRAS_PROV()
        {
            InitializeComponent();
            BaseGridSinFormato = true;
            doFormatGrid();

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

        public override void BaseMetodoInicio()
        {
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

        }


        public override void BaseBotonBuscarClick()
        {

            Fecha1 = txtFecha1.Value;
            Fecha2 = txtFecha2.Value;
            int K_Prov = Convert.ToInt32(txtClaveProveedor.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClaveProveedor.Text));


                dtDatos = sqlCompras.Gp_Ordenes_CompraProv(K_Prov, Fecha1, Fecha2);
                if (dtDatos != null)
                {
                   grdDatos.AutoGenerateColumns = false;
                   grdDatos.DataSource = dtDatos;
                   grdDatos.ScrollBars = ScrollBars.Both;
                }
                else
                {
                MessageBox.Show("NO EXISTE INFORMACION CON LOS PARAMETROS INDICADOS");
                    return;
                }



        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClaveProveedor.Text = string.Empty;
            txtProveedor.Text = string.Empty;

            txtFecha1.Value = Fecha1;
            txtFecha2.Value = Fecha2;

            grdDatos.DataSource = null;
            grdDatos.AutoGenerateColumns = false;
        }


        private void btnBuscaProveedor_Click(object sender, EventArgs e)
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
    }
}
