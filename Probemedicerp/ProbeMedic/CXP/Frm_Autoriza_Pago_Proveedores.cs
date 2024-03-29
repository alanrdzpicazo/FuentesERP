﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
namespace ProbeMedic.CXP
{
    public partial class Frm_Autoriza_Pago_Proveedores : FormaBase
    {
        string strMensaje = "";
        int res = 0;

        SQLCatalogos SqlCatalogos = new SQLCatalogos();
        SQLCuentasxPagar SqlCxp = new SQLCuentasxPagar();
        SQLCompras sqlCompras = new SQLCompras();
        Funciones fx = new Funciones();

        DataTable dtProveedores;
        DataTable dtOrdenes;
        DataTable dtGenerico;

        bool blnCargarCxP = true;
         
        public Frm_Autoriza_Pago_Proveedores()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            this.WindowState = FormWindowState.Maximized;
            blnCargarCxP = false;
            BaseMetodoRecarga();
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            //BaseBotonBuscar.Visible = false;
            //BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;

            gvCxp.AutoGenerateColumns = false;
            gvCxp.ScrollBars = ScrollBars.Both;

            dtProveedores = SqlCatalogos.Sk_Proveedores();
            
            dtOrdenes = sqlCompras.Sk_ConsultaOrdenesCompra(2, false);

            DataTable miDtMoneda = new DataTable();
            miDtMoneda.Columns.Add("K_Tipo_Moneda", (typeof(int)));
            miDtMoneda.Columns.Add("D_Tipo_Moneda", (typeof(string)));
            miDtMoneda.Columns.Add("CampoBusqueda", (typeof(string)));

            dtGenerico = Generico_Type;
            DataRow dr;

            dr = miDtMoneda.NewRow();
            dr["K_Tipo_Moneda"] = 0;
            dr["D_Tipo_Moneda"] = "TODAS";
            miDtMoneda.Rows.Add(dr);

            foreach (DataRow row in GlobalVar.dtTipoMoneda.Rows)
            {
                miDtMoneda.ImportRow(row);
            }

            DataTable dtMoneda = sqlCatalogos.Sk_Tipo_Moneda();
            if (dtMoneda != null)
            {
                LlenaCombo(dtMoneda, ref cmbMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda", 0);
            }

            blnCargarCxP = true;

            mtdCargaCXP();

            BaseBotonAfectar.Text = "Autorizar [F6]";

        }
        public override void BaseBotonAfectarClick()
        {
            dtGenerico.Rows.Clear();
            bool blnValidaChk = false;
            foreach (DataGridViewRow row in gvCxp.Rows)
            {
                if (row.Cells["D_Proveedor"].Value.ToString().Trim() != "zzTOTALES:")
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)gvCxp.Rows[row.Index].Cells[0];
                    if (Convert.ToBoolean(chk.Value))
                    {
                        blnValidaChk = true;
                        DataRow dr;
                        dr = dtGenerico.NewRow();

                        dr["Campo1"] = Convert.ToString(row.Cells["K_Cuenta_Pagar"].Value);
                        dr["Campo2"] = Convert.ToString(row.Cells["K_Proveedor"].Value);

                        dtGenerico.Rows.Add(dr);                       
                    }
                }
            }

            if (blnValidaChk == false)
            {
                MessageBox.Show("SELECCIONE UN DOCUMENTO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                strMensaje = "";
             res = SqlCxp.Gp_Autoriza_CxP(dtGenerico,GlobalVar.K_Usuario, GlobalVar.PC_Name,ref strMensaje);

            if (res < 0)
            {
                MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("DOCUMENTOS AUTORIZADOS CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtdCargaCXP();
            }
           
            }
        }
        public override void  BaseBotonBuscarClick()
        {
            mtdCargaCXP();
 	             base.BaseBotonBuscarClick();
            }
 
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
             mtdCargaCXP();
        }

