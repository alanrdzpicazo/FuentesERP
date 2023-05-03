﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_PreCierre_Empleado : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        DataTable dtTiposPagos = new DataTable();
        DataTable dtTiposPagosPrecierre = new DataTable();

        public Int32 p_K_Almacen { get; set; }

        int res = 0;
        string msg = string.Empty;

        bool B_NoEntrar = false;
        String strKeyPress = "";

        public Frm_PreCierre_Empleado(/*Int32 K_Usuario = 1,String D_Usuario="ERIKA PATRICIA ROSALES RANGEL",Int32 K_Almacen=2*/)
        {
            BaseGridSinFormato = true;
            InitializeComponent();

        }

        public override void BaseMetodoInicio()
        {

            Dgv_Tipos_Pagos.AutoGenerateColumns = false;
            this.Txt_Clave_Usuario.Text = Convert.ToString(GlobalVar.K_Usuario);
            this.Txt_Usuario.Text = GlobalVar.D_Usuario;
            this.BaseBarraHerramientas.Visible = false;
            Int32 CampoIdentity_K_Precierre_Empleado = 0;

            res = sqlVentas.Gp_Trae_Precierre(p_K_Almacen, Convert.ToInt32(Txt_Clave_Usuario.Text.Trim()), ref CampoIdentity_K_Precierre_Empleado, ref msg);

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg.ToUpper(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                BaseErrorResultado = false;
                this.Txt_No_Precierre.Text = CampoIdentity_K_Precierre_Empleado.ToString();
                Mtd_Llenar_Tipos_Pago();

                //BaseMetodoInicio();
                //BaseBotonCancelarClick();
            }
        }
        void Mtd_Llenar_Tipos_Pago()
        {
            dtTiposPagos = sqlVentas.Sk_Tipos_PagoVenta();
            dtTiposPagosPrecierre = sqlVentas.Sk_Tipos_PagoPrecierre(Convert.ToInt32(Txt_No_Precierre.Text.Trim()));
            if (dtTiposPagos != null)
            {
                if (dtTiposPagos.Rows.Count > 0)
                {
                    dtTiposPagos.Columns.Add("Monto_Pago", (typeof(decimal)));

                    foreach (DataRow dt in dtTiposPagos.Rows)
                    {
                        if (dt["D_Tipo_Pago"].ToString() == "CREDITO")
                        {
                            if (dtTiposPagosPrecierre != null)
                            {
                                var z = dtTiposPagosPrecierre.AsEnumerable().Where(x => x.Field<string>("D_Tipo_Pago") == "CREDITO").AsDataView();

                                if (z.Count > 0)
                                {
                                    dt["Monto_Pago"] = z[0][2];
                                }
                                else
                                {
                                    dt["Monto_Pago"] = 0.00;
                                }
                            }
                            else
                            {
                                dt["Monto_Pago"] = 0.00;
                            }
                        }
                        else if (dt["D_Tipo_Pago"].ToString() == "MONEDERO ELECTRONICO")
                        {
                            if (dtTiposPagosPrecierre != null)
                            {
                                var z = dtTiposPagosPrecierre.AsEnumerable().Where(x => x.Field<string>("D_Tipo_Pago") == "MONEDERO ELECTRONICO").AsDataView();

                                if (z.Count > 0)
                                {
                                    dt["Monto_Pago"] = z[0][2];
                                }
                                else
                                {
                                    dt["Monto_Pago"] = 0.00;
                                }
                            }
                            else
                            {
                                dt["Monto_Pago"] = 0.00;
                            }

                        }
                        else
                        {
                            dt["Monto_Pago"] = 0.00;
                        }

                    }

                    Dgv_Tipos_Pagos.DataSource = dtTiposPagos;
                    Dgv_Tipos_Pagos.EditMode = DataGridViewEditMode.EditOnEnter;
                    Dgv_Tipos_Pagos.MultiSelect = false;

                    Dgv_Tipos_Pagos.Rows[0].Cells["Monto_Pago"].Selected = true;
                    Dgv_Tipos_Pagos.Focus();


                }
                else
                {
                    MessageBox.Show("NO EXISTEN TIPOS DE PAGOS DADOS DE ALTA \r\n" +
                      "DEBE DE CREAR UN TIPO DE PAGO!...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("NO EXISTEN TIPOS DE PAGOS DADOS DE ALTA \r\n" +
                 "DEBE DE CREAR UN TIPO DE PAGO!...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool blnCeldaImportes()
        {
            if (Dgv_Tipos_Pagos.CurrentCell == null)
                return false;
            //if (B_NoEntrar == false)
            //    return false;

            return (Dgv_Tipos_Pagos.CurrentCell.ColumnIndex == 2);
        }

        private void Dgv_Tipos_Pagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!Dgv_Tipos_Pagos.CurrentCell.IsInEditMode)
                {
                    //grdDetalle.CurrentCell.ed = true;
                    Dgv_Tipos_Pagos.BeginEdit(true);
                    return;
                }
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;
                    if (Convert.ToDecimal((Boolean)(textBox.Text.Length == 0) ? "0" : textBox.Text.Replace("$", "0").Replace(".", "0")) == 0)
                    {
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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Int32 CampoIdentity = 0;
            string msg = string.Empty;
            res = 0;
            DataTable dtDetalle = Mtd_LLenar_Detalle_Pagos();
            BaseBotonGuardar.Enabled = true;
            if (dtDetalle != null)
            {
                try
                {
                    if (!BaseFuncionValidaciones())
                        return;
                    res = sqlVentas.Gp_Aplica_Precierre(
                        p_K_Almacen,
                        Convert.ToInt32(Txt_Clave_Usuario.Text),
                        dtDetalle,
                        ref CampoIdentity,
                        ref msg
                        );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("SE REALIZO EL PRECIERRE DEL USUARIO: " + Txt_Usuario.Text + "  CON CONSECUTIVO [" + CampoIdentity + "]...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte_Gp_RepPrecierre(CampoIdentity, Convert.ToInt32(Txt_Clave_Usuario.Text));
                    Cursor = Cursors.Default;
                    this.Close();
                }
            }
        }

        public DataTable Mtd_LLenar_Detalle_Pagos()
        {
            DataTable dtDatos = new DataTable();
            dtDatos = PagoPrecierreType;

            int row_K_Tipo_Pago = 0;
            decimal row_Monto_Pago;

            foreach (DataGridViewRow row in this.Dgv_Tipos_Pagos.Rows)
            {
                row_K_Tipo_Pago = int.Parse(row.Cells["K_Tipo_Pago"].Value.ToString());
                row_Monto_Pago = decimal.Parse(row.Cells["Monto_Pago"].Value.ToString());

                dtDatos.Rows.Add(row_K_Tipo_Pago, row_Monto_Pago);
            }

            return dtDatos;
        }

        void Reporte_Gp_RepPrecierre(Int32 K_Precierre_Empleado, Int32 K_Usuario)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = sqlVentas.Gp_RepPrecierre(K_Precierre_Empleado, K_Usuario);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new VENTAS.RPT_PreCierre_Empleado();
                ReporteTitulo = "REPORTE DE PRECIERRE";
                ReporteModulo = "Ventas";
                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private void Dgv_Tipos_Pagos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Dgv_Tipos_Pagos_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(Dgv_Tipos_Pagos_KeyPress);
            e.Control.TextChanged += new EventHandler(Dgv_Tipos_Pagos_TextChanged);
        }
        private void Dgv_Tipos_Pagos_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Trim().Length > 0)
            {
                try
                {
                    if (Convert.ToDecimal(textBox.Text.Trim()) > 1000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
                catch (Exception ex) { }

            }

        }
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void Dgv_Tipos_Pagos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = Dgv_Tipos_Pagos.CurrentRow;


            if (e.ColumnIndex == 2)
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    Dgv_Tipos_Pagos.CancelEdit();

                    return;
                }

                if (!EsNumero(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                {
                    Dgv_Tipos_Pagos.CancelEdit();
                    return;
                }
            }
        }
    }
}
