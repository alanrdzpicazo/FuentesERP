using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.DCC;
using ProbeMedic.AppCode.BLL;
using System.Globalization;

namespace ProbeMedic.PRECIOS
{
    public partial class Frm_PreciosPublicos : FormaBase
    {
        SQLVentas sql = new SQLVentas();
        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLPrecios sqlPrecios = new SQLPrecios();

        DataTable dtPrecios = new DataTable();
        DataTable dtPesos = new DataTable();
        CultureInfo daDK = CultureInfo.CreateSpecificCulture("es-MX");

        bool B_Inserta = false;
        bool B_NoEntrar = false;

        int res = 0;
        string msg = string.Empty;

        public Frm_PreciosPublicos()
        {
            InitializeComponent();
            grdPrecios.AutoGenerateColumns = false;
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonCancelar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;

            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;

            BaseBotonProceso4.Visible = false;
            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso4.Text = "Aplicar";
            BaseBotonProceso4.Width = 60;

            //BaseBotonProceso5.Visible = true;
            //BaseBotonProceso5.Image = ((System.Drawing.Image)(imageList1.Images["business_rankhistoryreport_therange_negocio_2345.ico"]));
            //BaseBotonProceso5.Text = "Historial Precios";
            //BaseBotonProceso5.Width = 90;

            BaseBotonProceso6.Visible = true;
            BaseBotonProceso6.Image = ((System.Drawing.Image)(imageList1.Images["if_price_1814073.png"]));
            BaseBotonProceso6.Text = "Precios Actuales";
            BaseBotonProceso6.Width = 130;
        }

        public override void BaseBotonBuscarClick()
        {
            if ((txt_D_Articulo.Text.Trim().Length == 0) &&(txtSKU.Text.Trim().Length==0) && (ucFamiliaArticulo1.K_Familia_Articulo ==0) && (ucLaboratorio1.K_Laboratorio == 0) && (ucSustanciaActiva1.K_Sustancia_Activa ==0))
            {
                MessageBox.Show("DEBE ESPECIFICAR AL MENOS UN FILTRO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ObtienePesosyPrecios();
        }

        //APLICAR
        public override void BaseBotonProceso4Click()
        {
            if (BaseFuncionValidaciones())
            {
                AplicarPrecios();
            }
        }

        //CANCELAR
        public override void BaseBotonCancelarClick()
        {
            dtPesos = null;
            dtPrecios = null;

            if(grdPrecios.Rows.Count>0)
            {
                DataTable dt = (DataTable)grdPrecios.DataSource;
                dt.Clear();
            }
            txt_D_Articulo.Text = string.Empty;
            txtSKU.Text = string.Empty;
            ucFamiliaArticulo1.K_Familia_Articulo = 0;
            ucFamiliaArticulo1.txt_FA_D_Familia_Articulo.Text = string.Empty;
            ucLaboratorio1.K_Laboratorio = 0;
            ucLaboratorio1.txt_L_D_Laboratorio.Text = string.Empty;
            ucSustanciaActiva1.K_Sustancia_Activa = 0;
            ucSustanciaActiva1.txt_SA_D_Sustancia_Activa.Text = string.Empty;

            BaseMetodoInicio();
          
            base.BaseBotonCancelarClick();
        }

        //MODIFICAR
        public override void BaseBotonModificarClick()
        {
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = true;

            grdPrecios.EditMode = DataGridViewEditMode.EditOnEnter;
            grdPrecios.MultiSelect = false;

            grdPrecios.Rows[0].Cells["Precio"].Selected = true;
            grdPrecios.Focus();

            grdPrecios.ReadOnly = false;
            grdPrecios.Columns["K_Articulo"].ReadOnly = true;
            grdPrecios.Columns["D_Articulo"].ReadOnly = true;
            grdPrecios.Columns["SKU"].ReadOnly = true;
            grdPrecios.Columns["SKU"].ReadOnly = true;
        }

        //BORRAR
        public override void BaseBotonBorrarClick()
        {
            BorrarPrecios();
        }

        //Historial Precios
        public override void BaseBotonProceso5Click()
        {
            //FRM_REPORTE_PRECIOS_PUBLICOS frm = new FRM_REPORTE_PRECIOS_PUBLICOS();

            //DataTable dtPaso = sql.sk_histprecios_rango();

            //if (dtPaso != null)
            //{
            //    if (dtPaso.Rows.Count > 0)
            //    {
            //        frm.dtDatos = dtPaso;
            //        frm.Text = "REPORTE HISTORIAL DE PRECIOS DE LISTA";
            //        frm.B_Historico = true;
            //        frm.ShowDialog();
            //        dtPaso = null;
            //    }
            //    else
            //    {
            //        MessageBox.Show("NO SE ENCONTRÓ INFORMACIÓN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("NO SE ENCONTRÓ INFORMACIÓN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //base.BaseBotonProceso5Click();
        }

        //Precios Actuales
        public override void BaseBotonProceso6Click()
        {
            Cursor = Cursors.WaitCursor;
            PRECIOS.FRM_PRECIOS_ACTUALES_PUBLICOS frmrpa = new PRECIOS.FRM_PRECIOS_ACTUALES_PUBLICOS();
            frmrpa.ShowDialog();
            Cursor = Cursors.Default;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            int contador = 0;
            grdPrecios.EndEdit();
            foreach (DataGridViewRow row in grdPrecios.Rows)
            {
                decimal Importe = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
                if (Importe == 0)
                {
                    contador += 1;
                }
            }
            if (contador > 0)
            {
                MessageBox.Show("DEBE CAPTURAR TODO EL LISTADO DE PRECIOS, Y QUE ESTOS PRECIOS SEAN MAYOR A CERO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return false;
            }
            return true;
        }

        private bool blnCeldaImportes()
        {
            if (grdPrecios.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdPrecios.CurrentCell.ColumnIndex == 5);
        }

        private void grdPrecios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!grdPrecios.CurrentCell.IsInEditMode)
                {
                    //grdDetalle.CurrentCell.ed = true;
                    grdPrecios.BeginEdit(true);
                    return;
                }

                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
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

        private void grdPrecios_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void grdPrecios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grdPrecios_KeyPress);
        }

