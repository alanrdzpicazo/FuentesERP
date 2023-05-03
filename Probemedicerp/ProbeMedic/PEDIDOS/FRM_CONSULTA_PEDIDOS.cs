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

namespace ProbeMedic
{
    public partial class FRM_CONSULTA_PEDIDOS : FormaConsulta
    {
        DataTable dtAlmacen = new DataTable();
        DataTable dtAseguradora = new DataTable();
        DataTable dt = new DataTable();
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLPedidos sqlpedidos = new SQLPedidos();
        private Int32 K_OficinaInt { get; set; }
        private Int32 K_AlmacenInt { get; set; }
        public Int32 K_PedidoInt { get; set; }
        string strMensaje;
        int res;

        public FRM_CONSULTA_PEDIDOS()
        {
            InitializeComponent();
            BaseBotonExcel.Visible = false;
        }

        private void FRM_CONSULTA_PEDIDOS_Load(object sender, EventArgs e)
        {
            BaseBotonExcel.Visible = false;
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
            BaseBotonCancelar.Visible = true;
            BaseBotonCancelar.Enabled = true;
            BaseBotonCancelar.Text = "Limpiar campos";
            BaseBotonCancelar.Width = BaseBotonCancelar.Width + 10;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["add.png"]));
            BaseBotonProceso1.Text = "Detalle";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso1.Text = "Agregar";
            BaseBotonProceso1.ToolTipText = "Agregar Nuevo Pedido..";

            K_OficinaInt = GlobalVar.K_Oficina;
            txtClaveOficina.Text = K_OficinaInt.ToString();
            txtOficina.Text = GlobalVar.D_Oficina;
            dtp_inicial.Value = dtp_final.Value.AddDays(-7);

            CargaAlmacen();
            CargaAseguradora();
            //CargaPedidos();

            WindowState = FormWindowState.Maximized;

