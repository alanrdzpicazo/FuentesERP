﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Ajuste_Recepcion : FormaBase
    {
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        int int_Concecutivo = 0;
        int int_K_Oficina_Recepcion = 0;
        int int_K_Almacen = 0;
        DataTable dtAlmacen = new DataTable();

        Funciones fx = new Funciones();

        public Frm_Ajuste_Recepcion()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            txtConsecutivo.valor.KeyUp += new KeyEventHandler(txtConsecutivo_KeyUp);
        }
        private void txtConsecutivo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BaseBotonBuscarClick();
            }
     
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            grdDetalle.AutoGenerateColumns = false;

            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = false;
            BaseBotonAfectar.Text = "Recibir";
            BaseBotonAfectar.ToolTipText = "Recibir Refacciones y Afectar Inventario";
            BaseBotonReporte.Text = "Reimprimir";
            BaseBotonReporte.ToolTipText = "Reimprimir Reporte";

           grdDetalle.AutoGenerateColumns= false;           
        }

        public override void BaseBotonBuscarClick()
        { 
            if (!string.IsNullOrEmpty(txtConsecutivo.valor.Text))
            {
                DataTable dt;
                int Resultado = 0;
                string Mensaje = string.Empty;
                // PRIMERO SE VALIDA SI EL CONSECUTIVO NO SE HA RECIBIDO POR COMPLETO
                Resultado = sqlAlmacen.Sk_transferencia_Almacen(Convert.ToInt32(txtConsecutivo.valor.Text), ref Mensaje);
                if (Resultado == -1)
                {
                    MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // POSTERIORMENTE SE REALIZA LA BUSQUEDA DE info DEL CONSECUTIVO
                dt = sqlAlmacen.Sk_transferencia_Almacen(Convert.ToInt32(txtConsecutivo.valor.Text));

                if (dt != null)
                {
                    BaseBotonCancelar.Enabled = true;
                    BaseBotonCancelar.Visible = true;
                    //if (Convert.ToBoolean(dt.Rows[0]["B_Recibida"]))
                    //{
                    //    MessageBox.Show("El Folio Proporcionado ya fue recibido, Verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    BaseBotonAfectar.Enabled = false;
                    //    BaseBotonReporte.Enabled = true;
                    //    return;
                    //}
                    dt.TableName = "Transito";
                    //if (Convert.ToBoolean(dt.Rows[0]["B_RecepcionCompleta"]))
                    //{
                    //    MessageBox.Show("El No. de Folio indicado ya fue recibido por completo. . !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    BaseBotonAfectar.Enabled = false;
                    //    BaseBotonReporte.Enabled = true;
                    //    return;
                    //}
                    //if (Convert.ToBoolean(dt.Rows[0]["B_RecepcionParcial"]))
                    //{
                    //    DialogResult dlgResult = MessageBox.Show("El No. de Folio indicado  tiene una recepción parcial" + System.Environment.NewLine +
                    //                                             "¿ Desea continuar recibiendo los Sistemas restantes ?", "Pregunta", MessageBoxButtons.YesNo,
                    //                                             MessageBoxIcon.Question);
                    //    if (dlgResult == DialogResult.No)
                    //    {
                    //        BaseBotonAfectar.Enabled = false;
                    //        BaseBotonReporte.Enabled = true;
                    //        return;
                    //    }
                    //}
                    int_Concecutivo = Convert.ToInt32(txtConsecutivo.valor.Text);
                    txtOficinaEnvio.Text = dt.Rows[0]["D_Oficina"].ToString();
                    txtOficina.Text = dt.Rows[0]["D_Oficina_Transfiere"].ToString();
                    txtObservaciones.Text = dt.Rows[0]["Observaciones"].ToString();
                    int_K_Oficina_Recepcion = Convert.ToInt32(dt.Rows[0]["K_Oficina_Transfiere"]);
                    int_K_Almacen = Convert.ToInt32(dt.Rows[0]["K_Almacen"]);
                    dt.Columns["Cantidad_por_Recibir"].ReadOnly = false; 
                    //dt.Columns["Cantidad_Recibida"].ReadOnly = true;
                    MtdCargaAlmacen();
                    grdDetalle.DataSource = dt;

                    String mensaje = string.Empty;

                    foreach (DataRow row in dt.Rows)
                    {
                  
                        DateTime F_Actual = DateTime.Now;
                        DateTime F_Caducidad = Convert.ToDateTime(row["F_Caducidad"].ToString());

                        TimeSpan ts = F_Caducidad - F_Actual;

                        int Diferencia_Dias = ts.Days;

                        if (Diferencia_Dias <= 4)
                        {
                            mensaje += "El Artículo [" + row["K_Articulo"] + "][" + row["D_Articulo"] + "] con LOTE [" + row["No_Lote"] + "] tiene una fecha de caducidad menor a 4 días. \n\n";

                        }
                      
                    }

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    BaseBotonAfectar.Enabled = true;
                    BaseBotonReporte.Enabled = true;
                }
                else
                {
                    BaseBotonCancelar.Enabled = false;
                    BaseBotonCancelar.Visible = false;
                    BaseBotonAfectar.Enabled = false;
                    BaseBotonReporte.Enabled = false;
                    MessageBox.Show("No fue posible localizar el No. de Folio indicado...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                BaseBotonAfectar.Enabled = false;
                BaseBotonReporte.Enabled = false;
                MessageBox.Show("Debe de escribir un Consecutivo para la busqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LlenaBusqueda() 
        {
            GlobalVar.dtTraspasos = sqlAlmacen.Sk_transferencia_Almacen();
        }

        public override void BaseBotonAfectarClick()
        {
            int res = 0;
            string strMensaje = "";
            DataTable dtDetalles;
            dtDetalles = Generico_Type;
            if (grdDetalle.Rows.Count > 0 && !string.IsNullOrEmpty(txtConsecutivo.valor.Text))
            {
                if (int_K_Almacen == 0)
                {
                    MessageBox.Show("El almacen de envio es invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (int_K_Almacen == Convert.ToInt32(this.cbxAlmacen.SelectedValue))
                {
                    MessageBox.Show("No puede realizarse el traspaso al mismo almacen de envio.Favor de elegir otro almacen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
                {
                    MessageBox.Show("Favor de seleccionar un almacén recibe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow grow in grdDetalle.Rows)
                {
                    if (Convert.ToDecimal(grow.Cells["Cantidad_por_Recibir"].Value.ToString()) != 0)
                    {
                        DataRow dr;
                        dr = dtDetalles.NewRow();

                        dr[0] = grow.Cells["K_Movimiento_Transito"].Value.ToString();
                        dr[1] = grow.Cells["Cantidad_por_Recibir"].Value.ToString();

                        dtDetalles.Rows.Add(dr);
                    }
                }
                res = sqlAlmacen.Gp_RecepcionAlmacen(int_Concecutivo, Convert.ToInt32(this.cbxAlmacen.SelectedValue), GlobalVar.K_Usuario, GlobalVar.PC_Name, dtDetalles, ref strMensaje);

                if (res == 0)
                {
                    MessageBox.Show("Recepción realizada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseBotonAfectar.Enabled = false;
                    BaseBotonCancelar.Visible = false;
                    BaseBotonCancelar.Enabled = false;
                    Limpiar();
                    txtConsecutivo.Text = "";
                }
                else
                {
                    MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para realizar la recepción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Limpiar()
        {
            int_Concecutivo = 0;
            txtConsecutivo.valor.Text = "";
            txtOficinaEnvio.Text = "";
            txtOficina.Text = "";
            txtObservaciones.Text = "";
            int_K_Oficina_Recepcion = 0;
            MtdCargaAlmacen();
            grdDetalle.DataSource = null;
            
        }

        private void MtdCargaAlmacen()
        {
           //dtAlmacen.Rows.Clear();
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            if (int_K_Oficina_Recepcion == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(int_K_Oficina_Recepcion);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                cbxAlmacen.SelectedValue = 0;
            }
        }

        private void grdDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = grdDetalle.CurrentRow;

            if (e.ColumnIndex == 0) //cantidad a movimiento
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    grdDetalle.CancelEdit();

                    return;
                }

                if (!EsNumero(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                {
                    grdDetalle.CancelEdit();
                    return;
                }
                if (row != null)
                {


                    //if (0 == Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                    //{
                    //    MessageBox.Show("LA CANTIDAD A TRANSFERIR NO PUEDE SER MAYOR A LA CANTIDAD DISPONIBLE, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    e.Cancel = true;
                    //}
                }

            }
        }

        private void btnBuscaTraspaso_Click(object sender, EventArgs e)
        {
            LlenaBusqueda();
            Busquedas.BuscaTraspasos frm = new Busquedas.BuscaTraspasos();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtTraspasos);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtTraspasos;
            frm.BusquedaPropiedadTitulo = "Busca Traspasos";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtConsecutivo.Text = frm.BusquedaPropiedadReglonRes["Consecutivo"].ToString();
                this.BaseBotonBuscarClick();
            }
        }

        public override void BaseBotonCancelarClick()
        {
            Limpiar();
            BaseMetodoInicio();
        }

        private void Reporte(int P_Consecutivo)
        {
//            DataTable dtReporte = sqlAlmacen.sps_transferencia_Almacen(P_Consecutivo);
            bool B_Reporte = true;
           /* DataTable dtReporte = sqlAlmacen.Sk_ReporteTransferenciaAlmacen(P_Consecutivo, B_Reporte);
            if (dtReporte == null)
            {
                MessageBox.Show("NO EXISTE EL NUMERO DE CONSECUTIVO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ReportedtCorreo = null; //dtReporte
            string Version = dtReporte.Rows[0]["Version"].ToString();

            ReportDocument rpt = new ReportDocument();
            rpt = new REPORTES.RPT_Transferencia_Almacen();

            ReporteTitulo = "Transferencia entre Oficinas";
            ReporteModulo = "ALMACEN";


            ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            ReporteRPT = rpt;

            Frm_Reportes frmReporte = new Frm_Reportes();
            frmReporte.P_Titulo = ReporteTitulo;
            frmReporte.P_ReporteRPT = ReporteRPT;
            frmReporte.P_TablaCorreo = ReportedtCorreo;
            frmReporte.ShowDialog();*/
        }

        public override void BaseBotonReporteClick()
        {
            Cursor = Cursors.WaitCursor;
            Reporte(Convert.ToInt32(txtConsecutivo.Text));
            Cursor = Cursors.Default;
        }

    }
}