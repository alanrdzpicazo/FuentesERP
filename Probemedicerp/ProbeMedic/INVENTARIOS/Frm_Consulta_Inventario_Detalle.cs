﻿using System;
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
    public partial class Frm_Consulta_Inventario_Detalle : FormaBase
    {
        public Frm_Consulta_Inventario_Detalle()
        {
            InitializeComponent();
        }

        Funciones fx = new Funciones();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();

        public int K_Oficina = 0;
        public int K_Articulo  = 0;
        public int K_Almacen = 0;
        public string Str_Oficina = "";
        public string Str_Almacen = "";
        public string Str_Articulo = "";
        public string Str_Unidad = "";    
        public bool B_MuestraTodo;

        DateTime FechaInicial = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;
        DataTable dtResultadoDetalle = new DataTable();
        
        private void Frm_Consulta_Inventario_Detalle_Load(object sender, EventArgs e)
        {      
        }
  
        public override void BaseMetodoInicio()
        {
            txtOficina.Text = Str_Oficina;
            txtAlmacen.Text = Str_Almacen;
            txtArticulo.Text = Str_Articulo;
            txtUnidadMedida.Text = Str_Unidad;

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
            cBoxMostrarTodo.Checked = B_MuestraTodo;
            grdDetalle.AutoGenerateColumns = false;

            dtResultadoDetalle = sqlAlmacen.Gp_Inventario_Detalle(
                K_Oficina, 
                K_Articulo, 
                K_Almacen,
                dtpInicio.Value,
                dtpFinal.Value,
                cBoxMostrarTodo.Checked     
                );

            LblSaldoDisponible.Text = "0 " + txtUnidadMedida.Text;

            try
            {
                var x = dtResultadoDetalle.AsEnumerable().Select(r => Convert.ToInt32(r.Field<Int32>("Cantidad_Disponible"))).Sum();
                if (x.ToString() != "")
                {
                    if (x != 0)
                    {
                        LblSaldoDisponible.Text = x.ToString("N3").Trim() + "   " + txtUnidadMedida.Text;
                    }
                    else
                    {
                        btnAjuste.Enabled = false;
                        btnDevolucion.Enabled = false;
                    }
                }
            }
            catch 
            {

                LblSaldoDisponible.Text = "0 " + txtUnidadMedida.Text;
                
            }

         
            grdDetalle.DataSource = dtResultadoDetalle;

            //Botón para consultar los movimientos de almacén los cuales pueden ser devoluciones o ajustes
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList2.Images["Historial.png"]));
            BaseBotonProceso1.Text = "Historial";
            BaseBotonProceso1.Visible = true;

            this.WindowState = FormWindowState.Maximized;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
           
            if(GlobalVar.B_PermiteAjustes)
                 btnAjuste.Visible = true;
            else
                btnAjuste.Visible = false;
            btnDevolucion.Visible = true;

        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {

            if (grdDetalle.CurrentRow != null)
            {
                try
                {
                    INVENTARIOS.Frm_Ajuste_Inventario frm = new INVENTARIOS.Frm_Ajuste_Inventario();

                    frm.Str_Oficina = Convert.ToString(Str_Oficina);
                    frm.K_Oficina = K_Oficina;
                    frm.Str_Almacen = Str_Almacen;
                    frm.Str_Articulo = Str_Articulo;
                    frm.Str_Unidad = Str_Unidad;
                    frm.Str_Lote = Convert.ToString(grdDetalle.CurrentRow.Cells["No_Lote"].Value);
                    frm.K_Movimiento_Inventario = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Movimiento_Inventario"].Value);

                    frm.ShowDialog();
                }
                finally
                {
                    FiltraDetalle();
                }
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            if (grdDetalle.CurrentRow != null)
            {
                try
                {
                    INVENTARIOS.Frm_Ajuste_Devolucion frm = new INVENTARIOS.Frm_Ajuste_Devolucion();
                    frm.Str_Oficina = Convert.ToString(Str_Oficina);
                    frm.K_Oficina = K_Oficina;
                    frm.Str_Almacen = Str_Almacen;
                    frm.Str_Articulo = Str_Articulo;
                    frm.Str_Unidad = Str_Unidad;
                    frm.F_Caducidad = Convert.ToDateTime(grdDetalle.CurrentRow.Cells["F_Caducidad"].Value);
                    frm.Str_ClaveProveedor = Convert.ToString(grdDetalle.CurrentRow.Cells["K_Proveedor"].Value);
                    frm.Str_Proveedor = Convert.ToString(grdDetalle.CurrentRow.Cells["D_Proveedor"].Value);
                    frm.Str_Nota_Recepcion = Convert.ToString(grdDetalle.CurrentRow.Cells["K_Nota_Recepcion"].Value);
                    frm.Str_F_Recepcion = Convert.ToString(grdDetalle.CurrentRow.Cells["F_Recepcion"].Value);
                    frm.Str_Tipo_Documento = Convert.ToString(grdDetalle.CurrentRow.Cells["Tipo_Documento"].Value);
                    frm.Str_No_Documento = Convert.ToString(grdDetalle.CurrentRow.Cells["No_Documento"].Value);
                    frm.Str_Lote = Convert.ToString(grdDetalle.CurrentRow.Cells["No_Lote"].Value);
                    frm.K_Movimiento_Inventario = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Movimiento_Inventario"].Value);
                    if (grdDetalle.CurrentRow.Cells["Cantidad_Articulo"].Value != null)
                        frm.CantidadEntrada = Convert.ToDecimal(grdDetalle.CurrentRow.Cells["Cantidad_Articulo"].Value);
                    if (grdDetalle.CurrentRow.Cells["Cantidad_Disponible"].Value != null)
                        frm.CantidadDisponible = Convert.ToDecimal(grdDetalle.CurrentRow.Cells["Cantidad_Disponible"].Value);
                    frm.ShowDialog();
                }
                finally
                {
                    FiltraDetalle();
                }
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            FiltraDetalle();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltraDetalle();
        }

        private void txtLote_Leave(object sender, EventArgs e)
        {
            FiltraDetalle();
        }

        private void grdDetalle_DataSourceChanged(object sender, EventArgs e)
        {
            if (grdDetalle.Rows.Count != 0)
            {
                BaseBotonExcel.Visible = true;
                BaseDtDatos = fx.GetDataTableFromDGV(grdDetalle);
            }
            else
            {
                BaseBotonExcel.Visible = false;                
            }
        }

        private void grdDetalle_SelectionChanged(object sender, EventArgs e)
        {
            if(grdDetalle.CurrentRow!=null)
            {
                if (grdDetalle.CurrentRow.Cells["Cantidad_Movimiento"].Value != null)
                {
                    BaseBotonProceso1.Enabled = (Convert.ToDecimal(grdDetalle.CurrentRow.Cells["Cantidad_Movimiento"].Value) > 0);
                }
            }        
        }

        private void cBoxMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            FiltraDetalle();
        }

        //carga los movimientos de ajustes o devoluciones
        public override void BaseBotonProceso1Click()
        {
            MtdCargaDetalle();
        }

        #region Funciones
        //filtra cada vez que se cambian los valores de los objetos
        void FiltraDetalle()
        {
      
            FechaFinal = dtpFinal.Value;
            FechaInicial = dtpInicio.Value;

            dtResultadoDetalle = sqlAlmacen.Gp_Inventario_DetallexLote(K_Oficina, K_Articulo, K_Almacen, dtpInicio.Value, dtpFinal.Value, (txtLote.Text.Trim().Length == 0) ? null : txtLote.Text.Trim(), cBoxMostrarTodo.Checked);
            LblSaldoDisponible.Text = "0 " + txtUnidadMedida.Text;

            if (dtResultadoDetalle != null)
            {
                try
                {
                    var x = dtResultadoDetalle.AsEnumerable().Select(r => Convert.ToInt32(r.Field<Int32>("Cantidad_Disponible"))).Sum();
                    if (x.ToString() != "")
                    {
                        if (x != 0)
                        {
                            LblSaldoDisponible.Text = x.ToString("N3").Trim() + "   " + txtUnidadMedida.Text;
                        }
                    }
                }
                catch 
                {
                    LblSaldoDisponible.Text = "0 " + txtUnidadMedida.Text;
                    btnDevolucion.Enabled = false;
                    btnAjuste.Enabled = false;
                }
                

            }
            grdDetalle.DataSource = dtResultadoDetalle;

            if(grdDetalle.DataSource == null)
            {
                BaseBotonProceso1.Enabled = false;
            }
            

        }

        //abre la pantalla donde estarán desglosados los ajustes y devoluciones
        void MtdCargaDetalle()
        {
            if (grdDetalle.CurrentRow != null)
            {
                INVENTARIOS.Frm_Consulta_inventario_Detalle_Movimiento frm = new INVENTARIOS.Frm_Consulta_inventario_Detalle_Movimiento();
                frm.Str_Oficina = Convert.ToString(Str_Oficina);
                frm.Str_Almacen = Str_Almacen;
                frm.Str_Articulo = Str_Articulo;
                frm.Str_Unidad = Str_Unidad;
                frm.Str_Lote = Convert.ToString(grdDetalle.CurrentRow.Cells["No_Lote"].Value);
                frm.K_Movimiento_Inventario = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Movimiento_Inventario"].Value);
                frm.InventarioDisponible = Convert.ToString(grdDetalle.CurrentRow.Cells["Cantidad_Disponible"].Value);
                frm.UnidadMedida = txtUnidadMedida.Text;
                frm.ShowDialog();
            }
        }
        #endregion

        //este evento tiene lugar cuando es necesario dibujar una celda//
        private void grdDetalle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //fx.DibujarColumnaTipoBotonGrid(ref grdDetalle,imageList3, e, "Devoluciones", "zoom.png");
            if (e.ColumnIndex >= 0 && grdDetalle.Columns[e.ColumnIndex].Name == "Devoluciones" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = grdDetalle.Rows[e.RowIndex].Cells["Devoluciones"] as DataGridViewButtonCell;
                Image imagen = imageList3.Images["zoom.png"];
                e.Graphics.DrawImage(imagen, e.CellBounds.Left + 38, e.CellBounds.Top + 3);
                grdDetalle.Rows[e.RowIndex].Height = imagen.Height + 4;
                grdDetalle.Columns[e.ColumnIndex].Width = imagen.Width + 4;
                e.Handled = true;
            }
        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (grdDetalle.Columns[e.ColumnIndex].Name == "Devoluciones")
                {
                    if (grdDetalle.CurrentRow != null)
                    {

                        int K_Movimiento_Inventario = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Movimiento_Inventario"].Value);

                        DataTable dt = sqlAlmacen.Sk_Devoluciones(K_Movimiento_Inventario);
                        if (dt == null)
                        {
                            MessageBox.Show("EL MOVIMIENTO DE INVENTARIO NO CUENTA CON DEVOLUCIONES..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }

                        INVENTARIOS.Frm_ConsultaDevoluciones frm = new INVENTARIOS.Frm_ConsultaDevoluciones();
                        frm.Str_Oficina = Convert.ToString(Str_Oficina);
                        frm.Str_Almacen = Str_Almacen;
                        frm.Str_Articulo = Str_Articulo;
                        frm.Str_Unidad = Str_Unidad;
                        frm.Str_Lote = Convert.ToString(grdDetalle.CurrentRow.Cells["No_Lote"].Value);
                        frm.PK_Movimiento_Inventario = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Movimiento_Inventario"].Value);
                        frm.UnidadMedida = txtUnidadMedida.Text;
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void grdDetalle_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdDetalle.Cursor = Cursors.Hand;
            else
                grdDetalle.Cursor = Cursors.Default;
        }
    
    }
}