        #region FUNCIONES Y METODOS
        private void ObtienePesosyPrecios()
        {
            if ((txt_D_Articulo.Text.Trim().Length>0)|| (txtSKU.Text.Trim().Length>0)|| (ucFamiliaArticulo1.K_Familia_Articulo>0)||(ucLaboratorio1.K_Laboratorio>0) ||(ucSustanciaActiva1.K_Sustancia_Activa>0))
            {
                dtPrecios =  sqlPrecios.Sk_Precios_Articulos_Actual(ucFamiliaArticulo1.K_Familia_Articulo,ucLaboratorio1.K_Laboratorio,ucSustanciaActiva1.K_Sustancia_Activa,
                    txtSKU.Text.Trim(),txt_D_Articulo.Text.Trim());

                if (dtPrecios != null)
                {
                    if (dtPrecios.Rows.Count > 0)
                    {
                        foreach (DataColumn columna in dtPrecios.Columns)
                        {
                            if (columna.ColumnName == "Precio")
                            {
                                columna.ReadOnly = false;
                            }
                        }
                        dtPrecios.AcceptChanges();

                        grdPrecios.DataSource = dtPrecios;
                        grdPrecios.ReadOnly = true;
                        B_Inserta = false;

                        BaseBotonProceso4.Visible = false;
                        BaseBotonProceso4.Enabled = false;
                        BaseBotonBorrar.Visible = false;
                        BaseBotonBorrar.Enabled = false;
                        BaseBotonModificar.Visible = true;
                        BaseBotonModificar.Enabled = true;
                        BaseBotonCancelar.Visible = true;
                        BaseBotonCancelar.Enabled = true;
                    }
                }
                else
                {
                    dtPesos = sqlCatalogos.Sk_Articulos_Consulta(ucFamiliaArticulo1.K_Familia_Articulo, ucLaboratorio1.K_Laboratorio, ucSustanciaActiva1.K_Sustancia_Activa, txtSKU.Text, txt_D_Articulo.Text);

                    if (dtPesos != null)
                    {
                        if (dtPesos.Rows.Count > 0)
                        {
                            B_Inserta = true;
                            BaseBotonProceso4.Visible = true;
                            BaseBotonProceso4.Enabled = true;
                            BaseBotonBuscar.Enabled = false;
                            BaseBotonBuscar.Visible = false;
                            BaseBotonModificar.Visible = false;
                            BaseBotonModificar.Enabled = false;
                            BaseBotonBorrar.Visible = false;
                            BaseBotonBorrar.Enabled = false;
                            BaseBotonCancelar.Visible = true;
                            BaseBotonCancelar.Enabled = true;

                            dtPesos.Columns.Add("Precio", (typeof(decimal)));
                            dtPesos.AcceptChanges();
                            foreach (DataRow row in dtPesos.Rows)
                            {
                                row["Precio"] = 0.00;
                            }
                            dtPesos.AcceptChanges();

                            grdPrecios.DataSource = dtPesos;
                            grdPrecios.EditMode = DataGridViewEditMode.EditOnEnter;
                            grdPrecios.MultiSelect = false;

                            grdPrecios.Rows[0].Cells["Precio"].Selected = true;
                            grdPrecios.Focus();
                 

                            B_Inserta = true;
                            B_NoEntrar = true;
                        }

                    }
                }


            }
        }

