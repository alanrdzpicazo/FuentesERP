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

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_DevolucionesCliente : FormaBase
    {
        SQLAdministracion sqlAdministracion= new SQLAdministracion();
        SQLVentas sqlVentas= new SQLVentas();

        DataTable dtDetalle = new DataTable();
        DataTable dtDatos = new DataTable();

        Int32 K_OficinaFactura { get; set; }
        Int32 K_AlmacenFactura { get; set; }

        bool PropiedadEsRegistroNuevo = false;

        int res = 0;
        string msg = string.Empty;

        public Frm_DevolucionesCliente()
        {
            InitializeComponent();
            

        }

        private void Frm_DevolucionesCliente_Load(object sender, EventArgs e)
        {   
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            pnlGeneral.Enabled = false;
            PropiedadEsRegistroNuevo = false;

            dtDatos = Detalle_Articulos_Devolucion_Table;
            grdDatos.AutoGenerateColumns = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnNuevo.Image.png"]));
            BaseBotonProceso1.Text = "Nuevo";
            BaseBotonProceso1.ToolTipText = "Nuevo";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnAfectar.Image.png"]));
            BaseBotonProceso2.Text = "Aceptar";
            BaseBotonProceso2.ToolTipText = "Aceptar";
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = false;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso3.Text = "Cancelar";
            BaseBotonProceso3.ToolTipText = "Cancelar Captura";
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = false;

            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true; 
            
        }

        //NUEVO
        public override void BaseBotonProceso1Click()
        {
            BaseBotonBuscar.Enabled = false;

            BaseMetodoLimpiaControles();
            PropiedadEsRegistroNuevo = true;
            pnlGeneral.Enabled = true;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso4.Enabled = false;

            lbl_SubTotal.Text = "0.00";
            lbl_SubTotal.Text = LblImporteToStr(ref lbl_SubTotal);

            lbl_IVA.Text = "0.00";
            lbl_IVA.Text = LblImporteToStr(ref lbl_IVA);

            lbl_Total.Text = "0.00";
            lbl_Total.Text = LblImporteToStr(ref lbl_Total);

            txt_K_Factura.Focus();
        }

        //ACEPTAR
        public override void BaseBotonProceso2Click()
        {
            if (!BaseFuncionValidaciones())
                return;

            Int32 CampoIdentity = 0;
            string msg = string.Empty;

            DataTable dtDetalleDevolucion = obtenerDetalleDevolucion();
       
            int K_Estatus_Devolucion = 1; //GENERADA
            res = 0;
            res = sqlAdministracion.In_Devoluciones_Cliente(ref CampoIdentity, Convert.ToInt32(txtClaveCliente.Text),
                    Convert.ToInt32(txt_K_Factura.Text), K_Estatus_Devolucion, K_OficinaFactura, K_AlmacenFactura,
                    DateTime.Now, Convert.ToDecimal(lbl_SubTotal.Text.Replace("$","")), Convert.ToDecimal(lbl_IVA.Text.Replace("$","")),
                    Convert.ToDecimal(lbl_Total.Text.Replace("$","")), GlobalVar.PC_Name, GlobalVar.K_Usuario, txt_Observaciones.Text,
                    Convert.ToInt32(txtClaveCuentaOrigen.Text), GlobalVar.K_Usuario, dtDetalleDevolucion, ref msg);
            
          
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = true;
                MessageBox.Show("SE GENERÓ LA DEVOLUCIÓN CORRECTAMENTE. ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoLimpiaControles();
                BaseMetodoInicio();
            }
        }

        //CANCELAR
        public override void BaseBotonProceso3Click()
        {
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
        }

        public override void BaseBotonBuscarClick()
        {
            BaseBotonProceso4.Enabled = true;

            DataTable dtDevoluciones = new DataTable();
            dtDevoluciones = sqlAdministracion.Sk_Devoluciones_Cliente();

            Busquedas.BuscaDevolucionesCliente frm = new Busquedas.BuscaDevolucionesCliente();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtDevoluciones);
            frm.BusquedaPropiedadTablaFiltra = dtDevoluciones;
            frm.BusquedaPropiedadTitulo = "Busca Devoluciones Cliente";
            frm.ShowDialog();          
        }

        public override void BaseMetodoLimpiaControles()
        {
            txt_K_Factura.Text = string.Empty;
            txtClaveCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtClaveCuentaOrigen.Text = string.Empty;
            txtCuentaOrigen.Text = string.Empty;
            txtCuentaCompletaCliente.Text = string.Empty;
            lbl_SubTotal.Text = string.Empty;
            lbl_IVA.Text = string.Empty;
            lbl_Total.Text = string.Empty;
            txt_Observaciones.Text = string.Empty;
            K_OficinaFactura = 0;
            K_AlmacenFactura = 0;

            dtDetalle = null;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txt_K_Factura.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL FOLIO DE LA FACTURA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_K_Factura.Focus();
                return false;
            }          
            BaseErrorResultado = false;
            return true;
        }

        private void btnBuscaCuentaOrigen_Click(object sender, EventArgs e)
        {      
            DataTable dtCuentasCliente = sqlCatalogos.Sk_Cliente_Cuentas(Convert.ToInt32(txtClaveCliente.Text.Trim()));
        
            if(dtCuentasCliente!=null)
            {
                if(dtCuentasCliente.Rows.Count==1)
                {
                    txtClaveCuentaOrigen.Text = dtCuentasCliente.Rows[0]["K_Cuenta_Cliente"].ToString();
                    txtCuentaOrigen.Text = dtCuentasCliente.Rows[0]["Numero_Cuenta"].ToString();
                    txtCuentaCompletaCliente.Text = dtCuentasCliente.Rows[0]["CuentaCompleta"].ToString();
                }
                else if(dtCuentasCliente.Rows.Count>1)
                {
                    Busquedas.BuscaClientesCuentas frm = new Busquedas.BuscaClientesCuentas();
                    frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentasCliente);
                    frm.BusquedaPropiedadTablaFiltra = dtCuentasCliente;
                    frm.BusquedaPropiedadTitulo = "Busca Cuentas de Clientes";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        txtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Cliente"].ToString();
                        txtCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["Numero_Cuenta"].ToString();
                        txtCuentaCompletaCliente.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("EL CLIENTE NO TIENE CUENTAS ASIGNADAS!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("EL CLIENTE NO TIENE CUENTAS ASIGNADAS!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
       
        }

        private void txt_K_Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar.ToString()))||(e.KeyChar==Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_K_Factura_Leave(object sender, EventArgs e)
        {
            if (txt_K_Factura.Text.Trim().Length > 0)
            {
                if (buscaDetalleFactura(Convert.ToInt32(txt_K_Factura.Text)))
                {
                    buscaEncabezado(Convert.ToInt32(txt_K_Factura.Text));
                }
            }
        }

        private void buscaEncabezado(Int32 K_Factura)
        {
            DataTable dtFacturas = sqlAdministracion.Sk_Factura(Convert.ToInt32(txt_K_Factura.Text));

            if(dtFacturas!=null)
            {
                if(dtFacturas.Rows.Count>0)
                {
                    DataRow row = dtFacturas.Rows[0];
                    txtClaveCliente.Text = row["K_Cliente"].ToString();
                    txtCliente.Text = row["D_Cliente"].ToString();
                }
            }
        }

        private bool buscaDetalleFactura(Int32 K_Factura)
        {
            dtDetalle = sqlAdministracion.Gp_Detalle_Factura(K_Factura);
            if(dtDetalle != null)
            {
                if(dtDetalle.Rows.Count>0)
                {
                    dtDetalle.Columns.Add("Seleccionar", (typeof(bool)));
                    dtDetalle.AcceptChanges();
                    grdDatos.DataSource = dtDetalle;
                    if (grdDatos.ReadOnly)
                    {
                        grdDatos.ReadOnly = false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show(string.Format("LA FACTURA {0} NO CUENTA CON DETALLE DE ARTÍCULOS. ",txt_K_Factura.Text.ToString()), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(string.Format("LA FACTURA {0} NO CUENTA CON DETALLE DE ARTÍCULOS. ", txt_K_Factura.Text.ToString()), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void calculaTotales()
        {
            //Calculamos el IVA de todos los artículos
            var x = dtDetalle.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("IVA"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    lbl_IVA.Text = Math.Round(x, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el SUBTOTAL de todos los artículos
            var z = dtDetalle.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("SubTotal"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    lbl_SubTotal.Text = Math.Round(z, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el TOTAL del pedido
            decimal totalPedido = x + z;
            lbl_Total.Text = Math.Round(totalPedido, 2).ToString("N2");

        }

        private DataTable obtenerDetalleDevolucion()
        {
            DataTable dtPaso = Detalle_Articulos_Devolucion_Table;
            foreach(DataGridViewRow row in grdDatos.Rows)
            {
                DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdDatos.Rows[row.Index].Cells[0];
                if (Convert.ToBoolean(chkCelda.Value) == true)
                {
                    DataRow dr = dtPaso.NewRow();
                    Int32 K_Articulo = Convert.ToInt32(row.Cells["K_Articulo"].Value);
                    decimal Precio_Unitario= Convert.ToDecimal(row.Cells["Precio_Unitario"].Value);
                    Int32 Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                    decimal Porcentaje_Iva = Convert.ToDecimal(row.Cells["Porcentaje_Iva"].Value);
                    decimal IVA= Convert.ToDecimal(row.Cells["IVA"].Value);
                    decimal Monto_Total = Convert.ToDecimal(row.Cells["Total_Detalle"].Value);
                    dtPaso.Rows.Add(dr);
                    dtPaso.AcceptChanges();
                }
            }
            return dtPaso;

        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {           
                if (e.ColumnIndex == this.grdDatos.Columns[0].Index)
                {
                    grdDatos.ReadOnly = false;
                    grdDatos.Rows[e.RowIndex].Cells["Seleccionar"].ReadOnly = false;
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdDatos.Rows[e.RowIndex].Cells[0];
                    if (Convert.ToBoolean(chkCelda.Value))
                    {
                        decimal SubTotal = Convert.ToDecimal(LblImporteToDec(ref lbl_SubTotal));
                        decimal IVA = Convert.ToDecimal(LblImporteToDec(ref lbl_IVA));
                        decimal Total_Detalle = Convert.ToDecimal(LblImporteToDec(ref lbl_Total));
                        SubTotal = SubTotal + Convert.ToDecimal(grdDatos.CurrentRow.Cells["SubTotal"].Value);
                        IVA = IVA + Convert.ToDecimal(grdDatos.CurrentRow.Cells["IVA"].Value);
                        Total_Detalle = Total_Detalle + Convert.ToDecimal(grdDatos.CurrentRow.Cells["Total_Detalle"].Value);

                        lbl_SubTotal.Text = SubTotal.ToString("C2");
                        lbl_IVA.Text = IVA.ToString("C2");
                        lbl_Total.Text = Total_Detalle.ToString("C2");

                    }
                    else if (!Convert.ToBoolean(chkCelda.Value))
                    {
                        decimal SubTotal = Convert.ToDecimal(LblImporteToDec(ref lbl_SubTotal));
                        decimal IVA = Convert.ToDecimal(LblImporteToDec(ref lbl_IVA));
                        decimal Total_Detalle = Convert.ToDecimal(LblImporteToDec(ref lbl_Total));
                        SubTotal = SubTotal - Convert.ToDecimal(grdDatos.CurrentRow.Cells["SubTotal"].Value);
                        IVA = IVA - Convert.ToDecimal(grdDatos.CurrentRow.Cells["IVA"].Value);
                        Total_Detalle = Total_Detalle - Convert.ToDecimal(grdDatos.CurrentRow.Cells["Total_Detalle"].Value);

                        lbl_SubTotal.Text = SubTotal.ToString("C2");
                        lbl_IVA.Text = IVA.ToString("C2");
                        lbl_Total.Text = Total_Detalle.ToString("C2");
                    }
                }
                    
            }
           
        }

        private void grdDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.ColumnIndex == this.grdDatos.Columns[0].Index)
                {
                    grdDatos.ReadOnly = false;
                    grdDatos.Rows[e.RowIndex].Cells["Seleccionar"].ReadOnly = false;
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.grdDatos.Rows[e.RowIndex].Cells[0];
                    if (Convert.ToBoolean(chkCelda.Value))
                    {
                        decimal SubTotal = Convert.ToDecimal(LblImporteToDec(ref lbl_SubTotal));
                        decimal IVA = Convert.ToDecimal(LblImporteToDec(ref lbl_IVA));
                        decimal Total_Detalle = Convert.ToDecimal(LblImporteToDec(ref lbl_Total));
                        SubTotal = SubTotal + Convert.ToDecimal(grdDatos.CurrentRow.Cells["SubTotal"].Value);
                        IVA = IVA + Convert.ToDecimal(grdDatos.CurrentRow.Cells["IVA"].Value);
                        Total_Detalle = Total_Detalle + Convert.ToDecimal(grdDatos.CurrentRow.Cells["Total_Detalle"].Value);

                        lbl_SubTotal.Text = SubTotal.ToString("C2");
                        lbl_IVA.Text = IVA.ToString("C2");
                        lbl_Total.Text = Total_Detalle.ToString("C2");

                    }
                    else if (!Convert.ToBoolean(chkCelda.Value))
                    {
                        decimal SubTotal = Convert.ToDecimal(LblImporteToDec(ref lbl_SubTotal));
                        decimal IVA = Convert.ToDecimal(LblImporteToDec(ref lbl_IVA));
                        decimal Total_Detalle = Convert.ToDecimal(LblImporteToDec(ref lbl_Total));
                        SubTotal = SubTotal - Convert.ToDecimal(grdDatos.CurrentRow.Cells["SubTotal"].Value);
                        IVA = IVA - Convert.ToDecimal(grdDatos.CurrentRow.Cells["IVA"].Value);
                        Total_Detalle = Total_Detalle - Convert.ToDecimal(grdDatos.CurrentRow.Cells["Total_Detalle"].Value);

                        lbl_SubTotal.Text = SubTotal.ToString("C2");
                        lbl_IVA.Text = IVA.ToString("C2");
                        lbl_Total.Text = Total_Detalle.ToString("C2");
                    }
                }

            }

        }
        private void txt_K_Factura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_K_Factura.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(txt_K_Factura.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_K_Factura.Text = string.Empty;
                return;
            }
        }

        
    }
}
