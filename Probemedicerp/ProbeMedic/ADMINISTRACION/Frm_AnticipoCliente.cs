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
    public partial class Frm_AnticipoCliente : FormaBase
    {
        int res = 0;
        string msg = string.Empty;

        int K_Oficina = 0;
        int 
            k_Almacen = 0;

        bool PropiedadEsRegistroNuevo = false;

        SQLAdministracion SQLADMINISTRACION = new SQLAdministracion();
        SQLCatalogos SQLCATALOGOS = new SQLCatalogos();

        DataTable dtTiposMotivos = new DataTable();
        DataTable dtAnticipos = new DataTable();

        public Frm_AnticipoCliente()
        {
            InitializeComponent();
            TxtMonto.Contenido.TextChanged += new EventHandler(Txt_Monto_TextChanged);
        }
        private void Txt_Monto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtMonto.Contenido.Text.Trim().Length > 0)
                {
                    decimal Valor = decimal.Parse(TxtMonto.Contenido.Text.Trim().Replace(",","").Replace(".",""));
                }                        
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!... " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMonto.Contenido.Text = "0.00";
                return;
            }

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

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnNuevo.Image.png"]));
            BaseBotonProceso1.Text = "Nuevo";
            BaseBotonProceso1.ToolTipText = "Nuevo";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso2.Text = "Guardar";
            BaseBotonProceso2.ToolTipText = "Guardar Anticipo";
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Enabled = false;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso3.Text = "Cancelar";
            BaseBotonProceso3.ToolTipText = "Cancelar Captura";
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Enabled = false;

            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["btnBorrar.Image.png"]));
            BaseBotonProceso4.Text = "Borrar";
            BaseBotonProceso4.ToolTipText = "Borrar";
            BaseBotonProceso4.Visible = false;
            BaseBotonProceso4.Enabled = false;

            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;

            PnlSuperior.Enabled = false;
            PnlIntermedio.Enabled = false;
            PnlCuentas.Enabled = false;

            PropiedadEsRegistroNuevo = false;
            GrdDatos.AutoGenerateColumns = false;

            dtAnticipos = SQLADMINISTRACION.Sk_Anticipo_Clientes();

            GrdDatos.DataSource = dtAnticipos;

            base.BaseMetodoInicio();
        }
        //NUEVO
        public override void BaseBotonProceso1Click()
        {
            BaseBotonProceso1.Visible = false;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;
            BaseBotonProceso4.Visible = false;
            BaseBotonProceso4.Enabled = false;

            PnlSuperior.Enabled = true;
            PnlIntermedio.Enabled = true;
            PnlCuentas.Enabled = true;

            BtnBuscaCliente.Focus();
        }
        //GUARDAR
        public override void BaseBotonProceso2Click()
        {
            PropiedadEsRegistroNuevo = true;

            if (!BaseFuncionValidaciones())
                return;

            if (PropiedadEsRegistroNuevo) // Nuevo
            {
                res = 0;
                msg = string.Empty;
                Int32 CampoIdentity = 0;

                Int32 K_Oficina = 0;
                Int32 K_Cliente = 0;

                if (TxtClaveCliente.Text.Trim().Length > 0)
                {
                    K_Cliente = Convert.ToInt32(TxtClaveCliente.Text.Trim().ToString());
                }
                res = SQLADMINISTRACION.In_Anticipo_Cliente(ref CampoIdentity,GlobalVar.K_Oficina, 2, K_Cliente,
                    GlobalVar.K_Usuario, GlobalVar.K_Usuario, DateTime.Now,Convert.ToDecimal(TxtMonto.Contenido.Text.Replace(",",".").Replace(".","")), ucMotivosAnticipoCliente1.K_Motivo,
                    Convert.ToInt32(TxtClaveCuentaOrigen.Text),Convert.ToInt32(TxtClaveCuentaDeposito.Text),
                    TxtObservaciones.Text,ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("Anticipo Generado Correctamente con No. de Folio [" + CampoIdentity.ToString() + "]", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
            else //Existe. Update
            {

            }

            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
            base.BaseBotonProceso1Click();
        }

        //CANCELAR
        public override void BaseBotonProceso3Click()
        {
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Enabled = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Enabled = false;
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = true;
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
        }

        //BORRAR
        public override void BaseBotonProceso4Click()
        {
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso4.Enabled = false;
            PropiedadEsRegistroNuevo = false;
            //pnlEncabezado.Enabled = false;

            if (GrdDatos.CurrentRow != null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ANTICIPO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL ANTICIPO CON FOLIO:\n" + GrdDatos.CurrentRow.Cells["K_Anticipo"].Value.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = SQLADMINISTRACION.Dl_Anticipo_Clientes(Convert.ToInt16(GrdDatos.CurrentRow.Cells["K_Anticipo"].Value.ToString()), GlobalVar.K_Usuario, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }



        }

        public override void BaseMetodoLimpiaControles()
        {
            TxtClaveCliente.Text = string.Empty;
            TxtCliente.Text = string.Empty;
            ucMotivosAnticipoCliente1.K_Motivo = 0;
            ucMotivosAnticipoCliente1.txt_Motivo.Text = string.Empty;
            TxtMonto.Contenido.Text = "0.00";
            TxtClaveCuentaOrigen.Text = string.Empty;
            TxtCuentaOrigen.Text = string.Empty;
            TxtClaveCuentaDeposito.Text = string.Empty;
            TxtCuentaDeposito.Text = string.Empty;
            TxtObservaciones.Text = string.Empty;
            base.BaseMetodoLimpiaControles();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            if (filtra.K_Cliente_Seleccionado == 0)
            {
                TxtClaveCliente.Text = string.Empty;
                TxtCliente.Text = string.Empty;
            }
            else if (filtra.K_Cliente_Seleccionado != 0 && filtra.D_Cliente_Seleccionado != "")
            {
                TxtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
                TxtCliente.Text = filtra.D_Cliente_Seleccionado;
            }
        }

        private void btnBuscaCuentaOrigen_Click(object sender, EventArgs e)
        {
            if (TxtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL CLIENTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClaveCliente.Focus();
                return;
            }
            DataTable dtCuentasCliente = sqlCatalogos.Sk_Cliente_Cuentas(Convert.ToInt32(TxtClaveCliente.Text.Trim()));

            if(dtCuentasCliente!=null)
            {
                if (dtCuentasCliente.Rows.Count == 1)
                {
                    TxtClaveCuentaOrigen.Text = dtCuentasCliente.Rows[0]["K_Cuenta_Cliente"].ToString();
                    TxtCuentaOrigen.Text = dtCuentasCliente.Rows[0]["Numero_Cuenta"].ToString();                  
                }
                else if (dtCuentasCliente.Rows.Count > 1)
                {
                    Busquedas.BuscaClientesCuentas frm = new Busquedas.BuscaClientesCuentas();
                    frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentasCliente);
                    frm.BusquedaPropiedadTablaFiltra = dtCuentasCliente;
                    frm.BusquedaPropiedadTitulo = "Busca Cuentas de Clientes";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        TxtClaveCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Cliente"].ToString();
                        TxtCuentaOrigen.Text = frm.BusquedaPropiedadReglonRes["Numero_Cuenta"].ToString();                     
                    }
                }
                else
                {
                    MessageBox.Show("EL CLIENTE NO CUENTA CON CUENTAS ASIGNADAS!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("EL CLIENTE NO CUENTA CON CUENTAS ASIGNADAS!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnBuscaCuentaDeposito_Click(object sender, EventArgs e)
        {
            DataTable dtCuentas = sqlCatalogos.Sk_Empresa_Cuentas(GlobalVar.K_Empresa);

            if(dtCuentas!=null)
            { 
                if(dtCuentas.Rows.Count == 1)
                {
                    TxtClaveCuentaDeposito.Text = dtCuentas.Rows[0]["K_Cuenta_Empresa"].ToString();
                    TxtCuentaDeposito.Text = dtCuentas.Rows[0]["CuentaCompleta"].ToString();
                }
                else if(dtCuentas.Rows.Count>1)
                {
                    Busquedas.BuscaEmpresa_Cuentas frm = new Busquedas.BuscaEmpresa_Cuentas();
                    frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtCuentas);
                    frm.BusquedaPropiedadTablaFiltra = dtCuentas;
                    frm.BusquedaPropiedadTitulo = "Busca Cuentas de la Empresa";
                    frm.ShowDialog();
                    if (frm.BusquedaPropiedadReglonRes != null)
                    {
                        TxtClaveCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["K_Cuenta_Empresa"].ToString();
                        TxtCuentaDeposito.Text = frm.BusquedaPropiedadReglonRes["CuentaCompleta"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("LA EMPRESA NO TIENE CUENTAS ASIGNADAS!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("LA EMPRESA NO TIENE CUENTAS ASIGNADAS!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }
    }
}
