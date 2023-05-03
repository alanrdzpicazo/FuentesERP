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

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Cancelacion_Venta : Forma
    {
        SQLVentas sqlVentas = new SQLVentas();

        DataTable dtVentas = new DataTable();
        DataTable dtDatos = new DataTable();

        string Detalle_Articulos = string.Empty;
        public DataTable DetalleCancelacion_Venta_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Almacen", (typeof(int)));
                dt.Columns.Add("K_Precierre_Empleado", (typeof(int)));
                dt.Columns.Add("K_Usuario", (typeof(int)));
                dt.Columns.Add("K_Transaccion", (typeof(int)));
                dt.Columns.Add("Cantidad_Cancelada", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Lote", (typeof(string)));
                dt.Columns.Add("F_Caducidad", (typeof(string)));
                dt.Columns.Add("Monto_Total", (typeof(decimal)));
                dt.Columns.Add("Precio_Unitario", (typeof(decimal)));
                return dt;
            }
        }

        public Frm_Cancelacion_Venta()
        {
            InitializeComponent();
        }
        private void Frm_Cancelacion_Venta_Load(object sender, EventArgs e)
        {
         
        }
        private void Frm_Cancelacion_Venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btn_Limpiar.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btn_Cancelar.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btn_Salir.PerformClick();
            }
        }
        private void txt_Folio_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode ==Keys.Tab))
            {
                if (txt_Folio.Text.Trim().Length == 0)
                {
                    MessageBox.Show("CAPTURE UN NUMERO DE FOLIO. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Folio.Focus();
                    return;
                }

                dtVentas = sqlVentas.Gp_Consulta_Venta(Convert.ToInt32(txt_Folio.Text.Trim()));
                if (dtVentas != null)
                {
                    dtVentas.Columns.Add(new DataColumn("Cantidad_Cancelacion", typeof(decimal)));

                    foreach (DataRow row in dtVentas.Rows)
                    {
                        if (row["Cantidad_Cancelacion"] == DBNull.Value)
                        {
                            row["Cantidad_Cancelacion"] = 0;
                        }
                    }
                    grdDatos.DataSource = dtVentas;
                    txt_Usuario.Text = "[" + dtVentas.Rows[0].ItemArray[4].ToString() + "] " + dtVentas.Rows[0].ItemArray[5].ToString();
                    txt_Almacen.Text = "[" + dtVentas.Rows[0].ItemArray[1].ToString() + "] " + dtVentas.Rows[0].ItemArray[2].ToString();
                    txt_Cliente.Text = dtVentas.Rows[0].ItemArray[12].ToString();
                    DateTime d = new DateTime();
                    d = Convert.ToDateTime(dtVentas.Rows[0].ItemArray[6].ToString());
                    lbl_Fecha.Text = d.ToString("dd/MM/yyyy hh:mm:ss");
                    lbl_Total.Text = dtVentas.Rows[0].ItemArray[7].ToString();
                    grdDatos.ClearSelection();
                    txt_Observaciones.Focus();

                    grdDatos.EditMode = DataGridViewEditMode.EditOnEnter;
                    if (grdDatos.Rows.Count > 0)
                    {
                        grdDatos.Rows[0].Cells["Cantidad_Cancelacion"].Selected = true;
                        grdDatos.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("EL FOLIO [" + txt_Folio.Text.Trim() + "] NO SE HA REGISTRADO COMO TRANSACCION. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Folio.Focus();
                    return;
                }
            }
        }
        private void txt_Folio_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
                {
                    if (txt_Folio.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("CAPTURE UN NUMERO DE FOLIO. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Folio.Focus();
                        return;
                    }

                    dtVentas = sqlVentas.Gp_Consulta_Venta(Convert.ToInt32(txt_Folio.Text.Trim()));

                    if (dtVentas != null)
                    {
                        dtVentas.Columns.Add(new DataColumn("Cantidad_Cancelacion", typeof(decimal)));

                        foreach (DataRow row in dtVentas.Rows)
                        {

                            if (row["Cantidad_Cancelacion"] == DBNull.Value)
                            {
                                row["Cantidad_Cancelacion"] = 0;
                            }
                        }
                        grdDatos.DataSource = dtVentas;
                        txt_Usuario.Text = "[" + dtVentas.Rows[0].ItemArray[4].ToString() + "] " + dtVentas.Rows[0].ItemArray[5].ToString();
                        txt_Almacen.Text = "[" + dtVentas.Rows[0].ItemArray[1].ToString() + "] " + dtVentas.Rows[0].ItemArray[2].ToString();
                        txt_Cliente.Text = dtVentas.Rows[0].ItemArray[12].ToString();
                        DateTime d = new DateTime();
                        d = Convert.ToDateTime(dtVentas.Rows[0].ItemArray[6].ToString());
                        lbl_Fecha.Text = d.ToString("dd/MM/yyyy hh:mm:ss") ;
                        lbl_Total.Text = dtVentas.Rows[0].ItemArray[7].ToString();
                        grdDatos.ClearSelection();
                        txt_Observaciones.Focus();
                    }
                    else
                    {
                        MessageBox.Show("EL FOLIO [" + txt_Folio.Text.Trim() + "] NO SE HA REGISTRADO COMO TRANSACCION. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Observaciones.Focus();
                        return;
                    }
                }
            }
        }
        private void txt_Folio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones fx = new Funciones();
            fx.ValidaSeaNumero(ref e);
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Folio.Text = string.Empty;
            txt_Usuario.Text = string.Empty;
            txt_Almacen.Text = string.Empty;
            txt_Cliente.Text = string.Empty;
            lbl_Fecha.Text = "_____________________";
            lbl_Total.Text = "________";
            if (dtVentas != null)
                dtVentas.Rows.Clear();
            grdDatos.DataSource = dtVentas;
            txt_Folio.Focus();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if(dtVentas!=null)
            {
                if(dtVentas.Rows.Count>0)
                {
                    string msg = string.Empty;
                    int res = 0;
                    DataTable dtDetalle = Mtd_Detalle_Cancelacion();

                    DialogResult dlg = MessageBox.Show("SERAN CANCELADOS LOS SIGUIENTES ARTICULOS: " + Detalle_Articulos + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        res = sqlVentas.Gp_Cancela_Venta(Convert.ToInt32(txt_Folio.Text.Trim()), txt_Observaciones.Text.Trim(), dtDetalle,GlobalVar.K_Usuario,GlobalVar.PC_Name, ref msg);
                        if (res == -1)
                        {
                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("SE CANCELO LA TRANSACCION CORRECTAMENTE CON NUMERO DE FOLIO [" + txt_Folio.Text + "]...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Limpiar.PerformClick();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("DEBE BUSCAR UN TICKET...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Folio.Focus();
                }
            }
        }    
        private void grdDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl text = (DataGridViewTextBoxEditingControl)e.Control;
            text.KeyPress -= new KeyPressEventHandler(textbox_KeyPress);
            text.KeyPress += new KeyPressEventHandler(textbox_KeyPress);
        }
        private void grdDatos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;

            if (grdDatos == null)
            {
                return;
            }
            if (grdDatos.CurrentRow == null)
            {
                return;
            }
            if (e.ColumnIndex == 27) //cantidad a cancelar
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    grdDatos.CancelEdit();
                    return;
                }

                if (!EsNumero(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                {
                    grdDatos.CancelEdit();
                    return;
                }
                if (row != null)
                {
                    if (Convert.ToDecimal(row.Cells["Cantidad_Articulos"].Value) < Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                    {
                        MessageBox.Show("LA CANTIDAD A CANCELAR NO PUEDE SER MAYOR A LA CANTIDAD DE LA TRANSACCION, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grdDatos.CancelEdit();
                        return;
                    }
                }
            }
        }
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public DataTable Mtd_Detalle_Cancelacion()
        {
            Detalle_Articulos = string.Empty;
            DataTable dtDatos = new DataTable();
            dtDatos = DetalleCancelacion_Venta_Type;

            int row_K_Almacen = 0;
            int row_K_Precierre_Empleado = 0;
            int row_K_Usuario = 0;
            int row_K_Transaccion = 0;
            int row_Cantidad_Cancelada = 0;
            int row_K_Articulo = 0;
            string row_Lote = string.Empty;
            string row_F_Caducidad = string.Empty;
            decimal row_Monto_Total = 0;
            decimal row_Precio_Unitario = 0;
        
            foreach (DataGridViewRow row in grdDatos.Rows)
            {
                if(int.Parse(row.Cells["Cantidad_Cancelacion"].Value.ToString()) >0)
                {
                    row_K_Almacen = int.Parse(row.Cells["K_Almacen"].Value.ToString());
                    row_K_Precierre_Empleado = int.Parse(row.Cells["K_Precierre_Empleado"].Value.ToString());
                    row_K_Usuario = Convert.ToInt32(GlobalVar.K_Usuario);
                    row_K_Transaccion = Convert.ToInt32(row.Cells["K_Transaccion"].Value.ToString());
                    row_Cantidad_Cancelada = Convert.ToInt32(row.Cells["Cantidad_Cancelacion"].Value.ToString());
                    row_K_Articulo = Convert.ToInt32(row.Cells["K_Articulo"].Value.ToString());
                    row_Lote = row.Cells["Lote"].Value.ToString();
                    row_F_Caducidad =row.Cells["F_Caducidad"].Value.ToString();
                    row_Monto_Total = Convert.ToDecimal(row.Cells["Monto_Total"].Value.ToString());
                    row_Precio_Unitario = Convert.ToDecimal(row.Cells["Precio_Unitario"].Value.ToString());             
                    Detalle_Articulos+= row.Cells["D_Articulo"].Value.ToString()+" | LOTE:"+ row.Cells["Lote"].Value.ToString()+". \n";
                    dtDatos.Rows.Add(row_K_Almacen, row_K_Precierre_Empleado, row_K_Usuario, row_K_Transaccion, row_Cantidad_Cancelada, row_K_Articulo, row_Lote, row_F_Caducidad, row_Monto_Total, row_Precio_Unitario);
                }
            }
            return dtDatos;    
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