        private void AplicarPrecios()
        {
            bool B_Aplicado;
            if (B_Inserta == true)
            {
                B_Aplicado = true;
                grdPrecios.EndEdit();
                foreach (DataGridViewRow row in grdPrecios.Rows)
                {
                    Int32 CampoIdentity = 0;
                    Int32 K_Articulo = Convert.ToInt32(row.Cells["K_Articulo"].Value.ToString());
                    decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
 
                    res = sqlPrecios.In_Precios_Articulos(ref CampoIdentity,
                       K_Articulo,
                       Precio,
                       DateTime.Now,
                       GlobalVar.K_Usuario,
                       ref msg);

                    if (res == -1)
                    {
                        B_Aplicado = false;
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                BaseBotonProceso4.Visible = false;
                BaseBotonProceso4.Enabled = false;
                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
                BaseBotonBorrar.Visible = true;
                BaseBotonBorrar.Enabled = true;

                grdPrecios.ReadOnly = true;

                B_Inserta = false;

                if (B_Aplicado == true)
                {
                    MessageBox.Show("EL LISTADO DE PRECIOS FUE APLICADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtienePesosyPrecios();
                }
            }

            else
            {
                B_Aplicado = true;
                grdPrecios.EndEdit();

                foreach (DataGridViewRow row in grdPrecios.Rows)
                {
                    res = 0;
                    msg = string.Empty;
                    Int32 CampoIdentity = Convert.ToInt32(row.Cells["K_Precio_Articulo_Actual"].Value.ToString());
                    Int32 K_Articulo = Convert.ToInt32(row.Cells["K_Articulo"].Value.ToString());
                    decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());

                    res = sqlPrecios.Up_Precios_Articulos(
                        CampoIdentity,
                        K_Articulo,
                        Precio,
                        DateTime.Now,
                        GlobalVar.K_Usuario,
                        ref msg);

                    if (res == -1)
                    {
                        B_Aplicado = false;
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                BaseBotonProceso4.Visible = false;
                BaseBotonProceso4.Enabled = false;
                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
                BaseBotonBorrar.Visible = true;
                BaseBotonBorrar.Enabled = true;

                grdPrecios.ReadOnly = true;

                B_Inserta = false;

                if (B_Aplicado == true)
                {
                    MessageBox.Show("EL LISTADO DE PRECIOS FUE ACTUALIZADO. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtienePesosyPrecios();
                }
            }

        }

        private void BorrarPrecios()
        {
            //if (sel_Tipo_Envio1.K_Tipo_Envio == 0)
            //{
            //    MessageBox.Show("DEBE ESPECIFICAR EL TIPO DE ENVIO. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    sel_Tipo_Envio1.Focus();
            //    return;
            //}
            //if (sel_Zona1.K_Zona == 0)
            //{
            //    MessageBox.Show("DEBE ESPECIFICAR LA ZONA. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    sel_Zona1.Focus();
            //    return;
            //}
            //if (dtp_Fecha.Value <= DateTime.Now)
            //{
            //    MessageBox.Show("LA FECHA DE VIGENCIA NO PUEDE SER MENOR A LA FECHA ACTUAL. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dtp_Fecha.Focus();
            //    return;
            //}
            //DialogResult dlg = MessageBox.Show("¿DESEA BORRAR TODO EL LISTADO DE PRECIOS?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dlg == DialogResult.Yes)
            //{
            //    res = 0;
            //    msg = string.Empty;
            //    res = sql.Dl_Precios_Rango((short)sel_Zona1.K_Zona, sel_Tipo_Envio1.K_Tipo_Envio, dtp_Fecha.Value, Global.K_Usuario, ref msg);

            //    if (res == -1)
            //    {
            //        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("EL LISTADO DE PRECIOS FUE BORRADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //    BaseMetodoInicio();

            //    dtPrecios = null;
            //    grdPrecios.DataSource = dtPrecios;

            //}
        }

        #endregion

        private void grdPrecios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = false;
        }

        private void grdPrecios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = true;
        }
    }
}
