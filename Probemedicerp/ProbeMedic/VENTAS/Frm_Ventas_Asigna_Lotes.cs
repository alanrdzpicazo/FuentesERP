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
    public partial class Frm_Ventas_Asigna_Lotes : FormaBase
    {
        public Int32 p_K_Almacen { get; set; }
        public Int32 p_K_Articulo { get; set; }
        public String p_D_Articulo { get; set; }
        public Decimal p_Cantidad_Inicial { get; set; }
        public DataTable p_dtDatosActuales { get; set; }

        public bool B_Afectado;

        SQLVentas sqlVentas = new SQLVentas();
        DataTable dtLotes = new DataTable();
        public Frm_Ventas_Asigna_Lotes()
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
        }

        private void Frm_Ventas_Asigna_Lotes_Load(object sender, EventArgs e)
        {

        }

        public override void BaseMetodoInicio()
        {
            Dgv_Inventario.AutoGenerateColumns = false;
            Dgv_Inventario.AutoGenerateColumns = false;

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

            LblArticulo.Text = p_D_Articulo.ToString().ToUpper();
            Mtd_Carga_Lotes();
        }

        public override void BaseBotonAfectarClick()
        {
            if (ValidaAsignacionLotes())
            {
                foreach (DataGridViewRow gridRow in Dgv_Inventario.Rows)
                {
                    if (Convert.ToInt32(gridRow.Cells["Cantidad_Asignada"].Value) > 0)
                    {
                        DataGridViewRow row = gridRow as DataGridViewRow;

                        IVentasFarmacia parent = this.Owner as IVentasFarmacia;
                        parent.AddDetalleLotes(row);

                    }
                }
                //Le indicamos que paso por el evento Afectar, para que al momento de cerrarlo ya no lo ejecute de nuevo
                B_Afectado = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Falta asignar Lotes al artículo...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
 
            }
        }

        void Mtd_Carga_Lotes()
        {
            dtLotes = null;
            dtLotes = sqlVentas.Gp_InventarioxArticulo(GlobalVar.K_Oficina,p_K_Almacen, p_K_Articulo);

            if (dtLotes != null)
            {
        
                dtLotes.Columns.Add(new DataColumn("Cantidad_Asignada", typeof(decimal)));

                foreach(DataRow row in dtLotes.Rows)
                {
                    if (p_dtDatosActuales != null)
                    {
                        var z = p_dtDatosActuales.AsEnumerable().Where(x => x.Field<int>("K_Movimiento_Inventario") == Convert.ToInt32(row["K_Movimiento_Inventario"])).AsDataView();

                        if (z.Count > 0)
                        {
                            row["Cantidad_Asignada"] = Convert.ToDecimal(z[0][3].ToString());
                        }
                        BaseBotonAfectar.Enabled = true;
                    }
                    else
                    {
                     

                        BaseBotonAfectar.Enabled = false;
                    }

                    if (row["Cantidad_Asignada"] == DBNull.Value)
                    {
                        row["Cantidad_Asignada"] = 0;
                    }
                }
                Dgv_Inventario.DataSource = dtLotes;
                Dgv_Inventario.EditMode = DataGridViewEditMode.EditOnEnter;
                Dgv_Inventario.MultiSelect = false;
                if (Dgv_Inventario.Rows.Count > 0)
                {
                    Dgv_Inventario.Rows[0].Cells["Cantidad_Asignada"].Selected = true;
                
                    Dgv_Inventario.Focus();
                }

          
            }
            else
            {
                BaseBotonCancelar.Visible = false;
                BaseBotonCancelar.Enabled = false;
                MessageBox.Show("No Existe Inventario Disponible del Artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dgv_Inventario_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = Dgv_Inventario.CurrentRow;

            if (Dgv_Inventario == null)
                return;
            if (Dgv_Inventario.CurrentRow == null)
                return;
            //if (p_dtDatosActuales == null)
            //    return;
       
            if (e.ColumnIndex == 5) //cantidad asignada
                {
                    if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                    {
                        Dgv_Inventario.CancelEdit();
                        return;
                    }

                    if (!EsNumero(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                    {
                        Dgv_Inventario.CancelEdit();
                        return;
                    }
                    if (row != null)
                    {
                        if (Convert.ToDecimal(row.Cells["Cantidad_Disponible"].Value) < Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()))
                        {
                            MessageBox.Show("LA CANTIDAD ASIGNADA NO PUEDE SER MAYOR A LA CANTIDAD DISPONIBLE, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Dgv_Inventario.CancelEdit();
                            return;
                        }

                        decimal dCantidadDetalle = p_Cantidad_Inicial;
                        decimal dCantidadAsiganda = Convert.ToDecimal(((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString());
                     
                        foreach (DataGridViewRow grow in Dgv_Inventario.Rows)
                        {
                            if (grow.Index != e.RowIndex)
                            {
                                dCantidadAsiganda = dCantidadAsiganda + Convert.ToDecimal(grow.Cells["Cantidad_Asignada"].Value);
                            }
                        }

                        if (dCantidadDetalle < dCantidadAsiganda)
                        {
                            MessageBox.Show("LA CANTIDAD ASIGNADA NO PUEDE SER MAYOR A LA CANTIDAD QUE EL CLIENTE SOLICITA, VERIFIQUE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Dgv_Inventario.CancelEdit();
                            return;
                        }
                       
                       
                    }
                }
            
        }

        private void Dgv_Inventario_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            decimal dCantidadVenta = 0;
            decimal dCantidadAsignada = 0;
            if (dtLotes == null)
            {
                return;
            }
          
            foreach (DataGridViewRow grdRow in Dgv_Inventario.Rows)
            {
                dCantidadVenta = p_Cantidad_Inicial;
                dCantidadAsignada += Convert.ToDecimal(grdRow.Cells["Cantidad_Asignada"].Value);
            
  
                if (dCantidadVenta== dCantidadAsignada)
                {      
                    BaseBotonAfectar.Enabled = true;
                }
                else
                {            
                    BaseBotonAfectar.Enabled = false;
                }
            
            }
          
           
        }

        private void Frm_Ventas_Asigna_Lotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (B_Afectado == false)
            {
                if (ValidaAsignacionLotes())
                {
                    foreach (DataGridViewRow gridRow in Dgv_Inventario.Rows)
                    {
                        if (Convert.ToInt32(gridRow.Cells["Cantidad_Asignada"].Value) > 0)
                        {
                            DataGridViewRow row = gridRow as DataGridViewRow;

                            IVentasFarmacia parent = this.Owner as IVentasFarmacia;
                            parent.AddDetalleLotes(row);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Faltan asignar Lotes...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private bool ValidaAsignacionLotes()
        {
           int sumatoria = 0;
           foreach(DataGridViewRow row in Dgv_Inventario.Rows)
           {
                sumatoria += Convert.ToInt32(row.Cells[5].Value.ToString()); 
           }
           if(sumatoria < p_Cantidad_Inicial)
           {
                return false;
           }
           else
           {
                return true;
           }
        }

        private void Dgv_Inventario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(OnlyNumbers_KeyPress);
            e.Control.TextChanged += new EventHandler(Dgv_Inventario_TextChanged);
        }
        private void Dgv_Inventario_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Trim().Length > 0)
            {
                try
                {
                    if(Convert.ToDecimal(textBox.Text.Trim())>1000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
                catch (Exception ex){ }
                           
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
    }
}
          


     