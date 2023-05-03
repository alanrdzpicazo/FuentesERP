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
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Facturas_Asigna_Inventario : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        SQLCatalogos sqlCatalogos = new SQLCatalogos();

        DataTable dtPedidos;
        DataTable dtLotes;

        DataTable dtAlmacen = new DataTable();

        string strMensaje = "";
        int int_K_TipoVenta = 0;
        int int_K_Factura = 0;
        bool B_NoEntrar;

        public Int32 K_Tipo_Entrega = 0;
        public string D_Tipo_Entrega = string.Empty;

        public Frm_Facturas_Asigna_Inventario()
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
            BaseBotonProceso1.Click += new EventHandler(BaseBotonProceso1_Click);
           
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
            BaseBotonAfectar.Width = 120;
            BaseBotonAfectar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));

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

        void BaseBotonProceso1_Click(object sender, EventArgs e)
        {
            //if (txtNoPedido.Text.ToString().Length <= 0)
            //{
            //    MessageBox.Show("SE DEBE INDICAR EL No DE PEDIDO AL CUAL DESEA ELIMINAR LA ASIGNACION...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if (txtNoPedido.CanFocus)
            //        txtNoPedido.Focus();
            //    return;
            //}
            //DialogResult dlg = MessageBox.Show("¿ DESEA ELIMINAR LA ASIGNACION DEL PEDIDO No. "+txtNoPedido.Text.ToString()+System.Environment.NewLine+
            //                                   "Y REGRESAR EL INVENTARIO ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dlg == DialogResult.Yes)
            //{
            //    int Resultado = 0;
            //    strMensaje = "";
            //    Resultado = sqlVentas.spg_CancelaAsignacion_PedidoInventario(GlobalVar.K_Oficina, Convert.ToInt32(txtNoPedido.Text), GlobalVar.K_Usuario, GlobalVar.PC_Name, ref strMensaje);
            //    if (Resultado == -1)
            //    {
            //        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("EL PEDIDO Y EL INVENTARIO HAN SIDO LIBERADOS CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtNoPedido.Text = string.Empty;
            //        if (BaseBotonProceso1.Visible)
            //            BaseBotonProceso1.Visible = false;
            //    }
            //}

        }

        public override void BaseBotonBuscarClick()
        {
            strMensaje = "";
            int int_Consecutivo = 0;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso1.Visible = false;

            if (!string.IsNullOrEmpty(txtNoFactura.Text))
            {
                dtPedidos = sqlVentas.Sk_ConsultaFacturaporAsignar(Convert.ToInt32(txtNoFactura.Text), GlobalVar.K_Oficina, ref int_Consecutivo, ref strMensaje);
                if (strMensaje != "")
                {
                    if (strMensaje == "-4")
                    {
                        BaseBotonProceso1.ToolTipText = "Cancelar Asignacion y Regresar el Inventario";
                        //BaseBotonProceso1.Image = Properties.Resources.CancelaSolicitud; //((System.Drawing.Image)(imageList1.Images["report.png"]));
                        BaseBotonProceso1.Text = "Cancelar Asig.";
                        BaseBotonProceso1.Width = 100;
                        BaseBotonProceso1.Enabled = true;
                        BaseBotonProceso1.Visible = true;

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
                        return;
                    }
                }

                if (dtPedidos == null)
                {
                    MessageBox.Show("NO SE ENCONTRO EL PEDIDO No. " + txtNoFactura.Text.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoFactura.Text = string.Empty;
                    return;
                }
                else
                {
                    BaseBotonCancelar.Visible = true;
                    BaseBotonCancelar.Enabled = true;
                    //panel2.Enabled = false;
                    txtNoFactura.Enabled = false;

                    int_K_Factura = Convert.ToInt32(dtPedidos.Rows[0]["K_Factura"]);
                    txtCliente.Text = dtPedidos.Rows[0]["D_Cliente"].ToString();
                    txtFecha.Text = dtPedidos.Rows[0]["F_Factura"].ToString();
                    txtMoneda.Text = dtPedidos.Rows[0]["D_Tipo_Moneda"].ToString();
                    txtSubTotal.Text = Convert.ToDouble(dtPedidos.Rows[0]["subtotal"]).ToString("C");
                    txtIVA.Text = Convert.ToDouble(dtPedidos.Rows[0]["total_iva"]).ToString("C");
                    txtTotalPedido.Text = Convert.ToDouble(dtPedidos.Rows[0]["Total_Factura"]).ToString("C");

                    dgvPedidoDetalle.DataSource = dtPedidos;

                    foreach (DataGridViewColumn column in dgvPedidoDetalle.Columns)
                    {
                        if (column.Name == "Cantidad_Asignada")
                            column.ReadOnly = false;
                    }

                    dtLotes = null;

                    dtLotes = sqlVentas.Sk_consulta_Factura_detalle_Inventario(int_K_Factura, 0);

                    if (dtLotes != null)
                    {
                        if(dtLotes.Rows.Count>0)
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
                        }
                       
                    }
                    else
                    {
                        BaseBotonCancelar.Visible = false;
                        BaseBotonCancelar.Enabled = false;
                        MessageBox.Show("No Existe Inventario para los Detalles de la Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        BaseMetodoInicio();
                        txtNoFactura.Focus();
                    }

                    SeleccionaDetalle();
                }
            }
            else
            {
                MessageBox.Show("DEBE ESCRIBIR UN NUMERO DE FACTURA.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            if (ucEmpresaEntrega1.txtEmpresaEntrega.Text.Trim().Length == 0 && D_Tipo_Entrega == "FORANEA")
            {
                MessageBox.Show("FALTA SELECCIONAR LA EMPRESA ENTREGA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucEmpresaEntrega1.Focus();
                return;
            }
            if (txtNoGuia.Text.Trim().Length == 0 && D_Tipo_Entrega == "FORANEA")
            {
                MessageBox.Show("FALTA CAPTURAR EL NÚMERO DE GUIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoGuia.Focus();
                return;
            }


            DataTable dtPD;
            dtPD = PDF_Inventario_Type;
            int_K_Factura = Convert.ToInt32(txtNoFactura.Text);
            foreach (DataRow drow in dtLotes.Rows)
            {
                if (Convert.ToInt32(drow["Cantidad_Asignada"]) > 0)
                {
                    DataRow dr;
                    dr = dtPD.NewRow();
                    dr["K_Factura"] = int_K_Factura;
                    dr["K_Factura_Detalle"] = drow["K_Factura_Detalle"];
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

                    dr["Lote"] = drow["No_Lote"];

                    dtPD.Rows.Add(dr);
                }
            }

            int ires = 0;
            int int_Consecutivo = 0;
            string strMensaje = "";

            ires = sqlVentas.In_Factura_inventario(dtPD, int_K_TipoVenta, GlobalVar.K_Usuario, GlobalVar.PC_Name, int_K_Factura, K_Tipo_Entrega, ucEmpresaEntrega1.K_Empresa_Entrega, txtNoGuia.Text.Trim(), txtObservaciones.Text, ref int_Consecutivo, ref strMensaje);

            if (ires < 0)
            {
                MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                MessageBox.Show("Lotes Asignados Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Imprimir(int_Consecutivo);
                Limpiar();
            }
        }

        public override void BaseBotonCancelarClick()
        {
            panel2.Enabled = true;
            Limpiar();
            if (txtNoFactura.CanFocus)
                txtNoFactura.Focus();
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

        private void dgvPedidoDetalle_SelectionChanged(object sender, EventArgs e)
        {
            SeleccionaDetalle();
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

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            /*Resaltamos el color del row seleccionado y en el Evento: dgvInventario_CellValidated cuando ya
              *no este seleccionado al terminar de validar, lo ponemos con sus atributos correctos.*/
            if (dgvInventario.RowCount > 1)
            {
                dgvInventario.EndEdit();

                DataGridViewRow row = dgvInventario.CurrentRow;
                row.DefaultCellStyle.Font = new Font(this.Font.ToString(), 30);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);

            }
        }

        //Tiene lugar cuando la celda esta validando
        private void dgvInventario_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = dgvInventario.CurrentRow;
            if (dgvInventario == null)
                return;
            if (dgvInventario.CurrentRow == null)
                return;
            if (dgvPedidoDetalle == null)
                return;
            if (dgvPedidoDetalle.CurrentRow == null)
                return;

            if (Convert.ToInt32(dgvPedidoDetalle.CurrentRow.Cells["K_Factura_Detalle"].Value) == Convert.ToInt32(dgvInventario.CurrentRow.Cells["K_Factura_Detalle_I"].Value))
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
                        dgvInventario.Rows[e.RowIndex].Cells["Cantidad_Asignada_kgs"].Value = dkgs_Unitario * Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString());
                    }
                }
            }
            if (dgvInventario.RowCount > 1)
            {
                row.DefaultCellStyle.Font = new Font(this.Font.ToString(), 30);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }

        //Tiene lugar cuando la celda a dejado de validarse
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
                    if (Convert.ToInt32(grdRow.Cells["K_Factura_Detalle"].Value) == Convert.ToInt32(drow["K_Factura_Detalle"]))
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
            if (dgvInventario.RowCount > 1)
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
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= Int32.MaxValue)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                               "EL VALOR MÁXIMO PERMITDO ES DE. " + Int32.MaxValue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtNoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar))||( e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void txtNoFactura_TextChanged(object sender, EventArgs e)
        {
            if (txtNoFactura.Text.Trim().Length > 0)
            {
                if (Convert.ToDecimal(txtNoFactura.Text.Trim()) > Int32.MaxValue)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                        "EL VALOR MÁXIMO PERMITDO ES DE. "+Int32.MaxValue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoFactura.Text = string.Empty;
                    return;
                }
            }          
            if (BaseBotonProceso1.Visible)
                BaseBotonProceso1.Visible = false;
        }

        private void txtNoGuia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoGuia_TextChanged(object sender, EventArgs e)
        {
            if (txtNoGuia.Text.Trim().Length > 0)
                if (Convert.ToDecimal(txtNoGuia.Text.Trim()) > Int32.MaxValue)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                        "EL VALOR MÁXIMO PERMITDO ES DE. " + Int32.MaxValue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoGuia.Text = string.Empty;
                }
        }

        private void Limpiar()
        {
            int_K_TipoVenta = 0;
            dtLotes = null;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;

            int_K_Factura = 0;
            txtNoFactura.Text = "";
            txtNoFactura.Enabled = true;
            txtObservaciones.Text = "";

            txtCliente.Text = "";
            txtFecha.Text = "";
            txtMoneda.Text = "";
            txtSubTotal.Text = "";
            txtIVA.Text = "";
            txtTotalPedido.Text = "";

            K_Tipo_Entrega = 0;
            txtTipo_Entrega.Text = "";
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
                dr["K_Usuario"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Usuario"] = "";
                dr["D_Almacen"] = "[Selecccionar]";
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

            int intK_Factura_Detalle = 0;
            int Cantidad_Factura = 0;
            intK_Factura_Detalle = Convert.ToInt32(dgvPedidoDetalle.Rows[iIndex].Cells["K_Factura_Detalle"].Value);
            Cantidad_Factura = Convert.ToInt32(dgvPedidoDetalle.Rows[iIndex].Cells["Cantidad"].Value);

            //dgvInventario.DataSource = null;
            if (dtLotes != null)
            {
                dgvInventario.DataSource = dtLotes.AsEnumerable().Where(p => p.Field<int>("K_Factura_Detalle") == intK_Factura_Detalle).AsDataView(); ;
                dgvInventario.EditMode = DataGridViewEditMode.EditOnEnter;
                dgvInventario.MultiSelect = false;
                if ((Int32)dgvInventario.Rows[0].Cells[10].Value == intK_Factura_Detalle)
                {
                    if ((Int32)(dgvInventario.Rows[0].Cells["Cantidad_Disponible"].Value) >= (Cantidad_Factura))
                    {
                        dgvInventario.Rows[0].Cells["Cantidad_Asignada"].Value = Cantidad_Factura;
                    }
                    else
                    {
                        dgvInventario.Rows[0].Cells["Cantidad_Asignada"].Value = 0;
                    }

                }
                dgvInventario.Rows[0].DefaultCellStyle.Font = new Font(this.Font.ToString(), 30);
                dgvInventario.Rows[0].DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
                dgvInventario.Rows[0].Cells["Cantidad_Asignada"].Selected = true;
                dgvInventario.Focus();
                B_NoEntrar = true;
            }
        }

        private void Imprimir(int Consecutivo)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dtReporte = null;
            ReportDocument rpt = new ReportDocument();

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
            ReporteTitulo = "SALIDA DE MATERIAL";
            rpt = new ProbeMedic.INVENTARIOS.RPT_Remision_Pedidos();

            ReportedtCorreo = null; //dtReporte
            string Version = "";//dtReporte.Rows[0]["Version"].ToString();

            ReporteModulo = "REMISION";

            ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, Version);
            ReporteRPT = rpt;

            Frm_Reportes frmReporte = new Frm_Reportes();
            frmReporte.P_Titulo = ReporteTitulo;
            frmReporte.P_ReporteRPT = ReporteRPT;
            frmReporte.P_TablaCorreo = ReportedtCorreo;
            frmReporte.ShowDialog();
            Cursor = Cursors.Default;
        }

        private bool blnCeldaImportes()
        {
            if (dgvInventario.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (dgvInventario.CurrentCell.ColumnIndex == 7);
        }


    }
}
