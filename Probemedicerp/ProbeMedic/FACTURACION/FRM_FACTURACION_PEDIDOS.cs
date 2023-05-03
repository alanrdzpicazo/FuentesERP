using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using ProbeMedic.AppCode.DCC;

namespace ProbeMedic.FACTURACION
{
    public partial class FRM_FACTURACION_PEDIDOS : FormaBase
    {
        SQLCatalogos sqlPxe = new SQLCatalogos();
        SQLVentas sqlVentas = new SQLVentas();
        SQLPedidos sqlPedidos = new SQLPedidos();

        DataTable dtDatos = new DataTable();
        DataTable dtDetalle = new DataTable();
        DataTable dtPaso = new DataTable();
        DataTable dtAlmacen = new DataTable();

        int numGuias = 0;

        public FRM_FACTURACION_PEDIDOS()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            BaseBotonProceso1.Image = Properties.Resources.Aceptar;
            BaseBotonProceso1.Text = "Facturar";
            BaseBotonProceso1.ToolTipText = "Facturar Pedidos Seleccionados..";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = false;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["if_edit-clear_118917.png"]));
            BaseBotonProceso2.Text = "Limpiar";
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = false;

            decimal a = Convert.ToDecimal(grdDatos.Width - 20) / Convert.ToDecimal(17);
            int b = Convert.ToInt32(a);

            grdDatos.Columns["Seleccionar"].Width = 20;
            grdDatos.Columns["K_Pedido"].Width = b;
            grdDatos.Columns["B_Remisionado"].Width = b;
            grdDatos.Columns["K_Remision"].Width = b;
            grdDatos.Columns["K_Cliente"].Width = b;
            grdDatos.Columns["K_Paciente"].Width = b;
            grdDatos.Columns["D_Oficina"].Width = b;
            grdDatos.Columns["D_Almacen"].Width = b;
            grdDatos.Columns["D_Paciente"].Width = b;
            grdDatos.Columns["Descuento"].Width = b;
            grdDatos.Columns["SubTotal"].Width = b;
            grdDatos.Columns["Total_Iva"].Width = b;
            grdDatos.Columns["Total_Pedido"].Width = b;
            grdDatos.Columns["D_Cliente"].Width = b;
            grdDatos.Columns["Coaseguro_Pedido"].Width = b;
            grdDatos.Columns["D_Canal_Distribucion_Cliente"].Width = b;
            grdDatos.Columns["B_SurtidoCompleto"].Width = b;
            grdDatos.Columns["F_Registro"].Width = b;

            grdDatos.AutoGenerateColumns = false;
            grdDatos.ScrollBars = ScrollBars.Both;
            WindowState = FormWindowState.Maximized;

            cargaAlmacenes();

            if (rbPedidos.Checked)
                cbxAlmacen.Enabled = false;
            else if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = true;

        }

        public override void BaseBotonBuscarClick()
        {
            // SOLO PEDIDOS SIN REMISIONAR o PEDIDOS DE VENTAS PRIVADA
            if (rbPedidos.Checked)
            {
                dtDatos = sqlPedidos.SK_Pedidos_Factura(txtClaveCliente.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClaveCliente.Text.Trim()),
                                                         txtClavePaciente.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClavePaciente.Text.Trim()),
                                                         txtDocumento.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtDocumento.Text.Trim()),
                                                         0,
                                                         dtpInicial.Value,
                                                         dtpFinal.Value,
                                                         2,
                                                         Convert.ToInt32(cbxAlmacen.SelectedValue));
            }
            // SOLO PEDIDOS CON REMISION o PEDIDO DE ASEGURADORAS
            if (rbRemisiones.Checked)
            {
                dtDatos = sqlPedidos.SK_Pedidos_Factura(txtClaveCliente.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClaveCliente.Text.Trim()),
                                                         txtClavePaciente.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClavePaciente.Text.Trim()),
                                                         0, 
                                                         txtDocumento.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtDocumento.Text.Trim()),
                                                         dtpInicial.Value,
                                                         dtpFinal.Value,
                                                         1,
                                                         Convert.ToInt32(cbxAlmacen.SelectedValue));
            }
            // SOLO PEDIDOS CON REMISION Y CON COASEGURO
            if (rbCoaseguro.Checked)
            {
                dtDatos = sqlPedidos.SK_Pedidos_Factura(txtClaveCliente.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClaveCliente.Text.Trim()),
                                                         txtClavePaciente.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtClavePaciente.Text.Trim()),
                                                         txtDocumento.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtDocumento.Text.Trim()),
                                                         0,
                                                         dtpInicial.Value, 
                                                         dtpFinal.Value,
                                                         0,
                                                         Convert.ToInt32(cbxAlmacen.SelectedValue));
            }
            // FACTURACION DIRECTA
            if (!rbtnPrivada.Checked)
            {
                if (dtDatos == null)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpia();
                    return;
                }
                else if (dtDatos != null)
                {
                    if(dtDatos.Rows.Count>0)
                    {
                        dtDatos.Columns.Add(new DataColumn("Seleccionar", typeof(bool)));

                        foreach (DataRow dr in dtDatos.Rows)
                        {
                            dr["Seleccionar"] = false;
                        }
                        dtDatos.DefaultView.Sort = "F_Registro DESC,K_Pedido DESC";
                        grdDatos.DataSource = dtDatos;

                        BaseBotonProceso2.Visible = true;
                        BaseBotonProceso2.Enabled = true;
                    }              
                }
                else
                { 
                    BaseBotonProceso2.Visible = true;
                    BaseBotonProceso2.Enabled = false;
                }

            }


        }

        public override void BaseBotonProceso1Click()
        {
            bool B_Entrar = true;
            Cursor = Cursors.WaitCursor;
            if (rbPedidos.Checked)
            {
                int Contador = 0;
                FACTURACION.FRM_REGISTRA_FACTURAS_PEDIDOS frm = new FACTURACION.FRM_REGISTRA_FACTURAS_PEDIDOS();
                foreach (DataGridViewRow RowGrid in grdDatos.Rows)
                {
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)RowGrid.Cells[0];

                    if (chk != null)
                    {
                        if ((bool)((chk.Value.ToString() == "") ? false : chk.Value) == true)
                        {
                            Contador += 1;
                            if (txtDocumento.Text.Trim().Length == 0)
                            {
                                dtPaso = sqlVentas.Sk_pedidos_detalle(Convert.ToInt32(RowGrid.Cells["K_Pedido"].Value.ToString()));

                                if (dtPaso == null)
                                {
                                    MessageBox.Show(String.Format("EL PEDIDO [{0}] NO CUENTA CON DETALLE DE ARTICULOS!...", RowGrid.Cells["K_Pedido"].Value.ToString()), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
      
                                }
                            }
                            else
                            {
                                DataTable dtPaso = sqlVentas.Sk_pedidos_detalle(Convert.ToInt32(txtDocumento.Text));
                                if (dtPaso == null)
                                {
                                    MessageBox.Show(String.Format("EL PEDIDO [{0}] NO CUENTA CON DETALLE DE ARTICULOS!...", txtDocumento.Text.Trim(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning));
                                    return;

                                }
                            }
                            if (B_Entrar == true)
                            {
                                frm.K_OficinaInt = Convert.ToInt32(RowGrid.Cells["K_Oficina"].Value.ToString());
                                frm.D_OficinaString = RowGrid.Cells["D_Oficina"].Value.ToString();
                                frm.K_AlmacenInt = Convert.ToInt32(RowGrid.Cells["K_Almacen"].Value.ToString());
                                frm.K_MedicoInt = RowGrid.Cells["K_Medico"].Value.ToString() !=""? Convert.ToInt32(RowGrid.Cells["K_Medico"].Value.ToString()):0;
                                frm.D_MedicoString = RowGrid.Cells["D_Medico"].Value.ToString() != "" ? RowGrid.Cells["D_Medico"].Value.ToString():"";
                                frm.K_PacienteInt = RowGrid.Cells["K_Paciente"].Value.ToString() !=""?Convert.ToInt32(RowGrid.Cells["K_Paciente"].Value.ToString()):0;
                                frm.D_PacienteString = RowGrid.Cells["D_Paciente"].Value.ToString()!=""? RowGrid.Cells["D_Paciente"].Value.ToString():"";
                                frm.K_Paciente_DireccionInt = RowGrid.Cells["K_Paciente_Direccion"].Value.ToString() !=""?Convert.ToInt32(RowGrid.Cells["K_Paciente_Direccion"].Value.ToString()):0;
                                frm.K_ClienteInt = Convert.ToInt32(RowGrid.Cells["K_Cliente"].Value.ToString());
                                frm.K_AsesorInt = RowGrid.Cells["K_Asesor"].Value.ToString() != DBNull.Value.ToString() ? Convert.ToInt32(RowGrid.Cells["K_Asesor"].Value.ToString()) : 0;
                                frm.NombreString = grdDatos.CurrentRow.Cells["Nombre"].Value.ToString() != "" ? grdDatos.CurrentRow.Cells["Nombre"].Value.ToString() : DBNull.Value.ToString();
                                frm.D_ClienteString = RowGrid.Cells["D_Cliente"].Value.ToString();
                                frm.K_Cliente_Domicilio_FiscalInt = Convert.ToInt32(RowGrid.Cells["K_Cliente_Domicilio_Fiscal"].Value.ToString());
                                frm.D_Cliente_Domicilio_FiscalString = RowGrid.Cells["Direccion_Fiscal"].Value.ToString();
                                frm.K_Canal_DistribucionInt = Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Canal_Distribucion_Cliente"].Value.ToString());
                                frm.D_Canal_DistrbucionString = grdDatos.CurrentRow.Cells["D_Canal_Distribucion_Cliente"].Value.ToString();
                                frm.F_Vencimiento = Convert.ToDateTime(RowGrid.Cells["F_Vencimiento"].Value.ToString());
                                frm.ObservacionesString = RowGrid.Cells["Nota"].Value.ToString();
                                frm.K_PedidoInt = Convert.ToInt32(RowGrid.Cells["K_Pedido"].Value.ToString());
                                frm.FolioString = RowGrid.Cells["K_Pedido"].Value.ToString();
                                frm.SiniestroString = RowGrid.Cells["Siniestro_Pedido"].Value.ToString() != DBNull.Value.ToString() ? RowGrid.Cells["Siniestro_Pedido"].Value.ToString() : DBNull.Value.ToString();
                                frm.ReclamacionString = RowGrid.Cells["Reclamacion_Pedido"].Value.ToString() != "" ? RowGrid.Cells["Reclamacion_Pedido"].Value.ToString() : DBNull.Value.ToString();
                                frm.CoaseguroString = RowGrid.Cells["Coaseguro_Pedido"].Value.ToString() != "" ? RowGrid.Cells["Coaseguro_Pedido"].Value.ToString() : DBNull.Value.ToString();
                                frm.PorcentajeDescuentoDecimal = Convert.ToDecimal(RowGrid.Cells["Porcentaje_Descuento"].Value.ToString());
                                frm.CoaseguroDecimal = RowGrid.Cells["Coaseguro_Pedido"].Value.ToString() != "" ? Convert.ToDecimal(RowGrid.Cells["Coaseguro_Pedido"].Value.ToString()) : 0;
                                frm.PorcentajeCoaseguroDecimal = RowGrid.Cells["PorcentajeCoaseguro"].Value.ToString() != "" ? Convert.ToDecimal(RowGrid.Cells["PorcentajeCoaseguro"].Value.ToString()) : 0;
                                frm.SubtotalDecimal = Convert.ToDecimal(RowGrid.Cells["SubTotal"].Value.ToString());
                                frm.Total_IVADecimal = Convert.ToDecimal(RowGrid.Cells["Total_Iva"].Value.ToString());
                                frm.DescuentolDecimal = Convert.ToDecimal(RowGrid.Cells["Descuento"].Value.ToString());
                                frm.Total_PedidoDecimal = Convert.ToDecimal(RowGrid.Cells["Total_Pedido"].Value.ToString());
                                frm.CartaString = RowGrid.Cells["Carta"].Value.ToString();
                                frm.PolizaString = RowGrid.Cells["Poliza"].Value.ToString();
                                frm.K_CelulaInt = RowGrid.Cells["K_Celula"].Value.ToString()!=""?Convert.ToInt32(RowGrid.Cells["K_Celula"].Value.ToString()):0;
                                frm.CelulaString = RowGrid.Cells["Celula"].Value.ToString();
                                frm.B_Remisionado = Convert.ToBoolean(RowGrid.Cells["B_Remisionado"].Value.ToString());
                                frm.B_SurtidoCompleto = Convert.ToBoolean(RowGrid.Cells["B_SurtidoCompleto"].Value.ToString());
                                dtDetalle = dtPaso.Clone();
                            }

                            foreach (DataRow item in dtPaso.Rows)
                            {
                                string SKU;
                                bool B_Existe;

                                if (dtDetalle.Rows.Count == 0)
                                {
                                    DataRow dr;
                                    dr = dtDetalle.NewRow();

                                    dr["K_Articulo"] = Convert.ToInt32(item["K_Articulo"]);
                                    dr["K_Pedido_Detalle"] = Convert.ToInt32(item["K_Pedido_Detalle"].ToString());
                                    dr["K_Pedido"] = Convert.ToInt32(item["K_Pedido"].ToString());
                                    dr["Cantidad"] = Convert.ToInt32(item["Cantidad"]).ToString();
                                    dr["K_Tipo_Producto"] = Convert.ToInt32(item["K_Tipo_Producto"].ToString());
                                    dr["D_Tipo_Producto"] = item["D_Tipo_Producto"];
                                    dr["Precio_Unitario"] = Convert.ToDecimal(item["Precio_Unitario"]);
                                    dr["K_Sustancia_Activa"] = Convert.ToInt32(item["K_Sustancia_Activa"]);
                                    dr["D_Sustancia_Activa"] = item["D_Sustancia_Activa"];
                                    dr["Subtotal"] = Convert.ToDecimal(item["Subtotal"]);
                                    dr["Tasa_IVA"] = Convert.ToDecimal(item["Tasa_IVA"]);
                                    dr["Total_IVA"] = Convert.ToDecimal(item["Total_IVA"]);
                                    dr["Total_Detalle"] = Convert.ToDecimal(item["Total_Detalle"]);
                                    dr["Porcentaje_Descuento"] = Convert.ToDecimal(item["Porcentaje_Descuento"]);
                                    dr["Descuento"] = Convert.ToDecimal(item["Descuento"]);
                                    dr["SKU"] = item["SKU"];
                                    dr["K_Laboratorio"] = Convert.ToInt32(item["K_laboratorio"]);
                                    dr["D_Laboratorio"] = item["D_Laboratorio"];
                                    dr["B_Remisionado"] = Convert.ToBoolean(item["B_Remisionado"]);
                                    dr["D_Articulo"] = item["D_Articulo"];
                                    dr["D_Unidad_Medida"] = item["D_Unidad_Medida"];
                                    dr["K_Unidad_Medida"] = Convert.ToInt32(item["K_Unidad_Medida"]);
                                    dr["B_Facturado"] = Convert.ToBoolean(item["B_Facturado"]);
                                    dtDetalle.Rows.Add(dr);

                                }
                                else
                                {
                                    B_Existe = false;
                                    //se encuentra  sumo 
                                    foreach (DataRow row in dtDetalle.Rows)
                                    {
                                        SKU = row["SKU"].ToString();
                                        B_Existe = false;

                                        if (item["SKU"].ToString() == SKU)
                                        {
                                            row["Cantidad"] = Convert.ToInt32(item["Cantidad"]) + Convert.ToInt32(row["Cantidad"]);
                                            row["Subtotal"] = Convert.ToDecimal(item["Subtotal"]) + Convert.ToDecimal(row["Subtotal"]);
                                            row["Total_IVA"] = Convert.ToDecimal(item["Total_IVA"]) + Convert.ToDecimal(row["Total_IVA"]);
                                            row["Total_Detalle"] = Convert.ToDecimal(item["Total_Detalle"]) + Convert.ToDecimal(row["Total_Detalle"]);
                                            row["Descuento"] = Convert.ToDecimal(item["Descuento"]) + Convert.ToDecimal(row["Descuento"]);
                                            B_Existe = true;
                                            break;

                                        }
                                    }
                                    if (B_Existe == false)
                                    {
                                        DataRow dr;
                                        dr = dtDetalle.NewRow();
                                        dr["K_Articulo"] = Convert.ToInt32(item["K_Articulo"]);
                                        dr["K_Pedido_Detalle"] = Convert.ToInt32(item["K_Pedido_Detalle"].ToString());
                                        dr["K_Pedido"] = Convert.ToInt32(item["K_Pedido"].ToString());
                                        dr["Cantidad"] = Convert.ToInt32(item["Cantidad"]).ToString();
                                        dr["K_Tipo_Producto"] = Convert.ToInt32(item["K_Tipo_Producto"].ToString());
                                        dr["D_Tipo_Producto"] = item["D_Tipo_Producto"];
                                        dr["Precio_Unitario"] = Convert.ToDecimal(item["Precio_Unitario"]);
                                        dr["K_Sustancia_Activa"] = Convert.ToInt32(item["K_Sustancia_Activa"]);
                                        dr["D_Sustancia_Activa"] = item["D_Sustancia_Activa"];
                                        dr["Subtotal"] = Convert.ToDecimal(item["Subtotal"]);
                                        dr["Tasa_IVA"] = Convert.ToDecimal(item["Tasa_IVA"]);
                                        dr["Total_IVA"] = Convert.ToDecimal(item["Total_IVA"]);
                                        dr["Total_Detalle"] = Convert.ToDecimal(item["Total_Detalle"]);
                                        dr["Porcentaje_Descuento"] = Convert.ToDecimal(item["Porcentaje_Descuento"]);
                                        dr["Descuento"] = Convert.ToDecimal(item["Descuento"]);
                                        dr["SKU"] = item["SKU"];
                                        dr["K_Laboratorio"] = Convert.ToInt32(item["K_laboratorio"]);
                                        dr["D_Laboratorio"] = item["D_Laboratorio"];
                                        dr["B_Remisionado"] = Convert.ToBoolean(item["B_Remisionado"]);
                                        dr["D_Articulo"] = item["D_Articulo"];
                                        dr["D_Unidad_Medida"] = item["D_Unidad_Medida"];
                                        dr["K_Unidad_Medida"] = Convert.ToInt32(item["K_Unidad_Medida"]);
                                        dr["B_Facturado"] = Convert.ToBoolean(item["B_Facturado"]);
                                        dtDetalle.Rows.Add(dr);
                                    }
                                }
                            }
                            frm.LstFolios.Add(Convert.ToInt32(RowGrid.Cells["K_Pedido"].Value.ToString()));
                            B_Entrar = false;
                        }
                    }
                  
                }

                if (Contador >= 1)
                {
                    if (dtDetalle != null)
                    {
                        if (dtDetalle.Rows.Count > 0)
                        {
                            frm.dtArticulos = dtDetalle;
                            frm.ShowDialog();

                        }
                    }

                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR POR LO MENOS UN PEDIDO PARA FACTURAR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (rbRemisiones.Checked)
            {
                int Contador = 0;
                FACTURACION.FRM_REGISTRA_FACTURAS_PEDIDOS frm = new FACTURACION.FRM_REGISTRA_FACTURAS_PEDIDOS();
                foreach (DataGridViewRow RowGrid in grdDatos.Rows)
                {
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)RowGrid.Cells["Seleccionar"];
                    if (chk != null)
                    {
                        if ((bool)((chk.Value.ToString() == "") ? false : chk.Value) == true)
                        {
                            Contador += 1;


                            DataTable dtPaso = sqlVentas.Sk_pedidos_detalle(Convert.ToInt32(RowGrid.Cells["K_Pedido"].Value.ToString()));
                            if (dtPaso == null)
                            {
                                MessageBox.Show(String.Format("EL PEDIDO [{0}] NO CUENTA CON DETALLE DE ARTICULOS!...", RowGrid.Cells["K_Pedido"].Value.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning));
                                return;
                            }
                            if (B_Entrar == true)
                            {
                                frm.K_OficinaInt = Convert.ToInt32(RowGrid.Cells["K_Oficina"].Value.ToString());
                                frm.D_OficinaString = RowGrid.Cells["D_Oficina"].Value.ToString();
                                frm.K_AlmacenInt = Convert.ToInt32(RowGrid.Cells["K_Almacen"].Value.ToString());
                                frm.K_MedicoInt = Convert.ToInt32(RowGrid.Cells["K_Medico"].Value.ToString());
                                frm.D_MedicoString = RowGrid.Cells["D_Medico"].Value.ToString();
                                frm.K_PacienteInt = Convert.ToInt32(RowGrid.Cells["K_Paciente"].Value.ToString());
                                frm.D_PacienteString = RowGrid.Cells["D_Paciente"].Value.ToString();
                                frm.K_Paciente_DireccionInt = Convert.ToInt32(RowGrid.Cells["K_Paciente_Direccion"].Value.ToString());
                                frm.K_ClienteInt = Convert.ToInt32(RowGrid.Cells["K_Cliente"].Value.ToString());
                                frm.K_AsesorInt = RowGrid.Cells["K_Asesor"].Value.ToString() != DBNull.Value.ToString() ? Convert.ToInt32(RowGrid.Cells["K_Asesor"].Value.ToString()) : 0;
                                frm.D_ClienteString = RowGrid.Cells["D_Cliente"].Value.ToString();
                                frm.K_Cliente_Domicilio_FiscalInt = Convert.ToInt32(RowGrid.Cells["K_Cliente_Domicilio_Fiscal"].Value.ToString());
                                frm.D_Cliente_Domicilio_FiscalString = RowGrid.Cells["Direccion_Fiscal"].Value.ToString();
                                frm.F_Vencimiento = Convert.ToDateTime(RowGrid.Cells["F_Vencimiento"].Value.ToString());
                                frm.ObservacionesString = RowGrid.Cells["Nota"].Value.ToString();
                                frm.K_PedidoInt = Convert.ToInt32(RowGrid.Cells["K_Pedido"].Value.ToString());
                                frm.FolioString = RowGrid.Cells["K_Pedido"].Value.ToString();
                                frm.SiniestroString = RowGrid.Cells["Siniestro_Pedido"].Value.ToString() != DBNull.Value.ToString() ? RowGrid.Cells["Siniestro_Pedido"].Value.ToString() : DBNull.Value.ToString();
                                frm.ReclamacionString = RowGrid.Cells["Reclamacion_Pedido"].Value.ToString() != "" ? RowGrid.Cells["Reclamacion_Pedido"].Value.ToString() : DBNull.Value.ToString();
                                frm.CoaseguroString = RowGrid.Cells["Coaseguro_Pedido"].Value.ToString() != "" ? RowGrid.Cells["Coaseguro_Pedido"].Value.ToString() : DBNull.Value.ToString();
                                frm.PorcentajeDescuentoDecimal = Convert.ToDecimal(RowGrid.Cells["Porcentaje_Descuento"].Value.ToString());
                                frm.CoaseguroDecimal = RowGrid.Cells["Descuento"].Value.ToString() != "" ? Convert.ToDecimal(RowGrid.Cells["Descuento"].Value.ToString()) : 0;
                                frm.PorcentajeCoaseguroDecimal = RowGrid.Cells["PorcentajeCoaseguro"].Value.ToString() != "" ? Convert.ToDecimal(RowGrid.Cells["PorcentajeCoaseguro"].Value.ToString()) : 0;
                                frm.SubtotalDecimal = Convert.ToDecimal(RowGrid.Cells["SubTotal"].Value.ToString());
                                frm.Total_IVADecimal = Convert.ToDecimal(RowGrid.Cells["Total_Iva"].Value.ToString());
                                frm.DescuentolDecimal = Convert.ToDecimal(RowGrid.Cells["Descuento"].Value.ToString());
                                frm.Total_PedidoDecimal = Convert.ToDecimal(RowGrid.Cells["Total_Pedido"].Value.ToString());
                                frm.CartaString = RowGrid.Cells["Carta"].Value.ToString();
                                frm.PolizaString = RowGrid.Cells["Poliza"].Value.ToString();
                                frm.B_Remisionado = Convert.ToBoolean(RowGrid.Cells["B_Remisionado"].Value.ToString());
                                frm.B_SurtidoCompleto = Convert.ToBoolean(RowGrid.Cells["B_SurtidoCompleto"].Value.ToString());
                                frm.K_CelulaInt = RowGrid.Cells["K_Celula"].Value.ToString() != "" ? Convert.ToInt32(RowGrid.Cells["K_Celula"].Value.ToString()) : 0;
                                frm.CelulaString = RowGrid.Cells["Celula"].Value.ToString();
                                dtDetalle = dtPaso.Clone();
                            }

                            foreach (DataRow item in dtPaso.Rows)
                            {
                                string SKU;
                                bool B_Existe;

                                if (dtDetalle.Rows.Count == 0)
                                {
                                    DataRow dr;
                                    dr = dtDetalle.NewRow();

                                    dr["K_Articulo"] = Convert.ToInt32(item["K_Articulo"]);
                                    dr["K_Pedido_Detalle"] = Convert.ToInt32(item["K_Pedido_Detalle"].ToString());
                                    dr["K_Pedido"] = Convert.ToInt32(item["K_Pedido"].ToString());
                                    dr["Cantidad"] = Convert.ToInt32(item["Cantidad"]).ToString();
                                    dr["K_Tipo_Producto"] = Convert.ToInt32(item["K_Tipo_Producto"].ToString());
                                    dr["D_Tipo_Producto"] = item["D_Tipo_Producto"];
                                    dr["Precio_Unitario"] = Convert.ToDecimal(item["Precio_Unitario"]);
                                    dr["K_Sustancia_Activa"] = Convert.ToInt32(item["K_Sustancia_Activa"]);
                                    dr["D_Sustancia_Activa"] = item["D_Sustancia_Activa"];
                                    dr["Subtotal"] = Convert.ToDecimal(item["Subtotal"]);
                                    dr["Tasa_IVA"] = Convert.ToDecimal(item["Tasa_IVA"]);
                                    dr["Total_IVA"] = Convert.ToDecimal(item["Total_IVA"]);
                                    dr["Total_Detalle"] = Convert.ToDecimal(item["Total_Detalle"]);
                                    dr["Porcentaje_Descuento"] = Convert.ToDecimal(item["Porcentaje_Descuento"]);
                                    dr["Descuento"] = Convert.ToDecimal(item["Descuento"]);
                                    dr["SKU"] = item["SKU"];
                                    dr["K_Laboratorio"] = Convert.ToInt32(item["K_laboratorio"]);
                                    dr["D_Laboratorio"] = item["D_Laboratorio"];
                                    dr["B_Remisionado"] = Convert.ToBoolean(item["B_Remisionado"]);
                                    dr["D_Articulo"] = item["D_Articulo"];
                                    dr["D_Unidad_Medida"] = item["D_Unidad_Medida"];
                                    dr["K_Unidad_Medida"] = Convert.ToInt32(item["K_Unidad_Medida"]);
                                    dr["B_Facturado"] = Convert.ToBoolean(item["B_Facturado"]);
                                    dtDetalle.Rows.Add(dr);

                                }
                                else
                                {
                                    B_Existe = false;
                                    //se encuentra  sumo 
                                    foreach (DataRow row in dtDetalle.Rows)
                                    {
                                        SKU = row["SKU"].ToString();
                                        B_Existe = false;

                                        if (item["SKU"].ToString() == SKU)
                                        {

                                            row["Cantidad"] = Convert.ToInt32(item["Cantidad"]) + Convert.ToInt32(row["Cantidad"]);
                                            row["Subtotal"] = Convert.ToDecimal(item["Subtotal"]) + Convert.ToDecimal(row["Subtotal"]);
                                            row["Total_IVA"] = Convert.ToDecimal(item["Total_IVA"]) + Convert.ToDecimal(row["Total_IVA"]);
                                            row["Total_Detalle"] = Convert.ToDecimal(item["Total_Detalle"]) + Convert.ToDecimal(row["Total_Detalle"]);
                                            row["Descuento"] = Convert.ToDecimal(item["Descuento"]) + Convert.ToDecimal(row["Descuento"]);
                                            B_Existe = true;
                                            break;

                                        }
                                    }
                                    if (B_Existe == false)
                                    {
                                        DataRow dr;
                                        dr = dtDetalle.NewRow();

                                        dr["K_Articulo"] = Convert.ToInt32(item["K_Articulo"]);
                                        dr["K_Pedido_Detalle"] = Convert.ToInt32(item["K_Pedido_Detalle"].ToString());
                                        dr["K_Pedido"] = Convert.ToInt32(item["K_Pedido"].ToString());
                                        dr["Cantidad"] = Convert.ToInt32(item["Cantidad"]).ToString();
                                        dr["K_Tipo_Producto"] = Convert.ToInt32(item["K_Tipo_Producto"].ToString());
                                        dr["D_Tipo_Producto"] = item["D_Tipo_Producto"];
                                        dr["Precio_Unitario"] = Convert.ToDecimal(item["Precio_Unitario"]);
                                        dr["K_Sustancia_Activa"] = Convert.ToInt32(item["K_Sustancia_Activa"]);
                                        dr["D_Sustancia_Activa"] = item["D_Sustancia_Activa"];
                                        dr["Subtotal"] = Convert.ToDecimal(item["Subtotal"]);
                                        dr["Tasa_IVA"] = Convert.ToDecimal(item["Tasa_IVA"]);
                                        dr["Total_IVA"] = Convert.ToDecimal(item["Total_IVA"]);
                                        dr["Total_Detalle"] = Convert.ToDecimal(item["Total_Detalle"]);
                                        dr["Porcentaje_Descuento"] = Convert.ToDecimal(item["Porcentaje_Descuento"]);
                                        dr["Descuento"] = Convert.ToDecimal(item["Descuento"]);
                                        dr["SKU"] = item["SKU"];
                                        dr["K_Laboratorio"] = Convert.ToInt32(item["K_laboratorio"]);
                                        dr["D_Laboratorio"] = item["D_Laboratorio"];
                                        dr["B_Remisionado"] = Convert.ToBoolean(item["B_Remisionado"]);
                                        dr["D_Articulo"] = item["D_Articulo"];
                                        dr["D_Unidad_Medida"] = item["D_Unidad_Medida"];
                                        dr["K_Unidad_Medida"] = Convert.ToInt32(item["K_Unidad_Medida"]);
                                        dr["B_Facturado"] = Convert.ToBoolean(item["B_Facturado"]);
                                        dtDetalle.Rows.Add(dr);
                                    }
                                }
                            }

                            frm.LstFolios.Add(Convert.ToInt32(RowGrid.Cells["K_Pedido"].Value.ToString()));

                            B_Entrar = false;

                            //this.dtDetalle.Merge(dtPaso);                                                         
                        }
                    }
                   
                }

                if (Contador >= 1)
                {
                    if (dtDetalle != null)
                    {
                        if (dtDetalle.Rows.Count > 0)
                        {
                            frm.dtArticulos = dtDetalle;
                            frm.ShowDialog();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR POR LO MENOS UN PEDIDO PARA FACTURAR!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (rbCoaseguro.Checked)
            {
                int contador = 0;
                foreach (DataGridViewRow RowGrid in grdDatos.Rows)
                {
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)RowGrid.Cells["Seleccionar"];

                    if (chk != null)
                    {
                        if ((bool)((chk.Value.ToString() == "") ? false : chk.Value) == true)
                        {
                            contador += 1;
                        }
                    }
                       
                }
                if (contador > 1)
                {
                    MessageBox.Show("SOLO PUEDE FACTURAR UN COASEGURO POR OPERACION!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contador = 0;
                    return;
                }
                contador = 0;


                FACTURACION.FRM_REGISTRA_FACTURA_COASEGURO frm = new FACTURACION.FRM_REGISTRA_FACTURA_COASEGURO();
                DataTable dtPaso = sqlPedidos.Sk_Trae_Coaseguro(Convert.ToInt32(grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString()));
                if ((dtPaso == null) || (dtPaso.Rows.Count == 0))
                {
                    MessageBox.Show("EL PEDIDO [" + grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString() + "] NO TIENE COASEGURO!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    frm.dtDatos = dtPaso;
                }

                frm.ShowDialog();
            }
            Cursor = Cursors.Default;
            BaseBotonBuscarClick();
        }

        public override void BaseBotonProceso2Click()
        {
            rbPedidos.Checked = true;
            txtDocumento.Text = string.Empty;
            txtClavePaciente.Text = string.Empty;
            txtClaveCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtPaciente.Text = string.Empty;
            txtFiltro.Text = string.Empty ;
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = false;
            limpia();
        }
 
        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Paciente_Pedido frm = new FILTROS.Frm_Filtro_Paciente_Pedido();
            frm.ShowDialog();
            if(frm.LLave_Seleccionado == 0)
            {
                txtClavePaciente.Text = string.Empty;
                txtPaciente.Text = string.Empty;
            }
            else if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                txtClavePaciente.Text = frm.LLave_Seleccionado.ToString();
                txtPaciente.Text = frm.Descripcion_Seleccionado.ToString();
            }

        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            if(filtra.K_Cliente_Seleccionado == 0)
            {
               txtClaveCliente.Text = string.Empty;
               txtCliente.Text = string.Empty;
            }
            else if (filtra.K_Cliente_Seleccionado  != 0 && filtra.D_Cliente_Seleccionado != "")
            {
                txtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
                txtCliente.Text = filtra.D_Cliente_Seleccionado;
            }
      
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)) ||(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            { dtDatos.DefaultView.RowFilter = $" D_Paciente LIKE '%{txtFiltro.Text}%' or  D_Cliente LIKE '%{txtFiltro.Text}%'"; }
            catch (Exception ex){}
        }

        private void rbtnCoaseguro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPrivada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrivada.Checked)
            {
                FRM_REGISTRO_FACTURAS frms = new FRM_REGISTRO_FACTURAS();
                frms.ShowDialog();
            }
        }

        private void limpia()
        {
            if (grdDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grdDatos.DataSource;
                dt.Clear();
                BaseBotonExcel.Visible = false;
                BaseBotonExcel.Enabled = false;
                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = false;
                BaseBotonProceso2.Visible = true;
                BaseBotonProceso2.Enabled = false;
            }

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if(txtDocumento.Text.Trim().Length>0)
            {
                try
                {
                    Int32 valor = Convert.ToInt32(txtDocumento.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Text = string.Empty;
                    txtDocumento.Focus();
                }
            }
        }

        public void cargaAlmacenes()
        {
            dtAlmacen = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            dtAlmacen = sqlCatalogos.Sk_Almacenes(GlobalVar.K_Oficina);


            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void grdDatos_Resize(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(grdDatos.Width - 20) / Convert.ToDecimal(17);
            int b = Convert.ToInt32(a);

            grdDatos.Columns["Seleccionar"].Width = 20;
            grdDatos.Columns["K_Pedido"].Width = b;
            grdDatos.Columns["B_Remisionado"].Width = b;
            grdDatos.Columns["K_Remision"].Width = b;
            grdDatos.Columns["K_Cliente"].Width = b;
            grdDatos.Columns["K_Paciente"].Width = b;
            grdDatos.Columns["D_Oficina"].Width = b;
            grdDatos.Columns["D_Almacen"].Width = b;
            grdDatos.Columns["D_Paciente"].Width = b;
            grdDatos.Columns["Descuento"].Width = b;
            grdDatos.Columns["SubTotal"].Width = b;
            grdDatos.Columns["Total_Iva"].Width = b;
            grdDatos.Columns["Total_Pedido"].Width = b;
            grdDatos.Columns["D_Cliente"].Width = b;
            grdDatos.Columns["Coaseguro_Pedido"].Width = b;
            grdDatos.Columns["D_Canal_Distribucion_Cliente"].Width = b;
            grdDatos.Columns["B_SurtidoCompleto"].Width = b;
            grdDatos.Columns["F_Registro"].Width = b;
        }

        private void grdDatos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                grdDatos.Cursor = Cursors.Hand;
            else
                grdDatos.Cursor = Cursors.Default;
        }

        private void rbPedidos_Click(object sender, EventArgs e)
        {
            if (rbPedidos.Checked)
                cbxAlmacen.Enabled = false;
            else if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = true;

            try
            {
                DataTable dt = (DataTable)grdDatos.DataSource;
                dt.Clear();

                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = false;
                BaseBotonProceso2.Visible = true;
                BaseBotonProceso2.Enabled = false;
            }
            catch (Exception) { }
        }

        private void rbRemisiones_Click(object sender, EventArgs e)
        {
            if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = true;
            else if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = false;

            try
            {
                DataTable dt = (DataTable)grdDatos.DataSource;
                dt.Clear();

                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = false;
                BaseBotonProceso2.Visible = true;
                BaseBotonProceso2.Enabled = false;
            }
            catch (Exception) { }
         
         
        }

        private void rbPedidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPedidos.Checked)
                cbxAlmacen.Enabled = false;
            else if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = true;
        }

        private void rbRemisiones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = true;
            else if (rbRemisiones.Checked)
                cbxAlmacen.Enabled = false;

        }

   

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDatos.Columns["Seleccionar"].Index == e.ColumnIndex)
            {
                //grdDatos.MultiSelect = true;
                if (Convert.ToBoolean(grdDatos["Seleccionar", e.RowIndex].FormattedValue) == true)
                {
                    grdDatos["Seleccionar", e.RowIndex].Value = false;
                    numGuias--;

                }
                else
                {
                    grdDatos["Seleccionar", e.RowIndex].Value = true;
                    numGuias++;
                }
            }

            /*int i = 0;
            foreach (DataGridViewRow dgvrow in grdGuias.Rows)
            {

                if (Convert.ToBoolean(dgvrow.Cells["Facturar"].Value.ToString()) == true)
                {
                    SetDataGridViewRowAsHighlighted(grdGuias, i, true);
                }
                else
                {
                    SetDataGridViewRowAsHighlighted(grdGuias, i, false);
                }
                i++;
            }*/

            if (numGuias > 0)
            {
                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = true;
            }
            else
            {
                BaseBotonProceso1.Visible = true;
                BaseBotonProceso1.Enabled = false;
            }
        }
    }

}