            if (BaseBotonExcel.Visible)
                BaseBotonExcel.Visible = false;
        }

        public override void BaseBotonBuscarClick()
        {
            CargaPedidos();
            if (BaseBotonExcel.Visible)
                BaseBotonExcel.Visible = false;
        }

        public override void BaseBotonCancelarClick()
        {
            txtPedido.Text = string.Empty;
            cbxAseguradora.SelectedIndex = 0;
            txtClavePaciente.Text = string.Empty;
            txtPaciente.Text = string.Empty;
            cbxAseguradora.SelectedIndex = 0;
            BaseBotonExcel.Visible = false;
            BaseMetodoInicio();
        }
   
        public override void BaseBotonProceso1Click()
        {
            PEDIDOS.FRM_INGRESA_PEDIDOS frm = new PEDIDOS.FRM_INGRESA_PEDIDOS();
            frm.ShowDialog();
            CargaPedidos();
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_OficinaInt = Convert.ToInt32(frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString());
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
            if (txtClaveOficina.Text != "")
            {
                CargaAlmacen();
            }
            Cursor = Cursors.Default;
        }

        private void txtClaveOficina_TextChanged(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Length > 0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClaveOficina.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VÁLIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Text = string.Empty;
                    txtClaveOficina.Focus();
                }
                else
                 cbxAlmacen.Enabled = true;
            }
            else
            {
                cbxAlmacen.Enabled = false;
            }
        }

        public bool Valida_Entradas()
        {
            bool validado = false;
            return validado;
        }

        private void CargaPedidos()
        {
            grdDatos.DataSource = null;
            int K_AlmacenInt = Convert.ToInt32(cbxAlmacen.SelectedValue == null ? 0 : cbxAlmacen.SelectedValue);
            int K_AseguradoraInt = Convert.ToInt32(cbxAseguradora.SelectedValue == null ? 0 : cbxAseguradora.SelectedValue);
            int K_PedidoInt = Convert.ToInt32(txtPedido.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtPedido.Text));
            int K_PacienteInt = Convert.ToInt32(txtClavePaciente.Text.Trim() == "" ? 0 : Convert.ToInt32(txtClavePaciente.Text.Trim()));
            dt = sqlpedidos.Sk_Pedidos(K_PedidoInt,K_OficinaInt,K_AlmacenInt,rdbTodos.Checked,rdbCancelados.Checked,
                false, K_PacienteInt,K_AseguradoraInt,0,dtp_inicial.Value,dtp_final.Value,0,0,0,false,0);

            if ((dt != null) && (dt.Rows.Count != 0))
            {
                BaseDtDatos = dt;
                grdDatos.AutoGenerateColumns = false;
                grdDatos.DataSource = dt;
                this.panel1.Enabled = true;
                //BaseBotonCancelar.Visible = true;
                BaseBotonExcel.Visible = true;
                BaseBotonExcel.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO EXISTE INFORMACION CON LOS PARAMETROS INDICADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CargaAlmacen()
        {            
            dtAlmacen = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            if (txtClaveOficina.Text.Trim().Length > 0)
                K_OficinaInt = Convert.ToInt32(txtClaveOficina.Text.Trim());

            if (K_OficinaInt> 0)
            { 
                dtAlmacen = sqlCatalogo.Sk_Almacenes(K_OficinaInt);
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

        private void CargaAseguradora()
        {
            DataTable dtAseguradora = new DataTable();
            dtAseguradora = null;
            cbxAseguradora.DataSource = null;
            cbxAseguradora.Items.Clear();
            cbxAseguradora.AutoCompleteSource = AutoCompleteSource.None;
            cbxAseguradora.AutoCompleteMode = AutoCompleteMode.None;

            dtAseguradora = sqlCatalogos.Sk_Aseguradora();

            if (dtAseguradora != null)
            {
                DataRow dr = dtAseguradora.NewRow();

                dr["K_Aseguradora"] = 0;
                dr["D_Aseguradora"] = "";
                dr["C_Aseguradora"] = "";
                dr["K_Cliente"] = 0;
                dr["D_Cliente"] = "";

                dtAseguradora.Rows.InsertAt(dr, 0);

                dtAseguradora.AcceptChanges();

                int indice = -1;
                indice = 0;

                dtAseguradora.Columns.Remove("C_Aseguradora");
                dtAseguradora.Columns.Remove("K_Cliente");
                dtAseguradora.Columns.Remove("D_Cliente");

                LlenaCombo(dtAseguradora, ref cbxAseguradora, "K_Aseguradora", "D_Aseguradora", indice);

                cbxAseguradora.SelectedIndex = 0;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    PEDIDOS.FRM_CONSULTA_PEDIDOS_DETALLE frm = new PEDIDOS.FRM_CONSULTA_PEDIDOS_DETALLE();
                    frm.K_PedidoInt = K_PedidoInt;
                    frm.ShowDialog();
                    CargaPedidos();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    strMensaje = "";

                    res = sqlpedidos.Gp_ActualizaEstatus_Pedidos(K_PedidoInt, true, false, ref strMensaje);

                    if (res < 0)
                    {
                        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("EL PEDIDO FUE APROBADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaPedidos();
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    strMensaje = "";

                    res = sqlpedidos.Gp_ActualizaEstatus_Pedidos(K_PedidoInt, false, true, ref strMensaje);

                    if (res < 0)
                    {
                        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("EL PEDIDO FUE ACTIVADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaPedidos();
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    PEDIDOS.FRM_CANCELACION_PEDIDOS frm = new PEDIDOS.FRM_CANCELACION_PEDIDOS();
                    frm.K_PedidoInt = K_PedidoInt;
                    frm.ShowDialog();
                    CargaPedidos();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                if (this.grdDatos.CurrentRow.Cells["D_Estatus_Pedido"].Value.ToString() == "CANCELADO")
                {
                    MessageBox.Show("EL PEDIDO SE ENCUENTRA CANCELADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    PEDIDOS.FRM_MODIFICA_PEDIDO frm = new PEDIDOS.FRM_MODIFICA_PEDIDO();
                    frm.K_PedidoInt = K_PedidoInt;
                    frm.ShowDialog();
                    CargaPedidos();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void txtVerNotas_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    PEDIDOS.FRM_CONSULTA_NOTA_CANCELACION frm = new PEDIDOS.FRM_CONSULTA_NOTA_CANCELACION();
                    frm.K_PedidoInt = K_PedidoInt;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void btnModificarPaqueteria_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    PEDIDOS.FRM_MODIFICAR_PAQUETERIA frm = new PEDIDOS.FRM_MODIFICAR_PAQUETERIA();
                    frm.K_PedidoInt = K_PedidoInt;
                    frm.ShowDialog();
                    CargaPedidos();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTodos.Checked)
                CargaPedidos();
        }

        private void rdbCancelados_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbCancelados.Checked)
                CargaPedidos();
        }

        private void dtp_inicial_ValueChanged(object sender, EventArgs e)
        {
            //MtdCargaPedidos();
        }

        private void dtp_final_ValueChanged(object sender, EventArgs e)
        {
            //MtdCargaPedidos();
        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPedido_Validated(object sender, EventArgs e)
        {
            //BaseBotonBuscarClick();
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPedido.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(txtPedido.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                          "EL VALOR MÁXIMO PERMITDO ES DE " + Int32.MaxValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPedido.Text = string.Empty;
                return;
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if(dt!=null)
            {
                if(dt.Rows.Count>0)
                {
                    dt.DefaultView.RowFilter = $"D_Estatus_Pedido LIKE '%{txtFiltrar.Text}%' or  D_Paciente LIKE '%{txtFiltrar.Text}%' or  D_Aseguradora LIKE '%{txtFiltrar.Text}%' or  D_Usuario LIKE '%{txtFiltrar.Text}%'";
                }
            }         
        }

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
           if((Char.IsLetter(e.KeyChar))||(e.KeyChar == Convert.ToChar(Keys.Back)))
           {
                e.Handled = false;
           }
           else
           {
                e.Handled = true;
           }
        }

        private void btnHistoriaPedido_Click(object sender, EventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
                if (K_PedidoInt != 0)
                {
                    FRM_HISTORIA_PEDIDO frm = new FRM_HISTORIA_PEDIDO();
                    frm.K_PedidoInt = K_PedidoInt;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

        }

        private void dgv_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //if (grdDatos.CurrentRow != null)
            //{
            //    if(e.RowIndex !=-1)
            //    {
            //        Int32 K_PedidoInt = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["K_Pedido"].Value.ToString());
            //        if (K_PedidoInt != 0)
            //        {
            //            PEDIDOS.FRM_MODIFICA_PEDIDO frm = new PEDIDOS.FRM_MODIFICA_PEDIDO();
            //            frm.K_PedidoInt = K_PedidoInt;
            //            frm.ShowDialog();
            //            CargaPedidos();
            //        }
            //        else
            //        {
            //            MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            
            //}
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Paciente_Pedido frm = new FILTROS.Frm_Filtro_Paciente_Pedido();
            frm.ShowDialog();
            if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                txtClavePaciente.Text = frm.LLave_Seleccionado.ToString();
                txtPaciente.Text = frm.Descripcion_Seleccionado.ToString();
            }
            else
            {
                txtClavePaciente.Text = string.Empty;
                txtPaciente.Text = string.Empty;
            }
        }

        private void cbxAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxAseguradora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnVer_MouseEnter(object sender, EventArgs e)
        {
            btnVer.Cursor = Cursors.Hand;
        }

        private void btnAprobar_MouseEnter(object sender, EventArgs e)
        {
            btnAprobar.Cursor = Cursors.Hand;
        }

        private void btnActivar_MouseEnter(object sender, EventArgs e)
        {
            btnActivar.Cursor = Cursors.Hand;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.Cursor = Cursors.Hand;
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.Cursor = Cursors.Hand;
        }

        private void txtVerNotas_MouseEnter(object sender, EventArgs e)
        {
            txtVerNotas.Cursor = Cursors.Hand;
        }

        private void btnModificarPaqueteria_MouseEnter(object sender, EventArgs e)
        {
            btnModificarPaqueteria.Cursor = Cursors.Hand;
        }

        private void btnHistoriaPedido_MouseEnter(object sender, EventArgs e)
        {
            btnHistoriaPedido.Cursor = Cursors.Hand;
        }

        private void txtClaveOficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()) || ((e.KeyChar == Convert.ToChar(Keys.Back)))))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = false;
                Cursor = Cursors.WaitCursor;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                Cursor = Cursors.Default;
                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Focus();
                }
                else
                {
                    CargaAlmacen();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClaveOficina_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Cursor = Cursors.WaitCursor;
                BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
                Cursor = Cursors.Default;

                if (txtClaveOficina.Text.Trim().Length == 0)
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveOficina.Focus();
                }
                else
                {
                    CargaAlmacen();
                }
            }
        }

        private void txtClavePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()) || ((e.KeyChar == Convert.ToChar(Keys.Back)))))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtClavePaciente.Text.Trim().Length > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    DataTable dtPacientes = sqlCatalogos.Sk_Pacientes_Top(0, 0, string.Empty, txtClavePaciente.Text.Trim().Length > 0 ? Convert.ToInt32(txtClavePaciente.Text.Trim()) : 0,
                        0, 0, 0, 0, 0);

                    Cursor = Cursors.Default;

                    if (dtPacientes != null)
                    {
                        if (dtPacientes.Rows.Count > 0)
                        {
                            txtClavePaciente.Text = dtPacientes.Rows[0]["K_Paciente"].ToString();
                            txtPaciente.Text = dtPacientes.Rows[0]["Nombre_Completo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClavePaciente.Text = string.Empty;
                            txtPaciente.Text = string.Empty;
                            txtClavePaciente.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClavePaciente.Text = string.Empty;
                        txtPaciente.Text = string.Empty;
                        txtClavePaciente.Focus();
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClavePaciente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if(txtClavePaciente.Text.Trim().Length>0)
                {
                    Cursor = Cursors.WaitCursor;
                    DataTable dtPacientes = sqlCatalogos.Sk_Pacientes_Top(0, 0, string.Empty, txtClavePaciente.Text.Trim().Length > 0 ? Convert.ToInt32(txtClavePaciente.Text.Trim()) : 0,
                        0, 0, 0, 0, 0);

                    Cursor = Cursors.Default;

                    if (dtPacientes != null)
                    {
                        if (dtPacientes.Rows.Count > 0)
                        {
                            txtClavePaciente.Text = dtPacientes.Rows[0]["K_Paciente"].ToString();
                            txtPaciente.Text = dtPacientes.Rows[0]["Nombre_Completo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClavePaciente.Text = string.Empty;
                            txtPaciente.Text = string.Empty;
                            txtClavePaciente.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClavePaciente.Text = string.Empty;
                        txtPaciente.Text = string.Empty;
                        txtClavePaciente.Focus();
                    }
                }
               
            }
        
        }

        private void txtClavePaciente_TextChanged(object sender, EventArgs e)
        {
            if (txtClavePaciente.Text.Trim().Length > 0)
            {
                Int32 valor = 0;
                if (!Int32.TryParse(txtClavePaciente.Text.Trim(), out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClavePaciente.Text = string.Empty;
                    txtClavePaciente.Focus();
                }
            }
        }

        private void grdDatos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ////Skip the Column and Row headers
            //if (e.ColumnIndex < 0 || e.RowIndex < 0)
            //{
            //    return;
            //}
            //var dataGridView = (sender as DataGridView);
            ////Check the condition as per the requirement casting the cell value to the appropriate type
            //if (e.ColumnIndex == 0)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
            //    grdDatos.Cursor = Cursors.Hand;
            //else
            //    grdDatos.Cursor = Cursors.Default;
        }
    }
}