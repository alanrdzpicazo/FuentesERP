using ProbeMedic.AppCode.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProbeMedic.CXP
{
    public partial class Frm_PagoCajaChica : FormaBase
    {

        public Frm_PagoCajaChica()
        {
            InitializeComponent();
        }
        public DataTable dtPagos = new DataTable();
        public DataTable dtTiposPagos = new DataTable();
        public decimal _Monto { get; set; }
        int res;
        string msg = "";


        public DataTable dtPagos_Completos { get; set; }
        SQLCuentasxPagar sqlCXP = new SQLCuentasxPagar();
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLVentas sQLVentas = new SQLVentas();
        Funciones fx = new Funciones();
        int K_Banco_Trans_Ent;
        int K_Banco_Cheque_Ent;
        int K_Banco_Trajeta_Ent;

        void MtdCargaAlmacen()
        {
            dtPagos.Rows.Clear();
            cbxTiposPagos.DataSource = null;
            cbxTiposPagos.Items.Clear();
            cbxTiposPagos.AutoCompleteSource = AutoCompleteSource.None;
            cbxTiposPagos.AutoCompleteMode = AutoCompleteMode.None;

            
            
                dtPagos = sQLVentas.Sk_Tipos_PagoVenta();
    

            if (dtPagos != null)
            {
                DataRow dr = dtPagos.NewRow();

                dr["K_Tipo_Pago"] = 0;
                dr["D_Tipo_Pago"] = "SELECCIONAR";
                //dr["B_Aplica_CXP"] = false;
                //dr["B_Aplica_CXC"] = false;
                //dr["B_NotaCredito"] = false;
                //dr["B_Incobrable"] = false;
                //dr["B_Aplica_Venta"] = false;

                dtPagos.Rows.InsertAt(dr, 0);

                dtPagos.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtPagos, ref cbxTiposPagos, "K_Tipo_Pago", "D_Tipo_Pago", indice);

                cbxTiposPagos.SelectedIndex = 1;
            }


        }


        private void Frm_Pagos_Venta_Shown(object sender, EventArgs e)
        {
            BaseBarraHerramientas.Visible = false;
            BarraEstatus.Visible = false;
            PnlTGral.Visible = false;
            PnlTGral.Enabled = false;
            dtTiposPagos = Detalle_PagosCXP_Table;
            //LblTotal.Text = Convert.ToString(_Monto);
            //LblResta.Text = Convert.ToString(_Monto);
            MtdCargaAlmacen();
            txtMontoPago.Focus();
        }

        private void BtnBancoTrans_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Trans_Ent = frm.LLave_Seleccionado;
            txtBancoTrans.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBancoTarjeta_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Trajeta_Ent = frm.LLave_Seleccionado;
            txtBanco.Text = frm.Descripcion_Seleccionado;
        }

        private void BtnBancoCheque_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Cheque_Ent = frm.LLave_Seleccionado;
            txtBancoCheque.Text = frm.Descripcion_Seleccionado;
        }

        private void cbxTiposPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTiposPagos_DisplayMemberChanged(object sender, EventArgs e)
        {
            if (cbxTiposPagos.SelectedText.ToString() == "CHEQUE")
            {
                PnlCheque.Dock = DockStyle.Fill;
                PnlTGral.Visible = true;
                PnlTGral.Enabled = true;
                PnlCheque.Visible = true;
                PnlCheque.Enabled = true;
                PnlTransferencia.Visible = false;
                PnlTransferencia.Enabled = false;
                PnlTarjeta.Visible = false;
                PnlTarjeta.Enabled = false;
            }
            else if (cbxTiposPagos.SelectedText.ToString() == "TRANSFERENCIA")
            {
                PnlTransferencia.Dock = DockStyle.Fill;
                PnlTGral.Visible = true;
                PnlTGral.Enabled = true;
                PnlCheque.Visible = false;
                PnlCheque.Enabled = false;
                PnlTransferencia.Visible = true;
                PnlTransferencia.Enabled = true;
                PnlTarjeta.Visible = false;
                PnlTarjeta.Enabled = false;
            }
            else if (cbxTiposPagos.SelectedText.ToString() == "TARJETA")
            {
                PnlTarjeta.Dock = DockStyle.Fill;
                PnlTGral.Visible = true;
                PnlTGral.Enabled = true;
                PnlCheque.Visible = false;
                PnlCheque.Enabled = false;
                PnlTransferencia.Visible = false;
                PnlTransferencia.Enabled = false;
                PnlTarjeta.Visible = true;
                PnlTarjeta.Enabled = true;
            }
            else
            {
                PnlTGral.Visible = false;
                PnlTGral.Enabled = false;
                PnlCheque.Visible = false;
                PnlCheque.Enabled = false;
                PnlTransferencia.Visible = false;
                PnlTransferencia.Enabled = false;
                PnlTarjeta.Visible = false;
                PnlTarjeta.Enabled = false;
            }
        }

        private void cbxTiposPagos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxTiposPagos.SelectedText.ToString());
            if (cbxTiposPagos.SelectedValue.ToString() == "2") //cheque
            {
                PnlCheque.Dock = DockStyle.Fill;
                PnlTGral.Visible = true;
                PnlTGral.Enabled = true;
                PnlCheque.Visible = true;
                PnlCheque.Enabled = true;
                PnlTransferencia.Visible = false;
                PnlTransferencia.Enabled = false;
                PnlTarjeta.Visible = false;
                PnlTarjeta.Enabled = false;
                BtnBancoCheque.Focus();

            }
            else if (cbxTiposPagos.SelectedValue.ToString() == "3")//transferencia
            {
                PnlTransferencia.Dock = DockStyle.Fill;
                PnlTGral.Visible = true;
                PnlTGral.Enabled = true;
                PnlCheque.Visible = false;
                PnlCheque.Enabled = false;
                PnlTransferencia.Visible = true;
                PnlTransferencia.Enabled = true;
                PnlTarjeta.Visible = false;
                PnlTarjeta.Enabled = false;
                BtnBancoTrans.Focus();
            }
            else if (cbxTiposPagos.SelectedValue.ToString() == "5") //tarjeta
            {
                PnlTarjeta.Dock = DockStyle.Fill;
                PnlTGral.Visible = true;
                PnlTGral.Enabled = true;
                PnlCheque.Visible = false;
                PnlCheque.Enabled = false;
                PnlTransferencia.Visible = false;
                PnlTransferencia.Enabled = false;
                PnlTarjeta.Visible = true;
                PnlTarjeta.Enabled = true;
                btnBancoTarjeta.Focus();
            }
            else
            {
                PnlTGral.Visible = false;
                PnlTGral.Enabled = false;
                PnlCheque.Visible = false;
                PnlCheque.Enabled = false;
                PnlTransferencia.Visible = false;
                PnlTransferencia.Enabled = false;
                PnlTarjeta.Visible = false;
                PnlTarjeta.Enabled = false;
            }
        }

        private void BtnAgergar_Click_1(object sender, EventArgs e)
        {
            int K_Tipo_Pago;
            bool B_Existe;

            if (Txt_Caja_Chica.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR LA CAJA CHICA A LIQUIDAR!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMontoPago.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL MONTO DEL PAGO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(cbxTiposPagos.SelectedValue) == 0)
            {
                MessageBox.Show("DEBE INDICAR EL TIPO DE PAGO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(cbxTiposPagos.SelectedValue) == 2)
            {
                if (K_Banco_Cheque_Ent == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL BANCO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNoCheque.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUMERO DE CHEQUE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtCuenqueCheque.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR LA CUENTA DEL CHEQUE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (Convert.ToInt32(cbxTiposPagos.SelectedValue) == 3)
            {
                if (K_Banco_Trans_Ent == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL BANCO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNoTrans.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUMERO DE TRANSFERENCIA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtReferencia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUMERO DE REFERENCIA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (Convert.ToInt32(cbxTiposPagos.SelectedValue) == 5)
            {
                if (K_Banco_Trajeta_Ent == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL BANCO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNumTarjeta.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUMERO DE TARJETA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNumOperacion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUEMRO DE OPERACION!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAprobacion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUEMRO DE APROBACION!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (LblResta.Text  == "0.00")
            {
                MessageBox.Show("EL MONTO DE PAGO SOLICITADO A SIDO CUBIERTO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LimpiaControles();
            //TOTAL, CALCULA,  RESTA , CAMBIO
            //CALCULA 
            if (LblResta.Text == LblTotal.Text)
            {
               LblTotalCal.Text = LblTotal.Text;
            }
            else
            {
              LblTotalCal.Text = LblResta.Text;
            }
            //RESTA //CAMBIO 
            LblResta.Text = Convert.ToString(Convert.ToDecimal(LblTotalCal.Text) - Convert.ToDecimal(txtMontoPago.Text));
            if ((Convert.ToDecimal(LblResta.Text)) < 0)
            {
                LblResta.Text = "0.00";
            }

            if (dbgPagos.RowCount == 0)
            {
                DataRow dr;
                dr = dtTiposPagos.NewRow();


                if (cbxTiposPagos.SelectedValue.ToString() == "1")
                {
                    dr["D_Tipo_Pago"] = "EFECTIVO";
                }
                else if (cbxTiposPagos.SelectedValue.ToString() == "2")
                {
                    dr["D_Tipo_Pago"] = "CHEQUE";
                }
                else if (cbxTiposPagos.SelectedValue.ToString() == "3")
                {
                    dr["D_Tipo_Pago"] = "TRANSFERENCIA";
                }
                else
                {
                    dr["D_Tipo_Pago"] = "TARJETA";
                }
                if (K_Banco_Trajeta_Ent == 0)
                {
                    dr["K_Banco_Tarjeta"] = DBNull.Value;
                }
                else
                {
                    dr["K_Banco_Tarjeta"] = K_Banco_Trajeta_Ent;
                }
                if (K_Banco_Cheque_Ent == 0)
                {
                    dr["K_Banco_Cheque"] = DBNull.Value;
                }
                else
                {
                    dr["K_Banco_Cheque"] = K_Banco_Cheque_Ent;
                }
                if (K_Banco_Trans_Ent == 0)
                {
                    dr["K_Banco_Transferencia"] = DBNull.Value;
                }
                else
                {
                    dr["K_Banco_Transferencia"] = K_Banco_Trans_Ent;
                }


                dr["K_Tipo_Pago"] = cbxTiposPagos.SelectedValue;
                dr["Monto_Pago"] = Convert.ToDecimal(txtMontoPago.Text);
                dr["No_Tarjeta_Credito"] = txtNumTarjeta.Text;
                dr["No_Tarjeta_Debito"] = txtNumTarjeta.Text;
                dr["Aprobacion"] = txtAprobacion.Text;
                dr["No_Operacion"] = txtNumOperacion.Text;
                dr["No_Cheque"] = txtNoCheque.Text;
                dr["Cuenta_Cheque"] = txtCuenqueCheque.Text;
                dr["No_Transferencia"] = txtNoTrans.Text;
                dr["Cuenta_Transferencia"] = txtCuentaTrans.Text;
                dr["Referencia_Transferencia"] = txtReferencia.Text;
                dtTiposPagos.Rows.Add(dr);

            }
            else
            {
                B_Existe = false;
                ////se encuentra  sumo 
                //foreach (DataRow row in dtTiposPagos.Rows)
                //{
                //    K_Tipo_Pago = Convert.ToInt32(row["K_Tipo_Pago"].ToString());
                //    B_Existe = false;

                //    if (Convert.ToInt32(cbxTiposPagos.SelectedValue) == K_Tipo_Pago)
                //    {

                //        row["Monto_Pago"] = Convert.ToDecimal(txtMontoPago.Text) + Convert.ToDecimal(row["Monto_Pago"]);
                //        B_Existe = true;
                //        break;

                //    }
                //}
                if (B_Existe == false)
                {
                    DataRow dr;
                    dr = dtTiposPagos.NewRow();

                    dr["K_Tipo_Pago"] = cbxTiposPagos.SelectedValue;

                    if (cbxTiposPagos.SelectedValue.ToString() == "1")
                    {
                        dr["D_Tipo_Pago"] = "EFECTIVO";
                    }
                    else if(cbxTiposPagos.SelectedValue.ToString() == "2")
                    {
                        dr["D_Tipo_Pago"] = "CHEQUE";
                    }
                    else if(cbxTiposPagos.SelectedValue.ToString() == "3")
                    {
                        dr["D_Tipo_Pago"] = "TRANSFERENCIA";
                    }
                    else
                    {
                        dr["D_Tipo_Pago"] = "TARJETA";
                    }
                    if (K_Banco_Trajeta_Ent == 0)
                    {
                        dr["K_Banco_Tarjeta"] = DBNull.Value;
                    }
                    else
                    {
                        dr["K_Banco_Tarjeta"] = K_Banco_Trajeta_Ent;
                    }
                    if (K_Banco_Cheque_Ent == 0)
                    {
                        dr["K_Banco_Cheque"] = DBNull.Value;
                    }
                    else
                    {
                        dr["K_Banco_Cheque"] = K_Banco_Cheque_Ent;
                    }
                    if (K_Banco_Trans_Ent == 0)
                    {
                        dr["K_Banco_Transferencia"] = DBNull.Value;
                    }
                    else
                    {
                        dr["K_Banco_Transferencia"] = K_Banco_Trans_Ent;
                    }


                    dr["Monto_Pago"] = Convert.ToDecimal(txtMontoPago.Text);
                    dr["K_Banco_Tarjeta"] = K_Banco_Trajeta_Ent;
                    dr["No_Tarjeta_Credito"] = txtNumTarjeta.Text;
                    dr["No_Tarjeta_Debito"] = txtNumTarjeta.Text;
                    dr["Aprobacion"] = txtAprobacion.Text;
                    dr["No_Operacion"] = txtNumOperacion.Text;
                    dr["No_Cheque"] = txtNoCheque.Text;
                    dr["K_Banco_Cheque"] = K_Banco_Cheque_Ent;
                    dr["Cuenta_Cheque"] = txtCuenqueCheque.Text;
                    dr["No_Transferencia"] = txtNoTrans.Text;
                    dr["Cuenta_Transferencia"] = dbgPagos.Text;
                    dr["K_Banco_Transferencia"] = K_Banco_Trans_Ent;
                    dr["Referencia_Transferencia"] = txtReferencia.Text;
                    dtTiposPagos.Rows.Add(dr);

                }


            }
            dbgPagos.DataSource = dtTiposPagos;
            cbxTiposPagos.SelectedIndex = 1;
            txtMontoPago.Text = "";
            txtMontoPago.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Caja_Chica.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR LA CAJA CHICA A LIQUIDAR!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (LblTotal.Text == "0.00")
            {
                MessageBox.Show("EL MONTO DE PAGO NO ESTA DEFINIDO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (LblResta.Text != "0.00")
            {
                MessageBox.Show("EL MONTO DE PAGO SOLICITADO NO A SIDO CUBIERTO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dtPagos_Completos = Detalle_PagosCXP_Table;

            foreach (DataGridViewRow rowGrid in dbgPagos.Rows)
            {
                DataRow dr = dtPagos_Completos.NewRow();
                dr["K_Caja_Chica"] = Convert.ToInt32(Txt_Caja_Chica.Text);
                dr["K_Tipo_Pago"] = Convert.ToInt32(rowGrid.Cells["K_Tipo_Pago"].Value);
                dr["D_Tipo_Pago"] = rowGrid.Cells["D_Tipo_Pago"].Value;
                dr["Monto_Pago"] = Convert.ToDecimal(rowGrid.Cells["Monto"].Value);
                if (Convert.ToInt32(K_Banco_Trajeta_Ent) > 0)
                {
                    dr["K_Banco_Tarjeta"] = Convert.ToInt32(rowGrid.Cells["K_Banco_Tarjeta"].Value);
                }
                else
                {
                    dr["K_Banco_Tarjeta"] = rowGrid.Cells["K_Banco_Tarjeta"].Value;
                }
                dr["No_Tarjeta_Credito"] = rowGrid.Cells["No_Tarjeta_Credito"].Value;
                dr["No_Tarjeta_Debito"] = rowGrid.Cells["No_Tarjeta_Debito"].Value;
                dr["Aprobacion"] = rowGrid.Cells["Aprobacion"].Value;
                dr["No_Operacion"] = rowGrid.Cells["No_Operacion"].Value;
                dr["No_Cheque"] = rowGrid.Cells["No_Cheque"].Value;
                if (Convert.ToInt32(K_Banco_Cheque_Ent) > 0)
                {
                    dr["K_Banco_Cheque"] = Convert.ToInt32(rowGrid.Cells["K_Banco_Cheque"].Value);
                }
                else
                {
                    dr["K_Banco_Cheque"] = rowGrid.Cells["K_Banco_Cheque"].Value;
                }
                dr["Cuenta_Cheque"] = rowGrid.Cells["Cuenta_Cheque"].Value;
                dr["No_Transferencia"] = rowGrid.Cells["No_Transferencia"].Value;
                dr["Cuenta_Transferencia"] = rowGrid.Cells["Cuenta_Transferencia"].Value;
                if (Convert.ToInt32(K_Banco_Trans_Ent) > 0)
                {
                    dr["K_Banco_Transferencia"] = Convert.ToInt32(rowGrid.Cells["K_Banco_Transferencia"].Value);
                }
                else
                {
                    dr["K_Banco_Transferencia"] = rowGrid.Cells["K_Banco_Transferencia"].Value;
                }

                dtPagos_Completos.Rows.Add(dr);

                txtAprobacion.Text = "";
            }

            res = sqlCXP.Gp_Liquida_Caja(dtPagos_Completos, Convert.ToInt32(Txt_Caja_Chica.Text), Convert.ToDecimal(LblTotal.Text), ref msg);

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("LA CAJA CHICA SE LIQUIDO CORRECTAMENTE...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

        }

        private void dbgPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgPagos.Rows.Count < 0)
            {
                return;
            }
            if (Convert.ToInt32(dbgPagos.Rows[e.RowIndex]) == -1)
            {
                return;
            }

            if (dbgPagos.Columns[e.ColumnIndex].Name == "Menos")
                {
                    Mtd_Disminuir(sender, e);

                }
        }
        public void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
        {

            dbgPagos.Rows.RemoveAt(dbgPagos.CurrentRow.Index);

            //recalcular montos 
            LblResta.Text = Convert.ToString(Convert.ToDecimal(LblTotalCal.Text));
            if ((Convert.ToDecimal(LblResta.Text)) < 0)
            {
                LblResta.Text = "0.00";
            }


        }

        private void txtMontoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumeroDecimal(ref e);
        }

        private void txtNoCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuenqueCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAprobacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNoTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuentaTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnBancoCheque_Click_1(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Cheque_Ent = frm.LLave_Seleccionado;
            txtBancoCheque.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBancoTarjeta_Click_1(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Trajeta_Ent = frm.LLave_Seleccionado;
            txtBanco.Text = frm.Descripcion_Seleccionado;
        }

        private void BtnBancoTrans_Click_1(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();
            K_Banco_Trans_Ent = frm.LLave_Seleccionado;
            txtBancoTrans.Text = frm.Descripcion_Seleccionado;
        }
        void LimpiaControles()
        {
            txtAprobacion.Text = "";
            txtBanco.Text = "";
            txtBancoCheque.Text = "";
            txtBancoTrans.Text = "";
            txtCuenqueCheque.Text = "";
            txtCuentaTrans.Text = "";
            txtNoCheque.Text = "";
            txtNoTrans.Text = "";
            txtNumOperacion.Text = "";
            txtNumTarjeta.Text = "";
            txtReferencia.Text = "";
         }            
    }


}
