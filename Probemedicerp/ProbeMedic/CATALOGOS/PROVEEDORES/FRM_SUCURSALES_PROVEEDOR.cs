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

namespace ProbeMedic.CATALOGOS.PROVEEDORES
{
    public partial class FRM_SUCURSALES_PROVEEDOR : FormaCatalogo
    {
        public int PropiedadK_Proveedor { get; set; }
        public string PropiedadD_Proveedor { get; set; }
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public FRM_SUCURSALES_PROVEEDOR()
        {
            InitializeComponent();
        }

        private void FRM_SUCURSALES_PROVEEDOR_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {
            BaseBotonBorrar.Visible = false;
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Sucursales_Proveedor(PropiedadK_Proveedor);
            CatalogoPropiedadCampoClave = "K_Sucursal_Proveedor";
            CatalogoPropiedadCampoDescripcion = "D_Sucursal_Proveedor";

            lblProveedor.Text = PropiedadD_Proveedor;

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Sucursal_Proveedor"].ToString();
            txtDescripcion.Text = ren["D_Sucursal_Proveedor"].ToString();
          
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            int CampoIdentity = 0;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sql_Catalogos.In_Sucursales_Proveedor(ref CampoIdentity, PropiedadK_Proveedor,txtDescripcion.Text.Trim(),GlobalVar.K_Usuario, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Sucursales_Proveedor(CampoIdentity,PropiedadK_Proveedor, txtDescripcion.Text,GlobalVar.K_Usuario, ref msg);
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

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA SUCURSAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
           
            BaseErrorResultado = false;
            return true;
        }
    }
}
