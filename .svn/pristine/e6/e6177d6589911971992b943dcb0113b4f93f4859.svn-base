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
    public partial class FRM_PARAMETROS_GENERALES : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;

        SQLCatalogos CatalogoSQL = new SQLCatalogos();
        Funciones fx = new Funciones();
       
        public FRM_PARAMETROS_GENERALES()
        {
            InitializeComponent();
            txtPorcentajeMargenGanancia.Moneda.TextChanged += new EventHandler(txtPorcentajeMargenGanancia_TextChanged);
        }
        private void txtPorcentajeMargenGanancia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPorcentajeMargenGanancia.Moneda.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(txtPorcentajeMargenGanancia.Moneda.Text.Trim()) > 100)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPorcentajeMargenGanancia.Moneda.Text = "0.00";
                    }
                }

            }
            catch
            {

                return;
            }

        }
        private void FRM_PARAMETROS_GENERALES_Load(object sender, EventArgs e)
        {

        }

        public override void BaseMetodoInicio()
        {          
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonGuardar.Enabled = true;
            CatalogoTxtFiltro.Visible = false;
            txtFocus = txtMonMaxCom.Contenido; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            BaseDtDatos = CatalogosSQL.Sk_Parametros_Generales();
            CatalogoPropiedadCampoClave = "K_Parametros_Generales";
            CatalogoPropiedadCampoDescripcion = "Descripcion";

            if(BaseDtDatos != null)
            {
                BaseBotonNuevo.Visible = false;
            }
            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtMonMaxCom.Contenido.Text = string.Empty;
            txtMontoMaxDif.Contenido.Text = string.Empty;
            txtMontoAutReqN1.Contenido.Text = string.Empty;
            txtMontoAutReqN2.Contenido.Text = string.Empty;
            txtMontoTercerPiso.Contenido.Text = string.Empty;
            txtMontoDescEmpleado.Contenido.Text = string.Empty;
            txtPorcentaje_Monedero.Contenido.Text = string.Empty;
            txtPorcentajeMargenGanancia.Moneda.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Parametros_Generales"].ToString();
            txtMonMaxCom.Contenido.Text = Convert.ToDecimal(ren["Monto_Maximo_OCompra"].ToString()).ToString("N2");
            txtMontoMaxDif.Contenido.Text = Convert.ToDecimal(ren["Monto_Maximo_Dif_OCompra"].ToString()).ToString("N2");
            txtMontoAutReqN1.Contenido.Text =Convert.ToDecimal(ren["Monto_Autoriza_Req_Nivel1"].ToString()).ToString("N2");
            txtMontoAutReqN2.Contenido.Text = Convert.ToDecimal(ren["Monto_Autoriza_Req_Nivel2"].ToString()).ToString("N2");
            txtMontoTercerPiso.Contenido.Text = Convert.ToDecimal(ren["Monto_TercerPiso"].ToString()).ToString("N2");
            txtMontoDescEmpleado.Contenido.Text = Convert.ToDecimal(ren["Monto_Descuento_Empleado"].ToString()).ToString("N2");
            txtPorcentaje_Monedero.Contenido.Text =Convert.ToDecimal(ren["Porcentaje_Monedero"].ToString()).ToString("N2");
            txtPorcentajeMargenGanancia.Moneda.Text =ren["Porcentaje_Margen_Ganancia"].ToString();
            txtPorcentajeMargenGanancia.Formato(txtPorcentajeMargenGanancia.Moneda.Text);
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
                res = CatalogosSQL.In_Parametros_Generales(ref CampoIdentity,Convert.ToDecimal(txtMonMaxCom.Contenido.Text),Convert.ToDecimal(txtMontoMaxDif.Contenido.Text),Convert.ToDecimal(txtMontoAutReqN1.Contenido.Text),
                                                           Convert.ToDecimal(txtMontoAutReqN2.Contenido.Text),Convert.ToDecimal(txtMontoTercerPiso.Contenido.Text), Convert.ToDecimal(txtMontoDescEmpleado.Contenido.Text),
                                                           GlobalVar.K_Usuario, Convert.ToDecimal(txtPorcentaje_Monedero.Contenido.Text), Convert.ToDecimal(txtPorcentajeMargenGanancia.Moneda.Text), ref msg);
            }

            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Parametros_Generales(CampoIdentity,Convert.ToDecimal(txtMonMaxCom.Contenido.Text),Convert.ToDecimal(txtMontoMaxDif.Contenido.Text),Convert.ToDecimal(txtMontoAutReqN1.Contenido.Text),
                                  Convert.ToDecimal(txtMontoAutReqN2.Contenido.Text),Convert.ToDecimal(txtMontoTercerPiso.Contenido.Text), Convert.ToDecimal(txtMontoDescEmpleado.Contenido.Text),GlobalVar.K_Usuario,
                                  Convert.ToDecimal(txtPorcentaje_Monedero.Contenido.Text), Convert.ToDecimal(txtPorcentajeMargenGanancia.Moneda.Text), ref msg);
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

          
            if (txtMonMaxCom.Contenido.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR MONTO MAXIMO COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonMaxCom.Focus();
                return false;
            }
            if (txtMontoMaxDif.Contenido.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR MONTO MAXIMO DIFERENCIA COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontoMaxDif.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

    }
}
