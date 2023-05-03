﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_ConsultaDevoluciones : FormaBase
    {
        public Frm_ConsultaDevoluciones()
        {
            InitializeComponent();
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        public int PK_Movimiento_Inventario { get; set; }
        public string Str_Oficina { get; set; }
        public string Str_Articulo { get; set; }
        public string Str_Almacen { get; set; }
        public string Str_Unidad { get; set; }
        public string Str_Lote { get; set; }
        public string UnidadMedida { get; set; }

        DataTable dtResultadoDetalle = new DataTable();
        DataTable dtResultadoSeguimiento = new DataTable();

        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        Funciones fx = new Funciones();
     
        public override void BaseMetodoInicio()
        {
            txtOficina.Text = Str_Oficina;
            txtAlmacen.Text = Str_Almacen;
            txtArticulo.Text = Str_Articulo;
            txtUnidadMedida.Text = Str_Unidad;
            txtLote.Text = Str_Lote;

            grdDatos.AutoGenerateColumns = false;
            dtResultadoDetalle = sqlAlmacen.Sk_Devoluciones(PK_Movimiento_Inventario);
            grdDatos.DataSource = dtResultadoDetalle;

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

           
            //Para imprimir el reporte
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["printer.png"]));
            BaseBotonProceso1.Text = "Imprimir Reporte";
            BaseBotonProceso1.Width = 120;

            //Para subir la nota de crédito
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["folder_up_upload_16671.ico"]));
            BaseBotonProceso2.Text = "Subir Nota de Crédito";
            BaseBotonProceso2.ToolTipText = "Subir Nota de Crédito del Proveedor";
            BaseBotonProceso2.Width = 145;

            this.WindowState = FormWindowState.Maximized;
            if (dtResultadoDetalle == null)
            {
                BaseBotonProceso1.Visible = false;
                BaseBotonProceso2.Visible = false;
            }
        }

        private void grdDatos_DataSourceChanged(object sender, EventArgs e)
        {
            if (grdDatos.Rows.Count != 0)
            {
                BaseBotonExcel.Visible = true;
                BaseDtDatos = fx.GetDataTableFromDGV(grdDatos);
            }
            else
            {
                BaseBotonExcel.Visible = false;

            }
        }

        //Imprimir Reporte
        public override void BaseBotonProceso1Click()
        {
            if(grdDatos.CurrentRow!=null)
            {
                Cursor = Cursors.WaitCursor;
                Reporte(Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Devolucion"].Value));
                Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA DEVOLUCIÓN!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //Nota de Crédito
        public override void BaseBotonProceso2Click()
        {
            if(grdDatos.CurrentRow!=null)
            {
                INVENTARIOS.Frm_Sube_NotaCredito frm = new Frm_Sube_NotaCredito();
                frm.pK_Devolucion = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Devolucion"].Value);
                frm.pK_Proveedor = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Devolucion"].Value);
                frm.pK_Estatus_Devolucion = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Estatus_Devolucion2"].Value.ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA DEVOLUCIÓN!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
        }

        //Funciones
        void MtdSegumientoDevolucion(Int32 K_Devolucion)
        {
            string msg = string.Empty;
            dtResultadoSeguimiento = sqlAlmacen.Sk_Seguimiento_Devolucion(K_Devolucion);

            grdSeguimiento.DataSource = dtResultadoSeguimiento;
        }
        void Reporte(Int32 K_Devolucion)
        {
            DataTable dtReporte = sqlAlmacen.sk_Devoluciones(K_Devolucion);
            ReportedtCorreo = null; //dtReporte
            string Version = "";//dtReporte.Rows[0]["Version"].ToString();

            ReportDocument rpt = new ReportDocument();
            rpt = new ProbeMedic.INVENTARIOS.RPT_AjustaDevoluciones();

            ReporteTitulo = "Ajuste de Inventario por Devolución";
            ReporteModulo = "ALMACEN";

            DataRow row = dtReporte.Rows[0];

            rpt.DataDefinition.FormulaFields["Str_K_Devolucion"].Text = "'" + row["K_Devolucion"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Articulo"].Text = "'" + row["D_Articulo"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_SKU"].Text = "'" + row["SKU"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_K_Articulo"].Text = "'" + row["K_Articulo"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Cantidad"].Text = "'" + row["Cantidad"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Motivo"].Text = "'" + row["D_Motivo_Devolucion"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Oficina"].Text = "'" + row["D_Oficina"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Almacen"].Text = "'" + row["D_Almacen"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Usuario"].Text = "'" + row["D_Usuario"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_UnidadMedida"].Text = "'" + row["UnidadMedida"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Lote"].Text = "'" + row["No_Lote"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Proveedor"].Text = "'" + row["D_Proveedor"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Nota_Recepcion"].Text = "'" + row["K_Nota_Recepcion"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_F_Recepcion"].Text = "'" + row["F_Recepcion"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Tipo_Documento"].Text = "'" + row["Tipo_Documento"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_No_Documento"].Text = "'" + row["No_Documento"].ToString() + "'";

            ConectaReporte(ref rpt, null, ReporteTitulo, ReporteModulo, Version);
            ReporteRPT = rpt;

            Frm_Reportes frmReporte = new Frm_Reportes();
            frmReporte.P_Titulo = ReporteTitulo;
            frmReporte.P_ReporteRPT = ReporteRPT;
            frmReporte.P_TablaCorreo = ReportedtCorreo;
            frmReporte.ShowDialog();
        }

        //Cada vez que cambie de pestaña a seguimientos
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) //DEtalle
            {
                //grdSeguimiento.DataSource = null;
                //if (grdSeguimiento.DataSource == null)
                //    return;
                if (grdSeguimiento.Rows.Count == 0)
                    return;

                int K_Devolucion = 0;

                DataGridViewRow row = grdDatos.CurrentRow;
                if (row != null)
                {
                    K_Devolucion = int.Parse(row.Cells["K_Devolucion"].Value.ToString());
                }

                DataTable dtDetalle = sqlAlmacen.Sk_Seguimiento_Devolucion(K_Devolucion);
                if (dtDetalle != null)
                {
                    if (dtDetalle.Rows.Count > 0)
                    {
                        grdSeguimiento.DataSource = dtDetalle;
                    }
                }
            }
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDatos.Columns[e.ColumnIndex].Name == "Actualizar_Estatus")
            {
                INVENTARIOS.Frm_ActualizaEstatusDevolucion frm = new INVENTARIOS.Frm_ActualizaEstatusDevolucion();
                frm.pK_Devolucion= Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Devolucion"].Value);
                frm.ShowDialog();
                BaseMetodoInicio();
            }
        }
    }
}
