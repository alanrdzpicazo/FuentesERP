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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Inventario_Ubicacion : FormaBase
    {
        DataTable dtAlmacen = new DataTable();
        DataTable dtArticulos = new DataTable();
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        SQLAlmacen sQLAlmacen = new SQLAlmacen();
        int res = 0;
        int k_Almacen = 0;
        int K_ArticuloSel = 0;
        string msg = string.Empty;

        public Frm_Inventario_Ubicacion()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            BaseGrid = grdArticulos;
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinasEmpresa);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinasEmpresa;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }

        }


        public override void BaseMetodoInicio()
        {
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonBuscar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonReporte.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            txtClaveOficina.Text = Convert.ToString(GlobalVar.K_Oficina);
            txtOficina.Text = GlobalVar.D_Oficina;
            MtdCargaAlmacen();

            grdArticulos.AutoGenerateColumns = false;
            PnlArticulos.Enabled = false;
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            if(frm.LLave_Seleccionado==0)
            {
                txtK_Articulo.Text = string.Empty;
                txtArticulo.Text = string.Empty;
            }
            else
            {
                txtK_Articulo.Text = Convert.ToString(frm.LLave_Seleccionado);
                txtArticulo.Text = frm.Descripcion_Seleccionado;
                cbxAlmacen.Focus();
            }
        

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR LA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxAlmacen.SelectedValue == null)
            {
                MessageBox.Show("FALTA SELECCIONAR EL ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return;
            }
            if (cbxRangosUbicacion.Checked)
            {
                if (txtRangoI.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL RANGO INICIAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRangoI.Focus();
                    return;

                }
                if (txtRangoF.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL RANGO FINAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRangoF.Focus();
                    return;

                }
            }
            if (txtK_Articulo.Text.Trim().Length != 0 )
            {
                K_ArticuloSel = Convert.ToInt32(txtK_Articulo.Text);
            }

            if (cbxFechas.Checked)
            {
                dtArticulos = sQLAlmacen.Sk_Inventario_Ubicacion(Convert.ToInt32(txtClaveOficina.Text), Convert.ToInt16(cbxAlmacen.SelectedValue), K_ArticuloSel,
                                txtSKU.Text, txtNo_Lote.Text, txtFechaInicial.Value, txtFechaFinal.Value, cbxSinUbicacion.Checked, cbxCompleta.Checked);

            }
            if(cbxRangosUbicacion.Checked)
            {
                dtArticulos = sQLAlmacen.Sk_Inventario_Ubicacion(Convert.ToInt32(txtClaveOficina.Text), Convert.ToInt16(cbxAlmacen.SelectedValue), K_ArticuloSel,
                                         txtSKU.Text, txtNo_Lote.Text, txtRangoI.Text, txtRangoF.Text, cbxSinUbicacion.Checked, cbxCompleta.Checked);
            }
            if(cbxRangosUbicacion.Checked == false & cbxFechas.Checked == false)
            {
                dtArticulos = sQLAlmacen.Sk_Inventario_Ubicacion(Convert.ToInt32(txtClaveOficina.Text), Convert.ToInt16(cbxAlmacen.SelectedValue), K_ArticuloSel,
                                         txtSKU.Text, txtNo_Lote.Text,cbxSinUbicacion.Checked, cbxCompleta.Checked);
            }
            BaseDtDatos = dtArticulos;
            grdArticulos.DataSource = dtArticulos;
            grdArticulos.EditMode = DataGridViewEditMode.EditOnEnter;

            grdArticulos.MultiSelect = false;


            if (grdArticulos.Rows.Count > 0)
            {

                grdArticulos.Rows[0].Cells["Ubicacion"].Selected = true;
                grdArticulos.Focus();
                BaseBotonExcel.Visible = true;
                BaseBotonReporte.Visible = true;
               
            }
            else
            {
                MessageBox.Show("NO EXISTE INFOMACION CON LOS PARAMETROS INDICADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxAlmacen.Focus();
                return;

            }
        }

        void MtdCargaAlmacen()
        {
            dtAlmacen = sqlCatalogos.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario,Convert.ToInt32(txtClaveOficina.Text),GlobalVar.K_Empresa);
            
            if (dtAlmacen != null)
            { 
                int indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNo_Lote.Text    = "";
            txtK_Articulo.Text = "";
            txtArticulo.Text = "";
            cbxCompleta.Checked = false;
            cbxSinUbicacion.Checked = false;
            txtSKU.Text = "";
            txtUbicacion.Text = "";
            BaseBotonExcel.Visible = false;
            cbxRangosUbicacion.Checked = false;
            txtRangoI.Text = "";
            txtRangoF.Text = "";
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR LA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxAlmacen.SelectedValue == null)
            {
                MessageBox.Show("FALTA SELECCIONAR EL ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return;
            }

            DataTable dtDetalle = Mtd_LLenar_Detalle();
            if (dtDetalle != null)
            {
                try
                {
                    res =  sQLAlmacen.Up_Inventario_Ubicacion(Convert.ToInt32(txtClaveOficina.Text), Convert.ToInt16(cbxAlmacen.SelectedValue), dtDetalle, txtUbicacion.Text, ref msg );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (res == -1)
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL INVENTARIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnBuscar.PerformClick();


                }
            }
        }
        public DataTable Mtd_LLenar_Detalle()
        {
            DataTable dtDatos = new DataTable();
            dtDatos = Detalle_UbicacionType;

            int row_K_Articulo = 0;
            string row_Lote = "";

            foreach (DataGridViewRow row in this.grdArticulos.Rows)
            {
                row_K_Articulo = int.Parse(row.Cells["K_Articulo"].Value.ToString());
                row_Lote = row.Cells["No_Lote"].Value.ToString();

                dtDatos.Rows.Add(row_K_Articulo, row_Lote);
            }

            return dtDatos;
        }
        public override void BaseBotonReporteClick()
        {
            Cursor = Cursors.WaitCursor;
            Reporte_Sk_Inventario_Ubicacion();
            Cursor = Cursors.Default;
        }
        void Reporte_Sk_Inventario_Ubicacion()
        {

            if (dtArticulos != null)
            {
                ReportDocument rpt = new ProbeMedic.INVENTARIOS.RPT_Inventario_Ubicacion();
                ReporteTitulo = "REPORTE DE UBICACIONES";
                ReporteModulo = "Ventas";
                ConectaReporte(ref rpt, dtArticulos, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private void cbxFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFechas.Checked)
            {
                txtFechaFinal.Visible = true;
                txtFechaInicial.Visible = true;
                LblInicialI.Visible = true;
                LblInicialF.Visible = true;
            }
            else
            {
                txtFechaFinal.Visible = false;
                txtFechaInicial.Visible = false;
                LblInicialI.Visible = false;
                LblInicialF.Visible = false;
            }
        }

        private void cbxRangosUbicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRangosUbicacion.Checked)
            {
                txtRangoI.Visible = true;
                txtRangoF.Visible = true;
                LblInicialRI.Visible = true;
                LblInicialRF.Visible = true;
            }
            else
            {
                txtRangoI.Visible = false;
                txtRangoF.Visible = false;
                LblInicialRI.Visible = false;
                LblInicialRF.Visible = false;
            }

        }

        private void Frm_Inventario_Ubicacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                BtnBuscar.PerformClick();
            }
           
        }

        private void txtClaveOficina_TextChanged(object sender, EventArgs e)
        {
            MtdCargaAlmacen();
        }
    }
}