﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using ProbeMedic.FILTROS;
namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_CLIENTES : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos CatalogoSQL = new SQLCatalogos();
        public FRM_CLIENTES()
        {
            InitializeComponent();          
        }
     
        private void FRM_CLIENTES_Load(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = CatalogoSQL.Sk_Clientes(GlobalVar.K_Empresa);
            CatalogoPropiedadCampoClave = "K_Cliente";
            CatalogoPropiedadCampoDescripcion = "D_Cliente";

            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["user_home_16958.ico"]));
            BaseBotonProceso1.Text = "Domicilios Fiscales";
            BaseBotonProceso1.Width = 120;

            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["Cuentas.png"]));
            BaseBotonProceso2.Text = "Cuentas";
            BaseBotonProceso2.Width = 80;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;
            BaseBotonProceso3.Image = ((System.Drawing.Image)(resources.GetObject("btnCorreo.Image")));
            BaseBotonProceso3.Text = "Contactos";
            BaseBotonProceso3.Width = 90;

            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void BaseBotonProceso1Click()
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_CLIENTES_DOMICILIOS_FISCALES frm = new FRM_CLIENTES_DOMICILIOS_FISCALES();
            frm.PropiedadK_Cliente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Cliente = txtDescripcion.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            //BaseMetodoInicio();
            BaseBotonCancelarClick();
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
        }
        public override void BaseBotonProceso2Click()
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_CUENTAS_CLIENTES frm = new FRM_CUENTAS_CLIENTES();
            frm.PropiedadK_Cliente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Cliente = txtDescripcion.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            //BaseMetodoInicio();
            BaseBotonCancelarClick();
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
        }
        public override void BaseBotonProceso3Click()
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_CLIENTES_CONTACTOS frm = new FRM_CLIENTES_CONTACTOS();
            frm.PropiedadK_Cliente = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Cliente = txtDescripcion.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            //BaseMetodoInicio();
            BaseBotonCancelarClick();
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCorto.Text = string.Empty;
            txtComercial.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtCURP.Text = string.Empty;
            txtDiasCredito.Text = string.Empty;
            txtLimiteCredito.Contenido.Text = "0.00";
            txtURL.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            ucCanalDistribucionCliente1.K_Canal_Distribucion = 0;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = String.Empty;
            ucTipoFiscal1.K_Tipo_Fiscal = 0;
            ucTipoFiscal1.txt_TF_D_Tipo_Fiscal.Text = String.Empty;
            usEstatusCliente1 .K_Estatus_Cliente = 0;
            usEstatusCliente1.D_Estatus.Text = String.Empty;
            Cbx_B_Cliente_Tarjeta.Checked = false;
            ucEmpresas1.K_Empresa = 0;
            ucEmpresas1.txt_G_Empresa.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Cliente"].ToString();
            txtDescripcion.Text = ren["D_Cliente"].ToString();
            txtCorto.Text = ren["C_Cliente"].ToString();
            txtComercial.Text = ren["D_Comercial"].ToString();
            txtRFC.Text = ren["RFC"].ToString();
            txtCURP.Text = ren["CURP"].ToString();
            txtDiasCredito.Text = ren["DiasCredito"].ToString();
            decimal LimiteCredito =Convert.ToDecimal(ren["LimiteCredito"].ToString());
            txtLimiteCredito.Contenido.Text = LimiteCredito.ToString("C2").Replace("$","");
            txtURL.Text = ren["URL"].ToString();
            txtCorreo.Text = ren["Correo"].ToString();
            ucCanalDistribucionCliente1.K_Canal_Distribucion = ren["K_Canal_Distribucion_Cliente"].ToString() != "" ? Convert.ToInt32(ren["K_Canal_Distribucion_Cliente"].ToString()) : 0;
            ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = ren["D_Canal_Distribucion_Cliente"].ToString() != "" ? ren["D_Canal_Distribucion_Cliente"].ToString() : string.Empty;
            ucTipoFiscal1.K_Tipo_Fiscal = ren["K_Tipo_Fiscal"].ToString() != "" ? Convert.ToInt32(ren["K_Tipo_Fiscal"].ToString()) : 0;
            ucTipoFiscal1.txt_TF_D_Tipo_Fiscal.Text = ren["D_Tipo_Fiscal"].ToString() != "" ? ren["D_Tipo_Fiscal"].ToString() : string.Empty;
            usEstatusCliente1.K_Estatus_Cliente = ren["K_Estatus_Cliente"].ToString() != "" ? Convert.ToInt32(ren["K_Estatus_Cliente"].ToString()) : 0;
            usEstatusCliente1.D_Estatus.Text = ren["D_Estatus_Cliente"].ToString() != "" ? ren["D_Estatus_Cliente"].ToString() : string.Empty;
            Cbx_B_Cliente_Tarjeta.Checked =Convert.ToBoolean(ren["B_Cliente_Tarjeta"].ToString());
            ucEmpresas1.K_Empresa = ren["K_Empresa"].ToString() != "" ? Convert.ToInt32(ren["K_Empresa"].ToString()) : 0;
            ucEmpresas1.txt_G_Empresa.Text = ren["D_Empresa"].ToString() != "" ? ren["D_Empresa"].ToString() : string.Empty;
            ucAgente1.K_Asesor = ren["K_Asesor_1"].ToString() != "" ? Convert.ToInt32(ren["K_Asesor_1"].ToString()) : 0;
            ucAgente1.txt_Nombre.Text = ren["Asesor_1"].ToString() != "" ? ren["Asesor_1"].ToString() : string.Empty;
            ucAgente2.K_Asesor = ren["K_Asesor_2"].ToString() != "" ? Convert.ToInt32(ren["K_Asesor_2"].ToString()) : 0;
            ucAgente2.txt_Nombre.Text = ren["Asesor_2"].ToString() != "" ? ren["Asesor_2"].ToString() : string.Empty;
        }
        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = CatalogosSQL.Dl_Clientes(Convert.ToInt16(CatalogoPropiedadId_Identity), ref msg);
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
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;
            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0;
            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = CatalogosSQL.In_Clientes(ref CampoIdentity, txtDescripcion.Text, txtCorto.Text, txtComercial.Text, txtRFC.Text, txtCURP.Text, Convert.ToInt16(txtDiasCredito.Text),
                    Convert.ToDecimal(txtLimiteCredito.Contenido.Text.Replace("$", "").Replace(",", "")), txtURL.Text, txtCorreo.Text, GlobalVar.K_Usuario,ucCanalDistribucionCliente1.K_Canal_Distribucion, Cbx_B_Cliente_Tarjeta.Checked,
                    usEstatusCliente1.K_Estatus_Cliente, ucTipoFiscal1.K_Tipo_Fiscal,ucEmpresas1.K_Empresa ,ucAgente1.K_Asesor,ucAgente2.K_Asesor,ref  msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Clientes(CampoIdentity, txtDescripcion.Text, txtCorto.Text, txtComercial.Text, txtRFC.Text, txtCURP.Text, Convert.ToInt16(txtDiasCredito.Text),
                    Convert.ToDecimal(txtLimiteCredito.Contenido.Text.Replace("$", "").Replace(",","")), txtURL.Text, txtCorreo.Text, GlobalVar.K_Usuario,ucCanalDistribucionCliente1.K_Canal_Distribucion, Cbx_B_Cliente_Tarjeta.Checked,
                    usEstatusCliente1.K_Estatus_Cliente, ucTipoFiscal1.K_Tipo_Fiscal,ucEmpresas1.K_Empresa , ucAgente1.K_Asesor, ucAgente2.K_Asesor, ref msg);
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
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
                BaseBotonCancelarClick();
                CargaTablasParciales(3);
            }
        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtCorto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION CORTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorto.Focus();
                return false;
            }
            if (txtComercial.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION COMERCIAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComercial.Focus();
                return false;
            }
            if (txtRFC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA RFC...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return false;
            }
            if (txtCURP.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CURP...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCURP.Focus();
                return false;
            }
            if (txtDiasCredito.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DIAS DE CREDITO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiasCredito.Focus();
                return false;
            }
            if (txtLimiteCredito.Contenido.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LIMITE DE CREDITO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimiteCredito.Contenido.Focus();
                return false;
            }
            if (txtURL.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR URL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtURL.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtURL.Focus();
                return false;
            }
            if (ucCanalDistribucionCliente1.K_Canal_Distribucion == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CANAL DE DISTRIBUCIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCanalDistribucionCliente1.Focus();
                return false;
            }
            if (ucTipoFiscal1.K_Tipo_Fiscal == 0)
            {
                MessageBox.Show("FALTA EL TIPO FISCAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoFiscal1.Focus();
                return false;
            }
            if (usEstatusCliente1.K_Estatus_Cliente == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ESTATUS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usEstatusCliente1.Focus();
                return false;
            }
            if (ucEmpresas1.K_Empresa == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA EMPRESA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucEmpresas1.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }
        public override void BaseBotonBuscarClick()
        {
            Frm_Filtra_Cliente_Catalogo filtra = new Frm_Filtra_Cliente_Catalogo();
            filtra.ShowDialog();
            if (filtra.dtFiltra != null)
            {
                if (filtra.dtFiltra.Rows.Count > 0)
                {
                    BaseDtDatos = filtra.dtFiltra;
                    CatalogoPropiedadCampoClave = "K_Cliente";
                    CatalogoPropiedadCampoDescripcion = "D_Cliente";
                    base.BaseMetodoInicio();
                    BaseBotonBuscar.Visible = true;
                }
            }

        }
        private void txtDiasCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtDiasCredito_TextChanged(object sender, EventArgs e)
        {
            if (txtDiasCredito.Text.Trim().Length > 0)
                if (Convert.ToInt32(txtDiasCredito.Text.Trim()) > 365)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                        "EL VALOR MÁXIMO PERMITDO ES DE 365. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiasCredito.Text = string.Empty;
                }
        }

 
        public void BaseBotonAgregarClick()
        {
            usEstatusCliente1.K_Estatus_Cliente = 1;
            usEstatusCliente1.D_Estatus.Text = "ACTIVO";
        }

       
    }

}