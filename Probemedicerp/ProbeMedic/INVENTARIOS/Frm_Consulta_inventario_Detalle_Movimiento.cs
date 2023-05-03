using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Consulta_inventario_Detalle_Movimiento : FormaBase
    {
        public int K_Movimiento_Inventario = 0;
      
        public string Str_Oficina = "";
        public string Str_Almacen = "";
        public string Str_Articulo = "";
        public string Str_Unidad = "";
        public string Str_Lote = "";
        public string InventarioDisponible = "";
        public string UnidadMedida = "";

        DataTable dtResultadoDetalle = new DataTable();

        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        Funciones fx = new Funciones();


        public Frm_Consulta_inventario_Detalle_Movimiento()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }
        private void Frm_Consulta_inventario_Detalle_Movimiento_Load(object sender, EventArgs e)
        {

        }

        public override void BaseMetodoInicio()
        {
            txtOficina.Text = Str_Oficina;
            txtAlmacen.Text = Str_Almacen;
            txtArticulo.Text = Str_Articulo;
            txtUnidadMedida.Text = Str_Unidad;
            txtLote.Text = Str_Lote;
            LblSaldoDisponible.Text = InventarioDisponible.ToString() +"  "+ UnidadMedida;

            grdDetalleMovimiento.AutoGenerateColumns = false;
            dtResultadoDetalle = sqlAlmacen.Gp_InventarioDetalle_Movimiento(K_Movimiento_Inventario);
            grdDetalleMovimiento.DataSource = dtResultadoDetalle;
            
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
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

            WindowState = FormWindowState.Maximized;            
        }

        private void grdDetalleMovimiento_DataSourceChanged(object sender, EventArgs e)
        {
            if (grdDetalleMovimiento.Rows.Count != 0)
            {
                BaseBotonExcel.Visible = true;
                BaseDtDatos = fx.GetDataTableFromDGV(grdDetalleMovimiento);
            }
            else
            {
                BaseBotonExcel.Visible = false;

            }
        }      
    }
}
