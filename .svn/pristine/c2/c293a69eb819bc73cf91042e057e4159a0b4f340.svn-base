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
using ProbeMedic.CATALOGOS.PROVEEDORES;

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_PROVEEDORES: FormaCatalogo
    {
        int res = 0;
        DateTime FechaInicial = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;
        Funciones fx = new Funciones();
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_PROVEEDORES()
        {
            InitializeComponent();
            BaseBotonProceso1.Click += new EventHandler(BaseBotonProceso1_Click);
            BaseBotonProceso3.Click += new EventHandler(BaseBotonProceso3_Click);
            BaseBotonProceso4.Click += new EventHandler(BaseBotonProceso4_Click);
            BaseBotonProceso5.Click += new EventHandler(BaseBotonProceso5_Click);

            this.geo_Colonia1.PropertyChanged += new PropertyChangedEventHandler(geo_Colonia1_PropertyChanged);

            BaseMetodoLimpiaControles();
        }

        private void geo_Colonia1_PropertyChanged(object sender, EventArgs e)
        {
            if (geo_Colonia1.K_Colonia > 0)
            {
                DataTable dtCodigoPostal = new DataTable();
                dtCodigoPostal = sqlCatalogos.Sk_Colonia_All(geo_Colonia1.K_Colonia);

                txtCodigoPostal.Text = dtCodigoPostal.Rows[0].ItemArray[9].ToString();
                
            }
            
        }
        void BaseBotonProceso1_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_CONTACTOS_PROVEEDOR frm = new FRM_CONTACTOS_PROVEEDOR();
            frm.PropiedadK_Proveedor = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Proveedor = txtNombre.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        void BaseBotonProceso3_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_PROVEEDORES_CUENTAS_BANCARIAS frm = new FRM_PROVEEDORES_CUENTAS_BANCARIAS();
            frm.PropiedadK_Proveedor = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Proveedor = txtNombre.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        void BaseBotonProceso4_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_DOC_PROVEEDOR frm = new FRM_DOC_PROVEEDOR();
            frm.PropiedadK_Proveedor = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Proveedor = txtNombre.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        void BaseBotonProceso5_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;

            FRM_SUCURSALES_PROVEEDOR frm = new FRM_SUCURSALES_PROVEEDOR();
            frm.PropiedadK_Proveedor = Convert.ToInt32(CatalogoPropiedadId_Identity);
            frm.PropiedadD_Proveedor = txtNombre.Text;
            frm.ShowDialog();

            //Para que se vuelva a llenar la var identity porque en los contactos se habia modificado
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso3.Visible= true;
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso5.Visible = true;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso1.Image = ((System.Drawing.Image)(resources.GetObject("btnCorreo.Image")));
            BaseBotonProceso1.ToolTipText = "Contactos del Proveedor";
            BaseBotonProceso1.Text = "Contactos";
            BaseBotonProceso1.Width = 75;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["Banking_00006_A_icon-icons.com_59820.ico"]));
            BaseBotonProceso3.ToolTipText = "Bancos del Proveedor";
            BaseBotonProceso3.Text = "Bancos";
            BaseBotonProceso3.Width = 65;
 
            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["document_write_22637.ico"]));
            BaseBotonProceso4.ToolTipText = "Documentos del Proveedor";
            BaseBotonProceso4.Text = "Documentos";
            BaseBotonProceso4.Width = 75; 

            BaseBotonProceso5.Image = ((System.Drawing.Image)(imageList1.Images["1497618988-16_85112.ico"]));
            BaseBotonProceso5.ToolTipText = "Sucursales del Proveedor";
            BaseBotonProceso5.Text = "Sucursales";
            BaseBotonProceso5.Width = 75;

            txtFocus =txtNombre; //Asignar el textbox que inicia el focus
            //pnlControles.Enabled = false; //NO Borrar
            DeshabilitaPages(ref tcControles, false);
            //cbxActiva.Enabled = false;

            //Si la empresa es SOS, muestro unicamente los proveedores asignados.
            if(GlobalVar.K_Empresa==10)
            {
                BaseDtDatos = sqlCatalogos.Sk_Proveedores(true);
            }
            else
            {
                BaseDtDatos = sqlCatalogos.Sk_Proveedores(false);
            }
            CatalogoPropiedadCampoClave = "K_Proveedor";
            CatalogoPropiedadCampoDescripcion = "D_Proveedor";

            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            //pnlControles.Enabled = B_Habilita;
            DeshabilitaPages(ref tcControles, B_Habilita);
           // cbxActiva.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {       
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombreCorto.Text = string.Empty;
            txtRFC.Text = string.Empty;
            cbxCredito.Checked = false;
            ucTipoFiscal1.txt_TF_D_Tipo_Fiscal.Text = string.Empty;
            txtDiasCredito.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            dtpAlta.Value = DateTime.Now;
            dtpBaja.Value = DateTime.Now;
            cbxAutorizado.Checked = false;
            cbxDevoluciones.Checked = false;
            geo_Colonia1.txt_G_Pais.Text = string.Empty;
            geo_Colonia1.txt_G_Estado.Text = string.Empty;
            geo_Colonia1.txt_G_Ciudad.Text = string.Empty;
            geo_Colonia1.txt_G_Colonia.Text = string.Empty;
            ucTipoFiscal1.K_Tipo_Fiscal = 0;
            geo_Colonia1.K_Pais = 0;
            geo_Colonia1.K_Estado = 0;
            geo_Colonia1.K_Ciudad = 0;
            geo_Colonia1.K_Colonia = 0;
            DeshabilitaPages(ref tcControles, false);
            cbxRechazado.Checked = false;
            txtObservaciones.Text = string.Empty;
            txtCodigoPostal.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtNumeroExterior.Text = string.Empty;
            txtNumeroInterior.Text = string.Empty;
            cbxSOS.Checked = false;
            //pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Proveedor"].ToString();
            txtNombre.Text = ren["D_Proveedor"].ToString();
            txtNombreCorto.Text = ren["C_Proveedor"].ToString();
            txtRFC.Text = ren["RFC"].ToString();
            cbxCredito.Checked = Convert.ToBoolean(ren["B_Otorga_Credito"]);
            ucTipoFiscal1.K_Tipo_Fiscal = Convert.ToInt16(ren["K_Tipo_Fiscal"]);
            ucTipoFiscal1.txt_TF_D_Tipo_Fiscal.Text = ren["D_Tipo_Fiscal"].ToString();
            txtDiasCredito.Text = ren["Dias_Credito"].ToString(); 
            txtLimiteCredito.Text = ren["Monto_Credito"].ToString();
            cbxRechazado.Checked = Convert.ToBoolean(ren["B_Rechazado"]);
            cbxAutorizado.Checked = Convert.ToBoolean(ren["B_Autorizado"]);
            txtObservaciones.Text = ren["Observaciones"].ToString();
            txtCodigoPostal.Text = ren["Codigo_Postal"].ToString();
            txtCalle.Text = ren["Calle"].ToString();
            txtNumeroExterior.Text = ren["Numero_Exterior"].ToString();
            txtNumeroInterior.Text = ren["Numero_Interior"].ToString();
            dtpAlta.Format = DateTimePickerFormat.Custom;
            dtpAlta.CustomFormat = "yyyy-MM-dd";
            dtpAlta.Value = Convert.ToDateTime(ren[14]);

            if(Convert.ToBoolean(ren["B_Activo"]) == false)
            {
                dtpBaja.Format = DateTimePickerFormat.Custom;
                dtpBaja.CustomFormat = "yyyy-MM-dd";
                dtpBaja.Value = Convert.ToDateTime(ren["F_Baja"]);
                dtpBaja.Visible = true;
                label3.Visible = true;
              
            }
            else
            {
                dtpBaja.Visible = false;
                label3.Visible = false;
            }
            cbxDevoluciones.Checked = Convert.ToBoolean(ren["B_Acepta_Devoluciones"]);
            //cbxActiva.Checked = Convert.ToBoolean(ren["B_Activo"]);
            geo_Colonia1.K_Pais = Convert.ToInt16(ren["K_Pais"]);
            geo_Colonia1.K_Estado = Convert.ToInt32(ren["K_Estado"]);
            geo_Colonia1.K_Ciudad = Convert.ToInt32(ren["K_Ciudad"]);
            geo_Colonia1.K_Colonia = Convert.ToInt32(ren["K_Colonia"]);
            geo_Colonia1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Colonia1.txt_G_Estado.Text = ren["D_Estado"].ToString();
            geo_Colonia1.txt_G_Ciudad.Text = ren["D_Ciudad"].ToString();
            geo_Colonia1.txt_G_Colonia.Text = ren["D_Colonia"].ToString();
            cbxSOS.Checked = ren["B_SOS"].ToString() !="" ?Convert.ToBoolean(ren["B_SOS"].ToString()) :false;

        }
        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtNombre.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCatalogos.Dl_Proveedores(Convert.ToInt32(CatalogoPropiedadId_Identity),ucTipoFiscal1.K_Tipo_Fiscal, ref msg);

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
            DateTime FechaAlta = DateTime.Today;
            FechaAlta = dtpAlta.Value;
            DateTime FechaBaja = DateTime.Today;
            FechaBaja = dtpBaja.Value;

            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            int CampoIdentity = 0;
            int CP = 0;
            String Numero_Interior = "";
            if (txtCP.Text.Trim().Length > 0)
                CP = Convert.ToInt32(txtCP.Text);
            if (txtCodigoPostal.Text.Trim().Length > 0)
                CP = Convert.ToInt32(txtCodigoPostal.Text);
            if (txtNumeroInterior.Text.Trim().Length > 0)
                Numero_Interior = txtNumeroInterior.Text.Trim();
        

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Proveedores(ref CampoIdentity,ucTipoFiscal1.K_Tipo_Fiscal,txtNombre.Text,txtNombreCorto.Text,
                    Convert.ToInt16(geo_Colonia1.K_Pais),txtRFC.Text,geo_Colonia1.K_Estado,geo_Colonia1.K_Ciudad,geo_Colonia1.K_Colonia,
                    txtCalle.Text.Trim(),txtNumeroExterior.Text,Numero_Interior, Convert.ToInt32(txtCodigoPostal.Text.Trim()),
                    FechaAlta,FechaBaja,cbxCredito.Checked,int.Parse(txtDiasCredito.Text),Convert.ToDecimal(txtLimiteCredito.Text),
                    cbxDevoluciones.Checked, cbxAutorizado.Checked, cbxRechazado.Checked, txtObservaciones.Text,cbxSOS.Checked, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Proveedores(
                    Convert.ToInt32(txtClave.Text.Trim()),
                    ucTipoFiscal1.K_Tipo_Fiscal, 
                    txtNombre.Text, 
                    txtNombreCorto.Text,
                    Convert.ToInt16(geo_Colonia1.K_Pais),
                    txtRFC.Text, geo_Colonia1.K_Estado,
                    geo_Colonia1.K_Ciudad, 
                    geo_Colonia1.K_Colonia,
                    txtCalle.Text.Trim(),
                    txtNumeroExterior.Text,
                    Numero_Interior,
                    txtCodigoPostal.Text.Trim().Length ==0 ? 0: Convert.ToInt32(txtCodigoPostal.Text.Trim()),
                    FechaAlta, 
                    FechaBaja, 
                    cbxCredito.Checked, 
                    int.Parse(txtDiasCredito.Text),
                    Convert.ToDecimal(txtLimiteCredito.Text),
                    cbxDevoluciones.Checked, 
                    cbxAutorizado.Checked, 
                    cbxRechazado.Checked, 
                    txtObservaciones.Text, cbxSOS.Checked, ref msg);
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
                CargaTablasParciales(7);
            }

        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (txtRFC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR R.F.C. ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return false;
            }
            if (ucTipoFiscal1.K_Tipo_Fiscal == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA TIPO FISCAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoFiscal1.txt_TF_D_Tipo_Fiscal.Focus();
                return false;
            }
            if (geo_Colonia1.K_Pais == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.txt_G_Pais.Focus();
                return false;
            }
            if (geo_Colonia1.K_Estado == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.txt_G_Estado.Focus();
                return false;
            }
            if (geo_Colonia1.K_Ciudad == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CIUDAD..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.txt_G_Ciudad.Focus();
                return false;
            }
            if (geo_Colonia1.K_Colonia == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA COLONIA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.txt_G_Colonia.Focus();
                return false;
            }
            if (txtDiasCredito.Text == "")
            {
                MessageBox.Show("DEBE INDICAR LOS DIAS DE CREDITO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiasCredito.Focus();
                return false;
            }
            if (txtLimiteCredito.Text == "")
            {
                MessageBox.Show("DEBE INDICAR EL LIMITE DE CREDITO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiasCredito.Focus();
                return false;
            }
            if (cbxRechazado.Checked)
            {
                 if (txtNombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EN OBSERVACIONES EL MOTIVO DE RECHAZO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtObservaciones.Focus();
                    return false;

                }

            }

            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoRecarga()
        {
            GlobalVar.dtPuestos = sqlCatalogos.Sk_Puesto();
            GlobalVar.dtOficinas = sqlCatalogos.Sk_Oficina();
            GlobalVar.dtDepartamentos = sqlCatalogos.Sk_Departamento();
            GlobalVar.dtUsuarios = sqlCatalogos.Sk_Empleado();
            GlobalVar.dtPaises = sqlCatalogos.Sk_Pais();
            GlobalVar.dtEstados = sqlCatalogos.Sk_Estado();

            base.BaseMetodoRecarga();
        }

        private void txtDiasCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtNumeroExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
           // fx.ValidaSeaNumero(ref e);
        }

       
    }
}
