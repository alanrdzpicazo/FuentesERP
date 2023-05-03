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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Ajuste_Transferencia_Seleccion : Forma
    {
        DataTable dtArticulos = new DataTable();

        public int K_Oficina = 0;
        public int K_Almacen = 0;
        int K_Articulo = 0;
        string d_Articulo;

        public string Str_Oficina = "";
        public string Str_Almacen = "";

        public DataTable dtResultado;
        public DataTable dtTransferidos;
        DataTable dtResultadoDetalle = new DataTable();

        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        Funciones fx = new Funciones();

        public Frm_Ajuste_Transferencia_Seleccion()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            txtRecepcion.valor.Leave += new EventHandler(txtRecepcion_Leave);
        }
        private void txtRecepcion_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }
        private void Frm_Ajuste_Transferencia_Seleccion_Load(object sender, EventArgs e)
        {
            grdDetalle.AutoGenerateColumns = false;

            txtOficina.Text = Str_Oficina;
            txtAlmacen.Text = Str_Almacen;

            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;

            //grdDetalle.Focus();

            Txt_Sku.Focus();
        }

        void FiltraDetalle()
        {
            Int32 valor = 0;
            if ((Forma.IsNumeric(txtArticulo.Text)) && (Int32.TryParse(txtArticulo.Text.Trim(), out valor)))
            {
                K_Articulo = Convert.ToInt32(txtArticulo.Text.Trim());

                dtResultadoDetalle = sqlAlmacen.GP_INVENTARIO_DETALLE(K_Oficina, K_Articulo, K_Almacen, dtpInicio.Value, dtpFinal.Value, txtLote.Text.Trim(), (txtRecepcion.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtRecepcion.Text.Trim()), cbxMostrarTodo.Checked, Txt_Sku.Text.Trim(),string.Empty
                );

            }
            else if(txtArticulo.Text.Trim().Length>0)
            {
                K_Articulo = 0;

                dtResultadoDetalle = sqlAlmacen.GP_INVENTARIO_DETALLE(K_Oficina, K_Articulo, K_Almacen, dtpInicio.Value, dtpFinal.Value, txtLote.Text.Trim(), (txtRecepcion.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtRecepcion.Text.Trim()), cbxMostrarTodo.Checked, Txt_Sku.Text.Trim(), txtArticulo.Text.Trim()
                );
            }
            else
            {
                K_Articulo = 0;

                dtResultadoDetalle = sqlAlmacen.GP_INVENTARIO_DETALLE(K_Oficina, K_Articulo, K_Almacen, dtpInicio.Value, dtpFinal.Value, txtLote.Text.Trim(), (txtRecepcion.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtRecepcion.Text.Trim()), cbxMostrarTodo.Checked, Txt_Sku.Text.Trim(), string.Empty
                );
            }

            if (dtResultadoDetalle != null)
            {
                dtResultadoDetalle.Columns.Add(new DataColumn("Seleccion", typeof(bool)));
                dtResultadoDetalle.Columns.Add(new DataColumn("Cantidad_Transferir", typeof(decimal)));

                foreach (DataRow dr in dtResultadoDetalle.Rows)
                {
                    dr["Seleccion"] = false;
                    dr["Cantidad_Transferir"] = 0;
                }

            }
            grdDetalle.DataSource = dtResultadoDetalle;


            if (dtTransferidos != null)
            {
                foreach (DataGridViewRow grow in grdDetalle.Rows)
                {
                    foreach (DataRow row in dtTransferidos.Rows)
                    {
                        if (grow.Cells["K_Movimiento_Inventario"].Value.ToString() == row["K_Movimiento_Inventario"].ToString())
                        {
                            grow.Cells["Cantidad_Transferir"].ReadOnly = true;
                            grow.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
                        }
                    }
                }

            }

            //Txt_Sku.Focus();

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void txtRecepcion_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void grdDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = grdDetalle.CurrentRow;


            if (e.ColumnIndex == 14) //cantidad a transferir
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
                    if (Convert.ToDecimal(row.Cells["Cantidad_Disponible"].Value) < Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                    {
                        MessageBox.Show("LA CANTIDAD A TRANSFERIR NO PUEDE SER MAYOR A LA CANTIDAD DISPONIBLE, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(dtResultadoDetalle!=null)
            {
                if(dtResultadoDetalle.Rows.Count>0)
                {
                    dtResultado = dtResultadoDetalle.Clone();

                    string mensaje = string.Empty;

                    foreach (DataRow dr in dtResultadoDetalle.Rows)
                    {
                        if (Convert.ToString(dr["Cantidad_Transferir"]) != "0" && Convert.ToString(dr["Cantidad_Transferir"]) != "")
                        {
                            dtResultado.ImportRow(dr);
                        }
                    }
                }
            }        
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {            
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            Txt_Sku.Text = frm.Sku;
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void btnLimpiaArticulo_Click(object sender, EventArgs e)
        {
            K_Articulo = 0;
            txtArticulo.Text = "";
            Txt_Sku.Text = "";
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void Txt_Sku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Txt_Sku.Text).Trim().Length > 0)


                if ((e.KeyChar == (char)13) || (e.KeyChar == (char)11))
                {
                    Cursor = Cursors.WaitCursor;
                    FiltraDetalle();
                    Cursor = Cursors.Default;
                    Txt_Sku.Text = "";

                }
        }

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.TextChanged += new EventHandler(grdDetalle_TextChanged);
        }
        private void grdDetalle_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(textBox.Text.Trim().Length > 0)
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

        private void txtLote_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void cbxMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void Txt_Sku_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FiltraDetalle();
            Cursor = Cursors.Default;
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab))
            {
                 Cursor = Cursors.WaitCursor;
                 FiltraDetalle();
                 Cursor = Cursors.Default;
                 txtArticulo.Text = string.Empty;
               
            }
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cursor = Cursors.WaitCursor;
                FiltraDetalle();
                Cursor = Cursors.Default;
                txtArticulo.Text = string.Empty;

            }
      
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            //Int32 valor = 0;
            //if (txtArticulo.Text.Trim().Length > 0)
            //{
            //    if (!Int32.TryParse(txtArticulo.Text.Trim(), out valor))
            //    {
            //        MessageBox.Show("VALOR INVALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtArticulo.Text = string.Empty;
            //        txtArticulo.Focus();
            //    }
            //}
        }
    }
}