        void mtdCargaCXP()
        {
            lblMensaje.Text = "";
            if (cmbMoneda.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            if (blnCargarCxP == false)
                return;
            if (dtpInicio.Value.Date.CompareTo(dtpFinal.Value.Date) == 1)
            {
                lblMensaje.Text = "Rango de Fechas Incorrecto";
                return;
            }
            DataTable dt;
            if (rbRango.Checked)
            {
                dt = SqlCxp.Sk_ConsultaCxP_PorAutorizar(
                (txtClaveProveedor.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtClaveProveedor.Text),
                (cmbMoneda.SelectedIndex == -1) ? Convert.ToInt16(0) : Convert.ToInt16(cmbMoneda.SelectedValue),
                dtpInicio.Value, dtpFinal.Value,
                (txtNoOrden.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtNoOrden.Text))
                ;
            }
            else
            {
                dt = SqlCxp.Sk_ConsultaCxP_PorAutorizar(
                (txtClaveProveedor.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtClaveProveedor.Text),
                (cmbMoneda.SelectedIndex == -1) ? Convert.ToInt16(0) : Convert.ToInt16(cmbMoneda.SelectedValue),
                (txtNoOrden.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtNoOrden.Text),
                rbVencidas.Checked, rbPorVencer.Checked);
            }

            if (dt == null)
            {
                //MessageBox.Show("No se Encontraros Registros con los Criterios de Búsqueda Proporcionados, Verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMensaje.Text = "No se Encontraros Registros con los Criterios de Búsqueda Proporcionados, Verifique";
            }
            gvCxp.DataSource = dt;

            if (dt != null)
            {
                lblTotalDoc.Text = (dt.Rows.Count - 1).ToString();
            }
            else
            {
                lblTotalDoc.Text = "0";
            }


            MtdChekaGrid();

        }

        private void txtClaveProveedor_Leave(object sender, EventArgs e)
        {

            BuscaEnTablaClaveDescripcion(dtProveedores, "K_Proveedor", "Nombre", ref txtClaveProveedor, ref txtProveedor);

            mtdCargaCXP();
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaProveedores frm = new Busquedas.BuscaProveedores();
            Cursor = Cursors.WaitCursor;
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtProveedores);
            frm.BusquedaPropiedadTablaFiltra = dtProveedores;
            frm.BusquedaPropiedadTitulo = "Busca Proveedores";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveProveedor.Text = frm.BusquedaPropiedadReglonRes["K_Proveedor"].ToString();
                txtProveedor.Text = frm.BusquedaPropiedadReglonRes["D_Proveedor"].ToString();
                mtdCargaCXP();
            }
            Cursor = Cursors.Default;
        }

        private void btnBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            //Busquedas.BuscaOrdenesCompra frm = new Busquedas.BuscaOrdenesCompra();
            //frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtOrdenes);
            //frm.BusquedaPropiedadTablaFiltra = dtOrdenes;
            //frm.BusquedaPropiedadTitulo = "Busca Ordenes de Compra";
            //frm.ShowDialog();
            //if (frm.BusquedaPropiedadReglonRes != null)
            //{
            //    txtNoOrden.Text = frm.BusquedaPropiedadReglonRes["K_Orden_Compra"].ToString();
            //}
        }

        private void rbRango_CheckedChanged(object sender, EventArgs e)
        {
            pRango.Enabled = rbRango.Checked;
            mtdCargaCXP();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            MtdChekaGrid();
        }

        void MtdChekaGrid()
        {
            //if (gvCxp.DataSource != null)
            //{
            //    foreach (DataGridViewRow row in gvCxp.Rows)
            //    {
  
            //            if (row.Cells["Nombre"].Value.ToString().Trim() != "zzTOTALES:")
            //            {
            //                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
            //                chk.Value = chkAll.Checked;
            //            }

            //    }
            //    MtdTotalGrid();
            //}


        }

        private void gvCxp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (gvCxp.Rows[e.RowIndex].Cells["D_Proveedor"].Value.ToString().Trim() != "zzTOTALES:")
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)gvCxp.Rows[e.RowIndex].Cells[0];
                    chk.Value = !Convert.ToBoolean(chk.Value);
                    //if (Convert.ToBoolean(chk.Value))
                    //{
                    MtdTotalGrid();
                    //}
                }
            }
        }
        private void gvCxp_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
            DataGridViewRow row = gvCxp.Rows[e.RowIndex];
            DataGridViewRow ren = gvCxp.CurrentRow;

            if (ren != null)
            {
                int indice = ren.Index;

                if (Convert.ToInt16(row.Cells["K_Cuenta_Pagar"].Value) == 0)
                {
                    row.DefaultCellStyle.SelectionBackColor = Color.Black; //Color.FromArgb(255, 128, 0);// Color.Lime;// FromArgb(255, 50, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.Lime;
                    row.DefaultCellStyle.BackColor = Color.Black;
                    row.DefaultCellStyle.ForeColor = Color.Lime;  //FromArgb(255, 50, 0);
                }

            }
        }
        void MtdTotalGrid()
        {
            double dblTotal = 0;
            double dblTotalDolar = 0;
            foreach (DataGridViewRow row in gvCxp.Rows)
            {
                    if (row.Cells["D_Proveedor"].Value.ToString().Trim() != "zzTOTALES:")
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)gvCxp.Rows[row.Index].Cells[0];
                        if (Convert.ToBoolean(chk.Value))
                        {
                            if (row.Cells["D_Tipo_Moneda"].Value.ToString().ToUpper() == "DOLARES")
                            {
                                dblTotalDolar = dblTotalDolar + Convert.ToDouble(row.Cells["Saldo"].Value);
                            }
                            else
                            {
                                dblTotal = dblTotal + Convert.ToDouble(row.Cells["Saldo"].Value);
                            }
                        }

                    }
            }
            txtTotal.Text = dblTotal.ToString("C2");
            txtTotalDolar.Text = dblTotalDolar.ToString("C2");
        }
        /// <summary>
        /// Works with the above.
        /// </summary>
        private void gvCxp_CellValueChanged(object sender,DataGridViewCellEventArgs e)
        {
            //UpdateDataGridViewSite();
            //update
        }

        private void txtNoOrden_TextChanged(object sender, EventArgs e)
        {
            mtdCargaCXP();
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtdCargaCXP();
        }

        private void rbVencidas_CheckedChanged(object sender, EventArgs e)
        {
            mtdCargaCXP();
        }

        private void rbPorVencer_CheckedChanged(object sender, EventArgs e)
        {
            mtdCargaCXP();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            mtdCargaCXP();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            mtdCargaCXP();
        }

    }
}
