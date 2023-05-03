﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Consulta_Escaneo_NRecepcion : FormaBase
    {
        DataTable dtResultado = new DataTable();
        SQLAlmacen sql_almacen = new SQLAlmacen();

        public int PK_Orden_Compra { get; set; }

        public Frm_Consulta_Escaneo_NRecepcion()
        {
            InitializeComponent();
            doFormatGrid();
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
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonBuscar.Visible = false;

            //Para imprimir el reporte
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["printer.png"]));
            BaseBotonProceso1.Text = "Imprimir Reporte";
            BaseBotonProceso1.Width = 120;

            txtNoOrden.Text = PK_Orden_Compra.ToString();

            MtdCargaResultado();
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
        public override void BaseBotonProceso1Click()
        {
            Cursor = Cursors.WaitCursor;
            Reporte();
            Cursor = Cursors.Default;
        }

        void MtdCargaResultado()
        {
            dtResultado = sql_almacen.Sk_Registro_Escaneo_NRecepcion(Convert.ToInt32(txtNoOrden.Text));

            if(dtResultado != null)
            {
                grdDatos.DataSource = dtResultado;
                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = true;
            }

        }
        void Reporte()
        {
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new ProbeMedic.INVENTARIOS.RPT_Registro_Escaneo_NRecepcion();
                ReporteTitulo = "Consulta de Escaneo de Recepción";
                ReporteModulo = "INVENTARIOS";
                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        
    }
}