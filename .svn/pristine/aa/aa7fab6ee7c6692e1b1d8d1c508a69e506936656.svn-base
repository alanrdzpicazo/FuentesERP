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
using ProbeMedic.Controles;

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_EMPLEADOS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        int K_Oficina = 0;
        short K_Puesto = 0;
        short K_Departamento = 0;
        int K_Usuario = 0;
        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public FRM_EMPLEADOS()
        {
            InitializeComponent();
            
            this.ucEmpresas1.PropertyChanged += new PropertyChangedEventHandler(ucEmpresas1_PropertyChanged);
        }
    
        private void ucEmpresas1_PropertyChanged(object sender, EventArgs e)
        {
            if (ucEmpresas1.K_Empresa > 0)
            {
                ucOficinas.K_Oficina = 0;
                ucOficinas.txt_E_Oficina.Text = string.Empty;
                ucOficinas.K_Empresa = ucEmpresas1.K_Empresa;
            }
            else
            {
                if (ucEmpresas1.K_Empresa == 0)
                {
                    ucOficinas.K_Oficina = 0;
                    ucOficinas.txt_E_Oficina.Text = string.Empty;
                    ucOficinas.K_Empresa = 0;
                }
            }
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            DeshabilitaPages(ref tcControles, false);
            //cbxActiva.Enabled = false;

            BaseDtDatos = sqlCatalogos.Sk_Empleado();
            CatalogoPropiedadCampoClave = "K_Empleado";
            CatalogoPropiedadCampoDescripcion = "D_Empleado";

            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            DeshabilitaPages(ref tcControles, B_Habilita);
        }
        public override void BaseMetodoLimpiaControles()
        {
            K_Oficina = 0;
            K_Puesto = 0;
            K_Departamento = 0;
            K_Usuario = 0;

            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtRFC.Text = string.Empty;

            ucOficinas.txt_E_Oficina.Text = string.Empty;
            ucOficinas.K_Oficina = 0;
            ucPuestos1.txt_E_Puesto.Text = string.Empty;
            ucPuestos1.K_Puesto = 0;
            ucDepartamentos1.txt_E_Departamento.Text = string.Empty;
            ucDepartamentos1.K_Departamento = 0;
            ucEmpresas1.txt_G_Empresa.Text = string.Empty;
            ucEmpresas1.K_Empresa = 0;
            geo_Ciudad1.txt_G_Pais.Text = string.Empty;
            geo_Ciudad1.K_Pais= 0;
            geo_Ciudad1.txt_G_Estado.Text = string.Empty;
            geo_Ciudad1.K_Estado = 0;
            geo_Ciudad1.txt_G_Ciudad.Text = string.Empty;
            geo_Ciudad1.K_Ciudad = 0;
            txtNoNomina.Text = string.Empty;
            txtNoSeguroSocial.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            DeshabilitaPages(ref tcControles, false);
            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Empleado"].ToString();
            txtDescripcion.Text = ren["D_Empleado"].ToString();

            ucOficinas.K_Oficina = Convert.ToInt32(ren["K_Oficina"]);
            ucPuestos1.K_Puesto = Convert.ToInt16(ren["K_Puesto"]);
            ucDepartamentos1.K_Departamento = Convert.ToInt16(ren["K_Departamento"]);
            ucEmpresas1.K_Empresa = Convert.ToInt32(ren["K_Empresa"]);

            ucOficinas.txt_E_Oficina.Text = ren["D_Oficina"].ToString();
            ucPuestos1.txt_E_Puesto.Text = ren["D_Puesto"].ToString();
            ucDepartamentos1.txt_E_Departamento.Text = ren["D_Departamento"].ToString();
            ucEmpresas1.txt_G_Empresa.Text = ren["D_Empresa"].ToString();


            if (ren["K_Usuario"].ToString().Trim().Length > 0)
                K_Usuario = Convert.ToInt32(ren["K_Usuario"]);
            else
                K_Usuario = 0;
            txtRFC.Text = ren["RFC"].ToString();
            geo_Ciudad1.K_Pais = Convert.ToInt32(ren["K_Pais"]);
            geo_Ciudad1.K_Estado = Convert.ToInt32(ren["K_Estado"]);
            geo_Ciudad1.K_Ciudad = Convert.ToInt32(ren["K_Ciudad"]);
            geo_Ciudad1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Ciudad1.txt_G_Estado.Text = ren["D_Estado"].ToString();
            geo_Ciudad1.txt_G_Ciudad.Text = ren["D_Ciudad"].ToString();

            txtColonia.Text = ren["Colonia"].ToString();
            txtCalle.Text = ren["Calle"].ToString();
            txtCP.Text = ren["Codigo_Postal"].ToString();

            txtTelefono.Text = ren["Telefono"].ToString();

            txtNoNomina.Text = ren["Numero_Nomina"].ToString();
            txtNoSeguroSocial.Text = ren["Numero_SeguroSocial"].ToString();
            DeshabilitaPages(ref tcControles, false);
            pnlControles.Enabled = true;
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
                res = sqlCatalogos.Dl_empleado(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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
            int CampoIdentity = 0;
            int CP = 0;
            if (txtCP.Text.Trim().Length > 0)
                CP = Convert.ToInt32(txtCP.Text);

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Empleado(ref CampoIdentity, txtDescripcion.Text, txtRFC.Text, ucOficinas.K_Oficina, Convert.ToInt16(ucPuestos1.K_Puesto), Convert.ToInt16(ucDepartamentos1.K_Departamento), Convert.ToInt16(geo_Ciudad1.K_Pais), Convert.ToInt32(geo_Ciudad1.K_Estado), Convert.ToInt32(geo_Ciudad1.K_Ciudad), txtColonia.Text, txtCalle.Text, CP, txtTelefono.Text, txtNoNomina.Text, txtNoSeguroSocial.Text, K_Usuario, ucEmpresas1.K_Empresa, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Empleado(CampoIdentity, txtDescripcion.Text, txtRFC.Text, ucOficinas.K_Oficina, Convert.ToInt16(ucPuestos1.K_Puesto), Convert.ToInt16(ucDepartamentos1.K_Departamento), Convert.ToInt16(geo_Ciudad1.K_Pais), Convert.ToInt32(geo_Ciudad1.K_Estado), Convert.ToInt32(geo_Ciudad1.K_Ciudad), txtColonia.Text, txtCalle.Text, CP, txtTelefono.Text, txtNoNomina.Text, txtNoSeguroSocial.Text, K_Usuario, ucEmpresas1.K_Empresa, ref msg);
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

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtRFC.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR R.F.C. ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return false;
            }
            if (ucEmpresas1.K_Empresa == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA EMPRESA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                ucEmpresas1.txt_G_Empresa.Focus();
                return false;
            }
            if (ucOficinas.K_Oficina == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ucPuestos1.K_Puesto == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PUESTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPuestos1.txt_E_Puesto.Focus();
                return false;
            }
            if (ucDepartamentos1.K_Departamento == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN DEPARTAMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDepartamento.Focus();
                return false;
            }

            if (geo_Ciudad1.K_Pais == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Ciudad1.txt_G_Pais.Focus();
                return false;
            }
            if (geo_Ciudad1.K_Estado == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Ciudad1.txt_G_Estado.Focus();
                return false;
            }
            if (geo_Ciudad1.K_Ciudad == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Ciudad1.txt_G_Ciudad.Focus();
                return false;
            }
            if (txtColonia.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectedTab = tpDomicilio;
                txtColonia.Focus();
                return false;
            }
            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectedTab = tpDomicilio;
                txtCalle.Focus();
                return false;
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

        private void ucOficinas_Load(object sender, EventArgs e)
        {

        }

        private void txtNoNomina_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoSeguroSocial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
