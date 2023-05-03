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

    public partial class FRM_REP_STOCK_LAB : ProbeMedic.FormaConsulta
    {
        DataTable dtDatos = new DataTable();
        DateTime Fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime Fecha2 = DateTime.Today;

        public FRM_REP_STOCK_LAB()
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
    }
