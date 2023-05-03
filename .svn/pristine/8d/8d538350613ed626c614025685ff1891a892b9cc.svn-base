using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_SeguimientoFacturas : FormaBase
    {
        DataTable DtFacturasCliente = new DataTable();
        Funciones fx = new Funciones();

        SQLAdministracion SQLADMINISTRACION = new SQLAdministracion();
        SQLCatalogos SQLCATALOGOS = new SQLCatalogos();

        DataTable DtClientes = new DataTable();
        public Int32 K_ClienteInt { get; set; }
        public string D_ClienteString { get; set; }
        public string P_Archivo { get; set; }

        int res = 0;
        string msg = string.Empty;

        public Frm_SeguimientoFacturas()
        {

            InitializeComponent();


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

            TxtOficina.Text = GlobalVar.D_Oficina;
            dtpProximoContacto.Value = DateTime.Now.AddDays(7);
            WindowState = FormWindowState.Maximized;
            grdClientes.AutoGenerateColumns = false;
            grdDocumentos.AutoGenerateColumns = false;
            grdSeguimiento.AutoGenerateColumns = false;
            grdDetalle.AutoGenerateColumns = false;
            grdPagos.AutoGenerateColumns = false;
            Cursor = Cursors.WaitCursor;
            DtClientes = SQLADMINISTRACION.Sk_Clientes_Muestra(GlobalVar.K_Empresa);
            Cursor = Cursors.Default;
            grdClientes.DataSource = DtClientes;


            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso1.Text = "Guardar";
            BaseBotonProceso1.ToolTipText = "Guardar Seguimiento";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso2.Text = "Cancelar";
            BaseBotonProceso2.ToolTipText = "Cancelar Captura";
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["sendbymail_enviar_1541.ico"]));
            BaseBotonProceso3.Text = "Enviar Correos";
            BaseBotonProceso3.ToolTipText = "Enviar Correos";
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;
            BaseBotonProceso3.Width = 100;

            TxtEncontrar.Focus();
        }

        //GUARDAR
        public override void BaseBotonProceso1Click()
        {
            if (!BaseFuncionValidaciones())
                return;
            DialogResult dlg = MessageBox.Show("SE DARA SEGUIMIENTO A LA FACTURA NUM: " +"["+ this.grdDocumentos.CurrentRow.Cells["K_Factura"].Value.ToString() +"]"+"\n" +
                                               "DEL CLIENTE: "+"["+ this.grdClientes.CurrentRow.Cells["K_Cliente"].Value.ToString()+"] " + this.grdClientes.CurrentRow.Cells["D_Cliente"].Value.ToString() +"."+ " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = 0;
                msg = string.Empty;
                Int32 CampoIdentity = 0;

                Int32 K_Cliente = Convert.ToInt32(this.grdClientes.CurrentRow.Cells["K_Cliente"].Value);
                Int32 K_Factura = Convert.ToInt32(this.grdDocumentos.CurrentRow.Cells["K_Factura"].Value);

                res = SQLADMINISTRACION.In_Seguimiento_Facturas(ref CampoIdentity, GlobalVar.K_Usuario, K_Cliente, K_Factura,
                    TxtResultado.Text.Trim(), DateTime.Now, dtpProximoContacto.Value, GlobalVar.PC_Name, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoLimpiaControles();
                    BaseMetodoInicio();
                }
            }
          

            base.BaseBotonProceso1Click();
        }
        public override void BaseMetodoLimpiaControles()
        {
            this.TxtOficina.Text = string.Empty;
            K_ClienteInt = 0;
            D_ClienteString = string.Empty;
            this.TxtClaveCliente.Text = string.Empty;
            this.TxtCliente.Text = string.Empty;
            this.TxtRFC.Text = string.Empty;
            this.TxtCanal.Text = string.Empty;
            this.TxtDias.Text = string.Empty;
            this.TxtLimite.Text = string.Empty;
            this.TxtContacto.Text = string.Empty;
            this.TxtLada.Text = string.Empty;
            this.TxtTel1.Text = string.Empty;
            this.TxtTel2.Text = string.Empty;
            this.TxtTel3.Text = string.Empty;
            this.TxtExt.Text = string.Empty;
            this.TxtResultado.Text = string.Empty;
            this.TxtTotal.Text = string.Empty;
            this.TxtVencido.Text = string.Empty;
            this.TxtNoVencido.Text = string.Empty;
            this.grdDetalle.DataSource = null;
            this.grdDocumentos.DataSource = null;
            this.grdPagos.DataSource = null;
            
            base.BaseMetodoLimpiaControles();
        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.grdClientes.CurrentRow.Cells["K_Cliente"].Value == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdClientes.Focus();
                return false;
            }
            if (this.grdDocumentos.CurrentRow.Cells["K_Factura"].Value == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FACTURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDocumentos.Focus();
                return false;
            }
            if (this.TxtResultado.Text.Trim().Length ==0)
            {
                MessageBox.Show("FALTA CAPTURAR UN RESULTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtResultado.Focus();
                return false;
            }
            if (dtpProximoContacto.Value <= DateTime.Now)
            {
                MessageBox.Show("SOLO PUEDE PROGRMAR UN PRÓXIMO CONTACTO CON FECHAS POSTERIORES \r\n" +
                "A LA FECHA ACTUAL, VERIFIQUE!..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }
        public override void BaseBotonProceso2Click()
        {
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
            base.BaseBotonProceso2Click();
        }

        public override void BaseBotonProceso3Click()
        {
            Frm_CorreosClientes frm = new Frm_CorreosClientes();
            frm.ShowDialog();
            base.BaseBotonProceso3Click();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Asunto = "Probemedic Distribuciones S.A, Administración / Cuentas por Cobrar. ";
            string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();
            string Cuerpo = fx.CuerpoCorreoHTML("Srita. Erika Patricia Rosales Rangel, usted presenta un saldo vencido por la cantidad de <strong> $15,800.00 MN </strong>. <br/> <p/>");

            string Recursos = "logo"; 
            string Archivos = Path.Combine(GlobalVar.rutaExe, "probemedic_login.png"); 

            //if (P_Archivo != null)
            //    P_Archivo = P_Archivo.ToString().Replace("Reporte", NombreReporteOC);
            string Adjuntos = "";// +"," + Archivos;
            string CorreosConCopia =  "alan_irpicazo@hotmail.com" +",airodriguez@altis.com.mx";

            if (fx.EnviaCorreo(CorreoDe, "a.rdzpzo@gmail.com", Asunto, "Probemedic Distribuciones S.A, Administración / Cuentas por Cobrar.", Cuerpo, Adjuntos, Archivos, Recursos, CorreosConCopia)) 
                Close();
        }
        private void BtnFiltroCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            K_ClienteInt = filtra.K_Cliente_Seleccionado;
            D_ClienteString = filtra.D_Cliente_Seleccionado;

        }
        private void TxtEncontrar_TextChanged(object sender, EventArgs e)
        {
            string Cadena = string.Empty;
            Int32 CadenaNumerica = 0;
            bool Numero = false;
            if (EsNumero(TxtEncontrar.Text.Trim()))
            {
                Numero = true;
                try { CadenaNumerica = Convert.ToInt32(TxtEncontrar.Text.Trim()); } catch (Exception) { CadenaNumerica = 0; }

            }
            else
            {
                Numero = false;
                Cadena = TxtEncontrar.Text.Trim();
            }
            if (TxtEncontrar.Text.Trim().Length > 0 && Numero == true)
            {
                DtClientes.DefaultView.RowFilter = $"K_Cliente ='{CadenaNumerica}' or D_Cliente LIKE '%{CadenaNumerica}%'";
            }
            else if (TxtEncontrar.Text.Trim().Length > 0 && Numero == false)
            {
                DtClientes.DefaultView.RowFilter = $"D_Cliente LIKE '%{Cadena}%'";
            }

            else
            {
               DtClientes.DefaultView.RowFilter = string.Empty;
            }         
        }
        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            DataTable DtContactosCliente = SQLCATALOGOS.Sk_Contactos_Cliente((Int32)this.grdClientes.CurrentRow.Cells["K_Cliente"].Value);
            
            if(DtContactosCliente!=null)
            {
                if (DtContactosCliente.Rows.Count == 1)
                {
                    TxtContacto.Text = DtContactosCliente.Rows[0]["D_Contacto_Cliente"].ToString();
                    TxtLada.Text = DtContactosCliente.Rows[0]["Lada"].ToString();
                    TxtTel1.Text = DtContactosCliente.Rows[0]["Telefono"].ToString();
                    TxtTel2.Text = DtContactosCliente.Rows[0]["Telefono2"].ToString() != "" ? DtContactosCliente.Rows[0]["Telefono2"].ToString() : "";
                    TxtTel3.Text = DtContactosCliente.Rows[0]["Telefono3"].ToString() != "" ? DtContactosCliente.Rows[0]["Telefono3"].ToString() : "";
                    TxtExt.Text = DtContactosCliente.Rows[0]["Ext"].ToString();
                }
                else if(DtContactosCliente.Rows.Count>1)
                {
                    Busquedas.BuscaClientesContactos frm = new Busquedas.BuscaClientesContactos();
                    frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(DtContactosCliente);
                    frm.BusquedaPropiedadTablaFiltra = DtContactosCliente;
                    frm.BusquedaPropiedadTitulo = "Busca Contactos Cliente";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        TxtContacto.Text = frm.BusquedaPropiedadReglonRes["D_Contacto_Cliente"].ToString();
                        TxtLada.Text = frm.BusquedaPropiedadReglonRes["Lada"].ToString();
                        TxtTel1.Text = frm.BusquedaPropiedadReglonRes["Telefono"].ToString();
                        TxtTel2.Text = frm.BusquedaPropiedadReglonRes["Telefono2"].ToString() != "" ? frm.BusquedaPropiedadReglonRes["Telefono2"].ToString() : "";
                        TxtTel3.Text = frm.BusquedaPropiedadReglonRes["Telefono3"].ToString() != "" ? frm.BusquedaPropiedadReglonRes["Telefono3"].ToString() : "";
                        TxtExt.Text = frm.BusquedaPropiedadReglonRes["Ext"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("EL CLIENTE NO CUENTA CON CONTACTOS ASIGNADOS!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("EL CLIENTE NO CUENTA CON CONTACTOS ASIGNADOS!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
        }
        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            if(grdClientes.CurrentRow != null)
            MtdCambiaCliente();
        }
        private void grdDocumentos_SelectionChanged(object sender, EventArgs e)
        {
            MtdCambiaDetalle();
            MtdCambiaSeguimiento();
            MtdCambiaPagos();
        }
        private void MtdCambiaCliente()
        {
            grdSeguimiento.DataSource = null;
            grdDocumentos.DataSource = null;
            grdDetalle.DataSource = null;

            int K_Cliente = (Int32)grdClientes.CurrentRow.Cells["K_Cliente"].Value;

            if(K_Cliente > 0)
            {
               DtFacturasCliente = SQLADMINISTRACION.Sk_Clientes_Credito(K_Cliente);

                if ((DtFacturasCliente != null))
                {
                    DataRow row = DtFacturasCliente.Rows[0];
                    this.TxtClaveCliente.Text = row["K_Cliente"].ToString();
                    this.TxtCliente.Text = row["D_Cliente"].ToString();
                    this.TxtRFC.Text = row["RFC"].ToString();
                    this.TxtCanal.Text = row["D_Canal_Distribucion_Cliente"].ToString();
                    this.TxtDias.Text = row["DiasCredito"].ToString();
                    this.TxtLimite.Text = row["LimiteCredito"].ToString();
                    this.TxtLimite.Text = TxtImporteToStr(ref TxtLimite);
                    this.TxtTotal.Text = row["Suma_Factura"].ToString();
                    this.TxtTotal.Text = TxtImporteToStr(ref TxtTotal);
                    this.TxtVencido.Text = Convert.ToString(row["Monto_Vencido"].ToString());
                    //this.TxtVencido.Text = TxtImporteToStr(ref TxtVencido);
                    this.TxtNoVencido.Text = row["Monto_NoVencido"].ToString();
                    this.TxtNoVencido.Text = TxtImporteToStr(ref TxtNoVencido);
                    this.TxtNeto.Text = row["Suma_Factura"].ToString();
                    this.TxtNeto.Text = TxtImporteToStr(ref TxtNeto);
                }
                this.grdDocumentos.DataSource = DtFacturasCliente;
            }
        }
        private void MtdCambiaDetalle()
        {
            int K_Factura = (Int32)grdDocumentos.CurrentRow.Cells["K_Factura"].Value;

            if (K_Factura > 0)
            {
                DataTable DtFacturasDetalle = SQLADMINISTRACION.Gp_Detalle_Factura(K_Factura);

                try
                {
                    if ((DtFacturasDetalle.Rows.Count > 0) || (DtFacturasDetalle != null))
                    {
                        this.grdDetalle.DataSource = DtFacturasDetalle;
                    }
                    else
                    {
                        MessageBox.Show("La Factura no cuenta con detalle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        grdDocumentos.Focus();
                        return;
                    }
                }
                catch (Exception) { }

              
            }
        }
        private void MtdCambiaSeguimiento()
        {
            int K_Factura = (Int32)this.grdDocumentos.CurrentRow.Cells["K_Factura"].Value;

            if (K_Factura > 0)
            {
                DataTable DtFacturasSeguimiento = SQLADMINISTRACION.Sk_Seguimiento_Facturas(K_Factura);

                if ((DtFacturasSeguimiento != null))
                {
                    this.grdSeguimiento.DataSource = DtFacturasSeguimiento;
                }
                //else
                //{
                //    MessageBox.Show("La Factura no cuenta con seguimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    grdDocumentos.Focus();
                //    return;
                //}

            }
        }

        private void MtdCambiaPagos()
        {
            int K_Factura = (Int32)this.grdDocumentos.CurrentRow.Cells["K_Factura"].Value;

            if (K_Factura > 0)
            {
                DataTable DtFacturasPagos = SQLADMINISTRACION.Sk_Pagos_CXC(K_Factura);

                if ((DtFacturasPagos!= null))
                {
                    this.grdPagos.DataSource = DtFacturasPagos;
                }
                //else
                //{
                //    MessageBox.Show("La Factura no cuenta con seguimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    grdDocumentos.Focus();
                //    return;
                //}

            }
        }

        private void txt_K_Factura_TextChanged(object sender, EventArgs e)
        {
            if(txt_K_Factura.Text.Trim().Length >0)
            DtFacturasCliente.DefaultView.RowFilter = $"K_Factura = "+txt_K_Factura.Text;
            else
            {
                DtFacturasCliente.DefaultView.RowFilter = "";
            }
        }

        private void dtpProximoContacto_ValueChanged(object sender, EventArgs e)
        {
            if (dtpProximoContacto.Value <= DateTime.Now)
            {
                MessageBox.Show("SOLO PUEDE PROGRMAR UN PRÓXIMO CONTACTO CON FECHAS POSTERIORES \r\n" +
                      "A LA FECHA ACTUAL, VERIFIQUE!..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpProximoContacto.Value = DateTime.Now.AddDays(1);
                return;
            }
                
        }

        private void TxtEncontrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)) || (Char.IsLetter(e.KeyChar)) || ( e.KeyChar ==Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
