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

namespace ProbeMedic.CATALOGOS
{

    public partial class FRM_CUENTANIVEL4 : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();

        public FRM_CUENTANIVEL4()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Cuenta_Nivel4();
            CatalogoPropiedadCampoClave = "K_Departamento";
            CatalogoPropiedadCampoDescripcion = "D_Departamento";
            BaseBotonNuevo.Enabled = true;

            base.BaseMetodoInicio();

            BaseBotonBorrar.Visible = false;
        }
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;


            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Cuenta_Nivel4(uc_CuentaNivel3.K_Cuenta_Mayor, uc_CuentaNivel3.K_Cuenta, uc_CuentaNivel3.K_SubCuenta, ucDepartamentos1.K_Departamento, txtCuenta.Text, ref msg);

            }
            else //Existe. Update
            {
                res = sqlCatalogos.Up_Cuenta_Nivel4(uc_CuentaNivel3.K_Cuenta_Mayor, uc_CuentaNivel3.K_Cuenta, uc_CuentaNivel3.K_SubCuenta, ucDepartamentos1.K_Departamento, txtCuenta.Text, ref msg);
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
            }

        }


        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            this.txtCuenta.Text = string.Empty;
            uc_CuentaNivel3.K_Cuenta_Mayor = 0;
            uc_CuentaNivel3.K_Cuenta = 0;
            uc_CuentaNivel3.K_SubCuenta = 0;
            ucDepartamentos1.K_Departamento = 0;
            uc_CuentaNivel3.txt_G_Cuenta.Text = "";
            uc_CuentaNivel3.txt_G_Cuenta_Mayor.Text = "";
            uc_CuentaNivel3.txt_G_Subcuenta.Text = "";
            ucDepartamentos1.txt_E_Departamento.Text = "";
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            this.uc_CuentaNivel3.K_Cuenta_Mayor = Convert.ToInt32(ren["K_Cuenta_Mayor"].ToString());
            this.uc_CuentaNivel3.txt_G_Cuenta_Mayor.Text = ren["D_Cuenta_Mayor"].ToString();
            this.uc_CuentaNivel3.K_Cuenta = Convert.ToInt32(ren["K_Cuenta"].ToString());
            this.uc_CuentaNivel3.txt_G_Cuenta.Text = ren["D_Cuenta"].ToString();
            this.uc_CuentaNivel3.K_SubCuenta = Convert.ToInt32(ren["K_Subcuenta"].ToString());
            this.uc_CuentaNivel3.txt_G_Subcuenta.Text = ren["D_Subcuenta"].ToString();
            this.ucDepartamentos1.K_Departamento = Convert.ToInt32(ren["K_Departamento"].ToString());
            this.ucDepartamentos1.txt_E_Departamento.Text = ren["D_Departamento"].ToString();
            this.txtCuenta.Text = ren["Cuenta"].ToString();

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.uc_CuentaNivel3.txt_G_Cuenta_Mayor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA MAYOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uc_CuentaNivel3.Focus();
                return false;
            }
            if (this.uc_CuentaNivel3.txt_G_Cuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uc_CuentaNivel3.Focus();
                return false;
            }
            if (this.uc_CuentaNivel3.txt_G_Subcuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA SUBCUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uc_CuentaNivel3.Focus();
                return false;
            }
            if (this.ucDepartamentos1.txt_E_Departamento.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL DEPARTAMENTO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucDepartamentos1.Focus();
                return false;
            }
            if (this.txtCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
    }
}
