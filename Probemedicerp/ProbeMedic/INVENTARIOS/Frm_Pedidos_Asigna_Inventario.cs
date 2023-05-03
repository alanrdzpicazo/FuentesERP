using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Pedidos_Asigna_Inventario : FormaBase  
    {
        SQLVentas sqlVentas = new SQLVentas();
        SQLCompras sqlCompras = new SQLCompras();
  
        DataTable dtPedidos;
        DataTable dtLotes;

        DataTable dtAlmacen = new DataTable();

        string strMensaje="";
        int int_K_TipoVenta = 0;
        int int_K_Pedido = 0;
        bool B_NoEntrar;

        public Int32 K_Tipo_Entrega = 0;
        public String D_Tipo_Entrega = string.Empty;
        public Int32 K_Empresa_Entrega { get; set; }
        public Int32 K_Almacen_Pedido { get; set; }

        public Frm_Pedidos_Asigna_Inventario()
        {
            BaseGridSinFormato = true;
            InitializeComponent();

            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
        }

        public override void BaseMetodoInicio()
        {
            dgvPedidoDetalle.AutoGenerateColumns = false;
            dgvInventario.AutoGenerateColumns = false;

            txtOficina.Text = GlobalVar.D_Oficina;

            WindowState = FormWindowState.Maximized;
            dgvPedidoDetalle.Height = 150;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));

            BaseBotonAfectar.ToolTipText = "Guardar y Afectar Inventarios";
            BaseBotonAfectar.Text = "Guardar";
            BaseBotonAfectar.Width = 60;
            BaseBotonAfectar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["zoom.png"]));
            BaseBotonProceso1.Text = "Pedidos Ptes";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;


            BaseBotonReporte.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonReporte.Visible = false;

            BaseBotonAfectar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonCancelar.Text = "Limpiar";
            CargaAlmacen();

            //BaseBotonCancelar.Image = Properties.Resources.page_refresh;

        }

        private void txtNoPedido_TextChanged(object sender, EventArgs e)
        {
            if (txtNoPedido.Text.Trim().Length > 0)
            {
                try
                {
                    Int32 Valor = Convert.ToInt32(txtNoPedido.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoPedido.Text = "";
                }
            }
            if (txtNoPedido.Text.Trim().Length > 0)
            {
                if (BaseBotonProceso1.Visible)
                    BaseBotonProceso1.Visible = false;
            }
            else
            {
                if (!BaseBotonProceso1.Visible)
                    BaseBotonProceso1.Visible = true;
            }

        }

        private void txtNoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        public override void BaseBotonCancelarClick()
        {
            panel2.Enabled = true;
            Limpiar();
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            if (txtNoPedido.CanFocus)
                txtNoPedido.Focus();
        }

        public override void BaseBotonBuscarClick()
        {
            if(cbxAlmacen.Items.Count==0)
            {
                MessageBox.Show("EL USUARIO NO TIENE ALMACENES ASIGNADOS!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(cbxAlmacen.SelectedValue.ToString()) == 0)
            {
                MsgBox msg = new MsgBox();
                msg.Show("FALTA SELECCIONAR ALMACEN DEL QUE SE ASIGNARAN LOTES...!", "Aviso");
                cbxAlmacen.Focus();
                return;
            }
            strMensaje = "";
            int int_Consecutivo = 0;
            //BaseBotonProceso1.Enabled = false;
            //BaseBotonProceso1.Visible = false;

            if (!string.IsNullOrEmpty(txtNoPedido.Text))
            {
                //if(K_Almacen_Pedido == 0)
                //{
                //    MessageBox.Show("EL PEDIDO NO TIENE ALMACEN ASIGNADO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //if(!ValidaPedido(K_Almacen_Pedido,Convert.ToInt32(txtNoPedido.Text.Trim())))
                //{
                //    MessageBox.Show("EL USUARIO NO TIENE ASIGNADO EL ALMACEN DEL PEDIDO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                dtPedidos = sqlVentas.Sk_ConsultaPedidoporAsignar(Convert.ToInt32(txtNoPedido.Text), GlobalVar.K_Oficina, ref int_Consecutivo, ref strMensaje);
                if (strMensaje != "")
                {
                    if (strMensaje == "-4")
                    {
                        //BaseBotonProceso1.ToolTipText = "Cancelar Asignacion y Regresar el Inventario";
                        ////BaseBotonProceso1.Image = Properties.Resources.CancelaSolicitud; //((System.Drawing.Image)(imageList1.Images["report.png"]));
                        //BaseBotonProceso1.Text = "Cancelar Asig.";
                        //BaseBotonProceso1.Width = 100;
                        //BaseBotonProceso1.Enabled = true;
                        //BaseBotonProceso1.Visible = true;

                        strMensaje = "EL PEDIDO YA TIENE LOTES ASIGNADOS" + System.Environment.NewLine + "¿ DESEA REIMPRIMIR EL REPORTE ?";
                        DialogResult dlg = MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlg == DialogResult.Yes)
                        {
                            Imprimir(int_Consecutivo);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BaseBotonProceso1.Visible = true;
                        BaseBotonProceso1.Enabled = true;
                        BaseMetodoInicio();
                        return;
                    }
                }

                if (dtPedidos == null)
                {
                    MessageBox.Show("NO SE ENCONTRO EL PEDIDO No. " + txtNoPedido.Text.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoPedido.Text = string.Empty;
                    return;
                }
                else
                {
                    BaseBotonCancelar.Visible = true;
                    BaseBotonCancelar.Enabled = true;

                    txtNoPedido.Enabled = false;
                    int_K_Pedido = Convert.ToInt32(dtPedidos.Rows[0]["K_Pedido"]);
                    txtCliente.Text = dtPedidos.Rows[0]["D_Cliente"].ToString();
                    txtEstatus.Text = dtPedidos.Rows[0]["d_estatus_pedido"].ToString();
                    txtFecha.Text = dtPedidos.Rows[0]["F_Pedido"].ToString();
                    txtMoneda.Text = dtPedidos.Rows[0]["D_Tipo_Moneda"].ToString();
                    txtSubTotal.Text = Convert.ToDouble(dtPedidos.Rows[0]["subtotal"]).ToString("C");
                    txtIVA.Text = Convert.ToDouble(dtPedidos.Rows[0]["total_iva"]).ToString("C");
                    txtTotalPedido.Text = Convert.ToDouble(dtPedidos.Rows[0]["total_pedido"]).ToString("C");
                    txtTipo_Entrega.Text = dtPedidos.Rows[0]["D_Tipo_Entrega"].ToString();
                    K_Tipo_Entrega = Convert.ToInt32(dtPedidos.Rows[0]["K_Tipo_Entrega"]);
                    //K_Empresa_Entrega = Convert.ToInt32(dtPedidos.Rows[0]["K_Empresa_Entrega"]);
                    if (dtPedidos.Rows[0]["D_Tipo_Entrega"].ToString() == "FORANEA")
                    {
                        pnlForanea.Visible = true;
                        Txt_Empresa_Entrega.Text = dtPedidos.Rows[0]["D_Empresa_Entrega"].ToString();
                        txtNoGuia.Text = dtPedidos.Rows[0]["No_Guia"].ToString();
                    }
                    else
                    {
                        pnlForanea.Visible = false;
                    }
     

                    dgvPedidoDetalle.DataSource = dtPedidos;
                    dtPedidos.DefaultView.RowFilter = "Cantidad>0";

                    foreach (DataGridViewColumn column in dgvPedidoDetalle.Columns)
                    {

                        if (column.Name == "Cantidad_Asignada")
                            column.ReadOnly = false;
                    }

                    int_K_TipoVenta = 0;
                    int_K_TipoVenta = Convert.ToInt32(dtPedidos.Rows[0]["K_TipoVenta"]);

                    if (Convert.ToInt32(dtPedidos.Rows[0]["K_TipoVenta"]) == 2) //Refacciones
                    {
                        dgvPedidoDetalle.Columns["CantidadKgs"].Visible = false;
                        dgvPedidoDetalle.Columns["d_articulo1"].Visible = true;
                        dgvPedidoDetalle.Columns["D_Producto"].Visible = false;
                        dgvInventario.Columns["Lote"].Visible = false;
                    }
                    else
                    {

                        dgvInventario.Columns["Lote"].Visible = true;
                        dgvPedidoDetalle.Columns["d_articulo1"].Visible = true;
                        dgvPedidoDetalle.Columns["D_Producto"].Visible = false;
                    }


                    dtLotes = null;

                    dtLotes = sqlVentas.Sk_consulta_Pedido_detalle_Inventario(int_K_Pedido, 0, 0,Convert.ToInt32(cbxAlmacen.SelectedValue));

                    if (dtLotes != null)
                    {
                        BaseBotonGuardar.Enabled = false;
                        BaseBotonGuardar.Visible = false;
                        BaseBotonBorrar.Enabled = false;
                        BaseBotonBorrar.Visible = false;

                        BaseBotonCancelar.Visible = true;
                        BaseBotonCancelar.Enabled = true;
                        BaseBotonAfectar.Visible = true;
                        BaseBotonAfectar.Enabled = true;

           
                         dtLotes.Columns.Add(new DataColumn("Cantidad_Asignada", typeof(decimal)));
                         dtLotes.Columns.Add(new DataColumn("Cantidad_Asignada_Kgs", typeof(decimal)));
                    

                        foreach (DataRow dr in dtLotes.Rows)
                        {
                            dr["Cantidad_Asignada"] = 0;
                            dr["Cantidad_Asignada_Kgs"] = 0;
                        }
                    }
                    else
                    {
                        BaseBotonCancelar.Visible = false;
                        BaseBotonCancelar.Enabled = false;
                        MessageBox.Show("No Existe Inventario para los Detalles del Pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        BaseMetodoInicio();
                        txtNoPedido.Focus();
                    }

                    SeleccionaDetalle();

                }
            }
            else
            {
                MessageBox.Show("DEBE ESCRIBIR UN NUMERO DE PEDIDO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public override void BaseBotonAfectarClick()
        {
            if (txtTipo_Entrega.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL TIPO DE ENTREGA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipo_Entrega.Focus();
                return;
            }
            dgvInventario.EndEdit();
            DataTable dtPD;
            dtPD = Pedido_Inventario_Type;
            int_K_Pedido = Convert.ToInt32(txtNoPedido.Text);
            foreach (DataRow drow in dtLotes.Rows)
            {
                if (Convert.ToInt32(drow["Cantidad_Asignada"]) > 0)
                {
                    DataRow dr;
                    dr = dtPD.NewRow();
                    dr["K_Pedido"] = int_K_Pedido;
                    dr["K_Pedido_Detalle"] = drow["K_Pedido_Detalle"];
                    if (int_K_TipoVenta == 1) //sistemas
                    {
                        dr["k_Movimiento_Inventario"] = drow["k_Movimiento_Inventario"];
                        dr["k_Movimiento_InventarioPT"] = 0;
                    }
                    else
                    {
                        dr["k_Movimiento_Inventario"] = drow["k_Movimiento_Inventario"];
                        dr["k_Movimiento_InventarioPT"] = 0;
                    }



                    dr["K_Articulo"] = drow["k_articulo"];
                    dr["Cantidad"] = drow["Cantidad_Asignada"];
                    dr["Cantidadkgs"] = drow["Cantidad_Asignada_Kgs"];
                    dr["Lote"] = drow["No_Lote"];

                    dtPD.Rows.Add(dr);
                }
            }

            int ires = 0;
            int int_Consecutivo = 0;
            string strMensaje = "";
            dtPD.Columns.Remove("Cantidadkgs");

            ires = sqlVentas.In_pedido_inventario(dtPD, int_K_TipoVenta, GlobalVar.K_Usuario, GlobalVar.PC_Name, int_K_Pedido, txtObservaciones.Text, ref int_Consecutivo,
               K_Tipo_Entrega, K_Empresa_Entrega, txtNoGuia.Text.Trim(), ref strMensaje);

            if (ires == -2)
            {
                MsgBox msgbox = new MsgBox();
                msgbox.Show(strMensaje, "AVISO");
                Bloquea_Pedido(int_K_Pedido);
                Limpiar();
                BaseMetodoInicio();
                txtNoPedido.Focus();
            }
            else if (ires == -1)
            {
                MsgBox msgbox = new MsgBox();
                msgbox.Show(strMensaje.ToUpper(), "AVISO");
                Limpiar();
                BaseMetodoInicio();
                txtNoPedido.Focus();
            }
            else if (ires == 0)
            {
                MessageBox.Show("Lotes Asignados Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor = Cursors.WaitCursor;
                Imprimir(int_Consecutivo);
                Cursor = Cursors.Default;
                Limpiar();
                BaseMetodoInicio();
            }
        }

        public override void BaseBotonProceso1Click()
        {
            base.BaseBotonProceso1Click();
            INVENTARIOS.Frm_Pedidos_Ptes frm_x_pedidos = new INVENTARIOS.Frm_Pedidos_Ptes();
            Cursor = Cursors.WaitCursor;
            frm_x_pedidos.LlenaDatos();
            if(frm_x_pedidos.dtDatos!=null)
            {
                if (frm_x_pedidos.dtDatos.Rows.Count > 0)
                {
                    frm_x_pedidos.ShowDialog();
                    Cursor = Cursors.Default;

                    if (frm_x_pedidos.K_Pedido > 0)
                    {
                        txtNoPedido.Text = frm_x_pedidos.K_Pedido.ToString();
                        K_Almacen_Pedido = frm_x_pedidos.K_Almacen;
                        if (txtNoPedido.Text.Trim().Length > 0)
                        {
                            BaseBotonBuscarClick();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON PEDIDOS PENDIENTES.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           

        }

        private void dgvInventario_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            DataGridViewRow row = dgvInventario.CurrentRow;

            if (dgvInventario == null)
                return;
            if (dgvInventario.CurrentRow == null)
                return;
            if (dgvPedidoDetalle == null)
                return;
            if (dgvPedidoDetalle.CurrentRow == null)
                return;

            if (Convert.ToInt32(dgvPedidoDetalle.CurrentRow.Cells["K_Pedido_Detalle"].Value) == Convert.ToInt32(dgvInventario.CurrentRow.Cells["K_Pedido_Detalle_I"].Value))
            {
                if (e.ColumnIndex == 7) //cantidad asignada
                {
                    if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                    {
                        dgvInventario.CancelEdit();
                        return;
                    }

                    if (!EsNumero(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                    {
                        dgvInventario.CancelEdit();
                        return;
                    }
                    if (row != null)
                    {
                        if (Convert.ToDecimal(row.Cells["Cantidad_Disponible"].Value) < Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                        {
                            MessageBox.Show("LA CANTIDAD ASIGNADA NO PUEDE SER MAYOR A LA CANTIDAD DISPONIBLE, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvInventario.CancelEdit();
                            return;
                        }

                        decimal dCantidadDetalle = Convert.ToDecimal(dgvPedidoDetalle.CurrentRow.Cells["Cantidad"].Value);
                        decimal dCantidadAsiganda = Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString());
                        decimal dkgs_Unitario = Convert.ToDecimal(dgvInventario.CurrentRow.Cells["kgs_Unitario"].Value);
                        foreach (DataGridViewRow grow in dgvInventario.Rows)
                        {
                            if (grow.Index != e.RowIndex)
                            {
                                dCantidadAsiganda = dCantidadAsiganda + Convert.ToDecimal(grow.Cells["Cantidad_Asignada"].Value);
                            }
                        }

                        if (dCantidadDetalle < dCantidadAsiganda)
                        {
                            MessageBox.Show("LA CANTIDAD ASIGNADA NO PUEDE SER MAYOR A LA CANTIDAD DEL DETALLE, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvInventario.CancelEdit();
                            return;
                        }
                        // PARA VALIDAR LA ASIGNACION DE PRESENTACIONES QUE NO SON COMPLETAS
                        //decimal KgsAsignados = (dkgs_Unitario * Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()));
                        //decimal KgsRequeridos = Convert.ToDecimal(dgvPedidoDetalle.CurrentRow.Cells["CantidadKgs"].Value);
                        //if (KgsAsignados >= KgsRequeridos)
                        //{
                        //    dgvInventario.Rows[e.RowIndex].Cells["Cantidad_Asignada_kgs"].Value = KgsAsignados;
                        //}
                        //else
                        //{
                        //    dgvInventario.Rows[e.RowIndex].Cells["Cantidad_Asignada_kgs"].Value = KgsRequeridos;
                        //}
                        //dgvInventario.Rows[e.RowIndex].Cells["Cantidad_Asignada_kgs"].Value = dkgs_Unitario * Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString());
                    }
                }
            }

        }

        private void dgvInventario_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            decimal dCantidadDetalle = 0;
            decimal dCantidadPedido = 0;
            decimal dCantidadAsignada = 0;
            decimal dCantidadAsignadaPedido = 0;

            if (dtLotes == null)
            {
                return;
            }
            bool temporal = false;
            foreach (DataGridViewRow grdRow in dgvPedidoDetalle.Rows)
            {
                dCantidadDetalle = Convert.ToDecimal(grdRow.Cells["Cantidad"].Value);
                dCantidadPedido += Convert.ToDecimal(grdRow.Cells["Cantidad"].Value);
                dCantidadAsignada = 0;

                foreach (DataRow drow in dtLotes.Rows)
                {
                    if (Convert.ToInt32(grdRow.Cells["K_Pedido_Detalle"].Value) == Convert.ToInt32(drow["K_Pedido_Detalle"]))
                    {
                        dCantidadAsignada = dCantidadAsignada + Convert.ToDecimal(drow["Cantidad_Asignada"]);
                        dCantidadAsignadaPedido = dCantidadAsignadaPedido + Convert.ToDecimal(drow["Cantidad_Asignada"]);
                    }
                }

                DataGridViewRow grdrow;
                grdrow = dgvPedidoDetalle.Rows[grdRow.Index];

                if (dCantidadDetalle == dCantidadAsignada)
                {
                    grdrow.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
                    grdrow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
                }
                else
                {
                    grdrow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    grdrow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
                }
                if (dCantidadDetalle == dCantidadAsignadaPedido)
                {
                    temporal = true;
                }


            }

            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;

            DataGridViewRow row = dgvInventario.CurrentRow;
            row.DefaultCellStyle.Font = new Font(this.Font.ToString(), 10);
            row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            if(dgvInventario.SelectedCells.Count>0)
            {
                foreach(DataGridViewRow rowC in dgvInventario.Rows)
                {
                    if (rowC.Cells["Cantidad_Asignada"].Selected)
                        rowC.Cells["Cantidad_Asignada"].Selected = false;
                }
            }
            //if (Convert.ToInt32(dgvPedidoDetalle.CurrentRow.Cells["K_Pedido_Detalle"].Value) == Convert.ToInt32(dgvInventario.CurrentRow.Cells["K_Pedido_Detalle_I"].Value))
            //{
            //    if (e.ColumnIndex == 5) //cantidad asignada
            //    {
            //        decimal dCantidadDetalle = Convert.ToDecimal(dgvPedidoDetalle.CurrentRow.Cells["Cantidad"].Value);
            //        decimal dCantidadAsiganda = 0;

            //        foreach (DataGridViewRow grow in dgvInventario.Rows)
            //        {

            //            dCantidadAsiganda = dCantidadAsiganda + Convert.ToDecimal(grow.Cells["Cantidad_Asignada"].Value);



            //        }

            //        DataGridViewRow grdrow;
            //        grdrow = dgvPedidoDetalle.CurrentRow;

            //        if (dCantidadDetalle == dCantidadAsiganda)
            //        {
            //            grdrow.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            //            grdrow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            //            // grow.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
            //        }
            //        else
            //        {
            //            grdrow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            //            grdrow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            //        }
            //    }
            //}
        }

        private void dgvInventario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dgvInventario_KeyPress);
            e.Control.TextChanged += new EventHandler(dgvInventario_TextChanged);
            if (dgvInventario.RowCount > 0)
            {
                DataGridViewRow row = dgvInventario.CurrentRow;
                row.DefaultCellStyle.Font = new Font(this.Font.ToString(), 30);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void dgvInventario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    Int32 VALOR = 0;

                    if (!Int32.TryParse(textBox.Text.Trim(),out VALOR))
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch
            {

            }
        }

        private void dgvInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!dgvInventario.CurrentCell.IsInEditMode)
                {
                    //grdDetalle.CurrentCell.ed = true;
                    dgvInventario.BeginEdit(true);
                    return;
                }

                if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;


                    if (Convert.ToDecimal((Boolean)(textBox.Text.Length == 0) ? "0" : textBox.Text.Replace("$", "0")) == 0)
                    {
                        //Si entra
                        e.Handled = false;
                        return;
                    }


                    string[] parts = textBox.Text.Split('.'); // result.Split('.');

                    if (parts.Length > 1)
                    {
                        if ((parts[1].Length > 1 && parts.Length > 2) && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }


                }
                else
                    e.Handled = true;
            }
        }

        private void dgvPedidoDetalle_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventario != null)
            {
                if (dgvInventario.CurrentCell != null)
                {
                    if (dgvInventario.CurrentCell.IsInEditMode)
                    {
                        dgvInventario.EndEdit();
                    }
                }
            }
        }

        private void dgvPedidoDetalle_SelectionChanged(object sender, EventArgs e)
        {
            SeleccionaDetalle();
        }

        private void btn_Buscar_Tipo_Entrega_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Entrega frm = new Busquedas.Frm_Busca_Tipo_Entrega();
            frm.ShowDialog();

            if (K_Tipo_Entrega != frm.LLave_Seleccionado)
            {
                K_Tipo_Entrega = frm.LLave_Seleccionado;
                txtTipo_Entrega.Text = frm.Descripcion_Seleccionado;
                D_Tipo_Entrega = frm.Descripcion_Seleccionado;

                if (D_Tipo_Entrega == "FORANEA")
                {
                    txtNoGuia.Enabled = true;
                    ucEmpresaEntrega1.Enabled = true;
                }
                else
                {
                    txtNoGuia.Enabled = false;
                    ucEmpresaEntrega1.Enabled = false;
                }
            }
        }

        private bool Bloquea_Pedido(Int32 K_Pedido)
        {
            try
            {
                sqlCompras.GP_Bloquea_Movimientos(0, K_Pedido, 0);
                return true;
            }
            catch
            {

                return false;
            }

        }

        private void Imprimir( int Consecutivo)
        {         
            DataTable dtReporte = new DataTable();
            dtReporte = sqlVentas.Gp_RepRemision(Consecutivo);

            if (dtReporte == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION CON LOS PARAMETROS SOLICITADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtReporte.Rows.Count <= 0)
            {
                MessageBox.Show("NO FUE POSIBLE LOCALIZAR NINGUN REGISTRO CON LOS PARAMETROS SOLICITADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BaseErrorResultado = false;

            if (dtReporte != null)
            {
                ReportDocument rpt = new ProbeMedic.INVENTARIOS.RPT_Remision_Pedidos();
                ReporteTitulo = "SALIDA DE MATERIAL";
                ReporteModulo = "Remisión de Pedido";
                ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private void Limpiar()
        {
            int_K_TipoVenta = 0;
            dtLotes = null;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;

            int_K_Pedido = 0;
            txtNoPedido.Text = "";
            txtNoPedido.Enabled = true;
            txtObservaciones.Text = "";

            txtCliente.Text = "";
            txtEstatus.Text = "";
            txtFecha.Text = "";
            txtMoneda.Text = "";
           
            txtSubTotal.Text = "";
            txtIVA.Text = "";
            txtTotalPedido.Text = "";

            K_Tipo_Entrega = 0;
            txtTipo_Entrega.Text = "";
            Txt_Empresa_Entrega.Text = "";
            ucEmpresaEntrega1.K_Empresa_Entrega = 0;
            ucEmpresaEntrega1.txtEmpresaEntrega.Text = "";
            txtNoGuia.Text = "";

            dgvInventario.DataSource = null;
            dgvPedidoDetalle.DataSource = null;            
        }

        private void CargaAlmacen()
        {

            //dtAlmacen.Rows.Clear();
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            if (GlobalVar.K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina,GlobalVar.K_Empresa);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["D_Usuario"] = "";
                dr["K_Usuario"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                cbxAlmacen.SelectedIndex = 1;
            }


        }

        private void SeleccionaDetalle()
        {
            int iIndex = 0;
            if (dgvPedidoDetalle == null)
                return;
            if (dgvPedidoDetalle.Rows.Count == 0)
                return;

            if (dgvPedidoDetalle.CurrentRow != null)
                iIndex = dgvPedidoDetalle.CurrentRow.Index;

            int intK_Pedido_Detalle = 0;
            int Cantidad_Pedido = 0;
            intK_Pedido_Detalle = Convert.ToInt32(dgvPedidoDetalle.Rows[iIndex].Cells["K_Pedido_Detalle"].Value);
            Cantidad_Pedido = Convert.ToInt32(dgvPedidoDetalle.Rows[iIndex].Cells["Cantidad"].Value);

            //dgvInventario.DataSource = null;
            if (dtLotes != null)
            {
                if (dtLotes.Rows.Count > 0)
                {
                    dgvInventario.DataSource = dtLotes.AsEnumerable().Where(p => p.Field<int>("K_Pedido_Detalle") == intK_Pedido_Detalle).AsDataView(); ;
                    dgvInventario.MultiSelect = false;


                    if (dgvInventario.Rows.Count > 0)
                    {
                        if ((Int32)dgvInventario.Rows[0].Cells[10].Value == intK_Pedido_Detalle)
                        {
                            bool B_Existe = false;
                            foreach(DataRow row in dtLotes.Rows)
                            {
                                if(Convert.ToInt32(row["K_Pedido_Detalle"])  == intK_Pedido_Detalle)
                                {
                                    if (Convert.ToInt32(row["Cantidad_Asignada"]) > 0)
                                        B_Existe = true;
                                }
                            
                            }

                            if(!B_Existe)
                            {
                                if ((Int32)(dgvInventario.Rows[0].Cells["Cantidad_Disponible"].Value) >= (Cantidad_Pedido))
                                {
                                    dgvInventario.Rows[0].Cells["Cantidad_Asignada"].Value = Cantidad_Pedido;
                                }
                                else
                                {
                                    dgvInventario.Rows[0].Cells["Cantidad_Asignada"].Value = 0;
                                }
                                dgvInventario.EditMode = DataGridViewEditMode.EditOnEnter;
                            }
                        }
                            
                        //dgvInventario.Rows[0].DefaultCellStyle.Font = new Font(this.Font.ToString(), 30);
                        //dgvInventario.Rows[0].DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
                        dgvInventario.Rows[0].Cells["Cantidad_Asignada"].Selected = true;
                        //dgvInventario.Focus();
                        B_NoEntrar = true;
                        //if (dgvInventario.RowCount > 0)
                        //{
                        //    //Recorremos el grid para poner en el primer row la cantidad solicitada
                        //    foreach (DataGridViewRow row_cantidad_iniciales in dgvInventario.Rows)
                        //    {
                        //        if (int.Parse(row_cantidad_iniciales.Cells[10].Value.ToString()) == intK_Pedido_Detalle && row_cantidad_iniciales.Index == 0)
                        //        {
                        //            row_cantidad_iniciales.Cells["Cantidad_Asignada"].Value = Cantidad_Pedido.ToString();
                        //        }
                        //    }
                        //    //Resaltamos el color del primer row que carga por defecto la consulta
                        //    DataGridViewRow row = dgvInventario.CurrentRow;
                        //    if (row != null)
                        //        row.DefaultCellStyle.Font = new Font(this.Font.ToString(), 30);
                        //    row.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
                        //}

                    }


                }

            }
        }

        private bool blnCeldaImportes()
        {
            if (dgvInventario.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (dgvInventario.CurrentCell.ColumnIndex == 7);
        }

        private bool ValidaPedido(Int32 K_Almacen,Int32 K_Pedido)
        {
            DataTable DtAlmacenesUsuario = sqlCatalogos.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina,GlobalVar.K_Empresa);

            if(DtAlmacenesUsuario!=null)
            {
                if (DtAlmacenesUsuario.Rows.Count > 0)
                {
                    var Results = from myRow in DtAlmacenesUsuario.AsEnumerable()
                                  where myRow.Field<int>("K_Almacen") == K_Almacen
                                  select myRow;
                    DataView View = Results.AsDataView();

                    if(View.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

    }
}
