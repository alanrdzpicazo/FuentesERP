﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Ajuste_Devolucion : Forma
    {
        public int K_Movimiento_Inventario = 0;
        public decimal CantidadEntrada = 0;
        public int K_Oficina = 0;
        public string Str_Oficina = "";
        public int K_Articulo = 0;
        public int K_Almacen = 0;
        public DateTime F_Caducidad =DateTime.Now;
        public string Str_Almacen = "";
        public string Str_Articulo = "";
        public string Str_Unidad = "";
        public string Str_Lote = "";
        public string Str_ClaveProveedor = "";
        public string Str_Proveedor = "";
        public string Str_Nota_Recepcion = "";
        public string Str_F_Recepcion = "";
        public string Str_Tipo_Documento = "";
        public string Str_No_Documento = "";
        public decimal CantidadDisponible = 0;

        Int32 K_Motivo_Devolucion = 0;
        String D_Motivo_Devolucion = String.Empty;

        int res;
        string strMensaje;
        string strCorreos;

        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        Funciones fx = new Funciones();

        public Frm_Ajuste_Devolucion()
        {
            InitializeComponent();
        }

        private void Frm_Ajuste_Devolucion_Load(object sender, EventArgs e)
        {
            txtArticulo.Text = Str_Articulo;
            txtUnidadMedida.Text = Str_Unidad;
            txtCveProveedor.Text = Str_ClaveProveedor;
            txtProveedor.Text = Str_Proveedor;
            txtNotaRecepcion.Text = Str_Nota_Recepcion;
            txtF_Caducidad.Text = F_Caducidad.ToString();
            txtLote.Text = Str_Lote;
            txtDisponible.Text = CantidadDisponible.ToString("N3");
            if (txtCantidadAjuste.Visible)
            {
                txtCantidadAjuste.Focus();
             }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidadAjuste.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE LA CANTIDAD DE LA DEVOLUCIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidadAjuste.Focus();
                return;
            }

            if (     Convert.ToDouble(txtCantidadAjuste.Text.Trim()) > Convert.ToDouble(txtDisponible.Text.Trim())    ) 
            {
                MessageBox.Show("LA CANTIDAD DE LA DEVOLUCION DEBE SER MENOR A LA CANTIDAD DISPONIBLE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidadAjuste.Focus();
                return;
            }
            if (txtMotivo.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE MOTIVO DE LA DEVOLUCION", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtObservaciones.Focus();
                return;
            }
            if (txtObservaciones.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE OBSERVACIONES DE LA DEVOLUCION", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtObservaciones.Focus();
                return;
            }
            try
            {
                strMensaje = "";
                Int32 CampoIdentity = 0;
                res = sqlAlmacen.Gp_AjusteInventarioDevolucion(ref CampoIdentity,K_Movimiento_Inventario, Convert.ToDecimal(txtCantidadAjuste.Text), txtObservaciones.Text, txtLote.Text, F_Caducidad, K_Oficina, GlobalVar.K_Usuario, GlobalVar.PC_Name, K_Motivo_Devolucion, ref strMensaje, ref strCorreos);

                if (res < 0)
                {
                    MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Devolución Realizada Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte(CampoIdentity);
                    Cursor = Cursors.Default;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarMotivo_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Motivos_Devolucion frm = new Busquedas.Frm_Busca_Motivos_Devolucion();
            frm.ShowDialog();
            K_Motivo_Devolucion= frm.LLave_Seleccionado;
            txtMotivo.Text = frm.Descripcion_Seleccionado;
        }

        private void txtCantidadAjuste_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumeroDecimal(ref e);
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
    }
}
