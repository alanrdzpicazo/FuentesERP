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
    public partial class FRM_CUENTANIVEL5 : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();

        public FRM_CUENTANIVEL5()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Cuenta_Nivel5();
            CatalogoPropiedadCampoClave = "K_Almacen";
            CatalogoPropiedadCampoDescripcion = "D_Almacen";
            BaseBotonNuevo.Enabled = true;

            DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes();
            if (dtAlmacen != null)
            {
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", 0);
            }

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
                res = sqlCatalogos.In_Cuenta_Nivel5(ucCuentaNivel41.K_Cuenta_Mayor, ucCuentaNivel41.K_Cuenta, ucCuentaNivel41.K_SubCuenta, ucCuentaNivel41.K_Departamento, Convert.ToInt32(cbxAlmacen.SelectedValue), ref msg);

            }
            else //Existe. Update
            {
                res = sqlCatalogos.Up_Cuenta_Nivel5(ucCuentaNivel41.K_Cuenta_Mayor, ucCuentaNivel41.K_Cuenta, ucCuentaNivel41.K_SubCuenta, ucCuentaNivel41.K_Departamento, Convert.ToInt32(cbxAlmacen.SelectedValue), ref msg);
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
            ucCuentaNivel41.K_Cuenta_Mayor = 0;
            ucCuentaNivel41.K_Cuenta = 0;
            ucCuentaNivel41.K_SubCuenta = 0;
            ucCuentaNivel41.K_Departamento = 0;
            ucCuentaNivel41.txt_G_Cuenta.Text = "";
            ucCuentaNivel41.txt_G_Cuenta_Mayor.Text = "";
            ucCuentaNivel41.txt_G_Subcuenta.Text = "";
            ucCuentaNivel41.txt_G_Departamento.Text = "";
            cbxAlmacen.SelectedIndex = -1;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            ucCuentaNivel41.K_Cuenta_Mayor = Convert.ToInt32(ren["K_Cuenta_Mayor"].ToString());
            ucCuentaNivel41.txt_G_Cuenta_Mayor.Text = ren["D_Cuenta_Mayor"].ToString();
            ucCuentaNivel41.K_Cuenta = Convert.ToInt32(ren["K_Cuenta"].ToString());
            ucCuentaNivel41.txt_G_Cuenta.Text = ren["D_Cuenta"].ToString();
            ucCuentaNivel41.K_SubCuenta = Convert.ToInt32(ren["K_Subcuenta"].ToString());
            ucCuentaNivel41.txt_G_Subcuenta.Text = ren["D_Subcuenta"].ToString();
            ucCuentaNivel41.K_Departamento = Convert.ToInt32(ren["K_Departamento"].ToString());
            ucCuentaNivel41.txt_G_Departamento.Text = ren["D_Departamento"].ToString();
            cbxAlmacen.SelectedValue = Convert.ToInt32(ren["K_Almacen"].ToString());
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.ucCuentaNivel41.txt_G_Cuenta_Mayor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA MAYOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCuentaNivel41.Focus();
                return false;
            }
            if (this.ucCuentaNivel41.txt_G_Cuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCuentaNivel41.Focus();
                return false;
            }
            if (this.ucCuentaNivel41.txt_G_Subcuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA SUBCUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCuentaNivel41.Focus();
                return false;
            }
            if (this.ucCuentaNivel41.txt_G_Departamento.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL DEPARTAMENTO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCuentaNivel41.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
    }
}
