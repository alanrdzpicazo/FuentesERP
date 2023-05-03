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

namespace ProbeMedic.FACTURACION
{
    public partial class 
        Frm_VP_Asigna_Inventario : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        public Int32 p_K_Almacen { get; set; }
        public String p_D_Almacen { get; set; }
        public Int32 p_K_Articulo { get; set; }
        public String p_D_Articulo { get; set; }
        public Int32 p_K_Oficina { get; set; }
        public String p_D_Oficina { get; set; }
        public Int32 p_Cantidad_Solicitada { get; set; }
        public Int32 p_K_Pedido { get; set; }
        public Int32 p_K_Pedido_Detalle { get; set; }

        DataTable dtLotes = new DataTable();
        public DataTable dtResultado;
        public DataTable dtTransferidos;

        public Frm_VP_Asigna_Inventario()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }
        public override void BaseMetodoInicio()
        {
            base.BaseMetodoInicio();
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
            BaseBotonAfectar.Visible = true;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
        }

        private void Frm_VP_Asigna_Inventario_Shown(object sender, EventArgs e)
        {
            lblD_Almacen.Text = p_D_Almacen.ToString();
            lblD_Articulo.Text = p_D_Articulo.ToString();          
        }

 

        private void grdDatos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;

            if (e.ColumnIndex == 5) //cantidad a asignar
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
                    if (Convert.ToDecimal(row.Cells["Cantidad_Disponible"].Value) < Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                    {
                        MessageBox.Show("LA CANTIDAD A ASIGNAR NO PUEDE SER MAYOR A LA CANTIDAD DISPONIBLE, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }

                }

            }
        }

        private void grdDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.TextChanged += new EventHandler(grdDatos_TextChanged);
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
        private void grdDatos_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Trim().Length > 0)
            {
                try
                {
                    Int32 valor = Convert.ToInt32(textBox.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = string.Empty;
                }
            }

        }

        private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdDatos.Columns[e.ColumnIndex].Name == "No_Lote")
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString().ToUpper();
                    e.FormattingApplied = true;
                }
            }
        }

        private void grdDatos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BaseBotonAfectar.Enabled = false;
        }

        private void grdDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BaseBotonAfectar.Enabled = true;
        }
        public override void BaseBotonAfectarClick()
        {
            grdDatos.EndEdit();
            dtLotes.AcceptChanges();
            var suma = dtLotes.Compute("SUM(Cantidad_Asignada)", "");
            if (p_Cantidad_Solicitada < Convert.ToDecimal(suma))
            {
                MessageBox.Show("LA CANTIDAD A ASIGNAR NO PUEDE SER MAYOR A LA CANTIDAD SOLCITADA, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dtResultado = dtLotes.Clone();
                dtResultado.AcceptChanges();
                foreach (DataRow dr in dtLotes.Rows)
                {
                    if (Convert.ToString(dr["Cantidad_Asignada"]) != "0" && Convert.ToString(dr["Cantidad_Asignada"]) != "")
                    {
                        dtLotes.AcceptChanges();
                        dtResultado.ImportRow(dr);
                        dtResultado.AcceptChanges();
                    }
                }
                Close();
            }
          
        }

        private void Frm_VP_Asigna_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dtLotes!=null)
            {
                if(dtLotes.Rows.Count>0)
                {
                    grdDatos.EndEdit();
                    dtLotes.AcceptChanges();
                    var suma = dtLotes.Compute("SUM(Cantidad_Asignada)", "");

                    if (suma == null)
                        suma = 0;
                    if (p_Cantidad_Solicitada < Convert.ToDecimal(suma))
                    {
                        MessageBox.Show("LA CANTIDAD A ASIGNAR NO PUEDE SER MAYOR A LA CANTIDAD SOLCITADA, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    if (Convert.ToDecimal(suma) < p_Cantidad_Solicitada)
                    {
                        MessageBox.Show("LA CANTIDAD A ASIGNAR NO PUEDE SER MENOR A LA CANTIDAD SOLCITADA, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
            }
           
        }

        private void Frm_VP_Asigna_Inventario_Load(object sender, EventArgs e)
        {
            dtLotes = sqlVentas.Gp_InventarioxArticulo(p_K_Oficina, p_K_Almacen, p_K_Articulo);
            if (dtLotes != null)
            {
                if (dtLotes.Rows.Count > 0)
                {
                    dtLotes.DefaultView.Sort = "F_Caducidad ASC, Cantidad_Disponible ASC";
                    dtLotes.Columns.Add(new DataColumn("Cantidad_Asignada", typeof(Int32)));
                    dtLotes.Columns.Add(new DataColumn("K_Pedido", typeof(Int32)));
                    dtLotes.Columns.Add(new DataColumn("K_Pedido_Detalle", typeof(Int32)));
                    foreach (DataRow dr in dtLotes.Rows)
                    {
                        dr["Cantidad_Asignada"] = 0;
                        dr["K_Pedido"] = p_K_Pedido;
                        dr["K_Pedido_Detalle"] = p_K_Pedido_Detalle;
                    }
                    grdDatos.DataSource = dtLotes;

                    if (dtTransferidos != null)
                    {
                        if (dtTransferidos.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow grow in grdDatos.Rows)
                            {
                                foreach (DataRow row in dtTransferidos.Rows)
                                {
                                    if ((grow.Cells["K_Articulo"].Value.ToString() == row["K_Articulo"].ToString())
                                        &&
                                        (grow.Cells["K_Movimiento_Inventario"].Value.ToString() == row["K_Movimiento_Inventario"].ToString())
                                        &&
                                        (grow.Cells["No_Lote"].Value.ToString() == row["No_Lote"].ToString())
                                        )
                                    {

                                        grow.Cells["Cantidad_Asignada"].Value = row["Cantidad_Asignada"].ToString();

                                    }
                                }
                            }
                        }

                    }

                    grdDatos.EditMode = DataGridViewEditMode.EditOnEnter;
                    grdDatos.MultiSelect = false;
                    if (grdDatos.Rows.Count > 0)
                    {
                        grdDatos.Rows[0].Cells["Cantidad_Asignada"].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("EL ARTICULO NO TIENE EXISTENCIA EN EL ALMACEN: [ " + p_D_Almacen + " ]", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("EL ARTICULO NO TIENE EXISTENCIA EN EL ALMACEN: [ " + p_D_Almacen + " ]", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
